namespace DateSystem
{
    partial class FormPesquisaLoginUsuario
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
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBoxSituacao = new System.Windows.Forms.CheckBox();
            this.buttonCancelarOs = new System.Windows.Forms.Button();
            this.buttonFecharOs = new System.Windows.Forms.Button();
            this.radioButtonTodos = new System.Windows.Forms.RadioButton();
            this.dataGridViewPesquisa = new System.Windows.Forms.DataGridView();
            this.buttonFuncionarioPesquisa = new System.Windows.Forms.Button();
            this.txtPesquisaUsuario = new System.Windows.Forms.TextBox();
            this.radioButtonPesquisaUsuario = new System.Windows.Forms.RadioButton();
            this.radioButtonRazaoSocial1 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.ID_ACESSO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPesquisa)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(522, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(13, 13);
            this.label8.TabIndex = 167;
            this.label8.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(534, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 166;
            this.label2.Text = ":Fornecedores";
            // 
            // checkBoxSituacao
            // 
            this.checkBoxSituacao.AutoSize = true;
            this.checkBoxSituacao.Checked = true;
            this.checkBoxSituacao.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxSituacao.Location = new System.Drawing.Point(516, 5);
            this.checkBoxSituacao.Name = "checkBoxSituacao";
            this.checkBoxSituacao.Size = new System.Drawing.Size(92, 17);
            this.checkBoxSituacao.TabIndex = 165;
            this.checkBoxSituacao.Text = ":Usuário Ativo";
            this.checkBoxSituacao.UseVisualStyleBackColor = true;
            // 
            // buttonCancelarOs
            // 
            this.buttonCancelarOs.Location = new System.Drawing.Point(615, 47);
            this.buttonCancelarOs.Name = "buttonCancelarOs";
            this.buttonCancelarOs.Size = new System.Drawing.Size(26, 26);
            this.buttonCancelarOs.TabIndex = 164;
            this.buttonCancelarOs.Text = "C";
            this.buttonCancelarOs.UseVisualStyleBackColor = true;
            this.buttonCancelarOs.Click += new System.EventHandler(this.buttonCancelarOs_Click);
            // 
            // buttonFecharOs
            // 
            this.buttonFecharOs.Location = new System.Drawing.Point(615, 79);
            this.buttonFecharOs.Name = "buttonFecharOs";
            this.buttonFecharOs.Size = new System.Drawing.Size(26, 26);
            this.buttonFecharOs.TabIndex = 163;
            this.buttonFecharOs.Text = "F";
            this.buttonFecharOs.UseVisualStyleBackColor = true;
            this.buttonFecharOs.Click += new System.EventHandler(this.buttonFecharOs_Click);
            // 
            // radioButtonTodos
            // 
            this.radioButtonTodos.AutoSize = true;
            this.radioButtonTodos.Location = new System.Drawing.Point(110, 8);
            this.radioButtonTodos.Name = "radioButtonTodos";
            this.radioButtonTodos.Size = new System.Drawing.Size(63, 17);
            this.radioButtonTodos.TabIndex = 162;
            this.radioButtonTodos.Text = "TODOS";
            this.radioButtonTodos.UseVisualStyleBackColor = true;
            this.radioButtonTodos.CheckedChanged += new System.EventHandler(this.radioButtonTodos_CheckedChanged);
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
            this.ID_ACESSO,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridViewPesquisa.Cursor = System.Windows.Forms.Cursors.Default;
            this.dataGridViewPesquisa.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewPesquisa.Location = new System.Drawing.Point(12, 47);
            this.dataGridViewPesquisa.MultiSelect = false;
            this.dataGridViewPesquisa.Name = "dataGridViewPesquisa";
            this.dataGridViewPesquisa.RowHeadersVisible = false;
            this.dataGridViewPesquisa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewPesquisa.Size = new System.Drawing.Size(596, 321);
            this.dataGridViewPesquisa.TabIndex = 161;
            this.dataGridViewPesquisa.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPesquisa_CellDoubleClick);
            // 
            // buttonFuncionarioPesquisa
            // 
            this.buttonFuncionarioPesquisa.Location = new System.Drawing.Point(462, 5);
            this.buttonFuncionarioPesquisa.Name = "buttonFuncionarioPesquisa";
            this.buttonFuncionarioPesquisa.Size = new System.Drawing.Size(48, 23);
            this.buttonFuncionarioPesquisa.TabIndex = 160;
            this.buttonFuncionarioPesquisa.Text = "Busca";
            this.buttonFuncionarioPesquisa.UseVisualStyleBackColor = true;
            this.buttonFuncionarioPesquisa.Click += new System.EventHandler(this.buttonFuncionarioPesquisa_Click);
            // 
            // txtPesquisaUsuario
            // 
            this.txtPesquisaUsuario.Enabled = false;
            this.txtPesquisaUsuario.Location = new System.Drawing.Point(326, 7);
            this.txtPesquisaUsuario.Name = "txtPesquisaUsuario";
            this.txtPesquisaUsuario.Size = new System.Drawing.Size(130, 20);
            this.txtPesquisaUsuario.TabIndex = 159;
            this.txtPesquisaUsuario.TextChanged += new System.EventHandler(this.txtPesquisaUsuario_TextChanged);
            // 
            // radioButtonPesquisaUsuario
            // 
            this.radioButtonPesquisaUsuario.AutoSize = true;
            this.radioButtonPesquisaUsuario.Location = new System.Drawing.Point(179, 8);
            this.radioButtonPesquisaUsuario.Name = "radioButtonPesquisaUsuario";
            this.radioButtonPesquisaUsuario.Size = new System.Drawing.Size(141, 17);
            this.radioButtonPesquisaUsuario.TabIndex = 158;
            this.radioButtonPesquisaUsuario.Text = "USUÁRIO DE ACESSO:";
            this.radioButtonPesquisaUsuario.UseVisualStyleBackColor = true;
            this.radioButtonPesquisaUsuario.CheckedChanged += new System.EventHandler(this.radioButtonPesquisaFuncionario_CheckedChanged);
            // 
            // radioButtonRazaoSocial1
            // 
            this.radioButtonRazaoSocial1.AutoSize = true;
            this.radioButtonRazaoSocial1.Location = new System.Drawing.Point(85, 374);
            this.radioButtonRazaoSocial1.Name = "radioButtonRazaoSocial1";
            this.radioButtonRazaoSocial1.Size = new System.Drawing.Size(144, 17);
            this.radioButtonRazaoSocial1.TabIndex = 157;
            this.radioButtonRazaoSocial1.Text = "RAZÃO SOCIAL(NOME):";
            this.radioButtonRazaoSocial1.UseVisualStyleBackColor = true;
            this.radioButtonRazaoSocial1.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 156;
            this.label1.Text = "Pesquisa Usuário:";
            // 
            // ID_ACESSO
            // 
            this.ID_ACESSO.DataPropertyName = "ID_ACESSO";
            this.ID_ACESSO.HeaderText = "ID_ACESSO";
            this.ID_ACESSO.Name = "ID_ACESSO";
            this.ID_ACESSO.Visible = false;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "NOME";
            this.Column1.HeaderText = "NOME";
            this.Column1.Name = "Column1";
            this.Column1.Width = 195;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "ABREVIACAO";
            this.Column2.HeaderText = "ABREVIACAO";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "USUARIO";
            this.Column3.HeaderText = "USUARIO";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "OBSERVACAO";
            this.Column4.HeaderText = "OBSERVACAO";
            this.Column4.Name = "Column4";
            this.Column4.Width = 200;
            // 
            // FormPesquisaLoginUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 397);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.checkBoxSituacao);
            this.Controls.Add(this.buttonCancelarOs);
            this.Controls.Add(this.buttonFecharOs);
            this.Controls.Add(this.radioButtonTodos);
            this.Controls.Add(this.dataGridViewPesquisa);
            this.Controls.Add(this.buttonFuncionarioPesquisa);
            this.Controls.Add(this.txtPesquisaUsuario);
            this.Controls.Add(this.radioButtonPesquisaUsuario);
            this.Controls.Add(this.radioButtonRazaoSocial1);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormPesquisaLoginUsuario";
            this.Text = "Pesquisa Login e Usuário";
            this.Load += new System.EventHandler(this.FormPesquisaLoginUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPesquisa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBoxSituacao;
        private System.Windows.Forms.Button buttonCancelarOs;
        private System.Windows.Forms.Button buttonFecharOs;
        private System.Windows.Forms.RadioButton radioButtonTodos;
        private System.Windows.Forms.DataGridView dataGridViewPesquisa;
        private System.Windows.Forms.Button buttonFuncionarioPesquisa;
        private System.Windows.Forms.TextBox txtPesquisaUsuario;
        private System.Windows.Forms.RadioButton radioButtonPesquisaUsuario;
        private System.Windows.Forms.RadioButton radioButtonRazaoSocial1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_ACESSO;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}