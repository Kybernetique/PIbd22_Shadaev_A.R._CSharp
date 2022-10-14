using System.Drawing;

namespace WindowsFormsBoat
{
    // Абстрактный класс "Транспорт"
    public abstract class Vehicle : ITransport
    {
        // Левая координата отрисовки 
        protected float _startPosX;

        // Правая координата отрисовки
        protected float _startPosY;

        // Ширина окна отрисовки
        protected int _pictureWidth;

        // Высота окна отрисовки
        protected int _pictureHeight;

        // Максимальная скорость
        public int MaxSpeed { protected set; get; }

        // Вес
        public float Weight { protected set; get; }

        // Основной цвет
        public Color MainColor { protected set; get; }

        // Установка позиции
        public void SetPosition(int x, int y, int width, int height)
        {
            _startPosX = x;
            _startPosY = y;
            _pictureWidth = width;
            _pictureHeight = height;
        }

        // Отрисовка
        public abstract void DrawTransport(Graphics g);

        // Изменение направления перемещения
        public abstract void MoveTransport(Direction direction);

        public void SetMainColor(Color color)
        {
            MainColor = color;
        }
    }
}