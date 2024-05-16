using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Pharmacy.Models
{
    public class DrugModel
    {
        //Fields
        private int id;
        private string name;
        private int amount;
        private int place;
        private double cost;

        //Properties - Validations
        [DisplayName("ID")]
        public int Id { get => id; set => id = value; }

        [DisplayName("Название")]
        [Required(ErrorMessage = "Drug name is required")]
        public string Name { get => name; set => name = value; }

        [DisplayName("Количество")]
        [Required(ErrorMessage = "Drug amount is required")]
        public int Amount { get => amount; set => amount = value; }

        [DisplayName("Ящик")]
        public int Place { get => place; set => place = value; }

        [DisplayName("Цена")]
        [Required(ErrorMessage = "Drug cost is required")]
        public double Cost { get => cost; set => cost = value; }
    }
}
