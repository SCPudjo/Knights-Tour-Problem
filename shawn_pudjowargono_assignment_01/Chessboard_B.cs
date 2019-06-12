using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shawn_pudjowargono_assignment_01
{
    partial class Chessboard
    {
        /*
         * Set each element in the tiles array to a Chessboard_tile object with appropriate x,y coordinate
         */
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

        /*
         * Initialize Knight object at x,y coordinates
         */
        public void create_knight(int x, int y)
        {
            knight = new Knight(x, y);
            tiles[x, y].step_order = turn; // set start tile to value of 1
            update_chessboard_tile_accessibilities();
        }

        /*
         * Adds representation of Knight movement order to a List of strings
         * to be used to print to output text files
         */ 
        public void get_chessboard_step_order(List<string> output_string)
        {
            string row = "";
            for (int i = 0; i < 8; i++)
            {
                for (int k = 0; k < 8; k++)
                {
                    row += "["+tiles[i, k].step_order.ToString("00")+"]";
                }
                output_string.Add(row); // add string to output string
                row = ""; // reset row string
            }
        }

        /*
         * Checks if the Chessboard_tile at x,y has been previously stepped on
         * by the Knight. If so, does nothing, otherwise, calls Knight.move()
         * to move Knight to that position, then calls update_chessboard_tile_accessibilities()
         * to update all tile accessibility ratings accordingly
         */
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

        /*
         *  Calls update_accessibility() on each Chessboard_tile in tiles array
         */
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

        /*
         * Checks the step_order value of all tiles within accessibility range of Knight and returns
         * true if there are no values of 0, indicating there are no more available tiles to move to,
         * otherwise returns false
         */
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
                                  // meaning the Knight has never been there before
                }
            }   
            return true;
        }
    }
}
