using NETFLIX.Controller;
using NETFLIX.Model;
using NETFLIX.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NETFLIX
{
    public partial class RegisterPage : Form
    {
        public RegisterPage()
        {
            InitializeComponent();
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            LoginPage loginPage = new LoginPage();
            loginPage.Show();
            this.Close();
        }

        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            UserController userController = new UserController();
            int result = userController.CreateAccount(Username.Text, Email.Text, Password.Text, Date.Value);
            /*
            * Donus:
            *        1 - Hesap Kayıt Edildi.
            *        2 - Hesap Kayıt Edilemedi.
            *        3 - Böyle Bir Eposta Sisteme Kayıtlı
            */
            switch (result)
            {
                case 1:
                    MessageBox.Show("Hesap Kayıt Edildi","Kayıt Başarılı",MessageBoxButtons.OK);
                    RegisterSelectType registerSelectType = new RegisterSelectType();
                    registerSelectType.Show();
                    this.Hide();
                    break;
                case 2:
                    MessageBox.Show("Hesap Kayıt Edilemedi!","Kayıt Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case 3:
                    MessageBox.Show("Böyle Bir Hesap Sisteme Kayıtlı","Kayıt Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    break;
            }
        }



        private void CloseApplication_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
