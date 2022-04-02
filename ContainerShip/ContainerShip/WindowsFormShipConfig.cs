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
    public partial class WindowsFormShipConfig : Form
    {
        /// <summary>
        /// Переменная-выбранный корабль
        /// </summary>
        ITransport _ship = null;
        /// <summary>
        /// Событие
        /// </summary>
        private event ShipDelegate EventAddShip;
        public WindowsFormShipConfig()
        {
            InitializeComponent();
            panelBlack.MouseDown += PanelColor_MouseDown;
            panelOrange.MouseDown += PanelColor_MouseDown;
            panelGray.MouseDown += PanelColor_MouseDown;
            panelGreen.MouseDown += PanelColor_MouseDown;
            panelRed.MouseDown += PanelColor_MouseDown;
            panelWhite.MouseDown += PanelColor_MouseDown;
            panelYellow.MouseDown += PanelColor_MouseDown;
            panelBlue.MouseDown += PanelColor_MouseDown;
            buttonCancel.Click += (object sender, EventArgs e) => { Close(); };

        }
        /// <summary>
        /// Отрисовать корабль
        /// </summary>
        private void DrawShip()
        {
            if (_ship != null)
            {
                Bitmap bmp = new Bitmap(pictureBoxShipConfig.Width, pictureBoxShipConfig.Height);
                Graphics gr = Graphics.FromImage(bmp);
                _ship.SetObject(5, 5, pictureBoxShipConfig.Width, pictureBoxShipConfig.Height);
                _ship.DrawTransport(gr);
                pictureBoxShipConfig.Image = bmp;
            }
        }
        /// <summary>
        /// Добавление события
        /// </summary>
        /// <param name="ev"></param>
        public void AddEvent(ShipDelegate ev)
        {
            if (EventAddShip == null)
            {
                EventAddShip = new ShipDelegate(ev);
            }
            else
            {
                EventAddShip += ev;
            }
        }
        /// <summary>
        /// Передаем информацию при нажатии на Label
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LabelObject_MouseDown(object sender, MouseEventArgs e)
        {
            (sender as Label).DoDragDrop((sender as Label).Name, DragDropEffects.Move | DragDropEffects.Copy);
        }
        /// Проверка получаемой информации (ее типа на соответствие требуемому)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PanelShipConfig_DragEnter(object sender, DragEventArgs e)
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
        /// <summary>
        /// Действия при приеме перетаскиваемой информации
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PanelShipConfig_DragDrop(object sender, DragEventArgs e)
        {
            switch (e.Data.GetData(DataFormats.Text).ToString())
            {
                case "labelShip":
                    _ship = new Ship((int)numericUpDownSpeed.Value, (int)numericUpDownWeight.Value, Color.Gray);
                    break;
                case "labelSuperShip":
                    _ship = new  SuperShip((int)numericUpDownSpeed.Value, (int)numericUpDownWeight.Value, Color.Gray,
                        Color.Black, checkBoxCran.Checked, checkBoxContainers.Checked);
                    break;
            }
            DrawShip();
        }
        /// <summary>
        /// Отправляем цвет с панели
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PanelColor_MouseDown(object sender, MouseEventArgs e)
        {
            (sender as Control).DoDragDrop((sender as Control).BackColor,  DragDropEffects.Move | DragDropEffects.Copy);
        }
        /// <summary>
        /// Проверка получаемой информации (ее типа на соответствие требуемому)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LabelMainColor_DragEnter(object sender, DragEventArgs e)
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
        /// <summary>
        /// Принимаем основной цвет
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LabelMainColor_DragDrop(object sender, DragEventArgs e)
        {
            if (_ship != null)
            {
                _ship.SetMainColor((Color)e.Data.GetData(typeof(Color)));
                DrawShip();
            }
        }
        /// <summary>
        /// Принимаем дополнительный цвет
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LabelDopColor_DragDrop(object sender, DragEventArgs e)
        {
            if (_ship != null)
            {
                if (_ship is SuperShip)
                {
                    (_ship as SuperShip).SetDopColor((Color)e.Data.GetData(typeof(Color)));
                    DrawShip();
                }
            }
        }
        /// <summary>
        /// Добавление машины
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            EventAddShip?.Invoke(_ship);
            Close();
        }


    }
}
