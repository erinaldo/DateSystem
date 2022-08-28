using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateSystem
{
    class CepJ
    {
        public CepJ()
        {
            this.idCep = 0;
            this.Cepc = 0;
            this.TipoLogradouro = "";
            this.Endereco = "";
            this.Numero = "";
            this.Complemento = "";
            this.Bairro = "";
            this.Cidade = "";
            this.SiglaCidade = "";
        }
        public CepJ(int ID_CEP, int CEPC, string TIPO_LOGRADOURO, string ENDERECO, string NUMERO, string COMPLEMENTO, string BAIRRO, string CIDADE,string SIGLACIDADE)
        {

            this.idCep = ID_CEP;
            this.Cepc = CEPC;
            this.TipoLogradouro = TIPO_LOGRADOURO;
            this.Endereco = ENDERECO;
            this.Numero = "";
            this.Complemento = COMPLEMENTO;
            this.Bairro = BAIRRO;
            this.Cidade = CIDADE;
            this.SiglaCidade = SIGLACIDADE;
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

        private string NUMERO;
        public string Numero
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
        private String SIGLACIDADE;
        public String SiglaCidade
        {
            get
            {
                return this.SIGLACIDADE;

            }
            set
            {
                this.SIGLACIDADE = value;
            }
        }
    }
}
