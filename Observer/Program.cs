using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("### Observer Pattern ###");

            // Create Opportunity and attach competitors
            Opportunity opp = new Opportunity("Active", 120.00);
            opp.Attach(new Competitor("JLL"));
            opp.Attach(new Competitor("Nordstrom"));

            // Fluctuating prices will notify investors
            opp.Price = 120.10;
            opp.Price = 121.00;
            opp.Price = 120.50;
            opp.Price = 120.75;

            // Wait for user
            Console.ReadKey();
        }
    }
}
