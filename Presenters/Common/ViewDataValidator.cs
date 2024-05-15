using Pharmacy.Views;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy.Presenters.Common
{
    public class DrugViewDataValidator
    {
        public void Validate(IDrugView view)
        {
            string errorMessage = "";
            if (!int.TryParse(view.DrugAmount, out _))
            {
                errorMessage += " -Кол-во лекарства должно быть целым числом\n";
            }
            else if (!int.TryParse(view.DrugPlace, out _))
            {
                errorMessage += " -Расположение лекарства должно быть целым число\n";
            }
            else if (!double.TryParse(view.DrugCost, out _) && !int.TryParse(view.DrugCost, out _))
            {
                errorMessage += " -Цена за лекарство должна быть вещественным или целым числом\n";
            }
            else
            {
                return;
            }

            throw new Exception(errorMessage);
        }
    }
}
