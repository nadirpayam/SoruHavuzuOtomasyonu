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

        // burada uygulamadan çıkışı sağlıyoruz isteğe bağlı
        private void buttonCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // soruları veritabanından getiren method
        void SorulariGetir()
        {
            DataTable tbl = new DataTable();
            SqlDataAdapter adtr = new SqlDataAdapter("Select * from Sorular", sql.baglan());
            adtr.Fill(tbl);
            dataGridViewSorular.DataSource = tbl;
        }

        // form açılır açılmaz sorular yükleniyor datagridview'e bu şekilde
        private void AdminKontrol_Load(object sender, EventArgs e)
        {

            SorulariGetir();
        }

        // admin isterse anasayfaya da dönebilir
        private void buttonAnasayfa_Click(object sender, EventArgs e)
        {
            Anasayfa anasayfa = new Anasayfa();
            anasayfa.Show();
            this.Hide();
        }

        // veritabanı bağlantısı için bir nesne oluşturduk 
        Classlar.SqlBaglantisi sql = new Classlar.SqlBaglantisi();


        //burada eğer admin soruyu onaylamazsa soru kayıtlar arasından kaldırılıyor
        private void buttonOnaylama_Click(object sender, EventArgs e)
        {
            string sorgu = "DELETE FROM Sorular WHERE SoruID=@id";
            SqlCommand komut = new SqlCommand(sorgu, sql.baglan());
            komut.Parameters.AddWithValue("@id", dataGridViewSorular.CurrentRow.Cells[0].Value);
            komut.ExecuteNonQuery();

            MessageBox.Show("Admin Soruyu Onaylamadı, soru kaldırıldı.");
            SorulariGetir();
        }

      

        // burada sorular veritabanından datagridview'e aktarılıyor
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

      // admin soruyu onaylarsa veritabanına sorunun onay durumu 'Onaylandı' olarak değişiyor
        private void buttonOnayla_Click(object sender, EventArgs e)
        {

            string sorgu = "UPDATE Sorular set OnayDurumu=@onay WHERE SoruID=@id"; // sql sorgusuyla OnayDurumu'nu değiştiriyoruz
            SqlCommand komut = new SqlCommand(sorgu, sql.baglan());
            komut.Parameters.AddWithValue("@id", Convert.ToInt32(dataGridViewSorular.CurrentRow.Cells[0].Value));
            komut.Parameters.AddWithValue("@onay", "Onaylandı");
            
            komut.ExecuteNonQuery();
           MessageBox.Show("Soru onaylandı");
             
              SorulariGetir(); // soru onaylandıktan sonra sorulaın bilgileri yenileniyor direkt


        }
    }
}
        