namespace Pharmacy.Views
{
    partial class DrugView
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.labelMedicines = new System.Windows.Forms.Label();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.buttonExit = new System.Windows.Forms.Button();
            this.tabControlDrugLists = new System.Windows.Forms.TabControl();
            this.tabPageList = new System.Windows.Forms.TabPage();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.dataGridViewDrugs = new System.Windows.Forms.DataGridView();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.labelSearch = new System.Windows.Forms.Label();
            this.tabPageDetail = new System.Windows.Forms.TabPage();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.textBoxDrugPlace = new System.Windows.Forms.TextBox();
            this.labelDrugPlace = new System.Windows.Forms.Label();
            this.textBoxDrugCost = new System.Windows.Forms.TextBox();
            this.labelDrugCost = new System.Windows.Forms.Label();
            this.textBoxDrugAmount = new System.Windows.Forms.TextBox();
            this.labelDrugAmount = new System.Windows.Forms.Label();
            this.textBoxDrugName = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxDrugId = new System.Windows.Forms.TextBox();
            this.labelId = new System.Windows.Forms.Label();
            this.panelTitle.SuspendLayout();
            this.tabControlDrugLists.SuspendLayout();
            this.tabPageList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDrugs)).BeginInit();
            this.tabPageDetail.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelMedicines
            // 
            this.labelMedicines.AutoSize = true;
            this.labelMedicines.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMedicines.Location = new System.Drawing.Point(13, 15);
            this.labelMedicines.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMedicines.Name = "labelMedicines";
            this.labelMedicines.Size = new System.Drawing.Size(185, 39);
            this.labelMedicines.TabIndex = 0;
            this.labelMedicines.Text = "Лекарства";
            this.labelMedicines.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelTitle
            // 
            this.panelTitle.Controls.Add(this.buttonExit);
            this.panelTitle.Controls.Add(this.labelMedicines);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(0, 0);
            this.panelTitle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(1067, 69);
            this.panelTitle.TabIndex = 1;
            // 
            // buttonExit
            // 
            this.buttonExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonExit.AutoSize = true;
            this.buttonExit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonExit.BackColor = System.Drawing.Color.Chocolate;
            this.buttonExit.FlatAppearance.BorderColor = System.Drawing.Color.Chocolate;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.Location = new System.Drawing.Point(1008, 15);
            this.buttonExit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(27, 28);
            this.buttonExit.TabIndex = 1;
            this.buttonExit.Text = "X";
            this.buttonExit.UseVisualStyleBackColor = false;
            // 
            // tabControlDrugLists
            // 
            this.tabControlDrugLists.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlDrugLists.Controls.Add(this.tabPageList);
            this.tabControlDrugLists.Controls.Add(this.tabPageDetail);
            this.tabControlDrugLists.Location = new System.Drawing.Point(0, 69);
            this.tabControlDrugLists.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabControlDrugLists.Name = "tabControlDrugLists";
            this.tabControlDrugLists.SelectedIndex = 0;
            this.tabControlDrugLists.Size = new System.Drawing.Size(1067, 485);
            this.tabControlDrugLists.TabIndex = 2;
            // 
            // tabPageList
            // 
            this.tabPageList.BackColor = System.Drawing.Color.White;
            this.tabPageList.Controls.Add(this.buttonDelete);
            this.tabPageList.Controls.Add(this.buttonEdit);
            this.tabPageList.Controls.Add(this.buttonAdd);
            this.tabPageList.Controls.Add(this.dataGridViewDrugs);
            this.tabPageList.Controls.Add(this.buttonSearch);
            this.tabPageList.Controls.Add(this.textBoxSearch);
            this.tabPageList.Controls.Add(this.labelSearch);
            this.tabPageList.Location = new System.Drawing.Point(4, 25);
            this.tabPageList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPageList.Name = "tabPageList";
            this.tabPageList.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPageList.Size = new System.Drawing.Size(1059, 456);
            this.tabPageList.TabIndex = 0;
            this.tabPageList.Text = "Список";
            // 
            // buttonDelete
            // 
            this.buttonDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDelete.BackColor = System.Drawing.Color.OrangeRed;
            this.buttonDelete.FlatAppearance.BorderColor = System.Drawing.Color.OrangeRed;
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete.Location = new System.Drawing.Point(929, 153);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(100, 28);
            this.buttonDelete.TabIndex = 6;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = false;
            // 
            // buttonEdit
            // 
            this.buttonEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonEdit.BackColor = System.Drawing.Color.Orange;
            this.buttonEdit.FlatAppearance.BorderColor = System.Drawing.Color.Orange;
            this.buttonEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEdit.Location = new System.Drawing.Point(929, 116);
            this.buttonEdit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(100, 28);
            this.buttonEdit.TabIndex = 5;
            this.buttonEdit.Text = "Изменить";
            this.buttonEdit.UseVisualStyleBackColor = false;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAdd.BackColor = System.Drawing.Color.YellowGreen;
            this.buttonAdd.FlatAppearance.BorderColor = System.Drawing.Color.YellowGreen;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Location = new System.Drawing.Point(929, 79);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(100, 28);
            this.buttonAdd.TabIndex = 4;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = false;
            // 
            // dataGridViewDrugs
            // 
            this.dataGridViewDrugs.AllowUserToAddRows = false;
            this.dataGridViewDrugs.AllowUserToDeleteRows = false;
            this.dataGridViewDrugs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewDrugs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewDrugs.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewDrugs.BackgroundColor = System.Drawing.Color.Wheat;
            this.dataGridViewDrugs.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewDrugs.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.ForestGreen;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.ForestGreen;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            this.dataGridViewDrugs.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewDrugs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.NavajoWhite;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewDrugs.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewDrugs.EnableHeadersVisualStyles = false;
            this.dataGridViewDrugs.Location = new System.Drawing.Point(36, 79);
            this.dataGridViewDrugs.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewDrugs.Name = "dataGridViewDrugs";
            this.dataGridViewDrugs.ReadOnly = true;
            this.dataGridViewDrugs.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.NavajoWhite;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewDrugs.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewDrugs.RowHeadersVisible = false;
            this.dataGridViewDrugs.RowHeadersWidth = 51;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridViewDrugs.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewDrugs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewDrugs.Size = new System.Drawing.Size(884, 347);
            this.dataGridViewDrugs.TabIndex = 3;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSearch.AutoSize = true;
            this.buttonSearch.BackColor = System.Drawing.Color.PapayaWhip;
            this.buttonSearch.FlatAppearance.BorderColor = System.Drawing.Color.PapayaWhip;
            this.buttonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSearch.Location = new System.Drawing.Point(820, 39);
            this.buttonSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(100, 34);
            this.buttonSearch.TabIndex = 2;
            this.buttonSearch.Text = "Поиск";
            this.buttonSearch.UseVisualStyleBackColor = false;
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSearch.Location = new System.Drawing.Point(36, 39);
            this.textBoxSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(773, 28);
            this.textBoxSearch.TabIndex = 1;
            // 
            // labelSearch
            // 
            this.labelSearch.AutoSize = true;
            this.labelSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSearch.Location = new System.Drawing.Point(31, 11);
            this.labelSearch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(68, 25);
            this.labelSearch.TabIndex = 0;
            this.labelSearch.Text = "Поиск";
            // 
            // tabPageDetail
            // 
            this.tabPageDetail.Controls.Add(this.buttonCancel);
            this.tabPageDetail.Controls.Add(this.buttonSave);
            this.tabPageDetail.Controls.Add(this.textBoxDrugPlace);
            this.tabPageDetail.Controls.Add(this.labelDrugPlace);
            this.tabPageDetail.Controls.Add(this.textBoxDrugCost);
            this.tabPageDetail.Controls.Add(this.labelDrugCost);
            this.tabPageDetail.Controls.Add(this.textBoxDrugAmount);
            this.tabPageDetail.Controls.Add(this.labelDrugAmount);
            this.tabPageDetail.Controls.Add(this.textBoxDrugName);
            this.tabPageDetail.Controls.Add(this.labelName);
            this.tabPageDetail.Controls.Add(this.textBoxDrugId);
            this.tabPageDetail.Controls.Add(this.labelId);
            this.tabPageDetail.Location = new System.Drawing.Point(4, 25);
            this.tabPageDetail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPageDetail.Name = "tabPageDetail";
            this.tabPageDetail.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPageDetail.Size = new System.Drawing.Size(1059, 456);
            this.tabPageDetail.TabIndex = 1;
            this.tabPageDetail.Text = "Детали";
            this.tabPageDetail.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.AutoSize = true;
            this.buttonCancel.BackColor = System.Drawing.Color.Teal;
            this.buttonCancel.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCancel.Location = new System.Drawing.Point(563, 347);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(141, 39);
            this.buttonCancel.TabIndex = 11;
            this.buttonCancel.Text = "Отменить";
            this.buttonCancel.UseVisualStyleBackColor = false;
            // 
            // buttonSave
            // 
            this.buttonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSave.AutoSize = true;
            this.buttonSave.BackColor = System.Drawing.Color.DarkKhaki;
            this.buttonSave.FlatAppearance.BorderColor = System.Drawing.Color.DarkKhaki;
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSave.Location = new System.Drawing.Point(303, 347);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(148, 39);
            this.buttonSave.TabIndex = 10;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = false;
            // 
            // textBoxDrugPlace
            // 
            this.textBoxDrugPlace.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDrugPlace.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxDrugPlace.Location = new System.Drawing.Point(469, 217);
            this.textBoxDrugPlace.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxDrugPlace.Name = "textBoxDrugPlace";
            this.textBoxDrugPlace.Size = new System.Drawing.Size(233, 26);
            this.textBoxDrugPlace.TabIndex = 9;
            // 
            // labelDrugPlace
            // 
            this.labelDrugPlace.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelDrugPlace.AutoSize = true;
            this.labelDrugPlace.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDrugPlace.Location = new System.Drawing.Point(328, 217);
            this.labelDrugPlace.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDrugPlace.Name = "labelDrugPlace";
            this.labelDrugPlace.Size = new System.Drawing.Size(55, 20);
            this.labelDrugPlace.TabIndex = 8;
            this.labelDrugPlace.Text = "Ящик";
            // 
            // textBoxDrugCost
            // 
            this.textBoxDrugCost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDrugCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxDrugCost.Location = new System.Drawing.Point(469, 270);
            this.textBoxDrugCost.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxDrugCost.Name = "textBoxDrugCost";
            this.textBoxDrugCost.Size = new System.Drawing.Size(233, 26);
            this.textBoxDrugCost.TabIndex = 7;
            // 
            // labelDrugCost
            // 
            this.labelDrugCost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelDrugCost.AutoSize = true;
            this.labelDrugCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDrugCost.Location = new System.Drawing.Point(328, 270);
            this.labelDrugCost.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDrugCost.Name = "labelDrugCost";
            this.labelDrugCost.Size = new System.Drawing.Size(52, 20);
            this.labelDrugCost.TabIndex = 6;
            this.labelDrugCost.Text = "Цена";
            // 
            // textBoxDrugAmount
            // 
            this.textBoxDrugAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDrugAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxDrugAmount.Location = new System.Drawing.Point(469, 111);
            this.textBoxDrugAmount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxDrugAmount.Name = "textBoxDrugAmount";
            this.textBoxDrugAmount.Size = new System.Drawing.Size(233, 26);
            this.textBoxDrugAmount.TabIndex = 5;
            // 
            // labelDrugAmount
            // 
            this.labelDrugAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelDrugAmount.AutoSize = true;
            this.labelDrugAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDrugAmount.Location = new System.Drawing.Point(328, 111);
            this.labelDrugAmount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDrugAmount.Name = "labelDrugAmount";
            this.labelDrugAmount.Size = new System.Drawing.Size(109, 20);
            this.labelDrugAmount.TabIndex = 4;
            this.labelDrugAmount.Text = "Количество";
            // 
            // textBoxDrugName
            // 
            this.textBoxDrugName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDrugName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxDrugName.Location = new System.Drawing.Point(469, 162);
            this.textBoxDrugName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxDrugName.Name = "textBoxDrugName";
            this.textBoxDrugName.Size = new System.Drawing.Size(233, 26);
            this.textBoxDrugName.TabIndex = 3;
            // 
            // labelName
            // 
            this.labelName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelName.Location = new System.Drawing.Point(328, 162);
            this.labelName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(91, 20);
            this.labelName.TabIndex = 2;
            this.labelName.Text = "Название";
            // 
            // textBoxDrugId
            // 
            this.textBoxDrugId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDrugId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxDrugId.Location = new System.Drawing.Point(469, 57);
            this.textBoxDrugId.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxDrugId.Name = "textBoxDrugId";
            this.textBoxDrugId.ReadOnly = true;
            this.textBoxDrugId.Size = new System.Drawing.Size(233, 26);
            this.textBoxDrugId.TabIndex = 1;
            this.textBoxDrugId.Text = "0";
            // 
            // labelId
            // 
            this.labelId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelId.AutoSize = true;
            this.labelId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelId.Location = new System.Drawing.Point(328, 57);
            this.labelId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(119, 20);
            this.labelId.TabIndex = 0;
            this.labelId.Text = "ID лекарства";
            // 
            // DrugView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.tabControlDrugLists);
            this.Controls.Add(this.panelTitle);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "DrugView";
            this.Text = "DrugView";
            this.panelTitle.ResumeLayout(false);
            this.panelTitle.PerformLayout();
            this.tabControlDrugLists.ResumeLayout(false);
            this.tabPageList.ResumeLayout(false);
            this.tabPageList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDrugs)).EndInit();
            this.tabPageDetail.ResumeLayout(false);
            this.tabPageDetail.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelMedicines;
        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.TabControl tabControlDrugLists;
        private System.Windows.Forms.TabPage tabPageList;
        private System.Windows.Forms.Label labelSearch;
        private System.Windows.Forms.TabPage tabPageDetail;
        private System.Windows.Forms.DataGridView dataGridViewDrugs;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.TextBox textBoxDrugPlace;
        private System.Windows.Forms.Label labelDrugPlace;
        private System.Windows.Forms.TextBox textBoxDrugCost;
        private System.Windows.Forms.Label labelDrugCost;
        private System.Windows.Forms.TextBox textBoxDrugAmount;
        private System.Windows.Forms.Label labelDrugAmount;
        private System.Windows.Forms.TextBox textBoxDrugName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxDrugId;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.Button buttonExit;
    }
}