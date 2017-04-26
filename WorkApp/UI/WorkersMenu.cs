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
    public partial class WorkersMenu : UserControl
    {
        List<WorkerCell> cells;
        WorkerCell cellSelected;
        int currentPage = 0;

        public WorkersMenu()
        {
            InitializeComponent();
            initializeCells();

            back1.Visible = false;
            next1.Visible = false;

            loadWorkers();

            delete1.Visible = false;
        }

        private void initializeCells()
        {
            cells = new List<WorkerCell>();
            cells.Add(workerCell1);
            cells.Add(workerCell2);
            cells.Add(workerCell3);
            cells.Add(workerCell4);
            cells.Add(workerCell5);
            cells.Add(workerCell6);
            cells.Add(workerCell7);
            cells.Add(workerCell8);
            cells.Add(workerCell9);
            cells.Add(workerCell10);
            cells.Add(workerCell11);
            cells.Add(workerCell12);
            cells.Add(workerCell13);
            cells.Add(workerCell14);
            cells.Add(workerCell15);
            cells.Add(workerCell16);
            cells.Add(workerCell17);
            cells.Add(workerCell18);
            cells.Add(workerCell19);
            cells.Add(workerCell20);
        }

        public void loadWorkers()
        {
            List<Worker> workers = Session.sharedInstance.company.workers;
            int workersCount = 0;

            for (int i = 0; i < cells.Count; i++)
            {

                if ((i + 20 * currentPage) < workers.Count)
                {
                    Worker worker = workers[i + 20 * currentPage];
                    cells[i].update(worker, this);
                    cells[i].Visible = true;

                    workersCount += 1;
                } else
                {
                    cells[i].Visible = false;
                }
            }

            if (workersCount < cells.Count)
            {
                cells[workersCount].showAddButton();
                cells[workersCount].context = this;

                next1.Visible = false;
            } else
            {
                next1.Visible = true;
            }
        }

        public void addWorker(Worker worker)
        {
            Session.sharedInstance.company.addWorker(worker);
            Session.sharedInstance.saveCompany();

            loadWorkers();
        }

        public void deleteWorker(Worker worker)
        {
            Session.sharedInstance.company.removeWorker(worker);
            Session.sharedInstance.saveCompany();

            loadWorkers();
        }

        public void selectWorkerCell(WorkerCell cell)
        {
            if (cellSelected != null)
            {
                cellSelected.deselect();
            }

            cellSelected = cell;

            bool selected = cell != null;
            delete1.Visible = selected;
        }

        public void workerCell_Click(Worker worker)
        {
            if (worker != null)
            {
                WorkerDetail detail = new WorkerDetail(worker);
                detail.Size = this.Size;

                this.Controls.Add(detail);
                detail.BringToFront();
            }
        }

        private void delete1_Click(object sender, EventArgs e)
        {
            if (cellSelected != null)
            {
                deleteWorker(cellSelected.worker);
                
                delete1.Visible = false;

                cellSelected = null;
            }
        }

        private void back1_Click(object sender, EventArgs e)
        {
            currentPage -= 1;
            next1.Visible = true;
            delete1.Visible = false;

            loadWorkers();

            if (currentPage <= 0)
            {
                currentPage = 0;
                back1.Visible = false;
                return;
            }
        }

        private void next1_Click(object sender, EventArgs e)
        {
            currentPage += 1;
            back1.Visible = true;
            delete1.Visible = false;

            loadWorkers();
        }
    }
}
