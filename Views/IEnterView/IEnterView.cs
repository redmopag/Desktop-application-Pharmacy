using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy.Views.IEnterView
{
    public interface IEnterView
    {
        string EnterName { get; set; }
        string EnterPassword { get; set; }

        event EventHandler EnterEvent;
    }
}
