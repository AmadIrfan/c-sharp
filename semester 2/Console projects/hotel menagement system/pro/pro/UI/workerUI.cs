using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using pro.BL;
using pro.DL;

namespace pro.UI
{
    class workerUI
    {
        public static string workerpath = "worker information.txt";
        public static  string currentproducts = "products information.txt";

        // funnction to keep the record of the employees
        public static void keepemployeerecords()
        {
            string workername, workerexperience;
            int n, workerage;
            double workersalary;
            Console.WriteLine("\n\n");
            Console.WriteLine("How many workers you want to enter at this time: ");
            n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter the name of the worker: ");
                workername = Console.ReadLine();
                Console.WriteLine("Enter the age of the worker: ");
                workerage = int.Parse(Console.ReadLine()); ;
                Console.WriteLine("Enter the salary of the worker: ");
                workersalary = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter the experience of the worker");
                workerexperience = Console.ReadLine();
                worker w = new worker(workername, workerage, workersalary, workerexperience);
                DL.workerDL.addworkerintolist(w);
            }
            DL.workerDL.sorting();
            workerview();
            DL.workerDL.addinfile(workerpath);


        }
        // function to keep the workers salary record
        public static void workerssalaryrecord()
        {
            for (int i = 0; i < DL.workerDL.workerlist.Count; i++)
            {
                Console.WriteLine(DL.workerDL.workerlist[i].workername + "......................" + DL.workerDL.workerlist[i].workersalary);
            }
        }
        // function for taking worker name
        public static worker workername()
        {
            string name;
            Console.WriteLine("Enter the name of the worker you want to delete from the system: ");
            name = Console.ReadLine();
            worker w = new worker(name);
            return w;
        }
        public static void workerview()
        {
            Console.WriteLine("NAME" + "  " + "AGE" + "  " + "SALARY" + "  " + "EXPERIENCE");
            foreach(worker w in DL.workerDL.workerlist)
            {
                Console.WriteLine(w.workername + "    " + w.workerage + "    " + w.workersalary + "    " + w.workerexperience);
            }
        }

        // function to delete worker from the system
        public static void deleteworker()
        {
            workerview();
            Console.WriteLine("\n\n");
            worker wo = new worker();
            wo = workername();
            DL.workerDL.del(wo);
            Console.WriteLine("\n\n\n");
            workerview();
            DL.workerDL.addinfile(workerpath);
        }
        // function to add new products
        public static void addnewproducts()
        {
            string workername, workerexperience;
            int workerage;
            double workersalary;
             Console.WriteLine("Enter the name of the worker: ");
             workername = Console.ReadLine();
             Console.WriteLine("Enter the age of the worker: ");
             workerage = int.Parse(Console.ReadLine()); ;
             Console.WriteLine("Enter the salary of the worker: ");
             workersalary = double.Parse(Console.ReadLine());
             Console.WriteLine("Enter the experience of the worker");
             workerexperience = Console.ReadLine();
            int n;
            string productname;
            string productprice;
            Console.WriteLine("\n\nEnter the number of products you want to enter: ");
            n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter the name of the product: ");
                productname = Console.ReadLine();
                Console.WriteLine("Enter the price of the product: ");
                productprice = Console.ReadLine();
                product ne = new product(productname, productprice);
                DL.productDL.productlist.Add(ne);
                DL.productDL.storeinfile(currentproducts, ne);
            }
        }
    }
}
