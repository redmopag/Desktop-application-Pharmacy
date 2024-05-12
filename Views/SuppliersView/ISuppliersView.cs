using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy.Views.SuppliersView
{
    public interface ISuppliersView
    {
     
        string SupplierId { get; set; }
        string SupplierName { get; set; }
        string SupplierEmail { get; set;  }
        string SearchValue { get; set; }
        bool IsEdit { get; set; }
        bool IsSuccessful { get; set; }
        string Message { get; set; }

        // Events
        event EventHandler SearchEvent;
        event EventHandler EditEvent;
        event EventHandler DeleteEvent;
        event EventHandler AddEvent;
        event EventHandler SaveEvent;
        event EventHandler CancelEvent;

        // Methods
        // BindingSource belongs to the Windows Froms namespace and allows to create the bind between
        // a data control and a data source. In the programm it is used to bing the data grid view and data from the DB
        void SetSupplierListBindingSource(BindingSource supplierList);
        void Show();
    }
}
