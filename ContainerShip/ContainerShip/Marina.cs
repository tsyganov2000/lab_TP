using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ContainerShip
{
    public class Marina<T> where T : class, ITransport
    {
        /// <summary>
        /// Список объектов, которые храним
        /// </summary>
        private readonly List<T> _places;
        /// <summary>
        /// Максимальное количество мест на пристани
        /// </summary>
        private readonly int _maxCount;
        /// <summary>
        /// Ширина окна отрисовки
        /// </summary>
        private readonly int _pictureWidth;
        /// <summary>
        /// Высота окна отрисовки
        /// </summary>
        private readonly int _pictureHeight;
        /// <summary>
        /// Размер места (ширина)
        /// </summary>
        private readonly int _placeSizeWidth = 210;
        /// <summary>
        /// Размер места (высота)
        /// </summary>
        private readonly int _placeSizeHeight = 80;
        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="picWidth">Рамзер парковки - ширина</param>
        /// <param name="picHeight">Рамзер парковки - высота</param>
        public Marina(int picWidth, int picHeight)
        {
            int width = picWidth / _placeSizeWidth;
            int height = picHeight / _placeSizeHeight;
            _maxCount = width * height;
            _pictureWidth = picWidth;
            _pictureHeight = picHeight;
            _places = new List<T>(_maxCount) { null, null, null, null, null,
                null, null, null, null, null,
                null, null, null, null, null };

        }
        /// <summary>
        /// Перегрузка оператора сложения
        /// Логика действия: на пристань добавляется корабль
        /// </summary>
        /// <param name="p">Пристань</param>
        /// <param name="ship">Добавляемый корабль</param>
        /// <returns></returns>
        public static bool operator +(Marina<T> p, T ship)
        {
            if (p._places.Count == p._maxCount + 1)
            {
                throw new MarinaOverflowException();
            }
            for (int i = 0; i < p._maxCount; i++)
            {
                if (p._places[i] == null)
                {
                    p._places[i] = ship;
                    p._places[i].SetObject(5 + i / 5 * p._placeSizeWidth + 5, i % 5 * p._placeSizeHeight + 15, p._pictureWidth,  p._pictureHeight);
                    return true;
                }
            }
            throw new MarinaOverflowException();
        }
        /// <summary>
        /// Перегрузка оператора вычитания
        /// Логика действия: с пристани забираем корабль
        /// </summary>
        /// <param name="p">Пристань</param>
        /// <param name="index">Индекс места, с которого пытаемся извлечь объект</param>
        /// <returns></returns>
        public static T operator -(Marina<T> p, int index)
        {
            if (index < 0 || index > p._places.Count)
            {
                return null;
            }
            if (p._places[index] != null)
            {
                T ship = p._places[index];
                p._places[index] = null;
                return ship;
            }
            throw new MarinaNotFoundException(index);
        }
        /// <summary>
        /// Метод отрисовки пристани
        /// </summary>
        /// <param name="g"></param>
        public void Draw(Graphics g)
        {
            DrawMarking(g);
            for (int i = 0; i < _places.Count; i++)
            {
                _places[i]?.SetObject(5 + i / 5 * _placeSizeWidth + 5, i % 5 * _placeSizeHeight + 15, _pictureWidth, _pictureHeight);
                _places[i]?.DrawTransport(g);
            }
        }
        /// <summary>
        /// Метод отрисовки разметки
        /// </summary>
        /// <param name="g"></param>
        private void DrawMarking(Graphics g)
        {
            Pen pen = new Pen(Color.SaddleBrown, 20);
            for (int i = 0; i < _pictureWidth / _placeSizeWidth; i++)
            {
                for (int j = 0; j < _pictureHeight / _placeSizeHeight + 1;  ++j)
                {//линия рамзетки места
                    g.DrawLine(pen, i * _placeSizeWidth, j *  _placeSizeHeight, i * _placeSizeWidth + _placeSizeWidth / 2, j * _placeSizeHeight);
                }
                g.DrawLine(pen, i * _placeSizeWidth, 0, i * _placeSizeWidth, (_pictureHeight / _placeSizeHeight) * _placeSizeHeight);
            }

        }
        /// <summary>
        /// Функция получения элементов из списка
        /// </summary>
        /// <returns></returns>
        public IEnumerable<T> GetNext()
        {
            foreach (var elem in _places)
            {
                yield return elem;
            }
        }
    }
}
