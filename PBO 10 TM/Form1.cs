   using Npgsql;
   using System;
   using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

    namespace PBO_10_TM
    {
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (this.Text != "Form1")
            {
                tb_id.Text = this.Text;
                this.Text = "Mode Edit";
            }
        }

        private void buttonLihatData_Click(object sender, EventArgs e)
        {
            Lihat_data lihatData = new Lihat_data();
            lihatData.Show();
            this.Hide();
        }

        private void buttonSimpan_Click(object sender, EventArgs e)
        {
            string ID_produk = tb_id.Text;
            string Nama_produk = tb_nama.Text;
            string Merek = tb_merk.Text;
            string Kategori = tb_kategori.Text;
            int Harga;
            if (int.TryParse(tb_harga.Text, out Harga))
            {
                // Conversion successful, Harga contains the converted value
                // Continue with your code here
            }
            else
            {
                // Conversion failed, handle the error
                MessageBox.Show("masukkan angka dengan benar");
            }


            //if (!int.TryParse(tb_harga.Text, out int Harga))
            //    {
            //        MessageBox.Show("Harga harus berupa angka!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        return;
            //    }


            using (NpgsqlConnection conn = new NpgsqlConnection("Host=localhost;Username=postgres;Password=wily;Database=PBOTM"))
            {
                conn.Open();

                if (this.Text == "Mode Edit")
                {
                    string sql = @"UPDATE produk SET nama_produk = @nama_produk, merek = @merek, kategori = @kategori, harga = @harga 
                                   WHERE id_produk = @id_produk";
                    using (NpgsqlCommand cmd = new NpgsqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("id_produk", ID_produk);
                        cmd.Parameters.AddWithValue("nama_produk", Nama_produk);
                        cmd.Parameters.AddWithValue("merek", Merek);
                        cmd.Parameters.AddWithValue("kategori", Kategori);
                        cmd.Parameters.AddWithValue("harga", Harga);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Data berhasil diubah", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                else
                {
                    string sql = @"INSERT INTO produk (id_produk, nama_produk, merek, kategori, harga) 
                                   VALUES (@id_produk, @nama_produk, @merek, @kategori, @harga)";
                    using (NpgsqlCommand cmd = new NpgsqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("id_produk", ID_produk);
                        cmd.Parameters.AddWithValue("nama_produk", Nama_produk);
                        cmd.Parameters.AddWithValue("merek", Merek);
                        cmd.Parameters.AddWithValue("kategori", Kategori);
                        cmd.Parameters.AddWithValue("harga", Harga);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Data berhasil ditambahkan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }

            KosongkanForm();
        }

        private void KosongkanForm()
        {
            tb_id.Text = string.Empty;
            tb_nama.Text = string.Empty;
            tb_merk.Text = string.Empty;
            tb_kategori.Text = string.Empty;
            tb_harga.Text = string.Empty;
        }
    }
    }

