using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;


namespace DBTestWinForm
{
    public partial class Form1: Form
    {
        PgUsersLoader loader = new PgUsersLoader();

        public Form1()
        {                                              
            InitializeComponent();
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            List<User> users = loader.Load();
            dataGridView.DataSource = users;
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView.SelectedRows[0];
            User user = row.DataBoundItem as User;
            loader.DeleteSelectedUser(user.Login);
        }
    }
}
