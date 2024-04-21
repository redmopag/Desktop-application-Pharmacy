namespace Pharmacy.Views.MainView
{
    partial class MainView
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
            this.panelControl = new System.Windows.Forms.Panel();
            this.buttonExit = new System.Windows.Forms.Button();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.buttonSuppliers = new System.Windows.Forms.Button();
            this.buttonDrugs = new System.Windows.Forms.Button();
            this.panelViews = new System.Windows.Forms.Panel();
            this.buttonPayment = new System.Windows.Forms.Button();
            this.buttonOrder = new System.Windows.Forms.Button();
            this.panelControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl
            // 
            this.panelControl.BackColor = System.Drawing.Color.Transparent;
            this.panelControl.Controls.Add(this.buttonOrder);
            this.panelControl.Controls.Add(this.buttonPayment);
            this.panelControl.Controls.Add(this.buttonExit);
            this.panelControl.Controls.Add(this.pictureBoxLogo);
            this.panelControl.Controls.Add(this.buttonSuppliers);
            this.panelControl.Controls.Add(this.buttonDrugs);
            this.panelControl.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelControl.Location = new System.Drawing.Point(0, 0);
            this.panelControl.Name = "panelControl";
            this.panelControl.Size = new System.Drawing.Size(200, 450);
            this.panelControl.TabIndex = 1;
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.LightGray;
            this.buttonExit.FlatAppearance.BorderSize = 0;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.Location = new System.Drawing.Point(0, 412);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(200, 38);
            this.buttonExit.TabIndex = 3;
            this.buttonExit.Text = "<----";
            this.buttonExit.UseVisualStyleBackColor = false;
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxLogo.Image = global::Pharmacy.Properties.Resources.Capsule;
            this.pictureBoxLogo.Location = new System.Drawing.Point(23, 0);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(151, 116);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogo.TabIndex = 2;
            this.pictureBoxLogo.TabStop = false;
            // 
            // buttonSuppliers
            // 
            this.buttonSuppliers.BackColor = System.Drawing.Color.Green;
            this.buttonSuppliers.FlatAppearance.BorderSize = 0;
            this.buttonSuppliers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSuppliers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSuppliers.Location = new System.Drawing.Point(0, 206);
            this.buttonSuppliers.Name = "buttonSuppliers";
            this.buttonSuppliers.Size = new System.Drawing.Size(200, 39);
            this.buttonSuppliers.TabIndex = 1;
            this.buttonSuppliers.Text = "Поставщики";
            this.buttonSuppliers.UseVisualStyleBackColor = false;
            // 
            // buttonDrugs
            // 
            this.buttonDrugs.BackColor = System.Drawing.Color.Green;
            this.buttonDrugs.FlatAppearance.BorderSize = 0;
            this.buttonDrugs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDrugs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDrugs.Location = new System.Drawing.Point(0, 161);
            this.buttonDrugs.Name = "buttonDrugs";
            this.buttonDrugs.Size = new System.Drawing.Size(200, 39);
            this.buttonDrugs.TabIndex = 0;
            this.buttonDrugs.Text = "Лекарства";
            this.buttonDrugs.UseVisualStyleBackColor = false;
            // 
            // panelViews
            // 
            this.panelViews.BackColor = System.Drawing.Color.Transparent;
            this.panelViews.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelViews.Location = new System.Drawing.Point(200, 0);
            this.panelViews.Name = "panelViews";
            this.panelViews.Size = new System.Drawing.Size(600, 450);
            this.panelViews.TabIndex = 2;
            // 
            // buttonPayment
            // 
            this.buttonPayment.BackColor = System.Drawing.Color.Green;
            this.buttonPayment.FlatAppearance.BorderSize = 0;
            this.buttonPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPayment.Location = new System.Drawing.Point(0, 251);
            this.buttonPayment.Name = "buttonPayment";
            this.buttonPayment.Size = new System.Drawing.Size(200, 39);
            this.buttonPayment.TabIndex = 4;
            this.buttonPayment.Text = "Оплата";
            this.buttonPayment.UseVisualStyleBackColor = false;
            // 
            // buttonOrder
            // 
            this.buttonOrder.BackColor = System.Drawing.Color.Green;
            this.buttonOrder.FlatAppearance.BorderSize = 0;
            this.buttonOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOrder.Location = new System.Drawing.Point(0, 296);
            this.buttonOrder.Name = "buttonOrder";
            this.buttonOrder.Size = new System.Drawing.Size(200, 39);
            this.buttonOrder.TabIndex = 5;
            this.buttonOrder.Text = "Поставки";
            this.buttonOrder.UseVisualStyleBackColor = false;
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelViews);
            this.Controls.Add(this.panelControl);
            this.Name = "MainView";
            this.Text = "MainView";
            this.panelControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelControl;
        private System.Windows.Forms.Button buttonSuppliers;
        private System.Windows.Forms.Button buttonDrugs;
        private System.Windows.Forms.Panel panelViews;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonOrder;
        private System.Windows.Forms.Button buttonPayment;
    }
}