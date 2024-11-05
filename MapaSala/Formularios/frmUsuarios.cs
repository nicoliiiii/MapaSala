using MapaSala.Classes;
using MapaSala.Formularios.Cadastro;
using MapaSala.Formularios.Editar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MapaSala.Formularios
{
    public partial class frmUsuarios : Form
    {

        public frmUsuarios()
        {
            InitializeComponent();
            Usuarios u = new Usuarios();
            dtGridUsuarios.DataSource = u.PreencherGrid();

        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            frmCadastrarUsuario frm = new frmCadastrarUsuario();
            frm.FormClosed += FecharForm;
            frm.ShowDialog();
        }

        private void FecharForm(object sender, FormClosedEventArgs e)
        {
            Usuarios u = new Usuarios();
            dtGridUsuarios.DataSource = u.PreencherGrid();
        }

        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {
            Usuarios u = new Usuarios();
            dtGridUsuarios.DataSource = u.Pesquisar(txtPesquisar.Text);
        }

        private void dtgridUsuarios_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int id = Convert.ToInt32(
                    dtGridUsuarios.Rows[e.RowIndex].Cells[0].Value);

                frmEditarUsuarios editar = new frmEditarUsuarios(id);

                
                editar.FormClosed += FecharForm;
                editar.ShowDialog(); 
            }
        }
    }
}