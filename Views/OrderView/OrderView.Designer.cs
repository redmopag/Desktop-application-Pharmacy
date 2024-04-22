namespace Pharmacy.Views.OrderView
{
    partial class OrderView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControlOrders = new System.Windows.Forms.TabControl();
            this.tabPageOrdersList = new System.Windows.Forms.TabPage();
            this.buttonDetail = new System.Windows.Forms.Button();
            this.labelOrderSearch = new System.Windows.Forms.Label();
            this.buttonOrderAdd = new System.Windows.Forms.Button();
            this.buttonOrderSearch = new System.Windows.Forms.Button();
            this.textBoxOrdersSearch = new System.Windows.Forms.TextBox();
            this.tabPageOrderAccept = new System.Windows.Forms.TabPage();
            this.buttonDetailToList = new System.Windows.Forms.Button();
            this.buttonOrderCancel = new System.Windows.Forms.Button();
            this.buttonOrderAccept = new System.Windows.Forms.Button();
            this.labelOrderDetails = new System.Windows.Forms.Label();
            this.tabPageOrderAdd = new System.Windows.Forms.TabPage();
            this.buttonBackToList = new System.Windows.Forms.Button();
            this.buttonDeleteDrug = new System.Windows.Forms.Button();
            this.buttonMakeOrder = new System.Windows.Forms.Button();
            this.buttonAddDrug = new System.Windows.Forms.Button();
            this.comboBoxSupplierForOrder = new System.Windows.Forms.ComboBox();
            this.textBoxDrugCount = new System.Windows.Forms.TextBox();
            this.textBoxDrugName = new System.Windows.Forms.TextBox();
            this.labelProductCount = new System.Windows.Forms.Label();
            this.labelProductName = new System.Windows.Forms.Label();
            this.labelSupplierForOrder = new System.Windows.Forms.Label();
            this.tabPageOrderCancel = new System.Windows.Forms.TabPage();
            this.buttonBackToDetail = new System.Windows.Forms.Button();
            this.buttonPostCancel = new System.Windows.Forms.Button();
            this.richTextBoxCancelText = new System.Windows.Forms.RichTextBox();
            this.labelCancelText = new System.Windows.Forms.Label();
            this.labelCancelList = new System.Windows.Forms.Label();
            this.panelOrder = new System.Windows.Forms.Panel();
            this.buttonExit = new System.Windows.Forms.Button();
            this.labelOrders = new System.Windows.Forms.Label();
            this.dataGridViewOrders = new System.Windows.Forms.DataGridView();
            this.dataGridViewOrderDetails = new System.Windows.Forms.DataGridView();
            this.dataGridViewDrugInOrder = new System.Windows.Forms.DataGridView();
            this.dataGridViewCancelList = new System.Windows.Forms.DataGridView();
            this.labelDrugInOrder = new System.Windows.Forms.Label();
            this.tabControlOrders.SuspendLayout();
            this.tabPageOrdersList.SuspendLayout();
            this.tabPageOrderAccept.SuspendLayout();
            this.tabPageOrderAdd.SuspendLayout();
            this.tabPageOrderCancel.SuspendLayout();
            this.panelOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrderDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDrugInOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCancelList)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlOrders
            // 
            this.tabControlOrders.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlOrders.Controls.Add(this.tabPageOrdersList);
            this.tabControlOrders.Controls.Add(this.tabPageOrderAccept);
            this.tabControlOrders.Controls.Add(this.tabPageOrderAdd);
            this.tabControlOrders.Controls.Add(this.tabPageOrderCancel);
            this.tabControlOrders.Location = new System.Drawing.Point(1, 96);
            this.tabControlOrders.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabControlOrders.Name = "tabControlOrders";
            this.tabControlOrders.SelectedIndex = 0;
            this.tabControlOrders.Size = new System.Drawing.Size(1065, 457);
            this.tabControlOrders.TabIndex = 5;
            // 
            // tabPageOrdersList
            // 
            this.tabPageOrdersList.Controls.Add(this.dataGridViewOrders);
            this.tabPageOrdersList.Controls.Add(this.buttonDetail);
            this.tabPageOrdersList.Controls.Add(this.labelOrderSearch);
            this.tabPageOrdersList.Controls.Add(this.buttonOrderAdd);
            this.tabPageOrdersList.Controls.Add(this.buttonOrderSearch);
            this.tabPageOrdersList.Controls.Add(this.textBoxOrdersSearch);
            this.tabPageOrdersList.Location = new System.Drawing.Point(4, 25);
            this.tabPageOrdersList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPageOrdersList.Name = "tabPageOrdersList";
            this.tabPageOrdersList.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPageOrdersList.Size = new System.Drawing.Size(1057, 428);
            this.tabPageOrdersList.TabIndex = 0;
            this.tabPageOrdersList.Text = "Список поставок";
            this.tabPageOrdersList.UseVisualStyleBackColor = true;
            // 
            // buttonDetail
            // 
            this.buttonDetail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDetail.Location = new System.Drawing.Point(911, 124);
            this.buttonDetail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonDetail.Name = "buttonDetail";
            this.buttonDetail.Size = new System.Drawing.Size(131, 28);
            this.buttonDetail.TabIndex = 7;
            this.buttonDetail.Text = "Открыть";
            this.buttonDetail.UseVisualStyleBackColor = true;
            // 
            // labelOrderSearch
            // 
            this.labelOrderSearch.AutoSize = true;
            this.labelOrderSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelOrderSearch.Location = new System.Drawing.Point(4, 28);
            this.labelOrderSearch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelOrderSearch.Name = "labelOrderSearch";
            this.labelOrderSearch.Size = new System.Drawing.Size(158, 25);
            this.labelOrderSearch.TabIndex = 6;
            this.labelOrderSearch.Text = "Поиск поставок";
            // 
            // buttonOrderAdd
            // 
            this.buttonOrderAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOrderAdd.Location = new System.Drawing.Point(911, 89);
            this.buttonOrderAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonOrderAdd.Name = "buttonOrderAdd";
            this.buttonOrderAdd.Size = new System.Drawing.Size(131, 28);
            this.buttonOrderAdd.TabIndex = 3;
            this.buttonOrderAdd.Text = "Добавить";
            this.buttonOrderAdd.UseVisualStyleBackColor = true;
            // 
            // buttonOrderSearch
            // 
            this.buttonOrderSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOrderSearch.Location = new System.Drawing.Point(779, 57);
            this.buttonOrderSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonOrderSearch.Name = "buttonOrderSearch";
            this.buttonOrderSearch.Size = new System.Drawing.Size(124, 25);
            this.buttonOrderSearch.TabIndex = 2;
            this.buttonOrderSearch.Text = "Поиск";
            this.buttonOrderSearch.UseVisualStyleBackColor = true;
            // 
            // textBoxOrdersSearch
            // 
            this.textBoxOrdersSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxOrdersSearch.Location = new System.Drawing.Point(4, 57);
            this.textBoxOrdersSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxOrdersSearch.Name = "textBoxOrdersSearch";
            this.textBoxOrdersSearch.Size = new System.Drawing.Size(765, 22);
            this.textBoxOrdersSearch.TabIndex = 1;
            // 
            // tabPageOrderAccept
            // 
            this.tabPageOrderAccept.Controls.Add(this.dataGridViewOrderDetails);
            this.tabPageOrderAccept.Controls.Add(this.buttonDetailToList);
            this.tabPageOrderAccept.Controls.Add(this.buttonOrderCancel);
            this.tabPageOrderAccept.Controls.Add(this.buttonOrderAccept);
            this.tabPageOrderAccept.Controls.Add(this.labelOrderDetails);
            this.tabPageOrderAccept.Location = new System.Drawing.Point(4, 25);
            this.tabPageOrderAccept.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPageOrderAccept.Name = "tabPageOrderAccept";
            this.tabPageOrderAccept.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPageOrderAccept.Size = new System.Drawing.Size(1057, 428);
            this.tabPageOrderAccept.TabIndex = 1;
            this.tabPageOrderAccept.Text = "Принятие поставки";
            this.tabPageOrderAccept.UseVisualStyleBackColor = true;
            // 
            // buttonDetailToList
            // 
            this.buttonDetailToList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDetailToList.Location = new System.Drawing.Point(580, 11);
            this.buttonDetailToList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonDetailToList.Name = "buttonDetailToList";
            this.buttonDetailToList.Size = new System.Drawing.Size(124, 28);
            this.buttonDetailToList.TabIndex = 4;
            this.buttonDetailToList.Text = "Назад";
            this.buttonDetailToList.UseVisualStyleBackColor = true;
            // 
            // buttonOrderCancel
            // 
            this.buttonOrderCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOrderCancel.Location = new System.Drawing.Point(864, 11);
            this.buttonOrderCancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonOrderCancel.Name = "buttonOrderCancel";
            this.buttonOrderCancel.Size = new System.Drawing.Size(180, 28);
            this.buttonOrderCancel.TabIndex = 3;
            this.buttonOrderCancel.Text = "К оформлению отказа";
            this.buttonOrderCancel.UseVisualStyleBackColor = true;
            // 
            // buttonOrderAccept
            // 
            this.buttonOrderAccept.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOrderAccept.Location = new System.Drawing.Point(712, 11);
            this.buttonOrderAccept.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonOrderAccept.Name = "buttonOrderAccept";
            this.buttonOrderAccept.Size = new System.Drawing.Size(144, 28);
            this.buttonOrderAccept.TabIndex = 2;
            this.buttonOrderAccept.Text = "Принятие заказа";
            this.buttonOrderAccept.UseVisualStyleBackColor = true;
            // 
            // labelOrderDetails
            // 
            this.labelOrderDetails.AutoSize = true;
            this.labelOrderDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelOrderDetails.Location = new System.Drawing.Point(4, 15);
            this.labelOrderDetails.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelOrderDetails.Name = "labelOrderDetails";
            this.labelOrderDetails.Size = new System.Drawing.Size(175, 25);
            this.labelOrderDetails.TabIndex = 1;
            this.labelOrderDetails.Text = "Детали поставки";
            // 
            // tabPageOrderAdd
            // 
            this.tabPageOrderAdd.Controls.Add(this.labelDrugInOrder);
            this.tabPageOrderAdd.Controls.Add(this.dataGridViewDrugInOrder);
            this.tabPageOrderAdd.Controls.Add(this.buttonBackToList);
            this.tabPageOrderAdd.Controls.Add(this.buttonDeleteDrug);
            this.tabPageOrderAdd.Controls.Add(this.buttonMakeOrder);
            this.tabPageOrderAdd.Controls.Add(this.buttonAddDrug);
            this.tabPageOrderAdd.Controls.Add(this.comboBoxSupplierForOrder);
            this.tabPageOrderAdd.Controls.Add(this.textBoxDrugCount);
            this.tabPageOrderAdd.Controls.Add(this.textBoxDrugName);
            this.tabPageOrderAdd.Controls.Add(this.labelProductCount);
            this.tabPageOrderAdd.Controls.Add(this.labelProductName);
            this.tabPageOrderAdd.Controls.Add(this.labelSupplierForOrder);
            this.tabPageOrderAdd.Location = new System.Drawing.Point(4, 25);
            this.tabPageOrderAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPageOrderAdd.Name = "tabPageOrderAdd";
            this.tabPageOrderAdd.Size = new System.Drawing.Size(1057, 428);
            this.tabPageOrderAdd.TabIndex = 2;
            this.tabPageOrderAdd.Text = "Создание поставки";
            this.tabPageOrderAdd.UseVisualStyleBackColor = true;
            // 
            // buttonBackToList
            // 
            this.buttonBackToList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBackToList.Location = new System.Drawing.Point(516, 361);
            this.buttonBackToList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonBackToList.Name = "buttonBackToList";
            this.buttonBackToList.Size = new System.Drawing.Size(159, 25);
            this.buttonBackToList.TabIndex = 10;
            this.buttonBackToList.Text = "Назад";
            this.buttonBackToList.UseVisualStyleBackColor = true;
            // 
            // buttonDeleteDrug
            // 
            this.buttonDeleteDrug.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDeleteDrug.Location = new System.Drawing.Point(708, 361);
            this.buttonDeleteDrug.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonDeleteDrug.Name = "buttonDeleteDrug";
            this.buttonDeleteDrug.Size = new System.Drawing.Size(159, 25);
            this.buttonDeleteDrug.TabIndex = 8;
            this.buttonDeleteDrug.Text = "Удалить";
            this.buttonDeleteDrug.UseVisualStyleBackColor = true;
            // 
            // buttonMakeOrder
            // 
            this.buttonMakeOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonMakeOrder.Location = new System.Drawing.Point(885, 361);
            this.buttonMakeOrder.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonMakeOrder.Name = "buttonMakeOrder";
            this.buttonMakeOrder.Size = new System.Drawing.Size(159, 25);
            this.buttonMakeOrder.TabIndex = 7;
            this.buttonMakeOrder.Text = "Оформить заказ";
            this.buttonMakeOrder.UseVisualStyleBackColor = true;
            // 
            // buttonAddDrug
            // 
            this.buttonAddDrug.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddDrug.Location = new System.Drawing.Point(808, 92);
            this.buttonAddDrug.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonAddDrug.Name = "buttonAddDrug";
            this.buttonAddDrug.Size = new System.Drawing.Size(236, 25);
            this.buttonAddDrug.TabIndex = 6;
            this.buttonAddDrug.Text = "Добавить ещё одно лекарство";
            this.buttonAddDrug.UseVisualStyleBackColor = true;
            // 
            // comboBoxSupplierForOrder
            // 
            this.comboBoxSupplierForOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxSupplierForOrder.FormattingEnabled = true;
            this.comboBoxSupplierForOrder.Location = new System.Drawing.Point(708, 148);
            this.comboBoxSupplierForOrder.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxSupplierForOrder.Name = "comboBoxSupplierForOrder";
            this.comboBoxSupplierForOrder.Size = new System.Drawing.Size(335, 24);
            this.comboBoxSupplierForOrder.TabIndex = 5;
            this.comboBoxSupplierForOrder.Text = "Выбор поставщика";
            // 
            // textBoxDrugCount
            // 
            this.textBoxDrugCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDrugCount.Location = new System.Drawing.Point(708, 92);
            this.textBoxDrugCount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxDrugCount.Name = "textBoxDrugCount";
            this.textBoxDrugCount.Size = new System.Drawing.Size(91, 22);
            this.textBoxDrugCount.TabIndex = 4;
            // 
            // textBoxDrugName
            // 
            this.textBoxDrugName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDrugName.Location = new System.Drawing.Point(708, 42);
            this.textBoxDrugName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxDrugName.Name = "textBoxDrugName";
            this.textBoxDrugName.Size = new System.Drawing.Size(335, 22);
            this.textBoxDrugName.TabIndex = 3;
            // 
            // labelProductCount
            // 
            this.labelProductCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelProductCount.AutoSize = true;
            this.labelProductCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelProductCount.Location = new System.Drawing.Point(511, 92);
            this.labelProductCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelProductCount.Name = "labelProductCount";
            this.labelProductCount.Size = new System.Drawing.Size(75, 25);
            this.labelProductCount.TabIndex = 2;
            this.labelProductCount.Text = "Кол-во";
            // 
            // labelProductName
            // 
            this.labelProductName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelProductName.AutoSize = true;
            this.labelProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelProductName.Location = new System.Drawing.Point(511, 43);
            this.labelProductName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelProductName.Name = "labelProductName";
            this.labelProductName.Size = new System.Drawing.Size(168, 25);
            this.labelProductName.TabIndex = 1;
            this.labelProductName.Text = "Название товара";
            // 
            // labelSupplierForOrder
            // 
            this.labelSupplierForOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSupplierForOrder.AutoSize = true;
            this.labelSupplierForOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSupplierForOrder.Location = new System.Drawing.Point(511, 149);
            this.labelSupplierForOrder.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSupplierForOrder.Name = "labelSupplierForOrder";
            this.labelSupplierForOrder.Size = new System.Drawing.Size(117, 25);
            this.labelSupplierForOrder.TabIndex = 0;
            this.labelSupplierForOrder.Text = "Поставщик";
            // 
            // tabPageOrderCancel
            // 
            this.tabPageOrderCancel.Controls.Add(this.dataGridViewCancelList);
            this.tabPageOrderCancel.Controls.Add(this.buttonBackToDetail);
            this.tabPageOrderCancel.Controls.Add(this.buttonPostCancel);
            this.tabPageOrderCancel.Controls.Add(this.richTextBoxCancelText);
            this.tabPageOrderCancel.Controls.Add(this.labelCancelText);
            this.tabPageOrderCancel.Controls.Add(this.labelCancelList);
            this.tabPageOrderCancel.Location = new System.Drawing.Point(4, 25);
            this.tabPageOrderCancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPageOrderCancel.Name = "tabPageOrderCancel";
            this.tabPageOrderCancel.Size = new System.Drawing.Size(1057, 428);
            this.tabPageOrderCancel.TabIndex = 3;
            this.tabPageOrderCancel.Text = "Отказ от товаров";
            this.tabPageOrderCancel.UseVisualStyleBackColor = true;
            // 
            // buttonBackToDetail
            // 
            this.buttonBackToDetail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBackToDetail.Location = new System.Drawing.Point(555, 373);
            this.buttonBackToDetail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonBackToDetail.Name = "buttonBackToDetail";
            this.buttonBackToDetail.Size = new System.Drawing.Size(231, 28);
            this.buttonBackToDetail.TabIndex = 5;
            this.buttonBackToDetail.Text = "Назад";
            this.buttonBackToDetail.UseVisualStyleBackColor = true;
            // 
            // buttonPostCancel
            // 
            this.buttonPostCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPostCancel.Location = new System.Drawing.Point(813, 373);
            this.buttonPostCancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonPostCancel.Name = "buttonPostCancel";
            this.buttonPostCancel.Size = new System.Drawing.Size(231, 28);
            this.buttonPostCancel.TabIndex = 4;
            this.buttonPostCancel.Text = "Отправить";
            this.buttonPostCancel.UseVisualStyleBackColor = true;
            // 
            // richTextBoxCancelText
            // 
            this.richTextBoxCancelText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxCancelText.Location = new System.Drawing.Point(555, 42);
            this.richTextBoxCancelText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.richTextBoxCancelText.Name = "richTextBoxCancelText";
            this.richTextBoxCancelText.Size = new System.Drawing.Size(495, 296);
            this.richTextBoxCancelText.TabIndex = 3;
            this.richTextBoxCancelText.Text = "";
            // 
            // labelCancelText
            // 
            this.labelCancelText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCancelText.AutoSize = true;
            this.labelCancelText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCancelText.Location = new System.Drawing.Point(549, 14);
            this.labelCancelText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCancelText.Name = "labelCancelText";
            this.labelCancelText.Size = new System.Drawing.Size(160, 25);
            this.labelCancelText.TabIndex = 2;
            this.labelCancelText.Text = "Причина отказа";
            // 
            // labelCancelList
            // 
            this.labelCancelList.AutoSize = true;
            this.labelCancelList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCancelList.Location = new System.Drawing.Point(4, 14);
            this.labelCancelList.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCancelList.Name = "labelCancelList";
            this.labelCancelList.Size = new System.Drawing.Size(267, 25);
            this.labelCancelList.TabIndex = 1;
            this.labelCancelList.Text = "Список товаров для отказа";
            // 
            // panelOrder
            // 
            this.panelOrder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelOrder.Controls.Add(this.buttonExit);
            this.panelOrder.Controls.Add(this.labelOrders);
            this.panelOrder.Location = new System.Drawing.Point(1, 1);
            this.panelOrder.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelOrder.Name = "panelOrder";
            this.panelOrder.Size = new System.Drawing.Size(1065, 98);
            this.panelOrder.TabIndex = 4;
            // 
            // buttonExit
            // 
            this.buttonExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonExit.AutoSize = true;
            this.buttonExit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonExit.BackColor = System.Drawing.Color.Chocolate;
            this.buttonExit.FlatAppearance.BorderColor = System.Drawing.Color.Chocolate;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.Location = new System.Drawing.Point(1022, 14);
            this.buttonExit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(27, 28);
            this.buttonExit.TabIndex = 8;
            this.buttonExit.Text = "X";
            this.buttonExit.UseVisualStyleBackColor = false;
            // 
            // labelOrders
            // 
            this.labelOrders.AutoSize = true;
            this.labelOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelOrders.Location = new System.Drawing.Point(12, 29);
            this.labelOrders.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelOrders.Name = "labelOrders";
            this.labelOrders.Size = new System.Drawing.Size(167, 39);
            this.labelOrders.TabIndex = 0;
            this.labelOrders.Text = "Поставки";
            // 
            // dataGridViewOrders
            // 
            this.dataGridViewOrders.AllowUserToAddRows = false;
            this.dataGridViewOrders.AllowUserToDeleteRows = false;
            this.dataGridViewOrders.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewOrders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewOrders.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewOrders.BackgroundColor = System.Drawing.Color.Wheat;
            this.dataGridViewOrders.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewOrders.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.ForestGreen;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.ForestGreen;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            this.dataGridViewOrders.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.NavajoWhite;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewOrders.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewOrders.EnableHeadersVisualStyles = false;
            this.dataGridViewOrders.Location = new System.Drawing.Point(0, 87);
            this.dataGridViewOrders.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewOrders.Name = "dataGridViewOrders";
            this.dataGridViewOrders.ReadOnly = true;
            this.dataGridViewOrders.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.NavajoWhite;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewOrders.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewOrders.RowHeadersVisible = false;
            this.dataGridViewOrders.RowHeadersWidth = 51;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridViewOrders.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewOrders.Size = new System.Drawing.Size(903, 341);
            this.dataGridViewOrders.TabIndex = 8;
            // 
            // dataGridViewOrderDetails
            // 
            this.dataGridViewOrderDetails.AllowUserToAddRows = false;
            this.dataGridViewOrderDetails.AllowUserToDeleteRows = false;
            this.dataGridViewOrderDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewOrderDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewOrderDetails.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewOrderDetails.BackgroundColor = System.Drawing.Color.Wheat;
            this.dataGridViewOrderDetails.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewOrderDetails.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.ForestGreen;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.ForestGreen;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            this.dataGridViewOrderDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewOrderDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.NavajoWhite;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewOrderDetails.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewOrderDetails.EnableHeadersVisualStyles = false;
            this.dataGridViewOrderDetails.Location = new System.Drawing.Point(0, 47);
            this.dataGridViewOrderDetails.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewOrderDetails.Name = "dataGridViewOrderDetails";
            this.dataGridViewOrderDetails.ReadOnly = true;
            this.dataGridViewOrderDetails.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.NavajoWhite;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewOrderDetails.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewOrderDetails.RowHeadersVisible = false;
            this.dataGridViewOrderDetails.RowHeadersWidth = 51;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridViewOrderDetails.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewOrderDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewOrderDetails.Size = new System.Drawing.Size(1057, 381);
            this.dataGridViewOrderDetails.TabIndex = 9;
            // 
            // dataGridViewDrugInOrder
            // 
            this.dataGridViewDrugInOrder.AllowUserToAddRows = false;
            this.dataGridViewDrugInOrder.AllowUserToDeleteRows = false;
            this.dataGridViewDrugInOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewDrugInOrder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewDrugInOrder.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewDrugInOrder.BackgroundColor = System.Drawing.Color.Wheat;
            this.dataGridViewDrugInOrder.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewDrugInOrder.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.ForestGreen;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.ForestGreen;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            this.dataGridViewDrugInOrder.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridViewDrugInOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.NavajoWhite;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewDrugInOrder.DefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridViewDrugInOrder.EnableHeadersVisualStyles = false;
            this.dataGridViewDrugInOrder.Location = new System.Drawing.Point(0, 42);
            this.dataGridViewDrugInOrder.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewDrugInOrder.Name = "dataGridViewDrugInOrder";
            this.dataGridViewDrugInOrder.ReadOnly = true;
            this.dataGridViewDrugInOrder.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.NavajoWhite;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewDrugInOrder.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridViewDrugInOrder.RowHeadersVisible = false;
            this.dataGridViewDrugInOrder.RowHeadersWidth = 51;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridViewDrugInOrder.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridViewDrugInOrder.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewDrugInOrder.Size = new System.Drawing.Size(503, 386);
            this.dataGridViewDrugInOrder.TabIndex = 11;
            // 
            // dataGridViewCancelList
            // 
            this.dataGridViewCancelList.AllowUserToAddRows = false;
            this.dataGridViewCancelList.AllowUserToDeleteRows = false;
            this.dataGridViewCancelList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCancelList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewCancelList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewCancelList.BackgroundColor = System.Drawing.Color.Wheat;
            this.dataGridViewCancelList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewCancelList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.ForestGreen;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.ForestGreen;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            this.dataGridViewCancelList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dataGridViewCancelList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.NavajoWhite;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewCancelList.DefaultCellStyle = dataGridViewCellStyle14;
            this.dataGridViewCancelList.EnableHeadersVisualStyles = false;
            this.dataGridViewCancelList.Location = new System.Drawing.Point(0, 43);
            this.dataGridViewCancelList.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewCancelList.Name = "dataGridViewCancelList";
            this.dataGridViewCancelList.ReadOnly = true;
            this.dataGridViewCancelList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.NavajoWhite;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewCancelList.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.dataGridViewCancelList.RowHeadersVisible = false;
            this.dataGridViewCancelList.RowHeadersWidth = 51;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridViewCancelList.RowsDefaultCellStyle = dataGridViewCellStyle16;
            this.dataGridViewCancelList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCancelList.Size = new System.Drawing.Size(516, 385);
            this.dataGridViewCancelList.TabIndex = 12;
            // 
            // labelDrugInOrder
            // 
            this.labelDrugInOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelDrugInOrder.AutoSize = true;
            this.labelDrugInOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDrugInOrder.Location = new System.Drawing.Point(4, 13);
            this.labelDrugInOrder.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDrugInOrder.Name = "labelDrugInOrder";
            this.labelDrugInOrder.Size = new System.Drawing.Size(216, 25);
            this.labelDrugInOrder.TabIndex = 12;
            this.labelDrugInOrder.Text = "Лекарства в поставке";
            // 
            // OrderView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.tabControlOrders);
            this.Controls.Add(this.panelOrder);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "OrderView";
            this.Text = "OrderView";
            this.tabControlOrders.ResumeLayout(false);
            this.tabPageOrdersList.ResumeLayout(false);
            this.tabPageOrdersList.PerformLayout();
            this.tabPageOrderAccept.ResumeLayout(false);
            this.tabPageOrderAccept.PerformLayout();
            this.tabPageOrderAdd.ResumeLayout(false);
            this.tabPageOrderAdd.PerformLayout();
            this.tabPageOrderCancel.ResumeLayout(false);
            this.tabPageOrderCancel.PerformLayout();
            this.panelOrder.ResumeLayout(false);
            this.panelOrder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrderDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDrugInOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCancelList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlOrders;
        private System.Windows.Forms.TabPage tabPageOrdersList;
        private System.Windows.Forms.Label labelOrderSearch;
        private System.Windows.Forms.Button buttonOrderAdd;
        private System.Windows.Forms.Button buttonOrderSearch;
        private System.Windows.Forms.TextBox textBoxOrdersSearch;
        private System.Windows.Forms.TabPage tabPageOrderAccept;
        private System.Windows.Forms.Button buttonOrderCancel;
        private System.Windows.Forms.Button buttonOrderAccept;
        private System.Windows.Forms.Label labelOrderDetails;
        private System.Windows.Forms.TabPage tabPageOrderAdd;
        private System.Windows.Forms.Button buttonMakeOrder;
        private System.Windows.Forms.Button buttonAddDrug;
        private System.Windows.Forms.ComboBox comboBoxSupplierForOrder;
        private System.Windows.Forms.TextBox textBoxDrugCount;
        private System.Windows.Forms.TextBox textBoxDrugName;
        private System.Windows.Forms.Label labelProductCount;
        private System.Windows.Forms.Label labelProductName;
        private System.Windows.Forms.Label labelSupplierForOrder;
        private System.Windows.Forms.TabPage tabPageOrderCancel;
        private System.Windows.Forms.Button buttonPostCancel;
        private System.Windows.Forms.RichTextBox richTextBoxCancelText;
        private System.Windows.Forms.Label labelCancelText;
        private System.Windows.Forms.Label labelCancelList;
        private System.Windows.Forms.Panel panelOrder;
        private System.Windows.Forms.Label labelOrders;
        private System.Windows.Forms.Button buttonDeleteDrug;
        private System.Windows.Forms.Button buttonDetail;
        private System.Windows.Forms.Button buttonBackToDetail;
        private System.Windows.Forms.Button buttonBackToList;
        private System.Windows.Forms.Button buttonDetailToList;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.DataGridView dataGridViewOrders;
        private System.Windows.Forms.DataGridView dataGridViewOrderDetails;
        private System.Windows.Forms.Label labelDrugInOrder;
        private System.Windows.Forms.DataGridView dataGridViewDrugInOrder;
        private System.Windows.Forms.DataGridView dataGridViewCancelList;
    }
}