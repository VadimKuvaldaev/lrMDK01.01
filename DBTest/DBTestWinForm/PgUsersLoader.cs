using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBTestWinForm
{
    public class PgUsersLoader
    {
        public List<User> Load() 
        {
            List<User> result = new List<User>();            
            var cs = "Host=192.168.1.48;Username=st50-10;Password=5010;Database=MDK01.01_Kuvaldaev";
            var con = new NpgsqlConnection(cs);
            con.Open();
            var sql = "SELECT login, password, age, name, last_name From myusers";
            var cmd = new NpgsqlCommand(sql, con);
            var reader = cmd.ExecuteReader();           
            while (reader.Read())
            {
                User user = new User
                {
                   Login = reader.GetString(0),
                   Password = reader.GetString(1),
                   Age = reader.GetInt32(2),
                   Name = reader.GetString(3),
                   LastName = reader.GetString(4)
                };
                result.Add(user);
            }
            return result;
        }               
    }
}
