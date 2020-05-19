using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETFLIX.Model
{
    class User
    {
        private int id;
        private string kullaniciAdi;
        private string kullaniciEmail;
        private string kullaniciParola;
        private DateTime kullaniciDogumTarihi;

        public int Id { get => id; set => id = value; }
        public string KullaniciAdi { get => kullaniciAdi; set => kullaniciAdi = value; }
        public string KullaniciEmail { get => kullaniciEmail; set => kullaniciEmail = value; }
        public string KullaniciParola { get => kullaniciParola; set => kullaniciParola = value; }
        public DateTime KullaniciDogumTarihi { get => kullaniciDogumTarihi; set => kullaniciDogumTarihi = value; }
    }
}
