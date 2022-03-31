using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContainerShip
{
    public class Ship
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
        /// <summary>
        /// Левая координата отрисовки 
        /// </summary>
        private float? _startPosX = null;
        /// <summary>
        /// Верхняя кооридната отрисовки 
        /// </summary>
        private float? _startPosY = null;
        /// <summary>
        /// Ширина окна отрисовки
        /// </summary>
        private int? _pictureWidth = null;
        /// <summary>
        /// Высота окна отрисовки
        /// </summary>
        private int? _pictureHeight = null;
        /// <summary>
        /// Ширина отрисовки 
        /// </summary>
        protected readonly int _shipWidth = 80;
        /// <summary>
        /// Высота отрисовки 
        /// </summary>
        protected readonly int _shipHeight = 50;
        /// <summary>
        /// Инициализация свойств
        /// </summary>
        /// <param name="speed">Скорость</param>
        /// <param name="weight">Веc</param>
        /// <param name="bodyColor">Цвет</param>
        public void Init(int speed, float weight, Color bodyColor)
        {
            Speed = speed;
            Weight = weight;
            BodyColor = bodyColor;
        }
        /// <summary>
        /// Установка позиции
        /// </summary>
        /// <param name="x">Координата X</param>
        /// <param name="y">Координата Y</param>
        /// <param name="width">Ширина картинки</param>
        /// <param name="height">Высота картинки</param>
        public void SetPosition(int x, int y, int width, int height)
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
        public void MoveTransport(Direction direction)
        {
            if (!_pictureWidth.HasValue || !_pictureHeight.HasValue)
            {
                return;
            }
            float step = Speed * 100 / Weight;
            switch (direction)
            {
                // вправо
                case Direction.Right:
                    if (_startPosX + _shipWidth + step < _pictureWidth)
                    {
                        _startPosX += step;
                    }
                    break;
                //влево
                case Direction.Left:
                    if (_startPosX - step > 0)
                    {
                        _startPosX -= step;
                    }
                    break;
                //вверх
                case Direction.Up:
                    if (_startPosY - step > 0)
                    {
                        _startPosY -= step;
                    }
                    break;
                //вниз
                case Direction.Down:
                    if (_startPosY + _shipHeight + step < _pictureHeight)
                    {
                        _startPosY += step;
                    }
                    break;
            }
        }
        /// <summary>
        /// Отрисовка
        /// </summary>
        /// <param name="g"></param>
        public void DrawTransport(Graphics g)
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
            g.FillRectangle(br, _startPosX.Value + 10, _startPosY.Value + 6, 50, 14);




        }
    }
}
