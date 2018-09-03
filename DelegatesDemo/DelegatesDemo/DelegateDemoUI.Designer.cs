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
            this.PreTotalDataLable = new System.Windows.Forms.Label();
            this.PreTotalTextBox = new System.Windows.Forms.TextBox();
            this.TotalLable = new System.Windows.Forms.Label();
            this.TotalTextBox = new System.Windows.Forms.TextBox();
            this.DelegateDemoLable = new System.Windows.Forms.Label();
            this.TotalTextBoxBtn = new System.Windows.Forms.Button();
            this.TotalAlertBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PreTotalDataLable
            // 
            this.PreTotalDataLable.AutoSize = true;
            this.PreTotalDataLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PreTotalDataLable.Location = new System.Drawing.Point(17, 125);
            this.PreTotalDataLable.Name = "PreTotalDataLable";
            this.PreTotalDataLable.Size = new System.Drawing.Size(105, 25);
            this.PreTotalDataLable.TabIndex = 0;
            this.PreTotalDataLable.Text = "Sub-Total";
            // 
            // PreTotalTextBox
            // 
            this.PreTotalTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PreTotalTextBox.Location = new System.Drawing.Point(128, 122);
            this.PreTotalTextBox.Name = "PreTotalTextBox";
            this.PreTotalTextBox.ReadOnly = true;
            this.PreTotalTextBox.Size = new System.Drawing.Size(212, 31);
            this.PreTotalTextBox.TabIndex = 1;
            this.PreTotalTextBox.Text = "Test Text";
            this.PreTotalTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TotalLable
            // 
            this.TotalLable.AutoSize = true;
            this.TotalLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalLable.Location = new System.Drawing.Point(17, 180);
            this.TotalLable.Name = "TotalLable";
            this.TotalLable.Size = new System.Drawing.Size(60, 25);
            this.TotalLable.TabIndex = 0;
            this.TotalLable.Text = "Total";
            // 
            // TotalTextBox
            // 
            this.TotalTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalTextBox.Location = new System.Drawing.Point(128, 177);
            this.TotalTextBox.Name = "TotalTextBox";
            this.TotalTextBox.ReadOnly = true;
            this.TotalTextBox.Size = new System.Drawing.Size(212, 31);
            this.TotalTextBox.TabIndex = 1;
            this.TotalTextBox.Text = "Test Total";
            this.TotalTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TotalTextBox.TextChanged += new System.EventHandler(this.TotalTextBox_TextChanged);
            // 
            // DelegateDemoLable
            // 
            this.DelegateDemoLable.AutoSize = true;
            this.DelegateDemoLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DelegateDemoLable.Location = new System.Drawing.Point(44, 45);
            this.DelegateDemoLable.Name = "DelegateDemoLable";
            this.DelegateDemoLable.Size = new System.Drawing.Size(270, 39);
            this.DelegateDemoLable.TabIndex = 2;
            this.DelegateDemoLable.Text = "Delegate Demo";
            // 
            // TotalTextBoxBtn
            // 
            this.TotalTextBoxBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.TotalTextBoxBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalTextBoxBtn.Location = new System.Drawing.Point(22, 247);
            this.TotalTextBoxBtn.Name = "TotalTextBoxBtn";
            this.TotalTextBoxBtn.Size = new System.Drawing.Size(149, 53);
            this.TotalTextBoxBtn.TabIndex = 3;
            this.TotalTextBoxBtn.Text = "Total In Cart \r\nText Box";
            this.TotalTextBoxBtn.UseVisualStyleBackColor = true;
            this.TotalTextBoxBtn.Click += new System.EventHandler(this.TotalTextBoxBtn_Click);
            // 
            // TotalAlertBtn
            // 
            this.TotalAlertBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.TotalAlertBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalAlertBtn.Location = new System.Drawing.Point(191, 247);
            this.TotalAlertBtn.Name = "TotalAlertBtn";
            this.TotalAlertBtn.Size = new System.Drawing.Size(149, 53);
            this.TotalAlertBtn.TabIndex = 3;
            this.TotalAlertBtn.Text = "Total In Cart \r\nAlert";
            this.TotalAlertBtn.UseVisualStyleBackColor = true;
            this.TotalAlertBtn.Click += new System.EventHandler(this.TotalAlertBtn_Click);
            // 
            // DelegateDemoUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 322);
            this.Controls.Add(this.TotalAlertBtn);
            this.Controls.Add(this.TotalTextBoxBtn);
            this.Controls.Add(this.DelegateDemoLable);
            this.Controls.Add(this.TotalTextBox);
            this.Controls.Add(this.TotalLable);
            this.Controls.Add(this.PreTotalTextBox);
            this.Controls.Add(this.PreTotalDataLable);
            this.Name = "DelegateDemoUI";
            this.Text = "DelegateDemoLibrary";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PreTotalDataLable;
        private System.Windows.Forms.TextBox PreTotalTextBox;
        private System.Windows.Forms.Label TotalLable;
        private System.Windows.Forms.TextBox TotalTextBox;
        private System.Windows.Forms.Label DelegateDemoLable;
        private System.Windows.Forms.Button TotalTextBoxBtn;
        private System.Windows.Forms.Button TotalAlertBtn;
    }
}

