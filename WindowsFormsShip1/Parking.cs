using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WindowsFormsTruck
{
  
     public class Parking<T> : IEnumerator<T>, IEnumerable<T>
     where T : class, ITransport
     {
            private readonly List<T> _places;
            
            private readonly int _maxCount;
            
            private readonly int pictureWidth;
            
            private readonly int pictureHeight;
            
            private readonly int _placeSizeWidth = 300;
            
            private readonly int _placeSizeHeight = 100;

            private int _currentIndex;
            public T Current => _places[_currentIndex];
            object IEnumerator.Current => _places[_currentIndex];

        public Parking(int picWidth, int picHeight)
        {
                int width = picWidth / _placeSizeWidth;
                int height = picHeight / _placeSizeHeight;
                _places = new List<T>();
                _maxCount= width * height;
                pictureWidth = picWidth;
                pictureHeight = picHeight;
                _currentIndex = -1;
        }

        public static bool operator +(Parking<T> p, T ship)
        {
            if (p._places.Count >= p._maxCount)
            {
                throw new ParkingOverflowException();
            }
            if (p._places.Contains(ship))
            {
                throw new ParkingAlreadyHaveThisShipException();
            }
            p._places.Add(ship);
            return true;
        }

        public static T operator -(Parking<T> p, int index)
        {
            if (index <= -1 || index >= p._places.Count)
            {
                throw new ParkingShipNotFoundException(index);
            }
            T ship = p._places[index];
            p._places.RemoveAt(index);
            return ship;
        }

        public void Draw(Graphics g)
        {
            DrawMarking(g);
            for (int i = 0; i < _places.Count; ++i)
            {
                int height = pictureHeight / _placeSizeHeight;
                int column = i / height;
                int row = i % height;
                _places[i].SetPosition(column * _placeSizeWidth + _placeSizeWidth / 8, row * _placeSizeHeight + _placeSizeHeight / 2, pictureWidth, pictureHeight);
                _places[i].DrawTransport(g);
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
        public T GetNext(int index)
        {
            if (index < 0 || index >= _places.Count)
            {
                return null;
            }
            return _places[index];
        }

        public void Sort() => _places.Sort((IComparer<T>)new ShipComparer());

        public void Dispose()
        {
        }

        public bool MoveNext()
        {
            _currentIndex++;
            return (_currentIndex > _places.Count);
        }

        public void Reset()
        {
            _currentIndex = -1;
        }

        public IEnumerator<T> GetEnumerator()
        {
            return this;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this;
        }
    }
}
