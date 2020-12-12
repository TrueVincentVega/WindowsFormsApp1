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
    public partial class PropertiesForm : Form
    {
            public Form1 parentForm;
            public PropertiesForm(Form1 form)
            {
                parentForm = form;
                InitializeComponent();
            }

            private void PropertiesForm_Load(object sender, EventArgs e)
            {

            }

            private void trackBar_Red_ValueChanged(object sender, EventArgs e)
            {
                parentForm.BackColor = Color.FromArgb(trackBar_red.Value, trackBar_green.Value, trackBar_blue.Value);
            }

            private void trackBar_Green_ValueChanged(object sender, EventArgs e)
            {
                parentForm.BackColor = Color.FromArgb(trackBar_red.Value, trackBar_green.Value, trackBar_blue.Value);
            }

            private void trackBar_Blue_ValueChanged(object sender, EventArgs e)
            {
                parentForm.BackColor = Color.FromArgb(trackBar_red.Value, trackBar_green.Value, trackBar_blue.Value);
             }
    }
}
