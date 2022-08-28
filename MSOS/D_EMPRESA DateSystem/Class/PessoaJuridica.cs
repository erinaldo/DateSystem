using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateSystem
{
    class PessoaJuridica
    {
        public PessoaJuridica()
        {
            this.idPessoaJuridica = 0;
            this.IdPessoaTipo = 0;
            this.RazaoSocial = "";
            this.Cnpj = "";
            this.NomeContato = "";
            this.InscricaoStadual = "";
        }
        public void Juridica(int idPessoaJuridica)
        {
            this.idPessoaJuridica = idPessoaJuridica;
            this.IdPessoaTipo = 0;
            this.RazaoSocial = "";
            this.Cnpj = "";
            this.NomeContato = "";
            this.InscricaoStadual = "";
        }
        public PessoaJuridica(int ID_PESSOA_TIPO, string RAZAO_SOCIAL, string CNPJ, string NOME_CONTATO, string INSCRICAO_STADUAL)
        {
            this.IdPessoaTipo = ID_PESSOA_TIPO;
            this.RazaoSocial = RAZAO_SOCIAL;
            this.Cnpj = CNPJ;
            this.NomeContato = NOME_CONTATO;
            this.InscricaoStadual = INSCRICAO_STADUAL;

        }

        private int ID_PESSOA_JURIDICA;
        public int idPessoaJuridica
        {
            get
            {
                return this.ID_PESSOA_JURIDICA;

            }
            set
            {
                this.ID_PESSOA_JURIDICA = value;
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
        private String RAZAO_SOCIAL;
        public string RazaoSocial
        {
            get
            {
                return this.RAZAO_SOCIAL;

            }
            set
            {
                this.RAZAO_SOCIAL = value;
            }
        }

        private string CNPJ;
        public string Cnpj
        {
            get
            {
                return this.CNPJ;

            }
            set
            {
                this.CNPJ = value;
            }
        }
        private string NOME_CONTATO;
        public string NomeContato
        {
            get
            {
                return this.NOME_CONTATO;

            }
            set
            {
                this.NOME_CONTATO = value;
            }
        }
        private string INSCRICAO_STADUAL;
        public string InscricaoStadual
        {
            get
            {
                return this.INSCRICAO_STADUAL;

            }
            set
            {
                this.INSCRICAO_STADUAL = value;
            }
        }
        private string CNAE;
        public string   Cnae
        {
            get
            {
                return this.CNAE;

            }
            set
            {
                this.CNAE = value;
            }
        }

    }
}