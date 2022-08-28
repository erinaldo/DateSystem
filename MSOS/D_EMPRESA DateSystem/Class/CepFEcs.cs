using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateSystem
{
    class CepFEcs
    {
        public CepFEcs()
        {
            this.idCep = 0;
            this.Cepc = 0;
            this.TipoLogradouro = "";
            this.Endereco = "";
            this.Numero = 0;
            this.Complemento = "";
            this.Bairro = "";
            this.Cidade = "";
            this.SiglaCidade = "";

        }
        public CepFEcs(int ID_CEP, int CEPC, string TIPO_LOGRADOURO, string ENDERECO, int NUMERO, string COMPLEMENTO, string BAIRRO, string CIDADE, String SIGLA_CIDADE)
        {

            this.idCep = ID_CEP;
            this.Cepc = CEPC;
            this.TipoLogradouro = TIPO_LOGRADOURO;
            this.Endereco = ENDERECO;
            this.Numero = NUMERO;
            this.Complemento = COMPLEMENTO;
            this.Bairro = BAIRRO;
            this.Cidade = CIDADE;
            this.SiglaCidade = SIGLA_CIDADE;
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

        private int CEP;
        public int Cepc
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

        private String TIPO_LOGRADOURO;
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
        public String Complemento
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

        private String BAIRRO;
        public String Bairro
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

        private String CIDADE;
        public String Cidade
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

        private String SIGLA_CIDADE;
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
    }
}
