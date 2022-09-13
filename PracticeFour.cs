using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practiceSeptemberOne
{
    internal class PracticeFour
    {
        public PracticeFour()
        {
            Console.Write("Enter Your Flight price in $: ");
            float flightTicketPrice = float.Parse(Console.ReadLine());
            float dollarRate = 3.39f;

            float ticketInNis = dollarRate * flightTicketPrice;
            Console.WriteLine($"Flight ticket price in NIS is: {ticketInNis}");
        }
    }
}
