using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy.Views
{
    public partial class DrugView : Form, IDrugView
    {
        private string _message;
        private bool _isSuccessful;
        private bool _isEdit;

        public DrugView()
        {
            InitializeComponent();
            LinkAndRaiseViewEvents();
            // Delete tabPageDetail
            tabControlDrugLists.TabPages.Remove(tabPageDetail);
            KeyDown += (s, e) =>
            {
                if (e.Modifiers == Keys.Control && e.KeyCode == Keys.W)
                    Close();
            };
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
                tabControlDrugLists.TabPages.Remove(tabPageList);
                tabControlDrugLists.TabPages.Add(tabPageDetail);
                tabPageDetail.Text = "Add drug";
            };
            // Edit
            buttonEdit.Click += delegate 
            { 
                EditEvent?.Invoke(this, EventArgs.Empty);
                tabControlDrugLists.TabPages.Remove(tabPageList);
                tabControlDrugLists.TabPages.Add(tabPageDetail);
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
                if(IsSuccessful)
                {
                    tabControlDrugLists.TabPages.Remove(tabPageDetail);
                    tabControlDrugLists.TabPages.Add(tabPageList);
                }
                MessageBox.Show(Message);
            };
            // Cancel
            buttonCancel.Click += delegate 
            {
                CancelEvent?.Invoke(this, EventArgs.Empty);
                tabControlDrugLists.TabPages.Remove(tabPageDetail);
                tabControlDrugLists.TabPages.Add(tabPageList);
            };
        }

        public string DrugId { 
            get => textBoxDrugId.Text; 
            set => textBoxDrugId.Text = value; }
        public string DrugName { 
            get => textBoxDrugName.Text; 
            set => textBoxDrugName.Text = value; }
        public string DrugAmount { 
            get => textBoxDrugAmount.Text;
            set => textBoxDrugAmount.Text = value; }
        public string DrugPlace { 
            get => textBoxDrugPlace.Text; 
            set => textBoxDrugPlace.Text = value; }
        public string DrugCost { 
            get => textBoxDrugCost.Text; 
            set => textBoxDrugCost.Text = value; }
        public string SearchValue { 
            get => textBoxSearch.Text; 
            set => textBoxSearch.Text = value; }
        public bool IsEdit { 
            get => _isEdit;
            set => _isEdit = value; }
        public bool IsSuccessful { 
            get => _isSuccessful;
            set => _isSuccessful = value; }
        public string Message { 
            get => _message;
            set => _message = value; }

        public event EventHandler SearchEvent;
        public event EventHandler EditEvent;
        public event EventHandler DeleteEvent;
        public event EventHandler AddEvent;
        public event EventHandler SaveEvent;
        public event EventHandler CancelEvent;

        public void SetDrugListBindingSource(BindingSource drugList)
        {
            dataGridViewDrugs.DataSource = drugList;
        }

        // Singleton
        private static DrugView instance;
        public static DrugView GetInstance(Form parent)
        {
            if(instance == null || instance.IsDisposed)
            {
                instance = new DrugView();
                instance.MdiParent= parent;
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
