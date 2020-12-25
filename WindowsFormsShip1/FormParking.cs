using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NLog;

namespace WindowsFormsTruck
{
    public partial class FormParking : Form
    {
        private readonly Logger logger;

        private readonly ParkingCollection parkingCollection;

        public FormParking()
        {
            InitializeComponent();
            parkingCollection = new ParkingCollection(pictureBoxParking.Width,pictureBoxParking.Height);
            logger = LogManager.GetCurrentClassLogger();
            Draw();
        }
        
        private void ReloadLevels()
        {
            int index = listBoxParkings.SelectedIndex;
            listBoxParkings.Items.Clear();
            for (int i = 0; i < parkingCollection.Keys.Count; i++)
            {
            listBoxParkings.Items.Add(parkingCollection.Keys[i]);
            }
            if (listBoxParkings.Items.Count > 0 && (index == -1 || index >=listBoxParkings.Items.Count))
            {
                listBoxParkings.SelectedIndex = 0;
            }
            else if (listBoxParkings.Items.Count > 0 && index > -1 && index <listBoxParkings.Items.Count)
            {
                listBoxParkings.SelectedIndex = index;
            }
        }

        private void Draw()
        {
            if (listBoxParkings.SelectedIndex > -1)
            {
                Bitmap bmp = new Bitmap(pictureBoxParking.Width, pictureBoxParking.Height);
                Graphics gr = Graphics.FromImage(bmp);
                parkingCollection[listBoxParkings.SelectedItem.ToString()].Draw(gr);
                pictureBoxParking.Image = bmp;
            }
        }

        private void buttonAddParking_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxNewLevelName.Text))
            {
                MessageBox.Show("Введите название парковки", "Ошибка",MessageBoxButtons.OK, MessageBoxIcon.Error);
                logger.Warn($"Ошибка при добавлении парковки: название было пустым");
                return;
            }
            logger.Info($"Добавили парковку {textBoxNewLevelName.Text}");
            parkingCollection.AddParking(textBoxNewLevelName.Text);
            ReloadLevels();
        }

        private void buttonDelParking_Click(object sender, EventArgs e)
        {
            if (listBoxParkings.SelectedIndex > -1)
            {
                if (MessageBox.Show($"Удалить парковку { listBoxParkings.SelectedItem.ToString()}?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    logger.Info($"Удалили пристань {textBoxNewLevelName.Text}");
                    parkingCollection.DelParking(textBoxNewLevelName.Text);
                    ReloadLevels();
                }
            }
        }


        private void buttonTakeShip_Click(object sender, EventArgs e)
        {
            if (listBoxParkings.SelectedIndex > -1 && maskedTextBox.Text != "")
            {
                try
                {
                    var ship = parkingCollection[listBoxParkings.SelectedItem.ToString()] - Convert.ToInt32(maskedTextBox.Text);
                    if (ship != null)
                    {
                        FormShip form = new FormShip();
                        form.SetShip(ship);
                        form.ShowDialog();
                        logger.Info($"Изъят корабль {ship} с места {textBoxNewLevelName.Text}");
                    }
                    Draw();
                }
                catch (ParkingShipNotFoundException ex)
                {
                    MessageBox.Show(ex.Message, "Корабль не найден", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    logger.Warn($"Ошибка при заборе корабля с парковки: корабль не найден");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Неизвестная ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    logger.Warn($"Неизвестная ошибка при заборе корабля с парковки");
                }
            }
        }


        private void listBoxParkings_SelectedIndexChanged(object sender, EventArgs e)
        {
            logger.Info($"Перешли на парковку {listBoxParkings.SelectedItem.ToString()}");
            Draw();
        }

        private void buttonShip_Click(object sender, EventArgs e)
        {
            var formShipConfig = new FormShipConfig();
            formShipConfig.AddEvent(AddShip);
            formShipConfig.Show();
        }

        private void AddShip(Vehicle ship)
        {
            if (ship != null && listBoxParkings.SelectedIndex > -1)
            {
                try
                {

                    if ((parkingCollection[listBoxParkings.SelectedItem.ToString()]) + ship)
                    {
                        Draw();
                        logger.Info($"Добавлен корабль {ship}");
                    }
                    else
                    {
                        MessageBox.Show("Не удалось припарковать корабль, парковка переполнена");
                        logger.Warn($"Не удалось припарковать корабль, парковка переполнена");
                    }
                }
                catch (ParkingOverflowException ex)
                {
                    MessageBox.Show(ex.Message, "Переполнение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    logger.Warn($"Ошибка при добавлении корабля на парковку: парковка переполнена");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Неизвестная ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    logger.Warn($"Неизвестная ошибка при добавлении корабля на парковку");
                }
            }
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (parkingCollection.SaveData(saveFileDialog.FileName))
                {
                    MessageBox.Show("Сохранение прошло успешно", "Результат",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    logger.Info("Сохранено в файл " + saveFileDialog.FileName);
                }
                else
                {
                    MessageBox.Show("Не сохранилось", "Результат",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    logger.Warn($"Неизвестная ошибка при сохранении");
                }
            }
        }

        private void загрузитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if (parkingCollection.LoadData(openFileDialog.FileName))
                    {
                        MessageBox.Show("Загрузили", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        logger.Info("Загружено из файла " + openFileDialog.FileName);
                        ReloadLevels();
                        Draw();
                    }
                }
                catch (ParkingShipCannotBeAddedException ex)
                {
                    MessageBox.Show(ex.Message, "Невозможно добавить корабля на парковку при загрузке", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    logger.Warn($"Ошибка при загрузке из файла: невозможно добавить корабля на причал");
                }
                catch (FileFormatException ex)
                {
                    MessageBox.Show(ex.Message, "Неверный формат файла при загрузке", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    logger.Warn($"Ошибка при загрузке из файла: неверный формат файла");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Неизвестная ошибка при загрузке", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    logger.Warn($"Неизвестная ошибка при загрузке из файла");
                }
            }
        }

        private void FormParking_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        
    }
}
