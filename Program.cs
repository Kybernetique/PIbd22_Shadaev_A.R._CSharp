using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsBoat
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormVessel());
        }
    }
}
