using System.Drawing;

namespace WindowsFormsBoat
{
    // Интерфейс "Транспорт"
    public interface ITransport
    {
        // Установка позиции
        void SetPosition(int x, int y, int width, int height);

        // Изменение направления перемещения
        void MoveTransport(Direction direction);

        // Отрисовка
        void DrawTransport(Graphics g);
    }
}
