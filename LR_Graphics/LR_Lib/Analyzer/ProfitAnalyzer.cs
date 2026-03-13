using LR_Lib.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR_Lib.Analyzer
{
    public class ProfitAnalyzer
    {
        public static double CalculateProfitPercentByItem(string itemName, RentalModel model)
        {
            RentalItem item = model.GetItem(itemName);
            if (item == null) return 0.0;

            double itemProfit = model.GetProfitByItem(item);
            double totalProfit = model.GetTotalProfit();

            if (totalProfit == 0) return 0.0;

            return (itemProfit / totalProfit) * 100.0;
        }

        public static Dictionary<string, double> CalculateAllProfitShares(RentalModel model)
        {
            var result = new Dictionary<string, double>();
            var items = model.GetAllItems();
            double totalProfit = model.GetTotalProfit();

            foreach (var item in items)
            {
                double itemProfit = model.GetProfitByItem(item);
                double share = totalProfit > 0 ? (itemProfit / totalProfit) * 100.0 : 0.0;
                result.Add(item.Name, share);
            }

            return result;
        }
    }
}
