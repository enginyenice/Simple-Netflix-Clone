using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NETFLIX.Datas
{
    class DBPath
    {
        public static string baslangicYolu = Application.StartupPath;
        public static string path = baslangicYolu + "/assets/";
        public static string databasePath = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source = "+path+"NetflixDataBase.accdb";
        public static string rememberMePath = path + "NETFLIXACCOUNT.nfx";

        public string DatabasePath { get => databasePath; set => databasePath = value; }
    }
}
