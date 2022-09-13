using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practiceSeptemberOne
{
    internal class PracticeSix
    {
        public PracticeSix()
        {
            // Six A
            Console.Write("Enter the first number is the series: ");
            float a = float.Parse(Console.ReadLine());

            Console.Write("Enter the jump amount: ");
            float b = float.Parse(Console.ReadLine());

            float member1 = a + b, member2 = a + 2 * b, member3 = a + 3 * b, member4 = a + 4 * b;

            Console.WriteLine($"The first five members of the series are: {a}, {member1}, {member2}, {member3}, {member4}.");

            // Six B
            float sumNum = member1 + member2 + member3 + member4 + a;
            Console.WriteLine($"The sum of all five first members is: {sumNum}");
        }

        public void LoopedVersionBecauseWhyNot()
        {

            Console.Write("Enter the first number is the series: ");
            float a = float.Parse(Console.ReadLine());

            Console.Write("Enter the jump amount: ");
            float b = float.Parse(Console.ReadLine());

            float[] members = {a};

            for (int i = 1; i<=5; i++)
            {
                members.Append(a + i*b);
            }

            Console.WriteLine(members);

        }
    }
}
