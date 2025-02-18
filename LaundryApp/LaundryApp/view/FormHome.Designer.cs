namespace LaundryApp.view
{
    partial class FormHome
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
            this.buttonRegisterForm = new System.Windows.Forms.Button();
            this.buttonLoginForm = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
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
            // buttonRegisterForm
            // 
            this.buttonRegisterForm.Location = new System.Drawing.Point(172, 189);
            this.buttonRegisterForm.Name = "buttonRegisterForm";
            this.buttonRegisterForm.Size = new System.Drawing.Size(124, 47);
            this.buttonRegisterForm.TabIndex = 1;
            this.buttonRegisterForm.Text = "Register";
            this.buttonRegisterForm.UseVisualStyleBackColor = true;
            this.buttonRegisterForm.Click += new System.EventHandler(this.buttonRegisterForm_Click);
            // 
            // buttonLoginForm
            // 
            this.buttonLoginForm.Location = new System.Drawing.Point(172, 122);
            this.buttonLoginForm.Name = "buttonLoginForm";
            this.buttonLoginForm.Size = new System.Drawing.Size(124, 47);
            this.buttonLoginForm.TabIndex = 2;
            this.buttonLoginForm.Text = "Login";
            this.buttonLoginForm.UseVisualStyleBackColor = true;
            this.buttonLoginForm.Click += new System.EventHandler(this.buttonLoginForm_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.buttonLoginForm);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.buttonRegisterForm);
            this.panel1.Location = new System.Drawing.Point(169, 97);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(463, 256);
            this.panel1.TabIndex = 3;
            // 
            // FormHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LaundryApp.Properties.Resources.Cream_Green_Abstract_Blank_Template_Instagram_Story;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Name = "FormHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.FormHome_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonRegisterForm;
        private System.Windows.Forms.Button buttonLoginForm;
        private System.Windows.Forms.Panel panel1;
    }
}