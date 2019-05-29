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
        public Knight knight;

        public Chessboard()
        {
            turn = 1;
            create_chessboard_tiles();
            update_chessboard_tile_accessibilities(); // might be redundant
        }

        public void create_chessboard_tiles()
        {
            for (int i = 0; i < 8; i++)
            {
                for (int k = 0; k < 8; k++)
                {
                    tiles[i, k] = new Chessboard_tile(i,k, this);
                }
            }
        }

        public void create_knight(int x, int y)
        {
            knight = new Knight(x, y);
            tiles[x, y].step_order = turn; // set start tile to value of 1
            update_chessboard_tile_accessibilities();
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

        public void move_knight(int x, int y)
        {
            if (tiles[x, y].step_order == 0)
            {
                if (knight.move(x, y))
                {
                    turn++;
                    tiles[x, y].step_order = turn;
                    update_chessboard_tile_accessibilities();
                }
                
            }
            else
            {
                //Console.WriteLine("Error: Knight has already been on this tile\n");
            }
        }

        public void update_chessboard_tile_accessibilities()
        {
            for (int i = 0; i < 8; i++)
            {
                for (int k = 0; k < 8; k++)
                {
                    tiles[i, k].update_accessibility();
                }
            }
        }

        public bool check_loss()
        {
            for (int i = 0; i < knight.accessible_tiles.Count; i++)
            {
                int X = knight.accessible_tiles[i].x;
                int Y = knight.accessible_tiles[i].y;

                // check all accessible tile step_orders are greater than 0, meaning they have been steped on
                if (tiles[X,Y].step_order == 0)
                {
                    return false; // return false as there is still a tile within reach with a step_order value of 0, 
                                  // meaning the knight has never been there before
                }
            }   
            return true;
        }
    }
}
