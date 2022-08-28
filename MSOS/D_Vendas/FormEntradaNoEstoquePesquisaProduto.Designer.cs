namespace DateSystem
{
    partial class FormEntradaNoEstoquePesquisaProduto
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
            this.txtPesquisaProduto = new System.Windows.Forms.TextBox();
            this.dataGridViewProdutoVenda = new System.Windows.Forms.DataGridView();
            this.labelPesquisa = new System.Windows.Forms.Label();
            this.radioButtonPesquisaPorProduto = new System.Windows.Forms.RadioButton();
            this.radioButtonPesquisaPorCodigo = new System.Windows.Forms.RadioButton();
            this.radioButtonPesquisaObservavacao = new System.Windows.Forms.RadioButton();
            this.radioButtonCodigoInterno = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.IdProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescricaoProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeFabricante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecoCusto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustoMedio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecoVenda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuantidadeItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnidadeProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LucroProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UltimoReajuste = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrevisaoChegada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataFoto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProdutoVenda)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPesquisaProduto
            // 
            this.txtPesquisaProduto.Location = new System.Drawing.Point(11, 28);
            this.txtPesquisaProduto.Name = "txtPesquisaProduto";
            this.txtPesquisaProduto.Size = new System.Drawing.Size(700, 20);
            this.txtPesquisaProduto.TabIndex = 0;
            this.txtPesquisaProduto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPesquisaProduto_KeyPress);
            // 
            // dataGridViewProdutoVenda
            // 
            this.dataGridViewProdutoVenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProdutoVenda.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdProduto,
            this.DescricaoProduto,
            this.NomeFabricante,
            this.PrecoCusto,
            this.CustoMedio,
            this.PrecoVenda,
            this.QuantidadeItem,
            this.UnidadeProduto,
            this.LucroProduto,
            this.UltimoReajuste,
            this.PrevisaoChegada,
            this.DataFoto});
            this.dataGridViewProdutoVenda.Location = new System.Drawing.Point(11, 54);
            this.dataGridViewProdutoVenda.Name = "dataGridViewProdutoVenda";
            this.dataGridViewProdutoVenda.Size = new System.Drawing.Size(700, 150);
            this.dataGridViewProdutoVenda.TabIndex = 1;
            this.dataGridViewProdutoVenda.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewProdutoVenda_CellDoubleClick);
            this.dataGridViewProdutoVenda.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridViewProdutoVenda_KeyDown);
            // 
            // labelPesquisa
            // 
            this.labelPesquisa.AutoSize = true;
            this.labelPesquisa.Location = new System.Drawing.Point(12, 9);
            this.labelPesquisa.Name = "labelPesquisa";
            this.labelPesquisa.Size = new System.Drawing.Size(151, 13);
            this.labelPesquisa.TabIndex = 2;
            this.labelPesquisa.Text = "Digite o produto para pesquisa";
            // 
            // radioButtonPesquisaPorProduto
            // 
            this.radioButtonPesquisaPorProduto.AutoSize = true;
            this.radioButtonPesquisaPorProduto.Checked = true;
            this.radioButtonPesquisaPorProduto.Location = new System.Drawing.Point(199, 217);
            this.radioButtonPesquisaPorProduto.Name = "radioButtonPesquisaPorProduto";
            this.radioButtonPesquisaPorProduto.Size = new System.Drawing.Size(126, 17);
            this.radioButtonPesquisaPorProduto.TabIndex = 3;
            this.radioButtonPesquisaPorProduto.TabStop = true;
            this.radioButtonPesquisaPorProduto.Text = "Pesquisa por Produto";
            this.radioButtonPesquisaPorProduto.UseVisualStyleBackColor = true;
            this.radioButtonPesquisaPorProduto.CheckedChanged += new System.EventHandler(this.radioButtonPesquisaPorProduto_CheckedChanged);
            // 
            // radioButtonPesquisaPorCodigo
            // 
            this.radioButtonPesquisaPorCodigo.AutoSize = true;
            this.radioButtonPesquisaPorCodigo.Location = new System.Drawing.Point(199, 253);
            this.radioButtonPesquisaPorCodigo.Name = "radioButtonPesquisaPorCodigo";
            this.radioButtonPesquisaPorCodigo.Size = new System.Drawing.Size(122, 17);
            this.radioButtonPesquisaPorCodigo.TabIndex = 4;
            this.radioButtonPesquisaPorCodigo.Text = "Pesquisa por Código";
            this.radioButtonPesquisaPorCodigo.UseVisualStyleBackColor = true;
            this.radioButtonPesquisaPorCodigo.CheckedChanged += new System.EventHandler(this.radioButtonPesquisaPorCodigo_CheckedChanged);
            // 
            // radioButtonPesquisaObservavacao
            // 
            this.radioButtonPesquisaObservavacao.AutoSize = true;
            this.radioButtonPesquisaObservavacao.Location = new System.Drawing.Point(371, 217);
            this.radioButtonPesquisaObservavacao.Name = "radioButtonPesquisaObservavacao";
            this.radioButtonPesquisaObservavacao.Size = new System.Drawing.Size(88, 17);
            this.radioButtonPesquisaObservavacao.TabIndex = 5;
            this.radioButtonPesquisaObservavacao.Text = "Observações";
            this.radioButtonPesquisaObservavacao.UseVisualStyleBackColor = true;
            this.radioButtonPesquisaObservavacao.CheckedChanged += new System.EventHandler(this.radioButtonPesquisaObservavacao_CheckedChanged);
            // 
            // radioButtonCodigoInterno
            // 
            this.radioButtonCodigoInterno.AutoSize = true;
            this.radioButtonCodigoInterno.Location = new System.Drawing.Point(371, 253);
            this.radioButtonCodigoInterno.Name = "radioButtonCodigoInterno";
            this.radioButtonCodigoInterno.Size = new System.Drawing.Size(93, 17);
            this.radioButtonCodigoInterno.TabIndex = 6;
            this.radioButtonCodigoInterno.Text = "Código interno";
            this.radioButtonCodigoInterno.UseVisualStyleBackColor = true;
            this.radioButtonCodigoInterno.CheckedChanged += new System.EventHandler(this.radioButtonCodigoInterno_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 207);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Produtos :";
            // 
            // IdProduto
            // 
            this.IdProduto.HeaderText = "Código Produto";
            this.IdProduto.Name = "IdProduto";
            this.IdProduto.ReadOnly = true;
            // 
            // DescricaoProduto
            // 
            this.DescricaoProduto.HeaderText = "Produto";
            this.DescricaoProduto.Name = "DescricaoProduto";
            this.DescricaoProduto.ReadOnly = true;
            // 
            // NomeFabricante
            // 
            this.NomeFabricante.HeaderText = "Fabricante";
            this.NomeFabricante.Name = "NomeFabricante";
            // 
            // PrecoCusto
            // 
            this.PrecoCusto.HeaderText = "Preço de Custo";
            this.PrecoCusto.Name = "PrecoCusto";
            // 
            // CustoMedio
            // 
            this.CustoMedio.HeaderText = "Custo médio";
            this.CustoMedio.Name = "CustoMedio";
            // 
            // PrecoVenda
            // 
            this.PrecoVenda.HeaderText = "Preço de venda";
            this.PrecoVenda.Name = "PrecoVenda";
            // 
            // QuantidadeItem
            // 
            this.QuantidadeItem.HeaderText = "Quantidade";
            this.QuantidadeItem.Name = "QuantidadeItem";
            // 
            // UnidadeProduto
            // 
            this.UnidadeProduto.HeaderText = "Unidade";
            this.UnidadeProduto.Name = "UnidadeProduto";
            // 
            // LucroProduto
            // 
            this.LucroProduto.HeaderText = "Lucro";
            this.LucroProduto.Name = "LucroProduto";
            // 
            // UltimoReajuste
            // 
            this.UltimoReajuste.HeaderText = "Último reajuste";
            this.UltimoReajuste.Name = "UltimoReajuste";
            // 
            // PrevisaoChegada
            // 
            this.PrevisaoChegada.HeaderText = "Previsão de Chegada";
            this.PrevisaoChegada.Name = "PrevisaoChegada";
            // 
            // DataFoto
            // 
            this.DataFoto.HeaderText = "Data Foto";
            this.DataFoto.Name = "DataFoto";
            // 
            // FormEntradaNoEstoquePesquisaProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 282);
            this.ControlBox = false;
            this.Controls.Add(this.label8);
            this.Controls.Add(this.radioButtonCodigoInterno);
            this.Controls.Add(this.radioButtonPesquisaObservavacao);
            this.Controls.Add(this.radioButtonPesquisaPorCodigo);
            this.Controls.Add(this.radioButtonPesquisaPorProduto);
            this.Controls.Add(this.labelPesquisa);
            this.Controls.Add(this.dataGridViewProdutoVenda);
            this.Controls.Add(this.txtPesquisaProduto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormEntradaNoEstoquePesquisaProduto";
            this.Text = "Pesquisa Produto de Entrada No Estoque - Os campos em \" *\" são  obrigatórios!";
            this.Load += new System.EventHandler(this.FormEntradaNoEstoquePesquisaProduto_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FormEntradaNoEstoquePesquisaProduto_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProdutoVenda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPesquisaProduto;
        private System.Windows.Forms.DataGridView dataGridViewProdutoVenda;
        private System.Windows.Forms.Label labelPesquisa;
        private System.Windows.Forms.RadioButton radioButtonPesquisaPorProduto;
        private System.Windows.Forms.RadioButton radioButtonPesquisaPorCodigo;
        private System.Windows.Forms.RadioButton radioButtonPesquisaObservavacao;
        private System.Windows.Forms.RadioButton radioButtonCodigoInterno;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescricaoProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeFabricante;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecoCusto;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustoMedio;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecoVenda;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuantidadeItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnidadeProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn LucroProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn UltimoReajuste;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrevisaoChegada;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataFoto;
    }
}