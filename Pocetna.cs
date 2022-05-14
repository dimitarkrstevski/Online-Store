using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineStore
{
    public partial class Pocetna : Form
    {
        public Pocetna()
        {
            InitializeComponent();
            glavnoMeni.Visible = false;
            lblError.Visible = false;
        }

        private void човечкиРесурсиToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void внесиВработенToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HRM hrm = new HRM();
            hrm.Show();
        }

        private void btnNajava_Click(object sender, EventArgs e)
        {
            
            if(tbUsername.Text.Equals("Dimitar") && tbLozinka.Text.Equals("1234"))
            {
                
                gbNajava.Visible = false;
                glavnoMeni.Visible = true;
                pbPocetna.Visible = false;

            }
            else
            {
                lblError.Visible = true;
                tbUsername.Text = "";
                tbLozinka.Text = "";
                tbUsername.Focus();
            }
        }

        private void pbPocetna_Click(object sender, EventArgs e)
        {

        }

        private void Pocetna_Load(object sender, EventArgs e)
        {

        }

        private void lblLozinka_Click(object sender, EventArgs e)
        {

        }

        private void gbNajava_Enter(object sender, EventArgs e)
        {

        }

        private void Pocetna_Load_1(object sender, EventArgs e)
        {

        }
    }
}
