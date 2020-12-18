using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsTruck
{
    public partial class FormShip : Form
    {

        private WarShip ship;

        public FormShip()
        {
            InitializeComponent();
        }

        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBoxShip.Width, pictureBoxShip.Height);
            Graphics gr = Graphics.FromImage(bmp);
            ship.DrawTransport(gr);
            pictureBoxShip.Image = bmp;
        }

        private void buttonCreateWarShip_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            ship = new WarShip(rnd.Next(100, 300), rnd.Next(1000, 3000), Color.Black, Color.Orange, true, true);
            ship.SetPosition(rnd.Next(10, 60), rnd.Next(100, 400), pictureBoxShip.Width, pictureBoxShip.Height);
            Draw();
        }


        private void buttonMove_Click(object sender, EventArgs e)
        {
            string name = (sender as Button).Name;
            switch (name)
            {
                case "buttonUp":
                    ship.MoveTransport(Enumeration.Up);
                    break;
                case "buttonDown":
                    ship.MoveTransport(Enumeration.Down);
                    break;
                case "buttonLeft":
                    ship.MoveTransport(Enumeration.Left);
                    break;
                case "buttonRight":
                    ship.MoveTransport(Enumeration.Right);
                    break;
            }
            Draw();
        }

        private void FormShip_Load(object sender, EventArgs e)
        {

        }

    }
}
