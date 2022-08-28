using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateSystem
{
    class Registro
    {
        public Registro()
        {
            this.idPessoa = 0;
            this.Nome = "";
        }
        public Registro(int ID_PESSOA, string NOME)
        {
            this.idPessoa = ID_PESSOA;
            this.Nome = NOME;
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

        private string NOME;
        public string Nome
        {
            get
            {
                return this.NOME;

            }
            set
            {
                this.NOME = value;
            }
        }
    }
}
