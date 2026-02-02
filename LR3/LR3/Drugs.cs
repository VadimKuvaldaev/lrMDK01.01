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
        private string imagePath_;
        public Drugs(string name, double price, string manufacturer, DateTime date, string provider, string imagePath)
        { 
            name_ = name;
            price_ = price;
            manufacturer_ = manufacturer;
            shelfLifeDate_ = date;
            provide_ = provider; 
            imagePath_ = imagePath;
        }
        public string Name 
        {
            get { return name_; }
        }
        public string Price 
        {
            get { return price_.ToString(); }
        }
        public string Manufacturer 
        {
            get { return manufacturer_; }
        }
        public string Date 
        { 
            get { return shelfLifeDate_.ToString("dd.MM.yyyy"); }
        }
        public string Provider
        { 
            get { return provide_; } 
        }
        public string ImagePath 
        {
            get { return imagePath_; }
        }
    }
}
