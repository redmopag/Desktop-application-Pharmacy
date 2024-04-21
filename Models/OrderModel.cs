using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy.Models
{
    public class OrderModel
    {
        private int id;
        private string data;
        private string time;

        [DisplayName("Код поставки")]
        public int Id { get => id; set => id = value; }

        [DisplayName("Дата поставки")]
        [Required(ErrorMessage = "Поле Дата поставки не может быть пустым")]
        public string Data { get => data; set => data = value; }

        [DisplayName("Время поставки")]
        [Required(ErrorMessage = "Поле Время поставки не может быть пустым")]
        public string Time { get => time; set => time = value; }
    }
}
