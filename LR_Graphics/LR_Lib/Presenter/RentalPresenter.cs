using LR_Lib.Analyzer;
using LR_Lib.Model;
using LR_Lib.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR_Lib.Presenter
{
    public class RentalPresenter
    {
        private RentalModel model_ = new RentalModel();
        private List<IRentalView> views_;

        public RentalPresenter(List<IRentalView> views)
        {
            views_ = views;
            model_.Load();
        }

        public void ShowRentalsByItem(string itemName)
        {
            List<RentalRecord> rentals = model_.LoadRentalsForItem(itemName);
            RentalItem item = model_.GetItem(itemName);
            
            foreach (IRentalView view in views_)
            {
                view.ShowRentalRecords(rentals, item);
            }
        }

        public List<RentalItem> GetAllItems()
        {
            return model_.GetAllItems();
        }
    }
}
