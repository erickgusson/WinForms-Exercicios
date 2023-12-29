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

        int timer = 1000;

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

        private void formEX1_Load(object sender, EventArgs e)
        {

            timer1.Interval = timer;
            timer1.Enabled = true;

            caminhoPasta = PastaDosArquivos;


            DirectoryInfo dir = new DirectoryInfo(caminhoPasta);
            FileInfo[] arquivos = dir.GetFiles("*.*");
            foreach (FileInfo fi in arquivos)
            {
                cbxArquivos.Items.Add(fi.Name);
            }

        }

        private void btnSalvarNota_Click(object sender, EventArgs e)
        {

            string nomeDoArquivo = txbNomeArquivo.Text;
            caminhoArquivo = caminhoPasta + nomeDoArquivo;

            if (!File.Exists(caminhoArquivo))
            {

                using (var sw = File.CreateText(caminhoArquivo))
                {

                    sw.WriteLine(txbConteudo.Text);

                }

                lblAlert.Text = "";

            }

            else
            {
                lblAlert.Text = "*Arquivo já existe";
            }


        }

        private void btnRecarregar_Click(object sender, EventArgs e)
        {

            lblAlert.Text = "";

            cbxArquivos.Items.Clear();

            DirectoryInfo dir = new DirectoryInfo(caminhoPasta);
            FileInfo[] arquivos = dir.GetFiles("*.*");
            foreach (FileInfo fi in arquivos)
            {
                cbxArquivos.Items.Add(fi.Name);
            }

        }

        private void cbxArquivos_SelectedIndexChanged(object sender, EventArgs e)
        {

            string nomeDoArquivo = cbxArquivos.Text;
            caminhoArquivo = caminhoPasta + nomeDoArquivo;

            using (StreamReader sr = new StreamReader(caminhoArquivo)) 
            {

                lblConteudoNotas.Text = sr.ReadToEnd();

            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {


            cbxArquivos.Items.Clear();

            DirectoryInfo dir = new DirectoryInfo(caminhoPasta);
            FileInfo[] arquivos = dir.GetFiles("*.*");
            foreach (FileInfo fi in arquivos)
            {
                cbxArquivos.Items.Add(fi.Name);
            }


        }
    }
}
