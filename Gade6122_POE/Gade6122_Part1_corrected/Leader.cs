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

        public override Movement ReturnMove(Movement move)
        {
           
        }
    }
}
