
namespace StokTakipOpomasyonu
{
    partial class FrmSatis
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.txtTc = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMiktar = new System.Windows.Forms.TextBox();
            this.txtToplamFiyat = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBarkodNo = new System.Windows.Forms.TextBox();
            this.txtSatisFiyati = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUrunAdi = new System.Windows.Forms.TextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnSatisYap = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnSatisIptal = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.lblGenelToplam = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnKategori = new System.Windows.Forms.Button();
            this.btnMarka = new System.Windows.Forms.Button();
            this.btnSatisleriListele = new System.Windows.Forms.Button();
            this.btnUrunListeleme = new System.Windows.Forms.Button();
            this.btnUrunEkle = new System.Windows.Forms.Button();
            this.btnMusteriListeleme = new System.Windows.Forms.Button();
            this.btnMusteriEkle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(283, 133);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(430, 307);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtTelefon);
            this.groupBox1.Controls.Add(this.txtAdSoyad);
            this.groupBox1.Controls.Add(this.txtTc);
            this.groupBox1.Location = new System.Drawing.Point(17, 157);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 163);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Musteri Islemleri";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 112);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Telefon";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ad Soyad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tc";
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(79, 116);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(100, 20);
            this.txtTelefon.TabIndex = 0;
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.Location = new System.Drawing.Point(79, 81);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(100, 20);
            this.txtAdSoyad.TabIndex = 0;
            // 
            // txtTc
            // 
            this.txtTc.Location = new System.Drawing.Point(79, 46);
            this.txtTc.Name = "txtTc";
            this.txtTc.Size = new System.Drawing.Size(100, 20);
            this.txtTc.TabIndex = 0;
            this.txtTc.TextChanged += new System.EventHandler(this.txtTc_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtMiktar);
            this.groupBox2.Controls.Add(this.txtToplamFiyat);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtBarkodNo);
            this.groupBox2.Controls.Add(this.txtSatisFiyati);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtUrunAdi);
            this.groupBox2.Location = new System.Drawing.Point(17, 374);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 169);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Urun Islemleri";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 137);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Toplam Fiyat";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Satis Fiyati";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Urun Adi";
            // 
            // txtMiktar
            // 
            this.txtMiktar.Location = new System.Drawing.Point(79, 80);
            this.txtMiktar.Name = "txtMiktar";
            this.txtMiktar.Size = new System.Drawing.Size(100, 20);
            this.txtMiktar.TabIndex = 0;
            this.txtMiktar.Text = "1";
            this.txtMiktar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtMiktar.TextChanged += new System.EventHandler(this.txtMiktar_TextChanged);
            // 
            // txtToplamFiyat
            // 
            this.txtToplamFiyat.Location = new System.Drawing.Point(79, 134);
            this.txtToplamFiyat.Name = "txtToplamFiyat";
            this.txtToplamFiyat.Size = new System.Drawing.Size(100, 20);
            this.txtToplamFiyat.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Miktar";
            // 
            // txtBarkodNo
            // 
            this.txtBarkodNo.Location = new System.Drawing.Point(79, 19);
            this.txtBarkodNo.Name = "txtBarkodNo";
            this.txtBarkodNo.Size = new System.Drawing.Size(100, 20);
            this.txtBarkodNo.TabIndex = 0;
            this.txtBarkodNo.TextChanged += new System.EventHandler(this.txtBarkodNo_TextChanged);
            // 
            // txtSatisFiyati
            // 
            this.txtSatisFiyati.Location = new System.Drawing.Point(79, 108);
            this.txtSatisFiyati.Name = "txtSatisFiyati";
            this.txtSatisFiyati.Size = new System.Drawing.Size(100, 20);
            this.txtSatisFiyati.TabIndex = 0;
            this.txtSatisFiyati.TextChanged += new System.EventHandler(this.txtSatisFiyati_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "BarkodNo";
            // 
            // txtUrunAdi
            // 
            this.txtUrunAdi.Location = new System.Drawing.Point(79, 50);
            this.txtUrunAdi.Name = "txtUrunAdi";
            this.txtUrunAdi.Size = new System.Drawing.Size(100, 20);
            this.txtUrunAdi.TabIndex = 0;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(283, 448);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 31);
            this.btnEkle.TabIndex = 3;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnSatisYap
            // 
            this.btnSatisYap.Location = new System.Drawing.Point(638, 444);
            this.btnSatisYap.Name = "btnSatisYap";
            this.btnSatisYap.Size = new System.Drawing.Size(75, 31);
            this.btnSatisYap.TabIndex = 3;
            this.btnSatisYap.Text = "Satis Yap";
            this.btnSatisYap.UseVisualStyleBackColor = true;
            this.btnSatisYap.Click += new System.EventHandler(this.btnSatisYap_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(719, 137);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 42);
            this.btnSil.TabIndex = 3;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnSatisIptal
            // 
            this.btnSatisIptal.Location = new System.Drawing.Point(719, 193);
            this.btnSatisIptal.Name = "btnSatisIptal";
            this.btnSatisIptal.Size = new System.Drawing.Size(75, 38);
            this.btnSatisIptal.TabIndex = 3;
            this.btnSatisIptal.Text = "Satis Iptal";
            this.btnSatisIptal.UseVisualStyleBackColor = true;
            this.btnSatisIptal.Click += new System.EventHandler(this.btnSatisIptal_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(434, 457);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "Genel Toplam";
            // 
            // lblGenelToplam
            // 
            this.lblGenelToplam.AutoSize = true;
            this.lblGenelToplam.Location = new System.Drawing.Point(525, 457);
            this.lblGenelToplam.Name = "lblGenelToplam";
            this.lblGenelToplam.Size = new System.Drawing.Size(0, 13);
            this.lblGenelToplam.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnKategori);
            this.panel1.Controls.Add(this.btnMarka);
            this.panel1.Controls.Add(this.btnSatisleriListele);
            this.panel1.Controls.Add(this.btnUrunListeleme);
            this.panel1.Controls.Add(this.btnUrunEkle);
            this.panel1.Controls.Add(this.btnMusteriListeleme);
            this.panel1.Controls.Add(this.btnMusteriEkle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(830, 100);
            this.panel1.TabIndex = 6;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnKategori
            // 
            this.btnKategori.Location = new System.Drawing.Point(691, 28);
            this.btnKategori.Name = "btnKategori";
            this.btnKategori.Size = new System.Drawing.Size(75, 44);
            this.btnKategori.TabIndex = 1;
            this.btnKategori.Text = "Kategori";
            this.btnKategori.UseVisualStyleBackColor = true;
            this.btnKategori.Click += new System.EventHandler(this.btnKategori_Click);
            // 
            // btnMarka
            // 
            this.btnMarka.Location = new System.Drawing.Point(586, 28);
            this.btnMarka.Name = "btnMarka";
            this.btnMarka.Size = new System.Drawing.Size(75, 44);
            this.btnMarka.TabIndex = 1;
            this.btnMarka.Text = "Marka";
            this.btnMarka.UseVisualStyleBackColor = true;
            this.btnMarka.Click += new System.EventHandler(this.btnMarka_Click);
            // 
            // btnSatisleriListele
            // 
            this.btnSatisleriListele.Location = new System.Drawing.Point(485, 28);
            this.btnSatisleriListele.Name = "btnSatisleriListele";
            this.btnSatisleriListele.Size = new System.Drawing.Size(75, 44);
            this.btnSatisleriListele.TabIndex = 0;
            this.btnSatisleriListele.Text = "Satisleri Listele";
            this.btnSatisleriListele.UseVisualStyleBackColor = true;
            this.btnSatisleriListele.Click += new System.EventHandler(this.btnSatisleriListele_Click);
            // 
            // btnUrunListeleme
            // 
            this.btnUrunListeleme.Location = new System.Drawing.Point(362, 28);
            this.btnUrunListeleme.Name = "btnUrunListeleme";
            this.btnUrunListeleme.Size = new System.Drawing.Size(75, 44);
            this.btnUrunListeleme.TabIndex = 0;
            this.btnUrunListeleme.Text = "Urun Listeleme";
            this.btnUrunListeleme.UseVisualStyleBackColor = true;
            this.btnUrunListeleme.Click += new System.EventHandler(this.btnUrunListeleme_Click);
            // 
            // btnUrunEkle
            // 
            this.btnUrunEkle.Location = new System.Drawing.Point(270, 28);
            this.btnUrunEkle.Name = "btnUrunEkle";
            this.btnUrunEkle.Size = new System.Drawing.Size(75, 44);
            this.btnUrunEkle.TabIndex = 0;
            this.btnUrunEkle.Text = "Urun Ekle";
            this.btnUrunEkle.UseVisualStyleBackColor = true;
            this.btnUrunEkle.Click += new System.EventHandler(this.btnUrunEkle_Click);
            // 
            // btnMusteriListeleme
            // 
            this.btnMusteriListeleme.Location = new System.Drawing.Point(106, 28);
            this.btnMusteriListeleme.Name = "btnMusteriListeleme";
            this.btnMusteriListeleme.Size = new System.Drawing.Size(75, 44);
            this.btnMusteriListeleme.TabIndex = 0;
            this.btnMusteriListeleme.Text = "Musteri Listeleme";
            this.btnMusteriListeleme.UseVisualStyleBackColor = true;
            this.btnMusteriListeleme.Click += new System.EventHandler(this.btnMusteriListeleme_Click);
            // 
            // btnMusteriEkle
            // 
            this.btnMusteriEkle.Location = new System.Drawing.Point(15, 28);
            this.btnMusteriEkle.Name = "btnMusteriEkle";
            this.btnMusteriEkle.Size = new System.Drawing.Size(75, 44);
            this.btnMusteriEkle.TabIndex = 0;
            this.btnMusteriEkle.Text = "Musteri Ekle";
            this.btnMusteriEkle.UseVisualStyleBackColor = true;
            this.btnMusteriEkle.Click += new System.EventHandler(this.btnMusteriEkle_Click);
            // 
            // FrmSatis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(830, 563);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblGenelToplam);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnSatisIptal);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnSatisYap);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FrmSatis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Satis Sayfasi";
            this.Load += new System.EventHandler(this.FrmSatis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.TextBox txtAdSoyad;
        private System.Windows.Forms.TextBox txtTc;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMiktar;
        private System.Windows.Forms.TextBox txtToplamFiyat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBarkodNo;
        private System.Windows.Forms.TextBox txtSatisFiyati;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUrunAdi;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnSatisYap;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnSatisIptal;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblGenelToplam;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSatisleriListele;
        private System.Windows.Forms.Button btnUrunListeleme;
        private System.Windows.Forms.Button btnUrunEkle;
        private System.Windows.Forms.Button btnMusteriListeleme;
        private System.Windows.Forms.Button btnMusteriEkle;
        private System.Windows.Forms.Button btnKategori;
        private System.Windows.Forms.Button btnMarka;
    }
}

