using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsTruck
{
    public class Ship : Vehicle, IEquatable<Ship>
    {
        protected readonly int shipWidth = 112;
        protected readonly int shipHeight = 42; 

        protected readonly char separator = ';';


        public Ship(int maxSpeed, float weight, Color mainColor)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
        }

        public Ship(string info)
        {
            string[] strs = info.Split(separator);
            if (strs.Length == 3)
            {
                MaxSpeed = Convert.ToInt32(strs[0]);
                Weight = Convert.ToInt32(strs[1]);
                MainColor = Color.FromName(strs[2]);
            }
        }
        protected Ship(int maxSpeed, float weight, Color mainColor, int shipWidth, int shipHeight)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
            this.shipWidth = shipWidth;
            this.shipHeight = shipHeight;
        }
        public override void MoveTransport(Enumeration enumeration)
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
        public override void DrawTransport(Graphics g)
        {
            Pen pen = new Pen(Color.Black,10);
            Pen greypen = new Pen(Color.Gray,10);
            Pen slimpen = new Pen(Color.Black,6);
            Brush br = new SolidBrush(MainColor);
            Brush brGreen = new SolidBrush(Color.Green);
            Brush brGray = new SolidBrush(Color.Gray);
            Brush brBlue = new SolidBrush(Color.LightBlue);
            Brush brWhite = new SolidBrush(Color.White);

            g.FillRectangle(br, _startPosX, _startPosY, 110, 20);
            g.FillEllipse(br, _startPosX + 100, _startPosY , 20, 20);
            g.FillEllipse(br, _startPosX + -10, _startPosY, 20, 20);

            g.FillRectangle(br, _startPosX+50, _startPosY-40, 20, 40);
            g.FillRectangle(brWhite, _startPosX + 55, _startPosY - 30, 10, 10);

            g.FillEllipse(brGray, _startPosX + 0, _startPosY+18, 30, 15);
            g.FillEllipse(brGray, _startPosX + 35, _startPosY + 18, 30, 15);
            g.FillEllipse(brGray, _startPosX + 70, _startPosY + 18, 30, 15);

            g.DrawLine(greypen, _startPosX , _startPosY - 10, _startPosX , _startPosY+5 );
            g.DrawLine(slimpen, _startPosX-20 , _startPosY - 10, _startPosX+5 , _startPosY-10 );

        }

        public override string ToString()
        {
            return $"{MaxSpeed}{separator}{Weight}{separator}{MainColor.Name}";
        }

        public bool Equals(Ship other)
        {
            if (other == null)
            {
                return false;
            }
            if (GetType().Name != other.GetType().Name)
            {
                return false;
            }
            if (MaxSpeed != other.MaxSpeed)
            {
                return false;
            }
            if (Weight != other.Weight)
            {
                return false;
            }
            if (MainColor != other.MainColor)
            {
                return false;
            }
            return true;
        }

        public override bool Equals(Object obj)
        {
            if (obj == null)
            {
                return false;
            }
            if (!(obj is Ship planeObj))
            {
                return false;
            }
            else
            {
                return Equals(planeObj);
            }
        }

    }
}
