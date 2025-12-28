/*
using adiWFProject.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace adiWFProject
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new pupilForm());
        }
    }
}
*/


using adiWFProject.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace adiWFProject
{
    static class Program
    {
        /// <summary>
        /// נקודת הכניסה הראשית של האפליקציה.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // תיקון: שינינו את pupilForm ל-login כדי שהתוכנית תתחיל במסך הכניסה
            Application.Run(new login());
        }
    }
}
