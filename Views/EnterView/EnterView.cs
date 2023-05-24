using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy.Views.EnterView
{
    public partial class EnterView : Form, IEnterView
    {
        private string _message;
        private bool _isSuccessful = false;

        public EnterView()
        {
            InitializeComponent();
            buttonEnter.Click += delegate 
            { 
                EnterEvent?.Invoke(this, EventArgs.Empty);
                if (IsSuccessful)
                    Close();
                else
                    MessageBox.Show(Message);
            };
            this.FormClosed += delegate { EnterClosed?.Invoke(this, EventArgs.Empty); };
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
        public string Message { get => _message; set => _message = value; }
        public bool IsSuccessful { get => _isSuccessful; set => _isSuccessful = value; }


        private static EnterView instance;
        public static EnterView GetInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new EnterView();
                instance.FormBorderStyle = FormBorderStyle.None;
                instance.Dock = DockStyle.Fill;
            }
            else
            {
                if (instance.WindowState == FormWindowState.Maximized)
                    instance.WindowState = FormWindowState.Normal;
                instance.BringToFront();
            }
            return instance;
        }

        public event EventHandler EnterEvent;
        public event EventHandler EnterClosed;
    }
}
