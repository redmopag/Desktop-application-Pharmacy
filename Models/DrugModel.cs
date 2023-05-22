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
        [DisplayName("Drug ID")]
        public int Id { get => id; set => id = value; }

        [DisplayName("Drug Name")]
        [Required(ErrorMessage = "Drug name is required")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "Drug name must be between 3 and 50 characters")]
        public string Name { get => name; set => name = value; }

        [DisplayName("Drug Amount")]
        public int Amount { get => amount; set => amount = value; }

        [DisplayName("Drug Case")]
        public int Place { get => place; set => place = value; }

        [DisplayName("Drug Cost")]
        public double Cost { get => cost; set => cost = value; }
    }
}
