using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsBoat
{
    class BoatComparer : IComparer<Vehicle>
    {

        public int Compare(Vehicle x, Vehicle y)
        {
            if (x is Boat && y is SailBoat)
            {
                return -1;

            }
            if (x is SailBoat && y is Boat)
            {
                return 1;
            }
            if (x is Boat && y is Boat)
            {
                return ComparerBoat((Boat)x, (Boat)y);
            }
            if (x is SailBoat && y is SailBoat)
            {
                return ComparerSailBoat((SailBoat)x, (SailBoat)y);
            }

            return 0;
        }

        private int ComparerBoat(Boat x, Boat y)
        {
            if (x.MaxSpeed != y.MaxSpeed)
            {
                return x.MaxSpeed.CompareTo(y.MaxSpeed);
            }
            if (x.Weight != y.Weight)
            {
                return x.Weight.CompareTo(y.Weight);
            }
            if (x.MainColor != y.MainColor)
            {
                return x.MainColor.Name.CompareTo(y.MainColor.Name);
            }
            return 0;
        }

        private int ComparerSailBoat(SailBoat x, SailBoat y)
        {
            var res = ComparerBoat(x, y);
            if (res != 0)
            {
                return res;
            }
            if (x.SecondaryColor != y.SecondaryColor)
            {
                return x.SecondaryColor.Name.CompareTo(y.SecondaryColor.Name);
            }
            if (x.Front != y.Front)
            {
                return x.Front.CompareTo(y.Front);
            }
            if (x.Back != y.Back)
            {
                return x.Back.CompareTo(y.Back);
            }
            if (x.Anchor != y.Anchor)
            {
                return x.Anchor.CompareTo(y.Anchor);
            }
            if (x.Sail != y.Sail)
            {
                return x.Sail.CompareTo(y.Sail);
            }
            return 0;
        }
    }
}
