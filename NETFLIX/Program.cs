using NETFLIX.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NETFLIX
{
    static class Program
    {
        public static User user = new User();
        public static List<Model.Type> SelectTypes = new List<Model.Type>();
        public static int watchFormStatus = 0;
        /// <summary>
        /// Uygulamanın ana girdi noktası.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginPage());
            

        }
    }
}
