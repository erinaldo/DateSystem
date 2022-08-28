using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateSystem
{
    class ListaProduto
    {
        public ListaProduto()
        {
            this.IdListaL = "";
            this.IdProdutoL = "";
            this.QuantidadeL = "";
            this.ValorVendidoL = "";
            this.ValorTotalL = "";

        }
        public ListaProduto(string IDLISTAL, string ID_PRODUTOL, string QUANTIDADEL, string VALORVENDIDOL, string VALORTOTALL)
        {
            this.IdListaL = IDLISTAL;
            this.IdProdutoL = ID_PRODUTOL;
            this.QuantidadeL = QUANTIDADEL;
            this.ValorVendidoL = VALORVENDIDOL;
            this.ValorTotalL= VALORTOTALL;


        }
        private string ID_LISTAL;
        public string IdListaL
        {
            get
            {
                return this.ID_LISTAL;

            }
            set
            {
                this.ID_LISTAL = value;
            }
        }

        private string ID_PRODUTOL;
        public string IdProdutoL
        {
            get
            {
                return this.ID_PRODUTOL;

            }
            set
            {
                this.ID_PRODUTOL = value;
            }
        }

        private string QUANTIDADEL;
        public string QuantidadeL
        {
            get
            {
                return this.QUANTIDADEL;
            }
            set
            {
                this.QUANTIDADEL = value;
            }
        }
        private string VALORVENDIDOL;
        public string ValorVendidoL
        {
            get
            {
                return this.VALORVENDIDOL;
            }
            set
            {
                this.VALORVENDIDOL = value;
            }
        }
        private string VALORTOTALL;
        public string ValorTotalL
        {
            get
            {
                return this.VALORTOTALL;
            }
            set
            {
                this.VALORTOTALL = value;
            }
        }
    }
}
