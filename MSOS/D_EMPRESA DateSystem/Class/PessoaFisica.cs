using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateSystem
{
    class PessoaFisica
    {

        public PessoaFisica()
        {
            this.idPessoaFisica = 0;
            this.IdPessoaTipo = 0;
            this.Nome = "";
            this.Cpf = "";
            this.Rg = "";
            this.dataNacimento = "";
            this.Celular = "";
            this.Celular2 = "";

        }
        public PessoaFisica(int ID_PESSOA_TIPO,string NOME, string SEXO, string CPF, string RG, string DATA_NASCIMENTO, string CELULAR, string CELULAR2)
        {
            this.Nome = NOME;
            this.IdPessoaTipo = ID_PESSOA_TIPO;
            this.Sexo = SEXO;
            this.Cpf = CPF;
            this.Rg = RG;
            this.dataNacimento = DATA_NASCIMENTO;
            this.Celular = CELULAR;
            this.Celular2 = CELULAR2;
        }

        private int ID_PESSOA_FISICA;
        public int idPessoaFisica
        {
            get
            {
                return this.ID_PESSOA_FISICA;

            }
            set
            {
                this.ID_PESSOA_FISICA = value;
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
        private String SEXO;
        public string Sexo
        {
            get
            {
                return this.SEXO;

            }
            set
            {
                this.SEXO = value;
            }
        }

        private string CPF;
        public string Cpf
        {
            get
            {
                return this.CPF;

            }
            set
            {
                this.CPF = value;
            }
        }
        private string RG;
        public string Rg
        {
            get
            {
                return this.RG;

            }
            set
            {
                this.RG = value;
            }
        }
        private String DATA_NASCIMENTO;
        public string dataNacimento
        {
            get
            {
                return this.DATA_NASCIMENTO;

            }
            set
            {
                this.DATA_NASCIMENTO = value;
            }
        
        }
        private string CELULAR;
        public string Celular
        {
            get
            {
                return this.CELULAR;

            }
            set
            {
                this.CELULAR = value;
            }
        }
        private string CELULAR2;
        public string Celular2
{
            get
            {
                return this.CELULAR2;

            }
            set
            {
                this.CELULAR2 = value;
            }
        }

    }
}