using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateSystem
{
    class ClientesContatos
    {
        public ClientesContatos()
        {
            this.IdContatof = 0;
            this.IdFornecedor = 0;
            this.Situacao = 0;
            this.Nome = "";
            this.Abreviacao = "";
            this.Telefone = "";
            this.Telefone2 = "";
            this.Celular = "";
            this.Celular2 = "";
            this.Email = "";
            this.Observacao = "";
        }
        public ClientesContatos(int ID_CONTATOF, int ID_FORNECEDOR, int SITUACAO, string NOME, string ABREVIACAO, String TELEFONE, string TELEFONE2, string CELULAR, string CELULAR2, string EMAIL,
           string OBSERVACAO)
        {

            this.IdContatof = ID_CONTATOF;
            this.IdFornecedor = ID_FORNECEDOR;
            this.Situacao = SITUACAO;
            this.Nome = NOME;
            this.Abreviacao = ABREVIACAO;
            this.Telefone = TELEFONE;
            this.Telefone2 = TELEFONE2;
            this.Celular = CELULAR;
            this.Celular2 = CELULAR2;

            this.Email = EMAIL;
            this.Observacao = OBSERVACAO;
        }

        private int ID_CONTATOF;
        public int IdContatof
        {
            get
            {
                return this.ID_CONTATOF;

            }
            set
            {
                this.ID_CONTATOF = value;
            }
        }

        private int ID_FORNECEDOR;
        public int IdFornecedor
        {
            get
            {
                return this.ID_FORNECEDOR;

            }
            set
            {
                this.ID_FORNECEDOR = value;
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
    }
}
