using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContainerShip
{
    public class Ship : IDrawObject
    {
        /// <summary>
        /// Скорость
        /// </summary>
        public int Speed { private set; get; }
        /// <summary>
        /// Вес
        /// </summary>
        public float Weight { private set; get; }
        /// <summary>
        /// Цвет
        /// </summary>
        public Color BodyColor { private set; get; }
        public float Step => Speed * 100 / Weight;
        /// <summary>
        /// Левая координата отрисовки 
        /// </summary>
        protected float? _startPosX = null;
        /// <summary>
        /// Верхняя кооридната отрисовки 
        /// </summary>
        protected float? _startPosY = null;
        /// <summary>
        /// Ширина окна отрисовки
        /// </summary>
        protected int? _pictureWidth = null;
        /// <summary>
        /// Высота окна отрисовки
        /// </summary>
        protected int? _pictureHeight = null;
        /// <summary>
        /// Ширина отрисовки 
        /// </summary>
        protected readonly int _shipWidth = 80;
        /// <summary>
        /// Высота отрисовки 
        /// </summary>
        protected readonly int _shipHeight = 50;
        /// <summary>
        /// Признак, что объект переместился
        /// </summary>
        protected bool _makeStep;
        /// <summary>
        /// Инициализация свойств
        /// </summary>
        /// <param name="speed">Скорость</param>
        /// <param name="weight">Веc</param>
        /// <param name="bodyColor">Цвет</param>
        public Ship(int speed, float weight, Color bodyColor)
        {
            Speed = speed;
            Weight = weight;
            BodyColor = bodyColor;
        }
        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="speed">Скорость</param>
        /// <param name="weight">Вес </param>
        /// <param name="bodyColor">Цвет</param>
        /// <param name="shipWidth">Ширина объекта</param>
        /// <param name="shipHeight">Высота объекта</param>
        protected Ship(int speed, float weight, Color bodyColor, int shipWidth, int shipHeight)
        {
            Speed = speed;
            Weight = weight;
            BodyColor = bodyColor;
            _shipWidth = shipWidth;
            _shipHeight = shipHeight;
        }
        public void SetObject(float x, float y, int width, int height)
        {
            _startPosX = x;
            _startPosY = y;
            _pictureWidth = width;
            _pictureHeight = height;
        }
        /// <summary>
        /// Смена границ формы отрисовки
        /// </summary>
        /// <param name="width">Ширина картинки</param>
        /// <param name="height">Высота картинки</param>
        public void ChangeBorders(int width, int height)
        {
            _pictureWidth = width;
            _pictureHeight = height;
            if (_startPosX + _shipWidth > width)
            {
                _startPosX = width - _shipWidth;
            }
            if (_startPosY + _shipHeight > height)
            {
                _startPosY = height - _shipHeight;
            }
        }
        /// <summary>
        /// Изменение направления пермещения
        /// </summary>
        /// <param name="direction">Направление</param>
        /// <param name="leftIndent">Отступ от левого края,чтобы объект не выходил за границы</param>
        /// <param name="topIndent">Отступ от верхнего края,чтобы объект не выходил за границы</param>
        public virtual void MoveTransport(Direction direction, int leftIndent = 0, int topIndent = 0)
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
        /// <summary>
        /// Отрисовка
        /// </summary>
        /// <param name="g"></param>
        public virtual void DrawTransport(Graphics g)
        {
            if (!_startPosX.HasValue || !_startPosY.HasValue)
            {
                return;
            }
            Pen pen = new(Color.Black);
            Brush br = new SolidBrush(BodyColor);
            g.FillRectangle(br, _startPosX.Value, _startPosY.Value + 18, 85, 5);
            g.FillRectangle(br, _startPosX.Value + 4, _startPosY.Value + 21, 72, 6);
            g.FillRectangle(br, _startPosX.Value + 10, _startPosY.Value + 21, 57, 9);
            g.FillRectangle(br, _startPosX.Value + 17, _startPosY.Value + 21, 42, 13);
            g.FillRectangle(br, _startPosX.Value + 10, _startPosY.Value + 6, 25, 14);
        }
        public bool MoveObject(Direction direction)
        {
            MoveTransport(direction);
            return _makeStep;
        }
        public void DrawObject(Graphics g)
        {
            DrawTransport(g);
        }
        public (float Left, float Right, float Top, float Bottom) GetCurrentPosition()
        {
            return (_startPosX.Value, _startPosX.Value + _shipWidth, _startPosY.Value, _startPosY.Value + _shipHeight);
        }
    }
}
