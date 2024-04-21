namespace Pharmacy.Views.DrugPayment
{
    partial class DrugPaymentView
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
            this.tabControlDrugLists = new System.Windows.Forms.TabControl();
            this.tabPageDrugList = new System.Windows.Forms.TabPage();
            this.buttonToPayment = new System.Windows.Forms.Button();
            this.dataGridViewDrugsList = new System.Windows.Forms.DataGridView();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.labelSearch = new System.Windows.Forms.Label();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.tabPagePay = new System.Windows.Forms.TabPage();
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.labelChange = new System.Windows.Forms.Label();
            this.textBoxChange = new System.Windows.Forms.TextBox();
            this.labelProvided = new System.Windows.Forms.Label();
            this.textBoxProvided = new System.Windows.Forms.TextBox();
            this.comboBoxPayMethod = new System.Windows.Forms.ComboBox();
            this.buttonPayment = new System.Windows.Forms.Button();
            this.checkBoxRecipeCheck = new System.Windows.Forms.CheckBox();
            this.textBoxTotalSum = new System.Windows.Forms.TextBox();
            this.labelTotalSum = new System.Windows.Forms.Label();
            this.dataGridViewPay = new System.Windows.Forms.DataGridView();
            this.panelDrugTitle = new System.Windows.Forms.Panel();
            this.labelDrugTitle = new System.Windows.Forms.Label();
            this.buttonExit = new System.Windows.Forms.Button();
            this.tabControlDrugLists.SuspendLayout();
            this.tabPageDrugList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDrugsList)).BeginInit();
            this.tabPagePay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPay)).BeginInit();
            this.panelDrugTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlDrugLists
            // 
            this.tabControlDrugLists.Controls.Add(this.tabPageDrugList);
            this.tabControlDrugLists.Controls.Add(this.tabPagePay);
            this.tabControlDrugLists.Location = new System.Drawing.Point(0, 79);
            this.tabControlDrugLists.Name = "tabControlDrugLists";
            this.tabControlDrugLists.SelectedIndex = 0;
            this.tabControlDrugLists.Size = new System.Drawing.Size(800, 372);
            this.tabControlDrugLists.TabIndex = 3;
            // 
            // tabPageDrugList
            // 
            this.tabPageDrugList.Controls.Add(this.buttonToPayment);
            this.tabPageDrugList.Controls.Add(this.dataGridViewDrugsList);
            this.tabPageDrugList.Controls.Add(this.buttonSearch);
            this.tabPageDrugList.Controls.Add(this.labelSearch);
            this.tabPageDrugList.Controls.Add(this.textBoxSearch);
            this.tabPageDrugList.Location = new System.Drawing.Point(4, 22);
            this.tabPageDrugList.Name = "tabPageDrugList";
            this.tabPageDrugList.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDrugList.Size = new System.Drawing.Size(792, 346);
            this.tabPageDrugList.TabIndex = 0;
            this.tabPageDrugList.Text = "Каталог";
            this.tabPageDrugList.UseVisualStyleBackColor = true;
            // 
            // buttonToPayment
            // 
            this.buttonToPayment.Location = new System.Drawing.Point(653, 40);
            this.buttonToPayment.Name = "buttonToPayment";
            this.buttonToPayment.Size = new System.Drawing.Size(130, 20);
            this.buttonToPayment.TabIndex = 4;
            this.buttonToPayment.Text = "К оплате";
            this.buttonToPayment.UseVisualStyleBackColor = true;
            // 
            // dataGridViewDrugsList
            // 
            this.dataGridViewDrugsList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewDrugsList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewDrugsList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewDrugsList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridViewDrugsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDrugsList.EnableHeadersVisualStyles = false;
            this.dataGridViewDrugsList.Location = new System.Drawing.Point(3, 66);
            this.dataGridViewDrugsList.Name = "dataGridViewDrugsList";
            this.dataGridViewDrugsList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridViewDrugsList.RowHeadersVisible = false;
            this.dataGridViewDrugsList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewDrugsList.Size = new System.Drawing.Size(789, 277);
            this.dataGridViewDrugsList.TabIndex = 3;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(553, 40);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(94, 20);
            this.buttonSearch.TabIndex = 2;
            this.buttonSearch.Text = "Поиск";
            this.buttonSearch.UseVisualStyleBackColor = true;
            // 
            // labelSearch
            // 
            this.labelSearch.AutoSize = true;
            this.labelSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSearch.Location = new System.Drawing.Point(6, 17);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(55, 20);
            this.labelSearch.TabIndex = 1;
            this.labelSearch.Text = "Поиск";
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(3, 40);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(544, 20);
            this.textBoxSearch.TabIndex = 0;
            // 
            // tabPagePay
            // 
            this.tabPagePay.Controls.Add(this.buttonOk);
            this.tabPagePay.Controls.Add(this.buttonBack);
            this.tabPagePay.Controls.Add(this.labelChange);
            this.tabPagePay.Controls.Add(this.textBoxChange);
            this.tabPagePay.Controls.Add(this.labelProvided);
            this.tabPagePay.Controls.Add(this.textBoxProvided);
            this.tabPagePay.Controls.Add(this.comboBoxPayMethod);
            this.tabPagePay.Controls.Add(this.buttonPayment);
            this.tabPagePay.Controls.Add(this.checkBoxRecipeCheck);
            this.tabPagePay.Controls.Add(this.textBoxTotalSum);
            this.tabPagePay.Controls.Add(this.labelTotalSum);
            this.tabPagePay.Controls.Add(this.dataGridViewPay);
            this.tabPagePay.Location = new System.Drawing.Point(4, 22);
            this.tabPagePay.Name = "tabPagePay";
            this.tabPagePay.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePay.Size = new System.Drawing.Size(792, 346);
            this.tabPagePay.TabIndex = 1;
            this.tabPagePay.Text = "Оплата";
            this.tabPagePay.UseVisualStyleBackColor = true;
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(640, 314);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(130, 23);
            this.buttonOk.TabIndex = 11;
            this.buttonOk.Text = "Готово";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Visible = false;
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(402, 314);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(130, 23);
            this.buttonBack.TabIndex = 10;
            this.buttonBack.Text = "Назад";
            this.buttonBack.UseVisualStyleBackColor = true;
            // 
            // labelChange
            // 
            this.labelChange.AutoSize = true;
            this.labelChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelChange.Location = new System.Drawing.Point(539, 171);
            this.labelChange.Name = "labelChange";
            this.labelChange.Size = new System.Drawing.Size(58, 20);
            this.labelChange.TabIndex = 9;
            this.labelChange.Text = "Сдача";
            this.labelChange.Visible = false;
            // 
            // textBoxChange
            // 
            this.textBoxChange.Location = new System.Drawing.Point(640, 171);
            this.textBoxChange.Name = "textBoxChange";
            this.textBoxChange.Size = new System.Drawing.Size(130, 20);
            this.textBoxChange.TabIndex = 8;
            this.textBoxChange.Visible = false;
            // 
            // labelProvided
            // 
            this.labelProvided.AutoSize = true;
            this.labelProvided.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelProvided.Location = new System.Drawing.Point(398, 131);
            this.labelProvided.Name = "labelProvided";
            this.labelProvided.Size = new System.Drawing.Size(199, 20);
            this.labelProvided.TabIndex = 7;
            this.labelProvided.Text = "Предоставленная сумма";
            this.labelProvided.Visible = false;
            // 
            // textBoxProvided
            // 
            this.textBoxProvided.Location = new System.Drawing.Point(640, 131);
            this.textBoxProvided.Name = "textBoxProvided";
            this.textBoxProvided.Size = new System.Drawing.Size(130, 20);
            this.textBoxProvided.TabIndex = 6;
            this.textBoxProvided.Visible = false;
            // 
            // comboBoxPayMethod
            // 
            this.comboBoxPayMethod.FormattingEnabled = true;
            this.comboBoxPayMethod.Items.AddRange(new object[] {
            "Наличная оплата",
            "Олата картой"});
            this.comboBoxPayMethod.Location = new System.Drawing.Point(621, 35);
            this.comboBoxPayMethod.Name = "comboBoxPayMethod";
            this.comboBoxPayMethod.Size = new System.Drawing.Size(149, 21);
            this.comboBoxPayMethod.TabIndex = 5;
            this.comboBoxPayMethod.Text = "Способ оплаты";
            // 
            // buttonPayment
            // 
            this.buttonPayment.Location = new System.Drawing.Point(640, 212);
            this.buttonPayment.Name = "buttonPayment";
            this.buttonPayment.Size = new System.Drawing.Size(130, 23);
            this.buttonPayment.TabIndex = 4;
            this.buttonPayment.Text = "Оплата";
            this.buttonPayment.UseVisualStyleBackColor = true;
            // 
            // checkBoxRecipeCheck
            // 
            this.checkBoxRecipeCheck.AutoSize = true;
            this.checkBoxRecipeCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxRecipeCheck.Location = new System.Drawing.Point(398, 61);
            this.checkBoxRecipeCheck.Name = "checkBoxRecipeCheck";
            this.checkBoxRecipeCheck.Size = new System.Drawing.Size(221, 24);
            this.checkBoxRecipeCheck.TabIndex = 3;
            this.checkBoxRecipeCheck.Text = "Подтверждение рецепта";
            this.checkBoxRecipeCheck.UseVisualStyleBackColor = true;
            // 
            // textBoxTotalSum
            // 
            this.textBoxTotalSum.Location = new System.Drawing.Point(398, 35);
            this.textBoxTotalSum.Name = "textBoxTotalSum";
            this.textBoxTotalSum.ReadOnly = true;
            this.textBoxTotalSum.Size = new System.Drawing.Size(130, 20);
            this.textBoxTotalSum.TabIndex = 2;
            this.textBoxTotalSum.Text = "0";
            // 
            // labelTotalSum
            // 
            this.labelTotalSum.AutoSize = true;
            this.labelTotalSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTotalSum.Location = new System.Drawing.Point(398, 8);
            this.labelTotalSum.Name = "labelTotalSum";
            this.labelTotalSum.Size = new System.Drawing.Size(68, 24);
            this.labelTotalSum.TabIndex = 1;
            this.labelTotalSum.Text = "Сумма";
            // 
            // dataGridViewPay
            // 
            this.dataGridViewPay.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewPay.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewPay.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewPay.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridViewPay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPay.EnableHeadersVisualStyles = false;
            this.dataGridViewPay.Location = new System.Drawing.Point(6, 6);
            this.dataGridViewPay.Name = "dataGridViewPay";
            this.dataGridViewPay.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridViewPay.RowHeadersVisible = false;
            this.dataGridViewPay.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewPay.Size = new System.Drawing.Size(385, 334);
            this.dataGridViewPay.TabIndex = 0;
            // 
            // panelDrugTitle
            // 
            this.panelDrugTitle.Controls.Add(this.buttonExit);
            this.panelDrugTitle.Controls.Add(this.labelDrugTitle);
            this.panelDrugTitle.Location = new System.Drawing.Point(0, -1);
            this.panelDrugTitle.Name = "panelDrugTitle";
            this.panelDrugTitle.Size = new System.Drawing.Size(800, 74);
            this.panelDrugTitle.TabIndex = 2;
            // 
            // labelDrugTitle
            // 
            this.labelDrugTitle.AutoSize = true;
            this.labelDrugTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDrugTitle.Location = new System.Drawing.Point(28, 27);
            this.labelDrugTitle.Name = "labelDrugTitle";
            this.labelDrugTitle.Size = new System.Drawing.Size(178, 24);
            this.labelDrugTitle.TabIndex = 0;
            this.labelDrugTitle.Text = "Продажа лекарств";
            // 
            // buttonExit
            // 
            this.buttonExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonExit.AutoSize = true;
            this.buttonExit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonExit.BackColor = System.Drawing.Color.Chocolate;
            this.buttonExit.FlatAppearance.BorderColor = System.Drawing.Color.Chocolate;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.Location = new System.Drawing.Point(762, 13);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(26, 25);
            this.buttonExit.TabIndex = 2;
            this.buttonExit.Text = "X";
            this.buttonExit.UseVisualStyleBackColor = false;
            // 
            // DrugPaymentView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControlDrugLists);
            this.Controls.Add(this.panelDrugTitle);
            this.Name = "DrugPaymentView";
            this.Text = "DrugPayment";
            this.tabControlDrugLists.ResumeLayout(false);
            this.tabPageDrugList.ResumeLayout(false);
            this.tabPageDrugList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDrugsList)).EndInit();
            this.tabPagePay.ResumeLayout(false);
            this.tabPagePay.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPay)).EndInit();
            this.panelDrugTitle.ResumeLayout(false);
            this.panelDrugTitle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlDrugLists;
        private System.Windows.Forms.TabPage tabPageDrugList;
        private System.Windows.Forms.Button buttonToPayment;
        private System.Windows.Forms.DataGridView dataGridViewDrugsList;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Label labelSearch;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.TabPage tabPagePay;
        private System.Windows.Forms.ComboBox comboBoxPayMethod;
        private System.Windows.Forms.Button buttonPayment;
        private System.Windows.Forms.CheckBox checkBoxRecipeCheck;
        private System.Windows.Forms.TextBox textBoxTotalSum;
        private System.Windows.Forms.Label labelTotalSum;
        private System.Windows.Forms.DataGridView dataGridViewPay;
        private System.Windows.Forms.Panel panelDrugTitle;
        private System.Windows.Forms.Label labelDrugTitle;
        private System.Windows.Forms.Label labelChange;
        private System.Windows.Forms.TextBox textBoxChange;
        private System.Windows.Forms.Label labelProvided;
        private System.Windows.Forms.TextBox textBoxProvided;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonExit;
    }
}