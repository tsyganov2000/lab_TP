using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContainerShip
{
    public partial class WindowsFormMarina : Form
    {
        /// <summary>
        /// Объект от класса-коллекции пристаней
        /// </summary>
        private MarinaCollection _marinaCollection;
        public WindowsFormMarina()
        {
            InitializeComponent();
            _marinaCollection = new MarinaCollection(pictureBoxMarina.Width, pictureBoxMarina.Height);
        }
        /// <summary>
        /// Заполнение listBoxLevels
        /// </summary>
        private void ReloadLevels()
        {
            int index = listBoxMarina.SelectedIndex;
            listBoxMarina.Items.Clear();
            for (int i = 0; i < _marinaCollection.Keys.Count; i++)
            {
                listBoxMarina.Items.Add(_marinaCollection.Keys[i]);
            }
            if (listBoxMarina.Items.Count > 0 && (index == -1 || index >=
            listBoxMarina.Items.Count))
            {
                listBoxMarina.SelectedIndex = 0;
            }
            else if (listBoxMarina.Items.Count > 0 && index > -1 && index <
            listBoxMarina.Items.Count)
            {
                listBoxMarina.SelectedIndex = index;
            }
        }
        /// <summary>
        /// Метод отрисовки парковки
        /// </summary>
        private void Draw()
        {
            if (listBoxMarina.SelectedIndex > -1)
            {//если выбран один из пуктов в listBox (при старте программы ни один пункт не будет выбран
             //и может возникнуть ошибка, если мы попытаемся обратиться к элементу listBox)
                Bitmap bmp = new Bitmap(pictureBoxMarina.Width, pictureBoxMarina.Height);
                Graphics gr = Graphics.FromImage(bmp);
                _marinaCollection[listBoxMarina.SelectedItem.ToString()].Draw(gr);
                pictureBoxMarina.Image = bmp;
            }

        }
        /// <summary>
        /// Обработка нажатия кнопки "Добавить парковку"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAddMarina_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxMarina.Text))
            {
                MessageBox.Show("Введите название пристани", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _marinaCollection.AddMarina(textBoxMarina.Text);
            ReloadLevels();
        }
        /// <summary>
        /// Обработка нажатия кнопки "Удалить парковку"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDelMarina_Click(object sender, EventArgs e)
        {
            if (listBoxMarina.SelectedIndex > -1)
            {
                if (MessageBox.Show($"Удалить пристань  { listBoxMarina.SelectedItem}?",
                    "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    _marinaCollection.DelMarina(listBoxMarina.SelectedItem.ToString());
                    ReloadLevels();
                }
            }
        }
        
        /// <summary>
        /// Обработка нажатия кнопки "Забрать"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonPickUp_Click(object sender, EventArgs e)
        {
            if (listBoxMarina.SelectedIndex > -1 && maskedTextBoxPlace.Text != "")
            {
                var ship = _marinaCollection[listBoxMarina.SelectedItem.ToString()] - Convert.ToInt32(maskedTextBoxPlace.Text);
                if (ship != null)
                {
                    WindowsFormContainerShip form = new WindowsFormContainerShip();
                    form.SetShip(ship);
                    form.ShowDialog();
                }
                Draw();
            }

        }
        /// <summary>
        /// Метод обработки выбора элемента на listBoxLevels
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBoxMarina_SelectedIndexChanged(object sender, EventArgs e) => Draw();

        /// <summary>
        /// Обработка нажатия кнопки "Добавить судно"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonAddShip_Click(object sender, EventArgs e)
        {
            var windowsFormShipConfig = new WindowsFormShipConfig();
            windowsFormShipConfig.AddEvent(AddShip);
            windowsFormShipConfig.Show();
        }
        /// <summary>
        /// Метод добавления машины
        /// </summary>
        /// <param name="car"></param>
        private void AddShip(ITransport ship)
        {
            if (ship != null && listBoxMarina.SelectedIndex > -1)
            {
                if
                ((_marinaCollection[listBoxMarina.SelectedItem.ToString()]) + ship)
                {
                    Draw();
                }
                else
                {
                    MessageBox.Show("Судно не удалось поставить");
                }
            }
        }
        /// <summary>
        /// Обработка нажатия пункта меню "Сохранить"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (_marinaCollection.SaveData(saveFileDialog.FileName))
                {
                    MessageBox.Show("Сохранение прошло успешно", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Не сохранилось", "Результат",  MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
        /// <summary>
        /// Обработка нажатия пункта меню "Загрузить"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void загрузитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (_marinaCollection.LoadData(openFileDialog.FileName))
                {
                    MessageBox.Show("Загрузили", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ReloadLevels();
                    Draw();
                }
                else
                {
                    MessageBox.Show("Не загрузили", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
    }
}
