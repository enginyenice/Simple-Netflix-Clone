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
    class WatchModel
    {
        private readonly DBPath GetDB = new DBPath();

        private readonly SQLiteConnection con = new SQLiteConnection();
        private SQLiteCommand cmd;
        private SQLiteDataReader dr;

        public WatchModel()
        {
            {
                con.ConnectionString = GetDB.DatabasePath;

            }
        }

        public List<Datas.Program> SelectProgram(int id)
        {
            con.Open();
            List<Datas.Program> programs = new List<Datas.Program>();
            string sorgu = "SELECT program.id, program.programAdi, program.programBolumSayisi,program.programTipi,program.programUzunlugu,program.toplamPuan,tur.turAdi,tur.id FROM program, programTur, tur WHERE program.id = " + id + " AND programTur.programId = program.id AND programTur.turId = tur.id; ";
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



            con.Open();
            int userID = Program.user.Id;
            int programID = id;
            string puanVarMiSorgu = "SELECT count(*) FROM program, kullaniciProgram, kullanici WHERE kullaniciProgram.programID = program.id AND kullaniciProgram.kullaniciID = kullanici.id AND kullanici.id = " + userID + " AND program.id= " + programID + ";";
            cmd = new SQLiteCommand(puanVarMiSorgu, con);
            //MessageBox.Show(cmd.ExecuteScalar().ToString());
            int puanVarMi = Int32.Parse(cmd.ExecuteScalar().ToString());
            con.Close();

            if (puanVarMi > 0)
            {
                con.Open();
                string puanSorgu = "SELECT * FROM program, kullaniciProgram, kullanici WHERE kullaniciProgram.programID = program.id AND kullaniciProgram.kullaniciID = kullanici.id AND kullanici.id = " + userID + " AND program.id= " + programID + " ORDER BY program.programUzunlugu DESC; ";

                cmd = new SQLiteCommand(puanSorgu, con);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    //Console.WriteLine(dr["verilenPuan"].ToString());
                   // Console.WriteLine(dr["izlemeSuresi"].ToString());
                   //Console.WriteLine(dr["izlemeTarihi"].ToString());
                   // Console.WriteLine(dr["izlemeTarihi"].GetType());


                    
                    programs[0].KullaniciPuani = (dr["verilenPuan"].ToString() != "") ? Int32.Parse(dr["verilenPuan"].ToString()) : 0;
                    programs[0].IzlemeSure = (dr["izlemeSuresi"].ToString() != "") ? Int32.Parse(dr["izlemeSuresi"].ToString()) : 0;
                    programs[0].IzlemeTarihi = (dr["izlemeTarihi"].ToString() != "") ? DateTime.Parse(dr["izlemeTarihi"].ToString()) : DateTime.MinValue;
                    programs[0].HangiBolumdeKaldi = (dr["HangiBolumdeKaldi"].ToString() != "") ? Int32.Parse(dr["HangiBolumdeKaldi"].ToString()) : 1;
                    
                }


                con.Close();
            }
            else
            {
                programs[0].KullaniciPuani = 0;
                programs[0].IzlemeSure = 0;
                programs[0].HangiBolumdeKaldi = 1;
            }












            return programs;

        }
        
        public void PuanCikart(int id)
        {
            con.Open();
            string PuanSorgu = "SELECT verilenPuan FROM kullaniciProgram WHERE kullaniciID=" + Program.user.Id + " and programID=" + id + "";
            cmd = new SQLiteCommand(PuanSorgu, con);
            dr = cmd.ExecuteReader();
            int eskiPuan = 0;
            while (dr.Read())
            {
                eskiPuan = Int32.Parse(dr["verilenPuan"].ToString());
            }
            con.Close();


            con.Open();
            string sorgu = "UPDATE program SET toplamPuan = toplamPuan - "+eskiPuan+" WHERE id="+id+"";
            cmd = new SQLiteCommand(sorgu, con);
            cmd.ExecuteNonQuery();
            con.Close();

        }
        public void PuanEkle(int id, int puan)
        {
            con.Open();
            string sorgu = "UPDATE program SET toplamPuan = toplamPuan + " + puan + " WHERE id=" + id + "";
            cmd = new SQLiteCommand(sorgu, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        
        public void PuanGonder(int value, int id)
        {
            int userID = Program.user.Id;
            int result = VeriVarMi(userID,id);
            if (result > 0)
            {

                PuanCikart(id);
                PuanEkle(id, value);

                con.Open();
                string sorgu = "UPDATE kullaniciProgram SET verilenPuan="+value+" WHERE kullaniciID="+ userID + " and programID=" + id + "";
                cmd = new SQLiteCommand(sorgu, con);
                cmd.ExecuteNonQuery();
                con.Close();

            }
            else
            {
                PuanEkle(id, value);
                con.Open();
                string sorgu = "INSERT INTO kullaniciProgram (verilenPuan ,kullaniciID,programID)" +
                                "VALUES(" + value + "," + userID + "," + id + ")";
                cmd = new SQLiteCommand(sorgu, con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        public int VeriVarMi(int userID,int id)
        {
            con.Open();
            string sorgu = "SELECT count(*)  from kullaniciProgram WHERE kullaniciID=" + userID + " and programID=" + id + "";
            cmd = new SQLiteCommand(sorgu, con);
            int result = Int32.Parse(cmd.ExecuteScalar().ToString());
            con.Close();
            return result;
        }
        public void ProgramIzle(int id, int sure, int bolum)
        {
            string tamzaman;
            tamzaman = DateTime.Now.ToString();
            int userID = Program.user.Id;
            int result = VeriVarMi(userID,id);
            if(result > 0)
            {
                con.Open();
                string sorgu = "UPDATE kullaniciProgram SET " +
                    "izlemeTarihi = '"+ tamzaman + "' ," +
                    " izlemeSuresi= "+ sure + " ," +
                    " hangiBolumdeKaldi= "+ bolum + " " +
                    " WHERE kullaniciID=" + userID + " and " +
                    " programID=" + id + "";
                cmd = new SQLiteCommand(sorgu, con);
                cmd.ExecuteNonQuery();
                con.Close();

            } else
            {
                con.Open();
                string sorgu = "INSERT INTO kullaniciProgram" +
                    " (izlemeTarihi, izlemeSuresi, hangiBolumdeKaldi,kullaniciID,programID)" +
                    "VALUES('" + tamzaman + "'," + sure + "," + bolum + "," + userID + "," + id + ")";
                cmd = new SQLiteCommand(sorgu, con);
                cmd.ExecuteNonQuery();
                con.Close();
            }

        }
    }
}
