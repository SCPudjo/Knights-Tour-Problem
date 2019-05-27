using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shawn_pudjowargono_assignment_01
{
    class Knight
    {
        public int row { get; set; }
        public int column { get; set; }

        public ArrayList accessible_tiles = new ArrayList();

        public int[,] knight_movements =
            {{-1, -2}, {-1, 2}, {1, -2}, {1, 2},
             {-2, -2}, {-2, 2}, {2, -2}, {2, 2}};

        public Knight()
        {
            row = 3;
            column = 4;
            update_accessible_tiles();
        }

        public void update_accessible_tiles()
        {
            accessible_tiles = new ArrayList();
            for (int i = 0; i < 8; i++)
            {
                if (this.row + knight_movements[i, 0] >= 0 && this.row + knight_movements[i, 0] <= 7 &&
                    this.column + knight_movements[i, 1] >= 0 && this.column + knight_movements[i, 1] <= 7)
                {
                    accessible_tiles.Add(this.row + knight_movements[i, 0] + ", " + (this.column + knight_movements[i, 1]));
                }
            }
        }

        public void display_accessible_tiles()
        {
            foreach (string tile in accessible_tiles)
            {
                Console.WriteLine(tile);
            }
        }

    }
}
