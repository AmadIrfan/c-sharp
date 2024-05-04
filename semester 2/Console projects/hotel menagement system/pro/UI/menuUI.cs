using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace pro.UI
{
    class menuUI
    {
        // function to print the name on the screen
        public static void printname()
        {
            string path = "h.txt";
            if (File.Exists(path))
            {
                StreamReader f = new StreamReader(path);
                string record;
                while ((record = f.ReadLine()) != null)
                {
                    Console.WriteLine(record);

                }
                f.Close();
            }
        }
        //function for the header
        public static void header()
        {
            string path = "hea.txt";
            if (File.Exists(path))
            {
                StreamReader f = new StreamReader(path);
                string record;
                while ((record = f.ReadLine()) != null)
                {
                    Console.WriteLine(record);

                }
                f.Close();
            }

        }
        // function for main menu
        public static void mainmenu()
        {
            Console.Clear();
            header();
            Console.WriteLine("\n\n");
            Console.WriteLine("1- Sign in");
            Console.WriteLine("2- Sign up");
            Console.WriteLine("3- Exit");
            Console.WriteLine("Enter any option: ");

        }
        // function for taking option 
        public static int takeoption()
        {
            int op;
            op = int.Parse(Console.ReadLine());
            return op;
        }
        // function to exit the system
        public static void exit()
        {
            header();
            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n");
            Console.WriteLine("             Exiting..........");
            Environment.Exit(0);
        }

        public static void inmenu()
        {
            header();
            Console.WriteLine("\n\n");
            Console.WriteLine(" Welcome to CANDLEWOOD hotel management system");
           
        }
    }
}
