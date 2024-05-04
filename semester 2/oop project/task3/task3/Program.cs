using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace task3
{
    class Program
    {
        static void Main()
        {
            string path = "E:\\C#\\oop 1\\task3\\task3\\Program.txt";
            StreamWriter file = new StreamWriter(path, false);
            file.WriteLine("Hallo Amad you Are a Programmer ");
            file.WriteLine("Hallo Amad you Are a Programmer ");
            file.Flush();
            file.Close();
            reader();
        }
        static void reader()
        {
            string path = "E:\\C#\\oop 1\\task3\\task3\\Program.txt";
            if (File.Exists(path)){
                StreamReader filereader = new StreamReader(path);
                string record;
   
                while ((record = filereader.ReadLine()) != null)
                {
                    Console.WriteLine(record);
                    Console.ReadKey();
                }
                filereader.Close();
            }
            else
            {
                Console.WriteLine("File not exists ");
            }
        }
        void admin_pass_way()
        {

            Console.Write("\n");
            Console.Write("\n");
            Console.Write("\t \t \t Enter your User Name ... ");
            Console.Write("\n");
            Console.Write("\n");
            Console.Write("\n");
            uname = Console.ReadLine();
            Console.Write("\t \t \t Enter your pasword ... ");
            Console.Write("\n");
            Console.Write("\n");
            Console.Write("\n");
            password = ConsoleInput.ReadToWhiteSpace(true);
            Console.Write("\n");
            Console.Write("\n");
            admin_checker();
        }
        private void admin_checker()
        {
            StreamReader file = new fstream();
            file.open("admin.txt", ios.@in);
            while (!file.eof())
            {
                string row = "";
                getline(file, row);

                username = parse(row, 4);
                userpass = parse(row, 5);
                if (username == uname && password == userpass)
                {
                    break;
                }
            }
        }

    }
}
