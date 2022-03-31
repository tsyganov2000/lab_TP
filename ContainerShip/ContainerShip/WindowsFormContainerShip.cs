

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
        /// ����� ��������� ������� �� �����
        /// </summary>
        /// <param name="rnd"></param>
        private void SetObject(Random rnd)
        {
            _ship?.SetObject(rnd.Next(10, 100), rnd.Next(10, 100),
            pictureBox.Width, pictureBox.Height);
            toolStripStatusLabelSpeed.Text = "��������:" + _ship?.Speed;
            toolStripStatusLabelWeight.Text = "���: " + _ship?.Weight;
            toolStripStatusLabelColor.Text = "����: " + _ship?.BodyColor.Name;
            Draw();
        }
        /// <summary>
        /// ���������� �����
        /// </summary>
        /// <param name="testObject"></param>
        private void RunTest(AbstractTestObject testObject)
        {
            if (testObject == null || _ship == null)
            {
                return;
            }
            var position = _ship.GetCurrentPosition();
            testObject.Init(_ship);
            testObject.SetPosition(pictureBox.Width,
            pictureBox.Height);
            MessageBox.Show(testObject.TestObject());
            _ship.SetObject(position.Left, position.Top, pictureBox.Width, pictureBox.Height);
        }
        /// <summary>
        /// ��������� �������� ����� ���������
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PictureBox_Resize(object sender, EventArgs e)
        {
            _ship?.ChangeBorders(pictureBox.Width, pictureBox.Height);
            Draw();
        }

        /// <summary>
        /// ��������� ������� ������ "�������"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCreate_Click(object sender, EventArgs e)
        {
            Random rnd = new();
            _ship = new Ship(rnd.Next(100, 300), rnd.Next(1000, 2000),
                Color.FromArgb(rnd.Next(0, 256), rnd.Next(0, 256), rnd.Next(0, 256)));
            SetObject(rnd);

        }
        /// <summary>
        /// ��������� ������� ������ "�����������"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonCreateModify_Click(object sender, EventArgs e)
        {
            Random rnd = new();
            _ship = new SuperShip(rnd.Next(100, 300), rnd.Next(1000, 2000), Color.FromArgb(rnd.Next(0, 256), rnd.Next(0, 256),
                rnd.Next(0, 256)), Color.FromArgb(rnd.Next(0, 256), rnd.Next(0, 256), rnd.Next(0, 256)), true, true);
            SetObject(rnd);
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
        /// <summary>
        /// ��������� ������� ������ "�������� ���� �� ��������"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonRunBorderTest_Click(object sender, EventArgs e)
        {
            switch (comboBoxTesting.SelectedIndex)
            {
                case 0:
                    RunTest(new BordersTestObject());
                    break;
            }
        }

    }
}