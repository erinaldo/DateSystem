using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateSystem
{
    class OsAtiva
    {
        public OsAtiva()
        {
            this.NumeroOS = 0;
            this.IdCliente = 0;
            this.Situacao = 0;
        }
        public OsAtiva(int NUMEROOS, int ID_CLIENTE, int SITUACAO)
        {
            this.NumeroOS = NUMEROOS;
            this.IdCliente = ID_CLIENTE;
            this.Situacao = SITUACAO;
        }

        private int NUMEROOS;
        public int NumeroOS
        {
            get
            {
                return this.NUMEROOS;

            }
            set
            {
                this.NUMEROOS = value;
            }
        }
        private int ID_CLIENTE;
        public int IdCliente
        {
            get
            {
                return this.ID_CLIENTE;

            }
            set
            {
                this.ID_CLIENTE = value;
            }
        }

        private int SITUACAO;
        public int Situacao
        {
            get
            {
                return this.SITUACAO;

            }
            set
            {
                this.SITUACAO = value;
            }
        }
    }
}
