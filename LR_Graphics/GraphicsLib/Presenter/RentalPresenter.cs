using GraphicsLib.Model;
using GraphicsLib.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicsLib.Presenter
{
    public class RentalPresenter
    {
        private readonly RentalModel _model;
        private readonly List<IRentalView> _views;
        public RentalPresenter(List<IRentalView> views)
        {
            _model = new RentalModel();
            _model.LoadData();
            _views = views;
        }
        public List<Item> GetAllItems() => _model.GetItems();

        public void SelectedItemChanged(string itemName)
        {
            var records = _model.GetRecordsForItem(itemName);
            foreach (var view in _views) view.DisplayChart(records);
        }
        public double GetContributionPercent(Item item)
        {
            double total = _model.GetTotalRevenue();
            return total == 0 ? 0 : Math.Round((_model.GetRevenueForItem(item) / total) * 100, 2);
        }
    }
}
