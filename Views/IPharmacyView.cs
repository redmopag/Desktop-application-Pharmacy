using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy.Views
{
    public interface IPharmacyView
    {
        void SetForm(Form form);
        event EventHandler PharmacyLoaded;
    }
}
