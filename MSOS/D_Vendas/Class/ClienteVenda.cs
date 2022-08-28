using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateSystem
{
    class ClienteVenda
    {
        public ClienteVenda()
        {
            this.idPessoa = 0;
            this.NumeroRegistro = "";
        }
        public ClienteVenda(int ID_PESSOA, string NUMERO_REGISTRO)
        {
            this.idPessoa = ID_PESSOA;
            this.NumeroRegistro = NUMERO_REGISTRO;
        }

        private int ID_PESSOA;
        public int idPessoa
        {
            get
            {
                return this.ID_PESSOA;

            }
            set
            {
                this.ID_PESSOA = value;
            }
        }

        private string NUMERO_REGISTRO;
        public string NumeroRegistro
        {
            get
            {
                return this.NUMERO_REGISTRO;
            }
            set
            {
                this.NUMERO_REGISTRO = value;
            }
        }
    }
}
