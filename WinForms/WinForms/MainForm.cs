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
        IUsersModel model_ = new MemoryUsersModel();
        UserPresenter presenter_;
        private IUsersView view;

        public MainForm()
        {
            InitializeComponent();
            presenter_ = new UserPresenter(model_, view);
            UsersTableView tableView = new UsersTableView();
            Controls.Add(tableView);
            tableView.Dock = DockStyle.Top;
            this.Controls.Add(this.toolStrip1);
            UserPresenter user = new UserPresenter( new MemoryUsersModel(), tableView);
        }                

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            List<User> selectedUser = view.GetSelectedUsers();
        }
    }
}
