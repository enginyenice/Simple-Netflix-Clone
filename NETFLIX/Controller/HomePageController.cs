using NETFLIX.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETFLIX.Controller
{
    class HomePageController
    {

        private readonly HomePageModel dBase = new HomePageModel();
        List<Datas.Program> programs = new List<Datas.Program>();
        public List<Datas.Program> SelectAllPrograms()
        {
            programs = dBase.SelectAllPrograms();
            return programs;
        }

        public List<Datas.Program> SelectPrograms(int turID, string programAdi)
        {
            programs = dBase.SelectPrograms(turID, programAdi);
            return programs;
        }
        public int PuanSorgula(int id)
        {

            return dBase.PuanSorgula(id,Program.user.Id);
        }
        public List<Datas.Program> OnerilenList()
        {
            List<Int32> onerilenListIDs = new List<Int32>();
            List<Datas.Program> onerilenList = new List<Datas.Program>();
            foreach (var item in Program.SelectTypes)
            {
                _ = new List<Int32>();
                List<int> onerilen = dBase.OnerilenListOlustur(item.Id);
                for (int i = 0; i < onerilenListIDs.Count; i++)
                {
                    for (int k = 0; k < onerilen.Count; k++)
                    {
                        if(onerilenListIDs[i] == onerilen[k])
                        {
                            onerilen.RemoveAt(k);
                        }
                    }
                }
                for(int i = 0; i< onerilen.Count;i++)
                {
                    if(onerilen.Count > 0 && i > -1 && onerilen[i] > -1)
                        onerilenListIDs.Add(onerilen[i]);
                }
            }

            foreach (var item in programs)
            {
                for(int i = 0; i< onerilenListIDs.Count;i++)
                {
                    if(onerilenListIDs[i] == item.Id)
                    {
                        onerilenList.Add(item);
                    }
                }
            }

            return onerilenList;
        }

        public void RandomScore()
        {
            dBase.RandomScore();
        }


    }
}
