using System;
using System.Collections.Generic;
using System.Text;

namespace Gade6122_Part1_corrected
{
    [Serializable]
    internal class MeleeWeapon : Weapon
    {
        public enum Types { Dagger, Longsword, Barehanded }
        public override int Range { get { return base.range; } }
        public MeleeWeapon(Types type, int x = 0, int y = 0) : base(x, y)
        {
           
            switch (type)
            {
                case Types.Dagger:
                    weaponType = "Dagger";
                    durability = 10;
                    dmg = 3;
                    cost = 3;
                    break;
                case Types.Longsword:
                    weaponType = "Longsword";
                    durability = 6;
                    dmg = 4;
                    cost = 5;
                    break;
                case Types.Barehanded:
                    weaponType = "Barehanded";
                    durability = 0;
                    dmg = 2;
                    cost = 0;
                    break;
                default:
                   break;
            }
        }

    }
}
