using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestFileStorage
{
    public class PgUserStorage : IUsersInterface
    {        
        private const string connectSetting = "Host=192.168.1.48;Username=st50-10;Password=5010;Database=MDK01.01_Kuvaldaev";
        public List<User> Load()
        {
            try 
            {
                List<User> allUsers = new List<User>();
                var con = new NpgsqlConnection(connectSetting);
                con.Open();
                var sql = "SELECT login, password From myusers";
                var cmd = new NpgsqlCommand(sql, con);
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    User user = new User(reader.GetString(0), reader.GetString(1));
                    allUsers.Add(user);
                }
                return allUsers;
            }
            catch (NpgsqlException exception)
            {
                MessageBox.Show($"Ошибка: {exception.Message}");
                return null;
            }
        }

        public bool UserRegistration(User user)
        {
            try
            {
                bool addResult = false;
                List<User> allUsers = new List<User>();
                var con = new NpgsqlConnection(connectSetting);
                con.Open();
                var sql = "INSERT INTO myusers(login, password) VALUES(@login, @password)";
                var cmd = new NpgsqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@login", user.Login);
                cmd.Parameters.AddWithValue("@password", user.Password);
                int execute = cmd.ExecuteNonQuery();
                if (execute > 0)
                {
                    addResult = true;
                    allUsers.Add(user);
                }
                return addResult;
            }
            catch (NpgsqlException exception)
            {
                MessageBox.Show($"Ошибка: {exception.Message}");
                return false;
            }
        }

        public bool UserVerification(string login)
        {
            try
            {
                
                var con = new NpgsqlConnection(connectSetting);
                con.Open();
                var sql = "SELECT EXISTS(SELECT 1 FROM myusers WHERE login = '@login');";
                var cmd = new NpgsqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@login", login);
                bool verifResult = (bool)cmd.ExecuteScalar();
                con.Close();
                return verifResult;
            }
            catch (NpgsqlException exception)
            {
                MessageBox.Show($"Ошибка: {exception.Message}");
                return false;
            }
        }
    }
}
