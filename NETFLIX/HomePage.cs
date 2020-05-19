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

namespace NETFLIX
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void HomePage_Load(object sender, EventArgs e)
        {
            label1.Text = Program.user.KullaniciAdi;
            dateTimePicker1.Value = Program.user.KullaniciDogumTarihi;
        }
    }
}
