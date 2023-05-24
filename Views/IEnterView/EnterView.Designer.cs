namespace Pharmacy.Views.IEnterView
{
    partial class EnterView
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
            this.textBoxEnterName = new System.Windows.Forms.TextBox();
            this.textBoxEnterPassword = new System.Windows.Forms.TextBox();
            this.buttonEnter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxEnterName
            // 
            this.textBoxEnterName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxEnterName.Location = new System.Drawing.Point(261, 145);
            this.textBoxEnterName.Name = "textBoxEnterName";
            this.textBoxEnterName.Size = new System.Drawing.Size(257, 26);
            this.textBoxEnterName.TabIndex = 0;
            // 
            // textBoxEnterPassword
            // 
            this.textBoxEnterPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxEnterPassword.Location = new System.Drawing.Point(261, 189);
            this.textBoxEnterPassword.Name = "textBoxEnterPassword";
            this.textBoxEnterPassword.Size = new System.Drawing.Size(257, 26);
            this.textBoxEnterPassword.TabIndex = 1;
            // 
            // buttonEnter
            // 
            this.buttonEnter.AutoSize = true;
            this.buttonEnter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonEnter.Location = new System.Drawing.Point(328, 230);
            this.buttonEnter.Name = "buttonEnter";
            this.buttonEnter.Size = new System.Drawing.Size(126, 30);
            this.buttonEnter.TabIndex = 2;
            this.buttonEnter.Text = "Enter";
            this.buttonEnter.UseVisualStyleBackColor = true;
            // 
            // EnterView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonEnter);
            this.Controls.Add(this.textBoxEnterPassword);
            this.Controls.Add(this.textBoxEnterName);
            this.Name = "EnterView";
            this.Text = "EnterView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxEnterName;
        private System.Windows.Forms.TextBox textBoxEnterPassword;
        private System.Windows.Forms.Button buttonEnter;
    }
}