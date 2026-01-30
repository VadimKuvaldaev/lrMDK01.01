using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR3
{
    public class OrderItem
    {
        private Drugs drug_;
        private int quantity_;
        public Drugs Drug
        {
            get { return drug_; }
            set { drug_ = value; }
        }
        public int Quantity
        {
            get { return quantity_; }
            set { quantity_ = value; }
        }
        public double TotalPrice
        {
            get
            {
                return drug_ != null ? drug_.Price * quantity_ : 0;
            }
        }
    }
}
