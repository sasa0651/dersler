namespace atmform
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.ekran = new System.Windows.Forms.Label();
            this.tus = new System.Windows.Forms.TextBox();
            this.parayatir = new System.Windows.Forms.Button();
            this.paracek = new System.Windows.Forms.Button();
            this.paragonder = new System.Windows.Forms.Button();
            this.onayla = new System.Windows.Forms.Button();
            this.bakiye = new System.Windows.Forms.Button();
            this.cıkıs = new System.Windows.Forms.Button();
            this.giris = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ekran
            // 
            this.ekran.AutoSize = true;
            this.ekran.Location = new System.Drawing.Point(183, 58);
            this.ekran.Name = "ekran";
            this.ekran.Size = new System.Drawing.Size(102, 20);
            this.ekran.TabIndex = 0;
            this.ekran.Text = "Hoşgeldiniz";
            // 
            // tus
            // 
            this.tus.Location = new System.Drawing.Point(187, 138);
            this.tus.Name = "tus";
            this.tus.Size = new System.Drawing.Size(201, 26);
            this.tus.TabIndex = 1;
            // 
            // parayatir
            // 
            this.parayatir.Location = new System.Drawing.Point(12, 138);
            this.parayatir.Name = "parayatir";
            this.parayatir.Size = new System.Drawing.Size(124, 39);
            this.parayatir.TabIndex = 2;
            this.parayatir.Text = "Para Yatır";
            this.parayatir.UseVisualStyleBackColor = true;
            this.parayatir.Click += new System.EventHandler(this.parayatir_Click_1);
            // 
            // paracek
            // 
            this.paracek.Location = new System.Drawing.Point(12, 192);
            this.paracek.Name = "paracek";
            this.paracek.Size = new System.Drawing.Size(124, 39);
            this.paracek.TabIndex = 2;
            this.paracek.Text = "Para Çek";
            this.paracek.UseVisualStyleBackColor = true;
            this.paracek.Click += new System.EventHandler(this.paracek_Click);
            // 
            // paragonder
            // 
            this.paragonder.Location = new System.Drawing.Point(12, 249);
            this.paragonder.Name = "paragonder";
            this.paragonder.Size = new System.Drawing.Size(124, 39);
            this.paragonder.TabIndex = 2;
            this.paragonder.Text = "Para Gönder";
            this.paragonder.UseVisualStyleBackColor = true;
            // 
            // onayla
            // 
            this.onayla.Location = new System.Drawing.Point(228, 181);
            this.onayla.Name = "onayla";
            this.onayla.Size = new System.Drawing.Size(124, 39);
            this.onayla.TabIndex = 2;
            this.onayla.Text = "Onayla";
            this.onayla.UseVisualStyleBackColor = true;
            this.onayla.Click += new System.EventHandler(this.onayla_Click);
            // 
            // bakiye
            // 
            this.bakiye.Location = new System.Drawing.Point(448, 192);
            this.bakiye.Name = "bakiye";
            this.bakiye.Size = new System.Drawing.Size(124, 39);
            this.bakiye.TabIndex = 2;
            this.bakiye.Text = "Bakiye";
            this.bakiye.UseVisualStyleBackColor = true;
            this.bakiye.Click += new System.EventHandler(this.bakiye_Click);
            // 
            // cıkıs
            // 
            this.cıkıs.Location = new System.Drawing.Point(448, 249);
            this.cıkıs.Name = "cıkıs";
            this.cıkıs.Size = new System.Drawing.Size(124, 39);
            this.cıkıs.TabIndex = 2;
            this.cıkıs.Text = "Çıkış";
            this.cıkıs.UseVisualStyleBackColor = true;
            this.cıkıs.Click += new System.EventHandler(this.cıkıs_Click);
            // 
            // giris
            // 
            this.giris.Location = new System.Drawing.Point(448, 138);
            this.giris.Name = "giris";
            this.giris.Size = new System.Drawing.Size(124, 39);
            this.giris.TabIndex = 3;
            this.giris.Text = "Ana Menü";
            this.giris.UseVisualStyleBackColor = true;
            this.giris.Click += new System.EventHandler(this.giris_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(584, 311);
            this.Controls.Add(this.giris);
            this.Controls.Add(this.cıkıs);
            this.Controls.Add(this.paragonder);
            this.Controls.Add(this.bakiye);
            this.Controls.Add(this.paracek);
            this.Controls.Add(this.onayla);
            this.Controls.Add(this.parayatir);
            this.Controls.Add(this.tus);
            this.Controls.Add(this.ekran);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ATM";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ekran;
        private System.Windows.Forms.TextBox tus;
        private System.Windows.Forms.Button parayatir;
        private System.Windows.Forms.Button paracek;
        private System.Windows.Forms.Button paragonder;
        private System.Windows.Forms.Button onayla;
        private System.Windows.Forms.Button bakiye;
        private System.Windows.Forms.Button cıkıs;
        private System.Windows.Forms.Button giris;
    }
}

