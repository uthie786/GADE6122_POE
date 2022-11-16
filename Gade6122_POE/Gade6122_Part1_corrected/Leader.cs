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

            int index = random.Next(4);
            while (checkedDirection.Count < 4 && (!(vision[index] is EmptyTile)))
            {
                if (checkedDirection.Contains(index))
                    checkedDirection.Add(index);

                index = random.Next(4);
                if ((vision[(int)direction].X < heroX))
                {
                    this.Move(Movement.Right);
                    return Movement.NoMovemnt;
                }
                if ((vision[(int)direction].X > heroX))
                {
                    this.Move(Movement.Left);
                    return Movement.NoMovemnt;
                }
                if ((vision[(int)direction].X < heroY))
                {
                    this.Move(Movement.Up);
                    return Movement.NoMovemnt;
                }
                if ((vision[(int)direction].X > heroY))
                {
                    this.Move(Movement.Down);
                    return Movement.NoMovemnt;
                }
            }
            if (checkedDirection.Count == 4)
                return Movement.NoMovemnt;

            return (Movement)index;

        }
    }
}
