using LR_Lib.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR_Lib.View
{
    public interface IRentalView
    {
        void ShowRentalRecords(List<RentalRecord> rentals, RentalItem item);
    }
}
