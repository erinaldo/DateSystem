namespace DateSystem
{
    partial class FormCadastraRegistroSub
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
            this.buttonLimpaRegistro = new System.Windows.Forms.Button();
            this.buttonFecharRegistro = new System.Windows.Forms.Button();
            this.buttonVerifica = new System.Windows.Forms.Button();
            this.panelDadosCliente = new System.Windows.Forms.Panel();
            this.buttonAtualizarContatos = new System.Windows.Forms.Button();
            this.buttonAdicionarContato = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNumeroCadastroCliente = new System.Windows.Forms.TextBox();
            this.NumeroCadastro = new System.Windows.Forms.Label();
            this.comboBoxContato = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtNomeRegistro = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panelSolicitacaoCriado = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDataSolicitacaoProcesso = new System.Windows.Forms.DateTimePicker();
            this.txtNumeroRegistro = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNumeroSubRegistro = new System.Windows.Forms.TextBox();
            this.nomeCliente = new System.Windows.Forms.Label();
            this.buttonCancelarRegistro1 = new System.Windows.Forms.Button();
            this.panelDocumentoRegistro = new System.Windows.Forms.Panel();
            this.checkBoxSituacao = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtOrigemRegistro = new System.Windows.Forms.TextBox();
            this.txtDataContatoRegistro = new System.Windows.Forms.DateTimePicker();
            this.buttonCadastraRegistro = new System.Windows.Forms.Button();
            this.errorProviderCadastraRegistroSub = new System.Windows.Forms.ErrorProvider(this.components);
            this.NomeLogado = new System.Windows.Forms.Label();
            this.timerRegistroSubNovo = new System.Windows.Forms.Timer(this.components);
            this.panelDadosCliente.SuspendLayout();
            this.panelSolicitacaoCriado.SuspendLayout();
            this.panelDocumentoRegistro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderCadastraRegistroSub)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonLimpaRegistro
            // 
            this.buttonLimpaRegistro.Enabled = false;
            this.buttonLimpaRegistro.Location = new System.Drawing.Point(864, 164);
            this.buttonLimpaRegistro.Name = "buttonLimpaRegistro";
            this.buttonLimpaRegistro.Size = new System.Drawing.Size(26, 26);
            this.buttonLimpaRegistro.TabIndex = 173;
            this.buttonLimpaRegistro.Text = "L";
            this.buttonLimpaRegistro.UseVisualStyleBackColor = true;
            this.buttonLimpaRegistro.Click += new System.EventHandler(this.buttonLimpaRegistro_Click);
            // 
            // buttonFecharRegistro
            // 
            this.buttonFecharRegistro.Location = new System.Drawing.Point(862, 196);
            this.buttonFecharRegistro.Name = "buttonFecharRegistro";
            this.buttonFecharRegistro.Size = new System.Drawing.Size(26, 26);
            this.buttonFecharRegistro.TabIndex = 175;
            this.buttonFecharRegistro.Text = "F";
            this.buttonFecharRegistro.UseVisualStyleBackColor = true;
            this.buttonFecharRegistro.Click += new System.EventHandler(this.buttonFecharRegistro_Click);
            // 
            // buttonVerifica
            // 
            this.buttonVerifica.Enabled = false;
            this.buttonVerifica.Location = new System.Drawing.Point(864, 132);
            this.buttonVerifica.Name = "buttonVerifica";
            this.buttonVerifica.Size = new System.Drawing.Size(26, 26);
            this.buttonVerifica.TabIndex = 172;
            this.buttonVerifica.Text = "S";
            this.buttonVerifica.UseVisualStyleBackColor = true;
            this.buttonVerifica.Click += new System.EventHandler(this.buttonVerifica_Click);
            // 
            // panelDadosCliente
            // 
            this.panelDadosCliente.Controls.Add(this.buttonAtualizarContatos);
            this.panelDadosCliente.Controls.Add(this.buttonAdicionarContato);
            this.panelDadosCliente.Controls.Add(this.label8);
            this.panelDadosCliente.Controls.Add(this.label2);
            this.panelDadosCliente.Controls.Add(this.txtNumeroCadastroCliente);
            this.panelDadosCliente.Controls.Add(this.NumeroCadastro);
            this.panelDadosCliente.Controls.Add(this.comboBoxContato);
            this.panelDadosCliente.Controls.Add(this.label11);
            this.panelDadosCliente.Controls.Add(this.txtNomeRegistro);
            this.panelDadosCliente.Controls.Add(this.label7);
            this.panelDadosCliente.Enabled = false;
            this.panelDadosCliente.Location = new System.Drawing.Point(12, 133);
            this.panelDadosCliente.Name = "panelDadosCliente";
            this.panelDadosCliente.Size = new System.Drawing.Size(846, 95);
            this.panelDadosCliente.TabIndex = 171;
            // 
            // buttonAtualizarContatos
            // 
            this.buttonAtualizarContatos.Enabled = false;
            this.buttonAtualizarContatos.Location = new System.Drawing.Point(289, 35);
            this.buttonAtualizarContatos.Name = "buttonAtualizarContatos";
            this.buttonAtualizarContatos.Size = new System.Drawing.Size(59, 23);
            this.buttonAtualizarContatos.TabIndex = 126;
            this.buttonAtualizarContatos.Text = "Atualizar";
            this.buttonAtualizarContatos.UseVisualStyleBackColor = true;
            this.buttonAtualizarContatos.Visible = false;
            this.buttonAtualizarContatos.Click += new System.EventHandler(this.buttonAtualizarContatos_Click);
            // 
            // buttonAdicionarContato
            // 
            this.buttonAdicionarContato.Enabled = false;
            this.buttonAdicionarContato.Location = new System.Drawing.Point(209, 36);
            this.buttonAdicionarContato.Name = "buttonAdicionarContato";
            this.buttonAdicionarContato.Size = new System.Drawing.Size(74, 23);
            this.buttonAdicionarContato.TabIndex = 125;
            this.buttonAdicionarContato.Text = "Add Contato";
            this.buttonAdicionarContato.UseVisualStyleBackColor = true;
            this.buttonAdicionarContato.Visible = false;
            this.buttonAdicionarContato.Click += new System.EventHandler(this.buttonAdicionarContato_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(94, 71);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 16);
            this.label8.TabIndex = 70;
            this.label8.Text = "*********";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 69;
            this.label2.Text = "ABREVIAÇÃO:*";
            // 
            // txtNumeroCadastroCliente
            // 
            this.txtNumeroCadastroCliente.Enabled = false;
            this.txtNumeroCadastroCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroCadastroCliente.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txtNumeroCadastroCliente.Location = new System.Drawing.Point(620, 6);
            this.txtNumeroCadastroCliente.Name = "txtNumeroCadastroCliente";
            this.txtNumeroCadastroCliente.Size = new System.Drawing.Size(81, 21);
            this.txtNumeroCadastroCliente.TabIndex = 67;
            // 
            // NumeroCadastro
            // 
            this.NumeroCadastro.AutoSize = true;
            this.NumeroCadastro.Location = new System.Drawing.Point(552, 12);
            this.NumeroCadastro.Name = "NumeroCadastro";
            this.NumeroCadastro.Size = new System.Drawing.Size(62, 13);
            this.NumeroCadastro.TabIndex = 68;
            this.NumeroCadastro.Text = "NÚMERO:*";
            // 
            // comboBoxContato
            // 
            this.comboBoxContato.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxContato.FormattingEnabled = true;
            this.comboBoxContato.ItemHeight = 13;
            this.comboBoxContato.Location = new System.Drawing.Point(82, 37);
            this.comboBoxContato.Name = "comboBoxContato";
            this.comboBoxContato.Size = new System.Drawing.Size(121, 21);
            this.comboBoxContato.TabIndex = 1;
            this.comboBoxContato.SelectedIndexChanged += new System.EventHandler(this.comboBoxContato_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 41);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 13);
            this.label11.TabIndex = 66;
            this.label11.Text = "CONTATO:*";
            // 
            // txtNomeRegistro
            // 
            this.txtNomeRegistro.Enabled = false;
            this.txtNomeRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeRegistro.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txtNomeRegistro.Location = new System.Drawing.Point(79, 9);
            this.txtNomeRegistro.Name = "txtNomeRegistro";
            this.txtNomeRegistro.Size = new System.Drawing.Size(467, 21);
            this.txtNomeRegistro.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 44;
            this.label7.Text = "CLIENTE:";
            // 
            // panelSolicitacaoCriado
            // 
            this.panelSolicitacaoCriado.Controls.Add(this.label1);
            this.panelSolicitacaoCriado.Controls.Add(this.txtDataSolicitacaoProcesso);
            this.panelSolicitacaoCriado.Controls.Add(this.txtNumeroRegistro);
            this.panelSolicitacaoCriado.Controls.Add(this.label3);
            this.panelSolicitacaoCriado.Controls.Add(this.label5);
            this.panelSolicitacaoCriado.Controls.Add(this.txtNumeroSubRegistro);
            this.panelSolicitacaoCriado.Controls.Add(this.nomeCliente);
            this.panelSolicitacaoCriado.Location = new System.Drawing.Point(331, 2);
            this.panelSolicitacaoCriado.Name = "panelSolicitacaoCriado";
            this.panelSolicitacaoCriado.Size = new System.Drawing.Size(227, 126);
            this.panelSolicitacaoCriado.TabIndex = 170;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 178;
            this.label1.Text = "REGISTRO:";
            // 
            // txtDataSolicitacaoProcesso
            // 
            this.txtDataSolicitacaoProcesso.CustomFormat = "dd/MM/yyyy";
            this.txtDataSolicitacaoProcesso.Enabled = false;
            this.txtDataSolicitacaoProcesso.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtDataSolicitacaoProcesso.Location = new System.Drawing.Point(107, 82);
            this.txtDataSolicitacaoProcesso.Name = "txtDataSolicitacaoProcesso";
            this.txtDataSolicitacaoProcesso.RightToLeftLayout = true;
            this.txtDataSolicitacaoProcesso.ShowCheckBox = true;
            this.txtDataSolicitacaoProcesso.Size = new System.Drawing.Size(103, 20);
            this.txtDataSolicitacaoProcesso.TabIndex = 47;
            this.txtDataSolicitacaoProcesso.Value = new System.DateTime(2017, 7, 10, 0, 0, 0, 0);
            // 
            // txtNumeroRegistro
            // 
            this.txtNumeroRegistro.Enabled = false;
            this.txtNumeroRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroRegistro.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txtNumeroRegistro.Location = new System.Drawing.Point(119, 29);
            this.txtNumeroRegistro.Name = "txtNumeroRegistro";
            this.txtNumeroRegistro.Size = new System.Drawing.Size(77, 21);
            this.txtNumeroRegistro.TabIndex = 177;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "SUB REGISTRO";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 48;
            this.label5.Text = "CRIADO";
            // 
            // txtNumeroSubRegistro
            // 
            this.txtNumeroSubRegistro.Enabled = false;
            this.txtNumeroSubRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroSubRegistro.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txtNumeroSubRegistro.Location = new System.Drawing.Point(119, 56);
            this.txtNumeroSubRegistro.Name = "txtNumeroSubRegistro";
            this.txtNumeroSubRegistro.Size = new System.Drawing.Size(77, 21);
            this.txtNumeroSubRegistro.TabIndex = 23;
            // 
            // nomeCliente
            // 
            this.nomeCliente.AutoSize = true;
            this.nomeCliente.Location = new System.Drawing.Point(26, 6);
            this.nomeCliente.Name = "nomeCliente";
            this.nomeCliente.Size = new System.Drawing.Size(151, 13);
            this.nomeCliente.TabIndex = 49;
            this.nomeCliente.Text = "GRUPO MASTER SECURITY";
            // 
            // buttonCancelarRegistro1
            // 
            this.buttonCancelarRegistro1.Enabled = false;
            this.buttonCancelarRegistro1.Location = new System.Drawing.Point(784, 512);
            this.buttonCancelarRegistro1.Name = "buttonCancelarRegistro1";
            this.buttonCancelarRegistro1.Size = new System.Drawing.Size(106, 23);
            this.buttonCancelarRegistro1.TabIndex = 169;
            this.buttonCancelarRegistro1.Text = "Cancelar Registro";
            this.buttonCancelarRegistro1.UseVisualStyleBackColor = true;
            this.buttonCancelarRegistro1.Visible = false;
            this.buttonCancelarRegistro1.Click += new System.EventHandler(this.buttonCancelarRegistro1_Click);
            // 
            // panelDocumentoRegistro
            // 
            this.panelDocumentoRegistro.Controls.Add(this.checkBoxSituacao);
            this.panelDocumentoRegistro.Controls.Add(this.label6);
            this.panelDocumentoRegistro.Controls.Add(this.label4);
            this.panelDocumentoRegistro.Controls.Add(this.txtOrigemRegistro);
            this.panelDocumentoRegistro.Controls.Add(this.txtDataContatoRegistro);
            this.panelDocumentoRegistro.Enabled = false;
            this.panelDocumentoRegistro.Location = new System.Drawing.Point(12, 233);
            this.panelDocumentoRegistro.Name = "panelDocumentoRegistro";
            this.panelDocumentoRegistro.Size = new System.Drawing.Size(846, 273);
            this.panelDocumentoRegistro.TabIndex = 168;
            // 
            // checkBoxSituacao
            // 
            this.checkBoxSituacao.AutoSize = true;
            this.checkBoxSituacao.Enabled = false;
            this.checkBoxSituacao.Location = new System.Drawing.Point(9, 247);
            this.checkBoxSituacao.Name = "checkBoxSituacao";
            this.checkBoxSituacao.Size = new System.Drawing.Size(50, 17);
            this.checkBoxSituacao.TabIndex = 47;
            this.checkBoxSituacao.Text = "Ativo";
            this.checkBoxSituacao.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(345, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(178, 13);
            this.label6.TabIndex = 46;
            this.label6.Text = "DOCUMENTAÇÃO DE REGISTRO:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "DIA DO CONTATO DO CLIENTE";
            // 
            // txtOrigemRegistro
            // 
            this.txtOrigemRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOrigemRegistro.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txtOrigemRegistro.Location = new System.Drawing.Point(9, 25);
            this.txtOrigemRegistro.Multiline = true;
            this.txtOrigemRegistro.Name = "txtOrigemRegistro";
            this.txtOrigemRegistro.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtOrigemRegistro.Size = new System.Drawing.Size(818, 152);
            this.txtOrigemRegistro.TabIndex = 6;
            this.txtOrigemRegistro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtOrigemRegistro_KeyPress);
            // 
            // txtDataContatoRegistro
            // 
            this.txtDataContatoRegistro.Location = new System.Drawing.Point(9, 216);
            this.txtDataContatoRegistro.Name = "txtDataContatoRegistro";
            this.txtDataContatoRegistro.Size = new System.Drawing.Size(200, 20);
            this.txtDataContatoRegistro.TabIndex = 2;
            // 
            // buttonCadastraRegistro
            // 
            this.buttonCadastraRegistro.Enabled = false;
            this.buttonCadastraRegistro.Location = new System.Drawing.Point(12, 512);
            this.buttonCadastraRegistro.Name = "buttonCadastraRegistro";
            this.buttonCadastraRegistro.Size = new System.Drawing.Size(106, 23);
            this.buttonCadastraRegistro.TabIndex = 167;
            this.buttonCadastraRegistro.Text = "Cadrastra Registro";
            this.buttonCadastraRegistro.UseVisualStyleBackColor = true;
            this.buttonCadastraRegistro.Click += new System.EventHandler(this.buttonCadastraRegistro_Click);
            // 
            // errorProviderCadastraRegistroSub
            // 
            this.errorProviderCadastraRegistroSub.ContainerControl = this;
            // 
            // NomeLogado
            // 
            this.NomeLogado.AutoSize = true;
            this.NomeLogado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NomeLogado.Location = new System.Drawing.Point(12, 115);
            this.NomeLogado.Name = "NomeLogado";
            this.NomeLogado.Size = new System.Drawing.Size(89, 15);
            this.NomeLogado.TabIndex = 176;
            this.NomeLogado.Text = "Nome Logado:";
            // 
            // timerRegistroSubNovo
            // 
            this.timerRegistroSubNovo.Tick += new System.EventHandler(this.timerRegistroSubNovo_Tick);
            // 
            // FormCadastraRegistroSub
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 542);
            this.ControlBox = false;
            this.Controls.Add(this.NomeLogado);
            this.Controls.Add(this.buttonLimpaRegistro);
            this.Controls.Add(this.buttonFecharRegistro);
            this.Controls.Add(this.buttonVerifica);
            this.Controls.Add(this.panelDadosCliente);
            this.Controls.Add(this.panelSolicitacaoCriado);
            this.Controls.Add(this.buttonCancelarRegistro1);
            this.Controls.Add(this.panelDocumentoRegistro);
            this.Controls.Add(this.buttonCadastraRegistro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCadastraRegistroSub";
            this.Text = "4 - Cadastra Registro Novo Sub - Os campos em \" *\" são  obrigatórios!";
            this.Load += new System.EventHandler(this.FormCadastraRegistroSub_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FormCadastraRegistroSub_KeyPress);
            this.panelDadosCliente.ResumeLayout(false);
            this.panelDadosCliente.PerformLayout();
            this.panelSolicitacaoCriado.ResumeLayout(false);
            this.panelSolicitacaoCriado.PerformLayout();
            this.panelDocumentoRegistro.ResumeLayout(false);
            this.panelDocumentoRegistro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderCadastraRegistroSub)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonLimpaRegistro;
        private System.Windows.Forms.Button buttonFecharRegistro;
        private System.Windows.Forms.Button buttonVerifica;
        private System.Windows.Forms.Panel panelDadosCliente;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNumeroCadastroCliente;
        private System.Windows.Forms.Label NumeroCadastro;
        private System.Windows.Forms.ComboBox comboBoxContato;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtNomeRegistro;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panelSolicitacaoCriado;
        private System.Windows.Forms.DateTimePicker txtDataSolicitacaoProcesso;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNumeroSubRegistro;
        private System.Windows.Forms.Label nomeCliente;
        private System.Windows.Forms.Button buttonCancelarRegistro1;
        private System.Windows.Forms.Panel panelDocumentoRegistro;
        private System.Windows.Forms.CheckBox checkBoxSituacao;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtOrigemRegistro;
        private System.Windows.Forms.DateTimePicker txtDataContatoRegistro;
        private System.Windows.Forms.Button buttonCadastraRegistro;
        private System.Windows.Forms.ErrorProvider errorProviderCadastraRegistroSub;
        private System.Windows.Forms.Label NomeLogado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNumeroRegistro;
        private System.Windows.Forms.Timer timerRegistroSubNovo;
        private System.Windows.Forms.Button buttonAtualizarContatos;
        private System.Windows.Forms.Button buttonAdicionarContato;
    }
}