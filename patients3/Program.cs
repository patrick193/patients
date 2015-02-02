using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace patients3
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
            Application.Run(new ГЛАВНАЯcs());
        }
    }
    public static class CallBackMy
    {
        public delegate void callBaackEvent(string text);
        public delegate void callBackForm(string state);
        public static callBackForm callBackFormHandler;
        public static callBaackEvent callBaackEventHandler;
    }
}
