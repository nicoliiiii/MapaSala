
namespace MapaSala.Formularios
{
    partial class frmDisciplina
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtGridDisciplina = new System.Windows.Forms.DataGridView();
            this.numId = new System.Windows.Forms.NumericUpDown();
            this.txtNomeDisciplina = new System.Windows.Forms.TextBox();
            this.chbAtivoDis = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.txtSiglaDisciplina = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_Novo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridDisciplina)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numId)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Location = new System.Drawing.Point(33, 112);
            this.txtPesquisar.Margin = new System.Windows.Forms.Padding(5);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(168, 23);
            this.txtPesquisar.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 90);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Pesquisar";
            // 
            // dtGridDisciplina
            // 
            this.dtGridDisciplina.AllowUserToAddRows = false;
            this.dtGridDisciplina.AllowUserToDeleteRows = false;
            this.dtGridDisciplina.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtGridDisciplina.BackgroundColor = System.Drawing.Color.Pink;
            this.dtGridDisciplina.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridDisciplina.Location = new System.Drawing.Point(16, 145);
            this.dtGridDisciplina.Margin = new System.Windows.Forms.Padding(5);
            this.dtGridDisciplina.Name = "dtGridDisciplina";
            this.dtGridDisciplina.ReadOnly = true;
            this.dtGridDisciplina.RowHeadersWidth = 51;
            this.dtGridDisciplina.Size = new System.Drawing.Size(742, 426);
            this.dtGridDisciplina.TabIndex = 7;
            this.dtGridDisciplina.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGridDisciplina_CellClick);
            this.dtGridDisciplina.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGridDisciplina_CellDoubleClick);
            // 
            // numId
            // 
            this.numId.Location = new System.Drawing.Point(16, 39);
            this.numId.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.numId.Name = "numId";
            this.numId.Size = new System.Drawing.Size(130, 23);
            this.numId.TabIndex = 12;
            // 
            // txtNomeDisciplina
            // 
            this.txtNomeDisciplina.Location = new System.Drawing.Point(172, 39);
            this.txtNomeDisciplina.Margin = new System.Windows.Forms.Padding(5);
            this.txtNomeDisciplina.Name = "txtNomeDisciplina";
            this.txtNomeDisciplina.Size = new System.Drawing.Size(168, 23);
            this.txtNomeDisciplina.TabIndex = 13;
            // 
            // chbAtivoDis
            // 
            this.chbAtivoDis.AutoSize = true;
            this.chbAtivoDis.Location = new System.Drawing.Point(462, 36);
            this.chbAtivoDis.Name = "chbAtivoDis";
            this.chbAtivoDis.Size = new System.Drawing.Size(58, 21);
            this.chbAtivoDis.TabIndex = 14;
            this.chbAtivoDis.Text = "Ativo";
            this.chbAtivoDis.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "Id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(169, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 17);
            this.label3.TabIndex = 16;
            this.label3.Text = "Nome Disciplina";
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnSalvar.Location = new System.Drawing.Point(530, 28);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(112, 34);
            this.btnSalvar.TabIndex = 18;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click_1);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnLimpar.Location = new System.Drawing.Point(656, 26);
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(112, 34);
            this.btnLimpar.TabIndex = 19;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click_1);
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnExcluir.Location = new System.Drawing.Point(530, 74);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(112, 34);
            this.btnExcluir.TabIndex = 20;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click_1);
            // 
            // txtSiglaDisciplina
            // 
            this.txtSiglaDisciplina.Location = new System.Drawing.Point(352, 39);
            this.txtSiglaDisciplina.Margin = new System.Windows.Forms.Padding(5);
            this.txtSiglaDisciplina.Name = "txtSiglaDisciplina";
            this.txtSiglaDisciplina.Size = new System.Drawing.Size(102, 23);
            this.txtSiglaDisciplina.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(349, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 17);
            this.label4.TabIndex = 22;
            this.label4.Text = "Sigla";
            // 
            // btn_Novo
            // 
            this.btn_Novo.BackColor = System.Drawing.Color.LavenderBlush;
            this.btn_Novo.Location = new System.Drawing.Point(656, 73);
            this.btn_Novo.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btn_Novo.Name = "btn_Novo";
            this.btn_Novo.Size = new System.Drawing.Size(112, 34);
            this.btn_Novo.TabIndex = 23;
            this.btn_Novo.Text = "Add Disciplina";
            this.btn_Novo.UseVisualStyleBackColor = false;
            this.btn_Novo.Click += new System.EventHandler(this.btn_Novo_Click);
            // 
            // frmDisciplina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 692);
            this.Controls.Add(this.btn_Novo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSiglaDisciplina);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chbAtivoDis);
            this.Controls.Add(this.txtNomeDisciplina);
            this.Controls.Add(this.numId);
            this.Controls.Add(this.dtGridDisciplina);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPesquisar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmDisciplina";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDisciplina";
            this.TransparencyKey = System.Drawing.Color.Black;
            ((System.ComponentModel.ISupportInitialize)(this.dtGridDisciplina)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numId)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtGridDisciplina;
        private System.Windows.Forms.NumericUpDown numId;
        private System.Windows.Forms.TextBox txtNomeDisciplina;
        private System.Windows.Forms.CheckBox chbAtivoDis;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.TextBox txtSiglaDisciplina;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_Novo;
    }
}