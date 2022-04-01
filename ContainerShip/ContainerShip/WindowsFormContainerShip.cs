

namespace ContainerShip
{
    public partial class WindowsFormContainerShip : Form
    {
        private IDrawObject _ship;
        public WindowsFormContainerShip()
        {
            InitializeComponent();
        }
        /// <summary>
        /// �������� ������ �� �����
        /// </summary>
        /// <param name="car"></param>
        public void SetShip(IDrawObject ship)
        {
            _ship = ship;
            Draw();
        }
        /// <summary>
        /// ����� ���������
        /// </summary>
        private void Draw()
        {
            Bitmap bmp = new(pictureBox.Width, pictureBox.Height);
            Graphics gr = Graphics.FromImage(bmp);
            _ship?.DrawTransport(gr);
            pictureBox.Image = bmp;
        }
        /// <summary>
        /// ��������� ������� ������ ����������
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonMove_Click(object sender, EventArgs e)
        {
            //�������� ��� ������
            string name = (sender as Button).Name;
            switch (name)
            {
                case "buttonUp":
                    _ship?.MoveObject(Direction.Up);
                    break;
                case "buttonDown":
                    _ship?.MoveObject(Direction.Down);
                    break;
                case "buttonLeft":
                    _ship?.MoveObject(Direction.Left);
                    break;
                case "buttonRight":
                    _ship?.MoveObject(Direction.Right);
                    break;
            }
            Draw();
        }
    }
}