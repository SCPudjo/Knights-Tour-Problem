using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shawn_pudjowargono_assignment_01
{
    class Knight : Position
    {
        public ArrayList accessible_tiles = new ArrayList();

        public Knight(int row, int column)
        {
            this.row = row;
            this.column = column;
            update_accessibility();
        }

        public override void update_accessibility()
        {
            accessible_tiles = new ArrayList();
            for (int i = 0; i < 8; i++)
            {
                if (this.row + knight_movements[i, 0] >= 0 && this.row + knight_movements[i, 0] <= 7 &&
                    this.column + knight_movements[i, 1] >= 0 && this.column + knight_movements[i, 1] <= 7)
                {
                    accessible_tiles.Add(Tuple.Create((this.row + knight_movements[i, 0]), (this.column + knight_movements[i, 1])));
                }
            }
        }

        public void display_accessible_tiles()
        {
            for (int i = 0; i < accessible_tiles.Count; i++)
            {
                Console.WriteLine(accessible_tiles[i]);
            }
        }

        public bool move(int row, int column)
        {
            for (int i = 0; i < this.accessible_tiles.Count; i++)
            {
                if (this.accessible_tiles[i].Equals(Tuple.Create(row, column)))
                {
                    this.row = row;
                    this.column = column;
                    Console.WriteLine("Knight New Position: {0}, {1}\n", row, column);
                    update_accessibility();
                    return true;
                }
            }
            Console.WriteLine("Error: Requested Row/Column is out of reach!");
            return false;
        }

        public void display_current_position()
        {
            Console.WriteLine("Knight Current Position: {0}, {1}\n", row, column);
        }

    }
}
