using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint
{
    public partial class frmPaint : Form
    {
        ObjectDrawing Shape;
        Bitmap doubleBuffer, fillImage;
        GraphicsList grapList;
      
        public frmPaint()
        {
            InitializeComponent();
            doubleBuffer = new Bitmap(picPaint.Width, picPaint.Height, picPaint.CreateGraphics());
            Graphics g = Graphics.FromImage(doubleBuffer);
            g.Clear(Color.White);
            fillImage = new Bitmap(picPaint.Width, picPaint.Height, picPaint.CreateGraphics());
            g = Graphics.FromImage(fillImage);
            g.Clear(Color.White);
            grapList = new GraphicsList();
         
        }

       
        private void picPaint_Paint(object sender, PaintEventArgs e)
        {
                      
            if (grapList._list.Count>0)
            {
                Graphics g = e.Graphics;
                grapList.Draw(g);
            }
        }

        private void picPaint_MouseDown(object sender, MouseEventArgs e)
        {
            if (Shape != null)
            {               
                Shape.Mouse_Down(e);
            }
            else
            {               
                Shape = new PenDrawing(Color.Black, 5);
                Shape.Mouse_Down(e);
                grapList._list.Insert(grapList._list.Count, Shape);
            }
        }

        private void picPaint_MouseMove(object sender, MouseEventArgs e)
        {

            toolStripStatusLabel1.Text = "Cursor: " + e.Location.X + " x " + e.Location.Y;

            if (Shape != null)
            {
                Shape.Mouse_Move(e);
                picPaint.Refresh();
            }
        }

        private void picPaint_MouseUp(object sender, MouseEventArgs e)
        {
            Shape = null;       
        }
    }
}
