using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace WorkApp
{
    [Serializable]
    public class Company
    {
        public string name;
        public List<Worker> workers;

        public Company() : this("My Company") { }

        public Company(string name)
        {
            this.name = name;
            workers = new List<Worker>();
        }

        public void addWorker(Worker worker)
        {
            workers.Add(worker);
        }

        public void removeWorker(Worker worker)
        {
            workers.Remove(worker);
        }

        //
        public void save(string filename)
        {
            using (var stream = new FileStream(filename, FileMode.Create))
            {
                var xml = new XmlSerializer(typeof(Company));
                xml.Serialize(stream, this);
            }
        }

        public static Company load(string filename)
        {
            using (var stream = new FileStream(filename, FileMode.Open))
            {
                var xml = new XmlSerializer(typeof(Company));
                return (Company)xml.Deserialize(stream);
            }
        }

    }
}
