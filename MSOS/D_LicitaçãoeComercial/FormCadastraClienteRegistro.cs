using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Reflection;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using static System.Console;
using System.Diagnostics;
using System.Threading;

namespace DateSystem
{
    public partial class FormCadastraClienteRegistro : Form
    {
        private string operacao = "";

        int SiteOFF = 0;

        int SiteTime = 0;

        Boolean verificador = false;
        Boolean CepSecundario = false;

        

        //public clsEmpresa empresa;
        private ConsultaCNPJReceita consulta;

        private int ID_PESSOAFISICA = 0;
        public int idPessoaFisica
        {
            get
            {
                return this.ID_PESSOAFISICA;

            }
            set
            {
                this.ID_PESSOAFISICA = value;
            }
        }
        private int ID_PESSOAJURIDICA = 0;
        public int idPessoaJuridica
        {
            get
            {
                return this.ID_PESSOAJURIDICA;

            }
            set
            {
                this.ID_PESSOAJURIDICA = value;
            }
        }
        private int ID_TIPO_PESSOA = 0;
        public int idPessoaTipo
        {
            get
            {
                return this.ID_TIPO_PESSOA;

            }
            set
            {
                this.ID_TIPO_PESSOA = value;
            }
        }
        private int IDPESSOA = 0;
        public int IdPessoa
        {
            get
            {
                return this.IDPESSOA;

            }
            set
            {
                this.IDPESSOA = value;
            }
        }
        private int ID_IDENTIFICADOR_CNPJ = 0;
        public int IdIdentificador_Cnpj
        {
            get
            {
                return this.ID_IDENTIFICADOR_CNPJ;

            }
            set
            {
                this.ID_IDENTIFICADOR_CNPJ = value;
            }
        }


        private int IDENTIFICADOR_CNPJ = 0;
        public int Identificador_Cnpj
        {
            get
            {
                return this.IDENTIFICADOR_CNPJ;

            }
            set
            {
                this.IDENTIFICADOR_CNPJ = value;
            }
        }
        private string NOMESERVIDOR = "";
        public string NomeServidor
        {
            get
            {
                return this.NOMESERVIDOR;

            }
            set
            {
                this.NOMESERVIDOR = value;
            }
        }
        private string BASE_DADOS = "";
        public string BaseDados
        {
            get
            {
                return this.BASE_DADOS;

            }
            set
            {
                this.BASE_DADOS = value;
            }
        }
        private string NOMEBASEDADOS = "";
        public string NomeBaseDados
        {
            get
            {
                return this.NOMEBASEDADOS;

            }
            set
            {
                this.NOMEBASEDADOS = value;
            }
        }
        private string NOMEUSUARIO = "";
        public string NomeUsuario
        {
            get
            {
                return this.NOMEUSUARIO;

            }
            set
            {
                this.NOMEUSUARIO = value;
            }
        }
        private string SENHABASEDADOS = "";
        public string SenhaBaseDados
        {
            get
            {
                return this.SENHABASEDADOS;

            }
            set
            {
                this.SENHABASEDADOS = value;
            }
        }

        private string CONNECTIONSTRING = "";
        public string connetionString
        {
            get
            {
                return this.CONNECTIONSTRING;

            }
            set
            {
                this.CONNECTIONSTRING = value;
            }
        }

        int TrocaCepBotaoTempoOs = 0;
        int TrocaCepBotaoTempoOs2 = 0;
        int CepManual = 0;
        int CepManualSe = 0;
        public FormCadastraClienteRegistro()
        {
            InitializeComponent();
        }

        public FormCadastraClienteRegistro(string NomeServidor, string NomeBaseDados, string NomeUsuario, string SenhaBaseDados)
        {
            InitializeComponent();

            this.NomeServidor = NomeServidor;
            this.NomeBaseDados = NomeBaseDados;
            this.NomeUsuario = NomeUsuario;
            this.SenhaBaseDados = SenhaBaseDados;
            this.connetionString = "Data Source=" + this.NomeServidor + ";Initial Catalog=" + this.NomeBaseDados + ";Persist Security Info=True;User ID=" + this.NomeUsuario + ";Password=" + this.SenhaBaseDados + ";";
        }
        private Boolean validaNome(TextBox textBox, ErrorProvider errorProvider)
        {
            if (!String.IsNullOrWhiteSpace(txtNomeCliente.Text))
            {
                errorProviderCadastraClienteRegistro.SetError(textBox, "");
                return true;
            }
            else
            {
                errorProviderCadastraClienteRegistro.SetError(textBox, "Nome Inválido!");
                return false;
            }

        }
        // VALIDAR ENTRADA COM ERROPROVIDER
        private Boolean validaEndereco(TextBox textBox, ErrorProvider errorProvider)
        {
            if (!String.IsNullOrWhiteSpace(txtEnderecoCliente.Text))
            {
                errorProviderCadastraClienteRegistro.SetError(textBox, "");
                return true;
            }
            else
            {
                errorProviderCadastraClienteRegistro.SetError(textBox, "Endereço Inválido!");
                return false;
            }
        }
        // VALIDAR ENTRADA COM ERROPROVIDER
        private Boolean validaTelefone(TextBox textBox, ErrorProvider errorProvider)
        {
            if (!String.IsNullOrWhiteSpace(txtTelefoneCliente.Text))
            {
                errorProviderCadastraClienteRegistro.SetError(textBox, "");
                return true;
            }
            else
            {
                errorProviderCadastraClienteRegistro.SetError(textBox, "Telefone Inválido!");
                return false;
            }
        }
        // VALIDAR ENTRADA COM ERROPROVIDER
        private Boolean validaBairro(TextBox textBox, ErrorProvider errorProvider)
        {
            if (!String.IsNullOrWhiteSpace(txtBairroCliente.Text))
            {
                errorProviderCadastraClienteRegistro.SetError(textBox, "");
                return true;
            }
            else
            {
                errorProviderCadastraClienteRegistro.SetError(textBox, "Bairro Inválido!");
                return false;
            }
        }
        // VALIDAR ENTRADA COM ERROPROVIDER
        private Boolean validaCep(MaskedTextBox textBox, ErrorProvider errorProvider)
        {
            if (!String.IsNullOrWhiteSpace(txtCepCliente.Text))
            {
                errorProviderCadastraClienteRegistro.SetError(textBox, "");
                return true;
            }
            else
            {
                errorProviderCadastraClienteRegistro.SetError(textBox, "Cep Inválido!");
                return false;
            }
        }
        // VALIDAR ENTRADA COM ERROPROVIDER
        private Boolean validaCidade(TextBox textBox, ErrorProvider errorProvider)
        {
            if (!String.IsNullOrWhiteSpace(txtCidadeCliente.Text))
            {
                errorProviderCadastraClienteRegistro.SetError(textBox, "");
                return true;
            }
            else
            {
                errorProviderCadastraClienteRegistro.SetError(textBox, "Cidade Inválido!");
                return false;
            }
        }
        // VALIDAR ENTRADA COM ERROPROVIDER
        private Boolean validaEmail(TextBox textBox, ErrorProvider errorProvider)
        {
            string email = txtEmailCliente.Text;
            string modelo = @"[\w\.-]+(\+[\w-]*)?@([\w-]+\.)+[\w-]+";

            if (Regex.IsMatch(email, modelo))
            {
                errorProviderCadastraClienteRegistro.SetError(textBox, "");
                return true;
            }
            else
            {
                errorProviderCadastraClienteRegistro.SetError(textBox, "E-mail Inválido!");
                return false;
            }
        }
        //private Boolean validaNumeroSecundario(TextBox textBox, ErrorProvider errorProvider)
        //{
        //    if (!String.IsNullOrWhiteSpace(txtBairroNumero.Text))
        //    {
        //        errorProviderCadastraClienteRegistro.SetError(textBox, "");
        //        return true;
        //    }
        //    else
        //    {
        //        errorProviderCadastraClienteRegistro.SetError(textBox, "Numero Inválido!");
        //        return false;
        //    }
        //}
        // VALIDAR ENTRADA COM ERROPROVIDER
        private Boolean NomePFisica(TextBox textBox, ErrorProvider errorProvider)
        {
            if (!String.IsNullOrWhiteSpace(txtNomePFisica.Text))
            {
                errorProviderCadastraClienteRegistro.SetError(textBox, "");
                return true;
            }
            else
            {
                errorProviderCadastraClienteRegistro.SetError(textBox, "Rg Inválido!");
                return false;
            }
        }


        // VALIDAR ENTRADA COM ERROPROVIDER
        private bool validaSexo()
        {
            // Determine whether the favorite color has a valid value.
            return ((comboBoxSexoPFIsica.SelectedItem != null) &&
                (!comboBoxSexoPFIsica.SelectedItem.ToString().Equals("")));//none
        }
        // VALIDAR ENTRADA COM ERROPROVIDER
        private Boolean validaRg(TextBox textBox, ErrorProvider errorProvider)
        {
            if (!String.IsNullOrWhiteSpace(txtRgFisica.Text))
            {
                errorProviderCadastraClienteRegistro.SetError(textBox, "");
                return true;
            }
            else
            {
                errorProviderCadastraClienteRegistro.SetError(textBox, "Rg Inválido!");
                return false;
            }
        }
        // VALIDAR ENTRADA COM ERROPROVIDER
        private Boolean validaCpf(MaskedTextBox textBox, ErrorProvider errorProvider)
        {
            if (!String.IsNullOrWhiteSpace(txtCpfPFisica.Text))
            {
                errorProviderCadastraClienteRegistro.SetError(textBox, "");
                return true;
            }
            else
            {
                errorProviderCadastraClienteRegistro.SetError(textBox, "Cpf Inválido!");
                return false;
            }
        }
        // VALIDAR ENTRADA COM ERROPROVIDER
        private bool validaCelular(MaskedTextBox textBox, ErrorProvider errorProvider)
        {
            if (!String.IsNullOrWhiteSpace(txtCelularPFisica.Text))
            {
                errorProviderCadastraClienteRegistro.SetError(textBox, "");
                return true;
            }
            else
            {
                errorProviderCadastraClienteRegistro.SetError(textBox, "Celular Inválido!");
                return false;
            }
        }
        private bool validaCelular2(MaskedTextBox textBox, ErrorProvider errorProvider)
        {
            if (!String.IsNullOrWhiteSpace(txtCelularPFisica2.Text))
            {
                errorProviderCadastraClienteRegistro.SetError(textBox, "");
                return true;
            }
            else
            {
                errorProviderCadastraClienteRegistro.SetError(textBox, "Celular Inválido!");
                return false;
            }
        }
        //Cep a verificar Principal
        private bool Cep(MaskedTextBox textBox, ErrorProvider errorProvider)
        {
            if (!String.IsNullOrWhiteSpace(maskedTextBoxCep.Text))
            {
                errorProviderCadastraClienteRegistro.SetError(textBox, "");
                return true;
            }
            else
            {
                errorProviderCadastraClienteRegistro.SetError(textBox, "Cep Inválido!");
                return false;
            }
        }
        private bool Endereco(TextBox textBox, ErrorProvider errorProvider)
        {
            if (!String.IsNullOrWhiteSpace(txtEndereco.Text))
            {
                errorProviderCadastraClienteRegistro.SetError(textBox, "");
                return true;
            }
            else
            {
                errorProviderCadastraClienteRegistro.SetError(textBox, "Cep Inválido!");
                return false;
            }
        }
        //private bool Numero(TextBox textBox, ErrorProvider errorProvider)
        //{
        //    if (!String.IsNullOrWhiteSpace(txtNumero.Text))
        //    {
        //        errorProviderCadastraClienteRegistro.SetError(textBox, "");
        //        return true;
        //    }
        //    else
        //    {
        //        errorProviderCadastraClienteRegistro.SetError(textBox, "Numero Inválido!");
        //        return false;
        //    }
        //}
        private bool bairro(TextBox textBox, ErrorProvider errorProvider)
        {
            if (!String.IsNullOrWhiteSpace(txtBairro.Text))
            {
                errorProviderCadastraClienteRegistro.SetError(textBox, "");
                return true;
            }
            else
            {
                errorProviderCadastraClienteRegistro.SetError(textBox, "Bairro Inválido!");
                return false;
            }
        }
        private bool Complemento(TextBox textBox, ErrorProvider errorProvider)
        {
            if (!String.IsNullOrWhiteSpace(txtComplemento.Text))
            {
                errorProviderCadastraClienteRegistro.SetError(textBox, "");
                return true;
            }
            else
            {
                errorProviderCadastraClienteRegistro.SetError(textBox, "Complemento Inválido!");
                return false;
            }
        }
        private bool Cidade(TextBox textBox, ErrorProvider errorProvider)
        {
            if (!String.IsNullOrWhiteSpace(txtCidade.Text))
            {
                errorProviderCadastraClienteRegistro.SetError(textBox, "");
                return true;
            }
            else
            {
                errorProviderCadastraClienteRegistro.SetError(textBox, "Cidade Inválido!");
                return false;
            }
        }
        //Cep a verificar Segundario
        private bool Cep2(MaskedTextBox textBox, ErrorProvider errorProvider)
        {
            if (!String.IsNullOrWhiteSpace(txtCepCliente.Text))
            {
                errorProviderCadastraClienteRegistro.SetError(textBox, "");
                return true;
            }
            else
            {
                errorProviderCadastraClienteRegistro.SetError(textBox, "Cep Inválido!");
                return false;
            }
        }
        private bool Endereco2(TextBox textBox, ErrorProvider errorProvider)
        {
            if (!String.IsNullOrWhiteSpace(txtEnderecoCliente.Text))
            {
                errorProviderCadastraClienteRegistro.SetError(textBox, "");
                return true;
            }
            else
            {
                errorProviderCadastraClienteRegistro.SetError(textBox, "Endereco2 Inválido!");
                return false;
            }
        }
        //private bool Numero2(TextBox textBox, ErrorProvider errorProvider)
        //{
        //    if (!String.IsNullOrWhiteSpace(txtBairroNumero.Text))
        //    {
        //        errorProviderCadastraClienteRegistro.SetError(textBox, "");
        //        return true;
        //    }
        //    else
        //    {
        //        errorProviderCadastraClienteRegistro.SetError(textBox, "Numero2 Inválido!");
        //        return false;
        //    }
        //}
        private bool bairro2(TextBox textBox, ErrorProvider errorProvider)
        {
            if (!String.IsNullOrWhiteSpace(txtBairroCliente.Text))
            {
                errorProviderCadastraClienteRegistro.SetError(textBox, "");
                return true;
            }
            else
            {
                errorProviderCadastraClienteRegistro.SetError(textBox, "bairro2 Inválido!");
                return false;
            }
        }
        private bool Complemento2(TextBox textBox, ErrorProvider errorProvider)
        {
            if (!String.IsNullOrWhiteSpace(txtComplCliente.Text))
            {
                errorProviderCadastraClienteRegistro.SetError(textBox, "");
                return true;
            }
            else
            {
                errorProviderCadastraClienteRegistro.SetError(textBox, "Complemento2 Inválido!");
                return false;
            }
        }
        private bool Cidade2(TextBox textBox, ErrorProvider errorProvider)
        {
            if (!String.IsNullOrWhiteSpace(txtCidadeCliente.Text))
            {
                errorProviderCadastraClienteRegistro.SetError(textBox, "");
                return true;
            }
            else
            {
                errorProviderCadastraClienteRegistro.SetError(textBox, "Cidade2 Inválido!");
                return false;
            }
        }
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        //BLOQUEIA LETRAS E SÓ POSSÍVEL USAR O BACKSPACE
        private void txtCpfPFisica_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Se a tecla digitada não for número
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }
        }
        //BLOQUEIA LETRAS E SÓ POSSÍVEL USAR O BACKSPACE
        private void txtRgFisica_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Se a tecla digitada não for número
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }
        }
        // VALIDAR ENTRADA COM ERROPROVIDER
        private Boolean validaCnpj(TextBox textBox, ErrorProvider errorProvider)
        {
            if (!String.IsNullOrWhiteSpace(txtCnpJTextBox.Text))
            {
                errorProvider.SetError(textBox, "");
                return true;
            }
            else
            {
                errorProvider.SetError(textBox, "Cnpj Inválido!");
                return false;
            }

        }
        // VALIDAR ENTRADA COM ERROPROVIDER
        private Boolean validaInscricaoStadual(TextBox textBox, ErrorProvider errorProvider)
        {
            if (!String.IsNullOrWhiteSpace(txtiNSCRICAO_STADUALTextBox.Text))
            {
                errorProvider.SetError(textBox, "");
                return true;
            }
            else
            {
                errorProvider.SetError(textBox, "Inscrição Estatual Inválido!");
                return false;
            }
        }
        // VALIDAR ENTRADA COM ERROPROVIDER
        private Boolean validaRazãoSocial(TextBox textBox, ErrorProvider errorProvider)
        {
            if (!String.IsNullOrWhiteSpace(txtrAZAO_SOCIALTextBox.Text))
            {
                errorProvider.SetError(textBox, "");
                return true;
            }
            else
            {
                errorProvider.SetError(textBox, "Razão Social Inválido!");
                return false;
            }
        }
        // VALIDAR ENTRADA COM ERROPROVIDER
        private Boolean validaNomeContato(TextBox textBox, ErrorProvider errorProvider)
        {
            if (!String.IsNullOrWhiteSpace(txtnOME_CONTATOTextBox.Text))
            {
                errorProvider.SetError(textBox, "");
                return true;
            }
            else
            {
                errorProvider.SetError(textBox, "Nome do Contato Inválido!");
                return false;
            }
        }
        // VALIDAR ENTRADA COM ERROPROVIDER
        private Boolean validaCnae(TextBox textBox, ErrorProvider errorProvider)
        {
            if (!String.IsNullOrWhiteSpace(txtCnae.Text))
            {
                errorProvider.SetError(textBox, "");
                return true;
            }
            else
            {
                errorProvider.SetError(textBox, "Nome do Contato Inválido!");
                return false;
            }
        }
        public void AlteraBotoes(int op)
        {
            if (op == 1)// Cadastra Cliente campos
            {
                panelCadastroCliente.Enabled = true;

                buttonCadastroCliente.Enabled = false;

                buttonVerifica.Enabled = true;
                buttonLimpaCliente.Enabled = false;
                buttonCancelarCliente.Enabled = true;
                buttonFecharCliente.Enabled = true;

                radioButtonPessoaFisica.Enabled = true;
                radioButtonPessoaJuridica.Enabled = true;
            }
            if (op == 2)//salvar Cadastro de Cliente
            {
                panelCadastroCliente.Enabled = false;

                buttonCadastroCliente.Enabled = true;

                buttonVerifica.Enabled = false;
                buttonLimpaCliente.Enabled = false;
                buttonCancelarCliente.Enabled = false;
                buttonFecharCliente.Enabled = true;


            }
            if (op == 3)//Calcelar Cadastro de Cliente
            {
                panelCadastroCliente.Enabled = false;

                buttonCadastroCliente.Enabled = true;

                buttonVerifica.Enabled = false;
                buttonLimpaCliente.Enabled = false;
                buttonCancelarCliente.Enabled = false;
                buttonFecharCliente.Enabled = true;

            }
            if (op == 4) //  Editar Cadastro de Cliente
            {
                panelCadastroCliente.Enabled = true;

                buttonCadastroCliente.Enabled = false;

                buttonVerifica.Enabled = true;
                buttonLimpaCliente.Enabled = false;
                buttonCancelarCliente.Enabled = true;
                buttonFecharCliente.Enabled = true;

            }
            if (op == 6)//Pesquisa Com suscesso!
            {
                buttonCadastroCliente.Enabled = false;

                buttonVerifica.Enabled = false;
                buttonLimpaCliente.Enabled = false;
                buttonCancelarCliente.Enabled = true;
                buttonFecharCliente.Enabled = true;
            }
            if (op == 7)//Botão Verificar informações Passadas
            {

                txtNomeCliente.Enabled = false;
                txtCepCliente.Enabled = false;
                txtTipo_logradouro.Enabled = false;
                txtBairroCliente.Enabled = false;
                txtBairroNumero.Enabled = false;
                txtTelefone2Cliente.Enabled = false;
                txtTelefoneCliente.Enabled = false;
                txtEmailCliente.Enabled = false;
                txtEnderecoCliente.Enabled = false;
                txtMunicipioCliente.Enabled = false;
                txtPaisCliente.Enabled = false;
                txtComplCliente.Enabled = false;
                txtCpMunicipalCliente.Enabled = false;
                txtFaxTelefoneCliente.Enabled = false;
                txtDescPaisCliente.Enabled = false;
                txtObservacaoCliente.Enabled = false;
                txtTipoCliente.Enabled = false;
                txtTelexTelefoneCliente.Enabled = false;

                buttonBuscaCep.Enabled = false;
            }
            if (op == 8)//Libera Pessoa Fisica e Juridica!
            {

            }
            if (op == 9)//Libera Pesquisa Por MS e Nome.
            {

                buttonCadastroCliente.Enabled = false;
                buttonCancelarCliente.Enabled = true;
                buttonFecharCliente.Enabled = true;

            }
            if (op == 10)//limpa textos
            {
                txtNomeCliente.Clear();
                maskedTextBoxCep.Clear();
                txtEndereco.Clear();
                txtNumero.Clear();
                txtBairro.Clear();
                txtComplemento.Clear();
                txtCidade.Clear();
                txtLogradouro.Clear();
                txtTelefoneCliente.Clear();
                txtTelefone2Cliente.Clear();
                txtFaxTelefoneCliente.Clear();
                txtTelexTelefoneCliente.Clear();
                txtEmailCliente.Clear();
                txtTipoCliente.Clear();
                txtCpMunicipalCliente.Clear();
                txtMunicipioCliente.Clear();
                txtPaisCliente.Clear();
                txtDescPaisCliente.Clear();
                txtObservacaoCliente.Clear();
                txtCnpjConsulta.Clear();
                txtLetrasConulta.Clear();
                txtCnpJTextBox.Clear();
                txtrAZAO_SOCIALTextBox.Clear();
                txtiNSCRICAO_STADUALTextBox.Clear();
                txtnOME_CONTATOTextBox.Clear();
                txtCnae.Clear();
                txtNomePFisica.Clear();
                txtCpfPFisica.Clear();
                txtRgFisica.Clear();
                txtCelularPFisica.Clear();
                txtCelularPFisica2.Clear();
                txtCepCliente.Clear();
                txtTipo_logradouro.Clear();
                txtEnderecoCliente.Clear();
                txtBairroNumero.Clear();
                txtComplCliente.Clear();
                txtBairroCliente.Clear();
                txtCidadeCliente.Clear();
                txtSiglaCidadeCliente.Clear();
            }
            if (op == 11)
            {//Pessoa Fisica
                txtNomePFisica.Enabled = true;
                comboBoxSexoPFIsica.Enabled = true;
                txtCpfPFisica.Enabled = true;
                txtRgFisica.Enabled = true;
                txtDataNascimento.Enabled = true;
                txtCelularPFisica.Enabled = true;
                txtCelularPFisica2.Enabled = true;
                txtnOME_CONTATOTextBox.Enabled = false;

                txtCnpJTextBox.Enabled = false;
                txtrAZAO_SOCIALTextBox.Enabled = false;
                txtiNSCRICAO_STADUALTextBox.Enabled = false;

                buttonConsultaCnpj.Enabled = false;
                buttonTrocaImagem.Enabled = false;
                txtCnpjConsulta.Enabled = false;
                txtLetrasConulta.Enabled = false;
                buttonConsultaCnpj.Visible = false;
                buttonTrocaImagem.Visible = false;
                txtCnpjConsulta.Visible = false;
                txtLetrasConulta.Visible = false;
                pictureBoxLetras.Enabled = false;
                pictureBoxLetras.Visible = false;
                txtCnae.Enabled = false;
                txtCnae.Visible = false;
                maskedTextBoxCep.Enabled = true;
                txtNumero.Enabled = true;
                buttonCepPrincipal.Enabled = true;
                txtCepCliente.Enabled = true;
                txtComplCliente.Enabled = true;
                txtnOME_CONTATOTextBox.Enabled = false;
                buttonCepPrincipal.Enabled = true;

                label5.Visible = false;
                label16.Visible = false;

                buttonCnpjManual.Enabled = false;
                buttonCnpjAutomatico.Enabled = false;


                tabControlFisicaJuridica.Enabled = true;

                txtCepCliente.Enabled = true;
                txtBairroNumero.Enabled = true;
                txtComplCliente.Enabled = true;

                txtCnpJTextBox.Clear();
                txtrAZAO_SOCIALTextBox.Clear();
                txtiNSCRICAO_STADUALTextBox.Clear();
                txtnOME_CONTATOTextBox.Clear();
                txtCnpjConsulta.Clear();
                txtLetrasConulta.Clear();
                txtCnae.Clear();

                maskedTextBoxCep.Clear();
                txtEndereco.Clear();
                txtNumero.Clear();
                txtBairro.Clear();
                txtComplemento.Clear();
                txtCidade.Clear();

                txtCepCliente.Clear();
                txtTipo_logradouro.Clear();
                txtBairroNumero.Clear();
                txtEnderecoCliente.Clear();
                txtComplCliente.Clear();
                txtBairroCliente.Clear();
                txtCidadeCliente.Clear();
                txtLogradouro.Clear();

                buttonCepManualPrincipal.Enabled = true;

                labelConfirmacaoPrimario.Text = "Resultado:";
            }
            if (op == 12)
            {//Pessoa Juridica

                txtNomePFisica.Enabled = false;
                comboBoxSexoPFIsica.Enabled = false;
                txtCpfPFisica.Enabled = false;
                txtRgFisica.Enabled = false;
                txtDataNascimento.Enabled = false;
                txtCelularPFisica.Enabled = false;
                txtCelularPFisica2.Enabled = false;

                maskedTextBoxCep.Enabled = false;
                txtNumero.Enabled = false;
                buttonCepPrincipal.Enabled = false;
                txtCepCliente.Enabled = true;
                txtComplCliente.Enabled = true;
                txtnOME_CONTATOTextBox.Enabled = true;
                txtCnae.Visible = true;
                txtCnae.Enabled = false;
                buttonCepPrincipal.Enabled = false;

                buttonCnpjManual.Enabled = true;
                buttonCnpjAutomatico.Enabled = true;

                txtNomePFisica.Clear();
                txtCpfPFisica.Clear();
                txtRgFisica.Clear();
                txtCelularPFisica.Clear();
                txtCelularPFisica2.Clear();
                txtCnpjConsulta.Clear();
                txtLetrasConulta.Clear();
                txtCnae.Clear();

                maskedTextBoxCep.Clear();
                txtEndereco.Clear();
                txtNumero.Clear();
                txtBairro.Clear();
                txtComplemento.Clear();
                txtCidade.Clear();

                txtCepCliente.Clear();
                txtTipo_logradouro.Clear();
                txtBairroNumero.Clear();
                txtEnderecoCliente.Clear();
                txtComplCliente.Clear();
                txtBairroCliente.Clear();
                txtCidadeCliente.Clear();
                txtLogradouro.Clear();

                buttonCepManualPrincipal.Enabled = false;

                labelConfirmacaoSecundario.Text = "Resultado:";
            }

        }
        public void AlteraBotoesCnpj(int op)
        {
            if (op == 1)//Manual
            {
                buttonCepManualPrincipal.Enabled = true;
                buttonConsultaCnpj.Visible = false;
                buttonTrocaImagem.Visible = false;
                label5.Visible = false;
                txtCnpjConsulta.Visible = false;
                label16.Visible = false;
                txtLetrasConulta.Visible = false;
                pictureBoxLetras.Visible = false;

                buttonConsultaCnpj.Enabled = false;
                buttonTrocaImagem.Enabled = false;
                label5.Enabled = false;
                txtCnpjConsulta.Enabled = false;
                label16.Enabled = false;
                txtLetrasConulta.Enabled = false;
                pictureBoxLetras.Enabled = false;

                buttonCepPrincipal.Enabled = true;

                buttonCnpjManual.Enabled = false;
                buttonCnpjAutomatico.Enabled = true;

                maskedTextBoxCep.Enabled = true;
                txtNumero.Enabled = true;

                txtCnpJTextBox.Enabled = true;
                txtrAZAO_SOCIALTextBox.Enabled = true;
                txtiNSCRICAO_STADUALTextBox.Enabled = true;
                txtCnae.Enabled = true;

                txtCepCliente.Enabled = true;

                buttonCepManualPrincipal.Enabled = true;
                tabControlFisicaJuridica.Enabled = true;

            }
            if (op == 2)//Automatico
            {
                buttonConsultaCnpj.Visible = true;
                buttonTrocaImagem.Visible = true;
                label5.Visible = true;
                txtCnpjConsulta.Visible = true;
                label16.Visible = true;
                txtLetrasConulta.Visible = true;
                pictureBoxLetras.Visible = true;

                buttonConsultaCnpj.Enabled = true;
                buttonTrocaImagem.Enabled = true;
                label5.Enabled = true;
                txtCnpjConsulta.Enabled = true;
                label16.Enabled = true;
                txtLetrasConulta.Enabled = true;
                pictureBoxLetras.Enabled = true;
                maskedTextBoxCep.Enabled = false;
                txtNumero.Enabled = true;
                buttonCepPrincipal.Enabled = false;
                txtNumero.Enabled = false;
                buttonCnpjManual.Enabled = true;
                buttonCnpjAutomatico.Enabled = false;

                txtCnpJTextBox.Enabled = false;
                txtrAZAO_SOCIALTextBox.Enabled = false;
                txtiNSCRICAO_STADUALTextBox.Enabled = false;
                txtCnae.Enabled = false;

                txtCepCliente.Enabled = true;
                txtBairroNumero.Enabled = true;
                txtComplCliente.Enabled = true;
                tabControlFisicaJuridica.Enabled = true;
            }
            if (op == 3)//Automatico Cep
            {
                txtEndereco.Enabled = false;
                txtBairro.Enabled = false;
                txtComplemento.Enabled = false;
                txtCidade.Enabled = false;
                buttonCepManualPrincipal.Text = "Cep automatico";
                TrocaCepBotaoTempoOs = 0;
                CepManual = 0;
                buttonCepPrincipal.Enabled = true;
                txtLogradouro.Enabled = false;
                txtSigla.Enabled = false;

            }
            if (op == 4)//Manual Cep
            {
                txtEndereco.Enabled = true;
                txtBairro.Enabled = true;
                txtComplemento.Enabled = true;
                txtCidade.Enabled = true;
                buttonCepManualPrincipal.Text = "Cep manual";
                TrocaCepBotaoTempoOs = 1;
                CepManual = 1;
                buttonCepPrincipal.Enabled = false;
                txtLogradouro.Enabled = true;
                txtSigla.Enabled = true;

            }
            if (op == 5)//Automatico Cep Secundario
            {
                txtEnderecoCliente.Enabled = false;
                txtBairroCliente.Enabled = false;
                txtComplCliente.Enabled = false;
                txtCidadeCliente.Enabled = false;
                txtTipo_logradouro.Enabled = false;
                txtSiglaCidadeCliente.Enabled = false;
                buttonCepManualSegun.Text = "Cep automatico";
                TrocaCepBotaoTempoOs2 = 0;
                CepManualSe = 0;
                buttonBuscaCep.Enabled = true;
            }
            if (op == 6)//Manual Cep Segundario
            {
                txtEnderecoCliente.Enabled = true;
                txtBairroCliente.Enabled = true;
                txtComplCliente.Enabled = true;
                txtCidadeCliente.Enabled = true;
                txtTipo_logradouro.Enabled = true;
                txtSiglaCidadeCliente.Enabled = true;
                buttonCepManualSegun.Text = "Cep manual";
                TrocaCepBotaoTempoOs2 = 1;
                CepManualSe = 1;
                buttonBuscaCep.Enabled = false;
            }
            if (op == 7)//Manual Cep
            {
                maskedTextBoxCep.Clear();
                txtEndereco.Clear();
                txtNumero.Clear();
                txtBairro.Clear();
                txtComplemento.Clear();
                txtCidade.Clear();
                txtLogradouro.Clear();
                txtLogradouro.Clear();
                txtSigla.Clear();
            }
            if (op == 8)//Manual Cep Secundario
            {
                txtCepCliente.Clear();
                txtTipo_logradouro.Clear();
                txtBairroNumero.Clear();
                txtEnderecoCliente.Clear();
                txtComplCliente.Clear();
                txtBairroCliente.Clear();
                txtCidadeCliente.Clear();
                txtSiglaCidadeCliente.Clear();
            }
        }
        private void FormCadastraClienteRegistro_Load(object sender, EventArgs e)
        {
            panelBotoesCadastroCliente.Enabled = true;

            buttonCadastroCliente.Enabled = true;

            txtNomeCliente.MaxLength = 150;

            txtTipo_logradouro.MaxLength = 25;

            txtEnderecoCliente.MaxLength = 40;

            txtBairroNumero.MaxLength = 9;

            txtComplCliente.MaxLength = 40;

            txtBairroCliente.MaxLength = 40;

            txtCidadeCliente.MaxLength = 40;

            txtSiglaCidadeCliente.MaxLength = 4;

            txtEmailCliente.MaxLength = 40;

            txtTipoCliente.MaxLength = 20;

            txtCpMunicipalCliente.MaxLength = 20;

            txtMunicipioCliente.MaxLength = 20;

            txtPaisCliente.MaxLength = 19;

            txtDescPaisCliente.MaxLength = 20;

            txtObservacaoCliente.MaxLength = 40;

            txtCnpJTextBox.MaxLength = 14;

            txtrAZAO_SOCIALTextBox.MaxLength = 150;

            txtiNSCRICAO_STADUALTextBox.MaxLength = 150;

            txtnOME_CONTATOTextBox.MaxLength = 20;
            txtCnpjConsulta.MaxLength = 14;

            txtNomePFisica.MaxLength = 50;

            comboBoxSexoPFIsica.MaxLength = 2;

            txtRgFisica.MaxLength = 9;

            txtLetrasConulta.MaxLength = 6;

            txtCnae.MaxLength = 150;
        }

        private void buttonCepManualPrincipal_Click(object sender, EventArgs e)
        {
            if (TrocaCepBotaoTempoOs == 0)
            {
                AlteraBotoesCnpj(4);
                AlteraBotoesCnpj(7);
            }
            else if (TrocaCepBotaoTempoOs == 1)
            {
                AlteraBotoesCnpj(3);
                AlteraBotoesCnpj(7);
            }
            maskedTextBoxCep.Enabled = true;
        }

        private void buttonCepPrincipal_Click(object sender, EventArgs e)
        {
            try
            {
                string xml = "http://cep.republicavirtual.com.br/web_cep.php?cep=@cep&formato=xml"
                .Replace("@cep", maskedTextBoxCep.Text);
                DataSet ds = new DataSet();
                ds.ReadXml(xml);

                labelConfirmacaoPrimario.Text = ds.Tables[0].Rows[0][1].ToString();
                txtLogradouro.Text = ds.Tables[0].Rows[0][5].ToString();
                txtEndereco.Text = ds.Tables[0].Rows[0][6].ToString();
                txtBairro.Text = ds.Tables[0].Rows[0][4].ToString();
                txtCidade.Text = ds.Tables[0].Rows[0][3].ToString();
                txtSigla.Text = ds.Tables[0].Rows[0][2].ToString();
            }
            catch
            {
                MessageBox.Show(" Erro: " + e.ToString());
            }

        }
        private Boolean VerificadorEndereco()
        {
            int EntradaContato = 0;

            string endereco1 = txtEndereco.ToString(), Bairro = txtBairro.ToString(), Logradouro = txtLogradouro.ToString(),
                Cidade = txtCidade.ToString(), Sigla = txtSigla.ToString();

            if (maskedTextBoxCep.Text == "")
            {
                if (endereco1.ToString() != "")
                {
                    for (int i = 0; i < endereco1.Length; i++)
                    {
                        if (endereco1[i] == '*')
                        {
                            EntradaContato++;
                            break;
                        }
                    }
                }
                if (Bairro.ToString() != "")
                {
                    for (int i = 0; i < Bairro.Length; i++)
                    {
                        if (Bairro[i] == '*')
                        {
                            EntradaContato++;
                            break;
                        }
                    }
                }
                if (Logradouro.ToString() != "")
                {
                    for (int i = 0; i < Logradouro.Length; i++)
                    {
                        if (Logradouro[i] == '*')
                        {
                            EntradaContato++;
                            break;
                        }
                    }
                }
                if (Cidade.ToString() != "")
                {
                    for (int i = 0; i < Cidade.Length; i++)
                    {
                        if (Cidade[i] == '*')
                        {
                            EntradaContato++;
                            break;
                        }
                    }
                }
                if (Sigla.ToString() != "")
                {
                    for (int i = 0; i < Sigla.Length; i++)
                    {
                        if (Sigla[i] == '*')
                        {
                            EntradaContato++;
                            break;
                        }
                    }
                }
                if (EntradaContato >= 5)
                {
                    return true;
                }
                else return false;
            }
            return false;
        }

        private void buttonVerifica_Click(object sender, EventArgs e)
        {
            CadastraCliente();
        }
        public void CadastraCliente()
        {
            try
            {
                string CepPrincipal = maskedTextBoxCep.Text;
                string CepSecundarioT = txtCepCliente.Text;
                //string tamanhoLetraCnpj = ;

                if ((txtTelefoneCliente.Equals("_____-___")))
                {
                    MessageBox.Show("ssssssssss");
                }
                if (txtTelefoneCliente.Equals(""))
                {
                    MessageBox.Show("nnnnnnnnnnnnnnnnnnnnnnn");
                }

                if ((validaNome(txtNomeCliente, errorProviderCadastraClienteRegistro) == true))
                {
                    if (!(txtTelefoneCliente.Text == ""))
                    {
                        SqlConnection conn = new SqlConnection(this.connetionString);

                        //Verifica Se a MS é Valida no sistema!

                        SqlDataAdapter da3 = new SqlDataAdapter("SELECT * FROM P_Pessoa where NOME = '" + txtNomeCliente.Text + "';", conn);

                        DataSet ds3 = new DataSet();
                        da3.Fill(ds3);

                        conn.Open();

                        if (ds3.Tables[0].Rows.Count > 0)

                        {
                            MessageBox.Show("O Nome consta no sistema não pode ser Inserido!");
                        }
                        if (!(ds3.Tables[0].Rows.Count > 0))
                        {
                            if ((radioButtonPessoaFisica.Checked == false) && (radioButtonPessoaJuridica.Checked == false))
                            {
                                MessageBox.Show("Seleciona Pessoa Fisíca ou Pessoa Jurídica!");
                            }
                            if (radioButtonPessoaFisica.Checked == true)
                            {
                                //Pessoa fisica Cep não pode está em branco
                                if (CepPrincipal.Equals("_____-___"))
                                {
                                    verificador = false;
                                    MessageBox.Show("O cep não pode está em branco e pesquisa o cep!");
                                }//Modo cep principal automatico
                                else if (!CepPrincipal.Equals("_____-___"))
                                {
                                    if (CepManual == 0)
                                    {
                                        if (labelConfirmacaoPrimario.Text.Equals("Resultado:"))
                                        {
                                            verificador = false;
                                            MessageBox.Show("Pesquisa o cep Principal!");
                                        }
                                        if (labelConfirmacaoPrimario.Text.Equals("sucesso - cep não encontrado"))
                                        {
                                            verificador = false;
                                            MessageBox.Show("O cep é não é válido!");
                                        }
                                        if (labelConfirmacaoPrimario.Text.Equals("sucesso - cep completo"))
                                        {
                                            if (CepSecundarioT.Equals("_____-___"))
                                            {
                                                verificador = true;
                                            }
                                            //Cep Segundario Automatico
                                            else if (!CepSecundarioT.Equals("_____-___"))
                                            {
                                                if (CepManualSe == 0)
                                                {
                                                    if (labelConfirmacaoSecundario.Text.Equals("Resultado:"))
                                                    {
                                                        verificador = false;
                                                        MessageBox.Show("Pesquisa o cep Secundario! 1");
                                                    }
                                                    if (labelConfirmacaoSecundario.Text.Equals("sucesso - cep não encontrado"))
                                                    {
                                                        verificador = false;
                                                        MessageBox.Show("O cep é não é válido!");
                                                    }
                                                    if (labelConfirmacaoSecundario.Text.Equals("sucesso - cep completo"))
                                                    {
                                                        verificador = true;
                                                        CepSecundario = true;
                                                    }
                                                }
                                                if (CepManualSe == 1)
                                                {
                                                    if ((Cep2(txtCepCliente, errorProviderCadastraClienteRegistro) == true) && (Endereco2(txtEnderecoCliente, errorProviderCadastraClienteRegistro) == true) &&
                                                           ((bairro2(txtBairroCliente, errorProviderCadastraClienteRegistro) == true) && (Cidade2(txtCidadeCliente, errorProviderCadastraClienteRegistro) == true)))
                                                    {
                                                        verificador = true;
                                                        CepSecundario = true;
                                                    }
                                                }

                                            }
                                        }

                                    }
                                    if (CepManual == 1)
                                    {
                                        if ((Cep(maskedTextBoxCep, errorProviderCadastraClienteRegistro) == true) && (Endereco(txtEndereco, errorProviderCadastraClienteRegistro) == true) &&
                                        (bairro(txtBairro, errorProviderCadastraClienteRegistro) == true) && (Cidade(txtCidade, errorProviderCadastraClienteRegistro) == true))
                                        {
                                            if (CepSecundarioT.Equals("_____-___"))
                                            {
                                                verificador = true;
                                            }
                                            else if (!CepSecundarioT.Equals("_____-___"))
                                            {
                                                if (CepManualSe == 0)
                                                {
                                                    //Cep Segundario Automatico
                                                    if (labelConfirmacaoSecundario.Text.Equals("Resultado:"))
                                                    {
                                                        verificador = false;
                                                        MessageBox.Show("Pesquisa o cep secundario!");
                                                    }
                                                    if (labelConfirmacaoSecundario.Text.Equals("sucesso - cep não encontrado"))
                                                    {
                                                        verificador = false;
                                                        MessageBox.Show("O cep é não é válido!");
                                                    }
                                                    if (labelConfirmacaoSecundario.Text.Equals("sucesso - cep completo"))
                                                    {
                                                        verificador = true;

                                                        CepSecundario = true;
                                                    }
                                                }
                                                if (CepManualSe == 1)
                                                {
                                                    //Cep Segundario Manual
                                                    if (!CepSecundarioT.Equals("_____-___"))
                                                    {
                                                        if ((Cep2(txtCepCliente, errorProviderCadastraClienteRegistro) == true) && (Endereco2(txtEnderecoCliente, errorProviderCadastraClienteRegistro) == true) &&
                                                           (bairro2(txtBairroCliente, errorProviderCadastraClienteRegistro) == true) && (Cidade2(txtCidadeCliente, errorProviderCadastraClienteRegistro) == true))
                                                        {
                                                            verificador = true;

                                                            CepSecundario = true;
                                                        }
                                                    }
                                                }                                            }
                                        }
                                    }
                                }
                                if (!validaSexo())
                                {
                                    MessageBox.Show("Por favor Digite um Sexo Válido!");
                                    verificador = false;
                                }

                                if (verificador == true)
                                {
                                    try
                                    {
                                        Conexao conexao = new Conexao(this.connetionString);
                                        DALDateSystem dal = new DALDateSystem(conexao); //cadastra Pessoa

                                        Conexao conexao5 = new Conexao(this.connetionString);
                                        DALDateSystem dal5 = new DALDateSystem(conexao5);//cadastra Cep Principal

                                        Conexao conexao1 = new Conexao(this.connetionString);
                                        DALDateSystem dal1 = new DALDateSystem(conexao1);//cadastra Cep

                                        Conexao conexao2 = new Conexao(this.connetionString);
                                        DALRegistroGerado dal2 = new DALRegistroGerado(conexao2);//cadastra Pesssoa Clientes Registro

                                        Conexao conexao4 = new Conexao(this.connetionString);
                                        DALDateSystem dal4 = new DALDateSystem(conexao4);//cadastra Pesssoa Fisica 

                                        Pessoa cadastra = new Pessoa();

                                        Registro ClienteRegistro = new Registro();

                                        CepSecundario cadastraCepSecundario = new CepSecundario();

                                        PessoaFisica PessoaFisica = new PessoaFisica();

                                        // Dados Pessoa
                                        cadastra.IdOs = 0;
                                        cadastra.Situacao = 1;
                                        cadastra.Nome = txtNomeCliente.Text;
                                        cadastra.Telefone = txtTelefoneCliente.Text;
                                        cadastra.Telefone2 = txtTelefone2Cliente.Text;
                                        cadastra.FaxTelefone = txtFaxTelefoneCliente.Text;
                                        cadastra.TelexTelefone = txtTelexTelefoneCliente.Text;
                                        cadastra.Email = txtEmailCliente.Text;
                                        cadastra.Observacao = txtObservacaoCliente.Text;
                                        cadastra.Tipo = txtTipoCliente.Text;
                                        cadastra.CpMunicipio = txtCpMunicipalCliente.Text;
                                        cadastra.Municipio = txtMunicipioCliente.Text;
                                        cadastra.Pais = txtPaisCliente.Text;
                                        cadastra.DesPais = txtDescPaisCliente.Text;
                                        cadastra.IdPessoaTipo = 2;

                                        ////Pessoa Fisica
                                        PessoaFisica.Nome = txtNomePFisica.Text;
                                        PessoaFisica.Cpf = txtCpfPFisica.Text;
                                        PessoaFisica.Rg = txtRgFisica.Text;
                                        PessoaFisica.dataNacimento = txtDataNascimento.Text;
                                        PessoaFisica.Celular = txtCelularPFisica.Text;
                                        PessoaFisica.Celular2 = txtCelularPFisica2.Text;

                                        //Dados Pessoa Cliente Registro
                                        ClienteRegistro.Nome = txtNomeCliente.Text;

                                        //Dados CEP Principal
                                        CepF CepFisico = new CepF();
                                        //Dados CEP
                                        if (maskedTextBoxCep.Text == "")
                                        {

                                        }
                                        else CepFisico.Cepc = int.Parse(maskedTextBoxCep.Text);
                                        CepFisico.TipoLogradouro = txtLogradouro.Text;
                                        CepFisico.Endereco = txtEndereco.Text;
                                        CepFisico.Numero = txtNumero.Text;
                                        CepFisico.Complemento = txtComplemento.Text;
                                        CepFisico.Bairro = txtBairro.Text;
                                        CepFisico.Cidade = txtCidade.Text;
                                        CepFisico.SiglaCidade = txtSigla.Text;

                                        ////Dados CEP Secundario
                                        if (labelConfirmacaoSecundario.Text.Equals("sucesso - cep completo"))
                                        {
                                            cadastraCepSecundario.Cepc = int.Parse(txtCepCliente.Text);
                                            cadastraCepSecundario.TipoLogradouro = txtTipo_logradouro.Text;
                                            cadastraCepSecundario.Endereco = txtEnderecoCliente.Text;
                                            cadastraCepSecundario.Numero = txtBairroNumero.Text;
                                            cadastraCepSecundario.Complemento = txtComplCliente.Text;
                                            cadastraCepSecundario.Bairro = txtBairroCliente.Text;
                                            cadastraCepSecundario.Cidade = txtCidadeCliente.Text;
                                            cadastraCepSecundario.SiglaCidade = txtSiglaCidadeCliente.Text;
                                        }
                                        if (!labelConfirmacaoSecundario.Text.Equals("sucesso - cep completo"))
                                        {

                                        }
                                        if ((NomePFisica(txtNomePFisica, errorProviderCadastraClienteRegistro) == true) && (validaCpf(txtCpfPFisica, errorProviderCadastraClienteRegistro) == true) &&
                                            (validaRg(txtRgFisica, errorProviderCadastraClienteRegistro) == true) && (validaCelular(txtCelularPFisica, errorProviderCadastraClienteRegistro) == true) &&
                                            (validaSexo()) && (comboBoxSexoPFIsica.SelectedItem.ToString() == "M"))
                                        {
                                            //Pessoa Fisica recebe M
                                            PessoaFisica.Sexo = "M";

                                            if (maskedTextBoxCep.Text == "")
                                            {
                                                DialogResult SalvaClienteRegistro = MessageBox.Show("Deseja Salvar em Pessoa Física?\n" +
                                                "Salvar sem um cep válido!", "Aviso", MessageBoxButtons.YesNo);

                                                if (SalvaClienteRegistro == DialogResult.Yes)
                                                {
                                                    //Inserir Pessoa
                                                    dal.Incluir(cadastra);

                                                    idPessoaFisica = int.Parse(cadastra.idPessoa.ToString());

                                                    if (idPessoaFisica > 0)
                                                    {
                                                        if (this.operacao == "Inserir")
                                                        {
                                                            //Inserir Pessoa Fisica
                                                            PessoaFisica.idPessoaFisica = idPessoaFisica;
                                                            dal4.IncluirPessoaFIsica(PessoaFisica);

                                                            //Inserir Cliente Registro
                                                            ClienteRegistro.idPessoa = idPessoaFisica;
                                                            dal2.IncluirClienteRegistro(ClienteRegistro);

                                                            //inserir Cep Principal
                                                            CepFisico.idCep = idPessoaFisica;
                                                            CepFisico.Cepc = 00000000;
                                                            dal5.IncluirCepFisico(CepFisico);

                                                            if (CepSecundario == true)
                                                            {
                                                                //Inserir Cep Segundario
                                                                cadastraCepSecundario.Numero = txtBairroNumero.Text;
                                                                dal1.IncluirCepSecundario(cadastraCepSecundario);

                                                            }
                                                            MessageBox.Show("Cliente Cadastrado com sucesso!");

                                                            FecharTodosFormulario();

                                                            FormCadastraClienteRegistro cadastracliente = new FormCadastraClienteRegistro(this.NomeServidor, this.NomeBaseDados, this.NomeUsuario, this.SenhaBaseDados);
                                                            cadastracliente.MdiParent = FormCadastraClienteRegistro.ActiveForm;
                                                            cadastracliente.Show();
                                                            cadastracliente.Top = 0;
                                                            cadastracliente.Left = 0;
                                                        }
                                                    }
                                                    else if (idPessoaFisica <= 0)
                                                    {
                                                        MessageBox.Show("Erro na geração de ID F.1.");
                                                    }
                                                }
                                                if (SalvaClienteRegistro == DialogResult.No)
                                                {
                                                    MessageBox.Show("Não atribuido ao sistema!");
                                                }
                                            }
                                            if (maskedTextBoxCep.Text != "")
                                            {
                                                //Inserir Pessoa
                                                dal.Incluir(cadastra);

                                                idPessoaFisica = int.Parse(cadastra.idPessoa.ToString());

                                                if (idPessoaFisica > 0)
                                                {
                                                    if (this.operacao == "Inserir")
                                                    {
                                                        //Inserir Pessoa Fisica
                                                        PessoaFisica.idPessoaFisica = idPessoaFisica;
                                                        dal4.IncluirPessoaFIsica(PessoaFisica);

                                                        //Inserir Cliente Registro
                                                        ClienteRegistro.idPessoa = idPessoaFisica;
                                                        dal2.IncluirClienteRegistro(ClienteRegistro);

                                                        //inserir Cep Principal
                                                        CepFisico.idCep = idPessoaFisica;
                                                        dal5.IncluirCepFisico(CepFisico);

                                                        if (CepSecundario == true)
                                                        {
                                                            //Inserir Cep Segundario
                                                            cadastraCepSecundario.Numero = txtBairroNumero.Text;
                                                            dal1.IncluirCepSecundario(cadastraCepSecundario);

                                                        }
                                                        MessageBox.Show("Cliente Cadastrado com sucesso!");

                                                        FecharTodosFormulario();

                                                        FormCadastraClienteRegistro cadastracliente = new FormCadastraClienteRegistro(this.NomeServidor, this.NomeBaseDados, this.NomeUsuario, this.SenhaBaseDados);
                                                        cadastracliente.MdiParent = FormCadastraClienteRegistro.ActiveForm;
                                                        cadastracliente.Show();
                                                        cadastracliente.Top = 0;
                                                        cadastracliente.Left = 0;

                                                    }
                                                }
                                                if (idPessoaFisica <= 0)
                                                {
                                                    MessageBox.Show("Erro na geração de ID F.2.");
                                                }
                                            }


                                            if ((NomePFisica(txtNomePFisica, errorProviderCadastraClienteRegistro) == true) && (validaCpf(txtCpfPFisica, errorProviderCadastraClienteRegistro) == true) &&
                                                    (validaRg(txtRgFisica, errorProviderCadastraClienteRegistro) == true) && (validaCelular(txtCelularPFisica, errorProviderCadastraClienteRegistro) == true) &&
                                                    (validaSexo()) && (comboBoxSexoPFIsica.SelectedItem.ToString() == "F"))
                                            {
                                                //Pessoa Fisica recebe M
                                                PessoaFisica.Sexo = "F";

                                                if (maskedTextBoxCep.Text == "")
                                                {
                                                    DialogResult SalvaClienteRegistro = MessageBox.Show("Deseja Salvar em Pessoa Física?\n" +
                                                    "Salvar sem um cep válido!", "Aviso", MessageBoxButtons.YesNo);

                                                    if (SalvaClienteRegistro == DialogResult.Yes)
                                                    {
                                                        //Inserir Pessoa
                                                        dal.Incluir(cadastra);

                                                        idPessoaFisica = int.Parse(cadastra.idPessoa.ToString());

                                                        if (idPessoaFisica > 0)
                                                        {
                                                            if (this.operacao == "Inserir")
                                                            {
                                                                //Inserir Pessoa Fisica
                                                                PessoaFisica.idPessoaFisica = idPessoaFisica;
                                                                dal4.IncluirPessoaFIsica(PessoaFisica);

                                                                //Inserir Cliente Registro
                                                                ClienteRegistro.idPessoa = idPessoaFisica;
                                                                dal2.IncluirClienteRegistro(ClienteRegistro);

                                                                //inserir Cep Principal
                                                                CepFisico.idCep = idPessoaFisica;
                                                                CepFisico.Cepc = 00000000;
                                                                dal5.IncluirCepFisico(CepFisico);

                                                                if (CepSecundario == true)
                                                                {
                                                                    //Inserir Cep Segundario
                                                                    cadastraCepSecundario.Numero = txtBairroNumero.Text;
                                                                    dal1.IncluirCepSecundario(cadastraCepSecundario);

                                                                }
                                                                MessageBox.Show("Cliente Cadastrado com sucesso!");

                                                                FecharTodosFormulario();

                                                                FormCadastraClienteRegistro cadastracliente = new FormCadastraClienteRegistro(this.NomeServidor, this.NomeBaseDados, this.NomeUsuario, this.SenhaBaseDados);
                                                                cadastracliente.MdiParent = FormCadastraClienteRegistro.ActiveForm;
                                                                cadastracliente.Show();
                                                                cadastracliente.Top = 0;
                                                                cadastracliente.Left = 0;
                                                            }
                                                        }
                                                        else if (idPessoaFisica <= 0)
                                                        {
                                                            MessageBox.Show("Erro na geração de ID F.3.");
                                                        }
                                                    }
                                                    if (SalvaClienteRegistro == DialogResult.No)
                                                    {
                                                        MessageBox.Show("Não atribuido ao sistema!");
                                                    }
                                                }
                                                if (maskedTextBoxCep.Text != "")
                                                {
                                                    //Inserir Pessoa
                                                    dal.Incluir(cadastra);
                                                    idPessoaFisica = int.Parse(cadastra.idPessoa.ToString());

                                                    if (idPessoaFisica > 0)
                                                    {
                                                        if (this.operacao == "Inserir")
                                                        {
                                                            //Inserir Pessoa Fisica
                                                            PessoaFisica.idPessoaFisica = idPessoaFisica;
                                                            dal4.IncluirPessoaFIsica(PessoaFisica);

                                                            //Inserir Cliente Registro
                                                            ClienteRegistro.idPessoa = idPessoaFisica;
                                                            dal2.IncluirClienteRegistro(ClienteRegistro);

                                                            //inserir Cep Principal
                                                            CepFisico.idCep = idPessoaFisica;
                                                            dal5.IncluirCepFisico(CepFisico);

                                                            if (CepSecundario == true)
                                                            {
                                                                //Inserir Cep Segundario
                                                                cadastraCepSecundario.Numero = txtBairroNumero.Text;
                                                                dal1.IncluirCepSecundario(cadastraCepSecundario);

                                                            }
                                                            MessageBox.Show("Cliente Cadastrado com sucesso!");

                                                            FecharTodosFormulario();

                                                            FormCadastraClienteRegistro cadastracliente = new FormCadastraClienteRegistro(this.NomeServidor, this.NomeBaseDados, this.NomeUsuario, this.SenhaBaseDados);
                                                            cadastracliente.MdiParent = FormCadastraClienteRegistro.ActiveForm;
                                                            cadastracliente.Show();
                                                            cadastracliente.Top = 0;
                                                            cadastracliente.Left = 0;

                                                        }
                                                    }
                                                    if (idPessoaFisica <= 0)
                                                    {
                                                        MessageBox.Show("Erro na geração de ID F.3.");
                                                    }
                                                }
                                            }
                                        }
                                    }
                                    catch (Exception ex)
                                    {
                                        MessageBox.Show("Erro de acesso ao banco de Dados " + ex.ToString() + "  ----------------------------------------------------------------------------------------------------------------------------------------. ", ex.Message);
                                    }
                                }
                            }
                            if (radioButtonPessoaJuridica.Checked == true)
                            {
                                if (SiteOFF == 0)
                                {
                                    if (CepSecundarioT.Equals("_____-___"))
                                    {
                                        verificador = true;
                                    }

                                    else if (!CepSecundarioT.Equals("_____-___"))
                                    {
                                        //Cep Segundario Automatico
                                        if (CepManualSe == 0)
                                        {
                                            if (labelConfirmacaoSecundario.Text.Equals("Resultado:"))
                                            {
                                                verificador = false;
                                                MessageBox.Show("Pesquisa o cep secundario!");
                                            }
                                            if (labelConfirmacaoSecundario.Text.Equals("sucesso - cep não encontrado"))
                                            {
                                                verificador = false;
                                                MessageBox.Show("O cep é não é válido!");
                                            }
                                            if (labelConfirmacaoSecundario.Text.Equals("sucesso - cep completo"))
                                            {
                                                verificador = true;
                                                CepSecundario = true;
                                            }
                                        }
                                        //Cep Segundario Manual
                                        if (CepManualSe == 1)
                                        {
                                            if ((Endereco2(txtEnderecoCliente, errorProviderCadastraClienteRegistro) == true) && (bairro2(txtBairroCliente, errorProviderCadastraClienteRegistro) == true) &&
                                           (Cidade2(txtCidadeCliente, errorProviderCadastraClienteRegistro) == true))
                                            {
                                                verificador = true;
                                                CepSecundario = true;
                                            }
                                        }

                                    }
                                    if ((validaNome(txtNomeCliente, errorProviderCadastraClienteRegistro) == true) && (verificador == true))//(labelConfirmacao.Text).Equals("sucesso - cep completo"))
                                    {
                                        try
                                        {
                                            Conexao conexao = new Conexao(this.connetionString);
                                            DALDateSystem dal = new DALDateSystem(conexao); //cadastra Pessoa

                                            Conexao conexao4 = new Conexao(this.connetionString);
                                            DALDateSystem dal4 = new DALDateSystem(conexao4);//Cadastra Cep Principal

                                            Conexao conexao1 = new Conexao(this.connetionString);
                                            DALDateSystem dal1 = new DALDateSystem(conexao1);//cadastra Cep

                                            Conexao conexao2 = new Conexao(this.connetionString);
                                            DALRegistroGerado dal2 = new DALRegistroGerado(conexao2);//cadastra Pesssoa Clientes DataSystem

                                            Conexao conexao5 = new Conexao(this.connetionString);
                                            DALDateSystem dal5 = new DALDateSystem(conexao5);//cadastra Pesssoa Juridica 


                                            Pessoa cadastra = new Pessoa();

                                            Registro pessoaRegistro = new Registro();

                                            CepSecundario cadastraCepSecundario = new CepSecundario();

                                            CepJ cadastraCepJurica = new CepJ();

                                            PessoaFisica PessoaFisica = new PessoaFisica();

                                            // Dados Pessoa

                                            cadastra.IdOs = 0;
                                            cadastra.Situacao = 1;
                                            cadastra.Nome = txtNomeCliente.Text;
                                            cadastra.Telefone = txtTelefoneCliente.Text;
                                            cadastra.Telefone2 = txtTelefone2Cliente.Text;
                                            cadastra.FaxTelefone = txtFaxTelefoneCliente.Text;
                                            cadastra.TelexTelefone = txtTelexTelefoneCliente.Text;
                                            cadastra.Email = txtEmailCliente.Text;
                                            cadastra.Observacao = txtObservacaoCliente.Text;
                                            cadastra.Tipo = txtTipoCliente.Text;
                                            cadastra.CpMunicipio = txtCpMunicipalCliente.Text;
                                            cadastra.Municipio = txtMunicipioCliente.Text;
                                            cadastra.Pais = txtPaisCliente.Text;
                                            cadastra.DesPais = txtDescPaisCliente.Text;
                                            cadastra.IdPessoaTipo = 2;

                                            //Pessoa Juridica
                                            PessoaJuridica pessoaJuridica = new PessoaJuridica();
                                            pessoaJuridica.IdPessoaTipo = 2;
                                            pessoaJuridica.Cnpj = txtCnpJTextBox.Text;
                                            pessoaJuridica.RazaoSocial = txtrAZAO_SOCIALTextBox.Text;
                                            pessoaJuridica.InscricaoStadual = txtiNSCRICAO_STADUALTextBox.Text;
                                            pessoaJuridica.NomeContato = txtnOME_CONTATOTextBox.Text;
                                            pessoaJuridica.Cnae = txtCnae.Text;


                                            //Dados Pessoa Cliente
                                            pessoaRegistro.Nome = txtNomeCliente.Text;

                                            //Dados CEP
                                            if(maskedTextBoxCep.Text == "")
                                            {
 
                                            }
                                            else cadastraCepJurica.Cepc = int.Parse(maskedTextBoxCep.Text);
                                            cadastraCepJurica.TipoLogradouro = txtLogradouro.Text;
                                            cadastraCepJurica.Endereco = txtEndereco.Text;
                                            cadastraCepJurica.Numero = txtNumero.Text;
                                            cadastraCepJurica.Complemento = txtComplemento.Text;
                                            cadastraCepJurica.Bairro = txtBairro.Text;
                                            cadastraCepJurica.Cidade = txtCidade.Text;
                                            cadastraCepJurica.SiglaCidade = txtSigla.Text;

                                            ////Dados CEP Secundario
                                            if (labelConfirmacaoSecundario.Text.Equals("sucesso - cep completo"))
                                            {
                                                cadastraCepSecundario.Cepc = int.Parse(txtCepCliente.Text);
                                                cadastraCepSecundario.TipoLogradouro = txtTipo_logradouro.Text;
                                                cadastraCepSecundario.Endereco = txtEnderecoCliente.Text;
                                                cadastraCepSecundario.Numero = txtBairroNumero.Text;
                                                cadastraCepSecundario.Complemento = txtComplCliente.Text;
                                                cadastraCepSecundario.Bairro = txtBairroCliente.Text;
                                                cadastraCepSecundario.Cidade = txtCidadeCliente.Text;
                                                cadastraCepSecundario.SiglaCidade = txtSiglaCidadeCliente.Text;
                                            }
                                            if (!labelConfirmacaoSecundario.Text.Equals("sucesso - cep completo"))
                                            {

                                            }

                                            if ((validaCnpj(txtCnpJTextBox, errorProviderCadastraClienteRegistro) == true))
                                            //(labelConfirmacao.Text).Equals("sucesso - cep completo"))
                                            {

                                                if (this.operacao == "Inserir")
                                                {
                                                    if (maskedTextBoxCep.Text == "")
                                                    {
                                                        if (VerificadorEndereco() == true)
                                                        {
                                                            DialogResult SalvaClienteRegistro = MessageBox.Show("Deseja Salvar em Pessoa Juridica?\n" +
                                                                "Por não consta endereço na Receita Federal sera salvo sem o mesmo.", "Aviso", MessageBoxButtons.YesNo);

                                                            if (SalvaClienteRegistro == DialogResult.Yes)
                                                            {
                                                                dal.Incluir(cadastra);
                                                                idPessoaJuridica = int.Parse(cadastra.idPessoa.ToString());

                                                                if (idPessoaJuridica > 0)
                                                                {
                                                                    //Inserir Pessoa Juridica
                                                                    pessoaJuridica.idPessoaJuridica = idPessoaJuridica;
                                                                    dal5.IncluirPessoaJuridica(pessoaJuridica);

                                                                    //Inserir Cliente Registro
                                                                    pessoaRegistro.idPessoa = idPessoaJuridica;
                                                                    dal2.IncluirClienteRegistro(pessoaRegistro);

                                                                    //Inserir Cep
                                                                    cadastraCepJurica.idCep = idPessoaJuridica;
                                                                    cadastraCepJurica.Cepc = 00000000;
                                                                    cadastraCepJurica.TipoLogradouro = "";
                                                                    cadastraCepJurica.Endereco = "";
                                                                    cadastraCepJurica.Numero = "";
                                                                    cadastraCepJurica.Complemento = "";
                                                                    cadastraCepJurica.Bairro = "";
                                                                    cadastraCepJurica.Cidade = "";
                                                                    cadastraCepJurica.SiglaCidade = "";
                                                                    dal4.IncluirCepJuridico(cadastraCepJurica);

                                                                    if (CepManualSe == 1)
                                                                    {
                                                                        //Inserir Cep Segundario
                                                                        cadastraCepSecundario.idCep = idPessoaJuridica;

                                                                        cadastraCepSecundario.Numero = txtBairroNumero.Text;
                                                                        dal1.IncluirCepSecundario(cadastraCepSecundario);
                                                                    }

                                                                    MessageBox.Show("Cliente Cadastrado com sucesso!");

                                                                    FecharTodosFormulario();

                                                                    FormCadastraClienteRegistro cadastracliente = new FormCadastraClienteRegistro(this.NomeServidor, this.NomeBaseDados, this.NomeUsuario, this.SenhaBaseDados);
                                                                    cadastracliente.MdiParent = FormCadastraClienteRegistro.ActiveForm;
                                                                    cadastracliente.Show();
                                                                    cadastracliente.Top = 0;
                                                                    cadastracliente.Left = 0;
                                                                }
                                                                else if (idPessoaJuridica <= 0)
                                                                {
                                                                    MessageBox.Show("Erro na geração de ID J.1.");
                                                                }
                                                            }
                                                            else if (SalvaClienteRegistro == DialogResult.No)
                                                            {
                                                                MessageBox.Show("Não atribuido ao sistema!");
                                                            }
                                                        }
                                                        if (VerificadorEndereco() == false)
                                                        {
                                                            DialogResult SalvaClienteRegistro = MessageBox.Show("Deseja Salvar em Pessoa Juridica?\n" +
                                                             "Sem um endereço. Passando cep com a numeração 0.", "Aviso", MessageBoxButtons.YesNo);

                                                            if (SalvaClienteRegistro == DialogResult.Yes)
                                                            {
                                                                dal.Incluir(cadastra);
                                                                idPessoaJuridica = int.Parse(cadastra.idPessoa.ToString());

                                                                if (idPessoaJuridica > 0)
                                                                {
                                                                    //Inserir Pessoa Juridica
                                                                    pessoaJuridica.idPessoaJuridica = idPessoaJuridica;
                                                                    dal5.IncluirPessoaJuridica(pessoaJuridica);

                                                                    //Inserir Cliente Registro
                                                                    pessoaRegistro.idPessoa = idPessoaJuridica;
                                                                    dal2.IncluirClienteRegistro(pessoaRegistro);

                                                                    //Inserir Cep
                                                                    cadastraCepJurica.idCep = idPessoaJuridica;
                                                                    cadastraCepJurica.Cepc = 00000000;
                                                                    cadastraCepJurica.TipoLogradouro = "";
                                                                    cadastraCepJurica.Endereco = "";
                                                                    cadastraCepJurica.Numero = "";
                                                                    cadastraCepJurica.Complemento = "";
                                                                    cadastraCepJurica.Bairro = "";
                                                                    cadastraCepJurica.Cidade = "";
                                                                    cadastraCepJurica.SiglaCidade = "";
                                                                    dal4.IncluirCepJuridico(cadastraCepJurica);

                                                                    if (CepManualSe == 1)
                                                                    {
                                                                        //Inserir Cep Segundario
                                                                        cadastraCepSecundario.idCep = idPessoaJuridica;

                                                                        cadastraCepSecundario.Numero = txtBairroNumero.Text;
                                                                        dal1.IncluirCepSecundario(cadastraCepSecundario);
                                                                    }

                                                                    MessageBox.Show("Cliente Cadastrado com sucesso!");

                                                                    FecharTodosFormulario();

                                                                    FormCadastraClienteRegistro cadastracliente = new FormCadastraClienteRegistro(this.NomeServidor, this.NomeBaseDados, this.NomeUsuario, this.SenhaBaseDados);
                                                                    cadastracliente.MdiParent = FormCadastraClienteRegistro.ActiveForm;
                                                                    cadastracliente.Show();
                                                                    cadastracliente.Top = 0;
                                                                    cadastracliente.Left = 0;
                                                                }
                                                                else if (idPessoaJuridica <= 0)
                                                                {
                                                                    MessageBox.Show("Erro na geração de ID J.2.");
                                                                }
                                                            }
                                                            if (SalvaClienteRegistro == DialogResult.No)
                                                            {
                                                                MessageBox.Show("Não atribuido ao sistema!");
                                                            }
                                                        }
                                                    }
                                                    if (maskedTextBoxCep.Text != "")
                                                    {
                                                        dal.Incluir(cadastra);
                                                        idPessoaJuridica = int.Parse(cadastra.idPessoa.ToString());

                                                        if (idPessoaJuridica > 0)
                                                        {
                                                            //Inserir Pessoa Juridica
                                                            pessoaJuridica.idPessoaJuridica = idPessoaJuridica;
                                                            dal5.IncluirPessoaJuridica(pessoaJuridica);

                                                            //Inserir Cliente Registro
                                                            pessoaRegistro.idPessoa = idPessoaJuridica;
                                                            dal2.IncluirClienteRegistro(pessoaRegistro);

                                                            //Inserir Cep
                                                            cadastraCepJurica.idCep = idPessoaJuridica;
                                                            dal4.IncluirCepJuridico(cadastraCepJurica);

                                                            if (CepManualSe == 1)
                                                            {
                                                                //Inserir Cep Segundario
                                                                cadastraCepSecundario.idCep = idPessoaJuridica;

                                                                cadastraCepSecundario.Numero = txtBairroNumero.Text;
                                                                dal1.IncluirCepSecundario(cadastraCepSecundario);
                                                            }

                                                            MessageBox.Show("Cliente Cadastrado com sucesso!");

                                                            FecharTodosFormulario();

                                                            FormCadastraClienteRegistro cadastracliente = new FormCadastraClienteRegistro(this.NomeServidor, this.NomeBaseDados, this.NomeUsuario, this.SenhaBaseDados);
                                                            cadastracliente.MdiParent = FormCadastraClienteRegistro.ActiveForm;
                                                            cadastracliente.Show();
                                                            cadastracliente.Top = 0;
                                                            cadastracliente.Left = 0;
                                                        }
                                                        else if (idPessoaJuridica <= 0)
                                                        {
                                                            MessageBox.Show("Erro na geração de ID J.3.");
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                        catch (Exception ex)
                                        {
                                            MessageBox.Show(ex.Message);
                                        }
                                    }
                                }
                                if (SiteOFF == 1)
                                {
                                    //Pessoa fisica Cep não pode está em branco
                                    if (CepPrincipal.Equals("_____-___"))
                                    {
                                        verificador = false;
                                        MessageBox.Show("O cep não pode está em branco e pesquisa o cep!");
                                    }//Modo cep principal automatico
                                    else if (!CepPrincipal.Equals("_____-___"))
                                    {
                                        if (CepManual == 0)
                                        {
                                            if (labelConfirmacaoPrimario.Text.Equals("Resultado:"))
                                            {
                                                verificador = false;
                                                MessageBox.Show("Pesquisa o cep Principal!");
                                            }
                                            if (labelConfirmacaoPrimario.Text.Equals("sucesso - cep não encontrado"))
                                            {
                                                verificador = false;
                                                MessageBox.Show("O cep é não é válido!");
                                            }
                                            if (labelConfirmacaoPrimario.Text.Equals("sucesso - cep completo"))
                                            {
                                                if (CepSecundarioT.Equals("_____-___"))
                                                {
                                                    verificador = true;
                                                }
                                                //Cep Segundario Automatico
                                                else if (!CepSecundarioT.Equals("_____-___"))
                                                {
                                                    if (CepManualSe == 0)
                                                    {
                                                        if (labelConfirmacaoSecundario.Text.Equals("Resultado:"))
                                                        {
                                                            verificador = false;
                                                            MessageBox.Show("Pesquisa o cep Secundario!");
                                                        }
                                                        if (labelConfirmacaoSecundario.Text.Equals("sucesso - cep não encontrado"))
                                                        {
                                                            verificador = false;
                                                            MessageBox.Show("O cep é não é válido!");
                                                        }
                                                        if (labelConfirmacaoSecundario.Text.Equals("sucesso - cep completo"))
                                                        {
                                                            verificador = true;
                                                            CepSecundario = true;
                                                        }
                                                    }
                                                    if (CepManualSe == 1)
                                                    {
                                                        if ((Cep2(txtCepCliente, errorProviderCadastraClienteRegistro) == true) && (Endereco2(txtEnderecoCliente, errorProviderCadastraClienteRegistro) == true) &&
                                                               (bairro2(txtBairroCliente, errorProviderCadastraClienteRegistro) == true) && (Cidade2(txtCidadeCliente, errorProviderCadastraClienteRegistro) == true))
                                                        {
                                                            verificador = true;
                                                            CepSecundario = true;
                                                        }
                                                    }
                                                }

                                            }

                                        }
                                        if (CepManual == 1)
                                        {
                                            if ((Cep(maskedTextBoxCep, errorProviderCadastraClienteRegistro) == true) && (Endereco(txtEndereco, errorProviderCadastraClienteRegistro) == true) &&
                                            (bairro(txtBairro, errorProviderCadastraClienteRegistro) == true) && (Cidade(txtCidade, errorProviderCadastraClienteRegistro) == true))
                                            {
                                                if (CepSecundarioT.Equals("_____-___"))
                                                {
                                                    verificador = true;
                                                }
                                                else if (!CepSecundarioT.Equals("_____-___"))
                                                {
                                                    if (CepManualSe == 0)
                                                    {
                                                        //Cep Segundario Automatico
                                                        if (labelConfirmacaoSecundario.Text.Equals("Resultado:"))
                                                        {
                                                            verificador = false;
                                                            MessageBox.Show("Pesquisa o cep secundario!");
                                                        }
                                                        if (labelConfirmacaoSecundario.Text.Equals("sucesso - cep não encontrado"))
                                                        {
                                                            verificador = false;
                                                            MessageBox.Show("O cep é não é válido!");
                                                        }
                                                        if (labelConfirmacaoSecundario.Text.Equals("sucesso - cep completo"))
                                                        {
                                                            verificador = true;

                                                            CepSecundario = true;
                                                        }
                                                    }
                                                    if (CepManualSe == 1)
                                                    {
                                                        //Cep Segundario Manual
                                                        if (!CepSecundarioT.Equals("_____-___"))
                                                        {
                                                            if ((Endereco2(txtEnderecoCliente, errorProviderCadastraClienteRegistro) == true) && (bairro2(txtBairroCliente, errorProviderCadastraClienteRegistro) == true) &&
                                                               (Cidade2(txtCidadeCliente, errorProviderCadastraClienteRegistro) == true))
                                                            {
                                                                verificador = true;

                                                                CepSecundario = true;
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }


                                    if ((validaNome(txtNomeCliente, errorProviderCadastraClienteRegistro) == true) && (verificador == true) &&
                                        (validaCnpj(txtCnpJTextBox, errorProviderCadastraClienteRegistro) == true) && (validaRazãoSocial(txtrAZAO_SOCIALTextBox, errorProviderCadastraClienteRegistro) == true) &&
                                        (validaInscricaoStadual(txtiNSCRICAO_STADUALTextBox, errorProviderCadastraClienteRegistro) == true) && (validaCnae(txtCnae, errorProviderCadastraClienteRegistro) == true) &&
                                        (txtCnpJTextBox.Text.Length == 14))//(labelConfirmacao.Text).Equals("sucesso - cep completo"))
                                    {
                                        try
                                        {
                                            Conexao conexao = new Conexao(this.connetionString);
                                            DALDateSystem dal = new DALDateSystem(conexao); //cadastra Pessoa

                                            Conexao conexao4 = new Conexao(this.connetionString);
                                            DALDateSystem dal4 = new DALDateSystem(conexao4);//Cadastra Cep Principal

                                            Conexao conexao1 = new Conexao(this.connetionString);
                                            DALDateSystem dal1 = new DALDateSystem(conexao1);//cadastra Cep

                                            Conexao conexao2 = new Conexao(this.connetionString);
                                            DALRegistroGerado dal2 = new DALRegistroGerado(conexao2);//cadastra Pesssoa Clientes Registro

                                            Conexao conexao5 = new Conexao(this.connetionString);
                                            DALDateSystem dal5 = new DALDateSystem(conexao5);//cadastra Pesssoa Juridica 


                                            Pessoa cadastra = new Pessoa();

                                            Registro pessoaRegistro = new Registro();

                                            CepSecundario cadastraCepSecundario = new CepSecundario();

                                            CepJ cadastraCepJurica = new CepJ();

                                            // Dados Pessoa

                                            cadastra.IdOs = 0;
                                            cadastra.Situacao = 1;
                                            cadastra.Nome = txtNomeCliente.Text;
                                            cadastra.Telefone = txtTelefoneCliente.Text;
                                            cadastra.Telefone2 = txtTelefone2Cliente.Text;
                                            cadastra.FaxTelefone = txtFaxTelefoneCliente.Text;
                                            cadastra.TelexTelefone = txtTelexTelefoneCliente.Text;
                                            cadastra.Email = txtEmailCliente.Text;
                                            cadastra.Observacao = txtObservacaoCliente.Text;
                                            cadastra.Tipo = txtTipoCliente.Text;
                                            cadastra.CpMunicipio = txtCpMunicipalCliente.Text;
                                            cadastra.Municipio = txtMunicipioCliente.Text;
                                            cadastra.Pais = txtPaisCliente.Text;
                                            cadastra.DesPais = txtDescPaisCliente.Text;
                                            cadastra.IdPessoaTipo = 2;

                                            //Pessoa Juridica
                                            PessoaJuridica pessoaJuridica = new PessoaJuridica();
                                            pessoaJuridica.IdPessoaTipo = 2;
                                            pessoaJuridica.Cnpj = txtCnpJTextBox.Text;
                                            pessoaJuridica.RazaoSocial = txtrAZAO_SOCIALTextBox.Text;
                                            pessoaJuridica.InscricaoStadual = txtiNSCRICAO_STADUALTextBox.Text;
                                            pessoaJuridica.NomeContato = txtnOME_CONTATOTextBox.Text;
                                            pessoaJuridica.Cnae = txtCnae.Text;


                                            //Dados Pessoa Cliente
                                            pessoaRegistro.Nome = txtNomeCliente.Text;

                                            //Dados CEP
                                            if (maskedTextBoxCep.Text == "")
                                            {
                                                
                                            }
                                            else cadastraCepJurica.Cepc = int.Parse(maskedTextBoxCep.Text);
                                            cadastraCepJurica.TipoLogradouro = txtLogradouro.Text;
                                            cadastraCepJurica.Endereco = txtEndereco.Text;
                                            cadastraCepJurica.Numero = txtNumero.Text;
                                            cadastraCepJurica.Complemento = txtComplemento.Text;
                                            cadastraCepJurica.Bairro = txtBairro.Text;
                                            cadastraCepJurica.Cidade = txtCidade.Text;
                                            cadastraCepJurica.SiglaCidade = txtSigla.Text;

                                            ////Dados CEP Secundario
                                            if (labelConfirmacaoSecundario.Text.Equals("sucesso - cep completo"))
                                            {
                                                cadastraCepSecundario.Cepc = int.Parse(txtCepCliente.Text);
                                                cadastraCepSecundario.TipoLogradouro = txtTipo_logradouro.Text;
                                                cadastraCepSecundario.Endereco = txtEnderecoCliente.Text;
                                                cadastraCepSecundario.Numero = txtBairroNumero.Text;
                                                cadastraCepSecundario.Complemento = txtComplCliente.Text;
                                                cadastraCepSecundario.Bairro = txtBairroCliente.Text;
                                                cadastraCepSecundario.Cidade = txtCidadeCliente.Text;
                                                cadastraCepSecundario.SiglaCidade = txtSiglaCidadeCliente.Text;
                                            }
                                            if (!labelConfirmacaoSecundario.Text.Equals("sucesso - cep completo"))
                                            {

                                            }

                                            if ((validaCnpj(txtCnpJTextBox, errorProviderCadastraClienteRegistro) == true))
                                            //(labelConfirmacao.Text).Equals("sucesso - cep completo"))
                                            {

                                                if (this.operacao == "Inserir")
                                                {
                                                    if (maskedTextBoxCep.Text == "")
                                                    {
                                                        if (VerificadorEndereco() == true)
                                                        {
                                                            DialogResult SalvaClienteRegistro = MessageBox.Show("Deseja Salvar em Pessoa Juridica?\n" +
                                                                "Por não consta endereço na Receita Federal sera salvo sem o mesmo.", "Aviso", MessageBoxButtons.YesNo);

                                                            if (SalvaClienteRegistro == DialogResult.Yes)
                                                            {
                                                                dal.Incluir(cadastra);
                                                                idPessoaJuridica = int.Parse(cadastra.idPessoa.ToString());

                                                                if (idPessoaJuridica > 0)
                                                                {
                                                                    //Inserir Pessoa Juridica
                                                                    pessoaJuridica.idPessoaJuridica = idPessoaJuridica;
                                                                    dal5.IncluirPessoaJuridica(pessoaJuridica);

                                                                    //Inserir Cliente Registro
                                                                    pessoaRegistro.idPessoa = idPessoaJuridica;
                                                                    dal2.IncluirClienteRegistro(pessoaRegistro);

                                                                    //Inserir Cep
                                                                    cadastraCepJurica.idCep = idPessoaJuridica;
                                                                    cadastraCepJurica.Cepc = 00000000;
                                                                    cadastraCepJurica.TipoLogradouro = "";
                                                                    cadastraCepJurica.Endereco = "";
                                                                    cadastraCepJurica.Numero = "";
                                                                    cadastraCepJurica.Complemento = "";
                                                                    cadastraCepJurica.Bairro = "";
                                                                    cadastraCepJurica.Cidade = "";
                                                                    cadastraCepJurica.SiglaCidade = "";

                                                                    dal4.IncluirCepJuridico(cadastraCepJurica);

                                                                    if (CepManualSe == 1)
                                                                    {
                                                                        //Inserir Cep Segundario
                                                                        cadastraCepSecundario.idCep = idPessoaJuridica;
                                                                        cadastraCepSecundario.Numero = txtBairroNumero.Text;
                                                                        dal1.IncluirCepSecundario(cadastraCepSecundario);
                                                                    }
                                                                    MessageBox.Show("Cliente Cadastrado com sucesso!");

                                                                    FecharTodosFormulario();

                                                                    FormCadastraClienteRegistro cadastracliente = new FormCadastraClienteRegistro(this.NomeServidor, this.NomeBaseDados, this.NomeUsuario, this.SenhaBaseDados);
                                                                    cadastracliente.MdiParent = FormCadastraClienteRegistro.ActiveForm;
                                                                    cadastracliente.Show();
                                                                    cadastracliente.Top = 0;
                                                                    cadastracliente.Left = 0;
                                                                }
                                                                else if (idPessoaJuridica <= 0)
                                                                {
                                                                    MessageBox.Show("Erro na geração de ID J.4.");
                                                                }
                                                            }
                                                            else if (SalvaClienteRegistro == DialogResult.No)
                                                            {
                                                                MessageBox.Show("Não atribuido ao sistema!");
                                                            }
                                                        }
                                                        if (VerificadorEndereco() == false)
                                                        {
                                                            DialogResult SalvaClienteRegistro = MessageBox.Show("Deseja Salvar em Pessoa Juridica?\n" +
                                                                "Sem um endereço. Passando cep com a numeração 0.", "Aviso", MessageBoxButtons.YesNo);

                                                            if (SalvaClienteRegistro == DialogResult.Yes)
                                                            {
                                                                dal.Incluir(cadastra);
                                                                idPessoaJuridica = int.Parse(cadastra.idPessoa.ToString());

                                                                if (idPessoaJuridica > 0)
                                                                {
                                                                    //Inserir Pessoa Juridica
                                                                    pessoaJuridica.idPessoaJuridica = idPessoaJuridica;
                                                                    dal5.IncluirPessoaJuridica(pessoaJuridica);

                                                                    //Inserir Cliente Registro
                                                                    pessoaRegistro.idPessoa = idPessoaJuridica;
                                                                    dal2.IncluirClienteRegistro(pessoaRegistro);

                                                                    //Inserir Cep
                                                                    cadastraCepJurica.idCep = idPessoaJuridica;
                                                                    cadastraCepJurica.Cepc = 00000000;
                                                                    dal4.IncluirCepJuridico(cadastraCepJurica);

                                                                    if (CepManualSe == 1)
                                                                    {
                                                                        //Inserir Cep Segundario
                                                                        cadastraCepSecundario.idCep = idPessoaJuridica;
                                                                        cadastraCepSecundario.Numero = txtBairroNumero.Text;
                                                                        dal1.IncluirCepSecundario(cadastraCepSecundario);
                                                                    }
                                                                    MessageBox.Show("Cliente Cadastrado com sucesso!");

                                                                    FecharTodosFormulario();

                                                                    FormCadastraClienteRegistro cadastracliente = new FormCadastraClienteRegistro(this.NomeServidor, this.NomeBaseDados, this.NomeUsuario, this.SenhaBaseDados);
                                                                    cadastracliente.MdiParent = FormCadastraClienteRegistro.ActiveForm;
                                                                    cadastracliente.Show();
                                                                    cadastracliente.Top = 0;
                                                                    cadastracliente.Left = 0;
                                                                }
                                                                else if (idPessoaJuridica <= 0)
                                                                {
                                                                    MessageBox.Show("Erro na geração de ID J.4.");
                                                                }
                                                            }
                                                            else if (SalvaClienteRegistro == DialogResult.No)
                                                            {
                                                                MessageBox.Show("Não atribuido ao sistema!");
                                                            }
                                                        }
                                                    }
                                                    if (maskedTextBoxCep.Text != "")
                                                    {
                                                        dal.Incluir(cadastra);

                                                        idPessoaJuridica = int.Parse(cadastra.idPessoa.ToString());

                                                        if (idPessoaJuridica > 0)
                                                        {
                                                            //Inserir Pessoa Juridica
                                                            pessoaJuridica.idPessoaJuridica = idPessoaJuridica;
                                                            dal5.IncluirPessoaJuridica(pessoaJuridica);

                                                            //Inserir Cliente Registro
                                                            pessoaRegistro.idPessoa = idPessoaJuridica;
                                                            dal2.IncluirClienteRegistro(pessoaRegistro);

                                                            //Inserir Cep
                                                            cadastraCepJurica.idCep = idPessoaJuridica;

                                                            dal4.IncluirCepJuridico(cadastraCepJurica);

                                                            if (CepManualSe == 1)
                                                            {
                                                                //Inserir Cep Segundario
                                                                cadastraCepSecundario.idCep = idPessoaJuridica;
                                                                cadastraCepSecundario.Numero = txtBairroNumero.Text;
                                                                dal1.IncluirCepSecundario(cadastraCepSecundario);
                                                            }
                                                            MessageBox.Show("Cliente Cadastrado com sucesso!");

                                                            FecharTodosFormulario();

                                                            FormCadastraClienteRegistro cadastracliente = new FormCadastraClienteRegistro(this.NomeServidor, this.NomeBaseDados, this.NomeUsuario, this.SenhaBaseDados);
                                                            cadastracliente.MdiParent = FormCadastraClienteRegistro.ActiveForm;
                                                            cadastracliente.Show();
                                                            cadastracliente.Top = 0;
                                                            cadastracliente.Left = 0;
                                                        }
                                                        else if (idPessoaJuridica <= 0)
                                                        {
                                                            MessageBox.Show("Erro na geração de ID J.4. ");
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                        catch (Exception ex)
                                        {
                                            MessageBox.Show(ex.Message);
                                        }
                                    }
                                }
                            }
                        }
                    }
                    else MessageBox.Show("Telefone da Empresa");
                }
            }
            catch(Exception ex)
            {
                ex.ToString();
            }
        }

        private void buttonLimpaCliente_Click(object sender, EventArgs e)
        {
            AlteraBotoes(10);
        }

        private void buttonCancelarCliente_Click(object sender, EventArgs e)
        {
            FecharTodosFormulario();

            FormCadastraClienteRegistro FormClienteProposta2 = new FormCadastraClienteRegistro(this.NomeServidor, this.NomeBaseDados,
            this.NomeUsuario, this.SenhaBaseDados);
            FormClienteProposta2.MdiParent = FormCadastraClienteRegistro.ActiveForm;
            FormClienteProposta2.Show();
            FormClienteProposta2.Top = 0;
            FormClienteProposta2.Left = 0;
        }

        private void buttonFecharCliente_Click(object sender, EventArgs e)
        {
            FecharTodosFormulario();
        }

        private void radioButtonPessoaFisica_CheckedChanged(object sender, EventArgs e)
        {
            AlteraBotoes(10);
            AlteraBotoes(11);
            SiteOFF = 0;
            maskedTextBoxCep.Enabled = true;
        }

        private void radioButtonPessoaJuridica_CheckedChanged(object sender, EventArgs e)
        {
            AlteraBotoes(10);
            AlteraBotoes(12);
            SiteOFF = 0;
        }

        private void buttonCnpjManual_Click(object sender, EventArgs e)
        {
            AlteraBotoesCnpj(1);
            SiteOFF = 1;
            maskedTextBoxCep.Enabled = true;
        }

        private void buttonCnpjAutomatico_Click(object sender, EventArgs e)
        {
            try
            {
                carregarCaptcha();
            }
            catch (Exception es)
            {
                es.ToString();
            }
        }
        private void buttonBuscaCep_Click(object sender, EventArgs e)
        {
            try
            {
                string xml = "http://cep.republicavirtual.com.br/web_cep.php?cep=@cep&formato=xml"
    .Replace("@cep", txtCepCliente.Text);
                DataSet ds = new DataSet();
                ds.ReadXml(xml);

                labelConfirmacaoSecundario.Text = ds.Tables[0].Rows[0][1].ToString();
                txtTipo_logradouro.Text = ds.Tables[0].Rows[0][5].ToString();
                txtEnderecoCliente.Text = ds.Tables[0].Rows[0][6].ToString();
                txtBairroCliente.Text = ds.Tables[0].Rows[0][4].ToString();
                txtCidadeCliente.Text = ds.Tables[0].Rows[0][3].ToString();
                txtSiglaCidadeCliente.Text = ds.Tables[0].Rows[0][2].ToString();
            }
            catch
            {
                MessageBox.Show(" Erro: " + e.ToString());
            }
        }

        private void buttonCepManualSegun_Click(object sender, EventArgs e)
        {
            if (TrocaCepBotaoTempoOs2 == 0)
            {
                AlteraBotoesCnpj(6);
                AlteraBotoesCnpj(8);
            }
            else if (TrocaCepBotaoTempoOs2 == 1)
            {
                AlteraBotoesCnpj(5);
                AlteraBotoesCnpj(8);
            }
        }

        private void buttonCadastroCliente_Click(object sender, EventArgs e)
        {
            try
            {
                this.operacao = "Inserir";

                buttonVerifica.Enabled = true;

                AlteraBotoes(1);


                checkBoxClienteSituacao.Checked = true;

                checkBoxClienteSituacao.Enabled = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Carregar o Salvar! " + ex.Message);
            }
        }

        private void buttonConsultaCnpj_Click(object sender, EventArgs e)
        {
            ConsultaCnpj();
        }

        private void buttonTrocaImagem_Click(object sender, EventArgs e)
        {
            carregarCaptcha();
        }

        private void txtCnpjConsulta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                ConsultaCnpj();
            }
            //Se a tecla digitada não for número
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }
            if (e.KeyChar == 13)
            {
                ConsultaCnpj();
            }
        }

        private void txtLetrasConulta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                ConsultaCnpj();
            }
        }
        public void ConsultaCnpj()
        {
            try
            {
                if ((txtCnpjConsulta.Text == "") || (txtLetrasConulta.Text == ""))
                {
                    MessageBox.Show("Cnpj ou Letras não podem está em branco!");
                }
                if (!(txtCnpjConsulta.Text == "") && !(txtLetrasConulta.Text == ""))
                {
                    Cursor cursor;
                    cursor = this.Cursor;

                    try
                    {
                        this.Cursor = Cursors.WaitCursor;
                        string tmp = consulta.Consulta(txtCnpjConsulta.Text, txtLetrasConulta.Text);

                        if (tmp.Length > 0)
                        {
                            txtCnpJTextBox.Text = txtCnpjConsulta.Text;
                            txtrAZAO_SOCIALTextBox.Text = RecuperaColunaValor(tmp, Coluna.RazaoSocial);
                            txtNomeCliente.Text = RecuperaColunaValor(tmp, Coluna.RazaoSocial);
                            txtEndereco.Text = RecuperaColunaValor(tmp, Coluna.EnderecoLogradouro);
                            txtNumero.Text = RecuperaColunaValor(tmp, Coluna.EnderecoNumero);
                            txtBairro.Text = RecuperaColunaValor(tmp, Coluna.EnderecoBairro);
                            txtCnae.Text = RecuperaColunaValor(tmp, Coluna.AtividadeEconomicaPrimaria);
                            txtCidade.Text = RecuperaColunaValor(tmp, Coluna.EnderecoCidade);
                            txtSigla.Text = RecuperaColunaValor(tmp, Coluna.EnderecoEstado);
                            txtComplemento.Text = RecuperaColunaValor(tmp, Coluna.EnderecoComplemento);
                            maskedTextBoxCep.Text = RecuperaColunaValor(tmp, Coluna.EnderecoCEP);
                            txtiNSCRICAO_STADUALTextBox.Text = RecuperaColunaValor(tmp, Coluna.NumeroDaInscricao);

                        }
                        if (tmp.Length <= 0)
                        {
                            tmp = consulta.Consulta(null, null);
                            MessageBox.Show("Não foi possível consultar Registro. 1");
                        }
                    }
                    catch (Exception)
                    {
                        txtLetrasConulta.Clear();
                        pictureBoxLetras.Image = null;

                        //string tmp = consulta.Consulta(null, null);

                        MessageBox.Show(" Erro ocorrido por possível lentidão na Receita Federal.\n Se persistir Cadastra manualmente! 2");

                        carregarCaptcha();
                    }

                    this.Cursor = cursor;
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Error se CNPJ e Letras não forem digitadas. 6");
            }

        }

        private enum Coluna
        {
            RazaoSocial = 0,
            NomeFantasia,

            AtividadeEconomicaPrimaria,
            AtividadeEconomicaSecundaria,

            NumeroDaInscricao,
            MatrizFilial,
            NaturezaJuridica,

            SituacaoCadastral,
            DataSituacaoCadastral,
            MotivoSituacaoCadastral,

            EnderecoLogradouro,
            EnderecoNumero,
            EnderecoComplemento,
            EnderecoCEP,
            EnderecoBairro,
            EnderecoCidade,
            EnderecoEstado


        };
        private String RecuperaColunaValor(String pattern, Coluna col)
        {
            String S = pattern.Replace("\n", "").Replace("\t", "").Replace("\r", "");

            switch (col)
            {
                case Coluna.RazaoSocial:
                    {
                        S = StringEntreString(S, "<!-- Início Linha NOME EMPRESARIAL -->", "<!-- Fim Linha NOME EMPRESARIAL -->");
                        S = StringEntreString(S, "<tr>", "</tr>");
                        S = StringEntreString(S, "<b>", "</b>");
                        return S.Trim();
                    }
                case Coluna.NomeFantasia:
                    {
                        S = StringEntreString(S, "<!-- Início Linha ESTABELECIMENTO -->", "<!-- Fim Linha ESTABELECIMENTO -->");
                        S = StringEntreString(S, "<tr>", "</tr>");
                        S = StringEntreString(S, "<b>", "</b>");
                        return S.Trim();
                    }
                case Coluna.NaturezaJuridica:
                    {
                        S = StringEntreString(S, "<!-- Início Linha NATUREZA JURÍDICA -->", "<!-- Fim Linha NATUREZA JURÍDICA -->");
                        S = StringEntreString(S, "<tr>", "</tr>");
                        S = StringEntreString(S, "<b>", "</b>");
                        return S.Trim();
                    }
                case Coluna.AtividadeEconomicaPrimaria:
                    {
                        S = StringEntreString(S, "<!-- Início Linha ATIVIDADE ECONOMICA -->", "<!-- Fim Linha ATIVIDADE ECONOMICA -->");
                        S = StringEntreString(S, "<tr>", "</tr>");
                        S = StringEntreString(S, "<b>", "</b>");
                        return S.Trim();
                    }
                case Coluna.AtividadeEconomicaSecundaria:
                    {
                        S = StringEntreString(S, "<!-- Início Linha ATIVIDADE ECONOMICA SECUNDARIA-->", "<!-- Fim Linha ATIVIDADE ECONOMICA SECUNDARIA -->");
                        S = StringEntreString(S, "<tr>", "</tr>");
                        S = StringEntreString(S, "<b>", "</b>");
                        return S.Trim();
                    }
                case Coluna.NumeroDaInscricao:
                    {
                        S = StringEntreString(S, "<!-- Início Linha NÚMERO DE INSCRIÇÃO -->", "<!-- Fim Linha NÚMERO DE INSCRIÇÃO -->");
                        S = StringEntreString(S, "<tr>", "</tr>");
                        S = StringEntreString(S, "<b>", "</b>");
                        return S.Trim();
                    }
                case Coluna.MatrizFilial:
                    {
                        S = StringEntreString(S, "<!-- Início Linha NÚMERO DE INSCRIÇÃO -->", "<!-- Fim Linha NÚMERO DE INSCRIÇÃO -->");
                        S = StringEntreString(S, "<tr>", "</tr>");
                        S = StringSaltaString(S, "</b>");
                        S = StringEntreString(S, "<b>", "</b>");
                        return S.Trim();
                    }
                case Coluna.EnderecoLogradouro:
                    {
                        S = StringEntreString(S, "<!-- Início Linha LOGRADOURO -->", "<!-- Fim Linha LOGRADOURO -->");
                        S = StringEntreString(S, "<tr>", "</tr>");
                        S = StringEntreString(S, "<b>", "</b>");
                        return S.Trim();
                    }
                case Coluna.EnderecoNumero:
                    {
                        S = StringEntreString(S, "<!-- Início Linha LOGRADOURO -->", "<!-- Fim Linha LOGRADOURO -->");
                        S = StringEntreString(S, "<tr>", "</tr>");
                        S = StringSaltaString(S, "</b>");
                        S = StringEntreString(S, "<b>", "</b>");
                        return S.Trim();
                    }
                case Coluna.EnderecoComplemento:
                    {
                        S = StringEntreString(S, "<!-- Início Linha LOGRADOURO -->", "<!-- Fim Linha LOGRADOURO -->");
                        S = StringEntreString(S, "<tr>", "</tr>");
                        S = StringSaltaString(S, "</b>");
                        S = StringSaltaString(S, "</b>");
                        S = StringEntreString(S, "<b>", "</b>");
                        return S.Trim();
                    }
                case Coluna.EnderecoCEP:
                    {
                        S = StringEntreString(S, "<!-- Início Linha CEP -->", "<!-- Fim Linha CEP -->");
                        S = StringEntreString(S, "<tr>", "</tr>");
                        S = StringEntreString(S, "<b>", "</b>");
                        return S.Trim();
                    }
                case Coluna.EnderecoBairro:
                    {
                        S = StringEntreString(S, "<!-- Início Linha CEP -->", "<!-- Fim Linha CEP -->");
                        S = StringEntreString(S, "<tr>", "</tr>");
                        S = StringSaltaString(S, "</b>");
                        S = StringEntreString(S, "<b>", "</b>");
                        return S.Trim();
                    }
                case Coluna.EnderecoCidade:
                    {
                        S = StringEntreString(S, "<!-- Início Linha CEP -->", "<!-- Fim Linha CEP -->");
                        S = StringEntreString(S, "<tr>", "</tr>");
                        S = StringSaltaString(S, "</b>");
                        S = StringSaltaString(S, "</b>");
                        S = StringEntreString(S, "<b>", "</b>");
                        return S.Trim();
                    }
                case Coluna.EnderecoEstado:
                    {
                        S = StringEntreString(S, "<!-- Início Linha CEP -->", "<!-- Fim Linha CEP -->");
                        S = StringEntreString(S, "<tr>", "</tr>");
                        S = StringSaltaString(S, "</b>");
                        S = StringSaltaString(S, "</b>");
                        S = StringSaltaString(S, "</b>");
                        S = StringEntreString(S, "<b>", "</b>");
                        return S.Trim();
                    }
                case Coluna.SituacaoCadastral:
                    {
                        S = StringEntreString(S, "<!-- Início Linha SITUAÇÃO CADASTRAL -->", "<!-- Fim Linha SITUACAO CADASTRAL -->");
                        S = StringEntreString(S, "<tr>", "</tr>");
                        S = StringEntreString(S, "<b>", "</b>");
                        return S.Trim();
                    }
                case Coluna.DataSituacaoCadastral:
                    {
                        S = StringEntreString(S, "<!-- Início Linha SITUAÇÃO CADASTRAL -->", "<!-- Fim Linha SITUACAO CADASTRAL -->");
                        S = StringEntreString(S, "<tr>", "</tr>");
                        S = StringSaltaString(S, "</b>");
                        S = StringEntreString(S, "<b>", "</b>");
                        return S.Trim();
                    }
                case Coluna.MotivoSituacaoCadastral:
                    {
                        S = StringEntreString(S, "<!-- Início Linha MOTIVO DE SITUAÇÃO CADASTRAL -->", "<!-- Fim Linha MOTIVO DE SITUAÇÃO CADASTRAL -->");
                        S = StringEntreString(S, "<tr>", "</tr>");
                        S = StringEntreString(S, "<b>", "</b>");
                        return S.Trim();
                    }

                default:
                    {
                        return S;
                    }
            }
        }

        private String StringEntreString(String Str, String StrInicio, String StrFinal)
        {
            int Ini;
            int Fim;
            int Diff;
            Ini = Str.IndexOf(StrInicio);
            Fim = Str.IndexOf(StrFinal);
            if (Ini > 0) Ini = Ini + StrInicio.Length;
            if (Fim > 0) Fim = Fim + StrFinal.Length;
            Diff = ((Fim - Ini) - StrFinal.Length);
            if ((Fim > Ini) && (Diff > 0))
                return Str.Substring(Ini, Diff);
            else
                return "";
        }
        private String StringSaltaString(String Str, String StrInicio)
        {
            int Ini;
            Ini = Str.IndexOf(StrInicio);
            if (Ini > 0)
            {
                Ini = Ini + StrInicio.Length;
                return Str.Substring(Ini);
            }
            else
                return Str;
        }

        public string StringPrimeiraLetraMaiuscula(String Str)
        {
            string StrResult = "";
            if (Str.Length > 0)
            {
                StrResult += Str.Substring(0, 1).ToUpper();
                StrResult += Str.Substring(1, Str.Length - 1).ToLower();
            }
            return StrResult;
        }
        public void carregarCaptcha()
        {
            try
            {
                consulta = new ConsultaCNPJReceita();
                pictureBoxLetras.Text = "";
                pictureBoxLetras.Focus();
                Cursor cursor;
                cursor = this.Cursor;
                this.Cursor = Cursors.WaitCursor;
                Bitmap bit = consulta.GetCaptcha();
                if (bit != null)
                {
                    pictureBoxLetras.Image = bit;
                    AlteraBotoesCnpj(2); //automatico
                    SiteOFF = 0;
                }
                else
                {
                    MessageBox.Show("Não foi possível recuperar a imagem de validação do site da Receita Federal. 3");

                    SiteOFF = 1;

                    AlteraBotoesCnpj(1);//Manual

                    maskedTextBoxCep.Enabled = false;

                }
                this.Cursor = cursor;
                

            }
            catch(Exception ex)
            {
                ex.ToString();

                if(this.SiteTime != 3)
                {
                    MessageBox.Show("Tempo de acesso expirado. 5");

                    FecharTodosFormulario();

                    FormCadastraClienteRegistro FormClienteProposta2 = new FormCadastraClienteRegistro(this.NomeServidor, this.NomeBaseDados,
                    this.NomeUsuario, this.SenhaBaseDados);
                    FormClienteProposta2.MdiParent = FormCadastraClienteRegistro.ActiveForm;
                    FormClienteProposta2.Show();
                    FormClienteProposta2.Top = 0;
                    FormClienteProposta2.Left = 0;
                }
            }
        }
        //CHAMA O METODO CancelaCadastradoCliente Proposta Contrato QUE FECHA FORMULÁRIOS ABERTOS
        public void FecharTodosFormulario()
        {
            CancelaCadastradoCliente(typeof(FormCadastraClienteRegistro));
        }
        //METODO PARA VERIFICA SE O FORMULÁRIO ESTA ABERTO SE TIVER ELE FECHA!
        public static void CancelaCadastradoCliente(Type frmType)
        {
            bool bolCtl = false;
            Type a = frmType;
            foreach (Form form in System.Windows.Forms.Application.OpenForms)
            {
                if (form.GetType().Equals(frmType))
                {
                    form.Close();

                    //MessageBox.Show("Formulario Já foi Fechado.");
                    bolCtl = true;
                    break;
                }
            }

            if (!bolCtl)
            {

            }
        }

        private void FormCadastraClienteRegistro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
            {
                this.Close();
            }
        }

        private void txtCnpJTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Se a tecla digitada não for número
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }
            if (e.KeyChar == 13)
            {
                ConsultaCnpj();
            }
        }

        private void buttonConsultarCara_Click(object sender, EventArgs e)
        {
            try
            {
                txtEndereco.Enabled = true;
                txtNumero.Enabled = true;
                txtBairro.Enabled = true;
                txtComplemento.Enabled = true;
                txtLogradouro.Enabled = true;
                txtCidade.Enabled = true;
                txtSigla.Enabled = true;


                MessageBox.Show(" txtEndereco: " + txtEndereco.TextLength.ToString() + "\n" + " txtNumero: " + txtNumero.TextLength.ToString() + "\n" +
                    " txtBairro: " + txtBairro.TextLength.ToString() + "\n" + " txtComplemento: " + txtComplemento.TextLength.ToString() + "\n" +
                    " txtLogradouro: " + txtLogradouro.TextLength.ToString() + "\n" + " txtCidade: " + txtCidade.TextLength.ToString() + "\n" +
                    " MaxLength: " + txtSigla.TextLength.ToString());

                MessageBox.Show(" txtEndereco: " + txtEndereco.ToString() + "\n" + " txtNumero: " + txtNumero.ToString() + "\n" +
    " txtBairro: " + txtBairro.ToString() + "\n" + " txtComplemento: " + txtComplemento.ToString() + "\n" +
    " txtLogradouro: " + txtLogradouro.ToString() + "\n" + " txtCidade: " + txtCidade.ToString() + "\n" +
    " MaxLength: " + txtSigla.ToString());

                txtCnpJTextBox.Enabled = true;
                txtrAZAO_SOCIALTextBox.Enabled = true;
                txtiNSCRICAO_STADUALTextBox.Enabled = true;
                txtnOME_CONTATOTextBox.Enabled = true;
                txtCnae.Enabled = true;

                MessageBox.Show(" txtCnpJTextBox: " + txtCnpJTextBox.TextLength.ToString() + "\n" + " txtrAZAO_SOCIALTextBox: " + txtrAZAO_SOCIALTextBox.TextLength.ToString() + "\n" +
        " txtiNSCRICAO_STADUALTextBox: " + txtiNSCRICAO_STADUALTextBox.TextLength.ToString() + "\n" + " txtnOME_CONTATOTextBox: " + txtnOME_CONTATOTextBox.TextLength.ToString() + "\n" +
        " txtCnae: " + txtLogradouro.TextLength.ToString());
            }
            catch (Exception ex)
            {
                ex.ToString();
            }




            //try
            //{
            //    pictureBoxLetras.Visible = true;
            //    pictureBoxLetras.Text = "";
            //    pictureBoxLetras.Focus();
            //    pictureBoxLetras.LoadAsync(@"Logotipo da Empresa.jpg");
            //}
            //catch (Exception ex)
            //{
            //    ex.ToString();
            //}


        }

        private void buttonCancelarBusca_Click(object sender, EventArgs e)
        {
            if(pictureBoxLetras.Image != null)
            {
                MessageBox.Show("Consta Imagem");
            }
            if (pictureBoxLetras.Image == null)
            {
                MessageBox.Show("Não consta Imagem");
            }
        }

        private void timerConsultarCNPJ_Tick(object sender, EventArgs e)
        {
            MessageBox.Show("aaaaa");

            //MessageBox.Show(" Valor3 " + this.SiteTime);
            //if (this.SiteTime == 1)
            //{
            //    if (pictureBoxLetras.Image == null)
            //    {
            //        timerConsultarCNPJ.Enabled = false;

            //        SiteTime = 3;

            //        MessageBox.Show("Tempo de acesso expirado. 7");

            //        FecharTodosFormulario();

            //        FormCadastraClienteRegistro FormClienteProposta2 = new FormCadastraClienteRegistro(this.NomeServidor, this.NomeBaseDados,
            //        this.NomeUsuario, this.SenhaBaseDados);
            //        FormClienteProposta2.MdiParent = FormCadastraClienteRegistro.ActiveForm;
            //        FormClienteProposta2.Show();
            //        FormClienteProposta2.Top = 0;
            //        FormClienteProposta2.Left = 0;
            //    }
            //    if (pictureBoxLetras.Image != null)
            //    {
            //        timerConsultarCNPJ.Enabled = false;
            //    }
            //}

            //if (this.SiteTime == 2)
            //{
            //    if (pictureBoxLetras.Image == null)
            //    {
            //        consulta.Consulta(null, null);

            //        timerConsultarCNPJ.Enabled = false;

            //        MessageBox.Show("Não Consta imagem. 4");
            //    }
            //    if (pictureBoxLetras.Image != null)
            //    {
            //        timerConsultarCNPJ.Enabled = false;
            //        //MessageBox.Show("Consta imagem.");
            //    }
            //}

        }

        private void buttonAbrir_Click(object sender, EventArgs e)
        {
            txtEndereco.Enabled = true;
            txtNumero.Enabled = true;
            txtBairro.Enabled = true;
            txtLogradouro.Enabled = true;
            txtCidade.Enabled = true;
            txtSigla.Enabled = true;
            txtCnpJTextBox.Enabled = true;
            txtrAZAO_SOCIALTextBox.Enabled = true;
            txtiNSCRICAO_STADUALTextBox.Enabled = true;
            txtCnae.Enabled = true;
        }
    }
}
