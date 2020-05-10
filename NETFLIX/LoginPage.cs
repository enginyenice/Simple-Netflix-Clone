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
    public partial class LoginPage : Form
    {
        readonly Model.Account Account = new Model.Account();
        public LoginPage()
        {
            InitializeComponent();
            String AccountData = Account.RememberMe();
           
            if(AccountData  != null)
            {
                String[] AccountSplit = AccountData.Split('|');
                //Console.WriteLine(AccountSplit[0] + " " + AccountSplit[1]);
                Email.Text = AccountSplit[0].ToString();
                Password.Text = AccountSplit[1].ToString();
                RememberMe.Checked = true;
            }

        }

        private void GirisEkrani_Load(object sender, EventArgs e)
        {

        }

        private void GirisBtn_Click(object sender, EventArgs e)
        {
            if (Account.LoginControl(Email.Text, Password.Text) == true)
            {
                HomePage homePage = new HomePage(Account.UserMail,Account.UserID);
                this.Hide();
                homePage.Show();
                //MessageBox.Show("Panele giriş yapılıyor.","Dogru Giriş",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
            }
            else
            {
                MessageBox.Show("E-Posta veya şifre hatalı", "Hatalı Giriş", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CreateAccount_Click(object sender, EventArgs e)
        {
            RegisterPage registerPage = new RegisterPage();
            registerPage.Show();
            this.Hide();
            
        }

        private void RememberMe_CheckedChanged(object sender, EventArgs e)
        {
            if(RememberMe.Checked == true)
            {
               Account.RememberMeCreate(Email.Text,Password.Text);
            } else
            {
                Account.RememberMeDelete();
            }
        }

        private void CloseApplication_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
