using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateSystem
{
    class CadastradoClienteVendaComplementos
    {
        public CadastradoClienteVendaComplementos()
        {
            this.idPessoa = 0;
            this.Filiacao = "";
            this.ReferenciaComercias = "";
            this.ReferenciaBancaria = "";
            this.IdTipoCliente = 0;
            this.TipoDeCliente = "";
            this.LimiteCredito = "";
            this.IdVendedor = 0;
            this.DataCadastro = "";
            this.BloqueioAtendimentoCliente = "";
            this.CorreioEletronico = "";
            this.PaginaWeb = "";
            this.IdRetencaoTributos = 0;
            this.IdCartaoCredito = 0;
            this.NumeroCartao = "";
            this.ValidadeCartao = "";
            this.NomeImpresso = "";
            this.IdClienteConheceuEmpresa = 0;
            this.IdClienteFoto = 0;

        }
        public CadastradoClienteVendaComplementos(int ID_PESSOA, string FILIACAO, string REFERENCIA_COMERCIAS, string REFERENCIA_BANCARIA,
            int ID_TIPO_CLIENTE, string TIPO_DE_CLIENTE, string LIMITE_CREDITO, int ID_VENDEDOR, string DATA_CADASTRO, 
            string BLOQUEIO_ATENDIMENTO_CLIENTE, string CORREIO_ELETRONICO, string PAGINAWEB, int ID_RETENCAO_TRIBUTOS, 
            int ID_CARTAO_CREDITO, string NUMERO_CARTAO, string VALIDADE_CARTAO, string NOME_IMPRESSO, int ID_CLIENTE_CONHECEU_EMPRESA
            , int ID_CLIENTE_FOTO)
        {
            this.idPessoa = ID_PESSOA;
            this.Filiacao = FILIACAO;
            this.ReferenciaComercias = REFERENCIA_COMERCIAS;
            this.ReferenciaBancaria = REFERENCIA_BANCARIA;
            this.IdTipoCliente = ID_TIPO_CLIENTE;
            this.TipoDeCliente = TIPO_DE_CLIENTE;
            this.LimiteCredito = LIMITE_CREDITO;
            this.IdVendedor = ID_VENDEDOR;
            this.DataCadastro = DATA_CADASTRO;
            this.BloqueioAtendimentoCliente = BLOQUEIO_ATENDIMENTO_CLIENTE;
            this.CorreioEletronico = CORREIO_ELETRONICO;
            this.PaginaWeb = PAGINAWEB;
            this.IdRetencaoTributos = ID_RETENCAO_TRIBUTOS;
            this.IdCartaoCredito = ID_CARTAO_CREDITO;
            this.NumeroCartao = NUMERO_CARTAO;
            this.ValidadeCartao = VALIDADE_CARTAO;
            this.NomeImpresso = NOME_IMPRESSO;
            this.IdClienteConheceuEmpresa = ID_CLIENTE_CONHECEU_EMPRESA;
            this.IdClienteFoto = ID_CLIENTE_FOTO;
        }

        private int ID_PESSOA;
        public int idPessoa
        {
            get
            {
                return this.ID_PESSOA;

            }
            set
            {
                this.ID_PESSOA = value;
            }
        }

        private string FILIACAO;
        public string Filiacao
        {
            get
            {
                return this.FILIACAO;
            }
            set
            {
                this.FILIACAO = value;
            }
        }

        private string REFERENCIA_COMERCIAS;
        public string ReferenciaComercias
        {
            get
            {
                return this.REFERENCIA_COMERCIAS;
            }
            set
            {
                this.REFERENCIA_COMERCIAS = value;
            }
        }
        private string REFERENCIA_BANCARIA;
        public string ReferenciaBancaria
        {
            get
            {
                return this.REFERENCIA_BANCARIA;
            }
            set
            {
                this.REFERENCIA_BANCARIA = value;
            }
        }
        private int ID_TIPO_CLIENTE;
        public int IdTipoCliente
        {
            get
            {
                return this.ID_TIPO_CLIENTE;
            }
            set
            {
                this.ID_TIPO_CLIENTE = value;
            }
        }
        private string TIPO_DE_CLIENTE;
        public string TipoDeCliente
        {
            get
            {
                return this.TIPO_DE_CLIENTE;
            }
            set
            {
                this.TIPO_DE_CLIENTE = value;
            }
        }
        private string LIMITE_CREDITO;
        public string LimiteCredito
        {
            get
            {
                return this.LIMITE_CREDITO;
            }
            set
            {
                this.LIMITE_CREDITO = value;
            }
        }
        private int ID_VENDEDOR;
        public int IdVendedor
        {
            get
            {
                return this.ID_VENDEDOR;
            }
            set
            {
                this.ID_VENDEDOR = value;
            }
        }
        private string DATA_CADASTRO;
        public string DataCadastro
        {
            get
            {
                return this.DATA_CADASTRO;
            }
            set
            {
                this.DATA_CADASTRO = value;
            }
        }
        private string BLOQUEIO_ATENDIMENTO_CLIENTE;
        public string BloqueioAtendimentoCliente
        {
            get
            {
                return this.BLOQUEIO_ATENDIMENTO_CLIENTE;
            }
            set
            {
                this.BLOQUEIO_ATENDIMENTO_CLIENTE = value;
            }
        }
        private string CORREIO_ELETRONICO;
        public string CorreioEletronico
        {
            get
            {
                return this.CORREIO_ELETRONICO;
            }
            set
            {
                this.CORREIO_ELETRONICO = value;
            }
        }
        private string PAGINA_WEB;
        public string PaginaWeb
        {
            get
            {
                return this.PAGINA_WEB;
            }
            set
            {
                this.PAGINA_WEB = value;
            }
        }
        private int ID_RETENCAO_TRIBUTOS;
        public int IdRetencaoTributos
        {
            get
            {
                return this.ID_RETENCAO_TRIBUTOS;
            }
            set
            {
                this.ID_RETENCAO_TRIBUTOS = value;
            }
        }
        private int ID_CARTAO_CREDITO;
        public int IdCartaoCredito
        {
            get
            {
                return this.ID_CARTAO_CREDITO;
            }
            set
            {
                this.ID_CARTAO_CREDITO = value;
            }
        }
        private string NUMERO_CARTAO;
        public string NumeroCartao
        {
            get
            {
                return this.NUMERO_CARTAO;
            }
            set
            {
                this.NUMERO_CARTAO = value;
            }
        }
        private string VALIDADE_CARTAO;
        public string ValidadeCartao
        {
            get
            {
                return this.VALIDADE_CARTAO;
            }
            set
            {
                this.VALIDADE_CARTAO = value;
            }
        }
        private string NOME_IMPRESSO;
        public string NomeImpresso
        {
            get
            {
                return this.NOME_IMPRESSO;
            }
            set
            {
                this.NOME_IMPRESSO = value;
            }
        }
        private int ID_CLIENTE_CONHECEU_EMPRESA;
        public int IdClienteConheceuEmpresa
        {
            get
            {
                return this.ID_CLIENTE_CONHECEU_EMPRESA;
            }
            set
            {
                this.ID_CLIENTE_CONHECEU_EMPRESA = value;
            }
        }
        private int ID_CLIENTE_FOTO;
        public int IdClienteFoto
        {
            get
            {
                return this.ID_CLIENTE_FOTO;
            }
            set
            {
                this.ID_CLIENTE_FOTO = value;
            }
        }
    }
}
