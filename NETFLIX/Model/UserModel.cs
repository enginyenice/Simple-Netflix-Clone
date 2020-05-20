using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Collections;
using System.Data;
using System.Windows.Forms;
using System.Data.Common;
using NETFLIX.Datas;

namespace NETFLIX.Model
{
    class UserModel
    {


        private readonly DBPath GetDB = new DBPath();

        private readonly OleDbConnection con = new OleDbConnection();
        private OleDbCommand cmd;
        private OleDbDataReader dr;
        public UserModel()
        {
            con.ConnectionString = GetDB.DatabasePath;
            con.Open();
        }


        public bool AccountCount(String email,string password)
        {
            string sorgu = "SELECT count(*)  from kullanici WHERE kullaniciEmail='"+email+"'and kullaniciParola='"+ password +"'";
            cmd = new OleDbCommand(sorgu, con);
            int result = (int)cmd.ExecuteScalar();
            if(result > 0)
            {
                SelectUser(email, password);
                return true;
            }

            return false;
                
        }
        public void SelectUser(String email, string password)
        {
            User user = new User();
            string sorgu = "SELECT * from kullanici  WHERE kullaniciEmail='" + email + "'and kullaniciParola='" + password + "'";
            cmd = new OleDbCommand(sorgu, con);
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                user.Id = Int32.Parse(dr["id"].ToString());
                user.KullaniciAdi = dr["kullaniciAdi"].ToString();
                user.KullaniciEmail = dr["kullaniciEmail"].ToString();
                user.KullaniciParola = dr["kullaniciParola"].ToString();
                user.KullaniciDogumTarihi = DateTime.Parse(dr["kullaniciDogumTarihi"].ToString());



            }
            Program.user = user;
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

        public int CreateAccount(User newUser)
        {
            try
            {
                bool result = MailCount(newUser.KullaniciEmail);
                if (!result)
                {
                    string sorgu = "INSERT INTO kullanici (kullaniciAdi, kullaniciEmail, kullaniciParola,kullaniciDogumTarihi)" +
                                    "VALUES('" +newUser.KullaniciAdi + "','" + newUser.KullaniciEmail + "','" + newUser.KullaniciParola + "','" + newUser.KullaniciDogumTarihi + "')";
                    cmd = new OleDbCommand(sorgu, con);
                    int data = cmd.ExecuteNonQuery();
                    if(data >= 1)
                        return 1;

                }

                return 3;
            }
            catch (OleDbException exp)
            {
                MessageBox.Show(exp.ToString());
                return 2;
            }
        }

        ~ UserModel()
        {
            con.Close();
        }

    }
}
