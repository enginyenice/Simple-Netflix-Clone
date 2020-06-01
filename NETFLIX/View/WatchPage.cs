using NETFLIX.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
// TODO : Puan ana puan listesine eklenecek....
namespace NETFLIX.View
{
    public partial class WatchPage : Form
    {
        readonly int myProgramID;
        int izlenenSure = 0;
        int programSuresi = 0;
        static int izlenenBolum = 1;
        int bolumSayisi = 1;
        readonly WatchController watchController = new WatchController();
        public WatchPage(int programID)
        {
            myProgramID = programID;
            izlenenSure = 0;
            izlenenBolum = 1;
            InitializeComponent();
        }

        

        List<Datas.Program> LastProgram = new List<Datas.Program>();
        private void WatchPage_Load(object sender, EventArgs e)
        {
            this.Icon = Properties.Resources.netflix;
            LastProgram = watchController.SelectProgram(myProgramID);
            for (int i = 1; i <= 10; i++)
            {
                PuanCombo.Items.Add(i.ToString());
            }
            comboBox1.Visible = false;
            label20.Visible = false;
            if (LastProgram[0].ProgramTipi == 0)
            {
                comboBox1.Visible = true;
                label20.Visible = true;
                for (int i = 1; i<= LastProgram[0].ProgramBolumSayisi;i++)
                {
                    comboBox1.Items.Add(i.ToString()+" .Bölüm");
                }
            }
            if (LastProgram[0].IzlemeSure == 0 && LastProgram[0].HangiBolumdeKaldi == 1)
            {
                button1.Text = "İzlemeye Başla";
            }
            else if(LastProgram[0].IzlemeSure > 0 || LastProgram[0].HangiBolumdeKaldi >= 1)
            {
                button1.Text = "İzlemeye Devam Et";
            }
            if(LastProgram[0].IzlemeSure == 0 && LastProgram[0].HangiBolumdeKaldi == 1)
            {
                EnBastanBtn.Visible = false;
            }





            
            this.Text = LastProgram[0].ProgramAdi;

            if (LastProgram[0].KullaniciPuani == 0)
            {
                label19.Text = "Bu programa oy kullanmadınız";
            }
            else
            {
                label19.Text = LastProgram[0].KullaniciPuani.ToString();
                PuanCombo.SelectedIndex = LastProgram[0].KullaniciPuani - 1;
            }
            programSuresi = LastProgram[0].ProgramUzunlugu;
            label12.Text = (LastProgram[0].ProgramTipi == 1) ? "Film" : "Dizi";
            bolumSayisi = LastProgram[0].ProgramBolumSayisi;
            
            
            izlenenBolum = Int32.Parse(LastProgram[0].HangiBolumdeKaldi.ToString());
            izlenenSure = Int32.Parse(LastProgram[0].IzlemeSure.ToString());
            label22.Text = izlenenBolum.ToString();
            comboBox1.Text = "";
            VerileriGuncelle();



           






        }
        int calismaDurumu = 0;
        public void VerileriGuncelle()
        {
            LastProgram = watchController.SelectProgram(myProgramID);
            label1.Text = LastProgram[0].ProgramAdi;
            label4.Text = LastProgram[0].Turler;
            label10.Text = LastProgram[0].ProgramUzunlugu.ToString() + "DK";
            label14.Text = LastProgram[0].ProgramBolumSayisi.ToString();
            label17.Text = LastProgram[0].ToplamPuan.ToString();
            label8.Text = izlenenSure.ToString() + " DK";
            label6.Text = (LastProgram[0].IzlemeTarihi != DateTime.MinValue) ? LastProgram[0].IzlemeTarihi.ToString() : "İzlenmeye başlanmadı";
            label19.Text = (LastProgram[0].KullaniciPuani != 0)? LastProgram[0].KullaniciPuani.ToString() : "Bu programa oy kullanmadınız";




        }



        private void PuanGonder_Click(object sender, EventArgs e)
        {
            if(PuanCombo.SelectedIndex > -1)
            {
                int value = Int32.Parse(PuanCombo.SelectedItem.ToString());
                if (value < 11 && value > 0)
                {
                    watchController.PuanGonder(value, myProgramID);
                    //  verileriGuncelle();
                    MessageBox.Show("Puan başarıyla eklendi");
                }
                else
                {
                    MessageBox.Show("Hatalı Puan");
                }
                if (LastProgram[0].KullaniciPuani == 0)
                {
                    label19.Text = "Bu programa oy kullanmadınız";
                }
                else
                {
                    label19.Text = LastProgram[0].KullaniciPuani.ToString();
                    PuanCombo.SelectedIndex = LastProgram[0].KullaniciPuani - 1;
                }
            } else
            {
                MessageBox.Show("Puan Seçmediniz.");
            }
            VerileriGuncelle();
        }

        private void Baslat_Click(object sender, EventArgs e)
        {

            if (calismaDurumu == 0)
            {
                EnBastanBtn.Visible = false;
                
                if (comboBox1.SelectedIndex != -1)
                {
                    izlenenBolum = comboBox1.SelectedIndex + 1;
                    izlenenSure = 0;
                    label22.Text = izlenenBolum.ToString();
                    comboBox1.SelectedIndex = -1;
                }

                calismaDurumu = 1;
                
                timer1.Start();


            }
            else
            {
                
                EnBastanBtn.Visible = true;
                button1.Text = "Devam Et";
                timer1.Stop();
                calismaDurumu = 0;
            }
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {


            string text = izlenenBolum + ". Bolum " + izlenenSure + ".Dakika";
            label22.Text = izlenenBolum.ToString();
            button1.Text = "Durdur: " + text;
            DialogResult cikis;

            if (izlenenSure == programSuresi && izlenenBolum == bolumSayisi)
            {
                timer1.Stop();
                cikis = MessageBox.Show("Program tamamen bitti. Baştan izlemek ister misiniz ?", "Uyarı", MessageBoxButtons.YesNo);
                if (cikis == DialogResult.Yes)
                {
                    timer1.Start();
                    izlenenBolum = 1;
                    izlenenSure = 0;
                }
                else
                {
                    button1.Text = "Bitti " + text;
                    calismaDurumu = 0;
                }
            }

            else if (izlenenSure == programSuresi && izlenenBolum <= bolumSayisi && bolumSayisi > 1)
            {
                timer1.Stop();
                cikis = MessageBox.Show("Bölüm bitti. Yeni Bölüme başlamak izlemek ister misiniz ?", "Uyarı", MessageBoxButtons.YesNo);
                if (cikis == DialogResult.Yes)
                {
                    timer1.Start();
                    izlenenBolum += 1;
                    izlenenSure = 0;
                    Console.WriteLine(izlenenBolum + "   .");
                }
                else
                {
                    button1.Text = "Bölüm Sonu " + text;
                    calismaDurumu = 0;
                }
            }


            izlenenSure++;
            if (izlenenSure > programSuresi)
            {
                izlenenSure = programSuresi;
            }
            VerileriGuncelle();
            watchController.ProgramIzle(myProgramID, izlenenSure, izlenenBolum);





        }

        private void WatchPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            timer1.Stop();
        }

        public int Opgave { get { return 1; } }

        private void EnBastanBtn_Click(object sender, EventArgs e)
        {

            if (calismaDurumu == 0)
            {
                EnBastanBtn.Visible = false;
                izlenenBolum = 1;
                izlenenSure = 0;
                calismaDurumu = 1;

                timer1.Start();


            } else
            {
                EnBastanBtn.Visible = true;
            }
        }
    }
}
