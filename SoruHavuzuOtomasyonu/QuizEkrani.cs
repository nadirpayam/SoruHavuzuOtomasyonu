using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace SoruHavuzuOtomasyonu
{
    public partial class QuizEkrani : Form
    {
        public QuizEkrani()
        {
            InitializeComponent();
        }

        //burada sınavı bitirip geri anasayfaya dönmüş oluyoruz
        private void buttonCikis_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cevaplarınız kaydedildi.");
            OgrenciAnaSayfa anasayfa = new OgrenciAnaSayfa();
            anasayfa.Show();
            this.Hide();
        }

        
        
        Classlar.SqlBaglantisi sql = new Classlar.SqlBaglantisi(); // veritabanı bağlantısını sağlıyoruz

        //veritabanından sınav sorularını getiriyoruz

        // 
        void SorulariGetir()
        {
            // 6 SİGMA ALGORİTMASI BURADA YAPILMIŞTIR
            string sorgulamak =// alt satırda daha önce hiç doğru bilinmemiş  yani sigması 0 olan 10 tane random şeklinde soru geliyor
                " select* from(Select top 10 S.SoruID as 'SoruID' from Sorular S, OgrenciCevap OC where S.SoruID != OC.SoruID order by NEWID()) as b union all "+
                // aşağıda ise sigma sayısına bağlı olarak süresi gelmiş sorular geliyor
            "select * from(Select C.SoruID as 'SoruID' from OgrenciCevap C  where C.KullaniciID ='" + Classlar.KullaniciBilgileri.KullaniciID + "'" +
        " AND C.Sigma = 1 AND DATEDIFF(day, SoruTarihi, getdate()) = (select D.Aralik from SureDegistirme D where D.SigmaSayisi = 1) " + // sigması 1 olan sorunun gelmesi için kullanıcının belirlediği süre tarihi gelmiş mi? geldiyse sigması 1 olan sorularda gelsin sınava
       "  OR(C.Sigma = 2 AND DATEDIFF(day, SoruTarihi, getdate()) = (select D.Aralik from SureDegistirme D where D.SigmaSayisi = 2)) " +
         " OR(C.Sigma = 3 AND DATEDIFF(day, SoruTarihi, getdate()) = (select D.Aralik from SureDegistirme D where D.SigmaSayisi = 3)) " +
     "	OR(C.Sigma = 4 AND DATEDIFF(day, SoruTarihi, getdate()) = (select D.Aralik from SureDegistirme D where D.SigmaSayisi = 4)) " +
    "    OR(C.Sigma = 5 AND DATEDIFF(day, SoruTarihi, getdate()) = (select D.Aralik from SureDegistirme D where D.SigmaSayisi = 5))) as a"; // en son 5 sigmalı soru geliyor çünkü sigması 6 olan soru demek  6 kez üst
            // üste doğru cevaplanmış demek yani bir daha sorulmasına gerek yok
       
                    DataTable tbl = new DataTable();
                    SqlDataAdapter adtr = new SqlDataAdapter(sorgulamak, sql.baglan());
                    adtr.Fill(tbl);
                    dataGridViewSorular.DataSource = tbl;
}
        private void QuizEkrani_Load(object sender, EventArgs e)
        {
            textBoxAd.Text = Classlar.KullaniciBilgileri.Ad + " " +  Classlar.KullaniciBilgileri.Soyad ; // sınavı olan kişinin adı soyadı görünüyor
  }
        
    

        // burada sınavın süresini ayarlıyoruz
        private void buttonBaslat_Click_1(object sender, EventArgs e)
        {
            SorulariGetir();

            labelSorusayısı.Text = dataGridViewSorular.RowCount.ToString();
            timer1.Interval = 1000; 
            timer1.Enabled = true;

            
        }

        int zaman = 10; // sınavda göstermelik olsun diye 10 saniyeden geri başlatıcam ki sisteminde çalıştığını test edelim
      
       // int zaman = Convert.ToInt32(labelSorusayısı.Text) * 60 yani soru başına 60 saniye süre veriyoruz
        private void timer1_Tick(object sender, EventArgs e)
        {
            
           if (zaman>0)
            {
               timer1.Interval = 1000; 
                timer1.Enabled = true;
              int sayac = zaman--;
              labelSure.Text = sayac.ToString();
           }
            else if(zaman == 0)
            {
                timer1.Enabled = false;
                MessageBox.Show("Süreniz dolmuştur, cevaplarınız kaydedildi.");
                OgrenciAnaSayfa anasayfa = new OgrenciAnaSayfa();
                anasayfa.Show();
              this.Hide();
          }
        }

      // soruları resim olarak getiriyor, veritabanında binary olarak kaydetmiştik burda gerekli dönüşümü yapıyoruz
        private void dataGridViewSorular_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string sorgu = "select Top 10 Soru, SoruID from Sorular order by newid()";


            SqlCommand komut = new SqlCommand(sorgu, sql.baglan());
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                if (dr["Soru"] != null)
                {
                    byte[] resim = new byte[0];
                    resim = (byte[])dr["Soru"];
                    MemoryStream memoryStream = new MemoryStream(resim);
                    pictureBoxsoru.Image = Image.FromStream(memoryStream);
                    dr.Close();
                    komut.Dispose();
                }


            }
        }
        

        private void buttonGönder_Click_1(object sender, EventArgs e)
        {
            
            string sorgu = "insert into OgrenciCevap(OgrenciCevap,SoruID,KullaniciID,SoruTarihi)values(@cevap,@soru,@kul,@tarih)"; // öğrencinin soruya verdiği cevabı veritabanına kaydediyoruz
            SqlCommand komut = new SqlCommand(sorgu, sql.baglan());
            string cevap; // öğrencinin verdiği cevabın tutullacağı değişkeni tanımlıyoruz 
            // öğrenci hangi şıkkı seçmiş onu belirliyoruz aşağıda
            if (radioButtonA.Checked)
                cevap = radioButtonA.Text;
            else if (radioButtonB.Checked)
                cevap = radioButtonB.Text;
            else if (radioButtonC.Checked)
                cevap = radioButtonC.Text;
            else
                cevap = radioButtonD.Text;


            komut.Parameters.AddWithValue("@cevap", cevap); // öğrencinin verdiği cevap kaydedildi
            komut.Parameters.AddWithValue("@soru", Convert.ToInt32(dataGridViewSorular.CurrentRow.Cells["SoruID"].Value.ToString()));
            komut.Parameters.AddWithValue("@kul", Classlar.KullaniciBilgileri.KullaniciID);
            komut.Parameters.AddWithValue("@tarih", dateTimePicker1.Value);


            komut.ExecuteNonQuery();
            MessageBox.Show("Cevabınız başarılı bir şekilde sisteme kaydedildi.");

            // aşağıda sigma'nın artım azalım işlemlerini yapıyoruz
            string sigma;
            string guncellesorgusu = "Select C.Sigma, S.Cevap from Sorular S inner join OgrenciCevap C on S.SoruID = C.SoruID where S.Cevap = C.OgrenciCevap";
              SqlCommand com = new SqlCommand(guncellesorgusu, sql.baglan());
             SqlDataReader rd = com.ExecuteReader();
            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    textBoxSigma.Text = rd["Sigma"].ToString();
                    textBoxCevap.Text = rd["Cevap"].ToString();
                }
            }
            sigma = textBoxSigma.Text;
           
            if (cevap == textBoxCevap.Text)
            {
               
                sigma += 1;
                textBoxSigma2.Text = sigma.ToString();
             
                string sorgu4 = "UPDATE OgrenciCevap set Sigma='" + textBoxSigma2.Text.ToString() +
                                                                "', KacKezSoruldu+=1, DogruSayisi+=1 where SoruID='" + Convert.ToInt32(dataGridViewSorular.CurrentRow.Cells["SoruID"].Value) + 
                                                                "'";
                string sorgu5 = "UPDATE Sorular set Sigma='" + textBoxSigma2.Text.ToString() +
                                                                "'where SoruID='" + Convert.ToInt32(dataGridViewSorular.CurrentRow.Cells["SoruID"].Value) +
                                                                "'";

                SqlCommand komut4 = new SqlCommand(sorgu4, sql.baglan());
                SqlCommand komut7 = new SqlCommand(sorgu5, sql.baglan());

                komut4.ExecuteNonQuery();
                komut7.ExecuteNonQuery();
            }
            else
            {
               
                string sorgu5 = "update  OgrenciCevap SET Sigma = 0,KacKezSoruldu+=1, YanlisSayisi+=1  where SoruID = '" + Convert.ToInt32(dataGridViewSorular.CurrentRow.Cells["SoruID"].Value) + "'";
                string sorgu7 = "update  Sorular SET Sigma = 0 where SoruID = '" + Convert.ToInt32(dataGridViewSorular.CurrentRow.Cells["SoruID"].Value) + "'"; // eğer soru yanlış bilinmişse sigması 0 oluyor çünkü soru üst üste doğru bilinmesi gerekiyor
                SqlCommand komutuu = new SqlCommand(sorgu5,sql.baglan());
                SqlCommand komutuun = new SqlCommand(sorgu7, sql.baglan());
                komutuu.ExecuteNonQuery();
                komutuun.ExecuteNonQuery();
            }
            textBoxSigma2.Clear();
            textBoxSigma.Clear();
            textBoxCevap.Clear();

            radioButtonA.Checked = false;
            radioButtonB.Checked = false;
            radioButtonC.Checked = false;
            radioButtonD.Checked = false;

            int a = Convert.ToInt32(labelsorusayisii.Text);
            a += 1;
            labelsorusayisii.Text = a.ToString();


        }


        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
   }
    }
    }

