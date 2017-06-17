using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint
{
    class RectangleSelection : RectangleDrawing
    {
        public Image _img;
        public RectangleSelection(Color color, int penwidth) : base(color, penwidth)
        {
        }
        public override void Draw(Graphics g)
        {
            Pen p = new Pen(Color.Black, 1);
            float[] dashValues = { 2, 2, 2, 2 };
            
            p.DashPattern = dashValues;
            g.DrawRectangle(p, GetRectangle(_startPoint, _endPoint));

            if (_img != null)
            {
                g.DrawImage(_img, GetRectangle(_startPoint, _endPoint));
            }
        }
        public override int CheckLocation(Point cursor)
        {
            for (int i = 1; i <= HANDLE_COUNT; i++)
            {
                if (GetRectangleHandle(i).Contains(cursor))
                    return i;
            }

            //Neu con tro thuoc region
            if (_region.IsVisible(cursor))
                return 0;

            //Neu con tro nam ngoai region
            return -1;
        }
        public override void ChangeSize(int handleIndex, Point destiny)
        {
            base.ChangeSize(handleIndex, destiny);
        }
        public override void ChangeStartAndEndPoint(int handleIndex)
        {
            base.ChangeStartAndEndPoint(handleIndex);
        }
        public override void Mouse_Up(MouseEventArgs e)
        {
            base.Mouse_Up(e);

        }
        public override void Mouse_Move(MouseEventArgs e)
        {
            base.Mouse_Move(e);
        }
        public override void Mouse_Down(MouseEventArgs e)
        {
            base.Mouse_Down(e);
        }
    }

}
