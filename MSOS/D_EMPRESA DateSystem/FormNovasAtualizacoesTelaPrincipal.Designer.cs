namespace DateSystem
{
    partial class FormNovasAtualizacoesTelaPrincipal
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
            this.checkBoxAtivo = new System.Windows.Forms.CheckBox();
            this.txtAtualizacaoTelaPrincipal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSalvarAlteracao = new System.Windows.Forms.Button();
            this.buttonFecharTela = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // checkBoxAtivo
            // 
            this.checkBoxAtivo.AutoSize = true;
            this.checkBoxAtivo.Location = new System.Drawing.Point(12, 396);
            this.checkBoxAtivo.Name = "checkBoxAtivo";
            this.checkBoxAtivo.Size = new System.Drawing.Size(282, 17);
            this.checkBoxAtivo.TabIndex = 0;
            this.checkBoxAtivo.Text = "Não mostra Novas Atualizações Realizado no Sistema";
            this.checkBoxAtivo.UseVisualStyleBackColor = true;
            this.checkBoxAtivo.CheckedChanged += new System.EventHandler(this.checkBoxAtivo_CheckedChanged);
            // 
            // txtAtualizacaoTelaPrincipal
            // 
            this.txtAtualizacaoTelaPrincipal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAtualizacaoTelaPrincipal.Enabled = false;
            this.txtAtualizacaoTelaPrincipal.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAtualizacaoTelaPrincipal.Location = new System.Drawing.Point(12, 12);
            this.txtAtualizacaoTelaPrincipal.Multiline = true;
            this.txtAtualizacaoTelaPrincipal.Name = "txtAtualizacaoTelaPrincipal";
            this.txtAtualizacaoTelaPrincipal.Size = new System.Drawing.Size(875, 378);
            this.txtAtualizacaoTelaPrincipal.TabIndex = 1;
            this.txtAtualizacaoTelaPrincipal.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAtualizacaoTelaPrincipal_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(767, 397);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "A versão consta na: 1.5";
            // 
            // buttonSalvarAlteracao
            // 
            this.buttonSalvarAlteracao.Location = new System.Drawing.Point(893, 12);
            this.buttonSalvarAlteracao.Name = "buttonSalvarAlteracao";
            this.buttonSalvarAlteracao.Size = new System.Drawing.Size(26, 26);
            this.buttonSalvarAlteracao.TabIndex = 32;
            this.buttonSalvarAlteracao.Text = "S";
            this.buttonSalvarAlteracao.UseVisualStyleBackColor = true;
            this.buttonSalvarAlteracao.Click += new System.EventHandler(this.buttonSalvarAlteracao_Click);
            // 
            // buttonFecharTela
            // 
            this.buttonFecharTela.Location = new System.Drawing.Point(893, 44);
            this.buttonFecharTela.Name = "buttonFecharTela";
            this.buttonFecharTela.Size = new System.Drawing.Size(26, 26);
            this.buttonFecharTela.TabIndex = 105;
            this.buttonFecharTela.Text = "F";
            this.buttonFecharTela.UseVisualStyleBackColor = true;
            this.buttonFecharTela.Click += new System.EventHandler(this.buttonFecharTela_Click);
            // 
            // FormNovasAtualizacoesTelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 425);
            this.ControlBox = false;
            this.Controls.Add(this.buttonFecharTela);
            this.Controls.Add(this.buttonSalvarAlteracao);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAtualizacaoTelaPrincipal);
            this.Controls.Add(this.checkBoxAtivo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormNovasAtualizacoesTelaPrincipal";
            this.Text = "Novas Atualizações Tela Principal";
            this.Load += new System.EventHandler(this.FormNovasAtualizacoesTelaPrincipal_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FormNovasAtualizacoesTelaPrincipal_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxAtivo;
        private System.Windows.Forms.TextBox txtAtualizacaoTelaPrincipal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSalvarAlteracao;
        private System.Windows.Forms.Button buttonFecharTela;
    }
}