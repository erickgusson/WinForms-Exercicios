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
        int questaoAtual = 0;
        int acertos = 0;

        private void FormEX7_Load(object sender, EventArgs e)
        {
            int erros = quantidadeQuestao - acertos;
            MessageBox.Show("Tem certeza que deseja começar este desafio?", "Está preparado", MessageBoxButtons.OK, MessageBoxIcon.Question);

            
            

        }
    }
}
