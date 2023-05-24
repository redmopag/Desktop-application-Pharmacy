using Pharmacy.Models;
using Pharmacy.Repositories;
using Pharmacy.Repositories.EnterRepository;
using Pharmacy.Repositories.SupplierRepository;
using Pharmacy.Views;
using Pharmacy.Views.EnterView;
using Pharmacy.Views.MainView;
using Pharmacy.Views.SuppliersView;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy.Presenters
{
    public class MainPresenter
    {
        private IMainView mainView;
        private string sqlConnection;

        public MainPresenter(IMainView mainView, string sqlConnection)
        {
            this.mainView = mainView;
            this.sqlConnection = sqlConnection;

            mainView.ShowDrugView += ShowDrug;
            mainView.ShowSuppliersView += ShowSuppliers;

            mainView.Show();
        }

        private void ShowSuppliers(object sender, EventArgs e)
        {
            ISuppliersView view = SuppliersView.GetInstance();
            mainView.SetForm((Form)view);
            ISupplierRepository repository = new SupplierRepository(sqlConnection);
            new SuppliersPresenter(view, repository);
        }

        private void ShowDrug(object sender, EventArgs e)
        {
            IDrugView view = DrugView.GetInstance();
            mainView.SetForm((Form)view);
            IDrugRepository repository = new DrugRepository(sqlConnection);
            new DrugPresenter(repository, view);
        }
    }
}
