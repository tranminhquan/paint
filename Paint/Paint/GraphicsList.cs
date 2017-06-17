using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
namespace Paint
{
    class GraphicsList
    {
        #region Decalre
        public List<ObjectDrawing> _list;
        public int _posINCOMPLETE;
        #endregion

        #region Method
        public GraphicsList()
        {
            _list = new List<ObjectDrawing>();
        }

        public void Draw(Graphics g)
        {

            for (int i = 0; i < _list.Count; i++)
            {

                _list[i].Draw(g);
                if (i == _posINCOMPLETE && _list[i]._startPoint != _list[i]._endPoint && _list[i].isNoneShape == true)
                    if (!(_list[i] is RectangleSelection))
                    {
                        _list[i].DrawHandlePoint(g);
                    }
            }
        }

     
        public void RemoveLast()
        {
            try
            {
                _list.RemoveAt(_list.Count - 1);
            }
            catch
            {
                MessageBox.Show("System error (GraphicsList cant find any element", "Noice");
            }
        }

        public bool isExist(ObjectDrawing shape)
        {
            for (int i = 0; i < _list.Count; i++)
            {
                if (shape.getColor() == _list[i].getColor() && shape.getMouseClick() == _list[i].getMouseClick())
                {
                    return true;
                }
            }
            return false;
        }

        public void Swap(int indexA , int indexB)
        {
            ObjectDrawing Temp = _list[indexA];
            _list[indexA] = _list[indexB];
            _list[indexB] = Temp;
        }
        #endregion
    }
}
