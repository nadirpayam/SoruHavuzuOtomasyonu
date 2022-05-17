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
using System.Net;
using System.Net.Mail;

namespace SoruHavuzuOtomasyonu
{
    public partial class SifremiUnuttum : Form
    {
        public SifremiUnuttum()
        {
            InitializeComponent();
        }

        //burada kullanıcının uygulamadan çıkmasını sağlıyoruz
        private void buttonCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //burada veritabanı bağlantısı için Classlar klasöründen SqlBaglantis sınıfının nesnesini oluşturuyoruz
        Classlar.SqlBaglantisi bgln = new Classlar.SqlBaglantisi();
        private void buttonGonder_Click(object sender, EventArgs e)
        {
          
            SqlCommand komut = new SqlCommand("Select * from Kullanicilar where KullaniciAd='" + textBoxKulAd.Text.ToString() +
              "' and Mail ='" + textBoxMail.Text.ToString() + "'", bgln.baglan());
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                try
                {
                    if (bgln.baglan().State == ConnectionState.Closed)
                    {
                        bgln.baglan().Open();
                    }
                    SmtpClient smtpserver = new SmtpClient();
                    MailMessage mail = new MailMessage();
                    String tarih = DateTime.Now.ToShortDateString();
                    String mailadresi = ("otomasyonmart2020@gmail.com"); // maili göndereceğimiz gmail hesabımızı giriyoruz
                    String sifre = "oto20012022"; // maili göndereceğimiz gmail hesabının şifresini giriyoruz
                    String smtpsrvr = "smtp.gmail.com"; // gmail serverını kullanıyoruz
                    String kime = (oku["Mail"].ToString());
                    String konu = ("Şifre Hatırlatma Maili"); // mailin konusunu giriyoruz
                    String yaz = ("Sayın, " + oku["Ad"].ToString() + " " + oku["Soyad"].ToString() + ", bizden " + tarih + " tarihinde şifre hatırlatma talebinde bulundunuz." // gidecek maili giriyoruz
                   + "\n" + " Parolanız: " + oku["Sifre"].ToString());
                    smtpserver.Credentials = new NetworkCredential(mailadresi, sifre);
                    smtpserver.Port = 587; // 587 gmail server'ıdır
                    smtpserver.Host = smtpsrvr;
                    smtpserver.EnableSsl = true;
                    mail.From = new MailAddress(mailadresi);
                    mail.To.Add(kime); // mailin kime gönderileceği belirleniyor
                    mail.Subject = konu;
                    mail.Body = yaz;
                    smtpserver.Send(mail);
                    DialogResult bilgi = new DialogResult();
                    bilgi = MessageBox.Show("Girmiş olduğunuz bilgiler uyuşuyor. Şifreniz Mail Adresinize gönderildi."); // kullanıcının girdiği bilgiler doğruysa şifrenin gönderildiğini kullanıcıya bildiriyoruz
                }
                catch (Exception hata)
                {
                    MessageBox.Show("Mail gönderme hatası!" + hata.Message); // mail gönderilmezse, gönderilmeme nedenyile birlikte kullanıcıya bilgi veriyoruz
                }
            }
        }

        //burada kullanıcı anasayfaya dönmek isterse butona bastığında dönmesini sağlıyoruz
        private void buttonAnasayfa_Click(object sender, EventArgs e)
        {
           Anasayfa anasayfa = new Anasayfa();
               anasayfa.Show();
                this.Hide();
        }
    }
}
