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
    public partial class GunDegistirme : Form
    {
        public GunDegistirme()
        {
            InitializeComponent();
        }

        Classlar.SqlBaglantisi sql = new Classlar.SqlBaglantisi();

        public string ogrenci;
        void Getir()
        {
            string sorgulamak = "Select D.SigmaSayisi, D.Aralik from SureDegistirme D";
            DataTable tbl = new DataTable();
            SqlDataAdapter adtr = new SqlDataAdapter(sorgulamak, sql.baglan());
            adtr.Fill(tbl);
            dataGridViewDegistirme.DataSource = tbl;
        }
        private void GunDegistirme_Load(object sender, EventArgs e)
        {
           

            Getir();
           
        }

        private void buttondegisiklik_Click(object sender, EventArgs e)
        {
            string sorgu = "UPDATE  SureDegistirme set Aralik=@aralik WHERE Sigmasayisi=@sigma";
           SqlCommand  komut = new SqlCommand(sorgu, sql.baglan());
            komut.Parameters.AddWithValue("@sigma", Convert.ToInt32(dataGridViewDegistirme.CurrentRow.Cells["SigmaSayisi"].Value));
            komut.Parameters.AddWithValue("@aralik", textBoxDegistirme.Text);
         
            komut.ExecuteNonQuery();
            Getir();
              MessageBox.Show("Sorunun çıkma sıklığı değiştirildi.");
        }

        private void labeldegistrime_Click(object sender, EventArgs e)
        {

        }

        private void buttonVazgec_Click(object sender, EventArgs e)
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
