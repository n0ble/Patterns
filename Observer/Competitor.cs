using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    class Competitor : ICompetitor
    {
        private double _requestedPrice;
        private string _name;

        public Competitor(string name)
        {
            _requestedPrice = 0.00;
            _name = name;
        }
        public double Price
        {
            get { return _requestedPrice; }
            set { _requestedPrice = value; }
        }

        public void UpdateState(Notifier opportunity)
        {
            Price = opportunity.Price;
            Console.WriteLine("Notified {0} of price change to {1:C}", _name, opportunity.Price);
        }
    }
}
