
namespace MapaSala.Formularios.Editar
{
    partial class frmEditarDisciplina
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
            this.components = new System.ComponentModel.Container();
            this.txtNomeDisciplina = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txtSiglaDisciplina = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.chkEditarDis = new System.Windows.Forms.CheckBox();
            this.btnSalvarEdit = new System.Windows.Forms.Button();
            this.label_id = new System.Windows.Forms.Label();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNomeDisciplina
            // 
            this.txtNomeDisciplina.Location = new System.Drawing.Point(35, 120);
            this.txtNomeDisciplina.Name = "txtNomeDisciplina";
            this.txtNomeDisciplina.Size = new System.Drawing.Size(173, 20);
            this.txtNomeDisciplina.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txtSiglaDisciplina
            // 
            this.txtSiglaDisciplina.Location = new System.Drawing.Point(35, 185);
            this.txtSiglaDisciplina.Name = "txtSiglaDisciplina";
            this.txtSiglaDisciplina.Size = new System.Drawing.Size(173, 20);
            this.txtSiglaDisciplina.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nome da Disciplina";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Sigla";
            // 
            // chkEditarDis
            // 
            this.chkEditarDis.AutoSize = true;
            this.chkEditarDis.Location = new System.Drawing.Point(45, 238);
            this.chkEditarDis.Name = "chkEditarDis";
            this.chkEditarDis.Size = new System.Drawing.Size(50, 17);
            this.chkEditarDis.TabIndex = 5;
            this.chkEditarDis.Text = "Ativo";
            this.chkEditarDis.UseVisualStyleBackColor = true;
            // 
            // btnSalvarEdit
            // 
            this.btnSalvarEdit.Location = new System.Drawing.Point(20, 284);
            this.btnSalvarEdit.Name = "btnSalvarEdit";
            this.btnSalvarEdit.Size = new System.Drawing.Size(75, 23);
            this.btnSalvarEdit.TabIndex = 6;
            this.btnSalvarEdit.Text = "Salvar";
            this.btnSalvarEdit.UseVisualStyleBackColor = true;
            this.btnSalvarEdit.Click += new System.EventHandler(this.btnSalvarEdit_Click);
            // 
            // label_id
            // 
            this.label_id.AutoSize = true;
            this.label_id.Location = new System.Drawing.Point(35, 48);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(35, 13);
            this.label_id.TabIndex = 7;
            this.label_id.Text = "label3";
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(119, 284);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 8;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // frmEditarDisciplina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 450);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.label_id);
            this.Controls.Add(this.btnSalvarEdit);
            this.Controls.Add(this.chkEditarDis);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSiglaDisciplina);
            this.Controls.Add(this.txtNomeDisciplina);
            this.Name = "frmEditarDisciplina";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmEditarDisciplina";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNomeDisciplina;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox txtSiglaDisciplina;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkEditarDis;
        private System.Windows.Forms.Button btnSalvarEdit;
        private System.Windows.Forms.Label label_id;
        private System.Windows.Forms.Button btnExcluir;
    }
}