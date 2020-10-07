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
    public partial class NovPodjetje : Form
    {
        public NovPodjetje()
        {
            InitializeComponent();
        }
        private void ShraniP_Click(object sender, EventArgs e)
        {
            if (ImeP.Text.Trim() == "" && NazivP.Text.Trim() == "" && MaticnaStP.Text.Trim() == "" && DavcnaP.Text.Trim() == "" && NazivP.Text.Trim() == "" )
            {
                MessageBox.Show("Izpolniti morate vsa polja!");
            }
            else
            {
                string query2 = "INSERT INTO Podjetje ('imeP', 'nazivP', 'maticnaStP', 'davcnaStP', 'naslovP') VALUES (@ImeP, @NazivP, @MaticnaStP, @DavcnaStP, @NaslovP)";
                SQLiteConnection conn = new SQLiteConnection("Data Source=db.db;Version=3;");
                conn.Open();
                SQLiteCommand cmd1 = new SQLiteCommand(query2, conn);
                cmd1.Parameters.AddWithValue("@imeP", ImeP.Text);
                cmd1.Parameters.AddWithValue("@nazivP", NazivP.Text);
                cmd1.Parameters.AddWithValue("@maticnaStP", MaticnaStP.Text);
                cmd1.Parameters.AddWithValue("@davcnaStP", DavcnaP.Text);
                cmd1.Parameters.AddWithValue("@naslovP", NaslovP.Text);
                cmd1.ExecuteReader();
                conn.Close();
                MessageBox.Show("Podjetje uspešno dodano!");
                ImeP.Text = String.Empty;
                NazivP.Text = String.Empty;
                MaticnaStP.Text = String.Empty;
                DavcnaP.Text = String.Empty;
                NaslovP.Text = String.Empty;
                this.Close();
            }

        }

     
    }
}
