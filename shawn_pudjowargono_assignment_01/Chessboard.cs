using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shawn_pudjowargono_assignment_01
{
    class Chessboard
    {
        public static int knight_start_row = 3;
        public static int knight_start_col = 4;
        public int turn { get; set; }
        public Chessboard_tile[,] tiles = new Chessboard_tile[8, 8];
        public Knight knight = new Knight(knight_start_row, knight_start_col);

        public Chessboard()
        {
            turn = 1;
            create_chessboard_tiles();
            tiles[knight_start_row, knight_start_col].step_order = turn;
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

        public void display_chessboard_step_order()
        {
            Console.WriteLine("Chessboard Step Order:");
            for (int i = 0; i < 8; i++)
            { 
                for (int k = 0; k < 8; k++)
                {
                    Console.Write("[{0}]", tiles[i, k].step_order.ToString("00"));
                }
                Console.WriteLine();
            }
        }

        public void display_chessboard_accessibility()
        {
            Console.WriteLine("Chessboard Accessibility:");
            for (int i = 0; i < 8; i++)
            {
                for (int k = 0; k < 8; k++)
                {
                    Console.Write("[{0}]", tiles[i, k].accessibility);
                }
                Console.WriteLine();
            }
        }

        public void move_knight(int row, int column)
        {
            if (tiles[row, column].step_order == 0)
            {
                if (knight.move(row, column))
                {
                    turn++;
                    tiles[row, column].step_order = turn;
                }
                
            }
            else
            {
                Console.WriteLine("Error: Knight has already been on this tile\n");
            }
        }

        public void strategy_non_intelligent_method()
        {

        }

        public void strategy_heuristic_method()
        {

        }

        public bool check_loss()
        {
            for (int i = 0; i < knight.accessible_tiles.Count; i++)
            {
                var tuple = knight.accessible_tiles[i];
                var tuple2 = Tuple.Create(2, 2);
                var tuple3 = tuple2;
                Console.WriteLine(tuple.Equals(tuple2));
            }   
            return true;
        }
    }
}
