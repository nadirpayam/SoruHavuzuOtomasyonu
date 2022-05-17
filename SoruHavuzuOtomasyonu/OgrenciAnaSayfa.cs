using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoruHavuzuOtomasyonu
{
    public partial class OgrenciAnaSayfa : Form
    {
        public OgrenciAnaSayfa()
        {
            InitializeComponent();
        }

       

        private void buttonCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonAyarlar_Click(object sender, EventArgs e)
        {
            GunDegistirme gun = new GunDegistirme();
            gun.Show();
            this.Hide();
        }

        private void buttonAnaliz_Click(object sender, EventArgs e)
        {
            AnalizYap analiz = new AnalizYap();
            analiz.Show();
            this.Hide();
        }

        private void buttonEksikSinav_Click(object sender, EventArgs e)
        {
            EksikQuizi eksik = new EksikQuizi();
            eksik.Show();
            this.Hide();
        }

        private void buttonSinavaGiris_Click(object sender, EventArgs e)
        {
            QuizEkrani quiz = new QuizEkrani();
            quiz.Show();
            this.Hide();
        }

        private void buttonAnasayfa_Click(object sender, EventArgs e)
        {
            Anasayfa anasayfa = new Anasayfa();
            anasayfa.Show();
            this.Hide();
        }
    }
}
