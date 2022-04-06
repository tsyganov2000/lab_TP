using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContainerShip
{
    public interface ITransport
    {
        /// <summary>
        /// Шаг объекта
        /// </summary>
        float Step { get; }
        /// <summary>
        /// Цвет объекта
        /// </summary>
        void SetMainColor(Color color);

        /// <summary>
        /// Установка позиции объекта
        /// </summary>
        /// <param name="x">Координата X</param>
        /// <param name="y">Координата Y</param>
        /// <param name="width">Ширина полотна</param>
        /// <param name="height">Высота полотна</param>
        void SetObject(float x, float y, int width, int height);
        /// <summary>
        /// Изменение направления пермещения объекта
        /// </summary>
        /// <param name="direction">Направление</param>
        /// <returns></returns>
        bool MoveObject(Direction direction);
        /// <summary>
        /// Отрисовка объекта
        /// </summary>
        /// <param name="g"></param>
        void DrawTransport(Graphics g);
        /// <summary>
        /// Получение текущей позиции объекта
        /// </summary>
        /// <returns></returns>
        (float Left, float Right, float Top, float Bottom) GetCurrentPosition();
    }
}
