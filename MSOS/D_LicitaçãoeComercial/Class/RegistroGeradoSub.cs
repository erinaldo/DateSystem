using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateSystem
{
    class RegistroGeradoSub
    {
        public RegistroGeradoSub()
        {
            this.IdRegistro = 0;
            this.IdRegistroSub = 0;
            this.IdClienteRegistro = 0;
            this.IdContato = 0;
            this.Situacao = 0;
            this.IdPessoaLogada = 0;
            this.IdPessoaLogadaAlterada = 0;
            this.OrigemRegistro = "";

            DateTime DataCriacadoFormato = DateTime.Now;
            string DataCriacado = DataCriacadoFormato.ToString("MM/dd/yyyy");

            DateTime DataContatoFormato = DateTime.Now;
            string DataContato = DataContatoFormato.ToString("MM/dd/yyyy");
        }
        public RegistroGeradoSub(int ID_REGISTRO, int ID_REGISTROSUB, int IDCLIENTEREGISTRO, int IDCONTATO,  int SITUACAO, int ID_PESSOA_LOGADA,
            int ID_PESSOA_LOGADA_ALTERADA, string ORIGEMREGISTRO, DateTime DATACRIADOREGISTRO, DateTime DATACONTATO)
        {
            this.IdRegistro = ID_REGISTRO;
            this.IdRegistroSub = ID_REGISTROSUB;
            this.IdClienteRegistro = IDCLIENTEREGISTRO;
            this.IdContato = IDCONTATO;
            this.Situacao = SITUACAO;
            this.IdPessoaLogada = ID_PESSOA_LOGADA;
            this.IdPessoaLogadaAlterada = ID_PESSOA_LOGADA_ALTERADA;
            this.OrigemRegistro = ORIGEMREGISTRO;

            this.DataCriadoRegistrado = DATACRIADOREGISTRO;
            this.DataContato = DATACONTATO;
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
        private int ID_REGISTROSUB;
        public int IdRegistroSub
        {
            get
            {
                return this.ID_REGISTROSUB;

            }
            set
            {
                this.ID_REGISTROSUB = value;
            }
        }
        private int ID_CLIENTE_REGISTRO;
        public int IdClienteRegistro
        {
            get
            {
                return this.ID_CLIENTE_REGISTRO;

            }
            set
            {
                this.ID_CLIENTE_REGISTRO = value;
            }
        }
        private int ID_CONTATO;
        public int IdContato
        {
            get
            {
                return this.ID_CONTATO;

            }
            set
            {
                this.ID_CONTATO = value;
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
        private int ID_PESSOA_LOGADA;
        public int IdPessoaLogada
        {
            get
            {
                return this.ID_PESSOA_LOGADA;

            }
            set
            {
                this.ID_PESSOA_LOGADA = value;
            }
        }
        private int ID_PESSOA_LOGADA_ALTERADA;
        public int IdPessoaLogadaAlterada
        {
            get
            {
                return this.ID_PESSOA_LOGADA_ALTERADA;

            }
            set
            {
                this.ID_PESSOA_LOGADA_ALTERADA = value;
            }
        }
        private string ORIGEM_REGISTRO;
        public string OrigemRegistro
        {
            get
            {
                return this.ORIGEM_REGISTRO;

            }
            set
            {
                this.ORIGEM_REGISTRO = value;
            }
        }
        private DateTime DATA_CRIADOREGISTRO;
        public DateTime DataCriadoRegistrado
        {
            get
            {
                return this.DATA_CRIADOREGISTRO;

            }
            set
            {
                this.DATA_CRIADOREGISTRO = value;
            }
        }
        private DateTime DATA_CONTATO;
        public DateTime DataContato
        {
            get
            {
                return this.DATA_CONTATO;

            }
            set
            {
                this.DATA_CONTATO = value;
            }
        }
    }
}
