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
                    new Drugs("Антигриппин", 199.99, "Фарма", new DateTime(2028, 07, 01), "Аптека.ru", "https://avatars.mds.yandex.net/i?id=f79548728a0dac044dc71c0d3d2e55dc45ddf44c-5443562-images-thumbs&n=13"),
                    new Drugs("Детралекс", 149.99, "Амбробене", new DateTime(2026, 11, 20), "Форте", "https://avatars.mds.yandex.net/i?id=9ed66dffc972811731192e21477af1d653fc440d-10391931-images-thumbs&n=13")
                }
            );
            drugs_.Add("Витамины",
                new List<Drugs>() {
                    new Drugs("Витамишки", 289.89, "Фармацевт", new DateTime(2026, 07, 15), "Аптека.ru", "https://avatars.mds.yandex.net/i?id=4b88297b1a6b27505690291cd65db3286b2d97f1-5220804-images-thumbs&n=13"),
                    new Drugs("Аскорбиновая кислота", 69.49, "Фарма", new DateTime(2027, 01, 05), "Озон", "https://avatars.mds.yandex.net/i?id=c2004ce254c1ed7222caf29e523baeee9028b18b-5886909-images-thumbs&n=13")
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
    }
}
