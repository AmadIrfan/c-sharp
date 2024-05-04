using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            Console.WriteLine(program.isEqual<string>("Amad","amad"));
            Console.WriteLine(program.isEqual<string>("Amad","Amad"));
            Console.WriteLine(program.isEqual<int>(5,5));
            Console.WriteLine(program.isEqual<float>(5.5f,6.7f));
           //Console.WriteLine( isEqual(5,5));   
            Console.ReadKey();
        }
        /*public static bool isEqual(int num1,int num2)
        {
            return num1.Equals(num2);
        }*/
        public bool isEqual<T>(T word1,T word2)
        {
            return word1.Equals(word2);
        } 
        /*public static bool isEqual(char ch1,char ch2)
        {
            return ch1.Equals(ch2);
        }*/
    }
}
