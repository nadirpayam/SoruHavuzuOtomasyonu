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
using System.IO;

namespace SoruHavuzuOtomasyonu
{
    public partial class SoruEklemeEkrani : Form
    {
        public SoruEklemeEkrani()
        {
            InitializeComponent();
        }
        Classlar.SqlBaglantisi sql = new Classlar.SqlBaglantisi();
        private void buttonEkle_Click(object sender, EventArgs e)
        {

            if (textBoxSinifDuzeyi.Text == "" || textBoxUniteNo.Text == "" || textBoxKonuNo.Text == "" || textBoxSoruNo.Text == "" || textBoxKodNo.Text == ""
                || textBoxDersinAdi.Text == "" || textBoxUniteAd.Text == "" || textBoxKonuAd.Text == "" || textBoxCevap.Text == "")
            {
                MessageBox.Show("Lütfen tüm alanları doldurun");
            }
            else
            {
                FileStream fileStream = new FileStream(imagepath, FileMode.Open, FileAccess.Read);
                BinaryReader binaryReader = new BinaryReader(fileStream);
                byte[] resim = binaryReader.ReadBytes((int)fileStream.Length);
                binaryReader.Close();
                fileStream.Close();



                string sorgu = "insert into Sorular(Soru,SinifDuzeyi,UniteNo,KonuNo,SoruNo,KodNo,DersinAdi,UniteAdi,KonuAdi,Cevap)values(@soru,@duzey,@uniteno,@konuno,@soruno,@kod,@ders,@unitead,@konuad,@cevap)";
                SqlCommand komut = new SqlCommand(sorgu, sql.baglan());
                komut.Parameters.Add("@soru", SqlDbType.Image, resim.Length).Value = resim;

                komut.Parameters.AddWithValue("@duzey", textBoxSinifDuzeyi.Text);
                komut.Parameters.AddWithValue("@uniteno", textBoxUniteNo.Text);
                komut.Parameters.AddWithValue("@konuno", textBoxKonuNo.Text);
                komut.Parameters.AddWithValue("@soruno", textBoxSoruNo.Text);
                komut.Parameters.AddWithValue("@kod", textBoxKodNo.Text);
                komut.Parameters.AddWithValue("@ders", textBoxDersinAdi.Text);
                komut.Parameters.AddWithValue("@unitead", textBoxUniteAd.Text);
                komut.Parameters.AddWithValue("@konuad", textBoxKonuAd.Text);
                komut.Parameters.AddWithValue("@cevap", textBoxCevap.Text);
                komut.ExecuteNonQuery();
                MessageBox.Show("Soru başarıyla eklendi.");

              //  textBoxSinifDuzeyi.Clear();
             //   textBoxUniteNo.Clear();
              //  textBoxKonuNo.Clear();
                textBoxSoruNo.Clear();
               // textBoxKodNo.Clear();
               // textBoxDersinAdi.Clear();
              //  textBoxUniteAd.Clear();
              //  textBoxKonuAd.Clear();
                textBoxCevap.Clear();


            }
        }

        string imagepath;
        private void buttonResimEkle_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBoxsoru.Image = Image.FromFile(openFileDialog1.FileName);
                imagepath = openFileDialog1.FileName;
            }
        }

        private void buttonCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //burada sinav sorumlusu anasayfaya dönmek isterse butona bastığında dönmesini sağlıyoruz
        private void buttonAnasayfa_Click(object sender, EventArgs e)
        {
            Anasayfa anasayfa = new Anasayfa();
            anasayfa.Show();
            this.Hide();
        }
    }
}
