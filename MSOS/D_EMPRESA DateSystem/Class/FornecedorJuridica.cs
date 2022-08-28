using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateSystem
{
    class FornecedorJuridica
    {
        public FornecedorJuridica()
        {
            this.idFornecedorJuridica = 0;
            this.IdFornecedorTipo = 0;
            this.RazaoSocial = "";
            this.Cnpj = "";
            this.NomeContato = "";
            this.InscricaoStadual = "";
        }
        public FornecedorJuridica(int idPessoaJuridica)
        {
            this.idFornecedorJuridica = idFornecedorJuridica;
            this.IdFornecedorTipo = 0;
            this.RazaoSocial = "";
            this.Cnpj = "";
            this.NomeContato = "";
            this.InscricaoStadual = "";
        }
        public FornecedorJuridica(int ID_FORNECEDOR_TIPO, string RAZAO_SOCIAL, string CNPJ, string NOME_CONTATO, string INSCRICAO_STADUAL)
        {
            this.IdFornecedorTipo = ID_FORNECEDOR_TIPO;
            this.RazaoSocial = RAZAO_SOCIAL;
            this.Cnpj = CNPJ;
            this.NomeContato = NOME_CONTATO;
            this.InscricaoStadual = INSCRICAO_STADUAL;

        }

        private int ID_FORNECEDOR_JURIDICA;
        public int idFornecedorJuridica
        {
            get
            {
                return this.ID_FORNECEDOR_JURIDICA;

            }
            set
            {
                this.ID_FORNECEDOR_JURIDICA = value;
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
    }
}