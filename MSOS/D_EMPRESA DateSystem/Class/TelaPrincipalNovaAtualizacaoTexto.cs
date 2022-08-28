using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateSystem
{
    class TelaPrincipalNovaAtualizacaoTexto
    {
        public TelaPrincipalNovaAtualizacaoTexto()
        {
            this.idUsuario = 0;
            this.AtualizacaoTelaPrincipal = 0;
        }
        public TelaPrincipalNovaAtualizacaoTexto(int ID_USUARIO, int ATUALIZACAOTELAPRINCIPAL)
        {

            this.idUsuario = ID_USUARIO;
            this.AtualizacaoTelaPrincipal = ATUALIZACAOTELAPRINCIPAL;
        }

        private int ID_USUARIO;
        public int idUsuario
        {
            get
            {
                return this.ID_USUARIO;

            }
            set
            {
                this.ID_USUARIO = value;
            }
        }

        private int ATUALIZACAOTELAPRINCIPAL;
        public int AtualizacaoTelaPrincipal
        {
            get
            {
                return this.ATUALIZACAOTELAPRINCIPAL;

            }
            set
            {
                this.ATUALIZACAOTELAPRINCIPAL = value;
            }
        }
    }
}
