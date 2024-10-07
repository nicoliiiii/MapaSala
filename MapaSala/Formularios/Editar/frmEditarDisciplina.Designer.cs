
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
            this.txtEditarDisciplina = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txtEditar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.chkEditarDis = new System.Windows.Forms.CheckBox();
            this.btnSalvarEdit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtEditarDisciplina
            // 
            this.txtEditarDisciplina.Location = new System.Drawing.Point(45, 61);
            this.txtEditarDisciplina.Name = "txtEditarDisciplina";
            this.txtEditarDisciplina.Size = new System.Drawing.Size(173, 20);
            this.txtEditarDisciplina.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txtEditar
            // 
            this.txtEditar.Location = new System.Drawing.Point(45, 136);
            this.txtEditar.Name = "txtEditar";
            this.txtEditar.Size = new System.Drawing.Size(173, 20);
            this.txtEditar.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nome da Disciplina";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Sigla";
            // 
            // chkEditarDis
            // 
            this.chkEditarDis.AutoSize = true;
            this.chkEditarDis.Location = new System.Drawing.Point(45, 201);
            this.chkEditarDis.Name = "chkEditarDis";
            this.chkEditarDis.Size = new System.Drawing.Size(50, 17);
            this.chkEditarDis.TabIndex = 5;
            this.chkEditarDis.Text = "Ativo";
            this.chkEditarDis.UseVisualStyleBackColor = true;
            // 
            // btnSalvarEdit
            // 
            this.btnSalvarEdit.Location = new System.Drawing.Point(45, 254);
            this.btnSalvarEdit.Name = "btnSalvarEdit";
            this.btnSalvarEdit.Size = new System.Drawing.Size(75, 23);
            this.btnSalvarEdit.TabIndex = 6;
            this.btnSalvarEdit.Text = "salvar";
            this.btnSalvarEdit.UseVisualStyleBackColor = true;
            // 
            // frmEditarDisciplina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 450);
            this.Controls.Add(this.btnSalvarEdit);
            this.Controls.Add(this.chkEditarDis);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEditar);
            this.Controls.Add(this.txtEditarDisciplina);
            this.Name = "frmEditarDisciplina";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmEditarDisciplina";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEditarDisciplina;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox txtEditar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkEditarDis;
        private System.Windows.Forms.Button btnSalvarEdit;
    }
}