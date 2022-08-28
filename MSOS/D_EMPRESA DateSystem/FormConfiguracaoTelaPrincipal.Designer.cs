namespace DateSystem
{
    partial class FormConfiguracaoTelaPrincipal
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
            this.buttonVerifica = new System.Windows.Forms.Button();
            this.buttonCancelarTelaSalvar = new System.Windows.Forms.Button();
            this.buttonFecharTela = new System.Windows.Forms.Button();
            this.PainelOs = new System.Windows.Forms.Panel();
            this.checkBoxVerificadorOs = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PainelOs.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonVerifica
            // 
            this.buttonVerifica.Enabled = false;
            this.buttonVerifica.Location = new System.Drawing.Point(383, 35);
            this.buttonVerifica.Name = "buttonVerifica";
            this.buttonVerifica.Size = new System.Drawing.Size(26, 26);
            this.buttonVerifica.TabIndex = 102;
            this.buttonVerifica.Text = "S";
            this.buttonVerifica.UseVisualStyleBackColor = true;
            this.buttonVerifica.Click += new System.EventHandler(this.buttonVerifica_Click);
            // 
            // buttonCancelarTelaSalvar
            // 
            this.buttonCancelarTelaSalvar.Location = new System.Drawing.Point(383, 67);
            this.buttonCancelarTelaSalvar.Name = "buttonCancelarTelaSalvar";
            this.buttonCancelarTelaSalvar.Size = new System.Drawing.Size(26, 26);
            this.buttonCancelarTelaSalvar.TabIndex = 101;
            this.buttonCancelarTelaSalvar.Text = "C";
            this.buttonCancelarTelaSalvar.UseVisualStyleBackColor = true;
            this.buttonCancelarTelaSalvar.Click += new System.EventHandler(this.buttonCancelarTelaSalvar_Click);
            // 
            // buttonFecharTela
            // 
            this.buttonFecharTela.Location = new System.Drawing.Point(383, 99);
            this.buttonFecharTela.Name = "buttonFecharTela";
            this.buttonFecharTela.Size = new System.Drawing.Size(26, 26);
            this.buttonFecharTela.TabIndex = 103;
            this.buttonFecharTela.Text = "F";
            this.buttonFecharTela.UseVisualStyleBackColor = true;
            this.buttonFecharTela.Click += new System.EventHandler(this.buttonFecharTela_Click);
            // 
            // PainelOs
            // 
            this.PainelOs.BackColor = System.Drawing.SystemColors.ControlLight;
            this.PainelOs.Controls.Add(this.checkBoxVerificadorOs);
            this.PainelOs.Controls.Add(this.label11);
            this.PainelOs.Enabled = false;
            this.PainelOs.Location = new System.Drawing.Point(12, 61);
            this.PainelOs.Name = "PainelOs";
            this.PainelOs.Size = new System.Drawing.Size(365, 37);
            this.PainelOs.TabIndex = 105;
            // 
            // checkBoxVerificadorOs
            // 
            this.checkBoxVerificadorOs.AutoSize = true;
            this.checkBoxVerificadorOs.Location = new System.Drawing.Point(202, 4);
            this.checkBoxVerificadorOs.Name = "checkBoxVerificadorOs";
            this.checkBoxVerificadorOs.Size = new System.Drawing.Size(95, 17);
            this.checkBoxVerificadorOs.TabIndex = 1;
            this.checkBoxVerificadorOs.Text = "Verificardor Os";
            this.checkBoxVerificadorOs.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 4);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(196, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Contador de Os Abertos e em Processo:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 106;
            this.label1.Text = "- DateSystem Os - ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(407, 13);
            this.label2.TabIndex = 107;
            this.label2.Text = "Aviso – Qualquer acesso e alteração a está Tela só terá efeito ao reiniciar o sis" +
    "tema. ";
            // 
            // FormConfiguracaoTelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 139);
            this.ControlBox = false;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PainelOs);
            this.Controls.Add(this.buttonVerifica);
            this.Controls.Add(this.buttonCancelarTelaSalvar);
            this.Controls.Add(this.buttonFecharTela);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormConfiguracaoTelaPrincipal";
            this.Text = "Configuração Tela Principal - Os campos em \" *\" são  obrigatórios!";
            this.Load += new System.EventHandler(this.FormConfiguracaoTelaPrincipal_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FormConfiguracaoTelaPrincipal_KeyPress);
            this.PainelOs.ResumeLayout(false);
            this.PainelOs.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonVerifica;
        private System.Windows.Forms.Button buttonCancelarTelaSalvar;
        private System.Windows.Forms.Button buttonFecharTela;
        private System.Windows.Forms.Panel PainelOs;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox checkBoxVerificadorOs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}