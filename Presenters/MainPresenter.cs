using Pharmacy.Models;
using Pharmacy.Repositories;
using Pharmacy.Repositories.EnterRepository;
using Pharmacy.Views;
using Pharmacy.Views.IEnterView;
using Pharmacy.Views.MainView;
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
        }

        private void ShowSuppliers(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void ShowDrug(object sender, EventArgs e)
        {
            IDrugView view = DrugView.GetInstance((Form)mainView);
            IDrugRepository repository = new DrugRepository(sqlConnection);
            new DrugPresenter(repository, view);
        }
    }
}
