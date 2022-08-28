using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateSystem
{
    class Pessoa
    {
        public Pessoa()
        {
            this.idPessoa = 0;
            this.IdPessoaTipo = 0;
            this.IdCidade = 0;
            this.IdCompra = 0;
            this.IdContatos = 0;
            this.IdMs = 0;
            this.IdOs = 0;
            this.idCep = 0;
            this.Situacao = 0;
            this.Nome = "";
            this.TipoLogradouro = "";
            this.Endereco = "";
            this.Numero = 0;
            this.COMPLEMENTO = "";
            this.Telefone = "";
            this.Telefone2 = "";
            this.FaxTelefone = "";
            this.TelexTelefone = "";
            this.Bairro = "";
            this.Cidade = "";
            this.SiglaCidade = "";
            this.Email = "";
            this.Cep = 0;
            this.Observacao = "";
            this.Tipo = "";
            this.CpMunicipio = "";
            this.Municipio = "";
            this.Pais = "";
            this.DesPais = "";
        }
        public Pessoa(int ID_PESSOA, int ID_PESSOA_TIPO, int ID_CIDADE, int ID_COMPRA, int ID_CONTATOS, int ID_MS, int ID_OS, int IDCEP, int SITUACAO, string NOME, string TIPO_LOGRADOURO, string ENDERECO,
            int NUMERO, string COMPLEMENTO, string TELEFONE, string TELEFONE2, string FAX_TELEFONE, string TELEX_TELEFONE, string BAIRRO, string CIDADE, String SIGLA_CIDADE, string EMAIL,
            int CEP, string OBSERVACAO, string TIPO, string CP_MUNICIPIO, string MUNICIPIO, string PAIS, string DESC_PAIS)
        {

            this.idPessoa = ID_PESSOA;
            this.IdPessoaTipo = ID_PESSOA_TIPO;
            this.IdCidade = ID_CIDADE;
            this.IdCompra = ID_COMPRA;
            this.IdContatos = ID_CONTATOS;
            this.IdMs = ID_MS;
            this.IdOs = ID_OS;
            this.idCep = ID_CEP;
            this.Situacao = SITUACAO;
            this.Nome = NOME;
            this.TipoLogradouro = TIPO_LOGRADOURO;
            this.Endereco = ENDERECO;
            this.Numero = NUMERO;
            this.Complemento = COMPLEMENTO;
            this.Telefone = TELEFONE;
            this.Telefone2 = TELEFONE2;
            this.FaxTelefone = FAX_TELEFONE;
            this.TelexTelefone = TELEX_TELEFONE;
            this.Bairro = BAIRRO;
            this.Bairro = CIDADE;
            this.SiglaCidade = SIGLA_CIDADE;
            this.Email = EMAIL;
            this.Cep = CEP;
            this.Observacao = OBSERVACAO;
            this.Tipo = TIPO;
            this.CpMunicipio = CP_MUNICIPIO;
            this.Municipio = MUNICIPIO;
            this.Pais = PAIS;
            this.DesPais = DESC_PAIS;
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

        private int ID_PESSOA_TIPO;
        public int IdPessoaTipo
        {
            get
            {
                return this.ID_PESSOA_TIPO;

            }
            set
            {
                this.ID_PESSOA_TIPO = value;
            }
        }

        private int ID_CIDADE;
        public int IdCidade
        {
            get
            {
                return this.ID_CIDADE;

            }
            set
            {
                this.ID_CIDADE = value;
            }
        }

        private int ID_COMPRA;
        public int IdCompra
        {
            get
            {
                return this.ID_COMPRA;

            }
            set
            {
                this.ID_COMPRA = value;
            }
        }

        private int ID_CONTATOS;
        public int IdContatos
        {
            get
            {
                return this.ID_CONTATOS;

            }
            set
            {
                this.ID_CONTATOS = value;
            }
        }

        private int ID_MS;
        public int IdMs
        {
            get
            {
                return this.ID_MS;

            }
            set
            {
                this.ID_MS = value;
            }
        }

        private int ID_OS;
        public int IdOs
        {
            get
            {
                return this.ID_OS;

            }
            set
            {
                this.ID_OS = value;
            }
        }

        private int ID_CEP;
        public int idCep
        {
            get
            {
                return this.ID_CEP;

            }
            set
            {
                this.ID_CEP = value;
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

        private string TIPO_LOGRADOURO;
        public string TipoLogradouro
        {
            get
            {
                return this.TIPO_LOGRADOURO;

            }
            set
            {
                this.TIPO_LOGRADOURO = value;
            }
        }

        private string ENDERECO;
        public string Endereco
        {
            get
            {
                return this.ENDERECO;

            }
            set
            {
                this.ENDERECO = value;
            }
        }

        private int NUMERO;
        public int Numero
        {
            get
            {
                return this.NUMERO;

            }
            set
            {
                this.NUMERO = value;
            }
        }

        private string COMPLEMENTO;
        public string Complemento
        {
            get
            {
                return this.COMPLEMENTO;

            }
            set
            {
                this.COMPLEMENTO = value;
            }
        }

        public string Telefone
        {
            get
            {
                return this.TELEFONE;

            }
            set
            {
                this.TELEFONE = value;
            }
        }
        private string TELEFONE;

        private string TELEFONE2;
        public string Telefone2
        {
            get
            {
                return this.TELEFONE2;

            }
            set
            {
                this.TELEFONE2 = value;
            }
        }

        private string FAX_TELEFONE;
        public string FaxTelefone
        {
            get
            {
                return this.FAX_TELEFONE;

            }
            set
            {
                this.FAX_TELEFONE = value;
            }
        }

        private string TELEX_TELEFONE;
        public string TelexTelefone
        {
            get
            {
                return this.TELEX_TELEFONE;

            }
            set
            {
                this.TELEX_TELEFONE = value;
            }
        }

        private string BAIRRO;
        public string Bairro
        {
            get
            {
                return this.BAIRRO;

            }
            set
            {
                this.BAIRRO = value;
            }
        }

        private string CIDADE;
        public string Cidade
        {
            get
            {
                return this.CIDADE;

            }
            set
            {
                this.CIDADE = value;
            }
        }

        private string SIGLA_CIDADE;
        public string SiglaCidade
        {
            get
            {
                return this.SIGLA_CIDADE;

            }
            set
            {
                this.SIGLA_CIDADE = value;
            }
        }

        private string EMAIL;
        public string Email
        {
            get
            {
                return this.EMAIL;

            }
            set
            {
                this.EMAIL = value;
            }
        }

        private int CEP;
        public int Cep
        {
            get
            {
                return this.CEP;

            }
            set
            {
                this.CEP = value;
            }
        }

        private string OBSERVACAO;
        public string Observacao
        {
            get
            {
                return this.OBSERVACAO;

            }
            set
            {
                this.OBSERVACAO = value;
            }
        }

        private string TIPO;
        public string Tipo
        {
            get
            {
                return this.TIPO;

            }
            set
            {
                this.TIPO = value;
            }
        }

        private string CP_MUNICIPIO;
        public string CpMunicipio
        {
            get
            {
                return this.CP_MUNICIPIO;

            }
            set
            {
                this.CP_MUNICIPIO = value;
            }
        }

        private string MUNICIPIO;
        public string Municipio
        {
            get
            {
                return this.MUNICIPIO;

            }
            set
            {
                this.MUNICIPIO = value;
            }
        }

        private string PAIS;
        public string Pais
        {
            get
            {
                return this.PAIS;

            }
            set
            {
                this.PAIS = value;
            }
        }

        private string DESC_PAIS;
        public string DesPais
        {
            get
            {
                return this.DESC_PAIS;

            }
            set
            {
                this.DESC_PAIS = value;
            }
        }
    }
}
