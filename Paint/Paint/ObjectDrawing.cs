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
        
        public enum MODE { DRAW, MOVE, RESIZE, IDLE }
        public MODE _PaintMode;        
        protected Color _color;
        protected int _penWidth;
        protected GraphicsPath _grapPath;
        
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
