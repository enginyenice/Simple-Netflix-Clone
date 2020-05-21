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

        readonly HomePageController homePageController = new HomePageController();
        private void HomePage_Load(object sender, EventArgs e)
        {

            FilmList.Columns.Add("Film ID", 50);
            FilmList.Columns.Add("Film Adı", 200);
            FilmList.Columns.Add("Film Türü", 300);
            FilmList.Columns.Add("Film Uzunluğu", 100);
            FilmList.Columns.Add("Puan", 100);

            
            
            DiziList.Columns.Add("Dizi ID", 50);
            DiziList.Columns.Add("Dizi Adı", 200);
            DiziList.Columns.Add("Dizi Türü", 300);
            DiziList.Columns.Add("Dizi Bölüm Sayısı", 100);
            DiziList.Columns.Add("Dizi Hangi Bölümde Kaldın", 175);
            DiziList.Columns.Add("Puan", 100);



            foreach (var item in homePageController.SelectAllPrograms())
            {
                List<Model.Type> programTypes = homePageController.GetTypes(item.Id);
                string TypesText = "";
                for(int i = 0; i< programTypes.Count;i++)
                {
                    TypesText += programTypes[i].TurAdi + " ";
                }

                if (item.ProgramTipi == 1) // Film
                {

                    string[] filmData = { item.Id.ToString(), item.ProgramAdi,TypesText, item.ProgramUzunlugu.ToString()+" Dakika", item.ToplamPuan.ToString() };
                    ListViewItem filmItem = new ListViewItem(filmData);
                    FilmList.Items.Add(filmItem);
                }
                else //Dizi
                {
                    string[] diziData = { item.Id.ToString(), item.ProgramAdi, TypesText, item.ProgramBolumSayisi.ToString(),"---",item.ToplamPuan.ToString() };
                    ListViewItem diziItem = new ListViewItem(diziData);
                    DiziList.Items.Add(diziItem);
                }

            }
            

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
