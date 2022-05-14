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
    public partial class HRM : Form
    {
        public HRM()
        {
            InitializeComponent();
            lblNevalidnaVozrast.Visible = false;
            lblNevalidnaEmailAdresa.Visible = false;
            lblerrImePrezime.Visible = false;
            lblerrEMBG.Visible = false;
            btnVnesi.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void gbVnesiInformaciiZaVraboten_Enter(object sender, EventArgs e)
        {

        }

        private void tbVozrast_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbVozrast_Validating(object sender, CancelEventArgs e)
        {
            int vozrast;

            if (!int.TryParse(tbVozrast.Text, out vozrast))
            {
                e.Cancel = true;
                tbVozrast.Select(0, tbVozrast.Text.Length);
                String messageError = "Внеси ја возраста со бројки!";
                errPVozrast.SetError(tbVozrast, messageError);
                lblNevalidnaVozrast.Visible = true;
            }
            else if (vozrast < 18)
            {
                e.Cancel = true;
                String messageError1 = "Вработениот мора да е полнолетен!";
                errPVozrast.SetError(tbVozrast, messageError1);
                lblNevalidnaVozrast.Visible = true;

            }
            else
            {
                errPVozrast.SetError(tbVozrast, "");
                lblNevalidnaVozrast.Visible = false;
            }



        }

        private bool ValidEmailAdress(string email, out string errorMessage)
        {
            if (email.Length == 0)
            {
                errorMessage = "Задолжителен внес на E-mail!";
                return false;
            }
            if (char.IsDigit(email.First()))
            {
                errorMessage = "E-mail мора да започнува на буква!";
                tbEmail.Select(0, tbEmail.Text.Length);
                return false;
            }
            int poz;
            if ((poz = email.IndexOf("@")) > -1)
            {
                if (email.IndexOf(".", poz) > poz && email.IndexOf("@", poz + 1) <= poz)
                {
                    errorMessage = "";
                    return true;   
                }

            }
            errorMessage = "E-mail адресата мора да е во валиден формат! \n" + "На пример: someone@example.com";
            return false;

        }

        private void tbEmail_Validating(object sender, CancelEventArgs e)
        {
            string errMsg;
            if (!ValidEmailAdress(tbEmail.Text, out errMsg))
            {
                e.Cancel = true;
                errPEmail.SetError(tbEmail, errMsg);
                lblNevalidnaEmailAdresa.Visible = true;

            }
            else
            {
                errPEmail.SetError(tbEmail, "");
                lblNevalidnaEmailAdresa.Visible = false;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void mtbTelefon_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void tbKodVraboten_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if (c != '\b' && !((c >= 'a' && c <= 'f') || (c <= 'F' && c >= 'A') || (c >= '0' && c <= '9')))
            {
                e.Handled = true;
            }
            if (c >= 'a' && c <= 'f')
            {
                e.KeyChar = char.ToUpper(e.KeyChar);
            }
        }

        // Pomos za uslovite za EMBG( 1-Da bide vnesen so brojki. 2-Da bidat tocno 13 cifri)
        private void tbEMBG_Validating(object sender, CancelEventArgs e)
        {
           int maticenbr;
            if(tbEmail.TextLength < 13)
            {
                e.Cancel = true;
                string msgerr1 = "Погрешен формат на ЕМБГ! \n" + "ЕМБГ мора да биде внесен во формат со 13 бројки!";
                errPEMBG.SetError(tbEMBG, msgerr1);
            }
            if(!int.TryParse(tbEMBG.Text, out maticenbr))
            {
                e.Cancel = true;
                tbEMBG.Select(0, tbEMBG.Text.Length);
                string msgeror2 = "Внес на ЕМБГ само со бројки!";
                errPEMBG.SetError(tbEMBG, msgeror2);
           }
           else
           {
                e.Cancel = false;
                errPEMBG.SetError(tbEMBG, "");
           }
        }

        private void cbUslovi_CheckedChanged(object sender, EventArgs e)
        {
            btnVnesi.Enabled = cbUslovi.Checked;


        }

        private void llblUslovi_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Dokumenti doc = new Dokumenti();
            doc.ShowDialog();
        }

        private void btnVnesi_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbIme.Text) || string.IsNullOrEmpty(tbPrezime.Text))
            {
                lblerrImePrezime.Visible = true;
                lblerrImePrezime.Text = "Задолжителен внес на Име и Презиме";
            }
            else if (string.IsNullOrEmpty(tbVozrast.Text))
            {
                lblNevalidnaVozrast.Visible = true;
                lblNevalidnaVozrast.Text = "Внесете возраст!";
            } // kjesesmeni

            else if (string.IsNullOrEmpty(tbEMBG.Text))
            {
                lblerrEMBG.Visible = true;
                lblerrEMBG.Text = "Задолжителен внес на ЕМБГ!";
                
            }
            else
            {
                lblerrImePrezime.Visible = false;
                lblNevalidnaVozrast.Visible = false;
                lblerrEMBG.Visible = false;
                MessageBox.Show("Вработениот е внесен");
                this.Close();
            }






        }

        private void tbEMBG_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnVnesi_Validating(object sender, CancelEventArgs e)
        {

        }

        private void tbVnesiVraboten_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
