namespace Pharmacy.Views
{
    partial class PharmacyView
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
            this.panelViews = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // panelViews
            // 
            this.panelViews.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelViews.Location = new System.Drawing.Point(0, 0);
            this.panelViews.Name = "panelViews";
            this.panelViews.Size = new System.Drawing.Size(800, 450);
            this.panelViews.TabIndex = 1;
            // 
            // PharmacyView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelViews);
            this.Name = "PharmacyView";
            this.Text = "Pharmacy";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelViews;
    }
}