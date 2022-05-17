
namespace SoruHavuzuOtomasyonu
{
    partial class EksikQuizi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EksikQuizi));
            this.pictureBoxsoru = new System.Windows.Forms.PictureBox();
            this.dataGridViewSorular = new System.Windows.Forms.DataGridView();
            this.SoruID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoruTarihi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Soru = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.radioButtonD = new System.Windows.Forms.RadioButton();
            this.radioButtonC = new System.Windows.Forms.RadioButton();
            this.radioButtonB = new System.Windows.Forms.RadioButton();
            this.radioButtonA = new System.Windows.Forms.RadioButton();
            this.buttonGönder = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.labelSinavTarihi = new System.Windows.Forms.Label();
            this.labelSkor = new System.Windows.Forms.Label();
            this.labelDogruSayısı = new System.Windows.Forms.Label();
            this.labelDoğru = new System.Windows.Forms.Label();
            this.labelYanlisSayisi = new System.Windows.Forms.Label();
            this.labelYanlis = new System.Windows.Forms.Label();
            this.textBoxCevap = new System.Windows.Forms.TextBox();
            this.buttonCikis = new System.Windows.Forms.Button();
            this.buttonOgrAnasayfa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxsoru)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSorular)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxsoru
            // 
            this.pictureBoxsoru.Location = new System.Drawing.Point(365, 90);
            this.pictureBoxsoru.Name = "pictureBoxsoru";
            this.pictureBoxsoru.Size = new System.Drawing.Size(466, 415);
            this.pictureBoxsoru.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxsoru.TabIndex = 66;
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
            this.dataGridViewSorular.Location = new System.Drawing.Point(99, 90);
            this.dataGridViewSorular.Name = "dataGridViewSorular";
            this.dataGridViewSorular.ReadOnly = true;
            this.dataGridViewSorular.RowHeadersWidth = 51;
            this.dataGridViewSorular.RowTemplate.Height = 24;
            this.dataGridViewSorular.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewSorular.Size = new System.Drawing.Size(225, 415);
            this.dataGridViewSorular.TabIndex = 67;
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
            // radioButtonD
            // 
            this.radioButtonD.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioButtonD.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.radioButtonD.Location = new System.Drawing.Point(675, 523);
            this.radioButtonD.Name = "radioButtonD";
            this.radioButtonD.Size = new System.Drawing.Size(50, 40);
            this.radioButtonD.TabIndex = 71;
            this.radioButtonD.TabStop = true;
            this.radioButtonD.Text = "D";
            this.radioButtonD.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.radioButtonD.UseVisualStyleBackColor = true;
            // 
            // radioButtonC
            // 
            this.radioButtonC.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioButtonC.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.radioButtonC.Location = new System.Drawing.Point(589, 523);
            this.radioButtonC.Name = "radioButtonC";
            this.radioButtonC.Size = new System.Drawing.Size(50, 40);
            this.radioButtonC.TabIndex = 70;
            this.radioButtonC.TabStop = true;
            this.radioButtonC.Text = "C";
            this.radioButtonC.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.radioButtonC.UseVisualStyleBackColor = true;
            // 
            // radioButtonB
            // 
            this.radioButtonB.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioButtonB.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.radioButtonB.Location = new System.Drawing.Point(514, 523);
            this.radioButtonB.Name = "radioButtonB";
            this.radioButtonB.Size = new System.Drawing.Size(50, 40);
            this.radioButtonB.TabIndex = 69;
            this.radioButtonB.TabStop = true;
            this.radioButtonB.Text = "B";
            this.radioButtonB.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.radioButtonB.UseVisualStyleBackColor = true;
            // 
            // radioButtonA
            // 
            this.radioButtonA.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioButtonA.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.radioButtonA.Location = new System.Drawing.Point(429, 523);
            this.radioButtonA.Name = "radioButtonA";
            this.radioButtonA.Size = new System.Drawing.Size(50, 40);
            this.radioButtonA.TabIndex = 68;
            this.radioButtonA.TabStop = true;
            this.radioButtonA.Text = "A";
            this.radioButtonA.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.radioButtonA.UseVisualStyleBackColor = true;
            // 
            // buttonGönder
            // 
            this.buttonGönder.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonGönder.BackgroundImage")));
            this.buttonGönder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonGönder.Location = new System.Drawing.Point(871, 454);
            this.buttonGönder.Name = "buttonGönder";
            this.buttonGönder.Size = new System.Drawing.Size(160, 51);
            this.buttonGönder.TabIndex = 72;
            this.buttonGönder.UseVisualStyleBackColor = true;
            this.buttonGönder.Click += new System.EventHandler(this.buttonGönder_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(880, 98);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(106, 22);
            this.dateTimePicker1.TabIndex = 74;
            // 
            // labelSinavTarihi
            // 
            this.labelSinavTarihi.AutoSize = true;
            this.labelSinavTarihi.BackColor = System.Drawing.Color.Transparent;
            this.labelSinavTarihi.ForeColor = System.Drawing.Color.White;
            this.labelSinavTarihi.Location = new System.Drawing.Point(903, 78);
            this.labelSinavTarihi.Name = "labelSinavTarihi";
            this.labelSinavTarihi.Size = new System.Drawing.Size(83, 17);
            this.labelSinavTarihi.TabIndex = 73;
            this.labelSinavTarihi.Text = "Sınav Tarihi";
            // 
            // labelSkor
            // 
            this.labelSkor.BackColor = System.Drawing.Color.Transparent;
            this.labelSkor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelSkor.ForeColor = System.Drawing.Color.White;
            this.labelSkor.Location = new System.Drawing.Point(935, 187);
            this.labelSkor.Name = "labelSkor";
            this.labelSkor.Size = new System.Drawing.Size(106, 31);
            this.labelSkor.TabIndex = 76;
            this.labelSkor.Text = "SKOR";
            this.labelSkor.Visible = false;
            // 
            // labelDogruSayısı
            // 
            this.labelDogruSayısı.BackColor = System.Drawing.Color.Transparent;
            this.labelDogruSayısı.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelDogruSayısı.ForeColor = System.Drawing.Color.White;
            this.labelDogruSayısı.Location = new System.Drawing.Point(896, 247);
            this.labelDogruSayısı.Name = "labelDogruSayısı";
            this.labelDogruSayısı.Size = new System.Drawing.Size(47, 31);
            this.labelDogruSayısı.TabIndex = 77;
            this.labelDogruSayısı.Text = "0";
            this.labelDogruSayısı.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelDoğru
            // 
            this.labelDoğru.BackColor = System.Drawing.Color.Transparent;
            this.labelDoğru.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelDoğru.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.labelDoğru.Location = new System.Drawing.Point(967, 247);
            this.labelDoğru.Name = "labelDoğru";
            this.labelDoğru.Size = new System.Drawing.Size(106, 31);
            this.labelDoğru.TabIndex = 78;
            this.labelDoğru.Text = "DOĞRU";
            // 
            // labelYanlisSayisi
            // 
            this.labelYanlisSayisi.BackColor = System.Drawing.Color.Transparent;
            this.labelYanlisSayisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelYanlisSayisi.ForeColor = System.Drawing.Color.White;
            this.labelYanlisSayisi.Location = new System.Drawing.Point(896, 338);
            this.labelYanlisSayisi.Name = "labelYanlisSayisi";
            this.labelYanlisSayisi.Size = new System.Drawing.Size(55, 31);
            this.labelYanlisSayisi.TabIndex = 79;
            this.labelYanlisSayisi.Text = "0";
            this.labelYanlisSayisi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelYanlis
            // 
            this.labelYanlis.BackColor = System.Drawing.Color.Transparent;
            this.labelYanlis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelYanlis.ForeColor = System.Drawing.Color.Red;
            this.labelYanlis.Location = new System.Drawing.Point(967, 338);
            this.labelYanlis.Name = "labelYanlis";
            this.labelYanlis.Size = new System.Drawing.Size(106, 31);
            this.labelYanlis.TabIndex = 80;
            this.labelYanlis.Text = "YANLIŞ";
            // 
            // textBoxCevap
            // 
            this.textBoxCevap.Location = new System.Drawing.Point(224, 538);
            this.textBoxCevap.Name = "textBoxCevap";
            this.textBoxCevap.Size = new System.Drawing.Size(100, 22);
            this.textBoxCevap.TabIndex = 81;
            this.textBoxCevap.Visible = false;
            // 
            // buttonCikis
            // 
            this.buttonCikis.BackColor = System.Drawing.Color.Transparent;
            this.buttonCikis.FlatAppearance.BorderSize = 0;
            this.buttonCikis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCikis.Font = new System.Drawing.Font("Constantia", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonCikis.ForeColor = System.Drawing.Color.Maroon;
            this.buttonCikis.Location = new System.Drawing.Point(1031, 62);
            this.buttonCikis.Name = "buttonCikis";
            this.buttonCikis.Size = new System.Drawing.Size(85, 76);
            this.buttonCikis.TabIndex = 82;
            this.buttonCikis.Text = "X";
            this.buttonCikis.UseVisualStyleBackColor = false;
            this.buttonCikis.Click += new System.EventHandler(this.buttonCikis_Click);
            // 
            // buttonOgrAnasayfa
            // 
            this.buttonOgrAnasayfa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonOgrAnasayfa.BackgroundImage")));
            this.buttonOgrAnasayfa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonOgrAnasayfa.Location = new System.Drawing.Point(64, 510);
            this.buttonOgrAnasayfa.Name = "buttonOgrAnasayfa";
            this.buttonOgrAnasayfa.Size = new System.Drawing.Size(105, 78);
            this.buttonOgrAnasayfa.TabIndex = 83;
            this.buttonOgrAnasayfa.UseVisualStyleBackColor = true;
            this.buttonOgrAnasayfa.Click += new System.EventHandler(this.buttonOgrAnasayfa_Click);
            // 
            // EksikQuizi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1157, 679);
            this.Controls.Add(this.buttonOgrAnasayfa);
            this.Controls.Add(this.buttonCikis);
            this.Controls.Add(this.textBoxCevap);
            this.Controls.Add(this.labelYanlis);
            this.Controls.Add(this.labelYanlisSayisi);
            this.Controls.Add(this.labelDoğru);
            this.Controls.Add(this.labelDogruSayısı);
            this.Controls.Add(this.labelSkor);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.labelSinavTarihi);
            this.Controls.Add(this.buttonGönder);
            this.Controls.Add(this.radioButtonD);
            this.Controls.Add(this.radioButtonC);
            this.Controls.Add(this.radioButtonB);
            this.Controls.Add(this.radioButtonA);
            this.Controls.Add(this.dataGridViewSorular);
            this.Controls.Add(this.pictureBoxsoru);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EksikQuizi";
            this.Text = "EksikQuizi";
            this.Load += new System.EventHandler(this.EksikQuizi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxsoru)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSorular)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxsoru;
        private System.Windows.Forms.DataGridView dataGridViewSorular;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoruID;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoruTarihi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Soru;
        private System.Windows.Forms.RadioButton radioButtonD;
        private System.Windows.Forms.RadioButton radioButtonC;
        private System.Windows.Forms.RadioButton radioButtonB;
        private System.Windows.Forms.RadioButton radioButtonA;
        private System.Windows.Forms.Button buttonGönder;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label labelSinavTarihi;
        private System.Windows.Forms.Label labelSkor;
        private System.Windows.Forms.Label labelDogruSayısı;
        private System.Windows.Forms.Label labelDoğru;
        private System.Windows.Forms.Label labelYanlisSayisi;
        private System.Windows.Forms.Label labelYanlis;
        private System.Windows.Forms.TextBox textBoxCevap;
        private System.Windows.Forms.Button buttonCikis;
        private System.Windows.Forms.Button buttonOgrAnasayfa;
    }
}