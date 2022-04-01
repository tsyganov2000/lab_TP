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
                MessageBox.Show("Введите название парковки", "Ошибка",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        /// Обработка нажатия кнопки "Пришвартовать корабль"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAddShip_Click(object sender, EventArgs e)
        {
            if (listBoxMarina.SelectedIndex > -1)
            {
                ColorDialog dialog = new ColorDialog();
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    AddToMarina(new Ship(100, 1000, dialog.Color));
                }
            }
        }
        /// <summary>
        /// Обработка нажатия кнопки "Пришвартовать контейнеровоз"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAddSuperShip_Click(object sender, EventArgs e)
        {
            if (listBoxMarina.SelectedIndex > -1)
            {
                ColorDialog dialog = new ColorDialog();
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    ColorDialog dialogDop = new ColorDialog();
                    if (dialogDop.ShowDialog() == DialogResult.OK)
                    {
                        AddToMarina(new SuperShip(100, 1000, dialog.Color, dialogDop.Color, true, true));
                    }
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
        /// Добавление объекта в класс-хранилище
        /// </summary>
        /// <param name="car"></param>
        private void AddToMarina(Ship ship)
        {
            if (listBoxMarina.SelectedIndex > -1)
            {
                if (_marinaCollection[listBoxMarina.SelectedItem.ToString()] + ship)
                {
                    Draw();
                }
                else
                {
                    MessageBox.Show("Парковка переполнена");
                }
            }

        }

    }
}
