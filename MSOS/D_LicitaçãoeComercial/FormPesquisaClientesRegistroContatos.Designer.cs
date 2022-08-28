namespace DateSystem
{
    partial class FormPesquisaClientesRegistroContatos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.checkBoxFornecedor = new System.Windows.Forms.CheckBox();
            this.radioButtonFornecedor = new System.Windows.Forms.RadioButton();
            this.txtPesquisaFornecedorContatos = new System.Windows.Forms.TextBox();
            this.checkBoxSituacao = new System.Windows.Forms.CheckBox();
            this.radioButtonTodos = new System.Windows.Forms.RadioButton();
            this.radioButtonPesquisarNome = new System.Windows.Forms.RadioButton();
            this.radioButtonPesquisarAbreviacao = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.radioButtonOculto = new System.Windows.Forms.RadioButton();
            this.buttonCancelarOs = new System.Windows.Forms.Button();
            this.buttonFecharOs = new System.Windows.Forms.Button();
            this.txtPesquisaNomeContatos = new System.Windows.Forms.TextBox();
            this.txtPesquisaAbreviacaoContatos = new System.Windows.Forms.TextBox();
            this.buttonPesquisaCliente = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewPesquisaClienteContatos = new System.Windows.Forms.DataGridView();
            this.ID_PESSOA_CONTATO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CLIENTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOME_CONTATO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ABREVIACAO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TELEFONE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TELEFONE2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CELULAR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CELULAR2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EMAIL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OBSERVACAO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPesquisaClienteContatos)).BeginInit();
            this.SuspendLayout();
            // 
            // checkBoxFornecedor
            // 
            this.checkBoxFornecedor.AutoSize = true;
            this.checkBoxFornecedor.Checked = true;
            this.checkBoxFornecedor.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxFornecedor.Location = new System.Drawing.Point(701, 41);
            this.checkBoxFornecedor.Name = "checkBoxFornecedor";
            this.checkBoxFornecedor.Size = new System.Drawing.Size(88, 17);
            this.checkBoxFornecedor.TabIndex = 185;
            this.checkBoxFornecedor.Text = ":Cliente Ativo";
            this.checkBoxFornecedor.UseVisualStyleBackColor = true;
            // 
            // radioButtonFornecedor
            // 
            this.radioButtonFornecedor.AutoSize = true;
            this.radioButtonFornecedor.Location = new System.Drawing.Point(666, 7);
            this.radioButtonFornecedor.Name = "radioButtonFornecedor";
            this.radioButtonFornecedor.Size = new System.Drawing.Size(103, 17);
            this.radioButtonFornecedor.TabIndex = 184;
            this.radioButtonFornecedor.TabStop = true;
            this.radioButtonFornecedor.Text = "FORNECEDOR:";
            this.radioButtonFornecedor.UseVisualStyleBackColor = true;
            this.radioButtonFornecedor.CheckedChanged += new System.EventHandler(this.radioButtonFornecedor_CheckedChanged);
            // 
            // txtPesquisaFornecedorContatos
            // 
            this.txtPesquisaFornecedorContatos.Enabled = false;
            this.txtPesquisaFornecedorContatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisaFornecedorContatos.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txtPesquisaFornecedorContatos.Location = new System.Drawing.Point(770, 6);
            this.txtPesquisaFornecedorContatos.Name = "txtPesquisaFornecedorContatos";
            this.txtPesquisaFornecedorContatos.Size = new System.Drawing.Size(145, 21);
            this.txtPesquisaFornecedorContatos.TabIndex = 183;
            this.txtPesquisaFornecedorContatos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPesquisaFornecedorContatos_KeyPress);
            // 
            // checkBoxSituacao
            // 
            this.checkBoxSituacao.AutoSize = true;
            this.checkBoxSituacao.Checked = true;
            this.checkBoxSituacao.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxSituacao.Location = new System.Drawing.Point(795, 41);
            this.checkBoxSituacao.Name = "checkBoxSituacao";
            this.checkBoxSituacao.Size = new System.Drawing.Size(93, 17);
            this.checkBoxSituacao.TabIndex = 182;
            this.checkBoxSituacao.Text = ":Contato Ativo";
            this.checkBoxSituacao.UseVisualStyleBackColor = true;
            // 
            // radioButtonTodos
            // 
            this.radioButtonTodos.AutoSize = true;
            this.radioButtonTodos.Location = new System.Drawing.Point(115, 7);
            this.radioButtonTodos.Name = "radioButtonTodos";
            this.radioButtonTodos.Size = new System.Drawing.Size(66, 17);
            this.radioButtonTodos.TabIndex = 181;
            this.radioButtonTodos.TabStop = true;
            this.radioButtonTodos.Text = "TODOS:";
            this.radioButtonTodos.UseVisualStyleBackColor = true;
            this.radioButtonTodos.CheckedChanged += new System.EventHandler(this.radioButtonTodos_CheckedChanged);
            // 
            // radioButtonPesquisarNome
            // 
            this.radioButtonPesquisarNome.AutoSize = true;
            this.radioButtonPesquisarNome.Location = new System.Drawing.Point(185, 7);
            this.radioButtonPesquisarNome.Name = "radioButtonPesquisarNome";
            this.radioButtonPesquisarNome.Size = new System.Drawing.Size(60, 17);
            this.radioButtonPesquisarNome.TabIndex = 180;
            this.radioButtonPesquisarNome.TabStop = true;
            this.radioButtonPesquisarNome.Text = "NOME:";
            this.radioButtonPesquisarNome.UseVisualStyleBackColor = true;
            this.radioButtonPesquisarNome.CheckedChanged += new System.EventHandler(this.radioButtonPesquisarNome_CheckedChanged);
            // 
            // radioButtonPesquisarAbreviacao
            // 
            this.radioButtonPesquisarAbreviacao.AutoSize = true;
            this.radioButtonPesquisarAbreviacao.Location = new System.Drawing.Point(411, 5);
            this.radioButtonPesquisarAbreviacao.Name = "radioButtonPesquisarAbreviacao";
            this.radioButtonPesquisarAbreviacao.Size = new System.Drawing.Size(96, 17);
            this.radioButtonPesquisarAbreviacao.TabIndex = 179;
            this.radioButtonPesquisarAbreviacao.TabStop = true;
            this.radioButtonPesquisarAbreviacao.Text = "ABREVIACAO:";
            this.radioButtonPesquisarAbreviacao.UseVisualStyleBackColor = true;
            this.radioButtonPesquisarAbreviacao.CheckedChanged += new System.EventHandler(this.radioButtonPesquisarAbreviacao_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(894, 44);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(13, 13);
            this.label8.TabIndex = 178;
            this.label8.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(913, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 177;
            this.label6.Text = "Quantidade";
            // 
            // radioButtonOculto
            // 
            this.radioButtonOculto.AutoSize = true;
            this.radioButtonOculto.Checked = true;
            this.radioButtonOculto.Enabled = false;
            this.radioButtonOculto.Location = new System.Drawing.Point(978, 186);
            this.radioButtonOculto.Name = "radioButtonOculto";
            this.radioButtonOculto.Size = new System.Drawing.Size(41, 17);
            this.radioButtonOculto.TabIndex = 176;
            this.radioButtonOculto.TabStop = true;
            this.radioButtonOculto.Text = "MS";
            this.radioButtonOculto.UseVisualStyleBackColor = true;
            this.radioButtonOculto.Visible = false;
            // 
            // buttonCancelarOs
            // 
            this.buttonCancelarOs.Location = new System.Drawing.Point(978, 60);
            this.buttonCancelarOs.Name = "buttonCancelarOs";
            this.buttonCancelarOs.Size = new System.Drawing.Size(26, 26);
            this.buttonCancelarOs.TabIndex = 175;
            this.buttonCancelarOs.Text = "C";
            this.buttonCancelarOs.UseVisualStyleBackColor = true;
            this.buttonCancelarOs.Click += new System.EventHandler(this.buttonCancelarOs_Click);
            // 
            // buttonFecharOs
            // 
            this.buttonFecharOs.Location = new System.Drawing.Point(978, 92);
            this.buttonFecharOs.Name = "buttonFecharOs";
            this.buttonFecharOs.Size = new System.Drawing.Size(26, 26);
            this.buttonFecharOs.TabIndex = 174;
            this.buttonFecharOs.Text = "F";
            this.buttonFecharOs.UseVisualStyleBackColor = true;
            this.buttonFecharOs.Click += new System.EventHandler(this.buttonFecharOs_Click);
            // 
            // txtPesquisaNomeContatos
            // 
            this.txtPesquisaNomeContatos.Enabled = false;
            this.txtPesquisaNomeContatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisaNomeContatos.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txtPesquisaNomeContatos.Location = new System.Drawing.Point(251, 4);
            this.txtPesquisaNomeContatos.Name = "txtPesquisaNomeContatos";
            this.txtPesquisaNomeContatos.Size = new System.Drawing.Size(154, 21);
            this.txtPesquisaNomeContatos.TabIndex = 173;
            this.txtPesquisaNomeContatos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPesquisaNomeContatos_KeyPress);
            // 
            // txtPesquisaAbreviacaoContatos
            // 
            this.txtPesquisaAbreviacaoContatos.Enabled = false;
            this.txtPesquisaAbreviacaoContatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisaAbreviacaoContatos.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txtPesquisaAbreviacaoContatos.Location = new System.Drawing.Point(515, 4);
            this.txtPesquisaAbreviacaoContatos.Name = "txtPesquisaAbreviacaoContatos";
            this.txtPesquisaAbreviacaoContatos.Size = new System.Drawing.Size(145, 21);
            this.txtPesquisaAbreviacaoContatos.TabIndex = 172;
            this.txtPesquisaAbreviacaoContatos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPesquisaAbreviacaoContatos_KeyPress);
            // 
            // buttonPesquisaCliente
            // 
            this.buttonPesquisaCliente.Location = new System.Drawing.Point(921, 5);
            this.buttonPesquisaCliente.Name = "buttonPesquisaCliente";
            this.buttonPesquisaCliente.Size = new System.Drawing.Size(51, 23);
            this.buttonPesquisaCliente.TabIndex = 171;
            this.buttonPesquisaCliente.Text = "Busca";
            this.buttonPesquisaCliente.UseVisualStyleBackColor = true;
            this.buttonPesquisaCliente.Click += new System.EventHandler(this.buttonPesquisaCliente_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 170;
            this.label1.Text = "Pesquisa de Cliente:";
            // 
            // dataGridViewPesquisaClienteContatos
            // 
            this.dataGridViewPesquisaClienteContatos.AllowUserToAddRows = false;
            this.dataGridViewPesquisaClienteContatos.AllowUserToDeleteRows = false;
            this.dataGridViewPesquisaClienteContatos.AllowUserToResizeRows = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridViewPesquisaClienteContatos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewPesquisaClienteContatos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewPesquisaClienteContatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPesquisaClienteContatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_PESSOA_CONTATO,
            this.Column1,
            this.CLIENTE,
            this.NOME_CONTATO,
            this.ABREVIACAO,
            this.TELEFONE,
            this.TELEFONE2,
            this.CELULAR,
            this.CELULAR2,
            this.EMAIL,
            this.OBSERVACAO});
            this.dataGridViewPesquisaClienteContatos.Cursor = System.Windows.Forms.Cursors.Default;
            this.dataGridViewPesquisaClienteContatos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewPesquisaClienteContatos.Location = new System.Drawing.Point(12, 60);
            this.dataGridViewPesquisaClienteContatos.MultiSelect = false;
            this.dataGridViewPesquisaClienteContatos.Name = "dataGridViewPesquisaClienteContatos";
            this.dataGridViewPesquisaClienteContatos.RowHeadersVisible = false;
            this.dataGridViewPesquisaClienteContatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewPesquisaClienteContatos.Size = new System.Drawing.Size(960, 343);
            this.dataGridViewPesquisaClienteContatos.TabIndex = 169;
            this.dataGridViewPesquisaClienteContatos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPesquisaClienteContatos_CellDoubleClick);
            // 
            // ID_PESSOA_CONTATO
            // 
            this.ID_PESSOA_CONTATO.DataPropertyName = "ID_PESSOA_CONTATO";
            this.ID_PESSOA_CONTATO.HeaderText = "ID_PESSOA_CONTATO";
            this.ID_PESSOA_CONTATO.Name = "ID_PESSOA_CONTATO";
            this.ID_PESSOA_CONTATO.Visible = false;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "ID_PESSOA";
            this.Column1.HeaderText = "ID_PESSOA";
            this.Column1.Name = "Column1";
            this.Column1.Visible = false;
            // 
            // CLIENTE
            // 
            this.CLIENTE.DataPropertyName = "CLIENTE";
            this.CLIENTE.HeaderText = "CLIENTE";
            this.CLIENTE.Name = "CLIENTE";
            this.CLIENTE.Width = 150;
            // 
            // NOME_CONTATO
            // 
            this.NOME_CONTATO.DataPropertyName = "NOME_CONTATO";
            this.NOME_CONTATO.HeaderText = "NOME_CONTATO";
            this.NOME_CONTATO.Name = "NOME_CONTATO";
            // 
            // ABREVIACAO
            // 
            this.ABREVIACAO.DataPropertyName = "ABREVIACAO";
            this.ABREVIACAO.HeaderText = "ABREVIACAO";
            this.ABREVIACAO.Name = "ABREVIACAO";
            // 
            // TELEFONE
            // 
            this.TELEFONE.DataPropertyName = "TELEFONE";
            this.TELEFONE.HeaderText = "TELEFONE";
            this.TELEFONE.Name = "TELEFONE";
            // 
            // TELEFONE2
            // 
            this.TELEFONE2.DataPropertyName = "TELEFONE2";
            this.TELEFONE2.HeaderText = "TELEFONE2";
            this.TELEFONE2.Name = "TELEFONE2";
            // 
            // CELULAR
            // 
            this.CELULAR.DataPropertyName = "CELULAR";
            this.CELULAR.HeaderText = "CELULAR";
            this.CELULAR.Name = "CELULAR";
            // 
            // CELULAR2
            // 
            this.CELULAR2.DataPropertyName = "CELULAR2";
            this.CELULAR2.HeaderText = "CELULAR2";
            this.CELULAR2.Name = "CELULAR2";
            // 
            // EMAIL
            // 
            this.EMAIL.DataPropertyName = "EMAIL";
            this.EMAIL.HeaderText = "EMAIL";
            this.EMAIL.Name = "EMAIL";
            // 
            // OBSERVACAO
            // 
            this.OBSERVACAO.DataPropertyName = "OBSERVACAO";
            this.OBSERVACAO.HeaderText = "OBSERVACAO";
            this.OBSERVACAO.Name = "OBSERVACAO";
            this.OBSERVACAO.Width = 120;
            // 
            // FormPesquisaClientesRegistroContatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 419);
            this.ControlBox = false;
            this.Controls.Add(this.checkBoxFornecedor);
            this.Controls.Add(this.radioButtonFornecedor);
            this.Controls.Add(this.txtPesquisaFornecedorContatos);
            this.Controls.Add(this.checkBoxSituacao);
            this.Controls.Add(this.radioButtonTodos);
            this.Controls.Add(this.radioButtonPesquisarNome);
            this.Controls.Add(this.radioButtonPesquisarAbreviacao);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.radioButtonOculto);
            this.Controls.Add(this.buttonCancelarOs);
            this.Controls.Add(this.buttonFecharOs);
            this.Controls.Add(this.txtPesquisaNomeContatos);
            this.Controls.Add(this.txtPesquisaAbreviacaoContatos);
            this.Controls.Add(this.buttonPesquisaCliente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewPesquisaClienteContatos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormPesquisaClientesRegistroContatos";
            this.Text = "Pesquisa Contatos de Clientes Registro";
            this.Load += new System.EventHandler(this.FormPesquisaClientesRegistroContatos_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FormPesquisaClientesRegistroContatos_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPesquisaClienteContatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxFornecedor;
        private System.Windows.Forms.RadioButton radioButtonFornecedor;
        private System.Windows.Forms.TextBox txtPesquisaFornecedorContatos;
        private System.Windows.Forms.CheckBox checkBoxSituacao;
        private System.Windows.Forms.RadioButton radioButtonTodos;
        private System.Windows.Forms.RadioButton radioButtonPesquisarNome;
        private System.Windows.Forms.RadioButton radioButtonPesquisarAbreviacao;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton radioButtonOculto;
        private System.Windows.Forms.Button buttonCancelarOs;
        private System.Windows.Forms.Button buttonFecharOs;
        private System.Windows.Forms.TextBox txtPesquisaNomeContatos;
        private System.Windows.Forms.TextBox txtPesquisaAbreviacaoContatos;
        private System.Windows.Forms.Button buttonPesquisaCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewPesquisaClienteContatos;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_PESSOA_CONTATO;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CLIENTE;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOME_CONTATO;
        private System.Windows.Forms.DataGridViewTextBoxColumn ABREVIACAO;
        private System.Windows.Forms.DataGridViewTextBoxColumn TELEFONE;
        private System.Windows.Forms.DataGridViewTextBoxColumn TELEFONE2;
        private System.Windows.Forms.DataGridViewTextBoxColumn CELULAR;
        private System.Windows.Forms.DataGridViewTextBoxColumn CELULAR2;
        private System.Windows.Forms.DataGridViewTextBoxColumn EMAIL;
        private System.Windows.Forms.DataGridViewTextBoxColumn OBSERVACAO;
    }
}