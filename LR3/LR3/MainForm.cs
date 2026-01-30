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
            this.Load += Form1_Load;
            GroupComboBox.SelectedIndexChanged += GroupComboBox_SelectedIndexChanged;
            DrugListBox.SelectedIndexChanged += DrugListBox_SelectedIndexChanged;
            OrderButton.Click += OrderButton_Click;            
            this.FormClosing += Form1_FormClosing;
        }

    }
}
