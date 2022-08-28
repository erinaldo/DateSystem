using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateSystem
{
    class ProdutoImagem
    {
        public ProdutoImagem()
        {
            this.IdProdutoImagem = 0;
            this.IdProduto = 0;
            this.Imagem = null;
        }
        public ProdutoImagem(int ID_PRODUTO_IMAGEM, int ID_PRODUTO, byte[] IMAGEM)
        {
            this.IdProdutoImagem = ID_PRODUTO_IMAGEM;
            this.IdProduto = ID_PRODUTO;
            this.Imagem = IMAGEM;
        }

        private int ID_PRODUTO_IMAGEM;
        public int IdProdutoImagem
        {
            get
            {
                return this.ID_PRODUTO_IMAGEM;

            }
            set
            {
                this.ID_PRODUTO_IMAGEM = value;
            }
        }

        private int ID_PRODUTO;
        public int IdProduto
        {
            get
            {
                return this.ID_PRODUTO;

            }
            set
            {
                this.ID_PRODUTO = value;
            }
        }
        private byte[] IMAGEM;
        public byte[] Imagem
        {
            get
            {
                return this.IMAGEM;

            }
            set
            {
                this.IMAGEM = value;
            }
        }
    }
}

