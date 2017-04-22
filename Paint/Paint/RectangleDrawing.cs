using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Paint
{
    class RectangleDrawing: ObjectDrawing
    {
        #region Declare
        protected const int HANDLE_COUNT = 8;
        protected Point  _currentPoint;
        protected Region _region;
        protected int posOfLocation;
        #endregion

        #region Method
        public RectangleDrawing(): base()
        {
            _color = Color.Black;
            _penWidth = 2;
            _startPoint = new Point(0, 0);
            _endPoint = new Point(0, 1);
            _grapPath = new GraphicsPath();
            _grapPath.AddRectangle(new Rectangle(0, 0, 0, 1));
            _grapPath.Widen(new Pen(_color, _penWidth));
            _region = new Region(new Rectangle(0, 0, 0, 1));
            _region.Union(_grapPath);
            _PaintMode = MODE.IDLE;
        }

        public RectangleDrawing(Color color, int penWidth): base()
        {
            _color = color;
            _penWidth = penWidth;
            _startPoint = new Point(0, 0);
            _endPoint = new Point(0, 1);
            _grapPath = new GraphicsPath();
            _grapPath.AddRectangle(new Rectangle(0, 0, 0, 1));
            _grapPath.Widen(new Pen(color, penWidth));
            _region = new Region(new Rectangle(0, 0, 0, 1));
            _region.Union(_grapPath);
            _PaintMode = MODE.IDLE;
        }

        public override void Draw(Graphics g)
        {
            //base.Draw(g);
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.DrawRectangle(new Pen(_color, _penWidth), GetRectangle(_startPoint, _endPoint));           
        }

        protected Rectangle GetRectangle(Point start, Point end)
        {
            if (start.X > end.X)
            {
                int temp = start.X;
                start.X = end.X;
                end.X = temp;
            }
            if (start.Y > end.Y)
            {
                int temp = start.Y;
                start.Y = end.Y;
                end.Y = temp;
            }

            return new Rectangle(start.X, start.Y, Math.Abs(end.X - start.X), Math.Abs(end.Y - start.Y));
        }

        //Tao cac diem handle point tai cac vi tri tuong ung
        //  1     2      3
        //  4            5
        //  6     7      8  
        protected virtual Point GetHandlePoint(int handleIndex)
        {
            Point center = new Point();
            center.X = (_startPoint.X + _endPoint.X) / 2;
            center.Y = (_startPoint.Y + _endPoint.Y) / 2;

            switch(handleIndex)
            {
                case 1:
                    return _startPoint;           
                case 2:
                    return new Point(center.X, _startPoint.Y);
                case 3:
                    return new Point(_endPoint.X, _startPoint.Y);
                case 4:
                    return new Point(_startPoint.X, center.Y);
                case 5:
                    return new Point(_endPoint.X, center.Y);
                case 6:
                    return new Point(_startPoint.X, _endPoint.Y);
                case 7:
                    return new Point(center.X, _endPoint.Y);
                case 8:
                    return _endPoint;
                default:
                    MessageBox.Show("Error system (Unknow handleIndex of Rectangle", "Noice");
                    return new Point();                   
            }          
        }

        protected virtual Rectangle GetRectangleHandle(int handleIndex)
        {
            Point point = GetHandlePoint(handleIndex);

            return new Rectangle(point.X - 3, point.Y - 3, 7, 7);
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

        protected virtual void MoveStartAndEndPoint(int deltaX, int deltaY)
        {
            _startPoint.X += deltaX;
            _startPoint.Y += deltaY;
            _endPoint.X += deltaX;
            _endPoint.Y += deltaY;
        }

        public virtual void ChangeStartAndEndPoint(int handleIndex)
        {
            if (handleIndex == 1 || handleIndex == 2 || handleIndex == 4)
            {
                Point temp = _startPoint;
                _startPoint = _endPoint;
                _endPoint = temp;
            }

            if (handleIndex == 3)
            {
                _startPoint = GetHandlePoint(6);
                _endPoint = GetHandlePoint(3);
            }

            if (handleIndex == 6)
            {
                _startPoint = GetHandlePoint(3);
                _endPoint = GetHandlePoint(6);
            }
        }

        public virtual void ChangeSize(int handleIndex, Point destiny)
        {
            //Khi goi ham nay start point va endpoint da thay doi
            int deltaX = destiny.X - _currentPoint.X;
            int deltaY = destiny.Y - _currentPoint.Y;

            switch(handleIndex)
            {
                case 2:
                case 7:
                    _endPoint.Y += deltaY;
                    break;

                case 4:
                case 5:
                    _endPoint.X += deltaX;
                    break;

                default:
                    _endPoint = destiny;
                    break;
            }
        }

        //Ham kiem tra vi tri cua vung hinh ve va con tro chuot khi co event Mouse_Down
        // > 0 : Vi tri tro chuot tai diem dieu khien
        // = 0 : Con tro trung diem dieu khien
        // < 0 : Con tro nam ngoai region
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
        public override void ChaneCursor(Cursor _cursor)
        {
            if (_PaintMode == MODE.MOVE)
                _cursor = Cursors.SizeAll;
            else if (_PaintMode == MODE.RESIZE)
                _cursor = Cursors.Cross;
            else
                _cursor = Cursors.Default;
        }
        #endregion

        #region Event
        public override void Mouse_Down(MouseEventArgs e)
        {
            base.Mouse_Down(e);
            
            if (_PaintMode == MODE.IDLE)
            {
                posOfLocation = CheckLocation(e.Location);

                if (posOfLocation < 0)
                {
                    _PaintMode = MODE.DRAW;
                    _startPoint = e.Location;
                    _endPoint.X = e.Location.X + 1;
                    _endPoint.Y = e.Location.Y + 1;

                }
                else if (posOfLocation == 0)
                {
                    _PaintMode = MODE.MOVE;
                    _currentPoint = e.Location;
                }
                else
                {
                    _PaintMode = MODE.RESIZE;
                    
                    ChangeStartAndEndPoint(posOfLocation);
                    _currentPoint = e.Location;

                }
            }
            
        }

        public override void Mouse_Move(MouseEventArgs e)
        {
            base.Mouse_Move(e);

            if (_PaintMode == MODE.MOVE)
            {
                int deltaX = e.Location.X - _currentPoint.X;
                int deltaY = e.Location.Y - _currentPoint.Y;

                MoveStartAndEndPoint(deltaX, deltaY);
                _currentPoint = e.Location;
            }

            if (_PaintMode == MODE.RESIZE)
            {
                ChangeSize(posOfLocation, e.Location);
                _currentPoint = e.Location;
            }

            if (_PaintMode == MODE.DRAW)
            {
                _endPoint = e.Location;
            }
        }

        public override void Mouse_Up(MouseEventArgs e)
        {
            base.Mouse_Up(e);

            _grapPath = new GraphicsPath();
            _grapPath.AddRectangle(GetRectangle(_startPoint, _endPoint));
            _grapPath.Widen(new Pen(_color, _penWidth));
            _region = new Region(GetRectangle(_startPoint, _endPoint));
            _region.Union(_grapPath);
            _PaintMode = MODE.IDLE;    
        }
        #endregion
    }
}
