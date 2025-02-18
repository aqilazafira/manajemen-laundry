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
    public partial class FormHome : Form
    {
        public FormHome()
        {
            InitializeComponent();
        }

        private void buttonLoginForm_Click(object sender, EventArgs e)
        {
            FormLogin fl = new FormLogin();
            this.Hide();
            fl.Show();
        }

        private void buttonRegisterForm_Click(object sender, EventArgs e)
        {
            FormRegister fr = new FormRegister();
            this.Hide();
            fr.Show();
        }

        private void FormHome_Load(object sender, EventArgs e)
        {

        }
    }
}
