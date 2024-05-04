using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using pro.BL;
using pro.DL;

namespace pro.UI
{
    class customerUI
    {
        public static string customerpath = "customer information for room booking.txt";
        public static void addcustomersforroombooking()
        {
                    List<room> roomsList = new List<room>();
            int n, index = 0;
            string name, idcardnumber;
            Console.WriteLine("How many customers you want to enter at this time: ");
            n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Enter the name of the customer: ");
                name = Console.ReadLine();
                Console.WriteLine("Enter the id card number of the customer: ");
                while (true)
                {
                    idcardnumber = Console.ReadLine();
                    // validation for the id card number
                    index = idcardnumber.Length;
                    if (index > 13 || index < 13)
                    {
                        Console.WriteLine("Invalid id card number!!!!!!!!!");
                        Console.WriteLine("Please enter again:");
                        index = 0;
                        continue;
                    }
                    index = 0;
                    break;
                }
                int m = 0, numberofdays;
                string roomname;
                Console.WriteLine("How many rooms you want to enter: ");
                m = int.Parse(Console.ReadLine());
                for (int j = 0; j < m; j++)
                {
                    Console.WriteLine("Enter the name of the room: ");
                    roomname = Console.ReadLine();
                    Console.WriteLine("Enter number of the days you want to book the enter: ");
                    numberofdays = int.Parse(Console.ReadLine());
                    room r = new room(roomname,idcardnumber, numberofdays);
                    roomsList.Add(r);
                roomDL.storebookedroomdataintolist(r);

                }
                customer c = new customer(name, idcardnumber,roomsList);
                DL.customerDL.addcustomersintolist(c);
                DL.customerDL.storecustomerdataintofile(customerpath, c);
            }
        }
        // function to delete the customer
        public static void deletecustomers()
        {
            customerrecord();
            string name;
            Console.WriteLine("Enter the name of the customer you want to delete from the system: ");
            name = Console.ReadLine();
            customer c = new customer(name);
            DL.customerDL.searchfordeleteincustomerlist(c);
            customerrecord();
            DL.customerDL.forstoringalllistatonceintolist(customerpath,c);
        }
        // function to see customer record
        public static void customerrecord()
        {
            Console.WriteLine("\n\n");
            foreach(customer c in DL.customerDL.customerlistforroom)
            {
                Console.Write(c.name + "  " + c.idcardnumber+"  ");
                Console.ReadKey();
                foreach(room r in DL.roomDL.bookedroomlist)
                {
                    Console.WriteLine(r.roomname + "  " + r.numberofdays);
                }
            }
        }
        // function for taking name and idcardnumber
        public static customer restaurant()
        {
            int index = 0;
            string name, idcard;
            Console.WriteLine("Dear customer please enter your name: ");
            name = Console.ReadLine();
            Console.WriteLine("Dear customer please enter your id card number: ");
            while (true)
            {
                idcard = Console.ReadLine();
                // validation for the id card number
                index = idcard.Length;
                if (index > 13 || index < 13)
                {
                    Console.WriteLine("Invalid id card number!!!!!!!!!");
                    Console.WriteLine("Please enter again:");
                    index = 0;
                    continue;
                }
                index = 0;
                break;
            }
            customer c = new customer(name, idcard);
            return c;
        }

    }
}
