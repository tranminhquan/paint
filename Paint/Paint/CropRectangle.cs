using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paint
{
    class CropRectangle : RectangleDrawing

    { 
        public CropRectangle()
        {

        }
        #region Method
        public override void Draw(Graphics g)
        {
            Pen p = new Pen(Color.Black, 1);
            float[] dashValues = { 2, 2, 2, 2 };
          
            p.DashPattern = dashValues;
            g.DrawRectangle(p, GetRectangle(_startPoint, _endPoint));
        }
        public override void DrawHandlePoint(Graphics g)
        {
            Pen p = new Pen(Color.Black, (float)0.2);
            SolidBrush brush = new SolidBrush(Color.Black);
            for (int i = 1; i <= HANDLE_COUNT; i++)
            {
                g.DrawRectangle(p, GetRectangleHandle(i));
                g.FillRectangle(brush, GetRectangleHandle(i));
            }
            p.Dispose();
            brush.Dispose();
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
        #endregion


        #region Event
        public override void Mouse_Down(MouseEventArgs e)
        {
           
            base.Mouse_Down(e);
        }
        public override void Mouse_Move(MouseEventArgs e)
        {
            base.Mouse_Move(e);
        }
        public override void Mouse_Up(MouseEventArgs e)
        {
            base.Mouse_Up(e);
        }

        #endregion
    }
}
