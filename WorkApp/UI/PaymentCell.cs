using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorkApp.UI
{
    public partial class PaymentCell : UserControl
    {
        public WorkerDetail context;
        public Payment payment;
        public int id;
        public bool selected;
        public bool editing;

        public PaymentCell()
        {
            InitializeComponent();
        }

        public void update(Payment payment, WorkerDetail context, int id)
        {
            this.payment = payment;
            this.context = context;
            this.id = id;

            label1.Text = payment.amount.ToString("n2");
            deselect();
        }

        public void showAddButton()
        {
            Visible = true;
            BackColor = Color.Transparent;
            label1.Visible = false;
            textbox1.Visible = true;
            textbox1.Text = "";
        }

        public void edit()
        {
            Visible = true;
            BackColor = Color.Transparent;
            label1.Visible = false;
            textbox1.Visible = true;
            textbox1.Text = label1.Text;
            textbox1.Focus();

            editing = true;
            selected = true;
        }

        public void deselect()
        {
            Visible = true;
            BackColor = Color.White;
            label1.ForeColor = Color.Black;
            label1.Visible = true;
            textbox1.Visible = false;

            editing = false;
            selected = false;
        }

        private void textbox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    double amount = Convert.ToDouble(textbox1.Text);
                    Payment newPayment = new Payment(amount);

                    if (editing)
                    {
                        context.finishEdition(newPayment, id);
                    } else
                    {
                        context.addPayment(newPayment);
                    }
                }
                catch
                {
                    textbox1.Text = "";
                }

                editing = false;
            }
        }

        private void PaymentCell_MouseClick(object sender, MouseEventArgs e)
        {
            if (editing)
            {
                deselect();
                context.selectPaymentCell(null);
            } else
            {
                if (selected)
                {
                    deselect();
                    context.selectPaymentCell(null);
                } else
                {
                    BackColor = Color.FromArgb(46, 139, 87);
                    label1.ForeColor = Color.White;
                    selected = true;
                    context.selectPaymentCell(this);
                }
            }
        }

        private void PaymentCell_MouseDoubleClick(object sender, MouseEventArgs e)
        { }

        private void textbox1_MouseClick(object sender, MouseEventArgs e)
        { }
    }
}
