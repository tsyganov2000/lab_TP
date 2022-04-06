using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContainerShip
{
    public class MarinaCollection
    {
        /// <summary>
        /// Словарь (хранилище) с пристанями
        /// </summary>
        private Dictionary<string, Marina<ITransport>> _marinaStages;
        /// <summary>
        /// Возвращение списка названий пристань
        /// </summary>
        public List<string> Keys => _marinaStages.Keys.ToList();
        /// <summary>
        /// Ширина окна отрисовки
        /// </summary>
        private readonly int _pictureWidth;
        /// <summary>
        /// Высота окна отрисовки
        /// </summary>
        private readonly int _pictureHeight;
        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="pictureWidth"></param>
        /// <param name="pictureHeight"></param>
        public MarinaCollection(int pictureWidth, int pictureHeight)
        {
            _marinaStages = new Dictionary<string, Marina<ITransport>>();
            _pictureWidth = pictureWidth;
            _pictureHeight = pictureHeight;
        }
        /// Добавление пристани
        /// </summary>
        /// <param name="name">Название пристани</param>
        public void AddMarina(string name)
        {
            if (!_marinaStages.ContainsKey(name))
            {
                _marinaStages.Add(name, new Marina<ITransport>(_pictureWidth, _pictureHeight));
            }
        }
        /// <summary>
        /// Удаление пристани
        /// </summary>
        /// <param name="name">Название пристани</param>
        public void DelMarina(string name)
        {
            _marinaStages.Remove(name);
        }
        /// <summary>
        /// Доступ к пристане
        /// </summary>
        /// <param name="ind"></param>
        /// <returns></returns>
        public Marina<ITransport> this[string ind]
        {
            get
            {
                if (_marinaStages.ContainsKey(ind))
                {
                    return _marinaStages[ind];
                }
                return null;
            }
        }

    }
}
