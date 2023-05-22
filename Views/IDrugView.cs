using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace Pharmacy.Views
{
    public interface IDrugView
    {
        //Properties (Fields)
        string DrugId { get; set; }
        string DrugName { get; set; }
        string DrugAmount { get; set; }
        string DrugPlace { get; set; }
        string DrugCost { get; set; }

        string SearchValue { get; set; }
        bool isEdit { get; set; }
        bool isSuccessful { get; set; }
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
        void SetDrugListBindingSource(BindingSource drugList);
        void Show();
    }
}
