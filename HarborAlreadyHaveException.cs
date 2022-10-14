using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsBoat
{
    class HarborAlreadyHaveException : Exception
    {
        public HarborAlreadyHaveException() : base("There is the boat with the same characteristics")
        {

        }
    }
}
