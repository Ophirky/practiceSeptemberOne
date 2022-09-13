using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practiceSeptemberOne
{
    internal class PracticeSeven
    {
        public PracticeSeven()
        {
            Console.WriteLine("Please enter two of the rect tzlaot: ");
            Console.Write("1: ");
            float a = float.Parse(Console.ReadLine());

            Console.Write("2: ");
            float b = float.Parse(Console.ReadLine());

            float perimeter = 2*a+2*b;
            float terrain = a * b;
            float difference = terrain - perimeter;

            Console.WriteLine($"The heikef is: {perimeter},\nthe terrain is: {terrain},\nthe difference is: {difference}");
        }
    }
}
