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
    public partial class NovKlient : Form
    {

        public NovKlient()
        {
            InitializeComponent();
        }
        private void Shrani_Click(object sender, EventArgs e)
        {
            if (ImeK.Text.Trim() == "" && DrzavaK.Text.Trim() == "" && DavcnaStK.Text.Trim() == "" && DatumRojK.Text.Trim() == "" && EmsoK.Text.Trim() == "" &&
                DavcnaStK.Text.Trim() == "" && DrzavljanstvoK.Text.Trim() == "" && BrutoPlacaK.Text.Trim() == "" && RezidentstvoK.Text.Trim() == "" && NaslovK.Text.Trim() == "" && EmsoK.Text.Trim() == "" &&
                UrnaPostavkaK.Text.Trim() == "" && DodatekHranaK.Text.Trim() == "" && DodatekPrevozK.Text.Trim() == "" && PricetekK.Text.Trim() == "")
            {
                MessageBox.Show("Izpolniti morate vsa polja!");
            }
            else
            {
                string query = "INSERT INTO Klient ('imeK', 'drzavaK', 'datumRojK', 'emsoK', 'davcnaK', 'drzavljanstvoK', 'brutoPlacaK', 'rezidentstvoK', 'naslovK', 'urnaPostavkaK','dodatekHranaK','dodatekPrevozK', 'pricetekK', 'konecK', 'imePodjetjaK') VALUES (@ImeK, @DrzavaK, @DatumRojK, @EmsoK, @DavcnaK, @DrzavljanstvoK, @BrutoPlacaK, @RezidentstvoK, @NaslovK, @UrnaPostavkaK, @DodatekHranaK, @DodatekPrevozK, @PricetekK, @KonecK, @ImePodjetjaK)";
                SQLiteConnection conn = new SQLiteConnection("Data Source=db.db;Version=3;");
                conn.Open();
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.AddWithValue("@imeK", ImeK.Text); 
                cmd.Parameters.AddWithValue("@drzavaK", DrzavaK.Text);
                cmd.Parameters.AddWithValue("@datumRojK", DatumRojK.Text);
                cmd.Parameters.AddWithValue("@emsoK", EmsoK.Text);
                cmd.Parameters.AddWithValue("@davcnaK", DavcnaStK.Text);
                cmd.Parameters.AddWithValue("@drzavljanstvoK", DrzavljanstvoK.Text);
                cmd.Parameters.AddWithValue("@brutoPlacaK", BrutoPlacaK.Text);
                cmd.Parameters.AddWithValue("@rezidentstvoK", RezidentstvoK.Text);
                cmd.Parameters.AddWithValue("@naslovK", NaslovK.Text);
                cmd.Parameters.AddWithValue("@emsoK", EmsoK.Text);
                cmd.Parameters.AddWithValue("@urnaPostavkaK", UrnaPostavkaK.Text);
                cmd.Parameters.AddWithValue("@dodatekHranaK", DodatekHranaK.Text);
                cmd.Parameters.AddWithValue("@dodatekPrevozK", DodatekPrevozK.Text);
                cmd.Parameters.AddWithValue("@pricetekK", PricetekK.Text);
                cmd.Parameters.AddWithValue("@konecK", KonecK.Text);
                cmd.Parameters.AddWithValue("@imePodjetjaK",ImePodjetjaK.SelectedItem);
                cmd.ExecuteReader();
                conn.Close();         
                MessageBox.Show("Klient uspešno dodan!");
                ImeK.Text = String.Empty;
                
                DrzavaK.Text = String.Empty;
                DatumRojK.Text = String.Empty;
                BrutoPlacaK.Text = String.Empty;
                EmsoK.Text = String.Empty;
                DavcnaStK.Text = String.Empty;
                RezidentstvoK.Text = String.Empty;
                NaslovK.Text = String.Empty;
                DrzavljanstvoK.Text = String.Empty;
                UrnaPostavkaK.Text = String.Empty;
                DodatekHranaK.Text = String.Empty;
                DodatekPrevozK.Text = String.Empty;
                PricetekK.Text = String.Empty;
                KonecK.Text = String.Empty;
                ImePodjetjaK.Text = String.Empty;
                this.Close();
            }
        }
        private void NovKlient_Load(object sender, EventArgs e)
        {
            SQLiteConnection conn = new SQLiteConnection("Data Source=db.db;Version=3;");
            SQLiteCommand cmd = new SQLiteCommand(conn);
            cmd.CommandText = @"SELECT * FROM Podjetje ORDER BY imeP ASC";
            cmd.Connection = conn;
            conn.Open();
            SQLiteDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                ImePodjetjaK.Items.Add(dr["imeP"]);
            }
            conn.Close();
        }

        private void ImePodjetjaK_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
