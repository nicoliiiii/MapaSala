﻿﻿using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MapaSala.DAO;
using MapaSala.Formularios.Cadastros;
using MapaSala.Formularios.Editar;
using Model.Entitidades;

namespace MapaSala.Formularios
{
    public partial class frmDisciplina : Form
    {
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


      
        private void dtGridDisciplina_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                int id = Convert.ToInt32(dtGridDisciplina.Rows[e.RowIndex].Cells[0].Value);
                frmEditarDisciplina editar = new frmEditarDisciplina(id);
                editar.FormClosed += Fechou_Editar_FormClosed;
                editar.ShowDialog();
            }
            
        }

        private void Fechou_Editar_FormClosed(object sender, FormClosedEventArgs e)
        {
            dtGridDisciplina.DataSource = dao.ObterDisciplinas();
        }

       

        private void btnAddDis_Click(object sender, EventArgs e)
        {
            CadastroDisciplina d = new CadastroDisciplina();
            d.FormClosed += Fechou_Editar_FormClosed;
            d.ShowDialog();
        }
    }
}