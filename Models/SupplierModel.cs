using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy.Models
{
    public class SupplierModel
    {
        private int id;
        private string name;
        private string email;

        [Required(ErrorMessage = "Supplier id is required")]
        public int Id { get => id; set => id = value; }

        [DisplayName("Поставщик")]
        [Required(ErrorMessage = "Supplier name is required")]
        public string Name { get => name; set => name = value; }

        [DisplayName("Email")]
        [Required(ErrorMessage = "Supplier email is required")]
        public string Email { get => email; set => email = value; }
    }
}
