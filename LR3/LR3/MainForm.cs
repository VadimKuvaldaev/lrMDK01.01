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

    }
}
