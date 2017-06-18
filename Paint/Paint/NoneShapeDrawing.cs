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
    class NoneShapeDrawing : RectangleDrawing
    {
        public NoneShapeDrawing() : base()
        {
            isNoneShape = true;
        }

        public override void Draw(Graphics g)
        {
            if (_PaintMode == MODE.DRAW)
            {
                Pen p = new Pen(Color.Blue, 3);
                p.DashStyle = DashStyle.Dash;
                g.SmoothingMode = SmoothingMode.AntiAlias;
                g.DrawRectangle(p, GetRectangle(_startPoint, _endPoint));
            }
        }

        public override void Mouse_Down(MouseEventArgs e)
        {
            _PaintMode = MODE.DRAW;
            _startPoint = e.Location;
            _endPoint.X = e.Location.X;
            _endPoint.Y = e.Location.Y;
        }

        public override void Mouse_Move(MouseEventArgs e)
        {
            if (_PaintMode == MODE.DRAW)
                _endPoint = e.Location;
        }
        public override void Mouse_Up(MouseEventArgs e)
        {
            _PaintMode = MODE.IDLE;
        }
    }
}
