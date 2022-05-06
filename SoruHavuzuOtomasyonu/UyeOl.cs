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

        Classlar.SqlBaglantisi sql = new Classlar.SqlBaglantisi();
        

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxAd.Text == "" || textBoxSoyad.Text == ""  || textBoxKulAd.Text == ""  || textBoxMail.Text == "" || textBoxSifre.Text == "")
            {
                MessageBox.Show("Lütfen tüm alanları doldurun");
            }
            else
            {
                string sorgu = "insert into Kullanicilar(KullaniciTipId,KullaniciAd,Ad,Soyad,Mail,Sifre)values(@kulId,@kulad,@ad,@soyad,@mail,@sifre)";
                SqlCommand komut = new SqlCommand(sorgu, sql.baglan());
                komut.Parameters.AddWithValue("@kulId", 3);
                komut.Parameters.AddWithValue("@kulad", textBoxKulAd.Text);
                komut.Parameters.AddWithValue("@ad", textBoxAd.Text);
                komut.Parameters.AddWithValue("@soyad", textBoxSoyad.Text);
                komut.Parameters.AddWithValue("@mail", textBoxMail.Text);
                komut.Parameters.AddWithValue("@sifre", textBoxSifre.Text);
                komut.ExecuteNonQuery();
                MessageBox.Show("Kaydınız başarıyla oluşturulmuştur.");
            }

        }

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

        private void buttonAnasayfa_Click(object sender, EventArgs e)
        {
            Anasayfa anasayfa = new Anasayfa();
            anasayfa.Show();
            this.Hide();
        }

        private void buttonGirisYap_Click(object sender, EventArgs e)
        {
            OgrenciGiris giris = new OgrenciGiris();
            giris.Show();
            this.Hide();
        }
    }
}



     
        

       