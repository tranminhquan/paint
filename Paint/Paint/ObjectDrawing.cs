using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;


namespace Paint
{
    class ObjectDrawing
    {
        #region Declare
        const int HANDLE_COUNT = 0;
        protected enum MODE { DRAW, MOVE, RESIZE }
        MODE STATUS;

        protected Color _color;
        protected int _penWidth;
        protected Point _startPoint, _endPoint, _currentPoint;
        protected GraphicsPath _grapPath;
        #endregion

        #region Method
        public ObjectDrawing()
        {
            _color = Color.Black;
            _penWidth = 2;
            _grapPath = new GraphicsPath();
            STATUS = MODE.DRAW;
        }

        public ObjectDrawing(Color color, int penwidth)
        {
            _color = color;
            _penWidth = penwidth;
            _grapPath = new GraphicsPath();
            STATUS = MODE.DRAW;
        }

        public virtual void Draw(Graphics g)
        {

        }

        protected virtual Point GetHandlePoint(int handleIndex)
        {
            return new Point();
        }

        protected virtual Rectangle GetRectangleHandle(int handleIndex)
        {
            Point point = GetHandlePoint(handleIndex);

            return new Rectangle(point.X - 3, point.Y - 3, 7, 7);
        }

        public virtual void DrawHandlePoint(Graphics g)
        {
            Pen p = new Pen(Color.Green, 2);
            Brush brush = new SolidBrush(Color.White);
            for (int i = 1; i < HANDLE_COUNT; i++)
            {
                g.DrawRectangle(p, GetRectangleHandle(i));
                g.FillRectangle(brush, GetRectangleHandle(i));
            }
            p.Dispose();
            brush.Dispose();
        }

        protected virtual void Move(int deltaX, int deltaY)
        {
            _startPoint.X += deltaX;
            _startPoint.Y += deltaY;
            _endPoint.X += deltaX;
            _endPoint.Y += deltaY;
        }

        protected virtual void ChangeSize(int handleIndex, Point destiny)
        {

        }
        #endregion

        #region Event
        public virtual void Mouse_Down(MouseEventArgs e)
        {

        }

        public virtual void Mouse_Move(MouseEventArgs e)
        {

        }

        public virtual void Mouse_Up(MouseEventArgs e)
        {

        }

        #endregion

    }
}
