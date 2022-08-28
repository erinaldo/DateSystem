namespace DateSystem
{
    partial class FormPesquisaProduto
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
            this.checkBoxSituacao = new System.Windows.Forms.CheckBox();
            this.radioButtonTodos = new System.Windows.Forms.RadioButton();
            this.radioButtonPesquisarDescrição = new System.Windows.Forms.RadioButton();
            this.radioButtonPesquisarRegistro = new System.Windows.Forms.RadioButton();
            this.radioButtonOculto = new System.Windows.Forms.RadioButton();
            this.buttonCancelarOs = new System.Windows.Forms.Button();
            this.buttonFecharOs = new System.Windows.Forms.Button();
            this.dataGridViewPesquisaProdutos = new System.Windows.Forms.DataGridView();
            this.ID_PRODUTO1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESCRICAO_PRODUTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRODUTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MARCA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CATEGORIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QUANTIDADE_ESTOQUE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtPesquisaDescricao = new System.Windows.Forms.TextBox();
            this.txtPesquisaRegistroProduto = new System.Windows.Forms.TextBox();
            this.buttonPesquisaCliente = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.radioButtonProduto = new System.Windows.Forms.RadioButton();
            this.comboBoxDescricaoProduto = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPesquisaProdutos)).BeginInit();
            this.SuspendLayout();
            // 
            // checkBoxSituacao
            // 
            this.checkBoxSituacao.AutoSize = true;
            this.checkBoxSituacao.Checked = true;
            this.checkBoxSituacao.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxSituacao.Location = new System.Drawing.Point(15, 37);
            this.checkBoxSituacao.Name = "checkBoxSituacao";
            this.checkBoxSituacao.Size = new System.Drawing.Size(88, 17);
            this.checkBoxSituacao.TabIndex = 161;
            this.checkBoxSituacao.Text = ":Cliente Ativo";
            this.checkBoxSituacao.UseVisualStyleBackColor = true;
            // 
            // radioButtonTodos
            // 
            this.radioButtonTodos.AutoSize = true;
            this.radioButtonTodos.Location = new System.Drawing.Point(121, 7);
            this.radioButtonTodos.Name = "radioButtonTodos";
            this.radioButtonTodos.Size = new System.Drawing.Size(66, 17);
            this.radioButtonTodos.TabIndex = 160;
            this.radioButtonTodos.TabStop = true;
            this.radioButtonTodos.Text = "TODOS:";
            this.radioButtonTodos.UseVisualStyleBackColor = true;
            this.radioButtonTodos.CheckedChanged += new System.EventHandler(this.radioButtonTodos_CheckedChanged);
            // 
            // radioButtonPesquisarDescrição
            // 
            this.radioButtonPesquisarDescrição.AutoSize = true;
            this.radioButtonPesquisarDescrição.Location = new System.Drawing.Point(416, 7);
            this.radioButtonPesquisarDescrição.Name = "radioButtonPesquisarDescrição";
            this.radioButtonPesquisarDescrição.Size = new System.Drawing.Size(76, 17);
            this.radioButtonPesquisarDescrição.TabIndex = 159;
            this.radioButtonPesquisarDescrição.TabStop = true;
            this.radioButtonPesquisarDescrição.Text = "Descrição:";
            this.radioButtonPesquisarDescrição.UseVisualStyleBackColor = true;
            this.radioButtonPesquisarDescrição.CheckedChanged += new System.EventHandler(this.radioButtonPesquisarNome_CheckedChanged);
            // 
            // radioButtonPesquisarRegistro
            // 
            this.radioButtonPesquisarRegistro.AutoSize = true;
            this.radioButtonPesquisarRegistro.Location = new System.Drawing.Point(193, 7);
            this.radioButtonPesquisarRegistro.Name = "radioButtonPesquisarRegistro";
            this.radioButtonPesquisarRegistro.Size = new System.Drawing.Size(107, 17);
            this.radioButtonPesquisarRegistro.TabIndex = 158;
            this.radioButtonPesquisarRegistro.TabStop = true;
            this.radioButtonPesquisarRegistro.Text = "Numero Registro:";
            this.radioButtonPesquisarRegistro.UseVisualStyleBackColor = true;
            this.radioButtonPesquisarRegistro.CheckedChanged += new System.EventHandler(this.radioButtonPesquisarRegistro_CheckedChanged);
            // 
            // radioButtonOculto
            // 
            this.radioButtonOculto.AutoSize = true;
            this.radioButtonOculto.Checked = true;
            this.radioButtonOculto.Enabled = false;
            this.radioButtonOculto.Location = new System.Drawing.Point(1064, 478);
            this.radioButtonOculto.Name = "radioButtonOculto";
            this.radioButtonOculto.Size = new System.Drawing.Size(41, 17);
            this.radioButtonOculto.TabIndex = 157;
            this.radioButtonOculto.TabStop = true;
            this.radioButtonOculto.Text = "MS";
            this.radioButtonOculto.UseVisualStyleBackColor = true;
            this.radioButtonOculto.Visible = false;
            // 
            // buttonCancelarOs
            // 
            this.buttonCancelarOs.Location = new System.Drawing.Point(1009, 42);
            this.buttonCancelarOs.Name = "buttonCancelarOs";
            this.buttonCancelarOs.Size = new System.Drawing.Size(26, 25);
            this.buttonCancelarOs.TabIndex = 156;
            this.buttonCancelarOs.Text = "C";
            this.buttonCancelarOs.UseVisualStyleBackColor = true;
            this.buttonCancelarOs.Click += new System.EventHandler(this.buttonCancelarOs_Click);
            // 
            // buttonFecharOs
            // 
            this.buttonFecharOs.Location = new System.Drawing.Point(1009, 74);
            this.buttonFecharOs.Name = "buttonFecharOs";
            this.buttonFecharOs.Size = new System.Drawing.Size(26, 25);
            this.buttonFecharOs.TabIndex = 155;
            this.buttonFecharOs.Text = "F";
            this.buttonFecharOs.UseVisualStyleBackColor = true;
            this.buttonFecharOs.Click += new System.EventHandler(this.buttonFecharOs_Click);
            // 
            // dataGridViewPesquisaProdutos
            // 
            this.dataGridViewPesquisaProdutos.AllowUserToAddRows = false;
            this.dataGridViewPesquisaProdutos.AllowUserToDeleteRows = false;
            this.dataGridViewPesquisaProdutos.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridViewPesquisaProdutos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewPesquisaProdutos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewPesquisaProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPesquisaProdutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_PRODUTO1,
            this.DESCRICAO_PRODUTO,
            this.PRODUTO,
            this.MARCA,
            this.CATEGORIA,
            this.QUANTIDADE_ESTOQUE});
            this.dataGridViewPesquisaProdutos.Cursor = System.Windows.Forms.Cursors.Default;
            this.dataGridViewPesquisaProdutos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewPesquisaProdutos.Location = new System.Drawing.Point(12, 105);
            this.dataGridViewPesquisaProdutos.MultiSelect = false;
            this.dataGridViewPesquisaProdutos.Name = "dataGridViewPesquisaProdutos";
            this.dataGridViewPesquisaProdutos.RowHeadersVisible = false;
            this.dataGridViewPesquisaProdutos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewPesquisaProdutos.Size = new System.Drawing.Size(1023, 390);
            this.dataGridViewPesquisaProdutos.TabIndex = 154;
            this.dataGridViewPesquisaProdutos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPesquisaProdutos_CellDoubleClick);
            // 
            // ID_PRODUTO1
            // 
            this.ID_PRODUTO1.DataPropertyName = "ID_PRODUTO";
            this.ID_PRODUTO1.HeaderText = "N°";
            this.ID_PRODUTO1.Name = "ID_PRODUTO1";
            this.ID_PRODUTO1.Width = 80;
            // 
            // DESCRICAO_PRODUTO
            // 
            this.DESCRICAO_PRODUTO.DataPropertyName = "DESCRICAO_PRODUTO";
            this.DESCRICAO_PRODUTO.HeaderText = "DESCRIÇÃO PRODUTO";
            this.DESCRICAO_PRODUTO.Name = "DESCRICAO_PRODUTO";
            this.DESCRICAO_PRODUTO.Width = 320;
            // 
            // PRODUTO
            // 
            this.PRODUTO.DataPropertyName = "PRODUTO";
            this.PRODUTO.HeaderText = "PRODUTO";
            this.PRODUTO.Name = "PRODUTO";
            this.PRODUTO.Width = 180;
            // 
            // MARCA
            // 
            this.MARCA.DataPropertyName = "MARCA";
            this.MARCA.HeaderText = "MARCA";
            this.MARCA.Name = "MARCA";
            this.MARCA.Width = 180;
            // 
            // CATEGORIA
            // 
            this.CATEGORIA.DataPropertyName = "CATEGORIA";
            this.CATEGORIA.HeaderText = "CATEGORIA";
            this.CATEGORIA.Name = "CATEGORIA";
            this.CATEGORIA.Width = 180;
            // 
            // QUANTIDADE_ESTOQUE
            // 
            this.QUANTIDADE_ESTOQUE.DataPropertyName = "QUANT_TOTAL_ESTOQUE";
            this.QUANTIDADE_ESTOQUE.FillWeight = 10F;
            this.QUANTIDADE_ESTOQUE.HeaderText = "QUANTIDADE ESTOQUE";
            this.QUANTIDADE_ESTOQUE.Name = "QUANTIDADE_ESTOQUE";
            this.QUANTIDADE_ESTOQUE.Width = 80;
            // 
            // txtPesquisaDescricao
            // 
            this.txtPesquisaDescricao.Enabled = false;
            this.txtPesquisaDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisaDescricao.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txtPesquisaDescricao.Location = new System.Drawing.Point(498, 6);
            this.txtPesquisaDescricao.Name = "txtPesquisaDescricao";
            this.txtPesquisaDescricao.Size = new System.Drawing.Size(537, 21);
            this.txtPesquisaDescricao.TabIndex = 153;
            this.txtPesquisaDescricao.TextChanged += new System.EventHandler(this.txtPesquisaNomeProduto_TextChanged);
            this.txtPesquisaDescricao.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPesquisaNomeProduto_KeyPress);
            // 
            // txtPesquisaRegistroProduto
            // 
            this.txtPesquisaRegistroProduto.Enabled = false;
            this.txtPesquisaRegistroProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisaRegistroProduto.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txtPesquisaRegistroProduto.Location = new System.Drawing.Point(300, 6);
            this.txtPesquisaRegistroProduto.Name = "txtPesquisaRegistroProduto";
            this.txtPesquisaRegistroProduto.Size = new System.Drawing.Size(110, 21);
            this.txtPesquisaRegistroProduto.TabIndex = 152;
            this.txtPesquisaRegistroProduto.TextChanged += new System.EventHandler(this.txtPesquisaRegistroProduto_TextChanged);
            this.txtPesquisaRegistroProduto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPesquisaRegistroProduto_KeyPress);
            // 
            // buttonPesquisaCliente
            // 
            this.buttonPesquisaCliente.Location = new System.Drawing.Point(15, 60);
            this.buttonPesquisaCliente.Name = "buttonPesquisaCliente";
            this.buttonPesquisaCliente.Size = new System.Drawing.Size(51, 23);
            this.buttonPesquisaCliente.TabIndex = 151;
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
            this.label1.TabIndex = 150;
            this.label1.Text = "Pesquisa de Cliente:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(616, 41);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 162;
            this.label8.Text = "Produtos :";
            // 
            // radioButtonProduto
            // 
            this.radioButtonProduto.AutoSize = true;
            this.radioButtonProduto.Location = new System.Drawing.Point(121, 39);
            this.radioButtonProduto.Name = "radioButtonProduto";
            this.radioButtonProduto.Size = new System.Drawing.Size(65, 17);
            this.radioButtonProduto.TabIndex = 164;
            this.radioButtonProduto.TabStop = true;
            this.radioButtonProduto.Text = "Produto:";
            this.radioButtonProduto.UseVisualStyleBackColor = true;
            this.radioButtonProduto.CheckedChanged += new System.EventHandler(this.radioButtonProduto_CheckedChanged);
            // 
            // comboBoxDescricaoProduto
            // 
            this.comboBoxDescricaoProduto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDescricaoProduto.Enabled = false;
            this.comboBoxDescricaoProduto.FormattingEnabled = true;
            this.comboBoxDescricaoProduto.ItemHeight = 13;
            this.comboBoxDescricaoProduto.Location = new System.Drawing.Point(192, 37);
            this.comboBoxDescricaoProduto.Name = "comboBoxDescricaoProduto";
            this.comboBoxDescricaoProduto.Size = new System.Drawing.Size(418, 21);
            this.comboBoxDescricaoProduto.TabIndex = 165;
            this.comboBoxDescricaoProduto.SelectedIndexChanged += new System.EventHandler(this.comboBoxDescricaoProduto_SelectedIndexChanged);
            // 
            // FormPesquisaProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 507);
            this.ControlBox = false;
            this.Controls.Add(this.comboBoxDescricaoProduto);
            this.Controls.Add(this.radioButtonProduto);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.checkBoxSituacao);
            this.Controls.Add(this.radioButtonTodos);
            this.Controls.Add(this.radioButtonPesquisarDescrição);
            this.Controls.Add(this.radioButtonPesquisarRegistro);
            this.Controls.Add(this.radioButtonOculto);
            this.Controls.Add(this.buttonCancelarOs);
            this.Controls.Add(this.buttonFecharOs);
            this.Controls.Add(this.dataGridViewPesquisaProdutos);
            this.Controls.Add(this.txtPesquisaDescricao);
            this.Controls.Add(this.txtPesquisaRegistroProduto);
            this.Controls.Add(this.buttonPesquisaCliente);
            this.Controls.Add(this.label1);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormPesquisaProduto";
            this.Text = "Pesquisa produtos Cadastrados - Itens para venda";
            this.Load += new System.EventHandler(this.FormPesquisaProduto_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FormPesquisaProduto_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPesquisaProdutos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxSituacao;
        private System.Windows.Forms.RadioButton radioButtonTodos;
        private System.Windows.Forms.RadioButton radioButtonPesquisarDescrição;
        private System.Windows.Forms.RadioButton radioButtonPesquisarRegistro;
        private System.Windows.Forms.RadioButton radioButtonOculto;
        private System.Windows.Forms.Button buttonCancelarOs;
        private System.Windows.Forms.Button buttonFecharOs;
        private System.Windows.Forms.DataGridView dataGridViewPesquisaProdutos;
        private System.Windows.Forms.TextBox txtPesquisaDescricao;
        private System.Windows.Forms.TextBox txtPesquisaRegistroProduto;
        private System.Windows.Forms.Button buttonPesquisaCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton radioButtonProduto;
        private System.Windows.Forms.ComboBox comboBoxDescricaoProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_PRODUTO1;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCRICAO_PRODUTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRODUTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn MARCA;
        private System.Windows.Forms.DataGridViewTextBoxColumn CATEGORIA;
        private System.Windows.Forms.DataGridViewTextBoxColumn QUANTIDADE_ESTOQUE;
    }
}