using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.UI;
using Emgu.CV.CvEnum;
using Emgu.CV.Util;

using Emgu.Util;

namespace EmguCV
{
    public partial class Form1 : Form
    {
        Image<Bgr, byte> img;
        bool check = false;
        IColorSkinDetector skinDetector;

        Image<Bgr, Byte> currentFrame; // img lay ra tu webcam
        Image<Bgr, Byte> currentFrameCopy; // clone de chuyen sang binary

        Image<Bgr, Byte> paper; // giay ve
        Image<Bgr, Byte> drawpaper;

        Capture capture;
        bool captureInProgress;
        //AdaptiveSkinDetector detector;

        int frameWidth;
        int frameHeight;

        Hsv hsv_min;
        Hsv hsv_max;
        Ycc YCrCb_min; // range ycbcr
        Ycc YCrCb_max;

        Double Result = 0; // area lon nhat
        Mat defect = new Mat(); // 2 matrix chua defect 
        Matrix<int> mDefect;


        Point[] points; // mang chua cua diem tao thanh vien ngoai`
        Point[] drawpoints = new Point[2];

        Rectangle handRect;
        RotatedRect box;  // Rect bao ngoai`cung


        // test Undo_Redo
        int limit = 5;
        private Stack<Image<Bgr, byte>> stackUndo = new Stack<Image<Bgr, Byte>>();
        private Stack<Image<Bgr, byte>> stackRedo = new Stack<Image<Bgr, byte>>();
        public Form1()
        {
            InitializeComponent();
            //Y


            trackBar4.Maximum = 255;
            trackBar4.Minimum = 0;
            trackBar1.Maximum = 255;
            trackBar1.Minimum = 0;

            //Cb
            trackBar2.Maximum = 255;
            trackBar2.Minimum = 0;
            trackBar5.Maximum = 255;
            trackBar5.Minimum = 0;
            //Cr    
            trackBar3.Maximum = 255;
            trackBar3.Minimum = 0;
            trackBar6.Maximum = 255;
            trackBar6.Minimum = 0;


            //detector = new AdaptiveSkinDetector(1, AdaptiveSkinDetector.MorphingMethod.NONE);
            hsv_min = new Hsv(0, 45, 0);
            hsv_max = new Hsv(20, 255, 255);
            YCrCb_min = new Ycc(80, 133, 80);
            YCrCb_max = new Ycc(255, 173, 158);
            box = new RotatedRect();

            DrawBox.MouseClick += new MouseEventHandler(Form1_MouseClick);
        }

        public void ProcessFrame(object sender, EventArgs args) // lay frame
        {
            Image<Bgr, byte> CamImg = capture.QueryFrame().ToImage<Bgr, byte>();

            WebcamBox.Image = CamImg.Flip(FlipType.Horizontal); // frame goc tu webcam
            int widthROI = CamImg.Size.Width / 4;
            int heightROI = CamImg.Size.Height / 4;
            currentFrame = CamImg.Copy(new Rectangle(widthROI, heightROI, widthROI * 2, heightROI * 2)); // frame de chinh sua
            if (currentFrame != null)
            {

                currentFrameCopy = currentFrame.Copy();
                //CvInvoke.GaussianBlur(currentFrameCopy, currentFrameCopy, new Size(3,3), 3);
                skinDetector = new YCrCbSkinDetector();

                Image<Gray, Byte> skin = skinDetector.DetectSkin(currentFrameCopy, YCrCb_min, YCrCb_max);
                // skin : anh binary dc loc ra
                skin.SmoothGaussian(9);
                Image<Gray, byte> skinCopy = skin.Copy().Flip(FlipType.Horizontal);
                SkinBox.Image = skinCopy;
                if (check == true)
                {

                    ExtractContourAndHull(skin);
                    // if(9500 < Result && Result < 25000)
                    DrawAndComputeFingersNum();
                }

                outputBox.Image = currentFrame.Copy().Flip(FlipType.Horizontal);

                DrawBox.Image = paper;

                if (RedoIsEmpty() == true)
                {
                    button3.Hide();
                }
                else
                    button3.Show();
            }
        }
        private void ExtractContourAndHull(Image<Gray, byte> skin) // kiem vien va lop ngoai 
        {
            using (MemStorage storage = new MemStorage())
            {
                VectorOfVectorOfPoint contours = new VectorOfVectorOfPoint();


                CvInvoke.FindContours(skin, contours, new Mat(), Emgu.CV.CvEnum.RetrType.External, Emgu.CV.CvEnum.ChainApproxMethod.ChainApproxSimple);




                VectorOfPoint biggestContour = new VectorOfPoint();// mang point[] chua vien` lon nhat
                Double Result1 = 0; // area dang xet
                Result = 0;

                for (int i = 0; i < contours.Size; i++)
                {
                    VectorOfPoint contour = contours[i]; // chuyen sang Point[][]
                    double area = CvInvoke.ContourArea(contour, false);// tinh area
                    Result1 = area;
                    if (Result1 > Result)
                    {
                        Result = Result1;
                        biggestContour = contour;
                    }
                }
                label8.Text = "Size Rect :" + Result.ToString();
                if (biggestContour != null)
                {
                    CvInvoke.ApproxPolyDP(biggestContour, biggestContour, 0.00025, false);

                    points = biggestContour.ToArray();

                    currentFrame.Draw(points, new Bgr(255, 0, 255), 4);


                    VectorOfPoint hull = new VectorOfPoint();
                    VectorOfInt convexHull = new VectorOfInt();
                    CvInvoke.ConvexHull(biggestContour, hull, false); //~ Hull
                    box = CvInvoke.MinAreaRect(hull);


                    currentFrame.Draw(new CircleF(box.Center, 5), new Bgr(Color.Black), 4);

                    CvInvoke.ConvexHull(biggestContour, convexHull);

                    //PointF[] Vertices = box.GetVertices();
                    // handRect = box.MinAreaRect();
                    currentFrame.Draw(box, new Bgr(200, 0, 0), 1);


                    // ve khung ban tay khung bao quanh tay
                    currentFrame.DrawPolyline(hull.ToArray(), true, new Bgr(200, 125, 75), 4);
                    currentFrame.Draw(new CircleF(new PointF(box.Center.X, box.Center.Y), 3), new Bgr(200, 125, 75));

                    // tim  convex defect

                    CvInvoke.ConvexityDefects(biggestContour, convexHull, defect);

                    // chuyen sang Matrix 
                    if (!defect.IsEmpty)
                    {
                        mDefect = new Matrix<int>(defect.Rows, defect.Cols, defect.NumberOfChannels);
                        defect.CopyTo(mDefect);
                    }

                }
            }
        }
        double getAngle(PointF s, PointF f, PointF e)
        {
            double l1 = Math.Sqrt(Math.Pow(f.X - s.X, 2) + Math.Pow(f.Y - s.Y, 2));
            double l2 = Math.Sqrt(Math.Pow(f.X - e.X, 2) + Math.Pow(f.Y - e.Y, 2));
            float dot = (s.X - f.X) * (e.X - f.X) + (s.Y - f.Y) * (e.Y - f.Y);
            double angle = Math.Acos(dot / (l1 * l2));
            angle = angle * 180 / Math.PI;
            return angle;
        }
        private void DrawAndComputeFingersNum()
        {
            int fingerNum = 0;

            #region defects drawing
            PointF[] start = new PointF[mDefect.Rows];
            int num = 0;
            start[0] = new PointF(0, 0);

            for (int i = 0; i < mDefect.Rows; i++)
            {
                int startIdx = mDefect.Data[i, 0];
                int depthIdx = mDefect.Data[i, 1];
                int endIdx = mDefect.Data[i, 2];


                Point startPoint = points[startIdx];
                Point endPoint = points[endIdx];

                Point depthPoint = points[depthIdx];


                LineSegment2D Line = new LineSegment2D(startPoint, new Point((int)box.Center.X, (int)box.Center.Y));

                CircleF startCircle = new CircleF(startPoint, 5f);
                CircleF endCircle = new CircleF(endPoint, 5f);
                CircleF depthCircle = new CircleF(depthPoint, 5f);


                //  currentFrame.Draw(startCircle, new Bgr(Color.Red), 2);
                //currentFrame.Draw(endCircle, new Bgr(Color.Yellow), 2);
                // currentFrame.Draw(depthCircle, new Bgr(Color.White), 2);


                if ((startPoint.Y < box.Center.Y && endPoint.Y < box.Center.Y) && (startPoint.Y < endPoint.Y) &&
                    (Math.Sqrt(Math.Pow(startPoint.X - endPoint.X, 2) + Math.Pow(startPoint.Y - endPoint.Y, 2)) > box.Size.Height / 6.5))
                {
                    if (getAngle(startPoint, box.Center, start[num]) > 10)
                    {
                        fingerNum++;
                        start[num] = startPoint;
                        num++;

                        currentFrame.Draw(Line, new Bgr(Color.Violet), 2);
                        currentFrame.Draw(startCircle, new Bgr(Color.OrangeRed), 5);
                        currentFrame.Draw(endCircle, new Bgr(Color.Black), 5);

                        currentFrame.Draw(fingerNum.ToString(), new Point(startPoint.X - 10, startPoint.Y), FontFace.HersheyPlain, 2, new Bgr(Color.Orange), 3);
                        currentFrame.Draw(fingerNum.ToString(), new Point(endPoint.X - 10, endPoint.Y), FontFace.HersheyPlain, 2, new Bgr(Color.Orange), 3);

                        if (drawpoints[0] == null)
                        {
                            drawpoints[0] = new Point(DrawBox.Width - startPoint.X, startPoint.Y);
                        }
                        else
                        {

                            drawpoints[1] = new Point(DrawBox.Width - startPoint.X, startPoint.Y);
                            LineSegment2D drawline = new LineSegment2D(drawpoints[0], drawpoints[1]);
                            paper.Draw(drawline, new Bgr(Color.Red), 4);
                            drawpoints[0] = drawpoints[1];
                        }
                    }
                }


                label7.Text = "Number of Fingers : " + fingerNum.ToString();

            }


            #endregion

        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (drawpoints[0] == null)
            {
                drawpoints[0] = new Point(e.X, e.Y);
            }
            else
            {

                drawpoints[1] = new Point(e.X, e.Y);
                LineSegment2D drawline = new LineSegment2D(drawpoints[0], drawpoints[1]);
                paper.Draw(drawline, new Bgr(Color.Red), 4);
                drawpoints[0] = drawpoints[1];
            }
            DrawBox.Image = paper;
            UpdateStack();
        }


        private void StartButton_Click(object sender, EventArgs e)
        {
            #region
            if (capture == null)
            {
                try
                {
                    capture = new Capture();// "C:\\Users\\User\\Documents\\Visual Studio 2015\\Projects\\EmguCV\\EmguCV\\bin\\Debug\\5.png");
                                            //img = capture.QueryFrame().ToImage<Bgr, byte>();

                    capture.SetCaptureProperty(Emgu.CV.CvEnum.CapProp.Fps, 5);

                }
                catch (NullReferenceException excpt)
                {
                    MessageBox.Show(excpt.Message);
                }
            }
            #endregion

            if (capture != null)
            {
                if (captureInProgress)
                {
                    StartButton.Text = "Pause";
                    Application.Idle += ProcessFrame;
                }
                else
                {
                    StartButton.Text = "Start";
                    Application.Idle -= ProcessFrame;
                }
                captureInProgress = !captureInProgress;

            }

        }
        private void ReleaseData()
        {
            if (capture != null)
                capture.Dispose();
        }

        private void trackBar4_Scroll(object sender, EventArgs e)
        {
            label1.Text = trackBar4.Value.ToString();
            YCrCb_min.Y = trackBar4.Value;
        }

        private void trackBar5_Scroll(object sender, EventArgs e)
        {
            label3.Text = trackBar5.Value.ToString();
            YCrCb_min.Cb = trackBar5.Value;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label2.Text = trackBar1.Value.ToString();
            YCrCb_max.Y = trackBar1.Value;
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            label4.Text = trackBar2.Value.ToString();
            YCrCb_max.Cb = trackBar2.Value;
        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            label6.Text = trackBar3.Value.ToString();
            YCrCb_max.Cr = trackBar3.Value;
        }

        private void trackBar6_Scroll(object sender, EventArgs e)
        {
            label5.Text = trackBar6.Value.ToString();
            YCrCb_min.Cr = trackBar6.Value;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            check = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void SkinBox_Click(object sender, EventArgs e)
        {

        }

        private void DrawBox_Click(object sender, EventArgs e)
        {


        }

        private void newButton_Click(object sender, EventArgs e)
        {
            paper = new Image<Bgr, byte>(@"C:\Users\User\Documents\Visual Studio 2015\Projects\EmguCV\EmguCV\bin\Debug\blank.png");

        }

        public void UpdateStack()
        {
            if (stackUndo.Count == limit)
            {
                // xoa phan tu duoi cung trong stack
                stackUndo.Reverse();
                stackUndo.Pop();
                stackUndo.Reverse();
            }
            stackUndo.Push(paper);
            stackRedo.Clear();
        }

        public void Undo()
        {
            stackRedo.Push(paper);
            paper = stackUndo.Pop();
            DrawBox.Image = paper;
        }
        public void Redo()
        {
            stackUndo.Push(paper);
            paper = stackRedo.Pop();
            DrawBox.Image = paper;
        }
        public bool UndoIsEmpty()
        {
            if (stackUndo.Count == 0)
                return true;
            return false;
        }

        public bool RedoIsEmpty()
        {
            if (stackRedo.Count == 0)
                return true;
            return false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Undo();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Redo();
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Name = "Form1";
            this.ResumeLayout(false);

        }
    }
}
