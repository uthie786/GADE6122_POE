using static System.Console;
using System;
using System.Collections.Generic;
using System.Text;


namespace Gade6122_Part1_corrected
{
    public class Shop
    {
        public Character buyer;
        Weapon[] weapon;
        protected static Random random = new Random();
        

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

        }

        public string DisplayWeapon(int num)
        {

        }
    }
 }

    


