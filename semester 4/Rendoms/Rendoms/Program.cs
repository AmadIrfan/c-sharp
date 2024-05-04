using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rendoms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String accountNumber = "";
            int[] arr = {1,2,3,4,5,6,7,8,9,0 };
            Random r= new Random();
            foreach ( int i in arr)
            {
               int a= r.Next(0,9);
                accountNumber = accountNumber + arr[a].ToString();
            }
            Console.WriteLine(accountNumber);
            Console.ReadLine();
        }
    }
}
