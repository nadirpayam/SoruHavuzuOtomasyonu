
namespace SoruHavuzuOtomasyonu
{
    partial class AnalizYap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnalizYap));
            this.dataGridViewAnaliz = new System.Windows.Forms.DataGridView();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.buttonOnizleme = new System.Windows.Forms.Button();
            this.buttonCikis = new System.Windows.Forms.Button();
            this.labelCiktiAl = new System.Windows.Forms.Label();
            this.buttonOgrAnasayfa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAnaliz)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewAnaliz
            // 
            this.dataGridViewAnaliz.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAnaliz.Location = new System.Drawing.Point(22, 94);
            this.dataGridViewAnaliz.Name = "dataGridViewAnaliz";
            this.dataGridViewAnaliz.RowHeadersWidth = 51;
            this.dataGridViewAnaliz.RowTemplate.Height = 24;
            this.dataGridViewAnaliz.Size = new System.Drawing.Size(832, 454);
            this.dataGridViewAnaliz.TabIndex = 0;
            // 
            // printDocument1
            // 
            this.printDocument1.BeginPrint += new System.Drawing.Printing.PrintEventHandler(this.printDocument1_BeginPrint);
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // buttonOnizleme
            // 
            this.buttonOnizleme.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonOnizleme.BackgroundImage")));
            this.buttonOnizleme.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonOnizleme.Location = new System.Drawing.Point(360, 567);
            this.buttonOnizleme.Name = "buttonOnizleme";
            this.buttonOnizleme.Size = new System.Drawing.Size(213, 77);
            this.buttonOnizleme.TabIndex = 2;
            this.buttonOnizleme.UseVisualStyleBackColor = true;
            this.buttonOnizleme.Click += new System.EventHandler(this.buttonOnizleme_Click);
            // 
            // buttonCikis
            // 
            this.buttonCikis.BackColor = System.Drawing.Color.Transparent;
            this.buttonCikis.FlatAppearance.BorderSize = 0;
            this.buttonCikis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCikis.Font = new System.Drawing.Font("Constantia", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonCikis.ForeColor = System.Drawing.Color.Maroon;
            this.buttonCikis.Location = new System.Drawing.Point(796, 6);
            this.buttonCikis.Name = "buttonCikis";
            this.buttonCikis.Size = new System.Drawing.Size(85, 76);
            this.buttonCikis.TabIndex = 50;
            this.buttonCikis.Text = "X";
            this.buttonCikis.UseVisualStyleBackColor = false;
            this.buttonCikis.Click += new System.EventHandler(this.buttonCikis_Click);
            // 
            // labelCiktiAl
            // 
            this.labelCiktiAl.BackColor = System.Drawing.Color.Transparent;
            this.labelCiktiAl.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelCiktiAl.ForeColor = System.Drawing.Color.RoyalBlue;
            this.labelCiktiAl.Location = new System.Drawing.Point(131, 9);
            this.labelCiktiAl.Name = "labelCiktiAl";
            this.labelCiktiAl.Size = new System.Drawing.Size(616, 71);
            this.labelCiktiAl.TabIndex = 51;
            this.labelCiktiAl.Text = "ANALİZ RAPORU";
            this.labelCiktiAl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonOgrAnasayfa
            // 
            this.buttonOgrAnasayfa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonOgrAnasayfa.BackgroundImage")));
            this.buttonOgrAnasayfa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonOgrAnasayfa.Location = new System.Drawing.Point(22, 587);
            this.buttonOgrAnasayfa.Name = "buttonOgrAnasayfa";
            this.buttonOgrAnasayfa.Size = new System.Drawing.Size(105, 78);
            this.buttonOgrAnasayfa.TabIndex = 52;
            this.buttonOgrAnasayfa.UseVisualStyleBackColor = true;
            this.buttonOgrAnasayfa.Click += new System.EventHandler(this.buttonOgrAnasayfa_Click);
            // 
            // AnalizYap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(893, 677);
            this.Controls.Add(this.buttonOgrAnasayfa);
            this.Controls.Add(this.labelCiktiAl);
            this.Controls.Add(this.buttonCikis);
            this.Controls.Add(this.buttonOnizleme);
            this.Controls.Add(this.dataGridViewAnaliz);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AnalizYap";
            this.Text = "AnalizYap";
            this.Load += new System.EventHandler(this.AnalizYap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAnaliz)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewAnaliz;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Button buttonOnizleme;
        private System.Windows.Forms.Button buttonCikis;
        private System.Windows.Forms.Label labelCiktiAl;
        private System.Windows.Forms.Button buttonOgrAnasayfa;
    }
}