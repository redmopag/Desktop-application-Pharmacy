using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pharmacy.Models;
using Pharmacy.Presenters;
using Pharmacy.Repositories;
using Pharmacy.Views;
using System.Configuration;
using Pharmacy.Views.IEnterView;
using Pharmacy.Views.MainView;
using Pharmacy.Repositories.EnterRepository;

namespace Pharmacy
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            string sqlConnection = ConfigurationManager.ConnectionStrings["SqlConnection"].ConnectionString;
            IMainView mainView = new MainView();
            new MainPresenter(mainView, sqlConnection);
            Application.Run((Form)mainView);
        }
    }
}
