using NETFLIX.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETFLIX.Controller
{
    class RegisterSelectTypeController
    {
        private readonly RegisterSelectTypeModel dBase = new RegisterSelectTypeModel();
        public List<Model.Type> SelectType()
        {
            
            return dBase.SelectType();
        }
    }
}
