namespace Balasagun_Pansiyon_ve_Dinlenme_Tesisleri
{
    partial class FrmStoklar
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtGidalar = new System.Windows.Forms.TextBox();
            this.Txtİcecekler = new System.Windows.Forms.TextBox();
            this.TxtAtistirmaliklar = new System.Windows.Forms.TextBox();
            this.BtnKaydet = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(29, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gıda Tutarı :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(29, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "İçecek  Tutarı :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(29, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Atıştırmalıklar :";
            // 
            // TxtGidalar
            // 
            this.TxtGidalar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtGidalar.Location = new System.Drawing.Point(215, 40);
            this.TxtGidalar.Name = "TxtGidalar";
            this.TxtGidalar.Size = new System.Drawing.Size(165, 25);
            this.TxtGidalar.TabIndex = 3;
            // 
            // Txtİcecekler
            // 
            this.Txtİcecekler.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Txtİcecekler.Location = new System.Drawing.Point(215, 92);
            this.Txtİcecekler.Name = "Txtİcecekler";
            this.Txtİcecekler.Size = new System.Drawing.Size(165, 25);
            this.Txtİcecekler.TabIndex = 4;
            // 
            // TxtAtistirmaliklar
            // 
            this.TxtAtistirmaliklar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtAtistirmaliklar.Location = new System.Drawing.Point(215, 143);
            this.TxtAtistirmaliklar.Name = "TxtAtistirmaliklar";
            this.TxtAtistirmaliklar.Size = new System.Drawing.Size(165, 25);
            this.TxtAtistirmaliklar.TabIndex = 5;
            // 
            // BtnKaydet
            // 
            this.BtnKaydet.BackColor = System.Drawing.Color.Lime;
            this.BtnKaydet.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnKaydet.Location = new System.Drawing.Point(244, 201);
            this.BtnKaydet.Name = "BtnKaydet";
            this.BtnKaydet.Size = new System.Drawing.Size(95, 34);
            this.BtnKaydet.TabIndex = 6;
            this.BtnKaydet.Text = "KAYDET";
            this.BtnKaydet.UseVisualStyleBackColor = false;
            this.BtnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(-1, 278);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(548, 172);
            this.listView1.TabIndex = 7;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Gıdalar";
            this.columnHeader1.Width = 159;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "İçecekler";
            this.columnHeader2.Width = 222;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Atıştırmalıklar";
            this.columnHeader3.Width = 425;
            // 
            // FrmStoklar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(547, 450);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.BtnKaydet);
            this.Controls.Add(this.TxtAtistirmaliklar);
            this.Controls.Add(this.Txtİcecekler);
            this.Controls.Add(this.TxtGidalar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmStoklar";
            this.Text = "FrmStoklar";
            this.Load += new System.EventHandler(this.FrmStoklar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtGidalar;
        private System.Windows.Forms.TextBox Txtİcecekler;
        private System.Windows.Forms.TextBox TxtAtistirmaliklar;
        private System.Windows.Forms.Button BtnKaydet;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}