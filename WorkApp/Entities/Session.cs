using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkApp
{
    class Session
    {
        private string filename = "app.xml";
        public Company company;

        private static Session instance;
        public static Session sharedInstance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Session();
                }
                return instance;
            }
        }

        private Session()
        {
            company = Company.load(filename);
            if (company == null) {
                company = new Company();
                company.save(filename);
            }
        }
        
        public void saveWorker(Worker worker)
        {
            bool found = false;

            for (int i=0; i < company.workers.Count; i++)
            {
                Worker myWorker = company.workers[i];

                if (myWorker.Equals(worker))
                {
                    company.workers[i] = worker;
                    found = true;
                }
            }

            if (!found)
            {
                company.addWorker(worker);
            }

            saveCompany();
        }

        public void saveCompany()
        {
            company.save(filename);
        }

    }
}
