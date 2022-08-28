using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateSystem
{
    class AlteracaoStatusRS
    {
        public AlteracaoStatusRS()
        {
            this.IdClienteOS = 0;
            this.IdFornecedor = 0;
            this.IdVendedor = 0;
            this.IdRegistro = 0;
            this.NomeClienteOs = "";
            this.IdMs = 0;
            this.NomeContatoF = "";
            this.CargoContatoF = "";
            this.NumeroVendedor = "";
            this.NomeRegistro = "";
        }
        public AlteracaoStatusRS(int ID_CLIENTE_OS, int ID_FORNECEDOR, int ID_VENDEDOR, int ID_REGISTO,
            string NOME_CLIENTE_OS, int ID_MS, string NOME_CONTATO_F, string CARGO_CONTATO_F, string NUMERO_VENDEDOR, string NOME_REGISTRO)
        {
            this.IdClienteOS = ID_CLIENTE_OS;
            this.IdFornecedor = ID_FORNECEDOR;
            this.IdVendedor = ID_VENDEDOR;
            this.IdRegistro = ID_REGISTO;
            this.NomeClienteOs = NOME_CLIENTE_OS;
            this.IdMs = ID_MS;
            this.NomeContatoF = NOME_CONTATO_F;
            this.CargoContatoF = CARGO_CONTATO_F;
            this.NumeroVendedor = NUMERO_VENDEDOR;
            this.NomeRegistro = NOME_REGISTRO;
        }
        private int ID_CLIENTE_OS;
        public int IdClienteOS
        {
            get
            {
                return this.ID_CLIENTE_OS;

            }
            set
            {
                this.ID_CLIENTE_OS = value;
            }
        }
        private int ID_FORNECEDOR;
        public int IdFornecedor
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
        private int ID_REGISTRO;
        public int IdRegistro
        {
            get
            {
                return this.ID_REGISTRO;

            }
            set
            {
                this.ID_REGISTRO = value;
            }
        }
        private string NO_CLIENTE_OS;
        public string NomeClienteOs
        {
            get
            {
                return this.NO_CLIENTE_OS;

            }
            set
            {
                this.NO_CLIENTE_OS = value;
            }
        }
        private int ID_MS;
        public int IdMs
        {
            get
            {
                return this.ID_MS;

            }
            set
            {
                this.ID_MS = value;
            }
        }

        private string NOME_CONTATO_F;
        public string NomeContatoF
        {
            get
            {
                return this.NOME_CONTATO_F;

            }
            set
            {
                this.NOME_CONTATO_F = value;
            }
        }
        private string CARGO_CONTATO_F;
        public string CargoContatoF
        {
            get
            {
                return this.CARGO_CONTATO_F;

            }
            set
            {
                this.CARGO_CONTATO_F = value;
            }
        }
        private string NUMERO_VENDEDOR;
        public string NumeroVendedor
        {
            get
            {
                return this.NUMERO_VENDEDOR;

            }
            set
            {
                this.NUMERO_VENDEDOR = value;
            }
        }
        private string NOME_REGISTRO;
        public string NomeRegistro
        {
            get
            {
                return this.NOME_REGISTRO;

            }
            set
            {
                this.NOME_REGISTRO = value;
            }
        }
    }
}
