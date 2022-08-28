namespace DateSystem
{
    partial class FormOspesquisaNumerosLivres
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
            this.dataGridViewPesquisa = new System.Windows.Forms.DataGridView();
            this.ORDEM_SERVIÇO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SOLICITAÇÃO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RAZAO_SOCIAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOME_CLIENTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LOGRADOURO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ENDEREÇO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COMPLEMENTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NUMERO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BAIRRO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CIDADE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOME_CONTATO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TELEFONE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ORIGEM_CHAMADO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SERVICO_EXECUTADO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TECNICO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HORARIO_INICIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HORARIO_FINAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESCRIÇÃO_OS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FINALIZADO_OS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_PESSOA_LOGADA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_PESSOA_LOGADA_ALTERADA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_CONTATO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_SITUACAO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonBuscaOS = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.radioButtonPequisaMS = new System.Windows.Forms.RadioButton();
            this.buttonPesquisaCliente = new System.Windows.Forms.Button();
            this.txtPesquisaMSCliente = new System.Windows.Forms.TextBox();
            this.txtPesquisaNomeCliente = new System.Windows.Forms.TextBox();
            this.radioButtonPesquisaNome = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewCliente = new System.Windows.Forms.DataGridView();
            this.ID_PESSOA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CLIENTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MS1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPesquisa)).BeginInit();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCliente)).BeginInit();
            this.SuspendLayout();
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
            this.NomeCliente,
            this.SOLICITAÇÃO,
            this.RAZAO_SOCIAL,
            this.NOME_CLIENTE,
            this.MS,
            this.LOGRADOURO,
            this.ENDEREÇO,
            this.COMPLEMENTO,
            this.NUMERO,
            this.BAIRRO,
            this.CIDADE,
            this.NOME_CONTATO,
            this.TELEFONE,
            this.ORIGEM_CHAMADO,
            this.SERVICO_EXECUTADO,
            this.TECNICO,
            this.HORARIO_INICIO,
            this.HORARIO_FINAL,
            this.DESCRIÇÃO_OS,
            this.FINALIZADO_OS,
            this.ID_PESSOA_LOGADA,
            this.ID_PESSOA_LOGADA_ALTERADA,
            this.ID_CONTATO,
            this.ID_SITUACAO});
            this.dataGridViewPesquisa.Cursor = System.Windows.Forms.Cursors.Default;
            this.dataGridViewPesquisa.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewPesquisa.Location = new System.Drawing.Point(14, 25);
            this.dataGridViewPesquisa.MultiSelect = false;
            this.dataGridViewPesquisa.Name = "dataGridViewPesquisa";
            this.dataGridViewPesquisa.RowHeadersVisible = false;
            this.dataGridViewPesquisa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewPesquisa.Size = new System.Drawing.Size(257, 237);
            this.dataGridViewPesquisa.TabIndex = 96;
            this.dataGridViewPesquisa.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewPesquisa_CellMouseDoubleClick);
            // 
            // ORDEM_SERVIÇO
            // 
            this.ORDEM_SERVIÇO.DataPropertyName = "ORDEM_SERVIÇO";
            this.ORDEM_SERVIÇO.HeaderText = "Numero de OS Abertos";
            this.ORDEM_SERVIÇO.Name = "ORDEM_SERVIÇO";
            // 
            // NomeCliente
            // 
            this.NomeCliente.DataPropertyName = "CLIENTE";
            this.NomeCliente.HeaderText = "Nome do Cliente";
            this.NomeCliente.Name = "NomeCliente";
            this.NomeCliente.Width = 150;
            // 
            // SOLICITAÇÃO
            // 
            this.SOLICITAÇÃO.DataPropertyName = "SOLICITAÇÃO";
            this.SOLICITAÇÃO.HeaderText = "SOLICITAÇÃO";
            this.SOLICITAÇÃO.Name = "SOLICITAÇÃO";
            this.SOLICITAÇÃO.Visible = false;
            // 
            // RAZAO_SOCIAL
            // 
            this.RAZAO_SOCIAL.DataPropertyName = "RAZAO_SOCIAL";
            this.RAZAO_SOCIAL.HeaderText = "RAZAO_SOCIAL";
            this.RAZAO_SOCIAL.Name = "RAZAO_SOCIAL";
            this.RAZAO_SOCIAL.Visible = false;
            // 
            // NOME_CLIENTE
            // 
            this.NOME_CLIENTE.DataPropertyName = "NOME_CLIENTE";
            this.NOME_CLIENTE.HeaderText = "NOME_CLIENTE";
            this.NOME_CLIENTE.Name = "NOME_CLIENTE";
            this.NOME_CLIENTE.Visible = false;
            // 
            // MS
            // 
            this.MS.DataPropertyName = "MS";
            this.MS.HeaderText = "MS";
            this.MS.Name = "MS";
            this.MS.Visible = false;
            // 
            // LOGRADOURO
            // 
            this.LOGRADOURO.DataPropertyName = "LOGRADOURO";
            this.LOGRADOURO.HeaderText = "LOGRADOURO";
            this.LOGRADOURO.Name = "LOGRADOURO";
            this.LOGRADOURO.Visible = false;
            // 
            // ENDEREÇO
            // 
            this.ENDEREÇO.DataPropertyName = "ENDEREÇO";
            this.ENDEREÇO.HeaderText = "ENDEREÇO";
            this.ENDEREÇO.Name = "ENDEREÇO";
            this.ENDEREÇO.Visible = false;
            // 
            // COMPLEMENTO
            // 
            this.COMPLEMENTO.DataPropertyName = "COMPLEMENTO";
            this.COMPLEMENTO.HeaderText = "COMPLEMENTO";
            this.COMPLEMENTO.Name = "COMPLEMENTO";
            this.COMPLEMENTO.Visible = false;
            // 
            // NUMERO
            // 
            this.NUMERO.DataPropertyName = "NUMERO";
            this.NUMERO.HeaderText = "NUMERO";
            this.NUMERO.Name = "NUMERO";
            this.NUMERO.Visible = false;
            // 
            // BAIRRO
            // 
            this.BAIRRO.DataPropertyName = "BAIRRO";
            this.BAIRRO.HeaderText = "BAIRRO";
            this.BAIRRO.Name = "BAIRRO";
            this.BAIRRO.Visible = false;
            // 
            // CIDADE
            // 
            this.CIDADE.DataPropertyName = "CIDADE";
            this.CIDADE.HeaderText = "CIDADE";
            this.CIDADE.Name = "CIDADE";
            this.CIDADE.Visible = false;
            // 
            // NOME_CONTATO
            // 
            this.NOME_CONTATO.DataPropertyName = "NOME_CONTATO";
            this.NOME_CONTATO.HeaderText = "NOME_CONTATO";
            this.NOME_CONTATO.Name = "NOME_CONTATO";
            this.NOME_CONTATO.Visible = false;
            // 
            // TELEFONE
            // 
            this.TELEFONE.DataPropertyName = "TELEFONE";
            this.TELEFONE.HeaderText = "TELEFONE";
            this.TELEFONE.Name = "TELEFONE";
            this.TELEFONE.Visible = false;
            // 
            // ORIGEM_CHAMADO
            // 
            this.ORIGEM_CHAMADO.DataPropertyName = "ORIGEM_CHAMADO";
            this.ORIGEM_CHAMADO.HeaderText = "ORIGEM_CHAMADO";
            this.ORIGEM_CHAMADO.Name = "ORIGEM_CHAMADO";
            this.ORIGEM_CHAMADO.Visible = false;
            // 
            // SERVICO_EXECUTADO
            // 
            this.SERVICO_EXECUTADO.DataPropertyName = "SERVICO_EXECUTADO";
            this.SERVICO_EXECUTADO.HeaderText = "SERVICO_EXECUTADO";
            this.SERVICO_EXECUTADO.Name = "SERVICO_EXECUTADO";
            this.SERVICO_EXECUTADO.Visible = false;
            // 
            // TECNICO
            // 
            this.TECNICO.DataPropertyName = "TECNICO";
            this.TECNICO.HeaderText = "TECNICO";
            this.TECNICO.Name = "TECNICO";
            this.TECNICO.Visible = false;
            // 
            // HORARIO_INICIO
            // 
            this.HORARIO_INICIO.DataPropertyName = "HORARIO_INICIO";
            this.HORARIO_INICIO.HeaderText = "HORARIO_INICIO";
            this.HORARIO_INICIO.Name = "HORARIO_INICIO";
            this.HORARIO_INICIO.Visible = false;
            // 
            // HORARIO_FINAL
            // 
            this.HORARIO_FINAL.DataPropertyName = "HORARIO_FINAL";
            this.HORARIO_FINAL.HeaderText = "HORARIO_FINAL";
            this.HORARIO_FINAL.Name = "HORARIO_FINAL";
            this.HORARIO_FINAL.Visible = false;
            // 
            // DESCRIÇÃO_OS
            // 
            this.DESCRIÇÃO_OS.DataPropertyName = "DESCRIÇÃO_OS";
            this.DESCRIÇÃO_OS.HeaderText = "DESCRIÇÃO_OS";
            this.DESCRIÇÃO_OS.Name = "DESCRIÇÃO_OS";
            this.DESCRIÇÃO_OS.Visible = false;
            // 
            // FINALIZADO_OS
            // 
            this.FINALIZADO_OS.DataPropertyName = "FINALIZADO_OS";
            this.FINALIZADO_OS.HeaderText = "FINALIZADO_OS";
            this.FINALIZADO_OS.Name = "FINALIZADO_OS";
            this.FINALIZADO_OS.Visible = false;
            // 
            // ID_PESSOA_LOGADA
            // 
            this.ID_PESSOA_LOGADA.DataPropertyName = "ID_PESSOA_LOGADA";
            this.ID_PESSOA_LOGADA.HeaderText = "ID_PESSOA_LOGADA";
            this.ID_PESSOA_LOGADA.Name = "ID_PESSOA_LOGADA";
            this.ID_PESSOA_LOGADA.Visible = false;
            // 
            // ID_PESSOA_LOGADA_ALTERADA
            // 
            this.ID_PESSOA_LOGADA_ALTERADA.DataPropertyName = "ID_PESSOA_LOGADA_ALTERADA";
            this.ID_PESSOA_LOGADA_ALTERADA.HeaderText = "ID_PESSOA_LOGADA_ALTERADA";
            this.ID_PESSOA_LOGADA_ALTERADA.Name = "ID_PESSOA_LOGADA_ALTERADA";
            this.ID_PESSOA_LOGADA_ALTERADA.Visible = false;
            // 
            // ID_CONTATO
            // 
            this.ID_CONTATO.DataPropertyName = "ID_CONTATO";
            this.ID_CONTATO.HeaderText = "ID_CONTATO";
            this.ID_CONTATO.Name = "ID_CONTATO";
            this.ID_CONTATO.Visible = false;
            // 
            // ID_SITUACAO
            // 
            this.ID_SITUACAO.DataPropertyName = "ID_SITUACAO";
            this.ID_SITUACAO.HeaderText = "ID_SITUACAO";
            this.ID_SITUACAO.Name = "ID_SITUACAO";
            this.ID_SITUACAO.Visible = false;
            // 
            // buttonBuscaOS
            // 
            this.buttonBuscaOS.Location = new System.Drawing.Point(277, 25);
            this.buttonBuscaOS.Name = "buttonBuscaOS";
            this.buttonBuscaOS.Size = new System.Drawing.Size(103, 23);
            this.buttonBuscaOS.TabIndex = 98;
            this.buttonBuscaOS.Text = "Busca Os Livres";
            this.buttonBuscaOS.UseVisualStyleBackColor = true;
            this.buttonBuscaOS.Click += new System.EventHandler(this.buttonBuscaOS_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 13);
            this.label1.TabIndex = 99;
            this.label1.Text = "Quantidade de Os desativada:";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.radioButtonPequisaMS);
            this.panel6.Controls.Add(this.buttonPesquisaCliente);
            this.panel6.Controls.Add(this.txtPesquisaMSCliente);
            this.panel6.Controls.Add(this.txtPesquisaNomeCliente);
            this.panel6.Controls.Add(this.radioButtonPesquisaNome);
            this.panel6.Location = new System.Drawing.Point(385, 25);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(227, 81);
            this.panel6.TabIndex = 149;
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
            // txtPesquisaMSCliente
            // 
            this.txtPesquisaMSCliente.Enabled = false;
            this.txtPesquisaMSCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisaMSCliente.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txtPesquisaMSCliente.Location = new System.Drawing.Point(70, 8);
            this.txtPesquisaMSCliente.Name = "txtPesquisaMSCliente";
            this.txtPesquisaMSCliente.Size = new System.Drawing.Size(69, 21);
            this.txtPesquisaMSCliente.TabIndex = 22;
            this.txtPesquisaMSCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPesquisaMSCliente_KeyPress);
            // 
            // txtPesquisaNomeCliente
            // 
            this.txtPesquisaNomeCliente.Enabled = false;
            this.txtPesquisaNomeCliente.Location = new System.Drawing.Point(70, 40);
            this.txtPesquisaNomeCliente.Name = "txtPesquisaNomeCliente";
            this.txtPesquisaNomeCliente.Size = new System.Drawing.Size(144, 20);
            this.txtPesquisaNomeCliente.TabIndex = 22;
            this.txtPesquisaNomeCliente.TextChanged += new System.EventHandler(this.txtPesquisaNomeCliente_TextChanged);
            this.txtPesquisaNomeCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPesquisaNomeCliente_KeyPress);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(615, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 13);
            this.label2.TabIndex = 151;
            this.label2.Text = "Quantidade de clientes:";
            // 
            // dataGridViewCliente
            // 
            this.dataGridViewCliente.AllowUserToAddRows = false;
            this.dataGridViewCliente.AllowUserToDeleteRows = false;
            this.dataGridViewCliente.AllowUserToResizeRows = false;
            this.dataGridViewCliente.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCliente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_PESSOA,
            this.CLIENTE,
            this.MS1});
            this.dataGridViewCliente.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewCliente.Location = new System.Drawing.Point(618, 25);
            this.dataGridViewCliente.MultiSelect = false;
            this.dataGridViewCliente.Name = "dataGridViewCliente";
            this.dataGridViewCliente.RowHeadersVisible = false;
            this.dataGridViewCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCliente.Size = new System.Drawing.Size(303, 236);
            this.dataGridViewCliente.TabIndex = 152;
            this.dataGridViewCliente.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewCliente_CellMouseDoubleClick);
            // 
            // ID_PESSOA
            // 
            this.ID_PESSOA.DataPropertyName = "ID_PESSOA";
            this.ID_PESSOA.HeaderText = "ID_PESSOA";
            this.ID_PESSOA.Name = "ID_PESSOA";
            this.ID_PESSOA.Visible = false;
            // 
            // CLIENTE
            // 
            this.CLIENTE.DataPropertyName = "CLIENTE";
            this.CLIENTE.HeaderText = "CLIENTE";
            this.CLIENTE.Name = "CLIENTE";
            this.CLIENTE.Width = 200;
            // 
            // MS1
            // 
            this.MS1.DataPropertyName = "MS";
            this.MS1.HeaderText = "MS";
            this.MS1.Name = "MS1";
            // 
            // FormOspesquisaNumerosLivres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 266);
            this.ControlBox = false;
            this.Controls.Add(this.dataGridViewCliente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonBuscaOS);
            this.Controls.Add(this.dataGridViewPesquisa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.Name = "FormOspesquisaNumerosLivres";
            this.Text = "Pesquisa Números de Os Livres!";
            this.Load += new System.EventHandler(this.FormOspesquisaNumerosLivres_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FormOspesquisaNumerosLivres_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPesquisa)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewPesquisa;
        private System.Windows.Forms.Button buttonBuscaOS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ORDEM_SERVIÇO;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn SOLICITAÇÃO;
        private System.Windows.Forms.DataGridViewTextBoxColumn RAZAO_SOCIAL;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOME_CLIENTE;
        private System.Windows.Forms.DataGridViewTextBoxColumn MS;
        private System.Windows.Forms.DataGridViewTextBoxColumn LOGRADOURO;
        private System.Windows.Forms.DataGridViewTextBoxColumn ENDEREÇO;
        private System.Windows.Forms.DataGridViewTextBoxColumn COMPLEMENTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn NUMERO;
        private System.Windows.Forms.DataGridViewTextBoxColumn BAIRRO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CIDADE;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOME_CONTATO;
        private System.Windows.Forms.DataGridViewTextBoxColumn TELEFONE;
        private System.Windows.Forms.DataGridViewTextBoxColumn ORIGEM_CHAMADO;
        private System.Windows.Forms.DataGridViewTextBoxColumn SERVICO_EXECUTADO;
        private System.Windows.Forms.DataGridViewTextBoxColumn TECNICO;
        private System.Windows.Forms.DataGridViewTextBoxColumn HORARIO_INICIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn HORARIO_FINAL;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCRIÇÃO_OS;
        private System.Windows.Forms.DataGridViewTextBoxColumn FINALIZADO_OS;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_PESSOA_LOGADA;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_PESSOA_LOGADA_ALTERADA;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_CONTATO;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_SITUACAO;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.RadioButton radioButtonPequisaMS;
        private System.Windows.Forms.Button buttonPesquisaCliente;
        private System.Windows.Forms.TextBox txtPesquisaMSCliente;
        private System.Windows.Forms.TextBox txtPesquisaNomeCliente;
        private System.Windows.Forms.RadioButton radioButtonPesquisaNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridViewCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_PESSOA;
        private System.Windows.Forms.DataGridViewTextBoxColumn CLIENTE;
        private System.Windows.Forms.DataGridViewTextBoxColumn MS1;
    }
}