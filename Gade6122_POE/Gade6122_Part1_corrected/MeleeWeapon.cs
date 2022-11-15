using System;
using System.Collections.Generic;
using System.Text;

namespace Gade6122_Part1_corrected
{
    public enum MTypes { Dagger, Longsword}
    internal class MeleeWeapon : Weapon
    {
        public MeleeWeapon(Types type, int x, int y) : base(x, y, '⚔')
        {
            //overridden range thing
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
                default:

                    break;
            }
        }

    }
}
