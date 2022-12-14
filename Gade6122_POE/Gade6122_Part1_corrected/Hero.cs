using System;
using System.Collections.Generic;
using System.Text;

namespace Gade6122_Part1_corrected
{
    [Serializable]
    public class Hero : Character //Hero character
    {
       
        public Hero(int x, int y, int hp) : base(x,y)
        {
            this.hp = hp;
            this.maxHp = hp;
            this.damage = 2;
            weapon = new MeleeWeapon(MeleeWeapon.Types.Barehanded); 
            
            

        }
        //going to have to change for hero moving onto a GOLD or WEAPON tile for example
        //for now Hero can only move onto EmptyTiles
        public override Movement ReturnMove(Movement move = Movement.NoMovemnt)
        {
            if (move == Movement.NoMovemnt)
            {
                return move;
            }
            if (vision[(int)move] is EmptyTile || vision[(int)move] is Gold || vision[(int)move] is MeleeWeapon || vision[(int)move] is RangedWeapon)
            {
                return move;
            }
            
            return Movement.NoMovemnt;
        }
        public override string ToString() //tostring method thats used to print the Hero stats
        {
            return $"Player stats: \n" +
                $"HP: {hp}/{maxHp}\n" +
                $"Weapon: {weapon.WeaponType}\n" +
                $"Damage: {weapon.DMG} \n" +
                $"Range: {weapon.Range} \n" +
                $"Durability: {weapon.Durability}\n" +
                $"Total Gold: {Purse}\n" +
                $"[{x}, {y}]";                   
        }
    }
}
