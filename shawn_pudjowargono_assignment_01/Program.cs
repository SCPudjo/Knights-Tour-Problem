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

            Console.WriteLine("Test");
            Chessboard chessboard = new Chessboard();
            Console.WriteLine("Test");
            chessboard.display_chessboard();
            chessboard.tiles[0, 0].step_order = 1;
            chessboard.tiles[2, 1].step_order = 2;
            chessboard.tiles[3, 3].step_order = 3;
            chessboard.tiles[4, 5].step_order = 4;
            Console.WriteLine();
            chessboard.display_chessboard();
            Console.WriteLine();

            Console.Write("Knight current pos: {0}, {1}\n", chessboard.knight.row, chessboard.knight.column);
            chessboard.knight.display_accessible_tiles();
            Console.WriteLine();

            chessboard.knight.row = 7;
            chessboard.knight.column = 7;
            chessboard.knight.update_accessible_tiles();
            Console.Write("Knight current pos: {0}, {1}\n", chessboard.knight.row, chessboard.knight.column);
            chessboard.knight.display_accessible_tiles();



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
