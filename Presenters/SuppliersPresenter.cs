using Pharmacy.Models;
using Pharmacy.Repositories.SupplierRepository;
using Pharmacy.Views.SuppliersView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy.Presenters
{
    public class SuppliersPresenter
    {
        private ISuppliersView view;
        private ISupplierRepository repository;
        private BindingSource suppliersBindingSource;
        private IEnumerable<SupplierModel> supplierList;

        public SuppliersPresenter(ISuppliersView view, ISupplierRepository repository)
        {
            suppliersBindingSource = new BindingSource();
            this.view = view;
            this.repository = repository;

            this.view.SearchEvent += Search;
            this.view.AddEvent += Add;
            this.view.EditEvent += Edit;
            this.view.DeleteEvent += Delete;
            this.view.SaveEvent += Save;
            this.view.CancelEvent += Cancel;

            this.view.SetSupplierListBindingSource(suppliersBindingSource);
            LoadAllSupllierList();
            this.view.Show();
        }

        private void LoadAllSupllierList()
        {
            supplierList = repository.GetAll();
            suppliersBindingSource.DataSource = supplierList;
        }

        private void Clean()
        {
            view.SupplierId = "0";
            view.SupplierName = "";
            view.SupplierEmail = "";
        }

        private void Cancel(object sender, EventArgs e)
        {
            Clean();
        }

        private void Save(object sender, EventArgs e)
        {
            try
            {
                var model = new SupplierModel();
                model.Id = int.TryParse(view.SupplierId, out _) ? int.Parse(view.SupplierId) : 0;
                model.Name = view.SupplierName;
                model.Email = view.SupplierEmail;

                new Common.ModelDataValidator().Validate(model);
                if (view.IsEdit)
                {
                    repository.Edit(model);
                    view.Message = "Supplier edited";
                }
                else
                {
                    repository.Add(model);
                    view.Message = "Supplier added";
                }
                view.IsSuccessful = true;
                LoadAllSupllierList();
                Clean();
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = ex.Message;
            }
        }

        private void Delete(object sender, EventArgs e)
        {
            try
            {
                var model = (SupplierModel)suppliersBindingSource.Current;
                repository.Delete(model.Id);
                view.IsSuccessful = true;
                view.Message = "Drug deleted";
                LoadAllSupllierList();
            }
            catch (Exception)
            {
                view.IsSuccessful = false;
                view.Message = "Couldn't delete supplier";
            }
        }

        private void Edit(object sender, EventArgs e)
        {
            var model = (SupplierModel)suppliersBindingSource.Current;
            view.SupplierId = model.Id.ToString();
            view.SupplierName = model.Name;
            view.SupplierEmail = model.Email;

            view.IsEdit = true;
        }

        private void Add(object sender, EventArgs e)
        {
            view.IsEdit = false;
        }

        private void Search(object sender, EventArgs e)
        {
            bool isEmptyValue = string.IsNullOrWhiteSpace(this.view.SearchValue);
            if (!isEmptyValue)
                supplierList = repository.GetByValue(this.view.SearchValue);
            else
                supplierList = repository.GetAll();

            suppliersBindingSource.DataSource = supplierList;
        }
    }
}
