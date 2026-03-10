using LiveCharts;
using LiveCharts.Wpf;
using SalesLibrary;
using SalesLibrary.Views;
using SalesLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using SalesLibrary.Presenters;

namespace ChartTest.Views
{
    public class SalesPieChart : LiveCharts.WinForms.PieChart
                                     
    {
        private SalesPresenter presenter_;
        public void SetPresenter(SalesPresenter presenter)
        {
            presenter_ = presenter;
        }
        public void UpdateView() 
        {
            List<Item> allItems = presenter_.GetAllItems();
            SeriesCollection seriesData = new SeriesCollection();
            foreach (Item item in allItems)
            {
                seriesData.Add(new PieSeries
                {
                    Title = item.Name,
                    Values = new ChartValues<double>(){Math.Round(presenter_.GetProfitPercentByItem(item), 2) }
                });
            }
            Series = seriesData;
        }
       
    }
}
