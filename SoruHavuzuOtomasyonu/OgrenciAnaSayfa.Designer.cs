
namespace SoruHavuzuOtomasyonu
{
    partial class OgrenciAnaSayfa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OgrenciAnaSayfa));
            this.buttonEksikSinav = new System.Windows.Forms.Button();
            this.buttonAnaliz = new System.Windows.Forms.Button();
            this.buttonAyarlar = new System.Windows.Forms.Button();
            this.buttonSinavaGir = new System.Windows.Forms.Button();
            this.labelOgrenciAnaSayfa = new System.Windows.Forms.Label();
            this.buttonCikis = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonEksikSinav
            // 
            this.buttonEksikSinav.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonEksikSinav.BackgroundImage")));
            this.buttonEksikSinav.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonEksikSinav.Location = new System.Drawing.Point(539, 194);
            this.buttonEksikSinav.Name = "buttonEksikSinav";
            this.buttonEksikSinav.Size = new System.Drawing.Size(277, 92);
            this.buttonEksikSinav.TabIndex = 42;
            this.buttonEksikSinav.UseVisualStyleBackColor = true;
            // 
            // buttonAnaliz
            // 
            this.buttonAnaliz.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonAnaliz.BackgroundImage")));
            this.buttonAnaliz.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonAnaliz.Location = new System.Drawing.Point(164, 354);
            this.buttonAnaliz.Name = "buttonAnaliz";
            this.buttonAnaliz.Size = new System.Drawing.Size(277, 92);
            this.buttonAnaliz.TabIndex = 41;
            this.buttonAnaliz.UseVisualStyleBackColor = true;
            // 
            // buttonAyarlar
            // 
            this.buttonAyarlar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonAyarlar.BackgroundImage")));
            this.buttonAyarlar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonAyarlar.Location = new System.Drawing.Point(539, 354);
            this.buttonAyarlar.Name = "buttonAyarlar";
            this.buttonAyarlar.Size = new System.Drawing.Size(277, 92);
            this.buttonAyarlar.TabIndex = 40;
            this.buttonAyarlar.UseVisualStyleBackColor = true;
            // 
            // buttonSinavaGir
            // 
            this.buttonSinavaGir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonSinavaGir.BackgroundImage")));
            this.buttonSinavaGir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonSinavaGir.Location = new System.Drawing.Point(164, 194);
            this.buttonSinavaGir.Name = "buttonSinavaGir";
            this.buttonSinavaGir.Size = new System.Drawing.Size(277, 92);
            this.buttonSinavaGir.TabIndex = 43;
            this.buttonSinavaGir.UseVisualStyleBackColor = true;
            this.buttonSinavaGir.Click += new System.EventHandler(this.buttonSinavaGir_Click);
            // 
            // labelOgrenciAnaSayfa
            // 
            this.labelOgrenciAnaSayfa.BackColor = System.Drawing.Color.Transparent;
            this.labelOgrenciAnaSayfa.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelOgrenciAnaSayfa.ForeColor = System.Drawing.Color.DarkBlue;
            this.labelOgrenciAnaSayfa.Location = new System.Drawing.Point(181, 87);
            this.labelOgrenciAnaSayfa.Name = "labelOgrenciAnaSayfa";
            this.labelOgrenciAnaSayfa.Size = new System.Drawing.Size(616, 71);
            this.labelOgrenciAnaSayfa.TabIndex = 44;
            this.labelOgrenciAnaSayfa.Text = "ÖĞRENCİ ANA SAYFA";
            this.labelOgrenciAnaSayfa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonCikis
            // 
            this.buttonCikis.BackColor = System.Drawing.Color.Transparent;
            this.buttonCikis.FlatAppearance.BorderSize = 0;
            this.buttonCikis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCikis.Font = new System.Drawing.Font("Constantia", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonCikis.ForeColor = System.Drawing.Color.Maroon;
            this.buttonCikis.Location = new System.Drawing.Point(863, 59);
            this.buttonCikis.Name = "buttonCikis";
            this.buttonCikis.Size = new System.Drawing.Size(85, 76);
            this.buttonCikis.TabIndex = 49;
            this.buttonCikis.Text = "X";
            this.buttonCikis.UseVisualStyleBackColor = false;
            // 
            // OgrenciAnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(985, 656);
            this.Controls.Add(this.buttonCikis);
            this.Controls.Add(this.labelOgrenciAnaSayfa);
            this.Controls.Add(this.buttonSinavaGir);
            this.Controls.Add(this.buttonEksikSinav);
            this.Controls.Add(this.buttonAnaliz);
            this.Controls.Add(this.buttonAyarlar);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OgrenciAnaSayfa";
            this.Text = "OgrenciAnaSayfa";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonEksikSinav;
        private System.Windows.Forms.Button buttonAnaliz;
        private System.Windows.Forms.Button buttonAyarlar;
        private System.Windows.Forms.Button buttonSinavaGir;
        private System.Windows.Forms.Label labelOgrenciAnaSayfa;
        private System.Windows.Forms.Button buttonCikis;
    }
}