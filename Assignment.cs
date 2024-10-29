using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program2
    {
        public static void Main(string[] args)
        {
            //TERNARY OPERATOR
            Console.Write("Enter your age: ");
            int age = Convert.toInt32(Console.ReadLine());

            int ageChecker = age > 0 "Valid" : "Invalid";
        }

    }
}
