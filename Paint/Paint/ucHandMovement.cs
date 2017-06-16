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
namespace Paint
{
    public partial class ucHandMovement : MetroFramework.Controls.MetroUserControl
    {
        Capture capture;
        Image<Bgr, byte> currentFrame;
        bool captureInProgress;
        public ucHandMovement()
        {
            if (!this.DesignMode)
            {
                this.InitializeComponent();
               

               
            }
        }

        void ProcessFramAndUpdateGUI(object Sender, EventArgs agr)
        {
            int Finger_num = 0;
            Double Result1 = 0;
            Double Result2 = 0;
            //querying image
            currentFrame = capture.QueryFrame().ToImage<Bgr, byte>();
            if (currentFrame == null) return;



            //Applying YCrCb filter
            Image<Ycc, Byte> currentYCrCbFrame = currentFrame.Convert<Ycc, byte>();
            Image<Gray, byte> skin = new Image<Gray, byte>(currentFrame.Width, currentFrame.Height);

            skin = currentYCrCbFrame.InRange(new Ycc(0, 131, 80), new Ycc(255, 185, 135));

            //Erode
            Mat rect_12 = CvInvoke.GetStructuringElement(ElementShape.Rectangle, new Size(10, 10), new Point(5, 5));
            CvInvoke.Erode(skin, skin, rect_12, new Point(-1, -1), 1, BorderType.Default, new MCvScalar());

            //Dilate
            Mat rect_6 = CvInvoke.GetStructuringElement(ElementShape.Rectangle, new Size(6, 6), new Point(3, 3));
            CvInvoke.Dilate(skin, skin, rect_6, new Point(-1, -1), 1, BorderType.Default, new MCvScalar());


            skin = skin.Flip(FlipType.Horizontal);

            //smoothing the filterd , eroded and dilated image.
            skin = skin.SmoothGaussian(9);

            currentFrame = currentFrame.Flip(FlipType.Horizontal);

            #region Extract contours and hull
            VectorOfVectorOfPoint contours = new VectorOfVectorOfPoint();
            CvInvoke.FindContours(skin, contours, new Mat(), Emgu.CV.CvEnum.RetrType.External,
                                          Emgu.CV.CvEnum.ChainApproxMethod.ChainApproxSimple);

            VectorOfPoint biggestContour = new VectorOfPoint();// mang point[] chua vien` lon nhat

            //Tim area contours lon nhat
            for (int i = 0; i < contours.Size; i++)
            {
                VectorOfPoint contour = contours[i]; // chuyen sang Point[][]
                Result1 = CvInvoke.ContourArea(contour, false);// tinh area
            
                if (Result1 > Result2)
                {
                    Result2 = Result1;
                    biggestContour = contour;
                }
            }

            //Gi do
            if (biggestContour != null)
            {
                Point[] contourPoints;
                CvInvoke.ApproxPolyDP(biggestContour, biggestContour, 0.00025, false);

                contourPoints = biggestContour.ToArray();

                currentFrame.Draw(contourPoints, new Bgr(255, 0, 255), 4);


                VectorOfPoint hull = new VectorOfPoint();
                VectorOfInt convexHull = new VectorOfInt();
                CvInvoke.ConvexHull(biggestContour, hull, true); //~ Hull   //Chinh clockwise thanh true          
                RotatedRect minAreaBox = CvInvoke.MinAreaRect(hull);
                

                currentFrame.Draw(new CircleF(minAreaBox.Center, 5), new Bgr(Color.Black), 4);

                CvInvoke.ConvexHull(biggestContour, convexHull);

                //PointF[] Vertices = box.GetVertices();
                // handRect = box.MinAreaRect();
                currentFrame.Draw(minAreaBox, new Bgr(200, 0, 0), 1);


                // ve khung ban tay khung bao quanh tay
                currentFrame.DrawPolyline(hull.ToArray(), true, new Bgr(200, 125, 75), 4);
                currentFrame.Draw(new CircleF(new PointF(minAreaBox.Center.X, minAreaBox.Center.Y), 3), new Bgr(200, 125, 75));

                // tim  convex defect
                Mat defect = new Mat();
                CvInvoke.ConvexityDefects(biggestContour, convexHull, defect);

                // chuyen sang Matrix 
                Matrix<int> mDefect;
                if (!defect.IsEmpty)
                {
                    mDefect = new Matrix<int>(defect.Rows, defect.Cols, defect.NumberOfChannels);
                    defect.CopyTo(mDefect);
                }

            }
            #endregion


            //Display image from camera
            picInputCam.Image = currentFrame.ToBitmap();
            picSkinCam.Image = skin.ToBitmap();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {          
            #region
            if (capture == null)
            {
                try
                {
                    capture = new Capture();

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
                    btnStart.Text = "Pause";
                    Application.Idle += ProcessFramAndUpdateGUI;
                }
                else
                {
                    btnStart.Text = "Start";
                    Application.Idle -= ProcessFramAndUpdateGUI;
                }
                captureInProgress = !captureInProgress;
            }
        }
    }
}
