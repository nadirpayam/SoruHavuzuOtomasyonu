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
    public partial class AdminKontrol : Form
    {
        public AdminKontrol()
        {
            InitializeComponent();
        }

        private void buttonCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        void SorulariGetir()
        {
            DataTable tbl = new DataTable();
            SqlDataAdapter adtr = new SqlDataAdapter("Select * from Sorular", sql.baglan());
            adtr.Fill(tbl);
            dataGridViewSorular.DataSource = tbl;
        }
        private void AdminKontrol_Load(object sender, EventArgs e)
        {

            SorulariGetir();
        }

        private void buttonAnasayfa_Click(object sender, EventArgs e)
        {
            Anasayfa anasayfa = new Anasayfa();
            anasayfa.Show();
            this.Hide();
        }
        Classlar.SqlBaglantisi sql = new Classlar.SqlBaglantisi();

        private void buttonOnaylama_Click(object sender, EventArgs e)
        {
            string sorgu = "DELETE FROM Sorular WHERE SoruID=@id";
            SqlCommand komut = new SqlCommand(sorgu, sql.baglan());
            komut.Parameters.AddWithValue("@id", dataGridViewSorular.CurrentRow.Cells[0].Value);
            komut.ExecuteNonQuery();

            MessageBox.Show("Admin Soruyu Onaylamadı, soru kaldırıldı.");
            SorulariGetir();
        }

        private void dataGridViewSorular_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewSorular_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            SqlCommand komut = new SqlCommand("select * from Sorular where SoruID='" + int.Parse(dataGridViewSorular.CurrentRow.Cells[0].Value.ToString()) + " ' ", sql.baglan());
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

     
        private void buttonOnayla_Click(object sender, EventArgs e)
        {

            string sorgu = "UPDATE Sorular set OnayDurumu=@onay WHERE SoruID=@id";
            SqlCommand komut = new SqlCommand(sorgu, sql.baglan());
            komut.Parameters.AddWithValue("@id", Convert.ToInt32(dataGridViewSorular.CurrentRow.Cells[0].Value));
            komut.Parameters.AddWithValue("@onay", "Onaylandı");
            
            komut.ExecuteNonQuery();
            

            MessageBox.Show("Soru onaylandı");
             
              SorulariGetir();


        }
    }
}
        