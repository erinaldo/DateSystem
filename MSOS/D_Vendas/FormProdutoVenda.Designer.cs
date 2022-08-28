namespace DateSystem
{
    partial class FormProdutoVenda
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelN1 = new System.Windows.Forms.Panel();
            this.txtNumeroVenda = new System.Windows.Forms.TextBox();
            this.dateTimePickerDataEntrega = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePickerDataVenda = new System.Windows.Forms.DateTimePicker();
            this.buttonNovaVenda = new System.Windows.Forms.Button();
            this.dataGridViewProdutoVenda = new System.Windows.Forms.DataGridView();
            this.Linha_Usada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_PRODUTOC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProdutoB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantidade1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor_Unitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor_Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelN2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtDescontoCompras = new System.Windows.Forms.TextBox();
            this.txtResultadoTotal = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTroco = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtValorPago = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDesconto = new System.Windows.Forms.TextBox();
            this.comboBoxModoPagamento = new System.Windows.Forms.ComboBox();
            this.txtTotal = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.timerValores = new System.Windows.Forms.Timer(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.mSOSDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panelN1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProdutoVenda)).BeginInit();
            this.panelN2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mSOSDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panelN1
            // 
            this.panelN1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.panelN1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelN1.Controls.Add(this.txtNumeroVenda);
            this.panelN1.Controls.Add(this.dateTimePickerDataEntrega);
            this.panelN1.Controls.Add(this.label2);
            this.panelN1.Controls.Add(this.label1);
            this.panelN1.Controls.Add(this.label3);
            this.panelN1.Controls.Add(this.dateTimePickerDataVenda);
            this.panelN1.Enabled = false;
            this.panelN1.Location = new System.Drawing.Point(271, 8);
            this.panelN1.Name = "panelN1";
            this.panelN1.Size = new System.Drawing.Size(249, 139);
            this.panelN1.TabIndex = 0;
            // 
            // txtNumeroVenda
            // 
            this.txtNumeroVenda.Location = new System.Drawing.Point(119, 7);
            this.txtNumeroVenda.Name = "txtNumeroVenda";
            this.txtNumeroVenda.Size = new System.Drawing.Size(100, 20);
            this.txtNumeroVenda.TabIndex = 1;
            // 
            // dateTimePickerDataEntrega
            // 
            this.dateTimePickerDataEntrega.Location = new System.Drawing.Point(9, 87);
            this.dateTimePickerDataEntrega.Name = "dateTimePickerDataEntrega";
            this.dateTimePickerDataEntrega.Size = new System.Drawing.Size(210, 20);
            this.dateTimePickerDataEntrega.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Data da Entrega:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Data da Venda:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Numero da venda N°";
            // 
            // dateTimePickerDataVenda
            // 
            this.dateTimePickerDataVenda.Location = new System.Drawing.Point(9, 48);
            this.dateTimePickerDataVenda.Name = "dateTimePickerDataVenda";
            this.dateTimePickerDataVenda.Size = new System.Drawing.Size(210, 20);
            this.dateTimePickerDataVenda.TabIndex = 2;
            // 
            // buttonNovaVenda
            // 
            this.buttonNovaVenda.Location = new System.Drawing.Point(12, 537);
            this.buttonNovaVenda.Name = "buttonNovaVenda";
            this.buttonNovaVenda.Size = new System.Drawing.Size(75, 23);
            this.buttonNovaVenda.TabIndex = 1;
            this.buttonNovaVenda.Text = "Nova Venda";
            this.buttonNovaVenda.UseVisualStyleBackColor = true;
            this.buttonNovaVenda.Click += new System.EventHandler(this.buttonNovaVenda_Click);
            // 
            // dataGridViewProdutoVenda
            // 
            this.dataGridViewProdutoVenda.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewProdutoVenda.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridViewProdutoVenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProdutoVenda.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Linha_Usada,
            this.ID_PRODUTOC,
            this.ProdutoB,
            this.Quantidade1,
            this.Valor_Unitario,
            this.Valor_Total});
            this.dataGridViewProdutoVenda.Location = new System.Drawing.Point(12, 157);
            this.dataGridViewProdutoVenda.Name = "dataGridViewProdutoVenda";
            this.dataGridViewProdutoVenda.RowHeadersWidth = 42;
            this.dataGridViewProdutoVenda.Size = new System.Drawing.Size(712, 201);
            this.dataGridViewProdutoVenda.TabIndex = 6;
            this.dataGridViewProdutoVenda.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewProdutoVenda_CellClick);
            this.dataGridViewProdutoVenda.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewProdutoVenda_CellDoubleClick);
            this.dataGridViewProdutoVenda.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridViewProdutoVenda_CellFormatting);
            this.dataGridViewProdutoVenda.ColumnMinimumWidthChanged += new System.Windows.Forms.DataGridViewColumnEventHandler(this.dataGridViewProdutoVenda_ColumnMinimumWidthChanged);
            this.dataGridViewProdutoVenda.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dataGridViewProdutoVenda_EditingControlShowing);
            this.dataGridViewProdutoVenda.Scroll += new System.Windows.Forms.ScrollEventHandler(this.dataGridViewProdutoVenda_Scroll);
            this.dataGridViewProdutoVenda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dataGridViewProdutoVenda_KeyPress);
            // 
            // Linha_Usada
            // 
            this.Linha_Usada.FillWeight = 20F;
            this.Linha_Usada.HeaderText = "Linha_Usada";
            this.Linha_Usada.Name = "Linha_Usada";
            // 
            // ID_PRODUTOC
            // 
            this.ID_PRODUTOC.FillWeight = 20F;
            this.ID_PRODUTOC.HeaderText = "Id Produto";
            this.ID_PRODUTOC.Name = "ID_PRODUTOC";
            // 
            // ProdutoB
            // 
            this.ProdutoB.FillWeight = 76.78825F;
            this.ProdutoB.HeaderText = "Produto";
            this.ProdutoB.Name = "ProdutoB";
            this.ProdutoB.ReadOnly = true;
            // 
            // Quantidade1
            // 
            this.Quantidade1.FillWeight = 27.29268F;
            this.Quantidade1.HeaderText = "Quantidade";
            this.Quantidade1.Name = "Quantidade1";
            // 
            // Valor_Unitario
            // 
            dataGridViewCellStyle1.NullValue = null;
            this.Valor_Unitario.DefaultCellStyle = dataGridViewCellStyle1;
            this.Valor_Unitario.FillWeight = 27.29268F;
            this.Valor_Unitario.HeaderText = "Valor Unitário";
            this.Valor_Unitario.Name = "Valor_Unitario";
            // 
            // Valor_Total
            // 
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = null;
            this.Valor_Total.DefaultCellStyle = dataGridViewCellStyle2;
            this.Valor_Total.FillWeight = 27.29268F;
            this.Valor_Total.HeaderText = "Valor Total";
            this.Valor_Total.Name = "Valor_Total";
            // 
            // panelN2
            // 
            this.panelN2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelN2.Controls.Add(this.panel3);
            this.panelN2.Controls.Add(this.label5);
            this.panelN2.Controls.Add(this.txtDesconto);
            this.panelN2.Controls.Add(this.comboBoxModoPagamento);
            this.panelN2.Enabled = false;
            this.panelN2.Location = new System.Drawing.Point(12, 387);
            this.panelN2.Name = "panelN2";
            this.panelN2.Size = new System.Drawing.Size(593, 123);
            this.panelN2.TabIndex = 7;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.txtDescontoCompras);
            this.panel3.Controls.Add(this.txtResultadoTotal);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.txtTroco);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.txtValorPago);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Location = new System.Drawing.Point(143, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(438, 113);
            this.panel3.TabIndex = 9;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // txtDescontoCompras
            // 
            this.txtDescontoCompras.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtDescontoCompras.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescontoCompras.Enabled = false;
            this.txtDescontoCompras.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescontoCompras.Location = new System.Drawing.Point(176, 39);
            this.txtDescontoCompras.Name = "txtDescontoCompras";
            this.txtDescontoCompras.Size = new System.Drawing.Size(98, 29);
            this.txtDescontoCompras.TabIndex = 19;
            // 
            // txtResultadoTotal
            // 
            this.txtResultadoTotal.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtResultadoTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtResultadoTotal.Enabled = false;
            this.txtResultadoTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResultadoTotal.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtResultadoTotal.Location = new System.Drawing.Point(129, 4);
            this.txtResultadoTotal.Name = "txtResultadoTotal";
            this.txtResultadoTotal.Size = new System.Drawing.Size(98, 29);
            this.txtResultadoTotal.TabIndex = 18;
            this.txtResultadoTotal.TextChanged += new System.EventHandler(this.txtResultadoTotal_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Bell MT", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(3, 42);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(167, 31);
            this.label9.TabIndex = 15;
            this.label9.Text = "Desconto R$";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Bell MT", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(3, 6);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(120, 31);
            this.label8.TabIndex = 14;
            this.label8.Text = "Total R$";
            // 
            // txtTroco
            // 
            this.txtTroco.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtTroco.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTroco.Enabled = false;
            this.txtTroco.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTroco.Location = new System.Drawing.Point(284, 80);
            this.txtTroco.Name = "txtTroco";
            this.txtTroco.Size = new System.Drawing.Size(116, 29);
            this.txtTroco.TabIndex = 12;
            this.txtTroco.TextChanged += new System.EventHandler(this.txtTroco_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(226, 87);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 18);
            this.label7.TabIndex = 13;
            this.label7.Text = "Troco:";
            // 
            // txtValorPago
            // 
            this.txtValorPago.Location = new System.Drawing.Point(87, 88);
            this.txtValorPago.Name = "txtValorPago";
            this.txtValorPago.Size = new System.Drawing.Size(122, 20);
            this.txtValorPago.TabIndex = 10;
            this.txtValorPago.TextChanged += new System.EventHandler(this.txtValorPago_TextChanged);
            this.txtValorPago.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValorPago_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 18);
            this.label6.TabIndex = 11;
            this.label6.Text = "Valor pago:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 18);
            this.label5.TabIndex = 3;
            this.label5.Text = "Desconto %";
            // 
            // txtDesconto
            // 
            this.txtDesconto.Location = new System.Drawing.Point(7, 96);
            this.txtDesconto.Name = "txtDesconto";
            this.txtDesconto.Size = new System.Drawing.Size(100, 20);
            this.txtDesconto.TabIndex = 2;
            this.txtDesconto.TextChanged += new System.EventHandler(this.txtDesconto_TextChanged);
            this.txtDesconto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDesconto_KeyPress);
            // 
            // comboBoxModoPagamento
            // 
            this.comboBoxModoPagamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxModoPagamento.FormattingEnabled = true;
            this.comboBoxModoPagamento.Location = new System.Drawing.Point(7, 17);
            this.comboBoxModoPagamento.Name = "comboBoxModoPagamento";
            this.comboBoxModoPagamento.Size = new System.Drawing.Size(121, 21);
            this.comboBoxModoPagamento.TabIndex = 0;
            this.comboBoxModoPagamento.SelectedIndexChanged += new System.EventHandler(this.comboBoxModoPagamento_SelectedIndexChanged);
            // 
            // txtTotal
            // 
            this.txtTotal.AutoSize = true;
            this.txtTotal.Font = new System.Drawing.Font("Bell MT", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(515, 537);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(80, 31);
            this.txtTotal.TabIndex = 16;
            this.txtTotal.Text = "Total";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 374);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Modo de Pagamento";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(649, 364);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(245, 537);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(122, 20);
            this.textBox1.TabIndex = 11;
            // 
            // timerValores
            // 
            this.timerValores.Interval = 25;
            this.timerValores.Tick += new System.EventHandler(this.timerValores_Tick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(649, 463);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "Calcular";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FormProdutoVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 572);
            this.ControlBox = false;
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panelN2);
            this.Controls.Add(this.dataGridViewProdutoVenda);
            this.Controls.Add(this.buttonNovaVenda);
            this.Controls.Add(this.panelN1);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormProdutoVenda";
            this.Text = "Produtos Venda - Itens para venda";
            this.Load += new System.EventHandler(this.FormProdutoVenda_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FormProdutoVenda_KeyPress);
            this.panelN1.ResumeLayout(false);
            this.panelN1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProdutoVenda)).EndInit();
            this.panelN2.ResumeLayout(false);
            this.panelN2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mSOSDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelN1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonNovaVenda;
        private System.Windows.Forms.DateTimePicker dateTimePickerDataVenda;
        private System.Windows.Forms.DateTimePicker dateTimePickerDataEntrega;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNumeroVenda;
        private System.Windows.Forms.DataGridView dataGridViewProdutoVenda;
        private System.Windows.Forms.Panel panelN2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label txtTotal;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTroco;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtValorPago;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDesconto;
        private System.Windows.Forms.ComboBox comboBoxModoPagamento;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Timer timerValores;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtResultadoTotal;
        private System.Windows.Forms.TextBox txtDescontoCompras;
        private System.Windows.Forms.DataGridViewTextBoxColumn Linha_Usada;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_PRODUTOC;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProdutoB;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantidade1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor_Unitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor_Total;
        private System.Windows.Forms.BindingSource mSOSDataSetBindingSource;
    }
}