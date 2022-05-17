
namespace SoruHavuzuOtomasyonu
{
    partial class QuizEkrani
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuizEkrani));
            this.labelSure = new System.Windows.Forms.Label();
            this.buttonBaslat = new System.Windows.Forms.Button();
            this.labelAdi = new System.Windows.Forms.Label();
            this.labelSinavTarihi = new System.Windows.Forms.Label();
            this.buttonCikis = new System.Windows.Forms.Button();
            this.radioButtonA = new System.Windows.Forms.RadioButton();
            this.radioButtonB = new System.Windows.Forms.RadioButton();
            this.radioButtonC = new System.Windows.Forms.RadioButton();
            this.radioButtonD = new System.Windows.Forms.RadioButton();
            this.pictureBoxsoru = new System.Windows.Forms.PictureBox();
            this.dataGridViewSorular = new System.Windows.Forms.DataGridView();
            this.SoruID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoruTarihi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Soru = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBoxAd = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.labelkalansaniye = new System.Windows.Forms.Label();
            this.buttonGönder = new System.Windows.Forms.Button();
            this.labelSorular = new System.Windows.Forms.Label();
            this.textBoxSigma = new System.Windows.Forms.TextBox();
            this.textBoxSigma2 = new System.Windows.Forms.TextBox();
            this.textBoxCevap = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxsoru)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSorular)).BeginInit();
            this.SuspendLayout();
            // 
            // labelSure
            // 
            this.labelSure.AutoSize = true;
            this.labelSure.BackColor = System.Drawing.Color.Transparent;
            this.labelSure.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelSure.ForeColor = System.Drawing.Color.White;
            this.labelSure.Location = new System.Drawing.Point(309, 113);
            this.labelSure.Name = "labelSure";
            this.labelSure.Size = new System.Drawing.Size(80, 37);
            this.labelSure.TabIndex = 41;
            this.labelSure.Text = "Süre";
            // 
            // buttonBaslat
            // 
            this.buttonBaslat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonBaslat.BackgroundImage")));
            this.buttonBaslat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonBaslat.Location = new System.Drawing.Point(90, 106);
            this.buttonBaslat.Name = "buttonBaslat";
            this.buttonBaslat.Size = new System.Drawing.Size(194, 60);
            this.buttonBaslat.TabIndex = 40;
            this.buttonBaslat.UseVisualStyleBackColor = true;
            this.buttonBaslat.Click += new System.EventHandler(this.buttonBaslat_Click_1);
            // 
            // labelAdi
            // 
            this.labelAdi.BackColor = System.Drawing.Color.Transparent;
            this.labelAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelAdi.ForeColor = System.Drawing.Color.White;
            this.labelAdi.Location = new System.Drawing.Point(609, 113);
            this.labelAdi.Name = "labelAdi";
            this.labelAdi.Size = new System.Drawing.Size(100, 19);
            this.labelAdi.TabIndex = 43;
            this.labelAdi.Text = "Öğrenci Adı";
            // 
            // labelSinavTarihi
            // 
            this.labelSinavTarihi.AutoSize = true;
            this.labelSinavTarihi.BackColor = System.Drawing.Color.Transparent;
            this.labelSinavTarihi.ForeColor = System.Drawing.Color.White;
            this.labelSinavTarihi.Location = new System.Drawing.Point(759, 108);
            this.labelSinavTarihi.Name = "labelSinavTarihi";
            this.labelSinavTarihi.Size = new System.Drawing.Size(83, 17);
            this.labelSinavTarihi.TabIndex = 44;
            this.labelSinavTarihi.Text = "Sınav Tarihi";
            // 
            // buttonCikis
            // 
            this.buttonCikis.BackColor = System.Drawing.Color.Black;
            this.buttonCikis.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonCikis.BackgroundImage")));
            this.buttonCikis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonCikis.FlatAppearance.BorderSize = 0;
            this.buttonCikis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCikis.Font = new System.Drawing.Font("Constantia", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonCikis.ForeColor = System.Drawing.Color.Maroon;
            this.buttonCikis.Location = new System.Drawing.Point(90, 635);
            this.buttonCikis.Name = "buttonCikis";
            this.buttonCikis.Size = new System.Drawing.Size(194, 52);
            this.buttonCikis.TabIndex = 50;
            this.buttonCikis.UseVisualStyleBackColor = false;
            this.buttonCikis.Click += new System.EventHandler(this.buttonCikis_Click);
            // 
            // radioButtonA
            // 
            this.radioButtonA.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioButtonA.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.radioButtonA.Location = new System.Drawing.Point(439, 647);
            this.radioButtonA.Name = "radioButtonA";
            this.radioButtonA.Size = new System.Drawing.Size(50, 40);
            this.radioButtonA.TabIndex = 51;
            this.radioButtonA.TabStop = true;
            this.radioButtonA.Text = "A";
            this.radioButtonA.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.radioButtonA.UseVisualStyleBackColor = true;
            // 
            // radioButtonB
            // 
            this.radioButtonB.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioButtonB.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.radioButtonB.Location = new System.Drawing.Point(524, 647);
            this.radioButtonB.Name = "radioButtonB";
            this.radioButtonB.Size = new System.Drawing.Size(50, 40);
            this.radioButtonB.TabIndex = 52;
            this.radioButtonB.TabStop = true;
            this.radioButtonB.Text = "B";
            this.radioButtonB.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.radioButtonB.UseVisualStyleBackColor = true;
            // 
            // radioButtonC
            // 
            this.radioButtonC.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioButtonC.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.radioButtonC.Location = new System.Drawing.Point(599, 647);
            this.radioButtonC.Name = "radioButtonC";
            this.radioButtonC.Size = new System.Drawing.Size(50, 40);
            this.radioButtonC.TabIndex = 53;
            this.radioButtonC.TabStop = true;
            this.radioButtonC.Text = "C";
            this.radioButtonC.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.radioButtonC.UseVisualStyleBackColor = true;
            // 
            // radioButtonD
            // 
            this.radioButtonD.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioButtonD.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.radioButtonD.Location = new System.Drawing.Point(685, 647);
            this.radioButtonD.Name = "radioButtonD";
            this.radioButtonD.Size = new System.Drawing.Size(50, 40);
            this.radioButtonD.TabIndex = 54;
            this.radioButtonD.TabStop = true;
            this.radioButtonD.Text = "D";
            this.radioButtonD.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.radioButtonD.UseVisualStyleBackColor = true;
            // 
            // pictureBoxsoru
            // 
            this.pictureBoxsoru.Location = new System.Drawing.Point(316, 183);
            this.pictureBoxsoru.Name = "pictureBoxsoru";
            this.pictureBoxsoru.Size = new System.Drawing.Size(654, 436);
            this.pictureBoxsoru.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxsoru.TabIndex = 65;
            this.pictureBoxsoru.TabStop = false;
            // 
            // dataGridViewSorular
            // 
            this.dataGridViewSorular.AllowUserToAddRows = false;
            this.dataGridViewSorular.AllowUserToDeleteRows = false;
            this.dataGridViewSorular.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewSorular.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSorular.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SoruID,
            this.SoruTarihi,
            this.Soru});
            this.dataGridViewSorular.Location = new System.Drawing.Point(85, 223);
            this.dataGridViewSorular.Name = "dataGridViewSorular";
            this.dataGridViewSorular.ReadOnly = true;
            this.dataGridViewSorular.RowHeadersWidth = 51;
            this.dataGridViewSorular.RowTemplate.Height = 24;
            this.dataGridViewSorular.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewSorular.Size = new System.Drawing.Size(225, 396);
            this.dataGridViewSorular.TabIndex = 66;
            this.dataGridViewSorular.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSorular_CellDoubleClick);
            // 
            // SoruID
            // 
            this.SoruID.DataPropertyName = "SoruID";
            this.SoruID.HeaderText = "Soru ID";
            this.SoruID.MinimumWidth = 6;
            this.SoruID.Name = "SoruID";
            this.SoruID.ReadOnly = true;
            // 
            // SoruTarihi
            // 
            this.SoruTarihi.DataPropertyName = "SoruTarihi";
            this.SoruTarihi.HeaderText = "Soru Tarihi";
            this.SoruTarihi.MinimumWidth = 6;
            this.SoruTarihi.Name = "SoruTarihi";
            this.SoruTarihi.ReadOnly = true;
            this.SoruTarihi.Visible = false;
            // 
            // Soru
            // 
            this.Soru.DataPropertyName = "Soru";
            this.Soru.HeaderText = "Soru";
            this.Soru.MinimumWidth = 6;
            this.Soru.Name = "Soru";
            this.Soru.ReadOnly = true;
            this.Soru.Visible = false;
            // 
            // textBoxAd
            // 
            this.textBoxAd.Location = new System.Drawing.Point(603, 142);
            this.textBoxAd.Multiline = true;
            this.textBoxAd.Name = "textBoxAd";
            this.textBoxAd.Size = new System.Drawing.Size(106, 24);
            this.textBoxAd.TabIndex = 67;
            this.textBoxAd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(751, 140);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(106, 22);
            this.dateTimePicker1.TabIndex = 69;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // labelkalansaniye
            // 
            this.labelkalansaniye.BackColor = System.Drawing.Color.Transparent;
            this.labelkalansaniye.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelkalansaniye.ForeColor = System.Drawing.Color.White;
            this.labelkalansaniye.Location = new System.Drawing.Point(395, 126);
            this.labelkalansaniye.Name = "labelkalansaniye";
            this.labelkalansaniye.Size = new System.Drawing.Size(100, 23);
            this.labelkalansaniye.TabIndex = 70;
            this.labelkalansaniye.Text = "Saniye Kaldı";
            // 
            // buttonGönder
            // 
            this.buttonGönder.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonGönder.BackgroundImage")));
            this.buttonGönder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonGönder.Location = new System.Drawing.Point(810, 647);
            this.buttonGönder.Name = "buttonGönder";
            this.buttonGönder.Size = new System.Drawing.Size(160, 51);
            this.buttonGönder.TabIndex = 71;
            this.buttonGönder.UseVisualStyleBackColor = true;
            this.buttonGönder.Click += new System.EventHandler(this.buttonGönder_Click_1);
            // 
            // labelSorular
            // 
            this.labelSorular.BackColor = System.Drawing.Color.Transparent;
            this.labelSorular.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelSorular.ForeColor = System.Drawing.Color.White;
            this.labelSorular.Location = new System.Drawing.Point(95, 177);
            this.labelSorular.Name = "labelSorular";
            this.labelSorular.Size = new System.Drawing.Size(168, 43);
            this.labelSorular.TabIndex = 73;
            this.labelSorular.Text = "Sorular";
            this.labelSorular.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxSigma
            // 
            this.textBoxSigma.Location = new System.Drawing.Point(613, 706);
            this.textBoxSigma.Multiline = true;
            this.textBoxSigma.Name = "textBoxSigma";
            this.textBoxSigma.Size = new System.Drawing.Size(106, 24);
            this.textBoxSigma.TabIndex = 74;
            this.textBoxSigma.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxSigma.Visible = false;
            // 
            // textBoxSigma2
            // 
            this.textBoxSigma2.Location = new System.Drawing.Point(501, 706);
            this.textBoxSigma2.Multiline = true;
            this.textBoxSigma2.Name = "textBoxSigma2";
            this.textBoxSigma2.Size = new System.Drawing.Size(106, 24);
            this.textBoxSigma2.TabIndex = 75;
            this.textBoxSigma2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxSigma2.Visible = false;
            // 
            // textBoxCevap
            // 
            this.textBoxCevap.Location = new System.Drawing.Point(389, 706);
            this.textBoxCevap.Multiline = true;
            this.textBoxCevap.Name = "textBoxCevap";
            this.textBoxCevap.Size = new System.Drawing.Size(106, 24);
            this.textBoxCevap.TabIndex = 76;
            this.textBoxCevap.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxCevap.Visible = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Constantia", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.Maroon;
            this.button1.Location = new System.Drawing.Point(899, 76);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 56);
            this.button1.TabIndex = 77;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // QuizEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1026, 819);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxCevap);
            this.Controls.Add(this.textBoxSigma2);
            this.Controls.Add(this.textBoxSigma);
            this.Controls.Add(this.labelSorular);
            this.Controls.Add(this.buttonGönder);
            this.Controls.Add(this.labelkalansaniye);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBoxAd);
            this.Controls.Add(this.dataGridViewSorular);
            this.Controls.Add(this.pictureBoxsoru);
            this.Controls.Add(this.radioButtonD);
            this.Controls.Add(this.radioButtonC);
            this.Controls.Add(this.radioButtonB);
            this.Controls.Add(this.radioButtonA);
            this.Controls.Add(this.buttonCikis);
            this.Controls.Add(this.labelSinavTarihi);
            this.Controls.Add(this.labelAdi);
            this.Controls.Add(this.labelSure);
            this.Controls.Add(this.buttonBaslat);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "QuizEkrani";
            this.Text = "QuizEkrani";
            this.Load += new System.EventHandler(this.QuizEkrani_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxsoru)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSorular)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelSure;
        private System.Windows.Forms.Button buttonBaslat;
        private System.Windows.Forms.Label labelAdi;
        private System.Windows.Forms.Label labelSinavTarihi;
        private System.Windows.Forms.Button buttonCikis;
        private System.Windows.Forms.RadioButton radioButtonA;
        private System.Windows.Forms.RadioButton radioButtonB;
        private System.Windows.Forms.RadioButton radioButtonC;
        private System.Windows.Forms.RadioButton radioButtonD;
        private System.Windows.Forms.PictureBox pictureBoxsoru;
        private System.Windows.Forms.DataGridView dataGridViewSorular;
        private System.Windows.Forms.TextBox textBoxAd;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label labelkalansaniye;
        private System.Windows.Forms.Button buttonGönder;
        private System.Windows.Forms.Label labelSorular;
        private System.Windows.Forms.TextBox textBoxSigma;
        private System.Windows.Forms.TextBox textBoxSigma2;
        private System.Windows.Forms.TextBox textBoxCevap;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoruID;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoruTarihi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Soru;
        private System.Windows.Forms.Button button1;
    }
}