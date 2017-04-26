using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WorkApp.UI
{
    public partial class PaymentForm : Form
    {
        public Payment payment;

        public PaymentForm(string title)
        {
            InitializeComponent();
            Text = title;
        }

        public void loadPayment(Payment payment)
        {
            this.payment = payment;

            textbox1.Text = payment.amount.ToString();
        }

        private void addButton1_Click(object sender, EventArgs e)
        {
            try
            {
                double amount = Convert.ToDouble(textbox1.Text);
                Payment newPayment = new Payment(amount);

                //addPayment(newPayment);
                textbox1.Text = "";
            }
            catch { }
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            Console.WriteLine(e.End.ToString());
        }
    }
}
