using ModelViewLib.ModelViews;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms
{
    public partial class AddUserForm: Form
    {
        public User user { get; set; }
       
        public AddUserForm()
        {
            InitializeComponent();
            user = new User();
        }

        private void AddUserButton_Click(object sender, EventArgs e)
        {
            user.Login = LoginTextBox.Text;
            user.Password = PasswordTextBox.Text;
            user.Name = NameTextBox.Text;
            DialogResult = DialogResult.OK;
            
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
