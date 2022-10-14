using System;

namespace WindowsFormsBoat
{
    // Класс-ошибка "Если в гавани нет свободных мест"
    public class HarborOverflowException : Exception
    {
        public HarborOverflowException() : base("There Are No Free Places In Harbor.")
        {
        }
    }
}

