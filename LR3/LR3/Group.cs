using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR3
{
    public class Group
    {
        private string name_;
        private List<Drugs> drugs_;
        public Group(string name)
        {
            name_ = name;
            drugs_ = new List<Drugs>();
        }
        public string Name
        {
            get { return name_; }
        }
        public List<Drugs> Drugs
        {
            get { return drugs_; }
        }
        public void AddDrug(Drugs drug)
        {
            if (drug != null)
            {
                drugs_.Add(drug);
            }
        }
    }
}
