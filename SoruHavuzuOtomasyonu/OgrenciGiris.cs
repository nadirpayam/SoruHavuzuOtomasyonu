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
    public partial class OgrenciGiris : Form
    {
        public OgrenciGiris()
        {
            InitializeComponent();
        }

      
        // Burada Sql baglantısını kurmak için Classlar klasöründen SqlBaglantisi sınıfını çalışıtırıyoruz
        Classlar.SqlBaglantisi sql = new Classlar.SqlBaglantisi();
        //Burda giriş yapan kullanıcının bilgilerini Classlar klasöründekiki Bilgiler sınıfına kaydediyoruz ki sonra lazım olursa oradan çekelim
        public Classlar.KullaniciBilgileri bilgiler = new Classlar.KullaniciBilgileri();

        // Şifresini unutan kullanıcının yönlendirileceği ekrana götüren kod 
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SifremiUnuttum sifre = new SifremiUnuttum();
            sifre.Show();
            this.Hide();
        }
        // burada kullanıcı şifresini doğru girip girmediğine bakmak için göster / gizli ayarını yapabiliyor
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

        //bu buton kullanıcını anasayfaya yönlendiriyor
        private void buttonAnasayfa_Click(object sender, EventArgs e)
        {
            Anasayfa anasayfa = new Anasayfa();
            anasayfa.Show();
            this.Hide();
        }

        // burada kullanıcının bilgilerinin doğru olup olmadığını kontrol ediyoruz, kayıt doğruysa Ogrenci Anasayfa ekranına götürüyor bizi
        private void buttonGirisYap_Click(object sender, EventArgs e)
        {
            if (textBoxKulAd.Text == "" || textBoxSifre.Text == "")
            {
                MessageBox.Show("Kullanıcı adı veya şifre boş geçilmez.");
            }
            else
            { 
                DataSet ds = new DataSet();
                string sql2 = "select * from Kullanicilar where KullaniciAd = '" + textBoxKulAd.Text + "'and Sifre = '" + textBoxSifre.Text + "'";
                SqlDataAdapter da = new SqlDataAdapter(sql2, sql.baglan());
                ds = new DataSet();
                da.Fill(ds, "KULLANICIDENEME");
                //con.Close();

                if (ds.Tables[0].Rows.Count > 0)
                {
                    // burada giren kullanıcının bilgilerini veritabnından çekiyoruz
                    string KullaniciIDtxt = ds.Tables[0].Rows[0]["KullaniciID"].ToString();
                    string Adtxt = ds.Tables[0].Rows[0]["Ad"].ToString();
                    string Soyadtxt = ds.Tables[0].Rows[0]["Soyad"].ToString();
                    string KullaniciAdtxt = ds.Tables[0].Rows[0]["KullaniciAd"].ToString();
                    string Mailtxt = ds.Tables[0].Rows[0]["Mail"].ToString();


                   // burada veritabanından çektiğimiz bilgileri class'a ekliyoruz
                    Classlar.KullaniciBilgileri.KullaniciID = Convert.ToInt32(KullaniciIDtxt);
                    Classlar.KullaniciBilgileri.Ad = Adtxt;
                    Classlar.KullaniciBilgileri.Soyad = Soyadtxt;
                    Classlar.KullaniciBilgileri.KullaniciAd = KullaniciAdtxt;
                    Classlar.KullaniciBilgileri.Mail = Mailtxt;

                    //////burada öğrenci anasayfasına yönlendiriyoruz
                    OgrenciAnaSayfa ogrenciAnaSayfa = new OgrenciAnaSayfa();
                    ogrenciAnaSayfa.Show();
                    this.Hide();
                    //Kontrol kont = new Kontrol();
                    //kont.Show();
                    //this.Hide();
                  
                }

                else
                {
                    //burada kullanıcı eğer yanlış bir bir kayıt girdiyse uyarı veriyoruz
                    MessageBox.Show("Kullanıcı  adı veya şifresi yanlış");
                    textBoxKulAd.Clear();
                    textBoxSifre.Clear();

                }
            }
}

       // burada uygulamadan çıkış butonu var
        private void buttonCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonOgrAnasayfa_Click(object sender, EventArgs e)
        {
            OgrenciAnaSayfa anaSayfa = new OgrenciAnaSayfa();
            anaSayfa.Show();
            this.Hide();
        }
    }
    }




