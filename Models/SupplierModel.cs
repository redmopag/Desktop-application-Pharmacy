using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy.Models
{
    public class SupplierModel
    {
        private int id;
        private string name;
        private string product;

        [Required(ErrorMessage = "Supplier id is required")]
        public int Id { get => id; set => id = value; }
        [Required(ErrorMessage = "Supplier name is required")]
        public string Name { get => name; set => name = value; }
        [Required(ErrorMessage = "Supplier product is required")]
        public string Product { get => product; set => product = value; }
    }
}
