using Pharmacy.Repositories.EnterRepository;
using Pharmacy.Views;
using Pharmacy.Views.EnterView;
using Pharmacy.Views.MainView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy.Presenters
{
    public class PharmacyPresenter
    {
        private IPharmacyView pharmacyView;
        private string sqlConnection;

        public PharmacyPresenter(IPharmacyView view, string sqlConnection)
        {
            this.pharmacyView = view;
            this.sqlConnection = sqlConnection;

            this.pharmacyView.PharmacyLoaded += LoadEnterView;
        }

        private void LoadEnterView(object sender, EventArgs e)
        {
            IEnterView view = EnterView.GetInstance();
            view.EnterClosed += CreateMainView;
            pharmacyView.SetForm((Form)view);
            IEnterRepository repository = new EnterRepository(sqlConnection);
            new EnterPresenter(view, repository);
        }

        private void CreateMainView(object sender, EventArgs e)
        {
            IMainView view = MainView.GetInstance();
            view.MainClosed += LoadEnterView;
            pharmacyView.SetForm((Form)view);
            new MainPresenter(view, sqlConnection);
        }
    }
}
