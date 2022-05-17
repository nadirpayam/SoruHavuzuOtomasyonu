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
using System.Text.RegularExpressions;
using System.Net.Mail;

namespace SoruHavuzuOtomasyonu
{
    public partial class UyeOl : Form
    {
        public UyeOl()
        {
            InitializeComponent();
          
        }

        //burada veritabanı bağlantısı için Classlar klasöründen SqlBaglantis sınıfının nesnesini oluşturuyoruz
        Classlar.SqlBaglantisi sql = new Classlar.SqlBaglantisi();
        

        private void button1_Click(object sender, EventArgs e)
        {
            // burada kullanıcının verilen bilgileri eksik girip girmediği kontrol ediliyor
            if (textBoxAd.Text == "" || textBoxSoyad.Text == ""  || textBoxKulAd.Text == ""  || textBoxMail.Text == "" || textBoxSifre.Text == "")
            {
                MessageBox.Show("Lütfen tüm alanları doldurun");
            }
            else
            {
                // eğer tüm bilgileri girmişse bu bilgiler veritabanına kaydediliyor
                string sorgu = "insert into Kullanicilar(KullaniciAd,Ad,Soyad,Mail,Sifre)values(@kulad,@ad,@soyad,@mail,@sifre)";
                SqlCommand komut = new SqlCommand(sorgu, sql.baglan());
                
                komut.Parameters.AddWithValue("@kulad", textBoxKulAd.Text);
                komut.Parameters.AddWithValue("@ad", textBoxAd.Text);
                komut.Parameters.AddWithValue("@soyad", textBoxSoyad.Text);
                komut.Parameters.AddWithValue("@mail", textBoxMail.Text);
                komut.Parameters.AddWithValue("@sifre", textBoxSifre.Text);
                komut.ExecuteNonQuery();
                MessageBox.Show("Kaydınız başarıyla oluşturulmuştur.");
            }

        }
        // burada kullanıcının şifresini girerken şifresinin görünürlüğünü kontrol etmesini sağlıyoruz
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

        //burada kullanıcı anasayfaya dönmek isterse butona bastığında dönmesini sağlıyoruz
        private void buttonAnasayfa_Click(object sender, EventArgs e)
        {
            Anasayfa anasayfa = new Anasayfa();
            anasayfa.Show();
            this.Hide();
        }

        //burada eğer kullanıcı kaydolmuşssa direkt giriş ekranına geçmesini sağlıyoruz
        private void buttonGirisYap_Click(object sender, EventArgs e)
        {
            OgrenciGiris giris = new OgrenciGiris();
            giris.Show();
            this.Hide();
        }

        //burada kullanıcının uygulamadan çıkmasını sağlıyoruz
        private void buttonCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBoxMail_Leave(object sender, EventArgs e)
        {
            
                string pattern = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";
                if (Regex.IsMatch(textBoxMail.Text, pattern))
                {
                    errorProvider1.Clear();
                }
                else
                {
                    errorProvider1.SetError(this.textBoxMail, "Lutfen calisan mail adresi girin");
                    return;
                }
            }
    }
}



     
        

       