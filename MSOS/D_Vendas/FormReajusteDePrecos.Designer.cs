namespace DateSystem
{
    partial class FormReajusteDePrecos
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
            this.panelSelecaoItens = new System.Windows.Forms.Panel();
            this.txtPesquisaItens = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBoxSelecionarTodos = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridViewProdutoVenda = new System.Windows.Forms.DataGridView();
            this.itens = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Produtos_Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonFechar = new System.Windows.Forms.Button();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.panelSelecaoItens.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProdutoVenda)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSelecaoItens
            // 
            this.panelSelecaoItens.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelSelecaoItens.Controls.Add(this.txtPesquisaItens);
            this.panelSelecaoItens.Controls.Add(this.label2);
            this.panelSelecaoItens.Controls.Add(this.checkBoxSelecionarTodos);
            this.panelSelecaoItens.Location = new System.Drawing.Point(12, 13);
            this.panelSelecaoItens.Name = "panelSelecaoItens";
            this.panelSelecaoItens.Size = new System.Drawing.Size(346, 460);
            this.panelSelecaoItens.TabIndex = 0;
            // 
            // txtPesquisaItens
            // 
            this.txtPesquisaItens.Location = new System.Drawing.Point(3, 84);
            this.txtPesquisaItens.Name = "txtPesquisaItens";
            this.txtPesquisaItens.Size = new System.Drawing.Size(338, 20);
            this.txtPesquisaItens.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Pesquisa Manual:";
            // 
            // checkBoxSelecionarTodos
            // 
            this.checkBoxSelecionarTodos.AutoSize = true;
            this.checkBoxSelecionarTodos.Location = new System.Drawing.Point(3, 21);
            this.checkBoxSelecionarTodos.Name = "checkBoxSelecionarTodos";
            this.checkBoxSelecionarTodos.Size = new System.Drawing.Size(105, 17);
            this.checkBoxSelecionarTodos.TabIndex = 2;
            this.checkBoxSelecionarTodos.Text = "Selecionar todos";
            this.checkBoxSelecionarTodos.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Seleção de Ítens";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(364, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Seleção de Ítens";
            // 
            // dataGridViewProdutoVenda
            // 
            this.dataGridViewProdutoVenda.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewProdutoVenda.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridViewProdutoVenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProdutoVenda.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.itens,
            this.numero,
            this.Produtos_Nome});
            this.dataGridViewProdutoVenda.Location = new System.Drawing.Point(367, 19);
            this.dataGridViewProdutoVenda.Name = "dataGridViewProdutoVenda";
            this.dataGridViewProdutoVenda.RowHeadersWidth = 42;
            this.dataGridViewProdutoVenda.Size = new System.Drawing.Size(425, 454);
            this.dataGridViewProdutoVenda.TabIndex = 7;
            // 
            // itens
            // 
            this.itens.FillWeight = 23.90376F;
            this.itens.HeaderText = "Ítens";
            this.itens.Name = "itens";
            // 
            // numero
            // 
            this.numero.FillWeight = 22.84264F;
            this.numero.HeaderText = "N";
            this.numero.Name = "numero";
            // 
            // Produtos_Nome
            // 
            this.Produtos_Nome.FillWeight = 253.2536F;
            this.Produtos_Nome.HeaderText = "Produtos";
            this.Produtos_Nome.Name = "Produtos_Nome";
            // 
            // buttonFechar
            // 
            this.buttonFechar.Location = new System.Drawing.Point(798, 48);
            this.buttonFechar.Name = "buttonFechar";
            this.buttonFechar.Size = new System.Drawing.Size(38, 23);
            this.buttonFechar.TabIndex = 8;
            this.buttonFechar.Text = "F";
            this.buttonFechar.UseVisualStyleBackColor = true;
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Location = new System.Drawing.Point(798, 19);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(38, 23);
            this.buttonSalvar.TabIndex = 9;
            this.buttonSalvar.Text = "S";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            // 
            // FormReajusteDePrecos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 488);
            this.ControlBox = false;
            this.Controls.Add(this.buttonSalvar);
            this.Controls.Add(this.buttonFechar);
            this.Controls.Add(this.dataGridViewProdutoVenda);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelSelecaoItens);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormReajusteDePrecos";
            this.Text = "Reajuste de Preços";
            this.panelSelecaoItens.ResumeLayout(false);
            this.panelSelecaoItens.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProdutoVenda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelSelecaoItens;
        private System.Windows.Forms.TextBox txtPesquisaItens;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBoxSelecionarTodos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridViewProdutoVenda;
        private System.Windows.Forms.DataGridViewTextBoxColumn itens;
        private System.Windows.Forms.DataGridViewTextBoxColumn numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn Produtos_Nome;
        private System.Windows.Forms.Button buttonFechar;
        private System.Windows.Forms.Button buttonSalvar;
    }
}