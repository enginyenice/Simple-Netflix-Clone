using NETFLIX.Controller;
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
        readonly UserController userControl = new UserController();
        public LoginPage()
        {
            InitializeComponent();
            
            String AccountData = userControl.RememberMe();
           
            if(AccountData  != null)
            {
                String[] AccountSplit = AccountData.Split('|');
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
            
            if(userControl.EmailKontrol(Email.Text) == false)
            {
                MessageBox.Show("Hatalı Mail Adresi");
            }
            
            else if (userControl.LoginControl(Email.Text, Password.Text) == true)
            {
                HomePage homePage = new HomePage();
                this.Hide();
                homePage.Show();
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
               userControl.RememberMeCreate(Email.Text,Password.Text);
            } else
            {
                userControl.RememberMeDelete();
            }
        }

        private void CloseApplication_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LoginPage_Load(object sender, EventArgs e)
        {
            this.Icon = Properties.Resources.netflix;

        }
    }
}
