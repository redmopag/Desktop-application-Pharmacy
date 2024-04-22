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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.tabControlDrugLists.Location = new System.Drawing.Point(0, 97);
            this.tabControlDrugLists.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabControlDrugLists.Name = "tabControlDrugLists";
            this.tabControlDrugLists.SelectedIndex = 0;
            this.tabControlDrugLists.Size = new System.Drawing.Size(1067, 458);
            this.tabControlDrugLists.TabIndex = 3;
            // 
            // tabPageDrugList
            // 
            this.tabPageDrugList.Controls.Add(this.dataGridViewDrugsList);
            this.tabPageDrugList.Controls.Add(this.buttonToPayment);
            this.tabPageDrugList.Controls.Add(this.buttonSearch);
            this.tabPageDrugList.Controls.Add(this.labelSearch);
            this.tabPageDrugList.Controls.Add(this.textBoxSearch);
            this.tabPageDrugList.Location = new System.Drawing.Point(4, 25);
            this.tabPageDrugList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPageDrugList.Name = "tabPageDrugList";
            this.tabPageDrugList.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPageDrugList.Size = new System.Drawing.Size(1059, 429);
            this.tabPageDrugList.TabIndex = 0;
            this.tabPageDrugList.Text = "Каталог";
            this.tabPageDrugList.UseVisualStyleBackColor = true;
            // 
            // buttonToPayment
            // 
            this.buttonToPayment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonToPayment.Location = new System.Drawing.Point(871, 49);
            this.buttonToPayment.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonToPayment.Name = "buttonToPayment";
            this.buttonToPayment.Size = new System.Drawing.Size(173, 25);
            this.buttonToPayment.TabIndex = 4;
            this.buttonToPayment.Text = "К оплате";
            this.buttonToPayment.UseVisualStyleBackColor = true;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSearch.Location = new System.Drawing.Point(737, 49);
            this.buttonSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(125, 25);
            this.buttonSearch.TabIndex = 2;
            this.buttonSearch.Text = "Поиск";
            this.buttonSearch.UseVisualStyleBackColor = true;
            // 
            // labelSearch
            // 
            this.labelSearch.AutoSize = true;
            this.labelSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSearch.Location = new System.Drawing.Point(8, 21);
            this.labelSearch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(68, 25);
            this.labelSearch.TabIndex = 1;
            this.labelSearch.Text = "Поиск";
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSearch.Location = new System.Drawing.Point(4, 49);
            this.textBoxSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(724, 22);
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
            this.tabPagePay.Location = new System.Drawing.Point(4, 25);
            this.tabPagePay.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPagePay.Name = "tabPagePay";
            this.tabPagePay.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPagePay.Size = new System.Drawing.Size(1059, 429);
            this.tabPagePay.TabIndex = 1;
            this.tabPagePay.Text = "Оплата";
            this.tabPagePay.UseVisualStyleBackColor = true;
            // 
            // buttonOk
            // 
            this.buttonOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOk.Location = new System.Drawing.Point(853, 386);
            this.buttonOk.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(173, 28);
            this.buttonOk.TabIndex = 11;
            this.buttonOk.Text = "Готово";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Visible = false;
            // 
            // buttonBack
            // 
            this.buttonBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBack.Location = new System.Drawing.Point(536, 386);
            this.buttonBack.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(173, 28);
            this.buttonBack.TabIndex = 10;
            this.buttonBack.Text = "Назад";
            this.buttonBack.UseVisualStyleBackColor = true;
            // 
            // labelChange
            // 
            this.labelChange.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelChange.AutoSize = true;
            this.labelChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelChange.Location = new System.Drawing.Point(719, 190);
            this.labelChange.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelChange.Name = "labelChange";
            this.labelChange.Size = new System.Drawing.Size(68, 25);
            this.labelChange.TabIndex = 9;
            this.labelChange.Text = "Сдача";
            this.labelChange.Visible = false;
            // 
            // textBoxChange
            // 
            this.textBoxChange.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.textBoxChange.Location = new System.Drawing.Point(853, 190);
            this.textBoxChange.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxChange.Name = "textBoxChange";
            this.textBoxChange.Size = new System.Drawing.Size(172, 22);
            this.textBoxChange.TabIndex = 8;
            this.textBoxChange.Visible = false;
            // 
            // labelProvided
            // 
            this.labelProvided.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelProvided.AutoSize = true;
            this.labelProvided.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelProvided.Location = new System.Drawing.Point(531, 141);
            this.labelProvided.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelProvided.Name = "labelProvided";
            this.labelProvided.Size = new System.Drawing.Size(247, 25);
            this.labelProvided.TabIndex = 7;
            this.labelProvided.Text = "Предоставленная сумма";
            this.labelProvided.Visible = false;
            // 
            // textBoxProvided
            // 
            this.textBoxProvided.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.textBoxProvided.Location = new System.Drawing.Point(853, 141);
            this.textBoxProvided.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxProvided.Name = "textBoxProvided";
            this.textBoxProvided.Size = new System.Drawing.Size(172, 22);
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
            this.comboBoxPayMethod.Location = new System.Drawing.Point(828, 43);
            this.comboBoxPayMethod.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxPayMethod.Name = "comboBoxPayMethod";
            this.comboBoxPayMethod.Size = new System.Drawing.Size(197, 24);
            this.comboBoxPayMethod.TabIndex = 5;
            this.comboBoxPayMethod.Text = "Способ оплаты";
            // 
            // buttonPayment
            // 
            this.buttonPayment.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonPayment.Location = new System.Drawing.Point(853, 314);
            this.buttonPayment.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonPayment.Name = "buttonPayment";
            this.buttonPayment.Size = new System.Drawing.Size(173, 28);
            this.buttonPayment.TabIndex = 4;
            this.buttonPayment.Text = "Оплата";
            this.buttonPayment.UseVisualStyleBackColor = true;
            // 
            // checkBoxRecipeCheck
            // 
            this.checkBoxRecipeCheck.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxRecipeCheck.AutoSize = true;
            this.checkBoxRecipeCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxRecipeCheck.Location = new System.Drawing.Point(755, 277);
            this.checkBoxRecipeCheck.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBoxRecipeCheck.Name = "checkBoxRecipeCheck";
            this.checkBoxRecipeCheck.Size = new System.Drawing.Size(271, 29);
            this.checkBoxRecipeCheck.TabIndex = 3;
            this.checkBoxRecipeCheck.Text = "Подтверждение рецепта";
            this.checkBoxRecipeCheck.UseVisualStyleBackColor = true;
            // 
            // textBoxTotalSum
            // 
            this.textBoxTotalSum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxTotalSum.Location = new System.Drawing.Point(536, 43);
            this.textBoxTotalSum.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxTotalSum.Name = "textBoxTotalSum";
            this.textBoxTotalSum.ReadOnly = true;
            this.textBoxTotalSum.Size = new System.Drawing.Size(172, 22);
            this.textBoxTotalSum.TabIndex = 2;
            this.textBoxTotalSum.Text = "0";
            // 
            // labelTotalSum
            // 
            this.labelTotalSum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTotalSum.AutoSize = true;
            this.labelTotalSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTotalSum.Location = new System.Drawing.Point(531, 10);
            this.labelTotalSum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTotalSum.Name = "labelTotalSum";
            this.labelTotalSum.Size = new System.Drawing.Size(90, 29);
            this.labelTotalSum.TabIndex = 1;
            this.labelTotalSum.Text = "Сумма";
            // 
            // panelDrugTitle
            // 
            this.panelDrugTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelDrugTitle.Controls.Add(this.buttonExit);
            this.panelDrugTitle.Controls.Add(this.labelDrugTitle);
            this.panelDrugTitle.Location = new System.Drawing.Point(0, -1);
            this.panelDrugTitle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelDrugTitle.Name = "panelDrugTitle";
            this.panelDrugTitle.Size = new System.Drawing.Size(1067, 91);
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
            this.buttonExit.Location = new System.Drawing.Point(1024, 16);
            this.buttonExit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(27, 28);
            this.buttonExit.TabIndex = 2;
            this.buttonExit.Text = "X";
            this.buttonExit.UseVisualStyleBackColor = false;
            // 
            // labelDrugTitle
            // 
            this.labelDrugTitle.AutoSize = true;
            this.labelDrugTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDrugTitle.Location = new System.Drawing.Point(13, 25);
            this.labelDrugTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDrugTitle.Name = "labelDrugTitle";
            this.labelDrugTitle.Size = new System.Drawing.Size(315, 39);
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
            this.dataGridViewDrugsList.BackgroundColor = System.Drawing.Color.Wheat;
            this.dataGridViewDrugsList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewDrugsList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.ForestGreen;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.ForestGreen;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            this.dataGridViewDrugsList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewDrugsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.NavajoWhite;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewDrugsList.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewDrugsList.EnableHeadersVisualStyles = false;
            this.dataGridViewDrugsList.Location = new System.Drawing.Point(0, 82);
            this.dataGridViewDrugsList.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewDrugsList.Name = "dataGridViewDrugsList";
            this.dataGridViewDrugsList.ReadOnly = true;
            this.dataGridViewDrugsList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.NavajoWhite;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewDrugsList.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewDrugsList.RowHeadersVisible = false;
            this.dataGridViewDrugsList.RowHeadersWidth = 51;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridViewDrugsList.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewDrugsList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewDrugsList.Size = new System.Drawing.Size(1059, 347);
            this.dataGridViewDrugsList.TabIndex = 5;
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
            this.dataGridViewPay.BackgroundColor = System.Drawing.Color.Wheat;
            this.dataGridViewPay.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewPay.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.ForestGreen;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.ForestGreen;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            this.dataGridViewPay.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewPay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.NavajoWhite;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewPay.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewPay.EnableHeadersVisualStyles = false;
            this.dataGridViewPay.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewPay.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewPay.Name = "dataGridViewPay";
            this.dataGridViewPay.ReadOnly = true;
            this.dataGridViewPay.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.NavajoWhite;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewPay.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewPay.RowHeadersVisible = false;
            this.dataGridViewPay.RowHeadersWidth = 51;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridViewPay.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewPay.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewPay.Size = new System.Drawing.Size(523, 429);
            this.dataGridViewPay.TabIndex = 12;
            // 
            // DrugPaymentView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.tabControlDrugLists);
            this.Controls.Add(this.panelDrugTitle);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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