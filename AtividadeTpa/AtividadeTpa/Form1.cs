using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtividadeTpa
{
    public partial class Fprincipal : Form
    {
        public Fprincipal()
        {
            InitializeComponent();
        }

        private void BtnIncluir_Click(object sender, EventArgs e)
        {
            txtbCd.Text = ("10288");
            txtbNom.Text = ("Abenr Santos Pereira");
            txtbRg.Text = ("12345678901");
            txtbTel.Text = ("13933330172");
            txtbCpf.Text = ("1234567890123");
            txtbCep.Text = ("1234567");
            txtbNum.Text = ("156");
            txtbLogradouro.Text = ("Albert");
            txtbBairro.Text = ("Centro");
            txtbCidade.Text = ("São Paulo");
            txtbEstado.Text = ("São Paulo");
            txtBEmail.Text = ("AbnerSantosPereira123@gamil.com");
            txtBFace.Text = ("Abner Pereira Oficial");
            txtBTwitter.Text = ("Abner Santos@Oficial");
            radbtnMasc.Checked = true;
            checkFace.Checked = true;
            checkTwitter.Checked = true;
            checkEmail.Checked = true;
            picbxImg.Image = Properties.Resources.wallpaper;
        }

        private void BtnAlterar_Click(object sender, EventArgs e)
        {

        }

        private void BtnConsultar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Código: "+ txtbCd.Text,"Dados Inseridos");
             MessageBox.Show("Código: "+ txtbCd.Text,"Dados Inseridos");
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {

        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            txtbCd.Text = null;
            txtbNom.Text = null;
            txtbRg.Text = null;
            txtbTel.Text = null;
            txtbCpf.Text = null;
            txtbCep.Text = null;
            txtbNum.Text = null;
            txtbLogradouro.Text = null;
            txtbBairro.Text = null;
            txtbCidade.Text = null;
            txtbEstado.Text = null;
            txtBEmail.Text = null;
            txtBFace.Text = null;
            txtBTwitter.Text = null;
            radbtnMasc.Checked = false;
            checkFace.Checked = false;
            checkTwitter.Checked = false;
            checkEmail.Checked = false;
            picbxImg.Image = null;
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnCarregarImg_Click(object sender, EventArgs e)
        {
            picbxImg.Image = Properties.Resources.wallpaper;
        }

        private void BtnLimparImg_Click(object sender, EventArgs e)
        {
            picbxImg.Image = null;
        }

        private void CheckEmail_CheckedChanged(object sender, EventArgs e)
        {
            if(checkEmail.Checked == false) {txtBEmail.Enabled = false;}
            else { txtBEmail.Enabled = true; }
           
        }

        private void CheckFace_CheckedChanged(object sender, EventArgs e)
        {
            if (checkFace.Checked == false) { txtBFace.Enabled = false; }
            else { txtBFace.Enabled = true; }
        }

        private void CheckTwitter_CheckedChanged(object sender, EventArgs e)
        {

            if (checkTwitter.Checked == false) { txtBTwitter.Enabled = false; }
            else { txtBTwitter.Enabled = true; }
        }
    }
}
