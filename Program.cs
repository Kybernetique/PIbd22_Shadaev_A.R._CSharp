using System;
using System.Windows.Forms;

namespace WindowsFormsBoat
{
    public delegate void BoatDelegate(Vehicle boat);

    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormHarbor());
        }
    }
}
