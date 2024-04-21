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
            this.tabControlOrders = new System.Windows.Forms.TabControl();
            this.tabPageOrdersList = new System.Windows.Forms.TabPage();
            this.labelOrderSearch = new System.Windows.Forms.Label();
            this.buttonOrderAdd = new System.Windows.Forms.Button();
            this.buttonOrderSearch = new System.Windows.Forms.Button();
            this.textBoxOrdersSearch = new System.Windows.Forms.TextBox();
            this.dataGridViewOrders = new System.Windows.Forms.DataGridView();
            this.tabPageOrderAccept = new System.Windows.Forms.TabPage();
            this.buttonOrderCancel = new System.Windows.Forms.Button();
            this.buttonOrderAccept = new System.Windows.Forms.Button();
            this.labelOrderDetails = new System.Windows.Forms.Label();
            this.dataGridViewOrderDetails = new System.Windows.Forms.DataGridView();
            this.tabPageOrderAdd = new System.Windows.Forms.TabPage();
            this.buttonMakeOrder = new System.Windows.Forms.Button();
            this.buttonAddDrug = new System.Windows.Forms.Button();
            this.comboBoxSupplierForOrder = new System.Windows.Forms.ComboBox();
            this.textBoxDrugCount = new System.Windows.Forms.TextBox();
            this.textBoxDrugName = new System.Windows.Forms.TextBox();
            this.labelProductCount = new System.Windows.Forms.Label();
            this.labelProductName = new System.Windows.Forms.Label();
            this.labelSupplierForOrder = new System.Windows.Forms.Label();
            this.tabPageOrderCancel = new System.Windows.Forms.TabPage();
            this.buttonPostCancel = new System.Windows.Forms.Button();
            this.richTextBoxCancelText = new System.Windows.Forms.RichTextBox();
            this.labelCancelText = new System.Windows.Forms.Label();
            this.labelCancelList = new System.Windows.Forms.Label();
            this.dataGridViewCancelList = new System.Windows.Forms.DataGridView();
            this.panelOrder = new System.Windows.Forms.Panel();
            this.labelOrders = new System.Windows.Forms.Label();
            this.buttonDeleteDrug = new System.Windows.Forms.Button();
            this.dataGridViewDrugInOrder = new System.Windows.Forms.DataGridView();
            this.buttonDetail = new System.Windows.Forms.Button();
            this.buttonBackToDetail = new System.Windows.Forms.Button();
            this.buttonBackToList = new System.Windows.Forms.Button();
            this.buttonDetailToList = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.tabControlOrders.SuspendLayout();
            this.tabPageOrdersList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrders)).BeginInit();
            this.tabPageOrderAccept.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrderDetails)).BeginInit();
            this.tabPageOrderAdd.SuspendLayout();
            this.tabPageOrderCancel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCancelList)).BeginInit();
            this.panelOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDrugInOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlOrders
            // 
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
            this.tabPageOrdersList.Controls.Add(this.buttonDetail);
            this.tabPageOrdersList.Controls.Add(this.labelOrderSearch);
            this.tabPageOrdersList.Controls.Add(this.buttonOrderAdd);
            this.tabPageOrdersList.Controls.Add(this.buttonOrderSearch);
            this.tabPageOrdersList.Controls.Add(this.textBoxOrdersSearch);
            this.tabPageOrdersList.Controls.Add(this.dataGridViewOrders);
            this.tabPageOrdersList.Location = new System.Drawing.Point(4, 22);
            this.tabPageOrdersList.Name = "tabPageOrdersList";
            this.tabPageOrdersList.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageOrdersList.Size = new System.Drawing.Size(791, 345);
            this.tabPageOrdersList.TabIndex = 0;
            this.tabPageOrdersList.Text = "Список поставок";
            this.tabPageOrdersList.UseVisualStyleBackColor = true;
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
            this.buttonOrderAdd.Location = new System.Drawing.Point(683, 72);
            this.buttonOrderAdd.Name = "buttonOrderAdd";
            this.buttonOrderAdd.Size = new System.Drawing.Size(98, 23);
            this.buttonOrderAdd.TabIndex = 3;
            this.buttonOrderAdd.Text = "Добавить";
            this.buttonOrderAdd.UseVisualStyleBackColor = true;
            // 
            // buttonOrderSearch
            // 
            this.buttonOrderSearch.Location = new System.Drawing.Point(584, 46);
            this.buttonOrderSearch.Name = "buttonOrderSearch";
            this.buttonOrderSearch.Size = new System.Drawing.Size(93, 20);
            this.buttonOrderSearch.TabIndex = 2;
            this.buttonOrderSearch.Text = "Поиск";
            this.buttonOrderSearch.UseVisualStyleBackColor = true;
            // 
            // textBoxOrdersSearch
            // 
            this.textBoxOrdersSearch.Location = new System.Drawing.Point(3, 46);
            this.textBoxOrdersSearch.Name = "textBoxOrdersSearch";
            this.textBoxOrdersSearch.Size = new System.Drawing.Size(575, 20);
            this.textBoxOrdersSearch.TabIndex = 1;
            // 
            // dataGridViewOrders
            // 
            this.dataGridViewOrders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewOrders.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewOrders.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewOrders.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridViewOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrders.EnableHeadersVisualStyles = false;
            this.dataGridViewOrders.Location = new System.Drawing.Point(3, 72);
            this.dataGridViewOrders.Name = "dataGridViewOrders";
            this.dataGridViewOrders.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridViewOrders.RowHeadersVisible = false;
            this.dataGridViewOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewOrders.Size = new System.Drawing.Size(674, 270);
            this.dataGridViewOrders.TabIndex = 0;
            // 
            // tabPageOrderAccept
            // 
            this.tabPageOrderAccept.Controls.Add(this.buttonDetailToList);
            this.tabPageOrderAccept.Controls.Add(this.buttonOrderCancel);
            this.tabPageOrderAccept.Controls.Add(this.buttonOrderAccept);
            this.tabPageOrderAccept.Controls.Add(this.labelOrderDetails);
            this.tabPageOrderAccept.Controls.Add(this.dataGridViewOrderDetails);
            this.tabPageOrderAccept.Location = new System.Drawing.Point(4, 22);
            this.tabPageOrderAccept.Name = "tabPageOrderAccept";
            this.tabPageOrderAccept.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageOrderAccept.Size = new System.Drawing.Size(791, 345);
            this.tabPageOrderAccept.TabIndex = 1;
            this.tabPageOrderAccept.Text = "Принятие поставки";
            this.tabPageOrderAccept.UseVisualStyleBackColor = true;
            // 
            // buttonOrderCancel
            // 
            this.buttonOrderCancel.Location = new System.Drawing.Point(648, 9);
            this.buttonOrderCancel.Name = "buttonOrderCancel";
            this.buttonOrderCancel.Size = new System.Drawing.Size(135, 23);
            this.buttonOrderCancel.TabIndex = 3;
            this.buttonOrderCancel.Text = "К оформлению отказа";
            this.buttonOrderCancel.UseVisualStyleBackColor = true;
            // 
            // buttonOrderAccept
            // 
            this.buttonOrderAccept.Location = new System.Drawing.Point(534, 9);
            this.buttonOrderAccept.Name = "buttonOrderAccept";
            this.buttonOrderAccept.Size = new System.Drawing.Size(108, 23);
            this.buttonOrderAccept.TabIndex = 2;
            this.buttonOrderAccept.Text = "Принятие заказа";
            this.buttonOrderAccept.UseVisualStyleBackColor = true;
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
            // dataGridViewOrderDetails
            // 
            this.dataGridViewOrderDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewOrderDetails.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewOrderDetails.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewOrderDetails.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridViewOrderDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrderDetails.EnableHeadersVisualStyles = false;
            this.dataGridViewOrderDetails.Location = new System.Drawing.Point(0, 44);
            this.dataGridViewOrderDetails.Name = "dataGridViewOrderDetails";
            this.dataGridViewOrderDetails.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridViewOrderDetails.RowHeadersVisible = false;
            this.dataGridViewOrderDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewOrderDetails.Size = new System.Drawing.Size(791, 301);
            this.dataGridViewOrderDetails.TabIndex = 0;
            // 
            // tabPageOrderAdd
            // 
            this.tabPageOrderAdd.Controls.Add(this.buttonBackToList);
            this.tabPageOrderAdd.Controls.Add(this.dataGridViewDrugInOrder);
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
            // buttonMakeOrder
            // 
            this.buttonMakeOrder.Location = new System.Drawing.Point(664, 293);
            this.buttonMakeOrder.Name = "buttonMakeOrder";
            this.buttonMakeOrder.Size = new System.Drawing.Size(119, 20);
            this.buttonMakeOrder.TabIndex = 7;
            this.buttonMakeOrder.Text = "Оформить заказ";
            this.buttonMakeOrder.UseVisualStyleBackColor = true;
            // 
            // buttonAddDrug
            // 
            this.buttonAddDrug.Location = new System.Drawing.Point(606, 75);
            this.buttonAddDrug.Name = "buttonAddDrug";
            this.buttonAddDrug.Size = new System.Drawing.Size(177, 20);
            this.buttonAddDrug.TabIndex = 6;
            this.buttonAddDrug.Text = "Добавить ещё одно лекарство";
            this.buttonAddDrug.UseVisualStyleBackColor = true;
            // 
            // comboBoxSupplierForOrder
            // 
            this.comboBoxSupplierForOrder.FormattingEnabled = true;
            this.comboBoxSupplierForOrder.Location = new System.Drawing.Point(531, 120);
            this.comboBoxSupplierForOrder.Name = "comboBoxSupplierForOrder";
            this.comboBoxSupplierForOrder.Size = new System.Drawing.Size(252, 21);
            this.comboBoxSupplierForOrder.TabIndex = 5;
            this.comboBoxSupplierForOrder.Text = "Выбор поставщика";
            // 
            // textBoxDrugCount
            // 
            this.textBoxDrugCount.Location = new System.Drawing.Point(531, 75);
            this.textBoxDrugCount.Name = "textBoxDrugCount";
            this.textBoxDrugCount.Size = new System.Drawing.Size(69, 20);
            this.textBoxDrugCount.TabIndex = 4;
            // 
            // textBoxDrugName
            // 
            this.textBoxDrugName.Location = new System.Drawing.Point(531, 34);
            this.textBoxDrugName.Name = "textBoxDrugName";
            this.textBoxDrugName.Size = new System.Drawing.Size(252, 20);
            this.textBoxDrugName.TabIndex = 3;
            // 
            // labelProductCount
            // 
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
            this.tabPageOrderCancel.Controls.Add(this.buttonBackToDetail);
            this.tabPageOrderCancel.Controls.Add(this.buttonPostCancel);
            this.tabPageOrderCancel.Controls.Add(this.richTextBoxCancelText);
            this.tabPageOrderCancel.Controls.Add(this.labelCancelText);
            this.tabPageOrderCancel.Controls.Add(this.labelCancelList);
            this.tabPageOrderCancel.Controls.Add(this.dataGridViewCancelList);
            this.tabPageOrderCancel.Location = new System.Drawing.Point(4, 22);
            this.tabPageOrderCancel.Name = "tabPageOrderCancel";
            this.tabPageOrderCancel.Size = new System.Drawing.Size(791, 345);
            this.tabPageOrderCancel.TabIndex = 3;
            this.tabPageOrderCancel.Text = "Отказ от товаров";
            this.tabPageOrderCancel.UseVisualStyleBackColor = true;
            // 
            // buttonPostCancel
            // 
            this.buttonPostCancel.Location = new System.Drawing.Point(610, 303);
            this.buttonPostCancel.Name = "buttonPostCancel";
            this.buttonPostCancel.Size = new System.Drawing.Size(173, 23);
            this.buttonPostCancel.TabIndex = 4;
            this.buttonPostCancel.Text = "Отправить";
            this.buttonPostCancel.UseVisualStyleBackColor = true;
            // 
            // richTextBoxCancelText
            // 
            this.richTextBoxCancelText.Location = new System.Drawing.Point(416, 34);
            this.richTextBoxCancelText.Name = "richTextBoxCancelText";
            this.richTextBoxCancelText.Size = new System.Drawing.Size(372, 241);
            this.richTextBoxCancelText.TabIndex = 3;
            this.richTextBoxCancelText.Text = "";
            // 
            // labelCancelText
            // 
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
            // dataGridViewCancelList
            // 
            this.dataGridViewCancelList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewCancelList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewCancelList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewCancelList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridViewCancelList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCancelList.EnableHeadersVisualStyles = false;
            this.dataGridViewCancelList.Location = new System.Drawing.Point(0, 34);
            this.dataGridViewCancelList.Name = "dataGridViewCancelList";
            this.dataGridViewCancelList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridViewCancelList.RowHeadersVisible = false;
            this.dataGridViewCancelList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCancelList.Size = new System.Drawing.Size(406, 311);
            this.dataGridViewCancelList.TabIndex = 0;
            // 
            // panelOrder
            // 
            this.panelOrder.Controls.Add(this.buttonExit);
            this.panelOrder.Controls.Add(this.labelOrders);
            this.panelOrder.Location = new System.Drawing.Point(1, 1);
            this.panelOrder.Name = "panelOrder";
            this.panelOrder.Size = new System.Drawing.Size(799, 80);
            this.panelOrder.TabIndex = 4;
            // 
            // labelOrders
            // 
            this.labelOrders.AutoSize = true;
            this.labelOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelOrders.Location = new System.Drawing.Point(11, 26);
            this.labelOrders.Name = "labelOrders";
            this.labelOrders.Size = new System.Drawing.Size(95, 24);
            this.labelOrders.TabIndex = 0;
            this.labelOrders.Text = "Поставки";
            // 
            // buttonDeleteDrug
            // 
            this.buttonDeleteDrug.Location = new System.Drawing.Point(531, 293);
            this.buttonDeleteDrug.Name = "buttonDeleteDrug";
            this.buttonDeleteDrug.Size = new System.Drawing.Size(119, 20);
            this.buttonDeleteDrug.TabIndex = 8;
            this.buttonDeleteDrug.Text = "Удалить";
            this.buttonDeleteDrug.UseVisualStyleBackColor = true;
            // 
            // dataGridViewDrugInOrder
            // 
            this.dataGridViewDrugInOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDrugInOrder.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewDrugInOrder.Name = "dataGridViewDrugInOrder";
            this.dataGridViewDrugInOrder.Size = new System.Drawing.Size(370, 345);
            this.dataGridViewDrugInOrder.TabIndex = 9;
            // 
            // buttonDetail
            // 
            this.buttonDetail.Location = new System.Drawing.Point(683, 101);
            this.buttonDetail.Name = "buttonDetail";
            this.buttonDetail.Size = new System.Drawing.Size(98, 23);
            this.buttonDetail.TabIndex = 7;
            this.buttonDetail.Text = "Открыть";
            this.buttonDetail.UseVisualStyleBackColor = true;
            // 
            // buttonBackToDetail
            // 
            this.buttonBackToDetail.Location = new System.Drawing.Point(416, 303);
            this.buttonBackToDetail.Name = "buttonBackToDetail";
            this.buttonBackToDetail.Size = new System.Drawing.Size(173, 23);
            this.buttonBackToDetail.TabIndex = 5;
            this.buttonBackToDetail.Text = "Назад";
            this.buttonBackToDetail.UseVisualStyleBackColor = true;
            // 
            // buttonBackToList
            // 
            this.buttonBackToList.Location = new System.Drawing.Point(387, 293);
            this.buttonBackToList.Name = "buttonBackToList";
            this.buttonBackToList.Size = new System.Drawing.Size(119, 20);
            this.buttonBackToList.TabIndex = 10;
            this.buttonBackToList.Text = "Назад";
            this.buttonBackToList.UseVisualStyleBackColor = true;
            // 
            // buttonDetailToList
            // 
            this.buttonDetailToList.Location = new System.Drawing.Point(435, 9);
            this.buttonDetailToList.Name = "buttonDetailToList";
            this.buttonDetailToList.Size = new System.Drawing.Size(93, 23);
            this.buttonDetailToList.TabIndex = 4;
            this.buttonDetailToList.Text = "Назад";
            this.buttonDetailToList.UseVisualStyleBackColor = true;
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
            // OrderView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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
            this.tabPageOrderCancel.ResumeLayout(false);
            this.tabPageOrderCancel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCancelList)).EndInit();
            this.panelOrder.ResumeLayout(false);
            this.panelOrder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDrugInOrder)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlOrders;
        private System.Windows.Forms.TabPage tabPageOrdersList;
        private System.Windows.Forms.Label labelOrderSearch;
        private System.Windows.Forms.Button buttonOrderAdd;
        private System.Windows.Forms.Button buttonOrderSearch;
        private System.Windows.Forms.TextBox textBoxOrdersSearch;
        private System.Windows.Forms.DataGridView dataGridViewOrders;
        private System.Windows.Forms.TabPage tabPageOrderAccept;
        private System.Windows.Forms.Button buttonOrderCancel;
        private System.Windows.Forms.Button buttonOrderAccept;
        private System.Windows.Forms.Label labelOrderDetails;
        private System.Windows.Forms.DataGridView dataGridViewOrderDetails;
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
        private System.Windows.Forms.DataGridView dataGridViewCancelList;
        private System.Windows.Forms.Panel panelOrder;
        private System.Windows.Forms.Label labelOrders;
        private System.Windows.Forms.DataGridView dataGridViewDrugInOrder;
        private System.Windows.Forms.Button buttonDeleteDrug;
        private System.Windows.Forms.Button buttonDetail;
        private System.Windows.Forms.Button buttonBackToDetail;
        private System.Windows.Forms.Button buttonBackToList;
        private System.Windows.Forms.Button buttonDetailToList;
        private System.Windows.Forms.Button buttonExit;
    }
}