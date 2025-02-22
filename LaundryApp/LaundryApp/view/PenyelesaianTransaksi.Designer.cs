namespace LaundryApp.view
{
    partial class PenyelesaianTransaksi
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
            this.txtCariData = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnKembali = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnSelesaikan = new System.Windows.Forms.Button();
            this.dataGridViewPenyelesaianTransaksi = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPenyelesaianTransaksi)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtCariData);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.btnKembali);
            this.groupBox1.Controls.Add(this.btnExport);
            this.groupBox1.Controls.Add(this.btnRefresh);
            this.groupBox1.Controls.Add(this.btnSelesaikan);
            this.groupBox1.Location = new System.Drawing.Point(13, 379);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(775, 96);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detail";
            // 
            // txtCariData
            // 
            this.txtCariData.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtCariData.Location = new System.Drawing.Point(339, 17);
            this.txtCariData.Name = "txtCariData";
            this.txtCariData.Size = new System.Drawing.Size(192, 20);
            this.txtCariData.TabIndex = 43;
            this.txtCariData.TextChanged += new System.EventHandler(this.txtCariData_TextChanged);
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(244, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 13);
            this.label10.TabIndex = 42;
            this.label10.Text = "Cari Data";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // btnKembali
            // 
            this.btnKembali.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnKembali.Location = new System.Drawing.Point(140, 52);
            this.btnKembali.Name = "btnKembali";
            this.btnKembali.Size = new System.Drawing.Size(105, 30);
            this.btnKembali.TabIndex = 39;
            this.btnKembali.Text = "Kembali";
            this.btnKembali.UseVisualStyleBackColor = true;
            this.btnKembali.Click += new System.EventHandler(this.btnKembali_Click);
            // 
            // btnExport
            // 
            this.btnExport.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnExport.Location = new System.Drawing.Point(530, 52);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(105, 30);
            this.btnExport.TabIndex = 19;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnRefresh.Location = new System.Drawing.Point(400, 52);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(105, 30);
            this.btnRefresh.TabIndex = 18;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnSelesaikan
            // 
            this.btnSelesaikan.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSelesaikan.Location = new System.Drawing.Point(270, 52);
            this.btnSelesaikan.Name = "btnSelesaikan";
            this.btnSelesaikan.Size = new System.Drawing.Size(105, 30);
            this.btnSelesaikan.TabIndex = 16;
            this.btnSelesaikan.Text = "Selesaikan";
            this.btnSelesaikan.UseVisualStyleBackColor = true;
            this.btnSelesaikan.Click += new System.EventHandler(this.btnSelesaikan_Click);
            // 
            // dataGridViewPenyelesaianTransaksi
            // 
            this.dataGridViewPenyelesaianTransaksi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPenyelesaianTransaksi.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewPenyelesaianTransaksi.Name = "dataGridViewPenyelesaianTransaksi";
            this.dataGridViewPenyelesaianTransaksi.RowHeadersWidth = 62;
            this.dataGridViewPenyelesaianTransaksi.Size = new System.Drawing.Size(776, 361);
            this.dataGridViewPenyelesaianTransaksi.TabIndex = 2;
            // 
            // PenyelesaianTransaksi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LaundryApp.Properties.Resources.Cream_Green_Abstract_Blank_Template_Instagram_Story;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 487);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridViewPenyelesaianTransaksi);
            this.DoubleBuffered = true;
            this.Name = "PenyelesaianTransaksi";
            this.Text = "Penyelesaian Transaksi";
            this.Load += new System.EventHandler(this.PenyelesaianTransaksi_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPenyelesaianTransaksi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnKembali;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnSelesaikan;
        private System.Windows.Forms.DataGridView dataGridViewPenyelesaianTransaksi;
        private System.Windows.Forms.TextBox txtCariData;
        private System.Windows.Forms.Label label10;
    }
}