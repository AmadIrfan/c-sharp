using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pointofsale.UI
{
    class manu
    {
        public static void LoginSinup()
        {
            Console.WriteLine("*****************************************");
            Console.WriteLine("             Login/signup                ");
            Console.WriteLine("*****************************************");
        }public static void Login()
        {
            Console.WriteLine("*****************************************");
            Console.WriteLine("                 Login                   ");
            Console.WriteLine("*****************************************");
        }
        public static void Singin()
        {
            Console.WriteLine("*****************************************");
            Console.WriteLine("                 Singin                  ");
            Console.WriteLine("*****************************************");
        }
        public static void adminpage(){
            Console.WriteLine("*****************************************");
            Console.WriteLine("                Admin page               ");
            Console.WriteLine("*****************************************");
        }
        public static void clearScreen()
        {
            Console.WriteLine("Press any key to Continue..");
            Console.ReadKey();
            Console.Clear();
        }
        public static int consoleManu()
        {
            int option;
            Console.WriteLine("1. SignIn");
            Console.WriteLine("2. SignUp");
            Console.WriteLine("3. Exit");
            Console.WriteLine("Enter your Option. ");
            option=int.Parse(Console.ReadLine());
            return option;
        }
        public static int adminManu()
        {
            int option;
            Console.WriteLine(" 1.Add Product.");
            Console.WriteLine(" 2.View All Products.");
            Console.WriteLine(" 3.Find Product with Highest Unit Price.");
            Console.WriteLine(" 4.View Sales Tax of All Products.");
            Console.WriteLine(" 5.Products to be Ordered. (less than threshold)");
            Console.WriteLine(" 6.Exit");
            option =int.Parse( Console.ReadLine());
            return option;
        }public static int custManu()
        {
            int option;
            Console.WriteLine("1.View all the products ");
            Console.WriteLine("2.Buy the products");
            Console.WriteLine("3.Generate invoice");
            Console.WriteLine("4.Exit");
            option =int.Parse( Console.ReadLine());
            return option;
      }
    }
}
