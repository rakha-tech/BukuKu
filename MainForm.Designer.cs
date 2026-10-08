namespace BukuKu
{
    partial class MainForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnTambah = new System.Windows.Forms.Button();
            this.btnHapus = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtJudul = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPenulis = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBahasa = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.numTotalHalaman = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.numHalamanDibaca = new System.Windows.Forms.NumericUpDown();
            this.lblTotalBuku = new System.Windows.Forms.Label();
            this.lblTotalDibaca = new System.Windows.Forms.Label();
            this.lblTotalBelumDibaca = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTotalHalaman)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHalamanDibaca)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(775, 231);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnTambah
            // 
            this.btnTambah.Location = new System.Drawing.Point(13, 251);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(75, 23);
            this.btnTambah.TabIndex = 1;
            this.btnTambah.Text = "Tambah";
            this.btnTambah.UseVisualStyleBackColor = true;
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);
            // 
            // btnHapus
            // 
            this.btnHapus.Location = new System.Drawing.Point(13, 281);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(75, 23);
            this.btnHapus.TabIndex = 2;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.UseVisualStyleBackColor = true;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 251);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Judul";
            // 
            // txtJudul
            // 
            this.txtJudul.Location = new System.Drawing.Point(98, 268);
            this.txtJudul.Name = "txtJudul";
            this.txtJudul.Size = new System.Drawing.Size(189, 20);
            this.txtJudul.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(95, 291);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Penulis";
            // 
            // txtPenulis
            // 
            this.txtPenulis.Location = new System.Drawing.Point(98, 308);
            this.txtPenulis.Name = "txtPenulis";
            this.txtPenulis.Size = new System.Drawing.Size(189, 20);
            this.txtPenulis.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(95, 331);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Bahasa";
            // 
            // txtBahasa
            // 
            this.txtBahasa.Location = new System.Drawing.Point(98, 347);
            this.txtBahasa.Name = "txtBahasa";
            this.txtBahasa.Size = new System.Drawing.Size(189, 20);
            this.txtBahasa.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(294, 251);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Total halaman";
            // 
            // numTotalHalaman
            // 
            this.numTotalHalaman.Location = new System.Drawing.Point(297, 267);
            this.numTotalHalaman.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numTotalHalaman.Name = "numTotalHalaman";
            this.numTotalHalaman.Size = new System.Drawing.Size(189, 20);
            this.numTotalHalaman.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(294, 294);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Halaman yang telah dibaca";
            // 
            // numHalamanDibaca
            // 
            this.numHalamanDibaca.Location = new System.Drawing.Point(297, 308);
            this.numHalamanDibaca.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numHalamanDibaca.Name = "numHalamanDibaca";
            this.numHalamanDibaca.Size = new System.Drawing.Size(189, 20);
            this.numHalamanDibaca.TabIndex = 12;
            // 
            // lblTotalBuku
            // 
            this.lblTotalBuku.AutoSize = true;
            this.lblTotalBuku.Location = new System.Drawing.Point(495, 261);
            this.lblTotalBuku.Name = "lblTotalBuku";
            this.lblTotalBuku.Size = new System.Drawing.Size(71, 13);
            this.lblTotalBuku.TabIndex = 13;
            this.lblTotalBuku.Text = "Total Buku: 0";
            // 
            // lblTotalDibaca
            // 
            this.lblTotalDibaca.AutoSize = true;
            this.lblTotalDibaca.Location = new System.Drawing.Point(495, 278);
            this.lblTotalDibaca.Name = "lblTotalDibaca";
            this.lblTotalDibaca.Size = new System.Drawing.Size(190, 13);
            this.lblTotalDibaca.TabIndex = 14;
            this.lblTotalDibaca.Text = "Total Halaman Yang Pernah Dibaca: 0";
            // 
            // lblTotalBelumDibaca
            // 
            this.lblTotalBelumDibaca.AutoSize = true;
            this.lblTotalBelumDibaca.Location = new System.Drawing.Point(495, 294);
            this.lblTotalBelumDibaca.Name = "lblTotalBelumDibaca";
            this.lblTotalBelumDibaca.Size = new System.Drawing.Size(222, 13);
            this.lblTotalBelumDibaca.TabIndex = 15;
            this.lblTotalBelumDibaca.Text = "Total Halaman Yang Belum Pernah Dibaca: 0";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTotalBelumDibaca);
            this.Controls.Add(this.lblTotalDibaca);
            this.Controls.Add(this.lblTotalBuku);
            this.Controls.Add(this.numHalamanDibaca);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numTotalHalaman);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBahasa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPenulis);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtJudul);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnHapus);
            this.Controls.Add(this.btnTambah);
            this.Controls.Add(this.dataGridView1);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buku Ku | Daftar Buku";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTotalHalaman)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHalamanDibaca)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtJudul;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPenulis;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBahasa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numTotalHalaman;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numHalamanDibaca;
        private System.Windows.Forms.Label lblTotalBuku;
        private System.Windows.Forms.Label lblTotalDibaca;
        private System.Windows.Forms.Label lblTotalBelumDibaca;
    }
}