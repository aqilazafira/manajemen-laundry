namespace LaundryApp.view
{
    partial class DataTransaksi
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
            this.dataGridViewTransaksi = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxIdPelanggan = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtCariData = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnKembali = new System.Windows.Forms.Button();
            this.txtNoHP = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.rdoMenyusul = new System.Windows.Forms.RadioButton();
            this.rdoTransfer = new System.Windows.Forms.RadioButton();
            this.rdoCash = new System.Windows.Forms.RadioButton();
            this.dtpTanggalSelesai = new System.Windows.Forms.DateTimePicker();
            this.dtpTanggalMasuk = new System.Windows.Forms.DateTimePicker();
            this.txtTotalHarga = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.chkHanger = new System.Windows.Forms.CheckBox();
            this.chkSetrikaUap = new System.Windows.Forms.CheckBox();
            this.cmbJenisService = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtBeratTotal = new System.Windows.Forms.TextBox();
            this.txtNamaPelanggan = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtJenisPakaian = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTransaksi)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewTransaksi
            // 
            this.dataGridViewTransaksi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTransaksi.Location = new System.Drawing.Point(18, 18);
            this.dataGridViewTransaksi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridViewTransaksi.Name = "dataGridViewTransaksi";
            this.dataGridViewTransaksi.RowHeadersWidth = 62;
            this.dataGridViewTransaksi.Size = new System.Drawing.Size(1164, 315);
            this.dataGridViewTransaksi.TabIndex = 0;
            this.dataGridViewTransaksi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewTransaksi_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtJenisPakaian);
            this.groupBox1.Controls.Add(this.comboBoxIdPelanggan);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txtCariData);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.btnKembali);
            this.groupBox1.Controls.Add(this.txtNoHP);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.rdoMenyusul);
            this.groupBox1.Controls.Add(this.rdoTransfer);
            this.groupBox1.Controls.Add(this.rdoCash);
            this.groupBox1.Controls.Add(this.dtpTanggalSelesai);
            this.groupBox1.Controls.Add(this.dtpTanggalMasuk);
            this.groupBox1.Controls.Add(this.txtTotalHarga);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.chkHanger);
            this.groupBox1.Controls.Add(this.chkSetrikaUap);
            this.groupBox1.Controls.Add(this.cmbJenisService);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.btnRefresh);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.txtBeratTotal);
            this.groupBox1.Controls.Add(this.txtNamaPelanggan);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(20, 345);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(1162, 422);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detail";
            // 
            // comboBoxIdPelanggan
            // 
            this.comboBoxIdPelanggan.FormattingEnabled = true;
            this.comboBoxIdPelanggan.Location = new System.Drawing.Point(152, 31);
            this.comboBoxIdPelanggan.Name = "comboBoxIdPelanggan";
            this.comboBoxIdPelanggan.Size = new System.Drawing.Size(286, 28);
            this.comboBoxIdPelanggan.TabIndex = 43;
            this.comboBoxIdPelanggan.SelectedIndexChanged += new System.EventHandler(this.comboBoxIdPelanggan_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 32);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(106, 20);
            this.label11.TabIndex = 42;
            this.label11.Text = "ID Pelanggan";
            // 
            // txtCariData
            // 
            this.txtCariData.Location = new System.Drawing.Point(508, 302);
            this.txtCariData.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCariData.Name = "txtCariData";
            this.txtCariData.Size = new System.Drawing.Size(286, 26);
            this.txtCariData.TabIndex = 41;
            this.txtCariData.TextChanged += new System.EventHandler(this.txtCariData_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(366, 306);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 20);
            this.label10.TabIndex = 40;
            this.label10.Text = "Cari Data";
            // 
            // btnKembali
            // 
            this.btnKembali.Location = new System.Drawing.Point(202, 355);
            this.btnKembali.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnKembali.Name = "btnKembali";
            this.btnKembali.Size = new System.Drawing.Size(158, 46);
            this.btnKembali.TabIndex = 39;
            this.btnKembali.Text = "Kembali";
            this.btnKembali.UseVisualStyleBackColor = true;
            // 
            // txtNoHP
            // 
            this.txtNoHP.Location = new System.Drawing.Point(152, 254);
            this.txtNoHP.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNoHP.Name = "txtNoHP";
            this.txtNoHP.Size = new System.Drawing.Size(286, 26);
            this.txtNoHP.TabIndex = 35;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 258);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 20);
            this.label9.TabIndex = 34;
            this.label9.Text = "No. HP";
            // 
            // rdoMenyusul
            // 
            this.rdoMenyusul.AutoSize = true;
            this.rdoMenyusul.Location = new System.Drawing.Point(777, 114);
            this.rdoMenyusul.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdoMenyusul.Name = "rdoMenyusul";
            this.rdoMenyusul.Size = new System.Drawing.Size(101, 24);
            this.rdoMenyusul.TabIndex = 33;
            this.rdoMenyusul.TabStop = true;
            this.rdoMenyusul.Text = "Menyusul";
            this.rdoMenyusul.UseVisualStyleBackColor = true;
            // 
            // rdoTransfer
            // 
            this.rdoTransfer.AutoSize = true;
            this.rdoTransfer.Location = new System.Drawing.Point(1044, 114);
            this.rdoTransfer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdoTransfer.Name = "rdoTransfer";
            this.rdoTransfer.Size = new System.Drawing.Size(93, 24);
            this.rdoTransfer.TabIndex = 32;
            this.rdoTransfer.TabStop = true;
            this.rdoTransfer.Text = "Transfer";
            this.rdoTransfer.UseVisualStyleBackColor = true;
            // 
            // rdoCash
            // 
            this.rdoCash.AutoSize = true;
            this.rdoCash.Location = new System.Drawing.Point(916, 114);
            this.rdoCash.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdoCash.Name = "rdoCash";
            this.rdoCash.Size = new System.Drawing.Size(71, 24);
            this.rdoCash.TabIndex = 31;
            this.rdoCash.TabStop = true;
            this.rdoCash.Text = "Cash";
            this.rdoCash.UseVisualStyleBackColor = true;
            // 
            // dtpTanggalSelesai
            // 
            this.dtpTanggalSelesai.Location = new System.Drawing.Point(646, 68);
            this.dtpTanggalSelesai.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpTanggalSelesai.Name = "dtpTanggalSelesai";
            this.dtpTanggalSelesai.Size = new System.Drawing.Size(494, 26);
            this.dtpTanggalSelesai.TabIndex = 30;
            // 
            // dtpTanggalMasuk
            // 
            this.dtpTanggalMasuk.Location = new System.Drawing.Point(646, 26);
            this.dtpTanggalMasuk.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpTanggalMasuk.Name = "dtpTanggalMasuk";
            this.dtpTanggalMasuk.Size = new System.Drawing.Size(494, 26);
            this.dtpTanggalMasuk.TabIndex = 29;
            // 
            // txtTotalHarga
            // 
            this.txtTotalHarga.Location = new System.Drawing.Point(627, 214);
            this.txtTotalHarga.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTotalHarga.Name = "txtTotalHarga";
            this.txtTotalHarga.Size = new System.Drawing.Size(514, 26);
            this.txtTotalHarga.TabIndex = 28;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(513, 218);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 20);
            this.label8.TabIndex = 27;
            this.label8.Text = "Total Harga";
            // 
            // chkHanger
            // 
            this.chkHanger.AutoSize = true;
            this.chkHanger.Location = new System.Drawing.Point(1044, 165);
            this.chkHanger.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkHanger.Name = "chkHanger";
            this.chkHanger.Size = new System.Drawing.Size(88, 24);
            this.chkHanger.TabIndex = 26;
            this.chkHanger.Text = "Hanger";
            this.chkHanger.UseVisualStyleBackColor = true;
            this.chkHanger.CheckedChanged += new System.EventHandler(this.chkHanger_CheckedChanged);
            // 
            // chkSetrikaUap
            // 
            this.chkSetrikaUap.AutoSize = true;
            this.chkSetrikaUap.Location = new System.Drawing.Point(916, 165);
            this.chkSetrikaUap.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkSetrikaUap.Name = "chkSetrikaUap";
            this.chkSetrikaUap.Size = new System.Drawing.Size(119, 24);
            this.chkSetrikaUap.TabIndex = 25;
            this.chkSetrikaUap.Text = "Setrika Uap";
            this.chkSetrikaUap.UseVisualStyleBackColor = true;
            this.chkSetrikaUap.CheckedChanged += new System.EventHandler(this.chkSetrikaUap_CheckedChanged);
            // 
            // cmbJenisService
            // 
            this.cmbJenisService.FormattingEnabled = true;
            this.cmbJenisService.Items.AddRange(new object[] {
            "Regular",
            "Express"});
            this.cmbJenisService.Location = new System.Drawing.Point(627, 162);
            this.cmbJenisService.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbJenisService.Name = "cmbJenisService";
            this.cmbJenisService.Size = new System.Drawing.Size(265, 28);
            this.cmbJenisService.TabIndex = 23;
            this.cmbJenisService.SelectedIndexChanged += new System.EventHandler(this.cmbJenisService_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(513, 166);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 20);
            this.label7.TabIndex = 22;
            this.label7.Text = "Jenis Service";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(801, 355);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(158, 46);
            this.btnRefresh.TabIndex = 18;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(602, 355);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(158, 46);
            this.btnDelete.TabIndex = 17;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(402, 355);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(158, 46);
            this.btnUpdate.TabIndex = 16;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtBeratTotal
            // 
            this.txtBeratTotal.Location = new System.Drawing.Point(152, 208);
            this.txtBeratTotal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBeratTotal.Name = "txtBeratTotal";
            this.txtBeratTotal.Size = new System.Drawing.Size(286, 26);
            this.txtBeratTotal.TabIndex = 12;
            this.txtBeratTotal.TextChanged += new System.EventHandler(this.txtBeratTotal_TextChanged);
            // 
            // txtNamaPelanggan
            // 
            this.txtNamaPelanggan.Location = new System.Drawing.Point(152, 68);
            this.txtNamaPelanggan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNamaPelanggan.Name = "txtNamaPelanggan";
            this.txtNamaPelanggan.Size = new System.Drawing.Size(286, 26);
            this.txtNamaPelanggan.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(513, 117);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(156, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Metode Pembayaran";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(513, 72);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Tanggal Selesai";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(513, 31);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tanggal Masuk";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 212);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Berat Total";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 106);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Jenis Pakaian";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 72);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nama Pelanggan";
            // 
            // txtJenisPakaian
            // 
            this.txtJenisPakaian.Location = new System.Drawing.Point(152, 106);
            this.txtJenisPakaian.Multiline = true;
            this.txtJenisPakaian.Name = "txtJenisPakaian";
            this.txtJenisPakaian.Size = new System.Drawing.Size(286, 84);
            this.txtJenisPakaian.TabIndex = 44;
            // 
            // DataTransaksi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LaundryApp.Properties.Resources.Cream_Green_Abstract_Blank_Template_Instagram_Story;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1200, 749);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridViewTransaksi);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "DataTransaksi";
            this.Text = "Data Transaksi";
            this.Load += new System.EventHandler(this.DataTransaksi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTransaksi)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewTransaksi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBeratTotal;
        private System.Windows.Forms.TextBox txtNamaPelanggan;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.ComboBox cmbJenisService;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox chkHanger;
        private System.Windows.Forms.CheckBox chkSetrikaUap;
        private System.Windows.Forms.TextBox txtTotalHarga;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton rdoTransfer;
        private System.Windows.Forms.RadioButton rdoCash;
        private System.Windows.Forms.DateTimePicker dtpTanggalSelesai;
        private System.Windows.Forms.DateTimePicker dtpTanggalMasuk;
        private System.Windows.Forms.TextBox txtNoHP;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RadioButton rdoMenyusul;
        private System.Windows.Forms.Button btnKembali;
        private System.Windows.Forms.TextBox txtCariData;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBoxIdPelanggan;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtJenisPakaian;
    }
}