using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shawn_pudjowargono_assignment_01
{
    abstract class Accessibility
    {
        // Multidimensional int array initialized to hold all knight movement patterns stored in int arrays
        public int[,] knight_movements =
            {{-1, -2}, {-1, 2}, {1, -2}, {1, 2},
             {-2, -1}, {-2, 1}, {2, -1}, {2, 1}};
        
        // Abstract method that will be used by Knight object to update it's list of accessible tiles
        // and by Chessboard_tile object to update it's own accessbility rating
        public abstract void update_accessibility();
    }
}
