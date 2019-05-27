using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shawn_pudjowargono_assignment_01
{
    class Chessboard_tile
    {
        public int step_order { get; set; }
        public int accessibility { get; set; }

        public int row { get; set; }
        public int column { get; set; }

        public Chessboard_tile(int row, int column)
        {
            step_order = 0;
            this.row = row;
            this.column = column;
        }

        public void calculate_accessibility()
        {
            return;
        }
    }
}
