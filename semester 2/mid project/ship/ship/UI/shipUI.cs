using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using plane.Ships.BL;
using ship.DL;

namespace ship.UL

{
    class shipUI
    {
       public static ships add_ship()
        {
            char Latitude_Direction, Longitude_Direction;
            string Number, Latitude_Degree, Latitude_Minute,  Longitude_Degree, Longitude_Minute;
            Console.WriteLine("Enter Ship Number: ");
            Number = Console.ReadLine();
            Console.WriteLine("Enter Ship Latitude: ");
            Console.WriteLine("Enter Latitude’s Degree: ");
            Latitude_Degree = Console.ReadLine();
            Console.WriteLine("Enter Latitude’s Minute: ");
            Latitude_Minute = Console.ReadLine();
            Console.WriteLine("Enter Latitude’s Direction: ");
            Latitude_Direction =char.Parse( Console.ReadLine());
            Console.WriteLine("Enter Ship Longitude: ");
            Console.WriteLine("Enter Longitude’s Degree: ");
            Longitude_Degree = Console.ReadLine();
            Console.WriteLine("Enter Longitude’s Minute: ");
            Longitude_Minute = Console.ReadLine();
            Console.WriteLine("Enter Longitude’s Direction: ");
            Longitude_Direction = char.Parse(Console.ReadLine());
            ships ship = new ships(Number, Latitude_Degree, Latitude_Minute, Latitude_Direction, Longitude_Degree, Longitude_Minute, Longitude_Direction);
            return ship;
        }
     public static string ship_checker()
        {
            string checker = "";
            Console.WriteLine("Enter Ship Serial Number to find its position:");
            checker = Console.ReadLine();
           shipDL.ship_index_checker(checker);
            return checker;
        }
       public static void ships_position(int index)
        {
            Console.WriteLine("Ships position ");
            Console.WriteLine("Latitude " +shipDL.ship_water[index].Latitude_Degree + " \u00b0 " + shipDL.ship_water[index].Latitude_Minute + "\'" + shipDL.ship_water[index].Latitude_Direction + "\"");
            Console.WriteLine("Longitude " + shipDL.ship_water[index].Longitude_Degree + " \u00b0 " + shipDL.ship_water[index].Longitude_Minute + "\'" + shipDL.ship_water[index].Longitude_Direction + "\"");
        }

       public static void find_ship()
        {
            char Latitude_Direction, Longitude_Direction;
            Console.WriteLine("Enter Ship Latitude: ");
            Console.WriteLine("Enter Latitude’s Degree: ");
            string Latitude_Degree = Console.ReadLine();
            Console.WriteLine("Enter Latitude’s Minute: ");
            string Latitude_Minute = Console.ReadLine();
            Console.WriteLine("Enter Latitude’s Direction: ");
            Latitude_Direction = char.Parse(Console.ReadLine());
            Console.WriteLine("Enter Ship Longitude: ");
            Console.WriteLine("Enter Longitude’s Degree: ");
            string Longitude_Degree = Console.ReadLine();
            Console.WriteLine("Enter Longitude’s Minute: ");
            string Longitude_Minute = Console.ReadLine();
            Console.WriteLine("Enter Longitude’s Direction: ");
             Longitude_Direction = char.Parse(Console.ReadLine());
            for (int i = 0; i <shipDL.ship_water.Count; i++)
            {
                if (Latitude_Degree == shipDL.ship_water[i].Latitude_Degree && Latitude_Minute == shipDL.ship_water[i].Latitude_Minute && Latitude_Direction == shipDL.ship_water[i].Latitude_Direction && Longitude_Degree == shipDL.ship_water[i].Longitude_Degree && Longitude_Minute == shipDL.ship_water[i].Longitude_Minute && Longitude_Direction == shipDL.ship_water[i].Longitude_Direction)
                {
                    Console.WriteLine("Ship’s serial number is ");
                    Console.WriteLine(shipDL.ship_water[i].Number);
                }

            }
        }
       public static int changePosition()
        {
            int index = 0;
            Console.WriteLine("Enter Ship’s serial number whose position you want to change: ");
            string number = Console.ReadLine();
            for (int i = 0; i < shipDL.ship_water.Count; i++)
            {
                if (shipDL.ship_water[i].Number == number)
                {
                    index = i;
                }
            }
            return index;
        }
       public static void newposition(int index)
        {
            Console.WriteLine("Enter Ship Latitude: ");
            Console.WriteLine("Enter Latitude’s Degree: ");
            shipDL.ship_water[index].Latitude_Degree = Console.ReadLine();
            Console.WriteLine("Enter Latitude’s Minute: ");
            shipDL.ship_water[index].Latitude_Minute = Console.ReadLine();
            Console.WriteLine("Enter Latitude’s Direction: ");
            shipDL.ship_water[index].Latitude_Direction = char.Parse(Console.ReadLine());
            Console.WriteLine("Enter Ship Longitude: ");
            Console.WriteLine("Enter Longitude’s Degree:");
            shipDL.ship_water[index].Longitude_Degree = Console.ReadLine();
            Console.WriteLine("Enter Longitude’s Minute: ");
            shipDL.ship_water[index].Longitude_Minute = Console.ReadLine();
            Console.WriteLine("Enter Longitude’s Direction: ");
            shipDL.ship_water[index].Longitude_Direction = char.Parse(Console.ReadLine());
            
        }
    }

}
