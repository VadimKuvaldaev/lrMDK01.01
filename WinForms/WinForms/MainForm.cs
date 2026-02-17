using ModelViewLib.Models;
using ModelViewLib.ModelViews;
using ModelViewLib.Presenters;
using ModelViewLib.Views;
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
    public partial class MainForm : Form
    {
        UserPresenter presenter_;       
        public MainForm()
        {
            InitializeComponent();
            presenter_ = new UserPresenter(new MemoryUsersModel(), tableView);           
        }                
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Вы действительно хотите удалить пользователей?",
                            "Внимание",
                             MessageBoxButtons.YesNo,
                             MassageBoxIcon.Question);
            List<User> selectedUser = tableView.GetSelectedUsers();
            presenter_.RemoveUsers(selectedUser);
        }
    }
}
