using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pharmacy.Models;
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


            // Set binding source
            this.view.SetDrugListBindingSource(drugsBindingSource);
            // Load drug list view, using GetAll
            LoadAllDrugList();
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
