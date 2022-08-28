using System.Windows.Forms;

namespace DateSystem
{
    partial class FormFornecedores
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
            System.Windows.Forms.Label BairroFornecedor;
            System.Windows.Forms.Label CargoContatoFornecedor;
            System.Windows.Forms.Label CidadadeFornecedor;
            System.Windows.Forms.Label CpMunicipioFornecedor;
            System.Windows.Forms.Label DesPaisFornecedor;
            System.Windows.Forms.Label EnderecoFornecedor;
            System.Windows.Forms.Label FaxFornecedor;
            System.Windows.Forms.Label PaisFornecedor;
            System.Windows.Forms.Label Telefone2Fornecedor;
            System.Windows.Forms.Label TelexTelefoneFornecedor;
            System.Windows.Forms.Label TipoFornecedor;
            System.Windows.Forms.Label ObservacaoFornecedor;
            System.Windows.Forms.Label MunicipioFornecedor;
            System.Windows.Forms.Label TelefoneFornecedor;
            System.Windows.Forms.Label NomeFornecedor;
            System.Windows.Forms.Label EmailFornecedor;
            System.Windows.Forms.Label CepFornecedor;
            System.Windows.Forms.Label nOME_CONTATOLabel;
            System.Windows.Forms.Label rAZAO_SOCIALLabel;
            System.Windows.Forms.Label iNSCRICAO_STADUALLabel;
            System.Windows.Forms.Label cNPJLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFornecedores));
            this.p_ClientePessoaBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.p_ClientePessoaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.p_ClientePessoaBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.txtBairroFornecedor = new System.Windows.Forms.TextBox();
            this.f_FornecedorPessoaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtCargoContatoFornecedor = new System.Windows.Forms.TextBox();
            this.txtCidadeFornecedor = new System.Windows.Forms.TextBox();
            this.txtCpMunicipioFornecedor = new System.Windows.Forms.TextBox();
            this.txtDesPaisFornecedor = new System.Windows.Forms.TextBox();
            this.txtEmailFornecedor = new System.Windows.Forms.TextBox();
            this.txtEnderecoFornecedor = new System.Windows.Forms.TextBox();
            this.txtMunicipioFornecedor = new System.Windows.Forms.TextBox();
            this.txtNomeFornecedor = new System.Windows.Forms.TextBox();
            this.txtPaisFornecedor = new System.Windows.Forms.TextBox();
            this.txtTipoFornecedor = new System.Windows.Forms.TextBox();
            this.panelCadastraFornecedor = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.txtSigla = new System.Windows.Forms.TextBox();
            this.txtNumeroPrincipal = new System.Windows.Forms.TextBox();
            this.labelConfirmacaoPrimario = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.maskedTextBoxCep = new System.Windows.Forms.MaskedTextBox();
            this.radioButtonOculto = new System.Windows.Forms.RadioButton();
            this.txtNomeContatoFornecedor = new System.Windows.Forms.TextBox();
            this.labelContatoFornecedor = new System.Windows.Forms.Label();
            this.txtObservacaoFornecedor = new System.Windows.Forms.TextBox();
            this.txtTelexTelefoneFornecedor = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtLogradouro = new System.Windows.Forms.TextBox();
            this.buttonCepPrincipal = new System.Windows.Forms.Button();
            this.txtFaxTelefoneFornecedor = new System.Windows.Forms.MaskedTextBox();
            this.txtTelefone2Fornecedor = new System.Windows.Forms.MaskedTextBox();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.txtcomplemento = new System.Windows.Forms.TextBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.txtTelefoneFornecedor = new System.Windows.Forms.MaskedTextBox();
            this.checkBoxClienteSituacao = new System.Windows.Forms.CheckBox();
            this.AtivoFornecedor = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelConfirmacaoSecundario = new System.Windows.Forms.Label();
            this.txtSiglaCidadeFornecedor = new System.Windows.Forms.TextBox();
            this.SiglaCidadeFornecedor = new System.Windows.Forms.Label();
            this.txtComplFornecedor = new System.Windows.Forms.TextBox();
            this.txtBairroNumeroFornecedor = new System.Windows.Forms.TextBox();
            this.BairroNumeroFornecedor = new System.Windows.Forms.Label();
            this.txtTipo_logradouro = new System.Windows.Forms.TextBox();
            this.Tipo_logradouroFornecedor = new System.Windows.Forms.Label();
            this.ButtonBuscaCep = new System.Windows.Forms.Button();
            this.txtCepFornecedor = new System.Windows.Forms.MaskedTextBox();
            this.buttonCancelarFornecedor = new System.Windows.Forms.Button();
            this.buttonCadastraFornecedor = new System.Windows.Forms.Button();
            this.buttonVerificarFornecedor = new System.Windows.Forms.Button();
            this.errorProviderFornecedor = new System.Windows.Forms.ErrorProvider(this.components);
            this.buttonLimpaFornecedor = new System.Windows.Forms.Button();
            this.buttonFecharFornecedor = new System.Windows.Forms.Button();
            this.radioButtonFornecedorFisica = new System.Windows.Forms.RadioButton();
            this.radioButtonFornecedorJuridica = new System.Windows.Forms.RadioButton();
            this.ComplFornecedor = new System.Windows.Forms.Label();
            this.tabControlFornedor = new System.Windows.Forms.TabControl();
            this.tabPageFornecedoresJuridica = new System.Windows.Forms.TabPage();
            this.panelJuridico = new System.Windows.Forms.Panel();
            this.txtCnae = new System.Windows.Forms.TextBox();
            this.label1CNAE = new System.Windows.Forms.Label();
            this.txtNomeContato = new System.Windows.Forms.TextBox();
            this.txtRazaoSocial = new System.Windows.Forms.TextBox();
            this.txtInscStatual = new System.Windows.Forms.TextBox();
            this.txtCnpj = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPageFornecedoresFisica = new System.Windows.Forms.TabPage();
            this.panelFisica = new System.Windows.Forms.Panel();
            this.txtNomePFisica = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCelularFFisica2 = new System.Windows.Forms.MaskedTextBox();
            this.comboBoxSexoFFIsica = new System.Windows.Forms.ComboBox();
            this.txtCelularFFisica = new System.Windows.Forms.MaskedTextBox();
            this.txtCpfFFisica = new System.Windows.Forms.MaskedTextBox();
            this.txtDataNascimentoFFisica = new System.Windows.Forms.DateTimePicker();
            this.Celular2PFisica = new System.Windows.Forms.Label();
            this.txtRgFisica = new System.Windows.Forms.TextBox();
            this.RgPFisica = new System.Windows.Forms.Label();
            this.CelularPFisica = new System.Windows.Forms.Label();
            this.DataNascimentoPF = new System.Windows.Forms.Label();
            this.CpfPFisica = new System.Windows.Forms.Label();
            this.SexoPFisica = new System.Windows.Forms.Label();
            this.checkboxtxtFisica = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBoxLetras = new System.Windows.Forms.PictureBox();
            this.txtLetrasConulta = new System.Windows.Forms.TextBox();
            this.txtCnpjConsulta = new System.Windows.Forms.TextBox();
            this.buttonTrocaImagem = new System.Windows.Forms.Button();
            this.buttonConsultaCnpj = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.buttonCnpjAutomatico = new System.Windows.Forms.Button();
            this.buttonCnpjManual = new System.Windows.Forms.Button();
            this.fFornecedorPessoaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            BairroFornecedor = new System.Windows.Forms.Label();
            CargoContatoFornecedor = new System.Windows.Forms.Label();
            CidadadeFornecedor = new System.Windows.Forms.Label();
            CpMunicipioFornecedor = new System.Windows.Forms.Label();
            DesPaisFornecedor = new System.Windows.Forms.Label();
            EnderecoFornecedor = new System.Windows.Forms.Label();
            FaxFornecedor = new System.Windows.Forms.Label();
            PaisFornecedor = new System.Windows.Forms.Label();
            Telefone2Fornecedor = new System.Windows.Forms.Label();
            TelexTelefoneFornecedor = new System.Windows.Forms.Label();
            TipoFornecedor = new System.Windows.Forms.Label();
            ObservacaoFornecedor = new System.Windows.Forms.Label();
            MunicipioFornecedor = new System.Windows.Forms.Label();
            TelefoneFornecedor = new System.Windows.Forms.Label();
            NomeFornecedor = new System.Windows.Forms.Label();
            EmailFornecedor = new System.Windows.Forms.Label();
            CepFornecedor = new System.Windows.Forms.Label();
            nOME_CONTATOLabel = new System.Windows.Forms.Label();
            rAZAO_SOCIALLabel = new System.Windows.Forms.Label();
            iNSCRICAO_STADUALLabel = new System.Windows.Forms.Label();
            cNPJLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.p_ClientePessoaBindingNavigator)).BeginInit();
            this.p_ClientePessoaBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.p_ClientePessoaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.f_FornecedorPessoaBindingSource)).BeginInit();
            this.panelCadastraFornecedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderFornecedor)).BeginInit();
            this.tabControlFornedor.SuspendLayout();
            this.tabPageFornecedoresJuridica.SuspendLayout();
            this.panelJuridico.SuspendLayout();
            this.tabPageFornecedoresFisica.SuspendLayout();
            this.panelFisica.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLetras)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fFornecedorPessoaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // BairroFornecedor
            // 
            BairroFornecedor.AutoSize = true;
            BairroFornecedor.Location = new System.Drawing.Point(252, 87);
            BairroFornecedor.Name = "BairroFornecedor";
            BairroFornecedor.Size = new System.Drawing.Size(55, 13);
            BairroFornecedor.TabIndex = 1;
            BairroFornecedor.Text = "BAIRRO*:";
            // 
            // CargoContatoFornecedor
            // 
            CargoContatoFornecedor.AutoSize = true;
            CargoContatoFornecedor.Location = new System.Drawing.Point(391, 9);
            CargoContatoFornecedor.Name = "CargoContatoFornecedor";
            CargoContatoFornecedor.Size = new System.Drawing.Size(48, 13);
            CargoContatoFornecedor.TabIndex = 3;
            CargoContatoFornecedor.Text = "CARGO:";
            // 
            // CidadadeFornecedor
            // 
            CidadadeFornecedor.AutoSize = true;
            CidadadeFornecedor.Location = new System.Drawing.Point(8, 120);
            CidadadeFornecedor.Name = "CidadadeFornecedor";
            CidadadeFornecedor.Size = new System.Drawing.Size(54, 13);
            CidadadeFornecedor.TabIndex = 7;
            CidadadeFornecedor.Text = "CIDADE*:";
            // 
            // CpMunicipioFornecedor
            // 
            CpMunicipioFornecedor.AutoSize = true;
            CpMunicipioFornecedor.Location = new System.Drawing.Point(489, 183);
            CpMunicipioFornecedor.Name = "CpMunicipioFornecedor";
            CpMunicipioFornecedor.Size = new System.Drawing.Size(83, 13);
            CpMunicipioFornecedor.TabIndex = 9;
            CpMunicipioFornecedor.Text = "CP MUNICIPIO:";
            // 
            // DesPaisFornecedor
            // 
            DesPaisFornecedor.AutoSize = true;
            DesPaisFornecedor.Location = new System.Drawing.Point(398, 216);
            DesPaisFornecedor.Name = "DesPaisFornecedor";
            DesPaisFornecedor.Size = new System.Drawing.Size(66, 13);
            DesPaisFornecedor.TabIndex = 13;
            DesPaisFornecedor.Text = "DESC PAIS:";
            // 
            // EnderecoFornecedor
            // 
            EnderecoFornecedor.AutoSize = true;
            EnderecoFornecedor.Location = new System.Drawing.Point(6, 58);
            EnderecoFornecedor.Name = "EnderecoFornecedor";
            EnderecoFornecedor.Size = new System.Drawing.Size(74, 13);
            EnderecoFornecedor.TabIndex = 17;
            EnderecoFornecedor.Text = "ENDERECO*:";
            // 
            // FaxFornecedor
            // 
            FaxFornecedor.AutoSize = true;
            FaxFornecedor.Location = new System.Drawing.Point(246, 155);
            FaxFornecedor.Name = "FaxFornecedor";
            FaxFornecedor.Size = new System.Drawing.Size(89, 13);
            FaxFornecedor.TabIndex = 19;
            FaxFornecedor.Text = "FAX TELEFONE:";
            // 
            // PaisFornecedor
            // 
            PaisFornecedor.AutoSize = true;
            PaisFornecedor.Location = new System.Drawing.Point(236, 217);
            PaisFornecedor.Name = "PaisFornecedor";
            PaisFornecedor.Size = new System.Drawing.Size(34, 13);
            PaisFornecedor.TabIndex = 29;
            PaisFornecedor.Text = "PAIS:";
            // 
            // Telefone2Fornecedor
            // 
            Telefone2Fornecedor.AutoSize = true;
            Telefone2Fornecedor.Location = new System.Drawing.Point(89, 155);
            Telefone2Fornecedor.Name = "Telefone2Fornecedor";
            Telefone2Fornecedor.Size = new System.Drawing.Size(72, 13);
            Telefone2Fornecedor.TabIndex = 35;
            Telefone2Fornecedor.Text = "TELEFONE2:";
            // 
            // TelexTelefoneFornecedor
            // 
            TelexTelefoneFornecedor.AutoSize = true;
            TelexTelefoneFornecedor.Location = new System.Drawing.Point(424, 155);
            TelexTelefoneFornecedor.Name = "TelexTelefoneFornecedor";
            TelexTelefoneFornecedor.Size = new System.Drawing.Size(103, 13);
            TelexTelefoneFornecedor.TabIndex = 37;
            TelexTelefoneFornecedor.Text = "TELEX TELEFONE:";
            // 
            // TipoFornecedor
            // 
            TipoFornecedor.AutoSize = true;
            TipoFornecedor.Location = new System.Drawing.Point(294, 183);
            TipoFornecedor.Name = "TipoFornecedor";
            TipoFornecedor.Size = new System.Drawing.Size(35, 13);
            TipoFornecedor.TabIndex = 39;
            TipoFornecedor.Text = "TIPO:";
            // 
            // ObservacaoFornecedor
            // 
            ObservacaoFornecedor.AutoSize = true;
            ObservacaoFornecedor.Location = new System.Drawing.Point(12, 243);
            ObservacaoFornecedor.Name = "ObservacaoFornecedor";
            ObservacaoFornecedor.Size = new System.Drawing.Size(83, 13);
            ObservacaoFornecedor.TabIndex = 88;
            ObservacaoFornecedor.Text = "OBSERVACAO:";
            // 
            // MunicipioFornecedor
            // 
            MunicipioFornecedor.AutoSize = true;
            MunicipioFornecedor.Location = new System.Drawing.Point(12, 213);
            MunicipioFornecedor.Name = "MunicipioFornecedor";
            MunicipioFornecedor.Size = new System.Drawing.Size(66, 13);
            MunicipioFornecedor.TabIndex = 86;
            MunicipioFornecedor.Text = "MUNICIPIO:";
            // 
            // TelefoneFornecedor
            // 
            TelefoneFornecedor.AutoSize = true;
            TelefoneFornecedor.Location = new System.Drawing.Point(12, 153);
            TelefoneFornecedor.Name = "TelefoneFornecedor";
            TelefoneFornecedor.Size = new System.Drawing.Size(70, 13);
            TelefoneFornecedor.TabIndex = 89;
            TelefoneFornecedor.Text = "TELEFONE*:";
            // 
            // NomeFornecedor
            // 
            NomeFornecedor.AutoSize = true;
            NomeFornecedor.Location = new System.Drawing.Point(12, 9);
            NomeFornecedor.Name = "NomeFornecedor";
            NomeFornecedor.Size = new System.Drawing.Size(46, 13);
            NomeFornecedor.TabIndex = 87;
            NomeFornecedor.Text = "NOME*:";
            // 
            // EmailFornecedor
            // 
            EmailFornecedor.AutoSize = true;
            EmailFornecedor.Location = new System.Drawing.Point(12, 184);
            EmailFornecedor.Name = "EmailFornecedor";
            EmailFornecedor.Size = new System.Drawing.Size(46, 13);
            EmailFornecedor.TabIndex = 85;
            EmailFornecedor.Text = "EMAIL*:";
            // 
            // CepFornecedor
            // 
            CepFornecedor.AutoSize = true;
            CepFornecedor.Location = new System.Drawing.Point(8, 28);
            CepFornecedor.Name = "CepFornecedor";
            CepFornecedor.Size = new System.Drawing.Size(35, 13);
            CepFornecedor.TabIndex = 84;
            CepFornecedor.Text = "CEP*:";
            // 
            // nOME_CONTATOLabel
            // 
            nOME_CONTATOLabel.AutoSize = true;
            nOME_CONTATOLabel.Location = new System.Drawing.Point(6, 84);
            nOME_CONTATOLabel.Name = "nOME_CONTATOLabel";
            nOME_CONTATOLabel.Size = new System.Drawing.Size(97, 13);
            nOME_CONTATOLabel.TabIndex = 73;
            nOME_CONTATOLabel.Text = "NOME CONTATO:";
            // 
            // rAZAO_SOCIALLabel
            // 
            rAZAO_SOCIALLabel.AutoSize = true;
            rAZAO_SOCIALLabel.Location = new System.Drawing.Point(146, 32);
            rAZAO_SOCIALLabel.Name = "rAZAO_SOCIALLabel";
            rAZAO_SOCIALLabel.Size = new System.Drawing.Size(88, 13);
            rAZAO_SOCIALLabel.TabIndex = 72;
            rAZAO_SOCIALLabel.Text = "RAZAO SOCIAL:";
            // 
            // iNSCRICAO_STADUALLabel
            // 
            iNSCRICAO_STADUALLabel.AutoSize = true;
            iNSCRICAO_STADUALLabel.Location = new System.Drawing.Point(5, 58);
            iNSCRICAO_STADUALLabel.Name = "iNSCRICAO_STADUALLabel";
            iNSCRICAO_STADUALLabel.Size = new System.Drawing.Size(121, 13);
            iNSCRICAO_STADUALLabel.TabIndex = 70;
            iNSCRICAO_STADUALLabel.Text = "INSCRICAO STADUAL:";
            // 
            // cNPJLabel
            // 
            cNPJLabel.AutoSize = true;
            cNPJLabel.Location = new System.Drawing.Point(4, 32);
            cNPJLabel.Name = "cNPJLabel";
            cNPJLabel.Size = new System.Drawing.Size(37, 13);
            cNPJLabel.TabIndex = 66;
            cNPJLabel.Text = "CNPJ:";
            // 
            // p_ClientePessoaBindingNavigator
            // 
            this.p_ClientePessoaBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.p_ClientePessoaBindingNavigator.BindingSource = this.p_ClientePessoaBindingSource;
            this.p_ClientePessoaBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.p_ClientePessoaBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.p_ClientePessoaBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.p_ClientePessoaBindingNavigatorSaveItem});
            this.p_ClientePessoaBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.p_ClientePessoaBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.p_ClientePessoaBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.p_ClientePessoaBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.p_ClientePessoaBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.p_ClientePessoaBindingNavigator.Name = "p_ClientePessoaBindingNavigator";
            this.p_ClientePessoaBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.p_ClientePessoaBindingNavigator.Size = new System.Drawing.Size(895, 25);
            this.p_ClientePessoaBindingNavigator.TabIndex = 0;
            this.p_ClientePessoaBindingNavigator.Text = "bindingNavigator1";
            this.p_ClientePessoaBindingNavigator.Visible = false;
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // p_ClientePessoaBindingNavigatorSaveItem
            // 
            this.p_ClientePessoaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.p_ClientePessoaBindingNavigatorSaveItem.Enabled = false;
            this.p_ClientePessoaBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("p_ClientePessoaBindingNavigatorSaveItem.Image")));
            this.p_ClientePessoaBindingNavigatorSaveItem.Name = "p_ClientePessoaBindingNavigatorSaveItem";
            this.p_ClientePessoaBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.p_ClientePessoaBindingNavigatorSaveItem.Text = "Save Data";
            // 
            // txtBairroFornecedor
            // 
            this.txtBairroFornecedor.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.f_FornecedorPessoaBindingSource, "BAIRRO", true));
            this.txtBairroFornecedor.Location = new System.Drawing.Point(309, 84);
            this.txtBairroFornecedor.Name = "txtBairroFornecedor";
            this.txtBairroFornecedor.Size = new System.Drawing.Size(100, 20);
            this.txtBairroFornecedor.TabIndex = 2;
            // 
            // f_FornecedorPessoaBindingSource
            // 
            this.f_FornecedorPessoaBindingSource.DataSource = typeof(DateSystem.P_ClientePessoa);
            // 
            // txtCargoContatoFornecedor
            // 
            this.txtCargoContatoFornecedor.Location = new System.Drawing.Point(445, 6);
            this.txtCargoContatoFornecedor.Name = "txtCargoContatoFornecedor";
            this.txtCargoContatoFornecedor.Size = new System.Drawing.Size(69, 20);
            this.txtCargoContatoFornecedor.TabIndex = 2;
            // 
            // txtCidadeFornecedor
            // 
            this.txtCidadeFornecedor.Location = new System.Drawing.Point(64, 116);
            this.txtCidadeFornecedor.Name = "txtCidadeFornecedor";
            this.txtCidadeFornecedor.Size = new System.Drawing.Size(100, 20);
            this.txtCidadeFornecedor.TabIndex = 8;
            // 
            // txtCpMunicipioFornecedor
            // 
            this.txtCpMunicipioFornecedor.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.f_FornecedorPessoaBindingSource, "CP_MUNICIPIO", true));
            this.txtCpMunicipioFornecedor.Location = new System.Drawing.Point(578, 180);
            this.txtCpMunicipioFornecedor.Name = "txtCpMunicipioFornecedor";
            this.txtCpMunicipioFornecedor.Size = new System.Drawing.Size(100, 20);
            this.txtCpMunicipioFornecedor.TabIndex = 12;
            // 
            // txtDesPaisFornecedor
            // 
            this.txtDesPaisFornecedor.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.f_FornecedorPessoaBindingSource, "DESC_PAIS", true));
            this.txtDesPaisFornecedor.Location = new System.Drawing.Point(470, 214);
            this.txtDesPaisFornecedor.Name = "txtDesPaisFornecedor";
            this.txtDesPaisFornecedor.Size = new System.Drawing.Size(130, 20);
            this.txtDesPaisFornecedor.TabIndex = 15;
            // 
            // txtEmailFornecedor
            // 
            this.txtEmailFornecedor.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.f_FornecedorPessoaBindingSource, "EMAIL", true));
            this.txtEmailFornecedor.Location = new System.Drawing.Point(5, 180);
            this.txtEmailFornecedor.Name = "txtEmailFornecedor";
            this.txtEmailFornecedor.Size = new System.Drawing.Size(283, 20);
            this.txtEmailFornecedor.TabIndex = 10;
            // 
            // txtEnderecoFornecedor
            // 
            this.txtEnderecoFornecedor.AcceptsReturn = true;
            this.txtEnderecoFornecedor.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.f_FornecedorPessoaBindingSource, "ENDERECO", true));
            this.txtEnderecoFornecedor.Location = new System.Drawing.Point(82, 55);
            this.txtEnderecoFornecedor.Name = "txtEnderecoFornecedor";
            this.txtEnderecoFornecedor.Size = new System.Drawing.Size(243, 20);
            this.txtEnderecoFornecedor.TabIndex = 0;
            // 
            // txtMunicipioFornecedor
            // 
            this.txtMunicipioFornecedor.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.f_FornecedorPessoaBindingSource, "MUNICIPIO", true));
            this.txtMunicipioFornecedor.Location = new System.Drawing.Point(5, 213);
            this.txtMunicipioFornecedor.Name = "txtMunicipioFornecedor";
            this.txtMunicipioFornecedor.Size = new System.Drawing.Size(100, 20);
            this.txtMunicipioFornecedor.TabIndex = 13;
            // 
            // txtNomeFornecedor
            // 
            this.txtNomeFornecedor.Location = new System.Drawing.Point(5, 6);
            this.txtNomeFornecedor.Name = "txtNomeFornecedor";
            this.txtNomeFornecedor.Size = new System.Drawing.Size(379, 20);
            this.txtNomeFornecedor.TabIndex = 1;
            // 
            // txtPaisFornecedor
            // 
            this.txtPaisFornecedor.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.f_FornecedorPessoaBindingSource, "PAIS", true));
            this.txtPaisFornecedor.Location = new System.Drawing.Point(276, 214);
            this.txtPaisFornecedor.Name = "txtPaisFornecedor";
            this.txtPaisFornecedor.Size = new System.Drawing.Size(116, 20);
            this.txtPaisFornecedor.TabIndex = 14;
            // 
            // txtTipoFornecedor
            // 
            this.txtTipoFornecedor.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.f_FornecedorPessoaBindingSource, "TIPO", true));
            this.txtTipoFornecedor.Location = new System.Drawing.Point(335, 180);
            this.txtTipoFornecedor.Name = "txtTipoFornecedor";
            this.txtTipoFornecedor.Size = new System.Drawing.Size(148, 20);
            this.txtTipoFornecedor.TabIndex = 11;
            // 
            // panelCadastraFornecedor
            // 
            this.panelCadastraFornecedor.Controls.Add(this.label13);
            this.panelCadastraFornecedor.Controls.Add(this.txtSigla);
            this.panelCadastraFornecedor.Controls.Add(this.txtNumeroPrincipal);
            this.panelCadastraFornecedor.Controls.Add(this.labelConfirmacaoPrimario);
            this.panelCadastraFornecedor.Controls.Add(this.label11);
            this.panelCadastraFornecedor.Controls.Add(this.maskedTextBoxCep);
            this.panelCadastraFornecedor.Controls.Add(this.radioButtonOculto);
            this.panelCadastraFornecedor.Controls.Add(this.txtNomeContatoFornecedor);
            this.panelCadastraFornecedor.Controls.Add(this.labelContatoFornecedor);
            this.panelCadastraFornecedor.Controls.Add(this.txtObservacaoFornecedor);
            this.panelCadastraFornecedor.Controls.Add(this.txtTelexTelefoneFornecedor);
            this.panelCadastraFornecedor.Controls.Add(this.label9);
            this.panelCadastraFornecedor.Controls.Add(this.txtLogradouro);
            this.panelCadastraFornecedor.Controls.Add(this.buttonCepPrincipal);
            this.panelCadastraFornecedor.Controls.Add(this.txtFaxTelefoneFornecedor);
            this.panelCadastraFornecedor.Controls.Add(this.txtTelefone2Fornecedor);
            this.panelCadastraFornecedor.Controls.Add(CargoContatoFornecedor);
            this.panelCadastraFornecedor.Controls.Add(this.txtBairro);
            this.panelCadastraFornecedor.Controls.Add(this.txtCargoContatoFornecedor);
            this.panelCadastraFornecedor.Controls.Add(this.txtcomplemento);
            this.panelCadastraFornecedor.Controls.Add(this.txtCidade);
            this.panelCadastraFornecedor.Controls.Add(this.txtTelefoneFornecedor);
            this.panelCadastraFornecedor.Controls.Add(this.checkBoxClienteSituacao);
            this.panelCadastraFornecedor.Controls.Add(PaisFornecedor);
            this.panelCadastraFornecedor.Controls.Add(this.txtPaisFornecedor);
            this.panelCadastraFornecedor.Controls.Add(this.AtivoFornecedor);
            this.panelCadastraFornecedor.Controls.Add(this.txtDesPaisFornecedor);
            this.panelCadastraFornecedor.Controls.Add(this.label5);
            this.panelCadastraFornecedor.Controls.Add(DesPaisFornecedor);
            this.panelCadastraFornecedor.Controls.Add(TelexTelefoneFornecedor);
            this.panelCadastraFornecedor.Controls.Add(TipoFornecedor);
            this.panelCadastraFornecedor.Controls.Add(this.txtTipoFornecedor);
            this.panelCadastraFornecedor.Controls.Add(this.txtMunicipioFornecedor);
            this.panelCadastraFornecedor.Controls.Add(Telefone2Fornecedor);
            this.panelCadastraFornecedor.Controls.Add(CpMunicipioFornecedor);
            this.panelCadastraFornecedor.Controls.Add(this.txtCpMunicipioFornecedor);
            this.panelCadastraFornecedor.Controls.Add(this.txtEmailFornecedor);
            this.panelCadastraFornecedor.Controls.Add(this.txtNomeFornecedor);
            this.panelCadastraFornecedor.Controls.Add(FaxFornecedor);
            this.panelCadastraFornecedor.Enabled = false;
            this.panelCadastraFornecedor.Location = new System.Drawing.Point(139, 12);
            this.panelCadastraFornecedor.Name = "panelCadastraFornecedor";
            this.panelCadastraFornecedor.Size = new System.Drawing.Size(719, 300);
            this.panelCadastraFornecedor.TabIndex = 43;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(236, 109);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(84, 13);
            this.label13.TabIndex = 123;
            this.label13.Text = "SIGLA CIDADE:";
            // 
            // txtSigla
            // 
            this.txtSigla.Enabled = false;
            this.txtSigla.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSigla.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txtSigla.Location = new System.Drawing.Point(326, 106);
            this.txtSigla.Name = "txtSigla";
            this.txtSigla.Size = new System.Drawing.Size(87, 21);
            this.txtSigla.TabIndex = 122;
            // 
            // txtNumeroPrincipal
            // 
            this.txtNumeroPrincipal.Enabled = false;
            this.txtNumeroPrincipal.Location = new System.Drawing.Point(459, 39);
            this.txtNumeroPrincipal.Name = "txtNumeroPrincipal";
            this.txtNumeroPrincipal.Size = new System.Drawing.Size(40, 20);
            this.txtNumeroPrincipal.TabIndex = 113;
            this.txtNumeroPrincipal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumero_KeyPress);
            // 
            // labelConfirmacaoPrimario
            // 
            this.labelConfirmacaoPrimario.AutoSize = true;
            this.labelConfirmacaoPrimario.Location = new System.Drawing.Point(5, 28);
            this.labelConfirmacaoPrimario.Name = "labelConfirmacaoPrimario";
            this.labelConfirmacaoPrimario.Size = new System.Drawing.Size(58, 13);
            this.labelConfirmacaoPrimario.TabIndex = 113;
            this.labelConfirmacaoPrimario.Text = "Resultado:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(414, 43);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 13);
            this.label11.TabIndex = 114;
            this.label11.Text = "Numero:";
            // 
            // maskedTextBoxCep
            // 
            this.maskedTextBoxCep.Enabled = false;
            this.maskedTextBoxCep.Location = new System.Drawing.Point(5, 43);
            this.maskedTextBoxCep.Mask = "00000-000";
            this.maskedTextBoxCep.Name = "maskedTextBoxCep";
            this.maskedTextBoxCep.Size = new System.Drawing.Size(67, 20);
            this.maskedTextBoxCep.TabIndex = 103;
            this.maskedTextBoxCep.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // radioButtonOculto
            // 
            this.radioButtonOculto.AutoSize = true;
            this.radioButtonOculto.Checked = true;
            this.radioButtonOculto.Enabled = false;
            this.radioButtonOculto.Location = new System.Drawing.Point(622, 152);
            this.radioButtonOculto.Name = "radioButtonOculto";
            this.radioButtonOculto.Size = new System.Drawing.Size(56, 17);
            this.radioButtonOculto.TabIndex = 61;
            this.radioButtonOculto.TabStop = true;
            this.radioButtonOculto.Text = "Oculto";
            this.radioButtonOculto.UseVisualStyleBackColor = true;
            this.radioButtonOculto.Visible = false;
            // 
            // txtNomeContatoFornecedor
            // 
            this.txtNomeContatoFornecedor.Location = new System.Drawing.Point(588, 6);
            this.txtNomeContatoFornecedor.Name = "txtNomeContatoFornecedor";
            this.txtNomeContatoFornecedor.Size = new System.Drawing.Size(116, 20);
            this.txtNomeContatoFornecedor.TabIndex = 3;
            // 
            // labelContatoFornecedor
            // 
            this.labelContatoFornecedor.AutoSize = true;
            this.labelContatoFornecedor.Location = new System.Drawing.Point(520, 9);
            this.labelContatoFornecedor.Name = "labelContatoFornecedor";
            this.labelContatoFornecedor.Size = new System.Drawing.Size(62, 13);
            this.labelContatoFornecedor.TabIndex = 60;
            this.labelContatoFornecedor.Text = "CONTATO:";
            // 
            // txtObservacaoFornecedor
            // 
            this.txtObservacaoFornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObservacaoFornecedor.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txtObservacaoFornecedor.Location = new System.Drawing.Point(6, 246);
            this.txtObservacaoFornecedor.Multiline = true;
            this.txtObservacaoFornecedor.Name = "txtObservacaoFornecedor";
            this.txtObservacaoFornecedor.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtObservacaoFornecedor.Size = new System.Drawing.Size(698, 69);
            this.txtObservacaoFornecedor.TabIndex = 16;
            // 
            // txtTelexTelefoneFornecedor
            // 
            this.txtTelexTelefoneFornecedor.Location = new System.Drawing.Point(533, 151);
            this.txtTelexTelefoneFornecedor.Mask = "(99) 0000-0000";
            this.txtTelexTelefoneFornecedor.Name = "txtTelexTelefoneFornecedor";
            this.txtTelexTelefoneFornecedor.Size = new System.Drawing.Size(83, 20);
            this.txtTelexTelefoneFornecedor.TabIndex = 9;
            this.txtTelexTelefoneFornecedor.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(341, 75);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 13);
            this.label9.TabIndex = 127;
            this.label9.Text = "Lograd.:";
            // 
            // txtLogradouro
            // 
            this.txtLogradouro.Enabled = false;
            this.txtLogradouro.Location = new System.Drawing.Point(390, 72);
            this.txtLogradouro.Name = "txtLogradouro";
            this.txtLogradouro.Size = new System.Drawing.Size(182, 20);
            this.txtLogradouro.TabIndex = 128;
            // 
            // buttonCepPrincipal
            // 
            this.buttonCepPrincipal.Enabled = false;
            this.buttonCepPrincipal.Location = new System.Drawing.Point(578, 69);
            this.buttonCepPrincipal.Name = "buttonCepPrincipal";
            this.buttonCepPrincipal.Size = new System.Drawing.Size(85, 23);
            this.buttonCepPrincipal.TabIndex = 126;
            this.buttonCepPrincipal.Text = "Pesquisa Cep";
            this.buttonCepPrincipal.UseVisualStyleBackColor = true;
            this.buttonCepPrincipal.Click += new System.EventHandler(this.buttonCepPrincipal_Click);
            // 
            // txtFaxTelefoneFornecedor
            // 
            this.txtFaxTelefoneFornecedor.Location = new System.Drawing.Point(341, 152);
            this.txtFaxTelefoneFornecedor.Mask = "(99) 0000-0000";
            this.txtFaxTelefoneFornecedor.Name = "txtFaxTelefoneFornecedor";
            this.txtFaxTelefoneFornecedor.Size = new System.Drawing.Size(77, 20);
            this.txtFaxTelefoneFornecedor.TabIndex = 8;
            this.txtFaxTelefoneFornecedor.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // txtTelefone2Fornecedor
            // 
            this.txtTelefone2Fornecedor.Location = new System.Drawing.Point(167, 151);
            this.txtTelefone2Fornecedor.Mask = "(99) 0000-0000";
            this.txtTelefone2Fornecedor.Name = "txtTelefone2Fornecedor";
            this.txtTelefone2Fornecedor.Size = new System.Drawing.Size(73, 20);
            this.txtTelefone2Fornecedor.TabIndex = 7;
            this.txtTelefone2Fornecedor.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // txtBairro
            // 
            this.txtBairro.Enabled = false;
            this.txtBairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBairro.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txtBairro.Location = new System.Drawing.Point(574, 38);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(121, 21);
            this.txtBairro.TabIndex = 121;
            // 
            // txtcomplemento
            // 
            this.txtcomplemento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcomplemento.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txtcomplemento.Location = new System.Drawing.Point(6, 72);
            this.txtcomplemento.Name = "txtcomplemento";
            this.txtcomplemento.Size = new System.Drawing.Size(329, 21);
            this.txtcomplemento.TabIndex = 118;
            // 
            // txtCidade
            // 
            this.txtCidade.Enabled = false;
            this.txtCidade.Location = new System.Drawing.Point(8, 106);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(222, 20);
            this.txtCidade.TabIndex = 120;
            // 
            // txtTelefoneFornecedor
            // 
            this.txtTelefoneFornecedor.Location = new System.Drawing.Point(7, 151);
            this.txtTelefoneFornecedor.Mask = "(99) 0000-0000";
            this.txtTelefoneFornecedor.Name = "txtTelefoneFornecedor";
            this.txtTelefoneFornecedor.Size = new System.Drawing.Size(76, 20);
            this.txtTelefoneFornecedor.TabIndex = 6;
            this.txtTelefoneFornecedor.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // checkBoxClienteSituacao
            // 
            this.checkBoxClienteSituacao.AutoSize = true;
            this.checkBoxClienteSituacao.Location = new System.Drawing.Point(172, 216);
            this.checkBoxClienteSituacao.Name = "checkBoxClienteSituacao";
            this.checkBoxClienteSituacao.Size = new System.Drawing.Size(58, 17);
            this.checkBoxClienteSituacao.TabIndex = 0;
            this.checkBoxClienteSituacao.Text = "ATIVO";
            this.checkBoxClienteSituacao.UseVisualStyleBackColor = true;
            // 
            // AtivoFornecedor
            // 
            this.AtivoFornecedor.AutoSize = true;
            this.AtivoFornecedor.Location = new System.Drawing.Point(111, 216);
            this.AtivoFornecedor.Name = "AtivoFornecedor";
            this.AtivoFornecedor.Size = new System.Drawing.Size(55, 13);
            this.AtivoFornecedor.TabIndex = 41;
            this.AtivoFornecedor.Text = "CLIENTE:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(520, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 116;
            this.label5.Text = "BAIRRO:*";
            // 
            // labelConfirmacaoSecundario
            // 
            this.labelConfirmacaoSecundario.AutoSize = true;
            this.labelConfirmacaoSecundario.Location = new System.Drawing.Point(85, 9);
            this.labelConfirmacaoSecundario.Name = "labelConfirmacaoSecundario";
            this.labelConfirmacaoSecundario.Size = new System.Drawing.Size(58, 13);
            this.labelConfirmacaoSecundario.TabIndex = 44;
            this.labelConfirmacaoSecundario.Text = "Resultado:";
            // 
            // txtSiglaCidadeFornecedor
            // 
            this.txtSiglaCidadeFornecedor.Enabled = false;
            this.txtSiglaCidadeFornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSiglaCidadeFornecedor.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txtSiglaCidadeFornecedor.Location = new System.Drawing.Point(260, 116);
            this.txtSiglaCidadeFornecedor.Name = "txtSiglaCidadeFornecedor";
            this.txtSiglaCidadeFornecedor.Size = new System.Drawing.Size(44, 21);
            this.txtSiglaCidadeFornecedor.TabIndex = 36;
            // 
            // SiglaCidadeFornecedor
            // 
            this.SiglaCidadeFornecedor.AutoSize = true;
            this.SiglaCidadeFornecedor.Location = new System.Drawing.Point(170, 119);
            this.SiglaCidadeFornecedor.Name = "SiglaCidadeFornecedor";
            this.SiglaCidadeFornecedor.Size = new System.Drawing.Size(84, 13);
            this.SiglaCidadeFornecedor.TabIndex = 37;
            this.SiglaCidadeFornecedor.Text = "SIGLA CIDADE:";
            // 
            // txtComplFornecedor
            // 
            this.txtComplFornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComplFornecedor.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txtComplFornecedor.Location = new System.Drawing.Point(82, 82);
            this.txtComplFornecedor.Name = "txtComplFornecedor";
            this.txtComplFornecedor.Size = new System.Drawing.Size(164, 21);
            this.txtComplFornecedor.TabIndex = 35;
            // 
            // txtBairroNumeroFornecedor
            // 
            this.txtBairroNumeroFornecedor.Location = new System.Drawing.Point(384, 58);
            this.txtBairroNumeroFornecedor.Name = "txtBairroNumeroFornecedor";
            this.txtBairroNumeroFornecedor.Size = new System.Drawing.Size(57, 20);
            this.txtBairroNumeroFornecedor.TabIndex = 5;
            this.txtBairroNumeroFornecedor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBairroNumeroFornecedor_KeyPress);
            // 
            // BairroNumeroFornecedor
            // 
            this.BairroNumeroFornecedor.AutoSize = true;
            this.BairroNumeroFornecedor.Location = new System.Drawing.Point(331, 58);
            this.BairroNumeroFornecedor.Name = "BairroNumeroFornecedor";
            this.BairroNumeroFornecedor.Size = new System.Drawing.Size(47, 13);
            this.BairroNumeroFornecedor.TabIndex = 33;
            this.BairroNumeroFornecedor.Text = "Numero:";
            // 
            // txtTipo_logradouro
            // 
            this.txtTipo_logradouro.Enabled = false;
            this.txtTipo_logradouro.Location = new System.Drawing.Point(294, 24);
            this.txtTipo_logradouro.Name = "txtTipo_logradouro";
            this.txtTipo_logradouro.Size = new System.Drawing.Size(80, 20);
            this.txtTipo_logradouro.TabIndex = 0;
            // 
            // Tipo_logradouroFornecedor
            // 
            this.Tipo_logradouroFornecedor.AutoSize = true;
            this.Tipo_logradouroFornecedor.Location = new System.Drawing.Point(242, 28);
            this.Tipo_logradouroFornecedor.Name = "Tipo_logradouroFornecedor";
            this.Tipo_logradouroFornecedor.Size = new System.Drawing.Size(46, 13);
            this.Tipo_logradouroFornecedor.TabIndex = 31;
            this.Tipo_logradouroFornecedor.Text = "Lograd.:";
            // 
            // ButtonBuscaCep
            // 
            this.ButtonBuscaCep.Location = new System.Drawing.Point(155, 24);
            this.ButtonBuscaCep.Name = "ButtonBuscaCep";
            this.ButtonBuscaCep.Size = new System.Drawing.Size(81, 23);
            this.ButtonBuscaCep.TabIndex = 29;
            this.ButtonBuscaCep.Text = "Pesquisa Cep";
            this.ButtonBuscaCep.UseVisualStyleBackColor = true;
            this.ButtonBuscaCep.Click += new System.EventHandler(this.ButtonBuscaCep_Click_1);
            // 
            // txtCepFornecedor
            // 
            this.txtCepFornecedor.Location = new System.Drawing.Point(82, 25);
            this.txtCepFornecedor.Mask = "00000-000";
            this.txtCepFornecedor.Name = "txtCepFornecedor";
            this.txtCepFornecedor.Size = new System.Drawing.Size(67, 20);
            this.txtCepFornecedor.TabIndex = 4;
            this.txtCepFornecedor.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // buttonCancelarFornecedor
            // 
            this.buttonCancelarFornecedor.Location = new System.Drawing.Point(864, 67);
            this.buttonCancelarFornecedor.Name = "buttonCancelarFornecedor";
            this.buttonCancelarFornecedor.Size = new System.Drawing.Size(26, 26);
            this.buttonCancelarFornecedor.TabIndex = 20;
            this.buttonCancelarFornecedor.Text = "C";
            this.buttonCancelarFornecedor.UseVisualStyleBackColor = true;
            this.buttonCancelarFornecedor.Click += new System.EventHandler(this.buttonCancelarFornecedor_Click);
            // 
            // buttonCadastraFornecedor
            // 
            this.buttonCadastraFornecedor.Location = new System.Drawing.Point(5, 7);
            this.buttonCadastraFornecedor.Name = "buttonCadastraFornecedor";
            this.buttonCadastraFornecedor.Size = new System.Drawing.Size(61, 23);
            this.buttonCadastraFornecedor.TabIndex = 49;
            this.buttonCadastraFornecedor.Text = "Cadastrar";
            this.buttonCadastraFornecedor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonCadastraFornecedor.UseVisualStyleBackColor = true;
            this.buttonCadastraFornecedor.Click += new System.EventHandler(this.buttonCadastraFornecedor_Click);
            // 
            // buttonVerificarFornecedor
            // 
            this.buttonVerificarFornecedor.Enabled = false;
            this.buttonVerificarFornecedor.Location = new System.Drawing.Point(864, 3);
            this.buttonVerificarFornecedor.Name = "buttonVerificarFornecedor";
            this.buttonVerificarFornecedor.Size = new System.Drawing.Size(26, 26);
            this.buttonVerificarFornecedor.TabIndex = 17;
            this.buttonVerificarFornecedor.Text = "S";
            this.buttonVerificarFornecedor.UseVisualStyleBackColor = true;
            this.buttonVerificarFornecedor.Click += new System.EventHandler(this.buttonVerificarFornecedor_Click);
            // 
            // errorProviderFornecedor
            // 
            this.errorProviderFornecedor.ContainerControl = this;
            // 
            // buttonLimpaFornecedor
            // 
            this.buttonLimpaFornecedor.Location = new System.Drawing.Point(864, 35);
            this.buttonLimpaFornecedor.Name = "buttonLimpaFornecedor";
            this.buttonLimpaFornecedor.Size = new System.Drawing.Size(26, 26);
            this.buttonLimpaFornecedor.TabIndex = 72;
            this.buttonLimpaFornecedor.Text = "L";
            this.buttonLimpaFornecedor.UseVisualStyleBackColor = true;
            this.buttonLimpaFornecedor.Click += new System.EventHandler(this.buttonLimpaFornecedor_Click);
            // 
            // buttonFecharFornecedor
            // 
            this.buttonFecharFornecedor.Location = new System.Drawing.Point(864, 99);
            this.buttonFecharFornecedor.Name = "buttonFecharFornecedor";
            this.buttonFecharFornecedor.Size = new System.Drawing.Size(26, 26);
            this.buttonFecharFornecedor.TabIndex = 71;
            this.buttonFecharFornecedor.Text = "F";
            this.buttonFecharFornecedor.UseVisualStyleBackColor = true;
            this.buttonFecharFornecedor.Click += new System.EventHandler(this.buttonFecharFornecedor_Click);
            // 
            // radioButtonFornecedorFisica
            // 
            this.radioButtonFornecedorFisica.AutoSize = true;
            this.radioButtonFornecedorFisica.BackColor = System.Drawing.SystemColors.Control;
            this.radioButtonFornecedorFisica.Enabled = false;
            this.radioButtonFornecedorFisica.Location = new System.Drawing.Point(13, 272);
            this.radioButtonFornecedorFisica.Name = "radioButtonFornecedorFisica";
            this.radioButtonFornecedorFisica.Size = new System.Drawing.Size(116, 17);
            this.radioButtonFornecedorFisica.TabIndex = 82;
            this.radioButtonFornecedorFisica.Text = "Fornecedor Fisica:*";
            this.radioButtonFornecedorFisica.UseVisualStyleBackColor = false;
            this.radioButtonFornecedorFisica.CheckedChanged += new System.EventHandler(this.radioButtonFornecedorFisica_CheckedChanged_1);
            // 
            // radioButtonFornecedorJuridica
            // 
            this.radioButtonFornecedorJuridica.AutoSize = true;
            this.radioButtonFornecedorJuridica.Enabled = false;
            this.radioButtonFornecedorJuridica.Location = new System.Drawing.Point(13, 295);
            this.radioButtonFornecedorJuridica.Name = "radioButtonFornecedorJuridica";
            this.radioButtonFornecedorJuridica.Size = new System.Drawing.Size(125, 17);
            this.radioButtonFornecedorJuridica.TabIndex = 83;
            this.radioButtonFornecedorJuridica.Text = "Fornecedor Juridica:*";
            this.radioButtonFornecedorJuridica.UseVisualStyleBackColor = true;
            this.radioButtonFornecedorJuridica.CheckedChanged += new System.EventHandler(this.radioButtonFornecedorJuridica_CheckedChanged_1);
            // 
            // ComplFornecedor
            // 
            this.ComplFornecedor.AutoSize = true;
            this.ComplFornecedor.Location = new System.Drawing.Point(8, 91);
            this.ComplFornecedor.Name = "ComplFornecedor";
            this.ComplFornecedor.Size = new System.Drawing.Size(44, 13);
            this.ComplFornecedor.TabIndex = 90;
            this.ComplFornecedor.Text = "COMPL";
            // 
            // tabControlFornedor
            // 
            this.tabControlFornedor.Controls.Add(this.tabPageFornecedoresJuridica);
            this.tabControlFornedor.Controls.Add(this.tabPageFornecedoresFisica);
            this.tabControlFornedor.Controls.Add(this.tabPage1);
            this.tabControlFornedor.Enabled = false;
            this.tabControlFornedor.Location = new System.Drawing.Point(139, 345);
            this.tabControlFornedor.Name = "tabControlFornedor";
            this.tabControlFornedor.SelectedIndex = 0;
            this.tabControlFornedor.Size = new System.Drawing.Size(460, 195);
            this.tabControlFornedor.TabIndex = 91;
            // 
            // tabPageFornecedoresJuridica
            // 
            this.tabPageFornecedoresJuridica.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPageFornecedoresJuridica.Controls.Add(this.panelJuridico);
            this.tabPageFornecedoresJuridica.Location = new System.Drawing.Point(4, 22);
            this.tabPageFornecedoresJuridica.Name = "tabPageFornecedoresJuridica";
            this.tabPageFornecedoresJuridica.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageFornecedoresJuridica.Size = new System.Drawing.Size(452, 169);
            this.tabPageFornecedoresJuridica.TabIndex = 0;
            this.tabPageFornecedoresJuridica.Text = "Fornecedor Jurídica";
            // 
            // panelJuridico
            // 
            this.panelJuridico.Controls.Add(this.txtCnae);
            this.panelJuridico.Controls.Add(this.label1CNAE);
            this.panelJuridico.Controls.Add(nOME_CONTATOLabel);
            this.panelJuridico.Controls.Add(this.txtNomeContato);
            this.panelJuridico.Controls.Add(rAZAO_SOCIALLabel);
            this.panelJuridico.Controls.Add(this.txtRazaoSocial);
            this.panelJuridico.Controls.Add(iNSCRICAO_STADUALLabel);
            this.panelJuridico.Controls.Add(this.txtInscStatual);
            this.panelJuridico.Controls.Add(cNPJLabel);
            this.panelJuridico.Controls.Add(this.txtCnpj);
            this.panelJuridico.Controls.Add(this.label3);
            this.panelJuridico.Location = new System.Drawing.Point(6, 6);
            this.panelJuridico.Name = "panelJuridico";
            this.panelJuridico.Size = new System.Drawing.Size(439, 157);
            this.panelJuridico.TabIndex = 11;
            // 
            // txtCnae
            // 
            this.txtCnae.Enabled = false;
            this.txtCnae.Location = new System.Drawing.Point(51, 106);
            this.txtCnae.Name = "txtCnae";
            this.txtCnae.Size = new System.Drawing.Size(368, 20);
            this.txtCnae.TabIndex = 77;
            // 
            // label1CNAE
            // 
            this.label1CNAE.AutoSize = true;
            this.label1CNAE.Location = new System.Drawing.Point(6, 111);
            this.label1CNAE.Name = "label1CNAE";
            this.label1CNAE.Size = new System.Drawing.Size(39, 13);
            this.label1CNAE.TabIndex = 76;
            this.label1CNAE.Text = "CNAE:";
            // 
            // txtNomeContato
            // 
            this.txtNomeContato.Location = new System.Drawing.Point(109, 81);
            this.txtNomeContato.Name = "txtNomeContato";
            this.txtNomeContato.Size = new System.Drawing.Size(310, 20);
            this.txtNomeContato.TabIndex = 4;
            // 
            // txtRazaoSocial
            // 
            this.txtRazaoSocial.Enabled = false;
            this.txtRazaoSocial.Location = new System.Drawing.Point(240, 29);
            this.txtRazaoSocial.Name = "txtRazaoSocial";
            this.txtRazaoSocial.Size = new System.Drawing.Size(179, 20);
            this.txtRazaoSocial.TabIndex = 2;
            // 
            // txtInscStatual
            // 
            this.txtInscStatual.Enabled = false;
            this.txtInscStatual.Location = new System.Drawing.Point(132, 55);
            this.txtInscStatual.Name = "txtInscStatual";
            this.txtInscStatual.Size = new System.Drawing.Size(287, 20);
            this.txtInscStatual.TabIndex = 3;
            // 
            // txtCnpj
            // 
            this.txtCnpj.Enabled = false;
            this.txtCnpj.Location = new System.Drawing.Point(40, 29);
            this.txtCnpj.Name = "txtCnpj";
            this.txtCnpj.Size = new System.Drawing.Size(100, 20);
            this.txtCnpj.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Cadastro de Pessoa Juridica:";
            // 
            // tabPageFornecedoresFisica
            // 
            this.tabPageFornecedoresFisica.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPageFornecedoresFisica.Controls.Add(this.panelFisica);
            this.tabPageFornecedoresFisica.Location = new System.Drawing.Point(4, 22);
            this.tabPageFornecedoresFisica.Name = "tabPageFornecedoresFisica";
            this.tabPageFornecedoresFisica.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageFornecedoresFisica.Size = new System.Drawing.Size(452, 169);
            this.tabPageFornecedoresFisica.TabIndex = 1;
            this.tabPageFornecedoresFisica.Text = "Fornecedor Fisíca";
            // 
            // panelFisica
            // 
            this.panelFisica.Controls.Add(this.txtNomePFisica);
            this.panelFisica.Controls.Add(this.label2);
            this.panelFisica.Controls.Add(this.txtCelularFFisica2);
            this.panelFisica.Controls.Add(this.comboBoxSexoFFIsica);
            this.panelFisica.Controls.Add(this.txtCelularFFisica);
            this.panelFisica.Controls.Add(this.txtCpfFFisica);
            this.panelFisica.Controls.Add(this.txtDataNascimentoFFisica);
            this.panelFisica.Controls.Add(this.Celular2PFisica);
            this.panelFisica.Controls.Add(this.txtRgFisica);
            this.panelFisica.Controls.Add(this.RgPFisica);
            this.panelFisica.Controls.Add(this.CelularPFisica);
            this.panelFisica.Controls.Add(this.DataNascimentoPF);
            this.panelFisica.Controls.Add(this.CpfPFisica);
            this.panelFisica.Controls.Add(this.SexoPFisica);
            this.panelFisica.Controls.Add(this.checkboxtxtFisica);
            this.panelFisica.Location = new System.Drawing.Point(3, 6);
            this.panelFisica.Name = "panelFisica";
            this.panelFisica.Size = new System.Drawing.Size(329, 168);
            this.panelFisica.TabIndex = 10;
            // 
            // txtNomePFisica
            // 
            this.txtNomePFisica.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtNomePFisica.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txtNomePFisica.Location = new System.Drawing.Point(54, 43);
            this.txtNomePFisica.Name = "txtNomePFisica";
            this.txtNomePFisica.Size = new System.Drawing.Size(267, 21);
            this.txtNomePFisica.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(6, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "NOME:";
            // 
            // txtCelularFFisica2
            // 
            this.txtCelularFFisica2.Location = new System.Drawing.Point(239, 124);
            this.txtCelularFFisica2.Mask = "(00)00000-0000";
            this.txtCelularFFisica2.Name = "txtCelularFFisica2";
            this.txtCelularFFisica2.Size = new System.Drawing.Size(81, 20);
            this.txtCelularFFisica2.TabIndex = 6;
            this.txtCelularFFisica2.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // comboBoxSexoFFIsica
            // 
            this.comboBoxSexoFFIsica.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSexoFFIsica.FormattingEnabled = true;
            this.comboBoxSexoFFIsica.Items.AddRange(new object[] {
            "M",
            "F"});
            this.comboBoxSexoFFIsica.Location = new System.Drawing.Point(50, 72);
            this.comboBoxSexoFFIsica.Name = "comboBoxSexoFFIsica";
            this.comboBoxSexoFFIsica.Size = new System.Drawing.Size(37, 21);
            this.comboBoxSexoFFIsica.TabIndex = 1;
            // 
            // txtCelularFFisica
            // 
            this.txtCelularFFisica.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.txtCelularFFisica.Location = new System.Drawing.Point(77, 125);
            this.txtCelularFFisica.Mask = "(99) 00000-0000";
            this.txtCelularFFisica.Name = "txtCelularFFisica";
            this.txtCelularFFisica.Size = new System.Drawing.Size(84, 20);
            this.txtCelularFFisica.TabIndex = 5;
            this.txtCelularFFisica.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // txtCpfFFisica
            // 
            this.txtCpfFFisica.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.txtCpfFFisica.Location = new System.Drawing.Point(130, 71);
            this.txtCpfFFisica.Mask = "000000000-00";
            this.txtCpfFFisica.Name = "txtCpfFFisica";
            this.txtCpfFFisica.Size = new System.Drawing.Size(73, 20);
            this.txtCpfFFisica.TabIndex = 2;
            this.txtCpfFFisica.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // txtDataNascimentoFFisica
            // 
            this.txtDataNascimentoFFisica.CustomFormat = "MM/dd/YYYY";
            this.txtDataNascimentoFFisica.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtDataNascimentoFFisica.Location = new System.Drawing.Point(142, 98);
            this.txtDataNascimentoFFisica.Name = "txtDataNascimentoFFisica";
            this.txtDataNascimentoFFisica.RightToLeftLayout = true;
            this.txtDataNascimentoFFisica.Size = new System.Drawing.Size(78, 20);
            this.txtDataNascimentoFFisica.TabIndex = 4;
            this.txtDataNascimentoFFisica.Value = new System.DateTime(2017, 1, 10, 0, 0, 0, 0);
            // 
            // Celular2PFisica
            // 
            this.Celular2PFisica.AllowDrop = true;
            this.Celular2PFisica.AutoSize = true;
            this.Celular2PFisica.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Celular2PFisica.Location = new System.Drawing.Point(167, 128);
            this.Celular2PFisica.Name = "Celular2PFisica";
            this.Celular2PFisica.Size = new System.Drawing.Size(65, 13);
            this.Celular2PFisica.TabIndex = 1;
            this.Celular2PFisica.Text = "CELULAR2:";
            // 
            // txtRgFisica
            // 
            this.txtRgFisica.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtRgFisica.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txtRgFisica.Location = new System.Drawing.Point(241, 72);
            this.txtRgFisica.Name = "txtRgFisica";
            this.txtRgFisica.Size = new System.Drawing.Size(79, 21);
            this.txtRgFisica.TabIndex = 3;
            // 
            // RgPFisica
            // 
            this.RgPFisica.AutoSize = true;
            this.RgPFisica.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.RgPFisica.Location = new System.Drawing.Point(209, 75);
            this.RgPFisica.Name = "RgPFisica";
            this.RgPFisica.Size = new System.Drawing.Size(30, 13);
            this.RgPFisica.TabIndex = 1;
            this.RgPFisica.Text = "RG:*";
            // 
            // CelularPFisica
            // 
            this.CelularPFisica.AutoSize = true;
            this.CelularPFisica.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.CelularPFisica.Location = new System.Drawing.Point(5, 130);
            this.CelularPFisica.Name = "CelularPFisica";
            this.CelularPFisica.Size = new System.Drawing.Size(63, 13);
            this.CelularPFisica.TabIndex = 1;
            this.CelularPFisica.Text = "CELULAR:*";
            // 
            // DataNascimentoPF
            // 
            this.DataNascimentoPF.AutoSize = true;
            this.DataNascimentoPF.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.DataNascimentoPF.Location = new System.Drawing.Point(5, 101);
            this.DataNascimentoPF.Name = "DataNascimentoPF";
            this.DataNascimentoPF.Size = new System.Drawing.Size(131, 13);
            this.DataNascimentoPF.TabIndex = 1;
            this.DataNascimentoPF.Text = "DATA DE NASCIMENTO:";
            // 
            // CpfPFisica
            // 
            this.CpfPFisica.AutoSize = true;
            this.CpfPFisica.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.CpfPFisica.Location = new System.Drawing.Point(93, 75);
            this.CpfPFisica.Name = "CpfPFisica";
            this.CpfPFisica.Size = new System.Drawing.Size(34, 13);
            this.CpfPFisica.TabIndex = 1;
            this.CpfPFisica.Text = "CPF:*";
            // 
            // SexoPFisica
            // 
            this.SexoPFisica.AutoSize = true;
            this.SexoPFisica.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.SexoPFisica.Location = new System.Drawing.Point(5, 76);
            this.SexoPFisica.Name = "SexoPFisica";
            this.SexoPFisica.Size = new System.Drawing.Size(43, 13);
            this.SexoPFisica.TabIndex = 1;
            this.SexoPFisica.Text = "SEXO:*";
            // 
            // checkboxtxtFisica
            // 
            this.checkboxtxtFisica.AutoSize = true;
            this.checkboxtxtFisica.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.checkboxtxtFisica.Location = new System.Drawing.Point(3, 4);
            this.checkboxtxtFisica.Name = "checkboxtxtFisica";
            this.checkboxtxtFisica.Size = new System.Drawing.Size(135, 13);
            this.checkboxtxtFisica.TabIndex = 1;
            this.checkboxtxtFisica.Text = "Cadastro de Pessoa Fisica:";
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage1.Controls.Add(this.ButtonBuscaCep);
            this.tabPage1.Controls.Add(this.txtCidadeFornecedor);
            this.tabPage1.Controls.Add(CidadadeFornecedor);
            this.tabPage1.Controls.Add(this.labelConfirmacaoSecundario);
            this.tabPage1.Controls.Add(this.ComplFornecedor);
            this.tabPage1.Controls.Add(this.txtBairroFornecedor);
            this.tabPage1.Controls.Add(BairroFornecedor);
            this.tabPage1.Controls.Add(EnderecoFornecedor);
            this.tabPage1.Controls.Add(this.txtEnderecoFornecedor);
            this.tabPage1.Controls.Add(this.txtCepFornecedor);
            this.tabPage1.Controls.Add(CepFornecedor);
            this.tabPage1.Controls.Add(this.Tipo_logradouroFornecedor);
            this.tabPage1.Controls.Add(this.txtTipo_logradouro);
            this.tabPage1.Controls.Add(this.txtBairroNumeroFornecedor);
            this.tabPage1.Controls.Add(this.txtComplFornecedor);
            this.tabPage1.Controls.Add(this.SiglaCidadeFornecedor);
            this.tabPage1.Controls.Add(this.txtSiglaCidadeFornecedor);
            this.tabPage1.Controls.Add(this.BairroNumeroFornecedor);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(452, 169);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Endereço";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 117;
            this.label1.Text = "CEP:*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(553, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 123;
            this.label4.Text = "Numero:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(598, 45);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(40, 20);
            this.textBox1.TabIndex = 122;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(151, 46);
            this.maskedTextBox1.Mask = "00000-000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(67, 20);
            this.maskedTextBox1.TabIndex = 119;
            this.maskedTextBox1.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 114;
            this.label6.Text = "COMPL";
            // 
            // txtEndereco
            // 
            this.txtEndereco.Enabled = false;
            this.txtEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEndereco.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txtEndereco.Location = new System.Drawing.Point(304, 45);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(243, 21);
            this.txtEndereco.TabIndex = 125;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 112);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 115;
            this.label7.Text = "CIDADE:*";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(224, 49);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 13);
            this.label8.TabIndex = 124;
            this.label8.Text = "ENDEREÇO:*";
            // 
            // pictureBoxLetras
            // 
            this.pictureBoxLetras.Enabled = false;
            this.pictureBoxLetras.Location = new System.Drawing.Point(598, 447);
            this.pictureBoxLetras.Name = "pictureBoxLetras";
            this.pictureBoxLetras.Size = new System.Drawing.Size(189, 95);
            this.pictureBoxLetras.TabIndex = 135;
            this.pictureBoxLetras.TabStop = false;
            this.pictureBoxLetras.Visible = false;
            // 
            // txtLetrasConulta
            // 
            this.txtLetrasConulta.Enabled = false;
            this.txtLetrasConulta.Location = new System.Drawing.Point(704, 421);
            this.txtLetrasConulta.Name = "txtLetrasConulta";
            this.txtLetrasConulta.Size = new System.Drawing.Size(83, 20);
            this.txtLetrasConulta.TabIndex = 134;
            this.txtLetrasConulta.Visible = false;
            this.txtLetrasConulta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLetrasConulta_KeyPress);
            // 
            // txtCnpjConsulta
            // 
            this.txtCnpjConsulta.Enabled = false;
            this.txtCnpjConsulta.Location = new System.Drawing.Point(598, 421);
            this.txtCnpjConsulta.Name = "txtCnpjConsulta";
            this.txtCnpjConsulta.Size = new System.Drawing.Size(100, 20);
            this.txtCnpjConsulta.TabIndex = 133;
            this.txtCnpjConsulta.Visible = false;
            this.txtCnpjConsulta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCnpjConsulta_KeyPress);
            // 
            // buttonTrocaImagem
            // 
            this.buttonTrocaImagem.Enabled = false;
            this.buttonTrocaImagem.Location = new System.Drawing.Point(759, 367);
            this.buttonTrocaImagem.Name = "buttonTrocaImagem";
            this.buttonTrocaImagem.Size = new System.Drawing.Size(75, 35);
            this.buttonTrocaImagem.TabIndex = 131;
            this.buttonTrocaImagem.Text = "Trocar Imagem";
            this.buttonTrocaImagem.UseVisualStyleBackColor = true;
            this.buttonTrocaImagem.Visible = false;
            this.buttonTrocaImagem.Click += new System.EventHandler(this.buttonTrocaImagem_Click_1);
            // 
            // buttonConsultaCnpj
            // 
            this.buttonConsultaCnpj.Enabled = false;
            this.buttonConsultaCnpj.Location = new System.Drawing.Point(678, 367);
            this.buttonConsultaCnpj.Name = "buttonConsultaCnpj";
            this.buttonConsultaCnpj.Size = new System.Drawing.Size(75, 35);
            this.buttonConsultaCnpj.TabIndex = 130;
            this.buttonConsultaCnpj.Text = "Consultar CNPJ";
            this.buttonConsultaCnpj.UseVisualStyleBackColor = true;
            this.buttonConsultaCnpj.Visible = false;
            this.buttonConsultaCnpj.Click += new System.EventHandler(this.buttonConsultaCnpj_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonCadastraFornecedor);
            this.panel1.Location = new System.Drawing.Point(601, 367);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(71, 35);
            this.panel1.TabIndex = 129;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(602, 404);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 13);
            this.label10.TabIndex = 136;
            this.label10.Text = "CNPJ Consulta:";
            this.label10.Visible = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(707, 404);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(39, 13);
            this.label12.TabIndex = 137;
            this.label12.Text = "Letras:";
            this.label12.Visible = false;
            // 
            // buttonCnpjAutomatico
            // 
            this.buttonCnpjAutomatico.Enabled = false;
            this.buttonCnpjAutomatico.Location = new System.Drawing.Point(12, 356);
            this.buttonCnpjAutomatico.Name = "buttonCnpjAutomatico";
            this.buttonCnpjAutomatico.Size = new System.Drawing.Size(75, 23);
            this.buttonCnpjAutomatico.TabIndex = 139;
            this.buttonCnpjAutomatico.Text = "Automático";
            this.buttonCnpjAutomatico.UseVisualStyleBackColor = true;
            this.buttonCnpjAutomatico.Click += new System.EventHandler(this.buttonCnpjAutomatico_Click);
            // 
            // buttonCnpjManual
            // 
            this.buttonCnpjManual.Enabled = false;
            this.buttonCnpjManual.Location = new System.Drawing.Point(12, 334);
            this.buttonCnpjManual.Name = "buttonCnpjManual";
            this.buttonCnpjManual.Size = new System.Drawing.Size(75, 23);
            this.buttonCnpjManual.TabIndex = 138;
            this.buttonCnpjManual.Text = "Manual";
            this.buttonCnpjManual.UseVisualStyleBackColor = true;
            this.buttonCnpjManual.Click += new System.EventHandler(this.buttonCnpjManual_Click);
            // 
            // fFornecedorPessoaBindingSource
            // 
            this.fFornecedorPessoaBindingSource.DataSource = typeof(DateSystem.F_FornecedorPessoa);
            // 
            // FormFornecedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 558);
            this.ControlBox = false;
            this.Controls.Add(this.buttonCnpjAutomatico);
            this.Controls.Add(this.buttonCnpjManual);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.pictureBoxLetras);
            this.Controls.Add(this.txtLetrasConulta);
            this.Controls.Add(this.txtCnpjConsulta);
            this.Controls.Add(this.buttonTrocaImagem);
            this.Controls.Add(this.buttonConsultaCnpj);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabControlFornedor);
            this.Controls.Add(this.radioButtonFornecedorFisica);
            this.Controls.Add(this.radioButtonFornecedorJuridica);
            this.Controls.Add(ObservacaoFornecedor);
            this.Controls.Add(MunicipioFornecedor);
            this.Controls.Add(TelefoneFornecedor);
            this.Controls.Add(this.label8);
            this.Controls.Add(NomeFornecedor);
            this.Controls.Add(EmailFornecedor);
            this.Controls.Add(this.buttonLimpaFornecedor);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtEndereco);
            this.Controls.Add(this.buttonFecharFornecedor);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panelCadastraFornecedor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.p_ClientePessoaBindingNavigator);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonCancelarFornecedor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonVerificarFornecedor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormFornecedores";
            this.Text = "Cadastro de Fornecedor - Os campos em \" *\" são  obrigatórios!";
            this.Load += new System.EventHandler(this.FormFornecedores_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FormFornecedores_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.p_ClientePessoaBindingNavigator)).EndInit();
            this.p_ClientePessoaBindingNavigator.ResumeLayout(false);
            this.p_ClientePessoaBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.p_ClientePessoaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.f_FornecedorPessoaBindingSource)).EndInit();
            this.panelCadastraFornecedor.ResumeLayout(false);
            this.panelCadastraFornecedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderFornecedor)).EndInit();
            this.tabControlFornedor.ResumeLayout(false);
            this.tabPageFornecedoresJuridica.ResumeLayout(false);
            this.panelJuridico.ResumeLayout(false);
            this.panelJuridico.PerformLayout();
            this.tabPageFornecedoresFisica.ResumeLayout(false);
            this.panelFisica.ResumeLayout(false);
            this.panelFisica.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLetras)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fFornecedorPessoaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource p_ClientePessoaBindingSource;
        private System.Windows.Forms.BindingNavigator p_ClientePessoaBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton p_ClientePessoaBindingNavigatorSaveItem;
        private System.Windows.Forms.BindingSource f_FornecedorPessoaBindingSource;
        private System.Windows.Forms.TextBox txtBairroFornecedor;
        private System.Windows.Forms.TextBox txtCargoContatoFornecedor;
        private System.Windows.Forms.TextBox txtCidadeFornecedor;
        private System.Windows.Forms.TextBox txtCpMunicipioFornecedor;
        private System.Windows.Forms.TextBox txtDesPaisFornecedor;
        private System.Windows.Forms.TextBox txtEmailFornecedor;
        private System.Windows.Forms.TextBox txtEnderecoFornecedor;
        private System.Windows.Forms.TextBox txtMunicipioFornecedor;
        private System.Windows.Forms.TextBox txtNomeFornecedor;
        private System.Windows.Forms.TextBox txtPaisFornecedor;
        private System.Windows.Forms.TextBox txtTipoFornecedor;
        private System.Windows.Forms.Panel panelCadastraFornecedor;
        private System.Windows.Forms.MaskedTextBox txtCepFornecedor;
        private System.Windows.Forms.Button ButtonBuscaCep;
        private System.Windows.Forms.TextBox txtTipo_logradouro;
        private System.Windows.Forms.Label Tipo_logradouroFornecedor;
        private System.Windows.Forms.TextBox txtBairroNumeroFornecedor;
        private System.Windows.Forms.Label BairroNumeroFornecedor;
        private System.Windows.Forms.TextBox txtComplFornecedor;
        private System.Windows.Forms.TextBox txtSiglaCidadeFornecedor;
        private System.Windows.Forms.Label SiglaCidadeFornecedor;
        private System.Windows.Forms.CheckBox checkBoxClienteSituacao;
        private System.Windows.Forms.Label AtivoFornecedor;
        private System.Windows.Forms.MaskedTextBox txtTelexTelefoneFornecedor;
        private System.Windows.Forms.MaskedTextBox txtFaxTelefoneFornecedor;
        private System.Windows.Forms.MaskedTextBox txtTelefone2Fornecedor;
        private System.Windows.Forms.MaskedTextBox txtTelefoneFornecedor;
        private System.Windows.Forms.TextBox txtObservacaoFornecedor;
        private System.Windows.Forms.Label labelConfirmacaoSecundario;
        private System.Windows.Forms.ErrorProvider errorProviderFornecedor;
        private System.Windows.Forms.Button buttonVerificarFornecedor;
        private System.Windows.Forms.Button buttonCancelarFornecedor;
        private System.Windows.Forms.Button buttonCadastraFornecedor;
        private System.Windows.Forms.TextBox txtNomeContatoFornecedor;
        private System.Windows.Forms.Label labelContatoFornecedor;
        private BindingSource fFornecedorPessoaBindingSource;
        private RadioButton radioButtonOculto;
        private Button buttonLimpaFornecedor;
        private Button buttonFecharFornecedor;
        private RadioButton radioButtonFornecedorFisica;
        private RadioButton radioButtonFornecedorJuridica;
        private Label ComplFornecedor;
        private TabControl tabControlFornedor;
        private TabPage tabPageFornecedoresJuridica;
        private TabPage tabPageFornecedoresFisica;
        private Panel panelFisica;
        private TextBox txtNomePFisica;
        private Label label2;
        private MaskedTextBox txtCelularFFisica2;
        private ComboBox comboBoxSexoFFIsica;
        private MaskedTextBox txtCelularFFisica;
        private MaskedTextBox txtCpfFFisica;
        private DateTimePicker txtDataNascimentoFFisica;
        private Label Celular2PFisica;
        private TextBox txtRgFisica;
        private Label RgPFisica;
        private Label CelularPFisica;
        private Label DataNascimentoPF;
        private Label CpfPFisica;
        private Label SexoPFisica;
        private Label checkboxtxtFisica;
        private Panel panelJuridico;
        private TextBox txtNomeContato;
        private TextBox txtRazaoSocial;
        private TextBox txtInscStatual;
        private TextBox txtCnpj;
        private Label label3;
        private TabPage tabPage1;
        private Label labelConfirmacaoPrimario;
        private Label label9;
        private TextBox txtLogradouro;
        private Button buttonCepPrincipal;
        private TextBox txtCidade;
        private TextBox txtcomplemento;
        private Label label8;
        private TextBox txtBairro;
        //private BindingSource pClientePessoaBindingSource;
        private Label label7;
        private TextBox txtEndereco;
        private Label label6;
        private Label label5;
        private Label label1;
        private MaskedTextBox maskedTextBox1;
        private TextBox textBox1;
        private Label label4;
        private MaskedTextBox maskedTextBoxCep;
        private TextBox txtNumeroPrincipal;
        private Label label11;
        private PictureBox pictureBoxLetras;
        private TextBox txtLetrasConulta;
        private TextBox txtCnpjConsulta;
        private Button buttonTrocaImagem;
        private Button buttonConsultaCnpj;
        private Panel panel1;
        private TextBox txtCnae;
        private Label label1CNAE;
        private Label label12;
        private Label label10;
        private Button buttonCnpjAutomatico;
        private Button buttonCnpjManual;
        private Label label13;
        private TextBox txtSigla;
        //     private BindingSource f_CepfBindingSource;
    }
}