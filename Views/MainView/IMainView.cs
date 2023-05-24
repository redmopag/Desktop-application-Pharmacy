using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace Pharmacy.Views.MainView
{
    public interface IMainView
    {
        void Show();
        void SetForm(Form form);

        event EventHandler ShowDrugView;
        event EventHandler ShowSuppliersView;
        event EventHandler MainClosed;
    }
}
