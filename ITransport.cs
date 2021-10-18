using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsBoat
{
    // Интерфейс "Транспорт"
    interface ITransport
    {
        // Установка позиции
        void SetPosition(int x, int y, int width, int height);

        // Изменение направления перемещения
        void MoveTransport(Direction direction);

        // Отрисовка
        void DrawTransport(Graphics g);
    }
}
