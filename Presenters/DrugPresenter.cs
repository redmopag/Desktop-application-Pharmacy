using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pharmacy.Models;
using Pharmacy.Presenters.Common;
using Pharmacy.Views;

namespace Pharmacy.Presenters
{
    public class DrugPresenter
    {
        //Fields
        // Here is used interface classes to applay the DIP 
        private IDrugRepository repository;
        private IDrugView view;
        // Field for bindin the data with the dataGridView using BindingSource
        private BindingSource drugsBindingSource;
        // List to store models
        private IEnumerable<DrugModel> drugList;

        // Constructor. It allows dependency injection
        public DrugPresenter(IDrugRepository repository, IDrugView view)
        {
            // Init
            drugsBindingSource = new BindingSource();
            this.repository = repository;
            this.view = view;

            // Link view events with presenter events
            // If view events is generated, the presenter events shoul be done

            // Если было вызвано событие, то то, как оно будет обрабатываться, опредеяется в SearchDrug
            // С остальными событиями аналогичная ситуация
            this.view.SearchEvent += SearchDrug;
            this.view.EditEvent += EditDrug;
            this.view.DeleteEvent += DeleteDrug;
            this.view.SaveEvent += SaveDrug;
            this.view.CancelEvent += Cancel;


            // Set binding source
            this.view.SetDrugListBindingSource(drugsBindingSource);
            // Load drug list view, using GetAll
            LoadAllDrugList();
            // Show From view
            this.view.Show();
        }

        private void Cancel(object sender, EventArgs e)
        {
            CleanViewFields();
        }

        private void SaveDrug(object sender, EventArgs e)
        {
            try
            {
                view.DrugCost = view.DrugCost.Replace('.', ',');
                new Common.DrugViewDataValidator().Validate(view);

                var model = new DrugModel();
                model.Id = int.TryParse(view.DrugId, out _) ? int.Parse(view.DrugId) : 0;
                model.Name = view.DrugName;
                model.Amount = int.Parse(view.DrugAmount);
                model.Place = int.Parse(view.DrugPlace);
                model.Cost = Convert.ToDouble(view.DrugCost);


                new Common.ModelDataValidator().Validate(model);
                if(view.IsEdit)
                {
                    repository.Edit(model);
                    view.Message = "Drug edited";
                }
                else
                {
                    repository.Add(model);
                    view.Message = "Drug added";
                }
                view.IsSuccessful = true;
                LoadAllDrugList();
                CleanViewFields();
            } 
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = ex.Message;
            }
        }

        private void CleanViewFields()
        {
            view.DrugId = "";
            view.DrugName = "";
            view.DrugAmount = "";
            view.DrugPlace = "";
            view.DrugCost = "";
        }

        private void DeleteDrug(object sender, EventArgs e)
        {
            try
            {
                var drugModel = (DrugModel)drugsBindingSource.Current;
                repository.Delete(drugModel.Id);
                view.IsSuccessful = true;
                view.Message = "Drug deleted";
                LoadAllDrugList();
            }
            catch (Exception)
            {
                view.IsSuccessful = false;
                view.Message = "Couldn't delete drug";
            }
        }

        private void EditDrug(object sender, EventArgs e)
        {
            var drug = (DrugModel)drugsBindingSource.Current;
            view.DrugId = drug.Id.ToString();
            view.DrugName = drug.Name;
            view.DrugAmount = drug.Amount.ToString();
            view.DrugPlace = drug.Place.ToString();
            view.DrugCost = drug.Cost.ToString();

            view.IsEdit = true;
        }

        private void AddDrug(object sender, EventArgs e)
        {
            view.IsEdit = false;
        }

        private void LoadAllDrugList()
        {
            drugList = repository.GetAll();
            drugsBindingSource.DataSource = drugList;
        }

        private void SearchDrug(object sender, EventArgs e)
        {
            bool isEmptyValue = string.IsNullOrWhiteSpace(this.view.SearchValue);
            if (!isEmptyValue)
                drugList = repository.GetByValue(this.view.SearchValue);
            else
                drugList = repository.GetAll();

            drugsBindingSource.DataSource = drugList;
        }
    }
}
