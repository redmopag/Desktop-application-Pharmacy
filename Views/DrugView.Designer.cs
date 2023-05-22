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
            this.labelMedicines = new System.Windows.Forms.Label();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.tabControlDrugLists = new System.Windows.Forms.TabControl();
            this.tabPageList = new System.Windows.Forms.TabPage();
            this.tabPageDetail = new System.Windows.Forms.TabPage();
            this.labelSearch = new System.Windows.Forms.Label();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.dataGridViewDrugs = new System.Windows.Forms.DataGridView();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.labelId = new System.Windows.Forms.Label();
            this.textBoxDrugId = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxDrugName = new System.Windows.Forms.TextBox();
            this.labelDrugAmount = new System.Windows.Forms.Label();
            this.textBoxDrugAmount = new System.Windows.Forms.TextBox();
            this.labelDrugCost = new System.Windows.Forms.Label();
            this.textBoxDrugCost = new System.Windows.Forms.TextBox();
            this.labelDrugPlace = new System.Windows.Forms.Label();
            this.textBoxDrugPlace = new System.Windows.Forms.TextBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.panelTitle.SuspendLayout();
            this.tabControlDrugLists.SuspendLayout();
            this.tabPageList.SuspendLayout();
            this.tabPageDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDrugs)).BeginInit();
            this.SuspendLayout();
            // 
            // labelMedicines
            // 
            this.labelMedicines.AutoSize = true;
            this.labelMedicines.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMedicines.Location = new System.Drawing.Point(12, 9);
            this.labelMedicines.Name = "labelMedicines";
            this.labelMedicines.Size = new System.Drawing.Size(122, 31);
            this.labelMedicines.TabIndex = 0;
            this.labelMedicines.Text = "Medicine";
            this.labelMedicines.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelTitle
            // 
            this.panelTitle.Controls.Add(this.labelMedicines);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(0, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(800, 56);
            this.panelTitle.TabIndex = 1;
            // 
            // tabControlDrugLists
            // 
            this.tabControlDrugLists.Controls.Add(this.tabPageList);
            this.tabControlDrugLists.Controls.Add(this.tabPageDetail);
            this.tabControlDrugLists.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlDrugLists.Location = new System.Drawing.Point(0, 56);
            this.tabControlDrugLists.Name = "tabControlDrugLists";
            this.tabControlDrugLists.SelectedIndex = 0;
            this.tabControlDrugLists.Size = new System.Drawing.Size(800, 394);
            this.tabControlDrugLists.TabIndex = 2;
            // 
            // tabPageList
            // 
            this.tabPageList.Controls.Add(this.buttonDelete);
            this.tabPageList.Controls.Add(this.buttonEdit);
            this.tabPageList.Controls.Add(this.buttonAdd);
            this.tabPageList.Controls.Add(this.dataGridViewDrugs);
            this.tabPageList.Controls.Add(this.buttonSearch);
            this.tabPageList.Controls.Add(this.textBoxSearch);
            this.tabPageList.Controls.Add(this.labelSearch);
            this.tabPageList.Location = new System.Drawing.Point(4, 22);
            this.tabPageList.Name = "tabPageList";
            this.tabPageList.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageList.Size = new System.Drawing.Size(792, 368);
            this.tabPageList.TabIndex = 0;
            this.tabPageList.Text = "List";
            this.tabPageList.UseVisualStyleBackColor = true;
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
            this.tabPageDetail.Location = new System.Drawing.Point(4, 22);
            this.tabPageDetail.Name = "tabPageDetail";
            this.tabPageDetail.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDetail.Size = new System.Drawing.Size(792, 368);
            this.tabPageDetail.TabIndex = 1;
            this.tabPageDetail.Text = "Detail";
            this.tabPageDetail.UseVisualStyleBackColor = true;
            // 
            // labelSearch
            // 
            this.labelSearch.AutoSize = true;
            this.labelSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSearch.Location = new System.Drawing.Point(24, 16);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(53, 17);
            this.labelSearch.TabIndex = 0;
            this.labelSearch.Text = "Search";
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(27, 37);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(581, 20);
            this.textBoxSearch.TabIndex = 1;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(615, 37);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 19);
            this.buttonSearch.TabIndex = 2;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            // 
            // dataGridViewDrugs
            // 
            this.dataGridViewDrugs.AllowUserToAddRows = false;
            this.dataGridViewDrugs.AllowUserToDeleteRows = false;
            this.dataGridViewDrugs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDrugs.Location = new System.Drawing.Point(27, 64);
            this.dataGridViewDrugs.Name = "dataGridViewDrugs";
            this.dataGridViewDrugs.ReadOnly = true;
            this.dataGridViewDrugs.Size = new System.Drawing.Size(663, 282);
            this.dataGridViewDrugs.TabIndex = 3;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(697, 64);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 4;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(697, 94);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(75, 23);
            this.buttonEdit.TabIndex = 5;
            this.buttonEdit.Text = "Edit";
            this.buttonEdit.UseVisualStyleBackColor = true;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(697, 124);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 6;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelId.Location = new System.Drawing.Point(25, 29);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(21, 17);
            this.labelId.TabIndex = 0;
            this.labelId.Text = "ID";
            // 
            // textBoxDrugId
            // 
            this.textBoxDrugId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxDrugId.Location = new System.Drawing.Point(87, 29);
            this.textBoxDrugId.Name = "textBoxDrugId";
            this.textBoxDrugId.Size = new System.Drawing.Size(176, 23);
            this.textBoxDrugId.TabIndex = 1;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelName.Location = new System.Drawing.Point(25, 100);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(45, 17);
            this.labelName.TabIndex = 2;
            this.labelName.Text = "Name";
            // 
            // textBoxDrugName
            // 
            this.textBoxDrugName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxDrugName.Location = new System.Drawing.Point(87, 99);
            this.textBoxDrugName.Name = "textBoxDrugName";
            this.textBoxDrugName.Size = new System.Drawing.Size(176, 23);
            this.textBoxDrugName.TabIndex = 3;
            // 
            // labelDrugAmount
            // 
            this.labelDrugAmount.AutoSize = true;
            this.labelDrugAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDrugAmount.Location = new System.Drawing.Point(319, 102);
            this.labelDrugAmount.Name = "labelDrugAmount";
            this.labelDrugAmount.Size = new System.Drawing.Size(56, 17);
            this.labelDrugAmount.TabIndex = 4;
            this.labelDrugAmount.Text = "Amount";
            // 
            // textBoxDrugAmount
            // 
            this.textBoxDrugAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxDrugAmount.Location = new System.Drawing.Point(381, 99);
            this.textBoxDrugAmount.Name = "textBoxDrugAmount";
            this.textBoxDrugAmount.Size = new System.Drawing.Size(176, 23);
            this.textBoxDrugAmount.TabIndex = 5;
            // 
            // labelDrugCost
            // 
            this.labelDrugCost.AutoSize = true;
            this.labelDrugCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDrugCost.Location = new System.Drawing.Point(25, 172);
            this.labelDrugCost.Name = "labelDrugCost";
            this.labelDrugCost.Size = new System.Drawing.Size(36, 17);
            this.labelDrugCost.TabIndex = 6;
            this.labelDrugCost.Text = "Cost";
            // 
            // textBoxDrugCost
            // 
            this.textBoxDrugCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxDrugCost.Location = new System.Drawing.Point(87, 172);
            this.textBoxDrugCost.Name = "textBoxDrugCost";
            this.textBoxDrugCost.Size = new System.Drawing.Size(176, 23);
            this.textBoxDrugCost.TabIndex = 7;
            // 
            // labelDrugPlace
            // 
            this.labelDrugPlace.AutoSize = true;
            this.labelDrugPlace.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDrugPlace.Location = new System.Drawing.Point(319, 175);
            this.labelDrugPlace.Name = "labelDrugPlace";
            this.labelDrugPlace.Size = new System.Drawing.Size(43, 17);
            this.labelDrugPlace.TabIndex = 8;
            this.labelDrugPlace.Text = "Place";
            // 
            // textBoxDrugPlace
            // 
            this.textBoxDrugPlace.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxDrugPlace.Location = new System.Drawing.Point(381, 174);
            this.textBoxDrugPlace.Name = "textBoxDrugPlace";
            this.textBoxDrugPlace.Size = new System.Drawing.Size(176, 23);
            this.textBoxDrugPlace.TabIndex = 9;
            // 
            // buttonSave
            // 
            this.buttonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSave.Location = new System.Drawing.Point(188, 254);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 10;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCancel.Location = new System.Drawing.Point(322, 254);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 11;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // DrugView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControlDrugLists);
            this.Controls.Add(this.panelTitle);
            this.Name = "DrugView";
            this.Text = "DrugView";
            this.panelTitle.ResumeLayout(false);
            this.panelTitle.PerformLayout();
            this.tabControlDrugLists.ResumeLayout(false);
            this.tabPageList.ResumeLayout(false);
            this.tabPageList.PerformLayout();
            this.tabPageDetail.ResumeLayout(false);
            this.tabPageDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDrugs)).EndInit();
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
    }
}