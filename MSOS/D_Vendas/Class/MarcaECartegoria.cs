using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateSystem
{
    class MarcaECartegoria
    {
        public MarcaECartegoria()
        {
            this.Id_Produto = 0;
            this.Produto = "";
            this.DescricaoProduto = "";
            this.Id_Marca = 0;
            this.Marca = "";
            this.DescricaoMarca = "";
            this.Id_Marca_Descriacao_Marca = 0;
            this.Categoria = "";
            this.DescricaoCategoria = "";
            this.ID_Fabricante = 0;
            this.Fabricante = "";
            this.DescricaoFabricante = "";
        }
        public MarcaECartegoria(int Id_Produto, string PRODUTO, string DESCRICAOPRODUTO,int ID_MARCA,string MARCA, string DESCRICAO_MARCA,
            int ID_CATEGORIA,string CATEGORIA, string DESCRICAOCATEGORIA,int ID_FABRICANTE, string FABRICANTE, string DESCRICAOFABRICANTE)
        {
            this.Id_Produto = Id_Produto;
            this.Produto = PRODUTO;
            this.DescricaoProduto = DESCRICAOPRODUTO;
            this.Id_Marca = ID_MARCA;
            this.Marca = MARCA;
            this.DescricaoMarca = DESCRICAO_MARCA;
            this.ID_Categoria = ID_CATEGORIA;
            this.Categoria = CATEGORIA;
            this.DescricaoCategoria = DESCRICAOCATEGORIA;
            this.ID_Fabricante = ID_FABRICANTE;
            this.Fabricante = FABRICANTE;
            this.DescricaoFabricante = DESCRICAOFABRICANTE;
        }
        private int ID_PRODUTO;
        public int Id_Produto
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
        private string PRODUTO;
        public string Produto
        {
            get
            {
                return this.PRODUTO;

            }
            set
            {
                this.PRODUTO = value;
            }
        }
        private string DESCRICAOPRODUTO;
        public string DescricaoProduto
        {
            get
            {
                return this.DESCRICAOPRODUTO;

            }
            set
            {
                this.DESCRICAOPRODUTO = value;
            }
        }
        private int ID_MARCA;
        public int Id_Marca
        {
            get
            {
                return this.ID_MARCA;

            }
            set
            {
                this.ID_MARCA = value;
            }
        }
        private string MARCA;
        public string Marca
        {
            get
            {
                return this.MARCA;

            }
            set
            {
                this.MARCA = value;
            }
        }
        private int ID_DESCRICAO_MARCA;
        public int Id_Marca_Descriacao_Marca
        {
            get
            {
                return this.ID_DESCRICAO_MARCA;

            }
            set
            {
                this.ID_DESCRICAO_MARCA = value;
            }
        }
        private string DESCRICAO_MARCA;
        public string DescricaoMarca
        {
            get
            {
                return this.DESCRICAO_MARCA;

            }
            set
            {
                this.DESCRICAO_MARCA = value;
            }
        }
        private int ID_CATEGORIA;
        public int ID_Categoria
        {
            get
            {
                return this.ID_CATEGORIA;

            }
            set
            {
                this.ID_CATEGORIA = value;
            }
        }
        private string CATEGORIA;
        public string Categoria
        {
            get
            {
                return this.CATEGORIA;

            }
            set
            {
                this.CATEGORIA = value;
            }
        }
        private string DESCRICAOCATEGORIA;
        public string DescricaoCategoria
        {
            get
            {
                return this.DESCRICAOCATEGORIA;

            }
            set
            {
                this.DESCRICAOCATEGORIA = value;
            }
        }
        private int ID_FABRICANTE;
        public int ID_Fabricante
        {
            get
            {
                return this.ID_FABRICANTE;

            }
            set
            {
                this.ID_FABRICANTE = value;
            }
        }
        private string FABRICANTE;
        public string Fabricante
        {
            get
            {
                return this.FABRICANTE;

            }
            set
            {
                this.FABRICANTE = value;
            }
        }
        private string DESCRICAOFABRICANTE;
        public string DescricaoFabricante
        {
            get
            {
                return this.DESCRICAOFABRICANTE;

            }
            set
            {
                this.DESCRICAOFABRICANTE = value;
            }
        }
    }
}
