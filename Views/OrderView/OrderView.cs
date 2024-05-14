using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy.Views.OrderView
{
    public partial class OrderView : Form
    {
        public event EventHandler SearchEvent;
        public event EventHandler AddOrderEvent;
        public event EventHandler AddAnotherDrugEvent;
        public event EventHandler DeleteDrugEvent;
        public event EventHandler PostOrderEvent;
        public event EventHandler ChooseEvent;
        public event EventHandler LookOrderEvent;
        public event EventHandler OrderAcceptEvent;
        public event EventHandler RemoveFromCancelEvent;
        public event EventHandler PostCancelEvent;
        public event EventHandler ToCancelListEvent;

        public OrderView()
        {
            InitializeComponent();
            SetupViewEvents();

            tabControlOrders.TabPages.Remove(tabPageOrderAccept);
            tabControlOrders.TabPages.Remove(tabPageOrderAdd);
            tabControlOrders.TabPages.Remove(tabPageOrderCancel);
        }

        public void SetBindingSource(BindingSource order, BindingSource cancel,
            BindingSource drugInOrder, BindingSource details)
        {
            dataGridViewOrders.DataSource = order;
            dataGridViewCancelList.DataSource = cancel;
            dataGridViewDrugInOrder.DataSource = drugInOrder;
            dataGridViewOrderDetails.DataSource = details;
        }

        private void SetupViewEvents()
        {
            buttonOrderAdd.Click += delegate
            {
                AddOrderEvent?.Invoke(this, EventArgs.Empty);

                tabControlOrders.TabPages.Remove(tabPageOrdersList);
                tabControlOrders.TabPages.Add(tabPageOrderAdd);
            };

            buttonOrderSearch.Click += delegate { SearchEvent?.Invoke(this, EventArgs.Empty); };

            textBoxOrdersSearch.KeyDown += delegate { SearchEvent?.Invoke(this, EventArgs.Empty); };

            buttonAddDrug.Click += delegate 
            { 
                AddAnotherDrugEvent?.Invoke(this, EventArgs.Empty);
                if (!isSuccessful)
                    MessageBox.Show(message);
                else
                {
                    textBoxDrugName.Text = "";
                    textBoxDrugCount.Text = "";
                    comboBoxSupplierForOrder.SelectedIndex = -1;
                }
            };

            buttonDeleteDrug.Click += delegate
            {
                DeleteDrugEvent?.Invoke(this, EventArgs.Empty);
            };

            buttonMakeOrder.Click += delegate
            {
                PostOrderEvent?.Invoke(this, EventArgs.Empty);
                if(isSuccessful)
                {
                    tabControlOrders.TabPages.Remove(tabPageOrderAdd);
                    tabControlOrders.TabPages.Add(tabPageOrdersList);
                }
                MessageBox.Show(message);
            };

            dataGridViewOrderDetails.DoubleClick += delegate
            {
                ChooseEvent?.Invoke(this, EventArgs.Empty);
            };

            buttonDetail.Click += delegate
            {
                tabControlOrders.TabPages.Remove(tabPageOrdersList);
                tabControlOrders.TabPages.Add(tabPageOrderAccept);

                LookOrderEvent?.Invoke(this, EventArgs.Empty);
            };

            buttonOrderAccept.Click += delegate
            {
                tabControlOrders.TabPages.Remove(tabPageOrderAccept);
                tabControlOrders.TabPages.Add(tabPageOrdersList);

                OrderAcceptEvent?.Invoke(this, EventArgs.Empty);
                MessageBox.Show(message);
            };

            buttonOrderCancel.Click += delegate
            {
                ToCancelListEvent?.Invoke(this, EventArgs.Empty);

                if (isSuccessful)
                {
                    tabControlOrders.TabPages.Remove(tabPageOrderAccept);
                    tabControlOrders.TabPages.Add(tabPageOrderCancel);
                }
                else
                {
                    MessageBox.Show(message);
                }
            };

            dataGridViewCancelList.DoubleClick += delegate
            {
                RemoveFromCancelEvent?.Invoke(this, EventArgs.Empty);
            };

            buttonPostCancel.Click += delegate
            {
                tabControlOrders.TabPages.Remove(tabPageOrderCancel);
                tabControlOrders.TabPages.Add(tabPageOrderAccept);

                PostCancelEvent?.Invoke(this, EventArgs.Empty);
                MessageBox.Show(message);
            };

            buttonBackToDetail.Click += delegate
            {
                tabControlOrders.TabPages.Remove(tabPageOrderCancel);
                tabControlOrders.TabPages.Add(tabPageOrderAccept);
            };

            buttonBackToList.Click += delegate
            {
                tabControlOrders.TabPages.Remove(tabPageOrderAdd);
                tabControlOrders.TabPages.Add(tabPageOrdersList);
            };

            buttonDetailToList.Click += delegate
            {
                tabControlOrders.TabPages.Remove(tabPageOrderAccept);
                tabControlOrders.TabPages.Add(tabPageOrdersList);
                dataGridViewOrderDetails.Rows.Clear();
            };

            buttonExit.Click += delegate { Close(); };
        }


        private string message;
        private bool isSuccessful;
        public string Message
        {
            get => message;
            set => message = value;
        }
        public bool IsSuccessful
        {
            get => isSuccessful;
            set => isSuccessful = value;
        }
        public string SearchValue
        {
            get => textBoxOrdersSearch.Text;
            set => textBoxOrdersSearch.Text = value;
        }
        public string DrugName
        {
            get => textBoxDrugName.Text;
            set => textBoxDrugName.Text = value;
        }
        public string DrugCount
        {
            get => textBoxDrugCount.Text;
            set => textBoxDrugCount.Text = value;
        }
        public ComboBox.ObjectCollection Suppliers
        {
            get => comboBoxSupplierForOrder.Items;
        }
        public object SelectedSupplier
        {
            get => comboBoxSupplierForOrder.SelectedItem;
        }
        public string CancelText
        {
            get => richTextBoxCancelText.Text;
            set => richTextBoxCancelText.Text = value;
        }

        private static OrderView instance;
        public static OrderView GetInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new OrderView();
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
