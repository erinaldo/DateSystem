using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateSystem
{
    class CadastraUsuario
    {
        public CadastraUsuario()
        {
            this.IdUsuario = 0;
            this.IdSituacao = 0;         
            this.Nome = "";
            this.SobreNome = "";
            this.Abreviacao = "";
            this.Telefone = "";
            this.Telefone2 = "";
            this.Celular = "";
            this.Celular2 = "";
            this.Email = "";
            this.Observacao = "";
            this.Sexo = "";
            this.Cpf = "";
            this.Rg = "";
            this.Data_Nascimento = "";
            this.Cod = 0;

        }
        public CadastraUsuario(int ID_USUARIO, int ID_SITUACAO, string NOME, string SOBRENOME, string ABREVIACAO,int NUMERO, string COMPLEMENTO, string TELEFONE, string TELEFONE2,
            string CELULAR, string CELULAR2,string EMAIL, string OBSERVACAO, string SEXO, string CPF, string RG, string DATA_NASCIMENTO,int COD)
        {

            this.IdUsuario = ID_USUARIO;
            this.IdSituacao = ID_SITUACAO;
            this.Nome = NOME;
            this.SobreNome = SOBRENOME;
            this.Abreviacao = ABREVIACAO;
            this.Telefone = TELEFONE;
            this.Telefone2 = TELEFONE2;
            this.Celular = CELULAR;
            this.Celular2 = CELULAR2;
            this.Email = EMAIL;
            this.Observacao = OBSERVACAO;
            this.Sexo = SEXO;
            this.Cpf = CPF;
            this.Rg = RG;
            this.Data_Nascimento = DATA_NASCIMENTO;
            this.Cod = COD;

        }

        private int ID_USUARIO;
        public int IdUsuario
        {
            get
            {
                return this.ID_USUARIO;

            }
            set
            {
                this.ID_USUARIO = value;
            }
        }

        private int ID_SITUACAO;
        public int IdSituacao
        {
            get
            {
                return this.ID_SITUACAO;

            }
            set
            {
                this.ID_SITUACAO = value;
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
        private string SOBRENOME;
        public string SobreNome
        {
            get
            {
                return this.SOBRENOME;

            }
            set
            {
                this.SOBRENOME = value;
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
        public string Data_Nascimento
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
        private int COD;
        public int Cod
        {
            get
            {
                return this.COD;

            }
            set
            {
                this.COD = value;
            }
        }
    }
}
