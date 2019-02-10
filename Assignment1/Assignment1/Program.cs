using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input:");
            string s1 = Console.ReadLine();

            int i1 = 0;
            float f1 = 0;
            bool b1;

            if (int.TryParse(s1, out i1))
            {
                Console.WriteLine("Your input {0} is Integer", s1);
            }

            else if (float.TryParse(s1, out f1))
            {
                Console.WriteLine("Your input {0} is Float", s1);
            }

            else if (bool.TryParse(s1, out b1))
            {
                Console.WriteLine("Your input {0} is bool", s1);
            }

            else
            {
                Console.WriteLine("Your input {0} is String", s1);
            }
            Console.ReadKey();

        }
    }
}
