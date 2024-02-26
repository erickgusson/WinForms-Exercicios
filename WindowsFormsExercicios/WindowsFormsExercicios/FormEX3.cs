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
    public partial class FormEX3 : Form
    {
        public FormEX3()
        {
            InitializeComponent();
        }

        public string PastaDosArquivos
        {

            get
            {
                string pastaDoAplicativo = Application.StartupPath;
                string pastaDoArquivo = pastaDoAplicativo + "/arquivos/ex3/";
                return pastaDoArquivo;
            }

        }

        string caminhoArquivo = "";

        private void FormEX3_Load(object sender, EventArgs e)
        {

            lbxContatos.Items.Clear();
            caminhoArquivo = PastaDosArquivos + "contatos.txt";

            string texto = LerArquivo(caminhoArquivo);

            Array lista = texto.Split('\n');

            foreach (string contato in lista)
            {

                string[] dados = contato.Split('|');


                lbxContatos.Items.Add(dados[0]);

            }


        }

        string LerArquivo(string endereco)
        {
            string conteudo = "";
            if (File.Exists(endereco))
            {

                using (StreamReader sr = new StreamReader(endereco))
                {

                    conteudo = sr.ReadToEnd();

                }

            }

            return conteudo;

        }

        private void btnSalvarContato_Click(object sender, EventArgs e)
        {

            string nome = "" + txbNome.Text;
            string tipo = "" + "Pessoal";
            if (rbEmpresarial.Checked) { tipo = "Empresarial"; }
            string numero = "" + mtbNumero.Text;
            string separador = "|";

            string novoContato = nome + separador + tipo + separador + numero;

            string textoAntigo = LerArquivo(caminhoArquivo);

            using (StreamWriter sw = new StreamWriter(caminhoArquivo))
            {

                sw.WriteLine(textoAntigo + novoContato);

            }

            lbxContatos.Items.Clear();

            string texto = LerArquivo(caminhoArquivo);

            Array lista = texto.Split('\n');

            foreach (string contato in lista)
            {

                string[] dados = contato.Split('|');


                lbxContatos.Items.Add(dados[0]);

            }

        }

        private void lbxContatos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbxContatos.SelectedIndex < lbxContatos.Items.Count)
            {


                string texto = LerArquivo(caminhoArquivo);

                int selecionado = lbxContatos.SelectedIndex;
                int contador = 0;

                Array lista = texto.Split('\n');

                foreach (string pessoa in lista)
                {

                    string[] dados = pessoa.Split('|');

                    if (contador == selecionado)
                    {
                        lblNome.Text = dados[0];
                        lblTipo.Text = dados[1];
                        lblNumero.Text = dados[2];
                    }

                    contador++;

                }
            }
        }



        private void txbProcurar_TextChanged(object sender, EventArgs e)
        {

            lbxContatos.Items.Clear();

            string texto = LerArquivo(caminhoArquivo);

            Array lista = texto.Split('\n');

            foreach (string pessoa in lista)
            {

                string[] dados = pessoa.Split('|');

                if (dados[0].ToUpper().Contains(txbProcurar.Text.ToUpper()))
                {

                    lbxContatos.Items.Add(dados[0]);

                }

                else if (txbProcurar.Text == "")
                {

                    lbxContatos.Items.Add(dados[0]);

                }


            }

        }
    }
}
