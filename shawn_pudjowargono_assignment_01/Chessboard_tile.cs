using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shawn_pudjowargono_assignment_01
{
    class Chessboard_tile : Position
    {
        public int step_order { get; set; }
        public int accessibility { get; set; }

        public Chessboard_tile(int row, int column)
        {
            step_order = 0;
            this.row = row;
            this.column = column;
            update_accessibility();
        }

        public override void update_accessibility()
        {
            accessibility = 0;
            for (int i = 0; i < 8; i++)
            {
                if (this.row + knight_movements[i, 0] >= 0 && this.row + knight_movements[i, 0] <= 7 &&
                    this.column + knight_movements[i, 1] >= 0 && this.column + knight_movements[i, 1] <= 7)
                {
                    accessibility++;
                }
            }
        }


    }
}
