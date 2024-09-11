using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
        public static string person { get; set; }
        public static string role { get; set; }
        public static Form1 form { get; set; }
        public static void direct(string path_directory)
        {
            if (!Directory.Exists(path_directory))
            {
                Directory.CreateDirectory(path_directory);
            }
        }
        public static string path_to_str(string path)
        {
            int startIndex = path.IndexOf('\\');
            int endIndex = path.LastIndexOf('.');
            string str_clon = path.Substring(startIndex + 1, endIndex - startIndex - 1);
            return str_clon;
        }
    }
}
