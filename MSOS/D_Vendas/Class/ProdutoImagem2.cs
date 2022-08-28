using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateSystem
{
    class ProdutoImagem2
    {
        public ProdutoImagem2()
        {
            this.IdProdutoImagem2 = 0;
            this.IdProduto2 = 0;
            this.Imagem2 = null;
        }
        public ProdutoImagem2(int ID_PRODUTO_IMAGEM2, int ID_PRODUTO2, byte[] IMAGEM2)
        {
            this.IdProdutoImagem2 = ID_PRODUTO_IMAGEM2;
            this.IdProduto2 = ID_PRODUTO2;
            this.Imagem2 = IMAGEM2;
        }

        private int ID_PRODUTO_IMAGEM2;
        public int IdProdutoImagem2
        {
            get
            {
                return this.ID_PRODUTO_IMAGEM2;

            }
            set
            {
                this.ID_PRODUTO_IMAGEM2 = value;
            }
        }

        private int ID_PRODUTO2;
        public int IdProduto2
        {
            get
            {
                return this.ID_PRODUTO2;

            }
            set
            {
                this.ID_PRODUTO2 = value;
            }
        }
        private byte[] IMAGEM2;
        public byte[] Imagem2
        {
            get
            {
                return this.IMAGEM2;

            }
            set
            {
                this.IMAGEM2 = value;
            }
        }
    }
}
