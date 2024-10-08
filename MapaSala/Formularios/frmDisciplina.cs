using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MapaSala.DAO;
using MapaSala.Formularios.Editar;
using Model.Entitidades;

namespace MapaSala.Formularios
{
    public partial class frmDisciplina : Form
    {
        private string LinhaConexao = "Server=LS05MPF;Database=AULA_DS;User Id=sa;Password=admsasql;";
        private SqlConnection Conexao;
        DataTable dados;
        DisciplinaDAO dao = new DisciplinaDAO();

        int LinhaSelecionada;

        public frmDisciplina()
        {
            InitializeComponent();
            dados = new DataTable();

            foreach (var atributos in typeof(DisciplinaEntidade).GetProperties())
            {
                dados.Columns.Add(atributos.Name);
            }


            dtGridDisciplina.DataSource = dao.ObterDisciplinas();

        }

       

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void LimparCampos()
        {
            numId.Value = 0;
            txtNomeDisciplina.Text = "";
            txtPesquisar.Text = "";
            chbAtivoDis.Checked = false;
        }

        private void dtGridDisciplina_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            LinhaSelecionada = e.RowIndex;
            txtNomeDisciplina.Text = dtGridDisciplina.Rows[LinhaSelecionada].Cells[1].Value.ToString();
            txtPesquisar.Text = dtGridDisciplina.Rows[LinhaSelecionada].Cells[2].Value.ToString();
            numId.Value = Convert.ToInt32(dtGridDisciplina.Rows[LinhaSelecionada].Cells[0].Value);

        }

      

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btneditar(object sender, EventArgs e)
        {
            DataGridViewRow editar = dtGridDisciplina.Rows[LinhaSelecionada];
            editar.Cells[0].Value = numId.Value;
            editar.Cells[1].Value = txtNomeDisciplina.Text;
            editar.Cells[2].Value = chbAtivoDis.Checked;
            editar.Cells[3].Value = txtPesquisar.Text;


        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            dtGridDisciplina.DataSource = dao.Pesquisar(txtPesquisar.Text);

        }

        private void dtGridDisciplina_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int id = Convert.ToInt32(
                    dtGridDisciplina.Rows[e.RowIndex].Cells[0].Value);

                frmEditarDisciplina editar = new frmEditarDisciplina(id);

                editar.FormClosed += Fechou_Editar_FormClosed;

                editar.ShowDialog();
            }
        }
        private void Fechou_Editar_FormClosed(object sender, FormClosedEventArgs e)
        {

            dtGridDisciplina.DataSource = dao.ObterDisciplinas();
        }

        private void btnSalvar_Click_1(object sender, EventArgs e)
        {
            DisciplinaEntidade d = new DisciplinaEntidade();
            d.Id = Convert.ToInt32(numId.Value);
            d.Nome = txtNomeDisciplina.Text;
            d.Ativo = chbAtivoDis.Checked;
            d.Sigla = txtPesquisar.Text;

            dao.Inserir(d);
            dtGridDisciplina.DataSource = dao.ObterDisciplinas();
            LimparCampos();
        }

        private void btnLimpar_Click_1(object sender, EventArgs e)
        {
            numId.Value = 0;
            txtNomeDisciplina.Text = "";
            txtPesquisar.Text = "";
            chbAtivoDis.Checked = false;
        }

        private void btnExcluir_Click_1(object sender, EventArgs e)
        {
            dtGridDisciplina.Rows.RemoveAt(LinhaSelecionada);
            LimparCampos();
        }

        private void btn_Novo_Click(object sender, EventArgs e)
        {
            string query = "insert into Disciplinas set Nome = @nome, Sigla = @sigla, Ativo = @ativo WHERE  Id = @id";

            Conexao = new SqlConnection(LinhaConexao);
            Conexao.Open();

            SqlCommand comando = new SqlCommand(query, Conexao);

            comando.Parameters.Add(new SqlParameter("@sigla", txtSiglaDisciplina.Text));
            comando.Parameters.Add(new SqlParameter("@nome", txtNomeDisciplina.Text));
            comando.Parameters.Add(new SqlParameter("@ativo", chbAtivoDis.Checked));

            int resposta = comando.ExecuteNonQuery();

            if (resposta == 1)
            {
                MessageBox.Show("Disciplina cadastrada com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Erro ao cadastrar", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}

    


