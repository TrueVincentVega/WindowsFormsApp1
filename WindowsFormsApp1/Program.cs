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
            /*LoginForm loginForm1 = new LoginForm();
            if (loginForm1.ShowDialog() == DialogResult.OK)
            {
                loginForm1.Close();
                Application.Run(new Form1());
            }
            loginForm1.ShowDialog();*/
            Application.Run(new Form1());
        }
    }
}
