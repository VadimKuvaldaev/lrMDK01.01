using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBTestWinForm
{
    public partial class AddForm : Form
    {
        public bool isEditMode_ = false;
        PgUsersLoader allUsers_;
        public AddForm(PgUsersLoader loader)
        {
            InitializeComponent();
            allUsers_ = loader;
            
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            if (isEditMode_)
            {
                UpdateUser();
            }
            else
            {
                AddUser();
            }
            Close();
        }

        private void CanselButton_Click(object sender, EventArgs e)
        {            
            this.Close();            
        }

        private void ApplyButton_Click(object sender, EventArgs e)
        {
            if (isEditMode_)
            {
                UpdateUser();
            }
            else
            {
                AddUser();
            }
        }
        public void SetUser(User user) 
        {
            isEditMode_ = true;
            LoginTextBox.Text = user.Login;
            PasswordTextBox.Text = user.Password;
            NameTextBox.Text = user.Name;
            LastNameTextBox.Text = user.LastName;
            AgeNumericUpDown.Value = user.Age;
            
        }
        public void UpdateUser()
        {
            allUsers_.UpdateUsers(new User
            {
                Login = LoginTextBox.Text,
                Password = PasswordTextBox.Text,
                Name = NameTextBox.Text,
                LastName = LastNameTextBox.Text,
                Age = (int)AgeNumericUpDown.Value
            });
        }
        public void AddUser()
        {
            allUsers_.AddUser(new User
            {
                Login = LoginTextBox.Text,
                Password = PasswordTextBox.Text,
                Name = NameTextBox.Text,
                LastName = LastNameTextBox.Text,
                Age = (int)AgeNumericUpDown.Value
            });
        }
    }
}
