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
    public partial class FormEX7 : Form
    {
        public FormEX7()
        {
            InitializeComponent();
        }

        int quantidadeQuestao = 4;
        int questaoAtual = 1;
        int acertos = 0;
        int erros = 0;
        string correta = "";
        int tempo = 0;

        private void FormEX7_Load(object sender, EventArgs e)
        {

            MessageBox.Show("Tem certeza que deseja começar este desafio?", "Está preparado", MessageBoxButtons.OK, MessageBoxIcon.Question);

            timer1.Enabled = true;
            timer1.Interval = 1000;

            gerarQuestoes();

        }

        private void gerarQuestoes()
        {

            switch(questaoAtual)
            {

                case 1:

                    lblPergunta.Text = "O que é SQL?";
                    btnOpcao1.Text = "Structured Query Language";
                    btnOpcao2.Text = "Secure Question Link";
                    btnOpcao3.Text = "Software Query Logic";
                    btnOpcao4.Text = "System Quality Level";

                    correta = btnOpcao1.Text;

                    break;

                case 2:

                    lblPergunta.Text = "Qual é o tipo de rede que conecta computadores localizados em uma mesma área física?";
                    btnOpcao1.Text = "WAN";
                    btnOpcao2.Text = "WLAN";
                    btnOpcao3.Text = "MAN";
                    btnOpcao4.Text = "LAN";

                    correta = btnOpcao4.Text;

                    break;

                case 3:

                    lblPergunta.Text = "Qual é o componente responsável por processar as instruções de um computador?";
                    btnOpcao1.Text = "GPU";
                    btnOpcao2.Text = "CPU";
                    btnOpcao3.Text = "RAM";
                    btnOpcao4.Text = "ROM";

                    correta = btnOpcao2.Text;

                    break;

                case 4:

                    lblPergunta.Text = "O que é o Visual Studio";
                    btnOpcao1.Text = "Editor de texto";
                    btnOpcao2.Text = "Linguagem de programação";
                    btnOpcao3.Text = "Um ambiente de desenvolvimento";
                    btnOpcao4.Text = "Banco de dados";

                    correta = btnOpcao3.Text;

                    break;

                default:

                    MessageBox.Show($"Parábens você completou o quiz, aqui estão os resultados: \n Acertos: {acertos} \n Erros: {erros} \n Tempo: {tempo} segundos");

                    MessageBox.Show("Gostaria de tentar de novo?", "Vai encarar" ,MessageBoxButtons.YesNo);

                    MessageBox.Show("Pois vai KKKK");

                    questaoAtual = 1;

                    gerarQuestoes();

                    break;

            }

        }

        private void escolha(string opcaoEscolhida)
        {

            if (opcaoEscolhida == correta)
            {

                acertos++;

                MessageBox.Show("Resposta correta");

            }

            else
            {

                erros++;

                MessageBox.Show("Resposta errada");

            }

            questaoAtual++;

        }

        private void btnOpcao1_Click(object sender, EventArgs e)
        {

            escolha(btnOpcao1.Text);

            gerarQuestoes();

        }

        private void btnOpcao2_Click(object sender, EventArgs e)
        {

            escolha(btnOpcao2.Text);

            gerarQuestoes();

        }

        private void btnOpcao3_Click(object sender, EventArgs e)
        {

            escolha(btnOpcao3.Text);

            gerarQuestoes();

        }

        private void btnOpcao4_Click(object sender, EventArgs e)
        {

            escolha(btnOpcao4.Text);

            gerarQuestoes();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            tempo++;

        }
    }
}
