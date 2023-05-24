using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy.Views.MainView
{
    public interface IMainView
    {
        event EventHandler ShowEnterView;
        event EventHandler ShowDrugView;
        event EventHandler ShowSuppliersView;
    }
}
