using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy.Views
{
    public partial class PharmacyView : Form, IPharmacyView
    {
        public PharmacyView()
        {
            InitializeComponent();
            Load += delegate { PharmacyLoaded?.Invoke(this, EventArgs.Empty); };
        }

        public event EventHandler PharmacyLoaded;


        private static Form instanceForm;
        public void SetForm(Form form)
        {
            form.TopLevel = false;
            if (instanceForm != null)
                panelViews.Controls.Remove(instanceForm);
            panelViews.Controls.Add(form);
            instanceForm = form;
        }
    }
}
