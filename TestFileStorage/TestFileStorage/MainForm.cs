using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestFileStorage
{
    public partial class MainForm : Form
    {
        List<string> allCategories = drugs_.Keys.ToList();
        public MainForm()
        {
            InitializeComponent();
            List<string> allLogins = .Keys.ToList();
            LoginComboBox.DataSource = ;
        }


        private void EnterButton_Click(object sender, EventArgs e)
        {
            //string login = LoginTextBox.Text;
            //string password = PasswordTextBox.Text;
            List<User> users = new List<User>();
            FileUsersStorage fileUsersStorage = new FileUsersStorage();
            users = fileUsersStorage.Load();
            foreach (User data in users)
            {
                if (PasswordTextBox.Text == data.Password)
                {
                    MessageBox.Show("Пароль введен верно :)");
                    break;
                }
                else
                {
                    MessageBox.Show("Пароль введен неверно :(");
                    return;
                }
            } 
        }

       
    }
}
