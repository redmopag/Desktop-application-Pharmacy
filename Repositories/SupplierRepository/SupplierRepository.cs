using Pharmacy.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Xml.Linq;

namespace Pharmacy.Repositories.SupplierRepository
{
    public class SupplierRepository : BaseRepository, ISupplierRepository
    {

        public SupplierRepository(string connectionString)
        {
            connection = connectionString;
        }
        public void Add(SupplierModel supplierModel)
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
                    cmd.CommandText = "insert into Suppliers values(NULL, @name, @product)";
                    cmd.Parameters.Add("@name", DbType.String).Value = supplierModel.Name;
                    cmd.Parameters.Add("@product", DbType.String).Value = supplierModel.Product;
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
                    cmd.CommandText = "delete from Suppliers where Supplier_id=@id";
                    cmd.Parameters.Add("@id", DbType.Int32).Value = id;
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void Edit(SupplierModel supplierModel)
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
                    cmd.CommandText = @"update Supplier
                                        set Supplier_name=@name, Supplier_product=@product
                                        where Supplier_id=@id";
                    cmd.Parameters.Add("@name", DbType.String).Value = supplierModel.Name;
                    cmd.Parameters.Add("@product", DbType.Int32).Value = supplierModel.Product;
                    cmd.Parameters.Add("@id", DbType.Int32).Value = supplierModel.Id;
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public IEnumerable<SupplierModel> GetAll()
        {
            var supplierList = new List<SupplierModel>();
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
                    cmd.CommandText = "Select * from Suppliers order by Supplier_id desc";
                    // Запускаем command reader
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var supplierModel = new SupplierModel();
                            supplierModel.Id = Convert.ToInt32(reader[0]);
                            supplierModel.Name = reader[1].ToString();
                            supplierModel.Product = reader[2].ToString();

                            supplierList.Add(supplierModel);
                        }
                    }
                }
            }
            return supplierList;
        }

        public IEnumerable<SupplierModel> GetByValue(string value)
        {
            var supplierList = new List<SupplierModel>();
            // Создаём соединение с базой данных
            int id = int.TryParse(value, out _) ? Convert.ToInt32(value) : 0;
            string name = value;
            using (var connect = new SQLiteConnection(connection))
            {
                // Определём SQLiteCommand для выполнения операций над БД
                using (var cmd = new SQLiteCommand())
                {
                    connect.Open();
                    // Устанавливаем соединение команд с БД
                    cmd.Connection = connect;
                    // Вводим команду
                    cmd.CommandText = @"Select * from Suppliers
                                    where (Supplier_id=@id or Supplier_name like @name)
                                    order by Supplier_id desc";
                    cmd.Parameters.Add("@id", DbType.Int32).Value = id;
                    cmd.Parameters.AddWithValue("@name", "%" + name + "%");
                    // Запускаем command reader
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var supplierModel = new SupplierModel();
                            supplierModel.Id = Convert.ToInt32(reader[0]);
                            supplierModel.Name = reader[1].ToString();
                            supplierModel.Product = reader[2].ToString();

                            supplierList.Add(supplierModel);
                        }
                    }
                }
            }
            return supplierList;
        }
    }
}
