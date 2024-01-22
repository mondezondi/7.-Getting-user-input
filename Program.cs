using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.Getting_user_input
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write(" Enter Your Name:  ");
            String name = Console.ReadLine();
            Console.Write("Hi " + name + "");
            Console.Write("How old are you? ");
            String age = Console.ReadLine();
            Console.Write("you are " + age );

            Console.ReadLine();
        }
    }
}
