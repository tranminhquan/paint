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
    class BucketDrawing : ObjectDrawing
    {
        #region Method

       public BucketDrawing(Color _color)
        {
            this._color = _color;
        }

        #endregion

        #region Event

        public override void Mouse_Down(MouseEventArgs e)
        {
            
        }

        public void Fill(Bitmap _pic,int x, int y) 
        // clickColor la color o vi tri click
        {
            if(x > 0 && x < _pic.Width && y > 0 && y < _pic.Height)
            {
                Point p = new Point(x, y);
                Color currColor = new Color();

                Color clickColor = new Color();
                if (_pic.GetPixel(x, y) == null)
                    clickColor = Color.White;
                else
                    clickColor = _pic.GetPixel(x, y);

                Stack<Point> _sPoint = new Stack<Point>();
                _sPoint.Push(p);

                while(_sPoint.Count > 0)
                {
                    p = _sPoint.Pop();
                    if (_pic.GetPixel(p.X, p.Y) == null)
                        currColor = Color.White;
                    else
                        currColor = _pic.GetPixel(p.X, p.Y);

                    if (p.X > 1 && p.X < _pic.Width - 1 && p.Y > 1 && p.Y < _pic.Height - 1)
                    {
                        if (currColor == clickColor)
                        {
                            _pic.SetPixel(p.X, p.Y, this._color);
                            _sPoint.Push(new Point(p.X - 1, p.Y));
                            _sPoint.Push(new Point(p.X + 1, p.Y));
                            _sPoint.Push(new Point(p.X, p.Y - 1));
                            _sPoint.Push(new Point(p.X, p.Y + 1));
                        }
                    }
                }
                
                              
            }
        }


        #endregion
    }
}
