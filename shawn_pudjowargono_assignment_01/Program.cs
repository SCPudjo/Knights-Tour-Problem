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

        public static string current_directory = Environment.CurrentDirectory;
        public static string output_directory = "\\..\\..\\output\\";
        public static string non_intelligent_output = "ShawnPudjowargonoNonIntelligentMethod.txt";
        public static string heuristics_output = "ShawnPudjowargonoHeuristicsMethod.txt";
        public static List<String> output_string;

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
         * Returns int value greater than 1 of the number of trails user wants to attempt the Knight's Tour
         */
        public static int get_number_of_trials()
        {
            Console.WriteLine("How many trials?");
            int num;
            while (true)
            {
                try
                {
                    num = int.Parse(Console.ReadLine());
                    if (num < 1)
                    {
                        throw new Exception();
                    }
                    else
                    {
                        if (num > 1)
                        {
                            Console.WriteLine("You selected {0} trails.", num);
                        }
                        else
                        {
                            Console.WriteLine("You selected {0} trail.", num);
                        }
                        
                        return num;
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid Entry, please enter a number greater than zero:");
                }
            }
        }

        /*
         * Returns int value of 0 or 1, 0 representing Non-intelligence strategy and 1 representing Heuristic strategy
         */
        public static int get_strategy()
        {
            Console.WriteLine("Please select a strategy:\n    0) Non-intelligent Strategy\n    1) Heuristic Strategy");
            int num;
            string strategy;
            while (true)
            {
                try
                {
                    num = int.Parse(Console.ReadLine());
                    if (num != 0 && num != 1)
                    {
                        throw new Exception();
                    }
                    else
                    {
                        strategy = (num == 0) ? "You selected 'Non-intelligent Strategy'" : "You selected 'Heuristic Strategy'";
                        Console.WriteLine(strategy);
                        return num;
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid Entry, please enter 0 or 1:");
                }
            }
        }
    
        /*
         * Returns Coordinate object storing knight's starting x and y coordinates based on user input
         */
        public static Coordinates get_knight_start_position()
        {
            Console.WriteLine("Please enter a start tile coordinates:");
            int start_x;
            int start_y;
            while (true)
            {
                try
                {
                    Console.WriteLine("Enter X: ");
                    start_x = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Y: ");
                    start_y = int.Parse(Console.ReadLine());

                    if (start_x < 0 || start_x > 7 || start_y < 0 || start_y > 7)
                    {
                        throw new Exception();
                    }
                    else
                    {
                        return new Coordinates(start_x, start_y);
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid Entry, please only enter numbers between 0 and 7:");
                }
            }
            
        }

        //public static void Start_Console()
        //{
        //    Coordinates start_coordinates; // declare Coordinates object to store Knight's start position
        //    int strategy;                  // declare int to store selected strategy, 0 being Non-intelligence, 1 being Heuristic
        //    int number_of_trials;          // declare int to store user input for number of trials

        //    Chessboard chessboard = new Chessboard(); // create chessboard

        //    Console.WriteLine("Welcome to the Knight's Tour Problem simulation.");

        //    start_coordinates = get_knight_start_position();    // get knight start coordinates
        //    chessboard.create_knight(start_coordinates.x, start_coordinates.y); // create knight based on start coordinates

        //    Console.WriteLine();
        //    chessboard.knight.display_current_position();   // displays knight's start coordinates
        //    chessboard.display_chessboard_step_order();     // displays knight's start position on chessboard
        //    chessboard.display_chessboard_accessibility();  // displays chessboard tile accessibility levels
        //    Console.WriteLine();

        //    strategy = get_strategy();  // get strategy
        //    number_of_trials = get_number_of_trials(); // get number of trials

        //    Console.WriteLine("Please press any key to begin.");
        //    Console.ReadKey();
        //    // call requested strategy number_of_trails number of times
        //    if (strategy == 0)
        //    {
        //        start_non_intelligent_strategy(chessboard, number_of_trials, start_coordinates);
        //    }
        //    else
        //    {
        //        start_heuristic_strategy(chessboard, number_of_trials, start_coordinates);
        //    }
        //    Console.WriteLine("Simulation complete. Please press any key to close this program.\n");
        //    Console.ReadKey();
        //}

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





            Console.ReadKey();
        }
    }
}