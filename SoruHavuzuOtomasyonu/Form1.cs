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
    public partial class Anasayfa : Form
    {
        public Anasayfa()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonSorumluGiris_Click(object sender, EventArgs e)
        {
            SinavSorumlusuGiris sorumlu = new SinavSorumlusuGiris();
            sorumlu.Show();
            this.Hide();
        }

        private void buttonOgrenciGiris_Click(object sender, EventArgs e)
        {
            OgrenciGiris ogrenci = new OgrenciGiris();
            ogrenci.Show();
            this.Hide();
        }

        private void buttonUyeOl_Click(object sender, EventArgs e)
        {
            UyeOl üye = new UyeOl();
            üye.Show();
            this.Hide();
        }

        private void buttonAdminGiris_Click(object sender, EventArgs e)
        {
            AdminGiris admin = new AdminGiris();
            admin.Show();
            this.Hide();
        }
    }
}
