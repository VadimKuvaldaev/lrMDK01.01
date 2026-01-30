using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR3
{
    public class Drugs
    {
        private int id_;
        private string name_;
        private string group_;
        private double price_;
        private string manufacturer_;
        private string expiryDate_;
        private string supplier_;
        private string image_;
        public Drugs(int id, string name, string group, double price, string manufacturer, string expiryDate, string supplier, string image)
        { 
            id_ = id;
            name_ = name;
            group_ = group;
            price_ = price;
            manufacturer_ = manufacturer;
            expiryDate_ = expiryDate;
            supplier_ = supplier;
            image_ = image;
        }
        /*public string GetInfo() 
        {
           
        }*/
    }
}
