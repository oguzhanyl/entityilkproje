namespace EntityFrameworkIlkProje
{
    partial class FrmUrun
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
            this.label1 = new System.Windows.Forms.Label();
            this.TxtId = new System.Windows.Forms.TextBox();
            this.TxtUrunAd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtMarka = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtStok = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Txtfiyat = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Txtdurum = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.BtnList = new System.Windows.Forms.Button();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.BtnDlt = new System.Windows.Forms.Button();
            this.Btnupt = new System.Windows.Forms.Button();
            this.BtnClr = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.CmbKategori = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // TxtId
            // 
            this.TxtId.Location = new System.Drawing.Point(112, 34);
            this.TxtId.Name = "TxtId";
            this.TxtId.Size = new System.Drawing.Size(142, 26);
            this.TxtId.TabIndex = 1;
            // 
            // TxtUrunAd
            // 
            this.TxtUrunAd.Location = new System.Drawing.Point(112, 66);
            this.TxtUrunAd.Name = "TxtUrunAd";
            this.TxtUrunAd.Size = new System.Drawing.Size(142, 26);
            this.TxtUrunAd.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "ÜRÜN ADI:";
            // 
            // TxtMarka
            // 
            this.TxtMarka.Location = new System.Drawing.Point(112, 98);
            this.TxtMarka.Name = "TxtMarka";
            this.TxtMarka.Size = new System.Drawing.Size(142, 26);
            this.TxtMarka.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "MARKA:";
            // 
            // TxtStok
            // 
            this.TxtStok.Location = new System.Drawing.Point(112, 130);
            this.TxtStok.Name = "TxtStok";
            this.TxtStok.Size = new System.Drawing.Size(142, 26);
            this.TxtStok.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "STOK:";
            // 
            // Txtfiyat
            // 
            this.Txtfiyat.Location = new System.Drawing.Point(112, 162);
            this.Txtfiyat.Name = "Txtfiyat";
            this.Txtfiyat.Size = new System.Drawing.Size(142, 26);
            this.Txtfiyat.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(47, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "FİYAT:";
            // 
            // Txtdurum
            // 
            this.Txtdurum.Location = new System.Drawing.Point(112, 194);
            this.Txtdurum.Name = "Txtdurum";
            this.Txtdurum.Size = new System.Drawing.Size(142, 26);
            this.Txtdurum.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 197);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "DURUM:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 229);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "KATEGORİ:";
            // 
            // BtnList
            // 
            this.BtnList.Location = new System.Drawing.Point(306, 22);
            this.BtnList.Name = "BtnList";
            this.BtnList.Size = new System.Drawing.Size(145, 38);
            this.BtnList.TabIndex = 14;
            this.BtnList.Text = "LİSTELE";
            this.BtnList.UseVisualStyleBackColor = true;
            this.BtnList.Click += new System.EventHandler(this.BtnList_Click);
            // 
            // BtnAdd
            // 
            this.BtnAdd.Location = new System.Drawing.Point(306, 77);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(145, 38);
            this.BtnAdd.TabIndex = 15;
            this.BtnAdd.Text = "EKLE";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // BtnDlt
            // 
            this.BtnDlt.Location = new System.Drawing.Point(306, 127);
            this.BtnDlt.Name = "BtnDlt";
            this.BtnDlt.Size = new System.Drawing.Size(145, 38);
            this.BtnDlt.TabIndex = 16;
            this.BtnDlt.Text = "SİL";
            this.BtnDlt.UseVisualStyleBackColor = true;
            this.BtnDlt.Click += new System.EventHandler(this.BtnDlt_Click);
            // 
            // Btnupt
            // 
            this.Btnupt.Location = new System.Drawing.Point(306, 176);
            this.Btnupt.Name = "Btnupt";
            this.Btnupt.Size = new System.Drawing.Size(145, 38);
            this.Btnupt.TabIndex = 17;
            this.Btnupt.Text = "GÜNCELLE";
            this.Btnupt.UseVisualStyleBackColor = true;
            this.Btnupt.Click += new System.EventHandler(this.Btnupt_Click);
            // 
            // BtnClr
            // 
            this.BtnClr.Location = new System.Drawing.Point(306, 223);
            this.BtnClr.Name = "BtnClr";
            this.BtnClr.Size = new System.Drawing.Size(145, 38);
            this.BtnClr.TabIndex = 18;
            this.BtnClr.Text = "TEMİZLE";
            this.BtnClr.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(14, 270);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(531, 207);
            this.dataGridView1.TabIndex = 19;
            // 
            // CmbKategori
            // 
            this.CmbKategori.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbKategori.FormattingEnabled = true;
            this.CmbKategori.Location = new System.Drawing.Point(112, 226);
            this.CmbKategori.Name = "CmbKategori";
            this.CmbKategori.Size = new System.Drawing.Size(142, 28);
            this.CmbKategori.TabIndex = 20;
            // 
            // FrmUrun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 489);
            this.Controls.Add(this.CmbKategori);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BtnClr);
            this.Controls.Add(this.Btnupt);
            this.Controls.Add(this.BtnDlt);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.BtnList);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Txtdurum);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Txtfiyat);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtStok);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtMarka);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtUrunAd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtId);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmUrun";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmUrun";
            this.Load += new System.EventHandler(this.FrmUrun_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtId;
        private System.Windows.Forms.TextBox TxtUrunAd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtMarka;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtStok;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Txtfiyat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Txtdurum;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button BtnList;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Button BtnDlt;
        private System.Windows.Forms.Button Btnupt;
        private System.Windows.Forms.Button BtnClr;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox CmbKategori;
    }
}