using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace PBO_10_TM
{
    public partial class Lihat_data : Form
    {

        public Lihat_data()
        {
            // Panggil InitializeComponent terlebih dahulu
            InitializeComponent();

            // Setelah itu baru akses database
            try
            {
                NpgsqlConnection conn = new NpgsqlConnection("Host=localhost;Username=postgres;Password=wily;Database=PBOTM");
                conn.Open();
                NpgsqlCommand comm = new NpgsqlCommand();
                comm.Connection = conn;
                comm.CommandType = CommandType.Text;
                comm.CommandText = "SELECT id_produk, nama_produk,merek,kategori,harga FROM produk";
                NpgsqlDataReader read = comm.ExecuteReader();
                DataTable data = new DataTable();
                data.Load(read);
                dataGridView1.DataSource = data;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void buttonHapus_Click(object sender, EventArgs e)
        {
            // Periksa apakah ada baris yang dipilih
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                string deleteId = Convert.ToString(selectedRow.Cells["id_produk"].Value);

                try
                {
                    NpgsqlConnection conn = new NpgsqlConnection("Host=localhost;Username=postgres;Password=wily;Database=PBOTM");
                    conn.Open();
                    string sql = @"DELETE FROM produk WHERE id_produk = @id_produk";
                    NpgsqlCommand cmd = new NpgsqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("id_produk", deleteId);
                    int rowsAffected = cmd.ExecuteNonQuery();
                    conn.Close();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Data berhasil dihapus", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Refresh data
                        Lihat_data refresh = new Lihat_data();
                        refresh.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Tidak ada data yang dihapus", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Silakan pilih data yang akan dihapus terlebih dahulu", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
            string updateId = Convert.ToString(selectedRow.Cells["id_produk"].Value);
            Form1 formEdit = new Form1();
            formEdit.Tag = updateId;
            formEdit.Text = updateId;
            formEdit.Show();
            this.Hide();
        }

        private void buttonTambah_Click(object sender, EventArgs e)
        {
            Form1 formTambah = new Form1();
            formTambah.Show();
            this.Hide();
        }

        private void buttonKembali_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // Event handler for DataGridView CellContentClick
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Add your logic here
            MessageBox.Show($"Cell clicked at row {e.RowIndex}, column {e.ColumnIndex}");
        }

        // Event handler for Form Load
        private void Lihat_data_Load(object sender, EventArgs e)
        {
            // Add your logic here
            MessageBox.Show("Form Loaded");
        }
    }
}
