using NETFLIX.Datas;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NETFLIX.Model
{
    class RegisterSelectTypeModel
    {
        private readonly DBPath GetDB = new DBPath();

        private readonly OleDbConnection con = new OleDbConnection();
        private OleDbCommand cmd;
        private OleDbDataReader dr;
        public RegisterSelectTypeModel()
        {
            con.ConnectionString = GetDB.DatabasePath;
            
        }

        public List<Type> SelectType()
        {

            con.Open();
            List<Type> types = new List<Type>();
            string sorgu = "SELECT * from tur";
            cmd = new OleDbCommand(sorgu, con);
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Type type = new Type
                {
                    Id = Int32.Parse(dr["id"].ToString()),
                    TurAdi = dr["turAdi"].ToString()
                };
                types.Add(type);
                
            }
            con.Close();
            return types;

        }

      

        ~RegisterSelectTypeModel()
        {
            
        }
    }
}
