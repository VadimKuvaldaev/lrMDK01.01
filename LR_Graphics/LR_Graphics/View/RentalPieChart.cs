using GraphicsLib.Presenter;
using LiveCharts;
using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR_Graphics.View
{
    public class RentalPieChart : LiveCharts.WinForms.PieChart
    {
        public void UpdateData(RentalPresenter presenter)
        {
            var series = new SeriesCollection();
            foreach (var item in presenter.GetAllItems())
            {
                series.Add(new PieSeries
                {
                    Title = item.Name,
                    Values = new ChartValues<double> { presenter.GetContributionPercent(item) },
                    DataLabels = false,
                    LabelPoint = point => "" //= chartPoint => $"{chartPoint.Y}%"
                });
            }
            Series = series;
        }
    }
}
