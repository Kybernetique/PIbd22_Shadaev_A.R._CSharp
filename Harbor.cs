using System.Drawing;
using System.Collections.Generic;
using System.Collections;

namespace WindowsFormsBoat
{
    // Класс "Гавань"
    public class Harbor<T> : IEnumerator<T>, IEnumerable<T>
        where T : class, ITransport
    {
        // Массив объектов, которые храним
        private readonly List<T> _places;

        // Максимальное количество мест в гавани
        private readonly int _maxCount;

        // Ширина окна отрисовки
        private readonly int pictureWidth;

        // Высота окна отрисовки
        private readonly int pictureHeight;

        // Размер места гавани (ширина)
        private readonly int _placeSizeWidth = 220;

        // Размер места гавани (высота)
        private readonly int _placeSizeHeight = 80;

        // Текущий элемент для вывода через IEnumerator (будет обращаться по своему индексу к ключу словаря, по которму будет возвращаться запись)
        private int currentIndex;

        public T Current => _places[currentIndex];

        object IEnumerator.Current => _places[currentIndex];

        // Конструктор
        public Harbor(int picWidth, int picHeight)
        {
            int width = picWidth / _placeSizeWidth;
            int height = picHeight / _placeSizeHeight; 
            _maxCount = width * height;
            pictureWidth = picWidth;
            pictureHeight = picHeight;
            _places = new List<T>();
        }

        // Перегрузка оператора сложения
        // Логика действия: на место добавляется судно
        public static bool operator +(Harbor<T> p, T boat)
        {
            if (p._places.Count >= p._maxCount)
            {
                throw new HarborOverflowException();
            }
            if (p._places.Contains(boat))
            {
                throw new HarborAlreadyHaveException();
            }
            p._places.Add(boat);
            return true;
        }

        // Перегрузка оператора вычитания
        // Логика действия: с места забираем судно
        public static T operator -(Harbor<T> p, int index)
        {
            if (index < -1 || index > p._places.Count)
            {
                throw new HarborNotFoundException(index);
            }
            T boat = p._places[index];
            p._places.RemoveAt(index);
            return boat;
        }

        // Метод отрисовки гавани
        public void Draw(Graphics g)
        {
            DrawMarking(g);
            for (int i = 0; i < _places.Count; i++)
            {
                _places[i].SetPosition(20 + i % 3 * _placeSizeWidth, i / 3 * _placeSizeHeight + 15, pictureWidth, pictureHeight);
                _places[i]?.DrawTransport(g);
            }
        }

        // Метод отрисовки границ мест гавани
        private void DrawMarking(Graphics g)
        {
            Pen pen = new Pen(Color.Black, 3);
            for (int i = 0; i < pictureWidth / _placeSizeWidth; i++)
            {
                for (int j = 0; j < pictureHeight / _placeSizeHeight + 1; ++j)
                { 
                    // Линия разметки места
                    g.DrawLine(pen, i * _placeSizeWidth, j * _placeSizeHeight, i * _placeSizeWidth + _placeSizeWidth / 2, j * _placeSizeHeight);
                }
                g.DrawLine(pen, i * _placeSizeWidth, 0, i * _placeSizeWidth, (pictureHeight / _placeSizeHeight) * _placeSizeHeight);
            }
        }

        // Функция получения элементов из списка
        public T GetNext(int index)
        {
            if (index < 0 || index >= _places.Count)
            {
                return null;
            }
            return _places[index];
        }

        // Сортировка лодок на парковке
        public void Sort() => _places.Sort((IComparer<T>)new BoatComparer());

        // Метод интерфейса IEnumerator, вызываемый при удалении объекта
        public void Dispose()
        {
        }

        // Метод интерфейса IEnumerator для перехода к следующему элементу или началу коллекции
        public bool MoveNext()
        {
            if (currentIndex < _places.Count - 1)
            {
                currentIndex++;
                return true;
            }
            return false;
        }

        // Метод интерфейса IEnumerator для сброса и возврата к началу коллекции
        public void Reset()
        {
            currentIndex = -1;
        }

        // Метод интерфейса IEnumerable
        public IEnumerator<T> GetEnumerator()
        {
            return this;
        }

        // Метод интерфейса IEnumerable
        IEnumerator IEnumerable.GetEnumerator()
        {
            return this;
        }
    }
}
