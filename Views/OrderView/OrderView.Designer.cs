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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle31 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle32 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControlOrders = new System.Windows.Forms.TabControl();
            this.tabPageOrdersList = new System.Windows.Forms.TabPage();
            this.dataGridViewOrders = new System.Windows.Forms.DataGridView();
            this.buttonDetail = new System.Windows.Forms.Button();
            this.labelOrderSearch = new System.Windows.Forms.Label();
            this.buttonOrderAdd = new System.Windows.Forms.Button();
            this.buttonOrderSearch = new System.Windows.Forms.Button();
            this.textBoxOrdersSearch = new System.Windows.Forms.TextBox();
            this.tabPageOrderAccept = new System.Windows.Forms.TabPage();
            this.dataGridViewOrderDetails = new System.Windows.Forms.DataGridView();
            this.buttonDetailToList = new System.Windows.Forms.Button();
            this.buttonOrderCancel = new System.Windows.Forms.Button();
            this.buttonOrderAccept = new System.Windows.Forms.Button();
            this.labelOrderDetails = new System.Windows.Forms.Label();
            this.tabPageOrderAdd = new System.Windows.Forms.TabPage();
            this.dataGridViewDrugInOrder = new System.Windows.Forms.DataGridView();
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
            this.dataGridViewCancelList = new System.Windows.Forms.DataGridView();
            this.buttonBackToDetail = new System.Windows.Forms.Button();
            this.buttonPostCancel = new System.Windows.Forms.Button();
            this.richTextBoxCancelText = new System.Windows.Forms.RichTextBox();
            this.labelCancelText = new System.Windows.Forms.Label();
            this.labelCancelList = new System.Windows.Forms.Label();
            this.panelOrder = new System.Windows.Forms.Panel();
            this.buttonExit = new System.Windows.Forms.Button();
            this.labelOrders = new System.Windows.Forms.Label();
            this.tabControlOrders.SuspendLayout();
            this.tabPageOrdersList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrders)).BeginInit();
            this.tabPageOrderAccept.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrderDetails)).BeginInit();
            this.tabPageOrderAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDrugInOrder)).BeginInit();
            this.tabPageOrderCancel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCancelList)).BeginInit();
            this.panelOrder.SuspendLayout();
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
            this.tabControlOrders.Location = new System.Drawing.Point(1, 78);
            this.tabControlOrders.Name = "tabControlOrders";
            this.tabControlOrders.SelectedIndex = 0;
            this.tabControlOrders.Size = new System.Drawing.Size(799, 371);
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
            this.tabPageOrdersList.Location = new System.Drawing.Point(4, 22);
            this.tabPageOrdersList.Name = "tabPageOrdersList";
            this.tabPageOrdersList.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageOrdersList.Size = new System.Drawing.Size(791, 345);
            this.tabPageOrdersList.TabIndex = 0;
            this.tabPageOrdersList.Text = "Список поставок";
            this.tabPageOrdersList.UseVisualStyleBackColor = true;
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
            this.dataGridViewOrders.BackgroundColor = System.Drawing.Color.NavajoWhite;
            this.dataGridViewOrders.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewOrders.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.ForestGreen;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.ForestGreen;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            this.dataGridViewOrders.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.dataGridViewOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.NavajoWhite;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewOrders.DefaultCellStyle = dataGridViewCellStyle18;
            this.dataGridViewOrders.EnableHeadersVisualStyles = false;
            this.dataGridViewOrders.Location = new System.Drawing.Point(0, 72);
            this.dataGridViewOrders.Name = "dataGridViewOrders";
            this.dataGridViewOrders.ReadOnly = true;
            this.dataGridViewOrders.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.NavajoWhite;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewOrders.RowHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.dataGridViewOrders.RowHeadersVisible = false;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridViewOrders.RowsDefaultCellStyle = dataGridViewCellStyle20;
            this.dataGridViewOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewOrders.Size = new System.Drawing.Size(677, 273);
            this.dataGridViewOrders.TabIndex = 9;
            // 
            // buttonDetail
            // 
            this.buttonDetail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDetail.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonDetail.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.buttonDetail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDetail.Location = new System.Drawing.Point(683, 101);
            this.buttonDetail.Name = "buttonDetail";
            this.buttonDetail.Size = new System.Drawing.Size(98, 23);
            this.buttonDetail.TabIndex = 7;
            this.buttonDetail.Text = "Открыть";
            this.buttonDetail.UseVisualStyleBackColor = false;
            // 
            // labelOrderSearch
            // 
            this.labelOrderSearch.AutoSize = true;
            this.labelOrderSearch.Location = new System.Drawing.Point(3, 30);
            this.labelOrderSearch.Name = "labelOrderSearch";
            this.labelOrderSearch.Size = new System.Drawing.Size(89, 13);
            this.labelOrderSearch.TabIndex = 6;
            this.labelOrderSearch.Text = "Поиск поставок";
            // 
            // buttonOrderAdd
            // 
            this.buttonOrderAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOrderAdd.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonOrderAdd.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.buttonOrderAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOrderAdd.Location = new System.Drawing.Point(683, 72);
            this.buttonOrderAdd.Name = "buttonOrderAdd";
            this.buttonOrderAdd.Size = new System.Drawing.Size(98, 23);
            this.buttonOrderAdd.TabIndex = 3;
            this.buttonOrderAdd.Text = "Добавить";
            this.buttonOrderAdd.UseVisualStyleBackColor = false;
            // 
            // buttonOrderSearch
            // 
            this.buttonOrderSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOrderSearch.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonOrderSearch.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.buttonOrderSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOrderSearch.Location = new System.Drawing.Point(584, 44);
            this.buttonOrderSearch.Name = "buttonOrderSearch";
            this.buttonOrderSearch.Size = new System.Drawing.Size(93, 22);
            this.buttonOrderSearch.TabIndex = 2;
            this.buttonOrderSearch.Text = "Поиск";
            this.buttonOrderSearch.UseVisualStyleBackColor = false;
            // 
            // textBoxOrdersSearch
            // 
            this.textBoxOrdersSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxOrdersSearch.Location = new System.Drawing.Point(3, 46);
            this.textBoxOrdersSearch.Name = "textBoxOrdersSearch";
            this.textBoxOrdersSearch.Size = new System.Drawing.Size(575, 20);
            this.textBoxOrdersSearch.TabIndex = 1;
            // 
            // tabPageOrderAccept
            // 
            this.tabPageOrderAccept.Controls.Add(this.dataGridViewOrderDetails);
            this.tabPageOrderAccept.Controls.Add(this.buttonDetailToList);
            this.tabPageOrderAccept.Controls.Add(this.buttonOrderCancel);
            this.tabPageOrderAccept.Controls.Add(this.buttonOrderAccept);
            this.tabPageOrderAccept.Controls.Add(this.labelOrderDetails);
            this.tabPageOrderAccept.Location = new System.Drawing.Point(4, 22);
            this.tabPageOrderAccept.Name = "tabPageOrderAccept";
            this.tabPageOrderAccept.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageOrderAccept.Size = new System.Drawing.Size(791, 345);
            this.tabPageOrderAccept.TabIndex = 1;
            this.tabPageOrderAccept.Text = "Принятие поставки";
            this.tabPageOrderAccept.UseVisualStyleBackColor = true;
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
            this.dataGridViewOrderDetails.BackgroundColor = System.Drawing.Color.NavajoWhite;
            this.dataGridViewOrderDetails.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewOrderDetails.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle21.BackColor = System.Drawing.Color.ForestGreen;
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle21.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.Color.ForestGreen;
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            this.dataGridViewOrderDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle21;
            this.dataGridViewOrderDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle22.BackColor = System.Drawing.Color.NavajoWhite;
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle22.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewOrderDetails.DefaultCellStyle = dataGridViewCellStyle22;
            this.dataGridViewOrderDetails.EnableHeadersVisualStyles = false;
            this.dataGridViewOrderDetails.Location = new System.Drawing.Point(0, 38);
            this.dataGridViewOrderDetails.Name = "dataGridViewOrderDetails";
            this.dataGridViewOrderDetails.ReadOnly = true;
            this.dataGridViewOrderDetails.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle23.BackColor = System.Drawing.Color.NavajoWhite;
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle23.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewOrderDetails.RowHeadersDefaultCellStyle = dataGridViewCellStyle23;
            this.dataGridViewOrderDetails.RowHeadersVisible = false;
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridViewOrderDetails.RowsDefaultCellStyle = dataGridViewCellStyle24;
            this.dataGridViewOrderDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewOrderDetails.Size = new System.Drawing.Size(791, 307);
            this.dataGridViewOrderDetails.TabIndex = 6;
            // 
            // buttonDetailToList
            // 
            this.buttonDetailToList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDetailToList.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonDetailToList.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.buttonDetailToList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDetailToList.Location = new System.Drawing.Point(415, 9);
            this.buttonDetailToList.Name = "buttonDetailToList";
            this.buttonDetailToList.Size = new System.Drawing.Size(93, 23);
            this.buttonDetailToList.TabIndex = 4;
            this.buttonDetailToList.Text = "Назад";
            this.buttonDetailToList.UseVisualStyleBackColor = false;
            // 
            // buttonOrderCancel
            // 
            this.buttonOrderCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOrderCancel.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonOrderCancel.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.buttonOrderCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOrderCancel.Location = new System.Drawing.Point(648, 9);
            this.buttonOrderCancel.Name = "buttonOrderCancel";
            this.buttonOrderCancel.Size = new System.Drawing.Size(135, 23);
            this.buttonOrderCancel.TabIndex = 3;
            this.buttonOrderCancel.Text = "К оформлению отказа";
            this.buttonOrderCancel.UseVisualStyleBackColor = false;
            // 
            // buttonOrderAccept
            // 
            this.buttonOrderAccept.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOrderAccept.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonOrderAccept.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.buttonOrderAccept.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOrderAccept.Location = new System.Drawing.Point(514, 9);
            this.buttonOrderAccept.Name = "buttonOrderAccept";
            this.buttonOrderAccept.Size = new System.Drawing.Size(128, 23);
            this.buttonOrderAccept.TabIndex = 2;
            this.buttonOrderAccept.Text = "Принятие поставки";
            this.buttonOrderAccept.UseVisualStyleBackColor = false;
            // 
            // labelOrderDetails
            // 
            this.labelOrderDetails.AutoSize = true;
            this.labelOrderDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelOrderDetails.Location = new System.Drawing.Point(3, 12);
            this.labelOrderDetails.Name = "labelOrderDetails";
            this.labelOrderDetails.Size = new System.Drawing.Size(141, 20);
            this.labelOrderDetails.TabIndex = 1;
            this.labelOrderDetails.Text = "Детали поставки";
            // 
            // tabPageOrderAdd
            // 
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
            this.tabPageOrderAdd.Location = new System.Drawing.Point(4, 22);
            this.tabPageOrderAdd.Name = "tabPageOrderAdd";
            this.tabPageOrderAdd.Size = new System.Drawing.Size(791, 345);
            this.tabPageOrderAdd.TabIndex = 2;
            this.tabPageOrderAdd.Text = "Создание поставки";
            this.tabPageOrderAdd.UseVisualStyleBackColor = true;
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
            this.dataGridViewDrugInOrder.BackgroundColor = System.Drawing.Color.NavajoWhite;
            this.dataGridViewDrugInOrder.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewDrugInOrder.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle25.BackColor = System.Drawing.Color.ForestGreen;
            dataGridViewCellStyle25.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle25.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle25.SelectionBackColor = System.Drawing.Color.ForestGreen;
            dataGridViewCellStyle25.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            this.dataGridViewDrugInOrder.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle25;
            this.dataGridViewDrugInOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle26.BackColor = System.Drawing.Color.NavajoWhite;
            dataGridViewCellStyle26.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle26.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle26.SelectionBackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle26.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle26.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewDrugInOrder.DefaultCellStyle = dataGridViewCellStyle26;
            this.dataGridViewDrugInOrder.EnableHeadersVisualStyles = false;
            this.dataGridViewDrugInOrder.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewDrugInOrder.Name = "dataGridViewDrugInOrder";
            this.dataGridViewDrugInOrder.ReadOnly = true;
            this.dataGridViewDrugInOrder.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle27.BackColor = System.Drawing.Color.NavajoWhite;
            dataGridViewCellStyle27.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle27.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle27.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle27.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle27.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewDrugInOrder.RowHeadersDefaultCellStyle = dataGridViewCellStyle27;
            this.dataGridViewDrugInOrder.RowHeadersVisible = false;
            dataGridViewCellStyle28.SelectionBackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle28.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridViewDrugInOrder.RowsDefaultCellStyle = dataGridViewCellStyle28;
            this.dataGridViewDrugInOrder.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewDrugInOrder.Size = new System.Drawing.Size(377, 345);
            this.dataGridViewDrugInOrder.TabIndex = 6;
            // 
            // buttonBackToList
            // 
            this.buttonBackToList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBackToList.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonBackToList.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.buttonBackToList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBackToList.Location = new System.Drawing.Point(387, 292);
            this.buttonBackToList.Name = "buttonBackToList";
            this.buttonBackToList.Size = new System.Drawing.Size(119, 21);
            this.buttonBackToList.TabIndex = 10;
            this.buttonBackToList.Text = "Назад";
            this.buttonBackToList.UseVisualStyleBackColor = false;
            // 
            // buttonDeleteDrug
            // 
            this.buttonDeleteDrug.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDeleteDrug.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonDeleteDrug.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.buttonDeleteDrug.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeleteDrug.Location = new System.Drawing.Point(531, 292);
            this.buttonDeleteDrug.Name = "buttonDeleteDrug";
            this.buttonDeleteDrug.Size = new System.Drawing.Size(119, 21);
            this.buttonDeleteDrug.TabIndex = 8;
            this.buttonDeleteDrug.Text = "Удалить";
            this.buttonDeleteDrug.UseVisualStyleBackColor = false;
            // 
            // buttonMakeOrder
            // 
            this.buttonMakeOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonMakeOrder.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonMakeOrder.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.buttonMakeOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMakeOrder.Location = new System.Drawing.Point(664, 292);
            this.buttonMakeOrder.Name = "buttonMakeOrder";
            this.buttonMakeOrder.Size = new System.Drawing.Size(119, 21);
            this.buttonMakeOrder.TabIndex = 7;
            this.buttonMakeOrder.Text = "Оформить заказ";
            this.buttonMakeOrder.UseVisualStyleBackColor = false;
            // 
            // buttonAddDrug
            // 
            this.buttonAddDrug.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddDrug.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonAddDrug.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.buttonAddDrug.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddDrug.Location = new System.Drawing.Point(383, 167);
            this.buttonAddDrug.Name = "buttonAddDrug";
            this.buttonAddDrug.Size = new System.Drawing.Size(141, 21);
            this.buttonAddDrug.TabIndex = 6;
            this.buttonAddDrug.Text = "Добавить";
            this.buttonAddDrug.UseVisualStyleBackColor = false;
            // 
            // comboBoxSupplierForOrder
            // 
            this.comboBoxSupplierForOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxSupplierForOrder.FormattingEnabled = true;
            this.comboBoxSupplierForOrder.Location = new System.Drawing.Point(531, 120);
            this.comboBoxSupplierForOrder.Name = "comboBoxSupplierForOrder";
            this.comboBoxSupplierForOrder.Size = new System.Drawing.Size(252, 21);
            this.comboBoxSupplierForOrder.TabIndex = 5;
            this.comboBoxSupplierForOrder.Text = "Выбор поставщика";
            // 
            // textBoxDrugCount
            // 
            this.textBoxDrugCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDrugCount.Location = new System.Drawing.Point(531, 75);
            this.textBoxDrugCount.Name = "textBoxDrugCount";
            this.textBoxDrugCount.Size = new System.Drawing.Size(252, 20);
            this.textBoxDrugCount.TabIndex = 4;
            // 
            // textBoxDrugName
            // 
            this.textBoxDrugName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDrugName.Location = new System.Drawing.Point(531, 34);
            this.textBoxDrugName.Name = "textBoxDrugName";
            this.textBoxDrugName.Size = new System.Drawing.Size(252, 20);
            this.textBoxDrugName.TabIndex = 3;
            // 
            // labelProductCount
            // 
            this.labelProductCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelProductCount.AutoSize = true;
            this.labelProductCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelProductCount.Location = new System.Drawing.Point(383, 75);
            this.labelProductCount.Name = "labelProductCount";
            this.labelProductCount.Size = new System.Drawing.Size(61, 20);
            this.labelProductCount.TabIndex = 2;
            this.labelProductCount.Text = "Кол-во";
            // 
            // labelProductName
            // 
            this.labelProductName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelProductName.AutoSize = true;
            this.labelProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelProductName.Location = new System.Drawing.Point(383, 35);
            this.labelProductName.Name = "labelProductName";
            this.labelProductName.Size = new System.Drawing.Size(141, 20);
            this.labelProductName.TabIndex = 1;
            this.labelProductName.Text = "Название товара";
            // 
            // labelSupplierForOrder
            // 
            this.labelSupplierForOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSupplierForOrder.AutoSize = true;
            this.labelSupplierForOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSupplierForOrder.Location = new System.Drawing.Point(383, 121);
            this.labelSupplierForOrder.Name = "labelSupplierForOrder";
            this.labelSupplierForOrder.Size = new System.Drawing.Size(95, 20);
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
            this.tabPageOrderCancel.Location = new System.Drawing.Point(4, 22);
            this.tabPageOrderCancel.Name = "tabPageOrderCancel";
            this.tabPageOrderCancel.Size = new System.Drawing.Size(791, 345);
            this.tabPageOrderCancel.TabIndex = 3;
            this.tabPageOrderCancel.Text = "Отказ от товаров";
            this.tabPageOrderCancel.UseVisualStyleBackColor = true;
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
            this.dataGridViewCancelList.BackgroundColor = System.Drawing.Color.NavajoWhite;
            this.dataGridViewCancelList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewCancelList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle29.BackColor = System.Drawing.Color.ForestGreen;
            dataGridViewCellStyle29.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle29.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle29.SelectionBackColor = System.Drawing.Color.ForestGreen;
            dataGridViewCellStyle29.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            this.dataGridViewCancelList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle29;
            this.dataGridViewCancelList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle30.BackColor = System.Drawing.Color.NavajoWhite;
            dataGridViewCellStyle30.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle30.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle30.SelectionBackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle30.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle30.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewCancelList.DefaultCellStyle = dataGridViewCellStyle30;
            this.dataGridViewCancelList.EnableHeadersVisualStyles = false;
            this.dataGridViewCancelList.Location = new System.Drawing.Point(0, 34);
            this.dataGridViewCancelList.Name = "dataGridViewCancelList";
            this.dataGridViewCancelList.ReadOnly = true;
            this.dataGridViewCancelList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle31.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle31.BackColor = System.Drawing.Color.NavajoWhite;
            dataGridViewCellStyle31.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle31.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle31.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle31.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle31.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewCancelList.RowHeadersDefaultCellStyle = dataGridViewCellStyle31;
            this.dataGridViewCancelList.RowHeadersVisible = false;
            dataGridViewCellStyle32.SelectionBackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle32.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridViewCancelList.RowsDefaultCellStyle = dataGridViewCellStyle32;
            this.dataGridViewCancelList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCancelList.Size = new System.Drawing.Size(410, 311);
            this.dataGridViewCancelList.TabIndex = 6;
            // 
            // buttonBackToDetail
            // 
            this.buttonBackToDetail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBackToDetail.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonBackToDetail.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.buttonBackToDetail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBackToDetail.Location = new System.Drawing.Point(416, 303);
            this.buttonBackToDetail.Name = "buttonBackToDetail";
            this.buttonBackToDetail.Size = new System.Drawing.Size(173, 23);
            this.buttonBackToDetail.TabIndex = 5;
            this.buttonBackToDetail.Text = "Назад";
            this.buttonBackToDetail.UseVisualStyleBackColor = false;
            // 
            // buttonPostCancel
            // 
            this.buttonPostCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPostCancel.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonPostCancel.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.buttonPostCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPostCancel.Location = new System.Drawing.Point(610, 303);
            this.buttonPostCancel.Name = "buttonPostCancel";
            this.buttonPostCancel.Size = new System.Drawing.Size(173, 23);
            this.buttonPostCancel.TabIndex = 4;
            this.buttonPostCancel.Text = "Отправить";
            this.buttonPostCancel.UseVisualStyleBackColor = false;
            // 
            // richTextBoxCancelText
            // 
            this.richTextBoxCancelText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxCancelText.Location = new System.Drawing.Point(416, 34);
            this.richTextBoxCancelText.Name = "richTextBoxCancelText";
            this.richTextBoxCancelText.Size = new System.Drawing.Size(372, 241);
            this.richTextBoxCancelText.TabIndex = 3;
            this.richTextBoxCancelText.Text = "";
            // 
            // labelCancelText
            // 
            this.labelCancelText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCancelText.AutoSize = true;
            this.labelCancelText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCancelText.Location = new System.Drawing.Point(412, 11);
            this.labelCancelText.Name = "labelCancelText";
            this.labelCancelText.Size = new System.Drawing.Size(131, 20);
            this.labelCancelText.TabIndex = 2;
            this.labelCancelText.Text = "Причина отказа";
            // 
            // labelCancelList
            // 
            this.labelCancelList.AutoSize = true;
            this.labelCancelList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCancelList.Location = new System.Drawing.Point(3, 11);
            this.labelCancelList.Name = "labelCancelList";
            this.labelCancelList.Size = new System.Drawing.Size(220, 20);
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
            this.panelOrder.Name = "panelOrder";
            this.panelOrder.Size = new System.Drawing.Size(799, 80);
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
            this.buttonExit.Location = new System.Drawing.Point(761, 11);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(26, 25);
            this.buttonExit.TabIndex = 8;
            this.buttonExit.Text = "X";
            this.buttonExit.UseVisualStyleBackColor = false;
            // 
            // labelOrders
            // 
            this.labelOrders.AutoSize = true;
            this.labelOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelOrders.Location = new System.Drawing.Point(11, 26);
            this.labelOrders.Name = "labelOrders";
            this.labelOrders.Size = new System.Drawing.Size(133, 31);
            this.labelOrders.TabIndex = 0;
            this.labelOrders.Text = "Поставки";
            // 
            // OrderView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControlOrders);
            this.Controls.Add(this.panelOrder);
            this.Name = "OrderView";
            this.Text = "OrderView";
            this.tabControlOrders.ResumeLayout(false);
            this.tabPageOrdersList.ResumeLayout(false);
            this.tabPageOrdersList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrders)).EndInit();
            this.tabPageOrderAccept.ResumeLayout(false);
            this.tabPageOrderAccept.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrderDetails)).EndInit();
            this.tabPageOrderAdd.ResumeLayout(false);
            this.tabPageOrderAdd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDrugInOrder)).EndInit();
            this.tabPageOrderCancel.ResumeLayout(false);
            this.tabPageOrderCancel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCancelList)).EndInit();
            this.panelOrder.ResumeLayout(false);
            this.panelOrder.PerformLayout();
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
        private System.Windows.Forms.DataGridView dataGridViewDrugInOrder;
        private System.Windows.Forms.DataGridView dataGridViewCancelList;
    }
}