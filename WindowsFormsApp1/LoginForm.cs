using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
        }

        private void loginForm_Load(object sender, EventArgs e)
        {

        }

        private void accept_button_Click(object sender, EventArgs e)
        {
            if (textBox_login.Text == "root" && textBox_password.Text == "12345678")
            {
                this.DialogResult = DialogResult.OK;
            }
            else information_label.Visible = true;
        }
    }
}
