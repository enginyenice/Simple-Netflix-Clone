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
        readonly DBConnection dB = new DBConnection();
        User user = new User();

        internal User User { get => user; set => user = value; }

        public bool LoginControl(String email, String password)
        {
        bool result = dB.AccountCount(email, password);
        return result;
        }
        public int CreateAccount(String name, String email, String password, DateTime date)
        {
            /*
             * Donus:
             *        1 - Hesap Kayıt Edildi.
             *        2 - Hesap Kayıt Edilemedi.
             *        3 - Böyle Bir Eposta Sisteme Kayıtlı
             */

            User newUser = new User();
            newUser.KullaniciAdi = name;
            newUser.KullaniciEmail = email;
            newUser.KullaniciParola = password;
            newUser.KullaniciDogumTarihi = date;
            int result = dB.CreateAccount(newUser);



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
