using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Esoft
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

            IPStatus status = IPStatus.TimedOut;
            try
            {
                Ping ping = new Ping();
                PingReply reply = ping.Send(@"ya.ru");
                status = reply.Status;
            }
            catch { }
            if (status != IPStatus.Success)
            {
                DialogResult result = MessageBox.Show("                                      (>_<)\n        Отсутствует соединение с интернетом\n\n\n\nПроверьте подключение...");
                if (result == DialogResult.OK)
                {
                    Application.Exit();
                }
            }
            else
            {
                Application.Run(new Login());
            }
        }
    }
}
