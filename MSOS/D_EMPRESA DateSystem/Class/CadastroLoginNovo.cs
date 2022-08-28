using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateSystem
{
    class CadastroLoginNovo
    {
        public CadastroLoginNovo()
        {
            //PERMISSAO USUARIO
            this.IdCadastroLoginNovo = 0;
            this.NOME = "";
            this.USUARIO = "";
            this.SENHA = "";
            this.CONFIRMASENHA = "";
            this.OBSERVACACAO = "";
            this.SITUACAO = 0;
            this.USUARIOACESSSO = 0;
            this.ID_ACESSO_BASE_DADOS = 0;

            this.USUARIOCRIAR = 0;
            this.USUARIOALTERAR = 0;
            this.USUARIOEXCLUIR = 0;
            this.USUARIOPESQUISA = 0;
            this.USUARIOVISUALIZAR = 0;
            //PERMISSA CLIENTE
            this.CLIENTECADASTRA = 0;
            this.CLIENTEPESQUISA = 0;
            this.CLIENTEVISUALIZAR = 0;
            this.CLIENTEEDITAR = 0;
            this.CLIENTEEXCLUIR = 0;
            this.CLIENTECCADASTRA = 0;
            this.CLIENTECPESQUISA = 0;
            this.CLIENTECVISUALIZAR = 0;
            this.CLIENTECEDITAR = 0;
            this.CLIENTECEXCLUIR = 0;
            //PERMISSAO FORNECEDOR
            this.FORNECEDORCADASTRA = 0;
            this.FORNECEDORPESQUISA = 0;
            this.FORNECEDORVISUALIZAR = 0;
            this.FORNECEDOREDITAR = 0;
            this.FORNECEDOREXCLUIR = 0;
            this.FORNECEDORCCADASTRA = 0;
            this.FORNECEDORCPESQUISA = 0;
            this.FORNECEDORCVISUALIZAR = 0;
            this.FORNECEDORCEDITAR = 0;
            this.FORNECEDORCEXCLUIR = 0;
            //PERMISSA FUNCIOANRIO
            this.FUNCIONARIOCADASTRA = 0;
            this.FUNCIONARIORPESQUISA = 0;
            this.FUNCIONARIOVISUALIZAR = 0;
            this.FUNCIONARIOEDITAR = 0;
            this.FUNCIONARIOEXCLUIR = 0;
            //PERMISSAO OS
            this.OSCADASTRA = 0;
            this.OSPESQUISA = 0;
            this.OSVISUALIZAR = 0;
            this.OSEDITAR = 0;
            this.OSEXCLUIR = 0;
            //PERMISSAO SENIOR SAPIENS
            this.SENIORSAPIENSACESSO = 0;
            this.SENIORSAPIENSPESQUISA = 0;
            this.SENIORSAPIENSEXCLUIR = 0;
            //PERMISSAO VENDEDOR
            this.VendedorCadastra = 0;
            this.VendedorPesquisa = 0;
            this.VendedorVisualizar = 0;
            this.VendedorExcluir = 0;
            //PERMISSAO REGISTRO
            this.RegistroCCadastra = 0;
            this.RegistroCPesquisa = 0;
            this.RegistroCVisualizar = 0;
            this.RegistroCEditar = 0;
            this.RegistroCExcluir = 0;
            this.RegistroCCCadastra = 0;
            this.RegistroCCPesquisa = 0;
            this.RegistroCCVisualizar = 0;
            this.RegistroCCEditar = 0;
            this.RegistroCCExcluir = 0;
            this.RegistroCadastra = 0;
            this.RegistroPesquisa = 0;
            this.RegistroVisualizar = 0;
            this.RegistroEditar = 0;
            this.RegistroExcluir = 0;
            //PERMISSAO NIVEIS
            this.PermissaoBasedados = 0;
            this.PermissaoNivelaAcesso = 0;
            this.PermissaoCliente = 0;
            this.PermissaoFornecedor = 0;
            this.PermissaoFuncionarioOs = 0;
            this.PermissaoFuncionarioVendedor = 0;
            this.PermissaoFuncionarioProdutos = 0;
            this.PermissaoUsuarioAcesso = 0;
            this.PermissaoOs = 0;
            this.PermissaoSeniorSapiens = 0;
            this.PermissaoRegistro = 0;
            this.PermissaoProposta = 0;
            //CRIAR CONTAS
            this.CriarDadosPessoas = 0;
            this.CriarFuncionarioOs = 0;
            this.CriarFuncionarioVendas = 0;
            this.CriarFuncionarioProdutos = 0;
            this.CriarFuncionarioRegistro = 0;
            this.CriarProposta = 0;
            this.CriarUsuarioAcesso = 0;
            //PERMISSAO PRODUTOS
            this.ProdutosCadastra = 0;
            this.ProdutosPesquisa = 0;
            this.ProdutosVisualizar = 0;
            this.ProdutosExcluir = 0;
            //PERMISSAO PROPOSTA
            this.PropostaCadastra = 0;
            this.PropostaPesquisa = 0;
            this.PropostaVisualizar = 0;
            this.PropostaExcluir = 0;
            //ATUALIZACAO TELA PRINCIPAL
            this.AtualicazaoTelaPrincipal = 0;
            //VERIFICADOR OS
            this.VerificadorOs = 0;

        }
        public CadastroLoginNovo(int IDCADASTROLOGINNOVO, string NOME, string ABREVIACAO, string USUARIO, string SENHA, string CONFIRMACAOSENHA, string OBSERVACAO,int SITUACAO,int USUARIOACESSO, int ID_ACESSO_BASE_DADOS,
            int USUARIOCRIAR, int USUARIOALTERAR, int USUARIOEXCLUIR, int USUARIOPESQUISA,int USUARIOVISUALIZAR,
            int CLIENTECADASTRA, int CLIENTEPESQUISA, int CLIENTEVISUALIZAR, int CLIENTEEDITAR, int CLIENTEEXCLUIR,
            int CLIENTECCADASTRA, int CLIENTECPESQUISA, int CLIENTECVISUALIZAR, int CLIENTECEDITAR, int CLIENTECEXCLUIR,
            int FORNECEDORCADASTRA, int FORNECEDORPESQUISA, int FORNECEDORVISUALIZAR, int FORNECEDOREDITAR, int FORNECEDOREXCLUIR,
            int FORNECEDORCCADASTRA, int FORNECEDORCPESQUISA, int FORNECEDORCVISUALIZAR, int FORNECEDORCEDITAR, int FORNECEDORCEXCLUIR,
            int FUNCIONARIOCADASTRA, int FUNCIONARIORPESQUISA, int FUNCIONARIOVISUALIZAR, int FUNCIONARIOEDITAR, int FUNCIONARIOEXCLUIR,
            int OSCADASTRA, int OSPESQUISA, int OSVISUALIZAR, int OSEDITAR, int OSEXCLUIR, int SENIORSAPIENSACESSO, int SENIORSAPIENSPESQUISA, int SENIORSAPIENSEXCLUIR,
            int VENDEDORCADASTRA, int VENDEDORPESQUISA, int VENDEDORVISUALIZAR, int VENDEDOREXCLUIR,
            int REGISTROCCADASTRA, int REGISTROCPESQUISA, int REGISTROCVISUALIZAR, int REGISTROCEXCLUIR,
            int REGISTROCCCADASTRA, int REGISTROCCPESQUISA, int REGISTROCCVISUALIZAR, int REGISTROCCEXCLUIR,
            int REGISTROCADASTRA, int REGISTROPESQUISA, int REGISTROVISUALIZAR, int REGISTROEXCLUIR,
            int PRODUTOSCADASTRA, int PRODUTOSPESQUISA, int PRODUTOSVISUALIZAR, int PRODUTOSEXCLUIR,
            int PROPOSTACADASTRA, int PROPOSTAPESQUISA, int PROPOSTAVISUALIZAR, int PROPOSTAEXCLUIR,
            int CRIARPROPOSTA, int PERMISSAOPROPOSTA,
            int PERMISSAOBASEDADOS, int PERMISSAONIVELACESSO, int PERMISSAOCLIENTE,
            int PERMISSAOFORNECEDOR, int PERMISSAOFUNCIONARIOOS, int PERMISSAOFUNCIONARIOVENDEDOR,int PERMISSAOFUNCIONARIOPRODUTOS,
            int PERMISSAOUSUARIOACESSO,int PERMISSAOOS, int PERMISSAOSENIORSAPIENS, int PERMISSAOREGISTRO,
            int CRIADADOSPESSOA, int CRIARFUNCIONARIOOS,int CRIARFUNCIONARIOVENDAS, int CRIARFUNIONARIOPRODUTOS, int CRIARFUNIONARIOREGISTRO, int CRIARUSUARIOACESSO,
            int ATUALIZACAOTELAPRINCIPAL, int  VERIFICADOROS)
        {
            //PERMISSAO USUARIO
            IdCadastroLoginNovo = IdCadastroLoginNovo;
            Nome = NOME;
            Senha = SENHA;
            ConfirmaSenha = CONFIRMACAOSENHA;
            Observacao = OBSERVACACAO;
            Situacao = SITUACAO;
            UsuarioAcesso = USUARIOACESSO;
            IdAcessoBaseDados = ID_ACESSO_BASE_DADOS;

            UsuarioCriar = USUARIOCRIAR;
            UsuarioAlterar = USUARIOALTERAR;
            UsuarioExcluir = USUARIOEXCLUIR;
            UsuarioPesquisa = USUARIOPESQUISA;
            UsuarioVisualizar = USUARIOVISUALIZAR;

            //PERMISSA CLIENTE
            ClienteCadastra = CLIENTECADASTRA;
            ClientePesquisa = CLIENTEPESQUISA;
            ClienteVisualizar = CLIENTEVISUALIZAR;
            ClienteEditar = CLIENTEEDITAR;
            ClienteExcluir = CLIENTEEXCLUIR;
            ClienteCCadastra = CLIENTECCADASTRA;
            ClienteCPesquisa = CLIENTECPESQUISA;
            ClienteCVisualizar = CLIENTECVISUALIZAR;
            ClienteCEditar = CLIENTECEDITAR;
            ClienteCExcluir = CLIENTECEXCLUIR;
            //PERMISSAO FORNECEDOR
            FornecedorCadastra = FORNECEDORCADASTRA;
            FornecedorPesquisa = FORNECEDORPESQUISA;
            FornecedorVisualizar = FORNECEDORVISUALIZAR;
            FornecedorEditar = FORNECEDOREDITAR;
            FornecedorExcluir = FORNECEDOREXCLUIR;
            FornecedorCCadastra = FORNECEDORCCADASTRA;
            FornecedorCPesquisa = FORNECEDORCPESQUISA;
            FornecedorCVisualizar = FORNECEDORCVISUALIZAR;
            FornecedorCEditar = FORNECEDORCEDITAR;
            FornecedorcExcluir = FORNECEDORCEXCLUIR;
            //PERMISSA FUNCIOANRIO
            FuncionarioCadastra = FUNCIONARIOCADASTRA;
            FuncionarioPesquisa = FUNCIONARIORPESQUISA;
            FuncionarioVisualizar = FUNCIONARIOVISUALIZAR;
            FuncionarioEditar = FUNCIONARIOEDITAR;
            FuncionarioExcluir = FUNCIONARIOEXCLUIR;
            //PERMISSAO OS
            OsCadastra = OSCADASTRA;
            OsPesquisa = OSPESQUISA;
            OsVisualizar = OSVISUALIZAR;
            OsEditar = OSEDITAR;
            OsExcluir = OSEXCLUIR;
            //PERMISSA SENIOR SAPIENS
            SeniorSapiensAcesso = SENIORSAPIENSACESSO;
            SeniorSapiensPesquisa = SENIORSAPIENSPESQUISA;
            SeniorSapiensExcluir = SENIORSAPIENSEXCLUIR;
            //PERMISSAO VENDEDOR
            VendedorCadastra = VENDEDORCADASTRA;
            VendedorPesquisa = VENDEDORPESQUISA;
            VendedorVisualizar = VENDEDORVISUALIZAR;
            VendedorExcluir = VENDEDOREXCLUIR;
            //PERMISSAO REGISTRO
            RegistroCCadastra = REGISTROCCADASTRA;
            RegistroCPesquisa = REGISTROCPESQUISA;
            RegistroCVisualizar = REGISTROCVISUALIZAR;
            RegistroCExcluir = REGISTROCEXCLUIR;
            RegistroCCCadastra = REGISTROCCCADASTRA;
            RegistroCCPesquisa = REGISTROCCPESQUISA;
            RegistroCCVisualizar = REGISTROCCVISUALIZAR;
            RegistroCCExcluir = REGISTROCEXCLUIR;
            RegistroCadastra = REGISTROCADASTRA;
            RegistroPesquisa = REGISTROPESQUISA;
            RegistroVisualizar = REGISTROVISUALIZAR;
            RegistroExcluir = REGISTROEXCLUIR;
            //PERMISSAO PRODUTOS
            ProdutosCadastra = PRODUTOSCADASTRA;
            ProdutosPesquisa = PRODUTOSPESQUISA;
            ProdutosVisualizar = PRODUTOSVISUALIZAR;
            ProdutosExcluir = PRODUTOSEXCLUIR;
            //PERMISSAO PROPOSTA
            PropostaCadastra = PROPOSTACADASTRA;
            PropostaPesquisa = PROPOSTAPESQUISA;
            PropostaVisualizar = PROPOSTAVISUALIZAR;
            PropostaExcluir = PROPOSTAEXCLUIR;
            //PERMISSAO NIVEIS
            PermissaoBasedados = PERMISSAOBASEDADOS;
            PermissaoNivelaAcesso = PERMISSAONIVELACESSO;
            PermissaoCliente = PERMISSAOCLIENTE;
            PermissaoFornecedor = PERMISSAOFORNECEDOR;
            PermissaoFuncionarioOs = PERMISSAOFUNCIONARIOOS;
            PermissaoFuncionarioVendedor = PERMISSAOFUNCIONARIOVENDEDOR;
            PermissaoFuncionarioProdutos = PERMISSAOFUNCIONARIOPRODUTOS;
            PermissaoUsuarioAcesso = PERMISSAOUSUARIOACESSO;
            PermissaoOs = PERMISSAOOS;
            PermissaoSeniorSapiens = PERMISSAOSENIORSAPIENS;
            PermissaoRegistro = PERMISSAOREGISTRO;
            PermissaoProposta = PERMISSAOPROPOSTA;
            //CRIAR CONTAS
            this.CriarDadosPessoas = CRIADADOSPESSOA;
            this.CriarFuncionarioOs = CRIARFUNCIONARIOOS;
            this.CriarFuncionarioVendas = CRIARFUNCIONARIOVENDAS;
            this.CriarFuncionarioProdutos = CRIARFUNIONARIOPRODUTOS;
            this.CriarFuncionarioRegistro = CRIARFUNIONARIOREGISTRO;
            this.CriarProposta = CRIARPROPOSTA;
            this.CriarUsuarioAcesso = CRIARUSUARIOACESSO;

            //ATUALIZACAO TELA PRINCIPAL
            this.AtualicazaoTelaPrincipal = ATUALIZACAOTELAPRINCIPAL;
            // VERIFICADOR DE OS
            this.VerificadorOs = VERIFICADOROS;

        }
        private int IDCADASTROLOGINNOVO;
        public int IdCadastroLoginNovo
        {
            get
            {
                return this.IDCADASTROLOGINNOVO;

            }
            set
            {
                this.IDCADASTROLOGINNOVO = value;
            }
        }
        private string NOME;
        public string Nome
        {
            get
            {
                return this.NOME;

            }
            set
            {
                this.NOME = value;
            }
        }
        private string USUARIO;
        public string Usuario
        {
            get
            {
                return this.USUARIO;

            }
            set
            {
                this.USUARIO = value;
            }
        }
        private string SENHA;
        public string Senha
        {
            get
            {
                return this.SENHA;

            }
            set
            {
                this.SENHA = value;
            }
        }
        private string CONFIRMASENHA;
        public string ConfirmaSenha
        {
            get
            {
                return this.CONFIRMASENHA;

            }
            set
            {
                this.CONFIRMASENHA = value;
            }
        }
        private string OBSERVACACAO;
        public string Observacao
        {
            get
            {
                return this.OBSERVACACAO;

            }
            set
            {
                this.OBSERVACACAO = value;
            }
        }
        private int SITUACAO;
        public int Situacao
        {
            get
            {
                return this.SITUACAO;

            }
            set
            {
                this.SITUACAO = value;
            }
        }
        private int USUARIOACESSSO;
        public int UsuarioAcesso
        {
            get
            {
                return this.USUARIOACESSSO;

            }
            set
            {
                this.USUARIOACESSSO = value;
            }
        }
        private int ID_ACESSO_BASE_DADOS;
        public int IdAcessoBaseDados
        {
            get
            {
                return this.ID_ACESSO_BASE_DADOS;

            }
            set
            {
                this.ID_ACESSO_BASE_DADOS = value;
            }
        }
        //PERMISSAO DO USUARIO----------------------------------------------------------------------------
        private int USUARIOCRIAR;
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
        private int USUARIOALTERAR;
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
        private int USUARIOEXCLUIR;
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
        private int USUARIOPESQUISA;
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
        private int USUARIOVISUALIZAR;
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
        //PERMISSÃO DO CLIENTE---------------------------------------------
        private int CLIENTECADASTRA;
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
        private int CLIENTEPESQUISA;
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
        private int CLIENTEVISUALIZAR;
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
        private int CLIENTEEDITAR;
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
        private int CLIENTEEXCLUIR;
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
        //PERMISSÃO DO CLIENTE CONTATOS---------------------------------------------
        private int CLIENTECCADASTRA;
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
        private int CLIENTECPESQUISA;
        public int ClienteCPesquisa
        {
            get
            {
                return this.CLIENTECPESQUISA;

            }
            set
            {
                this.CLIENTECPESQUISA = value;
            }
        }
        private int CLIENTECVISUALIZAR;
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
        private int CLIENTECEDITAR;
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
        private int CLIENTECEXCLUIR;
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
        //PERMISSÃO DO FORNECEDOR---------------------------------------------
        private int FORNECEDORCADASTRA;
        public int FornecedorCadastra
        {
            get
            {
                return this.FORNECEDORCADASTRA;

            }
            set
            {
                this.FORNECEDORCADASTRA = value;
            }
        }
        private int FORNECEDORPESQUISA;
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
        private int FORNECEDORVISUALIZAR;
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
        private int FORNECEDOREDITAR;
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
        private int FORNECEDOREXCLUIR;
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
        //PERMISSÃO DO FORNECEDOR CONTATOS---------------------------------------------
        private int FORNECEDORCCADASTRA;
        public int FornecedorCCadastra
        {
            get
            {
                return this.FORNECEDORCCADASTRA;

            }
            set
            {
                this.FORNECEDORCCADASTRA = value;
            }
        }
        private int FORNECEDORCPESQUISA;
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
        private int FORNECEDORCVISUALIZAR;
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
        private int FORNECEDORCEDITAR;
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
        private int FORNECEDORCEXCLUIR;
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
        //PERMISSÃO DO FUNCIONÁRIO---------------------------------------------
        private int FUNCIONARIOCADASTRA;
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
        private int FUNCIONARIORPESQUISA;
        public int FuncionarioPesquisa
        {
            get
            {
                return this.FUNCIONARIORPESQUISA;

            }
            set
            {
                this.FUNCIONARIORPESQUISA = value;
            }
        }
        private int FUNCIONARIOVISUALIZAR;
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
        private int FUNCIONARIOEDITAR;
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
        private int FUNCIONARIOEXCLUIR;
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
        //PERMISSÃO DA OS---------------------------------------------
        private int OSCADASTRA;
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
        private int OSPESQUISA;
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
        private int OSVISUALIZAR;
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
        private int OSEDITAR;
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
        private int OSEXCLUIR;
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
        //PERMISSÃO SENIOR
        private int SENIORSAPIENSACESSO;
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
        private int SENIORSAPIENSPESQUISA;
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
        private int SENIORSAPIENSEXCLUIR;
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
        //PERMISSÃO DA VENDEDOR---------------------------------------------
        private int VENDEDORCADASTRA;
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
        private int VENDEDORPESQUISA;
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
        private int VENDEDORVISUALIZAR;
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
        private int VENDEDOREDITAR;
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
        private int VENDEDOREXCLUIR;
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
        //PERMISSÃO CADASTRA CLIENTE REGISTRO---------------------------------------------
        private int REGISTROCCADASTRA;
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
        private int REGISTROCPESQUISA;
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
        private int REGISTROCVISUALIZAR;
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
        private int REGISTROCEDITAR;
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
        private int REGISTROCEXCLUIR;
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
        //PERMISSÃO CADASTRA CONTATOS DE CLIENTES REGISTRO---------------------------------------------
        private int REGISTROCCCADASTRA;
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
        private int REGISTROCCPESQUISA;
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
        private int REGISTROCCVISUALIZAR;
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
        private int REGISTROCCEDITAR;
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
        private int REGISTROCCEXCLUIR;
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
        //PERMISSÃO DA GERAÇÃO DE NOVOS REGISTROS---------------------------------------------
        private int REGISTROCADASTRA;
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
        private int REGISTROPESQUISA;
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
        private int REGISTROSVISUALIZAR;
        public int RegistroVisualizar
        {
            get
            {
                return this.REGISTROSVISUALIZAR;
            }
            set
            {
                this.REGISTROSVISUALIZAR = value;
            }
        }
        private int REGISTROEDITAR;
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
        private int REGISTROEXCLUIR;
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
        //PERMISSÃO DA PRODUTOS---------------------------------------------
        private int PRODUTOSCADASTRA;
        public int ProdutosCadastra
        {
            get
            {
                return this.PRODUTOSCADASTRA;

            }
            set
            {
                this.PRODUTOSCADASTRA = value;
            }
        }
        private int PRODUTOSPESQUISA;
        public int ProdutosPesquisa
        {
            get
            {
                return this.PRODUTOSPESQUISA;

            }
            set
            {
                this.PRODUTOSPESQUISA = value;
            }
        }
        private int PRODUTOSVISUALIZAR;
        public int ProdutosVisualizar
        {
            get
            {
                return this.PRODUTOSVISUALIZAR;
            }
            set
            {
                this.PRODUTOSVISUALIZAR = value;
            }
        }
        private int PRODUTOSEDITAR;
        public int ProdutosEditar
        {
            get
            {
                return this.PRODUTOSEDITAR;

            }
            set
            {
                this.PRODUTOSEDITAR = value;
            }
        }
        private int PRODUTOSEXCLUIR;
        public int ProdutosExcluir
        {
            get
            {
                return this.PRODUTOSEXCLUIR;

            }
            set
            {
                this.PRODUTOSEXCLUIR = value;
            }
        }
        //PERMISSÃO DA PROPOSTA---------------------------------------------
        private int PROPOSTACADASTRA;
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
        private int PROPOSTAPESQUISA;
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
        private int PROPOSTAVISUALIZAR;
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
        private int PROPOSTAEDITAR;
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
        private int PROPOSTAEXCLUIR;
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
        //PERMISSÃO DA PERMISSOES DE NIVEL---------------------------------------------
        private int PERMISSAOBASEDADOS;
        public int PermissaoBasedados
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
        private int PERMISSAONIVELACESSO;
        public int PermissaoNivelaAcesso
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
        private int PERMISSAOCLIENTE;
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
        private int PERMISSAOFORNECEDOR;
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
        private int PERMISSAOFUNCIONARIOOS;
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
        private int PERMISSAOFUNCIONARIOVENDEDOR;
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
        private int PERMISSAOFUNCIONARIOPRODUTOS;
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
        private int PERMISSAOUSUARIOACESSO;
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
        private int PERMISSAOOS;
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
        private int PERMISSAOSENIORSAPIENS;
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
        private int PERMISSAOREGISTRO;
        public int PermissaoRegistro
        {
            get
            {
                return this.PERMISSAOREGISTRO;

            }
            set
            {
                this.PERMISSAOREGISTRO = value;
            }
        }
        private int PERMISSAOPROPOSTA;
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

        //PERMISSÃO DE CRIAR CONTAS--------------------------------------------------
        private int CRIARDADOSPESSOAS;
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
        private int CRIARFUNCIONAIOOS;
        public int CriarFuncionarioOs
        {
            get
            {
                return this.CRIARFUNCIONAIOOS;

            }
            set
            {
                this.CRIARFUNCIONAIOOS = value;
            }
        }
        private int CRIARFUNCIONARIOVENDAS;
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
        private int CRIARFUNCIONARIOPRODUTOS;
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
        private int CRIARFUNCIONARIOREGISTRO;
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
        private int CRIARPROPOSTA;
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
        private int CRIARUSUARIOACESSO;
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
        private int ATUALIZACAOTELAPRINCIPAL;
        public int AtualicazaoTelaPrincipal
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
        private int VERIFICADOROS;
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
    }
}
