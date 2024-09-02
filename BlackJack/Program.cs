using System;
using System.Windows.Forms;

namespace BlackJack
{
    internal static class Program
    {
        /// <summary>
        /// necessario para inicio da aplicacao 
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}