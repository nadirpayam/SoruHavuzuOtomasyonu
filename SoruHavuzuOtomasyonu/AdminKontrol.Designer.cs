
namespace SoruHavuzuOtomasyonu
{
    partial class AdminKontrol
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminKontrol));
            this.dataGridViewSorular = new System.Windows.Forms.DataGridView();
            this.SoruID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoruNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KonuNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UniteNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SinifDuzeyi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Soru = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KodNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DersinAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UniteAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KonuAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cevap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBoxsoru = new System.Windows.Forms.PictureBox();
            this.buttonOnaylama = new System.Windows.Forms.Button();
            this.buttonAnasayfa = new System.Windows.Forms.Button();
            this.buttonCikis = new System.Windows.Forms.Button();
            this.buttonOnayla = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSorular)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxsoru)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewSorular
            // 
            this.dataGridViewSorular.AllowUserToAddRows = false;
            this.dataGridViewSorular.AllowUserToDeleteRows = false;
            this.dataGridViewSorular.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewSorular.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSorular.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SoruID,
            this.SoruNo,
            this.KonuNo,
            this.UniteNo,
            this.SinifDuzeyi,
            this.Soru,
            this.KodNo,
            this.DersinAdi,
            this.UniteAdi,
            this.KonuAdi,
            this.Cevap});
            this.dataGridViewSorular.Location = new System.Drawing.Point(12, 433);
            this.dataGridViewSorular.Name = "dataGridViewSorular";
            this.dataGridViewSorular.ReadOnly = true;
            this.dataGridViewSorular.RowHeadersWidth = 51;
            this.dataGridViewSorular.RowTemplate.Height = 24;
            this.dataGridViewSorular.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewSorular.Size = new System.Drawing.Size(936, 341);
            this.dataGridViewSorular.TabIndex = 13;
            
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
            // SoruNo
            // 
            this.SoruNo.DataPropertyName = "SoruNo";
            this.SoruNo.HeaderText = "Soru No";
            this.SoruNo.MinimumWidth = 6;
            this.SoruNo.Name = "SoruNo";
            this.SoruNo.ReadOnly = true;
            // 
            // KonuNo
            // 
            this.KonuNo.DataPropertyName = "KonuNo";
            this.KonuNo.HeaderText = "Konu No";
            this.KonuNo.MinimumWidth = 6;
            this.KonuNo.Name = "KonuNo";
            this.KonuNo.ReadOnly = true;
            // 
            // UniteNo
            // 
            this.UniteNo.DataPropertyName = "UniteNo";
            this.UniteNo.HeaderText = "Ünite No";
            this.UniteNo.MinimumWidth = 6;
            this.UniteNo.Name = "UniteNo";
            this.UniteNo.ReadOnly = true;
            // 
            // SinifDuzeyi
            // 
            this.SinifDuzeyi.DataPropertyName = "SinifDuzeyi";
            this.SinifDuzeyi.HeaderText = "Sınıf Düzeyi";
            this.SinifDuzeyi.MinimumWidth = 6;
            this.SinifDuzeyi.Name = "SinifDuzeyi";
            this.SinifDuzeyi.ReadOnly = true;
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
            // KodNo
            // 
            this.KodNo.DataPropertyName = "KodNo";
            this.KodNo.HeaderText = "Kod No";
            this.KodNo.MinimumWidth = 6;
            this.KodNo.Name = "KodNo";
            this.KodNo.ReadOnly = true;
            // 
            // DersinAdi
            // 
            this.DersinAdi.DataPropertyName = "DersinAdi";
            this.DersinAdi.HeaderText = "Dersin Adı";
            this.DersinAdi.MinimumWidth = 6;
            this.DersinAdi.Name = "DersinAdi";
            this.DersinAdi.ReadOnly = true;
            // 
            // UniteAdi
            // 
            this.UniteAdi.DataPropertyName = "UniteAdi";
            this.UniteAdi.HeaderText = "Ünite Adı";
            this.UniteAdi.MinimumWidth = 6;
            this.UniteAdi.Name = "UniteAdi";
            this.UniteAdi.ReadOnly = true;
            // 
            // KonuAdi
            // 
            this.KonuAdi.DataPropertyName = "KonuAdi";
            this.KonuAdi.HeaderText = "Konu Adı";
            this.KonuAdi.MinimumWidth = 6;
            this.KonuAdi.Name = "KonuAdi";
            this.KonuAdi.ReadOnly = true;
            // 
            // Cevap
            // 
            this.Cevap.DataPropertyName = "Cevap";
            this.Cevap.HeaderText = "Cevap";
            this.Cevap.MinimumWidth = 6;
            this.Cevap.Name = "Cevap";
            this.Cevap.ReadOnly = true;
            // 
            // pictureBoxsoru
            // 
            this.pictureBoxsoru.Location = new System.Drawing.Point(194, 12);
            this.pictureBoxsoru.Name = "pictureBoxsoru";
            this.pictureBoxsoru.Size = new System.Drawing.Size(572, 415);
            this.pictureBoxsoru.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxsoru.TabIndex = 64;
            this.pictureBoxsoru.TabStop = false;
            // 
            // buttonOnaylama
            // 
            this.buttonOnaylama.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonOnaylama.BackgroundImage")));
            this.buttonOnaylama.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonOnaylama.Location = new System.Drawing.Point(12, 362);
            this.buttonOnaylama.Name = "buttonOnaylama";
            this.buttonOnaylama.Size = new System.Drawing.Size(176, 65);
            this.buttonOnaylama.TabIndex = 65;
            this.buttonOnaylama.UseVisualStyleBackColor = true;
            this.buttonOnaylama.Click += new System.EventHandler(this.buttonOnaylama_Click);
            // 
            // buttonAnasayfa
            // 
            this.buttonAnasayfa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonAnasayfa.BackgroundImage")));
            this.buttonAnasayfa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonAnasayfa.Location = new System.Drawing.Point(12, 274);
            this.buttonAnasayfa.Name = "buttonAnasayfa";
            this.buttonAnasayfa.Size = new System.Drawing.Size(90, 67);
            this.buttonAnasayfa.TabIndex = 66;
            this.buttonAnasayfa.UseVisualStyleBackColor = true;
            this.buttonAnasayfa.Click += new System.EventHandler(this.buttonAnasayfa_Click);
            // 
            // buttonCikis
            // 
            this.buttonCikis.BackColor = System.Drawing.Color.Transparent;
            this.buttonCikis.FlatAppearance.BorderSize = 0;
            this.buttonCikis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCikis.Font = new System.Drawing.Font("Constantia", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonCikis.ForeColor = System.Drawing.Color.Maroon;
            this.buttonCikis.Location = new System.Drawing.Point(849, 12);
            this.buttonCikis.Name = "buttonCikis";
            this.buttonCikis.Size = new System.Drawing.Size(85, 76);
            this.buttonCikis.TabIndex = 85;
            this.buttonCikis.Text = "X";
            this.buttonCikis.UseVisualStyleBackColor = false;
            this.buttonCikis.Click += new System.EventHandler(this.buttonCikis_Click);
            // 
            // buttonOnayla
            // 
            this.buttonOnayla.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonOnayla.BackgroundImage")));
            this.buttonOnayla.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonOnayla.Location = new System.Drawing.Point(772, 362);
            this.buttonOnayla.Name = "buttonOnayla";
            this.buttonOnayla.Size = new System.Drawing.Size(176, 65);
            this.buttonOnayla.TabIndex = 86;
            this.buttonOnayla.UseVisualStyleBackColor = true;
            this.buttonOnayla.Click += new System.EventHandler(this.buttonOnayla_Click);
            // 
            // AdminKontrol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(959, 786);
            this.Controls.Add(this.buttonOnayla);
            this.Controls.Add(this.buttonCikis);
            this.Controls.Add(this.buttonAnasayfa);
            this.Controls.Add(this.buttonOnaylama);
            this.Controls.Add(this.pictureBoxsoru);
            this.Controls.Add(this.dataGridViewSorular);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminKontrol";
            this.Text = "AdminKontrol";
            this.Load += new System.EventHandler(this.AdminKontrol_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSorular)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxsoru)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewSorular;
        private System.Windows.Forms.PictureBox pictureBoxsoru;
        private System.Windows.Forms.Button buttonOnaylama;
        private System.Windows.Forms.Button buttonAnasayfa;
        private System.Windows.Forms.Button buttonCikis;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoruID;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoruNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn KonuNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn UniteNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn SinifDuzeyi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Soru;
        private System.Windows.Forms.DataGridViewTextBoxColumn KodNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn DersinAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn UniteAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn KonuAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cevap;
        private System.Windows.Forms.Button buttonOnayla;
    }
}