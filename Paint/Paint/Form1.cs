using System;
using System.Drawing;
using System.Windows.Forms;

namespace Paint
{
    public partial class frmPaint : Form
    {
        enum PANEL_MODE { OPEN, CLOSE }

        enum DRAW_STATUS { COMPLETE, INCOMPLETE };
        Color color = Color.Black;
        int penWidth = 3;
        string objectChoose;
        ObjectDrawing Shape;
        Bitmap doubleBuffer, fillImage;
        GraphicsList grapList;
        DRAW_STATUS status;


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

        }


        private void picPaint_Paint(object sender, PaintEventArgs e)
        {
            doubleBuffer = fillImage.Clone(new Rectangle(0, 0, fillImage.Width, fillImage.Height), System.Drawing.Imaging.PixelFormat.Format24bppRgb);
            Graphics g = Graphics.FromImage(doubleBuffer);
            if (grapList._list.Count > 0)
            {
                grapList.Draw(g);
            }
            if (status == DRAW_STATUS.INCOMPLETE)
                Shape.DrawHandlePoint(g);

            e.Graphics.DrawImageUnscaled(doubleBuffer, 0, 0);

        }

        private void picPaint_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {

                //Neu da chon doi tuong
                //if (objectChoose == "bucket")
                //{
                //    BucketDrawing bucket = new BucketDrawing(color);
                //    Bitmap temp = new Bitmap(picPaint.Image);
                //    bucket.Fill(temp, e.X, e.Y);
                //    picPaint.Image = temp;
                //}

                if (objectChoose == "rectangle" || objectChoose == "circle" || objectChoose == "star")
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
            OpenFileDialog _Open = new OpenFileDialog();
            if (_Open.ShowDialog() == DialogResult.OK)
            {
            }
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
                case "bucket":
                    Shape = new BucketDrawing(color);
                    break;


                default:
                    break;
            }
        }
    }
}
