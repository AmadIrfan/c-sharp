using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using pro1.BL;

namespace pro1
{
     class Program
    {
        static void Main(string[] args)
        {
         int count = 0;
             Store[] pro =new Store[5];
            int sum = 0;
         //   int count = 0;
            int option=0;
            Console.WriteLine(" _______________________");
            Console.WriteLine("|                       |");
            Console.WriteLine("|      MAIN MENU        |");
            Console.WriteLine("|_______________________|");
            Console.WriteLine("\n");
            Console.WriteLine("1- Add Product...");
            Console.WriteLine("2- Show Product...");
            Console.WriteLine("3- Total Store Worth...");
            Console.WriteLine("\n");
            Console.WriteLine("Enter your option...");
            option = int.Parse(Console.ReadLine());
            while (option < 4)
            {
                if (option == 1)
                {
                    add_product(pro, count);
                }
                if (option == 2)
                {
                    //show_product(arr, count);
                }
                if (option == 3)
                {
                    //total_worth(arr, count, sum);
                }
            }
            Console.ReadKey();

        }

        public static void add_product(Store[] pro,int count)
        {

            Console.WriteLine("Enter product name...");
            pro[count].name = Console.ReadLine();
            Console.WriteLine("Enter product id...");
            pro[count].id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter product price...");
            pro[count].price = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter product category...");
            pro[count].category = Console.ReadLine();
            Console.WriteLine("Enter product brand-name...");
            pro[count].brand = Console.ReadLine();
            Console.WriteLine("Enter product country...");
            pro[count].country = Console.ReadLine();
        }
    }
}

