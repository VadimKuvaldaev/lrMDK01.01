using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LR3
{
    
    public partial class MainForm : Form
    {
        private Dictionary<string, List<Drugs>> drugs_ = new Dictionary<string, List<Drugs>>();
        private Dictionary<string, int> orderItems_ = new Dictionary<string, int>();
        private FileDrugStorage fileDrugStorage = new FileDrugStorage();
        public MainForm()
        {
            InitializeComponent();
            drugs_ = fileDrugStorage.LoadDataFromCsv();
            List<string> allCategories = drugs_.Keys.ToList();
            CategoriesListBox.DataSource = allCategories;
        }
        private void CategoriesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedCategory = CategoriesListBox.SelectedItem.ToString();
            List<Drugs> drugSelectedCategory = drugs_[selectedCategory];
            DrugsComboBox.DataSource = drugSelectedCategory;
            DrugsComboBox.DisplayMember = "Name";
        }
        private void DrugsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Drugs selectedDrug = DrugsComboBox.SelectedItem as Drugs;
            if (selectedDrug != null)
            {
                PriceLabel.Text = selectedDrug.Price;
                ManufacturerLabel.Text = selectedDrug.Manufacturer;
                DateLabel.Text = selectedDrug.Date;
                ProviderLabel.Text = selectedDrug.Provider;
                DrugPictureBox.Load(selectedDrug.ImagePath);
            }
        }
        private void OrderButton_Click(object sender, EventArgs e)
        {
            Drugs selectedDrug = DrugsComboBox.SelectedItem as Drugs;
            if (selectedDrug != null)
            {
                string drugName = selectedDrug.Name;
                int quantity = (int)QuantityNumericUpDown.Value;
                if (orderItems_.ContainsKey(drugName))
                {
                    orderItems_[drugName] += quantity;
                }
                else
                {
                    orderItems_[drugName] = quantity;
                }
                string orderText = "Ваш заказ:\n";
                foreach (var item in orderItems_)
                {
                    orderText += $"{item.Key}: {item.Value} шт.\n";
                }

                MessageBox.Show(orderText, "Текущий заказ");
            }
        }
    }
}
