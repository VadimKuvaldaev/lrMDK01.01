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
        private string v1_;
        private string v2_;
        private string v3_;
        private string v4_;
        private string v5_;
        private string v6_;

        public Drugs(string name, double price, string manufacturer, DateTime date, string provider, string imagePath)
        { 
            name_ = name;
            price_ = price;
            manufacturer_ = manufacturer;
            shelfLifeDate_ = date;
            provide_ = provider; 
            imagePath_ = imagePath;
        }

        public Drugs(string v1, string v2, string v3, string v4, string v5, string v6)
        {
            v1_ = v1;
            v2_ = v2;
            v3_ = v3;
            v4_ = v4;
            v5_ = v5;
            v6_ = v6;
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
