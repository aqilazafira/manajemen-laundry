namespace LaundryApp.view
{
    partial class InputTransaksi
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonKembali = new System.Windows.Forms.Button();
            this.comboBoxIdPelanggan = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnKembali = new System.Windows.Forms.Button();
            this.rdoMenyusul = new System.Windows.Forms.RadioButton();
            this.txtNoHP = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.rdoTransfer = new System.Windows.Forms.RadioButton();
            this.rdoCash = new System.Windows.Forms.RadioButton();
            this.dtpTanggalSelesai = new System.Windows.Forms.DateTimePicker();
            this.dtpTanggalMasuk = new System.Windows.Forms.DateTimePicker();
            this.txtNamaPelanggan = new System.Windows.Forms.TextBox();
            this.txtTotalHarga = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.chkHanger = new System.Windows.Forms.CheckBox();
            this.chkSetrikaUap = new System.Windows.Forms.CheckBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.cmbJenisService = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtBeratTotal = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtJenisPakaian = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtJenisPakaian);
            this.groupBox1.Controls.Add(this.buttonKembali);
            this.groupBox1.Controls.Add(this.comboBoxIdPelanggan);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.btnKembali);
            this.groupBox1.Controls.Add(this.rdoMenyusul);
            this.groupBox1.Controls.Add(this.txtNoHP);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.rdoTransfer);
            this.groupBox1.Controls.Add(this.rdoCash);
            this.groupBox1.Controls.Add(this.dtpTanggalSelesai);
            this.groupBox1.Controls.Add(this.dtpTanggalMasuk);
            this.groupBox1.Controls.Add(this.txtNamaPelanggan);
            this.groupBox1.Controls.Add(this.txtTotalHarga);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.chkHanger);
            this.groupBox1.Controls.Add(this.chkSetrikaUap);
            this.groupBox1.Controls.Add(this.btnReset);
            this.groupBox1.Controls.Add(this.cmbJenisService);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.txtBeratTotal);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(18, 18);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(1164, 655);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Data Laundry";
            // 
            // buttonKembali
            // 
            this.buttonKembali.Location = new System.Drawing.Point(308, 600);
            this.buttonKembali.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonKembali.Name = "buttonKembali";
            this.buttonKembali.Size = new System.Drawing.Size(158, 46);
            this.buttonKembali.TabIndex = 42;
            this.buttonKembali.Text = "Kembali";
            this.buttonKembali.UseVisualStyleBackColor = true;
            this.buttonKembali.Click += new System.EventHandler(this.buttonKembali_Click);
            // 
            // comboBoxIdPelanggan
            // 
            this.comboBoxIdPelanggan.FormattingEnabled = true;
            this.comboBoxIdPelanggan.Location = new System.Drawing.Point(232, 38);
            this.comboBoxIdPelanggan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxIdPelanggan.Name = "comboBoxIdPelanggan";
            this.comboBoxIdPelanggan.Size = new System.Drawing.Size(284, 28);
            this.comboBoxIdPelanggan.TabIndex = 41;
            this.comboBoxIdPelanggan.SelectedIndexChanged += new System.EventHandler(this.comboBoxIdPelanggan_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(30, 48);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(106, 20);
            this.label10.TabIndex = 40;
            this.label10.Text = "ID Pelanggan";
            // 
            // btnKembali
            // 
            this.btnKembali.Location = new System.Drawing.Point(303, 642);
            this.btnKembali.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnKembali.Name = "btnKembali";
            this.btnKembali.Size = new System.Drawing.Size(158, 46);
            this.btnKembali.TabIndex = 39;
            this.btnKembali.Text = "Kembali";
            this.btnKembali.UseVisualStyleBackColor = true;
            // 
            // rdoMenyusul
            // 
            this.rdoMenyusul.AutoSize = true;
            this.rdoMenyusul.Location = new System.Drawing.Point(855, 183);
            this.rdoMenyusul.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdoMenyusul.Name = "rdoMenyusul";
            this.rdoMenyusul.Size = new System.Drawing.Size(101, 24);
            this.rdoMenyusul.TabIndex = 38;
            this.rdoMenyusul.TabStop = true;
            this.rdoMenyusul.Text = "Menyusul";
            this.rdoMenyusul.UseVisualStyleBackColor = true;
            // 
            // txtNoHP
            // 
            this.txtNoHP.Location = new System.Drawing.Point(232, 394);
            this.txtNoHP.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNoHP.Name = "txtNoHP";
            this.txtNoHP.Size = new System.Drawing.Size(284, 26);
            this.txtNoHP.TabIndex = 37;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(30, 405);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 20);
            this.label9.TabIndex = 36;
            this.label9.Text = "No. HP";
            // 
            // rdoTransfer
            // 
            this.rdoTransfer.AutoSize = true;
            this.rdoTransfer.Location = new System.Drawing.Point(855, 237);
            this.rdoTransfer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdoTransfer.Name = "rdoTransfer";
            this.rdoTransfer.Size = new System.Drawing.Size(93, 24);
            this.rdoTransfer.TabIndex = 31;
            this.rdoTransfer.TabStop = true;
            this.rdoTransfer.Text = "Transfer";
            this.rdoTransfer.UseVisualStyleBackColor = true;
            // 
            // rdoCash
            // 
            this.rdoCash.AutoSize = true;
            this.rdoCash.Location = new System.Drawing.Point(1005, 183);
            this.rdoCash.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdoCash.Name = "rdoCash";
            this.rdoCash.Size = new System.Drawing.Size(71, 24);
            this.rdoCash.TabIndex = 30;
            this.rdoCash.TabStop = true;
            this.rdoCash.Text = "Cash";
            this.rdoCash.UseVisualStyleBackColor = true;
            // 
            // dtpTanggalSelesai
            // 
            this.dtpTanggalSelesai.Location = new System.Drawing.Point(855, 115);
            this.dtpTanggalSelesai.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpTanggalSelesai.Name = "dtpTanggalSelesai";
            this.dtpTanggalSelesai.Size = new System.Drawing.Size(289, 26);
            this.dtpTanggalSelesai.TabIndex = 29;
            // 
            // dtpTanggalMasuk
            // 
            this.dtpTanggalMasuk.Location = new System.Drawing.Point(855, 60);
            this.dtpTanggalMasuk.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpTanggalMasuk.Name = "dtpTanggalMasuk";
            this.dtpTanggalMasuk.Size = new System.Drawing.Size(289, 26);
            this.dtpTanggalMasuk.TabIndex = 28;
            // 
            // txtNamaPelanggan
            // 
            this.txtNamaPelanggan.Location = new System.Drawing.Point(232, 82);
            this.txtNamaPelanggan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNamaPelanggan.Name = "txtNamaPelanggan";
            this.txtNamaPelanggan.Size = new System.Drawing.Size(284, 26);
            this.txtNamaPelanggan.TabIndex = 27;
            // 
            // txtTotalHarga
            // 
            this.txtTotalHarga.Location = new System.Drawing.Point(855, 400);
            this.txtTotalHarga.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTotalHarga.Name = "txtTotalHarga";
            this.txtTotalHarga.Size = new System.Drawing.Size(286, 26);
            this.txtTotalHarga.TabIndex = 26;
            this.txtTotalHarga.TextChanged += new System.EventHandler(this.txtTotalHarga_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(657, 405);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 20);
            this.label8.TabIndex = 25;
            this.label8.Text = "Total Harga";
            // 
            // chkHanger
            // 
            this.chkHanger.AutoSize = true;
            this.chkHanger.Location = new System.Drawing.Point(987, 349);
            this.chkHanger.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkHanger.Name = "chkHanger";
            this.chkHanger.Size = new System.Drawing.Size(88, 24);
            this.chkHanger.TabIndex = 24;
            this.chkHanger.Text = "Hanger";
            this.chkHanger.UseVisualStyleBackColor = true;
            this.chkHanger.CheckedChanged += new System.EventHandler(this.chkHanger_CheckedChanged);
            // 
            // chkSetrikaUap
            // 
            this.chkSetrikaUap.AutoSize = true;
            this.chkSetrikaUap.Location = new System.Drawing.Point(855, 349);
            this.chkSetrikaUap.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkSetrikaUap.Name = "chkSetrikaUap";
            this.chkSetrikaUap.Size = new System.Drawing.Size(119, 24);
            this.chkSetrikaUap.TabIndex = 23;
            this.chkSetrikaUap.Text = "Setrika Uap";
            this.chkSetrikaUap.UseVisualStyleBackColor = true;
            this.chkSetrikaUap.CheckedChanged += new System.EventHandler(this.chkSetrikaUap_CheckedChanged);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(699, 600);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(158, 46);
            this.btnReset.TabIndex = 22;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // cmbJenisService
            // 
            this.cmbJenisService.FormattingEnabled = true;
            this.cmbJenisService.Items.AddRange(new object[] {
            "Regular",
            "Express"});
            this.cmbJenisService.Location = new System.Drawing.Point(855, 292);
            this.cmbJenisService.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbJenisService.Name = "cmbJenisService";
            this.cmbJenisService.Size = new System.Drawing.Size(284, 28);
            this.cmbJenisService.TabIndex = 21;
            this.cmbJenisService.SelectedIndexChanged += new System.EventHandler(this.cmbJenisService_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(652, 297);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 20);
            this.label7.TabIndex = 20;
            this.label7.Text = "Jenis Service";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(502, 600);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(158, 46);
            this.btnAdd.TabIndex = 17;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtBeratTotal
            // 
            this.txtBeratTotal.Location = new System.Drawing.Point(232, 349);
            this.txtBeratTotal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBeratTotal.Name = "txtBeratTotal";
            this.txtBeratTotal.Size = new System.Drawing.Size(284, 26);
            this.txtBeratTotal.TabIndex = 9;
            this.txtBeratTotal.TextChanged += new System.EventHandler(this.txtBeratTotal_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(654, 186);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(156, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Metode Pembayaran";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(654, 115);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tanggal Selesai";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(654, 65);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tanggal Masuk";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 354);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Berat Total";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 126);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Jenis Pakaian";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 85);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nama Pelanggan";
            // 
            // txtJenisPakaian
            // 
            this.txtJenisPakaian.Location = new System.Drawing.Point(232, 126);
            this.txtJenisPakaian.Multiline = true;
            this.txtJenisPakaian.Name = "txtJenisPakaian";
            this.txtJenisPakaian.Size = new System.Drawing.Size(286, 194);
            this.txtJenisPakaian.TabIndex = 45;
            // 
            // InputTransaksi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LaundryApp.Properties.Resources.Cream_Green_Abstract_Blank_Template_Instagram_Story;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "InputTransaksi";
            this.Text = "Input Transaksi";
            this.Load += new System.EventHandler(this.Input_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBeratTotal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.CheckBox chkHanger;
        private System.Windows.Forms.CheckBox chkSetrikaUap;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.ComboBox cmbJenisService;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTotalHarga;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNamaPelanggan;
        private System.Windows.Forms.DateTimePicker dtpTanggalSelesai;
        private System.Windows.Forms.DateTimePicker dtpTanggalMasuk;
        private System.Windows.Forms.RadioButton rdoCash;
        private System.Windows.Forms.RadioButton rdoTransfer;
        private System.Windows.Forms.TextBox txtNoHP;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RadioButton rdoMenyusul;
        private System.Windows.Forms.Button btnKembali;
        private System.Windows.Forms.ComboBox comboBoxIdPelanggan;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button buttonKembali;
        private System.Windows.Forms.TextBox txtJenisPakaian;
    }
}