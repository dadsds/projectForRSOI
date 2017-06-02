using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Printing
{
    static class Program
    {
        public static Menu FormMenue;
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            FormMenue = new Menu();
            Application.Run(FormMenue);
        }
    }
}
