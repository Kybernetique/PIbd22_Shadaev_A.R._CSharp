using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsBoat
{
    // Класс "Лодка"
    public class Boat : Vessel
    {
        // Ширина отрисовки лодки
        protected readonly int boatWidth = 200;

        // Высота отрисовки лодки
        private readonly int boatHeight = 40;

        // Конструктор
        public Boat(int maxSpeed, float weight, Color mainColor)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
        }

        // Конструктор с изменением размеров лодки
        protected Boat(int maxSpeed, float weight, Color mainColor, int boatWidth,
            int boatHeight)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
            this.boatWidth = boatWidth;
            this.boatHeight = boatHeight;
        }

        // Изменение направления перемещения
        public override void MoveTransport(Direction direction)
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
        public override void DrawTransport(Graphics g)
        {
            Pen pen = new Pen(Color.Black);

            // Границы лодки
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
        }
    }
}
