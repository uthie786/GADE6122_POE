using System;
using System.Collections.Generic;
using System.Text;

namespace Gade6122_Part1_corrected
{
    internal class Leader : Enemy
    { 
        private Tile target { get; set; }

        public Leader(int x, int y) : base(x, y, 2, 20)
        {
          
        }
        public void SetTarget(Hero hero)
        {
            this.target = hero;
        }
        public override Movement ReturnMove(Movement move = Movement.NoMovemnt)
        {
           Random random = new Random();
           int direction = random.Next(0, 4);
            int heroX = target.X;
            int heroY = target.Y;
           List<int> checkedDirection = new List<int>();

            while (checkedDirection.Count < 4)
            {

                if (direction == 0 && !checkedDirection.Contains(direction))
                {
                    if (this.Y > heroY)
                    {
                        if (vision[direction] is EmptyTile || vision[direction] is Weapon)
                        {
                            this.Move(Movement.Up);
                            return Movement.NoMovemnt;
                        }
                    }
                }
                if (direction == 1 && !checkedDirection.Contains(direction))
                {
                    if (this.x < heroX)
                    {
                        if (vision[direction] is EmptyTile || vision[direction] is Weapon)
                        {
                            this.Move(Movement.Right);
                            return Movement.NoMovemnt;
                        }
                    }
                }
                if (direction == 2 && !checkedDirection.Contains(direction))
                {
                    if (this.x > heroX )
                    {
                        if (vision[direction] is EmptyTile || vision[direction] is Weapon)
                        {
                            this.Move(Movement.Left);
                            return Movement.NoMovemnt;
                        }
                    }
                }
                if (direction == 3 && !checkedDirection.Contains(direction))
                {
                    if (this.Y < heroY)
                    {
                        if (vision[direction] is EmptyTile || vision[direction] is Weapon)
                        {
                            this.Move(Movement.Down);
                            return Movement.NoMovemnt;
                        }
                    }
                }
                direction = random.Next(0, 4);
            }

            return (Movement.NoMovemnt);

        }
    }
}
