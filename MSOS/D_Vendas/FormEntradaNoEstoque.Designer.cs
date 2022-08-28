namespace DateSystem
{
    partial class FormEntradaNoEstoque
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dateTimePickerEntradaNota = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxTipoEntrada = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.txtNumeroNota = new System.Windows.Forms.TextBox();
            this.comboBoxCFOP = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.txtConsultarFornecedor = new System.Windows.Forms.TextBox();
            this.checkBoxSituacao = new System.Windows.Forms.CheckBox();
            this.Nome = new System.Windows.Forms.Label();
            this.dataGridViewFornecedores = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOME1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.INFORMACAO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxFornecedor = new System.Windows.Forms.ComboBox();
            this.txtValorFrete = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtIcms = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDesconto = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.checkBoxLancarContasPagar = new System.Windows.Forms.CheckBox();
            this.dataGridViewEstoque = new System.Windows.Forms.DataGridView();
            this.Linha_Usada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id_Produto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Produto_Pesquisa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor_Unitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor_Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.timerVerfiicaCampo = new System.Windows.Forms.Timer(this.components);
            this.buttonFecharOs = new System.Windows.Forms.Button();
            this.checkBoxReajustePrecoVenda = new System.Windows.Forms.CheckBox();
            this.checkBoxImprimiretiquetas = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFornecedores)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEstoque)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePickerEntradaNota
            // 
            this.dateTimePickerEntradaNota.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerEntradaNota.Location = new System.Drawing.Point(12, 24);
            this.dateTimePickerEntradaNota.Name = "dateTimePickerEntradaNota";
            this.dateTimePickerEntradaNota.Size = new System.Drawing.Size(100, 20);
            this.dateTimePickerEntradaNota.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Data:";
            // 
            // comboBoxTipoEntrada
            // 
            this.comboBoxTipoEntrada.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTipoEntrada.FormattingEnabled = true;
            this.comboBoxTipoEntrada.ItemHeight = 13;
            this.comboBoxTipoEntrada.Location = new System.Drawing.Point(138, 23);
            this.comboBoxTipoEntrada.Name = "comboBoxTipoEntrada";
            this.comboBoxTipoEntrada.Size = new System.Drawing.Size(182, 21);
            this.comboBoxTipoEntrada.TabIndex = 2;
            this.comboBoxTipoEntrada.SelectedIndexChanged += new System.EventHandler(this.comboBoxTipoEntrada_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(135, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tipo de Entrada:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(12, 53);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(63, 13);
            this.label18.TabIndex = 119;
            this.label18.Text = "N° da Nota:";
            // 
            // txtNumeroNota
            // 
            this.txtNumeroNota.Location = new System.Drawing.Point(12, 76);
            this.txtNumeroNota.Name = "txtNumeroNota";
            this.txtNumeroNota.Size = new System.Drawing.Size(100, 20);
            this.txtNumeroNota.TabIndex = 2;
            this.txtNumeroNota.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumeroNota_KeyPress);
            // 
            // comboBoxCFOP
            // 
            this.comboBoxCFOP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCFOP.FormattingEnabled = true;
            this.comboBoxCFOP.ItemHeight = 13;
            this.comboBoxCFOP.Location = new System.Drawing.Point(138, 75);
            this.comboBoxCFOP.Name = "comboBoxCFOP";
            this.comboBoxCFOP.Size = new System.Drawing.Size(82, 21);
            this.comboBoxCFOP.TabIndex = 3;
            this.comboBoxCFOP.SelectedIndexChanged += new System.EventHandler(this.comboBoxCFOP_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(135, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 120;
            this.label2.Text = "CFOP:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtConsultarFornecedor);
            this.panel1.Controls.Add(this.checkBoxSituacao);
            this.panel1.Controls.Add(this.Nome);
            this.panel1.Controls.Add(this.dataGridViewFornecedores);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.comboBoxFornecedor);
            this.panel1.Location = new System.Drawing.Point(326, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(520, 159);
            this.panel1.TabIndex = 122;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(76, 1);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 126;
            this.label4.Text = "Nome:";
            // 
            // txtConsultarFornecedor
            // 
            this.txtConsultarFornecedor.Location = new System.Drawing.Point(68, 17);
            this.txtConsultarFornecedor.Name = "txtConsultarFornecedor";
            this.txtConsultarFornecedor.Size = new System.Drawing.Size(449, 20);
            this.txtConsultarFornecedor.TabIndex = 125;
            this.txtConsultarFornecedor.TextChanged += new System.EventHandler(this.txtConsultarItens_TextChanged);
            this.txtConsultarFornecedor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtConsultarFornecedor_KeyPress);
            // 
            // checkBoxSituacao
            // 
            this.checkBoxSituacao.AutoSize = true;
            this.checkBoxSituacao.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.checkBoxSituacao.Checked = true;
            this.checkBoxSituacao.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxSituacao.Location = new System.Drawing.Point(9, 27);
            this.checkBoxSituacao.Name = "checkBoxSituacao";
            this.checkBoxSituacao.Size = new System.Drawing.Size(53, 31);
            this.checkBoxSituacao.TabIndex = 123;
            this.checkBoxSituacao.Text = "Situação";
            this.checkBoxSituacao.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.checkBoxSituacao.UseVisualStyleBackColor = true;
            // 
            // Nome
            // 
            this.Nome.AutoSize = true;
            this.Nome.Location = new System.Drawing.Point(6, 118);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(38, 13);
            this.Nome.TabIndex = 124;
            this.Nome.Text = "Nome:";
            // 
            // dataGridViewFornecedores
            // 
            this.dataGridViewFornecedores.AllowUserToAddRows = false;
            this.dataGridViewFornecedores.AllowUserToDeleteRows = false;
            this.dataGridViewFornecedores.AllowUserToResizeRows = false;
            this.dataGridViewFornecedores.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewFornecedores.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewFornecedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFornecedores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.NOME1,
            this.INFORMACAO});
            this.dataGridViewFornecedores.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewFornecedores.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridViewFornecedores.Location = new System.Drawing.Point(68, 39);
            this.dataGridViewFornecedores.MultiSelect = false;
            this.dataGridViewFornecedores.Name = "dataGridViewFornecedores";
            this.dataGridViewFornecedores.RowHeadersVisible = false;
            this.dataGridViewFornecedores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewFornecedores.Size = new System.Drawing.Size(449, 92);
            this.dataGridViewFornecedores.TabIndex = 124;
            this.dataGridViewFornecedores.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewFornecedores_CellDoubleClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "NUMERO";
            this.ID.Name = "ID";
            this.ID.Width = 60;
            // 
            // NOME1
            // 
            this.NOME1.DataPropertyName = "NOME";
            this.NOME1.HeaderText = "NOME";
            this.NOME1.Name = "NOME1";
            this.NOME1.Width = 220;
            // 
            // INFORMACAO
            // 
            this.INFORMACAO.DataPropertyName = "INFORMACAO";
            this.INFORMACAO.HeaderText = "DESCRIÇÃO";
            this.INFORMACAO.Name = "INFORMACAO";
            this.INFORMACAO.Width = 165;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, -2);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 123;
            this.label5.Text = "Fornecedor:";
            // 
            // comboBoxFornecedor
            // 
            this.comboBoxFornecedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFornecedor.FormattingEnabled = true;
            this.comboBoxFornecedor.ItemHeight = 13;
            this.comboBoxFornecedor.Location = new System.Drawing.Point(5, 134);
            this.comboBoxFornecedor.Name = "comboBoxFornecedor";
            this.comboBoxFornecedor.Size = new System.Drawing.Size(512, 21);
            this.comboBoxFornecedor.TabIndex = 6;
            this.comboBoxFornecedor.SelectedIndexChanged += new System.EventHandler(this.comboBoxFornecedor_SelectedIndexChanged);
            // 
            // txtValorFrete
            // 
            this.txtValorFrete.Location = new System.Drawing.Point(12, 373);
            this.txtValorFrete.Name = "txtValorFrete";
            this.txtValorFrete.Size = new System.Drawing.Size(100, 20);
            this.txtValorFrete.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 352);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 127;
            this.label6.Text = "Valor do Frete";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(139, 357);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 13);
            this.label7.TabIndex = 129;
            this.label7.Text = "I.C.M.S (%)";
            // 
            // txtIcms
            // 
            this.txtIcms.Location = new System.Drawing.Point(138, 373);
            this.txtIcms.Name = "txtIcms";
            this.txtIcms.Size = new System.Drawing.Size(100, 20);
            this.txtIcms.TabIndex = 6;
            this.txtIcms.TextChanged += new System.EventHandler(this.txtIcms_TextChanged);
            this.txtIcms.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIcms_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(380, 353);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 131;
            this.label8.Text = "Desconto";
            // 
            // txtDesconto
            // 
            this.txtDesconto.Location = new System.Drawing.Point(377, 369);
            this.txtDesconto.Name = "txtDesconto";
            this.txtDesconto.Size = new System.Drawing.Size(100, 20);
            this.txtDesconto.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.checkBoxLancarContasPagar);
            this.panel2.Location = new System.Drawing.Point(533, 352);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(204, 86);
            this.panel2.TabIndex = 132;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(45, 19);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 29);
            this.label12.TabIndex = 134;
            this.label12.Text = "Valor";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 13);
            this.label10.TabIndex = 133;
            this.label10.Text = "Desconto";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(15, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 29);
            this.label9.TabIndex = 132;
            this.label9.Text = "R$";
            // 
            // checkBoxLancarContasPagar
            // 
            this.checkBoxLancarContasPagar.AutoSize = true;
            this.checkBoxLancarContasPagar.Location = new System.Drawing.Point(3, 62);
            this.checkBoxLancarContasPagar.Name = "checkBoxLancarContasPagar";
            this.checkBoxLancarContasPagar.Size = new System.Drawing.Size(141, 17);
            this.checkBoxLancarContasPagar.TabIndex = 0;
            this.checkBoxLancarContasPagar.Text = "Lançar no Contas Pagar";
            this.checkBoxLancarContasPagar.UseVisualStyleBackColor = true;
            // 
            // dataGridViewEstoque
            // 
            this.dataGridViewEstoque.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewEstoque.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewEstoque.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Linha_Usada,
            this.Id_Produto,
            this.Quantidade,
            this.Produto_Pesquisa,
            this.Valor_Unitario,
            this.Valor_Total});
            this.dataGridViewEstoque.Location = new System.Drawing.Point(12, 173);
            this.dataGridViewEstoque.Name = "dataGridViewEstoque";
            this.dataGridViewEstoque.Size = new System.Drawing.Size(834, 173);
            this.dataGridViewEstoque.TabIndex = 1;
            this.dataGridViewEstoque.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewEstoque_CellDoubleClick);
            this.dataGridViewEstoque.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridViewEstoque_CellFormatting);
            this.dataGridViewEstoque.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dataGridViewEstoque_EditingControlShowing);
            this.dataGridViewEstoque.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridViewEstoque_KeyDown);
            // 
            // Linha_Usada
            // 
            this.Linha_Usada.Frozen = true;
            this.Linha_Usada.HeaderText = "N - Produtos";
            this.Linha_Usada.Name = "Linha_Usada";
            this.Linha_Usada.ReadOnly = true;
            this.Linha_Usada.Width = 80;
            // 
            // Id_Produto
            // 
            this.Id_Produto.HeaderText = "Id Produto";
            this.Id_Produto.Name = "Id_Produto";
            this.Id_Produto.ReadOnly = true;
            this.Id_Produto.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Quantidade
            // 
            this.Quantidade.HeaderText = "Quantidade";
            this.Quantidade.Name = "Quantidade";
            // 
            // Produto_Pesquisa
            // 
            this.Produto_Pesquisa.FillWeight = 80F;
            this.Produto_Pesquisa.HeaderText = "Produto Pesquisa";
            this.Produto_Pesquisa.Name = "Produto_Pesquisa";
            this.Produto_Pesquisa.ReadOnly = true;
            this.Produto_Pesquisa.Width = 300;
            // 
            // Valor_Unitario
            // 
            dataGridViewCellStyle3.NullValue = null;
            this.Valor_Unitario.DefaultCellStyle = dataGridViewCellStyle3;
            this.Valor_Unitario.HeaderText = "Valor Unitario";
            this.Valor_Unitario.Name = "Valor_Unitario";
            this.Valor_Unitario.Width = 105;
            // 
            // Valor_Total
            // 
            this.Valor_Total.HeaderText = "Valor Total ";
            this.Valor_Total.Name = "Valor_Total";
            this.Valor_Total.ReadOnly = true;
            this.Valor_Total.Width = 105;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(768, 352);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 134;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timerVerfiicaCampo
            // 
            this.timerVerfiicaCampo.Tick += new System.EventHandler(this.timerVerfiicaCampo_Tick_1);
            // 
            // buttonFecharOs
            // 
            this.buttonFecharOs.Location = new System.Drawing.Point(852, 9);
            this.buttonFecharOs.Name = "buttonFecharOs";
            this.buttonFecharOs.Size = new System.Drawing.Size(26, 26);
            this.buttonFecharOs.TabIndex = 135;
            this.buttonFecharOs.Text = "F";
            this.buttonFecharOs.UseVisualStyleBackColor = true;
            this.buttonFecharOs.Click += new System.EventHandler(this.buttonFecharOs_Click);
            // 
            // checkBoxReajustePrecoVenda
            // 
            this.checkBoxReajustePrecoVenda.AutoSize = true;
            this.checkBoxReajustePrecoVenda.Location = new System.Drawing.Point(12, 399);
            this.checkBoxReajustePrecoVenda.Name = "checkBoxReajustePrecoVenda";
            this.checkBoxReajustePrecoVenda.Size = new System.Drawing.Size(149, 17);
            this.checkBoxReajustePrecoVenda.TabIndex = 136;
            this.checkBoxReajustePrecoVenda.Text = "Reajustar preço de venda";
            this.checkBoxReajustePrecoVenda.UseVisualStyleBackColor = true;
            // 
            // checkBoxImprimiretiquetas
            // 
            this.checkBoxImprimiretiquetas.AutoSize = true;
            this.checkBoxImprimiretiquetas.Location = new System.Drawing.Point(12, 421);
            this.checkBoxImprimiretiquetas.Name = "checkBoxImprimiretiquetas";
            this.checkBoxImprimiretiquetas.Size = new System.Drawing.Size(107, 17);
            this.checkBoxImprimiretiquetas.TabIndex = 137;
            this.checkBoxImprimiretiquetas.Text = "Imprimir etiquetas";
            this.checkBoxImprimiretiquetas.UseVisualStyleBackColor = true;
            // 
            // FormEntradaNoEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 445);
            this.ControlBox = false;
            this.Controls.Add(this.checkBoxImprimiretiquetas);
            this.Controls.Add(this.checkBoxReajustePrecoVenda);
            this.Controls.Add(this.buttonFecharOs);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridViewEstoque);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtDesconto);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtIcms);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtValorFrete);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.comboBoxCFOP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.txtNumeroNota);
            this.Controls.Add(this.comboBoxTipoEntrada);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePickerEntradaNota);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormEntradaNoEstoque";
            this.Text = "Entrada No Estoque - Os campos em \" *\" são  obrigatórios!";
            this.Load += new System.EventHandler(this.FormEntradaNoEstoque_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FormEntradaNoEstoque_KeyPress);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFornecedores)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEstoque)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePickerEntradaNota;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxTipoEntrada;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtNumeroNota;
        private System.Windows.Forms.ComboBox comboBoxCFOP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxFornecedor;
        private System.Windows.Forms.Label Nome;
        private System.Windows.Forms.CheckBox checkBoxSituacao;
        private System.Windows.Forms.DataGridView dataGridViewFornecedores;
        private System.Windows.Forms.TextBox txtConsultarFornecedor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtValorFrete;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtIcms;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDesconto;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox checkBoxLancarContasPagar;
        private System.Windows.Forms.DataGridView dataGridViewEstoque;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timerVerfiicaCampo;
        private System.Windows.Forms.Button buttonFecharOs;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOME1;
        private System.Windows.Forms.DataGridViewTextBoxColumn INFORMACAO;
        private System.Windows.Forms.DataGridViewTextBoxColumn Linha_Usada;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Produto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn Produto_Pesquisa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor_Unitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor_Total;
        private System.Windows.Forms.CheckBox checkBoxReajustePrecoVenda;
        private System.Windows.Forms.CheckBox checkBoxImprimiretiquetas;
    }
}