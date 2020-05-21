using NETFLIX.Datas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace NETFLIX.View
{
    public partial class TurEkle : Form
    {
        private readonly DBPath GetDB = new DBPath();
        private readonly OleDbConnection con = new OleDbConnection();
        private OleDbCommand cmd;
        private OleDbDataReader dr;
        public TurEkle()
        {
            con.ConnectionString = GetDB.DatabasePath;



                InitializeComponent();
            con.Open();
            string sorgu = "select * from program";
            cmd = new OleDbCommand(sorgu, con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                listBox1.Items.Add(dr["programAdi"].ToString());
            }
            con.Close();

            con.Open();
            sorgu = "select * from tur";
            cmd = new OleDbCommand(sorgu, con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                checkedListBox1.Items.Add(dr["turAdi"].ToString());

            }
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // listBox1.SelectedIndex + 1
            // i + 1;
            
            for (int i = 0;i<checkedListBox1.CheckedItems.Count;i++)
            {
                con.Open();
                string sorgu = "SELECT * from tur WHERE turAdi='" + checkedListBox1.CheckedItems[i].ToString() + "'";
                cmd = new OleDbCommand(sorgu, con);
                dr = cmd.ExecuteReader();
                int id = 0;
                while (dr.Read())
                {
                    id = Int32.Parse(dr["id"].ToString());
                }
                sorgu = "INSERT INTO programTur (programId, turId) VALUES ("+(listBox1.SelectedIndex + 1) + ","+id +")";
                cmd = new OleDbCommand(sorgu, con);
                cmd.ExecuteNonQuery();
                con.Close();
                
            }
            for(int i = 0; i< checkedListBox1.Items.Count;i++)
            {
                checkedListBox1.SetItemCheckState(i, CheckState.Unchecked);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            string sorgu = "SELECT count(*) from program";
            cmd = new OleDbCommand(sorgu, con);
            int kayitSayisi = (int)cmd.ExecuteScalar();
            con.Close();
            for(int i = 1; i<= kayitSayisi;i++)
            {
                con.Open();
                sorgu = "SELECT * from program WHERE id="+ i+"";
                cmd = new OleDbCommand(sorgu, con);
                dr = cmd.ExecuteReader();
                
                int status = 0;
                while (dr.Read())
                {
                    status = Int32.Parse(dr["programTipi"].ToString());
                }
                con.Close();


                Random rastgele = new Random();
                int sayi = rastgele.Next(80,200);
                int bolum = rastgele.Next(1, 200);

                con.Open();
                if(status == 1)
                    sorgu = "UPDATE program SET programUzunlugu ="+sayi+", programBolumSayisi=1  WHERE id="+i+"";
                else
                    sorgu = "UPDATE program SET programUzunlugu =" + sayi + ", programBolumSayisi="+ bolum + " WHERE id=" + i + "";
                cmd = new OleDbCommand(sorgu, con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }
    }
}
