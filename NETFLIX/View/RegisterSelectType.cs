using NETFLIX.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NETFLIX.View
{
    public partial class RegisterSelectType : Form
    {
        private readonly RegisterSelectTypeController RegisterSelectTypeController = new RegisterSelectTypeController();
        public RegisterSelectType()
        {
            InitializeComponent();
        }

        private void RegisterSelectType_Load(object sender, EventArgs e)
        {
            this.Icon = Properties.Resources.netflix;
            label1.Text = "Merhaba " + Program.user.KullaniciAdi + " senden en çok sevdigin 3 türü seçmeni istiyoruz..";
            foreach (var item in RegisterSelectTypeController.SelectType())
            {
                TypeCheckList.Items.Add(item.TurAdi);
            }
        }

        private void SelectTypeList_Click(object sender, EventArgs e)
        {
            if (TypeCheckList.CheckedItems.Count > 3)
            {
                MessageBox.Show("Maksimum 3 Adet Seçim Yapılabilir");
            }
            else
            {
                MessageBox.Show("Onerilen Filmler Gösteriliyor..");
                foreach (var item in TypeCheckList.CheckedItems)
                {
                    Model.Type type = new Model.Type();
                    string[] words = item.ToString().Split('-');
                    type.Id = Int32.Parse(words[0]);
                    type.TurAdi = words[1];
                    Program.SelectTypes.Add(type);

                }
                this.Dispose();
                HomePage homePage = new HomePage(true);
                homePage.Show();

            }
        }
    }
}
