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
using System.Xml;

namespace WinForm
{
    public partial class MainForms : Form
    {
        private List<Student> ListStudent_ = new List<Student>();
        public MainForms()
        {
            InitializeComponent();
            ListStudent_.Add(new Student("Кувалдаев Вадим", 18, 4.5, 1, @"C:\Users\Вадим\source\repos\lrMDK01.01\WinForm\images\picture1.jpg"));
            ListStudent_.Add(new Student("Рыжов Арсений", 18, 4.5, 2, @"C:\Users\Вадим\source\repos\lrMDK01.01\WinForm\images\picture2.jpeg"));
            ListStudent_.Add(new Student("Андреев Андрей", 17, 4.0, 3, @"C:\Users\Вадим\source\repos\lrMDK01.01\WinForm\images\picture3.jpeg"));
            
            studentListBox.DataSource = ListStudent_;
            studentListBox.DisplayMember = "Name";
            studentListBox.SelectedIndexChanged += listBox_SelectedIndexChanged;
        }
        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Student st = (Student)studentListBox.SelectedItem;
            ageLabel.Text = st.Age.ToString();
            avgLabel.Text = st.Avg.ToString();
            ticketnumberLabel.Text = st.TicketNumber.ToString();
            picture.Load(st.Image);
        }
        
    }
}
