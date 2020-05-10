using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NETFLIX.Model
{
    class Account
    {
        public string UserMail { get; set; }
        public int UserID { get; set; }

        public bool LoginControl(String email, String password)
        {
            // SQL Sorgular sonuc true ise dogru
            bool result = true;
            if(result == true)
            {
                this.UserMail = email;
                this.UserID = 1;
            }

            return result;
        }
        public int CreateAccount(String email, String password, String date)
        {
            /*
             * Donus:
             *        1 - Hesap Kayıt Edildi.
             *        2 - Hesap Kayıt Edilemedi.
             *        3 - Böyle Bir Eposta Sisteme Kayıtlı
             */
            int result = 3;



            return result;

        }
        public string RememberMe()
        {
            string baslangicYolu = Application.StartupPath;
            string dosya_yolu = baslangicYolu+"//NETFLIXACCOUNT.nfx";
            FileStream fs = new FileStream(dosya_yolu, FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader sw = new StreamReader(fs);
            string text = sw.ReadLine();
            sw.Close();
            fs.Close();
            return text;
        }
        public void RememberMeCreate(String email, String password)
        {
            string baslangicYolu = Application.StartupPath;
            string dosya_yolu = baslangicYolu + "//NETFLIXACCOUNT.nfx";
            FileStream fs = new FileStream(dosya_yolu, FileMode.Create, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine(email + "|"+ password);
            sw.Close();
            fs.Close();
        }
        public void RememberMeDelete()
        {
            string baslangicYolu = Application.StartupPath;
            string dosya_yolu = baslangicYolu + "//NETFLIXACCOUNT.nfx";
            System.IO.File.Delete(dosya_yolu);
        }
    }
}
