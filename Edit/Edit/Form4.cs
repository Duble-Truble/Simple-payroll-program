using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Edit
{
   
    public partial class VpisUr : Form
    {
        public VpisUr()
        {
            InitializeComponent();
        }
       
        public void IzberiPodjetjeV_SelectedIndexChanged(object sender, EventArgs e)
        {
                IzberiZaposlenega.Items.Clear();
                SQLiteConnection conn = new SQLiteConnection("Data Source=db.db;Version=3;");
                SQLiteCommand cmd1 = new SQLiteCommand(conn);
                cmd1.CommandText = "SELECT imeK FROM Klient WHERE imePodjetjaK = '"+(IzberiPodjetje.SelectedItem)+"'";
                cmd1.Connection = conn;
                conn.Open();
                SQLiteDataReader dr1 = cmd1.ExecuteReader();
            do
            {
                while (dr1.Read())
                {                   
                    IzberiZaposlenega.Items.Add(dr1["imeK"]);                  
                }               
                conn.Close();             
            }
            while (IzberiPodjetje.SelectedValue != null);          
        }
        public void VpisUr_Load(object sender, EventArgs e)
        {
            SQLiteConnection conn = new SQLiteConnection("Data Source=db.db;Version=3;");
            SQLiteCommand cmd = new SQLiteCommand(conn);
            cmd.CommandText = @"SELECT * FROM Podjetje ORDER BY imeP ASC";
            cmd.Connection = conn;
            conn.Open();
            SQLiteDataReader dr = cmd.ExecuteReader();
            while (dr.Read())               
            {
                IzberiPodjetje.Items.Add(dr["imeP"]);              
            }           
            conn.Close();
        }
        public void ShraniU_Click(object sender, EventArgs e)
        {
            if ((bool)(IzberiZaposlenega.SelectedItem = true))
            {
                string query3 = "INSERT INTO StUr ('izberiMesec', 'sturS', 'prazS', 'imeKL', 'boleznineS', 'fondUr') VALUES (@izberiMesec, @sturs, @prazS, @imeKL, @boleznine, @fondUr)";
                SQLiteConnection conn3 = new SQLiteConnection("Data Source=db.db;Version=3;");
                conn3.Open();
                SQLiteCommand cmd3 = new SQLiteCommand(query3, conn3);
                cmd3.Parameters.AddWithValue("@izberiMesec", IzberiMesec.SelectedItem);
                cmd3.Parameters.AddWithValue("@sturS", Stur.Text);
                cmd3.Parameters.AddWithValue("@prazS", Prazniki.Text);
                cmd3.Parameters.AddWithValue("@imeKL", IzberiZaposlenega.SelectedItem);
                cmd3.Parameters.AddWithValue("@boleznine", Boleznine.Text);
                cmd3.Parameters.AddWithValue("@fondUr", fondUr.Text);
                cmd3.ExecuteReader();
                conn3.Close();
                MessageBox.Show("Ure uspešno dodane!");
                this.Close();
            }
        }
    }
}
