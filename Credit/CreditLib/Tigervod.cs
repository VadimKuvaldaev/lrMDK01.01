using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditLib
{
    public class Tigervod
    {
        private string fullName_;
        private int age_;
        private int cell_;
        public Tigervod(string fullName, int age, int cell)
        {
            fullName_ = fullName;           
            age_ = age;
            cell_ = cell;
        }
        public string FullName() 
        {
            return fullName_;
        }
        public int Age()
        {
            return age_;
        }
        public int Cell()
        {
            return cell_;
        }
    }
}
