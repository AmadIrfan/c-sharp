using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Point_Line.PointLine.BL;
using Point_Line.PointLine.UI;
using Point_Line.PointLine.DL;

namespace Point_Line_YasirHassan
{
    class Program
    {
        static Line MyLine;
        static void Main(string[] args)
        {
            //Path Of The Stored Data......
            string path = "points.txt";
            //Do-While Loop For Repetition
            do
            {
                //Showing Main Menu......
                Output.Header();
                int option = Output.Menu();
                //Make A Line........
                if (option == 1)
                {
                    MyLine = (Logic.option1());
                    Logic.storeDataIntoFile(MyLine, path);
                    Console.ReadKey();
                }
                //Update the Begin Point.....
                if (option == 2)
                {
                    MyLine = (Logic.option2(MyLine));
                    Logic.storeDataIntoFile(MyLine, path);
                    Console.ReadKey();
                }
                //Update the End Point......
                if (option == 3)
                {
                    MyLine = (Logic.option3(MyLine));
                    Logic.storeDataIntoFile(MyLine, path);
                    Console.ReadKey();
                }
                //Show the Beginning Point.......
                if (option == 4)
                {
                    Logic.option4(MyLine);
                    Console.ReadKey();
                }
                //Show the End Point........
                if (option == 5)
                {
                    Logic.option5(MyLine);
                    Console.ReadKey();
                }
                //Get the Length of Line.......
                if (option == 6)
                {
                    Logic.option6(MyLine);
                    Console.ReadKey();
                }
                //Get the Gradient of Line........
                if (option == 7)
                {
                    Logic.option7(MyLine);
                    Console.ReadKey();
                }
                //Distance of Begin Point from Zero.......
                if (option == 8)
                {
                    Logic.option8(MyLine);
                    Console.ReadKey();
                }
                //Distance of End Point from Zero........
                if (option == 9)
                {
                    Logic.option9(MyLine);
                    Console.ReadKey();
                }
                //Exit Function........
                if (option == 10)
                {
                    break;
                }
            }
            while (true);
        
        }
    }
}
