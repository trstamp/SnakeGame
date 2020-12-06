using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame
{
    enum BoxType
    {
        item,
        super,
        rotten
    }
    class Box
    {
        //x and y refer to coordinate positions on the grid
        public int x
        {
            get;
            set;
        }
        public int y
        {
            get;
            set;
        }

        public BoxType boxType
        {
            get;
            set;
        }

        //default postion is (0,0)
        public Box(BoxType type)
        {
            x = 0;
            y = 0;
            boxType = type;
        }
    }
}
