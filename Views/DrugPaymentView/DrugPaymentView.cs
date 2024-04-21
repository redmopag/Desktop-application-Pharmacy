using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy.Views.DrugPayment
{
    public partial class DrugPaymentView : Form
    {
        public event EventHandler SearchEvent;
        //public event EventHandler ToPaymentEvent;
        public event EventHandler DoubleClickedEvent;
        public event EventHandler Pay;
        public event EventHandler OkEvent;
        public event EventHandler DeleteDrugEvent;

        public DrugPaymentView()
        {
            InitializeComponent();
            SetupViewEvents();
            tabControlDrugLists.TabPages.Remove(tabPagePay);
        }

        // Настройка обработчиков событий
        public void SetupViewEvents()
        {
            // При нажатии на кнопку Поиск
            buttonSearch.Click += delegate { SearchEvent?.Invoke(this, EventArgs.Empty); };

            // При нажатии на Enter в строке поиска
            // Используется лямбда (объект, аргументы события)
            textBoxSearch.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                    SearchEvent?.Invoke(this, EventArgs.Empty);
            };

            buttonToPayment.Click += delegate
            {
                //ToPaymentEvent?.Invoke(this, EventArgs.Empty);
                // Переходим на другую страницу элемента tabControl
                tabControlDrugLists.TabPages.Remove(tabPageDrugList);
                tabControlDrugLists.TabPages.Add(tabPagePay);
            };

            // При двойном нажатии на строку в DataGridView
            dataGridViewDrugsList.DoubleClick += delegate { DoubleClickedEvent?.Invoke(this, EventArgs.Empty); };

            // Выбор способа оплаты
            comboBoxPayMethod.SelectedIndexChanged += delegate
            {
                if (comboBoxPayMethod.SelectedIndex == 0)
                {
                    labelProvided.Visible = true;
                    labelChange.Visible = true;
                    textBoxProvided.Visible = true;
                    textBoxChange.Visible = true;
                }
            };

            // Нажатие на кнопку Оплата
            buttonPayment.Click += delegate 
            { 
                Pay?.Invoke(this, EventArgs.Empty);

                if (isSuccessful)
                    buttonOk.Visible = true;
                MessageBox.Show(message);
            };

            buttonBack.Click += delegate
            {
                tabControlDrugLists.TabPages.Remove(tabPagePay);
                tabControlDrugLists.TabPages.Add(tabPageDrugList);
            };

            buttonOk.Click += delegate
            {
                OkEvent?.Invoke(this, EventArgs.Empty);
                tabControlDrugLists.TabPages.Remove(tabPagePay);
                tabControlDrugLists.TabPages.Add(tabPageDrugList);
            };

            dataGridViewPay.DoubleClick += delegate { DeleteDrugEvent?.Invoke(this, EventArgs.Empty); };

            buttonExit.Click += delegate { Close(); };
        }

        // Назначение данных, которые будут отображаться в dataGridView
        public void SetBindingSource(BindingSource dataSource)
        {
            dataGridViewDrugsList.DataSource = dataSource;
        }
        // Данные для DataGridView в разделе Оплата
        public void SetBindingSourcePayment(BindingSource dataSource)
        {
            dataGridViewPay.DataSource = dataSource;
        }

        // Singleton
        private static DrugPaymentView instance;
        public static DrugPaymentView GetInstance()
        {
            // Проверка закрывался ли элемент или ещё не был создан
            if(instance == null || instance.IsDisposed)
            {
                // Создание и настройка окна
                instance = new DrugPaymentView();
                instance.FormBorderStyle = FormBorderStyle.None; // Отсутствие рамок
                instance.Dock = DockStyle.Fill; // Полное заполнение
            }
            else
            {
                if (instance.WindowState == FormWindowState.Maximized)
                    instance.WindowState = FormWindowState.Normal;
                instance.BringToFront();
            }
            return instance;
        }


        private bool isSuccessful;
        private string message;
        public string SumPrice
        {
            get => textBoxTotalSum.Text;
            set => textBoxTotalSum.Text = value;
        }
        public string SearchValue
        {
            get => textBoxSearch.Text;
            set => textBoxSearch.Text = value;
        }
        public int MethodIndex
        {
            get => comboBoxPayMethod.SelectedIndex;
        }
        public string Provided
        {
            get => textBoxProvided.Text;
            set => textBoxProvided.Text = value;
        }
        public string Change
        {
            get => textBoxChange.Text;
            set => textBoxChange.Text = value;
        }
        public string Message
        {
            set => message = value;
            get => message;
        }
        public bool IsSuccessful
        {
            set => isSuccessful = value;
            get => isSuccessful;
        }
        public bool IsCheckedReciep
        {
            set => checkBoxRecipeCheck.Checked = value;
            get => checkBoxRecipeCheck.Checked;
        }
    }
}
