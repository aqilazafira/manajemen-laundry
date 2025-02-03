using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaundryApp.view
{
    public partial class FormRegister : Form
    {
        public FormRegister()
        {
            InitializeComponent();
        }

            this.labelTitle = new System.Windows.Forms.Label();  
            this.labelUsername = new System.Windows.Forms.Label();  
            this.textBoxUsername = new System.Windows.Forms.TextBox();  
            this.labelPassword = new System.Windows.Forms.Label();  
            this.textBoxPassword = new System.Windows.Forms.TextBox();  
            this.labelRetypePassword = new System.Windows.Forms.Label();  
            this.textBoxRetypePassword = new System.Windows.Forms.TextBox();  
            this.buttonRegister = new System.Windows.Forms.Button();  
            this.SuspendLayout();

        private void FormRegister_Load(object sender, EventArgs e)
        {

        }
    }
}
