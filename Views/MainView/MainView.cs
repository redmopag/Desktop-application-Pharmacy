using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy.Views.MainView
{
    public partial class MainView : Form, IMainView
    {
        public MainView()
        {
            InitializeComponent();
            buttonDrugs.Click += delegate { ShowDrugView?.Invoke(this, EventArgs.Empty); };
            buttonSuppliers.Click += delegate { ShowSuppliersView?.Invoke(this, EventArgs.Empty); };
            this.FormClosed += delegate { MainClosed?.Invoke(this, EventArgs.Empty); };
            buttonExit.Click += delegate { Close(); };
        }

        private static MainView instance;
        public static MainView GetInstance()
        {
            if (instance == null)
            {
                instance = new MainView();
                instance.FormBorderStyle = FormBorderStyle.None;
                instance.Dock = DockStyle.Fill;
            }
            else
            {
                if (instance.WindowState == FormWindowState.Maximized)
                    instance.WindowState = FormWindowState.Normal;
                instance.BringToFront();
            }

            return instance;
        }

        private static Form instanceForm;
        public void SetForm(Form form)
        {
            form.TopLevel = false;
            if(instanceForm != null)
                panelViews.Controls.Remove(instanceForm);
            panelViews.Controls.Add(form);
            form.Show();
            instanceForm = form;
        }

        public event EventHandler ShowDrugView;
        public event EventHandler ShowSuppliersView;
        public event EventHandler MainClosed;
    }
}
