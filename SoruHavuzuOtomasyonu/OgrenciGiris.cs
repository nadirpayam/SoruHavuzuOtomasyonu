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

      

        Classlar.SqlBaglantisi sql = new Classlar.SqlBaglantisi();
       

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SifremiUnuttum sifre = new SifremiUnuttum();
            sifre.Show();
            this.Hide();
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
            OgrenciGiris giris = new OgrenciGiris();
            giris.Show();
            this.Hide();
        }

        private void buttonGirisYap_Click(object sender, EventArgs e)
        {
            if (textBoxKulAd.Text == "" || textBoxSifre.Text == "")
            {
                MessageBox.Show("Kullanıcı adı veya şifre boş geçilmez.");
            }
            else
            {
                SqlCommand komut = new SqlCommand("select * from Kullanicilar where KullaniciAd='" + textBoxKulAd.Text + "'and Sifre = '" + textBoxSifre.Text + "'", sql.baglan());
            
                SqlDataReader dr = komut.ExecuteReader();
                if (dr.Read())
                {
                    MessageBox.Show("Aferin");
                }
                else
                {
                    MessageBox.Show("Kullanıcı  adı veya şifresi yanlış");
                    textBoxKulAd.Clear();
                    textBoxSifre.Clear();

                }
            }
           
        }

        private void buttonCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}



