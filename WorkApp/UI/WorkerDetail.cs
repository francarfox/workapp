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
        Worker worker;
        Dictionary<string, List<Payment>> paymentsData = new Dictionary<string, List<Payment>>();
        ListViewItem weekSelected;
        Payment paymentSelected;

        public WorkerDetail(Worker worker)
        {
            InitializeComponent();

            this.worker = worker;
            name1.Text = worker.name;
            label1.Text = "";
            
            initializeListViews();
        }

        private void initializeListViews()
        {
            dateListView.Items.Clear();

            int currentMonth = 0;
            int currentWeekOfYear = 0;
            string currentItemName = "";
            
            foreach (Payment payment in worker.payments)
            {
                //date group - month
                if (payment.date.Month != currentMonth)
                {
                    currentMonth = payment.date.Month;
                    string monthName = payment.date.ToString("MMMM", CultureInfo.CreateSpecificCulture("es"));
                    string groupName = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(monthName) + " " + payment.date.Year.ToString();

                    ListViewGroup group = new ListViewGroup(groupName);
                    dateListView.Groups.Add(group);
                }

                //date item - week of month
                if (payment.date.DayOfYear/7 != currentWeekOfYear)
                {
                    currentWeekOfYear = payment.date.DayOfYear / 7;
                    ListViewGroup dateGroup = dateListView.Groups[dateListView.Groups.Count - 1];

                    DateTime startOfWeek = payment.date.StartOfWeek(DayOfWeek.Monday);
                    DateTime endOfWeek   = payment.date.EndOfWeek(DayOfWeek.Sunday);

                    currentItemName = "Semana del " + startOfWeek.Day + " al " + endOfWeek.Day;
                    ListViewItem dateItem = new ListViewItem(currentItemName, dateGroup);
                    dateListView.Items.Add(dateItem);

                    //
                    var data = new List<Payment>();
                    paymentsData.Add(currentItemName, data);
                }

                //
                paymentsData[currentItemName].Add(payment);
            }
        }

        private void loadPayments()
        {
            if (weekSelected == null) { return; }

            clearAmountListView();

            int currentDay = 0;

            foreach (Payment payment in paymentsData[weekSelected.Text])
            {
                //amount group - day
                if (payment.date.Day != currentDay)
                {
                    currentDay = payment.date.Day;
                    string dayOfWeekName = payment.date.ToString("dddd", CultureInfo.CreateSpecificCulture("es"));
                    string currentDayOfWeekName = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(dayOfWeekName);
                    string monthName = payment.date.ToString("MMMM", CultureInfo.CreateSpecificCulture("es"));
                    string currentMonthName = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(monthName);

                    string groupName = currentDayOfWeekName + " " + currentDay.ToString() + " de " + currentMonthName;

                    ListViewGroup group = new ListViewGroup(groupName);
                    amountListView.Groups.Add(group);
                }

                //amount item - all
                ListViewGroup currentGroup = amountListView.Groups[amountListView.Groups.Count - 1];
                ListViewItem item = new ListViewItem(payment.amount.ToString(), currentGroup);
                amountListView.Items.Add(item);
            }
        }

        private void reloadPayments()
        {
            paymentsData = new Dictionary<string, List<Payment>>();
            
            initializeListViews();
            loadPayments();

            weekSelected = null;
            paymentSelected = null;
        }

        private void clearAmountListView()
        {
            amountListView.Items.Clear();
            paymentSelected = null;
        }

        private void calculateTotal()
        {
            total1.Text = worker.totalPayments.ToString("n2");

            addButton1.Text = "Calcular " + (int)Properties.Settings.Default["Percent"] + "%";
        }

        public void addPayment(Payment payment)
        {
            worker.addPayment(payment);
            Session.sharedInstance.saveWorker(worker);

            reloadPayments();
        }

        public void finishEdition(Payment payment, int id)
        {
            worker.updatePayment(payment, id);
            Session.sharedInstance.saveWorker(worker);

            //loadPayments();
        }

        public void deletePayment(Payment payment)
        {
            worker.removePayment(payment);
            Session.sharedInstance.saveWorker(worker);

            reloadPayments();
        }

        private void back_MouseClick(object sender, MouseEventArgs e)
        {
            this.Parent.Controls.Remove(this);
        }

        private void edit1_Click(object sender, EventArgs e)
        {
            if (paymentSelected != null)
            {
                PaymentForm dialog = new PaymentForm("Editar Monto");
                dialog.loadPayment(paymentSelected);
                dialog.StartPosition = FormStartPosition.CenterParent;
                dialog.ShowDialog();
            }

            showOptions(false);
        }

        private void delete1_Click(object sender, EventArgs e)
        {
            if (paymentSelected != null)
            {
                deletePayment(paymentSelected);
                paymentSelected = null;
            }

            showOptions(false);
        }

        private void percent1_Click(object sender, EventArgs e)
        {
            int percent = (int)Properties.Settings.Default["Percent"];
            double result = worker.totalPayments * percent / 100;

            addButton1.Text = "Resultado: " + result;
        }

        private void dateListView_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (e.IsSelected)
            {
                var item = dateListView.Items[e.ItemIndex];
                weekSelected = item;

                loadPayments();
            } else
            {
                weekSelected = null;

                clearAmountListView();
            }

            showOptions(false);
        }

        private void amountListView_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (e.IsSelected && weekSelected != null)
            {
                var item = amountListView.Items[e.ItemIndex];
                var payments = paymentsData[weekSelected.Text];
                var payment = payments[e.ItemIndex];

                paymentSelected = payment;
            } else
            {
                paymentSelected = null;
            }

            showOptions(e.IsSelected);
        }

        private void showOptions(bool show)
        {
            edit1.Visible = show;
            delete1.Visible = show;
        }

        private void name1_DoubleClick(object sender, EventArgs e)
        {
            name1.Visible = false;
            textbox1.Visible = true;
            textbox1.Text = name1.Text;
        }

        private void textbox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (textbox1.Text != "" && textbox1.Text != worker.name)
                {
                    worker.name = textbox1.Text;

                    Session.sharedInstance.saveWorker(worker);

                    name1.Text = worker.name;

                    ((WorkersMenu)Parent).loadWorkers();
                }

                name1.Visible = true;
                textbox1.Visible = false;
            }
        }

        private void addButton1_Click(object sender, EventArgs e)
        {
            PaymentForm dialog = new PaymentForm("Agregar Monto");
            dialog.StartPosition = FormStartPosition.CenterParent;
            dialog.ShowDialog();

            showOptions(false);
        }
    }
}

public static class DateTimeExtensions
{
    public static DateTime StartOfWeek(this DateTime dt, DayOfWeek startOfWeek)
    {
        int diff = dt.DayOfWeek - startOfWeek;
        if (diff < 0)
        {
            diff += 7;
        }
        return dt.AddDays(-1 * diff).Date;
    }

    public static DateTime EndOfWeek(this DateTime dt, DayOfWeek endOfWeek)
    {
        int diff = endOfWeek - dt.DayOfWeek;
        if (diff < 0)
        {
            diff += 7;
        }
        return dt.AddDays(diff).Date;
    }

}