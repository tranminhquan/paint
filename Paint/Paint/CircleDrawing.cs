using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Paint
{
    class CircleDrawing : RectangleDrawing
    {
        #region Declare
        public CircleDrawing() : base()
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
        public CircleDrawing(Color color, int penWidth) : base()
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
            float[] dashValues = { 2, 2, 2, 2 };
            Pen p = new Pen(_color, _penWidth - 1);
            p.DashPattern = dashValues;
            //g.DrawRectangle(p, GetRectangle(_startPoint, _endPoint));
            g.DrawEllipse(new Pen(_color, _penWidth), GetRectangle(_startPoint, _endPoint));

            //DrawHandlePoint(g);
        }

        public override void DrawHandlePoint(Graphics g)
        {
            Pen p = new Pen(Color.Green, 2);
            SolidBrush brush = new SolidBrush(Color.Green);
            for (int i = 1; i <= HANDLE_COUNT; i++)
            {
                g.DrawEllipse(p, GetRectangleHandle(i));
                g.FillEllipse(brush, GetRectangleHandle(i));
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
