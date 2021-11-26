using System;

namespace WindowsFormsBoat
{
    // Класс-ошибка "Лодка не найдена по месту"
    public class HarborNotFoundException : Exception
    {
        public HarborNotFoundException(int i) : base("Boat Is Not Found By Place " + i + ".")
        {
        }
    }
}
