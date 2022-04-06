using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContainerShip
{
    public class SuperShip : Ship
    {
        /// <summary>
        /// Дополнительный цвет
        /// </summary>
        public Color DopColor { private set; get; }
        /// <summary>
        /// Признак наличия крана
        /// </summary>
        public bool Crane { private set; get; }
        /// <summary>
        /// Признак наличия контейнеров
        /// </summary>
        public bool Container { private set; get; }
        /// <summary>
        /// Конструктор для загрузки с файла
        /// </summary>
        /// <param name="info"></param>
        public SuperShip(string info) : base(info)
        {
            string[] strs = info.Split(_separator);
            if (strs.Length == 6)
            {
                DopColor = Color.FromName(strs[3]);
                Crane = Convert.ToBoolean(strs[4]);
                Container = Convert.ToBoolean(strs[5]);
            }
        }
        /// <summary>
        /// Инициализация свойств
        /// </summary>
        /// <param name="speed">Скорость</param>
        /// <param name="weight">Вес</param>
        /// <param name="bodyColor">Цвет кузова</param>
        /// <param name="dopColor">Дополнительный цвет</param>
        /// <param name="crane">Признак наличия крана</param>
        /// <param name="container">Признак наличия контейнеров</param>
        public SuperShip(int speed, float weight, Color bodyColor, Color dopColor,  bool crane, bool container) :
            base(speed, weight, bodyColor, 100, 60)
        {
            DopColor = dopColor;
            Crane = crane;
            Container = container;
        }
        public void SetDopColor(Color color) => DopColor = color;
        public override void MoveTransport(Direction direction, int leftIndent = 0, int topIndent = 0)
        {
            _makeStep = false;
            if (!_pictureWidth.HasValue || !_pictureHeight.HasValue)
            {
                return;
            }
            switch (direction)
            {
                // вправо
                case Direction.Right:
                    if (_startPosX + _shipWidth + Step < _pictureWidth)
                    {
                        _startPosX += Step;
                        _makeStep = true;
                    }
                    break;
                //влево
                case Direction.Left:
                    if (_startPosX - Step > 0)
                    {
                        _startPosX -= Step;
                        _makeStep = true;
                    }
                    break;
                //вверх
                case Direction.Up:
                    if (_startPosY - Step > 0)
                    {
                        _startPosY -= Step;
                        _makeStep = true;
                    }
                    break;
                //вниз
                case Direction.Down:
                    if (_startPosY + _shipHeight + Step < _pictureHeight)
                    {
                        _startPosY += Step;
                        _makeStep = true;
                    }
                    break;

            }
        }
        public override void DrawTransport(Graphics g)
        {
            if (!_startPosX.HasValue || !_startPosY.HasValue)
            {
                return;
            }
            Pen pen = new(Color.Black);
            Brush br = new SolidBrush(DopColor);
            base.DrawTransport(g);
            if (Crane) {
                g.FillRectangle(br, _startPosX.Value + 64, _startPosY.Value + 13, 15, 5);
                g.FillRectangle(br, _startPosX.Value + 70, _startPosY.Value, 3, 13);
                g.FillRectangle(br, _startPosX.Value + 55, _startPosY.Value + 2, 15, 3);
            }
            if (Container)
            {
                
                g.FillRectangle(br, _startPosX.Value + 38, _startPosY.Value + 11, 4, 7);
                g.FillRectangle(br, _startPosX.Value + 46, _startPosY.Value + 11, 4, 7);
                g.FillRectangle(br, _startPosX.Value + 54, _startPosY.Value + 11, 4, 7);
            }
        }
        public override string ToString() => $"{base.ToString()}{_separator}{DopColor.Name}{_separator}{Crane}{_separator}{Container}";

    }
}
