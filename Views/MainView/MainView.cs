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
        }

        public event EventHandler ShowEnterView;
        public event EventHandler ShowDrugView;
        public event EventHandler ShowSuppliersView;
    }
}
