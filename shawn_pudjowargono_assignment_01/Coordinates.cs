using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shawn_pudjowargono_assignment_01
{
    class Coordinates
    {
        public int x { get; set; } // row
        public int y { get; set; } // column

        /*
         * Coordinates constructor (empty)
         */
        public Coordinates() { }

        /*
         * Coordinates constructor
         */
        public Coordinates(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }
}
