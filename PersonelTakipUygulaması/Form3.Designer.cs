
namespace PersonelTakipUygulaması
{
    partial class Form3
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.lblVeriSayisi = new System.Windows.Forms.Label();
            this.btnCikis = new System.Windows.Forms.Button();
            this.txtFiltreAd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFiltreSoyad = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblKullanici = new System.Windows.Forms.Label();
            this.lblYetki = new System.Windows.Forms.Label();
            this.btnMaasGoster = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.gbMaasGoster = new System.Windows.Forms.GroupBox();
            this.label26 = new System.Windows.Forms.Label();
            this.btnMaas = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSifreMaas = new System.Windows.Forms.TextBox();
            this.gbSifreDegistir = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtYeniSifre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEskiSifre = new System.Windows.Forms.TextBox();
            this.lblMaasBilgileri = new System.Windows.Forms.Label();
            this.cbSifreGoster = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtYeniSifreTekrar = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gbMaasGoster.SuspendLayout();
            this.gbSifreDegistir.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(541, 280);
            this.dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 348);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 42);
            this.button1.TabIndex = 1;
            this.button1.Text = "Kayıtları Yenile";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lblVeriSayisi
            // 
            this.lblVeriSayisi.AutoSize = true;
            this.lblVeriSayisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVeriSayisi.Location = new System.Drawing.Point(409, 311);
            this.lblVeriSayisi.Name = "lblVeriSayisi";
            this.lblVeriSayisi.Size = new System.Drawing.Size(144, 20);
            this.lblVeriSayisi.TabIndex = 2;
            this.lblVeriSayisi.Text = "Kayıt Gösteriliyor";
            // 
            // btnCikis
            // 
            this.btnCikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCikis.ForeColor = System.Drawing.Color.Red;
            this.btnCikis.Location = new System.Drawing.Point(489, 362);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(64, 28);
            this.btnCikis.TabIndex = 3;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // txtFiltreAd
            // 
            this.txtFiltreAd.Location = new System.Drawing.Point(53, 311);
            this.txtFiltreAd.Name = "txtFiltreAd";
            this.txtFiltreAd.Size = new System.Drawing.Size(122, 20);
            this.txtFiltreAd.TabIndex = 4;
            this.txtFiltreAd.TextChanged += new System.EventHandler(this.txtFiltreAd_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 314);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Filtre";
            // 
            // txtFiltreSoyad
            // 
            this.txtFiltreSoyad.Location = new System.Drawing.Point(181, 311);
            this.txtFiltreSoyad.Name = "txtFiltreSoyad";
            this.txtFiltreSoyad.Size = new System.Drawing.Size(122, 20);
            this.txtFiltreSoyad.TabIndex = 6;
            this.txtFiltreSoyad.TextChanged += new System.EventHandler(this.txtFiltreSoyad_TextChanged);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblKullanici
            // 
            this.lblKullanici.AutoSize = true;
            this.lblKullanici.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKullanici.Location = new System.Drawing.Point(12, 7);
            this.lblKullanici.Name = "lblKullanici";
            this.lblKullanici.Size = new System.Drawing.Size(81, 18);
            this.lblKullanici.TabIndex = 13;
            this.lblKullanici.Text = "Kullanıcı: ";
            // 
            // lblYetki
            // 
            this.lblYetki.AutoSize = true;
            this.lblYetki.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYetki.Location = new System.Drawing.Point(363, 7);
            this.lblYetki.Name = "lblYetki";
            this.lblYetki.Size = new System.Drawing.Size(55, 18);
            this.lblYetki.TabIndex = 14;
            this.lblYetki.Text = "Yetki: ";
            // 
            // btnMaasGoster
            // 
            this.btnMaasGoster.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaasGoster.Location = new System.Drawing.Point(15, 399);
            this.btnMaasGoster.Name = "btnMaasGoster";
            this.btnMaasGoster.Size = new System.Drawing.Size(214, 33);
            this.btnMaasGoster.TabIndex = 15;
            this.btnMaasGoster.Text = "Maaş Bilgileri Göster";
            this.btnMaasGoster.UseVisualStyleBackColor = true;
            this.btnMaasGoster.Click += new System.EventHandler(this.btnMaasGoster_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(351, 399);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(131, 33);
            this.button2.TabIndex = 16;
            this.button2.Text = "Şifre Değiştir";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // gbMaasGoster
            // 
            this.gbMaasGoster.Controls.Add(this.cbSifreGoster);
            this.gbMaasGoster.Controls.Add(this.lblMaasBilgileri);
            this.gbMaasGoster.Controls.Add(this.label26);
            this.gbMaasGoster.Controls.Add(this.btnMaas);
            this.gbMaasGoster.Controls.Add(this.label2);
            this.gbMaasGoster.Controls.Add(this.txtSifreMaas);
            this.gbMaasGoster.Location = new System.Drawing.Point(15, 438);
            this.gbMaasGoster.Name = "gbMaasGoster";
            this.gbMaasGoster.Size = new System.Drawing.Size(262, 212);
            this.gbMaasGoster.TabIndex = 17;
            this.gbMaasGoster.TabStop = false;
            this.gbMaasGoster.Text = "Maaş Bilgileri";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Agency FB", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.ForeColor = System.Drawing.Color.Red;
            this.label26.Location = new System.Drawing.Point(228, 179);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(28, 17);
            this.label26.TabIndex = 21;
            this.label26.Text = "kapat";
            this.label26.Click += new System.EventHandler(this.label26_Click);
            // 
            // btnMaas
            // 
            this.btnMaas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaas.ForeColor = System.Drawing.Color.Black;
            this.btnMaas.Location = new System.Drawing.Point(4, 106);
            this.btnMaas.Name = "btnMaas";
            this.btnMaas.Size = new System.Drawing.Size(64, 28);
            this.btnMaas.TabIndex = 19;
            this.btnMaas.Text = "OK";
            this.btnMaas.UseVisualStyleBackColor = true;
            this.btnMaas.Click += new System.EventHandler(this.btnMaas_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Şifrenizi Girin";
            // 
            // txtSifreMaas
            // 
            this.txtSifreMaas.Location = new System.Drawing.Point(6, 55);
            this.txtSifreMaas.Name = "txtSifreMaas";
            this.txtSifreMaas.Size = new System.Drawing.Size(250, 20);
            this.txtSifreMaas.TabIndex = 0;
            this.txtSifreMaas.TextChanged += new System.EventHandler(this.txtSifreMaas_TextChanged);
            // 
            // gbSifreDegistir
            // 
            this.gbSifreDegistir.Controls.Add(this.label6);
            this.gbSifreDegistir.Controls.Add(this.button3);
            this.gbSifreDegistir.Controls.Add(this.label5);
            this.gbSifreDegistir.Controls.Add(this.txtYeniSifreTekrar);
            this.gbSifreDegistir.Controls.Add(this.label4);
            this.gbSifreDegistir.Controls.Add(this.txtYeniSifre);
            this.gbSifreDegistir.Controls.Add(this.label3);
            this.gbSifreDegistir.Controls.Add(this.txtEskiSifre);
            this.gbSifreDegistir.Location = new System.Drawing.Point(312, 438);
            this.gbSifreDegistir.Name = "gbSifreDegistir";
            this.gbSifreDegistir.Size = new System.Drawing.Size(241, 212);
            this.gbSifreDegistir.TabIndex = 18;
            this.gbSifreDegistir.TabStop = false;
            this.gbSifreDegistir.Text = "Şifre Değiştir";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 16);
            this.label4.TabIndex = 23;
            this.label4.Text = "Yeni Şifre";
            // 
            // txtYeniSifre
            // 
            this.txtYeniSifre.Location = new System.Drawing.Point(17, 94);
            this.txtYeniSifre.Name = "txtYeniSifre";
            this.txtYeniSifre.Size = new System.Drawing.Size(168, 20);
            this.txtYeniSifre.TabIndex = 24;
            this.txtYeniSifre.TextChanged += new System.EventHandler(this.txtYeniSifre_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 16);
            this.label3.TabIndex = 22;
            this.label3.Text = "Eski Şifre";
            // 
            // txtEskiSifre
            // 
            this.txtEskiSifre.Location = new System.Drawing.Point(17, 46);
            this.txtEskiSifre.Name = "txtEskiSifre";
            this.txtEskiSifre.Size = new System.Drawing.Size(168, 20);
            this.txtEskiSifre.TabIndex = 22;
            this.txtEskiSifre.TextChanged += new System.EventHandler(this.txtEskiSifre_TextChanged);
            // 
            // lblMaasBilgileri
            // 
            this.lblMaasBilgileri.AutoSize = true;
            this.lblMaasBilgileri.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaasBilgileri.Location = new System.Drawing.Point(1, 179);
            this.lblMaasBilgileri.Name = "lblMaasBilgileri";
            this.lblMaasBilgileri.Size = new System.Drawing.Size(77, 16);
            this.lblMaasBilgileri.TabIndex = 22;
            this.lblMaasBilgileri.Text = "Maaşınız: ";
            // 
            // cbSifreGoster
            // 
            this.cbSifreGoster.AutoSize = true;
            this.cbSifreGoster.Location = new System.Drawing.Point(151, 111);
            this.cbSifreGoster.Name = "cbSifreGoster";
            this.cbSifreGoster.Size = new System.Drawing.Size(88, 17);
            this.cbSifreGoster.TabIndex = 23;
            this.cbSifreGoster.Text = "Şifreyi Göster";
            this.cbSifreGoster.UseVisualStyleBackColor = true;
            this.cbSifreGoster.CheckedChanged += new System.EventHandler(this.cbSifreGoster_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 16);
            this.label5.TabIndex = 25;
            this.label5.Text = "Yeni Şifre Tekrar";
            // 
            // txtYeniSifreTekrar
            // 
            this.txtYeniSifreTekrar.Location = new System.Drawing.Point(17, 140);
            this.txtYeniSifreTekrar.Name = "txtYeniSifreTekrar";
            this.txtYeniSifreTekrar.Size = new System.Drawing.Size(168, 20);
            this.txtYeniSifreTekrar.TabIndex = 26;
            this.txtYeniSifreTekrar.TextChanged += new System.EventHandler(this.txtYeniSifreTekrar_TextChanged);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Location = new System.Drawing.Point(17, 174);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(64, 25);
            this.button3.TabIndex = 24;
            this.button3.Text = "OK";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Agency FB", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(207, 182);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 17);
            this.label6.TabIndex = 24;
            this.label6.Text = "kapat";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 662);
            this.Controls.Add(this.gbSifreDegistir);
            this.Controls.Add(this.gbMaasGoster);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnMaasGoster);
            this.Controls.Add(this.lblYetki);
            this.Controls.Add(this.lblKullanici);
            this.Controls.Add(this.txtFiltreSoyad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFiltreAd);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.lblVeriSayisi);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gbMaasGoster.ResumeLayout(false);
            this.gbMaasGoster.PerformLayout();
            this.gbSifreDegistir.ResumeLayout(false);
            this.gbSifreDegistir.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblVeriSayisi;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.TextBox txtFiltreAd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFiltreSoyad;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblKullanici;
        private System.Windows.Forms.Label lblYetki;
        private System.Windows.Forms.Button btnMaasGoster;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox gbMaasGoster;
        private System.Windows.Forms.GroupBox gbSifreDegistir;
        //private System.Windows.Forms.Label lblMaasBilgileri;
        private System.Windows.Forms.Button btnMaas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSifreMaas;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtYeniSifre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEskiSifre;
        private System.Windows.Forms.Label lblMaasBilgileri;
        private System.Windows.Forms.CheckBox cbSifreGoster;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtYeniSifreTekrar;
        private System.Windows.Forms.Label label6;
    }
}