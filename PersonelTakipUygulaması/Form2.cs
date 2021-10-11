using PersonelTakipUygulaması.Veri_Tabanı;
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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        CrudDbContext db = new CrudDbContext();
        public void kayitYenile()
        {
            //this.dataGridView1.Columns[0].Name = "Id";
            //this.dataGridView1.Columns[1].Name = "Ad";
            //this.dataGridView1.Columns[2].Name = "Soyad";
            //this.dataGridView1.Columns[3].Name = "Maaş";
            //this.dataGridView1.Columns[4].Name = "Departmanı";
            //this.dataGridView1.Columns[5].Name = "Yetki";
            //this.dataGridView1.Columns[6].Name = "KUllanıcı Adı";
            //this.dataGridView1.Columns[7].Name = "Şifre";

            var sorgu = from item in db.calisan
                        select new { item.Id, item.Ad, item.Soyad, item.Maas, item.departmanId, item.rutbe, item.kullaniciAdi, item.sifre };
            dataGridView1.DataSource = sorgu.ToList();
            this.dataGridView1.Columns[0].Visible = false;
            lblVeriSayisi.Text = dataGridView1.RowCount + " Kayıt Gösteriliyor".ToString();
        }
        void kullaniciDef()
        {
            Form2 form2 = new Form2();
            form2.Visible = false;
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
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Form1.calisanId != 0 && Form1.kullaniciAdi != "admin")
            {
                kayitKontrol();
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            timer1.Start();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            this.Text = "Personel Yönetimi";
            yeniKayitGb.Visible = false;
            GuncellemeGb.Visible = false;
            //lblKullaniciId.Text = Form1.calisanId.ToString();
            lblKullaniciId.Visible = false;
            lblKullanici.Text = "Kullanıcı: " + Form1.calisanAd + " " + Form1.calisanSoyad;
            lblYetki.Text = "Yetki: " + Form1.calisanRutbe;
            var depart = db.departman.ToList();
            foreach (var item in depart)
            {
                cbDepartmanG.Items.Add(item.Ad);
                cbDepartmanK.Items.Add(item.Ad);
            }
            kayitYenile();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            kayitYenile();
        }
        //Ekleme Bölümünün Açılması
        private void btnEkle_Click(object sender, EventArgs e)
        {
            yeniKayitGb.Visible = true;
            GuncellemeGb.Visible = false;
            txtAdK.TabIndex = 1;
            txtSoyadK.TabIndex = 2;
            txtMaasK.TabIndex = 3;
            CbRutbeK.TabIndex = 4;
            cbDepartmanK.TabIndex = 5;
            txtKullaniciAdiK.TabIndex = 6;
            txtSifreK.TabIndex = 7;
            btnKayitEkle.TabIndex = 8;
        }
        //Kayıt Ekleme
        private void btnKayitEkle_Click(object sender, EventArgs e)
        {
            Calisan c = new Calisan();
            try
            {
                if (txtAdK.Text == "" || txtAdK.TextLength <= 2 || txtAdK.TextLength >= 25 ||
            txtSoyadK.Text == "" || txtSoyadK.TextLength < 2 || txtSoyadK.TextLength >= 25 ||
            cbDepartmanK.SelectedIndex == -1 || CbRutbeK.SelectedIndex == -1 ||
            txtMaasK.Text == "" || txtMaasK.TextLength < 4 || txtMaasK.TextLength > 5)
                {
                    MessageBox.Show("Doldurulması Gereken Alanların Tam ve Doğru Şekilde Doldurunuz", "HATA",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                c.Ad = txtAdK.Text;
                c.Soyad = txtSoyadK.Text;
                c.Maas = double.Parse(txtMaasK.Text);
                c.rutbe = CbRutbeK.Text;
                c.departmanId = cbDepartmanK.SelectedIndex + 1;
                c.kullaniciAdi = txtKullaniciAdiK.Text;
                c.sifre = txtSifreK.Text;
            }
            catch (Exception)
            {
                MessageBox.Show("Yanlış Değerler Girdiniz", "HATA",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            db.calisan.Add(c);
            db.SaveChanges();
            txtAdK.Text = ""; txtSoyadK.Text = ""; txtMaasK.Text = ""; CbRutbeK.SelectedItem = 0; cbDepartmanK.SelectedItem = 0;
            txtKullaniciAdiK.Text = ""; txtSifreK.Text = "";
            DialogResult dialogResult = MessageBox.Show("Kayıt Eklemeye Devam Etmek İster misiniz?",
                "Kayıt Eklendi", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                kayitYenile();
            }
            else if (dialogResult == DialogResult.No)
            {
                yeniKayitGb.Visible = false;
                kayitYenile();
            }
        }
        private void btnSil_Click(object sender, EventArgs e)
        {
            int id;
            if (Convert.ToInt32(dataGridView1.CurrentRow.Cells["id"].Value) == Form1.calisanId)
            {
                MessageBox.Show("Kendinizi Silemezsiniz", "HATA",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DialogResult dialogResult = MessageBox.Show("Seçili Kaydı Silmek İstiyor musunuz?",
                "Kayıt Silme", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["id"].Value);
                var degerler = from i in db.calisan
                               where i.Id == id
                               select i;
                degerler.ToList().ForEach(x => db.calisan.Remove(x));
                db.SaveChanges();
                kayitYenile();
            }
        }
        #region textBoxEkle
        private void txtAdK_TextChanged(object sender, EventArgs e)
        {
            if (txtAdK.TextLength < 3 || txtAdK.TextLength >= 20)
            {
                txtAdK.BackColor = Color.Red;
            }
            else
            {
                txtAdK.BackColor = SystemColors.Window;
            }
        }
        private void txtSoyadK_TextChanged(object sender, EventArgs e)
        {
            if (txtAdK.Text == "" || txtSoyadK.TextLength < 3 || txtSoyadK.TextLength >= 25)
            {
                txtSoyadK.BackColor = Color.Red;
            }
            else
            {
                txtSoyadK.BackColor = SystemColors.Window;
            }
        }
        private void txtMaasK_TextChanged(object sender, EventArgs e)
        {
            if (txtMaasK.TextLength < 4 || txtMaasK.TextLength >= 6)
            {
                txtMaasK.BackColor = Color.Red;
            }
            else
            {
                txtMaasK.BackColor = SystemColors.Window;
            }
        }
        private void txtKullaniciAdiK_TextChanged(object sender, EventArgs e)
        {
            if (txtKullaniciAdiK.TextLength < 2 || txtKullaniciAdiK.TextLength >= 30)
            {
                txtKullaniciAdiK.BackColor = Color.Red;
            }
            else
            {
                txtKullaniciAdiK.BackColor = SystemColors.Window;
            }
        }
        private void txtSifreK_TextChanged(object sender, EventArgs e)
        {
            if (txtSifreK.TextLength < 7 || txtSifreK.TextLength >= 30)
            {
                txtSifreK.BackColor = Color.Red;
            }
            else
            {
                txtSifreK.BackColor = SystemColors.Window;
            }
        }
        #endregion

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            GuncellemeGb.Visible = true;
            yeniKayitGb.Visible = false;
            txtAdG.TabIndex = 1;
            txtSoyadG.TabIndex = 2;
            txtMaasG.TabIndex = 3;
            cbRutbeG.TabIndex = 4;
            cbDepartmanG.TabIndex = 5;
            txtKullaniciAdiG.TabIndex = 6;
            txtSifreG.TabIndex = 7;
            btnGuncelleme.TabIndex = 8;
            txtAdG.Text = dataGridView1.CurrentRow.Cells["Ad"].Value.ToString();
            txtSoyadG.Text = dataGridView1.CurrentRow.Cells["Soyad"].Value.ToString();
            txtMaasG.Text = dataGridView1.CurrentRow.Cells["Maas"].Value.ToString();
            cbRutbeG.SelectedItem = dataGridView1.CurrentRow.Cells["Rutbe"].Value.ToString();
            cbDepartmanG.SelectedIndex = ((int)dataGridView1.CurrentRow.Cells["departmanId"].Value) - 1;
            txtKullaniciAdiG.Text = dataGridView1.CurrentRow.Cells["kullaniciAdi"].Value.ToString();
            txtSifreG.Text = dataGridView1.CurrentRow.Cells["sifre"].Value.ToString();
        }

        private void btnGuncelleme_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtAdG.Text == "" || txtAdG.TextLength <= 2 || txtAdG.TextLength >= 25 ||
            txtSoyadG.Text == "" || txtSoyadG.TextLength < 2 || txtSoyadG.TextLength >= 25 ||
            cbDepartmanG.SelectedIndex == -1 || cbRutbeG.SelectedIndex == -1 ||
            txtMaasG.Text == "" || txtMaasG.TextLength < 4 || txtMaasG.TextLength > 5)
                {
                    MessageBox.Show("Doldurulması Gereken Alanların Tam ve Doğru Şekilde Doldurunuz", "HATA",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var x = db.calisan.Find(dataGridView1.CurrentRow.Cells["Id"].Value);
                x.Ad = txtAdG.Text;
                x.Soyad = txtSoyadG.Text;
                x.Maas = double.Parse(txtMaasG.Text);
                x.kullaniciAdi = txtKullaniciAdiG.Text;
                x.sifre = txtSifreG.Text;
                x.rutbe = cbRutbeG.Text;
                x.departmanId = cbDepartmanG.SelectedIndex + 1;
                db.SaveChanges();
                kayitYenile();
                GuncellemeGb.Visible = false;
            }
            catch (Exception)
            {
                MessageBox.Show("Yanlış Değerler Girdiniz", "HATA",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void txtFiltreAd_TextChanged(object sender, EventArgs e)
        {
            string arananAd = txtFiltreAd.Text;
            var calisanlar = from item in db.calisan
                             where item.Ad.Contains(arananAd)
                             select new { item.Id, item.Ad, item.Soyad, item.Maas, item.departmanId, item.rutbe, item.kullaniciAdi, item.sifre };
            dataGridView1.DataSource = calisanlar.ToList();
            lblVeriSayisi.Text = dataGridView1.RowCount + " Kayıt Gösteriliyor".ToString();
        }

        private void txtFiltreSoyad_TextChanged(object sender, EventArgs e)
        {
            string arananSoyad = txtFiltreSoyad.Text;
            var calisanlar = from item in db.calisan
                             where item.Soyad.Contains(arananSoyad)
                             select new { item.Id, item.Ad, item.Soyad, item.Maas, item.departmanId, item.rutbe, item.kullaniciAdi, item.sifre };
            dataGridView1.DataSource = calisanlar.ToList();
            lblVeriSayisi.Text = dataGridView1.RowCount + " Kayıt Gösteriliyor".ToString();
        }

        private void txtFiltreRutbe_TextChanged(object sender, EventArgs e)
        {
            string arananRutbe = txtFiltreRutbe.Text;
            var calisanlar = from item in db.calisan
                             where item.rutbe.Contains(arananRutbe)
                             select new { item.Id, item.Ad, item.Soyad, item.Maas, item.departmanId, item.rutbe, item.kullaniciAdi, item.sifre };
            dataGridView1.DataSource = calisanlar.ToList();
            lblVeriSayisi.Text = dataGridView1.RowCount + " Kayıt Gösteriliyor".ToString();
        }

        private void label26_Click(object sender, EventArgs e)
        {
            yeniKayitGb.Visible = false;
        }

        private void label27_Click(object sender, EventArgs e)
        {
            GuncellemeGb.Visible = false;
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
            return;
        }
    }
}
