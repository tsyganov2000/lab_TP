

namespace ContainerShip
{
    public partial class WindowsFormContainerShip : Form
    {
        private Ship _ship;
        public WindowsFormContainerShip()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Метод отрисовки
        /// </summary>
        private void Draw()
        {
            Bitmap bmp = new(pictureBox.Width, pictureBox.Height);
            Graphics gr = Graphics.FromImage(bmp);
            _ship?.DrawTransport(gr);
            pictureBox.Image = bmp;
        }
        /// <summary>
        /// Изменение размеров формы отрисовки
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PictureBox_Resize(object sender, EventArgs e)
        {
            _ship?.ChangeBorders(pictureBox.Width, pictureBox.Height);
            Draw();
        }
        /// <summary>
        /// Обработка нажатия кнопки "Создать"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCreate_Click(object sender, EventArgs e)
        {
            Random rnd = new();
            _ship = new Ship();
            _ship.Init(rnd.Next(100, 300), rnd.Next(1000, 2000),
            Color.FromArgb(rnd.Next(0, 256), rnd.Next(0, 256), rnd.Next(0, 256)));
            _ship.SetPosition(rnd.Next(10, 100), rnd.Next(10, 100), pictureBox.Width, pictureBox.Height);
            toolStripStatusLabelSpeed.Text = "Скорость:" + _ship.Speed;
            toolStripStatusLabelWeight.Text = "Вес: " + _ship.Weight;
            toolStripStatusLabelColor.Text = "Цвет: " + _ship.BodyColor.Name;
            Draw();
        }
        /// <summary>
        /// Обработка нажатия кнопок управления
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonMove_Click(object sender, EventArgs e)
        {
            //получаем имя кнопки
            string name = (sender as Button).Name;
            switch (name)
            {
                case "buttonUp":
                    _ship?.MoveTransport(Direction.Up);
                    break;
                case "buttonDown":
                    _ship?.MoveTransport(Direction.Down);
                    break;
                case "buttonLeft":
                    _ship?.MoveTransport(Direction.Left);
                    break;
                case "buttonRight":
                    _ship?.MoveTransport(Direction.Right);
                    break;
            }
            Draw();
        }
    }   
}