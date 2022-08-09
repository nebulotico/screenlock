using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScreenLock
{
    internal class Program
    {
        [DllImport("kernel32.dll")]
        static extern IntPtr GetConsoleWindow();
        [DllImport("user32.dll")]
        static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

        static void Main(string[] args)
        {
            ShowWindow(GetConsoleWindow(), 0);
            Application.SetCompatibleTextRenderingDefault(false);

            

            while (true)
            {
                Form f = new Form();
                f.BackColor = System.Drawing.Color.Aqua;
                f.TransparencyKey = System.Drawing.Color.Aqua;
                f.FormBorderStyle = FormBorderStyle.None;
                f.ShowIcon = false;
                f.ShowInTaskbar = false;
                f.TopMost = true;
                f.WindowState = FormWindowState.Maximized;

                Application.EnableVisualStyles();
                Application.Run(f);

                Console.ReadLine(); //Remove this line
            }

        }
    }
}