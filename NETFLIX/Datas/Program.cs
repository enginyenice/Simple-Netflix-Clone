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
        private List<Model.Type> turler;

        public int Id { get => id; set => id = value; }
        public string ProgramAdi { get => programAdi; set => programAdi = value; }
        public int ProgramTipi { get => programTipi; set => programTipi = value; }
        public int ProgramBolumSayisi { get => programBolumSayisi; set => programBolumSayisi = value; }
        public int ProgramUzunlugu { get => programUzunlugu; set => programUzunlugu = value; }
        public int ToplamPuan { get => toplamPuan; set => toplamPuan = value; }
        public List<Model.Type> Turler { get => turler; set => turler = value; }
    }
}
