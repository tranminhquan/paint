using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Paint
{
    class PentagonDrawing : RectangleDrawing
    {
        #region Declare
        public PentagonDrawing() : base()
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
        public PentagonDrawing(Color color, int penWidth) : base()
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
            Pen p = new Pen(_color, _penWidth - 1);

            Point A = GetHandlePoint(2);
            Point B = new Point(_startPoint.X, _startPoint.Y + (_endPoint.Y - _startPoint.Y) * 2 / 6);
            Point C = new Point(_startPoint.X + (_endPoint.X - _startPoint.X) / 6, _endPoint.Y);
            Point D = new Point(_startPoint.X + (_endPoint.X - _startPoint.X) * 5 / 6, _endPoint.Y);
            Point E = new Point(_endPoint.X, _startPoint.Y + (_endPoint.Y - _startPoint.Y) * 2 / 6);

            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.DrawLine(new Pen(_color, _penWidth), A, B);
            g.DrawLine(new Pen(_color, _penWidth), B, C);
            g.DrawLine(new Pen(_color, _penWidth), C, D);
            g.DrawLine(new Pen(_color, _penWidth), D, E);
            g.DrawLine(new Pen(_color, _penWidth), E, A);

            //g.DrawRectangle(p, GetRectangle(_startPoint, _endPoint));
            //g.DrawEllipse(new Pen(_color, _penWidth), GetRectangle(_startPoint, _endPoint));
            //DrawHandlePoint(g);
        }

        public override void DrawHandlePoint(Graphics g)
        {
            Pen p = new Pen(Color.Blue, 2);
            SolidBrush brush = new SolidBrush(Color.Blue);
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
