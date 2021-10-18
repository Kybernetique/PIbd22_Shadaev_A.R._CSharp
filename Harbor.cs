﻿using System.Drawing;
using System.Collections.Generic;

namespace WindowsFormsBoat
{
    // Класс "Гавань"
    public class Harbor<T>
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

        // Конструктор
        public Harbor(int picWidth, int picHeight)
        {
            int width = picWidth / _placeSizeWidth;
            int height = picHeight / _placeSizeHeight; 
            _maxCount = width * height;
            pictureWidth = picWidth;
            pictureHeight = picHeight;
            _places = new List<T>(_maxCount);
        }

        // Индексатор
        public T this[int index]
        {
            set
            {
                if (index > -1 && index < _places.Count)
                {
                    _places[index] = value;
                }
            }
            get
            {
                if (index > -1 && index < _places.Count)
                {
                    return _places[index];
                }
                return null;
            }
        }

        // Перегрузка оператора сложения
        // Логика действия: на место добавляется судно
        public static int operator +(Harbor<T> p, T vessel)
        {
            for (int i = 0; i < p._places.Capacity; i++)
            {
                if (p._places.Count == p._places.Capacity)
                {
                    return -1;
                }
                else
                {
                    p._places.Add(vessel);
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
            if (index < p._places.Count && p._places[index] != null)
            {
                T vessel = p._places[index];
                p._places.RemoveAt(index);
                return vessel;
            }
            return null;
        }

        // Метод отрисовки гавани
        public void Draw(Graphics g)
        {
            DrawMarking(g);
            for (int i = 0; i < _places.Count; i++)
            {
                _places[i].SetPosition(5 + i / 5 * _placeSizeWidth + 5, i % 5 * _placeSizeHeight + 15, pictureWidth, pictureHeight);
                _places[i].DrawTransport(g);
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
