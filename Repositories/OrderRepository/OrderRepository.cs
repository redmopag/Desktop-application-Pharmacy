using Pharmacy.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Pharmacy.Repositories.OrderRepository
{
    public class OrderRepository : BaseRepository
    {
        public OrderRepository(string connection)
        {
            this.connection = connection;
        }

        public void AddOrder(OrderModel orderModel)
        {
            using(var connect = new SQLiteConnection(connection))
            {
                using (var cmd = new SQLiteCommand())
                {
                    connect.Open();
                    // Устанавливаем соединение команд с БД
                    cmd.Connection = connect;
                    // Вводим команду
                    cmd.CommandText = "insert into Orders values(NULL, @data, @time)";
                    cmd.Parameters.Add("@data", DbType.String).Value = orderModel.Data;
                    cmd.Parameters.Add("@time", DbType.Int32).Value = orderModel.Time;
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public void DeleteOrder(int id)
        {
            using (var connect = new SQLiteConnection(connection))
            {
                using (var cmd = new SQLiteCommand())
                {
                    connect.Open();
                    // Устанавливаем соединение команд с БД
                    cmd.Connection = connect;
                    // Вводим команду
                    cmd.CommandText = "delete from Orders where Order_id=@id";
                    cmd.Parameters.Add("@id", DbType.Int32).Value = id;
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public OrderModel getLatestRecord()
        {
            var orderModel = new OrderModel();
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
                    cmd.CommandText = "SELECT * FROM Orders order by column DESC LIMIT 1";
                    // Запускаем command reader
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            orderModel.Id = Convert.ToInt32(reader[0]);
                            orderModel.Data = reader[1].ToString();
                            orderModel.Time = reader[2].ToString();
                        }
                    }
                }
            }
            return orderModel;
        }

        public IEnumerable<OrderModel> GetAll()
        {
            var orderList = new List<OrderModel>();
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
                    cmd.CommandText = "Select * from Orders order by Order_id desc";
                    // Запускаем command reader
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var orderModel = new OrderModel();
                            orderModel.Id = Convert.ToInt32(reader[0]);
                            orderModel.Data = reader[1].ToString();
                            orderModel.Time = reader[2].ToString();

                            orderList.Add(orderModel);
                        }
                    }
                }
            }
            return orderList;
        }
        public IEnumerable<OrderModel> GetByValue(string value)
        {
            var orderList = new List<OrderModel>();
            int id = int.TryParse(value, out _) ? Convert.ToInt32(value) : 0;
            string data = value;
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
                    cmd.CommandText = @"Select * from Orders
                                    where (Order_id=@id or Order_data like @data)
                                    order by Order_id desc";
                    cmd.Parameters.Add("@id", DbType.Int32).Value = id;
                    cmd.Parameters.AddWithValue("@data", "%" + data + "%");
                    // Запускаем command reader
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var orderModel = new OrderModel();
                            orderModel.Id = Convert.ToInt32(reader[0]);
                            orderModel.Data = reader[1].ToString();
                            orderModel.Time = reader[2].ToString();

                            orderList.Add(orderModel);
                        }
                    }
                }
            }
            return orderList;
        }


        public void AddDrug(DrugsInOrderModel model)
        {
            using (var connect = new SQLiteConnection(connection))
            {
                using (var cmd = new SQLiteCommand())
                {
                    connect.Open();
                    // Устанавливаем соединение команд с БД
                    cmd.Connection = connect;
                    // Вводим команду
                    cmd.CommandText = "insert into DrugsInOrder values(@order_id, @drug_name, " +
                        "@drug_amount, @supplier_id, NULL)";
                    cmd.Parameters.Add("@order_id", DbType.String).Value = model.OrderId;
                    cmd.Parameters.Add("@drug_name", DbType.String).Value = model.Name;
                    cmd.Parameters.Add("@drug_amount", DbType.Int32).Value = model.Amount;
                    cmd.Parameters.Add("@supplier_id", DbType.Int32).Value = model.SupplierId;
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public void DeleteDrug(int id)
        {
            using (var connect = new SQLiteConnection(connection))
            {
                using (var cmd = new SQLiteCommand())
                {
                    connect.Open();
                    // Устанавливаем соединение команд с БД
                    cmd.Connection = connect;
                    // Вводим команду
                    cmd.CommandText = "delete from DrugsInOrder where Drugs_id=@id";
                    cmd.Parameters.Add("@id", DbType.Int32).Value = id;
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public IEnumerable<DrugsInOrderModel> GetAllDrugs(int id)
        {
            var drugList = new List<DrugsInOrderModel>();
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
                    cmd.CommandText = @"Select * from DrugsInOrder
                                    where Order_id=@id
                                    order by Drugs_id desc";
                    cmd.Parameters.Add("@id", DbType.Int32).Value = id;
                    // Запускаем command reader
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var drugModel = new DrugsInOrderModel();
                            drugModel.OrderId = Convert.ToInt32(reader[0]);
                            drugModel.Name = reader[1].ToString();
                            drugModel.Amount = Convert.ToInt32(reader[2]);
                            drugModel.SupplierId = Convert.ToInt32(reader[3]);
                            drugModel.DurgId = Convert.ToInt32(reader[4]);

                            drugList.Add(drugModel);
                        }
                    }
                }
            }
            return drugList;
        }
    }
}
