using Pharmacy.Models;
using Pharmacy.Views.DrugPayment;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy.Presenters
{
    public class DrugPaymentPresenter
    {
        private IDrugRepository repository;
        private DrugPaymentView view;
        // Для связи с DataGridView в разделе выбора товара
        private BindingSource bindingSource;
        // Для связи с DataGridView в разделе оплаты
        private BindingSource bindingSourcePayment;
        private IEnumerable<DrugModel> drugModels;

        public DrugPaymentPresenter(IDrugRepository repository, DrugPaymentView view)
        {
            this.repository = repository;
            this.view = view;
            bindingSource = new BindingSource();
            bindingSourcePayment = new BindingSource();

            // Определение логики обработки событий, возникающих в DrugPaymentView
            this.view.SearchEvent += SearchDrug;
            this.view.DoubleClickedEvent += DrugPreparing;
            this.view.Pay += DrugPay;
            this.view.OkEvent += CleanPage;
            this.view.DeleteDrugEvent += DeleteDrug;

            // Связывание источника информации и DataGridView
            this.view.SetBindingSource(bindingSource);
            // То же самое для раздела оплата
            this.view.SetBindingSourcePayment(bindingSourcePayment);
            // Заполнение источника информации данными
            LoadAllDrugModels();

            // Отображение окна
            this.view.Show();
        }

        private void DeleteDrug(object sender, EventArgs e)
        {
            bindingSourcePayment.Remove(bindingSourcePayment.Current);
        }

        private void CleanPage(object sender, EventArgs e)
        {
            Clean();
        }
        private void Clean()
        {
            this.view.SumPrice = "0";
            this.view.Provided = "";
            this.view.Change = "";
            this.view.IsCheckedReciep = false;
        }

        private void LoadAllDrugModels()
        {
            drugModels = repository.GetAll();
            bindingSource.DataSource = drugModels;
        }

        private void DrugPay(object sender, EventArgs e)
        {
            this.view.IsSuccessful = false;
            if (this.view.IsCheckedReciep)
            {
                if (this.view.MethodIndex == 0)
                {
                    if (double.Parse(this.view.Provided) < double.Parse(this.view.SumPrice))
                    {
                        this.view.Message = "Недостаточная сумма";
                        this.view.IsSuccessful = false;
                    }
                    else if (string.IsNullOrEmpty(this.view.Provided))
                    {
                        this.view.Message = "Не указана сумма";
                        this.view.IsSuccessful = false;
                    }
                    else
                    {
                        this.view.IsSuccessful = true;
                        this.view.Message = "Оплата прошла успешно";
                        this.view.Change = (double.Parse(view.Provided) - double.Parse(view.SumPrice)).ToString();
                    }
                }
                else
                {
                    this.view.IsSuccessful = true;
                    this.view.Message = "Оплата прошла успешно";
                }

                if (view.IsSuccessful)
                {
                    var drugModels = bindingSourcePayment.List;
                    for(int i = 0; i < drugModels.Count; ++i)
                    {
                        var drugModel = (DrugModel)drugModels[i];
                        if (--drugModel.Amount <= 0)
                            repository.Delete(drugModel.Id);
                        else
                            repository.Edit(drugModel);
                    }
                }
            }
            else
            {
                this.view.Message = "Рецепт не проверен";
                this.view.IsSuccessful = false;
            }
        }

        // Обработка события выбора лекарства двойным нажатием мыши
        private void DrugPreparing(object sender, EventArgs e)
        {
            // Добавление выделенного лекарства в список покумаемых
            bindingSourcePayment.Add(bindingSource.Current);

            // Получение цены за лекарство
            var drug = (DrugModel)bindingSource.Current;
            double price = drug.Cost;

            // Нахождение общей суммы лекарства
            this.view.SumPrice = (Double.Parse(this.view.SumPrice) + price).ToString();
        }

        // Обработка события поиска лекарства в разделе каталог лекарств
        private void SearchDrug(object sender, EventArgs e) 
        {
            bool isEmptySearch = string.IsNullOrWhiteSpace(this.view.SearchValue);
            // Если поле не пустое, то ищем по значению, иначе выводим все лекарства
            if (!isEmptySearch)
                drugModels = repository.GetByValue(this.view.SearchValue);
            else
                drugModels = repository.GetAll();

            bindingSource.DataSource = drugModels;
        }
    }
}
