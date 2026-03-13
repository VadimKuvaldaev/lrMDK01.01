using LiveCharts.Wpf;
using LiveCharts;
using LR_Lib;
using LR_Lib.Model;
using LR_Lib.Presenter;
using LR_Lib.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LR_Graphics
{
    public partial class MainForm : Form
    {
        private RentalPresenter presenter_;

        void FillCartesianChart()
        {
            rentalListBox.DataSource = presenter_.GetAllItems();
            rentalListBox.DisplayMember = "Name";
            if (rentalListBox.Items.Count > 0)
            {
                presenter_.ShowRentalsByItem(((RentalItem)rentalListBox.Items[0]).Name);
            }
        }

        public MainForm()
        {
            InitializeComponent();
            presenter_ = new RentalPresenter(new List<IRentalView> { cartesian, pie });

            FillCartesianChart();
        }

        private void rentalListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            RentalItem selectedItem = ((RentalItem)(rentalListBox.SelectedItem));
            if (selectedItem == null)
            {
                return;
            }
            presenter_.ShowRentalsByItem(selectedItem.Name);
        }       
    }
}
