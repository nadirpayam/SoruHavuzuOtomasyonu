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

        private void buttonSinavaGir_Click(object sender, EventArgs e)
        {
            QuizEkrani quiz = new QuizEkrani();
            quiz.Show();
            this.Hide();
        }
    }
}
