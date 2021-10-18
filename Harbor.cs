using System.Drawing;

namespace WindowsFormsBoat
{
    // Класс "Гавань"
    public class Harbor<T> 
        where T : class, ITransport
    {
        // Массив объектов, которые храним
        private readonly T[] _places;

        // Ширина окна отрисовки
        private readonly int pictureWidth;

        // Высота окна отрисовки
        private readonly int pictureHeight;

        // Размер места гавани (ширина)
        private readonly int _placeSizeWidth = 220;

        // Размер места гавани (высота)
        private readonly int _placeSizeHeight = 80;

        // Конструктор
        public Harbor(int picWidth, int picHeight)
        {
            int width = picWidth / _placeSizeWidth;
            int height = picHeight / _placeSizeHeight;
            _places = new T[width * height];
            pictureWidth = picWidth;
            pictureHeight = picHeight;
        }
        
        // Перегрузка оператора сложения
        // Логика действия: на место добавляется судно
        public static int operator +(Harbor<T> p, T vessel)
        {
            for (int i = 0; i < p._places.Length; i++)
            {
                if (p._places[i] == null)
                {
                    p._places[i] = vessel;
                    p._places[i].SetPosition(20 + i % 3 * p._placeSizeWidth, i / 3 * p._placeSizeHeight + 15, p.pictureWidth, p.pictureHeight);
                    return i;
                }
            }
            return -1;
        }
        
        // Перегрузка оператора вычитания
        // Логика действия: с места забираем судно
        public static T operator -(Harbor<T> p, int index)
        {
            if (index < p._places.Length && p._places[index] != null)
            {
                T vessel = p._places[index];
                p._places[index] = null;
                return vessel;
            }
            return null;
        }
        
        // Метод отрисовки гавани
        public void Draw(Graphics g)
        {
            DrawMarking(g);
            for (int i = 0; i < _places.Length; i++)
            {
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
    }
}
