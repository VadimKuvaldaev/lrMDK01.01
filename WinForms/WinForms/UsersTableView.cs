using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ModelViewLib.ModelViews;
using ModelViewLib.Views;

namespace WinForms
{
    public class UsersTableView : DataGridView, IUsersView
    {
        public void ShowUsers(List<User> users)
        {
            DataSource = users;
        }
    }
}
