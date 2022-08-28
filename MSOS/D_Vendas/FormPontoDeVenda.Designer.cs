namespace DateSystem
{
    partial class FormPontoDeVenda
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dateTimePickerSaida = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButtonOutros = new System.Windows.Forms.RadioButton();
            this.radioButtonOrcamento = new System.Windows.Forms.RadioButton();
            this.radioButtonVenda = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonLerOrcamento = new System.Windows.Forms.Button();
            this.buttonSair = new System.Windows.Forms.Button();
            this.buttonFechar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridViewPontoDeVenda = new System.Windows.Forms.DataGridView();
            this.Linha_Usada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id_Produto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Produto_Pesquisa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor_Unitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor_Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.buttonNovoCliente = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCodigoCliente = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtPercentual = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.radioButtonDesconto = new System.Windows.Forms.RadioButton();
            this.radioButtonAcrescimo = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.listBoxRecebimento = new System.Windows.Forms.ListBox();
            this.comboBoxVendedor = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.radioButtonAPrazoComEntrada = new System.Windows.Forms.RadioButton();
            this.radioButtonAPrazoSemEntrada = new System.Windows.Forms.RadioButton();
            this.radioButtonAvista = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txtNDoComprovante = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.checkBoxImprmirComprovante = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtValorTotalPV = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.txtNotaFiscalSerie = new System.Windows.Forms.TextBox();
            this.txtNotaFiscalNumero = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPontoDeVenda)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateTimePickerSaida
            // 
            this.dateTimePickerSaida.Enabled = false;
            this.dateTimePickerSaida.Location = new System.Drawing.Point(12, 36);
            this.dateTimePickerSaida.Name = "dateTimePickerSaida";
            this.dateTimePickerSaida.Size = new System.Drawing.Size(149, 20);
            this.dateTimePickerSaida.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Data da Saída";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.radioButtonOutros);
            this.panel1.Controls.Add(this.radioButtonOrcamento);
            this.panel1.Controls.Add(this.radioButtonVenda);
            this.panel1.Location = new System.Drawing.Point(167, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(223, 44);
            this.panel1.TabIndex = 15;
            // 
            // radioButtonOutros
            // 
            this.radioButtonOutros.AutoSize = true;
            this.radioButtonOutros.Location = new System.Drawing.Point(154, 20);
            this.radioButtonOutros.Name = "radioButtonOutros";
            this.radioButtonOutros.Size = new System.Drawing.Size(56, 17);
            this.radioButtonOutros.TabIndex = 2;
            this.radioButtonOutros.Text = "Outros";
            this.radioButtonOutros.UseVisualStyleBackColor = true;
            // 
            // radioButtonOrcamento
            // 
            this.radioButtonOrcamento.AutoSize = true;
            this.radioButtonOrcamento.Location = new System.Drawing.Point(71, 20);
            this.radioButtonOrcamento.Name = "radioButtonOrcamento";
            this.radioButtonOrcamento.Size = new System.Drawing.Size(77, 17);
            this.radioButtonOrcamento.TabIndex = 1;
            this.radioButtonOrcamento.Text = "Orçamento";
            this.radioButtonOrcamento.UseVisualStyleBackColor = true;
            // 
            // radioButtonVenda
            // 
            this.radioButtonVenda.AutoSize = true;
            this.radioButtonVenda.Checked = true;
            this.radioButtonVenda.Location = new System.Drawing.Point(9, 20);
            this.radioButtonVenda.Name = "radioButtonVenda";
            this.radioButtonVenda.Size = new System.Drawing.Size(56, 17);
            this.radioButtonVenda.TabIndex = 0;
            this.radioButtonVenda.TabStop = true;
            this.radioButtonVenda.Text = "Venda";
            this.radioButtonVenda.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(176, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Tipo de Saída";
            // 
            // buttonLerOrcamento
            // 
            this.buttonLerOrcamento.Location = new System.Drawing.Point(397, 36);
            this.buttonLerOrcamento.Name = "buttonLerOrcamento";
            this.buttonLerOrcamento.Size = new System.Drawing.Size(89, 23);
            this.buttonLerOrcamento.TabIndex = 17;
            this.buttonLerOrcamento.Text = "Ler Orçamento";
            this.buttonLerOrcamento.UseVisualStyleBackColor = true;
            // 
            // buttonSair
            // 
            this.buttonSair.Location = new System.Drawing.Point(492, 36);
            this.buttonSair.Name = "buttonSair";
            this.buttonSair.Size = new System.Drawing.Size(64, 24);
            this.buttonSair.TabIndex = 18;
            this.buttonSair.Text = "S";
            this.buttonSair.UseVisualStyleBackColor = true;
            // 
            // buttonFechar
            // 
            this.buttonFechar.Location = new System.Drawing.Point(562, 35);
            this.buttonFechar.Name = "buttonFechar";
            this.buttonFechar.Size = new System.Drawing.Size(64, 24);
            this.buttonFechar.TabIndex = 19;
            this.buttonFechar.Text = "F";
            this.buttonFechar.UseVisualStyleBackColor = true;
            this.buttonFechar.Click += new System.EventHandler(this.buttonFechar_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.dataGridViewPontoDeVenda);
            this.panel2.Location = new System.Drawing.Point(12, 62);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(854, 307);
            this.panel2.TabIndex = 20;
            // 
            // dataGridViewPontoDeVenda
            // 
            this.dataGridViewPontoDeVenda.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewPontoDeVenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewPontoDeVenda.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Linha_Usada,
            this.Id_Produto,
            this.Quantidade,
            this.Produto_Pesquisa,
            this.Valor_Unitario,
            this.Valor_Total});
            this.dataGridViewPontoDeVenda.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewPontoDeVenda.Name = "dataGridViewPontoDeVenda";
            this.dataGridViewPontoDeVenda.Size = new System.Drawing.Size(844, 297);
            this.dataGridViewPontoDeVenda.TabIndex = 2;
            this.dataGridViewPontoDeVenda.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPontoDeVenda_CellDoubleClick);
            this.dataGridViewPontoDeVenda.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridViewPontoDeVenda_CellFormatting);
            this.dataGridViewPontoDeVenda.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dataGridViewPontoDeVenda_EditingControlShowing);
            this.dataGridViewPontoDeVenda.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridViewPontoDeVenda_KeyDown);
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
            dataGridViewCellStyle5.NullValue = null;
            this.Valor_Unitario.DefaultCellStyle = dataGridViewCellStyle5;
            this.Valor_Unitario.HeaderText = "Valor Unitario";
            this.Valor_Unitario.Name = "Valor_Unitario";
            this.Valor_Unitario.Width = 110;
            // 
            // Valor_Total
            // 
            this.Valor_Total.HeaderText = "Valor Total ";
            this.Valor_Total.Name = "Valor_Total";
            this.Valor_Total.ReadOnly = true;
            this.Valor_Total.Width = 110;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.buttonNovoCliente);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.txtCodigoCliente);
            this.panel3.Controls.Add(this.comboBox1);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(12, 377);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(518, 64);
            this.panel3.TabIndex = 21;
            // 
            // buttonNovoCliente
            // 
            this.buttonNovoCliente.Location = new System.Drawing.Point(285, 6);
            this.buttonNovoCliente.Name = "buttonNovoCliente";
            this.buttonNovoCliente.Size = new System.Drawing.Size(76, 24);
            this.buttonNovoCliente.TabIndex = 23;
            this.buttonNovoCliente.Text = "Novo";
            this.buttonNovoCliente.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(368, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Código";
            // 
            // txtCodigoCliente
            // 
            this.txtCodigoCliente.Enabled = false;
            this.txtCodigoCliente.Location = new System.Drawing.Point(367, 30);
            this.txtCodigoCliente.Name = "txtCodigoCliente";
            this.txtCodigoCliente.Size = new System.Drawing.Size(137, 20);
            this.txtCodigoCliente.TabIndex = 25;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(11, 33);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(350, 21);
            this.comboBox1.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Nome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 374);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Cliente";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.txtPercentual);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.radioButtonDesconto);
            this.panel4.Controls.Add(this.radioButtonAcrescimo);
            this.panel4.Location = new System.Drawing.Point(536, 377);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 64);
            this.panel4.TabIndex = 23;
            // 
            // txtPercentual
            // 
            this.txtPercentual.Location = new System.Drawing.Point(72, 35);
            this.txtPercentual.Name = "txtPercentual";
            this.txtPercentual.Size = new System.Drawing.Size(118, 20);
            this.txtPercentual.TabIndex = 26;
            this.txtPercentual.TextChanged += new System.EventHandler(this.txtPercentual_TextChanged);
            this.txtPercentual.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPercentual_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "Percentual";
            // 
            // radioButtonDesconto
            // 
            this.radioButtonDesconto.AutoSize = true;
            this.radioButtonDesconto.Checked = true;
            this.radioButtonDesconto.Location = new System.Drawing.Point(91, 7);
            this.radioButtonDesconto.Name = "radioButtonDesconto";
            this.radioButtonDesconto.Size = new System.Drawing.Size(71, 17);
            this.radioButtonDesconto.TabIndex = 3;
            this.radioButtonDesconto.TabStop = true;
            this.radioButtonDesconto.Text = "Desconto";
            this.radioButtonDesconto.UseVisualStyleBackColor = true;
            // 
            // radioButtonAcrescimo
            // 
            this.radioButtonAcrescimo.AutoSize = true;
            this.radioButtonAcrescimo.Location = new System.Drawing.Point(11, 7);
            this.radioButtonAcrescimo.Name = "radioButtonAcrescimo";
            this.radioButtonAcrescimo.Size = new System.Drawing.Size(74, 17);
            this.radioButtonAcrescimo.TabIndex = 2;
            this.radioButtonAcrescimo.Text = "Acréscimo";
            this.radioButtonAcrescimo.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 445);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "Recebimento";
            // 
            // listBoxRecebimento
            // 
            this.listBoxRecebimento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBoxRecebimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxRecebimento.FormattingEnabled = true;
            this.listBoxRecebimento.ItemHeight = 16;
            this.listBoxRecebimento.Items.AddRange(new object[] {
            "Cheque",
            "Dinheiro",
            "Vale",
            "Combrança Bancária",
            "Cartão",
            "A prazo"});
            this.listBoxRecebimento.Location = new System.Drawing.Point(15, 467);
            this.listBoxRecebimento.Name = "listBoxRecebimento";
            this.listBoxRecebimento.Size = new System.Drawing.Size(133, 98);
            this.listBoxRecebimento.TabIndex = 25;
            // 
            // comboBoxVendedor
            // 
            this.comboBoxVendedor.FormattingEnabled = true;
            this.comboBoxVendedor.Location = new System.Drawing.Point(157, 467);
            this.comboBoxVendedor.Name = "comboBoxVendedor";
            this.comboBoxVendedor.Size = new System.Drawing.Size(349, 21);
            this.comboBoxVendedor.TabIndex = 26;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(154, 445);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 27;
            this.label8.Text = "Vendedor";
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.radioButtonAPrazoComEntrada);
            this.panel5.Controls.Add(this.radioButtonAPrazoSemEntrada);
            this.panel5.Controls.Add(this.radioButtonAvista);
            this.panel5.Location = new System.Drawing.Point(157, 502);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(189, 67);
            this.panel5.TabIndex = 28;
            // 
            // radioButtonAPrazoComEntrada
            // 
            this.radioButtonAPrazoComEntrada.AutoSize = true;
            this.radioButtonAPrazoComEntrada.Location = new System.Drawing.Point(9, 45);
            this.radioButtonAPrazoComEntrada.Name = "radioButtonAPrazoComEntrada";
            this.radioButtonAPrazoComEntrada.Size = new System.Drawing.Size(126, 17);
            this.radioButtonAPrazoComEntrada.TabIndex = 2;
            this.radioButtonAPrazoComEntrada.Text = "A Prazo Sem Entrada";
            this.radioButtonAPrazoComEntrada.UseVisualStyleBackColor = true;
            // 
            // radioButtonAPrazoSemEntrada
            // 
            this.radioButtonAPrazoSemEntrada.AutoSize = true;
            this.radioButtonAPrazoSemEntrada.Location = new System.Drawing.Point(9, 26);
            this.radioButtonAPrazoSemEntrada.Name = "radioButtonAPrazoSemEntrada";
            this.radioButtonAPrazoSemEntrada.Size = new System.Drawing.Size(126, 17);
            this.radioButtonAPrazoSemEntrada.TabIndex = 1;
            this.radioButtonAPrazoSemEntrada.Text = "A Prazo Sem Entrada";
            this.radioButtonAPrazoSemEntrada.UseVisualStyleBackColor = true;
            // 
            // radioButtonAvista
            // 
            this.radioButtonAvista.AutoSize = true;
            this.radioButtonAvista.Checked = true;
            this.radioButtonAvista.Location = new System.Drawing.Point(9, 7);
            this.radioButtonAvista.Name = "radioButtonAvista";
            this.radioButtonAvista.Size = new System.Drawing.Size(57, 17);
            this.radioButtonAvista.TabIndex = 0;
            this.radioButtonAvista.TabStop = true;
            this.radioButtonAvista.Text = "A vista";
            this.radioButtonAvista.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(164, 494);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Tipo de venda";
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.txtNDoComprovante);
            this.panel6.Controls.Add(this.label11);
            this.panel6.Controls.Add(this.checkBoxImprmirComprovante);
            this.panel6.Location = new System.Drawing.Point(352, 502);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(189, 67);
            this.panel6.TabIndex = 29;
            // 
            // txtNDoComprovante
            // 
            this.txtNDoComprovante.Location = new System.Drawing.Point(10, 22);
            this.txtNDoComprovante.Name = "txtNDoComprovante";
            this.txtNDoComprovante.Size = new System.Drawing.Size(174, 20);
            this.txtNDoComprovante.TabIndex = 32;
            this.txtNDoComprovante.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNDoComprovante_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(10, 7);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 13);
            this.label11.TabIndex = 31;
            this.label11.Text = "N° do Pedido";
            // 
            // checkBoxImprmirComprovante
            // 
            this.checkBoxImprmirComprovante.AutoSize = true;
            this.checkBoxImprmirComprovante.Location = new System.Drawing.Point(10, 47);
            this.checkBoxImprmirComprovante.Name = "checkBoxImprmirComprovante";
            this.checkBoxImprmirComprovante.Size = new System.Drawing.Size(59, 17);
            this.checkBoxImprmirComprovante.TabIndex = 1;
            this.checkBoxImprmirComprovante.Text = "Imprmir";
            this.checkBoxImprmirComprovante.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(363, 495);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 13);
            this.label10.TabIndex = 30;
            this.label10.Text = "Comprovante";
            // 
            // txtValorTotalPV
            // 
            this.txtValorTotalPV.Location = new System.Drawing.Point(583, 467);
            this.txtValorTotalPV.Name = "txtValorTotalPV";
            this.txtValorTotalPV.Size = new System.Drawing.Size(153, 20);
            this.txtValorTotalPV.TabIndex = 33;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(523, 470);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(54, 13);
            this.label12.TabIndex = 34;
            this.label12.Text = "Valor total";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(558, 495);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(60, 13);
            this.label13.TabIndex = 36;
            this.label13.Text = "Nota Fiscal";
            // 
            // panel7
            // 
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.label15);
            this.panel7.Controls.Add(this.txtNotaFiscalSerie);
            this.panel7.Controls.Add(this.txtNotaFiscalNumero);
            this.panel7.Controls.Add(this.label14);
            this.panel7.Controls.Add(this.checkBox1);
            this.panel7.Location = new System.Drawing.Point(547, 502);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(189, 67);
            this.panel7.TabIndex = 35;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(136, 6);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(31, 13);
            this.label15.TabIndex = 34;
            this.label15.Text = "Série";
            // 
            // txtNotaFiscalSerie
            // 
            this.txtNotaFiscalSerie.Location = new System.Drawing.Point(139, 22);
            this.txtNotaFiscalSerie.Name = "txtNotaFiscalSerie";
            this.txtNotaFiscalSerie.Size = new System.Drawing.Size(45, 20);
            this.txtNotaFiscalSerie.TabIndex = 33;
            this.txtNotaFiscalSerie.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNotaFiscalSerie_KeyPress);
            // 
            // txtNotaFiscalNumero
            // 
            this.txtNotaFiscalNumero.Location = new System.Drawing.Point(10, 22);
            this.txtNotaFiscalNumero.Name = "txtNotaFiscalNumero";
            this.txtNotaFiscalNumero.Size = new System.Drawing.Size(123, 20);
            this.txtNotaFiscalNumero.TabIndex = 32;
            this.txtNotaFiscalNumero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNotaFiscalNumero_KeyPress);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(10, 7);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(44, 13);
            this.label14.TabIndex = 31;
            this.label14.Text = "Número";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(10, 47);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(59, 17);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.Text = "Imprmir";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(784, 578);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 37;
            this.button1.Text = "buttonTESTE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormPontoDeVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 621);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtValorTotalPV);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.comboBoxVendedor);
            this.Controls.Add(this.listBoxRecebimento);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.buttonFechar);
            this.Controls.Add(this.buttonSair);
            this.Controls.Add(this.buttonLerOrcamento);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePickerSaida);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormPontoDeVenda";
            this.Text = "Ponto De Venda";
            this.Load += new System.EventHandler(this.FormPontoDeVenda_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FormPontoDeVenda_KeyPress);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPontoDeVenda)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePickerSaida;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioButtonOutros;
        private System.Windows.Forms.RadioButton radioButtonOrcamento;
        private System.Windows.Forms.RadioButton radioButtonVenda;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonLerOrcamento;
        private System.Windows.Forms.Button buttonSair;
        private System.Windows.Forms.Button buttonFechar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridViewPontoDeVenda;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button buttonNovoCliente;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCodigoCliente;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtPercentual;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton radioButtonDesconto;
        private System.Windows.Forms.RadioButton radioButtonAcrescimo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Linha_Usada;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Produto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn Produto_Pesquisa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor_Unitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor_Total;
        private System.Windows.Forms.ListBox listBoxRecebimento;
        private System.Windows.Forms.ComboBox comboBoxVendedor;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.RadioButton radioButtonAPrazoComEntrada;
        private System.Windows.Forms.RadioButton radioButtonAPrazoSemEntrada;
        private System.Windows.Forms.RadioButton radioButtonAvista;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox txtNDoComprovante;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox checkBoxImprmirComprovante;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtValorTotalPV;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtNotaFiscalSerie;
        private System.Windows.Forms.TextBox txtNotaFiscalNumero;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button1;
    }
}