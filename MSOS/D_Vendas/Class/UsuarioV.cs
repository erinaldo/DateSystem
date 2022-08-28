using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateSystem
{
    class UsuarioV
    {
        public UsuarioV()
        {
            this.ID_UsuarioV = 0;
            this.Situacao = 0;
            this.Abreviacao = "";
            this.Telefone = "";
            this.Telefone2 = "";
            this.Celular = "";
            this.Celular2 = "";
            this.Email = "";
        }
        public UsuarioV(int ID_UsuarioV, int SITUACAO, string ABREVIACAO, String TELEFONE, string TELEFONE2,
            string CELULAR, string CELULAR2, string EMAIL)
        {

            this.ID_UsuarioV = ID_UsuarioV;
            this.Abreviacao = ABREVIACAO;
            this.Telefone = TELEFONE;
            this.Telefone2 = TELEFONE2;
            this.Celular = CELULAR;
            this.Celular2 = CELULAR2;
            this.Situacao = Situacao;
            this.Email = EMAIL;
        }

        private int ID_USUARIOV;
        public int ID_UsuarioV
        {
            get
            {
                return this.ID_USUARIOV;

            }
            set
            {
                this.ID_USUARIOV = value;
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
    }
}
