﻿using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shawn_pudjowargono_assignment_01
{
    class Knight : Accessibility
    {
        // List to hold Coordinates objects for all accessible tiles
        public List<Coordinates> accessible_tiles = new List<Coordinates>();

        // Coordinate object to represent knight's current position
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
         * Updates list of knight's accessbile tiles by add all tiles within range
         * based on knight's movement pattern from Accessibility abstract class
         */
        public override void update_accessibility()
        {
            accessible_tiles = new List<Coordinates>();
            for (int i = 0; i < 8; i++)
            {
                if (this.coordinates.x + knight_movements[i, 0] >= 0 && this.coordinates.x + knight_movements[i, 0] <= 7 &&
                    this.coordinates.y + knight_movements[i, 1] >= 0 && this.coordinates.y + knight_movements[i, 1] <= 7)
                {
                    accessible_tiles.Add(new Coordinates((this.coordinates.x + knight_movements[i, 0]), 
                                                         (this.coordinates.y + knight_movements[i, 1])));
                }
            }
        }

        /*
         * Changes knight's x and y coordinates by searching through all it's
         * accessible tiles and finding the tile with coordinates that match
         * the x and y arguments passed
         */
        public bool move(int x, int y)
        {
            for (int i = 0; i < this.accessible_tiles.Count; i++)
            {
                if (this.accessible_tiles[i].x == x && this.accessible_tiles[i].y == y)
                {
                    this.coordinates.x = x;
                    this.coordinates.y = y;
                    //Console.WriteLine("Knight New Position:");
                    //coordinates.display_coordinates();
                    update_accessibility();
                    return true;
                }
            }
            //Console.WriteLine("Error: Requested Row/Column is out of reach!");
            return false;
        }

        /*
         * Print all tiles within knight's range to console
         */
        public void display_accessible_tiles()
        {
            Console.WriteLine("Accessible tiles: ");
            for (int i = 0; i < accessible_tiles.Count; i++)
            {
                accessible_tiles[i].display_coordinates();
            }
        }

        /*
         * Print knight's current coordinates to console
         */
        public void display_current_position()
        {
            Console.WriteLine("Knight Current Position:");
            coordinates.display_coordinates();
        }
    }
}
