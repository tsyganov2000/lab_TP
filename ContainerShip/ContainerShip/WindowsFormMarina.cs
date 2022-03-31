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
        /// Объект от класса-парковки
        /// </summary>
        private readonly Marina<IDrawObject> marina;
        public WindowsFormMarina()
        {
            InitializeComponent();
            marina = new Marina<IDrawObject>(pictureBoxMarina.Width, pictureBoxMarina.Height);
            Draw();
        }
        /// <summary>
        /// Метод отрисовки парковки
        /// </summary>
        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBoxMarina.Width, pictureBoxMarina.Height);
            Graphics gr = Graphics.FromImage(bmp);
            marina.Draw(gr);
            pictureBoxMarina.Image = bmp;
        }
        /// <summary>
        /// Обработка нажатия кнопки "Пришвартовать корабль"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAddShip_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                AddToMarina(new Ship(100, 1000, dialog.Color));
            }
        }
        /// <summary>
        /// Обработка нажатия кнопки "Пришвартовать контейнеровоз"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAddSuperShip_Click(object sender, EventArgs e)
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
        /// <summary>
        /// Обработка нажатия кнопки "Забрать"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonPickUp_Click(object sender, EventArgs e)
        {
            if (maskedTextBoxPlace.Text != "")
            {
                var ship = marina - Convert.ToInt32(maskedTextBoxPlace.Text);
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
        /// Добавление объекта в класс-хранилище
        /// </summary>
        /// <param name="car"></param>
        private void AddToMarina(Ship ship)
        {
            if (marina + ship)
            {
                Draw();
            }
            else
            {
                MessageBox.Show("Пристань переполнена");
            }
        }
    }
}
