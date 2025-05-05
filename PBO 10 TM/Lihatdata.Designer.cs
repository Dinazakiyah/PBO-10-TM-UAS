namespace PBO_10_TM
{
    partial class Lihat_data
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
            dataGridView1 = new DataGridView();
            buttonHapus = new Button();
            buttonEdit = new Button();
            buttonKembali = new Button();
            buttonTambah = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(1, 2);
            dataGridView1.Margin = new Padding(4, 5, 4, 5);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(889, 747);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // buttonHapus
            // 
            buttonHapus.Location = new Point(951, 40);
            buttonHapus.Margin = new Padding(4, 5, 4, 5);
            buttonHapus.Name = "buttonHapus";
            buttonHapus.Size = new Size(140, 92);
            buttonHapus.TabIndex = 1;
            buttonHapus.Text = "HAPUS";
            buttonHapus.UseVisualStyleBackColor = true;
            buttonHapus.Click += buttonHapus_Click;
            // 
            // buttonEdit
            // 
            buttonEdit.Location = new Point(951, 247);
            buttonEdit.Margin = new Padding(4, 5, 4, 5);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(140, 92);
            buttonEdit.TabIndex = 2;
            buttonEdit.Text = "EDIT";
            buttonEdit.UseVisualStyleBackColor = true;
            buttonEdit.Click += buttonEdit_Click;
            // 
            // buttonKembali
            // 
            buttonKembali.Location = new Point(951, 638);
            buttonKembali.Margin = new Padding(4, 5, 4, 5);
            buttonKembali.Name = "buttonKembali";
            buttonKembali.Size = new Size(140, 92);
            buttonKembali.TabIndex = 3;
            buttonKembali.Text = "KEMBALI";
            buttonKembali.UseVisualStyleBackColor = true;
            buttonKembali.Click += buttonKembali_Click;
            // 
            // buttonTambah
            // 
            buttonTambah.Location = new Point(951, 443);
            buttonTambah.Margin = new Padding(4, 5, 4, 5);
            buttonTambah.Name = "buttonTambah";
            buttonTambah.Size = new Size(140, 92);
            buttonTambah.TabIndex = 4;
            buttonTambah.Text = "TAMBAH";
            buttonTambah.UseVisualStyleBackColor = true;
            buttonTambah.Click += buttonTambah_Click;
            // 
            // Lihat_data
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1143, 750);
            Controls.Add(buttonTambah);
            Controls.Add(buttonKembali);
            Controls.Add(buttonEdit);
            Controls.Add(buttonHapus);
            Controls.Add(dataGridView1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Lihat_data";
            Text = "Lihat Data Produk";
            Load += Lihat_data_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button buttonHapus;
        private Button buttonEdit;
        private Button buttonKembali;
        private Button buttonTambah;
    }
}