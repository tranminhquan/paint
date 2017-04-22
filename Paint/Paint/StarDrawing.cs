using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Paint
{
    class StarDrawing : RectangleDrawing
    {
        #region Declare
        public StarDrawing() : base()
        {
            _color = Color.Black;
            _penWidth = 2;
            _startPoint = new Point(0, 0);
            _endPoint = new Point(0, 1);
            _grapPath = new GraphicsPath();
            _grapPath.AddEllipse(new Rectangle(0, 0, 0, 1));
            _grapPath.Widen(new Pen(_color, _penWidth));
            _region = new Region(new Rectangle(0, 0, 0, 1));
            _region.Union(_grapPath);
            _PaintMode = MODE.IDLE;
        }
        public StarDrawing(Color color, int penWidth) : base()
        {
            _color = color;
            _penWidth = penWidth;
            _startPoint = new Point(0, 0);
            _endPoint = new Point(0, 1);
            _grapPath = new GraphicsPath();
            _grapPath.AddEllipse(new Rectangle(0, 0, 0, 1));
            _grapPath.Widen(new Pen(color, penWidth));
            _region = new Region(new Rectangle(0, 0, 0, 1));
            _region.Union(_grapPath);
            _PaintMode = MODE.IDLE;
        }
        #endregion

        #region Method
        public override void Draw(Graphics g)
        {
            //base.Draw(g);
            //float[] dashValues = { 2, 2, 2, 2 };
            //Pen p = new Pen(_color, _penWidth - 1);
            //p.DashPattern = dashValues;
            //g.DrawRectangle(p, GetRectangle(_startPoint, _endPoint));

            PointF p4_Temp = GetHandlePoint(4);
            PointF p5_Temp = GetHandlePoint(5);
            if (GetHandlePoint(4).X > GetHandlePoint(5).X)
            {
                PointF Temp = p4_Temp;
                p4_Temp = p5_Temp;
                p5_Temp = Temp;

            }

            PointF p6_Temp = GetHandlePoint(6);
            PointF p8_Temp = GetHandlePoint(8);
            if (GetHandlePoint(6).X > GetHandlePoint(8).X)
            {
                PointF Temp = p6_Temp;
                p6_Temp = p8_Temp;
                p8_Temp = Temp;

            }
            PointF p1_Temp = GetHandlePoint(1);
            PointF p3_Temp = GetHandlePoint(3);
            if ( GetHandlePoint(3).X < GetHandlePoint(1).X )
            {
                PointF Temp = p3_Temp;
                p3_Temp = p1_Temp;
                p1_Temp = Temp;
            }
            PointF p7_Temp = GetHandlePoint(7);
            PointF p2_Temp = GetHandlePoint(2);
            if ( GetHandlePoint(2).Y > GetHandlePoint(7).Y )
            {
                PointF Temp = p2_Temp;
                p2_Temp = p7_Temp;
                p7_Temp = Temp;
            }
            if (GetHandlePoint(3).Y > GetHandlePoint(8).Y)
            {
                PointF Temp = p3_Temp;
                p3_Temp = p8_Temp;
                p8_Temp = Temp;
            }
            if (GetHandlePoint(1).Y > GetHandlePoint(6).Y)
            {
                PointF Temp = p1_Temp;
                p1_Temp = p6_Temp;
                p6_Temp = Temp;

            }
            float _distance_X = (float)(Math.Sqrt(Math.Pow((p2_Temp.X - p1_Temp.X), 2) + Math.Pow((p2_Temp.Y - p1_Temp.Y), 2)));
            float _distance_Y = (float)(Math.Sqrt(Math.Pow((p4_Temp.X - p1_Temp.X), 2) + Math.Pow((p4_Temp.Y - p1_Temp.Y), 2)));

            PointF p24 = new PointF(p2_Temp.X - _distance_X/4, p4_Temp.Y - _distance_Y/5 - _distance_Y/25);
            PointF p25 = new PointF(p2_Temp.X + _distance_X/4, p5_Temp.Y - _distance_Y/5 - _distance_Y/25);

            PointF p4 = new PointF(p4_Temp.X, p4_Temp.Y - _distance_Y/5);
            PointF p5 = new PointF(p5_Temp.X, p5_Temp.Y - _distance_Y/5);

            PointF p46 = new PointF(p2_Temp.X - _distance_X /(float)2.5, p4_Temp.Y + _distance_Y / 5 + _distance_Y / 25);
            PointF p57 = new PointF(p2_Temp.X + _distance_X /(float)2.5, p5_Temp.Y + _distance_Y / 5 + _distance_Y / 25);

            PointF p7 = new PointF(p2_Temp.X, p7_Temp.Y - 2*_distance_Y /3 + _distance_Y/5);

            PointF p67 = new PointF(p6_Temp.X + _distance_X/3, p7_Temp.Y);
            PointF p78 = new PointF(p8_Temp.X - _distance_X/3, p7_Temp.Y);

            PointF p12 = new PointF(p2_Temp.X - _distance_X /2, p2_Temp.Y);
            PointF p23 = new PointF(p2_Temp.X + _distance_X /2, p2_Temp.Y);

            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.DrawLine(new Pen(_color, _penWidth), p2_Temp, p24);
            g.DrawLine(new Pen(_color, _penWidth), p24 , p4);
            g.DrawLine(new Pen(_color, _penWidth), p4, p46);
            g.DrawLine(new Pen(_color, _penWidth) , p46 , p67);
            g.DrawLine(new Pen(_color, _penWidth), p67 , p7);
            g.DrawLine(new Pen(_color, _penWidth),p7 , p78);
            g.DrawLine(new Pen(_color, _penWidth), p78 , p57);
            g.DrawLine(new Pen(_color, _penWidth),p57,p5);
            g.DrawLine(new Pen(_color, _penWidth), p5,p25);
            g.DrawLine(new Pen(_color, _penWidth), p25, p2_Temp);
            
            
            //DrawHandlePoint(g);
        }
        public override void DrawHandlePoint(Graphics g)
        {
            Pen p = new Pen(Color.Green, 2);
            SolidBrush brush = new SolidBrush(Color.Green);
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
        #endregion

        #region Event
        public override void ChangeSize(int handleIndex, Point destiny)
        {
            base.ChangeSize(handleIndex, destiny);
        }
        public override void ChangeStartAndEndPoint(int handleIndex)
        {
            base.ChangeStartAndEndPoint(handleIndex);
        }

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
