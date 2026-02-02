using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LR3
{
    
    public partial class MainForm : Form
    {
        private Dictionary<string, List<Drugs>> drugs_ = new Dictionary<string, List<Drugs>>();
        public MainForm()
        {
            InitializeComponent();

            drugs_.Add("Антибиотики", 
                new List<Drugs>() { 
                    new Drugs("Антигриппин", 199.99, "Фарма", new DateTime(2028, 07, 01), "Аптека.ru"),
                    new Drugs("Детралекс", 149.99, "Амбробене", new DateTime(2026, 11, 20), "Форте")
                }
            );
            drugs_.Add("Витамины",
                new List<Drugs>() {
                    new Drugs("Витамишки", 289.89, "Фармацевт", new DateTime(2026, 07, 15), "Аптека.ru"),
                    new Drugs("Аскорбиновая кислота", 69.49, "Фарма", new DateTime(2027, 01, 05), "Озон")
                }
            );
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

        
    }
}
