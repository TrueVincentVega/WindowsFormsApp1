using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            LoginForm LoginForm1 = new LoginForm();
            if (LoginForm1.ShowDialog() == DialogResult.OK)
            {
                LoginForm1.Close();
                Application.Run(new Form1());
            }
            LoginForm1.ShowDialog();
            //Application.Run(new Form1());
        }
    }
}
