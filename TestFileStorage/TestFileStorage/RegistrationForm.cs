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
    public partial class RegistrationForm : Form
    {
        private FileUsersStorage fileUsersStorage = new FileUsersStorage();
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void RegButton_Click(object sender, EventArgs e)
        {
            string login = RegLoginTextBox.Text.Trim();
            string password = RegPasswordTextBox.Text.Trim();
            if (string.IsNullOrEmpty(login))
            {
                MessageBox.Show("Введите логин >:(");
                return;
            }
            if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Введите пароль >:(");
                return;
            }
            if (fileUsersStorage.CheckExistUser(login))
            {
                MessageBox.Show("Пользователь с таким логином уже существует :(");
                return;
            }
            User newUser = new User(login, password);
            bool isAdded = fileUsersStorage.AddUser(newUser);
            if (isAdded)
            {
                MessageBox.Show("Регистрация успешна :)");
                this.Close(); 
            }
            else
            {
                MessageBox.Show("Ошибка при регистрации. Попробуйте снова. :(");
            }
        }
    }
}
