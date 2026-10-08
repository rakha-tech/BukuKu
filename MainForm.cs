using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BukuKu
{
    public partial class MainForm : Form
    {
        private DataTable tableBuku;

        public MainForm()
        {
            InitializeComponent();
            InitDataTable();

            // Registrasi Listener Event CellFormatting
            dataGridView1.CellFormatting += DataGridView1_CellFormatting;
        }

        private void InitDataTable()
        {
            tableBuku = new DataTable();

            // Deklarasi Kolom
            tableBuku.Columns.Add("Judul", typeof(string));
            tableBuku.Columns.Add("Penulis", typeof(string));
            tableBuku.Columns.Add("Bahasa", typeof(string));
            tableBuku.Columns.Add("Total Halaman", typeof(int));
            tableBuku.Columns.Add("Halaman Dibaca", typeof(int));

            // Kolom Sisa Halaman menggunakan ekspresi kalkulasi otomatis
            tableBuku.Columns.Add("Sisa Halaman", typeof(int), "[Total Halaman] - [Halaman Dibaca]");

            // Bind ke DataGridView
            dataGridView1.DataSource = tableBuku;

            // Tambahkan Data Dummy
            tableBuku.Rows.Add("Atomic Habits", "James Clear", "Inggris", 320, 150);
            tableBuku.Rows.Add("Filosofi Teras", "Henry Manampiring", "Indonesia", 348, 348);
            tableBuku.Rows.Add("Deep Work", "Cal Newport", "Inggris", 304, 100);
            tableBuku.Rows.Add("Laut Bercerita", "James Clear", "Inggris", 320, 150);
            tableBuku.Rows.Add("Psychology of Money", "Morgan Housel", "Inggris", 252, 252);
            tableBuku.Rows.Add("Sapiens", "Yuval Noah Harari", "Inggris", 443, 80);
            tableBuku.Rows.Add("Bumi Manusia", "Pramoedya Ananta", "Indonesia", 535, 0);

            UpdateSummary();
        }

        private void DataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e != null && e.RowIndex >= 0 && dataGridView1.Rows[e.RowIndex].DataBoundItem is DataRowView rowView)
            {
                DataRow row = rowView.Row;

                // Ambil nilai Sisa Halaman dari DataRow
                if (row["Sisa Halaman"] != DBNull.Value)
                {
                    int sisaHalaman = Convert.ToInt32(row["Sisa Halaman"]);

                    // Jika Sisa Halaman == 0, ubah warna background row menjadi Hijau
                    if (sisaHalaman == 0)
                    {
                        dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Green;
                        dataGridView1.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.White;
                    }

                    // Formatting tampilan kolom "Sisa Halaman"
                    if (dataGridView1.Columns[e.ColumnIndex].Name == "Sisa Halaman")
                    {
                        if (sisaHalaman == 0)
                        {
                            e.Value = "Tamat";
                            e.FormattingApplied = true;
                        }
                    }
                }
            }
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            string judul = txtJudul.Text.Trim();
            string penulis = txtPenulis.Text.Trim();
            string bahasa = txtBahasa.Text.Trim();
            int totalHalaman = (int)numTotalHalaman.Value;
            int halamanDibaca = (int)numHalamanDibaca.Value;

            // Validasi input tidak boleh kosong
            if (string.IsNullOrEmpty(judul) || string.IsNullOrEmpty(penulis) || string.IsNullOrEmpty(bahasa))
            {
                MessageBox.Show("Semua kolom teks (Judul, Penulis, Bahasa) wajib diisi!", "Validasi Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validasi logika halaman
            if (halamanDibaca > totalHalaman)
            {
                MessageBox.Show("Halaman yang dibaca tidak boleh melebihi Total Halaman!", "Validasi Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Tambah ke DataTable
            tableBuku.Rows.Add(judul, penulis, bahasa, totalHalaman, halamanDibaca);

            // Reset Form Input
            txtJudul.Clear();
            txtPenulis.Clear();
            txtBahasa.Clear();
            numTotalHalaman.Value = 0;
            numHalamanDibaca.Value = 0;

            UpdateSummary();
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null && !dataGridView1.CurrentRow.IsNewRow)
            {
                string judul = dataGridView1.CurrentRow.Cells["Judul"].Value.ToString();

                // Konfirmasi Hapus
                DialogResult result = MessageBox.Show($"Apakah Anda yakin ingin menghapus buku '{judul}'?", "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
                    UpdateSummary();
                }
            }
            else
            {
                MessageBox.Show("Pilih baris buku yang ingin dihapus terlebih dahulu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void UpdateSummary()
        {
            int totalBuku = tableBuku.Rows.Count;
            int totalDibaca = 0;
            int totalBelumDibaca = 0;

            foreach (DataRow row in tableBuku.Rows)
            {
                if (row.RowState != DataRowState.Deleted)
                {
                    int totalHal = Convert.ToInt32(row["Total Halaman"]);
                    int halDibaca = Convert.ToInt32(row["Halaman Dibaca"]);

                    totalDibaca += halDibaca;
                    totalBelumDibaca += (totalHal - halDibaca);
                }
            }

            lblTotalBuku.Text = $"Total Buku: {totalBuku}";
            lblTotalDibaca.Text = $"Total Halaman Yang Pernah Dibaca: {totalDibaca}";
            lblTotalBelumDibaca.Text = $"Total Halaman Yang Belum Dibaca: {totalBelumDibaca}";
        }
    }
}
