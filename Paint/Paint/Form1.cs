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
        
        public frmPaint()
        {
            
            InitializeComponent();

            Shape = new PenDrawing(Color.Black, 5);
        }

        private void picPaint_MouseMove(object sender, MouseEventArgs e)
        {
            
            toolStripStatusLabel1.Text = "Cursor: " + e.Location.X + " x " + e.Location.Y;
        }

        private void picPaint_Paint(object sender, PaintEventArgs e)
        {
            Shape.Draw(e.Graphics);
            
        }

        private void picPaint_MouseDown(object sender, MouseEventArgs e)
        {
            Shape.Mouse_Down(e);
            picPaint.Refresh();
        }

        private void picPaint_MouseUp(object sender, MouseEventArgs e)
        {
            Shape.Mouse_Up(e);
        }
    }
}
