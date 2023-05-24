using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Configuration;

namespace Pharmacy.Presenters.Common
{
    public class ModelDataValidator
    {
        public void Validate(object model)
        {
            string errorMessage = "";
            // Записывается результат
            List<ValidationResult> errors = new List<ValidationResult>();
            // Контекс для оценки (проверки) модели
            ValidationContext context = new ValidationContext(model);
            bool isValid = Validator.TryValidateObject(model, context, errors, true);
            if(isValid == false)
            {
                foreach (var error in errors)
                    errorMessage += " -" + error.ErrorMessage + "\n";
                throw new Exception(errorMessage);
            }
        }
    }
}
