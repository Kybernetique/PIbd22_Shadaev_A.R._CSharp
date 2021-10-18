using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsBoat
{
    // Класс отрисовки лодки
    class Boat
    {
        // Левая координата отрисовки лодки
        private float _startPosX;

        // Правая координата отрисовки лодки
        private float _startPosY;

        // Ширина окна отрисовки
        private int _pictureWidth;

        // Высота окна отрисовки
        private int _pictureHeight;

        // Ширина отрисовки лодки
        private readonly int boatWidth = 200;

        // Высота отрисовки лодки
        private readonly int boatHeight = 40;

        // Максимальная скорость
        public int MaxSpeed { private set; get; }

        // Вес лодки
        public float Weight { private set; get; }

        // Основной цвет
        public Color MainColor { private set; get; }

        // Дополнительный цвет
        public Color SecondaryColor { private set; get; }

        // Признак наличия передней части
        public bool Front { private set; get; }

        // Признак наличия задней части
        public bool Back { private set; get; }

        // Признак наличия якоря
        public bool Anchor { private set; get; }

        // Признак наличия паруса
        public bool Sail { private set; get; }

        // Инициализация свойств
        public void Init(int maxSpeed, float weight, Color mainColor, Color secondaryColor,
       bool front, bool back, bool anchor, bool sail)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
            SecondaryColor = secondaryColor;
            Front = front;
            Back = back;
            Anchor = anchor;
            Sail = sail;
        }

        // Установка позиции лодки
        public void SetPosition(int x, int y, int width, int height)
        {
            _startPosX = x;
            _startPosY = y;
            _pictureWidth = width;
            _pictureHeight = height;
        }

        // Изменение направления перемещения
        public void MoveTransport(Direction direction)
        {
            float step = MaxSpeed * 100 / Weight;
            switch (direction)
            {
                // Вправо
                case Direction.Right:
                    if (_startPosX + step < _pictureWidth - boatWidth)
                    {
                        _startPosX += step;
                    }
                    break;

                // Влево
                case Direction.Left:
                    if (_startPosX - step > 0)
                    {
                        _startPosX -= step;
                    }
                    break;

                // Вверх
                case Direction.Up:
                    if (_startPosY - step > 0)
                    {
                        _startPosY -= step;
                    }
                    break;

                // Вниз
                case Direction.Down:
                    if (_startPosY + step < _pictureHeight - boatHeight)
                    {
                        _startPosY += step;
                    }
                    break;
            }
        }

        // Отрисовка лодки
        public void DrawTransport(Graphics g)
        {
            Pen pen = new Pen(Color.Black);

            // Отрисовка границ лодки
            g.DrawLine(pen, _startPosX, _startPosY, _startPosX + 100, _startPosY);
            g.DrawLine(pen, _startPosX + 100, _startPosY, _startPosX + 160, _startPosY + 20);
            g.DrawLine(pen, _startPosX + 160, _startPosY + 20, _startPosX + 100, _startPosY + 40);
            g.DrawLine(pen, _startPosX + 100, _startPosY + 40, _startPosX, _startPosY + 40);
            g.DrawLine(pen, _startPosX, _startPosY + 40, _startPosX, _startPosY);
            g.DrawLine(pen, _startPosX + 25, _startPosY + 10, _startPosX + 25, _startPosY + 30);
            g.DrawLine(pen, _startPosX + 90, _startPosY + 10, _startPosX + 90, _startPosY + 30);
            g.DrawEllipse(pen, _startPosX + 10, _startPosY + 10, 20, 20);
            g.DrawEllipse(pen, _startPosX + 80, _startPosY + 10, 20, 20);
            g.DrawRectangle(pen, _startPosX + 20, _startPosY + 10, 70, 20);

            // Заливка границ лодки
            Brush brSaddleBrown = new SolidBrush(Color.SaddleBrown);
            Point[] pts = {
                new Point((int) _startPosX + 100,(int) _startPosY),
                new Point((int) _startPosX + 160,(int) _startPosY + 20),
                new Point((int) _startPosX + 100,(int) _startPosY + 40)
            };
            g.FillPolygon(brSaddleBrown, pts);
            g.FillRectangle(brSaddleBrown, _startPosX, _startPosY, 100, 40);
            g.FillEllipse(new SolidBrush(MainColor), _startPosX + 80, _startPosY + 10, 20, 20);
            g.FillEllipse(new SolidBrush(MainColor), _startPosX + 10, _startPosY + 10, 20, 20);
            g.FillRectangle(new SolidBrush(MainColor), _startPosX + 25, _startPosY + 10, 65, 20);

            // Передняя часть лодки
            if (Front)
            {
                pen.Color = Color.Black;
                pen.Width = 1;

                // Массив точек для заливки границ передней части
                Point[] points =
                    {
                new Point((int) _startPosX + 200,(int) _startPosY + 20),
                new Point((int) _startPosX + 150,(int) _startPosY + 15),
                new Point((int) _startPosX + 160,(int) _startPosY + 20),
                new Point((int) _startPosX + 150,(int) _startPosY + 25)
                };
                g.FillPolygon(new SolidBrush(MainColor), points);

                // Отрисовка границ передней части
                g.DrawLine(pen, _startPosX + 160, _startPosY + 20, _startPosX + 200, _startPosY + 20);
                g.DrawLine(pen, _startPosX + 200, _startPosY + 20, _startPosX + 150, _startPosY + 15);
                g.DrawLine(pen, _startPosX + 200, _startPosY + 20, _startPosX + 150, _startPosY + 25);
            }

            // Задняя часть лодки
            if (Back)
            {
                pen.Color = MainColor;
                pen.Width = 2;

                // Отрисовка задней части
                g.DrawLine(pen, _startPosX, _startPosY, _startPosX - 20, _startPosY);
                g.DrawLine(pen, _startPosX, _startPosY + 40, _startPosX - 20, _startPosY + 40);
            }

            // Якорь
            if (Anchor)
            {
                pen.Width = 2;
                pen.Color = SecondaryColor;

                // Отрисовка якоря
                g.DrawLine(pen, _startPosX + 160, _startPosY + 20, _startPosX + 160, _startPosY + 40);
                g.DrawLine(pen, _startPosX + 160, _startPosY + 25, _startPosX + 162, _startPosY + 25);
                g.DrawLine(pen, _startPosX + 160, _startPosY + 25, _startPosX + 158, _startPosY + 25);
                g.DrawLine(pen, _startPosX + 160, _startPosY + 40, _startPosX + 165, _startPosY + 35);
                g.DrawLine(pen, _startPosX + 160, _startPosY + 40, _startPosX + 155, _startPosY + 35);
            }

            // Парус
            if (Sail)
            {
                pen.Width = 1;
                pen.Color = Color.Black;

                // Отрисовка границ паруса
                g.DrawLine(pen, _startPosX + 25, _startPosY + 10, _startPosX + 25, _startPosY + 30);
                g.DrawLine(pen, _startPosX + 90, _startPosY + 10, _startPosX + 90, _startPosY + 30);
                g.DrawEllipse(pen, _startPosX + 10, _startPosY + 10, 20, 20);
                g.DrawEllipse(pen, _startPosX + 80, _startPosY + 10, 20, 20);
                g.DrawRectangle(pen, _startPosX + 20, _startPosY + 10, 70, 20);

                // Заливка границ паруса
                g.FillEllipse(new SolidBrush(MainColor), _startPosX + 80, _startPosY + 10, 20, 20);
                g.FillEllipse(new SolidBrush(MainColor), _startPosX + 10, _startPosY + 10, 20, 20);
                g.FillRectangle(new SolidBrush(SecondaryColor), _startPosX + 25, _startPosY + 10, 65, 20);
            }
        }
    }
}
