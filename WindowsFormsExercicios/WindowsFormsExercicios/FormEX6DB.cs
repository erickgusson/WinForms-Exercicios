using MySql.Data.MySqlClient;
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
    public partial class FormEX6DB : Form
    {
        public FormEX6DB()
        {
            InitializeComponent();
        }

        private void FormEX6DB_Load(object sender, EventArgs e)
        {

            ConfigurarDataGridView();

            CarregarDados();

        }

        private void ConfigurarDataGridView()
        {

            dgvTarefas.ColumnCount = 4;
            dgvTarefas.Columns[0].Name = "ID";
            dgvTarefas.Columns[1].Name = "Tarefa";
            dgvTarefas.Columns[2].Name = "Descrição";
            dgvTarefas.Columns[3].Name = "Vencimento";

            DataGridViewButtonColumn coluna = new DataGridViewButtonColumn();
            coluna.Name = "Ações";
            coluna.Text = "Deletar";
            coluna.UseColumnTextForButtonValue = true;
            dgvTarefas.Columns.Add(coluna);

            dgvTarefas.Columns["ID"].Width = 25;
            dgvTarefas.Columns["Tarefa"].Width = 115;
            dgvTarefas.Columns["Descrição"].Width = 150;
            dgvTarefas.Columns["Vencimento"].Width = 70;
            dgvTarefas.Columns["Ações"].Width = 50;

        }

        private void LimparCampos()
        {

            txbTarefa.Text = string.Empty;
            txbDesc.Text = string.Empty;

        }

        private void CarregarDados()
        {

            dgvTarefas.Rows.Clear();

            string conexaoString = "server=62.72.62.1;user=u687609827_alunos;database=u687609827_TI21;port=3306;password=@Aluno12345";

            using (MySqlConnection conexao = new MySqlConnection(conexaoString))
            {

                string scriptSQL = "SELECT * FROM tb_erick_gerenciador";

                using (MySqlCommand comando = new MySqlCommand(scriptSQL, conexao))
                {

                    conexao.Open();

                    using (MySqlDataReader leitor = comando.ExecuteReader())
                    {
                        while (leitor.Read())
                        {

                            int id = leitor.GetInt32(0);
                            string tarefa = leitor.GetString(1);
                            string descricao = leitor.GetString(2);
                            string vencimento = leitor.GetString(3);

                            //MessageBox.Show($"{id}\n{tarefa}\n{descricao}\n{vencimento}");

                            dgvTarefas.Rows.Add(id, tarefa, descricao, vencimento);


                        }
                    }

                    conexao.Close();

                }

            }

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {

            LimparCampos();

        }

        private void btnAdicionarTarefa_Click(object sender, EventArgs e)
        {

            string conexaoString = "server=62.72.62.1;user=u687609827_alunos;database=u687609827_TI21;port=3306;password=@Aluno12345";

            string tarefa = txbTarefa.Text;
            string desc = txbDesc.Text;
            string venc = dtpVencimento.Text;

            try
            {
                using (MySqlConnection conexao = new MySqlConnection(conexaoString))
                {

                    string scriptSQL = $"INSERT INTO tb_erick_gerenciador (tarefa, descricao, vencimento) VALUES ('{tarefa}','{desc}','{venc}')";

                    using (MySqlCommand comando = new MySqlCommand(scriptSQL, conexao))
                    {

                        conexao.Open();

                        int linhasAfetadas = comando.ExecuteNonQuery();

                        if (linhasAfetadas > 0)
                        {

                            MessageBox.Show("Tarefa cadastrar com suesso");

                        }

                    }

                    conexao.Close();

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar informação: " + ex.Message);
            }

            CarregarDados();

        }

        private void dgvTarefas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex == dgvTarefas.Columns["Ações"].Index && e.RowIndex >= 0)
            {

                DialogResult confirmacao = MessageBox.Show("Tem certeza que deseja deletar esta tarefa?", "Confirmar Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirmacao == DialogResult.Yes)
                {

                    string conexaoString = "server=62.72.62.1;user=u687609827_alunos;database=u687609827_TI21;port=3306;password=@Aluno12345";


                    string idRemovido = dgvTarefas.Rows[e.RowIndex].Cells[0].Value.ToString();

                    try
                    {
                        using (MySqlConnection conexao = new MySqlConnection(conexaoString))
                        {

                            string scriptSQL = $"DELETE FROM tb_erick_gerenciador WHERE id = ({idRemovido})";

                            using (MySqlCommand comando = new MySqlCommand(scriptSQL, conexao))
                            {

                                conexao.Open();


                                int linhasAfetadas = comando.ExecuteNonQuery();

                                if (linhasAfetadas > 0)
                                {

                                    MessageBox.Show("Tarefa removida com suesso");

                                }

                            }

                            conexao.Close();

                            CarregarDados();

                        }

                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show("Erro ao Deletar informação: " + ex.Message);

                    }

                }

            }

        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {



            DialogResult confirmacao = MessageBox.Show("Tem certeza que deseja Atualizar esta tarefa?", "Confirmar Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmacao == DialogResult.Yes)
            {

                string conexaoString = "server=62.72.62.1;user=u687609827_alunos;database=u687609827_TI21;port=3306;password=@Aluno12345";

                for (int i = 0; i < dgvTarefas.Rows.Count; i++)
                {

                    string idOriginal = dgvTarefas.Rows[i].Cells[0].Value.ToString();

                    string novaTarefa = dgvTarefas.Rows[i].Cells[1].Value.ToString();
                    string novaDesc = dgvTarefas.Rows[i].Cells[2].Value.ToString();
                    string novoVencimento = dgvTarefas.Rows[i].Cells[3].Value.ToString();

                    //MessageBox.Show($"{idOriginal}\n{novaTarefa}\n{novaDesc}\n{novoVencimento} ");

                    try
                    {
                        using (MySqlConnection conexao = new MySqlConnection(conexaoString))
                        {

                            string scriptSQL = $"UPDATE tb_erick_gerenciador SET Tarefa = ('{novaTarefa}') WHERE id = ({idOriginal});" +
                                $"UPDATE tb_erick_gerenciador SET descricao = ('{novaDesc}') WHERE id = ({idOriginal});" +
                                $"UPDATE tb_erick_gerenciador SET vencimento = ('{novoVencimento}') WHERE id = ({idOriginal}); ";

                            using (MySqlCommand comando = new MySqlCommand(scriptSQL, conexao))
                            {

                                conexao.Open();


                                int linhasAfetadas = comando.ExecuteNonQuery();

                                if (linhasAfetadas > 0)
                                {

                                    MessageBox.Show("Tarefa alterada com suesso");

                                }

                            }

                            conexao.Close();


                        }

                    }

                    catch (Exception ex)
                    {

                        MessageBox.Show("Erro ao Atualizar informação: " + ex.Message);

                    }

                }

                CarregarDados();

            }

        }

    }

}
