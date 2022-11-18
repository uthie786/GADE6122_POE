using System;
using System.Collections.Generic;
using System.Text;

namespace Gade6122_Part1_corrected
{
    [Serializable]
    public abstract class Weapon : Item
    {
        protected int dmg;
        protected int range;
        protected int durability;
        protected int cost ;
        protected string weaponType;

        public int DMG { get { return dmg; } set { dmg = value; } }
        public virtual int Range { get { return range; } set { range = value; } }
        public int Durability { get { return durability; } set { durability = value; } }
        public int Cost { get { return cost; } set { cost = value; } }
        public string WeaponType { get { return weaponType; } set { weaponType = value; } }

        public Weapon(int x, int y) : base(x, y)
        {

        }
        public override string ToString()
        {
            throw new NotImplementedException();
        }
    }
}
