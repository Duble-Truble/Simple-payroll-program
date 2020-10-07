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
    public partial class izracun : Form
    {
        
        public izracun()
        {
            InitializeComponent();
            
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            SQLiteConnection conn1 = new SQLiteConnection("Data Source=db.db;Version=3;");
            SQLiteCommand cmd1 = new SQLiteCommand(conn1);
            cmd1.CommandText = "SELECT * FROM Klient WHERE imePodjetjaK = '" + (comboBox1.SelectedItem) + "'";
            cmd1.Connection = conn1;
            conn1.Open();
            SQLiteDataReader dr1 = cmd1.ExecuteReader();
            do
            {
                while (dr1.Read())
                {

                    comboBox2.Items.Add(dr1["imeK"]);
                    
                }
                conn1.Close();
            }
            while (comboBox1.SelectedValue != null);
        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {          
            SQLiteConnection conn2 = new SQLiteConnection("Data Source=db.db;Version=3;");
            SQLiteCommand cmd2 = new SQLiteCommand(conn2);
            cmd2.CommandText = @"SELECT * FROM Podjetje WHERE imep ='"+comboBox1.SelectedItem+"'   ";
            cmd2.Connection = conn2;
            conn2.Open();
            SQLiteDataReader dr2 = cmd2.ExecuteReader();
            while (dr2.Read())
            {
                textBox1.Text = (string)comboBox1.SelectedItem;
                textBox2.Text = dr2["naslovP"].ToString();
                textBox3.Text = dr2["davcnaStP"].ToString();
            }                     
            SQLiteCommand cmd3 = new SQLiteCommand(conn2);
            cmd3.CommandText = @"SELECT * FROM Klient WHERE imek ='" + comboBox2.SelectedItem + "'   ";
            cmd3.Connection = conn2;           
            SQLiteDataReader dr3 = cmd3.ExecuteReader();
            while (dr3.Read())
            {
                textBox4.Text = (dr3["imeK"].ToString());
                textBox5.Text = (dr3["davcnaK"].ToString());
                textBox15.Text = (dr3["brutoPlacaK"].ToString());
                textBox26.Text = (dr3["dodatekHranaK"].ToString());
                textBox27.Text = (dr3["dodatekPrevozK"].ToString());
                textBox11.Text = dr3["urnaPostavkaK"].ToString();
                textBox12.Text = dr3["urnaPostavkaK"].ToString();                
            }     
            SQLiteCommand cmd4 = new SQLiteCommand(conn2);
            cmd4.CommandText = @"SELECT * FROM StUr WHERE imeKL='"+comboBox2.SelectedItem+"'";
            cmd4.Connection = conn2;              
            SQLiteDataReader dr4 = cmd4.ExecuteReader();
            while (dr4.Read())
            {
               comboBox3.Items.Add(dr4["izberiMesec"]);                       
            }
            conn2.Close();          
        }
        private void izracun_Load(object sender, EventArgs e)
        {
            SQLiteConnection conn = new SQLiteConnection("Data Source=db.db;Version=3;");
            SQLiteCommand cmd = new SQLiteCommand(conn);
            cmd.CommandText = @"SELECT * FROM Podjetje ORDER BY imeP ASC";
            cmd.Connection = conn;
            conn.Open();
            SQLiteDataReader dr = cmd.ExecuteReader();
            while (dr.Read())

            {
                comboBox1.Items.Add(dr["imeP"]);
            }
            conn.Close();
        }
        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            SQLiteConnection conn2 = new SQLiteConnection("Data Source=db.db;Version=3;");
            SQLiteCommand cmd2 = new SQLiteCommand(conn2);
            cmd2.CommandText = @"SELECT * FROM StUr WHERE imeKL='" + comboBox2.SelectedItem + "'";
            cmd2.Connection = conn2;
            conn2.Open();
            SQLiteDataReader dr2 = cmd2.ExecuteReader();
            while (dr2.Read())
            {
                textBox7.Text = dr2["sturS"].ToString();
                textBox8.Text = dr2["prazS"].ToString();
                textBox9.Text = dr2["boleznineS"].ToString();
                double a = double.Parse(textBox7.Text);
                double b = double.Parse(textBox11.Text);
                double d = double.Parse(textBox8.Text);
                textBox15.Text = (a * b).ToString();
                textBox13.Text = (b/100*80).ToString();   
                textBox16.Text = (b * d).ToString();
                double o = double.Parse(textBox16.Text);   
                double c = double.Parse(textBox9.Text);
                textBox17.Text = (c * (b / 100 * 80)).ToString();
                textBox28.Text = (15.5).ToString();//prispevki delavec
                textBox29.Text = (6.36).ToString();
                textBox30.Text = (0.14).ToString();
                textBox31.Text = (0.10).ToString();
                textBox32.Text = (8.85).ToString();//prispevki delodajalec
                textBox33.Text = (6.56).ToString();
                textBox34.Text = (0.06).ToString();
                textBox35.Text = (0.53).ToString();
                textBox36.Text = (0.10).ToString();
                double f = float.Parse(textBox28.Text);
                double g = double.Parse(textBox29.Text);
                double h = double.Parse(textBox30.Text);
                double i = double.Parse(textBox31.Text);
                double j = double.Parse(textBox32.Text);
                double k = double.Parse(textBox33.Text);
                double l = double.Parse(textBox34.Text);
                double m = double.Parse(textBox35.Text);
                double n = double.Parse(textBox36.Text);
                double x = f + g + h + i;
                double y = double.Parse(textBox15.Text);
                double z = double.Parse(textBox26.Text);
                double q = double.Parse(textBox27.Text);
                double qa = double.Parse(textBox15.Text);
                double qc = double.Parse(textBox17.Text);
                double qb = double.Parse(textBox12.Text);
                textBox6.Text =x.ToString();
                textBox24.Text = (y / 100 * x).ToString();
                textBox19.Text = (y - (y / 100 * x)).ToString();        
                textBox18.Text = (qa + o + qc + z + q ).ToString();
                textBox20.Text = (d * qb -(d/100*22.1)).ToString();
                textBox21.Text = (qc - (qc / 100 * 22.1)).ToString();

                if (textBox19.Text.Trim() == "" || textBox14.Text.Trim() == "")
                {
                    MessageBox.Show("Vnesti je trbeba prispevke!", "Napaka", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
                else
                {
                    double r = double.Parse(textBox18.Text);
                    double w = double.Parse(textBox14.Text);
                    double ab = double.Parse(textBox20.Text);
                    double cd = double.Parse(textBox21.Text);
                    textBox22.Text = (r+ab+cd).ToString();
                    double abc = double.Parse(textBox24.Text);

                   

                    if (r <= 2083.33 && r >= 0)
                    {

                        textBox23.Text = (r - abc - w).ToString();
                        double t = double.Parse(textBox23.Text);
                        textBox25.Text = (t / 100 * 16).ToString();
                        double fd = double.Parse(textBox25.Text);
                        textBox40.Text = (r - abc -fd).ToString();
                    }
                    if (r >= 2083.34 && r <= 4166.67)
                    {

                        textBox23.Text = (r - abc - w).ToString();
                        double t = double.Parse(textBox23.Text);
                        textBox25.Text = (t / 100 * 33).ToString();
                        double fd = double.Parse(textBox25.Text);
                        textBox40.Text = (r - abc - fd).ToString();
                    }
                    if (r >= 4166.68 && r <= 6000.00)
                    {

                        textBox23.Text = (r - abc - w).ToString();
                        double t = double.Parse(textBox23.Text);
                        textBox25.Text = (t / 100 * 39).ToString();
                        double fd = double.Parse(textBox25.Text);
                        textBox40.Text = (r - abc - fd).ToString();
                    }
                    if (r > 6000.00)
                    {

                        textBox23.Text = (r - abc - w).ToString();
                        double t = double.Parse(textBox23.Text);
                        textBox25.Text = (t / 100 * 50).ToString();
                        double fd = double.Parse(textBox25.Text);
                        textBox40.Text = (r - abc - fd).ToString();
                    }
                    double aaa = double.Parse(textBox18.Text);
                    textBox38.Text = textBox24.Text.ToString();
                    textBox39.Text = (16.10).ToString();
                    textBox37.Text = (aaa / 100 * 16.10).ToString();
                    
                }
            }
            conn2.Close();
        }
  
    }
}
