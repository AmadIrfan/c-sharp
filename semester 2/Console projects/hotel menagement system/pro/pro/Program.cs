using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using pro.DL;
using pro.UI;

namespace pro
{
    class Program
    {
        static void Main(string[] args)
        {
            // file paths   
            string path = "sign file.txt";
            string customerpath = "customer information for room booking.txt";
            string customerpathforproducts = "customer information for products.txt";
            string currentproducts = "products information.txt";
            string roomsinfomation = "rooms information.txt";
            string workersinformation = "workers information.txt";
           //Load functions
           customerDL.readFromFileroom(customerpath);
           customerDL.readFromFileproduct(customerpathforproducts);
           productDL.readFromFile(currentproducts);
           roomDL.readFromFile(roomsinfomation);
           workerDL.readFromFile(workersinformation);
            // declaration of variables
            int option = 0;
            float givendiscount = 0, result = 0;
            int available = 0;
            long totalbillpaid = 0;
            float a = DL.productDL.paybill(ref givendiscount, ref result);

            // for color
            Console.ForegroundColor =
                ConsoleColor.DarkCyan;

            // to print the name of the system on the console
            UI.menuUI.printname();
            Console.ReadKey();
            while (option != 4)
            {
                DL.credentialsDL.readFromFile(path);
                UI.menuUI.mainmenu();
                option = 0;
                option = UI.menuUI.takeoption();
                // to sign in in the system
                string rolle;
                if (option == 1)
                {
                    Console.Clear();
                    rolle = UI.credentialsUI.signin();
                    if (rolle == "receptionist")
                    {
                        UI.menuUI.inmenu();
                        UI.credentialsUI.receptionistmenu();
                        continue;
                    }
                    else  if (rolle == "customer")
                    {
                        Console.Clear();
                        UI.menuUI.inmenu();
                        UI.credentialsUI.customermenu(available, givendiscount, result, totalbillpaid);
                        continue;
                    }
                    else if (rolle == "admin")
                    {
                        Console.Clear();
                        UI.menuUI.inmenu();
                        UI.credentialsUI.admin(givendiscount, a);
                        continue;
                    }
                    else if (rolle == "worker")
                    {
                        Console.Clear();
                        UI.menuUI.inmenu();
                        UI.credentialsUI.workermenu();
                        continue;
                    }

                }
                // to sign up in the system
                if (option == 2)
                {
                    Console.Clear();
                    UI.credentialsUI.input();
                }
                // to exit the system
                if (option == 3)
                {
                    Console.Clear();
                    Environment.Exit(0);
                }
            }

            Console.ReadKey();
        }
    }
    
}
