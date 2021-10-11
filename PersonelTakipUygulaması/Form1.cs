using PersonelTakipUygulaması.Veri_Tabanı;
using PersonelTakipUygulaması.Veri_Tabanı.Context;
using System;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        CrudDbContext db = new CrudDbContext();
        Form2 form2 = new Form2();
        Form3 form3 = new Form3();
        public static string calisanAd, calisanSoyad, calisanRutbe, kullaniciAdi, sifre, 
            calisanDepartman;
        public static double calisanMaas;
        public static int calisanId;
        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbSifreyiGoster_CheckedChanged(object sender, EventArgs e)
        {
            if (cbSifreyiGoster.Checked)
            {
                txtSifre.UseSystemPasswordChar = PasswordPropertyTextAttribute.No.Password;
            }
            else
            {
                txtSifre.UseSystemPasswordChar = PasswordPropertyTextAttribute.Yes.Password;
            }
        }

        private void txtSifre_TextChanged(object sender, EventArgs e)
        {
            txtSifre.UseSystemPasswordChar = PasswordPropertyTextAttribute.Yes.Password;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            this.Text = "Personel Girişi";
            this.AcceptButton = btnGiris;
            this.CancelButton = btnCikis;
            rbCalisan.Checked = true;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Form1.calisanId = 0;
            txtKullaniciAdi.TabIndex = 1;
            txtSifre.TabIndex = 2;
        }
        private void button1_Click(object sender, EventArgs e)
        {

            kullaniciAdi = txtKullaniciAdi.Text;
            sifre = txtSifre.Text;
            var ka = db.calisan.Where(
                x => x.kullaniciAdi == kullaniciAdi &&
            x.sifre == sifre).
            SingleOrDefault();
            if (txtKullaniciAdi.Text == "admin" && txtSifre.Text == "admin")
            {
                form2.Show();
                this.Hide();
                return;
            }
            if (ka == null)
            {
                MessageBox.Show("Kullanıcı Adı veya Şifre Hatalı", "HATA",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (ka != null)
            {
                if (ka.rutbe != "Yönetici" && rbYonetici.Checked)
                {
                    MessageBox.Show("Yönetici Değil", "HATA",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else if (ka.rutbe != "Çalışan" && rbCalisan.Checked)
                {
                    MessageBox.Show("Çalışan Değil", "HATA",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else if (ka.rutbe == "Yönetici" && rbYonetici.Checked)
                {
                    calisanAd = ka.Ad;
                    calisanSoyad = ka.Soyad;
                    calisanRutbe = ka.rutbe;
                    kullaniciAdi = ka.kullaniciAdi;
                    sifre = ka.sifre;
                    //calisanDepartman = ka.departman.Ad;
                    calisanMaas = ka.Maas;
                    calisanId = ka.Id;
                    form2.Show();
                    this.Hide();
                    return;
                }
                else if (ka.rutbe == "Çalışan" && rbCalisan.Checked)
                {
                    calisanAd = ka.Ad;
                    calisanSoyad = ka.Soyad;
                    calisanRutbe = ka.rutbe;
                    kullaniciAdi = ka.kullaniciAdi;
                    sifre = ka.sifre;
                    //calisanDepartman = ka.departman.Ad;
                    calisanMaas = ka.Maas;
                    calisanId = ka.Id;
                    form3.Show();
                    this.Hide();
                    return;
                }
            }
        }
    }
}
