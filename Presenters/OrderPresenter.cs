using Pharmacy.Models;
using Pharmacy.Repositories.OrderRepository;
using Pharmacy.Repositories.SupplierRepository;
using Pharmacy.Views.OrderView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy.Presenters
{
    public class OrderPresenter
    {
        private OrderRepository repository;
        private SupplierRepository supplierRepository;
        private OrderView view;
        private BindingSource bsOrderList;
        private BindingSource bsOrderDetail;
        private BindingSource bsOrderCancel;
        private BindingSource bsNewOrder;

        private IEnumerable<OrderModel> orderList;
        private IEnumerable<DrugsInOrderModel> drugList;

        public OrderPresenter(OrderRepository repository, OrderView view, SupplierRepository supplierRepository)
        {
            bsOrderList = new BindingSource();
            bsOrderDetail = new BindingSource();
            bsOrderCancel = new BindingSource();
            bsNewOrder = new BindingSource();

            this.repository = repository;
            this.view = view;
            this.supplierRepository = supplierRepository;

            this.view.SearchEvent += SearchOrder;
            this.view.AddOrderEvent += AddOrder;
            this.view.AddAnotherDrugEvent += AddDrug;
            this.view.DeleteDrugEvent += DeleteDrug;
            this.view.PostOrderEvent += MakeOrder;
            this.view.ChooseEvent += DrugToCancel;
            this.view.LookOrderEvent += LookOrder;
            this.view.OrderAcceptEvent += OrderAccept;
            this.view.RemoveFromCancelEvent += RemoveFromCancel;
            this.view.PostCancelEvent += PostCancel;
            

            this.view.SetBindingSource(bsOrderList, bsOrderCancel, bsNewOrder, bsOrderDetail);
            LoadAllOrderList();
            this.view.Show();
        }

        private void PostCancel(object sender, EventArgs e)
        {
            bsOrderCancel.Clear();
            view.CancelText = "";
            view.Message = "Отказ отправлен";
        }

        private void RemoveFromCancel(object sender, EventArgs e)
        {
            var current = bsOrderCancel.Current;
            bsOrderDetail.Add(current);
            bsOrderCancel.Remove(current);
        }

        private void OrderAccept(object sender, EventArgs e)
        {
            bsOrderList.Remove(bsOrderList.Current);
            bsOrderDetail.Clear();
            view.Message = "Поставка принята";
        }

        private void LookOrder(object sender, EventArgs e)
        {
            var orderModel = (OrderModel)bsOrderList.Current;
            drugList = repository.GetAllDrugs(orderModel.Id);
            bsOrderDetail.DataSource = drugList;
        }

        private void DrugToCancel(object sender, EventArgs e)
        {
            var current = bsOrderDetail.Current;
            bsOrderDetail.Remove(current);

            bsOrderCancel.Add(current); 
        }

        private void MakeOrder(object sender, EventArgs e)
        {
            if(bsNewOrder.Count != 0)
            {
                // Получение рандомного времени и даты доставки заказа
                Random gen = new Random();
                DateTime start = new DateTime(2023, 11, 12);
                int range = (DateTime.Today - start).Days;
                DateTime dateTime = start.AddDays(gen.Next(range));

                string date = dateTime.Date.ToString();
                string time = dateTime.TimeOfDay.ToString();

                // Создаём модель заказа
                var model = new OrderModel();
                model.Data = date;
                model.Time = time;
                // Частично заполняем её: дата и вермя - и добавляем в бд
                repository.AddOrder(model);

                // Получаем последнюю запись с БД
                model = repository.getLatestRecord();
                // Проходимся по всем лекарствам в заказе
                var list = bsNewOrder.List;
                for(int i = 0; i < list.Count; ++i)
                {
                    // Добавляем в модель данные: ID заказа
                    var drugModel = (DrugsInOrderModel)list[i];
                    drugModel.OrderId = model.Id;
                    repository.AddDrug(drugModel);
                }

                bsNewOrder.Clear();
                view.DrugCount = "";
                view.DrugName = "";

                view.IsSuccessful = true;
                view.Message = "Поставка создана";

                LoadAllOrderList();
            }
            else
            {
                view.IsSuccessful = false;
                view.Message = "Ошибка";
            }
        }

        private void DeleteDrug(object sender, EventArgs e)
        {
            bsNewOrder.Remove(bsNewOrder.Current);
        }

        private void AddDrug(object sender, EventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(view.DrugCount) && !string.IsNullOrWhiteSpace(view.DrugName))
            {
                string supplierName = view.SelectedText;
                IEnumerable<SupplierModel> suppliers = supplierRepository.GetByValue(supplierName);

                DrugsInOrderModel model = new DrugsInOrderModel();
                model.Name = view.DrugName;
                model.Amount = int.Parse(view.DrugCount);
                model.SupplierId = suppliers.First().Id;

                bsNewOrder.Add(model);
                view.IsSuccessful = true;
            }
            else
            {
                view.IsSuccessful = false;
                view.Message = "Поля должны быть заполнены";
            }
        }

        private void LoadAllOrderList()
        {
            orderList = repository.GetAll();
            bsOrderList.DataSource = orderList;
        }

        private void AddOrder(object sender, EventArgs e)
        {
            view.Suppliers.Clear();

            IEnumerable<SupplierModel> supplierList = supplierRepository.GetAll();
            for(int i = 0; i < supplierList.Count(); ++i)
                view.Suppliers.Add(supplierList.ElementAt(i).Name);
        }

        private void SearchOrder(object sender, EventArgs e)
        {
            bool isEmptyValue = string.IsNullOrWhiteSpace(view.SearchValue);
            if (!isEmptyValue)
                orderList = repository.GetByValue(view.SearchValue);
            else
                orderList = repository.GetAll();

            bsOrderList.DataSource = orderList;
        }
    }
}
