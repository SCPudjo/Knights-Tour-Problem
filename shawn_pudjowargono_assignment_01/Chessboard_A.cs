using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shawn_pudjowargono_assignment_01
{
    partial class Chessboard
    {
        public int turn { get; set; }   // keeps track of number of turns passed, starts at 1
        // 64 Chessboard tiles arranged in an 8x8 grid
        public Chessboard_tile[,] tiles = new Chessboard_tile[8, 8];    
        public Knight knight;   // Knight object for the Knight's Turn 

        /*
         * Chessboard constructor
         */
        public Chessboard()
        {
            turn = 1;
            create_chessboard_tiles();
            update_chessboard_tile_accessibilities();
        }
    }
}