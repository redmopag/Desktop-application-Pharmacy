using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;
using Pharmacy.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Windows.Forms;

namespace Pharmacy.Repositories
{
    public class DrugRepository : BaseRepository, IDrugRepository
    {
        //Constructor
        public DrugRepository(string connection)
        {
            this.connection = connection;
        }
        public void Add(DrugModel drugModel)
        {
            using (var connect = new SQLiteConnection(connection))
            {
                // Определём SQLiteCommand для выполнения операций над БД
                using (var cmd = new SQLiteCommand())
                {
                    connect.Open();
                    // Устанавливаем соединение команд с БД
                    cmd.Connection = connect;
                    // Вводим команду
                    cmd.CommandText = "insert into Drugs values(NULL, @name, @amount, @place, @cost)";
                    cmd.Parameters.Add("@name", DbType.String).Value = drugModel.Name;
                    cmd.Parameters.Add("@amount", DbType.Int32).Value = drugModel.Amount;
                    cmd.Parameters.Add("@place", DbType.Int32).Value = drugModel.Place;
                    cmd.Parameters.Add("@cost", DbType.Double).Value = drugModel.Cost;
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void Delete(int id)
        {
            using (var connect = new SQLiteConnection(connection))
            {
                // Определём SQLiteCommand для выполнения операций над БД
                using (var cmd = new SQLiteCommand())
                {
                    connect.Open();
                    // Устанавливаем соединение команд с БД
                    cmd.Connection = connect;
                    // Вводим команду
                    cmd.CommandText = "delete from Drugs where Drug_id=@id";
                    cmd.Parameters.Add("@id", DbType.Int32).Value = id;
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void Edit(DrugModel drugModel)
        {
            using (var connect = new SQLiteConnection(connection))
            {
                // Определём SQLiteCommand для выполнения операций над БД
                using (var cmd = new SQLiteCommand())
                {
                    connect.Open();
                    // Устанавливаем соединение команд с БД
                    cmd.Connection = connect;
                    // Вводим команду
                    cmd.CommandText = @"update Drugs
                                        set Drug_name=@name, Drug_amount=@amount, Drug_place=@place, Drug_cost=@cost
                                        where Drug_id=@id";
                    cmd.Parameters.Add("@name", DbType.String).Value = drugModel.Name;
                    cmd.Parameters.Add("@amount", DbType.Int32).Value = drugModel.Amount;
                    cmd.Parameters.Add("@place", DbType.Int32).Value = drugModel.Place;
                    cmd.Parameters.Add("@cost", DbType.Double).Value = drugModel.Cost;
                    cmd.Parameters.Add("@id", DbType.Int32).Value = drugModel.Id;
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public IEnumerable<DrugModel> GetAll()
        {
            var drugList = new List<DrugModel>();
            // Создаём соединение с базой данных
            using (var connect = new SQLiteConnection(connection))
            {
                // Определём SQLiteCommand для выполнения операций над БД
                using (var cmd = new SQLiteCommand())
                {
                    connect.Open();
                    // Устанавливаем соединение команд с БД
                    cmd.Connection = connect;
                    // Вводим команду
                    cmd.CommandText = "Select * from Drugs order by Drug_id desc";
                    // Запускаем command reader
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var drugModel = new DrugModel();
                            drugModel.Id = Convert.ToInt32(reader[0]);
                            drugModel.Name = reader[1].ToString();
                            drugModel.Amount = Convert.ToInt32(reader[2]);
                            drugModel.Place = Convert.ToInt32(reader[3]);
                            drugModel.Cost = Convert.ToDouble(reader[4]);

                            drugList.Add(drugModel);
                        }
                    }
                }
            }
            return drugList;
        }

        public IEnumerable<DrugModel> GetByValue(string value)
        {
            var drugList = new List<DrugModel>();
            int id = int.TryParse(value, out _) ? Convert.ToInt32(value) : 0;
            string name = value;
            // Создаём соединение с базой данных
            using (var connect = new SQLiteConnection(connection))
            {
                // Определём SqlCommand для выполнения операций над БД
                using (var cmd = new SQLiteCommand())
                {
                    connect.Open();
                    // Устанавливаем соединение команд с БД
                    cmd.Connection = connect;
                    // Вводим команду
                    cmd.CommandText = @"Select * from Drugs
                                    where (Drug_id=@id or Drug_name like @name)
                                    order by Drug_id desc";
                    cmd.Parameters.Add("@id", DbType.Int32).Value = id;
                    cmd.Parameters.AddWithValue("@name", "%" + name + "%");
                    // Запускаем command reader
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var drugModel = new DrugModel();
                            drugModel.Id = Convert.ToInt32(reader[0]);
                            drugModel.Name = reader[1].ToString();
                            drugModel.Amount = Convert.ToInt32(reader[2]);
                            drugModel.Place = Convert.ToInt32(reader[3]);
                            drugModel.Cost = Convert.ToDouble(reader[4]);

                            drugList.Add(drugModel);
                        }
                    }
                }
            }
            return drugList;
        }
    }
}
