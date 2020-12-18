using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsTruck
{
  
        public class Parking<T> where T : class, ITransport
        {
            private readonly T[] _places;

            private readonly int pictureWidth;

            private readonly int pictureHeight;
 
            private readonly int _placeSizeWidth = 300;
 
            private readonly int _placeSizeHeight = 100;
            public Parking(int picWidth, int picHeight)
            {
                int width = picWidth / _placeSizeWidth;
                int height = picHeight / _placeSizeHeight;
                _places = new T[width * height];
                pictureWidth = picWidth;
                pictureHeight = picHeight;
            }

        public static bool operator +(Parking<T> p, T ship)
            {
            for (int i = 0; i < p._places.Length; i++)
            {
                if (p._places[i] is null)
                {
                    p._places[i] = ship;
                    int width = p.pictureWidth / p._placeSizeWidth;
                    int height = p.pictureHeight / p._placeSizeHeight;
                    int column = i / height;
                    int row = i % height;
                    ship.SetPosition(column * p._placeSizeWidth + p._placeSizeWidth / 8, row * p._placeSizeHeight + p._placeSizeHeight / 2, p.pictureWidth, p.pictureHeight);
                    return true;
                }
            }
            return false;
        }

            public static T operator -(Parking<T> p, int index)
            {
                 if (index >= 0 && index < p._places.Length)
                 {
                var res = p._places[index];
                p._places[index] = null;
                return res;
                 }
            return null;
             }

            public void Draw(Graphics g)
            {
                DrawMarking(g);
                for (int i = 0; i < _places.Length; i++)
                {
                    _places[i]?.DrawTransport(g);
                }
            }

            private void DrawMarking(Graphics g)
            {
                Pen pen = new Pen(Color.Black, 3);
                for (int i = 0; i < pictureWidth / _placeSizeWidth; i++)
                {
                    for (int j = 0; j < pictureHeight / _placeSizeHeight + 1; ++j)
                    {
                        g.DrawLine(pen, i * _placeSizeWidth, j * _placeSizeHeight, i *_placeSizeWidth + _placeSizeWidth / 2, j * _placeSizeHeight);
                    }
                    g.DrawLine(pen, i * _placeSizeWidth, 0, i * _placeSizeWidth,
                   (pictureHeight / _placeSizeHeight) * _placeSizeHeight);
                }
            }
        }
}
