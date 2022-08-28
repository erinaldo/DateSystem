using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateSystem
{
    class Fornecedor
    {
        public Fornecedor()
        { 
            this.idFornecedor = 0;
            this.NomeContato = "";
            this.CargoContato = "";
            
        }
        public Fornecedor(int ID_FORNECEDOR, string NOME_CONTATO, string CARGO_CONTATO)
        {
            this.idFornecedor = ID_FORNECEDOR;
            this.NomeContato = NOME_CONTATO;
            this.CargoContato = CARGO_CONTATO;

        }

        private int ID_FORNECEDOR;
        public int idFornecedor
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

        private string CARGO_CONTATO;
        public string CargoContato
        {
            get
            {
                return this.CARGO_CONTATO;

            }
            set
            {
                this.CARGO_CONTATO = value;
            }
        }
    }
}
