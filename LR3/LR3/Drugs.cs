using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR3
{
    public class Drugs
    {
        private string name_;
        private double price_;
        private string manufacturer_;
        private DateTime shelfLifeDate_;
        private string provide_;
        public Drugs(string name, double price, string manufacturer, DateTime date, string provider)
        { 
            name_ = name;
            price_ = price;
            manufacturer_ = manufacturer;
            shelfLifeDate_ = date;
            provide_ = provider;           
        }
        public string Name 
        {
            get { return name_; }
        }
    }
}
