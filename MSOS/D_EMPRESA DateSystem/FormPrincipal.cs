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
    public partial class FormPrincipal : Form
    {
        private int ID_USUARIOACESSO = 0;
        public int IdUsuarioAcesso
        {
            get
            {
                return this.ID_USUARIOACESSO;

            }
            set
            {
                this.ID_USUARIOACESSO = value;
            }
        }
        private String connectionString = "";

        private string NOMEACESSO = "";
        public string NomeAcesso
        {
            get
            {
                return this.NOMEACESSO;

            }
            set
            {
                this.NOMEACESSO = value;
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
        private int TROCADESTATUSBOTAOTEMPOOS = 1;
        public int TrocaStatusBotaoTempoOs
        {
            get
            {
                return this.TROCADESTATUSBOTAOTEMPOOS;

            }
            set
            {
                this.TROCADESTATUSBOTAOTEMPOOS = value;
            }
        }
        private int VERIFICADORTEMPO = 0;
        public int VerificadorTempo
        {
            get
            {
                return this.VERIFICADORTEMPO;

            }
            set
            {
                this.VERIFICADORTEMPO = value;
            }
        }
        private string NOMEUSUARIOLOGADO = "";
        public string NomeUsuarioLogado
        {
            get
            {
                return this.NOMEUSUARIOLOGADO;

            }
            set
            {
                this.NOMEUSUARIOLOGADO = value;
            }
        }
        //PERMISSÕES DE ACESSO AO SISTEMA
        private int CRIARDADOSPESSOAS = 0;
        public int CriarDadosPessoas
        {
            get
            {
                return this.CRIARDADOSPESSOAS;

            }
            set
            {
                this.CRIARDADOSPESSOAS = value;
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
        private int CRIARFUNCIONARIOPRODUTOS = 0;
        public int CriarFuncionarioProdutos
        {
            get
            {
                return this.CRIARFUNCIONARIOPRODUTOS;

            }
            set
            {
                this.CRIARFUNCIONARIOPRODUTOS = value;
            }
        }
        private int CRIARFUNCIONARIOREGISTRO = 0;
        public int CriarFuncionarioRegistro
        {
            get
            {
                return this.CRIARFUNCIONARIOREGISTRO;

            }
            set
            {
                this.CRIARFUNCIONARIOREGISTRO = value;
            }
        }
        private int PROPOSTACADASTRA = 0;
        public int PropostaCadastra
        {
            get
            {
                return this.PROPOSTACADASTRA;

            }
            set
            {
                this.PROPOSTACADASTRA = value;
            }
        }
        private int PROPOSTAVISUALIZAR = 0;
        public int PropostaVisualizar
        {
            get
            {
                return this.PROPOSTAVISUALIZAR;

            }
            set
            {
                this.PROPOSTAVISUALIZAR = value;
            }
        }
        private int PROPOSTAPESQUISA = 0;
        public int PropostaPesquisa
        {
            get
            {
                return this.PROPOSTAPESQUISA;

            }
            set
            {
                this.PROPOSTAPESQUISA = value;
            }
        }
        private int PROPOSTAEDITAR = 0;
        public int PropostaEditar
        {
            get
            {
                return this.PROPOSTAEDITAR;

            }
            set
            {
                this.PROPOSTAEDITAR = value;
            }
        }
        private int PROPOSTAEXCLUIR = 0;
        public int PropostaExcluir
        {
            get
            {
                return this.PROPOSTAEXCLUIR;

            }
            set
            {
                this.PROPOSTAEXCLUIR = value;
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

        private int USUARIOCRIAR = 0;
        public int UsuarioCriar
        {
            get
            {
                return this.USUARIOCRIAR;

            }
            set
            {
                this.USUARIOCRIAR = value;
            }
        }
        private int USUARIOALTERAR = 0;
        public int UsuarioAlterar
        {
            get
            {
                return this.USUARIOALTERAR;

            }
            set
            {
                this.USUARIOALTERAR = value;
            }
        }
        private int USUARIOEXCLUIR = 0;
        public int UsuarioExcluir
        {
            get
            {
                return this.USUARIOEXCLUIR;

            }
            set
            {
                this.USUARIOEXCLUIR = value;
            }
        }
        private int USUARIOPESQUISA = 0;
        public int UsuarioPesquisa
        {
            get
            {
                return this.USUARIOPESQUISA;

            }
            set
            {
                this.USUARIOPESQUISA = value;
            }
        }
        private int USUARIOVISUALIZAR = 0;
        public int UsuarioVisualizar
        {
            get
            {
                return this.USUARIOVISUALIZAR;

            }
            set
            {
                this.USUARIOVISUALIZAR = value;
            }
        }

        private int CLIENTECADASTRA = 0;
         public int ClienteCadastra
        {
            get
            {
                return this.CLIENTECADASTRA;

            }
            set
            {
                this.CLIENTECADASTRA = value;
            }
        }
        private int CLIENTEPESQUISA = 0;
        public int ClientePesquisa
        {
            get
            {
                return this.CLIENTEPESQUISA;

            }
            set
            {
                this.CLIENTEPESQUISA = value;
            }
        }
        private int CLIENTEVISUALIZAR = 0;
        public int ClienteVisualizar
        {
            get
            {
                return this.CLIENTEVISUALIZAR;

            }
            set
            {
                this.CLIENTEVISUALIZAR = value;
            }
        }
        private int CLIENTEEDITAR = 0;
        public int ClienteEditar
        {
            get
            {
                return this.CLIENTEEDITAR;

            }
            set
            {
                this.CLIENTEEDITAR = value;
            }
        }
        private int CLIENTEEXCLUIR = 0;
        public int ClienteExcluir
        {
            get
            {
                return this.CLIENTEEXCLUIR;

            }
            set
            {
                this.CLIENTEEXCLUIR = value;
            }
        }
        private int CLIENTECCADASTRA = 0;
        public int ClienteCCadastra
        {
            get
            {
                return this.CLIENTECCADASTRA;

            }
            set
            {
                this.CLIENTECCADASTRA = value;
            }
        }
        private int CLIENTECPESQUISA = 0;
        public int ClienteCPesquisa
        {
            get
            {
                return this.CLIENTECPESQUISA;

            }
            set
            {
                CLIENTECPESQUISA = value;
            }
        }
        private int CLIENTECVISUALIZAR = 0;
        public int ClienteCVisualizar
        {
            get
            {
                return this.CLIENTECVISUALIZAR;

            }
            set
            {
                this.CLIENTECVISUALIZAR = value;
            }
        }
        private int CLIENTECEDITAR = 0;
        public int ClienteCEditar
        {
            get
            {
                return this.CLIENTECEDITAR;

            }
            set
            {
                this.CLIENTECEDITAR = value;
            }
        }
        private int CLIENTECEXCLUIR = 0;
        public int ClienteCExcluir
        {
            get
            {
                return this.CLIENTECEXCLUIR;

            }
            set
            {
                this.CLIENTECEXCLUIR = value;
            }
        }
        private int FORNECEDORCADASTRO = 0;
        public int FornecedorCadastra
        {
            get
            {
                return this.FORNECEDORCADASTRO;

            }
            set
            {
                this.FORNECEDORCADASTRO = value;
            }
        }
        private int FORNECEDORPESQUISA = 0;
        public int FornecedorPesquisa
        {
            get
            {
                return this.FORNECEDORPESQUISA;

            }
            set
            {
                this.FORNECEDORPESQUISA = value;
            }
        }
        private int FORNECEDORVISUALIZAR = 0;
        public int FornecedorVisualizar
        {
            get
            {
                return this.FORNECEDORVISUALIZAR;

            }
            set
            {
                this.FORNECEDORVISUALIZAR = value;
            }
        }
        private int FORNECEDOREDITAR = 0;
        public int FornecedorEditar
        {
            get
            {
                return this.FORNECEDOREDITAR;

            }
            set
            {
                this.FORNECEDOREDITAR = value;
            }
        }
        private int FORNECEDOREXCLUIR = 0;
        public int FornecedorExcluir
        {
            get
            {
                return this.FORNECEDOREXCLUIR;

            }
            set
            {
                this.FORNECEDOREXCLUIR = value;
            }
        }
        private int FORNECEDORCCADASTRO = 0;
        public int FornecedorCCadastra
        {
            get
            {
                return this.FORNECEDORCCADASTRO;

            }
            set
            {
                this.FORNECEDORCCADASTRO = value;
            }
        }
        private int FORNECEDORCPESQUISA = 0;
        public int FornecedorCPesquisa
        {
            get
            {
                return this.FORNECEDORCPESQUISA;

            }
            set
            {
                this.FORNECEDORCPESQUISA = value;
            }
        }
        private int FORNECEDORCVISUALIZAR = 0;
        public int FornecedorCVisualizar
        {
            get
            {
                return this.FORNECEDORCVISUALIZAR;

            }
            set
            {
                this.FORNECEDORCVISUALIZAR = value;
            }
        }
        private int FORNECEDORCEDITAR = 0;
        public int FornecedorCEditar
        {
            get
            {
                return this.FORNECEDORCEDITAR;

            }
            set
            {
                this.FORNECEDORCEDITAR = value;
            }
        }
        private int FORNECEDORCEXCLUIR = 0;
        public int FornecedorcExcluir
        {
            get
            {
                return this.FORNECEDORCEXCLUIR;

            }
            set
            {
                this.FORNECEDORCEXCLUIR = value;
            }
        }
        private int FUNCIONARIOCADASTRA = 0;
        public int FuncionarioCadastra
        {
            get
            {
                return this.FUNCIONARIOCADASTRA;

            }
            set
            {
                this.FUNCIONARIOCADASTRA = value;
            }
        }
        private int FUNCIONARIOPESQUISA = 0;
        public int FuncionarioPesquisa
        {
            get
            {
                return this.FUNCIONARIOPESQUISA;

            }
            set
            {
                this.FUNCIONARIOPESQUISA = value;
            }
        }
        private int FUNCIONARIOVISUALIZAR = 0;
        public int FuncionarioVisualizar
        {
            get
            {
                return this.FUNCIONARIOVISUALIZAR;

            }
            set
            {
                this.FUNCIONARIOVISUALIZAR = value;
            }
        }
        private int FUNCIONARIOEDITAR = 0;
        public int FuncionarioEditar
        {
            get
            {
                return this.FUNCIONARIOEDITAR;

            }
            set
            {
                this.FUNCIONARIOEDITAR = value;
            }
        }
        private int FUNCIONARIOEXCLUIR = 0;
        public int FuncionarioExcluir
        {
            get
            {
                return this.FUNCIONARIOEXCLUIR;

            }
            set
            {
                this.FUNCIONARIOEXCLUIR = value;
            }
        }
        private int OSCADASTRA = 0;
        public int OsCadastra
        {
            get
            {
                return this.OSCADASTRA;

            }
            set
            {
                this.OSCADASTRA = value;
            }
        }
        private int OSPESQUISA = 0;
        public int OsPesquisa
        {
            get
            {
                return this.OSPESQUISA;

            }
            set
            {
                this.OSPESQUISA = value;
            }
        }
        private int OSVISUALIZAR = 0;
        public int OsVisualizar
        {
            get
            {
                return this.OSVISUALIZAR;

            }
            set
            {
                this.OSVISUALIZAR = value;
            }
        }
        private int OSEDITAR = 0;
        public int OsEditar
        {
            get
            {
                return this.OSEDITAR;

            }
            set
            {
                this.OSEDITAR = value;
            }
        }
        private int OSEXCLUIR = 0;
        public int OsExcluir
        {
            get
            {
                return this.OSEXCLUIR;

            }
            set
            {
                this.OSEXCLUIR = value;
            }
        }
        private int SENIORSAPIENSACESSO = 0;
        public int SeniorSapiensAcesso
        {
            get
            {
                return this.SENIORSAPIENSACESSO;

            }
            set
            {
                this.SENIORSAPIENSACESSO = value;
            }
        }
        private int SENIORSAPIENSPESQUISA = 0;
        public int SeniorSapiensPesquisa
        {
            get
            {
                return this.SENIORSAPIENSPESQUISA;

            }
            set
            {
                this.SENIORSAPIENSPESQUISA = value;
            }
        }
        private int SENIORSAPIENSEXCLUIR = 0;
        public int SeniorSapiensExcluir
        {
            get
            {
                return this.SENIORSAPIENSEXCLUIR;

            }
            set
            {
                this.SENIORSAPIENSEXCLUIR = value;
            }
        }

        private int VENDEDORCADASTRA = 0;
        public int VendedorCadastra
        {
            get
            {
                return this.VENDEDORCADASTRA;

            }
            set
            {
                this.VENDEDORCADASTRA = value;
            }
        }
        private int VENDEDORPESQUISA = 0;
        public int VendedorPesquisa
        {
            get
            {
                return this.VENDEDORPESQUISA;

            }
            set
            {
                this.VENDEDORPESQUISA = value;
            }
        }
        private int VENDEDORVISUALIZAR = 0;
        public int VendedorVisualizar
        {
            get
            {
                return this.VENDEDORVISUALIZAR;

            }
            set
            {
                this.VENDEDORVISUALIZAR = value;
            }
        }
        private int VENDEDOREDITAR = 0;
        public int VendedorEditar
        {
            get
            {
                return this.VENDEDOREDITAR;

            }
            set
            {
                this.VENDEDOREDITAR = value;
            }
        }
        private int VENDEDOREXCLUIR = 0;
        public int VendedorExcluir
        {
            get
            {
                return this.VENDEDOREXCLUIR;

            }
            set
            {
                this.VENDEDOREXCLUIR = value;
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
        private int PERMISSAOOS = 0;
        public int PermissaoOs
        {
            get
            {
                return this.PERMISSAOOS;

            }
            set
            {
                this.PERMISSAOOS = value;
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
        private int PRODUTOCADASTRA = 0;
        public int ProdutoCadastra
        {
            get
            {
                return this.PRODUTOCADASTRA;

            }
            set
            {
                this.PRODUTOCADASTRA = value;
            }
        }
        private int PRODUTOVISUALIZAR = 0;
        public int ProdutoVisualizar
        {
            get
            {
                return this.PRODUTOVISUALIZAR;

            }
            set
            {
                this.PRODUTOVISUALIZAR = value;
            }
        }
        private int PRODUTOPESQUISA = 0;
        public int ProdutoPesquisa
        {
            get
            {
                return this.PRODUTOPESQUISA;

            }
            set
            {
                this.PRODUTOPESQUISA = value;
            }
        }
        private int PRODUTOEDITAR = 0;
        public int ProdutoEditar
        {
            get
            {
                return this.PRODUTOEDITAR;

            }
            set
            {
                this.PRODUTOEDITAR = value;
            }
        }
        private int PRODUTOEXCLUIR = 0;
        public int ProdutoExcluir
        {
            get
            {
                return this.PRODUTOEXCLUIR;

            }
            set
            {
                this.PRODUTOEXCLUIR = value;
            }
        }
        private int REGISTROCADASTRA = 0;
        public int RegistroCadastra
        {
            get
            {
                return this.REGISTROCADASTRA;

            }
            set
            {
                this.REGISTROCADASTRA = value;
            }
        }
        private int REGISTROVISUALIZAR = 0;
        public int RegistroVisualizar
        {
            get
            {
                return this.REGISTROVISUALIZAR;

            }
            set
            {
                this.REGISTROVISUALIZAR = value;
            }
        }
        private int REGISTROPESQUISA = 0;
        public int RegistroPesquisa
        {
            get
            {
                return this.REGISTROPESQUISA;

            }
            set
            {
                this.REGISTROPESQUISA = value;
            }
        }
        private int REGISTROEDITAR = 0;
        public int RegistroEditar
        {
            get
            {
                return this.REGISTROEDITAR;

            }
            set
            {
                this.REGISTROEDITAR = value;
            }
        }
        private int REGISTROEXCLUIR = 0;
        public int RegistroExcluir
        {
            get
            {
                return this.REGISTROEXCLUIR;

            }
            set
            {
                this.REGISTROEXCLUIR = value;
            }
        }
        private int REGISTROCCADASTRA = 0;
        public int RegistroCCadastra
        {
            get
            {
                return this.REGISTROCCADASTRA;

            }
            set
            {
                this.REGISTROCCADASTRA = value;
            }
        }
        private int REGISTROCVISUALIZAR = 0;
        public int RegistroCVisualizar
        {
            get
            {
                return this.REGISTROCVISUALIZAR;

            }
            set
            {
                this.REGISTROCVISUALIZAR = value;
            }
        }
        private int REGISTROCPESQUISA = 0;
        public int RegistroCPesquisa
        {
            get
            {
                return this.REGISTROCPESQUISA;

            }
            set
            {
                this.REGISTROCPESQUISA = value;
            }
        }
        private int REGISTROCEDITAR = 0;
        public int RegistroCEditar
        {
            get
            {
                return this.REGISTROCEDITAR;

            }
            set
            {
                this.REGISTROCEDITAR = value;
            }
        }
        private int REGISTROCEXCLUIR = 0;
        public int RegistroCExcluir
        {
            get
            {
                return this.REGISTROCEXCLUIR;

            }
            set
            {
                this.REGISTROCEXCLUIR = value;
            }
        }
        private int REGISTROCCCADASTRA = 0;
        public int RegistroCCCadastra
        {
            get
            {
                return this.REGISTROCCCADASTRA;

            }
            set
            {
                this.REGISTROCCCADASTRA = value;
            }
        }
        private int REGISTROCCVISUALIZAR = 0;
        public int RegistroCCVisualizar
        {
            get
            {
                return this.REGISTROCCVISUALIZAR;

            }
            set
            {
                this.REGISTROCCVISUALIZAR = value;
            }
        }
        private int REGISTROCCPESQUISA = 0;
        public int RegistroCCPesquisa
        {
            get
            {
                return this.REGISTROCCPESQUISA;

            }
            set
            {
                this.REGISTROCCPESQUISA = value;
            }
        }
        private int REGISTROCCEDITAR = 0;
        public int RegistroCCEditar
        {
            get
            {
                return this.REGISTROCCEDITAR;

            }
            set
            {
                this.REGISTROCCEDITAR = value;
            }
        }
        private int REGISTROCCEXCLUIR = 0;
        public int RegistroCCExcluir
        {
            get
            {
                return this.REGISTROCCEXCLUIR;

            }
            set
            {
                this.REGISTROCCEXCLUIR = value;
            }
        }
        private int VERIFICADOROS = 0;
        public int VerificadorOs
        {
            get
            {
                return this.VERIFICADOROS;

            }
            set
            {
                this.VERIFICADOROS = value;
            }
        }

        private int ATUALIZACAOTELAPRINCIPAL = 0;
        public int AtualizacaoTelaPrincipal
        {
            get
            {
                return this.ATUALIZACAOTELAPRINCIPAL;

            }
            set
            {
                this.ATUALIZACAOTELAPRINCIPAL = value;
            }
        }

        public FormPrincipal(string nome, string connectionString)
        {

            InitializeComponent();

            try
            {
                this.connectionString = connectionString;

                SqlConnection conn = new SqlConnection(connectionString);
                string sql1 = "exec D_ConsultaNomeUsuarioAcesso '" + nome + "';";
                SqlDataAdapter sda = new SqlDataAdapter(sql1, conn);
                DataSet ds1 = new DataSet();
                sda.Fill(ds1);

                conn.Open();

                //PERMISSÃO DO SISTEMA

                this.IdUsuarioAcesso = int.Parse(ds1.Tables[0].Rows[0][0].ToString());

                this.NomeAcesso = ds1.Tables[0].Rows[0][16].ToString();

                this.UsuarioAcessoAdm = int.Parse(ds1.Tables[0].Rows[0][19].ToString());

                int IdAcessoBaseDados = int.Parse(ds1.Tables[0].Rows[0][20].ToString());

                this.CriarDadosPessoas = int.Parse(ds1.Tables[0].Rows[0][21].ToString());
                this.CriarFuncionariosOs = int.Parse(ds1.Tables[0].Rows[0][22].ToString());
                this.CriarFuncionarioVendas = int.Parse(ds1.Tables[0].Rows[0][23].ToString());

                this.CriarFuncionarioProdutos = int.Parse(ds1.Tables[0].Rows[0][88].ToString());
                this.CriarFuncionarioRegistro = int.Parse(ds1.Tables[0].Rows[0][89].ToString());

                this.CriarUsuarioAcesso = int.Parse(ds1.Tables[0].Rows[0][24].ToString());
                this.UsuarioCriar = int.Parse(ds1.Tables[0].Rows[0][25].ToString());
                this.UsuarioAlterar = int.Parse(ds1.Tables[0].Rows[0][26].ToString());
                this.UsuarioExcluir = int.Parse(ds1.Tables[0].Rows[0][27].ToString());
                this.UsuarioPesquisa = int.Parse(ds1.Tables[0].Rows[0][28].ToString());
                this.UsuarioVisualizar = int.Parse(ds1.Tables[0].Rows[0][29].ToString());

                //PERMISSÃO DO CLIENTE
                this.ClienteCadastra = int.Parse(ds1.Tables[0].Rows[0][30].ToString());
                this.ClientePesquisa = int.Parse(ds1.Tables[0].Rows[0][31].ToString());
                this.ClienteVisualizar = int.Parse(ds1.Tables[0].Rows[0][32].ToString());
                this.ClienteEditar = int.Parse(ds1.Tables[0].Rows[0][33].ToString());
                this.ClienteExcluir = int.Parse(ds1.Tables[0].Rows[0][34].ToString());

                //PERMISSÃO DO CONTATOS CLIENTE
                this.ClienteCCadastra = int.Parse(ds1.Tables[0].Rows[0][35].ToString());
                this.ClienteCPesquisa = int.Parse(ds1.Tables[0].Rows[0][36].ToString());
                this.ClienteCVisualizar = int.Parse(ds1.Tables[0].Rows[0][37].ToString());
                this.ClienteCEditar = int.Parse(ds1.Tables[0].Rows[0][38].ToString());
                this.ClienteCExcluir = int.Parse(ds1.Tables[0].Rows[0][39].ToString());

                //PERMISSÃO DO FORNECEDOR
                this.FornecedorCadastra = int.Parse(ds1.Tables[0].Rows[0][40].ToString());
                this.FornecedorPesquisa = int.Parse(ds1.Tables[0].Rows[0][41].ToString());
                this.FornecedorVisualizar = int.Parse(ds1.Tables[0].Rows[0][42].ToString());
                this.FornecedorEditar = int.Parse(ds1.Tables[0].Rows[0][43].ToString());
                this.FornecedorExcluir = int.Parse(ds1.Tables[0].Rows[0][44].ToString());

                //PERMISSÃO DO CONTATOS FORNECEDOR
                this.FornecedorCCadastra = int.Parse(ds1.Tables[0].Rows[0][45].ToString());
                this.FornecedorCPesquisa = int.Parse(ds1.Tables[0].Rows[0][46].ToString());
                this.FornecedorCVisualizar = int.Parse(ds1.Tables[0].Rows[0][47].ToString());
                this.FornecedorCEditar = int.Parse(ds1.Tables[0].Rows[0][48].ToString());
                this.FornecedorcExcluir = int.Parse(ds1.Tables[0].Rows[0][49].ToString());

                //PERMISSÃO DO FUNCIONÁRIO
                this.FuncionarioCadastra = int.Parse(ds1.Tables[0].Rows[0][50].ToString());
                this.FuncionarioPesquisa = int.Parse(ds1.Tables[0].Rows[0][51].ToString());
                this.FuncionarioVisualizar = int.Parse(ds1.Tables[0].Rows[0][52].ToString());
                this.FuncionarioEditar = int.Parse(ds1.Tables[0].Rows[0][53].ToString());
                this.FuncionarioExcluir = int.Parse(ds1.Tables[0].Rows[0][54].ToString());

                //PERMISSÃO DE OS
                this.OsCadastra = int.Parse(ds1.Tables[0].Rows[0][55].ToString());
                this.OsPesquisa = int.Parse(ds1.Tables[0].Rows[0][56].ToString());
                this.OsVisualizar = int.Parse(ds1.Tables[0].Rows[0][57].ToString());
                this.OsEditar = int.Parse(ds1.Tables[0].Rows[0][58].ToString());
                this.OsExcluir = int.Parse(ds1.Tables[0].Rows[0][59].ToString());

                //PERMISSÃO DE SENIOR SAPIENS
                this.SeniorSapiensAcesso = int.Parse(ds1.Tables[0].Rows[0][60].ToString());
                this.SeniorSapiensPesquisa = int.Parse(ds1.Tables[0].Rows[0][61].ToString());
                this.SeniorSapiensExcluir = int.Parse(ds1.Tables[0].Rows[0][62].ToString());

                //PERMISSÃO ACESSO AS DADOS PARA CADASTRA
                this.PermissaoBaseDados = int.Parse(ds1.Tables[0].Rows[0][63].ToString());
                this.PermissaoNivelAcesso = int.Parse(ds1.Tables[0].Rows[0][64].ToString());
                this.PermissaoCliente = int.Parse(ds1.Tables[0].Rows[0][65].ToString());
                this.PermissaoFornecedor = int.Parse(ds1.Tables[0].Rows[0][66].ToString());
                this.PermissaoFuncionarioOs = int.Parse(ds1.Tables[0].Rows[0][67].ToString());
                this.PermissaoFuncionarioVendedor = int.Parse(ds1.Tables[0].Rows[0][68].ToString());
                this.PermissaoUsuarioAcesso = int.Parse(ds1.Tables[0].Rows[0][69].ToString());
                this.PermissaoOs = int.Parse(ds1.Tables[0].Rows[0][70].ToString());
                this.PermissaoSeniorSapiens = int.Parse(ds1.Tables[0].Rows[0][71].ToString());
                this.PermissaoFuncionarioRegistro = int.Parse(ds1.Tables[0].Rows[0][90].ToString());
                this.PermissaoFuncionarioProdutos = int.Parse(ds1.Tables[0].Rows[0][91].ToString());

                //PERMISSÃO DO VENDEDOR
                this.VendedorCadastra = int.Parse(ds1.Tables[0].Rows[0][72].ToString());
                this.VendedorPesquisa = int.Parse(ds1.Tables[0].Rows[0][73].ToString());
                this.VendedorVisualizar = int.Parse(ds1.Tables[0].Rows[0][74].ToString());
                this.VendedorEditar = int.Parse(ds1.Tables[0].Rows[0][75].ToString());
                this.VendedorExcluir = int.Parse(ds1.Tables[0].Rows[0][76].ToString());

                //PERMISSÃO TELA PRINCIPAL
                this.VerificadorOs = int.Parse(ds1.Tables[0].Rows[0][77].ToString());

                //////PERMISSÃO DO PRODUTOS
                this.ProdutoCadastra = int.Parse(ds1.Tables[0].Rows[0][78].ToString());
                this.ProdutoPesquisa = int.Parse(ds1.Tables[0].Rows[0][79].ToString());
                this.ProdutoVisualizar = int.Parse(ds1.Tables[0].Rows[0][80].ToString());
                this.ProdutoEditar = int.Parse(ds1.Tables[0].Rows[0][81].ToString());
                this.ProdutoExcluir = int.Parse(ds1.Tables[0].Rows[0][82].ToString());

                //////PERMISSÃO DO REGISTRA
                this.RegistroCadastra = int.Parse(ds1.Tables[0].Rows[0][83].ToString());
                this.RegistroVisualizar = int.Parse(ds1.Tables[0].Rows[0][84].ToString());
                this.RegistroPesquisa = int.Parse(ds1.Tables[0].Rows[0][85].ToString());
                this.RegistroEditar = int.Parse(ds1.Tables[0].Rows[0][86].ToString());
                this.RegistroExcluir = int.Parse(ds1.Tables[0].Rows[0][87].ToString());
                this.RegistroCCadastra = int.Parse(ds1.Tables[0].Rows[0][92].ToString());
                this.RegistroCVisualizar = int.Parse(ds1.Tables[0].Rows[0][93].ToString());
                this.RegistroCPesquisa = int.Parse(ds1.Tables[0].Rows[0][94].ToString());
                this.RegistroCEditar = int.Parse(ds1.Tables[0].Rows[0][95].ToString());
                this.RegistroCExcluir = int.Parse(ds1.Tables[0].Rows[0][96].ToString());
                this.RegistroCCCadastra = int.Parse(ds1.Tables[0].Rows[0][97].ToString());
                this.RegistroCCVisualizar = int.Parse(ds1.Tables[0].Rows[0][98].ToString());
                this.RegistroCCPesquisa = int.Parse(ds1.Tables[0].Rows[0][99].ToString());
                this.RegistroCCEditar = int.Parse(ds1.Tables[0].Rows[0][100].ToString());
                this.RegistroCCExcluir = int.Parse(ds1.Tables[0].Rows[0][101].ToString());

                //////PERMISSÃO DO PROPOSTA
                this.PropostaCadastra = int.Parse(ds1.Tables[0].Rows[0][102].ToString());
                this.PropostaPesquisa = int.Parse(ds1.Tables[0].Rows[0][104].ToString());
                this.PropostaVisualizar = int.Parse(ds1.Tables[0].Rows[0][103].ToString());
                this.PropostaEditar = int.Parse(ds1.Tables[0].Rows[0][105].ToString());
                this.PropostaExcluir = int.Parse(ds1.Tables[0].Rows[0][106].ToString());
                this.CriarProposta = int.Parse(ds1.Tables[0].Rows[0][107].ToString());
                this.PermissaoProposta = int.Parse(ds1.Tables[0].Rows[0][108].ToString());

                //////ATUALIZACAO DA TELA PRINCIPAL - ABRE JANELA SE TIVER NOVAS ATUALIZACOES

                this.AtualizacaoTelaPrincipal = int.Parse(ds1.Tables[0].Rows[0][109].ToString());

                conn.Close();

                SqlConnection conn2 = new SqlConnection(connectionString);
                string sql2 = "exec D_ConsultaAcessoBaseDadosAcesso " + IdAcessoBaseDados + ";";
                SqlDataAdapter sda2 = new SqlDataAdapter(sql2, conn2);
                DataSet ds2 = new DataSet();
                sda2.Fill(ds2);

                // ACESSO AO SERVIDOR
                this.NomeServidor = ds2.Tables[0].Rows[0][1].ToString();
                this.NomeBaseDados = ds2.Tables[0].Rows[0][2].ToString();
                this.NomeUsuario = ds2.Tables[0].Rows[0][3].ToString();
                this.SenhaBaseDados = ds2.Tables[0].Rows[0][4].ToString();

                this.NomeServidor.ToString();
                this.NomeBaseDados.ToString();
                this.NomeUsuario.ToString();
                this.SenhaBaseDados.ToString();

                connectionString.ToString();

                this.Text = "Tela principal DateSystem - Base de dados: " + NomeBaseDados + " - Brasil é um país de todos!";
                NomeUsuarioLogado = nome;

                if (AtualizacaoTelaPrincipal == 1)
                {
                    FormNovasAtualizacoesTelaPrincipal FormNovasAtualizacoesTelaPrincipalF = new FormNovasAtualizacoesTelaPrincipal(
                    this.NomeServidor, this.NomeBaseDados, this.NomeUsuario, this.SenhaBaseDados,
                    this.IdUsuarioAcesso);
                    // Set the Parent Form of the Child window.
                    FormNovasAtualizacoesTelaPrincipalF.MdiParent = this;
                    // Display the new form.
                    FormNovasAtualizacoesTelaPrincipalF.Show();
                    FormNovasAtualizacoesTelaPrincipalF.Top = 0;
                    FormNovasAtualizacoesTelaPrincipalF.Left = 0;
                }

                if (VerificadorOs == 0)
                {
                    VerificadorTempo = 1;
                    TrocaStatusBotaoTempoOs = 0;
                    buttonIniciarFinalizar.Text = "Iniciar";
                    BemVindoLogado.Text = "Bem vindo: " + nome;
                    labelPendencias.Text = "Pendências:Parado o Serviço!";
                    timerOs.Stop();
                    this.labelPendencias.ForeColor = Color.Black;
                }
                if (VerificadorOs == 1)
                {
                    OsAbertos();
                }

                conn2.Close();


            }
            catch (Exception e)
            {
                MessageBox.Show("Erro ao acessar informações do sistema! " + e.Message);
                Application.Exit();
            }

        }



        //public FormPrincipal(string nome, string connectionString, string BaseDados)
        //{

        //    InitializeComponent();

        //    try
        //    {

        //        //PERMISSÃO DO SISTEMA

        //        string connectionString1 = connectionString;

        //        this.Text = "Tela Principal " + BaseDados + ".";

        //        this.connectionString = "Data Source=PROGRAMAS;Initial Catalog=MSOSTESTE2;Persist Security Info=True;User ID=master;Password=dellm@ster2016;";

        //        this.IdUsuarioAcesso = 1;

        //        this.NomeAcesso = "hexen";

        //        this.UsuarioAcessoAdm = 1;

        //        int IdAcessoBaseDados = 1;

        //        this.CriarDadosPessoas = 1;
        //        this.CriarFuncionariosOs = 1;
        //        this.CriarFuncionarioVendas = 1;

        //        this.CriarFuncionarioProdutos = 1;
        //        this.CriarFuncionarioRegistro = 1;

        //        this.CriarUsuarioAcesso = 1;
        //        this.UsuarioCriar = 1;
        //        this.UsuarioAlterar = 1;
        //        this.UsuarioExcluir = 1;
        //        this.UsuarioPesquisa = 1;
        //        this.UsuarioVisualizar = 1;

        //        //PERMISSÃO DO CLIENTE
        //        this.ClienteCadastra = 1;
        //        this.ClientePesquisa = 1;
        //        this.ClienteVisualizar = 1;
        //        this.ClienteEditar = 1;
        //        this.ClienteExcluir = 1;

        //        //PERMISSÃO DO CONTATOS CLIENTE
        //        this.ClienteCCadastra = 1;
        //        this.ClienteCPesquisa = 1;
        //        this.ClienteCVisualizar = 1;
        //        this.ClienteCEditar = 1;
        //        this.ClienteCExcluir = 1;

        //        //PERMISSÃO DO FORNECEDOR
        //        this.FornecedorCadastra = 1;
        //        this.FornecedorPesquisa = 1;
        //        this.FornecedorVisualizar = 1;
        //        this.FornecedorEditar = 1;
        //        this.FornecedorExcluir = 1;

        //        //PERMISSÃO DO CONTATOS FORNECEDOR
        //        this.FornecedorCCadastra = 1;
        //        this.FornecedorCPesquisa = 1;
        //        this.FornecedorCVisualizar = 1;
        //        this.FornecedorCEditar = 1;
        //        this.FornecedorcExcluir = 1;

        //        //PERMISSÃO DO FUNCIONÁRIO
        //        this.FuncionarioCadastra = 1;
        //        this.FuncionarioPesquisa = 1;
        //        this.FuncionarioVisualizar = 1;
        //        this.FuncionarioEditar = 1;
        //        this.FuncionarioExcluir = 1;

        //        //PERMISSÃO DE OS
        //        this.OsCadastra = 1;
        //        this.OsPesquisa = 1;
        //        this.OsVisualizar = 1;
        //        this.OsEditar = 1;
        //        this.OsExcluir = 1;

        //        //PERMISSÃO DE SENIOR SAPIENS
        //        this.SeniorSapiensAcesso = 1;
        //        this.SeniorSapiensPesquisa = 1;
        //        this.SeniorSapiensExcluir = 1;

        //        //PERMISSÃO ACESSO AS DADOS PARA CADASTRA
        //        this.PermissaoBaseDados = 1;
        //        this.PermissaoNivelAcesso = 1;
        //        this.PermissaoCliente = 1;
        //        this.PermissaoFornecedor = 1;
        //        this.PermissaoFuncionarioOs = 1;
        //        this.PermissaoFuncionarioVendedor = 1;
        //        this.PermissaoUsuarioAcesso = 1;
        //        this.PermissaoOs = 1;
        //        this.PermissaoSeniorSapiens = 1;
        //        this.PermissaoFuncionarioRegistro = 1;
        //        this.PermissaoFuncionarioProdutos = 1;

        //        //PERMISSÃO DO VENDEDOR
        //        this.VendedorCadastra = 1;
        //        this.VendedorPesquisa = 1;
        //        this.VendedorVisualizar = 1;
        //        this.VendedorEditar = 1;
        //        this.VendedorExcluir = 1;

        //        //PERMISSÃO TELA PRINCIPAL
        //        this.VerificadorOs = 1;

        //        //////PERMISSÃO DO PRODUTOS
        //        this.ProdutoCadastra = 1;
        //        this.ProdutoPesquisa = 1;
        //        this.ProdutoVisualizar = 1;
        //        this.ProdutoEditar = 1;
        //        this.ProdutoExcluir = 1;

        //        //////PERMISSÃO DO REGISTRA
        //        this.RegistroCadastra = 1;
        //        this.RegistroVisualizar = 1;
        //        this.RegistroPesquisa = 1;
        //        this.RegistroEditar = 1;
        //        this.RegistroExcluir = 1;
        //        this.RegistroCCadastra = 1;
        //        this.RegistroCVisualizar = 1;
        //        this.RegistroCPesquisa = 1;
        //        this.RegistroCEditar = 1;
        //        this.RegistroCExcluir = 1;
        //        this.RegistroCCCadastra = 1;
        //        this.RegistroCCVisualizar = 1;
        //        this.RegistroCCPesquisa = 1;
        //        this.RegistroCCEditar = 1;
        //        this.RegistroCCExcluir = 1;

        //        //////PERMISSÃO DO PROPOSTA
        //        this.PropostaCadastra = 1;
        //        this.PropostaPesquisa = 1;
        //        this.PropostaVisualizar = 1;
        //        this.PropostaEditar = 1;
        //        this.PropostaExcluir = 1;
        //        this.CriarProposta = 1;
        //        this.PermissaoProposta = 1;

        //        //////ATUALIZACAO DA TELA PRINCIPAL - ABRE JANELA SE TIVER NOVAS ATUALIZACOES

        //        this.AtualizacaoTelaPrincipal = 1;


        //        // ACESSO AO SERVIDOR
        //        this.NomeServidor = "ARQUIVOSERVER";
        //        this.NomeBaseDados = "MSOSTESTE2";
        //        this.NomeUsuario = "hexen";
        //        this.SenhaBaseDados = "hexen";

        //        this.NomeServidor.ToString();
        //        this.NomeBaseDados.ToString();
        //        this.NomeUsuario.ToString();
        //        this.SenhaBaseDados.ToString();

        //        //this.Text = "Tela principal DateSystem - Base de dados: " + NomeBaseDados + " - Brasil é um país de todos!";

        //        NomeUsuarioLogado = nome;

        //        //if (AtualizacaoTelaPrincipal == 1)
        //        //{
        //        //    FormNovasAtualizacoesTelaPrincipal FormNovasAtualizacoesTelaPrincipalF = new FormNovasAtualizacoesTelaPrincipal(
        //        //    this.NomeServidor, this.NomeBaseDados, this.NomeUsuario, this.SenhaBaseDados,
        //        //    this.IdUsuarioAcesso);
        //        //    // Set the Parent Form of the Child window.
        //        //    FormNovasAtualizacoesTelaPrincipalF.MdiParent = this;
        //        //    // Display the new form.
        //        //    FormNovasAtualizacoesTelaPrincipalF.Show();
        //        //    FormNovasAtualizacoesTelaPrincipalF.Top = 0;
        //        //    FormNovasAtualizacoesTelaPrincipalF.Left = 0;
        //        //}

        //        //if (VerificadorOs == 0)
        //        //{
        //        //    VerificadorTempo = 1;
        //        //    TrocaStatusBotaoTempoOs = 0;
        //        //    buttonIniciarFinalizar.Text = "Iniciar";
        //        //    BemVindoLogado.Text = "Bem vindo: " + nome;
        //        //    labelPendencias.Text = "Pendências:Parado o Serviço!";
        //        //    timerOs.Stop();
        //        //    this.labelPendencias.ForeColor = Color.Black;
        //        //}
        //        //if (VerificadorOs == 1)
        //        //{
        //        //    OsAbertos();
        //        //}

        //    }
        //    catch (Exception e)
        //    {
        //        MessageBox.Show("Erro ao acessar informações do sistema! " + e.Message);
        //        Application.Exit();
        //    }

        //}
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            
        }
        public void OsAbertos() //CONSULTA AS OS ABERTAS NO SISTEMA
        {
            SqlConnection conn3 = new SqlConnection(this.connectionString);
            string sql3 = "SELECT ID_ORDEM_SERVICO FROM O_OrdemServico WHERE ID_ESTADO = 1 OR ID_ESTADO = 2; ";
            SqlDataAdapter sda3 = new SqlDataAdapter(sql3, conn3);
            DataSet ds3 = new DataSet();
            sda3.Fill(ds3);

            conn3.Open();

            if (ds3.Tables[0].Rows.Count == 0)
            {
                //this.labelPendencias.Text = "Pendências:N° 0.";
                //this.Pedencias.Text = "Pendências:N° 0.";
                BemVindoLogado.Text = "Bem vindo: " + NomeUsuarioLogado;
                this.labelPendencias.Text = "Pendências:N° 0.";
                timerOs.Enabled = true;
                this.VerificadorTempo = 0;
                conn3.Close();
            }
            if (ds3.Tables[0].Rows.Count > 0)
            {
                timerOs.Enabled = true;
                //this.Pedencias.Text = "Pendências:N° " + ds3.Tables[0].Rows.Count + ".";
                BemVindoLogado.Text = "Bem vindo: " + NomeUsuarioLogado +".     " ;
                labelPendencias.Text = "Pendências:N° " + ds3.Tables[0].Rows.Count +".";
                this.VerificadorTempo = 1;
                conn3.Close();
            }
        }
        public void FormularioAbertos()
        {
            MessageBox.Show("Form Abertos " + Application.OpenForms.Count.ToString());
        }

        private void timerOs_Tick(object sender, EventArgs e)
        {
            OsAbertos();

            if(VerificadorTempo == 0)
            {
                if (this.labelPendencias.ForeColor == Color.Red)
                {
                    this.labelPendencias.ForeColor = Color.Black;
                }
                else
                {
                    this.labelPendencias.ForeColor = Color.Black;
                }
            }

            if (VerificadorTempo == 1)
            {
                if (this.labelPendencias.ForeColor == Color.Red)
                {
                    this.labelPendencias.ForeColor = Color.Black;
                }
                else
                {
                    this.labelPendencias.ForeColor = Color.Red;
                }
            }          
        }
    private void buttonIniciarFinalizar_Click(object sender, EventArgs e)
        {
            if (TrocaStatusBotaoTempoOs == 0)
            {
                VerificadorTempo = 0;
                TrocaStatusBotaoTempoOs = 1;
                buttonIniciarFinalizar.Text = "Parado";
                OsAbertos();

                timerOs.Enabled = true;
                timerOs.Start();

            }
            else if (TrocaStatusBotaoTempoOs == 1)
            {
                VerificadorTempo = 1;
                TrocaStatusBotaoTempoOs = 0;
                buttonIniciarFinalizar.Text = "Iniciar";
                BemVindoLogado.Text = "Bem vindo: " + NomeUsuarioLogado;
                this.labelPendencias.Text = "Pendências:Parado o Serviço!";
                timerOs.Stop();
                this.labelPendencias.ForeColor = Color.Black;
                //this.labelPendencias.ForeColor = Color.Black;
            }

        }
        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {


        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void sistemaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            String S = "Desenvolvido por Hexen Alvares! \n " + "Ano de 2017 \n" + " Versão 1.0 :)";
            MessageBox.Show(S, "Agradeço a Todos pelo o Apoio!");

        }
        private void desenvolvimentoToolStripMenuItem_Click(object sender, EventArgs e)
        {

            String S = "Desenvolvido por Hexen Alvares! \n " + "Ano de 2017 \n" + " Versão inicial 1.0 :)";
            MessageBox.Show(S, "Agradeço a Todos pelo o Apoio!");
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Deseja Sair do Sistema!", "Aviso", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
            else if (dialogResult == DialogResult.No)
            {

            }
        }
        private void clienteToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }
        //METODO PARA VERIFICA SE O FORMULÁRIO ESTA ABERTO SE TIVER ELE FECHA!
        public static void FechatodosOsFormularios(Type frmType)
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
            FechatodosOsFormularios(typeof(FormCadastroClientes));
            FechatodosOsFormularios(typeof(FormClientesContatos));
            FechatodosOsFormularios(typeof(FormFornecedores));
            FechatodosOsFormularios(typeof(FormPesquisaFornecedor));
            FechatodosOsFormularios(typeof(FormFornecedoresContatos));
            FechatodosOsFormularios(typeof(FormCadastroOsNovo));
            FechatodosOsFormularios(typeof(FormOSPesquisa));
            FechatodosOsFormularios(typeof(FormOSPesquisaEditar));
            FechatodosOsFormularios(typeof(FormPesquisaClientes));
            FechatodosOsFormularios(typeof(FormPesquisaClientesEditar));
            FechatodosOsFormularios(typeof(FormPesquisaClientesContatos));
            FechatodosOsFormularios(typeof(FormPesquisaFornecedorContatos));
            FechatodosOsFormularios(typeof(FormPesquisaFuncionario));
            FechatodosOsFormularios(typeof(FormPesquisaLoginUsuario));
            FechatodosOsFormularios(typeof(FormPesquisaLoginUsuarioEditar));
            FechatodosOsFormularios(typeof(FormSeniorSapiens));
            FechatodosOsFormularios(typeof(FormPesquisaLoginUsuario));
            FechatodosOsFormularios(typeof(FormLoginUsuarioSapiens));
            FechatodosOsFormularios(typeof(FormCadastraUsuario));
            FechatodosOsFormularios(typeof(FormOspesquisaNumerosLivres));
            FechatodosOsFormularios(typeof(FormCadastraProdutos));
            FechatodosOsFormularios(typeof(FormCadastraClienteV));
            FechatodosOsFormularios(typeof(FormPesquisaClienteVenda));
            FechatodosOsFormularios(typeof(FormProdutoVenda));
            FechatodosOsFormularios(typeof(FormPesquisaClientesVendaEditar));
            FechatodosOsFormularios(typeof(FormPesquisaProduto));
            FechatodosOsFormularios(typeof(FormPesquisaProdutoEditar));
            FechatodosOsFormularios(typeof(FormCadastraClienteRegistro));
            FechatodosOsFormularios(typeof(FormCadastraContatoRegistro));
            FechatodosOsFormularios(typeof(FormPesquisaCadastraRegistro));

            FechatodosOsFormularios(typeof(FormCadastraClienteRegistro));
            FechatodosOsFormularios(typeof(FormCadastraContatoRegistro));
            FechatodosOsFormularios(typeof(FormEntradaNoEstoque));
            //FechatodosOsFormularios(typeof(FormPesquisaProduto));

            FechatodosOsFormularios(typeof(FormCadastraRegistro));
            FechatodosOsFormularios(typeof(FormCadastraRegistroSub));
            FechatodosOsFormularios(typeof(FormCadastraRegistroSubEditar));
            FechatodosOsFormularios(typeof(FormPesquisaCadastraRegistro));
            FechatodosOsFormularios(typeof(FormPesquisaCadastraRegistroEditar));
            FechatodosOsFormularios(typeof(FormRelatorioRegistroComSubRegistro));
            FechatodosOsFormularios(typeof(FormRelatorioRegistroSemSubRegistro));

            FechatodosOsFormularios(typeof(FormNovasAtualizacoesTelaPrincipal));

            FechatodosOsFormularios(typeof(FormPesquisaClienteRegistro));
            FechatodosOsFormularios(typeof(FormPesquisaClientesRegistroEditar));
            
            FechatodosOsFormularios(typeof(FormPesquisaClientesRegistroContatos));

            FechatodosOsFormularios(typeof(FormAlteracaoStatusRS));

            FechatodosOsFormularios(typeof(FormPontoDeVenda));


        }

        public void CadastroCliente2()
        {
            FormCadastroClientes FormClientesCadastro = new FormCadastroClientes(this.NomeServidor,this.NomeBaseDados,this.NomeUsuario,
            this.SenhaBaseDados);
            // Set the Parent Form of the Child window.
            FormClientesCadastro.MdiParent = this;
            // Display the new form.
            FormClientesCadastro.Show();
            FormClientesCadastro.Top = 50;
            FormClientesCadastro.Left = 0;

        }

        private void fornecedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {


        }
        private void teste1ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void funcionarioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (FuncionarioCadastra == 0)
            {
                MessageBox.Show("Acesso não Permitido!");
            }
            if (FuncionarioCadastra == 1)
            {
                //FecharTodosFormulario();
                //FormCadastroFuncionario Funcionario = new FormCadastroFuncionario(this.NomeServidor, this.NomeBaseDados, this.NomeUsuario, this.SenhaBaseDados);
                //Funcionario.MdiParent = this;
                //Funcionario.Show();
                //Funcionario.Top = 0;
                //Funcionario.Left = 0;
            }
        }

        private void fornecedoresToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (FornecedorCadastra == 0)
            {
                MessageBox.Show("Acesso não Permitido!");
            }
            if (FornecedorCadastra == 1)
            {
                FecharTodosFormulario();
                FormFornecedores Fornecedor = new FormFornecedores(this.NomeServidor, this.NomeBaseDados, this.NomeUsuario, this.SenhaBaseDados);
                Fornecedor.MdiParent = this;
                Fornecedor.Show();
                Fornecedor.Top = 0;
                Fornecedor.Left = 0;
            }
        }

        private void clientesToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if(ClienteCadastra == 0)
            {
                MessageBox.Show("Acesso não Permitido!");
            }
            if (ClienteCadastra == 1)
            {
                FecharTodosFormulario();
                FormCadastroClientes FormClientesCadastro = new FormCadastroClientes(this.NomeServidor, this.NomeBaseDados, this.NomeUsuario,
                this.SenhaBaseDados);
                // Set the Parent Form of the Child window.
                FormClientesCadastro.MdiParent = this;
                // Display the new form.
                FormClientesCadastro.Show();
                FormClientesCadastro.Top = 0;
                FormClientesCadastro.Left = 0;
            }

        }

        private void contatosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (FornecedorCCadastra == 0)
            {
                MessageBox.Show("Acesso não Permitido!");
            }
            if (FornecedorCCadastra == 1)
            {
                FecharTodosFormulario();
                FormFornecedoresContatos FornecedorContatos = new FormFornecedoresContatos(this.NomeServidor, this.NomeBaseDados, 
                this.NomeUsuario, this.SenhaBaseDados);
                FornecedorContatos.MdiParent = this;
                FornecedorContatos.Show();
                FornecedorContatos.Top = 0;
                FornecedorContatos.Left = 0;
            }
        }

        private void contatosToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (ClienteCCadastra == 0)
            {
                MessageBox.Show("Acesso não Permitido!");
            }
            if (ClienteCCadastra == 1)
            {
                FecharTodosFormulario();
                FormClientesContatos ClientesContatos = new FormClientesContatos(this.NomeServidor, this.NomeBaseDados, this.NomeUsuario, 
                this.SenhaBaseDados);
                ClientesContatos.MdiParent = this;
                ClientesContatos.Show();
                ClientesContatos.Top = 0;
                ClientesContatos.Left = 0;
            }
        }

        private void lançamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void osToolStripMenuItem1_Click(object sender, EventArgs e)// KeyPressEventArgs 
        {       
            if (OsCadastra == 0)
            {
                MessageBox.Show("Acesso não Permitido!");
            }
            if (OsCadastra == 1)
            {
                FecharTodosFormulario();
                FormCadastroOsNovo CadastraOs = new FormCadastroOsNovo( this.IdUsuarioAcesso, this.NomeAcesso, this.NomeServidor, 
                this.NomeBaseDados, this.NomeUsuario, this.SenhaBaseDados);
                CadastraOs.MdiParent = this;
                CadastraOs.Show();
                CadastraOs.Top = 0;
                CadastraOs.Left = 0;
            }
        }

        private void pesquisarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pesquisaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void testeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void buscaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void aToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void clienteToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (ClientePesquisa == 0)
            {
                MessageBox.Show("Acesso não Permitido!");
            }
            if (ClientePesquisa == 1)
            {
                FecharTodosFormulario();
                FormPesquisaClientes FormClientesCadastro = new FormPesquisaClientes(this.ClienteVisualizar, this.ClienteEditar,
                this.ClienteExcluir,this.NomeServidor, this.NomeBaseDados, this.NomeUsuario, this.SenhaBaseDados);
                // Set the Parent Form of the Child window.
                FormClientesCadastro.MdiParent = this;
                // Display the new form.
                FormClientesCadastro.Show();
                FormClientesCadastro.Top = 0;
                FormClientesCadastro.Left = 0;
            }

            
        }

        private void contatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ClienteCPesquisa == 0)
            {
                MessageBox.Show("Acesso não Permitido!");
            }
            if (ClienteCPesquisa == 1)
            {
                FecharTodosFormulario();
                FormPesquisaClientesContatos FormClientesContatos = new FormPesquisaClientesContatos(this.ClienteCVisualizar, this.ClienteCEditar,
                this.ClienteCExcluir, this.NomeServidor, this.NomeBaseDados, this.NomeUsuario, this.SenhaBaseDados);
                // Set the Parent Form of the Child window.
                FormClientesContatos.MdiParent = this;
                // Display the new form.
                FormClientesContatos.Show();
                FormClientesContatos.Top = 0;
                FormClientesContatos.Left = 0;
            }
        }

        private void fornecedorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (FornecedorPesquisa == 0)
            {
                MessageBox.Show("Acesso não Permitido!");
            }
            if (FornecedorPesquisa == 1)
            {
                FecharTodosFormulario();
                FormPesquisaFornecedor FormFornecedorPesquisa = new FormPesquisaFornecedor(this.FornecedorVisualizar, this.FornecedorEditar, 
                this.FornecedorExcluir,this.NomeServidor, this.NomeBaseDados, this.NomeUsuario, this.SenhaBaseDados);
                // Set the Parent Form of the Child window.
                FormFornecedorPesquisa.MdiParent = this;
                // Display the new form.
                FormFornecedorPesquisa.Show();
                FormFornecedorPesquisa.Top = 0;
                FormFornecedorPesquisa.Left = 0;
            }
        }

        private void contatosToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            if (FornecedorCPesquisa == 0)
            {
                MessageBox.Show("Acesso não Permitido!");
            }
            if (FornecedorCPesquisa == 1)
            {
                FecharTodosFormulario();
                FormPesquisaFornecedorContatos FormFornecedorContatos = new FormPesquisaFornecedorContatos(this.FornecedorVisualizar, 
                this.FornecedorEditar, this.FornecedorExcluir,this.NomeServidor, this.NomeBaseDados, this.NomeUsuario, this.SenhaBaseDados);
                // Set the Parent Form of the Child window.
                FormFornecedorContatos.MdiParent = this;
                // Display the new form.
                FormFornecedorContatos.Show();
                FormFornecedorContatos.Top = 0;
                FormFornecedorContatos.Left = 0;
            }
        }

        private void funcionarioToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (FuncionarioPesquisa == 0)
            {
                MessageBox.Show("Acesso não Permitido!");
            }
            if (FuncionarioPesquisa == 1)
            {
                FecharTodosFormulario();
                FormPesquisaFuncionario Funcionario = new FormPesquisaFuncionario(this.FuncionarioVisualizar, this.FuncionarioEditar,
                this.FuncionarioExcluir,this.NomeServidor, this.NomeBaseDados, this.NomeUsuario, this.SenhaBaseDados);
                Funcionario.MdiParent = this;
                Funcionario.Show();
                Funcionario.Top = 0;
                Funcionario.Left = 0;
            }
        }

        private void pesquisaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        private void entrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FecharTodosFormulario();
            FormLoginUsuario FormClientesEntrarLogin = new FormLoginUsuario();
            // Set the Parent Form of the Child window.
            FormClientesEntrarLogin.MdiParent = this;
            // Display the new form.
            FormClientesEntrarLogin.Show();
            FormClientesEntrarLogin.Top = 0;
            FormClientesEntrarLogin.Left = 0;
        }

        private void usuárioDeAcessoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void loginESenhaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void usuárioDeAcessoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (ProdutoPesquisa == 0)
            {
                MessageBox.Show("Acesso não Permitido!");
            }
            if (ProdutoPesquisa == 1)
            {
                FecharTodosFormulario();
                FormPesquisaProduto FormClientesEntrarLogin = new FormPesquisaProduto(this.NomeServidor, this.NomeBaseDados, this.NomeUsuario,
                this.SenhaBaseDados,this.ProdutoVisualizar, this.ProdutoEditar, this.ProdutoExcluir);
                // Set the Parent Form of the Child window.
                FormClientesEntrarLogin.MdiParent = this;
                // Display the new form.
                FormClientesEntrarLogin.Show();
                FormClientesEntrarLogin.Top = 0;
                FormClientesEntrarLogin.Left = 0;
            }
        }
        private void osToolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void seniorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(SeniorSapiensAcesso == 0)
            {
                MessageBox.Show("Acesso não Permitido!");
            }
            if (SeniorSapiensAcesso == 1)
            {
                FecharTodosFormulario();

                FormLoginUsuarioSapiens FormFormSeniorSapiens = new FormLoginUsuarioSapiens(this.NomeServidor, this.NomeBaseDados, 
                this.NomeUsuario, this.SenhaBaseDados);
                // Set the Parent Form of the Child window.
                FormFormSeniorSapiens.Show();
                FormFormSeniorSapiens.Top = 0;
                FormFormSeniorSapiens.Left = 0;
            }
        }

        private void atualizaçãoVersão11ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FecharTodosFormulario();

            FormNovasAtualizacoesTelaPrincipal FormNovasAtualizacoesTelaPrincipalF = new FormNovasAtualizacoesTelaPrincipal(
            this.NomeServidor, this.NomeBaseDados, this.NomeUsuario, this.SenhaBaseDados,
            this.IdUsuarioAcesso);

            FormNovasAtualizacoesTelaPrincipalF.Show();
            FormNovasAtualizacoesTelaPrincipalF.Top = 0;
            FormNovasAtualizacoesTelaPrincipalF.Left = 0;

            //String S =
            //        "1 -> Imprementação para verificação de os em aberto e também que estejam em processos. \n" +
            //        "2 -> Uso manual e automático de busca por Cnpj em tempo real.\n" + "Versão Atual 1.2\n" +
            //        "3 ->Atalho de recursos F3 e F4. Permissão para Verificar Os abertas seja inicializada.\n" +
            //        "4 -> Botões abreviados: S = Salvar, C = Cancelar, F = Fechar, L = Limpar, \n" +
            //        "E = Editar, D = Deletar e T = Texto.   ";
            //MessageBox.Show(S, "DateSystem - Sempre tentando melhora.");
        }

        private void usuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FecharTodosFormulario();

            if (CriarDadosPessoas == 0)
            {
                MessageBox.Show("Acesso não Permitido!");
            }
            if (CriarDadosPessoas == 1)
            {
                FecharTodosFormulario();
                
                FormCadastraUsuario FormCadastraUsuario = new FormCadastraUsuario(this.CriarFuncionariosOs, this.CriarFuncionarioVendas, 
                    this.PermissaoFuncionarioRegistro, this.CriarFuncionarioProdutos, this.CriarUsuarioAcesso,this.CriarProposta,
                    this.PermissaoBaseDados, this.PermissaoNivelAcesso,
                    this.PermissaoCliente, this.PermissaoFornecedor, this.PermissaoFuncionarioOs, this.PermissaoFuncionarioVendedor,
                    this.PermissaoUsuarioAcesso,this.PermissaoSeniorSapiens, this.PermissaoFuncionarioRegistro, 
                    this.PermissaoFuncionarioProdutos,this.PermissaoProposta,
                    this.NomeServidor, this.NomeBaseDados, this.NomeUsuario, this.SenhaBaseDados, this.UsuarioAcessoAdm);
                        // Set the Parent Form of the Child window.
                        FormCadastraUsuario.MdiParent = this;
                        // Display the new form.
                        FormCadastraUsuario.Show();
                        FormCadastraUsuario.Top = 0;
                        FormCadastraUsuario.Left = 0;
            }
        }

        private void funcionarioToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FecharTodosFormulario();
            FormCadastraProdutos CadastraProdutos = new FormCadastraProdutos(this.NomeServidor, this.NomeBaseDados, this.NomeUsuario,
            this.SenhaBaseDados);
            // Set the Parent Form of the Child window.
            CadastraProdutos.MdiParent = this;
            // Display the new form.
            CadastraProdutos.Show();
            CadastraProdutos.Top = 0;
            CadastraProdutos.Left = 0;
            
        }

        private void geradasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (OsPesquisa == 0)
            {
                MessageBox.Show("Acesso não Permitido!");
            }
            if (OsPesquisa == 1)
            {
                FecharTodosFormulario();
                FormOSPesquisa OsPesquisa = new FormOSPesquisa(this.OsVisualizar, this.OsEditar, this.OsExcluir, this.IdUsuarioAcesso,
                this.ClienteCCadastra,
                    this.NomeServidor, this.NomeBaseDados, this.NomeUsuario, this.SenhaBaseDados);
                OsPesquisa.MdiParent = this;
                OsPesquisa.Show();
                OsPesquisa.Top = 0;
                OsPesquisa.Left = 0;
            }
        }

        private void corrigirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (OsExcluir == 0)
            {
                MessageBox.Show("Acesso não Permitido!");
            }
            if (OsExcluir == 1)
            {
                FecharTodosFormulario();
                FormOspesquisaNumerosLivres OsPesquisa = new FormOspesquisaNumerosLivres(this.NomeServidor, this.NomeBaseDados, this.NomeUsuario,
                this.SenhaBaseDados);
                OsPesquisa.MdiParent = this;
                OsPesquisa.Show();
                OsPesquisa.Top = 0;
                OsPesquisa.Left = 0;
            }
        }

        private void telaPrincipalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FecharTodosFormulario();

            FormConfiguracaoTelaPrincipal FormConfiguracaoTelaPrincipalP = new FormConfiguracaoTelaPrincipal(this.NomeServidor,
                this.NomeBaseDados, this.NomeUsuario, this.SenhaBaseDados, this.IdUsuarioAcesso, this.PermissaoCliente,
                this.VerificadorOs);
            // Set the Parent Form of the Child window.
            FormConfiguracaoTelaPrincipalP.MdiParent = this;
            // Display the new form.
            FormConfiguracaoTelaPrincipalP.Show();
            FormConfiguracaoTelaPrincipalP.Top = 0;
            FormConfiguracaoTelaPrincipalP.Left = 0;

        }

        private void FormPrincipal_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F3)
            {
                if (OsPesquisa == 0)
                {
                    MessageBox.Show("Acesso não Permitido!");
                }
                if (OsPesquisa == 1)
                {
                    FecharTodosFormulario();
                    FormOSPesquisa OsPesquisa = new FormOSPesquisa(this.OsVisualizar, this.OsEditar, this.OsExcluir, this.IdUsuarioAcesso,
                    this.ClienteCCadastra,
                        this.NomeServidor, this.NomeBaseDados, this.NomeUsuario, this.SenhaBaseDados);
                    OsPesquisa.MdiParent = this;
                    OsPesquisa.Show();
                    OsPesquisa.Top = 0;
                    OsPesquisa.Left = 0;
                }
            }
            if (e.KeyCode == Keys.F4)
            {
                if (OsCadastra == 0)
                {
                    MessageBox.Show("Acesso não Permitido!");
                }
                if (OsCadastra == 1)
                {
                    FecharTodosFormulario();
                    FormCadastroOsNovo CadastraOs = new FormCadastroOsNovo(this.IdUsuarioAcesso, this.NomeAcesso, this.NomeServidor,
                    this.NomeBaseDados, this.NomeUsuario, this.SenhaBaseDados);
                    CadastraOs.MdiParent = this;
                    CadastraOs.Show();
                    CadastraOs.Top = 0;
                    CadastraOs.Left = 0;
                }
            }

            //if(e.KeyCode == Keys.F5)
            // {
            //     FecharTodosFormulario();
            //     FormProdutoVenda CadastraOs = new FormProdutoVenda(this.NomeServidor, this.NomeBaseDados, this.NomeUsuario, this.SenhaBaseDados);
            //     CadastraOs.MdiParent = this;
            //     CadastraOs.Show();
            //     CadastraOs.Top = 0;
            //     CadastraOs.Left = 0;
            // }

            // Cadastra Novos Produtos no sistema-----------------------------
            //if (e.KeyCode == Keys.F2)
            //{
            //    FecharTodosFormulario();
            //    FormCadastraProdutos CadastraProdutos = new FormCadastraProdutos(this.NomeServidor, this.NomeBaseDados, this.NomeUsuario,
            //    this.SenhaBaseDados);
            //    // Set the Parent Form of the Child window.
            //    CadastraProdutos.MdiParent = this;
            //    // Display the new form.
            //    CadastraProdutos.Show();
            //    CadastraProdutos.Top = 0;
            //    CadastraProdutos.Left = 0;
            //}

            //Pesquisa Produtos Cadastrados----------------------
            //if (e.KeyCode == Keys.F2)
            //{
            //    FecharTodosFormulario();
            //    FormPesquisaProduto FormPesquisaProdutoP = new FormPesquisaProduto(this.NomeServidor, this.NomeBaseDados, this.NomeUsuario, this.SenhaBaseDados,
            //    this.PRODUTOVISUALIZAR, this.PRODUTOEDITAR, this.PRODUTOEXCLUIR);
            //    // Set the Parent Form of the Child window.
            //    FormPesquisaProdutoP.MdiParent = this;
            //    // Display the new form.
            //    FormPesquisaProdutoP.Show();
            //    FormPesquisaProdutoP.Top = 0;
            //    FormPesquisaProdutoP.Left = 0;
            //}


            //Cadastra produtos de Vendas----------------------------
            //if (e.KeyCode == Keys.F2)
            //{
            //    FecharTodosFormulario();
            //    FormProdutoVenda FormProdutoVendaV = new FormProdutoVenda(this.NomeServidor, this.NomeBaseDados, this.NomeUsuario, this.SenhaBaseDados);
            //    FormProdutoVendaV.MdiParent = this;
            //    FormProdutoVendaV.Show();
            //    FormProdutoVendaV.Top = 0;
            //    FormProdutoVendaV.Left = 0;

            //    FormularioAbertos();

            //    CadastraRegistro();
            //}

            // Cadastra Entrada de Estoque Produto-----------------------------
            //if (e.KeyCode == Keys.F2)
            //{
            //    FecharTodosFormulario();
            //    FormPontoDeVenda FormPontoDeVendaP = new FormPontoDeVenda(this.NomeServidor, this.NomeBaseDados, this.NomeUsuario,
            //    this.SenhaBaseDados);
            //    //CadastraRegistro.MdiParent = this;
            //    FormPontoDeVendaP.Show();
            //    FormPontoDeVendaP.Top = 100;
            //    FormPontoDeVendaP.Left = 100;
            //}

            // Cadastra Entrada de Estoque Produto / Controle de Estoque / Entrada-----------------------------
            //if (e.KeyCode == Keys.F2)
            //{
            //    FecharTodosFormulario();
            //    FormEntradaNoEstoque FormEntradaNoEstoqueP = new FormEntradaNoEstoque(this.NomeServidor, this.NomeBaseDados, this.NomeUsuario,
            //    this.SenhaBaseDados);
            //    //CadastraRegistro.MdiParent = this;
            //    FormEntradaNoEstoqueP.Show();
            //    FormEntradaNoEstoqueP.Top = 100;
            //    FormEntradaNoEstoqueP.Left = 100;
            //}

            // Cadastra Entrada de Estoque Produto-----------------------------
            //if (e.KeyCode == Keys.F2)
            //{
            //    FecharTodosFormulario();
            //    FormEntradaNoEstoque FormEntradaNoEstoqueP = new FormEntradaNoEstoque(this.NomeServidor, this.NomeBaseDados, this.NomeUsuario,
            //    this.SenhaBaseDados);
            //    //CadastraRegistro.MdiParent = this;
            //    FormEntradaNoEstoqueP.Show();
            //    FormEntradaNoEstoqueP.Top = 100;
            //    FormEntradaNoEstoqueP.Left = 100;
            //}
        }

        private void FormPrincipal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
            {
                DialogResult dialogResult = MessageBox.Show("Deseja Sair do Sistema!", "Aviso", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    Application.Exit();
                }
                else if (dialogResult == DialogResult.No)
                {

                }
            }
        }

        private void clientesVendasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FecharTodosFormulario();
            FormCadastraClienteV CadastraClienteV = new FormCadastraClienteV(this.NomeServidor, this.NomeBaseDados, this.NomeUsuario, 
            this.SenhaBaseDados);
            // Set the Parent Form of the Child window.
            CadastraClienteV.MdiParent = this;
            // Display the new form.
            CadastraClienteV.Show();
            CadastraClienteV.Top = 0;
            CadastraClienteV.Left = 0;
        }

        private void cadastrarToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FecharTodosFormulario();
            FormPesquisaClienteVenda FormPesquisaClienteVendaV = new FormPesquisaClienteVenda(this.ClienteVisualizar, this.ClienteEditar, 
            this.ClienteExcluir,
                this.NomeServidor, this.NomeBaseDados, this.NomeUsuario, this.SenhaBaseDados);
            // Set the Parent Form of the Child window.
            FormPesquisaClienteVendaV.MdiParent = this;
            // Display the new form.
            FormPesquisaClienteVendaV.Show();
            FormPesquisaClienteVendaV.Top = 0;
            FormPesquisaClienteVendaV.Left = 0;
        }

        private void produtoVendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FecharTodosFormulario();
            FormProdutoVenda CadastraOs = new FormProdutoVenda(this.NomeServidor, this.NomeBaseDados, this.NomeUsuario, this.SenhaBaseDados);
            CadastraOs.MdiParent = this;
            CadastraOs.Show();
            CadastraOs.Top = 0;
            CadastraOs.Left = 0;
        }

        private void clientesCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (RegistroCCadastra == 0)
            {
                MessageBox.Show("Acesso não Permitido!");
            }
            if (RegistroCCadastra == 1)
            {
                FecharTodosFormulario();

                FormCadastraClienteRegistro FormCadastraClienteRegistros = new FormCadastraClienteRegistro(this.NomeServidor, this.NomeBaseDados, this.NomeUsuario, this.SenhaBaseDados);
                // Set the Parent Form of the Child window.
                FormCadastraClienteRegistros.MdiParent = this;
                // Display the new form.
                FormCadastraClienteRegistros.Show();
                FormCadastraClienteRegistros.Top = 0;
                FormCadastraClienteRegistros.Left = 0;
            }
        }
        

        private void contatosCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (RegistroCCCadastra == 0)
            {
                MessageBox.Show("Acesso não Permitido!");
            }
            if (RegistroCCCadastra == 1)
            {
                FecharTodosFormulario();

                FormCadastraContatoRegistro FormCadastraContatoRegistros = new FormCadastraContatoRegistro(this.NomeServidor, this.NomeBaseDados, this.NomeUsuario, this.SenhaBaseDados);
                // Set the Parent Form of the Child window.
                FormCadastraContatoRegistros.MdiParent = this;
                // Display the new form.
                FormCadastraContatoRegistros.Show();
                FormCadastraContatoRegistros.Top = 0;
                FormCadastraContatoRegistros.Left = 0;
            }
        }

        private void processoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (RegistroCadastra == 0)
            {
                MessageBox.Show("Acesso não Permitido!");
            }
            if (RegistroCadastra == 1)
            {
                FecharTodosFormulario();
                FormCadastraRegistro CadastraRegistro = new FormCadastraRegistro(this.IdUsuarioAcesso, this.NomeAcesso, this.NomeServidor,
                this.NomeBaseDados, this.NomeUsuario, this.SenhaBaseDados, this.RegistroCCCadastra);
                CadastraRegistro.MdiParent = this;
                CadastraRegistro.Show();
                CadastraRegistro.Top = 0;
                CadastraRegistro.Left = 0;
            }
        }

        private void registroGerenciadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (RegistroPesquisa == 0)
            {
                MessageBox.Show("Acesso não Permitido!");
            }
            if (RegistroPesquisa == 1)
            {
                FecharTodosFormulario();
                FormPesquisaCadastraRegistro CadastraRegistro = new FormPesquisaCadastraRegistro(this, this.IdUsuarioAcesso, 
                    this.NomeAcesso, this.NomeServidor,this.NomeBaseDados, this.NomeUsuario, 
                    this.SenhaBaseDados,this.RegistroVisualizar,this.RegistroEditar,this.RegistroExcluir,
                    this.RegistroCadastra,this.RegistroCCCadastra);
                //CadastraRegistro.MdiParent = this;
                CadastraRegistro.Show();
                CadastraRegistro.Top = 0;
                CadastraRegistro.Left = 0;
            }            
        }
        public void CadastraRegistro()
        {
            try
            {
                FormCadastraRegistro CadastraRegistro = new FormCadastraRegistro(this.IdUsuarioAcesso, this.NomeAcesso, this.NomeServidor,
                this.NomeBaseDados, this.NomeUsuario, this.SenhaBaseDados, this.RegistroCCCadastra);
                //CadastraRegistro.MdiParent = this;
                CadastraRegistro.Show();
                CadastraRegistro.Top = 0;
                CadastraRegistro.Left = 0;
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
        }

        private void clienteRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (RegistroCPesquisa == 0)
            {
                MessageBox.Show("Acesso não Permitido!");
            }
            if (RegistroCPesquisa == 1)
            {
                FecharTodosFormulario();
                  FormPesquisaClienteRegistro FormPesquisaClienteRegistroR = new FormPesquisaClienteRegistro(this.RegistroVisualizar, this.RegistroEditar,
                this.RegistroExcluir, this.NomeServidor, this.NomeBaseDados, this.NomeUsuario, this.SenhaBaseDados);
                // Set the Parent Form of the Child window.
                FormPesquisaClienteRegistroR.MdiParent = this;
                // Display the new form.
                FormPesquisaClienteRegistroR.Show();
                FormPesquisaClienteRegistroR.Top = 0;
                FormPesquisaClienteRegistroR.Left = 0;
            }
        }

        private void contatoRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (RegistroCCPesquisa == 0)
            {
                MessageBox.Show("Acesso não Permitido!");
            }
            if (RegistroCCPesquisa == 1)
            {
                FecharTodosFormulario();
                FormPesquisaClientesRegistroContatos FormPesquisaClientesRegistroContatosR = new FormPesquisaClientesRegistroContatos(this.ClienteCVisualizar, this.ClienteCEditar,
                this.ClienteCExcluir, this.NomeServidor, this.NomeBaseDados, this.NomeUsuario, this.SenhaBaseDados);
                // Set the Parent Form of the Child window.
                FormPesquisaClientesRegistroContatosR.MdiParent = this;
                // Display the new form.
                FormPesquisaClientesRegistroContatosR.Show();
                FormPesquisaClientesRegistroContatosR.Top = 0;
                FormPesquisaClientesRegistroContatosR.Left = 0;
            }
        }

        private void razãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (UsuarioAcessoAdm == 0)
            {
                MessageBox.Show("Acesso não Permitido!");
            }
            if (UsuarioAcessoAdm == 1)
            {
                FecharTodosFormulario();
                FormAlteracaoStatusRS FormAlteracapStatusRSF = new FormAlteracaoStatusRS(this.NomeServidor, this.NomeBaseDados, this.NomeUsuario, this.SenhaBaseDados);
                // Set the Parent Form of the Child window.
                FormAlteracapStatusRSF.MdiParent = this;
                // Display the new form.
                FormAlteracapStatusRSF.Show();
                FormAlteracapStatusRSF.Top = 0;
                FormAlteracapStatusRSF.Left = 0;
            }
        }
    }
}
