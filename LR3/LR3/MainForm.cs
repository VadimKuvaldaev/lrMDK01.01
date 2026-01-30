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
        private List<Group> medicationGroups;
        private Dictionary<string, Drugs> drugsDictionary;
        private string imagesFolder;
        public MainForm()
        {
            InitializeComponent();
            medicationGroups = new List<Group>();
            drugsDictionary = new Dictionary<string, Drugs>();
            InitializeData();
            InitializeFormEvents();
        }
        private void InitializeFormEvents()
        {
            this.Load += MainForm_Load;
            GroupComboBox.SelectedIndexChanged += GroupComboBox_SelectedIndexChanged;
            DrugListBox.SelectedIndexChanged += DrugListBox_SelectedIndexChanged;
            OrderButton.Click += OrderButton_Click;            
            this.FormClosing += Form1_FormClosing;
        }
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {           
            if (ImagePictureBox.Image != null)
            {
                ImagePictureBox.Image.Dispose();
                ImagePictureBox.Image = null;
            }
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            if (GroupComboBox.Items.Count > 0)
            {
                GroupComboBox.SelectedIndex = 0;
            }
        }
        private void InitializeData()
        {            
            imagesFolder = Path.Combine(Application.StartupPath, "Images");

            var group1 = new Group("Жаропонижающие");
            var group2 = new Group("Желудочно-кишечные");
            var group3 = new Group("Антибиотики");

            string paracetamolPath = Path.Combine(imagesFolder, "paracetamol.jpg");
            string ibuprofenPath = Path.Combine(imagesFolder, "ibuprofen.jpg");
            string loperamidePath = Path.Combine(imagesFolder, "loperamide.jpg");
            string mezimPath = Path.Combine(imagesFolder, "mezim.jpg");
            string amoxicillinPath = Path.Combine(imagesFolder, "amoxicillin.jpg");
            string azithromycinPath = Path.Combine(imagesFolder, "azithromycin.jpg");

            Drugs drug1 = new Drugs("Парацетамол", "Жаропонижающие", 150.50, "Фармстандарт", "31.12.2026", "Аптека-Склад", paracetamolPath);
            Drugs drug2 = new Drugs("Ибупрофен", "Жаропонижающие", 220.00, "Берлин-Хеми", "31.12.2027", "Медпоставка", ibuprofenPath);
            Drugs drug3 = new Drugs("Лоперамид", "Желудочно-кишечные", 85.75, "Озон", "31.12.2025", "Фармакор", loperamidePath);
            Drugs drug4 = new Drugs("Мезим", "Желудочно-кишечные", 310.20, "Берлин-Хеми", "31.12.2026", "Аптека-Склад", mezimPath);
            Drugs drug5 = new Drugs("Амоксициллин", "Антибиотики", 450.00, "Синтез", "31.12.2026", "Медпоставка", amoxicillinPath);
            Drugs drug6 = new Drugs("Азитромицин", "Антибиотики", 520.30, "Вертекс", "31.12.2027", "Фармакор", azithromycinPath);

            group1.AddDrug(drug1);
            group1.AddDrug(drug2);
            group2.AddDrug(drug3);
            group2.AddDrug(drug4);
            group3.AddDrug(drug5);
            group3.AddDrug(drug6);

            drugsDictionary[drug1.Name] = drug1;
            drugsDictionary[drug2.Name] = drug2;
            drugsDictionary[drug3.Name] = drug3;
            drugsDictionary[drug4.Name] = drug4;
            drugsDictionary[drug5.Name] = drug5;
            drugsDictionary[drug6.Name] = drug6;

            medicationGroups.Add(group1);
            medicationGroups.Add(group2);
            medicationGroups.Add(group3);

            GroupComboBox.Items.Clear();
            foreach (var group in medicationGroups)
            {
                GroupComboBox.Items.Add(group.Name);
            }

            this.Text = "Заказ лекарственных препаратов";
            QuantityNumericUpDown.Minimum = 1;
            QuantityNumericUpDown.Maximum = 100;
            QuantityNumericUpDown.Value = 1;

            ImagePictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            ImagePictureBox.Image = CreatePlaceholderImage("Выберите препарат");
        }

    }
}
