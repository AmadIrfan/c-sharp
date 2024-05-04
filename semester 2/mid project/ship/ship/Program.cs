using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using plane.Ships.BL;
using ship.DL;
using ship.UL;
namespace ship
{
    class Program
    {

        static void Main(string[] args)
        {
            shipDL.ShipDataFromFile();
            Console.WriteLine("loaded data");
           manuUI.clearScreen();
            int input = 0;
            do
            {
                input =manuUI.menu();
                Console.ReadKey();
                //Console.WriteLine(input);
                if (input == 1)
                {
                    ships temp;
                    temp = shipUI.add_ship();
                    shipDL.addShip(temp);
                    manuUI.clearScreen();
                }
                if (input == 2)
                {
                    string checker =shipUI.ship_checker();
                    int index = shipDL.ship_index_checker(checker);
                    shipUI.ships_position(index);
                    manuUI.clearScreen();
                }
                if (input == 3)
                {
                    shipUI.find_ship();
                    manuUI.clearScreen();
                }
                if (input == 4)
                {
                    int index;
                   index= shipUI.changePosition();
                    shipUI.newposition(index);
                    manuUI.clearScreen();
                }
                if (input == 5)
                {
                    manuUI.clearScreen();
                    break;
                }
                shipDL.ShipDataToFile();
            }
            while (input < 5);
        }

    }
}
