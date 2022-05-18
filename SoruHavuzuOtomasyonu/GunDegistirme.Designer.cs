
namespace SoruHavuzuOtomasyonu
{
    partial class GunDegistirme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GunDegistirme));
            this.dataGridViewDegistirme = new System.Windows.Forms.DataGridView();
            this.SigmaSayisi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Aralık = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBoxDegistirme = new System.Windows.Forms.TextBox();
            this.labeldegistrime = new System.Windows.Forms.Label();
            this.buttondegisiklik = new System.Windows.Forms.Button();
            this.buttonVazgec = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelAnasayfa = new System.Windows.Forms.Label();
            this.buttonOgrAnasayfa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDegistirme)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewDegistirme
            // 
            this.dataGridViewDegistirme.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDegistirme.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SigmaSayisi,
            this.Aralık});
            this.dataGridViewDegistirme.Location = new System.Drawing.Point(197, 146);
            this.dataGridViewDegistirme.Name = "dataGridViewDegistirme";
            this.dataGridViewDegistirme.RowHeadersWidth = 51;
            this.dataGridViewDegistirme.RowTemplate.Height = 24;
            this.dataGridViewDegistirme.Size = new System.Drawing.Size(310, 268);
            this.dataGridViewDegistirme.TabIndex = 0;
            // 
            // SigmaSayisi
            // 
            this.SigmaSayisi.DataPropertyName = "SigmaSayisi";
            this.SigmaSayisi.HeaderText = "Doğru Cevaplanma Sayısı";
            this.SigmaSayisi.MinimumWidth = 6;
            this.SigmaSayisi.Name = "SigmaSayisi";
            this.SigmaSayisi.Width = 90;
            // 
            // Aralık
            // 
            this.Aralık.DataPropertyName = "Aralik";
            this.Aralık.HeaderText = "Gün Aralığı";
            this.Aralık.MinimumWidth = 6;
            this.Aralık.Name = "Aralık";
            this.Aralık.Width = 80;
            // 
            // textBoxDegistirme
            // 
            this.textBoxDegistirme.Location = new System.Drawing.Point(725, 101);
            this.textBoxDegistirme.Name = "textBoxDegistirme";
            this.textBoxDegistirme.Size = new System.Drawing.Size(100, 22);
            this.textBoxDegistirme.TabIndex = 1;
            // 
            // labeldegistrime
            // 
            this.labeldegistrime.BackColor = System.Drawing.Color.Transparent;
            this.labeldegistrime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labeldegistrime.ForeColor = System.Drawing.Color.Lime;
            this.labeldegistrime.Location = new System.Drawing.Point(479, 92);
            this.labeldegistrime.Name = "labeldegistrime";
            this.labeldegistrime.Size = new System.Drawing.Size(240, 35);
            this.labeldegistrime.TabIndex = 2;
            this.labeldegistrime.Text = "Yeni gün aralığını girin: ";
            this.labeldegistrime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labeldegistrime.Click += new System.EventHandler(this.labeldegistrime_Click);
            // 
            // buttondegisiklik
            // 
            this.buttondegisiklik.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttondegisiklik.BackgroundImage")));
            this.buttondegisiklik.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttondegisiklik.Location = new System.Drawing.Point(529, 146);
            this.buttondegisiklik.Name = "buttondegisiklik";
            this.buttondegisiklik.Size = new System.Drawing.Size(221, 82);
            this.buttondegisiklik.TabIndex = 3;
            this.buttondegisiklik.UseVisualStyleBackColor = true;
            this.buttondegisiklik.Click += new System.EventHandler(this.buttondegisiklik_Click);
            // 
            // buttonVazgec
            // 
            this.buttonVazgec.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonVazgec.BackgroundImage")));
            this.buttonVazgec.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonVazgec.Location = new System.Drawing.Point(529, 332);
            this.buttonVazgec.Name = "buttonVazgec";
            this.buttonVazgec.Size = new System.Drawing.Size(221, 82);
            this.buttonVazgec.TabIndex = 6;
            this.buttonVazgec.UseVisualStyleBackColor = true;
            this.buttonVazgec.Click += new System.EventHandler(this.buttonVazgec_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(108, 433);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(717, 80);
            this.label1.TabIndex = 7;
            this.label1.Text = "Bilgilendirme: \'Gün Aralığı\' sutünuna göre soruyu bir daha kaç gün sonra göreceği" +
    "niz yazıyor. Eğer soruyu 6 kez üst üste doğru cevaplamışsanız o soruyu bir daha " +
    "görmenize gerek kalmıyor.";
            // 
            // labelAnasayfa
            // 
            this.labelAnasayfa.BackColor = System.Drawing.Color.Transparent;
            this.labelAnasayfa.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelAnasayfa.ForeColor = System.Drawing.Color.Maroon;
            this.labelAnasayfa.Location = new System.Drawing.Point(85, 9);
            this.labelAnasayfa.Name = "labelAnasayfa";
            this.labelAnasayfa.Size = new System.Drawing.Size(614, 71);
            this.labelAnasayfa.TabIndex = 37;
            this.labelAnasayfa.Text = "SORU ÇIKMA SIKLIĞI DEĞİŞTİRME EKRANI";
            this.labelAnasayfa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonOgrAnasayfa
            // 
            this.buttonOgrAnasayfa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonOgrAnasayfa.BackgroundImage")));
            this.buttonOgrAnasayfa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonOgrAnasayfa.Location = new System.Drawing.Point(3, 445);
            this.buttonOgrAnasayfa.Name = "buttonOgrAnasayfa";
            this.buttonOgrAnasayfa.Size = new System.Drawing.Size(82, 78);
            this.buttonOgrAnasayfa.TabIndex = 84;
            this.buttonOgrAnasayfa.UseVisualStyleBackColor = true;
            this.buttonOgrAnasayfa.Click += new System.EventHandler(this.buttonOgrAnasayfa_Click);
            // 
            // GunDegistirme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(840, 535);
            this.Controls.Add(this.buttonOgrAnasayfa);
            this.Controls.Add(this.labelAnasayfa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonVazgec);
            this.Controls.Add(this.buttondegisiklik);
            this.Controls.Add(this.labeldegistrime);
            this.Controls.Add(this.textBoxDegistirme);
            this.Controls.Add(this.dataGridViewDegistirme);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GunDegistirme";
            this.Text = "GunDegistirme";
            this.Load += new System.EventHandler(this.GunDegistirme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDegistirme)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewDegistirme;
        private System.Windows.Forms.TextBox textBoxDegistirme;
        private System.Windows.Forms.Label labeldegistrime;
        private System.Windows.Forms.Button buttondegisiklik;
        private System.Windows.Forms.Button buttonVazgec;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn SigmaSayisi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Aralık;
        private System.Windows.Forms.Label labelAnasayfa;
        private System.Windows.Forms.Button buttonOgrAnasayfa;
    }
}