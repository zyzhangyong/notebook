using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopNote
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormLogin());
            FormDirectory fm1 = new FormDirectory();
            //fm1.ShowDialog();
            FormDirectory fm2 = new FormDirectory();
            //fm2.ShowDialog();
        }
    }
}
