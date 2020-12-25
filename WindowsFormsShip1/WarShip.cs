using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsTruck
{
    class WarShip : Ship
    {
        public Color DopColor { private set; get; }

        public bool Radar { private set; get; }

        public bool Weapon { private set; get; }

        public WarShip(int maxSpeed, float weight, Color mainColor, Color dopColor, bool radar, bool weapon) : base(maxSpeed, weight, mainColor, 112, 42)
        {
            MaxSpeed = maxSpeed;
            Weight = weight; //
            MainColor = mainColor;  
            DopColor = dopColor;
            Radar = radar; 
            Weapon = weapon; 
        }

        public WarShip(string info) : base(info)
        {
            string[] strs = info.Split(separator);
            if (strs.Length == 6)
            {
                MaxSpeed = Convert.ToInt32(strs[0]);
                Weight = Convert.ToInt32(strs[1]);
                MainColor = Color.FromName(strs[2]);
                DopColor = Color.FromName(strs[3]);
                Radar = Convert.ToBoolean(strs[4]);
                Weapon = Convert.ToBoolean(strs[5]);
            }
        }

        public override void DrawTransport(Graphics g)
        {
            Pen pen = new Pen(Color.Black,10);
            Pen greypen = new Pen(Color.Gray,10);
            Pen slimpen = new Pen(Color.Black,6);
            Brush br = new SolidBrush(MainColor);
            Brush brDop = new SolidBrush(DopColor);
            Brush brGray = new SolidBrush(Color.Gray);
            Brush brBlue = new SolidBrush(Color.LightBlue);
            Brush brWhite = new SolidBrush(Color.White);

            base.DrawTransport(g);

            if (Radar)
            {
                g.FillEllipse(brDop, _startPosX + 90, _startPosY - 15, 25, 25);
                g.DrawLine(pen, _startPosX + 110, _startPosY - 10, _startPosX + 140, _startPosY - 40);
            }
            if (Weapon)
            {
                g.FillRectangle(br, _startPosX + 20, _startPosY - 30, 10, 30);
                g.FillEllipse(br, _startPosX + 15, _startPosY - 40, 20, 20);
                g.FillEllipse(brWhite, _startPosX + 20, _startPosY - 35, 10, 10);
                g.DrawLine(slimpen, _startPosX, _startPosY + 10, _startPosX + 115, _startPosY + 10);
            }
        }
            public void SetDopColor(Color color)
            {
                DopColor = color;
            }
        public override string ToString()
        {
            return
           $"{base.ToString()}{separator}{DopColor.Name}{separator}{Radar}{separator}{Weapon}";
        }

        }
    }
