using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsTruck
{

    class WarShip 
    {
        private float _startPosX;

        private float _startPosY;

        private int _pictureWidth;

        private int _pictureHeight;


        private readonly int shipWidth = 100;

        private readonly int shipHeight = 60;

        public int MaxSpeed { private set; get; }

        public float Weight { private set; get; }

        public Color MainColor { private set; get; }

        public Color DopColor { private set; get; }

        public bool Radar { private set; get; }

        public bool Weapon { private set; get; }

        public WarShip(int maxSpeed, float weight, Color mainColor, Color dopColor, bool radar, bool weapon)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
            DopColor = dopColor;
            Radar = radar; 
            Weapon = weapon; 
        }

        public void SetPosition(int x, int y, int width, int height)
        {
            _startPosX = x;
            _startPosY = y;
            _pictureWidth = width;
            _pictureHeight = height;
        }


        public void MoveTransport(Enumeration enumeration)
        {
            float step = MaxSpeed * 100 / Weight;
            int shipLeftIndent = 1;
            int shipDownIndent = 12;
            switch (enumeration)
            {
                case Enumeration.Right:
                    if (_startPosX + step < _pictureWidth - shipWidth)
                    {
                        _startPosX += step;
                    }
                    break;

                case Enumeration.Left:
                    if (_startPosX - step > shipLeftIndent)
                    {
                        _startPosX -= step;
                    }
                    break;

                case Enumeration.Up:
                    if (_startPosY - step > shipHeight)
                    {
                        _startPosY -= step;
                    }
                    break;

                case Enumeration.Down:
                    if (_startPosY + step < _pictureHeight - shipDownIndent)
                    {
                        _startPosY += step;
                    }
                    break;
            }
        }

        public void DrawTransport(Graphics g)
        {
            Pen pen = new Pen(Color.Black, 10);
            Pen greypen = new Pen(Color.Gray, 10);
            Pen slimpen = new Pen(Color.Black, 6);
            Brush br = new SolidBrush(MainColor);
            Brush brGreen = new SolidBrush(Color.Green);
            Brush brGray = new SolidBrush(Color.Gray);
            Brush brBlue = new SolidBrush(Color.LightBlue);
            Brush brWhite = new SolidBrush(Color.White);

            g.FillRectangle(brGray, _startPosX, _startPosY, 110, 20);
            g.FillEllipse(brGray, _startPosX + 100, _startPosY, 20, 20);
            g.FillEllipse(brGray, _startPosX + -10, _startPosY, 20, 20);

            g.FillRectangle(brGray, _startPosX + 50, _startPosY - 40, 20, 40);
            g.FillRectangle(brWhite, _startPosX + 55, _startPosY - 30, 10, 10);

            g.FillEllipse(br, _startPosX + 0, _startPosY + 18, 30, 15);
            g.FillEllipse(br, _startPosX + 35, _startPosY + 18, 30, 15);
            g.FillEllipse(br, _startPosX + 70, _startPosY + 18, 30, 15);

            g.DrawLine(greypen, _startPosX, _startPosY - 10, _startPosX, _startPosY + 5);
            g.DrawLine(slimpen, _startPosX - 20, _startPosY - 10, _startPosX + 5, _startPosY - 10);

            if (Radar)
            {
                if (Weapon)
                {

                   g.FillRectangle(br, _startPosX + 20, _startPosY - 30, 10, 30);
                    g.FillEllipse(br, _startPosX + 15, _startPosY-40, 20, 20);
                    g.FillEllipse(brWhite, _startPosX + 20, _startPosY - 35, 10, 10);
                    g.DrawLine(slimpen, _startPosX , _startPosY + 10, _startPosX + 115, _startPosY + 10);
                }
                g.FillEllipse(brGray, _startPosX + 90, _startPosY - 15, 25, 25);
                g.DrawLine(pen, _startPosX + 110, _startPosY - 10, _startPosX + 140, _startPosY - 40);
            }
        }
    }
}
