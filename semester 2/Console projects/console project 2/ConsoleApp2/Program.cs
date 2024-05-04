using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int age, machine, toy;
            Console.WriteLine("Enter age ");
            age=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Priece of machine ");
            machine = int.Parse(Console.ReadLine());
            Console.WriteLine("Priece of Toy ");
            toy = int.Parse(Console.ReadLine());
            calc(age, machine, toy);
        }
        static void calc(int age,int mac_pri,int priece)
        {
            int sum=0,multi=1;
          for(int i = 1; i <= age; i++)
            {
                if (i % 2 == 0)
                {
                    sum = sum + (i * 10);
                }
                else
                {
                    multi = multi * priece-1;
                }
            }
            int total = multi + sum;
            int profit = mac_pri - total;
            int remind = total - mac_pri;
            if (total>=mac_pri)
            {
                Console.WriteLine("Yes You can Mannage ");
                Console.Write("Price is " );
                Console.WriteLine(remind);

            }
            else
            {
                Console.WriteLine("Yes You can Mannage ");
                Console.Write("Price is ");
                Console.WriteLine(remind);

            }
        }
    }
}
