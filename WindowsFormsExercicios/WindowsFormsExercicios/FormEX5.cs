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
    public partial class FormEX5 : Form
    {
        public FormEX5()
        {
            InitializeComponent();
        }

        public string PastaDosArquivos
        {

            get
            {
                string pastaDoAplicativo = Application.StartupPath;
                string pastaDoArquivo = pastaDoAplicativo + "/arquivos/ex5/";
                return pastaDoArquivo;
            }

        }

        string caminhoPasta = "";
        string caminhoArquivo = "";

        private void listarArquivos()
        {

            lbxNotas.Items.Clear();

            caminhoPasta = PastaDosArquivos;

            DirectoryInfo diretorio = new DirectoryInfo(caminhoPasta);
            FileInfo[] arquivos = diretorio.GetFiles("*");
            foreach (FileInfo fi in arquivos)
            {
                lbxNotas.Items.Add(fi.Name);
            }

        }

        private void FormEX5_Load(object sender, EventArgs e)
        {

            listarArquivos();

        }

        private void lbxNotas_SelectedIndexChanged(object sender, EventArgs e)
        {

            string arquivo = lbxNotas.SelectedItem.ToString();
            caminhoArquivo = caminhoPasta + arquivo;


            using (StreamReader sr = new StreamReader(caminhoArquivo))
            {

                txbNotaConteudo.Text = sr.ReadToEnd();

            }

        }
        

        private void btnCriar_Click(object sender, EventArgs e)
        {

            if (txbCriacaoNome.Text == "")
            {

                txbCriacaoNome.Text = "Arquivo";

            }

            int contador = 1;
            string arquivoCriacao = txbCriacaoNome.Text;
            caminhoArquivo = caminhoPasta + arquivoCriacao;


            if (!File.Exists(caminhoArquivo)) {

                using (StreamWriter sw = File.CreateText(caminhoArquivo))
                {

                    sw.WriteLine(txbCriacaoConteudo.Text);

                }

            }

            else
            {
                while (File.Exists(caminhoArquivo))
                {
                    string novoArquivo = caminhoArquivo + $" ({contador})";
                    if (!File.Exists(novoArquivo))
                    {

                        using (StreamWriter sw = File.CreateText(novoArquivo))
                        {

                            sw.WriteLine(txbCriacaoConteudo.Text);

                        }

                        break;

                    }

                    contador++;

                }

            }

            listarArquivos();

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

            string arquivoDeletar = lbxNotas.SelectedItem.ToString();
            caminhoArquivo = caminhoPasta + arquivoDeletar;

            if (File.Exists(caminhoArquivo))
            {

                File.Delete(caminhoArquivo);

            }

            listarArquivos();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {

            string arquivoAtualizar = lbxNotas.SelectedItem.ToString();
            caminhoArquivo = caminhoPasta + arquivoAtualizar;


            if (File.Exists(caminhoArquivo))
            {

                using (StreamWriter sw = File.CreateText(caminhoArquivo))
                {

                    sw.WriteLine(txbNotaConteudo.Text);

                }

            }

        }

       
    }
}
