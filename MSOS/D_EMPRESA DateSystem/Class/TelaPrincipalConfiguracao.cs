using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateSystem
{
    class TelaPrincipalConfiguracao
    {
        public TelaPrincipalConfiguracao()
        {
            this.idUsuario = 0;
            this.VerificadorOS = 0;
        }
        public TelaPrincipalConfiguracao(int ID_USUARIO, int VERIFICADOR_OS, string TIPO_LOGRADOURO, string ENDERECO, string NUMERO, string COMPLEMENTO, string BAIRRO, string CIDADE, String SIGLA_CIDADE)
        {

            this.idUsuario = ID_USUARIO;
            this.VerificadorOS = VERIFICADOR_OS;
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

        private int VERIFICADOROS;
        public int VerificadorOS
        {
            get
            {
                return this.VERIFICADOROS;

            }
            set
            {
                this.VERIFICADOROS = value;
            }
        }
    }
}
