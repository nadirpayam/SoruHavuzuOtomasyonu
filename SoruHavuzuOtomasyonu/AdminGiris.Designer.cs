
namespace SoruHavuzuOtomasyonu
{
    partial class AdminGiris
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.LinkLabel linkLabel1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminGiris));
            this.buttonCikis = new System.Windows.Forms.Button();
            this.buttonGirisYap = new System.Windows.Forms.Button();
            this.buttonAnasayfa = new System.Windows.Forms.Button();
            this.checkBoxGoster = new System.Windows.Forms.CheckBox();
            this.textBoxSifre = new System.Windows.Forms.TextBox();
            this.textBoxKulAd = new System.Windows.Forms.TextBox();
            this.labelSifre = new System.Windows.Forms.Label();
            this.labelKulAd = new System.Windows.Forms.Label();
            this.labelAdminGiris = new System.Windows.Forms.Label();
            linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // linkLabel1
            // 
            linkLabel1.BackColor = System.Drawing.Color.Transparent;
            linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            linkLabel1.ForeColor = System.Drawing.Color.DarkBlue;
            linkLabel1.LinkColor = System.Drawing.Color.White;
            linkLabel1.Location = new System.Drawing.Point(340, 420);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new System.Drawing.Size(193, 23);
            linkLabel1.TabIndex = 57;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Şifremi Unuttum";
            linkLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // buttonCikis
            // 
            this.buttonCikis.BackColor = System.Drawing.Color.Transparent;
            this.buttonCikis.FlatAppearance.BorderSize = 0;
            this.buttonCikis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCikis.Font = new System.Drawing.Font("Constantia", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonCikis.ForeColor = System.Drawing.Color.Maroon;
            this.buttonCikis.Location = new System.Drawing.Point(625, 3);
            this.buttonCikis.Name = "buttonCikis";
            this.buttonCikis.Size = new System.Drawing.Size(85, 76);
            this.buttonCikis.TabIndex = 58;
            this.buttonCikis.Text = "X";
            this.buttonCikis.UseVisualStyleBackColor = false;
            this.buttonCikis.Click += new System.EventHandler(this.buttonCikis_Click);
            // 
            // buttonGirisYap
            // 
            this.buttonGirisYap.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonGirisYap.BackgroundImage")));
            this.buttonGirisYap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonGirisYap.Location = new System.Drawing.Point(336, 336);
            this.buttonGirisYap.Name = "buttonGirisYap";
            this.buttonGirisYap.Size = new System.Drawing.Size(197, 55);
            this.buttonGirisYap.TabIndex = 56;
            this.buttonGirisYap.UseVisualStyleBackColor = true;
            this.buttonGirisYap.Click += new System.EventHandler(this.buttonGirisYap_Click);
            // 
            // buttonAnasayfa
            // 
            this.buttonAnasayfa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonAnasayfa.BackgroundImage")));
            this.buttonAnasayfa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonAnasayfa.Location = new System.Drawing.Point(12, 446);
            this.buttonAnasayfa.Name = "buttonAnasayfa";
            this.buttonAnasayfa.Size = new System.Drawing.Size(90, 67);
            this.buttonAnasayfa.TabIndex = 55;
            this.buttonAnasayfa.UseVisualStyleBackColor = true;
            this.buttonAnasayfa.Click += new System.EventHandler(this.buttonAnasayfa_Click);
            // 
            // checkBoxGoster
            // 
            this.checkBoxGoster.AutoSize = true;
            this.checkBoxGoster.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxGoster.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBoxGoster.ForeColor = System.Drawing.Color.White;
            this.checkBoxGoster.Location = new System.Drawing.Point(570, 266);
            this.checkBoxGoster.Name = "checkBoxGoster";
            this.checkBoxGoster.Size = new System.Drawing.Size(107, 33);
            this.checkBoxGoster.TabIndex = 54;
            this.checkBoxGoster.Text = "Göster";
            this.checkBoxGoster.UseVisualStyleBackColor = false;
            this.checkBoxGoster.CheckedChanged += new System.EventHandler(this.checkBoxGoster_CheckedChanged);
            // 
            // textBoxSifre
            // 
            this.textBoxSifre.Location = new System.Drawing.Point(336, 260);
            this.textBoxSifre.Multiline = true;
            this.textBoxSifre.Name = "textBoxSifre";
            this.textBoxSifre.PasswordChar = '*';
            this.textBoxSifre.Size = new System.Drawing.Size(197, 39);
            this.textBoxSifre.TabIndex = 53;
            // 
            // textBoxKulAd
            // 
            this.textBoxKulAd.Location = new System.Drawing.Point(336, 176);
            this.textBoxKulAd.Multiline = true;
            this.textBoxKulAd.Name = "textBoxKulAd";
            this.textBoxKulAd.Size = new System.Drawing.Size(197, 39);
            this.textBoxKulAd.TabIndex = 52;
            // 
            // labelSifre
            // 
            this.labelSifre.BackColor = System.Drawing.Color.Transparent;
            this.labelSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelSifre.ForeColor = System.Drawing.Color.DarkBlue;
            this.labelSifre.Location = new System.Drawing.Point(29, 257);
            this.labelSifre.Name = "labelSifre";
            this.labelSifre.Size = new System.Drawing.Size(276, 42);
            this.labelSifre.TabIndex = 51;
            this.labelSifre.Text = "Şifre:";
            this.labelSifre.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelKulAd
            // 
            this.labelKulAd.BackColor = System.Drawing.Color.Transparent;
            this.labelKulAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelKulAd.ForeColor = System.Drawing.Color.DarkBlue;
            this.labelKulAd.Location = new System.Drawing.Point(29, 173);
            this.labelKulAd.Name = "labelKulAd";
            this.labelKulAd.Size = new System.Drawing.Size(276, 42);
            this.labelKulAd.TabIndex = 50;
            this.labelKulAd.Text = "Kullanıcı Adı:";
            this.labelKulAd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelAdminGiris
            // 
            this.labelAdminGiris.BackColor = System.Drawing.Color.Transparent;
            this.labelAdminGiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelAdminGiris.ForeColor = System.Drawing.Color.DarkBlue;
            this.labelAdminGiris.Location = new System.Drawing.Point(124, 35);
            this.labelAdminGiris.Name = "labelAdminGiris";
            this.labelAdminGiris.Size = new System.Drawing.Size(422, 71);
            this.labelAdminGiris.TabIndex = 49;
            this.labelAdminGiris.Text = "ADMİN GİRİŞİ";
            this.labelAdminGiris.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AdminGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(720, 538);
            this.Controls.Add(this.buttonCikis);
            this.Controls.Add(linkLabel1);
            this.Controls.Add(this.buttonGirisYap);
            this.Controls.Add(this.buttonAnasayfa);
            this.Controls.Add(this.checkBoxGoster);
            this.Controls.Add(this.textBoxSifre);
            this.Controls.Add(this.textBoxKulAd);
            this.Controls.Add(this.labelSifre);
            this.Controls.Add(this.labelKulAd);
            this.Controls.Add(this.labelAdminGiris);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminGiris";
            this.Text = "cd ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCikis;
        private System.Windows.Forms.Button buttonGirisYap;
        private System.Windows.Forms.Button buttonAnasayfa;
        private System.Windows.Forms.CheckBox checkBoxGoster;
        private System.Windows.Forms.TextBox textBoxSifre;
        private System.Windows.Forms.TextBox textBoxKulAd;
        private System.Windows.Forms.Label labelSifre;
        private System.Windows.Forms.Label labelKulAd;
        private System.Windows.Forms.Label labelAdminGiris;
    }
}