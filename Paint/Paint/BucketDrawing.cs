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

        public Bitmap Fill(Bitmap _pic , Bitmap _fillpic ,int x, int y) 
        // clickColor la color o vi tri click
        {
            _fillpic = _pic.Clone(new Rectangle(0, 0, _pic.Width,_pic.Height), System.Drawing.Imaging.PixelFormat.Format24bppRgb);
            
            if (x > 0 && x < _fillpic.Width && y > 0 && y < _fillpic.Height)
            {
                Point p = new Point(x, y);
                Color currColor = new Color();

                Color clickColor = new Color();
                //if (_fillpic.GetPixel(x, y) == null)
                //    clickColor = Color.White;
                //else
                    clickColor = _fillpic.GetPixel(x, y);

                Stack<Point> _sPoint = new Stack<Point>();
                _sPoint.Push(p);

                while(_sPoint.Count > 0)
                {
                    p = _sPoint.Pop();
                    //if (_fillpic.GetPixel(p.X, p.Y) == null)
                    //    currColor = Color.White;
                    //else
                        currColor = _fillpic.GetPixel(p.X, p.Y);

                    if (p.X > 1 && p.X < _fillpic.Width - 1 && p.Y > 1 && p.Y < _fillpic.Height - 1)
                    {
                        if (currColor == clickColor)
                        {
                            _fillpic.SetPixel(p.X, p.Y, this._color);
                            _sPoint.Push(new Point(p.X - 1, p.Y));
                            _sPoint.Push(new Point(p.X + 1, p.Y));
                            _sPoint.Push(new Point(p.X, p.Y - 1));
                            _sPoint.Push(new Point(p.X, p.Y + 1));
                        }
                    }
                }
                
                              
            }

            return _fillpic;
        }


        #endregion
    }
}
