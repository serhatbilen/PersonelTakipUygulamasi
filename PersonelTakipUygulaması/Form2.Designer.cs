
namespace PersonelTakipUygulaması
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.yeniKayitGb = new System.Windows.Forms.GroupBox();
            this.label26 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.cbDepartmanK = new System.Windows.Forms.ComboBox();
            this.CbRutbeK = new System.Windows.Forms.ComboBox();
            this.btnKayitEkle = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSifreK = new System.Windows.Forms.TextBox();
            this.txtKullaniciAdiK = new System.Windows.Forms.TextBox();
            this.txtMaasK = new System.Windows.Forms.TextBox();
            this.txtSoyadK = new System.Windows.Forms.TextBox();
            this.txtAdK = new System.Windows.Forms.TextBox();
            this.GuncellemeGb = new System.Windows.Forms.GroupBox();
            this.label27 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.cbDepartmanG = new System.Windows.Forms.ComboBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.cbRutbeG = new System.Windows.Forms.ComboBox();
            this.label24 = new System.Windows.Forms.Label();
            this.txtAdG = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.btnGuncelleme = new System.Windows.Forms.Button();
            this.txtSoyadG = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtMaasG = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtKullaniciAdiG = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtSifreG = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.txtFiltreRutbe = new System.Windows.Forms.TextBox();
            this.txtFiltreSoyad = new System.Windows.Forms.TextBox();
            this.txtFiltreAd = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.lblVeriSayisi = new System.Windows.Forms.Label();
            this.btnCikis = new System.Windows.Forms.Button();
            this.lblKullanici = new System.Windows.Forms.Label();
            this.lblYetki = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblKullaniciId = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.yeniKayitGb.SuspendLayout();
            this.GuncellemeGb.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 30);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(630, 274);
            this.dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(153, 340);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 36);
            this.button1.TabIndex = 1;
            this.button1.Text = "Kayıtları Yenile";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSil
            // 
            this.btnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSil.Location = new System.Drawing.Point(386, 340);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(126, 36);
            this.btnSil.TabIndex = 1;
            this.btnSil.Text = "Seçili Kaydı Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // yeniKayitGb
            // 
            this.yeniKayitGb.Controls.Add(this.label26);
            this.yeniKayitGb.Controls.Add(this.label19);
            this.yeniKayitGb.Controls.Add(this.label18);
            this.yeniKayitGb.Controls.Add(this.label17);
            this.yeniKayitGb.Controls.Add(this.label16);
            this.yeniKayitGb.Controls.Add(this.label15);
            this.yeniKayitGb.Controls.Add(this.cbDepartmanK);
            this.yeniKayitGb.Controls.Add(this.CbRutbeK);
            this.yeniKayitGb.Controls.Add(this.btnKayitEkle);
            this.yeniKayitGb.Controls.Add(this.label7);
            this.yeniKayitGb.Controls.Add(this.label6);
            this.yeniKayitGb.Controls.Add(this.label5);
            this.yeniKayitGb.Controls.Add(this.label4);
            this.yeniKayitGb.Controls.Add(this.label3);
            this.yeniKayitGb.Controls.Add(this.label2);
            this.yeniKayitGb.Controls.Add(this.label1);
            this.yeniKayitGb.Controls.Add(this.txtSifreK);
            this.yeniKayitGb.Controls.Add(this.txtKullaniciAdiK);
            this.yeniKayitGb.Controls.Add(this.txtMaasK);
            this.yeniKayitGb.Controls.Add(this.txtSoyadK);
            this.yeniKayitGb.Controls.Add(this.txtAdK);
            this.yeniKayitGb.Location = new System.Drawing.Point(12, 391);
            this.yeniKayitGb.Name = "yeniKayitGb";
            this.yeniKayitGb.Size = new System.Drawing.Size(312, 233);
            this.yeniKayitGb.TabIndex = 3;
            this.yeniKayitGb.TabStop = false;
            this.yeniKayitGb.Text = "Yeni Kayıt";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Agency FB", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.ForeColor = System.Drawing.Color.Red;
            this.label26.Location = new System.Drawing.Point(280, 213);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(28, 17);
            this.label26.TabIndex = 9;
            this.label26.Text = "kapat";
            this.label26.Click += new System.EventHandler(this.label26_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(154, 128);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(12, 13);
            this.label19.TabIndex = 8;
            this.label19.Text = "*";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(154, 101);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(12, 13);
            this.label18.TabIndex = 7;
            this.label18.Text = "*";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(154, 75);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(12, 13);
            this.label17.TabIndex = 6;
            this.label17.Text = "*";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(154, 49);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(12, 13);
            this.label16.TabIndex = 5;
            this.label16.Text = "*";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(154, 24);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(12, 13);
            this.label15.TabIndex = 4;
            this.label15.Text = "*";
            // 
            // cbDepartmanK
            // 
            this.cbDepartmanK.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDepartmanK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDepartmanK.FormattingEnabled = true;
            this.cbDepartmanK.Location = new System.Drawing.Point(167, 123);
            this.cbDepartmanK.Name = "cbDepartmanK";
            this.cbDepartmanK.Size = new System.Drawing.Size(139, 24);
            this.cbDepartmanK.TabIndex = 3;
            // 
            // CbRutbeK
            // 
            this.CbRutbeK.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbRutbeK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbRutbeK.FormattingEnabled = true;
            this.CbRutbeK.Items.AddRange(new object[] {
            "Çalışan",
            "Yönetici"});
            this.CbRutbeK.Location = new System.Drawing.Point(167, 96);
            this.CbRutbeK.Name = "CbRutbeK";
            this.CbRutbeK.Size = new System.Drawing.Size(139, 24);
            this.CbRutbeK.TabIndex = 3;
            // 
            // btnKayitEkle
            // 
            this.btnKayitEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKayitEkle.Location = new System.Drawing.Point(91, 203);
            this.btnKayitEkle.Name = "btnKayitEkle";
            this.btnKayitEkle.Size = new System.Drawing.Size(115, 23);
            this.btnKayitEkle.TabIndex = 2;
            this.btnKayitEkle.Text = "Kayıt Ekle";
            this.btnKayitEkle.UseVisualStyleBackColor = true;
            this.btnKayitEkle.Click += new System.EventHandler(this.btnKayitEkle_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 178);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 16);
            this.label7.TabIndex = 1;
            this.label7.Text = "Şifre";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 152);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 16);
            this.label6.TabIndex = 1;
            this.label6.Text = "Kullanıcı Adı";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "Departman";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Rütbe";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Personel Maaş";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Personel Soyad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Personel Ad";
            // 
            // txtSifreK
            // 
            this.txtSifreK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSifreK.Location = new System.Drawing.Point(167, 175);
            this.txtSifreK.Name = "txtSifreK";
            this.txtSifreK.Size = new System.Drawing.Size(139, 22);
            this.txtSifreK.TabIndex = 0;
            this.txtSifreK.TextChanged += new System.EventHandler(this.txtSifreK_TextChanged);
            // 
            // txtKullaniciAdiK
            // 
            this.txtKullaniciAdiK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKullaniciAdiK.Location = new System.Drawing.Point(167, 149);
            this.txtKullaniciAdiK.Name = "txtKullaniciAdiK";
            this.txtKullaniciAdiK.Size = new System.Drawing.Size(139, 22);
            this.txtKullaniciAdiK.TabIndex = 0;
            this.txtKullaniciAdiK.TextChanged += new System.EventHandler(this.txtKullaniciAdiK_TextChanged);
            // 
            // txtMaasK
            // 
            this.txtMaasK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaasK.Location = new System.Drawing.Point(167, 71);
            this.txtMaasK.Name = "txtMaasK";
            this.txtMaasK.Size = new System.Drawing.Size(139, 22);
            this.txtMaasK.TabIndex = 0;
            this.txtMaasK.TextChanged += new System.EventHandler(this.txtMaasK_TextChanged);
            // 
            // txtSoyadK
            // 
            this.txtSoyadK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoyadK.Location = new System.Drawing.Point(167, 45);
            this.txtSoyadK.Name = "txtSoyadK";
            this.txtSoyadK.Size = new System.Drawing.Size(139, 22);
            this.txtSoyadK.TabIndex = 0;
            this.txtSoyadK.TextChanged += new System.EventHandler(this.txtSoyadK_TextChanged);
            // 
            // txtAdK
            // 
            this.txtAdK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdK.Location = new System.Drawing.Point(167, 19);
            this.txtAdK.Name = "txtAdK";
            this.txtAdK.Size = new System.Drawing.Size(139, 22);
            this.txtAdK.TabIndex = 0;
            this.txtAdK.TextChanged += new System.EventHandler(this.txtAdK_TextChanged);
            // 
            // GuncellemeGb
            // 
            this.GuncellemeGb.Controls.Add(this.label27);
            this.GuncellemeGb.Controls.Add(this.label21);
            this.GuncellemeGb.Controls.Add(this.cbDepartmanG);
            this.GuncellemeGb.Controls.Add(this.label22);
            this.GuncellemeGb.Controls.Add(this.label8);
            this.GuncellemeGb.Controls.Add(this.label23);
            this.GuncellemeGb.Controls.Add(this.cbRutbeG);
            this.GuncellemeGb.Controls.Add(this.label24);
            this.GuncellemeGb.Controls.Add(this.txtAdG);
            this.GuncellemeGb.Controls.Add(this.label25);
            this.GuncellemeGb.Controls.Add(this.btnGuncelleme);
            this.GuncellemeGb.Controls.Add(this.txtSoyadG);
            this.GuncellemeGb.Controls.Add(this.label14);
            this.GuncellemeGb.Controls.Add(this.txtMaasG);
            this.GuncellemeGb.Controls.Add(this.label13);
            this.GuncellemeGb.Controls.Add(this.txtKullaniciAdiG);
            this.GuncellemeGb.Controls.Add(this.label12);
            this.GuncellemeGb.Controls.Add(this.txtSifreG);
            this.GuncellemeGb.Controls.Add(this.label11);
            this.GuncellemeGb.Controls.Add(this.label9);
            this.GuncellemeGb.Controls.Add(this.label10);
            this.GuncellemeGb.Location = new System.Drawing.Point(330, 391);
            this.GuncellemeGb.Name = "GuncellemeGb";
            this.GuncellemeGb.Size = new System.Drawing.Size(312, 233);
            this.GuncellemeGb.TabIndex = 3;
            this.GuncellemeGb.TabStop = false;
            this.GuncellemeGb.Text = "Güncelleme";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Agency FB", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.ForeColor = System.Drawing.Color.Red;
            this.label27.Location = new System.Drawing.Point(280, 212);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(28, 17);
            this.label27.TabIndex = 10;
            this.label27.Text = "kapat";
            this.label27.Click += new System.EventHandler(this.label27_Click);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(153, 126);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(12, 13);
            this.label21.TabIndex = 13;
            this.label21.Text = "*";
            // 
            // cbDepartmanG
            // 
            this.cbDepartmanG.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDepartmanG.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDepartmanG.FormattingEnabled = true;
            this.cbDepartmanG.Location = new System.Drawing.Point(167, 120);
            this.cbDepartmanG.Name = "cbDepartmanG";
            this.cbDepartmanG.Size = new System.Drawing.Size(139, 24);
            this.cbDepartmanG.TabIndex = 3;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(153, 99);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(12, 13);
            this.label22.TabIndex = 12;
            this.label22.Text = "*";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 16);
            this.label8.TabIndex = 1;
            this.label8.Text = "Personel Ad";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(153, 73);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(12, 13);
            this.label23.TabIndex = 11;
            this.label23.Text = "*";
            // 
            // cbRutbeG
            // 
            this.cbRutbeG.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRutbeG.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbRutbeG.FormattingEnabled = true;
            this.cbRutbeG.Items.AddRange(new object[] {
            "Çalışan",
            "Yönetici"});
            this.cbRutbeG.Location = new System.Drawing.Point(167, 93);
            this.cbRutbeG.Name = "cbRutbeG";
            this.cbRutbeG.Size = new System.Drawing.Size(139, 24);
            this.cbRutbeG.TabIndex = 3;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(153, 47);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(12, 13);
            this.label24.TabIndex = 10;
            this.label24.Text = "*";
            // 
            // txtAdG
            // 
            this.txtAdG.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdG.Location = new System.Drawing.Point(167, 16);
            this.txtAdG.Name = "txtAdG";
            this.txtAdG.Size = new System.Drawing.Size(139, 22);
            this.txtAdG.TabIndex = 0;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(153, 22);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(12, 13);
            this.label25.TabIndex = 9;
            this.label25.Text = "*";
            // 
            // btnGuncelleme
            // 
            this.btnGuncelleme.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuncelleme.Location = new System.Drawing.Point(93, 204);
            this.btnGuncelleme.Name = "btnGuncelleme";
            this.btnGuncelleme.Size = new System.Drawing.Size(126, 23);
            this.btnGuncelleme.TabIndex = 2;
            this.btnGuncelleme.Text = "Kaydı Güncelle";
            this.btnGuncelleme.UseVisualStyleBackColor = true;
            this.btnGuncelleme.Click += new System.EventHandler(this.btnGuncelleme_Click);
            // 
            // txtSoyadG
            // 
            this.txtSoyadG.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoyadG.Location = new System.Drawing.Point(167, 42);
            this.txtSoyadG.Name = "txtSoyadG";
            this.txtSoyadG.Size = new System.Drawing.Size(139, 22);
            this.txtSoyadG.TabIndex = 0;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(6, 175);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(40, 16);
            this.label14.TabIndex = 1;
            this.label14.Text = "Şifre";
            // 
            // txtMaasG
            // 
            this.txtMaasG.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaasG.Location = new System.Drawing.Point(167, 68);
            this.txtMaasG.Name = "txtMaasG";
            this.txtMaasG.Size = new System.Drawing.Size(139, 22);
            this.txtMaasG.TabIndex = 0;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(6, 149);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(93, 16);
            this.label13.TabIndex = 1;
            this.label13.Text = "Kullanıcı Adı";
            // 
            // txtKullaniciAdiG
            // 
            this.txtKullaniciAdiG.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKullaniciAdiG.Location = new System.Drawing.Point(167, 146);
            this.txtKullaniciAdiG.Name = "txtKullaniciAdiG";
            this.txtKullaniciAdiG.Size = new System.Drawing.Size(139, 22);
            this.txtKullaniciAdiG.TabIndex = 0;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(6, 123);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(84, 16);
            this.label12.TabIndex = 1;
            this.label12.Text = "Departman";
            // 
            // txtSifreG
            // 
            this.txtSifreG.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSifreG.Location = new System.Drawing.Point(167, 172);
            this.txtSifreG.Name = "txtSifreG";
            this.txtSifreG.Size = new System.Drawing.Size(139, 22);
            this.txtSifreG.TabIndex = 0;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(6, 97);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 16);
            this.label11.TabIndex = 1;
            this.label11.Text = "Rütbe";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 45);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(119, 16);
            this.label9.TabIndex = 1;
            this.label9.Text = "Personel Soyad";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(6, 71);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(112, 16);
            this.label10.TabIndex = 1;
            this.label10.Text = "Personel Maaş";
            // 
            // btnEkle
            // 
            this.btnEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEkle.Location = new System.Drawing.Point(21, 340);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(126, 36);
            this.btnEkle.TabIndex = 1;
            this.btnEkle.Text = "Yeni Kayıt Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuncelle.Location = new System.Drawing.Point(516, 340);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(126, 36);
            this.btnGuncelle.TabIndex = 1;
            this.btnGuncelle.Text = "Seçili Kaydı Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // txtFiltreRutbe
            // 
            this.txtFiltreRutbe.Location = new System.Drawing.Point(386, 310);
            this.txtFiltreRutbe.Name = "txtFiltreRutbe";
            this.txtFiltreRutbe.Size = new System.Drawing.Size(86, 20);
            this.txtFiltreRutbe.TabIndex = 5;
            this.txtFiltreRutbe.TextChanged += new System.EventHandler(this.txtFiltreRutbe_TextChanged);
            // 
            // txtFiltreSoyad
            // 
            this.txtFiltreSoyad.Location = new System.Drawing.Point(133, 310);
            this.txtFiltreSoyad.Name = "txtFiltreSoyad";
            this.txtFiltreSoyad.Size = new System.Drawing.Size(86, 20);
            this.txtFiltreSoyad.TabIndex = 8;
            this.txtFiltreSoyad.TextChanged += new System.EventHandler(this.txtFiltreSoyad_TextChanged);
            // 
            // txtFiltreAd
            // 
            this.txtFiltreAd.Location = new System.Drawing.Point(49, 310);
            this.txtFiltreAd.Name = "txtFiltreAd";
            this.txtFiltreAd.Size = new System.Drawing.Size(86, 20);
            this.txtFiltreAd.TabIndex = 9;
            this.txtFiltreAd.TextChanged += new System.EventHandler(this.txtFiltreAd_TextChanged);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(13, 313);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(35, 13);
            this.label20.TabIndex = 9;
            this.label20.Text = "Filtre";
            // 
            // lblVeriSayisi
            // 
            this.lblVeriSayisi.AutoSize = true;
            this.lblVeriSayisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVeriSayisi.Location = new System.Drawing.Point(499, 310);
            this.lblVeriSayisi.Name = "lblVeriSayisi";
            this.lblVeriSayisi.Size = new System.Drawing.Size(138, 18);
            this.lblVeriSayisi.TabIndex = 10;
            this.lblVeriSayisi.Text = "Kayıt Gösteriliyor";
            // 
            // btnCikis
            // 
            this.btnCikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCikis.ForeColor = System.Drawing.Color.Red;
            this.btnCikis.Location = new System.Drawing.Point(295, 347);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(75, 23);
            this.btnCikis.TabIndex = 11;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // lblKullanici
            // 
            this.lblKullanici.AutoSize = true;
            this.lblKullanici.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKullanici.Location = new System.Drawing.Point(13, 7);
            this.lblKullanici.Name = "lblKullanici";
            this.lblKullanici.Size = new System.Drawing.Size(81, 18);
            this.lblKullanici.TabIndex = 12;
            this.lblKullanici.Text = "Kullanıcı: ";
            // 
            // lblYetki
            // 
            this.lblYetki.AutoSize = true;
            this.lblYetki.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYetki.Location = new System.Drawing.Point(457, 9);
            this.lblYetki.Name = "lblYetki";
            this.lblYetki.Size = new System.Drawing.Size(55, 18);
            this.lblYetki.TabIndex = 13;
            this.lblYetki.Text = "Yetki: ";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblKullaniciId
            // 
            this.lblKullaniciId.AutoSize = true;
            this.lblKullaniciId.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKullaniciId.Location = new System.Drawing.Point(207, 7);
            this.lblKullaniciId.Name = "lblKullaniciId";
            this.lblKullaniciId.Size = new System.Drawing.Size(81, 18);
            this.lblKullaniciId.TabIndex = 14;
            this.lblKullaniciId.Text = "Kullanıcı: ";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 630);
            this.Controls.Add(this.lblKullaniciId);
            this.Controls.Add(this.lblYetki);
            this.Controls.Add(this.lblKullanici);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.lblVeriSayisi);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.txtFiltreAd);
            this.Controls.Add(this.txtFiltreSoyad);
            this.Controls.Add(this.txtFiltreRutbe);
            this.Controls.Add(this.GuncellemeGb);
            this.Controls.Add(this.yeniKayitGb);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.yeniKayitGb.ResumeLayout(false);
            this.yeniKayitGb.PerformLayout();
            this.GuncellemeGb.ResumeLayout(false);
            this.GuncellemeGb.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.GroupBox yeniKayitGb;
        private System.Windows.Forms.ComboBox cbDepartmanK;
        private System.Windows.Forms.ComboBox CbRutbeK;
        private System.Windows.Forms.Button btnKayitEkle;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSifreK;
        private System.Windows.Forms.TextBox txtKullaniciAdiK;
        private System.Windows.Forms.TextBox txtMaasK;
        private System.Windows.Forms.TextBox txtSoyadK;
        private System.Windows.Forms.TextBox txtAdK;
        private System.Windows.Forms.GroupBox GuncellemeGb;
        private System.Windows.Forms.ComboBox cbDepartmanG;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbRutbeG;
        private System.Windows.Forms.TextBox txtAdG;
        private System.Windows.Forms.Button btnGuncelleme;
        private System.Windows.Forms.TextBox txtSoyadG;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtMaasG;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtKullaniciAdiG;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtSifreG;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtFiltreRutbe;
        private System.Windows.Forms.TextBox txtFiltreSoyad;
        private System.Windows.Forms.TextBox txtFiltreAd;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label lblVeriSayisi;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Label lblKullanici;
        private System.Windows.Forms.Label lblYetki;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblKullaniciId;
    }
}