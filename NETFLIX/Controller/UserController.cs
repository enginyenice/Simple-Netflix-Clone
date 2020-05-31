using NETFLIX.Datas;
using NETFLIX.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NETFLIX.Controller
{
    class UserController
    {
        readonly UserModel dB = new UserModel();
        User user = new User();

        internal User User { get => user; set => user = value; }

        public bool EmailKontrol(string email)
        {
            try
            {
                MailAddress m = new MailAddress(email);
                return true;
            }
            catch
            {
                return false;
            }
        }
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
             *        4 - Hatali Mail
             *        5 - Kullanıcı Adı veya şifre kısa
             */
            if(EmailKontrol(email) == false)
            {
                return 4;
            }
            if(name.Trim().Length <= 6 || password.Trim().Length <= 6)
            {
                return 5;
            }
           User newUser = new User
            {
                KullaniciAdi = name,
                KullaniciEmail = email,
                KullaniciParola = password,
                KullaniciDogumTarihi = date
            };
            
            int result = dB.CreateAccount(newUser);
            if (result == 1)
                Program.user = newUser;
            return result;

        }
        public string RememberMe()
        {
            string dosya_yolu = DBPath.rememberMePath;
            FileStream fs = new FileStream(dosya_yolu, FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader sw = new StreamReader(fs);
            string text = sw.ReadLine();
            sw.Close();
            fs.Close();
            return text;
        }
        public void RememberMeCreate(String email, String password)
        {
            string dosya_yolu = DBPath.rememberMePath;
            FileStream fs = new FileStream(dosya_yolu, FileMode.Create, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine(email + "|" + password);
            sw.Close();
            fs.Close();
        }
        public void RememberMeDelete()
        {
            string dosya_yolu = DBPath.rememberMePath;
            System.IO.File.Delete(dosya_yolu);
        }
    }
}
