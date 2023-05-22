using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Pharmacy.Models;

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
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Edit(DrugModel drugModel)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<DrugModel> GetAll()
        {
            var drugList = new List<DrugModel>();
            // Создаём соединение с базой данных
            using(var connect = new SqlConnection(connection))
                // Определём SqlCommand для выполнения операций над БД
                using(var cmd = new SqlCommand())
            {
                connect.Open();
                // Устанавливаем соединение команд с БД
                cmd.Connection = connect;
                // Вводим команду
                cmd.CommandText = "Select * from Drugs order by Drug_id desc";
                // Запускаем command reader
                using (var reader = cmd.ExecuteReader())
                {
                    while(reader.Read())
                    {
                        var drugModel = new DrugModel();
                        drugModel.Id = (int)reader[0];
                        drugModel.Name = reader[1].ToString();
                        drugModel.Amount = (int)reader[2];
                        drugModel.Place = (int)reader[3];
                        drugModel.Cost = (float)reader[4];

                        drugList.Add(drugModel);
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
            using (var connect = new SqlConnection(connection))
            // Определём SqlCommand для выполнения операций над БД
            using (var cmd = new SqlCommand())
            {
                connect.Open();
                // Устанавливаем соединение команд с БД
                cmd.Connection = connect;
                // Вводим команду
                cmd.CommandText = @"Select * from Drugs
                                    where Drug_id=@id or Drug_name like @name+'%'
                                    order by Drug_id desc";
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
                cmd.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;
                // Запускаем command reader
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var drugModel = new DrugModel();
                        drugModel.Id = (int)reader[0];
                        drugModel.Name = reader[1].ToString();
                        drugModel.Amount = (int)reader[2];
                        drugModel.Place = (int)reader[3];
                        drugModel.Cost = (float)reader[4];

                        drugList.Add(drugModel);
                    }
                }
            }
            return drugList;
        }
    }
}
