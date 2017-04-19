using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkApp
{
    [Serializable]
    public class Worker
    {
        public string name;
        public List<Payment> payments;

        public double totalPayments
        {
            get
            {
                double total = 0;

                foreach (Payment payment in payments)
                {
                    total += payment.amount;
                }

                return total;
            }
        }

        public Worker() : this("My Worker") { }

        public Worker(string name)
        {
            this.name = name;
            payments = new List<Payment>();
        }

        public void update(string name)
        {
            this.name = name;
        }

        public void addPayment(Payment payment)
        {
            payments.Add(payment);
        }

        public void updatePayment(Payment payment, int id)
        {
            payments[id].update(payment.amount);
        }

        public void removePayment(Payment payment)
        {
            payments.Remove(payment);
        }

    }
}
