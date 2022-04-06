using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContainerShip
{
    public class MarinaCollection : IEnumerator<string>, IEnumerable<string>
    {
        /// <summary>
        /// Словарь (хранилище) с пристанями
        /// </summary>
        private Dictionary<string, Marina<ITransport>> _marinaStages;
        /// <summary>
        /// Возвращение списка названий пристань
        /// </summary>
        public List<string> _keys => _marinaStages.Keys.ToList();
        /// <summary>
        /// Ширина окна отрисовки
        /// </summary>
        private readonly int _pictureWidth;
        /// <summary>
        /// Высота окна отрисовки
        /// </summary>
        private readonly int _pictureHeight;
        /// <summary>
        /// Разделитель для записи информации по объекту в файл
        /// </summary>
        protected readonly char separator = ':';
        /// <summary>
        /// Текущий элемент для вывода через IEnumerator (будет обращаться по  своему индексу к ключу словаря, по которму будет возвращаться запись)
        /// </summary>
        private int _currentIndex = -1;
        /// <summary>
        /// Возвращение текущего элемента для IEnumerator
        /// </summary>
        public string Current => _keys[_currentIndex];
        /// <summary>
        /// Возвращение текущего элемента для IEnumerator
        /// </summary>
        object IEnumerator.Current => _keys[_currentIndex];
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
        /// <summary>
        /// Метод записи информации в файл
        /// </summary>
        /// <param name="text">Строка, которую следует записать</param>
        /// <param name="stream">Поток для записи</param>
        private void WriteToFile(string text, FileStream stream)
        {
            byte[] info = new UTF8Encoding(true).GetBytes(text);
            stream.Write(info, 0, info.Length);
        }
        /// Сохранение информации по суднам на пристанях в файл
        /// </summary>
        /// <param name="filename">Путь и имя файла</param>
        /// <returns></returns>
        public void SaveData(string filename)
        {
            if (File.Exists(filename))
            {
                File.Delete(filename);
            }
            using (FileStream fs = new FileStream(filename, FileMode.Create))
            {
                WriteToFile($"MarinaCollection{Environment.NewLine}", fs);
                foreach (var level in _marinaStages)
                {
                    //Начинаем парковку
                    WriteToFile($"Marina{separator}{level.Key}{Environment.NewLine}", fs);
                    foreach (var car in level.Value.GetNext())
                    {
                        //если место не пустое
                        if (car != null)
                        {
                            WriteToFile($"{car.GetType().Name}{separator}{car}{Environment.NewLine}", fs);
                        }
                    }
                }
            }
        }
        /// <summary>
        /// Загрузка нформации по суднам на пристанях из файла
        /// </summary>
        /// <param name="filename"></param>
        /// <returns></returns>
        public void LoadData(string filename)
        {
            if (!File.Exists(filename))
            {
                throw new FileNotFoundException(filename);
            }
            string bufferTextFromFile = "";
            using (FileStream fs = new FileStream(filename, FileMode.Open))
            {
                byte[] b = new byte[fs.Length];
                UTF8Encoding temp = new UTF8Encoding(true);
                while (fs.Read(b, 0, b.Length) > 0)
                {
                    bufferTextFromFile += temp.GetString(b);
                }
            }
            var strs = bufferTextFromFile.Split(new char[] { '\n', '\r' },
            StringSplitOptions.RemoveEmptyEntries);
            if (!strs[0].Contains("MarinaCollection"))
            {
                //если нет такой записи, то это не те данные
                throw new FileFormatException();
            }
            //очищаем записи
            _marinaStages.Clear();
            ITransport ship = null;
            string key = string.Empty;
            for (int i = 1; i < strs.Length; ++i)
            {
                //идем по считанным записям
                if (strs[i].Contains("Marina"))
                {
                    //начинаем новую парковку
                    key = strs[i].Split(separator)[1];
                    _marinaStages.Add(key, new Marina<ITransport>(_pictureWidth, _pictureHeight));
                    continue;
                }
                if (strs[i].Split(separator)[0] == "Ship")
                {
                    ship = new Ship(strs[i].Split(separator)[1]);
                }
                else if (strs[i].Split(separator)[0] == "SuperShip")
                {
                    ship = new SuperShip(strs[i].Split(separator)[1]);
                }
                _ = _marinaStages[key] + ship;
            }
        }
        /// <summary>
        /// Метод от IDisposable (унаследован в IEnumerator). В данном случае, логики в нем не требуется
        /// </summary>
        public void Dispose() { }
        /// <summary>
        /// Переход к следующему элементу
        /// </summary>
        /// <returns></returns>
        public bool MoveNext()
        {
            if (_currentIndex + 1 >= _marinaStages.Count)
            {
                Reset();
                return false;
            }
            _currentIndex++;
            return true;
        }
        /// <summary>
        /// Сброс при достижении конца
        /// </summary>
        public void Reset() => _currentIndex = -1;
        /// <summary>
        /// Получение ссылки на объект от класса, реализующего IEnumerator
        /// </summary>
        /// <returns></returns>
        public IEnumerator<string> GetEnumerator() => this;
        /// <summary>
        /// Получение ссылки на объект от класса, реализующего IEnumerable
        /// </summary>
        /// <returns></returns>
        IEnumerator IEnumerable.GetEnumerator() => this;

    }
}
