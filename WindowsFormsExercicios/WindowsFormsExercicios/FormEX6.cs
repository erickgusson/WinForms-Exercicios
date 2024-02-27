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
    public partial class FormEX6 : Form
    {

        private List<Tarefa> listaTarefas;

        public FormEX6()
        {

            InitializeComponent();
            listaTarefas = new List<Tarefa>();
            ConfigurarDataGridView();

        }

        private void ConfigurarDataGridView()
        {

            dgvTarefas.ColumnCount = 3;
            dgvTarefas.Columns[0].Name = "Tarefa";
            dgvTarefas.Columns[1].Name = "Descrição";
            dgvTarefas.Columns[2].Name = "Vencimento";

            DataGridViewButtonColumn coluna = new DataGridViewButtonColumn();
            coluna.Name = "Ações";
            coluna.Text = "Deletar";
            coluna.UseColumnTextForButtonValue = true;
            dgvTarefas.Columns.Add(coluna);

            dgvTarefas.Columns["Tarefa"].Width = 140;
            dgvTarefas.Columns["Descrição"].Width = 150;
            dgvTarefas.Columns["Vencimento"].Width = 100;
            dgvTarefas.Columns["Ações"].Width = 50;

        }

        private void AdicionarTarefa(string titulo, string descricao, DateTime dataVencimento)
        {
            Tarefa tarefa = new Tarefa(titulo, descricao, dataVencimento);
            listaTarefas.Add(tarefa);

            AtualizarDataGridView();
            LimparCampos();
        }

        private void AtualizarDataGridView()
        {
            dgvTarefas.Rows.Clear();



            foreach (Tarefa tarefa in listaTarefas)
            {

                dgvTarefas.Rows.Add(tarefa.Titulo, tarefa.Descricao, tarefa.DataVencimento.ToString("dd/MM/yyyy"));

            }
        }

        private void dgvTarefas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex == dgvTarefas.Columns["Ações"].Index && e.RowIndex >= 0)
            {
                // Botão "Deletar" foi clicado
                DialogResult resultado = MessageBox.Show("Tem certeza que deseja deletar esta tarefa?", "Confirmar Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    listaTarefas.RemoveAt(e.RowIndex);
                    AtualizarDataGridView();
                }
            }

        }

        private void LimparCampos()
        {
            txbTarefa.Clear();
            txbDesc.Clear();
            dtpVencimento.Value = DateTime.Now;
        }

        private void buttonAdicionarTarefa_Click(object sender, EventArgs e)
        {
            string titulo = txbTarefa.Text;
            string descricao = txbDesc.Text;
            DateTime dataVencimento = dtpVencimento.Value;

            if (!string.IsNullOrWhiteSpace(titulo))
            {
                AdicionarTarefa(titulo, descricao, dataVencimento);
            }
            else
            {
                MessageBox.Show("Por favor, insira um título para a tarefa.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void btnLimpar_Click(object sender, EventArgs e)
        {

            LimparCampos();

        }


    }

    public class Tarefa
    {
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public DateTime DataVencimento { get; set; }

        public Tarefa(string titulo, string descricao, DateTime dataVencimento)
        {
            Titulo = titulo;
            Descricao = descricao;
            DataVencimento = dataVencimento;
        }
    }
}
