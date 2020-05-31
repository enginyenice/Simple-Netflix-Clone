using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Data;
using System.Windows.Forms;
using System.Data.Common;
using NETFLIX.Datas;
using System.Data.SQLite;

namespace NETFLIX.Model
{
    class UserModel
    {


        private readonly DBPath GetDB = new DBPath();
        
        private readonly SQLiteConnection con = new SQLiteConnection();
        private SQLiteCommand cmd;
        private SQLiteDataReader dr;
        public UserModel()
        {
            
            con.ConnectionString = GetDB.DatabasePath;
            
        }

        
        public bool AccountCount(String email,string password)
        {
            con.Open();
            string sorgu = "SELECT count(*)  from kullanici WHERE kullaniciEmail='"+email+"' and kullaniciParola='"+ password +"'";
            cmd = new SQLiteCommand(sorgu, con);
            
            int result = Int32.Parse(cmd.ExecuteScalar().ToString());
            con.Close();
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
            con.Open();
            string sorgu = "SELECT * from kullanici  WHERE kullaniciEmail='" + email + "'and kullaniciParola='" + password + "'";
            cmd = new SQLiteCommand(sorgu, con);
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                user.Id = Int32.Parse(dr["id"].ToString());
                user.KullaniciAdi = dr["kullaniciAdi"].ToString();
                user.KullaniciEmail = dr["kullaniciEmail"].ToString();
                user.KullaniciParola = dr["kullaniciParola"].ToString();
                user.KullaniciDogumTarihi = DateTime.Parse(dr["kullaniciDogumTarihi"].ToString());



            }
            con.Close();
            Program.user = user;
        }



        public bool MailCount(String email)
        {
            con.Open();
            string sorgu = "SELECT count(*)  from kullanici WHERE kullaniciEmail='" + email + "'";
            cmd = new SQLiteCommand(sorgu, con);
            int result = Int32.Parse(cmd.ExecuteScalar().ToString());
            con.Close();
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
                    con.Open();
                    string sorgu = "INSERT INTO kullanici (kullaniciAdi, kullaniciEmail, kullaniciParola,kullaniciDogumTarihi)" +
                                    "VALUES('" +newUser.KullaniciAdi + "','" + newUser.KullaniciEmail + "','" + newUser.KullaniciParola + "','" + newUser.KullaniciDogumTarihi + "')";
                    cmd = new SQLiteCommand(sorgu, con);
                    int data = cmd.ExecuteNonQuery();
                    con.Close();
                    if(data >= 1)
                        return 1;

                }

                return 3;
            }
            catch (SQLiteException exp)
            {
                MessageBox.Show(exp.ToString());
                return 2;
            }
        }



    }
}
