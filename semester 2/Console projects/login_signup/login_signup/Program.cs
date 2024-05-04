using System;

namespace login_signup
{
     class Program
    {
        public static string[] user_name = new string[10];
        public static int[] password = new int[10];
        static void Main(string[] args)
        {
            int input = 0;
            while (input < 3)
            {
                input = login_signup();
                if (input == 1) {
                    login();
                }
                if (input == 2) {
                    signup();
                }
                if(input==3)
                {
                    break;
                }
            }
        }
        static int login_signup()
        {
            int input;
            Console.WriteLine("************************************************");
            Console.WriteLine("*                Login Signup                  *");
            Console.WriteLine("************************************************");
            Console.WriteLine("1).Login ");
            Console.WriteLine("2).Signup ");
            Console.WriteLine("3).Exit ");
            Console.WriteLine("\n\n INPUT.. ");
            input = int.Parse(Console.ReadLine());
            return input;

        }
        static void signup()
        {
            int index=0;
            Console.WriteLine("Enter your name ");
            user_name[index] = Console.ReadLine();
            Console.WriteLine("Enter your Password ");
            password[index] = int.Parse(Console.ReadLine());
        
        } static void login()
        {
            bool status = false;
            string name;
            int pass;
            Console.WriteLine("Enter your name ");
            name = Console.ReadLine();
            Console.WriteLine("Enter your Password ");
            pass = int.Parse(Console.ReadLine());
            for(int x=0; x<10; x++)
            {
                if (user_name[x] == name && password[x] == pass)
                {
                    status = true;
                    break;
                }
            }
            if (status == true)
            {
                 Console.WriteLine("Success full to login ");

            }
            else
            {
                 Console.WriteLine("Try again! ");

            }
        }

    }
}
