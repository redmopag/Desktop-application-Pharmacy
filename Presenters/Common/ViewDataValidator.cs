using Pharmacy.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy.Presenters.Common
{
    public class ViewDataValidator
    {
        public void Validate(IDrugView view)
        {
            string errorMessage = "";
            if (!int.TryParse(view.DrugAmount, out _))
            {
                errorMessage += " -Drug amount must be integer value\n";
            }
            else if (!int.TryParse(view.DrugPlace, out _))
            {
                errorMessage += " -Drug amunt must be integer value\n";
            }
            else if (!double.TryParse(view.DrugCost, out _))
            {
                errorMessage += " -Drug cost must be fractional number\n";
            }
            else
            {
                return;
            }

            throw new Exception(errorMessage);
        }
    }
}
