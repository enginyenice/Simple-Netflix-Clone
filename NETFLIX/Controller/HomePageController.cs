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
        public List<Datas.Program> SelectAllPrograms()
        {

            return dBase.SelectAllPrograms();
        }
        public List<Model.Type> GetTypes(int id)
        {
            return dBase.GetTypes(id);
        }
    }
}
