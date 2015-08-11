using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    class Opportunity : Notifier
    {
        public Opportunity(string state, double price)
      : base(state, price)
    {
        }
    }
}
