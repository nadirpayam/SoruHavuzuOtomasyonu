using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace SoruHavuzuOtomasyonu
{
    public partial class SinavSorumlusuGiris : Form
    {
        public SinavSorumlusuGiris()
        {
            InitializeComponent();
        }
        //burada sınav sorumlusunun uygulamadan çıkmasını sağlıyoruz
        private void buttonCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        Classlar.SqlBaglantisi sql = new Classlar.SqlBaglantisi();
        private void buttonGirisYap_Click(object sender, EventArgs e)
        {
            // burada sınav sorumlusunun bilgilerini eksik girip girmediği kontrol ediyoruz, eksik girdiyse uyarı veriyoruz
            if (textBoxKulAd.Text == "" || textBoxSifre.Text == "")
            {
                MessageBox.Show("Kullanıcı adı veya şifre boş geçilmez.");
            }
            else
            {
                SqlCommand komut = new SqlCommand("select * from SinavSorumlusu where KulAd='" + textBoxKulAd.Text + "'and Sifre = '" + textBoxSifre.Text + "'", sql.baglan());
                
                SqlDataReader dr = komut.ExecuteReader();
                if (dr.Read())
                {
                    SoruEklemeEkrani soruekle = new SoruEklemeEkrani();  // sınav sorumlusu bilgilerini doğru girdiyse soru ekleme sayfasına yönlendiriliyor
                    soruekle.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Kullanıcı  adı veya şifresi yanlış"); // admin şifresini yanlış girdiyse uyarı alıyor
                    textBoxKulAd.Clear();
                    textBoxSifre.Clear();

                }
            }
          

        }
        //burada anasayfaya dönüşü sağlıyoruz
        private void buttonAnasayfa_Click(object sender, EventArgs e)
        {
            Anasayfa anasayfa = new Anasayfa();
            anasayfa.Show();
            this.Hide();
        }

        // burada sınav sorumlusunun şifresini girerken şifresinin görünürlüğünü kontrol etmesini sağlıyoruz
        private void checkBoxGoster_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxGoster.CheckState == CheckState.Checked)
            {
                textBoxSifre.UseSystemPasswordChar = true;
                checkBoxGoster.Text = "Gizle";
            }
            else if (checkBoxGoster.CheckState == CheckState.Unchecked)
            {
                textBoxSifre.UseSystemPasswordChar = false;
                checkBoxGoster.Text = "Göster";
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SifremiUnuttum sifre = new SifremiUnuttum();
            sifre.Show();
            this.Hide();
        }
    }
}
