using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shawn_pudjowargono_assignment_01
{
    class Program
    {
        static void Main(string[] args)
        {

            Chessboard chessboard = new Chessboard();
            chessboard.display_chessboard_accessibility();
            Console.WriteLine();
            chessboard.display_chessboard_step_order();
            Console.WriteLine();
            
            chessboard.knight.display_current_position();
            chessboard.knight.display_accessible_tiles();
            Console.WriteLine();

            int row;
            int col;
            //while (true)
            //{
            //    try
            //    {
            //        Console.WriteLine("Enter row: ");
            //        row = int.Parse(Console.ReadLine());
            //        Console.WriteLine("Enter col: ");
            //        col = int.Parse(Console.ReadLine());

            //        chessboard.move_knight(row, col);
            //        chessboard.display_chessboard_step_order();
            //        chessboard.knight.display_current_position();
            //        chessboard.knight.display_accessible_tiles();
            //        Console.WriteLine();
            //    }
            //    catch (Exception e)
            //    {
            //        Console.WriteLine("Invalid Entry, please try again");
            //    }
            //}

            //Console.WriteLine("Welcome to the Knight's Tour Problem simulation.");
            //Console.WriteLine("Please select a strategy:\n    0) Non-intelligent Strategy\n    1) Heuristic Strategy");
            //int num;
            //while (true)
            //{
            //    try
            //    {
            //        num = int.Parse(Console.ReadLine());
            //        if (num != 0 && num != 1)
            //        {
            //            throw new Exception(); 
            //        }
            //        else
            //        {
            //            break;
            //        }
            //    }
            //    catch (Exception e)
            //    {
            //        Console.WriteLine("Invalid Entry, please selection 0 or 1:");
            //    }        
            //}
            //Console.WriteLine("You selected: {0}", num);
            //Console.Read();




            Console.Read();
        }
    }
}
