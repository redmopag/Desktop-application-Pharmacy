using Pharmacy.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Pharmacy.Views.SuppliersView
{
    public partial class SuppliersView : Form, ISuppliersView
    {
        private bool _isEdit;
        private bool _isSuccessful;
        private string _message;

        public SuppliersView()
        {
            InitializeComponent();
            LinkAndRaiseViewEvents();
            // Delete tabPageDetail
            tabControlSupplierLists.TabPages.Remove(tabPageDetail);
            buttonExit.Click += delegate { Close(); };
        }

        private void LinkAndRaiseViewEvents()
        {
            // Search
            // If search event is not null, it will be invoked
            // Here is used delegate to rais the search event
            buttonSearch.Click += delegate { SearchEvent?.Invoke(this, EventArgs.Empty); };
            // Here is udes labda instead delegate, there is no matter to use one from them
            textBoxSearch.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                    SearchEvent?.Invoke(this, EventArgs.Empty);
            };
            // Add
            buttonAdd.Click += delegate
            {
                AddEvent?.Invoke(this, EventArgs.Empty);
                tabControlSupplierLists.TabPages.Remove(tabPageList);
                tabControlSupplierLists.TabPages.Add(tabPageDetail);
                tabPageDetail.Text = "Add drug";
            };
            // Edit
            buttonEdit.Click += delegate
            {
                EditEvent?.Invoke(this, EventArgs.Empty);
                tabControlSupplierLists.TabPages.Remove(tabPageList);
                tabControlSupplierLists.TabPages.Add(tabPageDetail);
                tabPageDetail.Text = "Edit drug";
            };
            // Delete
            buttonDelete.Click += delegate
            {
                var result = MessageBox.Show("Are you sure you want to delete?", "Warnign", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    DeleteEvent?.Invoke(this, EventArgs.Empty);
                    MessageBox.Show(Message);
                }
            };
            // Save
            buttonSave.Click += delegate
            {
                SaveEvent?.Invoke(this, EventArgs.Empty);
                if (IsSuccessful)
                {
                    tabControlSupplierLists.TabPages.Remove(tabPageDetail);
                    tabControlSupplierLists.TabPages.Add(tabPageList);
                }
                MessageBox.Show(Message);
            };
            // Cancel
            buttonCancel.Click += delegate
            {
                CancelEvent?.Invoke(this, EventArgs.Empty);
                tabControlSupplierLists.TabPages.Remove(tabPageDetail);
                tabControlSupplierLists.TabPages.Add(tabPageList);
            };
        }

        public string SupplierId 
        { 
            get => textBoxSupplierId.Text;
            set => textBoxSupplierId.Text = value; 
        }
        public string SupplierName 
        { 
            get => textBoxSupplier.Text;
            set => textBoxSupplier.Text = value;
        }
        public string SupplierProduct 
        { 
            get => textBoxProduct.Text; 
            set => textBoxProduct.Text = value; 
        }
        public string SearchValue
        {
            get => textBoxSearch.Text;
            set => textBoxSearch.Text = value;
        }
        public bool IsEdit
        {
            get => _isEdit;
            set => _isEdit = value;
        }
        public bool IsSuccessful
        {
            get => _isSuccessful;
            set => _isSuccessful = value;
        }
        public string Message
        {
            get => _message;
            set => _message = value;
        }

        public event EventHandler SearchEvent;
        public event EventHandler EditEvent;
        public event EventHandler DeleteEvent;
        public event EventHandler AddEvent;
        public event EventHandler SaveEvent;
        public event EventHandler CancelEvent;

        public void SetSupplierListBindingSource(BindingSource supplierList)
        {
            dataGridViewSuppliers.DataSource = supplierList;
        }

        private static SuppliersView instance;
        public static SuppliersView GetInstance()
        {
            if(instance == null || instance.IsDisposed)
            {
                instance = new SuppliersView();
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
    }
}
