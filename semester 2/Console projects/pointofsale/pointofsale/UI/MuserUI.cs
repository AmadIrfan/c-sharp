﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using pointofsale.DL;
using pointofsale.BL;

namespace pointofsale.UI
{
    class MuserUI
    {
        public static Muser signup()
        {
            string name,password,Roll;
            Console.WriteLine("Enter your name ");
            name = Console.ReadLine();
            Console.WriteLine("Enter your Password ");
            password = Console.ReadLine();
            Console.WriteLine("Enter your Roll ");
            Roll = Console.ReadLine();
            Muser temp = new Muser(name, password, Roll);
            return temp;
        }
        public static Muser login() {
            string name,password,Roll;
            Console.WriteLine("Enter your name ");
            name = Console.ReadLine();
            Console.WriteLine("Enter your Password ");
            password = Console.ReadLine();
            Muser temp = new Muser(name,password);
            return temp;
        }
    }
}
