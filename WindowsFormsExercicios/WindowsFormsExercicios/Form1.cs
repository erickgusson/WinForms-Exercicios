using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsExercicios
{
    public partial class FormHome : Form
    {
        public FormHome()
        {
            InitializeComponent();
        }

        public void loadForm(object form)
        {

            if (this.painelConteudo.Controls.Count > 0)
                this.painelConteudo.Controls.RemoveAt(0);

            Form formSelecionado = form as Form;
            formSelecionado.TopLevel = false;
            formSelecionado.Dock = DockStyle.Fill;
            this.painelConteudo.Controls.Add(formSelecionado);
            this.painelConteudo.Tag = formSelecionado;
            formSelecionado.Show();

            

        }

        private void btnEX1_Click(object sender, EventArgs e)
        {

            loadForm(new formEX1());

            lblFormNome.Text = btnEX1.Text;

        }

        private void btnEX2_Click(object sender, EventArgs e)
        {
            loadForm(new FormEX2());

            lblFormNome.Text = btnEX2.Text;
        }

        private void btnEX3_Click(object sender, EventArgs e)
        {
            loadForm(new FormEX3());

            lblFormNome.Text = btnEX3.Text;
        }

        private void btnEX4_Click(object sender, EventArgs e)
        {
            loadForm(new FormEX4());

            lblFormNome.Text = btnEX4.Text;
        }

        private void btnEX5_Click(object sender, EventArgs e)
        {
            loadForm(new FormEX5());

            lblFormNome.Text = btnEX5.Text;

        }

        private void btnEX6_Click(object sender, EventArgs e)
        {

            loadForm(new FormEX6());

            lblFormNome.Text = btnEX6.Text;

        }

        private void btnEX7_Click(object sender, EventArgs e)
        {

            loadForm(new FormEX7());

            lblFormNome.Text = btnEX7.Text;

        }

        private void btnDesafio_Click(object sender, EventArgs e)
        {

            loadForm(new FormDesafio());

            lblFormNome.Text = btnDesafio.Text;

        }
        
        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
