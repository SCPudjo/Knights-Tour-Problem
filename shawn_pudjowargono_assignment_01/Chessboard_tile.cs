using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shawn_pudjowargono_assignment_01
{
    class Chessboard_tile : Accessibility
    {
        // Object representing x, y coordinates
        Coordinates coordinates = new Coordinates();

        // Order in which Knight reached this tile based on the current turn
        // Set to 0 upon construction, meaning the Knight has not reached this tile
        public int step_order { get; set; }

        // Accessibility rating based on how many tiles within range (based on 
        // Knight's movement pattern) have a step_order value of 0
        public int accessibility { get; set; }

        // Reference to Chessboard that current tile belongs to, used to allow this tile
        // to interact with other Chessboard_tile objects to update accessbility
        Chessboard chessboard;

        /*
         * Chessboard_tile constructor
         * 
         * Upon construction of the Chessboard object, the Chessboard will pass a  
         * reference of itself to each individual tile so that each tile will be 
         * able to "see" all other tiles on the Chessboard through it's tiles array
         */
        public Chessboard_tile(int x, int y, Chessboard chessboard)
        {
            step_order = 0;
            this.coordinates.x = x;
            this.coordinates.y = y;
            this.chessboard = chessboard;
        }

        /*
         * Update value of accessibility by checking all tiles within range 
         * based on Knight's movement pattern in the Accessibility class 
         * and checking how many of them have been stepped on already
         * 
         * Each accessible tile with a step_order value of 0 will increase 
         * accessibility by 1
         */
        public override void update_accessibility()
        {
            accessibility = 0;
            for (int i = 0; i < 8; i++)
            {
                // Checks that x and y coordinate values do not go below 0 or above 7 
                // (would be outside of 8x8 chessboard)
                if (this.coordinates.x + knight_movements[i, 0] >= 0 && 
                    this.coordinates.x + knight_movements[i, 0] <= 7 &&
                    this.coordinates.y + knight_movements[i, 1] >= 0 && 
                    this.coordinates.y + knight_movements[i, 1] <= 7)
                {
                    int X = this.coordinates.x + knight_movements[i, 0];
                    int Y = this.coordinates.y + knight_movements[i, 1];

                    if (chessboard.tiles[X, Y].step_order == 0)
                    {
                        accessibility++;
                    }
                }
            }
        }
    }
}
