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
    public partial class WorkerDetail : UserControl
    {
        List<PaymentCell> cells;
        Worker worker;
        PaymentCell cellSelected;

        public WorkerDetail(Worker worker)
        {
            InitializeComponent();
            initializeCells();

            this.worker = worker;
            name1.Text = worker.name;
            label1.Text = "";

            loadPayments();
        }

        private void initializeCells()
        {
            cells = new List<PaymentCell>();
            cells.Add(paymentCell1);
            cells.Add(paymentCell2);
            cells.Add(paymentCell3);
            cells.Add(paymentCell4);
            cells.Add(paymentCell5);
            cells.Add(paymentCell6);
            cells.Add(paymentCell7);
            cells.Add(paymentCell8);
            cells.Add(paymentCell9);
            cells.Add(paymentCell10);
            cells.Add(paymentCell11);
            cells.Add(paymentCell12);
            cells.Add(paymentCell13);
            cells.Add(paymentCell14);
            cells.Add(paymentCell15);
            cells.Add(paymentCell16);
            cells.Add(paymentCell17);
            cells.Add(paymentCell18);
            cells.Add(paymentCell19);
            cells.Add(paymentCell20);
            cells.Add(paymentCell21);
            cells.Add(paymentCell22);
            cells.Add(paymentCell23);
            cells.Add(paymentCell24);
            cells.Add(paymentCell25);
            cells.Add(paymentCell26);
            cells.Add(paymentCell27);
            cells.Add(paymentCell28);
        }

        private void loadPayments()
        {
            for (int i = 0; i < worker.payments.Count; i++)
            {
                Payment payment = worker.payments[i];
                cells[i].update(payment, this, i);
            }

            for (int i = worker.payments.Count; i < cells.Count; i++)
            {
                cells[i].Visible = false;
            }

            if (worker.payments.Count < this.cells.Count)
            {
                cells[worker.payments.Count].showAddButton();
                cells[worker.payments.Count].context = this;
            }

            calculateTotal();

            selectPaymentCell(null);
        }

        private void calculateTotal()
        {
            total1.Text = worker.totalPayments.ToString("n2");

            percentButton1.Text = "Calcular " + (int)Properties.Settings.Default["Percent"] + "%";
        }

        public void addPayment(Payment payment)
        {
            worker.addPayment(payment);
            Session.sharedInstance.saveWorker(worker);

            loadPayments();
        }

        public void finishEdition(Payment payment, int id)
        {
            worker.updatePayment(payment, id);
            Session.sharedInstance.saveWorker(worker);

            loadPayments();
        }

        public void deletePayment(Payment payment)
        {
            worker.removePayment(payment);
            Session.sharedInstance.saveWorker(worker);

            loadPayments();
        }

        public void selectPaymentCell(PaymentCell cell)
        {
            if (cellSelected != null)
            {
                cellSelected.deselect();
            }

            cellSelected = cell;

            bool selected = cell != null;
            edit1.Visible = selected;
            delete1.Visible = selected;
        }

        private void back_MouseClick(object sender, MouseEventArgs e)
        {
            this.Parent.Controls.Remove(this);
        }

        private void edit1_Click(object sender, EventArgs e)
        {
            if (cellSelected != null)
            {
                cellSelected.edit();

                edit1.Visible = false;
                delete1.Visible = false;
            }
        }

        private void delete1_Click(object sender, EventArgs e)
        {
            if (cellSelected != null)
            {
                deletePayment(cellSelected.payment);

                edit1.Visible = false;
                delete1.Visible = false;

                cellSelected = null;
            }
        }

        private void percent1_Click(object sender, EventArgs e)
        {
            int percent = (int)Properties.Settings.Default["Percent"];
            double result = worker.totalPayments * percent / 100;

            percentButton1.Text = "Resultado: " + result;
        }
    }
}
