using System.Drawing;

namespace WindowsFormsBoat
{
    // Класс отрисовки автомобиля
    class Boat
    {
        /// Левая координата отрисовки автомобиля
        private float _startPosX;

        /// Правая кооридната отрисовки автомобиля
        private float _startPosY;

        /// Ширина окна отрисовки
        private int _pictureWidth;

        /// Высота окна отрисовки
        private int _pictureHeight;

        /// Ширина отрисовки автомобиля
        private readonly int boatWidth = 200;

        /// Высота отрисовки автомобиля
        private readonly int boatHeight = 40;

        /// Максимальная скорость
        public int MaxSpeed { private set; get; }

        /// Вес автомобиля
        public float Weight { private set; get; }

        /// Основной цвет кузова
        public Color MainColor { private set; get; }

        /// Дополнительный цвет
        public Color SecondaryColor { private set; get; }

        /// Признак наличия носа корабля
        public bool Front { private set; get; }

        // Признак наличия якоря
        public bool Anchor { private set; get; }

        // Признак наличия паруса
        public bool Sail { private set; get; }

        // Признак наличия задней части корабля
        public bool Back { private set; get; }


        /// Инициализация свойств
        public void Init(int maxSpeed, float weight, Color mainColor, Color secondaryColor,
       bool front, bool anchor, bool sail, bool back)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
            SecondaryColor = secondaryColor;
            Front = front;
            Anchor = anchor;
            Sail = sail;
            Back = back;
        }

        /// Установка позиции автомобиля
        public void SetPosition(int x, int y, int width, int height)
        {
            _startPosX = x;
            _startPosY = y;
            _pictureWidth = width;
            _pictureHeight = height;
        }

        /// Изменение направления перемещения
        public void MoveTransport(Direction direction)
        {
            float step = MaxSpeed * 100 / Weight;
            switch (direction)
            {
                // вправо
                case Direction.Right:
                    if (_startPosX + step < _pictureWidth - boatWidth)
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
                    if (_startPosY + step < _pictureHeight - boatHeight)
                    {
                        _startPosY += step;
                    }
                    break;
            }
        }

        /// Отрисовка автомобиля
        public void DrawTransport(Graphics g)
        {
            //g.FillRectangle(new SolidBrush(Color.Aqua),0, 0, _pictureWidth, _pictureHeight);

            Pen pen = new Pen(Color.Black);

            // Заливка границ парусника
            Brush brBrown = new SolidBrush(Color.SaddleBrown);
            Point[] pts = {
                new Point((int) _startPosX + 100,(int) _startPosY),
                new Point((int) _startPosX + 160,(int) _startPosY + 20),
                new Point((int) _startPosX + 100,(int) _startPosY + 40)
            };
            g.FillPolygon(brBrown, pts);
            g.FillRectangle(brBrown, _startPosX, _startPosY, 100, 40);

            // Границы парусника
            g.DrawLine(pen, _startPosX, _startPosY, _startPosX + 100, _startPosY);
            g.DrawLine(pen, _startPosX + 100, _startPosY, _startPosX + 160, _startPosY + 20);
            g.DrawLine(pen, _startPosX + 160, _startPosY + 20, _startPosX + 100, _startPosY + 40);
            g.DrawLine(pen, _startPosX + 100, _startPosY + 40, _startPosX, _startPosY + 40);
            g.DrawLine(pen, _startPosX, _startPosY + 40, _startPosX, _startPosY);

            // Парус
            g.DrawEllipse(pen, _startPosX + 10, _startPosY + 10, 20, 20);
            g.DrawEllipse(pen, _startPosX + 80, _startPosY + 10, 20, 20);
            g.DrawRectangle(pen, _startPosX + 20, _startPosY + 10, 70, 20);

            // Якорь
            if (Anchor)
            {
                pen.Width = 2;
                pen.Color = SecondaryColor;
                g.DrawLine(pen, _startPosX + 160, _startPosY + 20, _startPosX + 160, _startPosY + 40);

                g.DrawLine(pen, _startPosX + 160, _startPosY + 25, _startPosX + 162, _startPosY + 25);
                g.DrawLine(pen, _startPosX + 160, _startPosY + 25, _startPosX + 158, _startPosY + 25);

                g.DrawLine(pen, _startPosX + 160, _startPosY + 40, _startPosX + 165, _startPosY + 35);
                g.DrawLine(pen, _startPosX + 160, _startPosY + 40, _startPosX + 155, _startPosY + 35);
            }

            // Передняя часть корабля
            if (Front)
            {
                pen.Color = Color.Black;
                pen.Width = 1;
                Point[] points =
                    {
                new Point((int) _startPosX + 200,(int) _startPosY + 20),
                new Point((int) _startPosX + 150,(int) _startPosY + 15),
                new Point((int) _startPosX + 160,(int) _startPosY + 20),
                new Point((int) _startPosX + 150,(int) _startPosY + 25)
                };
                g.FillPolygon(new SolidBrush(MainColor), points);

                g.DrawLine(pen, _startPosX + 160, _startPosY + 20, _startPosX + 200, _startPosY + 20);
                g.DrawLine(pen, _startPosX + 200, _startPosY + 20, _startPosX + 150, _startPosY + 15);
                g.DrawLine(pen, _startPosX + 200, _startPosY + 20, _startPosX + 150, _startPosY + 25);

                
            }

            // Флаг
            if (Sail)
            {
                g.FillEllipse(new SolidBrush(MainColor), _startPosX + 80, _startPosY + 10, 20, 20);
                g.FillEllipse(new SolidBrush(MainColor), _startPosX + 10, _startPosY + 10, 20, 20);
                g.FillRectangle(new SolidBrush(SecondaryColor), _startPosX + 25, _startPosY + 10, 65, 20);

                pen.Width = 1;
                pen.Color = Color.Black;
                g.DrawLine(pen, _startPosX + 25, _startPosY + 10, _startPosX + 25, _startPosY + 30);
                g.DrawLine(pen, _startPosX + 90, _startPosY + 10, _startPosX + 90, _startPosY + 30);
            }

            // Задняя часть корабля
            if (Back)
            {
                pen.Color = MainColor;
                pen.Width = 2;
                g.DrawLine(pen, _startPosX, _startPosY, _startPosX - 20, _startPosY);
                g.DrawLine(pen, _startPosX, _startPosY + 40, _startPosX - 20, _startPosY + 40);
            }

        }

    }
}
