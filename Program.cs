﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pharmacy.Models;
using Pharmacy.Presenters;
using Pharmacy.Repositories;
using Pharmacy.Views;
using System.Configuration;
using Pharmacy.Views.EnterView;
using Pharmacy.Views.MainView;
using Pharmacy.Repositories.EnterRepository;
using System.IO;

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
            //string sqlConnection = ConfigurationManager.ConnectionStrings["SqlConnection"].ConnectionString;

            var root = Directory.GetCurrentDirectory();
            var temp = Directory.GetParent(root);
            var db = Directory.GetParent(temp.FullName);
            string sqlConnection = @"Data Source=" + db + @"\Pharmacy.db;Version=3;";

            IPharmacyView pharmacyView = new PharmacyView();
            new PharmacyPresenter(pharmacyView, sqlConnection);
            Application.Run((Form)pharmacyView);
            //IMainView view = new MainView();
            //new MainPresenter(view, sqlConnection);
            //Application.Run((Form)view);
        }
    }
}
