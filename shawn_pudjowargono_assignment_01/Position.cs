using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shawn_pudjowargono_assignment_01
{
    abstract class Position
    {
        public int row { get; set; }
        public int column { get; set; }

        public int[,] knight_movements =
            {{-1, -2}, {-1, 2}, {1, -2}, {1, 2},
             {-2, -1}, {-2, 1}, {2, -1}, {2, 1}};

        public abstract void update_accessibility();
    }
}
