using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shawn_pudjowargono_assignment_01
{
    class Knight : Accessibility
    {
        // List to hold Coordinates objects for each accessible tile within Knight's range
        // Accessibility is determined by on tiles that fall within the Knight's
        // movement range based on the knight_movements array inherited from the
        // Accessibility abstract class
        public List<Coordinates> accessible_tiles = new List<Coordinates>();

        // Coordinates object to represent knight's current position
        Coordinates coordinates = new Coordinates();

        /*
         * Knight constructor
         */
        public Knight(int x, int y)
        {
            this.coordinates.x = x;
            this.coordinates.y = y;
            update_accessibility();
        }

        /*
         * Updates list of Knight's accessbile tiles by adding all tiles within range
         * to the accessible_tiles List
         */
        public override void update_accessibility()
        {
            accessible_tiles = new List<Coordinates>();
            for (int i = 0; i < 8; i++)
            {
                if (this.coordinates.x + knight_movements[i, 0] >= 0 && 
                    this.coordinates.x + knight_movements[i, 0] <= 7 &&
                    this.coordinates.y + knight_movements[i, 1] >= 0 && 
                    this.coordinates.y + knight_movements[i, 1] <= 7)
                {
                    accessible_tiles.Add(new Coordinates((this.coordinates.x + 
                                                          knight_movements[i, 0]), 
                                                         (this.coordinates.y + 
                                                          knight_movements[i, 1])));
                }
            }
        }

        /*
         * Changes Knight's x and y coordinates by searching through all it's
         * accessible tiles and finding the tile with coordinates that match
         * the x and y arguments passed
         * 
         * Returns true upon successfully moving, which is used by the Chessboard
         * as a condition to increment turn number, update the new tile's step order
         * value and update all tile accessibility ratings
         * 
         * Returns false if the x and y coordinates passed are invalid, meaning the
         * requested tile does not fall within the Knight's range
         */
        public bool move(int x, int y)
        {
            for (int i = 0; i < this.accessible_tiles.Count; i++)
            {
                if (this.accessible_tiles[i].x == x && this.accessible_tiles[i].y == y)
                {
                    this.coordinates.x = x;
                    this.coordinates.y = y;
                    update_accessibility();
                    return true;
                }
            }
            return false;
        }
    }
}
