namespace DelegatesDemo
{
    partial class DelegateDemoUI
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
            this.ReturnDataLable = new System.Windows.Forms.Label();
            this.ReturnDataTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ReturnDataLable
            // 
            this.ReturnDataLable.AutoSize = true;
            this.ReturnDataLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReturnDataLable.Location = new System.Drawing.Point(34, 28);
            this.ReturnDataLable.Name = "ReturnDataLable";
            this.ReturnDataLable.Size = new System.Drawing.Size(127, 25);
            this.ReturnDataLable.TabIndex = 0;
            this.ReturnDataLable.Text = "Return Data";
            // 
            // ReturnDataTextBox
            // 
            this.ReturnDataTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReturnDataTextBox.Location = new System.Drawing.Point(196, 28);
            this.ReturnDataTextBox.Name = "ReturnDataTextBox";
            this.ReturnDataTextBox.ReadOnly = true;
            this.ReturnDataTextBox.Size = new System.Drawing.Size(212, 31);
            this.ReturnDataTextBox.TabIndex = 1;
            this.ReturnDataTextBox.Text = "Test Text";
            // 
            // DelegateDemoUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 497);
            this.Controls.Add(this.ReturnDataTextBox);
            this.Controls.Add(this.ReturnDataLable);
            this.Name = "DelegateDemoUI";
            this.Text = "DelegateDemoLibrary";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ReturnDataLable;
        private System.Windows.Forms.TextBox ReturnDataTextBox;
    }
}

