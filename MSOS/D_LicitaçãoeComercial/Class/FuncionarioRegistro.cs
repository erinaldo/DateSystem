using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateSystem
{
    class FuncionarioRegistro
    {
        public FuncionarioRegistro()
        {
            this.IdFuncionario = 0;
            this.IdRe = 0;
            this.Situacao = 0;
            this.Nome = "";
            this.Abreviacao = "";
            this.Telefone = "";
            this.Telefone2 = "";
            this.Celular = "";
            this.Celular2 = "";
            this.Email = "";
            this.Observacao = "";
            this.SEXO = "";
            this.Cpf = "";
            this.Rg = "";
            this.DataNascimento = "";
        }
        public FuncionarioRegistro(int ID_FUNCIONARIO, int ID_RE, int SITUACAO, string NOME, string ABREVIACAO, String TELEFONE, string TELEFONE2, string CELULAR, string CELULAR2, string EMAIL,
           string OBSERVACAO, string SEXO, string CPF, string RG, string DATA_NASCIMENTO)
        {

            this.IdFuncionario = ID_FUNCIONARIO;
            this.IdRe = ID_RE;
            this.Nome = NOME;
            this.Abreviacao = ABREVIACAO;
            this.Telefone = TELEFONE;
            this.Telefone2 = TELEFONE2;
            this.Celular = CELULAR;
            this.Celular2 = CELULAR2;
            this.Situacao = Situacao;
            this.Email = EMAIL;
            this.Observacao = OBSERVACAO;
            this.SEXO = SEXO;
            this.Cpf = CPF;
            this.Rg = RG;
            this.DataNascimento = DATA_NASCIMENTO;
        }

        private int ID_FUNCIONARIO;
        public int IdFuncionario
        {
            get
            {
                return this.ID_FUNCIONARIO;

            }
            set
            {
                this.ID_FUNCIONARIO = value;
            }
        }

        private int ID_RE;
        public int IdRe
        {
            get
            {
                return this.ID_RE;

            }
            set
            {
                this.ID_RE = value;
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


        private string ABREVIACAO;
        public string Abreviacao
        {
            get
            {
                return this.ABREVIACAO;

            }
            set
            {
                this.ABREVIACAO = value;
            }
        }
        private string TELEFONE;
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

        private string EMAIL;
        public String Email
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

        private string OBSERVACAO;
        public String Observacao
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

        private string SEXO;
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

        private string DATA_NASCIMENTO;
        public string DataNascimento
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
    }
}
