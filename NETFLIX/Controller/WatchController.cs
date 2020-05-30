using NETFLIX.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NETFLIX.Controller
{
    class WatchController
    {
        private readonly WatchModel dBase = new WatchModel();

        public List<Datas.Program> SelectProgram(int id)
        {
            List<Datas.Program> LastProgram;
            LastProgram = dBase.SelectProgram(id);
            return LastProgram;

        }
        public void ProgramIzle(int id,int sure,int bolum) {

            dBase.ProgramIzle(id, sure, bolum);
            //Console.WriteLine(id.ToString() + " " + sure.ToString()+" "+ bolum.ToString());
        }
        public void PuanGonder(int value, int id)
        {

            dBase.PuanGonder(value, id);
        }

    }
}
