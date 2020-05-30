using NETFLIX.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETFLIX.Datas
{
    class Program
    {
        private int id;
        private string programAdi;
        private int programTipi;
        private int programBolumSayisi;
        private int programUzunlugu;
        private int toplamPuan;
        private String turler = "";
        private int kullaniciPuani;
        private int izlemeSure;
        private DateTime izlemeTarihi;
        private int hangiBolumdeKaldi;

        public int Id { get => id; set => id = value; }
        public string ProgramAdi { get => programAdi; set => programAdi = value; }
        public int ProgramTipi { get => programTipi; set => programTipi = value; }
        public int ProgramBolumSayisi { get => programBolumSayisi; set => programBolumSayisi = value; }
        public int ProgramUzunlugu { get => programUzunlugu; set => programUzunlugu = value; }
        public int ToplamPuan { get => toplamPuan; set => toplamPuan = value; }
        public string Turler { get => turler; set => turler = value; }
        public int KullaniciPuani { get => kullaniciPuani; set => kullaniciPuani = value; }
        public int IzlemeSure { get => izlemeSure; set => izlemeSure = value; }
        public DateTime IzlemeTarihi { get => izlemeTarihi; set => izlemeTarihi = value; }
        public int HangiBolumdeKaldi { get => hangiBolumdeKaldi; set => hangiBolumdeKaldi = value; }
    }
}
