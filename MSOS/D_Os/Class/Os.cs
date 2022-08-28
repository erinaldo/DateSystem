using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateSystem
{
    class Os
    {
        public Os()
        {
            this.IdOs = 0;
            this.IdPessoaCliente = 0;
            this.IdFuncionario = 0;
            this.IdServico = 0;
            this.IdItemServico = 0;
            this.IdPessoaLogada = 0;
            this.IdPessoaLogadaAlterada = 0;
            this.Estado = 0;
            this.Situacao = 0;
            this.OrigemChamado = "";
            this.ServicosExecutados = "";
            this.ValorObra = "";
            this.HorarioInicio = "";
            this.HorarioFinal = "";
            DateTime DataSolicitacao = DateTime.Now;
            string DataSolicitacaoFormato = DataSolicitacao.ToString("MM/dd/yyyy");
            DateTime DataFechamento = DateTime.Now;
            this.DataSolicitacao = DataSolicitacao;
            this.DataFechamento = DataFechamento;
            string DataFechamentoFormato = DataFechamento.ToString("MM/dd/yyyy");
            this.MudancaDataFechamento = 0;
        }
        public Os(int ID_OS, int ID_PESSOA_CLIENTE, int ID_FUNCIONARIO, int ID_SERVICO, int ID_ITEM_SERVICO,int ID_PESSOA_LOGADA,int ID_PESSOA_LOGADA_ALTERADA, int SITUACAO, int ESTADO, string ORIGEM_CHAMADO,
            string SERVICOS_EXECUTADOS, String VALOR_OBRA, string HORARIO_INICIO, string HORARIO_FINAL, DateTime DATA_SOLICITACAO, DateTime DATA_FECHAMENTO, int MUDANCADATAFECHAMENTO)
        {
            this.IdOs = ID_OS;
            this.IdPessoaCliente = ID_PESSOA_CLIENTE;
            this.IdFuncionario = ID_FUNCIONARIO;
            this.IdServico = ID_SERVICO;
            this.IdItemServico = ID_ITEM_SERVICO;
            this.IdPessoaLogada = ID_PESSOA_LOGADA;
            this.IdPessoaLogadaAlterada = ID_PESSOA_LOGADA_ALTERADA;
            this.Estado = ESTADO;
            this.Situacao = SITUACAO;
            this.OrigemChamado = ORIGEM_CHAMADO;
            this.ServicosExecutados = SERVICOS_EXECUTADOS;
            this.ValorObra = VALOR_OBRA;
            this.HorarioInicio = HORARIO_INICIO;
            this.HorarioFinal = HORARIO_FINAL;
            this.DataSolicitacao = DATA_SOLICITACAO;
            this.DataFechamento = DATA_FECHAMENTO;
            this.MudancaDataFechamento = MUDANCADATAFECHAMENTO;

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
        private int MUDANCADATAFECHAMENTO;
        public int MudancaDataFechamento
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
        private int ID_OS;
        public int IdOs
        {
            get
            {
                return this.ID_OS;

            }
            set
            {
                this.ID_OS = value;
            }
        }

        private int ID_PESSOA_CLIENTE;
        public int IdPessoaCliente
        {
            get
            {
                return this.ID_PESSOA_CLIENTE;

            }
            set
            {
                this.ID_PESSOA_CLIENTE = value;
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
        private int ID_FUNCIONARIO;
        public int IdFuncionario
        {
            get
            {
                return this.ID_FUNCIONARIO;

            }
            set
            {
                this.ID_FUNCIONARIO = value;
            }
        }
        private int ID_SERVICO;
        public int IdServico
        {
            get
            {
                return this.ID_SERVICO;

            }
            set
            {
                this.ID_SERVICO = value;
            }
        }

        private int ID_ITEM_SERVICO;
        public int IdItemServico
        {
            get
            {
                return this.ID_ITEM_SERVICO;

            }
            set
            {
                this.ID_ITEM_SERVICO = value;
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

        private string ORIGEM_CHAMADO;
        public string OrigemChamado
        {
            get
            {
                return this.ORIGEM_CHAMADO;

            }
            set
            {
                this.ORIGEM_CHAMADO = value;
            }
        }

        private string SERVICOS_EXECUTADOS;
        public string ServicosExecutados
        {
            get
            {
                return this.SERVICOS_EXECUTADOS;

            }
            set
            {
                this.SERVICOS_EXECUTADOS = value;
            }
        }
        private string VALOR_OBRA;
        public string ValorObra
        {
            get
            {
                return this.VALOR_OBRA;

            }
            set
            {
                this.VALOR_OBRA = value;
            }
        }
        private string HORARIO_INICIO;
        public string HorarioInicio
        {
            get
            {
                return this.HORARIO_INICIO;

            }
            set
            {
                this.HORARIO_INICIO = value;
            }
        }
        private string HORARIO_FINAL;
        public string HorarioFinal
        {
            get
            {
                return this.HORARIO_FINAL;

            }
            set
            {
                this.HORARIO_FINAL = value;
            }
        }
        private DateTime DATA_SOLICITACAO;
        public DateTime DataSolicitacao
        {
            get
            {
                return this.DATA_SOLICITACAO;

            }
            set
            {
                this.DATA_SOLICITACAO = value;
            }
        }
        private DateTime DATA_FECHAMENTO;
        public DateTime DataFechamento
        {
            get
            {
                return this.DATA_FECHAMENTO;

            }
            set
            {
                this.DATA_FECHAMENTO = value;
            }
        }
    }
}
