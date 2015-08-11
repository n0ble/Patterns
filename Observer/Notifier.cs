using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    abstract class Notifier
    {
        private string _state;
        private double _requestedPrice;
        private List<ICompetitor> _competitors = new List<ICompetitor>();

        // Constructor
        public Notifier(string state, double requestedPrice)
        {
            this._state = state;
            this._requestedPrice = requestedPrice;
        }

        public void Attach(ICompetitor competitor)
        {
            _competitors.Add(competitor);
        }

        public void Detach(ICompetitor competitor)
        {
            _competitors.Remove(competitor);
        }

        public void Notify()
        {
            foreach (ICompetitor c in _competitors)
            {
                c.UpdateState(this);
            }
        }

        // Gets or sets the price
        public double Price
        {
            get { return _requestedPrice; }
            set
            {
                if (_requestedPrice != value)
                {
                    _requestedPrice = value;
                    Notify();
                }
            }
        }
    }
}
