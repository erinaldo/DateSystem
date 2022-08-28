namespace DateSystem
{
    partial class FormSeniorSapiens
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewPesquisaSenior = new System.Windows.Forms.DataGridView();
            this.IDUSUARIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATTIM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOMECOMPUTADOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOMEUSUARIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SISTEMA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOMEUSUARIOAPLI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDINST = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonPesquisaUsuario = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBoxSapiens = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonSair = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPesquisaSenior)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewPesquisaSenior
            // 
            this.dataGridViewPesquisaSenior.AllowUserToAddRows = false;
            this.dataGridViewPesquisaSenior.AllowUserToDeleteRows = false;
            this.dataGridViewPesquisaSenior.AllowUserToResizeRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridViewPesquisaSenior.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewPesquisaSenior.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewPesquisaSenior.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPesquisaSenior.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDUSUARIO,
            this.DATTIM,
            this.NOMECOMPUTADOR,
            this.NOMEUSUARIO,
            this.SISTEMA,
            this.NOMEUSUARIOAPLI,
            this.IDINST});
            this.dataGridViewPesquisaSenior.Cursor = System.Windows.Forms.Cursors.Default;
            this.dataGridViewPesquisaSenior.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewPesquisaSenior.Location = new System.Drawing.Point(12, 23);
            this.dataGridViewPesquisaSenior.MultiSelect = false;
            this.dataGridViewPesquisaSenior.Name = "dataGridViewPesquisaSenior";
            this.dataGridViewPesquisaSenior.RowHeadersVisible = false;
            this.dataGridViewPesquisaSenior.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewPesquisaSenior.Size = new System.Drawing.Size(426, 337);
            this.dataGridViewPesquisaSenior.TabIndex = 96;
            this.dataGridViewPesquisaSenior.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPesquisaSenior_CellDoubleClick);
            // 
            // IDUSUARIO
            // 
            this.IDUSUARIO.DataPropertyName = "IDUSUARIO";
            this.IDUSUARIO.HeaderText = "ID DO USUARIO";
            this.IDUSUARIO.Name = "IDUSUARIO";
            this.IDUSUARIO.Visible = false;
            // 
            // DATTIM
            // 
            this.DATTIM.DataPropertyName = "DATTIM";
            this.DATTIM.HeaderText = "DATTIM";
            this.DATTIM.Name = "DATTIM";
            this.DATTIM.Visible = false;
            // 
            // NOMECOMPUTADOR
            // 
            this.NOMECOMPUTADOR.DataPropertyName = "NOMECOMPUTADOR";
            this.NOMECOMPUTADOR.HeaderText = "NOME DO COMPUTADOR";
            this.NOMECOMPUTADOR.Name = "NOMECOMPUTADOR";
            this.NOMECOMPUTADOR.Width = 150;
            // 
            // NOMEUSUARIO
            // 
            this.NOMEUSUARIO.DataPropertyName = "NOMEUSUARIO";
            this.NOMEUSUARIO.HeaderText = "NOME DO USUARIO";
            this.NOMEUSUARIO.Name = "NOMEUSUARIO";
            this.NOMEUSUARIO.Width = 150;
            // 
            // SISTEMA
            // 
            this.SISTEMA.DataPropertyName = "SISTEMA";
            this.SISTEMA.HeaderText = "SISTEMA";
            this.SISTEMA.Name = "SISTEMA";
            this.SISTEMA.Visible = false;
            // 
            // NOMEUSUARIOAPLI
            // 
            this.NOMEUSUARIOAPLI.DataPropertyName = "NOMEUSUARIOAPLI";
            this.NOMEUSUARIOAPLI.HeaderText = "NOME DO USUARIO NO APLICATIVO";
            this.NOMEUSUARIOAPLI.Name = "NOMEUSUARIOAPLI";
            this.NOMEUSUARIOAPLI.Width = 150;
            // 
            // IDINST
            // 
            this.IDINST.DataPropertyName = "IDINST";
            this.IDINST.HeaderText = "IDINST";
            this.IDINST.Name = "IDINST";
            this.IDINST.Visible = false;
            // 
            // buttonPesquisaUsuario
            // 
            this.buttonPesquisaUsuario.Location = new System.Drawing.Point(444, 23);
            this.buttonPesquisaUsuario.Name = "buttonPesquisaUsuario";
            this.buttonPesquisaUsuario.Size = new System.Drawing.Size(59, 23);
            this.buttonPesquisaUsuario.TabIndex = 97;
            this.buttonPesquisaUsuario.Text = "Pesquisa";
            this.buttonPesquisaUsuario.UseVisualStyleBackColor = true;
            this.buttonPesquisaUsuario.Click += new System.EventHandler(this.buttonPesquisaUsuario_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(387, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 98;
            this.label1.Text = ":Usuários";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(373, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 99;
            this.label2.Text = "0";
            // 
            // checkBoxSapiens
            // 
            this.checkBoxSapiens.AutoSize = true;
            this.checkBoxSapiens.Location = new System.Drawing.Point(444, 111);
            this.checkBoxSapiens.Name = "checkBoxSapiens";
            this.checkBoxSapiens.Size = new System.Drawing.Size(97, 17);
            this.checkBoxSapiens.TabIndex = 100;
            this.checkBoxSapiens.Text = "Derruba Todos";
            this.checkBoxSapiens.UseVisualStyleBackColor = true;
            this.checkBoxSapiens.MouseClick += new System.Windows.Forms.MouseEventHandler(this.checkBoxSapiens_MouseClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(444, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 26);
            this.label3.TabIndex = 101;
            this.label3.Text = "Atenção Derruba Todos\n os usuários do sistema!";
            // 
            // buttonSair
            // 
            this.buttonSair.Location = new System.Drawing.Point(442, 134);
            this.buttonSair.Name = "buttonSair";
            this.buttonSair.Size = new System.Drawing.Size(61, 23);
            this.buttonSair.TabIndex = 102;
            this.buttonSair.Text = "Sair";
            this.buttonSair.UseVisualStyleBackColor = true;
            this.buttonSair.Click += new System.EventHandler(this.buttonSair_Click);
            // 
            // FormSeniorSapiens
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 377);
            this.ControlBox = false;
            this.Controls.Add(this.buttonSair);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.checkBoxSapiens);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonPesquisaUsuario);
            this.Controls.Add(this.dataGridViewPesquisaSenior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSeniorSapiens";
            this.Text = "Pesquisa usuários ON-LINE Sapiens";
            this.Load += new System.EventHandler(this.FormSeniorSapiens_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FormSeniorSapiens_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPesquisaSenior)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewPesquisaSenior;
        private System.Windows.Forms.Button buttonPesquisaUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBoxSapiens;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDUSUARIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATTIM;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMECOMPUTADOR;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMEUSUARIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn SISTEMA;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMEUSUARIOAPLI;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDINST;
        private System.Windows.Forms.Button buttonSair;
    }
}