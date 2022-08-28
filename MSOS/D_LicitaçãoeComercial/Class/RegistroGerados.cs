using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateSystem
{
    class RegistroGerados
    {
        public RegistroGerados()
        {
            this.IdGeradoRegistro = 0;
            this.IdClienteRegistro = 0;
            this.IdContato = 0;
            this.Estado = 0;
            this.Situacao = 0;
            this.IdPessoaLogada = 0;
            this.IdPessoaLogadaAlterada = 0;  
            this.OrigemRegistro = "";

            DateTime DataCriacadoFormato = DateTime.Now;
            string DataCriacado = DataCriacadoFormato.ToString("MM/dd/yyyy");

            DateTime DataContatoFormato = DateTime.Now;
            string DataContato = DataContatoFormato.ToString("MM/dd/yyyy");

            DateTime MudancaDataFechamentoFormato = DateTime.Now;
            string MudancaDataFechamento = MudancaDataFechamentoFormato.ToString("MM/dd/yyyy");

        }
        public RegistroGerados(int ID_GERADO_REGISTRO, int IDCLIENTEREGISTRO, int IDCONTATO, int ESTADO, int SITUACAO, int ID_PESSOA_LOGADA,
            int ID_PESSOA_LOGADA_ALTERADA, string ORIGEMREGISTRO, DateTime DATACRIADOREGISTRO, DateTime DATACONTATO,
            DateTime MUDANCADATAFECHAMENTO)
        {
            this.IdGeradoRegistro = ID_GERADO_REGISTRO;
            this.IdClienteRegistro = IDCLIENTEREGISTRO;
            this.IdContato = IDCONTATO;
            this.Estado = ESTADO;
            this.Situacao = SITUACAO;
   
            this.IdPessoaLogada = ID_PESSOA_LOGADA;
            this.IdPessoaLogadaAlterada = ID_PESSOA_LOGADA_ALTERADA;
            this.OrigemRegistro = ORIGEMREGISTRO;
          
            this.DataCriadoRegistrado = DATACRIADOREGISTRO;
            this.DataContato = DATACONTATO;
            this.MudancaDataFechamento = MUDANCADATAFECHAMENTO;


        }
        private int ID_GERADO_REGISTRO;
        public int IdGeradoRegistro
        {
            get
            {
                return this.ID_GERADO_REGISTRO;

            }
            set
            {
                this.ID_GERADO_REGISTRO = value;
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
        private int ESTADO;
        public int Estado
        {
            get
            {
                return this.ESTADO;

            }
            set
            {
                this.ESTADO = value;
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
        private DateTime MUDANCADATAFECHAMENTO;
        public DateTime MudancaDataFechamento
        {
            get
            {
                return this.MUDANCADATAFECHAMENTO;

            }
            set
            {
                this.MUDANCADATAFECHAMENTO = value;
            }
        }        
    }
}
