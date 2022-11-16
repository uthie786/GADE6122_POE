using System;
using System.Collections.Generic;
using System.Text;

namespace Gade6122_Part1_corrected
{
    internal class RangedWeapon : Weapon
    {
        public enum Types { Rifle, Longbow }
        public override int Range { get { return base.range; } }
        public RangedWeapon(Types type, int x = 0, int y = 0) : base(x, y, '⌖')
        {
            switch (type)
            {
                case Types.Rifle:
                    weaponType = "Rifle";
                    durability = 3;
                    dmg = 5;
                    cost = 7;
                    range = 3;
                    break;
                case Types.Longbow:
                    weaponType = "Longbow";
                    durability = 4;
                    dmg = 4;
                    cost = 6;
                    range = 2;
                    break;
                default:

                    break;
            }
        }
    }

}
