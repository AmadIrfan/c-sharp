using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using pro.BL;

namespace pro.UI
{
    class roomUI
    {
        public static int avaliable2;
        // manage availbility of rooms
        public static void manage()
        {
            int total, booked, available;
            Console.WriteLine("Enter the total number of the rooms in the hotel: ");
            total = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the number of rooms which are booked: ");
            booked = int.Parse(Console.ReadLine());
            available = total - booked;
            avaliable2 = available;
            Console.WriteLine("So the number of available rooms are: " + available);
        }
        // function to see rooms data
        public static void currentroomsdata()
        {
            Console.WriteLine("ROOM NAME" + "               " + "ROOM PRICE\n");
            DL.roomDL.viewrooms();
        }
        public static void changeprice()
        {
            DL.roomDL.searchforchangingroomname();
            for (int i = 0; i < DL.roomDL.roomlist.Count; i++)
            {
                Console.WriteLine(DL.roomDL.roomlist[i].roomname + "       " + DL.roomDL.roomlist[i].roomprice);
            }
        }
        // function to see the number of available rooms as a customer
        public static void seeavailable(int available)
        {
            Console.WriteLine("Dear customer////");
            Console.WriteLine("The number of available rooms are: " + available);
        }
        // function to see the prices of different rooms as a customer
        public static void seenamesprices()
        {
            Console.WriteLine("\n                         ROOMS DATA\n");
            for (int i = 0; i <DL.roomDL.roomlist.Count; i++)
            {
                Console.WriteLine(DL.roomDL.roomlist[i].roomname + "............." +DL.roomDL.roomlist[i].roomprice);
            }
        }
        // function to pay the bill of the hotel
        public static void hotelbillforroombooking(long totalbillpaid)
        {
            DL.roomDL.hotelbook(totalbillpaid);

        }
        // function for taking hotel room
        public static room ron()
        {
            string rn;
            Console.WriteLine("Enter the name of the room you have booked: ");
            rn = Console.ReadLine();
            room rr = new room(rn);
            return rr;
        }
        public static void write()
        {
            Console.WriteLine("Invalid Choice!!! Try Again please  :) ");

        }
        public static room day()
        {
            int days;
            Console.WriteLine("Enter the number of days for which you have booked the room: ");
            days = int.Parse(Console.ReadLine());
            room r = new room(days);
            return r;
        }
        public static void total(long totalbillpaid)
        {
            Console.WriteLine("!Dear customer....");
            Console.WriteLine("\nYour total bill is: " + totalbillpaid);
        }
    }
}
