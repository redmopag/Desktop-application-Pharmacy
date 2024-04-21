using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy.Models
{
    public class DrugsInOrderModel
    {
        private int orderId;
        private string name;
        private int amount;
        private int supplierId;
        private int drugId;

        [DisplayName("Код поставки")]
        public int OrderId { get => orderId; set => orderId = value; }

        [DisplayName("Название лекарства")]
        [Required(ErrorMessage = "Поле Название лекарства должно быть заполненым")]
        public string Name { get => name; set => name = value; }

        [DisplayName("Кол-во")]
        [Required(ErrorMessage = "Поле Кол-во должно быть заполненым")]
        public int Amount { get => amount; set => amount = value; }

        [DisplayName("Код поставщика")]
        [Required(ErrorMessage = "Поле Код поставщика должно быть заполненым")]
        public int SupplierId { get => supplierId; set => supplierId = value; }

        [DisplayName("Код лекарства")]
        public int DurgId { get => drugId; set => drugId = value; }
    }
}
