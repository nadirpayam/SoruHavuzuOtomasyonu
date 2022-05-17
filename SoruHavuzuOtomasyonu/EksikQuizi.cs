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
    public partial class EksikQuizi : Form
    {
        public EksikQuizi()
        {
            InitializeComponent();
        }
        Classlar.SqlBaglantisi sql = new Classlar.SqlBaglantisi();

       
        private void EksikQuizi_Load(object sender, EventArgs e)
        {
            SorulariGetir();
        }
        void SorulariGetir()
        {
            string sorgulamak = "Select  top 10 S.Soru , S.SoruID from Sorular S  where S.Sigma = 0  order by newid()";
            DataTable tbl = new DataTable();
            SqlDataAdapter adtr = new SqlDataAdapter(sorgulamak, sql.baglan());
            adtr.Fill(tbl);
            dataGridViewSorular.DataSource = tbl;
        }
        private void dataGridViewSorular_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string sorgu = "Select top 10 Soru, S.SoruID from Sorular S, OgrenciCevap C where S.SoruID = C.SoruID and C.Sigma = 0  and  C.KullaniciID ='" + Classlar.KullaniciBilgileri.KullaniciID + "'" + " order by NEWID()";
           

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

        private void buttonGönder_Click(object sender, EventArgs e)
        {
            string cevap;
               if (radioButtonA.Checked)
                  cevap = radioButtonA.Text;
              else if (radioButtonB.Checked)
                  cevap = radioButtonB.Text;
              else if (radioButtonC.Checked)
                  cevap = radioButtonC.Text;
            else
                 cevap = radioButtonD.Text;
            string guncellesorgusu = "Select S.Cevap from Sorular S where S.Sigma = 0";
           SqlCommand com = new SqlCommand(guncellesorgusu, sql.baglan());
       SqlDataReader rd = com.ExecuteReader();
               if (rd.HasRows)
               {
                  while (rd.Read())
                   {
                     
                      textBoxCevap.Text = rd["Cevap"].ToString();
               }
                }
               

               if (cevap == textBoxCevap.Text)
              {
                int a = Convert.ToInt32(labelDogruSayısı.Text);
                a += 1;
                labelDogruSayısı.Text = a.ToString();
               
               }
            else
             {
                int b = Convert.ToInt32(labelYanlisSayisi.Text);
                b += 1;
                labelYanlisSayisi.Text = b.ToString();
            }

           
        }

        
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
