namespace Balasagun_Pansiyon_ve_Dinlenme_Tesisleri
{
    partial class FrmSifreGuncelle
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
            this.BtnGuncelle = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtSifre = new System.Windows.Forms.TextBox();
            this.TxtKullaniciAdi = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(55, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "Kullanıcı Adı :";
            // 
            // BtnGuncelle
            // 
            this.BtnGuncelle.BackColor = System.Drawing.Color.Lime;
            this.BtnGuncelle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnGuncelle.Location = new System.Drawing.Point(219, 227);
            this.BtnGuncelle.Name = "BtnGuncelle";
            this.BtnGuncelle.Size = new System.Drawing.Size(142, 40);
            this.BtnGuncelle.TabIndex = 9;
            this.BtnGuncelle.Text = "Güncelle";
            this.BtnGuncelle.UseVisualStyleBackColor = false;
            this.BtnGuncelle.Click += new System.EventHandler(this.BtnGuncelle_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(54, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 21);
            this.label2.TabIndex = 6;
            this.label2.Text = "Şifre :";
            // 
            // TxtSifre
            // 
            this.TxtSifre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.TxtSifre.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtSifre.Location = new System.Drawing.Point(200, 166);
            this.TxtSifre.Name = "TxtSifre";
            this.TxtSifre.Size = new System.Drawing.Size(183, 25);
            this.TxtSifre.TabIndex = 8;
            this.TxtSifre.UseSystemPasswordChar = true;
            // 
            // TxtKullaniciAdi
            // 
            this.TxtKullaniciAdi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.TxtKullaniciAdi.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtKullaniciAdi.Location = new System.Drawing.Point(200, 109);
            this.TxtKullaniciAdi.Name = "TxtKullaniciAdi";
            this.TxtKullaniciAdi.Size = new System.Drawing.Size(183, 25);
            this.TxtKullaniciAdi.TabIndex = 7;
            // 
            // FrmSifreGuncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(471, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnGuncelle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtSifre);
            this.Controls.Add(this.TxtKullaniciAdi);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmSifreGuncelle";
            this.Text = "Sifre Guncelle";
            this.Load += new System.EventHandler(this.FrmSifreGuncelle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnGuncelle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtSifre;
        private System.Windows.Forms.TextBox TxtKullaniciAdi;
    }
}