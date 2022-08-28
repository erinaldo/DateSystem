using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateSystem
{
    class Vendedor
    {
        public Vendedor()
        {
            this.ID_VENDEDOR = 0;
            this.Salario = 0;
            this.Situacao = 0;
            this.Abreviacao = "";
            this.Telefone = "";
            this.Telefone2 = "";
            this.Celular = "";
            this.Celular2 = "";
            this.Email = "";
            this.Observacao = "";
            this.Cargo = "";
            this.DataAdmissao = "";
            this.DiaPAgamento = 0;
            this.Comissao = 0;
            this.Tipo = 0;
            this.Codigo = 0;
            this.Descricao = "";
        }
        public Vendedor(int ID_VENDEDOR, int SALARIO, int SITUACAO,string ABREVIACAO, String TELEFONE, string TELEFONE2, string CELULAR, string CELULAR2, string EMAIL,
           string DESCRICAO, string CARGO, string DATAAADMISSAO, int DIAPAGAMENTO, int COMISSAO, int TIPO, int CODIGO)
        {

            this.ID_VENDEDOR = ID_VENDEDOR;
            this.SALARIO = SALARIO;
            this.Abreviacao = ABREVIACAO;
            this.Telefone = TELEFONE;
            this.Telefone2 = TELEFONE2;
            this.Celular = CELULAR;
            this.Celular2 = CELULAR2;
            this.Situacao = Situacao;
            this.Email = EMAIL;

            this.CARGO = CARGO;
            this.DataAdmissao = DATAAADMISSAO;
            this.DiaPAgamento = DIAPAGAMENTO;
            this.Comissao = COMISSAO;
            this.Tipo = TIPO;
            this.Codigo = CODIGO;
            this.Descricao = DESCRICAO;

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

        private int SALARIO;
        public int Salario
        {
            get
            {
                return this.SALARIO;

            }
            set
            {
                this.SALARIO = value;
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
        private string CARGO;
        public String Cargo
        {
            get
            {
                return this.CARGO;

            }
            set
            {
                this.CARGO = value;
            }
        }
        private string DATA_ADMISSAO;
        public String DataAdmissao
        {
            get
            {
                return this.DATA_ADMISSAO;

            }
            set
            {
                this.DATA_ADMISSAO = value;
            }
        }
        private int DIA_PAGAMENTO;
        public int DiaPAgamento
        {
            get
            {
                return this.DIA_PAGAMENTO;

            }
            set
            {
                this.DIA_PAGAMENTO = value;
            }

        }
        private int COMISSAO;
        public int Comissao
        {
            get
            {
                return this.COMISSAO;

            }
            set
            {
                this.COMISSAO = value;
            }
        }
        private int TIPO;
        public int Tipo
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
        private int CODIGO;
        public int Codigo
        {
            get
            {
                return this.CODIGO;

            }
            set
            {
                this.CODIGO = value;
            }
        }
        private String DESCRISAO;
        public String Descricao
        {
            get
            {
                return this.DESCRISAO;

            }
            set
            {
                this.DESCRISAO = value;
            }
        }
    }
}
