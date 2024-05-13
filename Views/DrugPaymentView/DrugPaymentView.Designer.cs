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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControlDrugLists = new System.Windows.Forms.TabControl();
            this.tabPageDrugList = new System.Windows.Forms.TabPage();
            this.buttonToPayment = new System.Windows.Forms.Button();
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
            this.panelDrugTitle = new System.Windows.Forms.Panel();
            this.buttonExit = new System.Windows.Forms.Button();
            this.labelDrugTitle = new System.Windows.Forms.Label();
            this.dataGridViewDrugsList = new System.Windows.Forms.DataGridView();
            this.dataGridViewPay = new System.Windows.Forms.DataGridView();
            this.tabControlDrugLists.SuspendLayout();
            this.tabPageDrugList.SuspendLayout();
            this.tabPagePay.SuspendLayout();
            this.panelDrugTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDrugsList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPay)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlDrugLists
            // 
            this.tabControlDrugLists.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.tabPageDrugList.Controls.Add(this.dataGridViewDrugsList);
            this.tabPageDrugList.Controls.Add(this.buttonToPayment);
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
            this.buttonToPayment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonToPayment.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonToPayment.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.buttonToPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonToPayment.Location = new System.Drawing.Point(653, 40);
            this.buttonToPayment.Name = "buttonToPayment";
            this.buttonToPayment.Size = new System.Drawing.Size(130, 21);
            this.buttonToPayment.TabIndex = 4;
            this.buttonToPayment.Text = "К оплате";
            this.buttonToPayment.UseVisualStyleBackColor = false;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSearch.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonSearch.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.buttonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSearch.Location = new System.Drawing.Point(553, 40);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(94, 21);
            this.buttonSearch.TabIndex = 2;
            this.buttonSearch.Text = "Поиск";
            this.buttonSearch.UseVisualStyleBackColor = false;
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
            this.textBoxSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSearch.Location = new System.Drawing.Point(3, 40);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(544, 20);
            this.textBoxSearch.TabIndex = 0;
            // 
            // tabPagePay
            // 
            this.tabPagePay.Controls.Add(this.dataGridViewPay);
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
            this.buttonOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOk.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonOk.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.buttonOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOk.Location = new System.Drawing.Point(640, 314);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(130, 23);
            this.buttonOk.TabIndex = 11;
            this.buttonOk.Text = "Готово";
            this.buttonOk.UseVisualStyleBackColor = false;
            this.buttonOk.Visible = false;
            // 
            // buttonBack
            // 
            this.buttonBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBack.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonBack.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.buttonBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBack.Location = new System.Drawing.Point(402, 314);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(130, 23);
            this.buttonBack.TabIndex = 10;
            this.buttonBack.Text = "Назад";
            this.buttonBack.UseVisualStyleBackColor = false;
            // 
            // labelChange
            // 
            this.labelChange.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
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
            this.textBoxChange.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxChange.Location = new System.Drawing.Point(640, 171);
            this.textBoxChange.Name = "textBoxChange";
            this.textBoxChange.ReadOnly = true;
            this.textBoxChange.Size = new System.Drawing.Size(130, 20);
            this.textBoxChange.TabIndex = 8;
            this.textBoxChange.Visible = false;
            // 
            // labelProvided
            // 
            this.labelProvided.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
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
            this.textBoxProvided.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxProvided.Location = new System.Drawing.Point(640, 131);
            this.textBoxProvided.Name = "textBoxProvided";
            this.textBoxProvided.Size = new System.Drawing.Size(130, 20);
            this.textBoxProvided.TabIndex = 6;
            this.textBoxProvided.Visible = false;
            // 
            // comboBoxPayMethod
            // 
            this.comboBoxPayMethod.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
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
            this.buttonPayment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPayment.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonPayment.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.buttonPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPayment.Location = new System.Drawing.Point(640, 212);
            this.buttonPayment.Name = "buttonPayment";
            this.buttonPayment.Size = new System.Drawing.Size(130, 23);
            this.buttonPayment.TabIndex = 4;
            this.buttonPayment.Text = "Оплата";
            this.buttonPayment.UseVisualStyleBackColor = false;
            // 
            // checkBoxRecipeCheck
            // 
            this.checkBoxRecipeCheck.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
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
            this.textBoxTotalSum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxTotalSum.Location = new System.Drawing.Point(398, 35);
            this.textBoxTotalSum.Name = "textBoxTotalSum";
            this.textBoxTotalSum.ReadOnly = true;
            this.textBoxTotalSum.Size = new System.Drawing.Size(130, 20);
            this.textBoxTotalSum.TabIndex = 2;
            this.textBoxTotalSum.Text = "0";
            // 
            // labelTotalSum
            // 
            this.labelTotalSum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTotalSum.AutoSize = true;
            this.labelTotalSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTotalSum.Location = new System.Drawing.Point(398, 8);
            this.labelTotalSum.Name = "labelTotalSum";
            this.labelTotalSum.Size = new System.Drawing.Size(68, 24);
            this.labelTotalSum.TabIndex = 1;
            this.labelTotalSum.Text = "Сумма";
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
            // dataGridViewDrugsList
            // 
            this.dataGridViewDrugsList.AllowUserToAddRows = false;
            this.dataGridViewDrugsList.AllowUserToDeleteRows = false;
            this.dataGridViewDrugsList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewDrugsList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewDrugsList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewDrugsList.BackgroundColor = System.Drawing.Color.NavajoWhite;
            this.dataGridViewDrugsList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewDrugsList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.ForestGreen;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.ForestGreen;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            this.dataGridViewDrugsList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridViewDrugsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.NavajoWhite;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewDrugsList.DefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridViewDrugsList.EnableHeadersVisualStyles = false;
            this.dataGridViewDrugsList.Location = new System.Drawing.Point(0, 66);
            this.dataGridViewDrugsList.Name = "dataGridViewDrugsList";
            this.dataGridViewDrugsList.ReadOnly = true;
            this.dataGridViewDrugsList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.NavajoWhite;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewDrugsList.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridViewDrugsList.RowHeadersVisible = false;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridViewDrugsList.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridViewDrugsList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewDrugsList.Size = new System.Drawing.Size(796, 280);
            this.dataGridViewDrugsList.TabIndex = 4;
            // 
            // dataGridViewPay
            // 
            this.dataGridViewPay.AllowUserToAddRows = false;
            this.dataGridViewPay.AllowUserToDeleteRows = false;
            this.dataGridViewPay.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewPay.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewPay.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewPay.BackgroundColor = System.Drawing.Color.NavajoWhite;
            this.dataGridViewPay.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewPay.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.ForestGreen;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.ForestGreen;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            this.dataGridViewPay.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dataGridViewPay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.NavajoWhite;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewPay.DefaultCellStyle = dataGridViewCellStyle14;
            this.dataGridViewPay.EnableHeadersVisualStyles = false;
            this.dataGridViewPay.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewPay.Name = "dataGridViewPay";
            this.dataGridViewPay.ReadOnly = true;
            this.dataGridViewPay.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.NavajoWhite;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewPay.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.dataGridViewPay.RowHeadersVisible = false;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridViewPay.RowsDefaultCellStyle = dataGridViewCellStyle16;
            this.dataGridViewPay.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewPay.Size = new System.Drawing.Size(392, 346);
            this.dataGridViewPay.TabIndex = 4;
            // 
            // DrugPaymentView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControlDrugLists);
            this.Controls.Add(this.panelDrugTitle);
            this.Name = "DrugPaymentView";
            this.Text = "DrugPayment";
            this.tabControlDrugLists.ResumeLayout(false);
            this.tabPageDrugList.ResumeLayout(false);
            this.tabPageDrugList.PerformLayout();
            this.tabPagePay.ResumeLayout(false);
            this.tabPagePay.PerformLayout();
            this.panelDrugTitle.ResumeLayout(false);
            this.panelDrugTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDrugsList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPay)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlDrugLists;
        private System.Windows.Forms.TabPage tabPageDrugList;
        private System.Windows.Forms.Button buttonToPayment;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Label labelSearch;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.TabPage tabPagePay;
        private System.Windows.Forms.ComboBox comboBoxPayMethod;
        private System.Windows.Forms.Button buttonPayment;
        private System.Windows.Forms.CheckBox checkBoxRecipeCheck;
        private System.Windows.Forms.TextBox textBoxTotalSum;
        private System.Windows.Forms.Label labelTotalSum;
        private System.Windows.Forms.Panel panelDrugTitle;
        private System.Windows.Forms.Label labelDrugTitle;
        private System.Windows.Forms.Label labelChange;
        private System.Windows.Forms.TextBox textBoxChange;
        private System.Windows.Forms.Label labelProvided;
        private System.Windows.Forms.TextBox textBoxProvided;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.DataGridView dataGridViewDrugsList;
        private System.Windows.Forms.DataGridView dataGridViewPay;
    }
}