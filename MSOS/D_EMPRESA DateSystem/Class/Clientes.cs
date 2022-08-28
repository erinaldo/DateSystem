using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateSystem
{
    class Clientes
    {
        public Clientes()
        {
            this.idPessoa = 0;
            this.IdMs = 0;
        }
        public Clientes(int ID_PESSOA, int ID_MS)
        {
            this.idPessoa = ID_PESSOA;
            this.IdMs = ID_MS;
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

    }
}
