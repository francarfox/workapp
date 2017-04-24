using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

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

            //loadPayments();
            initializeListViews();
        }

        private void initializeCells()
        {
            cells = new List<PaymentCell>();
        }

        private void initializeListViews()
        {
            int currentYear = 0;
            int currentMonth = 0;
            int currentDay = 0;
            string currentMonthName = "";

            for (int i = 0; i < worker.payments.Count; i++)
            {
                Payment payment = worker.payments[i];

                //date group - year
                if (payment.date.Year != currentYear)
                {
                    currentYear = payment.date.Year;
                    ListViewGroup group = new ListViewGroup(currentYear.ToString());
                    dateListView.Groups.Add(group);
                }

                //date item - month
                if (payment.date.Month != currentMonth)
                {
                    currentMonth = payment.date.Month;
                    ListViewGroup dateGroup = dateListView.Groups[dateListView.Groups.Count - 1];
                    string monthName = payment.date.ToString("MMMM", CultureInfo.CreateSpecificCulture("es"));
                    currentMonthName = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(monthName);

                    ListViewItem dateItem = new ListViewItem(currentMonthName, dateGroup);
                    dateListView.Items.Add(dateItem);
                }

                //amount group - day
                if (payment.date.Day != currentDay)
                {
                    currentDay = payment.date.Day;
                    string dayOfWeekName = payment.date.ToString("dddd", CultureInfo.CreateSpecificCulture("es"));
                    string groupName = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(dayOfWeekName) + " " + currentDay.ToString() + " de " + currentMonthName;

                    ListViewGroup group = new ListViewGroup(groupName);
                    amountListView.Groups.Add(group);
                }

                //amount item - all
                ListViewGroup currentGroup = amountListView.Groups[amountListView.Groups.Count - 1];
                ListViewItem item = new ListViewItem(payment.amount.ToString(), currentGroup);
                amountListView.Items.Add(item);
            }
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
