
namespace MapaSala.Formularios.Cadastros
{
    partial class CadastroDisciplina
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
            this.txtNomeDisciplina = new System.Windows.Forms.TextBox();
            this.txtSigla = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.chkCadastro = new System.Windows.Forms.CheckBox();
            this.btnSalvarCadastro = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNomeDisciplina
            // 
            this.txtNomeDisciplina.Location = new System.Drawing.Point(34, 106);
            this.txtNomeDisciplina.Name = "txtNomeDisciplina";
            this.txtNomeDisciplina.Size = new System.Drawing.Size(100, 20);
            this.txtNomeDisciplina.TabIndex = 0;
            // 
            // txtSigla
            // 
            this.txtSigla.Location = new System.Drawing.Point(34, 164);
            this.txtSigla.Name = "txtSigla";
            this.txtSigla.Size = new System.Drawing.Size(100, 20);
            this.txtSigla.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nome Disciplina";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Sigla";
            // 
            // chkCadastro
            // 
            this.chkCadastro.AutoSize = true;
            this.chkCadastro.Location = new System.Drawing.Point(34, 206);
            this.chkCadastro.Name = "chkCadastro";
            this.chkCadastro.Size = new System.Drawing.Size(50, 17);
            this.chkCadastro.TabIndex = 4;
            this.chkCadastro.Text = "Ativo";
            this.chkCadastro.UseVisualStyleBackColor = true;
            // 
            // btnSalvarCadastro
            // 
            this.btnSalvarCadastro.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnSalvarCadastro.Location = new System.Drawing.Point(34, 253);
            this.btnSalvarCadastro.Name = "btnSalvarCadastro";
            this.btnSalvarCadastro.Size = new System.Drawing.Size(75, 23);
            this.btnSalvarCadastro.TabIndex = 5;
            this.btnSalvarCadastro.Text = "Salvar";
            this.btnSalvarCadastro.UseVisualStyleBackColor = false;
            this.btnSalvarCadastro.Click += new System.EventHandler(this.btnSalvarCadastro_Click);
            // 
            // CadastroDisciplina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(195, 450);
            this.Controls.Add(this.btnSalvarCadastro);
            this.Controls.Add(this.chkCadastro);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSigla);
            this.Controls.Add(this.txtNomeDisciplina);
            this.Name = "CadastroDisciplina";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCadastroDisciplina";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNomeDisciplina;
        private System.Windows.Forms.TextBox txtSigla;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkCadastro;
        private System.Windows.Forms.Button btnSalvarCadastro;
    }
}