using System.Drawing;

namespace WindowsFormsBoat
{
    // Класс "Парусник"
    public class SailBoat : Boat
    {
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
        public SailBoat(int maxSpeed, float weight, Color mainColor, Color secondaryColor,
       bool front, bool back, bool anchor, bool sail) : base(maxSpeed, weight, mainColor, 200, 40)
        {
            SecondaryColor = secondaryColor;
            Front = front;
            Back = back;
            Anchor = anchor;
            Sail = sail;
        }

        // Отрисовка парусника
        public override void DrawTransport(Graphics g)
        {
            Pen pen = new Pen(Color.Black);
            base.DrawTransport(g);

            // Передняя часть
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

            // Задняя часть
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
