namespace PBO_10_TM
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbtoko = new Label();
            tb_id = new TextBox();
            tb_nama = new TextBox();
            tb_merk = new TextBox();
            tb_kategori = new TextBox();
            tb_harga = new TextBox();
            buttonSimpan = new Button();
            buttonLihatData = new Button();
            labelID = new Label();
            labelnama = new Label();
            labelmerk = new Label();
            labelkategori = new Label();
            labelharga = new Label();
            SuspendLayout();
            // 
            // lbtoko
            // 
            lbtoko.AutoSize = true;
            lbtoko.Font = new Font("Verdana", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbtoko.Location = new Point(304, 23);
            lbtoko.Name = "lbtoko";
            lbtoko.Size = new Size(263, 38);
            lbtoko.TabIndex = 0;
            lbtoko.Text = "Toko Elektronik";
            // 
            // tb_id
            // 
            tb_id.Location = new Point(272, 92);
            tb_id.Name = "tb_id";
            tb_id.Size = new Size(304, 31);
            tb_id.TabIndex = 1;
            // 
            // tb_nama
            // 
            tb_nama.Location = new Point(272, 141);
            tb_nama.Name = "tb_nama";
            tb_nama.Size = new Size(304, 31);
            tb_nama.TabIndex = 2;
            // 
            // tb_merk
            // 
            tb_merk.Location = new Point(272, 200);
            tb_merk.Name = "tb_merk";
            tb_merk.Size = new Size(304, 31);
            tb_merk.TabIndex = 3;
            // 
            // tb_kategori
            // 
            tb_kategori.Location = new Point(272, 254);
            tb_kategori.Name = "tb_kategori";
            tb_kategori.Size = new Size(304, 31);
            tb_kategori.TabIndex = 4;
            // 
            // tb_harga
            // 
            tb_harga.Location = new Point(272, 305);
            tb_harga.Name = "tb_harga";
            tb_harga.Size = new Size(304, 31);
            tb_harga.TabIndex = 5;
            // 
            // buttonSimpan
            // 
            buttonSimpan.BackColor = SystemColors.Highlight;
            buttonSimpan.ForeColor = SystemColors.HighlightText;
            buttonSimpan.Location = new Point(62, 367);
            buttonSimpan.Name = "buttonSimpan";
            buttonSimpan.Size = new Size(148, 42);
            buttonSimpan.TabIndex = 6;
            buttonSimpan.Text = "Simpan";
            buttonSimpan.UseVisualStyleBackColor = false;
            buttonSimpan.Click += buttonSimpan_Click;
            // 
            // buttonLihatData
            // 
            buttonLihatData.BackColor = SystemColors.Highlight;
            buttonLihatData.ForeColor = Color.White;
            buttonLihatData.Location = new Point(272, 367);
            buttonLihatData.Name = "buttonLihatData";
            buttonLihatData.Size = new Size(148, 42);
            buttonLihatData.TabIndex = 7;
            buttonLihatData.Text = "Lihat Data";
            buttonLihatData.UseVisualStyleBackColor = false;
            buttonLihatData.Click += buttonLihatData_Click;
            // 
            // labelID
            // 
            labelID.AutoSize = true;
            labelID.Location = new Point(101, 98);
            labelID.Name = "labelID";
            labelID.Size = new Size(92, 25);
            labelID.TabIndex = 8;
            labelID.Text = "ID Produk";
            // 
            // labelnama
            // 
            labelnama.AutoSize = true;
            labelnama.Location = new Point(102, 144);
            labelnama.Name = "labelnama";
            labelnama.Size = new Size(59, 25);
            labelnama.TabIndex = 9;
            labelnama.Text = "Nama";
            // 
            // labelmerk
            // 
            labelmerk.AutoSize = true;
            labelmerk.Location = new Point(101, 200);
            labelmerk.Name = "labelmerk";
            labelmerk.Size = new Size(52, 25);
            labelmerk.TabIndex = 10;
            labelmerk.Text = "Merk";
            // 
            // labelkategori
            // 
            labelkategori.AutoSize = true;
            labelkategori.Location = new Point(101, 254);
            labelkategori.Name = "labelkategori";
            labelkategori.Size = new Size(78, 25);
            labelkategori.TabIndex = 11;
            labelkategori.Text = "Kategori";
            // 
            // labelharga
            // 
            labelharga.AutoSize = true;
            labelharga.Location = new Point(102, 305);
            labelharga.Name = "labelharga";
            labelharga.Size = new Size(60, 25);
            labelharga.TabIndex = 12;
            labelharga.Text = "Harga";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelharga);
            Controls.Add(labelkategori);
            Controls.Add(labelmerk);
            Controls.Add(labelnama);
            Controls.Add(labelID);
            Controls.Add(buttonLihatData);
            Controls.Add(buttonSimpan);
            Controls.Add(tb_harga);
            Controls.Add(tb_kategori);
            Controls.Add(tb_merk);
            Controls.Add(tb_nama);
            Controls.Add(tb_id);
            Controls.Add(lbtoko);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbtoko;
        private TextBox tb_id;
        private TextBox tb_nama;
        private TextBox tb_merk;
        private TextBox tb_kategori;
        private TextBox tb_harga;
        private Button buttonSimpan;
        private Button buttonLihatData;
        private Label labelID;
        private Label labelnama;
        private Label labelmerk;
        private Label labelkategori;
        private Label labelharga;
    }
    

    
}
