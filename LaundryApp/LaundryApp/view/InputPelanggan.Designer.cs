namespace LaundryApp.view
{
    partial class InputPelanggan
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
            this.label4 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.txtNamaPelanggan = new System.Windows.Forms.TextBox();
            this.dtpTanggalDaftar = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.txtNoHP = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnKembali = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(226, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nama Pelanggan";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(226, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tanggal Daftar";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(336, 390);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(105, 30);
            this.btnAdd.TabIndex = 17;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(476, 390);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(105, 30);
            this.btnReset.TabIndex = 22;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // txtNamaPelanggan
            // 
            this.txtNamaPelanggan.Location = new System.Drawing.Point(359, 39);
            this.txtNamaPelanggan.Name = "txtNamaPelanggan";
            this.txtNamaPelanggan.Size = new System.Drawing.Size(191, 20);
            this.txtNamaPelanggan.TabIndex = 27;
            // 
            // dtpTanggalDaftar
            // 
            this.dtpTanggalDaftar.Location = new System.Drawing.Point(358, 113);
            this.dtpTanggalDaftar.Name = "dtpTanggalDaftar";
            this.dtpTanggalDaftar.Size = new System.Drawing.Size(194, 20);
            this.dtpTanggalDaftar.TabIndex = 28;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(226, 79);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 13);
            this.label9.TabIndex = 36;
            this.label9.Text = "No. HP";
            // 
            // txtNoHP
            // 
            this.txtNoHP.Location = new System.Drawing.Point(359, 76);
            this.txtNoHP.Name = "txtNoHP";
            this.txtNoHP.Size = new System.Drawing.Size(192, 20);
            this.txtNoHP.TabIndex = 37;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnKembali);
            this.groupBox1.Controls.Add(this.txtNoHP);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.dtpTanggalDaftar);
            this.groupBox1.Controls.Add(this.txtNamaPelanggan);
            this.groupBox1.Controls.Add(this.btnReset);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 426);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Data Pelanggan";
            // 
            // btnKembali
            // 
            this.btnKembali.Location = new System.Drawing.Point(196, 390);
            this.btnKembali.Name = "btnKembali";
            this.btnKembali.Size = new System.Drawing.Size(105, 30);
            this.btnKembali.TabIndex = 38;
            this.btnKembali.Text = "Kembali";
            this.btnKembali.UseVisualStyleBackColor = true;
            this.btnKembali.Click += new System.EventHandler(this.btnKembali_Click);
            // 
            // InputPelanggan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "InputPelanggan";
            this.Text = "InputPelanggan";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.TextBox txtNamaPelanggan;
        private System.Windows.Forms.DateTimePicker dtpTanggalDaftar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtNoHP;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnKembali;
    }
}