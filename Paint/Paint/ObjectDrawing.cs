using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;


namespace Paint
{
    class ObjectDrawing
    {
        #region Declare
        
        public enum MODE { DRAW, MOVE, RESIZE, IDLE }
        public MODE _PaintMode;        
        protected Color _color;
        protected int _penWidth;
        protected GraphicsPath _grapPath;
        public Point _startPoint;
        public Point _endPoint;
        public bool isNoneShape = true;
        public bool isBucket = false;

        



        #endregion

        #region Method
        public ObjectDrawing()
        {
            _PaintMode = MODE.DRAW;
            _color = Color.Black;
            _penWidth = 2;
            _grapPath = new GraphicsPath();          
        }

        public ObjectDrawing(Color color, int penwidth)
        {
            _PaintMode = MODE.DRAW;
            _color = color;
            _penWidth = penwidth;
            _grapPath = new GraphicsPath();           
        }

        public virtual void Draw(Graphics g)
        {

        }

        public virtual void DrawHandlePoint(Graphics g)
        {

        }

        public virtual int CheckLocation(Point cursor)
        {
            return -1;
        }

        public virtual void ChaneCursor(Cursor _cursor)
        {

        }

        public Color getColor()
        {
            return _color;
        }

        public virtual Point getMouseClick()
        {
            return new Point(0, 0);
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
