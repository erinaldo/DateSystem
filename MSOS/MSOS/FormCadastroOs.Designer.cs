﻿namespace MSOS
{
    partial class FormCadastroOsNovo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadastroOsNovo));
            this.nomeCliente = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtDataSolicitacao = new System.Windows.Forms.DateTimePicker();
            this.txtNumeroOrdemServico = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtservicoexecutados = new System.Windows.Forms.TextBox();
            this.pClientePessoaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ServicosExecutados = new System.Windows.Forms.Label();
            this.txtOrigemChamado = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.maskedTxtHorarioFInal = new System.Windows.Forms.MaskedTextBox();
            this.comboBoxFuncionario = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.maskedTxtHorarioInicio = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtVistoCliente = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonCadastraOs = new System.Windows.Forms.Button();
            this.buttonCancelarOs = new System.Windows.Forms.Button();
            this.buttonLimpaOs = new System.Windows.Forms.Button();
            this.buttonFecharOs = new System.Windows.Forms.Button();
            this.buttonVerifica = new System.Windows.Forms.Button();
            this.errorProviderOs = new System.Windows.Forms.ErrorProvider(this.components);
            this.buttonPesquisaCliente = new System.Windows.Forms.Button();
            this.txtPesquisaNomeCliente = new System.Windows.Forms.TextBox();
            this.radioButtonPesquisaNome = new System.Windows.Forms.RadioButton();
            this.radioButtonPequisaMS = new System.Windows.Forms.RadioButton();
            this.txtPesquisaMSCliente = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.radioButtonOculto = new System.Windows.Forms.RadioButton();
            this.txtTelefoneOs = new System.Windows.Forms.MaskedTextBox();
            this.TelefoneCliente = new System.Windows.Forms.Label();
            this.MsCliente = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.EnderecoCliente = new System.Windows.Forms.Label();
            this.txtBairroNumero = new System.Windows.Forms.TextBox();
            this.txtMsOs = new System.Windows.Forms.TextBox();
            this.txtEnderecoOS = new System.Windows.Forms.TextBox();
            this.txtBairroOS = new System.Windows.Forms.TextBox();
            this.txtTipo_logradouro = new System.Windows.Forms.TextBox();
            this.txtNomeOS = new System.Windows.Forms.TextBox();
            this.txtComplOs = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtCidadeOs = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.comboBoxContato = new System.Windows.Forms.ComboBox();
            this.buttonImprimirOS = new System.Windows.Forms.Button();
            this.printDocumentOs = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialogOs = new System.Windows.Forms.PrintPreviewDialog();
            this.Caixa_setup = new System.Windows.Forms.PrintDialog();
            this.buttonImprimir = new System.Windows.Forms.Button();
            this.buttonCadastraOsNovo = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pClientePessoaBindingSource)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderOs)).BeginInit();
            this.panel6.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // nomeCliente
            // 
            this.nomeCliente.AutoSize = true;
            this.nomeCliente.Location = new System.Drawing.Point(119, 6);
            this.nomeCliente.Name = "nomeCliente";
            this.nomeCliente.Size = new System.Drawing.Size(151, 13);
            this.nomeCliente.TabIndex = 46;
            this.nomeCliente.Text = "GRUPO MASTER SECURITY";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtDataSolicitacao);
            this.panel1.Controls.Add(this.txtNumeroOrdemServico);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.nomeCliente);
            this.panel1.Enabled = false;
            this.panel1.Location = new System.Drawing.Point(260, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(397, 86);
            this.panel1.TabIndex = 58;
            // 
            // txtDataSolicitacao
            // 
            this.txtDataSolicitacao.CustomFormat = "dd/mm/yyyy";
            this.txtDataSolicitacao.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtDataSolicitacao.Location = new System.Drawing.Point(141, 51);
            this.txtDataSolicitacao.Name = "txtDataSolicitacao";
            this.txtDataSolicitacao.RightToLeftLayout = true;
            this.txtDataSolicitacao.ShowCheckBox = true;
            this.txtDataSolicitacao.Size = new System.Drawing.Size(78, 20);
            this.txtDataSolicitacao.TabIndex = 0;
            this.txtDataSolicitacao.Value = new System.DateTime(2017, 1, 10, 0, 0, 0, 0);
            // 
            // txtNumeroOrdemServico
            // 
            this.txtNumeroOrdemServico.Enabled = false;
            this.txtNumeroOrdemServico.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroOrdemServico.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txtNumeroOrdemServico.Location = new System.Drawing.Point(141, 24);
            this.txtNumeroOrdemServico.Name = "txtNumeroOrdemServico";
            this.txtNumeroOrdemServico.Size = new System.Drawing.Size(77, 21);
            this.txtNumeroOrdemServico.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 46;
            this.label2.Text = "SOLICITAÇÃO";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 13);
            this.label1.TabIndex = 46;
            this.label1.Text = "ORDEM DE SERVIÇO N";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtservicoexecutados);
            this.panel3.Controls.Add(this.ServicosExecutados);
            this.panel3.Controls.Add(this.txtOrigemChamado);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Enabled = false;
            this.panel3.Location = new System.Drawing.Point(12, 195);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(829, 195);
            this.panel3.TabIndex = 59;
            // 
            // txtservicoexecutados
            // 
            this.txtservicoexecutados.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pClientePessoaBindingSource, "OBSERVACAO", true));
            this.txtservicoexecutados.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtservicoexecutados.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txtservicoexecutados.Location = new System.Drawing.Point(4, 112);
            this.txtservicoexecutados.Multiline = true;
            this.txtservicoexecutados.Name = "txtservicoexecutados";
            this.txtservicoexecutados.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtservicoexecutados.Size = new System.Drawing.Size(820, 78);
            this.txtservicoexecutados.TabIndex = 3;
            // 
            // pClientePessoaBindingSource
            // 
            this.pClientePessoaBindingSource.DataSource = typeof(MSOS.P_ClientePessoa);
            // 
            // ServicosExecutados
            // 
            this.ServicosExecutados.AutoSize = true;
            this.ServicosExecutados.Location = new System.Drawing.Point(369, 98);
            this.ServicosExecutados.Name = "ServicosExecutados";
            this.ServicosExecutados.Size = new System.Drawing.Size(140, 13);
            this.ServicosExecutados.TabIndex = 47;
            this.ServicosExecutados.Text = "SERVIÇOS EXECUTADOS:";
            // 
            // txtOrigemChamado
            // 
            this.txtOrigemChamado.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pClientePessoaBindingSource, "OBSERVACAO", true));
            this.txtOrigemChamado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOrigemChamado.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txtOrigemChamado.Location = new System.Drawing.Point(6, 15);
            this.txtOrigemChamado.Multiline = true;
            this.txtOrigemChamado.Name = "txtOrigemChamado";
            this.txtOrigemChamado.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtOrigemChamado.Size = new System.Drawing.Size(818, 80);
            this.txtOrigemChamado.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(368, 2);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 13);
            this.label4.TabIndex = 45;
            this.label4.Text = "ORIGEM DO CHAMADO:";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.maskedTxtHorarioFInal);
            this.panel5.Controls.Add(this.comboBoxFuncionario);
            this.panel5.Controls.Add(this.label10);
            this.panel5.Controls.Add(this.maskedTxtHorarioInicio);
            this.panel5.Controls.Add(this.label9);
            this.panel5.Controls.Add(this.label8);
            this.panel5.Controls.Add(this.label7);
            this.panel5.Controls.Add(this.txtVistoCliente);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Enabled = false;
            this.panel5.Location = new System.Drawing.Point(12, 487);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(829, 97);
            this.panel5.TabIndex = 61;
            // 
            // maskedTxtHorarioFInal
            // 
            this.maskedTxtHorarioFInal.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pClientePessoaBindingSource, "TELEFONE2", true));
            this.maskedTxtHorarioFInal.Enabled = false;
            this.maskedTxtHorarioFInal.Location = new System.Drawing.Point(226, 69);
            this.maskedTxtHorarioFInal.Mask = "00:00";
            this.maskedTxtHorarioFInal.Name = "maskedTxtHorarioFInal";
            this.maskedTxtHorarioFInal.Size = new System.Drawing.Size(38, 20);
            this.maskedTxtHorarioFInal.TabIndex = 0;
            this.maskedTxtHorarioFInal.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.maskedTxtHorarioFInal.ValidatingType = typeof(System.DateTime);
            // 
            // comboBoxFuncionario
            // 
            this.comboBoxFuncionario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFuncionario.FormattingEnabled = true;
            this.comboBoxFuncionario.ItemHeight = 13;
            this.comboBoxFuncionario.Location = new System.Drawing.Point(118, 9);
            this.comboBoxFuncionario.Name = "comboBoxFuncionario";
            this.comboBoxFuncionario.Size = new System.Drawing.Size(180, 21);
            this.comboBoxFuncionario.TabIndex = 4;
            this.comboBoxFuncionario.SelectedIndexChanged += new System.EventHandler(this.comboBoxFuncionario_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(160, 72);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 13);
            this.label10.TabIndex = 49;
            this.label10.Text = "TERMINO:";
            // 
            // maskedTxtHorarioInicio
            // 
            this.maskedTxtHorarioInicio.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pClientePessoaBindingSource, "TELEFONE", true));
            this.maskedTxtHorarioInicio.Enabled = false;
            this.maskedTxtHorarioInicio.Location = new System.Drawing.Point(117, 69);
            this.maskedTxtHorarioInicio.Mask = "00:00";
            this.maskedTxtHorarioInicio.Name = "maskedTxtHorarioInicio";
            this.maskedTxtHorarioInicio.Size = new System.Drawing.Size(37, 20);
            this.maskedTxtHorarioInicio.TabIndex = 0;
            this.maskedTxtHorarioInicio.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.maskedTxtHorarioInicio.ValidatingType = typeof(System.DateTime);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(69, 72);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "INICIO:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 72);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "HORARIO:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 41);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "VISTO DO CLIENTE:";
            // 
            // txtVistoCliente
            // 
            this.txtVistoCliente.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pClientePessoaBindingSource, "NOME", true));
            this.txtVistoCliente.Enabled = false;
            this.txtVistoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVistoCliente.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txtVistoCliente.Location = new System.Drawing.Point(118, 36);
            this.txtVistoCliente.Name = "txtVistoCliente";
            this.txtVistoCliente.Size = new System.Drawing.Size(379, 21);
            this.txtVistoCliente.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "TECNICO:";
            // 
            // buttonCadastraOs
            // 
            this.buttonCadastraOs.Location = new System.Drawing.Point(27, 597);
            this.buttonCadastraOs.Name = "buttonCadastraOs";
            this.buttonCadastraOs.Size = new System.Drawing.Size(75, 23);
            this.buttonCadastraOs.TabIndex = 5;
            this.buttonCadastraOs.Text = "Cadastra";
            this.buttonCadastraOs.UseVisualStyleBackColor = true;
            this.buttonCadastraOs.Click += new System.EventHandler(this.buttonCadastraOs_Click);
            // 
            // buttonCancelarOs
            // 
            this.buttonCancelarOs.Location = new System.Drawing.Point(847, 165);
            this.buttonCancelarOs.Name = "buttonCancelarOs";
            this.buttonCancelarOs.Size = new System.Drawing.Size(26, 26);
            this.buttonCancelarOs.TabIndex = 8;
            this.buttonCancelarOs.Text = "C";
            this.buttonCancelarOs.UseVisualStyleBackColor = true;
            this.buttonCancelarOs.Click += new System.EventHandler(this.buttonCancelarCliente_Click);
            // 
            // buttonLimpaOs
            // 
            this.buttonLimpaOs.Location = new System.Drawing.Point(847, 133);
            this.buttonLimpaOs.Name = "buttonLimpaOs";
            this.buttonLimpaOs.Size = new System.Drawing.Size(26, 26);
            this.buttonLimpaOs.TabIndex = 7;
            this.buttonLimpaOs.Text = "L";
            this.buttonLimpaOs.UseVisualStyleBackColor = true;
            this.buttonLimpaOs.Click += new System.EventHandler(this.buttonLimpaCliente_Click);
            // 
            // buttonFecharOs
            // 
            this.buttonFecharOs.Location = new System.Drawing.Point(847, 197);
            this.buttonFecharOs.Name = "buttonFecharOs";
            this.buttonFecharOs.Size = new System.Drawing.Size(26, 26);
            this.buttonFecharOs.TabIndex = 9;
            this.buttonFecharOs.Text = "F";
            this.buttonFecharOs.UseVisualStyleBackColor = true;
            this.buttonFecharOs.Click += new System.EventHandler(this.buttonFecharCliente_Click);
            // 
            // buttonVerifica
            // 
            this.buttonVerifica.Enabled = false;
            this.buttonVerifica.Location = new System.Drawing.Point(847, 101);
            this.buttonVerifica.Name = "buttonVerifica";
            this.buttonVerifica.Size = new System.Drawing.Size(26, 26);
            this.buttonVerifica.TabIndex = 6;
            this.buttonVerifica.Text = "V";
            this.buttonVerifica.UseVisualStyleBackColor = true;
            this.buttonVerifica.Click += new System.EventHandler(this.buttonVerifica_Click);
            // 
            // errorProviderOs
            // 
            this.errorProviderOs.ContainerControl = this;
            // 
            // buttonPesquisaCliente
            // 
            this.buttonPesquisaCliente.Location = new System.Drawing.Point(163, 6);
            this.buttonPesquisaCliente.Name = "buttonPesquisaCliente";
            this.buttonPesquisaCliente.Size = new System.Drawing.Size(51, 23);
            this.buttonPesquisaCliente.TabIndex = 22;
            this.buttonPesquisaCliente.Text = "Busca";
            this.buttonPesquisaCliente.UseVisualStyleBackColor = true;
            this.buttonPesquisaCliente.Click += new System.EventHandler(this.buttonPesquisaCliente_Click);
            // 
            // txtPesquisaNomeCliente
            // 
            this.txtPesquisaNomeCliente.Enabled = false;
            this.txtPesquisaNomeCliente.Location = new System.Drawing.Point(70, 40);
            this.txtPesquisaNomeCliente.Name = "txtPesquisaNomeCliente";
            this.txtPesquisaNomeCliente.Size = new System.Drawing.Size(144, 20);
            this.txtPesquisaNomeCliente.TabIndex = 22;
            // 
            // radioButtonPesquisaNome
            // 
            this.radioButtonPesquisaNome.AutoSize = true;
            this.radioButtonPesquisaNome.Location = new System.Drawing.Point(4, 40);
            this.radioButtonPesquisaNome.Name = "radioButtonPesquisaNome";
            this.radioButtonPesquisaNome.Size = new System.Drawing.Size(60, 17);
            this.radioButtonPesquisaNome.TabIndex = 22;
            this.radioButtonPesquisaNome.TabStop = true;
            this.radioButtonPesquisaNome.Text = "NOME:";
            this.radioButtonPesquisaNome.UseVisualStyleBackColor = true;
            this.radioButtonPesquisaNome.CheckedChanged += new System.EventHandler(this.radioButtonPesquisaNome_CheckedChanged);
            // 
            // radioButtonPequisaMS
            // 
            this.radioButtonPequisaMS.AutoSize = true;
            this.radioButtonPequisaMS.Location = new System.Drawing.Point(4, 8);
            this.radioButtonPequisaMS.Name = "radioButtonPequisaMS";
            this.radioButtonPequisaMS.Size = new System.Drawing.Size(41, 17);
            this.radioButtonPequisaMS.TabIndex = 22;
            this.radioButtonPequisaMS.TabStop = true;
            this.radioButtonPequisaMS.Text = "MS";
            this.radioButtonPequisaMS.UseVisualStyleBackColor = true;
            this.radioButtonPequisaMS.CheckedChanged += new System.EventHandler(this.radioButtonPequisaMS_CheckedChanged);
            // 
            // txtPesquisaMSCliente
            // 
            this.txtPesquisaMSCliente.Enabled = false;
            this.txtPesquisaMSCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisaMSCliente.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txtPesquisaMSCliente.Location = new System.Drawing.Point(70, 8);
            this.txtPesquisaMSCliente.Name = "txtPesquisaMSCliente";
            this.txtPesquisaMSCliente.Size = new System.Drawing.Size(69, 21);
            this.txtPesquisaMSCliente.TabIndex = 22;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.radioButtonPequisaMS);
            this.panel6.Controls.Add(this.buttonPesquisaCliente);
            this.panel6.Controls.Add(this.txtPesquisaMSCliente);
            this.panel6.Controls.Add(this.txtPesquisaNomeCliente);
            this.panel6.Controls.Add(this.radioButtonPesquisaNome);
            this.panel6.Enabled = false;
            this.panel6.Location = new System.Drawing.Point(663, 1);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(227, 81);
            this.panel6.TabIndex = 75;
            // 
            // radioButtonOculto
            // 
            this.radioButtonOculto.AutoSize = true;
            this.radioButtonOculto.Checked = true;
            this.radioButtonOculto.Enabled = false;
            this.radioButtonOculto.Location = new System.Drawing.Point(847, 320);
            this.radioButtonOculto.Name = "radioButtonOculto";
            this.radioButtonOculto.Size = new System.Drawing.Size(41, 17);
            this.radioButtonOculto.TabIndex = 76;
            this.radioButtonOculto.TabStop = true;
            this.radioButtonOculto.Text = "MS";
            this.radioButtonOculto.UseVisualStyleBackColor = true;
            this.radioButtonOculto.Visible = false;
            // 
            // txtTelefoneOs
            // 
            this.txtTelefoneOs.Enabled = false;
            this.txtTelefoneOs.Location = new System.Drawing.Point(282, 69);
            this.txtTelefoneOs.Mask = "(99) 0000-0000";
            this.txtTelefoneOs.Name = "txtTelefoneOs";
            this.txtTelefoneOs.Size = new System.Drawing.Size(76, 20);
            this.txtTelefoneOs.TabIndex = 52;
            this.txtTelefoneOs.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // TelefoneCliente
            // 
            this.TelefoneCliente.AutoSize = true;
            this.TelefoneCliente.Location = new System.Drawing.Point(206, 73);
            this.TelefoneCliente.Name = "TelefoneCliente";
            this.TelefoneCliente.Size = new System.Drawing.Size(66, 13);
            this.TelefoneCliente.TabIndex = 38;
            this.TelefoneCliente.Text = "TELEFONE:";
            // 
            // MsCliente
            // 
            this.MsCliente.AutoSize = true;
            this.MsCliente.Location = new System.Drawing.Point(464, 14);
            this.MsCliente.Name = "MsCliente";
            this.MsCliente.Size = new System.Drawing.Size(30, 13);
            this.MsCliente.TabIndex = 43;
            this.MsCliente.Text = "MS:*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 44;
            this.label3.Text = "CLIENTE:";
            // 
            // EnderecoCliente
            // 
            this.EnderecoCliente.AutoSize = true;
            this.EnderecoCliente.Location = new System.Drawing.Point(3, 47);
            this.EnderecoCliente.Name = "EnderecoCliente";
            this.EnderecoCliente.Size = new System.Drawing.Size(74, 13);
            this.EnderecoCliente.TabIndex = 40;
            this.EnderecoCliente.Text = "ENDEREÇO:*";
            // 
            // txtBairroNumero
            // 
            this.txtBairroNumero.Enabled = false;
            this.txtBairroNumero.Location = new System.Drawing.Point(467, 40);
            this.txtBairroNumero.Name = "txtBairroNumero";
            this.txtBairroNumero.Size = new System.Drawing.Size(54, 20);
            this.txtBairroNumero.TabIndex = 22;
            // 
            // txtMsOs
            // 
            this.txtMsOs.Enabled = false;
            this.txtMsOs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMsOs.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txtMsOs.Location = new System.Drawing.Point(496, 12);
            this.txtMsOs.Name = "txtMsOs";
            this.txtMsOs.Size = new System.Drawing.Size(113, 21);
            this.txtMsOs.TabIndex = 22;
            // 
            // txtEnderecoOS
            // 
            this.txtEnderecoOS.Enabled = false;
            this.txtEnderecoOS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEnderecoOS.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txtEnderecoOS.Location = new System.Drawing.Point(185, 40);
            this.txtEnderecoOS.Name = "txtEnderecoOS";
            this.txtEnderecoOS.Size = new System.Drawing.Size(180, 21);
            this.txtEnderecoOS.TabIndex = 22;
            // 
            // txtBairroOS
            // 
            this.txtBairroOS.Enabled = false;
            this.txtBairroOS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBairroOS.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txtBairroOS.Location = new System.Drawing.Point(522, 40);
            this.txtBairroOS.Name = "txtBairroOS";
            this.txtBairroOS.Size = new System.Drawing.Size(87, 21);
            this.txtBairroOS.TabIndex = 22;
            // 
            // txtTipo_logradouro
            // 
            this.txtTipo_logradouro.Enabled = false;
            this.txtTipo_logradouro.Location = new System.Drawing.Point(79, 40);
            this.txtTipo_logradouro.Name = "txtTipo_logradouro";
            this.txtTipo_logradouro.Size = new System.Drawing.Size(105, 20);
            this.txtTipo_logradouro.TabIndex = 22;
            // 
            // txtNomeOS
            // 
            this.txtNomeOS.Enabled = false;
            this.txtNomeOS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeOS.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txtNomeOS.Location = new System.Drawing.Point(79, 9);
            this.txtNomeOS.Name = "txtNomeOS";
            this.txtNomeOS.Size = new System.Drawing.Size(379, 21);
            this.txtNomeOS.TabIndex = 22;
            // 
            // txtComplOs
            // 
            this.txtComplOs.Enabled = false;
            this.txtComplOs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComplOs.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txtComplOs.Location = new System.Drawing.Point(366, 40);
            this.txtComplOs.Name = "txtComplOs";
            this.txtComplOs.Size = new System.Drawing.Size(100, 21);
            this.txtComplOs.TabIndex = 22;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 73);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 13);
            this.label11.TabIndex = 66;
            this.label11.Text = "CONTATO:*";
            // 
            // txtCidadeOs
            // 
            this.txtCidadeOs.Enabled = false;
            this.txtCidadeOs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCidadeOs.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txtCidadeOs.Location = new System.Drawing.Point(610, 40);
            this.txtCidadeOs.Name = "txtCidadeOs";
            this.txtCidadeOs.Size = new System.Drawing.Size(87, 21);
            this.txtCidadeOs.TabIndex = 22;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.comboBoxContato);
            this.panel2.Controls.Add(this.txtCidadeOs);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.txtComplOs);
            this.panel2.Controls.Add(this.txtNomeOS);
            this.panel2.Controls.Add(this.txtTipo_logradouro);
            this.panel2.Controls.Add(this.txtBairroOS);
            this.panel2.Controls.Add(this.txtEnderecoOS);
            this.panel2.Controls.Add(this.txtMsOs);
            this.panel2.Controls.Add(this.txtBairroNumero);
            this.panel2.Controls.Add(this.EnderecoCliente);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.MsCliente);
            this.panel2.Controls.Add(this.TelefoneCliente);
            this.panel2.Controls.Add(this.txtTelefoneOs);
            this.panel2.Enabled = false;
            this.panel2.Location = new System.Drawing.Point(12, 92);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(829, 99);
            this.panel2.TabIndex = 0;
            // 
            // comboBoxContato
            // 
            this.comboBoxContato.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxContato.FormattingEnabled = true;
            this.comboBoxContato.ItemHeight = 13;
            this.comboBoxContato.Location = new System.Drawing.Point(79, 69);
            this.comboBoxContato.Name = "comboBoxContato";
            this.comboBoxContato.Size = new System.Drawing.Size(121, 21);
            this.comboBoxContato.TabIndex = 1;
            this.comboBoxContato.SelectedIndexChanged += new System.EventHandler(this.comboBoxContato_SelectedIndexChanged);
            // 
            // buttonImprimirOS
            // 
            this.buttonImprimirOS.Location = new System.Drawing.Point(41, 0);
            this.buttonImprimirOS.Name = "buttonImprimirOS";
            this.buttonImprimirOS.Size = new System.Drawing.Size(63, 23);
            this.buttonImprimirOS.TabIndex = 22;
            this.buttonImprimirOS.Text = "Visualizar";
            this.buttonImprimirOS.UseVisualStyleBackColor = true;
            this.buttonImprimirOS.Click += new System.EventHandler(this.buttonImprimirOS_Click);
            // 
            // printDocumentOs
            // 
            this.printDocumentOs.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocumentOs_PrintPage);
            // 
            // printPreviewDialogOs
            // 
            this.printPreviewDialogOs.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialogOs.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialogOs.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialogOs.Document = this.printDocumentOs;
            this.printPreviewDialogOs.Enabled = true;
            this.printPreviewDialogOs.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialogOs.Icon")));
            this.printPreviewDialogOs.Name = "printPreviewDialogOs";
            this.printPreviewDialogOs.Visible = false;
            this.printPreviewDialogOs.Load += new System.EventHandler(this.printPreviewDialogOs_Load);
            // 
            // Caixa_setup
            // 
            this.Caixa_setup.UseEXDialog = true;
            // 
            // buttonImprimir
            // 
            this.buttonImprimir.Enabled = false;
            this.buttonImprimir.Image = global::MSOS.Properties.Resources.imprimir0311;
            this.buttonImprimir.Location = new System.Drawing.Point(2, -2);
            this.buttonImprimir.Name = "buttonImprimir";
            this.buttonImprimir.Size = new System.Drawing.Size(33, 36);
            this.buttonImprimir.TabIndex = 22;
            this.buttonImprimir.Text = "I";
            this.buttonImprimir.UseVisualStyleBackColor = true;
            this.buttonImprimir.Click += new System.EventHandler(this.buttonImprimir_Click);
            // 
            // buttonCadastraOsNovo
            // 
            this.buttonCadastraOsNovo.Enabled = false;
            this.buttonCadastraOsNovo.Location = new System.Drawing.Point(108, 597);
            this.buttonCadastraOsNovo.Name = "buttonCadastraOsNovo";
            this.buttonCadastraOsNovo.Size = new System.Drawing.Size(88, 23);
            this.buttonCadastraOsNovo.TabIndex = 10;
            this.buttonCadastraOsNovo.Text = "Cadastra Novo";
            this.buttonCadastraOsNovo.UseVisualStyleBackColor = true;
            this.buttonCadastraOsNovo.Click += new System.EventHandler(this.buttonCadastraOsNovo_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(368, 4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 13);
            this.label5.TabIndex = 45;
            this.label5.Text = "MATERIAL UTILIZADO:";
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pClientePessoaBindingSource, "OBSERVACAO", true));
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.textBox1.Location = new System.Drawing.Point(6, 20);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox1.Size = new System.Drawing.Size(820, 52);
            this.textBox1.TabIndex = 22;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.textBox1);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Enabled = false;
            this.panel4.Location = new System.Drawing.Point(12, 396);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(829, 86);
            this.panel4.TabIndex = 60;
            // 
            // FormCadastroOsNovo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 627);
            this.Controls.Add(this.buttonCadastraOsNovo);
            this.Controls.Add(this.buttonImprimir);
            this.Controls.Add(this.buttonImprimirOS);
            this.Controls.Add(this.radioButtonOculto);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.buttonCancelarOs);
            this.Controls.Add(this.buttonLimpaOs);
            this.Controls.Add(this.buttonFecharOs);
            this.Controls.Add(this.buttonVerifica);
            this.Controls.Add(this.buttonCadastraOs);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "FormCadastroOsNovo";
            this.Text = "FormCadastroOs";
            this.Load += new System.EventHandler(this.FormCadastroOsNovo_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pClientePessoaBindingSource)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderOs)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label nomeCliente;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtNumeroOrdemServico;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtVistoCliente;
        private System.Windows.Forms.BindingSource pClientePessoaBindingSource;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonCadastraOs;
        private System.Windows.Forms.Button buttonCancelarOs;
        private System.Windows.Forms.Button buttonLimpaOs;
        private System.Windows.Forms.Button buttonFecharOs;
        private System.Windows.Forms.Button buttonVerifica;
        private System.Windows.Forms.ErrorProvider errorProviderOs;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.RadioButton radioButtonPequisaMS;
        private System.Windows.Forms.Button buttonPesquisaCliente;
        private System.Windows.Forms.TextBox txtPesquisaMSCliente;
        private System.Windows.Forms.TextBox txtPesquisaNomeCliente;
        private System.Windows.Forms.RadioButton radioButtonPesquisaNome;
        private System.Windows.Forms.RadioButton radioButtonOculto;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtCidadeOs;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtComplOs;
        private System.Windows.Forms.TextBox txtNomeOS;
        private System.Windows.Forms.TextBox txtTipo_logradouro;
        private System.Windows.Forms.TextBox txtBairroOS;
        private System.Windows.Forms.TextBox txtEnderecoOS;
        private System.Windows.Forms.TextBox txtMsOs;
        private System.Windows.Forms.TextBox txtBairroNumero;
        private System.Windows.Forms.Label EnderecoCliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label MsCliente;
        private System.Windows.Forms.Label TelefoneCliente;
        private System.Windows.Forms.MaskedTextBox txtTelefoneOs;
        private System.Windows.Forms.ComboBox comboBoxContato;
        private System.Windows.Forms.ComboBox comboBoxFuncionario;
        private System.Windows.Forms.TextBox txtOrigemChamado;
        private System.Windows.Forms.MaskedTextBox maskedTxtHorarioFInal;
        private System.Windows.Forms.MaskedTextBox maskedTxtHorarioInicio;
        private System.Windows.Forms.DateTimePicker txtDataSolicitacao;
        private System.Windows.Forms.Button buttonImprimirOS;
        private System.Drawing.Printing.PrintDocument printDocumentOs;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialogOs;
        private System.Windows.Forms.PrintDialog Caixa_setup;
        private System.Windows.Forms.Button buttonImprimir;
        private System.Windows.Forms.Button buttonCadastraOsNovo;
        private System.Windows.Forms.TextBox txtservicoexecutados;
        private System.Windows.Forms.Label ServicosExecutados;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
    }
}