using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkApp
{
    [Serializable]
    public class Payment
    {
        public double amount;
        public DateTime date;

        public Payment() : this(0) { }

        public Payment(double amount)
        {
            this.amount = amount;
            date = DateTime.Today;
        }

        public void update(double amount)
        {
            this.amount = amount;
        }
    }
}
