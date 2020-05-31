using NETFLIX.Datas;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NETFLIX.Model
{
    class HomePageModel
    {
        private readonly DBPath GetDB = new DBPath();

        private readonly SQLiteConnection con = new SQLiteConnection();
        private SQLiteCommand cmd;
        private SQLiteDataReader dr;
       
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
            cmd = new SQLiteCommand(sorgu, con);
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
            cmd = new SQLiteCommand(sorgu, con);
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
                sorgu = "SELECT " +
                    "program.id AS pid, program.programAdi, program.programBolumSayisi," +
                    "program.programTipi,program.programUzunlugu,program.toplamPuan," +
                    "tur.turAdi, tur.id " +
                    "FROM " +
                    "programTur " +
                    "INNER JOIN tur ON " +
                    "tur.id = programTur.turID " +
                    "INNER JOIN program ON " +
                    "program.id = programTur.programID " +
                    "WHERE tur.id = "+turID+"";
            else if(turID == -1 && programAdi != "_____")
                sorgu = "SELECT program.id AS pid, program.programAdi, " +
                    "program.programBolumSayisi,program.programTipi," +
                    "program.programUzunlugu,program.toplamPuan, tur.turAdi, tur.id " +
                    "FROM " +
                    "programTur INNER JOIN " +
                    "tur ON " +
                    "tur.id = programTur.turID " +
                    "INNER JOIN program ON " +
                    "program.id = programTur.programID " +
                    "WHERE program.programAdi LIKE  '%" + programAdi + "%'; ";
            else if(turID != -1 && programAdi != "_____")
                sorgu = "SELECT program.id AS pid, program.programAdi, " +
                    "program.programBolumSayisi,program.programTipi," +
                    "program.programUzunlugu,program.toplamPuan, tur.turAdi, tur.id " +
                    "FROM " +
                    "programTur INNER JOIN " +
                    "tur ON " +
                    "tur.id = programTur.turID " +
                    "INNER JOIN program ON " +
                    "program.id = programTur.programID " +
                    "WHERE tur.id = " + turID + " AND program.programAdi LIKE  '%" + programAdi + "%'; ";
            else
                sorgu = "SELECT program.id AS pid, program.programAdi, " +
    "program.programBolumSayisi,program.programTipi," +
    "program.programUzunlugu,program.toplamPuan, tur.turAdi, tur.id " +
    "FROM " +
    "programTur INNER JOIN " +
    "tur ON " +
    "tur.id = programTur.turID " +
    "INNER JOIN program ON " +
    "program.id = programTur.programID";

            cmd = new SQLiteCommand(sorgu, con);
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Datas.Program program = new Datas.Program
                {
                    Id = Int32.Parse(dr["pid"].ToString()),
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
            con.Open();
            List<Int32> programIDs = new List<int>();
            //string sorgu = "SELECT TOP 2 program.id FROM program, programTur, tur WHERE programTur.programId = program.id AND programTur.turId = tur.id AND tur.id = "+turId+" ORDER BY program.toplamPuan DESC,program.id DESC;";
            string sorgu = "SELECT " +
                "program.id, program.programAdi, tur.id " +
                "FROM  programTur " +
                "INNER JOIN " +
                " tur ON " +
                "tur.id = programTur.turID " +
                "INNER JOIN " +
                "program ON " +
                "program.id = programTur.programID " +
                "WHERE tur.id = "+turId+" LIMIT 2 ";
            cmd = new SQLiteCommand(sorgu, con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                programIDs.Add(Int32.Parse(dr["id"].ToString()));
            }

            con.Close();
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
                cmd = new SQLiteCommand(sorgu, con);
                cmd.ExecuteNonQuery();
                con.Close();
            }

            
            



        }
        public List<Datas.Program> TakipEttigimProgramlar(List<Datas.Program> programlar)
        {

            con.Open();
            string CountSorgu = "SELECT count(*)  from kullaniciProgram WHERE kullaniciID =" + Program.user.Id + "";
            cmd = new SQLiteCommand(CountSorgu, con);
            int result = Int32.Parse(cmd.ExecuteScalar().ToString());
            //Int32.Parse(cmd.ExecuteScalar().ToString());
            con.Close();
            List<Datas.Program> programs = new List<Datas.Program>();
            if (result > 0)
            {
                
                con.Open();
#pragma warning disable IDE0059 // Bir değerin gereksiz ataması
                DateTime izlemeTarihi = DateTime.MinValue;
#pragma warning restore IDE0059 // Bir değerin gereksiz ataması

                string sorgu = "SELECT * FROM kullaniciProgram WHERE kullaniciID =" + Program.user.Id + "";
                cmd = new SQLiteCommand(sorgu, con);
                dr = cmd.ExecuteReader();
                var idArray = new ArrayList();
                var izlemeSuresiArray = new ArrayList();
                var hangiBolumdeKaldiArray = new ArrayList();
                var verilenPuanArray = new ArrayList();
                var izlemeTarihiArray = new ArrayList();
                while (dr.Read())
                {
                    idArray.Add(Int32.Parse(dr["programID"].ToString()));
                    izlemeSuresiArray.Add((dr["izlemeSuresi"].ToString() != "")? Int32.Parse(dr["izlemeSuresi"].ToString()) : 0);

                    hangiBolumdeKaldiArray.Add((dr["hangiBolumdeKaldi"].ToString() != "") ? Int32.Parse(dr["hangiBolumdeKaldi"].ToString()) : 1);
                    
                    verilenPuanArray.Add(Int32.Parse(dr["verilenPuan"].ToString()));
                    izlemeTarihiArray.Add((dr["izlemeTarihi"].ToString() != "") ? DateTime.Parse(dr["izlemeTarihi"].ToString()): DateTime.MinValue) ;




                }
                con.Close();

                for (int i = 0; i < idArray.Count; i++)
                {
                    foreach (var item in programlar)
                    {
                        if (item.Id == Int32.Parse(idArray[i].ToString()))
                        {
                            item.IzlemeSure = Int32.Parse(izlemeSuresiArray[i].ToString());
                            item.IzlemeTarihi = DateTime.Parse(izlemeTarihiArray[i].ToString());
                            item.KullaniciPuani = Int32.Parse(verilenPuanArray[i].ToString());
                            item.HangiBolumdeKaldi = Int32.Parse(hangiBolumdeKaldiArray[i].ToString());

                            programs.Add(item);
                        }
                    }
                }
            }

         

            return programs;
        }


    }
}
