namespace DateSystem
{
    partial class FormAlteracaoStatusRS
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
            this.checkedListBoxStatus = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButtonNumeroCadastro1 = new System.Windows.Forms.RadioButton();
            this.radioButtonNomeCadastro = new System.Windows.Forms.RadioButton();
            this.radioButtonCnpj = new System.Windows.Forms.RadioButton();
            this.txtNumeroCadastro = new System.Windows.Forms.TextBox();
            this.txtNomeCadastro = new System.Windows.Forms.TextBox();
            this.txtCnpj = new System.Windows.Forms.TextBox();
            this.dataGridViewPesquisa = new System.Windows.Forms.DataGridView();
            this.ID_PESSOA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOMECADASTRADO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RAZAO_SOCIAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CNPJ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.radioButtonTodos = new System.Windows.Forms.RadioButton();
            this.buttonBuscaCasdatrado = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.radioButtonNumeroCadastro = new System.Windows.Forms.RadioButton();
            this.buttonSalvaAlteracao = new System.Windows.Forms.Button();
            this.buttonVerificar = new System.Windows.Forms.Button();
            this.panelOS = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMS = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNomeOs = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panelFORNECEDOR = new System.Windows.Forms.Panel();
            this.txtCargoContato = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtNomeContato = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtNumeroVendedor = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.panelVENDEDOR = new System.Windows.Forms.Panel();
            this.panelREGISTRO = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNomeRegistro = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPesquisa)).BeginInit();
            this.panelOS.SuspendLayout();
            this.panelFORNECEDOR.SuspendLayout();
            this.panelVENDEDOR.SuspendLayout();
            this.panelREGISTRO.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkedListBoxStatus
            // 
            this.checkedListBoxStatus.CheckOnClick = true;
            this.checkedListBoxStatus.Enabled = false;
            this.checkedListBoxStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBoxStatus.FormattingEnabled = true;
            this.checkedListBoxStatus.Items.AddRange(new object[] {
            "CLIENTE DE OS",
            "FORNECEDOR",
            "VENDEDOR",
            "REGISTRO"});
            this.checkedListBoxStatus.Location = new System.Drawing.Point(16, 428);
            this.checkedListBoxStatus.Name = "checkedListBoxStatus";
            this.checkedListBoxStatus.Size = new System.Drawing.Size(199, 124);
            this.checkedListBoxStatus.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Buscar Razão Social Cadastrado:";
            // 
            // radioButtonNumeroCadastro1
            // 
            this.radioButtonNumeroCadastro1.AutoSize = true;
            this.radioButtonNumeroCadastro1.Location = new System.Drawing.Point(272, 4);
            this.radioButtonNumeroCadastro1.Name = "radioButtonNumeroCadastro1";
            this.radioButtonNumeroCadastro1.Size = new System.Drawing.Size(156, 17);
            this.radioButtonNumeroCadastro1.TabIndex = 3;
            this.radioButtonNumeroCadastro1.Text = "NÚMERO DE CADASTRO:";
            this.radioButtonNumeroCadastro1.UseVisualStyleBackColor = true;
            this.radioButtonNumeroCadastro1.Visible = false;
            this.radioButtonNumeroCadastro1.CheckedChanged += new System.EventHandler(this.radioButtonNumeroCadastro_CheckedChanged);
            // 
            // radioButtonNomeCadastro
            // 
            this.radioButtonNomeCadastro.AutoSize = true;
            this.radioButtonNomeCadastro.Location = new System.Drawing.Point(351, 38);
            this.radioButtonNomeCadastro.Name = "radioButtonNomeCadastro";
            this.radioButtonNomeCadastro.Size = new System.Drawing.Size(140, 17);
            this.radioButtonNomeCadastro.TabIndex = 4;
            this.radioButtonNomeCadastro.Text = "NOME DE CADASTRO:";
            this.radioButtonNomeCadastro.UseVisualStyleBackColor = true;
            this.radioButtonNomeCadastro.CheckedChanged += new System.EventHandler(this.radioButtonNomeCadastro_CheckedChanged);
            // 
            // radioButtonCnpj
            // 
            this.radioButtonCnpj.AutoSize = true;
            this.radioButtonCnpj.Location = new System.Drawing.Point(825, 39);
            this.radioButtonCnpj.Name = "radioButtonCnpj";
            this.radioButtonCnpj.Size = new System.Drawing.Size(55, 17);
            this.radioButtonCnpj.TabIndex = 5;
            this.radioButtonCnpj.Text = "CNPJ:";
            this.radioButtonCnpj.UseVisualStyleBackColor = true;
            this.radioButtonCnpj.CheckedChanged += new System.EventHandler(this.radioButtonCnpj_CheckedChanged);
            // 
            // txtNumeroCadastro
            // 
            this.txtNumeroCadastro.Enabled = false;
            this.txtNumeroCadastro.Location = new System.Drawing.Point(245, 37);
            this.txtNumeroCadastro.Name = "txtNumeroCadastro";
            this.txtNumeroCadastro.Size = new System.Drawing.Size(100, 20);
            this.txtNumeroCadastro.TabIndex = 6;
            this.txtNumeroCadastro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumeroCadastro_KeyPress);
            // 
            // txtNomeCadastro
            // 
            this.txtNomeCadastro.Enabled = false;
            this.txtNomeCadastro.Location = new System.Drawing.Point(497, 38);
            this.txtNomeCadastro.Name = "txtNomeCadastro";
            this.txtNomeCadastro.Size = new System.Drawing.Size(312, 20);
            this.txtNomeCadastro.TabIndex = 7;
            this.txtNomeCadastro.TextChanged += new System.EventHandler(this.txtNomeCadastro_TextChanged);
            this.txtNomeCadastro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNomeCadastro_KeyPress);
            // 
            // txtCnpj
            // 
            this.txtCnpj.Enabled = false;
            this.txtCnpj.Location = new System.Drawing.Point(886, 38);
            this.txtCnpj.Name = "txtCnpj";
            this.txtCnpj.Size = new System.Drawing.Size(146, 20);
            this.txtCnpj.TabIndex = 8;
            this.txtCnpj.TextChanged += new System.EventHandler(this.txtCnpj_TextChanged);
            this.txtCnpj.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCnpj_KeyPress);
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
            this.ID_PESSOA,
            this.NOMECADASTRADO,
            this.RAZAO_SOCIAL,
            this.CNPJ});
            this.dataGridViewPesquisa.Cursor = System.Windows.Forms.Cursors.Default;
            this.dataGridViewPesquisa.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewPesquisa.Location = new System.Drawing.Point(15, 61);
            this.dataGridViewPesquisa.MultiSelect = false;
            this.dataGridViewPesquisa.Name = "dataGridViewPesquisa";
            this.dataGridViewPesquisa.RowHeadersVisible = false;
            this.dataGridViewPesquisa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewPesquisa.Size = new System.Drawing.Size(1017, 303);
            this.dataGridViewPesquisa.TabIndex = 97;
            this.dataGridViewPesquisa.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPesquisa_CellDoubleClick);
            // 
            // ID_PESSOA
            // 
            this.ID_PESSOA.DataPropertyName = "ID_PESSOA";
            this.ID_PESSOA.HeaderText = "ID_PESSOA";
            this.ID_PESSOA.Name = "ID_PESSOA";
            // 
            // NOMECADASTRADO
            // 
            this.NOMECADASTRADO.DataPropertyName = "NOMECADASTRADO";
            this.NOMECADASTRADO.HeaderText = "NOME DE CADASTRADO";
            this.NOMECADASTRADO.Name = "NOMECADASTRADO";
            this.NOMECADASTRADO.Width = 350;
            // 
            // RAZAO_SOCIAL
            // 
            this.RAZAO_SOCIAL.DataPropertyName = "RAZAO_SOCIAL";
            this.RAZAO_SOCIAL.HeaderText = "RAZAO SOCIAL";
            this.RAZAO_SOCIAL.Name = "RAZAO_SOCIAL";
            this.RAZAO_SOCIAL.Width = 450;
            // 
            // CNPJ
            // 
            this.CNPJ.DataPropertyName = "CNPJ";
            this.CNPJ.HeaderText = "CNPJ";
            this.CNPJ.Name = "CNPJ";
            this.CNPJ.Width = 110;
            // 
            // radioButtonTodos
            // 
            this.radioButtonTodos.AutoSize = true;
            this.radioButtonTodos.Checked = true;
            this.radioButtonTodos.Location = new System.Drawing.Point(15, 37);
            this.radioButtonTodos.Name = "radioButtonTodos";
            this.radioButtonTodos.Size = new System.Drawing.Size(66, 17);
            this.radioButtonTodos.TabIndex = 98;
            this.radioButtonTodos.TabStop = true;
            this.radioButtonTodos.Text = "TODOS:";
            this.radioButtonTodos.UseVisualStyleBackColor = true;
            this.radioButtonTodos.CheckedChanged += new System.EventHandler(this.radioButtonTodos_CheckedChanged);
            // 
            // buttonBuscaCasdatrado
            // 
            this.buttonBuscaCasdatrado.Location = new System.Drawing.Point(497, 4);
            this.buttonBuscaCasdatrado.Name = "buttonBuscaCasdatrado";
            this.buttonBuscaCasdatrado.Size = new System.Drawing.Size(115, 23);
            this.buttonBuscaCasdatrado.TabIndex = 99;
            this.buttonBuscaCasdatrado.Text = "Busca Razão Social";
            this.buttonBuscaCasdatrado.UseVisualStyleBackColor = true;
            this.buttonBuscaCasdatrado.Click += new System.EventHandler(this.buttonBuscaCasdatrado_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(863, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 13);
            this.label2.TabIndex = 100;
            this.label2.Text = "Quantidade de Cadastrado:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 375);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(206, 21);
            this.label3.TabIndex = 101;
            this.label3.Text = "Razão Social Selecionada:";
            // 
            // radioButtonNumeroCadastro
            // 
            this.radioButtonNumeroCadastro.AutoSize = true;
            this.radioButtonNumeroCadastro.Location = new System.Drawing.Point(83, 37);
            this.radioButtonNumeroCadastro.Name = "radioButtonNumeroCadastro";
            this.radioButtonNumeroCadastro.Size = new System.Drawing.Size(156, 17);
            this.radioButtonNumeroCadastro.TabIndex = 103;
            this.radioButtonNumeroCadastro.Text = "NÚMERO DE CADASTRO:";
            this.radioButtonNumeroCadastro.UseVisualStyleBackColor = true;
            this.radioButtonNumeroCadastro.CheckedChanged += new System.EventHandler(this.radioButtonNumeroCadastro_CheckedChanged_1);
            // 
            // buttonSalvaAlteracao
            // 
            this.buttonSalvaAlteracao.Enabled = false;
            this.buttonSalvaAlteracao.Location = new System.Drawing.Point(1003, 370);
            this.buttonSalvaAlteracao.Name = "buttonSalvaAlteracao";
            this.buttonSalvaAlteracao.Size = new System.Drawing.Size(26, 26);
            this.buttonSalvaAlteracao.TabIndex = 104;
            this.buttonSalvaAlteracao.Text = "S";
            this.buttonSalvaAlteracao.UseVisualStyleBackColor = true;
            this.buttonSalvaAlteracao.Click += new System.EventHandler(this.buttonSalvaAlteracao_Click);
            // 
            // buttonVerificar
            // 
            this.buttonVerificar.Location = new System.Drawing.Point(971, 370);
            this.buttonVerificar.Name = "buttonVerificar";
            this.buttonVerificar.Size = new System.Drawing.Size(26, 26);
            this.buttonVerificar.TabIndex = 105;
            this.buttonVerificar.Text = "V";
            this.buttonVerificar.UseVisualStyleBackColor = true;
            this.buttonVerificar.Click += new System.EventHandler(this.buttonVerificar_Click);
            // 
            // panelOS
            // 
            this.panelOS.Controls.Add(this.label8);
            this.panelOS.Controls.Add(this.txtMS);
            this.panelOS.Controls.Add(this.label5);
            this.panelOS.Controls.Add(this.txtNomeOs);
            this.panelOS.Controls.Add(this.label4);
            this.panelOS.Enabled = false;
            this.panelOS.Location = new System.Drawing.Point(272, 399);
            this.panelOS.Name = "panelOS";
            this.panelOS.Size = new System.Drawing.Size(693, 52);
            this.panelOS.TabIndex = 106;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(365, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "CLIENTE DE OS";
            // 
            // txtMS
            // 
            this.txtMS.Location = new System.Drawing.Point(136, 29);
            this.txtMS.Name = "txtMS";
            this.txtMS.Size = new System.Drawing.Size(87, 20);
            this.txtMS.TabIndex = 3;
            this.txtMS.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMS_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "MS:";
            // 
            // txtNomeOs
            // 
            this.txtNomeOs.Location = new System.Drawing.Point(136, 5);
            this.txtNomeOs.Name = "txtNomeOs";
            this.txtNomeOs.Size = new System.Drawing.Size(554, 20);
            this.txtNomeOs.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "NOME DO CLIENTE OS:";
            // 
            // panelFORNECEDOR
            // 
            this.panelFORNECEDOR.Controls.Add(this.txtCargoContato);
            this.panelFORNECEDOR.Controls.Add(this.label10);
            this.panelFORNECEDOR.Controls.Add(this.label9);
            this.panelFORNECEDOR.Controls.Add(this.txtNomeContato);
            this.panelFORNECEDOR.Controls.Add(this.label7);
            this.panelFORNECEDOR.Enabled = false;
            this.panelFORNECEDOR.Location = new System.Drawing.Point(272, 457);
            this.panelFORNECEDOR.Name = "panelFORNECEDOR";
            this.panelFORNECEDOR.Size = new System.Drawing.Size(693, 52);
            this.panelFORNECEDOR.TabIndex = 107;
            // 
            // txtCargoContato
            // 
            this.txtCargoContato.Location = new System.Drawing.Point(466, 5);
            this.txtCargoContato.Name = "txtCargoContato";
            this.txtCargoContato.Size = new System.Drawing.Size(224, 20);
            this.txtCargoContato.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(338, 8);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(122, 13);
            this.label10.TabIndex = 6;
            this.label10.Text = "CARGO DO CONTATO:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(368, 33);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "FORNECEDOR";
            // 
            // txtNomeContato
            // 
            this.txtNomeContato.Location = new System.Drawing.Point(119, 5);
            this.txtNomeContato.Name = "txtNomeContato";
            this.txtNomeContato.Size = new System.Drawing.Size(214, 20);
            this.txtNomeContato.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 7);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "NOME DE CONTATO:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(3, 10);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(116, 13);
            this.label14.TabIndex = 0;
            this.label14.Text = "NÚMERO DE VENDA:";
            // 
            // txtNumeroVendedor
            // 
            this.txtNumeroVendedor.Location = new System.Drawing.Point(134, 6);
            this.txtNumeroVendedor.Name = "txtNumeroVendedor";
            this.txtNumeroVendedor.Size = new System.Drawing.Size(219, 20);
            this.txtNumeroVendedor.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(368, 33);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(68, 13);
            this.label12.TabIndex = 5;
            this.label12.Text = "VENDEDOR";
            // 
            // panelVENDEDOR
            // 
            this.panelVENDEDOR.Controls.Add(this.label12);
            this.panelVENDEDOR.Controls.Add(this.txtNumeroVendedor);
            this.panelVENDEDOR.Controls.Add(this.label14);
            this.panelVENDEDOR.Enabled = false;
            this.panelVENDEDOR.Location = new System.Drawing.Point(272, 517);
            this.panelVENDEDOR.Name = "panelVENDEDOR";
            this.panelVENDEDOR.Size = new System.Drawing.Size(693, 52);
            this.panelVENDEDOR.TabIndex = 108;
            // 
            // panelREGISTRO
            // 
            this.panelREGISTRO.Controls.Add(this.label6);
            this.panelREGISTRO.Controls.Add(this.txtNomeRegistro);
            this.panelREGISTRO.Controls.Add(this.label11);
            this.panelREGISTRO.Enabled = false;
            this.panelREGISTRO.Location = new System.Drawing.Point(272, 576);
            this.panelREGISTRO.Name = "panelREGISTRO";
            this.panelREGISTRO.Size = new System.Drawing.Size(693, 52);
            this.panelREGISTRO.TabIndex = 109;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(368, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "REGISTRO";
            // 
            // txtNomeRegistro
            // 
            this.txtNomeRegistro.Location = new System.Drawing.Point(177, 6);
            this.txtNomeRegistro.Name = "txtNomeRegistro";
            this.txtNomeRegistro.Size = new System.Drawing.Size(513, 20);
            this.txtNomeRegistro.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(168, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "NOME DO CLIENTE REGISTRO:";
            // 
            // FormAlteracaoStatusRS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1041, 632);
            this.ControlBox = false;
            this.Controls.Add(this.panelREGISTRO);
            this.Controls.Add(this.panelVENDEDOR);
            this.Controls.Add(this.panelFORNECEDOR);
            this.Controls.Add(this.panelOS);
            this.Controls.Add(this.buttonVerificar);
            this.Controls.Add(this.buttonSalvaAlteracao);
            this.Controls.Add(this.radioButtonNumeroCadastro);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonBuscaCasdatrado);
            this.Controls.Add(this.radioButtonTodos);
            this.Controls.Add(this.dataGridViewPesquisa);
            this.Controls.Add(this.txtCnpj);
            this.Controls.Add(this.txtNomeCadastro);
            this.Controls.Add(this.txtNumeroCadastro);
            this.Controls.Add(this.radioButtonCnpj);
            this.Controls.Add(this.radioButtonNomeCadastro);
            this.Controls.Add(this.radioButtonNumeroCadastro1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkedListBoxStatus);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAlteracaoStatusRS";
            this.Text = "Alteração de Status Razão Social Cadastrado";
            this.Load += new System.EventHandler(this.FormAlteracapStatusRS_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FormAlteracapStatusRS_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPesquisa)).EndInit();
            this.panelOS.ResumeLayout(false);
            this.panelOS.PerformLayout();
            this.panelFORNECEDOR.ResumeLayout(false);
            this.panelFORNECEDOR.PerformLayout();
            this.panelVENDEDOR.ResumeLayout(false);
            this.panelVENDEDOR.PerformLayout();
            this.panelREGISTRO.ResumeLayout(false);
            this.panelREGISTRO.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox checkedListBoxStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButtonNumeroCadastro1;
        private System.Windows.Forms.RadioButton radioButtonNomeCadastro;
        private System.Windows.Forms.RadioButton radioButtonCnpj;
        private System.Windows.Forms.TextBox txtNumeroCadastro;
        private System.Windows.Forms.TextBox txtNomeCadastro;
        private System.Windows.Forms.TextBox txtCnpj;
        private System.Windows.Forms.DataGridView dataGridViewPesquisa;
        private System.Windows.Forms.RadioButton radioButtonTodos;
        private System.Windows.Forms.Button buttonBuscaCasdatrado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_PESSOA;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMECADASTRADO;
        private System.Windows.Forms.DataGridViewTextBoxColumn RAZAO_SOCIAL;
        private System.Windows.Forms.DataGridViewTextBoxColumn CNPJ;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radioButtonNumeroCadastro;
        private System.Windows.Forms.Button buttonSalvaAlteracao;
        private System.Windows.Forms.Button buttonVerificar;
        private System.Windows.Forms.Panel panelOS;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtMS;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNomeOs;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panelFORNECEDOR;
        private System.Windows.Forms.TextBox txtCargoContato;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtNomeContato;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtNumeroVendedor;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panelVENDEDOR;
        private System.Windows.Forms.Panel panelREGISTRO;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNomeRegistro;
        private System.Windows.Forms.Label label11;
    }
}