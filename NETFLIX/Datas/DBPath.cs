using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETFLIX.Datas
{
    class DBPath
    {
        private string databasePath = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source = NetflixDataBase.accdb";

        public string DatabasePath { get => databasePath; set => databasePath = value; }
    }
}
