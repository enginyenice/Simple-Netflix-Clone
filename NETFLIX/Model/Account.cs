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
        public bool LoginControl(String Email, String Password)
        {
            // SQL Sorgular sonuc true ise dogru
            bool result = true;

            return result;
        }
        public int CreateAccount(String Email, String Password, String Date)
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
        public void RememberMeCreate(String Email, String Password)
        {
            string baslangicYolu = Application.StartupPath;
            string dosya_yolu = baslangicYolu + "//NETFLIXACCOUNT.nfx";
            FileStream fs = new FileStream(dosya_yolu, FileMode.Create, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine(Email+"|"+Password);
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
