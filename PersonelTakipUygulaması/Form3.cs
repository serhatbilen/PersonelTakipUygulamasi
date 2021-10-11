using PersonelTakipUygulaması.Veri_Tabanı.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonelTakipUygulaması
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        CrudDbContext db = new CrudDbContext();
        public void kayitYenile()
        {
            var sorgu = from item in db.calisan
                        select new { item.Id, item.Ad, item.Soyad, item.departmanId, item.rutbe};

            dataGridView1.DataSource = sorgu.ToList();
            this.dataGridView1.Columns[0].Visible = false;
            lblVeriSayisi.Text = dataGridView1.RowCount + " Kayıt Gösteriliyor".ToString();
            //this.dataGridView1.Columns[3].Name = "sssss";
        }
        private void Form3_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            this.Text = "Çalışan";
            lblKullanici.Text = "Kullanıcı: " + Form1.calisanAd + " " + Form1.calisanSoyad;
            lblYetki.Text = "Yetki: " + Form1.calisanRutbe;
            gbMaasGoster.Visible = false;
            gbSifreDegistir.Visible = false;
            kayitYenile();
        }
        

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void txtFiltreAd_TextChanged(object sender, EventArgs e)
        {
            string arananAd = txtFiltreAd.Text;
            var calisanlar = from item in db.calisan
                             where item.Ad.Contains(arananAd)
                             select new { item.Id, item.Ad, item.Soyad, item.departmanId, item.rutbe };
            dataGridView1.DataSource = calisanlar.ToList();
            lblVeriSayisi.Text = dataGridView1.RowCount + " Kayıt Gösteriliyor".ToString();
        }

        private void txtFiltreSoyad_TextChanged(object sender, EventArgs e)
        {
            string arananSoyad = txtFiltreSoyad.Text;
            var calisanlar = from item in db.calisan
                             where item.Soyad.Contains(arananSoyad)
                             select new { item.Id, item.Ad, item.Soyad, item.departmanId, item.rutbe };
            dataGridView1.DataSource = calisanlar.ToList();
            lblVeriSayisi.Text = dataGridView1.RowCount + " Kayıt Gösteriliyor".ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Form1.calisanId != 0 && Form1.kullaniciAdi != "admin")
            {
                kayitKontrol();
            }
        }
        public void kayitKontrol()
        {
            var kontrol = db.calisan.Where(
                x => x.Id == Form1.calisanId).
            SingleOrDefault();
            if (kontrol == null)
            {
                timer1.Stop();
                kullaniciDef();
                MessageBox.Show("Çıkış Yaptınız", "HATA",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Form1 form1 = new Form1();
                form1.Show();
                this.Hide();
                return;
            }
        }
        void kullaniciDef()
        {
            Form3 form3 = new Form3();
            form3.Visible = false;
        }

        private void btnMaasGoster_Click(object sender, EventArgs e)
        {
            gbMaasGoster.Visible = true;
            gbSifreDegistir.Visible = false;
            lblMaasBilgileri.Text = "Maaşınız:";
            txtSifreMaas.Text = "";
            txtSifreMaas.TabIndex = 1;
            btnMaas.TabIndex = 2;
            this.AcceptButton = btnMaas;
        }

        private void btnMaas_Click(object sender, EventArgs e)
        {
            if (txtSifreMaas.Text != Form1.sifre)
            {
                MessageBox.Show("Şifre Yanlış", "HATA",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (txtSifreMaas.Text == Form1.sifre)
            {
                lblMaasBilgileri.Text = "Maaşınız: " + Form1.calisanMaas.ToString() + "₺' dir";
            }
        }

        private void label26_Click(object sender, EventArgs e)
        {
            gbMaasGoster.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            gbSifreDegistir.Visible = true;
            gbMaasGoster.Visible = false;
            txtEskiSifre.TabIndex = 1;
            txtYeniSifre.TabIndex = 2;
            txtYeniSifreTekrar.TabIndex = 3;
            this.AcceptButton = button3;

        }

        private void cbSifreGoster_CheckedChanged(object sender, EventArgs e)
        {
            if (cbSifreGoster.Checked)
            {
                txtSifreMaas.UseSystemPasswordChar = PasswordPropertyTextAttribute.No.Password;
            }
            else
            {
                txtSifreMaas.UseSystemPasswordChar = PasswordPropertyTextAttribute.Yes.Password;
            }
        }

        private void txtSifreMaas_TextChanged(object sender, EventArgs e)
        {
            txtSifreMaas.UseSystemPasswordChar = PasswordPropertyTextAttribute.Yes.Password;
        }
        private void txtEskiSifre_TextChanged(object sender, EventArgs e)
        {
            txtEskiSifre.UseSystemPasswordChar = PasswordPropertyTextAttribute.Yes.Password;
        }
        private void txtYeniSifre_TextChanged(object sender, EventArgs e)
        {
            txtYeniSifre.UseSystemPasswordChar = PasswordPropertyTextAttribute.Yes.Password;
        }
        private void txtYeniSifreTekrar_TextChanged(object sender, EventArgs e)
        {
            txtYeniSifreTekrar.UseSystemPasswordChar = PasswordPropertyTextAttribute.Yes.Password;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (txtEskiSifre.Text != Form1.sifre)
            {
                MessageBox.Show("Eski Şifre Yanlış Girildi", "HATA",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtYeniSifre.Text != txtYeniSifreTekrar.Text)
            {
                MessageBox.Show("Girilen Yeni Şifreler Aynı Değil", "HATA",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var x = db.calisan.Find(Form1.calisanId);
            x.sifre = txtYeniSifre.Text;
            db.SaveChanges();
            MessageBox.Show("Şifreniz Güncellendi", "Bilgi",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtEskiSifre.Text = "";
            txtYeniSifre.Text = "";
            txtYeniSifreTekrar.Text = "";
            return;
        }

        private void label6_Click(object sender, EventArgs e)
        {
            gbSifreDegistir.Visible = false;
        }
    }
}
