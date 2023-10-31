using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot
{
    internal class Position
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Direction Facing { get; set; }
    }
    internal enum Direction
    {
        NORTH, EAST,
        SOUTH, WEST
    }
}
