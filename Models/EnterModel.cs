using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Pharmacy.Models
{
    // Класс для авторизации 
    public class EnterModel
    {
        private int id;
        private string name;
        private string password;

        public int Id { get => id; set => id = value; }
        [Required(ErrorMessage ="Name is required")]
        public string Name { get => name; set => name = value; }
        [Required(ErrorMessage ="Password is required")]
        public string Password { get => password; set => password = value; }
    }
}
