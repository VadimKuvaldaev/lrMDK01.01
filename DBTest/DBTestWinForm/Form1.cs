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
        
        
        public Form1()
        {                                              
            InitializeComponent();
            PgUsersLoader loader = new PgUsersLoader();
            List<User> users = loader.Load();
            dataGridView.DataSource = users;
        }
    }
}
