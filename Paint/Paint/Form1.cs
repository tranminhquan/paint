using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
namespace Paint
{
    public partial class frmPaint : Form
    {
        enum PANEL_MODE { OPEN, CLOSE }
        
        enum DRAW_STATUS { COMPLETE, INCOMPLETE };
        Color color = Color.Black;
        int penWidth = 1;
        string objectChoose;
        ObjectDrawing Shape;
        Bitmap doubleBuffer, fillImage;
        GraphicsList grapList;
        DRAW_STATUS status;
        bool isSaved = false;
        Graphics pen; // pen width
        bool isCrop = false;



        Panel panelTab; //Dung trong hieu ung slide tab
        PANEL_MODE panelMode = PANEL_MODE.CLOSE;


        public frmPaint()
        {
            InitializeComponent();
            doubleBuffer = new Bitmap(1527, 707, picPaint.CreateGraphics());
            Graphics g = Graphics.FromImage(doubleBuffer);
            g.Clear(Color.White);
            fillImage = new Bitmap(1527, 707, picPaint.CreateGraphics());
            g = Graphics.FromImage(fillImage);
            g.Clear(Color.White);
            grapList = new GraphicsList();

            pen = pn_penWidth.CreateGraphics();
        }


        private void picPaint_Paint(object sender, PaintEventArgs e)
        {
            doubleBuffer = fillImage.Clone(new Rectangle(0, 0, fillImage.Width, fillImage.Height), System.Drawing.Imaging.PixelFormat.Format24bppRgb);
            Graphics g = Graphics.FromImage(doubleBuffer);
            if (grapList._list.Count > 0)
            {
                grapList.Draw(g);
            }
            if (status == DRAW_STATUS.INCOMPLETE && objectChoose != "bucket")

            e.Graphics.DrawImageUnscaled(doubleBuffer, 0, 0);
        }

        private void picPaint_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {

                //Neu da chon doi tuong
                if (objectChoose == "bucket")
                {
                    //Shape = null;
                if (objectChoose == "rectangle" || objectChoose == "circle" || objectChoose == "star")

                    //BucketDrawing bucket = new BucketDrawing(color);

                    //fillImage = bucket.Fill(doubleBuffer,fillImage, e.X, e.Y);
                    picPaint.Refresh();
                    
                }
                else
                 if (objectChoose == "rectangle" || objectChoose == "circle" || objectChoose == "star" || objectChoose == "line" || objectChoose == "rhombus" || objectChoose == "triangle" || objectChoose == "pentagon" || objectChoose == "hexagon" || objectChoose == "crop")
                {
                    if (Shape != null && Shape.CheckLocation(e.Location) >= 0)
                    {
                        Shape.Mouse_Down(e);
                        status = DRAW_STATUS.INCOMPLETE;

                        if (Shape.CheckLocation(e.Location) == 0)
                            Cursor = Cursors.SizeAll;
                        if (Shape.CheckLocation(e.Location) > 0)
                            Cursor = Cursors.Cross;
                    }

                    else
                    {
                        status = DRAW_STATUS.COMPLETE;
                        ChooseObject();
                        Shape.Mouse_Down(e);
                        grapList._list.Insert(grapList._list.Count, Shape);
                    }
                }
                else
                {
                    status = DRAW_STATUS.COMPLETE;
                    ChooseObject();
                    Shape.Mouse_Down(e);
                    grapList._list.Insert(grapList._list.Count, Shape);
                }
            }

            else
            {
                status = DRAW_STATUS.COMPLETE;
                Shape = null;
            }

        }
        private void picPaint_MouseMove(object sender, MouseEventArgs e)
        {

            toolStripStatusLabel1.Text = "Cursor: " + e.Location.X + " x " + e.Location.Y;

            if (Shape != null)
            {
                Shape.Mouse_Move(e);
                status = DRAW_STATUS.INCOMPLETE;
                if (Shape.CheckLocation(e.Location) == 0)
                    Cursor = Cursors.SizeAll;
                else if (Shape.CheckLocation(e.Location) > 0)
                    Cursor = Cursors.Cross;
                else
                    Cursor = Cursors.Default;
                picPaint.Refresh();
            }

        }

        private void picPaint_MouseUp(object sender, MouseEventArgs e)
        {
            if (objectChoose == "pencil" || objectChoose == "eraser")
                Shape = null;
            if (Shape != null)
                Shape.Mouse_Up(e);
        }

        public void btnObject_Click(object sender, EventArgs e)
        {
            
                Button btnObject = (Button)sender;
                objectChoose = btnObject.Name.Remove(0, 3).ToLower();
                
          
            if(objectChoose == "crop" && isCrop == true)
            {
                int width = Math.Abs(Shape._endPoint.X - Shape._startPoint.X);
                int height = Math.Abs(Shape._endPoint.Y - Shape._startPoint.Y);
                Rectangle ROI = new Rectangle(Shape._startPoint.X + 1, Shape._startPoint.Y + 1, width - 2, height-2);
                
                

                fillImage = CropImage(doubleBuffer, ROI);

                panelPaint.Size = fillImage.Size;
                             
                picPaint.Refresh();
                isCrop = false;
            }
        }

        private void timerPanel_Tick(object sender, EventArgs e)
        {

            if (panelMode == PANEL_MODE.CLOSE)
            {
                if (panelTab.Location.X <= -10)
                {
                    this.timerPanel.Enabled = false;
                    panelMode = PANEL_MODE.OPEN;
                }
                else
                {
                    Point temp = panelTab.Location;
                    temp.X -= 50;
                    panelTab.Location = temp;

                }
            }

            else if (panelMode == PANEL_MODE.OPEN)
            {
                if (panelTab.Location.X >= 240)
                {
                    this.timerPanel.Enabled = false;
                    panelMode = PANEL_MODE.CLOSE;
                }
                else
                {
                    Point temp = panelTab.Location;
                    temp.X += 50;
                    panelTab.Location = temp;

                }
            }
        }


        private void pnlTab_Click(object sender, EventArgs e)
        {
            panelTab = (Panel)sender;
            this.timerPanel.Enabled = true;
        }


        private void pnlTab_MouseLeave(object sender, EventArgs e)
        {
            if (panelMode == PANEL_MODE.OPEN)
                this.timerPanel.Enabled = true;
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "All Picture Files|*.bmp;*.ico;*.gif;*.jpeg;*.jpg;*.jfif;*.png;*.tif;*.tiff;*.wmf;*.emf|" +
                            "Windows Bitmap (*.bmp)|*.bmp|" +
                            "All Files (*.*)|*.*";
            openFileDialog1.Title = "Open an Image File";

            newToolStripMenuItem_Click(sender, e);
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    fillImage = new Bitmap(openFileDialog1.FileName);
                    picPaint.Image = fillImage;
                    picPaint.Refresh();
                }
                catch
                {
                    MessageBox.Show("Can't read this file", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }

        private void TB_penWidth_Scroll(object sender, EventArgs e)
        {
            penWidth = TB_penWidth.Value;
            lb_penWidth.Text = TB_penWidth.Value.ToString();

            DrawpenWidth();
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            ColorDialog _Color = new ColorDialog();
            _Color.ShowDialog();

            color = _Color.Color;

            DrawpenWidth();
        }
        public void DrawpenWidth()
        {
            pen.Clear(Color.White);

            SolidBrush brush = new SolidBrush(color);

            RectangleF rec = new RectangleF(2, 2, pn_penWidth.Width,
                                                pn_penWidth.Height);

            pen.DrawLine(new Pen(color, penWidth), new Point(5, pn_penWidth.Height / 2), new Point(pn_penWidth.Width - 5, pn_penWidth.Height / 2));
        }
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Shape = null;
            grapList._list.Clear();
            if (isSaved == false)
            {
                DialogResult dlr = MessageBox.Show("Do you want to save first?", "Absoluke Paint", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dlr == DialogResult.Yes)
                {
                    saveAsToolStripMenuItem_Click(sender, e);
                    isSaved = true;
                }
                else
                {
                    fillImage = new Bitmap(1145, 526, System.Drawing.Imaging.PixelFormat.Format24bppRgb);
                    Graphics g = Graphics.FromImage(fillImage);
                    g.Clear(Color.White);
                    picPaint.Size = fillImage.Size;
                    picPaint.Refresh();
                }
            }
            else
            {
                fillImage = new Bitmap(1145, 526, System.Drawing.Imaging.PixelFormat.Format24bppRgb);
                Graphics g = Graphics.FromImage(fillImage);
                g.Clear(Color.White);
                picPaint.Size = fillImage.Size;
                picPaint.Refresh();
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (File.Exists(saveFileDialog1.FileName))
                doubleBuffer.Save(saveFileDialog1.FileName);
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Title = "Save an Image File";
            saveFileDialog1.Filter = "BMP (*.bmp)|*.bmp|All File (*.*)|*.*";
            saveFileDialog1.CheckPathExists = true;
            saveFileDialog1.OverwritePrompt = true;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                doubleBuffer.Save(saveFileDialog1.FileName);
            isSaved = true;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (isSaved == false)
            {
                DialogResult dlr = MessageBox.Show("Do you want to save first?", "Absoluke Paint", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dlr == DialogResult.Yes)
                {
                    saveAsToolStripMenuItem_Click(sender, e);
                    isSaved = true;
                    this.Close();
                    this.Dispose();
                }
                else
                {
                    this.Close();
                    this.Dispose();
                }
            }
            else
            {
                this.Close();
                this.Dispose();
            }
        }

        private void frmPaint_FormClosed(object sender, FormClosingEventArgs e)
        {
            exitToolStripMenuItem_Click(sender, e);
        }

        private void ChooseObject()
        {
            switch (objectChoose)
            {
                case "pencil":
                    Shape = new PenDrawing(color, penWidth);
                    break;

                case "eraser":
                    Shape = new EraserDrawing(penWidth);
                    break;
                case "rectangle":
                    Shape = new RectangleDrawing(color, penWidth);
                    break;
                case "circle":
                    Shape = new CircleDrawing(color, penWidth);
                    break;
                case "star":
                    Shape = new StarDrawing(color, penWidth);
                    break;
                case "line":
                    Shape = new LineDrawing(color, penWidth);
                    break;
                case "triangle":
                    Shape = new TriangleDrawing(color, penWidth);
                    break;
                case "rhombus":
                    Shape = new RhombusDrawing(color, penWidth);
                    break;
                case "pentagon":
                    Shape = new PentagonDrawing(color, penWidth);
                    break;
                case "hexagon":
                    Shape = new HexagonDrawing(color, penWidth);
                    break;
                case "crop":
                    Shape = new CropRectangle(); 
                    isCrop = true;
                    break;
                
                default:
                    objectChoose = "none";
                    Shape = new NoneShapeDrawing();
                    break;
            }
        }

 

        private Bitmap CropImage(Bitmap src,Rectangle Roi)
        {
            Bitmap croppedImg;
            

            croppedImg =src.Clone(Roi, System.Drawing.Imaging.PixelFormat.Format24bppRgb);

            
            return croppedImg;
        }

        private void pn_penWidth_Paint(object sender, PaintEventArgs e)
        {
            DrawpenWidth();
        }

        private void Renew()
        {
            
            grapList._list.Clear();
            fillImage = new Bitmap(1527, 707, System.Drawing.Imaging.PixelFormat.Format24bppRgb);
            Graphics g = Graphics.FromImage(fillImage);
            g.Clear(Color.White);
            picPaint.Size = fillImage.Size;
            picPaint.Refresh();
        }
    }
}
