using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;

namespace Pharmacy.Repositories.EnterRepository
{
    public class EnterRepository : BaseRepository, IEnterRepository
    {
        public EnterRepository(string connectionString)
        {
            this.connection = connectionString;
        }

        public bool checkPasswordByName(string name, string password)
        {
            using(var connect = new SQLiteConnection(connection))
            {
                using(var cmd = new SQLiteCommand())
                {
                    connect.Open();
                    cmd.Connection = connect;
                    cmd.CommandText = "Select Enter_password from Enters where Enter_name=@name";
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader == null)
                        {
                            return false;
                        }
                        else
                        {
                            while (reader.Read())
                                return password == reader[0].ToString();
                        }
                    }
                }
            }
            throw new Exception("Не удалось получить доступ к базе данных");
        }
    }
}
