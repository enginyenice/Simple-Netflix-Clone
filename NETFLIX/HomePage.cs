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
    public partial class HomePage : Form
    {
        public HomePage(String email,int id)
        {
            InitializeComponent();
            EmailData.Text = email;
            UserID.Text = id.ToString();
        }

        private void ApplicationClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SignOut_Click(object sender, EventArgs e)
        {
            LoginPage loginPage = new LoginPage();
            loginPage.Show();
            this.Close();
        }


        private bool menuStatus = false;

        private void MenuBtn_Click(object sender, EventArgs e)
        {
            if(menuStatus == false)
            {
                MenuPage.Location = new Point(-260, 100);
                MenuPage.Size = new Size(250, this.Size.Height-100);
            }
            Timer1.Enabled = true;
            pozition = 0;
            
        }

        int pozition = 0;
        readonly int anlikPikselIlerleme = 20;
        readonly int kacKereDonecek = 260 / 20;

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (pozition < kacKereDonecek && menuStatus == false)
            {
                MenuBtn.Enabled = false;
                MenuPage.Visible = true;
                MenuPage.Location = new Point((MenuPage.Location.X) + anlikPikselIlerleme, 100);
                TypeGroup.Location = new Point((TypeGroup.Location.X) + anlikPikselIlerleme, 100);
                FilmGroup.Location = new Point((FilmGroup.Location.X) + anlikPikselIlerleme, 250);
                SeriesGroup.Location = new Point((SeriesGroup.Location.X)+ anlikPikselIlerleme, 500);
                TypeGroup.Size = new Size(TypeGroup.Size.Width - anlikPikselIlerleme, TypeGroup.Size.Height);
                FilmGroup.Size = new Size(FilmGroup.Size.Width - anlikPikselIlerleme, FilmGroup.Size.Height);
                SeriesGroup.Size = new Size(SeriesGroup.Size.Width - anlikPikselIlerleme, SeriesGroup.Size.Height);
                pozition++;
            }
            else if (pozition < kacKereDonecek && menuStatus == true)
            {
                MenuBtn.Enabled = false;
                MenuPage.Visible = true;
                MenuPage.Location = new Point((MenuPage.Location.X) - anlikPikselIlerleme, 100);
                TypeGroup.Location = new Point((TypeGroup.Location.X) - anlikPikselIlerleme, 100);
                TypeGroup.Size = new Size(TypeGroup.Size.Width + anlikPikselIlerleme, TypeGroup.Size.Height);
                FilmGroup.Location = new Point((FilmGroup.Location.X) - anlikPikselIlerleme, 250);
                FilmGroup.Size = new Size(FilmGroup.Size.Width + anlikPikselIlerleme, FilmGroup.Size.Height);
                SeriesGroup.Location = new Point((SeriesGroup.Location.X) - anlikPikselIlerleme, 500);
                SeriesGroup.Size = new Size(SeriesGroup.Size.Width + anlikPikselIlerleme, SeriesGroup.Size.Height);
                pozition++;
            }

            if (pozition == kacKereDonecek && menuStatus == false)
            {
                MenuBtn.Enabled = true;
                menuStatus = true;
                MenuBtn.Text = "+";
                Timer1.Enabled = false;
            }
            else if (pozition == kacKereDonecek && menuStatus == true)
            {
                MenuBtn.Enabled = true;
                menuStatus = false;
                MenuPage.Visible = false;
                MenuBtn.Text = "-";
                Timer1.Enabled = false;
            }
        }
    }
}
