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
    public partial class WorkerCell : UserControl
    {
        public Worker worker;
        public WorkersMenu context;
        public bool selected;

        public WorkerCell()
        {
            InitializeComponent();
        }

        public WorkerCell(Worker worker)
        {
            InitializeComponent();
            update(worker, null);
        }

        public void update(Worker worker, WorkersMenu context)
        {
            this.worker = worker;
            this.context = context;

            name1.Text = worker.name;
            label1.Text = "";

            deselect();
        }

        public void showAddButton()
        {
            Visible = true;
            BackColor = Color.Transparent;
            name1.Visible = false;
            pictureBox1.Visible = false;
            textbox1.Visible = true;
            textbox1.Text = "";
        }

        public void deselect()
        {
            Visible = true;
            BackColor = Color.Transparent;
            name1.ForeColor = Color.Black;
            name1.Visible = true;
            pictureBox1.Visible = true;
            textbox1.Visible = false;
            
            selected = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (selected)
            {
                deselect();
                context.selectWorkerCell(null);
            }
            else
            {
                name1.ForeColor = Color.Green;
                selected = true;
                context.selectWorkerCell(this);
            }
        }

        private void pictureBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (context != null)
            {
                context.workerCell_Click(worker);
            }
        }

        private void textbox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (textbox1.Text != "")
                {
                    Worker newWorker = new Worker(textbox1.Text);

                    context.addWorker(newWorker);
                } else
                {
                    textbox1.Text = "";
                }
            }
        }

    }
}
