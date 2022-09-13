using System; 
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practiceSeptemberOne
{
    internal class PracticeThree
    {
        public PracticeThree()
        {
            float n1, n2, n3, n4;

            Console.Write("Enter a number: ");
            n1 = float.Parse(Console.ReadLine());

            Console.Write("Enter another number: ");
            n2 = float.Parse(Console.ReadLine());

            Console.Write("Enter another number: ");
            n3 = float.Parse(Console.ReadLine());

            Console.Write("Enter another number (last one I promise): ");
            n4 = float.Parse(Console.ReadLine());

            float sum = n1 + n2 + n3 + n4;
            int numberOfNumbers = 4;
            float average = sum / numberOfNumbers;

            Console.WriteLine($"The average of the numbers {n1}, {n2}, {n3}, {n4} is: {average}");


        }
    }
}
