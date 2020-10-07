using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Edit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }    
        private void novKlientToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            NovKlient nov = new NovKlient();
            nov.Show();
        }
        private void dodajNovoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NovPodjetje novP = new NovPodjetje();
            novP.Show();
        }
        private void VpisUr_Click(object sender, EventArgs e)
        {
            VpisUr novU = new VpisUr();
                novU.Show();
        }
        private void izračunToolStripMenuItem_Click(object sender, EventArgs e)
        {
            izracun izr = new izracun();
            izr.Show();
        }       
    }
}
