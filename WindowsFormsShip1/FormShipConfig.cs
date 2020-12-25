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
    public partial class FormShipConfig : Form
    {
        Vehicle ship = null;

        private event Action<Vehicle> eventAddShip;

        public FormShipConfig()
        {
            InitializeComponent();
            foreach (var item in groupBoxColors.Controls)
            {
                if (item is Panel)
                {
                    ((Panel)item).MouseDown += panelColor_MouseDown;
                }
            }
            buttonCancel.Click += (object sender, EventArgs e) => { Close(); };
        }

        private void DrawShip()
        {
            if (ship != null)
            {
                Bitmap bmp = new Bitmap(pictureBoxShip.Width, pictureBoxShip.Height);
                Graphics gr = Graphics.FromImage(bmp);
                ship.SetPosition(100, 100, pictureBoxShip.Width, pictureBoxShip.Height);
                ship.DrawTransport(gr);
                pictureBoxShip.Image = bmp;
            }
        }

        public void AddEvent(Action<Vehicle> ev)
        {
            if (eventAddShip == null)
            {
                eventAddShip = new Action<Vehicle>(ev);
            }
            else
            {
                eventAddShip += ev;
            }
        }

      
        private void labelShip_MouseDown(object sender, MouseEventArgs e)
        {

            labelShip.DoDragDrop(labelShip.Text, DragDropEffects.Move | DragDropEffects.Copy);
        }
       
        private void labelWarShip_MouseDown(object sender, MouseEventArgs e)
        {
            labelWarShip.DoDragDrop(labelWarShip.Text, DragDropEffects.Move | DragDropEffects.Copy);
        }
      
        private void panelShip_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }
        
        private void panelShip_DragDrop(object sender, DragEventArgs e)
        {
            switch (e.Data.GetData(DataFormats.Text).ToString())
            {
                case "Военный корабль":
                    ship = new Ship((int)numericUpDownMaxSpeed.Value, (int)numericUpDownWeight.Value, Color.White);
                    break;
                case "Крейсер":
                    ship = new WarShip((int)numericUpDownMaxSpeed.Value, (int)numericUpDownWeight.Value, Color.White, Color.Black, checkBoxWeapon.Checked, checkBoxRadar.Checked);
                    break;
            }
            DrawShip();
        }

        private void panelColor_MouseDown(object sender, MouseEventArgs e)
        {
            ((Panel)sender).DoDragDrop(((Panel)sender).BackColor, DragDropEffects.Move | DragDropEffects.Copy);
        }

        private void labelColor_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(Color)))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }
        private void labelMainColor_DragDrop(object sender, DragEventArgs e)
        {
            ship?.SetMainColor((Color)(e.Data.GetData(typeof(Color))));
            DrawShip();
        }

        private void labelDopColor_DragDrop(object sender, DragEventArgs e)
        {
            if (ship is WarShip)
            {
                WarShip thisShip = (WarShip)ship;
                thisShip.SetDopColor((Color)(e.Data.GetData(typeof(Color))));
                ship = thisShip;
                DrawShip();
            }
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            eventAddShip?.Invoke(ship);
            Close();
        }

        private void FormShipConfig_Load(object sender, EventArgs e)
        {

        }

        private void labelMainColor_Click(object sender, EventArgs e)
        {

        }
    }
}
