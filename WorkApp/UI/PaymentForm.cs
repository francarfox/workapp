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
        WorkerDetail context;
        Payment payment;
        int id;
        bool isEditing = false;

        public PaymentForm(WorkerDetail context)
        {
            this.context = context;
            InitializeComponent();
        }

        public void setupNewPayment()
        {
            Text = "Nuevo Monto";
            payment = new Payment();

            loadPayment();
        }

        public void setupEditPayment(Payment payment, int id)
        {
            Text = "Editar Monto";
            this.payment = payment;
            this.id = id;
            isEditing = true;

            loadPayment();
        }

        private void loadPayment()
        {
            textbox1.Text = payment.amount.ToString();
            dateButton1.Text = WorkerDetail.getGroupName(payment.date);

            monthCalendar1.Visible = false;
        }

        private void editAmount()
        {
            try
            {
                double amount = Convert.ToDouble(textbox1.Text);
                payment.amount = amount;
            }
            catch { }
        }

        private void textbox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                acceptButton1_Click(sender, e);
            }
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            editAmount();

            payment.date = e.End;
            loadPayment();
        }

        private void dateButton1_Click(object sender, EventArgs e)
        {
            monthCalendar1.SelectionEnd = payment.date;
            monthCalendar1.Visible = true;
        }

        private void acceptButton1_Click(object sender, EventArgs e)
        {
            editAmount();

            if (payment.amount <= 0) { return; }

            if (isEditing)
            {
                context.finishEdition(payment, id);
            } else
            {
                context.addPayment(payment);
            }

            Close();
        }
    }
}
