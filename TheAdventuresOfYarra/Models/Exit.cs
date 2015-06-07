using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheAdventuresOfYarra.Models
{
    class Exit
    {
        public Tile exitTile;
        public Direction direction;
    }

    enum Direction
    {
        North,
        East,
        South,
        West
    }
}
