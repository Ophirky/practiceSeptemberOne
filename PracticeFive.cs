using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practiceSeptemberOne
{
    internal class PracticeFive
    {
        public PracticeFive()
        {
            Console.Write("Enter a number: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Enter another number: ");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine($"a = {a}, b = {b}");

            int temp = a;
            a = b;
            b = temp;

            Console.WriteLine($"a = {a}, b = {b}");

        }
    }
}
