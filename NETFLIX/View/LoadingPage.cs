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
    public partial class LoadingPage : Form
    {
        public LoadingPage()
        {
            InitializeComponent();
        }

        private void LoadingPage_Load(object sender, EventArgs e)
        {
            this.Icon = Properties.Resources.netflix;
            this.BackgroundImage = Image.FromFile("Assets/loginScreen.png");
        }
    }
}
