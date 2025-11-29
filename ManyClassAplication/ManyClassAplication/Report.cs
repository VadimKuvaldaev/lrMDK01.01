using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ManyClassAplication.RepoprtRow;
using static ManyClassAplication.Warehouse;

namespace ManyClassAplication
{
    class Report
    {
        private List<ReportRow> report_ = new List<ReportRow>(); 

        public void AddReport(ReportRow row) 
        {
            report_.Add(row);
        }

        static public string ConvertRowToString(ReportRow row) 
        {                     
            return row.Product + ", " + row.Price + ", " + row.Quantity + ".";           
        }
        public string PrintReport() 
        {
            string result;
            foreach (ReportRow row in report_)
            {
                report_.Add(ConvertRowToString(row));
            }
            return result;
        }
    }
}
