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
using System;

namespace ContainerShip
{
    public partial class WindowsFormMarina : Form
    {
        /// <summary>
        /// Объект от класса-коллекции пристаней
        /// </summary>
        private readonly MarinaCollection _marinaCollection;
        /// <summary>
        /// Логгер
        /// </summary>
        private readonly Logger logger;

        public WindowsFormMarina()
        {
            InitializeComponent();
            _marinaCollection = new MarinaCollection(pictureBoxMarina.Width, pictureBoxMarina.Height);
            logger = LogManager.GetCurrentClassLogger();
        }
        /// <summary>
        /// Заполнение listBoxLevels
        /// </summary>
        private void ReloadLevels()
        {
            int index = listBoxMarina.SelectedIndex;
            listBoxMarina.Items.Clear();
            for (int i = 0; i < _marinaCollection._keys.Count; i++)
            {
                listBoxMarina.Items.Add(_marinaCollection._keys[i]);
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
        /// Обработка нажатия кнопки "Добавить пристань"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAddMarina_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxMarina.Text))
            {
                MessageBox.Show("Введите название пристани", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                logger.Warn($"Ошибка: не введено название пристани");
                return;
            }
            logger.Info($"Добавили пристань {textBoxMarina.Text}");
            _marinaCollection.AddMarina(textBoxMarina.Text);
            ReloadLevels();
        }
        /// <summary>
        /// Обработка нажатия кнопки "Удалить пристань"
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
                    logger.Info($"Удалили пристань  {listBoxMarina.SelectedItem}");
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
            if (listBoxMarina.SelectedIndex > -1 && maskedTextBoxPlace.Text !="")
            {
                try
                {
                    var ship = _marinaCollection[listBoxMarina.SelectedItem.ToString()] - Convert.ToInt32(maskedTextBoxPlace.Text);
                    if (ship != null)
                    {
                        WindowsFormContainerShip form = new WindowsFormContainerShip();
                        form.SetShip(ship);
                        form.ShowDialog();
                    }
                    logger.Info($"Изъято судно {ship} с места {maskedTextBoxPlace.Text} ");
                    Draw();
                }
                catch (MarinaNotFoundException ex)
                {
                    MessageBox.Show(ex.Message, "Не найдено", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    logger.Warn($"Ошибка: не найдено судно на месте {maskedTextBoxPlace.Text} ");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Неизвестная ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    logger.Warn($"Ошибка: неизвестная ошибка");
                }
            }

        }
        /// <summary>
        /// Метод обработки выбора элемента на listBoxLevels
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBoxMarina_SelectedIndexChanged(object sender, EventArgs e)
        {
            Draw();
            logger.Info($"Перешли на парковку {listBoxMarina.SelectedItem}");
        }

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
        /// Метод добавления судна
        /// </summary>
        /// <param name="car"></param>
        private void AddShip(ITransport ship)
        {
            if (ship != null && listBoxMarina.SelectedIndex > -1)
            {
                try
                {
                    if
                    (_marinaCollection[listBoxMarina.SelectedItem.ToString()] + ship)
                    {
                        Draw();
                        logger.Info($"Добавлено судно {ship}");
                    }
                    else
                    {
                        MessageBox.Show("Судно не удалось поставить");
                        logger.Warn($"Ошибка: судно не удалось поставить");
                    }
                    Draw();
                }
                catch (MarinaOverflowException ex)
                {
                    MessageBox.Show(ex.Message, "Переполнение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    logger.Warn($"Ошибка: пристань переполнена");
                }
                catch (MarinaAlreadyHaveException ex)
                {
                    MessageBox.Show(ex.Message, "Дублирование", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    logger.Warn($"Ошибка: такое судно уже есть на пристани");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Неизвестная ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    logger.Warn($"Ошибка: неизвестная ошибка");
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
                try
                {
                    _marinaCollection.SaveData(saveFileDialog.FileName);
                    MessageBox.Show("Сохранение прошло успешно",
                    "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    logger.Info("Сохранено в файл " + saveFileDialog.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.GetType().Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    MessageBox.Show("Не сохранилось", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    logger.Warn($"Ошибка: не удалось сохранить");
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
                try
                {
                    _marinaCollection.LoadData(openFileDialog.FileName);
                    MessageBox.Show("Загрузили", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    logger.Info("Загружено из файла " + openFileDialog.FileName);
                    ReloadLevels();
                    Draw();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.GetType().Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    MessageBox.Show("Не загрузили", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    logger.Warn($"Ошибка: не удалось загрузить");
                }
            }

        }

        private void buttonSort_Click(object sender, EventArgs e)
        {
            if (listBoxMarina.SelectedIndex > -1)
            {
                _marinaCollection[listBoxMarina.SelectedItem.ToString()].Sort();
                Draw();
                logger.Info("Сортировка уровней");
            }

        }
    }
}
