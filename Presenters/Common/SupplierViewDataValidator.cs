using Pharmacy.Views;
using Pharmacy.Views.SuppliersView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy.Presenters.Common
{
    public class SupplierViewDataValidator
    {
        public void Validate(ISuppliersView view)
        {
            string errorMessage = "";
            if (view.SupplierEmail.Contains("@")) {
                return;
            }
            else
            {
                errorMessage += "Email поставщика должен содержать @";
            }

            throw new Exception(errorMessage);
        }
    }
}
