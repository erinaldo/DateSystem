namespace DateSystem
{
    partial class FormOSPesquisa
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.radioButtonOculto = new System.Windows.Forms.RadioButton();
            this.buttonCancelarOs = new System.Windows.Forms.Button();
            this.buttonFecharOs = new System.Windows.Forms.Button();
            this.panelEstado = new System.Windows.Forms.Panel();
            this.checkBoxOs = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBoxTodos = new System.Windows.Forms.CheckBox();
            this.checkBoxEstadoF = new System.Windows.Forms.CheckBox();
            this.checkBoxEstadoP = new System.Windows.Forms.CheckBox();
            this.checkBoxEstadoA = new System.Windows.Forms.CheckBox();
            this.txtDataSolicitacao2 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDataSolicitacao = new System.Windows.Forms.DateTimePicker();
            this.radioButtonPesquisaData = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.radioButtonPequisaMS = new System.Windows.Forms.RadioButton();
            this.buttonPesquisaCliente = new System.Windows.Forms.Button();
            this.txtPesquisaMSOs = new System.Windows.Forms.TextBox();
            this.txtPesquisaNomeOs = new System.Windows.Forms.TextBox();
            this.radioButtonPesquisaNome = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButtonTodosClientes = new System.Windows.Forms.RadioButton();
            this.dataGridViewPesquisa = new System.Windows.Forms.DataGridView();
            this.ORDEM_SERVIÇO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOME_CLIENTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SERVICO_EXECUTADO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_PESSOA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_CONTATO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_CLIENTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_PESSSOA_LOGADA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_PESSSOA_LOGADA_ALTERADA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.txtOrdemServico = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panelEstado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPesquisa)).BeginInit();
            this.SuspendLayout();
            // 
            // radioButtonOculto
            // 
            this.radioButtonOculto.AutoSize = true;
            this.radioButtonOculto.Checked = true;
            this.radioButtonOculto.Enabled = false;
            this.radioButtonOculto.Location = new System.Drawing.Point(994, 345);
            this.radioButtonOculto.Name = "radioButtonOculto";
            this.radioButtonOculto.Size = new System.Drawing.Size(41, 17);
            this.radioButtonOculto.TabIndex = 115;
            this.radioButtonOculto.TabStop = true;
            this.radioButtonOculto.Text = "MS";
            this.radioButtonOculto.UseVisualStyleBackColor = true;
            this.radioButtonOculto.Visible = false;
            // 
            // buttonCancelarOs
            // 
            this.buttonCancelarOs.Location = new System.Drawing.Point(995, 63);
            this.buttonCancelarOs.Name = "buttonCancelarOs";
            this.buttonCancelarOs.Size = new System.Drawing.Size(26, 26);
            this.buttonCancelarOs.TabIndex = 114;
            this.buttonCancelarOs.Text = "C";
            this.buttonCancelarOs.UseVisualStyleBackColor = true;
            this.buttonCancelarOs.Click += new System.EventHandler(this.buttonCancelarOs_Click);
            // 
            // buttonFecharOs
            // 
            this.buttonFecharOs.Location = new System.Drawing.Point(995, 95);
            this.buttonFecharOs.Name = "buttonFecharOs";
            this.buttonFecharOs.Size = new System.Drawing.Size(26, 26);
            this.buttonFecharOs.TabIndex = 112;
            this.buttonFecharOs.Text = "F";
            this.buttonFecharOs.UseVisualStyleBackColor = true;
            this.buttonFecharOs.Click += new System.EventHandler(this.buttonFecharOs_Click);
            // 
            // panelEstado
            // 
            this.panelEstado.Controls.Add(this.checkBoxOs);
            this.panelEstado.Controls.Add(this.label5);
            this.panelEstado.Controls.Add(this.label4);
            this.panelEstado.Controls.Add(this.checkBoxTodos);
            this.panelEstado.Controls.Add(this.checkBoxEstadoF);
            this.panelEstado.Controls.Add(this.checkBoxEstadoP);
            this.panelEstado.Controls.Add(this.checkBoxEstadoA);
            this.panelEstado.Enabled = false;
            this.panelEstado.Location = new System.Drawing.Point(15, 30);
            this.panelEstado.Name = "panelEstado";
            this.panelEstado.Size = new System.Drawing.Size(593, 27);
            this.panelEstado.TabIndex = 108;
            // 
            // checkBoxOs
            // 
            this.checkBoxOs.AutoSize = true;
            this.checkBoxOs.Enabled = false;
            this.checkBoxOs.Location = new System.Drawing.Point(474, 4);
            this.checkBoxOs.Name = "checkBoxOs";
            this.checkBoxOs.Size = new System.Drawing.Size(116, 17);
            this.checkBoxOs.TabIndex = 120;
            this.checkBoxOs.Text = "ORDEM SERVIÇO";
            this.checkBoxOs.UseVisualStyleBackColor = true;
            this.checkBoxOs.CheckedChanged += new System.EventHandler(this.checkBoxOs_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(142, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 119;
            this.label5.Text = "ESCOLHA B:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 118;
            this.label4.Text = "ESCOLHA A:";
            // 
            // checkBoxTodos
            // 
            this.checkBoxTodos.AutoSize = true;
            this.checkBoxTodos.Location = new System.Drawing.Point(75, 4);
            this.checkBoxTodos.Name = "checkBoxTodos";
            this.checkBoxTodos.Size = new System.Drawing.Size(64, 17);
            this.checkBoxTodos.TabIndex = 117;
            this.checkBoxTodos.Text = "TODOS";
            this.checkBoxTodos.UseVisualStyleBackColor = true;
            // 
            // checkBoxEstadoF
            // 
            this.checkBoxEstadoF.AutoSize = true;
            this.checkBoxEstadoF.Location = new System.Drawing.Point(379, 3);
            this.checkBoxEstadoF.Name = "checkBoxEstadoF";
            this.checkBoxEstadoF.Size = new System.Drawing.Size(89, 17);
            this.checkBoxEstadoF.TabIndex = 86;
            this.checkBoxEstadoF.Text = "FINALIZADO";
            this.checkBoxEstadoF.UseVisualStyleBackColor = true;
            // 
            // checkBoxEstadoP
            // 
            this.checkBoxEstadoP.AutoSize = true;
            this.checkBoxEstadoP.Location = new System.Drawing.Point(288, 4);
            this.checkBoxEstadoP.Name = "checkBoxEstadoP";
            this.checkBoxEstadoP.Size = new System.Drawing.Size(85, 17);
            this.checkBoxEstadoP.TabIndex = 86;
            this.checkBoxEstadoP.Text = "PROCESSO";
            this.checkBoxEstadoP.UseVisualStyleBackColor = true;
            // 
            // checkBoxEstadoA
            // 
            this.checkBoxEstadoA.AutoSize = true;
            this.checkBoxEstadoA.Location = new System.Drawing.Point(213, 4);
            this.checkBoxEstadoA.Name = "checkBoxEstadoA";
            this.checkBoxEstadoA.Size = new System.Drawing.Size(69, 17);
            this.checkBoxEstadoA.TabIndex = 86;
            this.checkBoxEstadoA.Text = "ABERTA";
            this.checkBoxEstadoA.UseVisualStyleBackColor = true;
            // 
            // txtDataSolicitacao2
            // 
            this.txtDataSolicitacao2.CustomFormat = "MM/dd/YYYY";
            this.txtDataSolicitacao2.Enabled = false;
            this.txtDataSolicitacao2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtDataSolicitacao2.Location = new System.Drawing.Point(761, 5);
            this.txtDataSolicitacao2.Name = "txtDataSolicitacao2";
            this.txtDataSolicitacao2.RightToLeftLayout = true;
            this.txtDataSolicitacao2.Size = new System.Drawing.Size(78, 20);
            this.txtDataSolicitacao2.TabIndex = 106;
            this.txtDataSolicitacao2.Value = new System.DateTime(2017, 1, 10, 0, 0, 0, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(725, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 105;
            this.label3.Text = "De a";
            // 
            // txtDataSolicitacao
            // 
            this.txtDataSolicitacao.CustomFormat = "MM/dd/YYYY";
            this.txtDataSolicitacao.Enabled = false;
            this.txtDataSolicitacao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtDataSolicitacao.Location = new System.Drawing.Point(641, 5);
            this.txtDataSolicitacao.Name = "txtDataSolicitacao";
            this.txtDataSolicitacao.RightToLeftLayout = true;
            this.txtDataSolicitacao.Size = new System.Drawing.Size(78, 20);
            this.txtDataSolicitacao.TabIndex = 104;
            this.txtDataSolicitacao.Value = new System.DateTime(2017, 1, 10, 0, 0, 0, 0);
            // 
            // radioButtonPesquisaData
            // 
            this.radioButtonPesquisaData.AutoSize = true;
            this.radioButtonPesquisaData.Location = new System.Drawing.Point(530, 6);
            this.radioButtonPesquisaData.Name = "radioButtonPesquisaData";
            this.radioButtonPesquisaData.Size = new System.Drawing.Size(105, 17);
            this.radioButtonPesquisaData.TabIndex = 103;
            this.radioButtonPesquisaData.TabStop = true;
            this.radioButtonPesquisaData.Text = "Periodo de Data:";
            this.radioButtonPesquisaData.UseVisualStyleBackColor = true;
            this.radioButtonPesquisaData.CheckedChanged += new System.EventHandler(this.radioButtonPesquisaData_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(531, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 102;
            // 
            // radioButtonPequisaMS
            // 
            this.radioButtonPequisaMS.AutoSize = true;
            this.radioButtonPequisaMS.Location = new System.Drawing.Point(192, 4);
            this.radioButtonPequisaMS.Name = "radioButtonPequisaMS";
            this.radioButtonPequisaMS.Size = new System.Drawing.Size(41, 17);
            this.radioButtonPequisaMS.TabIndex = 98;
            this.radioButtonPequisaMS.TabStop = true;
            this.radioButtonPequisaMS.Text = "MS";
            this.radioButtonPequisaMS.UseVisualStyleBackColor = true;
            this.radioButtonPequisaMS.CheckedChanged += new System.EventHandler(this.radioButtonPequisaMS_CheckedChanged);
            // 
            // buttonPesquisaCliente
            // 
            this.buttonPesquisaCliente.AutoEllipsis = true;
            this.buttonPesquisaCliente.Location = new System.Drawing.Point(845, 2);
            this.buttonPesquisaCliente.Name = "buttonPesquisaCliente";
            this.buttonPesquisaCliente.Size = new System.Drawing.Size(51, 23);
            this.buttonPesquisaCliente.TabIndex = 101;
            this.buttonPesquisaCliente.Text = "Busca";
            this.buttonPesquisaCliente.UseVisualStyleBackColor = true;
            this.buttonPesquisaCliente.Click += new System.EventHandler(this.buttonPesquisaCliente_Click);
            // 
            // txtPesquisaMSOs
            // 
            this.txtPesquisaMSOs.Enabled = false;
            this.txtPesquisaMSOs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisaMSOs.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txtPesquisaMSOs.Location = new System.Drawing.Point(239, 2);
            this.txtPesquisaMSOs.Name = "txtPesquisaMSOs";
            this.txtPesquisaMSOs.Size = new System.Drawing.Size(69, 21);
            this.txtPesquisaMSOs.TabIndex = 97;
            this.txtPesquisaMSOs.TextChanged += new System.EventHandler(this.txtPesquisaMSOs_TextChanged);
            this.txtPesquisaMSOs.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPesquisaMSOs_KeyPress);
            // 
            // txtPesquisaNomeOs
            // 
            this.txtPesquisaNomeOs.AcceptsReturn = true;
            this.txtPesquisaNomeOs.Enabled = false;
            this.txtPesquisaNomeOs.Location = new System.Drawing.Point(380, 6);
            this.txtPesquisaNomeOs.Name = "txtPesquisaNomeOs";
            this.txtPesquisaNomeOs.Size = new System.Drawing.Size(144, 20);
            this.txtPesquisaNomeOs.TabIndex = 100;
            this.txtPesquisaNomeOs.TextChanged += new System.EventHandler(this.txtPesquisaNomeOs_TextChanged);
            this.txtPesquisaNomeOs.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPesquisaNomeOs_KeyPress);
            // 
            // radioButtonPesquisaNome
            // 
            this.radioButtonPesquisaNome.AutoSize = true;
            this.radioButtonPesquisaNome.Location = new System.Drawing.Point(314, 6);
            this.radioButtonPesquisaNome.Name = "radioButtonPesquisaNome";
            this.radioButtonPesquisaNome.Size = new System.Drawing.Size(60, 17);
            this.radioButtonPesquisaNome.TabIndex = 99;
            this.radioButtonPesquisaNome.TabStop = true;
            this.radioButtonPesquisaNome.Text = "NOME:";
            this.radioButtonPesquisaNome.UseVisualStyleBackColor = true;
            this.radioButtonPesquisaNome.CheckedChanged += new System.EventHandler(this.radioButtonPesquisaNome_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 96;
            this.label1.Text = "Pesquisa De OS :";
            // 
            // radioButtonTodosClientes
            // 
            this.radioButtonTodosClientes.AutoSize = true;
            this.radioButtonTodosClientes.Location = new System.Drawing.Point(109, 4);
            this.radioButtonTodosClientes.Name = "radioButtonTodosClientes";
            this.radioButtonTodosClientes.Size = new System.Drawing.Size(77, 17);
            this.radioButtonTodosClientes.TabIndex = 116;
            this.radioButtonTodosClientes.TabStop = true;
            this.radioButtonTodosClientes.Text = "CLIENTES";
            this.radioButtonTodosClientes.UseVisualStyleBackColor = true;
            this.radioButtonTodosClientes.CheckedChanged += new System.EventHandler(this.radioButtonTodosClientes_CheckedChanged);
            // 
            // dataGridViewPesquisa
            // 
            this.dataGridViewPesquisa.AllowUserToAddRows = false;
            this.dataGridViewPesquisa.AllowUserToDeleteRows = false;
            this.dataGridViewPesquisa.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridViewPesquisa.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewPesquisa.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewPesquisa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPesquisa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ORDEM_SERVIÇO,
            this.Column16,
            this.Column19,
            this.Column18,
            this.NOME_CLIENTE,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column10,
            this.Column11,
            this.SERVICO_EXECUTADO,
            this.Column12,
            this.Column14,
            this.Column15,
            this.Column13,
            this.Column9,
            this.ID_PESSOA,
            this.ID_CONTATO,
            this.ID_CLIENTE,
            this.ID_PESSSOA_LOGADA,
            this.ID_PESSSOA_LOGADA_ALTERADA});
            this.dataGridViewPesquisa.Cursor = System.Windows.Forms.Cursors.Default;
            this.dataGridViewPesquisa.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewPesquisa.Location = new System.Drawing.Point(12, 63);
            this.dataGridViewPesquisa.MultiSelect = false;
            this.dataGridViewPesquisa.Name = "dataGridViewPesquisa";
            this.dataGridViewPesquisa.RowHeadersVisible = false;
            this.dataGridViewPesquisa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewPesquisa.Size = new System.Drawing.Size(977, 337);
            this.dataGridViewPesquisa.TabIndex = 95;
            this.dataGridViewPesquisa.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPesquisa_CellDoubleClick);
            // 
            // ORDEM_SERVIÇO
            // 
            this.ORDEM_SERVIÇO.DataPropertyName = "ORDEM_SERVIÇO";
            this.ORDEM_SERVIÇO.HeaderText = "ORDEM SERVIÇO";
            this.ORDEM_SERVIÇO.Name = "ORDEM_SERVIÇO";
            this.ORDEM_SERVIÇO.Width = 60;
            // 
            // Column16
            // 
            this.Column16.DataPropertyName = "SOLICITAÇÃO";
            this.Column16.HeaderText = "SOLICITAÇÃO";
            this.Column16.Name = "Column16";
            // 
            // Column19
            // 
            this.Column19.DataPropertyName = "CLIENTE";
            this.Column19.HeaderText = "CLIENTE";
            this.Column19.Name = "Column19";
            // 
            // Column18
            // 
            this.Column18.DataPropertyName = "RAZAO_SOCIAL";
            this.Column18.HeaderText = "RAZÃO SOCIAL";
            this.Column18.Name = "Column18";
            this.Column18.Width = 150;
            // 
            // NOME_CLIENTE
            // 
            this.NOME_CLIENTE.DataPropertyName = "NOME_CLIENTE";
            this.NOME_CLIENTE.HeaderText = "NOME CLIENTE";
            this.NOME_CLIENTE.Name = "NOME_CLIENTE";
            this.NOME_CLIENTE.Width = 150;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MS";
            this.Column1.HeaderText = "MS";
            this.Column1.Name = "Column1";
            this.Column1.Width = 60;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "LOGRADOURO";
            this.Column2.HeaderText = "LOGRADOURO";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "ENDEREÇO";
            this.Column3.HeaderText = "ENDEREÇO";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "COMPLEMENTO";
            this.Column4.HeaderText = "COMPLEMENTO";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "NUMERO";
            this.Column5.HeaderText = "NUMERO";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "BAIRRO";
            this.Column6.HeaderText = "BAIRRO";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "CIDADE";
            this.Column7.HeaderText = "CIDADE";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "NOME_CONTATO";
            this.Column8.HeaderText = "NOME CONTATO";
            this.Column8.Name = "Column8";
            // 
            // Column10
            // 
            this.Column10.DataPropertyName = "TELEFONE";
            dataGridViewCellStyle2.Format = "(99) 0000-0000";
            dataGridViewCellStyle2.NullValue = null;
            this.Column10.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column10.HeaderText = "TELEFONE";
            this.Column10.Name = "Column10";
            // 
            // Column11
            // 
            this.Column11.DataPropertyName = "ORIGEM_CHAMADO";
            dataGridViewCellStyle3.Format = "(00)0000-0000";
            dataGridViewCellStyle3.NullValue = "0000000000";
            this.Column11.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column11.FillWeight = 150F;
            this.Column11.HeaderText = "ORIGEM CHAMADO";
            this.Column11.Name = "Column11";
            // 
            // SERVICO_EXECUTADO
            // 
            this.SERVICO_EXECUTADO.DataPropertyName = "SERVICO_EXECUTADO";
            this.SERVICO_EXECUTADO.FillWeight = 150F;
            this.SERVICO_EXECUTADO.HeaderText = "SERVIÇO EXECUTADOS";
            this.SERVICO_EXECUTADO.Name = "SERVICO_EXECUTADO";
            // 
            // Column12
            // 
            this.Column12.DataPropertyName = "TECNICO";
            this.Column12.HeaderText = "TECNICO";
            this.Column12.Name = "Column12";
            // 
            // Column14
            // 
            this.Column14.DataPropertyName = "HORARIO_INICIO";
            this.Column14.HeaderText = "HORARIO INICIO";
            this.Column14.Name = "Column14";
            // 
            // Column15
            // 
            this.Column15.DataPropertyName = "HORARIO_FINAL";
            this.Column15.HeaderText = "HORARIO FINAL";
            this.Column15.Name = "Column15";
            // 
            // Column13
            // 
            this.Column13.DataPropertyName = "FINALIZADO_OS";
            this.Column13.HeaderText = "FINALIZADO OS";
            this.Column13.Name = "Column13";
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "DESCRIÇÃO_OS";
            this.Column9.HeaderText = "DESCRIÇÃO OS";
            this.Column9.Name = "Column9";
            // 
            // ID_PESSOA
            // 
            this.ID_PESSOA.DataPropertyName = "ID_PESSOA";
            this.ID_PESSOA.HeaderText = "ID_PESSOA";
            this.ID_PESSOA.Name = "ID_PESSOA";
            this.ID_PESSOA.Visible = false;
            // 
            // ID_CONTATO
            // 
            this.ID_CONTATO.DataPropertyName = "ID_CONTATO";
            this.ID_CONTATO.HeaderText = "ID_CONTATO";
            this.ID_CONTATO.Name = "ID_CONTATO";
            this.ID_CONTATO.Visible = false;
            // 
            // ID_CLIENTE
            // 
            this.ID_CLIENTE.DataPropertyName = "ID_CLIENTE";
            this.ID_CLIENTE.HeaderText = "ID_CLIENTE";
            this.ID_CLIENTE.Name = "ID_CLIENTE";
            this.ID_CLIENTE.Visible = false;
            // 
            // ID_PESSSOA_LOGADA
            // 
            this.ID_PESSSOA_LOGADA.DataPropertyName = "ID_PESSOA_LOGADA";
            this.ID_PESSSOA_LOGADA.HeaderText = "ID_PESSSOA_LOGADA";
            this.ID_PESSSOA_LOGADA.Name = "ID_PESSSOA_LOGADA";
            this.ID_PESSSOA_LOGADA.Visible = false;
            // 
            // ID_PESSSOA_LOGADA_ALTERADA
            // 
            this.ID_PESSSOA_LOGADA_ALTERADA.DataPropertyName = "ID_PESSOA_LOGADA_ALTERADA";
            this.ID_PESSSOA_LOGADA_ALTERADA.HeaderText = "ID_PESSSOA_LOGADA_ALTERADA";
            this.ID_PESSSOA_LOGADA_ALTERADA.Name = "ID_PESSSOA_LOGADA_ALTERADA";
            this.ID_PESSSOA_LOGADA_ALTERADA.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(611, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(19, 13);
            this.label7.TabIndex = 120;
            this.label7.Text = "=>";
            // 
            // txtOrdemServico
            // 
            this.txtOrdemServico.Enabled = false;
            this.txtOrdemServico.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOrdemServico.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txtOrdemServico.Location = new System.Drawing.Point(636, 34);
            this.txtOrdemServico.Name = "txtOrdemServico";
            this.txtOrdemServico.Size = new System.Drawing.Size(69, 21);
            this.txtOrdemServico.TabIndex = 121;
            this.txtOrdemServico.TextChanged += new System.EventHandler(this.txtOrdemServico_TextChanged);
            this.txtOrdemServico.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtOrdemServico_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(924, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 122;
            this.label6.Text = "Quantidade";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(911, 44);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(13, 13);
            this.label8.TabIndex = 123;
            this.label8.Text = "0";
            // 
            // FormOSPesquisa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 443);
            this.ControlBox = false;
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtOrdemServico);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.radioButtonTodosClientes);
            this.Controls.Add(this.radioButtonOculto);
            this.Controls.Add(this.buttonCancelarOs);
            this.Controls.Add(this.buttonFecharOs);
            this.Controls.Add(this.panelEstado);
            this.Controls.Add(this.txtDataSolicitacao2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDataSolicitacao);
            this.Controls.Add(this.radioButtonPesquisaData);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.radioButtonPequisaMS);
            this.Controls.Add(this.buttonPesquisaCliente);
            this.Controls.Add(this.txtPesquisaMSOs);
            this.Controls.Add(this.txtPesquisaNomeOs);
            this.Controls.Add(this.radioButtonPesquisaNome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewPesquisa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormOSPesquisa";
            this.Text = "Pesquisa de Ordem de Serviço";
            this.Load += new System.EventHandler(this.FormOSPesquisa_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FormOSPesquisa_KeyPress);
            this.panelEstado.ResumeLayout(false);
            this.panelEstado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPesquisa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButtonOculto;
        private System.Windows.Forms.Button buttonCancelarOs;
        private System.Windows.Forms.Button buttonFecharOs;
        private System.Windows.Forms.Panel panelEstado;
        private System.Windows.Forms.CheckBox checkBoxEstadoF;
        private System.Windows.Forms.CheckBox checkBoxEstadoP;
        private System.Windows.Forms.CheckBox checkBoxEstadoA;
        private System.Windows.Forms.DateTimePicker txtDataSolicitacao2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker txtDataSolicitacao;
        private System.Windows.Forms.RadioButton radioButtonPesquisaData;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioButtonPequisaMS;
        private System.Windows.Forms.Button buttonPesquisaCliente;
        private System.Windows.Forms.TextBox txtPesquisaMSOs;
        private System.Windows.Forms.TextBox txtPesquisaNomeOs;
        private System.Windows.Forms.RadioButton radioButtonPesquisaNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButtonTodosClientes;
        private System.Windows.Forms.CheckBox checkBoxTodos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBoxOs;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtOrdemServico;
        private System.Windows.Forms.DataGridView dataGridViewPesquisa;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn ORDEM_SERVIÇO;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column16;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column19;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column18;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOME_CLIENTE;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn SERVICO_EXECUTADO;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column14;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column15;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_PESSOA;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_CONTATO;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_CLIENTE;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_PESSSOA_LOGADA;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_PESSSOA_LOGADA_ALTERADA;
    }
}