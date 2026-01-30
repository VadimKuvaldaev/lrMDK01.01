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
    public partial class Form1 : Form
    {
        List<Drugs> allDrugs = new List<Drugs>();
        List<string> order = new List<string>();
        public Form1()
        {
            InitializeComponent();

            Drugs drug1 = new Drugs(1, "Неболин форте", "Антибиотики", 229.99, "Форте Inc", "16.07.2027", "Мастер доставки", "");
            Drugs drug2 = new Drugs(2, "Фармацитрит", "Обезболивающие", 149.89, "Форте Inc", "27.11.2026", "Аптека.ru", "");
            Drugs drug3 = new Drugs(3, "Витамишки", "Витамины", 99.99, "Эвалар", "13.01.2027", "Мастер доставки", "");

            allDrugs.Add(drug1);
            allDrugs.Add(drug2);
            allDrugs.Add(drug3);

            GroupsListBox.SelectedIndexChanged += GroupsListBox_SelectedIndexChanged; 
            DrugsComboBox.SelectedIndexChanged += DrugsComboBox_SelectedIndexChanged;
            OrderButton.Click += OrderButton_Click;
        }

        private void OrderButton_Click(object sender, EventArgs e)
        {
            
        }

        private void GroupsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*if (GroupsListBox.SelectedItems.Count > 0)
            {
                string selectedGroup = GroupsListBox.SelectedItems.ToString();
                DrugsComboBox.Items.Clear();
                foreach (var drug in allDrugs) 
                {
                   if (drug.group == selectedGroup) 
                   {
                        DrugsComboBox.Items.Add(drug);
                   }
                }
            }*/
        }

        private void DrugsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*if (DrugsComboBox.SelectedItem is drug selectedDrug) 
            {
              DrugInfoLabel.Text = selectedDrug.GetInfo();
            }*/
        }
    }
}
