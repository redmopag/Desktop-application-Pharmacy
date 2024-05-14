using Pharmacy.Views;
using Pharmacy.Views.OrderView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy.Presenters.Common
{
    public class DrugInOrderDataValidator
    {
        public void Validate(OrderView view)
        {
            string errorMessage = "";
            if(string.IsNullOrEmpty(view.DrugName))
            {
                errorMessage += " -Название лекарства должно присутствовать";
            }
            else if (!int.TryParse(view.DrugCount, out _))
            {
                errorMessage += " -Кол-во лекарств должно быть целочисленным значением\n";
            }
            else if(view.SelectedSupplier == null)
            {
                errorMessage += " -Поставщик не указан";
            }
            else
            {
                return;
            }

            throw new Exception(errorMessage);
        }
    }
}
