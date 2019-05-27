using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shawn_pudjowargono_assignment_01
{
    class Chessboard
    {
        public int turn { get; set; }
        public Chessboard_tile[,] tiles = new Chessboard_tile[8, 8];

        public Chessboard()
        {
            create_chessboard_tiles();
        }

        public void create_chessboard_tiles()
        {
            for (int i = 0; i < 8; i++)
            {
                for (int k = 0; k < 8; k++)
                {
                    tiles[i, k] = new Chessboard_tile(i,k);
                }
            }
        }

        public void display_chessboard()
        {
            for (int i = 0; i < 8; i++)
            { 
                for (int k = 0; k < 8; k++)
                {
                    Console.Write("[{0}]", tiles[i, k].step_order);
                }
                Console.WriteLine();
            }
        }

    }
}
