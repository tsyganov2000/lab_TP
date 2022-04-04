﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ContainerShip
{
    public class Ship : ITransport, IEquatable<Ship>
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
        public Color MainColor { private set; get; }
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
        /// Разделитель для записи информации по объекту в файл
        /// </summary>
        protected readonly char _separator = ';';
        /// <summary>
        /// Конструктор для загрузки с файла
        /// </summary>
        /// <param name="info">Информация по объекту</param>
        public Ship(string info)
        {
            string[] strs = info.Split(_separator);
            if (strs.Length >= 3)
            {
                Speed = Convert.ToInt32(strs[0]);
                Weight = Convert.ToInt32(strs[1]);
                MainColor = Color.FromName(strs[2]);
            }
        }
        /// <summary>
        /// Инициализация свойств
        /// </summary>
        /// <param name="speed">Скорость</param>
        /// <param name="weight">Веc</param>
        /// <param name="bodyColor">Цвет</param>
        public Ship(int speed, float weight, Color mainColor)
        {
            Speed = speed;
            Weight = weight;
            MainColor = mainColor;
        }
        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="speed">Скорость</param>
        /// <param name="weight">Вес </param>
        /// <param name="bodyColor">Цвет</param>
        /// <param name="shipWidth">Ширина объекта</param>
        /// <param name="shipHeight">Высота объекта</param>
        protected Ship(int speed, float weight, Color mainColor, int shipWidth, int shipHeight)
        {
            Speed = speed;
            Weight = weight;
            MainColor = mainColor;
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
        public override string ToString() => $"{Speed}{_separator}{Weight}{_separator}{MainColor.Name}";
        public void SetMainColor(Color color) => MainColor = color;
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
            Brush br = new SolidBrush(MainColor);
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

        public (float Left, float Right, float Top, float Bottom) GetCurrentPosition()
        {
            return (_startPosX.Value, _startPosX.Value + _shipWidth, _startPosY.Value, _startPosY.Value + _shipHeight);
        }
        /// <summary>
        /// Метод интерфейса IEquatable для класса Ship
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public bool Equals(Ship other)
        {
            if (other == null)
            {
                return false;
            }
            if (GetType().Name != other.GetType().Name)
            {
                return false;
            }
            if (MainColor != other.MainColor)
            {
                return false;
            }
            return true;
        }
        public override bool Equals(Object obj)
        {
            if (obj == null)
            {
                return false;
            }
            if (!(obj is Ship shipObj))
            {
                return false;
            }
            else
            {
                return Equals(shipObj);
            }
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
