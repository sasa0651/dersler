namespace atmform
{
    partial class Form2
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
            this.ekran1 = new System.Windows.Forms.Label();
            this.tus1 = new System.Windows.Forms.TextBox();
            this.onay1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ekran1
            // 
            this.ekran1.AutoSize = true;
            this.ekran1.Location = new System.Drawing.Point(184, 66);
            this.ekran1.Name = "ekran1";
            this.ekran1.Size = new System.Drawing.Size(205, 20);
            this.ekran1.TabIndex = 0;
            this.ekran1.Text = "Merhaba Şifrenizi Giriniz";
            // 
            // tus1
            // 
            this.tus1.Location = new System.Drawing.Point(188, 118);
            this.tus1.Name = "tus1";
            this.tus1.Size = new System.Drawing.Size(201, 26);
            this.tus1.TabIndex = 1;
            // 
            // onay1
            // 
            this.onay1.Location = new System.Drawing.Point(233, 172);
            this.onay1.Name = "onay1";
            this.onay1.Size = new System.Drawing.Size(110, 45);
            this.onay1.TabIndex = 2;
            this.onay1.Text = "Onay";
            this.onay1.UseVisualStyleBackColor = true;
            this.onay1.Click += new System.EventHandler(this.onay1_Click);
         
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(584, 311);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.onay1);
            this.Controls.Add(this.tus1);
            this.Controls.Add(this.ekran1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ATM";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ekran1;
        private System.Windows.Forms.TextBox tus1;
        private System.Windows.Forms.Button onay1;
        private System.Windows.Forms.Label label1;
    }
}