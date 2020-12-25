using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsTruck
{
    class ShipComparer : IComparer<Vehicle>

    {
        public int Compare(Vehicle x, Vehicle y)
        {
            if (x is WarShip && y is WarShip)
            {
                return ComparerWarShip((WarShip)x, (WarShip)y);
            }
            if (x is WarShip && y is Ship)
            {
                return -1;
            }
            if (x is Ship && y is WarShip)
            {
                return 1;
            }
            if (x is Ship && y is Ship)
            {
                return ComparerShip((Ship)x, (Ship)y);
            }
            return 0;
        }


        private int ComparerShip(Ship x, Ship y)
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

        private int ComparerWarShip(WarShip x, WarShip y)
        {
            var res = ComparerShip(x, y);
            if (res != 0)
            {
                return res;
            }
            if (x.DopColor != y.DopColor)
            {
                return x.DopColor.Name.CompareTo(y.DopColor.Name);
            }
            if (x.Radar != y.Radar)
            {
                return x.Radar.CompareTo(y.Radar);
            }
            if (x.Weapon != y.Weapon)
            {
                return x.Weapon.CompareTo(y.Weapon);
            }
            return 0;
        }
    }
}
