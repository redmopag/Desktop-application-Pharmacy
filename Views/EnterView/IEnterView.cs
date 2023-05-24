using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy.Views.EnterView
{
    public interface IEnterView
    {
        string EnterName { get; set; }
        string EnterPassword { get; set; }
        string Message { get; set; }
        bool IsSuccessful { get; set; }
        void Close();
        void Show();

        event EventHandler EnterEvent;
        event EventHandler EnterClosed;
    }
}
