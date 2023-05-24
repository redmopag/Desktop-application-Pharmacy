using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy.Views.IEnterView
{
    public partial class EnterView : Form, IEnterView
    {
        public EnterView()
        {
            InitializeComponent();
            buttonEnter.Click += delegate { EnterEvent?.Invoke(this, EventArgs.Empty); };
        }

        public string EnterName 
        { 
            get => textBoxEnterName.Text; 
            set => textBoxEnterName.Text = value; 
        }
        public string EnterPassword 
        { 
            get => textBoxEnterPassword.Text; 
            set => textBoxEnterPassword.Text = value; 
        }

        public event EventHandler EnterEvent;
    }
}
