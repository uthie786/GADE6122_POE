using static System.Console;
using System;
using System.Collections.Generic;
using System.Text;


namespace Gade6122_Part1_corrected
{
    [Serializable]
    public class Shop
    {
        public Character buyer;
        public Weapon[] weapon;
       [NonSerialized] protected static Random random = new Random();
        

        public Shop(Character temp)
        {
            buyer = temp;
            weapon = new Weapon[3];
            int rng = random.Next(2);
            for (int x = 0; x < 3; x++)
            {
                weapon[0] = RandomWeapon();
                weapon[1] = RandomWeapon();
                weapon[2] = RandomWeapon();
            }
        }

        private Weapon RandomWeapon()
        {
            
            MeleeWeapon meleeWeapon;
            RangedWeapon rangedWeapon;
           int rng = random.Next(2);
           if (rng == 0) //melee
            {
                rng = random.Next(2);
                if (rng == 0)
                {
                    meleeWeapon = new MeleeWeapon(MeleeWeapon.Types.Dagger, buyer.X, buyer.Y);
                    return meleeWeapon;
                }
                if (rng == 1)
                {
                    meleeWeapon = new MeleeWeapon(MeleeWeapon.Types.Longsword, buyer.X, buyer.Y);
                    return meleeWeapon;
                }
            }
            if (rng == 1)//ranged
            {
                rng = random.Next(2);
                if (rng == 0)
                {
                    rangedWeapon = new RangedWeapon(RangedWeapon.Types.Longbow, buyer.X, buyer.Y);
                    return rangedWeapon;
                }
                if (rng == 1)
                {
                    rangedWeapon = new RangedWeapon(RangedWeapon.Types.Rifle, buyer.X, buyer.Y);
                    return rangedWeapon;
                }
            }
            return null;
        }

        public bool CanBuy(int num)
        {
            if(num == 0)
            {
                if (weapon[num].Cost <= buyer.Purse)
                {
                    return true;
                }
               
                else return false;
            }
            if (num == 1)
            {
                if (weapon[num].Cost <= buyer.Purse)
                {
                    return true;
                }

                else return false;
            }
            if (num == 2)
            {
                if (weapon[num].Cost <= buyer.Purse)
                {
                    return true;
                }

                else return false;
            }
            else return false;
        }

        public void Buy(int num)
        {
            buyer.PickUp(weapon[num]);
            weapon[num] = RandomWeapon();
        }

        public string DisplayWeapon(int num)
        {
            return "Buy " + weapon[num].WeaponType + "for " + weapon[num].Cost + "Gold.";
        }
    }
 }

    


