namespace DateSystem
{
    partial class FormPesquisaFornecedorContatos
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
            this.dataGridViewPesquisaForncedorContatos = new System.Windows.Forms.DataGridView();
            this.ID_PESSOA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPesquisaForncedorContatos)).BeginInit();
            this.SuspendLayout();
            // 
            // checkBoxFornecedor
            // 
            this.checkBoxFornecedor.AutoSize = true;
            this.checkBoxFornecedor.Checked = true;
            this.checkBoxFornecedor.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxFornecedor.Location = new System.Drawing.Point(685, 41);
            this.checkBoxFornecedor.Name = "checkBoxFornecedor";
            this.checkBoxFornecedor.Size = new System.Drawing.Size(110, 17);
            this.checkBoxFornecedor.TabIndex = 185;
            this.checkBoxFornecedor.Text = ":Fornecedor Ativo";
            this.checkBoxFornecedor.UseVisualStyleBackColor = true;
            // 
            // radioButtonFornecedor
            // 
            this.radioButtonFornecedor.AutoSize = true;
            this.radioButtonFornecedor.Location = new System.Drawing.Point(689, 7);
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
            this.txtPesquisaFornecedorContatos.Location = new System.Drawing.Point(793, 6);
            this.txtPesquisaFornecedorContatos.Name = "txtPesquisaFornecedorContatos";
            this.txtPesquisaFornecedorContatos.Size = new System.Drawing.Size(145, 21);
            this.txtPesquisaFornecedorContatos.TabIndex = 183;
            this.txtPesquisaFornecedorContatos.TextChanged += new System.EventHandler(this.txtPesquisaFornecedorContatos_TextChanged);
            this.txtPesquisaFornecedorContatos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPesquisaFornecedorContatos_KeyPress);
            // 
            // checkBoxSituacao
            // 
            this.checkBoxSituacao.AutoSize = true;
            this.checkBoxSituacao.Checked = true;
            this.checkBoxSituacao.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxSituacao.Location = new System.Drawing.Point(801, 42);
            this.checkBoxSituacao.Name = "checkBoxSituacao";
            this.checkBoxSituacao.Size = new System.Drawing.Size(93, 17);
            this.checkBoxSituacao.TabIndex = 182;
            this.checkBoxSituacao.Text = ":Contato Ativo";
            this.checkBoxSituacao.UseVisualStyleBackColor = true;
            // 
            // radioButtonTodos
            // 
            this.radioButtonTodos.AutoSize = true;
            this.radioButtonTodos.Location = new System.Drawing.Point(138, 7);
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
            this.radioButtonPesquisarNome.Location = new System.Drawing.Point(208, 7);
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
            this.radioButtonPesquisarAbreviacao.Location = new System.Drawing.Point(434, 5);
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
            this.label8.Location = new System.Drawing.Point(897, 44);
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
            this.radioButtonOculto.Location = new System.Drawing.Point(1001, 191);
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
            this.buttonCancelarOs.Location = new System.Drawing.Point(1001, 60);
            this.buttonCancelarOs.Name = "buttonCancelarOs";
            this.buttonCancelarOs.Size = new System.Drawing.Size(26, 26);
            this.buttonCancelarOs.TabIndex = 175;
            this.buttonCancelarOs.Text = "C";
            this.buttonCancelarOs.UseVisualStyleBackColor = true;
            this.buttonCancelarOs.Click += new System.EventHandler(this.buttonCancelarOs_Click);
            // 
            // buttonFecharOs
            // 
            this.buttonFecharOs.Location = new System.Drawing.Point(1001, 92);
            this.buttonFecharOs.Name = "buttonFecharOs";
            this.buttonFecharOs.Size = new System.Drawing.Size(26, 26);
            this.buttonFecharOs.TabIndex = 174;
            this.buttonFecharOs.Text = "F";
            this.buttonFecharOs.UseVisualStyleBackColor = true;
            // 
            // txtPesquisaNomeContatos
            // 
            this.txtPesquisaNomeContatos.Enabled = false;
            this.txtPesquisaNomeContatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisaNomeContatos.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txtPesquisaNomeContatos.Location = new System.Drawing.Point(274, 4);
            this.txtPesquisaNomeContatos.Name = "txtPesquisaNomeContatos";
            this.txtPesquisaNomeContatos.Size = new System.Drawing.Size(154, 21);
            this.txtPesquisaNomeContatos.TabIndex = 173;
            this.txtPesquisaNomeContatos.TextChanged += new System.EventHandler(this.txtPesquisaNomeContatos_TextChanged);
            this.txtPesquisaNomeContatos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPesquisaNomeContatos_KeyPress);
            // 
            // txtPesquisaAbreviacaoContatos
            // 
            this.txtPesquisaAbreviacaoContatos.Enabled = false;
            this.txtPesquisaAbreviacaoContatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisaAbreviacaoContatos.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txtPesquisaAbreviacaoContatos.Location = new System.Drawing.Point(538, 4);
            this.txtPesquisaAbreviacaoContatos.Name = "txtPesquisaAbreviacaoContatos";
            this.txtPesquisaAbreviacaoContatos.Size = new System.Drawing.Size(145, 21);
            this.txtPesquisaAbreviacaoContatos.TabIndex = 172;
            this.txtPesquisaAbreviacaoContatos.TextChanged += new System.EventHandler(this.txtPesquisaAbreviacaoContatos_TextChanged);
            this.txtPesquisaAbreviacaoContatos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPesquisaAbreviacaoContatos_KeyPress);
            // 
            // buttonPesquisaCliente
            // 
            this.buttonPesquisaCliente.Location = new System.Drawing.Point(944, 5);
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
            this.label1.Size = new System.Drawing.Size(125, 13);
            this.label1.TabIndex = 170;
            this.label1.Text = "Pesquisa de Fornecedor:";
            // 
            // dataGridViewPesquisaForncedorContatos
            // 
            this.dataGridViewPesquisaForncedorContatos.AllowUserToAddRows = false;
            this.dataGridViewPesquisaForncedorContatos.AllowUserToDeleteRows = false;
            this.dataGridViewPesquisaForncedorContatos.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridViewPesquisaForncedorContatos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewPesquisaForncedorContatos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewPesquisaForncedorContatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPesquisaForncedorContatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_PESSOA,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9});
            this.dataGridViewPesquisaForncedorContatos.Cursor = System.Windows.Forms.Cursors.Default;
            this.dataGridViewPesquisaForncedorContatos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewPesquisaForncedorContatos.Location = new System.Drawing.Point(12, 60);
            this.dataGridViewPesquisaForncedorContatos.MultiSelect = false;
            this.dataGridViewPesquisaForncedorContatos.Name = "dataGridViewPesquisaForncedorContatos";
            this.dataGridViewPesquisaForncedorContatos.RowHeadersVisible = false;
            this.dataGridViewPesquisaForncedorContatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewPesquisaForncedorContatos.Size = new System.Drawing.Size(983, 343);
            this.dataGridViewPesquisaForncedorContatos.TabIndex = 169;
            this.dataGridViewPesquisaForncedorContatos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPesquisaClienteContatos_CellDoubleClick);
            // 
            // ID_PESSOA
            // 
            this.ID_PESSOA.DataPropertyName = "ID_PESSOA";
            this.ID_PESSOA.HeaderText = "ID_PESSOA";
            this.ID_PESSOA.Name = "ID_PESSOA";
            this.ID_PESSOA.Visible = false;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "CLIENTE";
            this.Column1.HeaderText = "CLIENTE";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "NOME_CONTATO";
            this.Column2.HeaderText = "NOME CONTATO";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "ABREVIACAO";
            this.Column3.HeaderText = "ABREVIACAO";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "TELEFONE";
            this.Column4.HeaderText = "TELEFONE";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "TELEFONE2";
            this.Column5.HeaderText = "TELEFONE2";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "CELULAR";
            this.Column6.HeaderText = "CELULAR";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "CELULAR2";
            this.Column7.HeaderText = "CELULAR2";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "EMAIL";
            this.Column8.HeaderText = "EMAIL";
            this.Column8.Name = "Column8";
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "OBSERVACAO";
            this.Column9.HeaderText = "OBSERVACAO";
            this.Column9.Name = "Column9";
            this.Column9.Width = 200;
            // 
            // FormPesquisaFornecedorContatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 423);
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
            this.Controls.Add(this.dataGridViewPesquisaForncedorContatos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormPesquisaFornecedorContatos";
            this.Text = "Pesquisa Contatos de Fornecedor";
            this.Load += new System.EventHandler(this.FormPesquisaFornecedorContatos_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FormPesquisaFornecedorContatos_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPesquisaForncedorContatos)).EndInit();
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
        private System.Windows.Forms.DataGridView dataGridViewPesquisaForncedorContatos;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_PESSOA;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
    }
}