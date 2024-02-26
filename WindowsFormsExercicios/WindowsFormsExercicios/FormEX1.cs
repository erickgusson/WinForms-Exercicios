using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsExercicios
{
    public partial class formEX1 : Form
    {
        public formEX1()
        {
            InitializeComponent();
        }

        int timer = 2000;

        public string PastaDosArquivos
        {

            get
            {
                string pastaDoAplicativo = Application.StartupPath;
                string pastaDoArquivo = pastaDoAplicativo + "/arquivos/ex1/";
                return pastaDoArquivo;
            }

        }

        string caminhoPasta = "";
        string caminhoArquivo = "";

        private void CarregarNotas()
        {

            cbxArquivos.Items.Clear();

            DirectoryInfo dir = new DirectoryInfo(caminhoPasta);
            FileInfo[] arquivos = dir.GetFiles("*.*");
            foreach (FileInfo fi in arquivos)
            {
                cbxArquivos.Items.Add(fi.Name);
            }

        }

        private void formEX1_Load(object sender, EventArgs e)
        {

            timer1.Interval = timer;
            timer1.Enabled = true;

            caminhoPasta = PastaDosArquivos;


            CarregarNotas();

        }

        private void btnSalvarNota_Click(object sender, EventArgs e)
        {

            string nomeDoArquivo = txbNomeArquivo.Text + ".txt";
            caminhoArquivo = caminhoPasta + nomeDoArquivo;

            if (!File.Exists(caminhoArquivo))
            {

                using (StreamWriter sw = File.CreateText(caminhoArquivo))
                {

                    sw.WriteLine(txbConteudo.Text);

                }

                lblAlert.Text = "";

                MessageBox.Show("Nota criada com sucesso!");

            }

            else
            {
                lblAlert.Text = "*Arquivo já existe";
            }

            CarregarNotas();

        }

        private void btnRecarregar_Click(object sender, EventArgs e)
        {

            CarregarNotas();

        }

        private void cbxArquivos_SelectedIndexChanged(object sender, EventArgs e)
        {

            string nomeDoArquivo = cbxArquivos.Text;
            caminhoArquivo = caminhoPasta + nomeDoArquivo;

            using (StreamReader sr = new StreamReader(caminhoArquivo)) 
            {

                txbConteudoNota.Text = sr.ReadToEnd();

            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            lblAlert.Text = "";

            CarregarNotas();


        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {

            string arquivoAtualizar = cbxArquivos.Text;
            caminhoArquivo = caminhoPasta + arquivoAtualizar;

            if (File.Exists(caminhoArquivo))
            {

                using (StreamWriter sw = File.CreateText(caminhoArquivo))
                {

                    sw.WriteLine(txbConteudoNota.Text);

                }

                MessageBox.Show("Nota atualiza com sucesso!");

            }

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

            string arquivoAtualizar = cbxArquivos.Text;
            string caminhoArquivo = caminhoPasta + arquivoAtualizar;

            if (File.Exists(caminhoArquivo))
            {

                File.Delete(caminhoArquivo);

                MessageBox.Show("Nota excluida com sucesso!");

            }

            CarregarNotas();
            cbxArquivos.SelectedIndex = 0;


        }
    }
}
