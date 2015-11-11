namespace WindowsFormsApplication1
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnBerekenen = new System.Windows.Forms.Button();
            this.tb2 = new WindowsFormsApplication1.NumericTextBox();
            this.tb1 = new WindowsFormsApplication1.NumericTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Voer 2 getallen in:";
            // 
            // btnBerekenen
            // 
            this.btnBerekenen.Location = new System.Drawing.Point(43, 51);
            this.btnBerekenen.Name = "btnBerekenen";
            this.btnBerekenen.Size = new System.Drawing.Size(75, 23);
            this.btnBerekenen.TabIndex = 1;
            this.btnBerekenen.Text = "Bereken";
            this.btnBerekenen.UseVisualStyleBackColor = true;
            this.btnBerekenen.Click += new System.EventHandler(this.btnBerekenen_Click);
            // 
            // tb2
            // 
            this.tb2.AllowSpace = false;
            this.tb2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tb2.Location = new System.Drawing.Point(81, 25);
            this.tb2.MaxLength = 50;
            this.tb2.Name = "tb2";
            this.tb2.Size = new System.Drawing.Size(53, 20);
            this.tb2.TabIndex = 2;
            this.tb2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb1
            // 
            this.tb1.AllowSpace = false;
            this.tb1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tb1.Location = new System.Drawing.Point(22, 25);
            this.tb1.MaxLength = 50;
            this.tb1.Name = "tb1";
            this.tb1.Size = new System.Drawing.Size(53, 20);
            this.tb1.TabIndex = 3;
            this.tb1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(156, 80);
            this.Controls.Add(this.tb1);
            this.Controls.Add(this.tb2);
            this.Controls.Add(this.btnBerekenen);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBerekenen;
        private NumericTextBox tb2;
        private NumericTextBox tb1;
    }
}

