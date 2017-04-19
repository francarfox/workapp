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

        public WorkersMenu()
        {
            InitializeComponent();
            initializeCells();

            loadWorkers();
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

        private void loadWorkers()
        {
            List<Worker> workers = Session.sharedInstance.company.workers;

            for (int i = 0; i < workers.Count; i++)
            {
                Worker worker = workers[i];
                cells[i].update(worker, this);
            }

            for (int i = workers.Count; i < cells.Count; i++)
            {
                cells[i].Visible = false;
            }

            if (workers.Count < this.cells.Count)
            {
                cells[workers.Count].showAddButton();
                cells[workers.Count].context = this;
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
    }
}
