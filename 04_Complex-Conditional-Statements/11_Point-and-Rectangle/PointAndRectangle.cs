using System;
using System.Windows.Forms;

namespace _11_Point_and_Rectangle
{
    static class PointAndRectangle
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormPointAndRectangle());
        }
    }
}
