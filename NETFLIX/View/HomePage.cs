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
    public partial class HomePage : Form
    {
        readonly private bool  ilkKayitMi;
        public HomePage(bool ilkKayitMi = false)
        {
            InitializeComponent();
            this.ilkKayitMi = ilkKayitMi;
            this.Opacity = 0;


        }

        readonly HomePageController homePageController = new HomePageController();
        readonly RegisterSelectTypeController register = new RegisterSelectTypeController();


        private void HomePage_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("Assets/account.png");
            System.Drawing.Icon ico = new System.Drawing.Icon("Assets/netflix.ico");
            this.Icon = ico;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            LoadingPage loading = new LoadingPage();
            
            loading.Show();
            if(ilkKayitMi == false)
            {
                tabControl1.TabPages.Remove(tabPage4);
            }
            else if (ilkKayitMi == true)
            {
                tabControl1.SelectedTab = tabPage4;
            }
            FilmList.Columns.Add("ID", 50);
            FilmList.Columns.Add("Adı", 200);
            FilmList.Columns.Add("Türü", 500);
            FilmList.Columns.Add("Uzunluğu", 165);
            ///FilmList.Columns.Add("Puanım", 100);
            FilmList.Columns.Add("Puan", 120);


            DiziList.Columns.Add("ID", 50);
            DiziList.Columns.Add("Adı", 200);
            DiziList.Columns.Add("Türü", 400);
            DiziList.Columns.Add("Uzunluğu", 160);
            DiziList.Columns.Add("Bölüm Sayısı", 100);
            ///DiziList.Columns.Add("Puanım", 100);
            DiziList.Columns.Add("Puan", 120);



            arananList.Columns.Add("ID", 50);
            arananList.Columns.Add("Adı", 200);
            arananList.Columns.Add("Türü", 460);
            arananList.Columns.Add("Tipi", 50);
            arananList.Columns.Add("Bölüm Sayısı", 100);
            arananList.Columns.Add("Uzunluğu", 100);
            ///arananList.Columns.Add("Puanım", 100);
            arananList.Columns.Add("Puan", 100);



            TakipEttigimProgramlarList.Columns.Add("ID", 50);
            TakipEttigimProgramlarList.Columns.Add("Adı", 200);
            TakipEttigimProgramlarList.Columns.Add("Türü", 460);
            TakipEttigimProgramlarList.Columns.Add("Tipi", 50);
            TakipEttigimProgramlarList.Columns.Add("Bölüm Sayısı", 100);
            TakipEttigimProgramlarList.Columns.Add("Uzunluğu", 100);
            ///arananList.Columns.Add("Puanım", 100);
            TakipEttigimProgramlarList.Columns.Add("Kaldığım Bölüm", 100);
            TakipEttigimProgramlarList.Columns.Add("Kaldığım Süre", 100);
            TakipEttigimProgramlarList.Columns.Add("Verdiğim Puan", 100);
            TakipEttigimProgramlarList.Columns.Add("Toplam Puan", 100);
            TakipEttigimProgramlarList.Columns.Add("İzleme Tarihi", 100);


            VerileriGetir();
            Search();
            System.Threading.Thread.Sleep(2000);
            this.Opacity = 100;
            loading.Hide();

        }
        public void VerileriGetir()
        {
            adsoyad.Text = Program.user.KullaniciAdi;
            eposta.Text = Program.user.KullaniciEmail;
            dogumtarihi.Text = Program.user.KullaniciDogumTarihi.ToShortDateString();
            FilmList.Items.Clear();
            DiziList.Items.Clear();
            OnerilenlerList.Items.Clear();
            arananList.Items.Clear();
            List<Model.Type> types;
            types = register.SelectType();
            foreach (var item in types)
            {
                TypeCombo.Items.Add(item.TurAdi);
                typeIDCombo.Items.Add(item.Id.ToString());
            }

            foreach (var item in homePageController.SelectAllPrograms())
            {
                //int puanim = homePageController.PuanSorgula(item.Id);
                if (item.ProgramTipi == 1) // Film
                {

                    string[] filmData = { item.Id.ToString(), item.ProgramAdi, item.Turler, item.ProgramUzunlugu.ToString() + " Dakika", item.ToplamPuan.ToString() };
                    ListViewItem filmItem = new ListViewItem(filmData);
                    FilmList.Items.Add(filmItem);
                }
                else //Dizi
                {
                    string[] diziData = { item.Id.ToString(), item.ProgramAdi, item.Turler,item.ProgramUzunlugu.ToString()+ " Dakika", item.ProgramBolumSayisi.ToString(), item.ToplamPuan.ToString() };
                    ListViewItem diziItem = new ListViewItem(diziData);
                    DiziList.Items.Add(diziItem);
                }

            }


            if (ilkKayitMi == true)
            {
                OnerilenlerList.Columns.Add("Film ID", 50);
                OnerilenlerList.Columns.Add("Adı", 200);
                OnerilenlerList.Columns.Add("Türü", 300);
                OnerilenlerList.Columns.Add("Uzunluğu / Bölüm Sayısı", 300);
                OnerilenlerList.Columns.Add("Puan", 100);
                label7.Text = "Sevdiğiniz Türler: ";

                foreach (var item in homePageController.OnerilenList())
                {
                    string[] onerilenData = { item.Id.ToString(), item.ProgramAdi, item.Turler, item.ProgramUzunlugu.ToString() + " Dakika", item.ToplamPuan.ToString() };
                    ListViewItem onerilenItem = new ListViewItem(onerilenData);
                    OnerilenlerList.Items.Add(onerilenItem);
                }
                foreach (var item in Program.SelectTypes)
                {

                    label7.Text += item.TurAdi + ", ";
                }
            }
            TakipEttigim();
            Search();
        }

        private void FilmList_DoubleClick(object sender, EventArgs e)
        {
            if (FilmList.SelectedItems.Count > 0)
            {
                ListViewItem item = FilmList.SelectedItems[0];
                int selectProgramID = Int32.Parse(item.SubItems[0].Text);
                View.WatchPage watchPage = new WatchPage(selectProgramID);
                watchPage.ShowDialog();
                if(watchPage.Opgave == 1)
                {
                    VerileriGetir();
                }
            }
        }

        private void OnerilenlerList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FilmList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DiziList_DoubleClick(object sender, EventArgs e)
        {
            if (DiziList.SelectedItems.Count > 0)
            {
                ListViewItem item = DiziList.SelectedItems[0];
                int selectProgramID = Int32.Parse(item.SubItems[0].Text);
                View.WatchPage watchPage = new WatchPage(selectProgramID);
                watchPage.ShowDialog();
                if (watchPage.Opgave == 1)
                {
                    VerileriGetir();
                }
            }
        }



        private void OnerilenlerList_DoubleClick(object sender, EventArgs e)
        {
            if (OnerilenlerList.SelectedItems.Count > 0)
            {
                ListViewItem item = OnerilenlerList.SelectedItems[0];
                int selectProgramID = Int32.Parse(item.SubItems[0].Text);
                View.WatchPage watchPage = new WatchPage(selectProgramID);
                watchPage.ShowDialog();
                if (watchPage.Opgave == 1)
                {
                    VerileriGetir();
                }
            }
        }


        private void SearchButton(object sender, EventArgs e)
        {
            Search();
        }

        private void Search()
        {
            string aramaText = "";
            TypeCombo.Text = "";
            arananList.Items.Clear();
            string program = "_____";
            if (programName.Text.Length > 0)
            {
                program = programName.Text;
                aramaText += "Aranan Kelime: " + program + " ";
            }

            int turID = -1;
            if (TypeCombo.SelectedIndex != -1)
            {
                turID = Int32.Parse(typeIDCombo.Items[TypeCombo.SelectedIndex].ToString()) + 1;
                aramaText += "Aranan Tür: " + TypeCombo.SelectedItem.ToString() + " ";
            }

            foreach (var item in homePageController.SelectPrograms(turID, program))
            {
                string[] aramaData = { item.Id.ToString(), item.ProgramAdi, item.Turler, (item.ProgramTipi == 1) ? "Film" : "Dizi", item.ProgramBolumSayisi.ToString(), item.ProgramUzunlugu.ToString() + " Dakika", item.ToplamPuan.ToString() };
                ListViewItem aramaItem = new ListViewItem(aramaData);
                arananList.Items.Add(aramaItem);
            }
            label6.Text = aramaText;
        }

        private void ArananList_DoubleClick(object sender, EventArgs e)
        {
            if (arananList.SelectedItems.Count > 0)
            {
                ListViewItem item = arananList.SelectedItems[0];
                int selectProgramID = Int32.Parse(item.SubItems[0].Text);
                View.WatchPage watchPage = new WatchPage(selectProgramID);
                watchPage.ShowDialog();
                                if(watchPage.Opgave == 1)
                {
                    VerileriGetir();
                }
            }
        }

        private void TakipEttigimProgramlarList_DoubleClick(object sender, EventArgs e)
        {
            if (TakipEttigimProgramlarList.SelectedItems.Count > 0)
            {
                ListViewItem item = TakipEttigimProgramlarList.SelectedItems[0];
                int takiptProgramID = Int32.Parse(item.SubItems[0].Text);
                View.WatchPage watchPage = new WatchPage(takiptProgramID);
                watchPage.ShowDialog();
                if (watchPage.Opgave == 1)
                {
                    VerileriGetir();
                }
            }
        }


        private void TakipBtn_Click(object sender, EventArgs e)
        {

            TakipEttigim();
        }

        private void TakipEttigim()
        {
            TakipEttigimProgramlarList.Items.Clear();
            List<Datas.Program> programData = homePageController.TakipEttigimProgramlar();
            if (programData.Count == 0)
            {
               // MessageBox.Show("Takip Ettiğiniz Program Bulunmuyor...");
            }
            foreach (var item in programData)
            {
                string[] takipList = { item.Id.ToString(), item.ProgramAdi, item.Turler,
                                       (item.ProgramTipi == 1) ? "Film" : "Dizi",
                                       item.ProgramBolumSayisi.ToString(),
                                       item.ProgramUzunlugu.ToString() + " Dakika",
                                        item.HangiBolumdeKaldi.ToString(),item.IzlemeSure.ToString(),
                                      (item.KullaniciPuani != 0)? item.KullaniciPuani.ToString() : "Verilmedi",item.ToplamPuan.ToString(),
                                       (item.IzlemeTarihi != DateTime.MinValue)? item.IzlemeTarihi.ToShortDateString() : "Başlanmadı"};
                ListViewItem takipItem = new ListViewItem(takipList);
                TakipEttigimProgramlarList.Items.Add(takipItem);
            }
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            this.Dispose();
            LoginPage login = new LoginPage();
            Program.user.Id = -1;
            Program.user.KullaniciAdi = "";
            Program.user.KullaniciEmail = "";
            Program.user.KullaniciParola = "";
            Program.SelectTypes.Clear();
            login.Show();
        }

        private void HomePage_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("İyi günler dileriz... :)", "NETFLIX");
            Application.Exit();
        }

        private void HesapAyarlari_Click(object sender, EventArgs e)
        {
            View.AccountSetting accountSetting = new AccountSetting();
            accountSetting.ShowDialog();
            if (accountSetting.Opgave == 1)
            {
                VerileriGetir();
            }
        }
    }
}
