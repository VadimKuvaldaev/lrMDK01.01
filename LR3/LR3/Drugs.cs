using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR3
{
    public class Drugs
    {
        private string name_;
        private string group_;
        private double price_;
        private string manufacturer_;
        private string expiryDate_;
        private string supplier_;
        private string imagePath_;
        public Drugs(string name, string group, double price, string manufacturer, string expiryDate, string supplier, string imagePath)
        {
            name_ = name;
            group_ = group;
            price_ = price;
            manufacturer_ = manufacturer;
            expiryDate_ = expiryDate;
            supplier_ = supplier;
            imagePath_ = imagePath;
        }
        public string Name
        {
            get { return name_; }
        }
        public string Group
        {
            get { return group_; }
        }
        public double Price
        {
            get { return price_; }
        }
        public string Manufacturer
        {
            get { return manufacturer_; }
        }
        public string ExpiryDate
        {
            get { return expiryDate_; }
        }
        public string Supplier
        {
            get { return supplier_; }
        }
        public string ImagePath
        {
            get { return imagePath_; }
        }
        public override string ToString()
        {
            return $"{name_} ({group_}) - {price_:F2} руб.";
        }
    }
}
