using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateSystem
{
    class SituacaoAdiquirida
    {
        public SituacaoAdiquirida()
        {
            this.IdEstado = 0;
            this.TabelaAtribuida = "";
            this.Descricao = "";
            this.Sigla = "";

        }
        public SituacaoAdiquirida(int ID_ESTADO, string TABELA_ATRIBUIDA, string DESCRICAO, string SIGLA)
        {
            this.IdEstado = ID_ESTADO;
            this.TabelaAtribuida = TABELA_ATRIBUIDA;
            this.Descricao = DESCRICAO;
            this.SIGLA = SIGLA;

        }

        private int ID_ESTADO;
        public int IdEstado
        {
            get
            {
                return this.ID_ESTADO;

            }
            set
            {
                this.ID_ESTADO = value;
            }
        }

        private string TABELA_ATRIBUIDA;
        public string TabelaAtribuida
        {
            get
            {
                return this.TABELA_ATRIBUIDA;

            }
            set
            {
                this.TABELA_ATRIBUIDA = value;
            }
        }

        private string DESCRICAO;
        public string Descricao
        {
            get
            {
                return this.DESCRICAO;

            }
            set
            {
                this.DESCRICAO = value;
            }
        }
        private string SIGLA;
        public string Sigla
        {
            get
            {
                return this.SIGLA;

            }
            set
            {
                this.SIGLA = value;
            }
        }
    }
}
