using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using pro.BL;

namespace pro.UI
{
    class credentialsUI
    {
        public static string credentialspath = "sign file.txt";

        public static credentials input()
        {
            UI.menuUI.header();
            string username, password, role;
            Console.WriteLine("Enter your name: ");
            username = Console.ReadLine();
            Console.WriteLine("Enter your password: ");
            password = Console.ReadLine();
            Console.WriteLine("Enter your role: ");
            role = Console.ReadLine();
            credentials s = new credentials(username, password, role);
            DL.credentialsDL.store(s, credentialspath);
            return s;
        }
        public static credentials inputforsignin()
        {
            string username, password;
            Console.WriteLine("Enter your name: ");
            username = Console.ReadLine();
            Console.WriteLine("Enter your password");
            password = Console.ReadLine();
            credentials cc = new credentials(username, password);
            return cc;
        }

        public static void sfun()
        {
            Console.WriteLine("You are not valid user");

        }
        public static string signin()
        {
            string rolee;
            credentials s = new credentials();
            Console.Clear();
            UI.menuUI.header();
            s = inputforsignin();
            rolee = DL.credentialsDL.searchforsignin(s);
            Console.WriteLine("\n\n");
            Console.WriteLine("          YOU ARE " + rolee);
            Console.ReadKey();
            return rolee;

        }
        // function for the receptionist menu
        public static void receptionistmenu()
        {
            int op = 0;
            while (true)
            {
                Console.Clear();
                UI.menuUI.header();
                Console.WriteLine("\n                                 WELCOME TO THE RECEPTIONIST MENU\n");
                Console.WriteLine("1-Calculate number of available rooms");
                Console.WriteLine("2-Customer record of room booking");
                Console.WriteLine("3-Delete customer record");
                Console.WriteLine("4-Current rooms data");
                Console.WriteLine("5-change the price of different rooms if needed");
                Console.WriteLine("6-exit");
                Console.WriteLine("Enter any option: ");
                op = UI.menuUI.takeoption();
                if (op == 6)
                {
                    break;
                }

                recep(op);
            }
        }
        // function for the customer menu
        public static void customermenu(int available, float givendiscount, float result, long totalbillpaid)
        {
            while (true)
            {
                int op = 0;
                Console.Clear();
                UI.menuUI.header();
                Console.WriteLine("\n                                 WELCOME TO THE CUSTOMER MENU\n");
                Console.WriteLine("1-Number of available rooms");
                Console.WriteLine("2-Check the prices of different rooms and see the names of the rooms");
                Console.WriteLine("3-Booking the room");
                Console.WriteLine("4-Use hotel restaurant");
                Console.WriteLine("5-To take discount on restaurant items");
                Console.WriteLine("6-Pay bill for the restaurant items");
                Console.WriteLine("7-To pay the bill for the rooms booking");
                Console.WriteLine("8-To exit the customer menu ");
                Console.WriteLine("Enter any option: ");
                op = UI.menuUI.takeoption();
                if (op == 8)
                {
                    break;
                }
                   cus(op, available, givendiscount, result, totalbillpaid);
            }
        }
        // function for the restaurant admin menu
        public static void admin(float givendiscount, float a)
        {
            int op = 0;
            while (true)
            {
                Console.Clear();
                UI.menuUI.header();
                Console.WriteLine("\n                                 WELCOME TO THE RESTAURANT ADMIN MENU\n");
                Console.WriteLine("1-See puchases");
                Console.WriteLine("2-Calculate profit and loss");
                Console.WriteLine("3-To see the price you have received after the discount");
                Console.WriteLine("4-Keep the record of employee");
                Console.WriteLine("5-Worker's salary record");
                Console.WriteLine("6-Delete workers");
                Console.WriteLine("7-Current products and their current prices");
                Console.WriteLine("8-exit");
                Console.WriteLine("Enter any option: ");
                op = UI.menuUI.takeoption();
                if (op == 8)
                {
                    break;
                }
                 restaurantadmin(givendiscount, op, a);
            }
        }
        public static void workermenu()
        {
            int op = 0;
            while (true)
            {
                Console.WriteLine("\n                                 WELCOME TO THE WORKER MENU\n");
                Console.WriteLine("1-Add new products");
                Console.WriteLine("2-exit");
                op = UI.menuUI.takeoption();
                if (op == 2)
                {
                    break;
                }
               
                workerpro(op);

            }
        }
        // function in which all the functions of the receptionist are performed
        public static void recep(int op)
        {
            // to check the number of available rooms
            if (op == 1)
            {
                Console.Clear();
                UI.menuUI.header();
                Console.WriteLine("\n\n");
                UI.roomUI.manage();
                Console.ReadKey();
                Console.Clear();
                UI.menuUI.header();
            }
            // to add new customers for room booking
            else if (op == 2)
            {
                Console.Clear();
                UI.menuUI.header();
                UI.customerUI.customerrecord();
                Console.WriteLine("\n\n");
                Console.ReadKey();
                Console.Clear();
                UI.menuUI.header();
            }
            // to delete customers record
            else if (op == 3)
            {
                Console.Clear();
                UI.menuUI.header();
                Console.WriteLine("\n\n");
                UI.customerUI.deletecustomers();
                Console.ReadKey();
                Console.Clear();
                UI.menuUI.header();
            }
            // current rooms data
            else if (op == 4)
            {
                Console.Clear();
                UI.menuUI.header();
                Console.WriteLine("\n\n\n\n");
                UI.roomUI.currentroomsdata();
                Console.ReadKey();
                Console.Clear();
                UI.menuUI.header();
            }
            // to update or change the price of any room if needed
            else if (op == 5)
            {
                Console.Clear();
                UI.menuUI.header();
                Console.WriteLine("\n\n");
                UI.roomUI.changeprice();
                Console.ReadKey();
                Console.Clear();
                UI.menuUI.header();
            }
            // to exit the receptionist menu
            else if (op == 6)
            {
                Console.Clear();
                UI.menuUI.header();
                UI.menuUI.mainmenu();
            }
        }
        // function for the customer
        static void cus(int op, int available, float givendiscount, float result, long totalbillpaid)
        {
            // to see the number of available rooms
            if (op == 1)
            {
                Console.Clear();
                UI.menuUI.header();
                Console.WriteLine("\n\n");
                UI.roomUI.seeavailable(UI.roomUI.avaliable2);
                Console.ReadKey();
                Console.Clear();
                UI.menuUI.header();
            }
            // to see the prices of different rooms and the names of the rooms
            else if (op == 2)
            {
                Console.Clear();
                UI.menuUI.header();
                Console.WriteLine("\n\n");
                UI.roomUI.seenamesprices();
                Console.ReadKey();
                Console.Clear();
                UI.menuUI.header();
            }
            // to book the rooms online
            else if (op == 3)
            {
                Console.Clear();
                UI.menuUI.header();
                Console.WriteLine("\n\n");
                UI.customerUI.addcustomersforroombooking();
                Console.ReadKey();
                Console.Clear();
                UI.menuUI.header();
            }
            // to use the hotel restaurant
            else if (op == 4)
            {
                Console.Clear();
                UI.menuUI.header();
                Console.WriteLine("\n\n");
                UI.productUI.useres();
                Console.ReadKey();
                Console.Clear();
                UI.menuUI.header();
            }
            // To take discount on restaurant items
            else if (op == 5)
            {
                Console.Clear();
                UI.menuUI.header();
                Console.WriteLine("\n\n");
                UI.productUI.takediscount();
                Console.ReadKey();
                Console.Clear();
                UI.menuUI.header();
            }
            // to pay the bill for the restaurant items
            else if (op == 6)
            {
                Console.Clear();
                UI.menuUI.header();
                Console.WriteLine("\n\n");
                UI.productUI.paybillres(givendiscount, result);
                Console.ReadKey();
                Console.Clear();
                UI.menuUI.header();
            }
            // to pay bill for the hotel booking
            else if (op == 7)
            {
                Console.Clear();
                UI.menuUI.header();
                Console.WriteLine("\n\n");
                UI.roomUI.hotelbillforroombooking(totalbillpaid);
                Console.ReadKey();
                Console.Clear();
                UI.menuUI.header();
            }

            // to exit the customer menu
            else if (op == 8)
            {

                Console.Clear();
                UI.menuUI.header();
                UI.menuUI.mainmenu();
            }
        }

        // function for the restaurant admin
        static void restaurantadmin(float givendiscount, int op, float a)
        {
            // to see the purchases of the current customer
            if (op == 1)
            {
                Console.Clear();
                UI.menuUI.header();
                Console.WriteLine("\n\n");
                UI.productUI.seepurchases();
                Console.ReadKey();
                Console.Clear();
                UI.menuUI.header();
            }
            // to calculate the profit and loss to the purchases
            else if (op == 2)
            {
                Console.Clear();
                UI.menuUI.header();
                Console.WriteLine("\n\n");
                UI.productUI.calculateprofitloss();
                Console.ReadKey();
                Console.Clear();
                UI.menuUI.header();
            }
            // to see the price you have received from the customer after the discount
            else if (op == 3)
            {
                Console.Clear();
                UI.menuUI.header();
                Console.WriteLine("\n\n");
                UI.productUI.pricereceivedafterdisc(UI.productUI.givendiscount2);
                Console.ReadKey();
                Console.Clear();
                UI.menuUI.header();
            }
           
            // to keep the record of the employee
            else if (op == 4)
            {
                Console.Clear();
                UI.menuUI.header();
                Console.WriteLine("\n\n");
                UI.workerUI.keepemployeerecords();
                Console.ReadKey();
                Console.Clear();
                UI.menuUI.header();
            }
            // to keep the workers salary record
            else if (op == 5)
            {
                Console.Clear();
                UI.menuUI.header();
                Console.WriteLine("\n\n");
                UI.workerUI.workerssalaryrecord();
                Console.ReadKey();
                Console.Clear();
                UI.menuUI.header();
            }
            // to delete any worker from the system
            else if (op == 6)
            {
                Console.Clear();
                UI.menuUI.header();
                Console.WriteLine("\n\n");
                UI.workerUI.deleteworker();
                Console.ReadKey();
                Console.Clear();
                UI.menuUI.header();
            }
            // to store current products and their current prices
            else if (op == 7)
            {
                Console.Clear();
                UI.menuUI.header();
                Console.WriteLine("\n\n");
                UI.productUI.show();
                Console.ReadKey();
                Console.Clear();
                UI.menuUI.header();
            }

            // to exit the restaurant admin menu
            else if (op == 8)
            {
                Console.Clear();
                UI.menuUI.header();
                UI.menuUI.mainmenu();
            }
        }
        public static void workerpro(int op)
        {
            // to add new products to the system
            if (op == 1)
            { 
                    Console.Clear();
                    UI.menuUI.header();
                    Console.WriteLine("\n\n");
                    UI.workerUI.addnewproducts();
                    Console.ReadKey();
                    Console.Clear();
                    UI.menuUI.header();
                
            }
            // to exit the worker menu
            else if (op == 2)
            {
                Console.Clear();
                UI.menuUI.header();
                UI.menuUI.mainmenu();
            }
        }





    }
}
