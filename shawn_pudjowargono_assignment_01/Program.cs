using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace shawn_pudjowargono_assignment_01
{
    class Program
    {
        // The below four string variables are used to generate the path of output files
        public static string current_directory = Environment.CurrentDirectory; // current working directory
        public static string output_directory = "\\..\\..\\output\\"; // output directory from CWD
        public static string non_intelligent_output = "ShawnPudjowargonoNonIntelligentMethod.txt"; // non intelligent method output file
        public static string heuristics_output = "ShawnPudjowargonoHeuristicsMethod.txt"; // heuristics method output file

        public static List<String> output_string; // String List that will store all the strings to be written to output file

        /*
         * Start heuristic strategy
         */
        public static void start_heuristic_strategy(Chessboard chessboard, int number_of_trials, Coordinates start_coordinates)
        {
            output_string = new List<string>(); // create new string List to store output

            Random random = new Random(); // used to generate random int 
            int random_tile_index;  // used to store random int generated in case of multiple tiles tied for lowest accessibility
            int trial_number = 1;   // keeps track of number of trials
            int lowest_accessibility; // declare int to store lowest accessbility level within range of knight

            List<Coordinates> priority_tiles;   // declare List of coordinates to hold tiles tied for lowest accessibilty
            double total_score = 0; // used to print final score at end by dividing total_score by trial_number

            int X; // declare x coordinate for use with coordinate system
            int Y; // declare y coordinate for use with coordinate system

            // loop once for each trial attempt
            for (int i = 0; i < number_of_trials; i++)
            {
                while (!chessboard.check_loss()) // continue with current trial until knight loses (unable to move to any new tiles)
                {
                    lowest_accessibility = 9;
                    priority_tiles = new List<Coordinates>();

                    // find lowest accessibility value amongst all tiles within reach, excluding those that 
                    // Knight has already reached
                    for (int j = 0; j < chessboard.knight.accessible_tiles.Count; j++)
                    {
                        X = chessboard.knight.accessible_tiles[j].x;
                        Y = chessboard.knight.accessible_tiles[j].y;

                        if (chessboard.tiles[X, Y].step_order == 0)
                        {
                            if (chessboard.tiles[X, Y].accessibility < lowest_accessibility)
                            {
                                lowest_accessibility = chessboard.tiles[X, Y].accessibility;
                            }
                        }
                    }

                    // Add all tiles within reach that match the lowest accessibility level
                    // to priority_tiles List
                    for (int j = 0; j < chessboard.knight.accessible_tiles.Count; j++)
                    {
                        X = chessboard.knight.accessible_tiles[j].x;
                        Y = chessboard.knight.accessible_tiles[j].y;

                        if (chessboard.tiles[X, Y].accessibility == lowest_accessibility)
                        {
                            priority_tiles.Add(new Coordinates(X, Y));
                        }
                    }

                    // Randomly select tile to move to amongst tiles tied for lowest accessbility level
                    random_tile_index = random.Next(0, priority_tiles.Count);
                    // Move to tile
                    chessboard.move_knight(priority_tiles[random_tile_index].x, priority_tiles[random_tile_index].y);
                }
                output_string.Add("Trial " + trial_number + ": The knight was able to successfully touch "+ chessboard.turn + " squares.");
                trial_number++;
                total_score += chessboard.turn; // add score to total score
                chessboard.get_chessboard_step_order(output_string);

                chessboard = new Chessboard();  // reset chessboard
                chessboard.create_knight(start_coordinates.x, start_coordinates.y); // reset knight position
            }
            output_string.Add("Average Score: " + (total_score / number_of_trials));


            // print output to heuristic txt file
            System.IO.File.WriteAllLines(@current_directory + output_directory + heuristics_output, output_string);
        }

        /*
         * Start non-intelligent strategy
         */
        public static void start_non_intelligent_strategy(Chessboard chessboard, int number_of_trials, Coordinates start_coordinates)
        {
            output_string = new List<string>(); // create new string List to store output

            Random random = new Random();
            int random_tile_index;
            int trial_number = 1;
            double total_score = 0;

            for (int i = 0; i < number_of_trials; i++)
            {
                while (!chessboard.check_loss())
                {
                    random_tile_index = random.Next(0, chessboard.knight.accessible_tiles.Count);
                    chessboard.move_knight(chessboard.knight.accessible_tiles[random_tile_index].x, chessboard.knight.accessible_tiles[random_tile_index].y);
                }
                output_string.Add("Trial " + trial_number + ": The knight was able to successfully touch " + chessboard.turn + " squares.");
                trial_number++;
                total_score += chessboard.turn; // add score to total score
                chessboard.get_chessboard_step_order(output_string);

                chessboard = new Chessboard();
                chessboard.create_knight(start_coordinates.x, start_coordinates.y);
            }
            output_string.Add("Average Score: " + (total_score / number_of_trials));

            // print output to non intelligent txt file
            System.IO.File.WriteAllLines(@current_directory + output_directory + non_intelligent_output, output_string);
        }

        /*
         * Starts Knight's Tour Problem based on input from Windows Form
         */ 
        public static void Start_Knights_Tour(int start_x, int start_y, int strategy, int number_of_trials)
        {
            // Create Coordinates object to store Knight's start position
            Coordinates start_coordinates = new Coordinates(start_x, start_y);

            Chessboard chessboard = new Chessboard(); // Create Chessboard
            chessboard.create_knight(start_coordinates.x, start_coordinates.y); // Create Knight based on start coordinates

            // Call requested strategy number_of_trails number of times
            // Strategy of 0 is Non-intelligent, else, Heuristic
            if (strategy == 0)
            {
                start_non_intelligent_strategy(chessboard, number_of_trials, start_coordinates);
            }
            else
            {
                start_heuristic_strategy(chessboard, number_of_trials, start_coordinates);
            }
        }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]

        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Windows_Form());
        }
    }
}