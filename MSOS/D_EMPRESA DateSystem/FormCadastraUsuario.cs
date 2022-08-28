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

namespace DateSystem
{
    public partial class FormCadastraUsuario : Form
    {
        private string UNomeUsuario= "";     
        private string FucionarioRegistro = "";
        private string FucionarioOS = "";
        private string FucionarioVendas = "";
        private string CBaseDados = "";
        private string FuncionarioComercio = "";
        private string DadosPessoas = "";

        int contadorVerificar = 0;

        int cont = 0;

        private Boolean ConfirmacaoNomeUsuario = false;
        private Boolean ConfirmacaoFuncionarioOs = false;
        private Boolean ConfirmacaoFuncionarioVendas = false;
        private Boolean ConfirmacaoUsuarioAcesso = false;
        private Boolean ConfirmacaoFuncionarioRegistro = false;
        private Boolean ConfirmacaoFuncionarioUsuarioVendas = false;
        private Boolean ConfirmacaoBaseDados = false;
        private Boolean ConfirmacaoCep = false;


        Boolean SelecionarTodosPermissao = false;

        private string NIVELACESSO = "";
        public string NivelAcesso
        {
            get
            {
                return this.NIVELACESSO;

            }
            set
            {
                this.NIVELACESSO = value;
            }
        }
        private string CPERMISSAOCLIENTE = "";
        public string CPermissaoCliente
        {
            get
            {
                return this.CPERMISSAOCLIENTE;

            }
            set
            {
                this.CPERMISSAOCLIENTE = value;
            }
        }
        private string CPERMISSAOFORNECEDOR = "";
        public string CPermissaoFornecedor
        {
            get
            {
                return this.CPERMISSAOFORNECEDOR;

            }
            set
            {
                this.CPERMISSAOFORNECEDOR = value;
            }
        }
        private string CPERMISSAOUSUARIOACESSO = "";
        public string CPermissaoUsuarioAcesso
        {
            get
            {
                return this.CPERMISSAOUSUARIOACESSO;

            }
            set
            {
                this.CPERMISSAOUSUARIOACESSO = value;
            }
        }
        private string CPERMISSAOSAPIENS = "";
        public string CPermissaoSapiens
        {
            get
            {
                return this.CPERMISSAOSAPIENS;

            }
            set
            {
                this.CPERMISSAOSAPIENS = value;
            }
        }
        private string CPERMISSAOREGISTRO = "";
        public string CPermissaoRegistro
        {
            get
            {
                return this.CPERMISSAOREGISTRO;

            }
            set
            {
                this.CPERMISSAOREGISTRO = value;
            }
        }
        private int IDACESSOBASEDADOS = 0;
        public int IdAcessoBaseDados
        {
            get
            {
                return this.IDACESSOBASEDADOS;

            }
            set
            {
                this.IDACESSOBASEDADOS = value;
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
        private int USUARIOACESSO = 0;
        public int UsuarioAcesso
        {
            get
            {
                return this.USUARIOACESSO;

            }
            set
            {
                this.USUARIOACESSO = value;
            }
        }

        private string USUARIOTEMPBANCODADOS = "";
        public string UsuarioTempBancoDados
        {
            get
            {
                return this.USUARIOTEMPBANCODADOS;

            }
            set
            {
                this.USUARIOTEMPBANCODADOS = value;
            }
        }
        private string SENHATEMPBANCODADOS = "";
        public string SenhaTempBancoDados
        {
            get
            {
                return this.SENHATEMPBANCODADOS;

            }
            set
            {
                this.SENHATEMPBANCODADOS = value;
            }
        }

        private int CONEXAOACEITA = 0;
        public int ConexaoAceita
        {
            get
            {
                return this.CONEXAOACEITA;

            }
            set
            {
                this.CONEXAOACEITA = value;
            }
        }
        private int NOVOREGISTRO = 0;
        public int NovoRegisto
        {
            get
            {
                return this.NOVOREGISTRO;

            }
            set
            {
                this.NOVOREGISTRO = value;
            }
        }
        private int CRIARFUNCIONARIOOS = 0;
        public int CriarFuncionariosOs
        {
            get
            {
                return this.CRIARFUNCIONARIOOS;

            }
            set
            {
                this.CRIARFUNCIONARIOOS = value;
            }
        }
        private int CRIARFUNCIONARIOVENDAS = 0;
        public int CriarFuncionarioVendas
        {
            get
            {
                return this.CRIARFUNCIONARIOVENDAS;

            }
            set
            {
                this.CRIARFUNCIONARIOVENDAS = value;
            }
        }
        private int CRIARUSUARIOACESSO = 0;
        public int CriarUsuarioAcesso
        {
            get
            {
                return this.CRIARUSUARIOACESSO;

            }
            set
            {
                this.CRIARUSUARIOACESSO = value;
            }
        }
        private int CRIARFUNIONARIOREGISTRO = 0;
        public int CriarFuncionarioRegistro
        {
            get
            {
                return this.CRIARFUNIONARIOREGISTRO;

            }
            set
            {
                this.CRIARFUNIONARIOREGISTRO = value;
            }
        }
        private int CRIARFUNIONARIOPRODUTOS = 0;
        public int CriarFuncionarioProdutos
        {
            get
            {
                return this.CRIARFUNIONARIOPRODUTOS;

            }
            set
            {
                this.CRIARFUNIONARIOPRODUTOS = value;
            }
        }
        private int CRIARPROPOSTA = 0;
        public int CriarProposta
        {
            get
            {
                return this.CRIARPROPOSTA;

            }
            set
            {
                this.CRIARPROPOSTA = value;
            }
        }
        private int PERMISSAOPROPOSTA = 0;
        public int PermissaoProposta
        {
            get
            {
                return this.PERMISSAOPROPOSTA;

            }
            set
            {
                this.PERMISSAOPROPOSTA = value;
            }
        }
        private int PERMISSAOBASEDADOS = 0;
        public int PermissaoBaseDados
        {
            get
            {
                return this.PERMISSAOBASEDADOS;

            }
            set
            {
                this.PERMISSAOBASEDADOS = value;
            }
        }
        private int PERMISSAONIVELACESSO = 0;
        public int PermissaoNivelAcesso
        {
            get
            {
                return this.PERMISSAONIVELACESSO;

            }
            set
            {
                this.PERMISSAONIVELACESSO = value;
            }
        }
        private int PERMISSAOCLIENTE = 0;
        public int PermissaoCliente
        {
            get
            {
                return this.PERMISSAOCLIENTE;

            }
            set
            {
                this.PERMISSAOCLIENTE = value;
            }
        }
        private int PERMISSAOFORNECEDOR = 0;
        public int PermissaoFornecedor
        {
            get
            {
                return this.PERMISSAOFORNECEDOR;

            }
            set
            {
                this.PERMISSAOFORNECEDOR = value;
            }
        }
        private int PERMISSAOFUNCIONARIOOS = 0;
        public int PermissaoFuncionarioOs
        {
            get
            {
                return this.PERMISSAOFUNCIONARIOOS;

            }
            set
            {
                this.PERMISSAOFUNCIONARIOOS = value;
            }
        }
        private int PERMISSAOFUNCIONARIOVENDEDOR = 0;
        public int PermissaoFuncionarioVendedor
        {
            get
            {
                return this.PERMISSAOFUNCIONARIOVENDEDOR;

            }
            set
            {
                this.PERMISSAOFUNCIONARIOVENDEDOR = value;
            }
        }
        private int PERMISSAOUSUARIOACESSO = 0;
        public int PermissaoUsuarioAcesso
        {
            get
            {
                return this.PERMISSAOUSUARIOACESSO;

            }
            set
            {
                this.PERMISSAOUSUARIOACESSO = value;
            }
        }
        private int PERMISSAOSENIORSAPIENS = 0;
        public int PermissaoSeniorSapiens
        {
            get
            {
                return this.PERMISSAOSENIORSAPIENS;

            }
            set
            {
                this.PERMISSAOSENIORSAPIENS = value;
            }
        }
        private int PERMISSAOFUNCIONARIOREGISTRO = 0;
        public int PermissaoFuncionarioRegistro
        {
            get
            {
                return this.PERMISSAOFUNCIONARIOREGISTRO;

            }
            set
            {
                this.PERMISSAOFUNCIONARIOREGISTRO = value;
            }
        }
        private int PERMISSAOFUNCIONARIOPRODUTOS = 0;
        public int PermissaoFuncionarioProdutos
        {
            get
            {
                return this.PERMISSAOFUNCIONARIOPRODUTOS;

            }
            set
            {
                this.PERMISSAOFUNCIONARIOPRODUTOS = value;
            }
        }
        private int USUARIOACESSOADM = 0;
        public int UsuarioAcessoAdm
        {
            get
            {
                return this.USUARIOACESSOADM;

            }
            set
            {
                this.USUARIOACESSOADM = value;
            }
        }
        //ERRO EM DADOS PESSOAS
        private Boolean DadosPessoaNome(TextBox textBox, ErrorProvider errorProvider)
        {
            if (!String.IsNullOrWhiteSpace(txtNomePessoa.Text))
            {
                errorProviderCadastraUsuario.SetError(textBox, "");
                return true;
            }
            else
            {
                errorProviderCadastraUsuario.SetError(textBox, "Nome Não pode se em branco!");
                return false;
            }
        }
        private Boolean DadosPessoaSobreNome(TextBox textBox, ErrorProvider errorProvider)
        {
            if (!String.IsNullOrWhiteSpace(txtSobrenomePessoa.Text))
            {
                errorProviderCadastraUsuario.SetError(textBox, "");
                return true;
            }
            else
            {
                errorProviderCadastraUsuario.SetError(textBox, "Sobre nome não pode está em branco!");
                return false;
            }
        }
        private Boolean DadosPessoaSobreAbreviacao(TextBox textBox, ErrorProvider errorProvider)
        {
            if (!String.IsNullOrWhiteSpace(txtAbreviacao.Text))
            {
                errorProviderCadastraUsuario.SetError(textBox, "");
                return true;
            }
            else
            {
                errorProviderCadastraUsuario.SetError(textBox, "Abreviação não pode esta em branco!");
                return false;
            }
        }
        private Boolean DadosPessoaNumeroEndereco(TextBox textBox, ErrorProvider errorProvider)
        {
            if (!String.IsNullOrWhiteSpace(txtNumeroPessoa.Text))
            {
                errorProviderCadastraUsuario.SetError(textBox, "");
                return true;
            }
            else
            {
                errorProviderCadastraUsuario.SetError(textBox, "Abreviação não pode esta em branco!");
                return false;
            }
        }
        //ERRO EM DADOS PESSOA FUNCIONARIO OS
        private Boolean DadosPessoaFuncionarioOsRE(TextBox textBox, ErrorProvider errorProvider)
        {
            if (!String.IsNullOrWhiteSpace(txtReFuncionarioO.Text))
            {
                errorProviderCadastraUsuario.SetError(textBox, "");
                return true;
            }
            else
            {
                errorProviderCadastraUsuario.SetError(textBox, "Re Não pode se em branco!");
                return false;
            }
        }
        private Boolean DadosPessoaFuncionarioOsAbreviacao(TextBox textBox, ErrorProvider errorProvider)
        {
            if (!String.IsNullOrWhiteSpace(txtFuncionarioAbreviacaoO.Text))
            {
                errorProviderCadastraUsuario.SetError(textBox, "");
                return true;
            }
            else
            {
                errorProviderCadastraUsuario.SetError(textBox, "Sobre nome não pode está em branco!");
                return false;
            }
        }
        //Erro ME DADOS PESSOA FUNCIONARIO CONTRATOS
        private Boolean DadosPessoaFuncionarioContratosRE(TextBox textBox, ErrorProvider errorProvider)
        {
            if (!String.IsNullOrWhiteSpace(txtReFuncionarioRegistro.Text))
            {
                errorProviderCadastraUsuario.SetError(textBox, "");
                return true;
            }
            else
            {
                errorProviderCadastraUsuario.SetError(textBox, "Re Não pode se em branco!");
                return false;
            }
        }
        private Boolean DadosPessoaFuncionarioContratosAbreviacao(TextBox textBox, ErrorProvider errorProvider)
        {
            if (!String.IsNullOrWhiteSpace(txtFuncionarioAbreviacaoRegistro.Text))
            {
                errorProviderCadastraUsuario.SetError(textBox, "");
                return true;
            }
            else
            {
                errorProviderCadastraUsuario.SetError(textBox, "Sobre nome não pode está em branco!");
                return false;
            }
        }
        //ERRO EM DADOS PESSOA FUNCIONARIO VENDEDOR
        private Boolean DadosPessoaFuncionarioVendedorSalario(TextBox textBox, ErrorProvider errorProvider)
        {
            if (!String.IsNullOrWhiteSpace(txtSalarioFuncionarioV.Text))
            {
                errorProviderCadastraUsuario.SetError(textBox, "");
                return true;
            }
            else
            {
                errorProviderCadastraUsuario.SetError(textBox, "Salário Não pode se em branco!");
                return false;
            }
        }
        private Boolean DadosPessoaFuncionarioVendedorAbreviacao(TextBox textBox, ErrorProvider errorProvider)
        {
            if (!String.IsNullOrWhiteSpace(txtAbreviacaoFuncionarioV.Text))
            {
                errorProviderCadastraUsuario.SetError(textBox, "");
                return true;
            }
            else
            {
                errorProviderCadastraUsuario.SetError(textBox, "Abreviação não pode está em branco!");
                return false;
            }
        }
        private Boolean DadosPessoaFuncionarioVendedorComissao(TextBox textBox, ErrorProvider errorProvider)
        {
            if (!String.IsNullOrWhiteSpace(txtComissaoVendedor.Text))
            {
                errorProviderCadastraUsuario.SetError(textBox, "");
                return true;
            }
            else
            {
                errorProviderCadastraUsuario.SetError(textBox, "Comissão não pode está em branco!");
                return false;
            }
        }
        //ERRO EM DADOS PESSOA FUNCIONARIO COMERCIO
        private Boolean DadosPessoaFuncionarioComercio(TextBox textBox, ErrorProvider errorProvider)
        {
            if (!String.IsNullOrWhiteSpace(txtFuncionarioAbreviacaoComercio.Text))
            {
                errorProviderCadastraUsuario.SetError(textBox, "");
                return true;
            }
            else
            {
                errorProviderCadastraUsuario.SetError(textBox, "Comércio Não pode se em branco!");
                return false;
            }
        }
        //ERRO EM DADOS PESSOA FUNCIONARIO Registro
        private Boolean DadosPessoaFuncionarioRegistro(TextBox textBox, ErrorProvider errorProvider)
        {
            if (!String.IsNullOrWhiteSpace(txtReFuncionarioRegistro.Text))
            {
                errorProviderCadastraUsuario.SetError(textBox, "");
                return true;
            }
            else
            {
                errorProviderCadastraUsuario.SetError(textBox, "Registro Não pode se em branco!");
                return false;
            }
        }
        private Boolean DadosPessoaFuncionarioSobreNomeRegistro(TextBox textBox, ErrorProvider errorProvider)
        {
            if (!String.IsNullOrWhiteSpace(txtFuncionarioAbreviacaoRegistro.Text))
            {
                errorProviderCadastraUsuario.SetError(textBox, "");
                return true;
            }
            else
            {
                errorProviderCadastraUsuario.SetError(textBox, "Registro Não pode se em branco!");
                return false;
            }
        }
        //usuario para acesso do sistema.
        private Boolean DadosPessoaUsuarioAcessoSistema(TextBox textBox, ErrorProvider errorProvider)
        {
            if (!String.IsNullOrWhiteSpace(txtUsuarioLoginFuncionario.Text))
            {
                errorProviderCadastraUsuario.SetError(textBox, "");
                return true;
            }
            else
            {
                errorProviderCadastraUsuario.SetError(textBox, "Usuário acesso ao sistema!");
                return false;
            }
        }
        public FormCadastraUsuario(int CriarFuncionariosOs, int CriarFuncionarioVendas, int CriarFuncionarioRegistro, int CriarFuncionarioProdutos,
            int CriarUsuarioAcesso, int CriarProposta, int PermissabaseDados, int PermissaoNivelAcesso,
            int PermissaoCliente, int PermissaoFornecedor, int PermissaoFuncionarioOs, int PermissaoFuncionarioVendedor, int PermissaoUsuarioAcesso,
            int PermissaoSeniorSapiens, int PermissaoFuncionarioRegistro, int PermissaoFuncionarioProdutos, int PermissaoProposta,
            string NomeServidor, string NomeBaseDados, string NomeUsuario, string SenhaBaseDados, int UsuarioAcessoAdm)
        {
            InitializeComponent();

            this.CriarFuncionariosOs = CriarFuncionariosOs;
            this.CriarFuncionarioVendas = CriarFuncionarioVendas;
            this.CriarFuncionarioRegistro = CriarFuncionarioRegistro;
            this.CriarFuncionarioProdutos = CriarFuncionarioProdutos;
            this.CriarUsuarioAcesso = CriarUsuarioAcesso;
            this.CriarProposta = CriarProposta;
            this.PermissaoBaseDados = PermissabaseDados;
            this.PermissaoNivelAcesso = PermissaoNivelAcesso;
            this.PermissaoCliente = PermissaoCliente;
            this.PermissaoFornecedor = PermissaoFornecedor;
            this.PermissaoFuncionarioOs = PermissaoFuncionarioOs;
            this.PermissaoFuncionarioVendedor = PermissaoFuncionarioVendedor;
            this.PermissaoFuncionarioProdutos = PermissaoFuncionarioProdutos;
            this.PermissaoUsuarioAcesso = PermissaoUsuarioAcesso;
            this.PermissaoSeniorSapiens = PermissaoSeniorSapiens;
            this.PermissaoFuncionarioRegistro = PermissaoFuncionarioRegistro;
            this.PermissaoProposta = PermissaoProposta;
            this.NomeServidor = NomeServidor;
            this.NomeBaseDados = NomeBaseDados;
            this.NomeUsuario = NomeUsuario;
            this.SenhaBaseDados = SenhaBaseDados;
            this.UsuarioAcessoAdm = UsuarioAcessoAdm;



            if (UsuarioAcessoAdm == 0)
            {
                checkBoxADM.Enabled = false;
            }
            if (UsuarioAcessoAdm == 1)
            {
                checkBoxADM.Enabled = true;
            }

            txtDataNascimentoPessoa.Value = DateTime.Now.Date;

            //DADOS PESSOAS
            txtNomePessoa.MaxLength = 50; txtSobrenomePessoa.MaxLength = 50; txtAbreviacao.MaxLength = 20; txtLogradouroPessoa.MaxLength = 25; txtEnderecoPessoa.MaxLength = 40; txtComplPessoa.MaxLength = 40;
            txtBairroPessoa.MaxLength = 40; txtCidadePessoa.MaxLength = 40; txtSiglaCidadePessoa.MaxLength = 4; txtTelefonePessoa.MaxLength = 13; txtTelefone2Pessoa.MaxLength = 13; txtCelularCelular.MaxLength = 11;
            txtCelular2Pessoa.MaxLength = 11; txtEmailEmail.MaxLength = 40; comboBoxSexoPessoa.MaxLength = 1; txtCpfPessoa.MaxLength = 11; txtRgPessoa.MaxLength = 9; txtObservacaoPessoa.MaxLength = 40;

            //FUNCIONARIO OS
            txtReFuncionarioO.MaxLength = 16; txtFuncionarioAbreviacaoO.MaxLength = 20; txtFuncionarioEmaillO.MaxLength = 40; maskedTelefoneFuncionarioO.MaxLength = 13; maskedTelefone2FuncionarioO.MaxLength = 13;
            maskedCelularFuncionarioO.MaxLength = 11; maskedCelular2FuncionarioO.MaxLength = 11;

            //FUNCIONARIO VENDAS
            txtSalarioFuncionarioV.MaxLength = 20; txtAbreviacaoFuncionarioV.MaxLength = 20; txtEmailFuncionarioV.MaxLength = 40; maskedTelefoneFuncionarioV.MaxLength = 13; maskedTelefone2FuncionarioV.MaxLength = 13;
            maskedtxtCelularFuncionarioV.MaxLength = 11; maskedCelular2FuncionarioV.MaxLength = 11; txtCargoFuncionarioV.MaxLength = 20; txtDiaPagamentoFuncionarioV.MaxLength = 20; txtComissaoVendedor.MaxLength = 20;
            txtTipoVendedor.MaxLength = 20; txtCodigoVendedor.MaxLength = 20; txtDescricaoVendedor.MaxLength = 50;


            this.connetionString = "Data Source=" + this.NomeServidor + ";Initial Catalog=" + this.NomeBaseDados + ";Persist Security Info=True;User ID=" + this.NomeUsuario + ";Password=" + this.SenhaBaseDados + ";";

            LiberacaoPanel(CriarFuncionarioRegistro, CriarFuncionariosOs, CriarFuncionarioVendas, CriarUsuarioAcesso,
                PermissaoBaseDados, PermissaoNivelAcesso);

        }

        public void LiberacaoPanel(int CriarFuncionarioRegistro, int CriarFuncionariosOs, int CriarFuncionarioVendas,
            int CriarUsuarioAcesso, int PermissaoBaseDados, int PermissaoNivelAcesso)
        {
            //Botão Cadastra Contratos
            if (CriarFuncionarioRegistro == 1)
            {
                buttonCadastraRegistro.Enabled = true;
                //checkBoxCadastraVendedor.Enabled = true;
            }
            //Botão Cadastra Funcionario Os
            if (CriarFuncionariosOs == 1)
            {
                buttonCadastraFuncionario.Enabled = true;
                //checkBoxFUNCIONARIOOS.Enabled = true;
            }
            //Botão Cadastra Funcionario Vendas
            if (CriarFuncionarioVendas == 1)
            {
                buttonCadastraVendedor.Enabled = true;
                //checkBoxCadastraVendedor.Enabled = true;
            }
            //Botão Cadastra Usuario Acesso
            if (CriarUsuarioAcesso == 1)
            {
                buttonCadastraUsuarioAcesso.Enabled = true;
            }
            //Botão Cadastra Base de Dados
            if (PermissaoBaseDados == 1)
            {
                buttonCadastraBaseDados.Enabled = true;
            }
            //Botão Cadastra Nivel de Acesso
            if (PermissaoNivelAcesso == 1)
            {
                buttonCadastraNivelAcesso.Enabled = true;
                //checkNivelAcesso.Enabled = true;
            }
            //Botão Cadastra Nivel de Acesso
            if (CriarFuncionarioProdutos == 1)
            {
                buttonCadastraUsuarioComercio.Enabled = true;
                //checkNivelAcesso.Enabled = true;
            }
            //Botão Cadastra Permissão Proposta
            if (PermissaoProposta == 1)
            {
                buttonCadastraPermissaoProposta.Enabled = true;
                //checkNivelAcesso.Enabled = true;
            }
        }
        public static void Moeda(ref TextBox txt)
        {
            string n = string.Empty;

            double v = 0;

            try
            {
                n = txt.Text.Replace(",", "").Replace(".", "");
                if (n.Equals(""))
                    n = "";
                n = n.PadLeft(3, '0');
                if (n.Length > 3 & n.Substring(0, 1) == "0")
                    n = n.Substring(1, n.Length - 1);
                v = Convert.ToDouble(n) / 100;
                txt.Text = string.Format("{0:N}", v);
                txt.SelectionStart = txt.Text.Length;
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro" + e);
            }
        }
        public static string ConverterValores(string VALORES)
        {
            try
            {
                string ConversaoValores = VALORES;

                Boolean finalizador = false;

                while (finalizador == false)
                {
                    int i = 0;

                    StringBuilder sb = new StringBuilder(VALORES);

                    int quantString = VALORES.Length;

                    string StringTeste = VALORES;


                    //QUEBRA DE LINHA SE FOR MAS QUE UMA LINHA
                    for (i = 0; i <= quantString - 1; i++)
                    {
                        if (StringTeste[i] == '.')
                        {
                            sb.Remove(i, 1);
                            VALORES = sb.ToString();
                            finalizador = false;
                            break;
                        }
                        if (StringTeste[i] == ',')
                        {
                            sb.Remove(i, 1);
                            VALORES = sb.ToString();
                            finalizador = false;
                            break;
                        }
                        else if (!(StringTeste[i] == '.') && !(StringTeste[i] == ','))
                        {
                            finalizador = true;
                            ConversaoValores = sb.ToString();
                        }
                    }
                }

                return ConversaoValores;
            }

            catch (Exception exp)
            {
                return exp.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string valor = ConverterValores(txtSalarioFuncionarioV.Text);
            MessageBox.Show(valor);
        }
        private void checkBoxCadastraVendedor_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxCadastraVendedor.Checked == true)
            {
                //PERMISSÃO DE FUNCIONARIO VENDEDOR
                checkBoxCriarVendedor.Checked = true;
                checkBoxAlterarVendedor.Checked = true;
                checkBoxExcluirVendedor.Checked = true;
                checkBoxPesquisaVendedor.Checked = true;
                checkBoxVisualizarVendedor.Checked = true;
            }
            if (checkBoxCadastraVendedor.Checked == false)
            {

                //PERMISSÃO DE FUNCIONARIO VENDEDOR
                checkBoxCriarVendedor.Checked = false;
                checkBoxAlterarVendedor.Checked = false;
                checkBoxExcluirVendedor.Checked = false;
                checkBoxPesquisaVendedor.Checked = false;
                checkBoxVisualizarVendedor.Checked = false;
            }
        }

        private void checkBoxCadastraUsuarioAcesso_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxCadastraUsuarioAcesso.Checked == true)
            {
                //PERMISSÃO DE USUARIO ACESSO
                checkBoxCRIARSistema.Checked = true;
                checkBoxALTERARSistema.Checked = true;
                checkBoxEXCLUIRSistema.Checked = true;
                checkBoxPESQUISASistema.Checked = true;
                checkBoxVISUALIZARSistema.Checked = true;
            }
            if (checkBoxCadastraUsuarioAcesso.Checked == false)
            {

                //PERMISSÃO DE USUARIO ACESSO
                checkBoxCRIARSistema.Checked = false;
                checkBoxALTERARSistema.Checked = false;
                checkBoxEXCLUIRSistema.Checked = false;
                checkBoxPESQUISASistema.Checked = false;
                checkBoxVISUALIZARSistema.Checked = false;
            }
        }
        //LISTA dos Usuários cadastrado no Banco de Dados
        void Fill_listBoxAcessoBaseDados()
        {
            SqlConnection connection = new SqlConnection(this.connetionString);

            try
            {
                connection.Open();
                string Query = "EXEC D_ConsultaAcessoBaseDados;";


                SqlCommand command = new SqlCommand(Query, connection);
                SqlDataReader dr = command.ExecuteReader();
                while (dr.Read())
                {
                    string name = dr.GetString(3);
                    comboBoxUsuarioBaseDados.Items.Add(name);
                }
                connection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void buttonCadastraPessoa_Click(object sender, EventArgs e)
        {
            txtDataNascimentoPessoa.Value = DateTime.Now.Date;


            UNomeUsuario = "Cadastrar";

            panelDadosPessoal.Enabled = true;
            PainelPrincipal.Enabled = true;
            buttonCadastraPessoa.Enabled = false;
            buttonVerifica.Enabled = true;
            buttonCancelarcadastrousuario.Enabled = true;
            buttonFecharFuncionario.Enabled = true;
            buttonCancelaDadosPessoas.Enabled = true;

            panelSelecionar.Enabled = true;

            buttonCadastraPessoa.Enabled = false;

            //panelDadosPessoal.Enabled = true;


            //buttonCadastraFuncionario.Enabled = true;

            //if (SelecionarTodosPermissao == true)
            //{
            //    SubPUPermissaoUsuario.Enabled = true;
            //    panelSelecionar.Enabled = true;
            //}


            //SqlConnection conn = new SqlConnection(this.connetionString);

            ////SELECIONA POR BASE DE DADOS CADASTRADOS
            //SqlDataAdapter da1 = new SqlDataAdapter("EXEC ConsultaAcessoBaseDados; ", conn);
            //DataSet ds1 = new DataSet();
            //da1.Fill(ds1);

            //conn.Open();

            //if (ds1.Tables[0].Rows.Count > 0)
            //{
            //    IdAcessoBaseDados = int.Parse(ds1.Tables[0].Rows[0][0].ToString());

            //    if (IdAcessoBaseDados != 0)
            //    {
            //        comboBoxUsuarioBaseDados.Items.Clear();

            //        Fill_listBoxAcessoBaseDados();

            //        comboBoxUsuarioBaseDados.Enabled = true;
            //    }
            //    if (IdAcessoBaseDados == 0)
            //    {
            //        comboBoxUsuarioBaseDados.Enabled = false;
            //    }
            //}
        }
        public void VerificaUsuarioComercio()
        {

        }
        //METODO PARA VERIFICA SE O FORMULÁRIO ESTA ABERTO SE TIVER ELE FECHA!
        public static void CancelaCadastradoUsuario(Type frmType)
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
        //CHAMA O METODO CancelaCadastradoCliente QUE FECHA FORMULÁRIOS ABERTOS
        public void FecharTodosFormulario()
        {
            CancelaCadastradoUsuario(typeof(FormCadastraUsuario));
        }

        private void checkNivelAcesso_CheckedChanged(object sender, EventArgs e)
        {
            if (checkNivelAcesso.Checked == true)
            {
                checkBoxBaseDados.Checked = true;
                checkBoxCliente.Checked = true;
                checkBoxFornecedor.Checked = true;
                checkBoxFuncinarioOS.Checked = true;
                checkBoxFuncionarioVenda.Checked = true;
                checkBoxUsuarioAcesso.Checked = true;
                checkBoxSeniorSapiens.Checked = true;
                checkBoxNivelAcesso.Checked = true;
                checkBoxCriarCadastroUsuario.Checked = true;
                CheckBoxCriarFuncionarioOs.Checked = true;
                checkBoxCriarFuncionarioVendedor.Checked = true;
                checkBoxCriarUsuarioAcesso.Checked = true;
                checkBoxCriarFuncionarioRegistro.Checked = true;
                checkBoxFuncionarioRegistro.Checked = true;
                checkBoxPermissãoProdutos.Checked = true;
                checkBoxCriarUsuarioProdutos.Checked = true;
                checkBoxCriarUsuarioProposta.Checked = true;
                checkBoxPermissãoProposta.Checked = true;
            }
            if (checkNivelAcesso.Checked == false)
            {
                checkBoxBaseDados.Checked = false;
                checkBoxCliente.Checked = false;
                checkBoxFornecedor.Checked = false;
                checkBoxFuncinarioOS.Checked = false;
                checkBoxFuncionarioVenda.Checked = false;
                checkBoxUsuarioAcesso.Checked = false;
                checkBoxSeniorSapiens.Checked = false;
                checkBoxNivelAcesso.Checked = false;
                checkBoxCriarCadastroUsuario.Checked = false;
                CheckBoxCriarFuncionarioOs.Checked = false;
                checkBoxCriarFuncionarioVendedor.Checked = false;
                checkBoxCriarUsuarioAcesso.Checked = false;
                checkBoxCriarFuncionarioRegistro.Checked = false;
                checkBoxFuncionarioRegistro.Checked = false;
                checkBoxPermissãoProdutos.Checked = false;
                checkBoxCriarUsuarioProdutos.Checked = false;
                checkBoxCriarUsuarioProposta.Checked = false;
                checkBoxPermissãoProposta.Checked = false;
            }
        }

        private void checkBoxTODAS_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxTODAS.Checked == true)
            {
                checkNivelAcesso.Checked = true;
                checkBoxSELECIONARCLIENTE.Checked = true;
                checkBoxSELECIONARFORNECEDOR.Checked = true;
                checkBoxFUNCIONARIOOS.Checked = true;
                checkBoxCadastraVendedor.Checked = true;
                checkBoxCadastraUsuarioAcesso.Checked = true;
                checkBoxSapiens.Checked = true;
            }
            if (checkBoxTODAS.Checked == false)
            {
                checkNivelAcesso.Checked = false;
                checkBoxSELECIONARCLIENTE.Checked = false;
                checkBoxSELECIONARFORNECEDOR.Checked = false;
                checkBoxFUNCIONARIOOS.Checked = false;
                checkBoxCadastraVendedor.Checked = false;
                checkBoxCadastraUsuarioAcesso.Checked = false;
                checkBoxSapiens.Checked = false;
            }
        }

        private void checkBoxSELECIONARCLIENTE_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSELECIONARCLIENTE.Checked == true)
            {
                //PERMISSÃO DO CLIENTE
                checkBoxCADASTRACLIENTE.Checked = true;
                checkBoxPESQUISACLIENTE.Checked = true;
                checkBoxVISUALIZARCLIENTE.Checked = true;
                checkBoxEDITARCLIENTE.Checked = true;
                checkBoxEXCLUIRCLIENTE.Checked = true;

                //PERMISSÃO DO CONTATOS CLIENTE
                checkBoxCADASTRACCLIENTE.Checked = true;
                checkBoxPESQUISACCLIENTE.Checked = true;
                checkBoxVISUALIZARCCLIENTE.Checked = true;
                checkBoxEDITARCCLIENTE.Checked = true;
                checkBoxEXCLUIRCCLIENTE.Checked = true;

            }
            if (checkBoxSELECIONARCLIENTE.Checked == false)
            {
                //PERMISSÃO DO CLIENTE
                checkBoxCADASTRACLIENTE.Checked = false;
                checkBoxPESQUISACLIENTE.Checked = false;
                checkBoxVISUALIZARCLIENTE.Checked = false;
                checkBoxEDITARCLIENTE.Checked = false;
                checkBoxEXCLUIRCLIENTE.Checked = false;

                //PERMISSÃO DO CONTATOS CLIENTE
                checkBoxCADASTRACCLIENTE.Checked = false;
                checkBoxPESQUISACCLIENTE.Checked = false;
                checkBoxVISUALIZARCCLIENTE.Checked = false;
                checkBoxEDITARCCLIENTE.Checked = false;
                checkBoxEXCLUIRCCLIENTE.Checked = false;
            }
        }

        private void checkBoxSELECIONARFORNECEDOR_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSELECIONARFORNECEDOR.Checked == true)
            {

                //PERMISSÃO DO FORNECEDOR
                checkBoxCADASTRAFORNECEDOR.Checked = true;
                checkBoxPESQUISAFORNECEDOR.Checked = true;
                checkBoxVISUALIZARFORNECEDOR.Checked = true;
                checkBoxEDITARFORNECEDOR.Checked = true;
                checkBoxEXCLUIRFORNECEDOR.Checked = true;

                //PERMISSÃO DO CONTATOS FORNECEDOR
                checkBoxCADASTRACFORNECEDOR.Checked = true;
                checkBoxPESQUISACFORNECEDOR.Checked = true;
                checkBoxVISUALIZARCFORNECEDOR.Checked = true;
                checkBoxEDITARCFORNECEDOR.Checked = true;
                checkBoxEXCLUIRCFORNECEDOR.Checked = true;
            }
            if (checkBoxSELECIONARFORNECEDOR.Checked == false)
            {
                //PERMISSÃO DO FORNECEDOR
                checkBoxCADASTRAFORNECEDOR.Checked = false;
                checkBoxPESQUISAFORNECEDOR.Checked = false;
                checkBoxVISUALIZARFORNECEDOR.Checked = false;
                checkBoxEDITARFORNECEDOR.Checked = false;
                checkBoxEXCLUIRFORNECEDOR.Checked = false;

                //PERMISSÃO DO CONTATOS FORNECEDOR
                checkBoxCADASTRACFORNECEDOR.Checked = false;
                checkBoxPESQUISACFORNECEDOR.Checked = false;
                checkBoxVISUALIZARCFORNECEDOR.Checked = false;
                checkBoxEDITARCFORNECEDOR.Checked = false;
                checkBoxEXCLUIRCFORNECEDOR.Checked = false;
            }
        }
        private void checkBoxFUNCIONARIOOS_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxFUNCIONARIOOS.Checked == true)
            {
                //PERMISSÃO DE FUNCIONARIO OS
                checkBoxCADASTRAFUNCIOANRIO.Checked = true;
                checkBoxPESQUISAFUNCIONARIO.Checked = true;
                checkBoxVISUALIZARFUNCIONARIO.Checked = true;
                checkBoxEDITARFUNCIONARIO.Checked = true;
                checkBoxEXCLUIRFUNCIONARIO.Checked = true;
            }
            if (checkBoxFUNCIONARIOOS.Checked == false)
            {

                //PERMISSÃO DE FUNCIONARIO OS
                checkBoxCADASTRAFUNCIOANRIO.Checked = false;
                checkBoxPESQUISAFUNCIONARIO.Checked = false;
                checkBoxVISUALIZARFUNCIONARIO.Checked = false;
                checkBoxEDITARFUNCIONARIO.Checked = false;
                checkBoxEXCLUIRFUNCIONARIO.Checked = false;
            }
        }

        private void checkBoxSapiens_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSapiens.Checked == true)
            {
                //PERMISSÃO DE SAPIENS
                checkBoxAcesso.Checked = true;
                checkBoxVisualizar.Checked = true;
                checkBoxExcluir.Checked = true;
            }
            if (checkBoxSapiens.Checked == false)
            {

                //PERMISSÃO DE SAPIENS
                checkBoxAcesso.Checked = false;
                checkBoxVisualizar.Checked = false;
                checkBoxExcluir.Checked = false;
            }
        }

        private void panelSelecionar_Paint(object sender, PaintEventArgs e)
        {

        }
        private void buttonVerifica_Click(object sender, EventArgs e)
        {
            salvarCadastroUsuario();
        }
        public void salvarCadastroUsuario()
        {
            try
            {
                contadorVerificar = 0;

                if(UNomeUsuario == "Cadastrar")
                {
                    contadorVerificar++;
                }
                if (FucionarioRegistro == "Cadastrar")
                {
                    contadorVerificar++;
                }
                if (FucionarioOS == "Cadastrar")
                {
                    contadorVerificar++;
                }
                if (FucionarioVendas == "Cadastrar")
                {
                    contadorVerificar++;
                }
                if (FuncionarioComercio == "Cadastrar")
                {
                    contadorVerificar++;
                }
                if (CPermissaoUsuarioAcesso == "Cadastrar")
                {
                    contadorVerificar++;
                }
            
                ConfirmacaoFuncionarioRegistro = false;
                ConfirmacaoFuncionarioOs = false;
                ConfirmacaoFuncionarioVendas = false;
                ConfirmacaoUsuarioAcesso = false;
                ConfirmacaoFuncionarioUsuarioVendas = false;
                ConfirmacaoBaseDados = false;
                ConfirmacaoCep = false;

                CadastraUsuario CadastraUsuarioGeral = new CadastraUsuario(); //Dados Pessoas - Cadastra
                
                CadastraUsuarioGeral.Nome = txtNomePessoa.Text;
                CadastraUsuarioGeral.SobreNome = txtSobrenomePessoa.Text;
                CadastraUsuarioGeral.Abreviacao = txtAbreviacao.Text;
                CadastraUsuarioGeral.Telefone = txtTelefonePessoa.Text;
                CadastraUsuarioGeral.Telefone2 = txtTelefone2Pessoa.Text;
                CadastraUsuarioGeral.Celular = txtCelularCelular.Text;
                CadastraUsuarioGeral.Celular2 = txtCelular2Pessoa.Text;
                CadastraUsuarioGeral.Email = txtEmailEmail.Text;
                CadastraUsuarioGeral.Sexo = comboBoxSexoPessoa.Text;
                CadastraUsuarioGeral.Cpf = txtCpfPessoa.Text;
                CadastraUsuarioGeral.Rg = txtRgPessoa.Text;
                CadastraUsuarioGeral.Data_Nascimento = txtDataNascimentoPessoa.Text;
                CadastraUsuarioGeral.Observacao = txtObservacaoPessoa.Text;
                CadastraUsuarioGeral.IdSituacao = 1;

                CepCadastraUsuario CepCadastraUsuarioGeral = new CepCadastraUsuario(); //Cep Dados Pessoas - Cadastra

                if (txtCepPessoa.Text == "")
                {

                }
                if (!(txtCepPessoa.Text == ""))
                {
                    CepCadastraUsuarioGeral.Cepc = int.Parse(txtCepPessoa.Text);
                    CepCadastraUsuarioGeral.TipoLogradouro = txtLogradouroPessoa.Text;
                    CepCadastraUsuarioGeral.Endereco = txtEnderecoPessoa.Text;
                    CepCadastraUsuarioGeral.Numero = txtNumeroPessoa.Text;
                    CepCadastraUsuarioGeral.Complemento = txtComplPessoa.Text;
                    CepCadastraUsuarioGeral.Bairro = txtBairroPessoa.Text;
                    CepCadastraUsuarioGeral.Cidade = txtCidadePessoa.Text;
                    CepCadastraUsuarioGeral.SiglaCidade = txtSiglaCidadePessoa.Text;
                }

                FuncionarioOS CadastraFuncionarioOs = new FuncionarioOS();//Funcionario Dados Pessoas - Cadastra FuncionarioOS

                if (txtReFuncionarioO.Text == "")
                {

                }
                if (!(txtReFuncionarioO.Text == ""))
                {
                    CadastraFuncionarioOs.IdRe = int.Parse(txtReFuncionarioO.Text);
                    CadastraFuncionarioOs.Abreviacao = txtFuncionarioAbreviacaoO.Text;
                    CadastraFuncionarioOs.Email = txtFuncionarioEmaillO.Text;
                    CadastraFuncionarioOs.Telefone = maskedTelefoneFuncionarioO.Text;
                    CadastraFuncionarioOs.Telefone2 = maskedTelefone2FuncionarioO.Text;
                    CadastraFuncionarioOs.Celular = maskedCelularFuncionarioO.Text;
                    CadastraFuncionarioOs.Celular2 = maskedCelular2FuncionarioO.Text;
                }
                FuncionarioRegistro CadastraFuncionarioRegistro = new FuncionarioRegistro();//Funcionario Dados Pessoas - Cadastra FuncionarioOS

                if (txtReFuncionarioRegistro.Text == "")
                {

                }
                if (!(txtReFuncionarioRegistro.Text == ""))
                {
                    CadastraFuncionarioRegistro.IdRe = int.Parse(txtReFuncionarioRegistro.Text);
                    CadastraFuncionarioRegistro.Abreviacao = txtFuncionarioAbreviacaoRegistro.Text;
                    CadastraFuncionarioRegistro.Email = txtFuncionarioEmaillRegistro.Text;
                    CadastraFuncionarioRegistro.Telefone = maskedTelefoneFuncionarioRegistro.Text;
                    CadastraFuncionarioRegistro.Telefone2 = maskedTelefone2FuncionarioRegistro.Text;
                    CadastraFuncionarioRegistro.Celular = maskedCelularFuncionarioRegistro.Text;
                    CadastraFuncionarioRegistro.Celular2 = maskedCelular2FuncionarioRegistro.Text;
                }

                Vendedor CadastraVendedor = new Vendedor();//Funcionario Dados Pessoas - Cadastra Vendedor

                if (txtSalarioFuncionarioV.Text == "")
                {
                    CadastraVendedor.Salario = 0;
                }
                if (!(txtSalarioFuncionarioV.Text == ""))
                {
                    string salario = ConverterValores(txtSalarioFuncionarioV.Text);
                    CadastraVendedor.Salario = int.Parse(salario);
                }
                CadastraVendedor.Abreviacao = txtAbreviacaoFuncionarioV.Text;
                CadastraVendedor.Email = txtEmailFuncionarioV.Text;
                CadastraVendedor.Telefone = maskedTelefoneFuncionarioV.Text;
                CadastraVendedor.Telefone2 = maskedTelefone2FuncionarioV.Text;
                CadastraVendedor.Celular = maskedtxtCelularFuncionarioV.Text;
                CadastraVendedor.Celular2 = maskedCelular2FuncionarioV.Text;
                CadastraVendedor.Cargo = txtCargoFuncionarioV.Text;
                CadastraVendedor.DataAdmissao = dateTimePickerDataAdmissaoV.Text;

                if (txtDiaPagamentoFuncionarioV.Text == "")
                {
                    CadastraVendedor.DiaPAgamento = 0;
                }
                if (!(txtDiaPagamentoFuncionarioV.Text == ""))
                {
                    CadastraVendedor.DiaPAgamento = int.Parse(txtDiaPagamentoFuncionarioV.Text);
                }

                if (txtComissaoVendedor.Text == "")
                {
                    CadastraVendedor.Comissao = 0;
                }
                if (!(txtComissaoVendedor.Text == ""))
                {
                    string comissao = ConverterValores(txtComissaoVendedor.Text);
                    CadastraVendedor.Comissao = int.Parse(comissao);
                }

                if (txtTipoVendedor.Text == "")
                {
                    CadastraVendedor.Tipo = 0;
                }
                if (!(txtTipoVendedor.Text == ""))
                {
                    string Tipo = txtTipoVendedor.Text;
                    CadastraVendedor.Tipo = int.Parse(Tipo);

                }
                UsuarioV CadastraFuncionarioUsuarioVendas = new UsuarioV();//Funcionario Dados Pessoas - Cadastra FuncionarioOS

                if (txtFuncionarioAbreviacaoComercio.Text == "")
                {

                }
                if (!(txtFuncionarioAbreviacaoComercio.Text == ""))
                {
                    CadastraFuncionarioUsuarioVendas.Abreviacao = txtFuncionarioAbreviacaoComercio.Text;
                    CadastraFuncionarioUsuarioVendas.Email = txtFuncionarioEmailComercio.Text;
                    CadastraFuncionarioUsuarioVendas.Telefone = maskedTelefoneFuncionarioTelefoneUsuarioV.Text;
                    CadastraFuncionarioUsuarioVendas.Telefone2 = maskedTelefoneFuncionarioTelefone2UsuarioV.Text;
                    CadastraFuncionarioUsuarioVendas.Celular = maskedTelefoneFuncionarioCelularUsuarioV.Text;
                    CadastraFuncionarioUsuarioVendas.Celular2 = maskedTelefoneFuncionarioCelular2UsuarioV.Text;
                }
                CadastraVendedor.Descricao = txtDescricaoVendedor.Text;

                CadastroLoginNovo cadastrologin1 = new CadastroLoginNovo(); //Base de Dados Dados Pessoas - Cadastra

                cadastrologin1.Nome = txtNomePessoa.Text;
                cadastrologin1.Usuario = txtUsuarioLoginFuncionario.Text;
                cadastrologin1.Senha = txtSenhaFuncionario.Text;
                cadastrologin1.ConfirmaSenha = txtConfirmacaoSenhaFuncionario.Text;
                cadastrologin1.Observacao = txtObservacaoFuncionario.Text;
                cadastrologin1.Situacao = 1;
                cadastrologin1.IdAcessoBaseDados = this.IdAcessoBaseDados;

                if (checkBoxADM.Checked == false)
                {
                    cadastrologin1.UsuarioAcesso = 0;
                }
                if (checkBoxADM.Checked == true)
                {
                    cadastrologin1.UsuarioAcesso = 1;
                }

                //PERMISSÃO DE NIVEL DE ACESSO - CRIAR-----------------------------------------------------------------------

                if (checkBoxCriarCadastroUsuario.Checked == true) { cadastrologin1.CriarDadosPessoas = 1; }
                if (checkBoxCriarCadastroUsuario.Checked == false) { cadastrologin1.CriarDadosPessoas = 0; }


                if (checkBoxFuncinarioOS.Checked == true) { cadastrologin1.PermissaoFuncionarioOs = 1; }
                if (checkBoxFuncinarioOS.Checked == false) { cadastrologin1.PermissaoFuncionarioOs = 0; }

                if (checkBoxCriarFuncionarioVendedor.Checked == true) { cadastrologin1.CriarFuncionarioVendas = 1; }
                if (checkBoxCriarFuncionarioVendedor.Checked == false) { cadastrologin1.CriarFuncionarioVendas = 0; }

                if (checkBoxFuncionarioVenda.Checked == true) { cadastrologin1.PermissaoFuncionarioVendedor = 1; }
                if (checkBoxFuncionarioVenda.Checked == false) { cadastrologin1.PermissaoFuncionarioVendedor = 0; }

                if (checkBoxCriarUsuarioProdutos.Checked == true) { cadastrologin1.CriarFuncionarioProdutos = 1; }
                if (checkBoxCriarUsuarioProdutos.Checked == false) { cadastrologin1.CriarFuncionarioProdutos = 0; }

                if (checkBoxPermissãoProdutos.Checked == true) { cadastrologin1.PermissaoFuncionarioProdutos = 1; }
                if (checkBoxPermissãoProdutos.Checked == false) { cadastrologin1.PermissaoFuncionarioProdutos = 0; }

                if (checkBoxCriarFuncionarioRegistro.Checked == true) { cadastrologin1.CriarFuncionarioRegistro = 1; }
                if (checkBoxCriarFuncionarioRegistro.Checked == false) { cadastrologin1.CriarFuncionarioRegistro = 0; }

                if (checkBoxFuncionarioRegistro.Checked == true) { cadastrologin1.PermissaoRegistro = 1; }
                if (checkBoxFuncionarioRegistro.Checked == false) { cadastrologin1.PermissaoRegistro = 0; }

                if (checkBoxCriarUsuarioAcesso.Checked == true) { cadastrologin1.CriarUsuarioAcesso = 1; }
                if (checkBoxCriarUsuarioAcesso.Checked == false) { cadastrologin1.CriarUsuarioAcesso = 0; }

                


                //PERMISÃO DO NIVEL-------------------------------------------------------------------

                if (checkBoxBaseDados.Checked == true) { cadastrologin1.PermissaoBasedados = 1; }
                if (checkBoxBaseDados.Checked == false) { cadastrologin1.PermissaoBasedados = 0; }

                if (checkBoxNivelAcesso.Checked == true) { cadastrologin1.PermissaoNivelaAcesso = 1; }
                if (checkBoxNivelAcesso.Checked == false) { cadastrologin1.PermissaoNivelaAcesso = 0; }

                if (checkBoxCliente.Checked == true) { cadastrologin1.PermissaoCliente = 1; }
                if (checkBoxCliente.Checked == false) { cadastrologin1.PermissaoCliente = 0; }

                if (checkBoxFornecedor.Checked == true) { cadastrologin1.PermissaoFornecedor = 1; }
                if (checkBoxFornecedor.Checked == false) { cadastrologin1.PermissaoFornecedor = 0; }

                if (CheckBoxCriarFuncionarioOs.Checked == true) { cadastrologin1.CriarFuncionarioOs = 1; }
                if (CheckBoxCriarFuncionarioOs.Checked == false) { cadastrologin1.CriarFuncionarioOs = 0; }

                if (checkBoxUsuarioAcesso.Checked == true) { cadastrologin1.PermissaoUsuarioAcesso = 1; }
                if (checkBoxUsuarioAcesso.Checked == false) { cadastrologin1.PermissaoUsuarioAcesso = 0; }

                if (checkBoxSeniorSapiens.Checked == true) { cadastrologin1.PermissaoSeniorSapiens = 1; }
                if (checkBoxSeniorSapiens.Checked == false) { cadastrologin1.PermissaoSeniorSapiens = 0; }


                //PERMISSÃO DO CLIENTE----------------------------------------------------------------ed == true) { cadastrologin1.FuncionarioCadastra = 1; }//@@

                if (checkBoxCADASTRACLIENTE.Checked == true) { cadastrologin1.ClienteCadastra = 1; }
                if (checkBoxCADASTRACLIENTE.Checked == false) { cadastrologin1.ClienteCadastra = 0; }

                if (checkBoxPESQUISACLIENTE.Checked == true) { cadastrologin1.ClientePesquisa = 1; }
                if (checkBoxPESQUISACLIENTE.Checked == false) { cadastrologin1.ClientePesquisa = 0; }

                if (checkBoxVISUALIZARCLIENTE.Checked == true) { cadastrologin1.ClienteVisualizar = 1; }
                if (checkBoxVISUALIZARCLIENTE.Checked == false) { cadastrologin1.ClienteVisualizar = 0; }

                if (checkBoxEDITARCLIENTE.Checked == true) { cadastrologin1.ClienteEditar = 1; }
                if (checkBoxEDITARCLIENTE.Checked == false) { cadastrologin1.ClienteEditar = 0; }

                if (checkBoxEXCLUIRCLIENTE.Checked == true) { cadastrologin1.ClienteExcluir = 1; }
                if (checkBoxEXCLUIRCLIENTE.Checked == false) { cadastrologin1.ClienteExcluir = 0; }


                //PERMISSÃO DO CONTATOS CLIENTE
                if (checkBoxCADASTRACCLIENTE.Checked == true) { cadastrologin1.ClienteCCadastra = 1; }
                if (checkBoxCADASTRACCLIENTE.Checked == false) { cadastrologin1.ClienteCCadastra = 0; }

                if (checkBoxPESQUISACCLIENTE.Checked == true) { cadastrologin1.ClienteCPesquisa = 1; }
                if (checkBoxPESQUISACCLIENTE.Checked == false) { cadastrologin1.ClienteCPesquisa = 0; }

                if (checkBoxVISUALIZARCCLIENTE.Checked == true) { cadastrologin1.ClienteCVisualizar = 1; }
                if (checkBoxVISUALIZARCCLIENTE.Checked == false) { cadastrologin1.ClienteCVisualizar = 0; }

                if (checkBoxEDITARCCLIENTE.Checked == true) { cadastrologin1.ClienteCEditar = 1; }
                if (checkBoxEDITARCCLIENTE.Checked == false) { cadastrologin1.ClienteCEditar = 0; }

                if (checkBoxEXCLUIRCCLIENTE.Checked == true) { cadastrologin1.ClienteCExcluir = 1; }
                if (checkBoxEXCLUIRCCLIENTE.Checked == false) { cadastrologin1.ClienteCExcluir = 0; }

                //PERMISSÃO DO FORNECEDOR--------------------------------------------------------------------------------

                if (checkBoxCADASTRAFORNECEDOR.Checked == true) { cadastrologin1.FornecedorCadastra = 1; }
                if (checkBoxCADASTRAFORNECEDOR.Checked == false) { cadastrologin1.FornecedorCadastra = 0; }

                if (checkBoxPESQUISAFORNECEDOR.Checked == true) { cadastrologin1.FornecedorPesquisa = 1; }
                if (checkBoxPESQUISAFORNECEDOR.Checked == false) { cadastrologin1.FornecedorPesquisa = 0; }

                if (checkBoxVISUALIZARFORNECEDOR.Checked == true) { cadastrologin1.FornecedorVisualizar = 1; }
                if (checkBoxVISUALIZARFORNECEDOR.Checked == false) { cadastrologin1.FornecedorVisualizar = 0; }

                if (checkBoxEDITARFORNECEDOR.Checked == true) { cadastrologin1.FornecedorEditar = 1; }
                if (checkBoxEDITARFORNECEDOR.Checked == false) { cadastrologin1.FornecedorEditar = 0; }

                if (checkBoxEXCLUIRFORNECEDOR.Checked == true) { cadastrologin1.FornecedorExcluir = 1; }
                if (checkBoxEXCLUIRFORNECEDOR.Checked == false) { cadastrologin1.FornecedorExcluir = 0; }

                //PERMISSÃO DO CONTATOS FORNECEDOR
                if (checkBoxCADASTRACFORNECEDOR.Checked == true) { cadastrologin1.FornecedorCCadastra = 1; }
                if (checkBoxCADASTRACFORNECEDOR.Checked == false) { cadastrologin1.FornecedorCCadastra = 0; }

                if (checkBoxPESQUISACFORNECEDOR.Checked == true) { cadastrologin1.FornecedorCPesquisa = 1; }
                if (checkBoxPESQUISACFORNECEDOR.Checked == false) { cadastrologin1.FornecedorCPesquisa = 0; }

                if (checkBoxVISUALIZARCFORNECEDOR.Checked == true) { cadastrologin1.FornecedorCVisualizar = 1; }
                if (checkBoxVISUALIZARCFORNECEDOR.Checked == false) { cadastrologin1.FornecedorCVisualizar = 0; }

                if (checkBoxEDITARCFORNECEDOR.Checked == true) { cadastrologin1.FornecedorCEditar = 1; }
                if (checkBoxEDITARCFORNECEDOR.Checked == false) { cadastrologin1.FornecedorCEditar = 0; }

                if (checkBoxEXCLUIRCFORNECEDOR.Checked == true) { cadastrologin1.FornecedorcExcluir = 1; }
                if (checkBoxEXCLUIRCFORNECEDOR.Checked == false) { cadastrologin1.FornecedorcExcluir = 0; }

                //PERMISSÃO DE OS FUNCIONARIO--------------------------------------------------------------------------

                if (checkBoxCADASTRAFUNCIOANRIO.Checked == true) { cadastrologin1.OsCadastra = 1; }
                if (checkBoxCADASTRAFUNCIOANRIO.Checked == false) { cadastrologin1.OsCadastra = 0; }

                if (checkBoxPESQUISAFUNCIONARIO.Checked == true) { cadastrologin1.OsPesquisa = 1; }
                if (checkBoxPESQUISAFUNCIONARIO.Checked == false) { cadastrologin1.OsPesquisa = 0; }

                if (checkBoxVISUALIZARFUNCIONARIO.Checked == true) { cadastrologin1.OsVisualizar = 1; }
                if (checkBoxVISUALIZARFUNCIONARIO.Checked == false) { cadastrologin1.OsVisualizar = 0; }

                if (checkBoxEDITARFUNCIONARIO.Checked == true) { cadastrologin1.OsEditar = 1; }
                if (checkBoxEDITARFUNCIONARIO.Checked == false) { cadastrologin1.OsEditar = 0; }

                if (checkBoxEXCLUIRFUNCIONARIO.Checked == true) { cadastrologin1.OsExcluir = 1; }
                if (checkBoxEXCLUIRFUNCIONARIO.Checked == false) { cadastrologin1.OsExcluir = 0; }

                //PERMISSÃO DE VENDEDOR---------------------------------------------------------------------

                if (checkBoxCriarVendedor.Checked == true) { cadastrologin1.VendedorCadastra = 1; }
                if (checkBoxCriarVendedor.Checked == false) { cadastrologin1.VendedorCadastra = 0; }

                if (checkBoxPesquisaVendedor.Checked == true) { cadastrologin1.VendedorPesquisa = 1; }
                if (checkBoxPesquisaVendedor.Checked == false) { cadastrologin1.VendedorPesquisa = 0; }

                if (checkBoxVisualizarVendedor.Checked == true) { cadastrologin1.VendedorVisualizar = 1; }
                if (checkBoxVisualizarVendedor.Checked == false) { cadastrologin1.VendedorVisualizar = 0; }


                if (checkBoxAlterarVendedor.Checked == true) { cadastrologin1.VendedorEditar = 1; }
                if (checkBoxAlterarVendedor.Checked == false) { cadastrologin1.VendedorEditar = 0; }

                if (checkBoxExcluirVendedor.Checked == true) { cadastrologin1.VendedorExcluir = 1; }
                if (checkBoxExcluirVendedor.Checked == false) { cadastrologin1.VendedorExcluir = 0; }

                //PERMISSÃO DE CLIENTES REGISTRO---------------------------------------------------------------------

                if (checkBoxCADASTRACREGISTRO.Checked == true) { cadastrologin1.RegistroCCadastra = 1; }
                if (checkBoxCADASTRACREGISTRO.Checked == false) { cadastrologin1.RegistroCCadastra = 0; }

                if (checkBoxVISUALIZARCREGISTRO.Checked == true) { cadastrologin1.RegistroCVisualizar = 1; }
                if (checkBoxVISUALIZARCREGISTRO.Checked == false) { cadastrologin1.RegistroCVisualizar = 0; }

                if (checkBoxPESQUISARECGISTRO.Checked == true) { cadastrologin1.RegistroCPesquisa = 1; }
                if (checkBoxPESQUISARECGISTRO.Checked == false) { cadastrologin1.RegistroCPesquisa = 0; }

                if (checkBoxEDITARCREGISTRO.Checked == true) { cadastrologin1.RegistroCEditar = 1; }
                if (checkBoxEDITARCREGISTRO.Checked == false) { cadastrologin1.RegistroCEditar = 0; }

                if (checkBoxEXCLUIRCREGISTRO.Checked == true) { cadastrologin1.RegistroCExcluir = 1; }
                if (checkBoxEXCLUIRCREGISTRO.Checked == false) { cadastrologin1.RegistroCExcluir = 0; }

                //PERMISSÃO DE CONTATOS CLIENTES REGISTRO-----------------------------------------------------------------------

                if (checkBoxCADASTRACCREGISTRO.Checked == true) { cadastrologin1.RegistroCCCadastra = 1; }
                if (checkBoxCADASTRACCREGISTRO.Checked == false) { cadastrologin1.RegistroCCCadastra = 0; }

                if (checkBoxVISUALIZARCCREGISTRO.Checked == true) { cadastrologin1.RegistroCCVisualizar = 1; }
                if (checkBoxVISUALIZARCCREGISTRO.Checked == false) { cadastrologin1.RegistroCCVisualizar = 0; }

                if (checkBoxPESQUISACCREGISTRO.Checked == true) { cadastrologin1.RegistroCCPesquisa = 1; }
                if (checkBoxPESQUISACCREGISTRO.Checked == false) { cadastrologin1.RegistroCCPesquisa = 0; }

                if (checkBoxEDITARCCREGISTRO.Checked == true) { cadastrologin1.RegistroCCEditar = 1; }
                if (checkBoxEDITARCCREGISTRO.Checked == false) { cadastrologin1.RegistroCCEditar = 0; }

                if (checkBoxEXCLUIRCCREGISTRO.Checked == true) { cadastrologin1.RegistroCCExcluir = 1; }
                if (checkBoxEXCLUIRCCREGISTRO.Checked == false) { cadastrologin1.RegistroCCExcluir = 0; }

                //PERMISSÃO DE GERAÇÃO DE NOVOS REGISTRO---------------------------------------------------------------------

                if (checkBoxCADASTRAREGISTRO.Checked == true) { cadastrologin1.RegistroCadastra = 1; }
                if (checkBoxCADASTRAREGISTRO.Checked == false) { cadastrologin1.RegistroCadastra = 0; }

                if (checkBoxVISUALIZARREGISTRO.Checked == true) { cadastrologin1.RegistroVisualizar = 1; }
                if (checkBoxVISUALIZARREGISTRO.Checked == false) { cadastrologin1.RegistroVisualizar = 0; }

                if (checkBoxPESQUISAREGISTRO.Checked == true) { cadastrologin1.RegistroPesquisa = 1; }
                if (checkBoxPESQUISAREGISTRO.Checked == false) { cadastrologin1.RegistroPesquisa = 0; }

                if (checkBoxEDITAREGISTRO.Checked == true) { cadastrologin1.RegistroEditar = 1; }
                if (checkBoxEDITAREGISTRO.Checked == false) { cadastrologin1.RegistroEditar = 0; }

                if (checkBoxEXCLUIRREGISTRO.Checked == true) { cadastrologin1.RegistroExcluir = 1; }
                if (checkBoxEXCLUIRREGISTRO.Checked == false) { cadastrologin1.RegistroExcluir = 0; }

                //PERMISSÃO DE PRODUTOS---------------------------------------------------------------------

                if (checkBoxCriarProdutos.Checked == true) { cadastrologin1.ProdutosCadastra = 1; }
                if (checkBoxCriarProdutos.Checked == false) { cadastrologin1.ProdutosCadastra = 0; }

                if (checkBoxVisualizarProdutos.Checked == true) { cadastrologin1.ProdutosVisualizar = 1; }
                if (checkBoxVisualizarProdutos.Checked == false) { cadastrologin1.ProdutosVisualizar = 0; }

                if (checkBoxPesquisaProdutos.Checked == true) { cadastrologin1.ProdutosPesquisa = 1; }
                if (checkBoxPesquisaProdutos.Checked == false) { cadastrologin1.ProdutosPesquisa = 0; }

                if (checkBoxAlterarProdutos.Checked == true) { cadastrologin1.ProdutosEditar = 1; }
                if (checkBoxAlterarProdutos.Checked == false) { cadastrologin1.ProdutosEditar = 0; }

                if (checkBoxExcluirProduttos.Checked == true) { cadastrologin1.ProdutosExcluir = 1; }
                if (checkBoxExcluirProduttos.Checked == false) { cadastrologin1.ProdutosExcluir = 0; }

                //PERMISSÃO DE PROPOSTA--------------------------------------------------------------------

                if (checkBoxCriarProposta.Checked == true) { cadastrologin1.PropostaCadastra = 1; }
                if (checkBoxCriarProposta.Checked == false) { cadastrologin1.PropostaCadastra = 0; }

                if (checkBoxVisualizarProposta.Checked == true) { cadastrologin1.PropostaVisualizar = 1; }
                if (checkBoxVisualizarProposta.Checked == false) { cadastrologin1.PropostaVisualizar = 0; }

                if (checkBoxPesquisaProposta.Checked == true) { cadastrologin1.PropostaPesquisa = 1; }
                if (checkBoxPesquisaProposta.Checked == false) { cadastrologin1.PropostaPesquisa = 0; }

                if (checkBoxAlterarProposta.Checked == true) { cadastrologin1.PropostaEditar = 1; }
                if (checkBoxAlterarProposta.Checked == false) { cadastrologin1.PropostaEditar = 0; }

                if (checkBoxExcluirProposta.Checked == true) { cadastrologin1.PropostaExcluir = 1; }
                if (checkBoxExcluirProposta.Checked == false) { cadastrologin1.PropostaExcluir = 0; }

                if (checkBoxCriarUsuarioProposta.Checked == true) { cadastrologin1.CriarProposta = 1; }
                if (checkBoxCriarUsuarioProposta.Checked == false) { cadastrologin1.CriarProposta = 0; }

                if (checkBoxPermissãoProposta.Checked == true) { cadastrologin1.PermissaoProposta = 1; }
                if (checkBoxPermissãoProposta.Checked == false) { cadastrologin1.PermissaoProposta = 0; }


                //PERMISSÃO DO SISTEMA USUARIO-----------------------------------------------------------

                if (checkBoxCRIARSistema.Checked == true) { cadastrologin1.UsuarioCriar = 1; }
                if (checkBoxCRIARSistema.Checked == false) { cadastrologin1.UsuarioCriar = 0; }

                if (checkBoxALTERARSistema.Checked == true) { cadastrologin1.UsuarioAlterar = 1; }
                if (checkBoxALTERARSistema.Checked == false) { cadastrologin1.UsuarioAlterar = 0; }

                if (checkBoxEXCLUIRSistema.Checked == true) { cadastrologin1.UsuarioExcluir = 1; }
                if (checkBoxEXCLUIRSistema.Checked == false) { cadastrologin1.UsuarioExcluir = 0; }

                if (checkBoxPESQUISASistema.Checked == true) { cadastrologin1.UsuarioPesquisa = 1; }
                if (checkBoxPESQUISASistema.Checked == false) { cadastrologin1.UsuarioPesquisa = 0; }

                if (checkBoxVISUALIZARSistema.Checked == true) { cadastrologin1.UsuarioVisualizar = 1; }
                if (checkBoxVISUALIZARSistema.Checked == false) { cadastrologin1.UsuarioVisualizar = 0; }

                //PERMISSÃO DE SENIOR--------------------------------------------------------------------------

                if (checkBoxAcesso.Checked == true) { cadastrologin1.SeniorSapiensAcesso = 1; }
                if (checkBoxAcesso.Checked == false) { cadastrologin1.SeniorSapiensAcesso = 0; }

                if (checkBoxVisualizar.Checked == true) { cadastrologin1.SeniorSapiensPesquisa = 1; }
                if (checkBoxVisualizar.Checked == false) { cadastrologin1.SeniorSapiensPesquisa = 0; }

                if (checkBoxExcluir.Checked == true) { cadastrologin1.SeniorSapiensExcluir = 1; }
                if (checkBoxExcluir.Checked == false) { cadastrologin1.SeniorSapiensExcluir = 0; }

                //ATUALIZACAO DE TELA PRINCIPAL
                cadastrologin1.AtualicazaoTelaPrincipal = 1;

                //VERIFICADOR DE OS
                //cadastrologin1.VerificadorOs = 1;

                if ((DadosPessoaNome(txtNomePessoa, errorProviderCadastraUsuario) == true) && (DadosPessoaSobreNome(txtSobrenomePessoa, errorProviderCadastraUsuario) == true) &&
                    (DadosPessoaSobreAbreviacao(txtAbreviacao, errorProviderCadastraUsuario) == true))
                {
                    if (txtCepPessoa.Text == "")
                    {
                        if (UNomeUsuario == "Cadastrar")
                        {
                            if(VerificadorNomeUsuario() == true)
                            {
                                ConfirmacaoNomeUsuario = true;
                            }
                            else
                            {
                                MessageBox.Show("Abreviação de usuário já existe!");
                            }                               
                        }
                        if (FucionarioRegistro == "Cadastrar")
                        {
                            if ((DadosPessoaFuncionarioRegistro(txtReFuncionarioRegistro, errorProviderCadastraUsuario) == true) &&
                                (DadosPessoaFuncionarioSobreNomeRegistro(txtFuncionarioAbreviacaoRegistro, errorProviderCadastraUsuario) == true))
                            {
                                if (VerificadorFucionarioRegistroRe() == true)
                                {
                                    this.ConfirmacaoFuncionarioRegistro = true;
                                }
                                else {MessageBox.Show("Número de RE Registro já existe!");}
                            }
                            else { contadorVerificar++; }
                        }
                        if (FucionarioOS == "Cadastrar")
                        {
                            if ((DadosPessoaFuncionarioOsRE(txtReFuncionarioO, errorProviderCadastraUsuario) == true) &&
                                (DadosPessoaFuncionarioOsAbreviacao(txtFuncionarioAbreviacaoO, errorProviderCadastraUsuario) == true))
                            {
                                if (VerificadorReOs() == true)
                                {
                                    this.ConfirmacaoFuncionarioOs = true;
                                }
                                else
                                {  MessageBox.Show("Número de RE OS já existe!"); }
                            }
                            else { contadorVerificar++; }
                        }

                        if (FucionarioVendas == "Cadastrar")
                        {
                            if (DadosPessoaFuncionarioOsAbreviacao(txtAbreviacaoFuncionarioV, errorProviderCadastraUsuario) == true)
                            {
                                if (VerificadorFucionarioVendas() == true)
                                {
                                    this.ConfirmacaoFuncionarioVendas = true;
                                }
                                else
                                { MessageBox.Show("Abreviação de usuário já existe!"); }
                            }
                            else { contadorVerificar++; }
                        }
                        //COMERCIAL NÃO CRIADO NESTE MOMENTO!
                        //if (FuncionarioComercio == "Cadastrar")
                        //{ }

                        if (CPermissaoUsuarioAcesso == "Cadastrar")
                        {
                            if (DadosPessoaUsuarioAcessoSistema(txtUsuarioLoginFuncionario, errorProviderCadastraUsuario) == true)
                            {

                                if (VerificadorFucionarioUsuarioAcesso() == true)
                                {
                                    string senhaAcesso = txtSenhaFuncionario.Text;
                                    string senhaConfirmacao = txtConfirmacaoSenhaFuncionario.Text;
                                    string UsoAcesso = comboBoxUsuarioBaseDados.Text.ToString();
                                    UsoAcesso.ToString();

                                    if ((senhaAcesso=="") || (senhaConfirmacao == ""))
                                    {
                                        contadorVerificar++;
                                        contadorVerificar.ToString();
                                        MessageBox.Show("A senha de acesso não pode estarem em branco!");
                                    }
                                    if (!(senhaAcesso == "") && !(senhaConfirmacao == ""))
                                    {
                                        if (UsoAcesso != "")
                                        {
                                            if (senhaAcesso.Equals(senhaConfirmacao))
                                            {
                                                this.ConfirmacaoUsuarioAcesso = true;
                                            }
                                            else { contadorVerificar++; MessageBox.Show("As senhas não conferem."); }
                                        }
                                        if (UsoAcesso == "")
                                        {
                                            contadorVerificar++;
                                            contadorVerificar.ToString();
                                            MessageBox.Show("Escolhe a conexão com sistema.");
                                        }
                                    }
                                }
                                else
                                { MessageBox.Show("Usuário já existe!"); }
                            }
                            else { contadorVerificar++; }
                        }
                        if (CBaseDados == "Cadastrar")
                        {
                            
                        }

                        //confirma todas as entradas
                        if (contadorVerificar == 0)
                        {
                            if (UNomeUsuario == "Cadastrar")
                            {
                                //Cadastro Dados Geral usuário
                                Conexao conexao = new Conexao(this.connetionString);
                                DALDateSystem da = new DALDateSystem(conexao);

                                da.IncluirUsuarioGeral(CadastraUsuarioGeral);

                                int IdUsuarioGeral = 0;
                                IdUsuarioGeral = int.Parse(CadastraUsuarioGeral.IdUsuario.ToString());

                                if (ConfirmacaoCep == true)
                                {
                                    //Cadastro usuário Cep
                                    Conexao conexao2 = new Conexao(this.connetionString);
                                    DALDateSystem da2 = new DALDateSystem(conexao2);
                                    CepCadastraUsuarioGeral.idCep = IdUsuarioGeral;
                                    da2.UsuarioGeralCepInserir(CepCadastraUsuarioGeral);
                                }
                                if (ConfirmacaoFuncionarioOs == true)
                                {
                                    try
                                    {
                                        //VERIFICADOR DE OS
                                        if (FucionarioOS == "Cadastrar") { cadastrologin1.VerificadorOs = 1; }
                                        else { cadastrologin1.VerificadorOs = 0; }

                                        //Cadastro usuário Funcionário de OS
                                        Conexao conexao3 = new Conexao(this.connetionString);
                                        DALDateSystem da3 = new DALDateSystem(conexao3);

                                        CadastraFuncionarioOs.IdFuncionario = IdUsuarioGeral;
                                        da3.IncluirFuncionarioOs(CadastraFuncionarioOs);
                                    }
                                    catch (Exception EX)
                                    {
                                        EX.ToString();
                                    }
                                }
                                if (ConfirmacaoFuncionarioVendas == true)
                                {
                                    //Cadastro usuário Funcionário de Vendedor
                                    Conexao conexao4 = new Conexao(this.connetionString);
                                    DALDateSystem da4 = new DALDateSystem(conexao4);
                                    CadastraVendedor.IdVendedor = IdUsuarioGeral;
                                    da4.IncluirFuncionarioVendedor(CadastraVendedor);
                                }
                                if (ConfirmacaoUsuarioAcesso == true)
                                {
                                    //Cadastro usuário Acesso ao Sistema
                                    Conexao conexao5 = new Conexao(this.connetionString);
                                    DALDateSystem da5 = new DALDateSystem(conexao5);
                                    cadastrologin1.IdCadastroLoginNovo = IdUsuarioGeral;
                                    da5.IncluirLoginUsuario(cadastrologin1);
                                }
                                if (ConfirmacaoFuncionarioRegistro == true)
                                {
                                    //Cadastro usuário Funcionário de Contratos
                                    Conexao conexao6 = new Conexao(this.connetionString);
                                    DALDateSystem da6 = new DALDateSystem(conexao6);
                                    CadastraFuncionarioRegistro.IdFuncionario = IdUsuarioGeral;
                                    da6.IncluirFuncionarioRegistro(CadastraFuncionarioRegistro);
                                }
                                if (ConfirmacaoFuncionarioUsuarioVendas == true)
                                {
                                    //Cadastro usuário Funcionário de Contratos
                                    Conexao conexao7 = new Conexao(this.connetionString);
                                    DALDateSystem da7 = new DALDateSystem(conexao7);
                                    CadastraFuncionarioUsuarioVendas.ID_UsuarioV = IdUsuarioGeral;
                                    da7.IncluirUsuarioV(CadastraFuncionarioUsuarioVendas);
                                }
                                if (ConfirmacaoBaseDados == true)
                                {

                                }

                                MessageBox.Show("Usuário Cadastrado com sucesso! ");

                                FecharTodosFormulario();

                                FormCadastraUsuario FormCadastraUsuario = new FormCadastraUsuario(this.CriarFuncionariosOs, this.CriarFuncionarioVendas,
                                    this.CriarFuncionarioRegistro, this.CriarFuncionarioProdutos, this.CriarUsuarioAcesso, this.CriarProposta,
                            this.PermissaoBaseDados, this.PermissaoNivelAcesso,
                            this.PermissaoCliente, this.PermissaoFornecedor, this.PermissaoFuncionarioOs, this.PermissaoFuncionarioVendedor, this.PermissaoUsuarioAcesso,
                            this.PermissaoSeniorSapiens, this.PermissaoFuncionarioRegistro, this.PermissaoFuncionarioProdutos, this.PermissaoProposta,
                            this.NomeServidor, this.NomeBaseDados, this.NomeUsuario, this.SenhaBaseDados, this.UsuarioAcessoAdm);
                                FormCadastraUsuario.MdiParent = FormCadastraUsuario.ActiveForm;
                                FormCadastraUsuario.Show();
                                FormCadastraUsuario.Top = 0;
                                FormCadastraUsuario.Left = 0;
                            }
                        }
                    }

                    ///Cep preenchido  -----------------------------------------------

                    if (!(txtCepPessoa.Text == ""))
                    {
                        if (!(txtCepPessoa.Text == "") && (labelConfirmacao.Text.Equals("Resultado:")))
                        {
                            contadorVerificar++;
                            MessageBox.Show("Pesquisa o cep ou limpa o Cep! ");
                        }
                        if (!(txtCepPessoa.Text == "") && labelConfirmacao.Text.Equals("sucesso - cep não encontrado"))
                        {
                            contadorVerificar++;

                            MessageBox.Show("O cep é não é válido!");
                        }
                        if (!(txtCepPessoa.Text == "") && labelConfirmacao.Text.Equals("sucesso - cep completo"))
                        {
                            
                            if (UNomeUsuario == "Cadastrar")
                            {
                                if (VerificadorNomeUsuario() == true)
                                {
                                    ConfirmacaoNomeUsuario = true;
                                }
                                else
                                {
                                    MessageBox.Show("Abreviação de usuário já existe!");
                                }
                            }
                            if (FucionarioRegistro == "Cadastrar")
                            {
                                if ((DadosPessoaFuncionarioRegistro(txtReFuncionarioRegistro, errorProviderCadastraUsuario) == true) &&
                                    (DadosPessoaFuncionarioSobreNomeRegistro(txtFuncionarioAbreviacaoRegistro, errorProviderCadastraUsuario) == true))
                                {
                                    if (VerificadorFucionarioRegistroRe() == true)
                                    {
                                        this.ConfirmacaoFuncionarioRegistro = true;
                                    }
                                    else { MessageBox.Show("Número de RE Registro já existe!"); }
                                }
                                else { contadorVerificar++; }
                            }
                            if (FucionarioOS == "Cadastrar")
                            {
                                if ((DadosPessoaFuncionarioOsRE(txtReFuncionarioO, errorProviderCadastraUsuario) == true) &&
                                    (DadosPessoaFuncionarioOsAbreviacao(txtFuncionarioAbreviacaoO, errorProviderCadastraUsuario) == true))
                                {
                                    if (VerificadorReOs() == true)
                                    {
                                        this.ConfirmacaoFuncionarioOs = true;
                                    }
                                    else
                                    { MessageBox.Show("Número de RE OS já existe!"); }
                                }
                                else { contadorVerificar++; }
                            }


                            if (FucionarioVendas == "Cadastrar")
                            {
                                if (DadosPessoaFuncionarioOsAbreviacao(txtAbreviacaoFuncionarioV, errorProviderCadastraUsuario) == true)
                                {
                                    if (VerificadorFucionarioVendas() == true)
                                    {
                                        this.ConfirmacaoFuncionarioVendas = true;
                                    }
                                    else
                                    { MessageBox.Show("Abreviação de usuário já existe!"); }
                                }
                                else { contadorVerificar++; }
                            }
                            //COMERCIAL NÃO CRIADO NESTE MOMENTO!
                            //if (FuncionarioComercio == "Cadastrar")
                            //{ }

                            if (CPermissaoUsuarioAcesso == "Cadastrar")
                            {
                                if (DadosPessoaUsuarioAcessoSistema(txtUsuarioLoginFuncionario, errorProviderCadastraUsuario) == true)
                                {

                                    if (VerificadorFucionarioUsuarioAcesso() == true)
                                    {
                                        string senhaAcesso = txtSenhaFuncionario.Text;
                                        string senhaConfirmacao = txtConfirmacaoSenhaFuncionario.Text;
                                        string UsoAcesso = comboBoxUsuarioBaseDados.Text.ToString();
                                        UsoAcesso.ToString();

                                        if ((senhaAcesso == "") || (senhaConfirmacao == ""))
                                        {
                                            contadorVerificar++;
                                            contadorVerificar.ToString();
                                            MessageBox.Show("A senha de acesso não pode estarem em branco!");
                                        }
                                        if (!(senhaAcesso == "") && !(senhaConfirmacao == ""))
                                        {
                                            if (UsoAcesso != "")
                                            {
                                                if (senhaAcesso.Equals(senhaConfirmacao))
                                                {
                                                    this.ConfirmacaoUsuarioAcesso = true;
                                                }
                                                else { contadorVerificar++; MessageBox.Show("As senhas não conferem."); }
                                            }
                                            if (UsoAcesso == "")
                                            {
                                                contadorVerificar++;
                                                contadorVerificar.ToString();
                                                MessageBox.Show("Escolhe a conexão com sistema.");
                                            }
                                        }
                                    }
                                    else
                                    { MessageBox.Show("Usuário já existe!"); }
                                }
                                else { contadorVerificar++; }
                            }
                            if (CBaseDados == "Cadastrar")
                            {

                            }

                            ///confirma todas as entradas
                            if (contadorVerificar == 0)
                            {
                                if (UNomeUsuario== "Cadastrar")
                                {
                                    try
                                    {
                                        //Cadastro Dados Geral usuário
                                        Conexao conexao = new Conexao(this.connetionString);
                                        DALDateSystem da = new DALDateSystem(conexao);
                                        da.IncluirUsuarioGeral(CadastraUsuarioGeral);
                                    }
                                    catch (Exception EX)
                                    {
                                        MessageBox.Show("Confirmação de Dados Pessoas: " + EX.ToString());
                                    }
                                    int IdUsuarioGeral = 0;
                                    IdUsuarioGeral = int.Parse(CadastraUsuarioGeral.IdUsuario.ToString());

                                    if (ConfirmacaoCep == true)
                                    {
                                        try
                                        {
                                            //Cadastro usuário Cep
                                            Conexao conexao2 = new Conexao(this.connetionString);
                                            DALDateSystem da2 = new DALDateSystem(conexao2);
                                            CepCadastraUsuarioGeral.idCep = IdUsuarioGeral;
                                            da2.UsuarioGeralCepInserir(CepCadastraUsuarioGeral);
                                        }
                                        catch (Exception EX)
                                        {
                                            MessageBox.Show("Confirmação de Cep: " + EX.ToString());
                                        }

                                    }
                                    if (ConfirmacaoFuncionarioOs == true)
                                    {
                                        try
                                        {
                                            //VERIFICADOR DE OS
                                            if (FucionarioOS == "Cadastrar") { cadastrologin1.VerificadorOs = 1; }
                                            else { cadastrologin1.VerificadorOs = 0; }

                                            //Cadastro usuário Funcionário de OS
                                            Conexao conexao3 = new Conexao(this.connetionString);
                                            DALDateSystem da3 = new DALDateSystem(conexao3);

                                            CadastraFuncionarioOs.IdFuncionario = IdUsuarioGeral;
                                            da3.IncluirFuncionarioOs(CadastraFuncionarioOs);
                                        }
                                        catch (Exception EX)
                                        {
                                            MessageBox.Show("Confirmação de OS: " + EX.ToString());
                                        }
                                    }
                                    if (ConfirmacaoFuncionarioVendas == true)
                                    {
                                        try
                                        {
                                            //Cadastro usuário Funcionário de Vendedor
                                            Conexao conexao4 = new Conexao(this.connetionString);
                                            DALDateSystem da4 = new DALDateSystem(conexao4);
                                            CadastraVendedor.IdVendedor = IdUsuarioGeral;
                                            da4.IncluirFuncionarioVendedor(CadastraVendedor);
                                        }
                                        catch (Exception EX)
                                        {
                                            MessageBox.Show("Confirmação de Vendedor: " + EX.ToString());
                                        }
                                    }
                                    if (ConfirmacaoUsuarioAcesso == true)
                                    {
                                        try
                                        {
                                            //Cadastro usuário Acesso ao Sistema
                                            Conexao conexao5 = new Conexao(this.connetionString);
                                            DALDateSystem da5 = new DALDateSystem(conexao5);
                                            cadastrologin1.IdCadastroLoginNovo = IdUsuarioGeral;
                                            da5.IncluirLoginUsuario(cadastrologin1);
                                        }
                                        catch (Exception EX)
                                        {
                                            MessageBox.Show("Confirmação de Acesso ao Sistema: " + EX.ToString());
                                        }
                                    }
                                    if (ConfirmacaoFuncionarioRegistro == true)
                                    {
                                        try
                                        {
                                            //Cadastro usuário Funcionário de Contratos
                                            Conexao conexao6 = new Conexao(this.connetionString);
                                            DALDateSystem da6 = new DALDateSystem(conexao6);

                                            CadastraFuncionarioRegistro.IdFuncionario = IdUsuarioGeral;
                                            da6.IncluirFuncionarioRegistro(CadastraFuncionarioRegistro);
                                        }
                                        catch (Exception EX)
                                        {
                                            MessageBox.Show("Confirmação de Registro: " + EX.ToString());
                                        }
                                    }
                                    if (ConfirmacaoFuncionarioUsuarioVendas == true)
                                    {
                                        //Cadastro usuário Funcionário de Contratos
                                        Conexao conexao7 = new Conexao(this.connetionString);
                                        DALDateSystem da7 = new DALDateSystem(conexao7);
                                        CadastraFuncionarioUsuarioVendas.ID_UsuarioV = IdUsuarioGeral;
                                        da7.IncluirUsuarioV(CadastraFuncionarioUsuarioVendas);
                                    }
                                    if (ConfirmacaoBaseDados == true)
                                    {

                                    }

                                    MessageBox.Show("Usuário Cadastrado com sucesso! ");

                                    FecharTodosFormulario();

                                    FormCadastraUsuario cadastracliente = new FormCadastraUsuario(this.CriarFuncionariosOs, this.CriarFuncionarioVendas,
                                        this.CriarFuncionarioRegistro, this.CriarFuncionarioProdutos, this.CriarUsuarioAcesso, this.CriarProposta,
                            this.PermissaoBaseDados, this.PermissaoNivelAcesso,
                            this.PermissaoCliente, this.PermissaoFornecedor, this.PermissaoFuncionarioOs, this.PermissaoFuncionarioVendedor, this.PermissaoUsuarioAcesso,
                            this.PermissaoSeniorSapiens, this.PermissaoFuncionarioRegistro, this.PermissaoFuncionarioProdutos, this.PermissaoProposta,
                            this.NomeServidor, this.NomeBaseDados, this.NomeUsuario, this.SenhaBaseDados, this.UsuarioAcessoAdm);
                                    cadastracliente.MdiParent = FormCadastraUsuario.ActiveForm;
                                    cadastracliente.Show();
                                    cadastracliente.Top = 0;
                                    cadastracliente.Left = 0;
                                }
                            }
                            else
                            {
                                MessageBox.Show("Dados não estão corretamente preechidos");
                            }

                        }
                    }
                }
            }
            catch (Exception EX)
            {
                MessageBox.Show("Salvar error: " + EX.ToString());
            }         
        }
        private bool VerificadorNomeUsuario()
        {
            try
            {
                bool consta = false;
                SqlConnection conn = new SqlConnection(this.connetionString);

                SqlDataAdapter da2 = new SqlDataAdapter("SELECT * FROM U_USUARIO WHERE ABREVIACAO = '" + txtAbreviacao.Text + "';", conn);

                DataSet ds2 = new DataSet();

                da2.Fill(ds2);

                if (ds2.Tables[0].Rows.Count == 0)
                {
                    conn.Close();
                    contadorVerificar--;
                    consta = true;
                }
                if (ds2.Tables[0].Rows.Count > 0)
                {
                    conn.Close();            
                }
                return consta;
            }
            catch (Exception)
            {

                return true;
            }
        }
        private bool VerificadorFucionarioRegistroRe()
        {
            try
            {
                bool consta = false;
                SqlConnection conn = new SqlConnection(this.connetionString);

                SqlDataAdapter da2 = new SqlDataAdapter("SELECT * FROM U_FuncionarioRegistro WHERE ID_RE = '" + txtReFuncionarioRegistro.Text + "';", conn);

                DataSet ds2 = new DataSet();

                da2.Fill(ds2);

                if (ds2.Tables[0].Rows.Count == 0)
                {
                    conn.Close();
                    contadorVerificar--;
                    consta = true;
                }
                if (ds2.Tables[0].Rows.Count > 0)
                {
                    conn.Close();
                }
                return consta;
            }
            catch (Exception)
            {

                return true;
            }
        }
        private bool VerificadorReOs()
        {
            try
            {
                bool consta = false;
                SqlConnection conn = new SqlConnection(this.connetionString);

                SqlDataAdapter da2 = new SqlDataAdapter("SELECT * FROM U_FuncionarioOs WHERE ID_RE = " + txtReFuncionarioO.Text + ";", conn);

                DataSet ds2 = new DataSet();

                da2.Fill(ds2);

                if (ds2.Tables[0].Rows.Count == 0)
                {
                    conn.Close();
                    contadorVerificar--;
                    consta = true;
                }
                if (ds2.Tables[0].Rows.Count > 0)
                {
                    conn.Close();
                }
                return consta;
            }
            catch (Exception)
            {

                return true;
            }
        }
        private bool VerificadorFucionarioVendas()
        {
            try
            {
                bool consta = false;
                SqlConnection conn = new SqlConnection(this.connetionString);

                SqlDataAdapter da2 = new SqlDataAdapter("SELECT * FROM U_FuncionarioVendedor WHERE ABREVIACAO  = '" + txtAbreviacaoFuncionarioV.Text + "';", conn);

                DataSet ds2 = new DataSet();

                da2.Fill(ds2);

                if (ds2.Tables[0].Rows.Count == 0)
                {
                    conn.Close();
                    contadorVerificar--;
                    consta = true;
                }
                if (ds2.Tables[0].Rows.Count > 0)
                {
                    conn.Close();
                }
                return consta;
            }
            catch (Exception)
            {

                return true;
            }
        }
        
        
        private bool VerificadorFucionarioUsuarioAcesso()
        {
            try
            {
                bool consta = false;
                SqlConnection conn = new SqlConnection(this.connetionString);

                SqlDataAdapter da2 = new SqlDataAdapter("SELECT * FROM U_LoginUsuario WHERE usuario = '" + txtUsuarioLoginFuncionario.Text + "';", conn);

                DataSet ds2 = new DataSet();

                da2.Fill(ds2);

                if (ds2.Tables[0].Rows.Count == 0)
                {
                    conn.Close();
                    contadorVerificar--;
                    consta = true;
                }
                if (ds2.Tables[0].Rows.Count > 0)
                {
                    conn.Close();
                }
                return consta;
            }
            catch (Exception)
            {

                return true;
            }
        }
        
        
        private void comboBoxUsuarioBaseDados_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(this.connetionString);

            try
            {
                connection.Open();
                string Query = "EXEC D_ConsultaAcessoBaseDadosTxT " + comboBoxUsuarioBaseDados.Text + ";";


                SqlCommand command = new SqlCommand(Query, connection);
                SqlDataReader dr = command.ExecuteReader();
                while (dr.Read())
                {
                    this.IdAcessoBaseDados = dr.GetInt32(0);

                    //MessageBox.Show("O IdAcessoBaseDados : " + this.IdAcessoBaseDados);
                }
                connection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void buttonBaseDados_Click(object sender, EventArgs e)
        {
            txtUsuario.Enabled = true;
            txtSenha.Enabled = true;
            buttonTestaConexao.Enabled = true;
            buttonBaseDados.Enabled = false;
            //comboBoxUsuarioBaseDados.Items.Clear();
            this.NOVOREGISTRO = 1;

        }

        private void buttonTestaConexao_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(this.connetionString);

            //Verifica Se a USUARIO CONSTA NO SISTEMA!    

            SqlDataAdapter da3 = new SqlDataAdapter("EXEC D_ConsultaNomeAcessoBaseDadosTXT '" + txtUsuario.Text + "';", conn);

            DataSet ds3 = new DataSet();
            da3.Fill(ds3);

            conn.Open();

            if (ds3.Tables[0].Rows.Count > 0)
            {
                MessageBox.Show("O Usuário já consta no sistema não pode ser Inserido!");

                conn.Close();
            }
            if (ds3.Tables[0].Rows.Count == 0)
            {
                SqlConnection conn2 = new SqlConnection("Data Source=" + this.NomeServidor + ";Initial Catalog=MSOS;Persist Security Info=True;User ID=" + txtUsuario.Text + ";Password=" + txtSenha.Text + ";");
                try
                {
                    conn2.Open();

                    this.UsuarioTempBancoDados = txtUsuario.Text;

                    this.SenhaTempBancoDados = txtSenha.Text;

                    buttonBaseDadosSalvar.Enabled = true;

                    MessageBox.Show("Usuário e senha estão corretos! ");

                }
                catch (SqlException)
                {
                    buttonBaseDadosSalvar.Enabled = false;
                    MessageBox.Show("Usuário ou senha estão incorretos. Digite informações corretas! ");

                    conn2.Close();

                }
                finally
                {
                    conn2.Close();
                }
            }
        }
        public void AlterarBotoes(int Numero)
        {
            if (Numero == 1)//Base de dados Usuário novo
            {
                txtUsuario.Clear();
                txtSenha.Clear();

                txtUsuario.Enabled = false;
                txtSenha.Enabled = false;
            }
            if (Numero == 2)//Dados Pessoas
            {
                txtNomePessoa.Clear();
                txtSobrenomePessoa.Clear();
                txtAbreviacao.Clear();
                txtCepPessoa.Clear();
                txtLogradouroPessoa.Clear();
                txtEnderecoPessoa.Clear();
                txtNumeroPessoa.Clear();
                txtComplPessoa.Clear();
                txtBairroPessoa.Clear();
                txtCidadePessoa.Clear();
                txtSiglaCidadePessoa.Clear();
                txtTelefonePessoa.Clear();
                txtTelefone2Pessoa.Clear();
                txtCelularCelular.Clear();
                txtCelular2Pessoa.Clear();
                txtEmailEmail.Clear();
                txtCpfPessoa.Clear();
                txtRgPessoa.Clear();
                txtDataNascimentoPessoa.Value = DateTime.Now.Date;
            }
            if (Numero == 3)//Funcionario OS
            {
                txtReFuncionarioO.Clear();
                txtFuncionarioAbreviacaoO.Clear();
                txtFuncionarioEmaillO.Clear();
                maskedTelefoneFuncionarioO.Clear();
                maskedTelefone2FuncionarioO.Clear();
                maskedCelularFuncionarioO.Clear();
                maskedCelular2FuncionarioO.Clear();
            }
            if (Numero == 4)//Funcionario Vendedor
            {
                txtSalarioFuncionarioV.Clear();
                txtAbreviacaoFuncionarioV.Clear();
                txtEmailFuncionarioV.Clear();
                maskedTelefoneFuncionarioV.Clear();
                maskedTelefone2FuncionarioV.Clear();
                maskedtxtCelularFuncionarioV.Clear();
                maskedCelular2FuncionarioV.Clear();
                txtCargoFuncionarioV.Clear();
                txtDiaPagamentoFuncionarioV.Clear();
                txtComissaoVendedor.Clear();
                txtTipoVendedor.Clear();
                txtCodigoVendedor.Clear();
                txtDescricaoVendedor.Clear();
                dateTimePickerDataAdmissaoV.Value = DateTime.Now.Date;
            }
            if (Numero == 5)//USUARIO DE ACESSO
            {
                txtUsuarioLoginFuncionario.Clear();
                txtSenhaFuncionario.Clear();
                txtConfirmacaoSenhaFuncionario.Clear();
                txtObservacaoFuncionario.Clear();

            }
            if (Numero == 6)//Funcionario CONTRATOS
            {
                txtReFuncionarioRegistro.Clear();
                txtFuncionarioAbreviacaoRegistro.Clear();
                txtFuncionarioEmaillRegistro.Clear();
                maskedTelefoneFuncionarioRegistro.Clear();
                maskedTelefone2FuncionarioRegistro.Clear();
                maskedCelularFuncionarioRegistro.Clear();
                maskedCelular2FuncionarioRegistro.Clear();
            }
            if (Numero == 7)
            {
                txtFuncionarioAbreviacaoComercio.Clear();
                txtFuncionarioEmailComercio.Clear();
                maskedTelefoneFuncionarioTelefoneUsuarioV.Clear();
                maskedTelefoneFuncionarioTelefone2UsuarioV.Clear();
                maskedTelefoneFuncionarioCelularUsuarioV.Clear();
                maskedTelefoneFuncionarioCelular2UsuarioV.Clear();

            }
        }
        private void BotaoCancelarAcao(int Entrada)
        {
            if (Entrada == 1)//Nivel Acesso
            {
                checkNivelAcesso.Enabled = false;
                checkNivelAcesso.Checked = false;

                checkBoxNivelAcesso.Checked = false;
                checkBoxCriarCadastroUsuario.Checked = false;
                CheckBoxCriarFuncionarioOs.Checked = false;
                checkBoxCriarFuncionarioVendedor.Checked = false;
                checkBoxCriarFuncionarioRegistro.Checked = false;
                checkBoxCriarUsuarioAcesso.Checked = false;
                checkBoxFuncinarioOS.Checked = false;
                checkBoxFuncionarioVenda.Checked = false;
                checkBoxFuncionarioRegistro.Checked = false;
                checkBoxUsuarioAcesso.Checked = false;
                checkBoxSeniorSapiens.Checked = false;
                checkBoxBaseDados.Checked = false;
                checkBoxCliente.Checked = false;
                checkBoxFornecedor.Checked = false;
                checkBoxFuncionarioRegistro.Checked = false;
                checkBoxPermissãoProdutos.Checked = false;
            }
            if (Entrada == 2)//Permissao Cliente
            {
                checkNivelAcesso.Enabled = false;
                checkNivelAcesso.Checked = false;

                checkBoxCADASTRACLIENTE.Checked = false;
                checkBoxPESQUISACLIENTE.Checked = false;
                CheckBoxCriarFuncionarioOs.Checked = false;
                checkBoxCriarFuncionarioVendedor.Checked = false;
                checkBoxCriarFuncionarioRegistro.Checked = false;
                checkBoxCriarUsuarioAcesso.Checked = false;
                checkBoxFuncinarioOS.Checked = false;
                checkBoxFuncionarioVenda.Checked = false;
                checkBoxFuncionarioRegistro.Checked = false;
                checkBoxUsuarioAcesso.Checked = false;
                checkBoxSeniorSapiens.Checked = false;
                checkBoxBaseDados.Checked = false;
                checkBoxCliente.Checked = false;
                checkBoxFornecedor.Checked = false;
            }
            if (Entrada == 3)//Permissão Contratos
            {
                checkBoxCADASTRACREGISTRO.Checked = false;
                checkBoxPESQUISARECGISTRO.Checked = false;
                checkBoxVISUALIZARCREGISTRO.Checked = false;
                checkBoxEDITARCREGISTRO.Checked = false;
                checkBoxEXCLUIRCREGISTRO.Checked = false;

                checkBoxCADASTRACCREGISTRO.Checked = false;
                checkBoxPESQUISACCREGISTRO.Checked = false;
                checkBoxVISUALIZARCCREGISTRO.Checked = false;
                checkBoxEDITARCCREGISTRO.Checked = false;
                checkBoxEXCLUIRCCREGISTRO.Checked = false;

                checkBoxCADASTRAREGISTRO.Checked = false;
                checkBoxPESQUISAREGISTRO.Checked = false;
                checkBoxVISUALIZARREGISTRO.Checked = false;
                checkBoxEDITAREGISTRO.Checked = false;
                checkBoxEXCLUIRREGISTRO.Checked = false;
            }
            if (Entrada == 4)//permissão Fornecedor
            {
                checkBoxSELECIONARFORNECEDOR.Enabled = false;
                checkBoxSELECIONARFORNECEDOR.Checked = false;

                checkBoxCADASTRAFORNECEDOR.Checked = false;
                checkBoxPESQUISAFORNECEDOR.Checked = false;
                checkBoxVISUALIZARFORNECEDOR.Checked = false;
                checkBoxEDITARFORNECEDOR.Checked = false;
                checkBoxEXCLUIRFORNECEDOR.Checked = false;
                checkBoxCADASTRACFORNECEDOR.Checked = false;
                checkBoxPESQUISACFORNECEDOR.Checked = false;
                checkBoxVISUALIZARCFORNECEDOR.Checked = false;
                checkBoxEDITARCFORNECEDOR.Checked = false;
                checkBoxEXCLUIRCFORNECEDOR.Checked = false;
            }
            if (Entrada == 5)//Permissão Funcionario OS
            {
                checkBoxFUNCIONARIOOS.Enabled = false;

                checkBoxCADASTRAFUNCIOANRIO.Checked = false;
                checkBoxPESQUISAFUNCIONARIO.Checked = false;
                checkBoxVISUALIZARFUNCIONARIO.Checked = false;
                checkBoxEDITARFUNCIONARIO.Checked = false;
                checkBoxEXCLUIRFUNCIONARIO.Checked = false;
            }
            if (Entrada == 6) //Permissão Vendedor
            {
                checkBoxCadastraVendedor.Enabled = false;

                checkBoxCriarVendedor.Checked = false;
                checkBoxAlterarVendedor.Checked = false;
                checkBoxExcluirVendedor.Checked = false;
                checkBoxPesquisaVendedor.Checked = false;
                checkBoxVisualizarVendedor.Checked = false;
            }
            if (Entrada == 7) //permissão Usuário Acesso
            {
                checkBoxCRIARSistema.Checked = false;
                checkBoxALTERARSistema.Checked = false;
                checkBoxEXCLUIRSistema.Checked = false;
                checkBoxPESQUISASistema.Checked = false;
                checkBoxVISUALIZARSistema.Checked = false;
            }
            if (Entrada == 8)//Senior Sapiens
            {
                checkBoxSapiens.Enabled = false;
                checkBoxSapiens.Checked = false;
                checkBoxAcesso.Checked = false;
                checkBoxVisualizar.Checked = false;
                checkBoxExcluir.Checked = false;
            }
            if (Entrada == 9)//Permissão Produtos
            {
                checkBoxCriarProdutos.Checked = false;
                checkBoxAlterarProdutos.Checked = false;
                checkBoxExcluirProduttos.Checked = false;
                checkBoxPesquisaProdutos.Checked = false;
                checkBoxVisualizarProdutos.Checked = false;
            }
            if (Entrada == 10)//Permissão Proposta
            {
                checkBoxCriarProposta.Checked = false;
                checkBoxAlterarProposta.Checked = false;
                checkBoxExcluirProposta.Checked = false;
                checkBoxPesquisaProposta.Checked = false;
                checkBoxVisualizarProposta.Checked = false;
            }
        }

        private void buttonCadastraBaseDados_Click(object sender, EventArgs e)
        {
            BotaoCadastraBaseDados();
        }
        private void BotaoCadastraBaseDados()
        {
            CBaseDados = "Cadastrar";

            comboBoxUsuarioBaseDados.Enabled = false;
            buttonCancelarBaseDados.Enabled = true;
            buttonCadastraBaseDados.Enabled = false;
            panelBasedados.Enabled = true;
            buttonTestaConexao.Enabled = false;

        }

        private void buttonCancelarBaseDados_Click(object sender, EventArgs e)
        {

            BotaoCancelarBaseDados();
        }
        public void BotaoCancelarBaseDados()
        {
            CBaseDados = "";

            buttonCancelarBaseDados.Enabled = false;
            panelBasedados.Enabled = false;

            buttonBaseDados.Enabled = true;
            comboBoxUsuarioBaseDados.Enabled = true;
            buttonTestaConexao.Enabled = false;
            buttonCadastraBaseDados.Enabled = true;

            AlterarBotoes(1);
        }


        private void buttonCadastraNivelAcesso_Click(object sender, EventArgs e)
        {
            BotaoCadastraNivelAcesso();
        }
        private void BotaoCadastraNivelAcesso()
        {
            NivelAcesso = "Cadastrar";

            panelNivelAcesso.Enabled = true;
            checkNivelAcesso.Enabled = true;
            buttonCadastraNivelAcesso.Enabled = false;
            buttonCancelarNivelAcesso.Enabled = true;

            this.cont++;
        }

        private void buttonCancelarNivelAcesso_Click(object sender, EventArgs e)
        {
            BotaoCancelarNivelAcesso();
        }
        private void BotaoCancelarNivelAcesso()
        {
            NivelAcesso = "";

            panelNivelAcesso.Enabled = false;
            buttonCadastraNivelAcesso.Enabled = true;
            buttonCancelarNivelAcesso.Enabled = false;

            AlterarBotoes(7);
            BotaoCancelarAcao(1);

            this.cont--;
        }
        private void buttonCadastraPermissaoCliente_Click(object sender, EventArgs e)
        {
            BotaoCadastraPermissaoCliente();

        }
        private void BotaoCadastraPermissaoCliente()
        {
            CPermissaoCliente = "Cadastrar";

            panelPermissaCliente.Enabled = true;
            checkBoxSELECIONARCLIENTE.Enabled = true;
            buttonCadastraPermissaoCliente.Enabled = false;
            buttonCancelarPermissaoCliente.Enabled = true;

            this.cont++;
        }

        private void buttonCancelarPermissaoCliente_Click(object sender, EventArgs e)
        {
            BotaoCancelarPermissaoCliente();
        }
        private void BotaoCancelarPermissaoCliente()
        {
            CPermissaoCliente = "";

            panelPermissaCliente.Enabled = false;
            buttonCadastraPermissaoCliente.Enabled = true;
            buttonCancelarPermissaoCliente.Enabled = false;
            checkBoxSELECIONARCLIENTE.Enabled = false;
            checkBoxSELECIONARCLIENTE.Checked = false;

            this.cont--;

            AlterarBotoes(8);
            BotaoCancelarAcao(2);

        }
        private void buttonCadastraPermissaoFornecedor_Click(object sender, EventArgs e)
        {
            BotaoCadastraFornecedor();
        }
        public void BotaoCadastraFornecedor()
        {
            CPermissaoFornecedor = "Cadastrar";
            panelPermissaoFornecedor.Enabled = true;
            checkBoxSELECIONARFORNECEDOR.Enabled = true;
            buttonCadastraPermissaoFornecedor.Enabled = false;
            buttonCancelarPermissaoFornecedor.Enabled = true;

            this.cont++;
        }

        private void buttonCancelarPermissaoFornecedor_Click(object sender, EventArgs e)
        {
            BotaoCancelarPermissaoFornecedor();
        }
        public void BotaoCancelarPermissaoFornecedor()
        {
            CPermissaoFornecedor = "";

            panelPermissaoFornecedor.Enabled = false;

            buttonCadastraPermissaoFornecedor.Enabled = true;
            buttonCancelarPermissaoFornecedor.Enabled = false;
            checkBoxSELECIONARFORNECEDOR.Enabled = false;

            AlterarBotoes(9);
            BotaoCancelarAcao(4);

            this.cont--;
        }

        private void buttonCadastraUsuarioAcesso_Click(object sender, EventArgs e)
        {
            BotaoCadastraUsuarioAcesso();
        }
        private void BotaoCadastraUsuarioAcesso()
        {
            CPermissaoUsuarioAcesso = "Cadastrar";

            //Botão Cadastra Permissao Cliente
            if (PermissaoCliente == 1)
            {
                buttonCadastraPermissaoCliente.Enabled = true;
            }
            //Botão Cadastra Permissao Fornecedor
            if (PermissaoFornecedor == 1)
            {
                buttonCadastraPermissaoFornecedor.Enabled = true;
            }
            //Painel Cadastra Permissao Usuario de Acesso
            if (PermissaoUsuarioAcesso == 1)
            {
                panelPermissaoSistema.Enabled = true;
            }
            //Botão Cadastra Permissao do Senior e Sapiens
            if (PermissaoSeniorSapiens == 1)
            {
                buttonCadastraSapiens.Enabled = true;
            }



            panelCriarUsuarioAcesso.Enabled = true;
            buttonCadastraUsuarioAcesso.Enabled = false;
            buttonCancelarUsuarioAcesso.Enabled = true;
            checkBoxCadastraUsuarioAcesso.Enabled = true;
            comboBoxUsuarioBaseDados.Enabled = true;

            this.cont++;

            if (this.cont > 0)
            {
                SubPUPermissaoUsuario.Enabled = true;
            }
            if (this.cont == 0)
            {
                SubPUPermissaoUsuario.Enabled = false;
            }
            comboBoxUsuarioBaseDados.Items.Clear();

            Fill_listBoxAcessoBaseDados();
        }

        private void buttonCancelarUsuarioAcesso_Click(object sender, EventArgs e)
        {
            BotaoCancelarUsuarioAcesso();

        }
        private void BotaoCancelarUsuarioAcesso()
        {
            CPermissaoUsuarioAcesso = "";

            panelCriarUsuarioAcesso.Enabled = false;
            panelPermissaoSistema.Enabled = false;
            buttonCadastraUsuarioAcesso.Enabled = true;
            buttonCancelarUsuarioAcesso.Enabled = false;
            comboBoxUsuarioBaseDados.Enabled = false;
            BotaoCancelarAcao(1);
            BotaoCancelarAcao(2);
            BotaoCancelarAcao(3);
            BotaoCancelarAcao(4);
            BotaoCancelarAcao(5);
            BotaoCancelarAcao(6);
            BotaoCancelarAcao(7);
            BotaoCancelarAcao(8);

            cont--;
        }
        private void buttonCadastraSapiens_Click(object sender, EventArgs e)
        {
            BotaoCadastraSapiens();
        }
        public void BotaoCadastraSapiens()
        {
            CPermissaoSapiens = "Cadastrar";

            panelSeniorSapiens.Enabled = true;
            checkBoxSapiens.Enabled = true;
            buttonCadastraSapiens.Enabled = false;
            buttonCancelarSapiens.Enabled = true;

            this.cont++;
        }

        private void buttonCancelarSapiens_Click(object sender, EventArgs e)
        {
            BotaoCancelarSapiens();
        }
        public void BotaoCancelarSapiens()
        {
            CPermissaoSapiens = "";

            panelSeniorSapiens.Enabled = false;
            buttonCadastraSapiens.Enabled = true;
            buttonCancelarSapiens.Enabled = false;
            checkBoxSapiens.Checked = false;
            checkBoxSapiens.Enabled = false;
            AlterarBotoes(10);
            BotaoCancelarAcao(8);

            this.cont--;
        }


        private void buttonCancelaDadosPessoas_Click(object sender, EventArgs e)
        {
            FecharTodosFormulario();

            FormCadastraUsuario FormCadastraUsuario = new FormCadastraUsuario(this.CriarFuncionariosOs, this.CriarFuncionarioVendas,
                this.CriarFuncionarioRegistro, this.CriarFuncionarioProdutos, this.CriarUsuarioAcesso,this.CriarProposta,
                            this.PermissaoBaseDados, this.PermissaoNivelAcesso,
                            this.PermissaoCliente, this.PermissaoFornecedor, this.PermissaoFuncionarioOs, this.PermissaoFuncionarioVendedor, this.PermissaoUsuarioAcesso,
                            this.PermissaoSeniorSapiens, this.PermissaoFuncionarioRegistro, this.PermissaoFuncionarioProdutos,this.PermissaoProposta,
                            this.NomeServidor, this.NomeBaseDados, this.NomeUsuario, this.SenhaBaseDados, this.UsuarioAcessoAdm);
            FormCadastraUsuario.MdiParent = FormCadastraUsuario.ActiveForm;
            FormCadastraUsuario.Show();
            FormCadastraUsuario.Top = 0;
            FormCadastraUsuario.Left = 0;
        }

        private void buttonCancelarcadastrousuario_Click(object sender, EventArgs e)
        {
            FecharTodosFormulario();

            FormCadastraUsuario FormCadastraUsuario = new FormCadastraUsuario(this.CriarFuncionariosOs, this.CriarFuncionarioVendas,
                this.CriarFuncionarioRegistro, this.CriarFuncionarioProdutos, this.CriarUsuarioAcesso,this.CriarProposta,
                            this.PermissaoBaseDados, this.PermissaoNivelAcesso,
                            this.PermissaoCliente, this.PermissaoFornecedor, this.PermissaoFuncionarioOs, this.PermissaoFuncionarioVendedor, this.PermissaoUsuarioAcesso,
                            this.PermissaoSeniorSapiens, this.PermissaoFuncionarioRegistro, this.PermissaoFuncionarioProdutos,this.PermissaoProposta,
                            this.NomeServidor, this.NomeBaseDados, this.NomeUsuario, this.SenhaBaseDados, this.UsuarioAcessoAdm);
            FormCadastraUsuario.MdiParent = FormCadastraUsuario.ActiveForm;
            FormCadastraUsuario.Show();
            FormCadastraUsuario.Top = 0;
            FormCadastraUsuario.Left = 0;
        }

        private void buttonCadastraFuncionario_Click(object sender, EventArgs e)
        {
            BotaoCadastraFuncionarioOS();
        }
        public void BotaoCadastraFuncionarioOS()
        {
            FucionarioOS = "Cadastrar";

            panelCriarfuncionarioOs.Enabled = true;
            buttonCadastraFuncionario.Enabled = false;
            buttonCancelarFuncionario.Enabled = true;

            if (PermissaoFuncionarioOs == 1)
            {
                buttonCadastraPermissaoFuncionarioOs.Enabled = true;
            }


            //if (this.cont > 0)
            //{
            //    SubPUPermissaoUsuario.Enabled = true;
            //}
            //if (this.cont == 0)
            //{
            //    SubPUPermissaoUsuario.Enabled = false;
            //}
        }

        private void buttonCancelarFuncionario_Click(object sender, EventArgs e)
        {
            BotaoCancelarFuncionarioOS();
        }
        private void BotaoCancelarFuncionarioOS()
        {
            FucionarioOS = "";

            panelCriarfuncionarioOs.Enabled = false;
            panelPermissaoFuncionario.Enabled = false;
            buttonCancelarFuncionario.Enabled = false;
            buttonCadastraFuncionario.Enabled = true;
            checkBoxFUNCIONARIOOS.Enabled = false;
            checkBoxFUNCIONARIOOS.Checked = false;

            this.cont--;

            AlterarBotoes(3);
            BotaoCancelarAcao(5);
        }


        private void buttonCadastraVendedor_Click(object sender, EventArgs e)
        {
            BotaoCadastraVendedor();
        }
        private void BotaoCadastraVendedor()
        {
            FucionarioVendas = "Cadastrar";

            panelFuncionarioVendas.Enabled = true;
            buttonCancelarVendedor.Enabled = true;
            buttonCadastraVendedor.Enabled = false;

            if (PermissaoFuncionarioVendedor == 1)
            {
                buttonPermissaoCadastrarVendedor.Enabled = true;
            }


            //if (this.cont > 0)
            //{
            //    SubPUPermissaoUsuario.Enabled = true;
            //}
            //if (this.cont == 0)
            //{
            //    SubPUPermissaoUsuario.Enabled = false;
            //}
        }

        private void buttonCancelarVendedor_Click(object sender, EventArgs e)
        {
            BotaoCancelarVendedor();
        }
        private void BotaoCancelarVendedor()
        {
            FucionarioVendas = "";

            buttonCancelarVendedor.Enabled = false;
            buttonCadastraVendedor.Enabled = true;
            panelFuncionarioVendas.Enabled = false;
            panelPermissaoVendedor.Enabled = false;

            buttonPermissaoCadastrarVendedor.Enabled = true;
            buttonPermissaoCancelarVendedor.Enabled = false;
            checkBoxCadastraVendedor.Enabled = false;
            checkBoxCadastraVendedor.Checked = false;

            AlterarBotoes(4);
            BotaoCancelarAcao(6);

        }
        private void buttonLimpaCep_Click(object sender, EventArgs e)
        {
            labelConfirmacao.Text = "Resultado:";
            txtCepPessoa.Clear();
            txtLogradouroPessoa.Clear();
            txtEnderecoPessoa.Clear();
            txtNumeroPessoa.Clear();
            txtComplPessoa.Clear();
            txtBairroPessoa.Clear();
            txtCidadePessoa.Clear();
            txtSiglaCidadePessoa.Clear();
        }

        private void buttonBaseDadosSalvar_Click(object sender, EventArgs e)
        {
            //Cadastro usuário Base Dados Novo Acesso
            Conexao conexao7 = new Conexao(this.connetionString);
            DALDateSystem da7 = new DALDateSystem(conexao7);

            AcessoBaseDados NovoAcesso = new AcessoBaseDados();

            NovoAcesso.Servidor = this.NomeServidor;
            NovoAcesso.BaseDados = this.NomeBaseDados;
            NovoAcesso.Nome = this.UsuarioTempBancoDados;
            NovoAcesso.Senha = this.SenhaTempBancoDados;

            da7.IncluiAcessoBancoDados(NovoAcesso);

            buttonBaseDados.Enabled = false;
            buttonTestaConexao.Enabled = false;
            txtUsuario.Enabled = false;
            txtSenha.Enabled = false;
            buttonBaseDadosSalvar.Enabled = false;
            buttonCadastraBaseDados.Enabled = true;
            buttonCancelarBaseDados.Enabled = false;
            panelBasedados.Enabled = false;
            CBaseDados = "";
            comboBoxUsuarioBaseDados.Enabled = true;
            comboBoxUsuarioBaseDados.Refresh();



        }

        private void buttonBuscaCepFuncionario_Click(object sender, EventArgs e)
        {
            string xml = "http://cep.republicavirtual.com.br/web_cep.php?cep=@cep&formato=xml"
    .Replace("@cep", txtCepPessoa.Text);
            DataSet ds = new DataSet();
            ds.ReadXml(xml);

            labelConfirmacao.Text = ds.Tables[0].Rows[0][1].ToString();
            txtLogradouroPessoa.Text = ds.Tables[0].Rows[0][5].ToString();
            txtEnderecoPessoa.Text = ds.Tables[0].Rows[0][6].ToString();
            txtBairroPessoa.Text = ds.Tables[0].Rows[0][4].ToString();
            txtCidadePessoa.Text = ds.Tables[0].Rows[0][3].ToString();
        }

        private void txtNumeroPessoa_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Se a tecla digitada não for número
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }
        }

        private void txtReFuncionarioO_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Se a tecla digitada não for número
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }
        }

        private void txtSalarioFuncionarioV_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Se a tecla digitada não for número
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }
        }

        private void txtComissaoVendedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Se a tecla digitada não for número
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }
        }

        private void txtTipoVendedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Se a tecla digitada não for número
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }
        }

        private void txtCodigoVendedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Se a tecla digitada não for número
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }
        }

        private void txtSalarioFuncionarioV_TextChanged(object sender, EventArgs e)
        {
            Moeda(ref txtSalarioFuncionarioV);
        }

        private void txtComissaoVendedor_TextChanged(object sender, EventArgs e)
        {
            Moeda(ref txtComissaoVendedor);
        }

        private void txtSalarioFuncionarioV_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            //Se a tecla digitada não for número
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }
        }

        private void FormCadastraUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
            {
                this.Close();
            }
        }
        private void buttonCadastraRegistro_Click(object sender, EventArgs e)
        {
            BotaoCadastraRegistro();
        }
        private void BotaoCadastraRegistro()
        {
            FucionarioRegistro = "Cadastrar";

            panelCriarfuncionarioRegistro.Enabled = true;
            buttonCadastraRegistro.Enabled = false;
            buttonCancelarRegistro.Enabled = true;

            if (PermissaoFuncionarioRegistro == 1)
            {
                buttonCadastraPermissaoRegistro.Enabled = true;
            }
            //if (this.cont > 0)
            //{
            //    SubPUPermissaoUsuario.Enabled = true;
            //}
            //if (this.cont == 0)
            //{
            //    SubPUPermissaoUsuario.Enabled = false;
            //}
        }

        private void buttonCadastraPermissaoFuncionarioOs_Click(object sender, EventArgs e)
        {
            panelPermissaoFuncionario.Enabled = true;
            checkBoxFUNCIONARIOOS.Enabled = true;
            buttonCadastraPermissaoFuncionarioOs.Enabled = false;
            buttonCancelarPermissaoFuncionarioOs.Enabled = true;
        }

        private void buttonCancelarPermissaoFuncionarioOs_Click(object sender, EventArgs e)
        {
            panelPermissaoFuncionario.Enabled = false;
            checkBoxFUNCIONARIOOS.Enabled = false;
            checkBoxFUNCIONARIOOS.Checked = false;
            buttonCadastraPermissaoFuncionarioOs.Enabled = true;
            buttonCancelarPermissaoFuncionarioOs.Enabled = false;
            BotaoCancelarAcao(5);
        }

        private void buttonPermissaoCadastrarVendedor_Click(object sender, EventArgs e)
        {
            panelPermissaoVendedor.Enabled = true;
            buttonPermissaoCadastrarVendedor.Enabled = false;
            buttonPermissaoCancelarVendedor.Enabled = true;
            checkBoxCadastraVendedor.Enabled = true;
        }

        private void buttonPermissaoCancelarVendedor_Click(object sender, EventArgs e)
        {
            panelPermissaoVendedor.Enabled = false;
            buttonPermissaoCadastrarVendedor.Enabled = true;
            buttonPermissaoCancelarVendedor.Enabled = false;
            checkBoxCadastraVendedor.Enabled = false;
            checkBoxCadastraVendedor.Checked = false;
            BotaoCancelarAcao(6);
        }

        private void buttonPermissaoCadastrarProdutos_Click(object sender, EventArgs e)
        {
            panelPermissaoProdutos.Enabled = true;

            buttonPermissaoCadastrarProdutos.Enabled = false;
            buttonPermissaoCancelarProdutos.Enabled = true;
            checkBoxComercio.Enabled = true;
            BotaoCancelarAcao(9);
        }

        private void buttonCadastraUsuarioComercio_Click(object sender, EventArgs e)
        {
            FuncionarioComercio = "Cadastrar";

            panelFuncionarioComercio.Enabled = true;
                  
            buttonCadastraUsuarioComercio.Enabled = false;
            buttonCancelarUsuarioComercio.Enabled = true;

            if(PermissaoFuncionarioProdutos == 1)
            {
                buttonPermissaoCadastrarProdutos.Enabled = true;
                checkBoxComercio.Enabled = true;
            }
        }

        private void buttonCancelarUsuarioComercio_Click(object sender, EventArgs e)
        {
            FuncionarioComercio = "";

            panelFuncionarioComercio.Enabled = false;
            buttonCadastraUsuarioComercio.Enabled = true;
            buttonCancelarUsuarioComercio.Enabled = false;

            buttonPermissaoCadastrarProdutos.Enabled = true;
            buttonPermissaoCancelarProdutos.Enabled = false;
            checkBoxComercio.Enabled = false;
            checkBoxComercio.Checked = false;

            AlterarBotoes(7);
            BotaoCancelarAcao(9);

            this.cont--;
        }

        private void checkBoxComercio_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxComercio.Checked == true)
            {
                //PERMISSÃO DE FUNCIONARIO Comercio
                checkBoxCriarProdutos.Checked = true;
                checkBoxAlterarProdutos.Checked = true;
                checkBoxExcluirProduttos.Checked = true;
                checkBoxPesquisaProdutos.Checked = true;
                checkBoxVisualizarProdutos.Checked = true;
            }
            if (checkBoxComercio.Checked == false)
            {

                //PERMISSÃO DE FUNCIONARIO Comercio
                checkBoxCriarProdutos.Checked = false;
                checkBoxAlterarProdutos.Checked = false;
                checkBoxExcluirProduttos.Checked = false;
                checkBoxPesquisaProdutos.Checked = false;
                checkBoxVisualizarProdutos.Checked = false;
            }
        }

        private void buttonPermissaoCancelarProdutos_Click(object sender, EventArgs e)
        {
            panelPermissaoProdutos.Enabled = false;
            buttonPermissaoCadastrarProdutos.Enabled = true;
            buttonPermissaoCancelarProdutos.Enabled = false;
            
            checkBoxComercio.Checked = false;
            checkBoxComercio.Enabled = false;
            BotaoCancelarAcao(9);
        }

        private void FormCadastraUsuario_Load(object sender, EventArgs e)
        {

        }

        private void checkBoxCadastraProposta_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxCadastraProposta.Checked == true)
            {
                //PERMISSÃO DE FUNCIONARIO Proposta
                checkBoxCriarProposta.Checked = true;
                checkBoxAlterarProposta.Checked = true;
                checkBoxExcluirProposta.Checked = true;
                checkBoxPesquisaProposta.Checked = true;
                checkBoxVisualizarProposta.Checked = true;
            }
            if (checkBoxCadastraProposta.Checked == false)
            {
                //PERMISSÃO DE FUNCIONARIO Proposta
                checkBoxCriarProposta.Checked = false;
                checkBoxAlterarProposta.Checked = false;
                checkBoxExcluirProposta.Checked = false;
                checkBoxPesquisaProposta.Checked = false;
                checkBoxVisualizarProposta.Checked = false;
            }
        }

        private void buttonCadastraPermissaoProposta_Click(object sender, EventArgs e)
        {
            panelCadastraProposta.Enabled = true;

            buttonCadastraPermissaoProposta.Enabled = false;
            buttonCancelarProposta.Enabled = true;
            checkBoxCadastraProposta.Enabled = true;
            BotaoCancelarAcao(10);
        }

        private void buttonCancelarProposta_Click(object sender, EventArgs e)
        {
            panelCadastraProposta.Enabled = false;
            buttonCadastraPermissaoProposta.Enabled = true;
            buttonCancelarProposta.Enabled = false;

            checkBoxCadastraProposta.Checked = false;
            checkBoxCadastraProposta.Enabled = false;
            BotaoCancelarAcao(10);
        }

        private void buttonCadastraPermissaoRegistro_Click(object sender, EventArgs e)
        {
            buttonCadastraPermissaoRegistro.Enabled = true;
            panelPermissaoFuncionarioRegistro.Enabled = true;
            buttonCancelarPermissaoRegistro.Enabled = true;
            checkBoxSELECIONARREGISTRO.Enabled = true;
        }

        private void buttonCancelarPermissaoRegistro_Click(object sender, EventArgs e)
        {
            buttonCadastraPermissaoRegistro.Enabled = false;
            panelPermissaoFuncionarioRegistro.Enabled = false;
            buttonCancelarPermissaoRegistro.Enabled = false;
            checkBoxSELECIONARREGISTRO.Enabled = false;
            checkBoxSELECIONARREGISTRO.Checked = false;
            BotaoCancelarAcao(3);
        }

        private void checkBoxSELECIONARREGISTRO_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSELECIONARREGISTRO.Checked == true)
            {
                //PERMISSÃO DO CADASTRA REGISTRO
                checkBoxCADASTRACREGISTRO.Checked = true;
                checkBoxPESQUISARECGISTRO.Checked = true;
                checkBoxVISUALIZARCREGISTRO.Checked = true;
                checkBoxEDITARCREGISTRO.Checked = true;
                checkBoxEXCLUIRCREGISTRO.Checked = true;


                //PERMISSÃO DO CONTRATOS CADASTRA REGISTRO
                checkBoxCADASTRACCREGISTRO.Checked = true;
                checkBoxPESQUISACCREGISTRO.Checked = true;
                checkBoxVISUALIZARCCREGISTRO.Checked = true;
                checkBoxEDITARCCREGISTRO.Checked = true;
                checkBoxEXCLUIRCCREGISTRO.Checked = true;

                //PERMISSÃO DO CADASTRA GERAÇÃO DE REGISTRO
                checkBoxCADASTRAREGISTRO.Checked = true;
                checkBoxPESQUISAREGISTRO.Checked = true;
                checkBoxVISUALIZARREGISTRO.Checked = true;
                checkBoxEDITAREGISTRO.Checked = true;
                checkBoxEXCLUIRREGISTRO.Checked = true;


            }
            if (checkBoxSELECIONARREGISTRO.Checked == false)
            {
                //PERMISSÃO DO CADASTRA REGISTRO
                checkBoxCADASTRACREGISTRO.Checked = false;
                checkBoxPESQUISARECGISTRO.Checked = false;
                checkBoxVISUALIZARCREGISTRO.Checked = false;
                checkBoxEDITARCREGISTRO.Checked = false;
                checkBoxEXCLUIRCREGISTRO.Checked = false;

                //PERMISSÃO DO CONTRATOS CADASTRA REGISTRO
                checkBoxCADASTRACCREGISTRO.Checked = false;
                checkBoxPESQUISACCREGISTRO.Checked = false;
                checkBoxVISUALIZARCCREGISTRO.Checked = false;
                checkBoxEDITARCCREGISTRO.Checked = false;
                checkBoxEXCLUIRCCREGISTRO.Checked = false;

                //PERMISSÃO DO CADASTRA GERAÇÃO DE REGISTRO
                checkBoxCADASTRAREGISTRO.Checked = false;
                checkBoxPESQUISAREGISTRO.Checked = false;
                checkBoxVISUALIZARREGISTRO.Checked = false;
                checkBoxEDITAREGISTRO.Checked = false;
                checkBoxEXCLUIRREGISTRO.Checked = false;
            }
        }
        private void buttonCancelarRegistro_Click(object sender, EventArgs e)
        {
            FucionarioRegistro = "";

            panelCriarfuncionarioRegistro.Enabled = false;
            panelPermissaoFuncionario.Enabled = false;
            buttonCadastraRegistro.Enabled = true;
            buttonCancelarRegistro.Enabled = false;
            panelPermissaoFuncionarioRegistro.Enabled = false;
            buttonCancelarPermissaoRegistro.Enabled = false;
            checkBoxSELECIONARREGISTRO.Enabled = false;
            checkBoxSELECIONARREGISTRO.Checked = false;

            this.cont--;

            buttonCadastraPermissaoRegistro.Enabled = false;

            AlterarBotoes(6);
            BotaoCancelarAcao(3);
        }

        private void buttonFecharFuncionario_Click(object sender, EventArgs e)
        {
            FecharTodosFormulario();
        }
    }
}
