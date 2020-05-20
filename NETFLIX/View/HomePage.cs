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
        readonly private bool  ilkKayitMi;
        public HomePage(bool ilkKayitMi = false)
        {
            this.ilkKayitMi = ilkKayitMi;
            InitializeComponent();
        }

        private void HomePage_Load(object sender, EventArgs e)
        {
            if(ilkKayitMi == true)
            {
                foreach (var item in Program.SelectTypes)
                {
                    listBox1.Items.Add(item.TurAdi);
                }
            }
            label1.Text = Program.user.KullaniciAdi;
            label2.Text = "İlk kayıt mı ? : " + ilkKayitMi.ToString();
            dateTimePicker1.Value = Program.user.KullaniciDogumTarihi;
        }
    }
}
