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
       

        public int PuanSorgula(int programID,int userID)
        {
            int puan = 0;
            con.Open();
            string sorgu = "SELECT TOP 1 kullaniciProgram.verilenPuan AS puan FROM program, kullaniciProgram, kullanici WHERE kullaniciProgram.programID = program.id AND kullaniciProgram.kullaniciID = kullanici.id AND kullanici.id = " + userID + " AND program.id= "+programID+" ORDER BY program.programUzunlugu DESC; ";
            cmd = new OleDbCommand(sorgu, con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                puan = Int32.Parse(dr["puan"].ToString());
            }
            if (puan < 0 || puan > 10)
                puan = 0;
            con.Close();
            return puan;
        }
        public List<Datas.Program> SelectAllPrograms()
        {
            con.Open();
            List<Datas.Program> programs = new List<Datas.Program>();
            string sorgu = "SELECT program.id, program.programAdi, program.programBolumSayisi,program.programTipi,program.programUzunlugu,program.toplamPuan,tur.turAdi,tur.id FROM program, programTur, tur WHERE programTur.programId = program.id AND programTur.turId = tur.id; ";
            cmd = new OleDbCommand(sorgu, con);
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Datas.Program program = new Datas.Program
                {
                    Id = Int32.Parse(dr["program.id"].ToString()),
                    ProgramAdi = dr["programAdi"].ToString(),
                    ProgramBolumSayisi = Int32.Parse(dr["programBolumSayisi"].ToString()),
                    ProgramTipi = Int32.Parse(dr["programTipi"].ToString()),
                    ProgramUzunlugu = Int32.Parse(dr["programUzunlugu"].ToString()),
                    ToplamPuan = Int32.Parse(dr["toplamPuan"].ToString()),
                    Turler = dr["turAdi"].ToString()
                };

                bool varMi = false;
                foreach (var item in programs)
                {
                    if(program.Id == item.Id)
                    {
                        item.Turler += "," + program.Turler;
                        varMi = true;
                    }
                }
                if(varMi == false)
                {
                    programs.Add(program);
                }
            }
  
            con.Close();
            return programs;

        }



        public List<Datas.Program> SelectPrograms(int turID, string programAdi)
        {
            con.Open();
            /*
             SELECT program.id, program.programAdi, program.programBolumSayisi,program.programTipi,program.programUzunlugu,program.toplamPuan,tur.turAdi,tur.id FROM program, programTur, tur WHERE  programTur.programId = program.id AND programTur.turId = tur.id AND  programAdi LIKE  "*Recep İvedik*";
             */
            List<Datas.Program> programs = new List<Datas.Program>();
            string sorgu;
            if (programAdi == "_____" && turID != -1)
                sorgu = "SELECT program.id, program.programAdi, program.programBolumSayisi,program.programTipi,program.programUzunlugu,program.toplamPuan,tur.turAdi,tur.id FROM program, programTur, tur WHERE tur.id = "+turID+" AND programTur.programId = program.id AND programTur.turId = tur.id; ";
            else if(turID == -1 && programAdi != "_____")
                sorgu = "SELECT program.id, program.programAdi, program.programBolumSayisi,program.programTipi,program.programUzunlugu,program.toplamPuan,tur.turAdi,tur.id FROM program, programTur, tur WHERE  programTur.programId = program.id AND programTur.turId = tur.id AND  programAdi LIKE  '%"+programAdi+"%';";
            else if(turID != -1 && programAdi != "_____")
                sorgu = "SELECT program.id, program.programAdi, program.programBolumSayisi,program.programTipi,program.programUzunlugu,program.toplamPuan,tur.turAdi,tur.id FROM program, programTur, tur WHERE tur.id = " + turID + " AND  programTur.programId = program.id AND programTur.turId = tur.id AND  programAdi LIKE  '%" + programAdi + "%';";
            else
                sorgu = "SELECT program.id, program.programAdi, program.programBolumSayisi,program.programTipi,program.programUzunlugu,program.toplamPuan,tur.turAdi,tur.id FROM program, programTur, tur WHERE programTur.programId = program.id AND programTur.turId = tur.id;";

            cmd = new OleDbCommand(sorgu, con);
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Datas.Program program = new Datas.Program
                {
                    Id = Int32.Parse(dr["program.id"].ToString()),
                    ProgramAdi = dr["programAdi"].ToString(),
                    ProgramBolumSayisi = Int32.Parse(dr["programBolumSayisi"].ToString()),
                    ProgramTipi = Int32.Parse(dr["programTipi"].ToString()),
                    ProgramUzunlugu = Int32.Parse(dr["programUzunlugu"].ToString()),
                    ToplamPuan = Int32.Parse(dr["toplamPuan"].ToString()),
                    Turler = dr["turAdi"].ToString()
                };

                bool varMi = false;
                foreach (var item in programs)
                {
                    if (program.Id == item.Id)
                    {
                        item.Turler += "," + program.Turler;
                        varMi = true;
                    }
                }
                if (varMi == false)
                {
                    programs.Add(program);
                }
            }

            con.Close();
            return programs;

        }


        public List<Int32> OnerilenListOlustur(int turId)
        {
            /*TODO: Uzunluga gore sıraliyor suan*/
            con.Close();
            con.Open();
            List<Int32> programIDs = new List<int>();
            string sorgu = "SELECT TOP 2 program.id FROM program, programTur, tur WHERE programTur.programId = program.id AND programTur.turId = tur.id AND tur.id = "+turId+" ORDER BY program.toplamPuan DESC,program.id DESC;";
            cmd = new OleDbCommand(sorgu, con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                programIDs.Add(Int32.Parse(dr["id"].ToString()));
            }


            return programIDs;
        }


        public void RandomScore()
        {
         
            for(int id = 1; id <76;id++)
            {
                con.Open();
                Random rastgele = new Random();
                int sayi = rastgele.Next(0, 250);
                string sorgu = "UPDATE program SET toplamPuan = " + sayi + " WHERE id = " + id + "; ";
                cmd = new OleDbCommand(sorgu, con);
                cmd.ExecuteNonQuery();
                con.Close();
            }

            
            



        }

    }
}
