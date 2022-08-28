using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateSystem
{
    class FornecedorFisica
    { 
     public FornecedorFisica()
        {
            this.idFornecedorFisica = 0;
            this.IdFornecedorTipo = 1;
            this.Cpf = "";
            this.Rg = "";
            this.dataNacimento = "";
            this.Celular = "";
            this.Celular2 = "";
            this.Nome = "";
        }
        public FornecedorFisica(int ID_FORNECEDOR_TIPO,string NOME, string SEXO, string CPF, string RG, string DATA_NASCIMENTO, string CELULAR, string CELULAR2)
        {
            this.IdFornecedorTipo = ID_FORNECEDOR_TIPO;
            this.Sexo = SEXO;
            this.Cpf = CPF;
            this.Rg = RG;
            this.dataNacimento = DATA_NASCIMENTO;
            this.Celular = CELULAR;
            this.Celular2 = CELULAR2;
            this.Nome = NOME;
        }

        private int ID_FORNECEDOR_FISICA;
        public int idFornecedorFisica
        {
            get
            {
                return this.ID_FORNECEDOR_FISICA;

            }
            set
            {
                this.ID_FORNECEDOR_FISICA = value;
            }
        }
        private int ID_FORNECEDOR_TIPO;
        public int IdFornecedorTipo
        {
            get
            {
                return this.ID_FORNECEDOR_TIPO;

            }
            set
            {
                this.ID_FORNECEDOR_TIPO = value;
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