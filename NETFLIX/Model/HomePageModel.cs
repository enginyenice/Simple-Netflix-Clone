using NETFLIX.Datas;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NETFLIX.Model
{
    class HomePageModel
    {
        private readonly DBPath GetDB = new DBPath();

        private readonly OleDbConnection con = new OleDbConnection();
        private OleDbCommand cmd;
        private OleDbDataReader dr;
       
        public HomePageModel()
        {
            {
                con.ConnectionString = GetDB.DatabasePath;
                
            }
        }
       
        public List<Datas.Program> SelectAllPrograms()
        {
            con.Open();
            List<Datas.Program> programs = new List<Datas.Program>();
            string sorgu = "SELECT * from program";
            cmd = new OleDbCommand(sorgu, con);
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Datas.Program program = new Datas.Program
                {
                    Id = Int32.Parse(dr["id"].ToString()),
                    ProgramAdi = dr["programAdi"].ToString(),
                    ProgramBolumSayisi = Int32.Parse(dr["programBolumSayisi"].ToString()),
                    ProgramTipi = Int32.Parse(dr["programTipi"].ToString()),
                    ProgramUzunlugu = Int32.Parse(dr["programUzunlugu"].ToString()),
                    ToplamPuan = Int32.Parse(dr["toplamPuan"].ToString())
                };

                programs.Add(program);
            }
            con.Close();
            return programs;

        }
        public List<Model.Type> GetTypes(int id)
        {
            con.Open();
            List<Model.Type> types = new List<Type>();
            string sorgu = "select  tur.id , tur.turAdi from program,programTur,tur WHERE program.id = " + id+" AND  programTur.programId = "+id+"  And programTur.turId = tur.id";
            
            cmd = new OleDbCommand(sorgu, con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Model.Type type = new Type
                {
                    Id = Int32.Parse(dr["id"].ToString()),
                    TurAdi = dr["turAdi"].ToString()
                };

                types.Add(type);
            }


            con.Close();
            return types;

        }

        ~HomePageModel()
        {
            
        }
    }
}
