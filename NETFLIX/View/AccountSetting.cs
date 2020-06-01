using NETFLIX.Controller;
using NETFLIX.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NETFLIX.View
{
    public partial class AccountSetting : Form
    {
        public AccountSetting()
        {
            InitializeComponent();
        }

        private void AccountSetting_Load(object sender, EventArgs e)
        {
            Username.Text = Program.user.KullaniciAdi;
            Password.Text = Program.user.KullaniciParola;
            Email.Text = Program.user.KullaniciEmail;
            Date.Value = Program.user.KullaniciDogumTarihi;
        }

        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            UserController userControl = new UserController();
            User user = new User
            {
                KullaniciAdi = Username.Text,
                KullaniciParola = Password.Text,
                KullaniciDogumTarihi = Date.Value,
                Id = Program.user.Id
            };
            int result = userControl.AccountSetting(user);


            /*
 * Donus:
 *        1 - Hesap Kayıt Edildi.
 *        2 - Hesap Kayıt Edilemedi.
 *        3 - Böyle Bir Eposta Sisteme Kayıtlı
 *        5 - Kullanıcı Adı veya şifre kısa
 */

            switch (result)
            {
                case 1:
                    MessageBox.Show("Hesap Düzenlendi", "Düzenleme Başarılı", MessageBoxButtons.OK);
                    this.Close();
                    break;
                case 2:
                    MessageBox.Show("Hesap Düzenlenemedi!", "Düzenleme Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case 3:
                    MessageBox.Show("Böyle Bir Hesap Sisteme Kayıtlı", "Düzenleme Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    break;
                case 4:
                    MessageBox.Show("Hatalı Mail Adresi", "Düzenleme Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    break;
                case 5:
                    MessageBox.Show("Ad Soyad ve Şifre en az 6 karakter olmalıdır.", "Düzenleme Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    break;
            }


        }


        public int Opgave { get { return 1; } }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
