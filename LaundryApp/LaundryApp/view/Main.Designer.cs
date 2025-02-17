namespace LaundryApp.view
{
    partial class Main
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonPenyelesaianTransaksi = new System.Windows.Forms.Button();
            this.buttonDataTransaksi = new System.Windows.Forms.Button();
            this.buttonDataPelanggan = new System.Windows.Forms.Button();
            this.buttonInputPelanggan = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonInputTransaksi = new System.Windows.Forms.Button();
            this.buttonKeluar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.buttonKeluar);
            this.panel1.Controls.Add(this.buttonPenyelesaianTransaksi);
            this.panel1.Controls.Add(this.buttonDataTransaksi);
            this.panel1.Controls.Add(this.buttonDataPelanggan);
            this.panel1.Controls.Add(this.buttonInputPelanggan);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.buttonInputTransaksi);
            this.panel1.Location = new System.Drawing.Point(169, 97);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(463, 256);
            this.panel1.TabIndex = 4;
            // 
            // buttonPenyelesaianTransaksi
            // 
            this.buttonPenyelesaianTransaksi.Location = new System.Drawing.Point(308, 97);
            this.buttonPenyelesaianTransaksi.Name = "buttonPenyelesaianTransaksi";
            this.buttonPenyelesaianTransaksi.Size = new System.Drawing.Size(124, 47);
            this.buttonPenyelesaianTransaksi.TabIndex = 5;
            this.buttonPenyelesaianTransaksi.Text = "Penyelesaian Transaksi";
            this.buttonPenyelesaianTransaksi.UseVisualStyleBackColor = true;
            this.buttonPenyelesaianTransaksi.Click += new System.EventHandler(this.buttonPenyelesaianTransaksi_Click);
            // 
            // buttonDataTransaksi
            // 
            this.buttonDataTransaksi.Location = new System.Drawing.Point(169, 168);
            this.buttonDataTransaksi.Name = "buttonDataTransaksi";
            this.buttonDataTransaksi.Size = new System.Drawing.Size(124, 47);
            this.buttonDataTransaksi.TabIndex = 4;
            this.buttonDataTransaksi.Text = "Data Transaksi";
            this.buttonDataTransaksi.UseVisualStyleBackColor = true;
            this.buttonDataTransaksi.Click += new System.EventHandler(this.buttonDataTransaksi_Click);
            // 
            // buttonDataPelanggan
            // 
            this.buttonDataPelanggan.Location = new System.Drawing.Point(169, 97);
            this.buttonDataPelanggan.Name = "buttonDataPelanggan";
            this.buttonDataPelanggan.Size = new System.Drawing.Size(124, 47);
            this.buttonDataPelanggan.TabIndex = 3;
            this.buttonDataPelanggan.Text = "Data Pelanggan";
            this.buttonDataPelanggan.UseVisualStyleBackColor = true;
            this.buttonDataPelanggan.Click += new System.EventHandler(this.buttonDataPelanggan_Click);
            // 
            // buttonInputPelanggan
            // 
            this.buttonInputPelanggan.Location = new System.Drawing.Point(30, 97);
            this.buttonInputPelanggan.Name = "buttonInputPelanggan";
            this.buttonInputPelanggan.Size = new System.Drawing.Size(124, 47);
            this.buttonInputPelanggan.TabIndex = 2;
            this.buttonInputPelanggan.Text = "Input Pelanggan";
            this.buttonInputPelanggan.UseVisualStyleBackColor = true;
            this.buttonInputPelanggan.Click += new System.EventHandler(this.buttonInputPelanggan_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(429, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Selamat Datang di Laundri-in!";
            // 
            // buttonInputTransaksi
            // 
            this.buttonInputTransaksi.Location = new System.Drawing.Point(30, 168);
            this.buttonInputTransaksi.Name = "buttonInputTransaksi";
            this.buttonInputTransaksi.Size = new System.Drawing.Size(124, 47);
            this.buttonInputTransaksi.TabIndex = 1;
            this.buttonInputTransaksi.Text = "Input Transaksi";
            this.buttonInputTransaksi.UseVisualStyleBackColor = true;
            this.buttonInputTransaksi.Click += new System.EventHandler(this.buttonInputTransaksi_Click);
            // 
            // buttonKeluar
            // 
            this.buttonKeluar.Location = new System.Drawing.Point(308, 168);
            this.buttonKeluar.Name = "buttonKeluar";
            this.buttonKeluar.Size = new System.Drawing.Size(124, 47);
            this.buttonKeluar.TabIndex = 6;
            this.buttonKeluar.Text = "Keluar";
            this.buttonKeluar.UseVisualStyleBackColor = true;
            this.buttonKeluar.Click += new System.EventHandler(this.buttonKeluar_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Main";
            this.Text = "Main";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonInputPelanggan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonInputTransaksi;
        private System.Windows.Forms.Button buttonDataPelanggan;
        private System.Windows.Forms.Button buttonDataTransaksi;
        private System.Windows.Forms.Button buttonPenyelesaianTransaksi;
        private System.Windows.Forms.Button buttonKeluar;
    }
}