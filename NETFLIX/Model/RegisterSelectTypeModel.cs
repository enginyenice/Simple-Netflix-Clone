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
            con.Open();
        }


        public bool AccountCount(String email, string password)
        {
            string sorgu = "SELECT count(*)  from kullanici WHERE kullaniciEmail='" + email + "'and kullaniciParola='" + password + "'";
            cmd = new OleDbCommand(sorgu, con);
            int result = (int)cmd.ExecuteScalar();
            if (result > 0)
            {
                //SelectUser(email, password);
                return true;
            }

            return false;

        }
        public List<Type> SelectType()
        {


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

            return types;

        }



        public bool MailCount(String email)
        {
            string sorgu = "SELECT count(*)  from kullanici WHERE kullaniciEmail='" + email + "'";
            cmd = new OleDbCommand(sorgu, con);
            int result = (int)cmd.ExecuteScalar();
            if (result > 0)
                return true;
            return false;

        }

        

        ~RegisterSelectTypeModel()
        {
            con.Close();
        }
    }
}
