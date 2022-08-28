using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Reflection;
using System.Drawing.Printing;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;

namespace DateSystem
{
    public partial class FormOSPesquisa : Form
    {
        DataTable TableNome;
        DataTable TableMs;
        DataTable TableTodos;
        DataTable TableOs;

        private int ID_CLIENTEG = 0;
        public int IdCLiente
        {
            get
            {
                return this.ID_CLIENTEG;

            }
            set
            {
                this.ID_CLIENTEG = value;
            }
        }
        private int VALORPESQUISA = 0;
        public int ValorPesquisa
        {
            get
            {
                return this.VALORPESQUISA;

            }
            set
            {
                this.VALORPESQUISA = value;
            }
        }
        private int ID_OS = 0;
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
        private int ID_PESSOA_LOGADA = 0;
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
        private string NOMEACESSO = "";
        public string NomeAcesso
        {
            get
            {
                return this.NOMEACESSO;

            }
            set
            {
                this.NOMEACESSO = value;
            }
        }

        //-----------------Paramentros usado para Busca-----

        private int ABERTO = 0;
        public int Aberto
        {
            get
            {
                return this.ABERTO;

            }
            set
            {
                this.ABERTO = value;
            }
        }
        private int PROCESSO = 0;
        public int Processo
        {
            get
            {
                return this.PROCESSO;

            }
            set
            {
                this.PROCESSO = value;
            }
        }
        private int FECHADO = 0;
        public int Fechado
        {
            get
            {
                return this.FECHADO;

            }
            set
            {
                this.FECHADO = value;
            }
        }
        private int TODOS = 0;
        public int Todos
        {
            get
            {
                return this.TODOS;

            }
            set
            {
                this.TODOS = value;
            }
        }
        private int OS = 0;
        public int Os
        {
            get
            {
                return this.OS;

            }
            set
            {
                this.OS = value;
            }
        }
        private int OSPESQUISA = 0;
        public int OsPesquisa
        {
            get
            {
                return this.OSPESQUISA;

            }
            set
            {
                this.OSPESQUISA = value;
            }
        }
        private int OSVISUALIZAR = 0;
        public int OsVisualizar
        {
            get
            {
                return this.OSVISUALIZAR;

            }
            set
            {
                this.OSVISUALIZAR = value;
            }
        }
        private int OSEDITAR = 0;
        public int OsEditar
        {
            get
            {
                return this.OSEDITAR;

            }
            set
            {
                this.OSEDITAR = value;
            }
        }
        private int OSEXCLUIR = 0;
        public int OsExcluir
        {
            get
            {
                return this.OSEXCLUIR;

            }
            set
            {
                this.OSEXCLUIR = value;
            }
        }
        private int CLIENTECCADASTRA = 0;
        public int ClienteCCadastra
        {
            get
            {
                return this.CLIENTECCADASTRA;

            }
            set
            {
                this.CLIENTECCADASTRA = value;
            }
        }
        private string NOMESERVIDOR = "";
        public string NomeServidor
        {
            get
            {
                return this.NOMESERVIDOR;

            }
            set
            {
                this.NOMESERVIDOR = value;
            }
        }
        private string BASE_DADOS = "";
        public string BaseDados
        {
            get
            {
                return this.BASE_DADOS;

            }
            set
            {
                this.BASE_DADOS = value;
            }
        }
        private string NOMEBASEDADOS = "";
        public string NomeBaseDados
        {
            get
            {
                return this.NOMEBASEDADOS;

            }
            set
            {
                this.NOMEBASEDADOS = value;
            }
        }
        private string NOMEUSUARIO = "";
        public string NomeUsuario
        {
            get
            {
                return this.NOMEUSUARIO;

            }
            set
            {
                this.NOMEUSUARIO = value;
            }
        }
        private string SENHABASEDADOS = "";
        public string SenhaBaseDados
        {
            get
            {
                return this.SENHABASEDADOS;

            }
            set
            {
                this.SENHABASEDADOS = value;
            }
        }
        private string CONNECTIONSTRING = "";
        public string connetionString
        {
            get
            {
                return this.CONNECTIONSTRING;

            }
            set
            {
                this.CONNECTIONSTRING = value;
            }
        }


        public FormOSPesquisa()
        {
            InitializeComponent();

            dataGridViewPesquisaNome();
            dataGridViewPesquisaMS();
            dataGridViewPesquisaTodos();
            dataGridViewPesquisaOs();
        }
        public FormOSPesquisa(int OSVISUALIZAR,int OSEDITAR,int OSEXCLUIR,int ID_USUARIO_ACESSO,int ClienteCCadastra, string NomeServidor, string NomeBaseDados, string NomeUsuario, string SenhaBaseDados)
        {
            InitializeComponent();

            this.OsVisualizar = OSVISUALIZAR;
            this.OsEditar = OSEDITAR;
            this.OsExcluir = OSEXCLUIR;
            this.IdPessoaLogada = ID_USUARIO_ACESSO;
            //this.id_CadastroOs = id_CadastroOs;
            this.ClienteCCadastra = ClienteCCadastra;

            this.NomeServidor = NomeServidor;
            this.NomeBaseDados = NomeBaseDados;
            this.NomeUsuario = NomeUsuario;
            this.SenhaBaseDados = SenhaBaseDados;

            this.connetionString = "Data Source=" + this.NomeServidor + ";Initial Catalog=" + this.NomeBaseDados + ";Persist Security Info=True;User ID=" + this.NomeUsuario + ";Password=" + this.SenhaBaseDados + ";";

            dataGridViewPesquisaTodos();

            //dataGridViewPesquisaNome();
            //dataGridViewPesquisaMS();

            //dataGridViewPesquisaOs();
        }

        private void radioButtonPequisaMS_CheckedChanged(object sender, EventArgs e)
        {
            txtPesquisaMSOs.Enabled = true;
            txtPesquisaNomeOs.Enabled = false;
            txtDataSolicitacao.Enabled = false;
            txtDataSolicitacao2.Enabled = false;
            panelEstado.Enabled = true;
            txtOrdemServico.Enabled = false;

            txtPesquisaNomeOs.Clear();
            txtPesquisaMSOs.Clear();
            txtOrdemServico.Clear();

            checkBoxTodos.Checked = true;
            checkBoxEstadoA.Checked = false;
            checkBoxEstadoP.Checked = false;
            checkBoxEstadoF.Checked = false;
            checkBoxOs.Enabled = false;
            checkBoxOs.Checked = false;

            //dataGridViewPesquisa.Columns.Clear();
            //dataGridViewPesquisa.Refresh();
            label8.Text = dataGridViewPesquisa.RowCount.ToString();
        }

        private void radioButtonPesquisaNome_CheckedChanged(object sender, EventArgs e)
        {
            txtPesquisaMSOs.Enabled = false;
            txtPesquisaNomeOs.Enabled = true;
            txtDataSolicitacao.Enabled = false;
            txtDataSolicitacao2.Enabled = false;
            panelEstado.Enabled = true;
            panelEstado.Enabled = true;
            txtOrdemServico.Enabled = false;
            txtPesquisaNomeOs.Clear();
            txtPesquisaMSOs.Clear();
            txtOrdemServico.Clear();

            checkBoxTodos.Checked = true;
            checkBoxEstadoA.Checked = false;
            checkBoxEstadoP.Checked = false;
            checkBoxEstadoF.Checked = false;
            checkBoxOs.Enabled = false;
            checkBoxOs.Checked = false;

            //dataGridViewPesquisa.Columns.Clear();
            label8.Text = dataGridViewPesquisa.RowCount.ToString();
        }

        private void radioButtonPesquisaData_CheckedChanged(object sender, EventArgs e)
        {
            txtPesquisaMSOs.Enabled = false;
            txtPesquisaNomeOs.Enabled = false;
            txtDataSolicitacao.Enabled = true;
            txtDataSolicitacao2.Enabled = true;
            panelEstado.Enabled = true;

            txtOrdemServico.Enabled = false;
            txtPesquisaNomeOs.Clear();
            txtPesquisaMSOs.Clear();
            txtOrdemServico.Clear();

            checkBoxTodos.Checked = true;
            checkBoxEstadoA.Checked = false;
            checkBoxEstadoP.Checked = false;
            checkBoxEstadoF.Checked= false;
            checkBoxOs.Enabled = false;
            checkBoxOs.Checked = false;

            //dataGridViewPesquisa.Columns.Clear();
    
            label8.Text = dataGridViewPesquisa.RowCount.ToString();
        }

        private void buttonPesquisaOS_Click(object sender, EventArgs e)
        {
            radioButtonPequisaMS.Enabled = true;
            radioButtonPesquisaNome.Enabled = true;
            radioButtonPesquisaData.Enabled = true;
            buttonPesquisaCliente.Enabled = true;
            radioButtonTodosClientes.Enabled = true;
        }
        //METODO PARA VERIFICA SE O FORMULÁRIO ESTA ABERTO SE TIVER ELE FECHA!
        public static void CancelaCadastradoOs(Type frmType)
        {
            bool bolCtl = false;
            Type a = frmType;
            foreach (Form form in System.Windows.Forms.Application.OpenForms)
            {
                if (form.GetType().Equals(frmType))
                {

                    form.Close();

                    //MessageBox.Show("Formulario Já foi Fechado.");


                    bolCtl = true;
                    break;
                }
            }

            if (!bolCtl)
            {

            }
        }
        //CHAMA O METODO CancelaCadastradoCliente QUE FECHA FORMULÁRIOS ABERTOS
        public void FecharTodosFormulario()
        {
            CancelaCadastradoOs(typeof(FormOSPesquisa));
        }
        public void FecharFormOSPesquisaEditar()
        {
            CancelaCadastradoOs(typeof(FormOSPesquisaEditar));
        }

        private void buttonFecharOs_Click(object sender, EventArgs e)
        {
            FecharTodosFormulario();
        }

        private void buttonCancelarOs_Click(object sender, EventArgs e)
        {
            FecharTodosFormulario();

            FormOSPesquisa cadastracliente = new FormOSPesquisa(this.OSVISUALIZAR,this.OSEDITAR,this.OSEXCLUIR,this.IdPessoaLogada, this.ClienteCCadastra, 
                this.NomeServidor, this.NomeBaseDados,this.NomeUsuario,this.SenhaBaseDados);
            cadastracliente.MdiParent = FormOSPesquisa.ActiveForm;
            cadastracliente.Show();
            cadastracliente.Top = 0;
            cadastracliente.Left = 0;
        }
        private void FormOSPesquisa_Load(object sender, EventArgs e)
        {
            txtDataSolicitacao.Value = DateTime.Now;
            txtDataSolicitacao2.Value = DateTime.Now;

            //PESQUISA TODAS AS OS CADASTRADA

            txtDataSolicitacao.Value.DayOfWeek.ToString();
            txtDataSolicitacao2.Value.DayOfWeek.ToString();

            //txtPesquisaMSOs.AutoCompleteMode = AutoCompleteMode.Suggest;
            //txtPesquisaMSOs.AutoCompleteSource = AutoCompleteSource.CustomSource;
            //txtPesquisaMSOs.AutoCompleteCustomSource = FormOSPesquisa.LoadAutoCompleteMsOs();

        }
        public void AlteraBotoes(int op)
        {
            if (op == 1)// Cadastra Cliente campos
            {

            }
            if (op == 2)//salvar Cadastro de Cliente
            {
                buttonCancelarOs.Enabled = false;
                buttonFecharOs.Enabled = true;


            }
            if (op == 3)//Calcelar Cadastro de Cliente
            {
                buttonCancelarOs.Enabled = false;
                buttonFecharOs.Enabled = true;

            }
            if (op == 4) //  Editar Cadastro de Cliente
            {
                buttonCancelarOs.Enabled = true;
                buttonFecharOs.Enabled = true;


            }
            if (op == 5)//Cancela Pesquisa
            {

                radioButtonOculto.Checked = true;
                radioButtonPequisaMS.Enabled = false;
                radioButtonPesquisaNome.Enabled = false;
            }
            if (op == 6)//Pesquisa Com suscesso!
            {
                buttonCancelarOs.Enabled = true;
                buttonFecharOs.Enabled = true;
            }
            if (op == 7)//Botão Verificar informações Passadas
            {

            }
            if (op == 8)//Libera Pessoa Fisica e Juridica!
            {

            }
            if (op == 9)//Libera Pesquisa Por MS e Nome.
            {
                buttonCancelarOs.Enabled = true;
                buttonFecharOs.Enabled = true;

            }
            if (op == 10)//limpa textos
            {

            }

        }      
        public int Verificador(int Aberto, int Processo, int Fechado)
        {

            int soma = 0;

            soma = Aberto + Processo + Fechado + soma;

            return soma;
        }
        public int Verificador1(int Todos)
        {

            int soma = 0;

            soma = Todos + soma;

            return soma;
        }
        public int Verificador2(int Os)
        {

            int soma = 0;

            soma = Os + soma;

            return soma;
        }
        private void buttonPesquisaCliente_Click(object sender, EventArgs e)
        {
            PesquisaOs();
        }
        public void PesquisaOs()
        {
            this.Todos = 0;
            this.Aberto = 0;
            this.Processo = 0;
            this.Fechado = 0;
            this.OS = 0;


            if (checkBoxTodos.Checked == true)
            {
                this.Todos = 1;
            }
            if (checkBoxEstadoA.Checked == true)
            {
                this.Aberto = 1;
            }
            if (checkBoxEstadoP.Checked == true)
            {
                this.Processo = 2;
            }
            if (checkBoxEstadoF.Checked == true)
            {
                this.Fechado = 3;
            }
            if (checkBoxOs.Checked == true)
            {
                this.OS = 1;
            }
            Verificador1(Todos);
            Verificador(Aberto, Processo, Fechado);

            int operadorA = Verificador1(Todos);
            int operadorB = Verificador(Aberto, Processo, Fechado);
            int operadorC = Verificador2(OS);
            int operadorAB = Verificador(Aberto, Processo, Fechado) + Verificador1(Todos);

            SqlConnection conn = new SqlConnection(this.connetionString);

            if (!(radioButtonTodosClientes.Checked == true) && !(radioButtonPequisaMS.Checked == true) && !(radioButtonPesquisaNome.Checked == true) &&
                !(radioButtonPesquisaData.Checked == true))
            {
                MessageBox.Show("Seleciona um modo de busca, por MS , Nome , Período de Data!");
            }

            else if (radioButtonTodosClientes.Checked)
            {
                //dataGridViewPesquisa.Columns.Clear();
                dataGridViewPesquisa.Refresh();

                if (operadorA == 1 && operadorB == 0)
                {
                    this.Aberto = 1;
                    this.Processo = 2;
                    this.Fechado = 3;
                    this.Todos = 0;

                    //SELECIONA POR TODOS OS 
                    SqlDataAdapter da1 = new SqlDataAdapter("Exec D_O_ConsultaOstodostxt " + "1,2,3,1 ;", conn);
                    DataSet ds1 = new DataSet();
                    da1.Fill(ds1);

                    conn.Open();

                    if (!(ds1.Tables[0].Rows.Count > 0))
                    {
                        if (dataGridViewPesquisa.DataSource == null)
                        {
                            dataGridViewPesquisa.Refresh();
                        }
                        if (!(dataGridViewPesquisa.DataSource == null))
                        {
                            //dataGridViewPesquisa.Columns.Clear();
                            dataGridViewPesquisa.Refresh();
                        }
                        label8.Text = dataGridViewPesquisa.RowCount.ToString();
                        MessageBox.Show("Nem um Registro de OS Achado!");

                        conn.Close();
                    }
                    if (ds1.Tables[0].Rows.Count > 0)
                    {
                        this.Aberto = 1;
                        this.Processo = 2;
                        this.Fechado = 3;
                        this.Todos = 0;

                        ValorPesquisa = 1;
                        dataGridViewPesquisaTodos();
                        label8.Text = dataGridViewPesquisa.RowCount.ToString();

                    }
                }
                if (operadorC == 1)
                {
                    if (txtOrdemServico.Text == "")
                    {
                        if (dataGridViewPesquisa.DataSource == null)
                        {
                            dataGridViewPesquisa.Refresh();
                        }
                        if (!(dataGridViewPesquisa.DataSource == null))
                        {
                            // dataGridViewPesquisa.Columns.Clear();
                            dataGridViewPesquisa.Refresh();
                        }

                        label8.Text = dataGridViewPesquisa.RowCount.ToString();

                        MessageBox.Show("A os não pode esta em Branco!");
                    }
                    if (!(txtOrdemServico.Text == ""))
                    {
                        //SELECIONA POR TODOS OS 
                        SqlDataAdapter da1 = new SqlDataAdapter("EXEC D_O_ConsultaOstxt '" + txtOrdemServico.Text + "',1;", conn);
                        DataSet ds1 = new DataSet();
                        da1.Fill(ds1);

                        conn.Open();

                        if (!(ds1.Tables[0].Rows.Count > 0))
                        {
                            if (dataGridViewPesquisa.DataSource == null)
                            {
                                dataGridViewPesquisa.Refresh();
                            }
                            if (!(dataGridViewPesquisa.DataSource == null))
                            {
                                // dataGridViewPesquisa.Columns.Clear();
                                dataGridViewPesquisa.Refresh();
                            }
                            label8.Text = dataGridViewPesquisa.RowCount.ToString();

                            MessageBox.Show("Nem um Registro de OS Achado!");

                            conn.Close();
                        }
                        if (ds1.Tables[0].Rows.Count > 0)
                        {
                            dataGridViewPesquisaOs();
                            ValorPesquisa = 5;
                            label8.Text = dataGridViewPesquisa.RowCount.ToString();
                        }
                    }
                }
                //Só Pode escolher todos em chexbox não mas nem um!
                if (operadorA == 1 && operadorB > 0)
                {
                    //SELECIONA POR TODOS OS 
                    SqlDataAdapter da1 = new SqlDataAdapter("Exec D_O_ConsultaOstodostxt " + this.Aberto + "," + this.Processo + "," + this.Fechado + ",1;", conn);
                    DataSet ds1 = new DataSet();
                    da1.Fill(ds1);

                    conn.Open();
                    if (!(ds1.Tables[0].Rows.Count > 0))
                    {
                        if (dataGridViewPesquisa.DataSource == null)
                        {
                            dataGridViewPesquisa.Refresh();
                        }
                        if (!(dataGridViewPesquisa.DataSource == null))
                        {
                            //dataGridViewPesquisa.Columns.Clear();
                            dataGridViewPesquisa.Refresh();
                        }
                        label8.Text = dataGridViewPesquisa.RowCount.ToString();

                        MessageBox.Show("Nem um Registro de OS Achado!");

                        conn.Close();
                    }
                    if (ds1.Tables[0].Rows.Count > 0)
                    {
                        conn.Close();

                        dataGridViewPesquisaTodos();
                        ValorPesquisa = 1;
                        label8.Text = dataGridViewPesquisa.RowCount.ToString();
                    }
                }
                if (operadorA == 0 && operadorB > 0)
                {
                    //SELECIONA POR TODOS OS 
                    SqlDataAdapter da1 = new SqlDataAdapter("Exec D_O_ConsultaOstodostxt " + this.Aberto + "," + this.Processo + "," + this.Fechado + ",1;", conn);
                    DataSet ds1 = new DataSet();
                    da1.Fill(ds1);

                    conn.Open();
                    if (!(ds1.Tables[0].Rows.Count > 0))
                    {
                        dataGridViewPesquisa.Refresh();
                        label8.Text = dataGridViewPesquisa.RowCount.ToString();

                        MessageBox.Show("Nem um Registro de OS Achado!");

                        conn.Close();
                    }
                    if (ds1.Tables[0].Rows.Count > 0)
                    {
                        conn.Close();
                        dataGridViewPesquisaTodos();
                        ValorPesquisa = 1;
                        label8.Text = dataGridViewPesquisa.RowCount.ToString();
                    }
                }
                if (operadorA == 0 && operadorB > 0)
                {
                    //SELECIONA POR TODOS OS 
                    SqlDataAdapter da1 = new SqlDataAdapter("Exec D_O_ConsultaOstodostxt " + this.Aberto + "," + this.Processo + "," + this.Fechado + ",1;", conn);
                    DataSet ds1 = new DataSet();
                    da1.Fill(ds1);

                    conn.Open();
                    if (!(ds1.Tables[0].Rows.Count > 0))
                    {
                        if (dataGridViewPesquisa.DataSource == null)
                        {
                            dataGridViewPesquisa.Refresh();
                        }
                        if (!(dataGridViewPesquisa.DataSource == null))
                        {
                            //dataGridViewPesquisa.Columns.Clear();
                            dataGridViewPesquisa.Refresh();
                        }
                        label8.Text = dataGridViewPesquisa.RowCount.ToString();

                        MessageBox.Show("Nem um Registro de OS Achado!");
                        conn.Close();
                    }
                    if (ds1.Tables[0].Rows.Count > 0)
                    {
                        conn.Close();

                        dataGridViewPesquisaTodos();
                        ValorPesquisa = 1;
                        label8.Text = dataGridViewPesquisa.RowCount.ToString();
                    }
                }
                if (operadorA == 0 && operadorB == 0 && operadorC == 0)
                {
                    MessageBox.Show("Por Favor Seleciona A ESCOLHA A ou alguma opção de ESCOLHA B!");
                }
            }
            if (radioButtonPequisaMS.Checked)
            {
                if (txtPesquisaMSOs.Text == "")
                {
                    //dataGridViewPesquisa.Columns.Clear();
                    dataGridViewPesquisa.Refresh();

                    label8.Text = dataGridViewPesquisa.RowCount.ToString();
                    VALORPESQUISA = 0;
                    MessageBox.Show("O Ms não pode esta em Branco!");
                }
                if (!(txtPesquisaMSOs.Text == ""))
                {
                    if (operadorA == 1 && operadorB == 0)
                    {
                        //SELECIONA POR TODOS OS 
                        SqlDataAdapter da1 = new SqlDataAdapter("EXEC D_O_ConsultaMsOstxt '" + txtPesquisaMSOs.Text + "',1,2,3,1;", conn);
                        DataSet ds1 = new DataSet();
                        da1.Fill(ds1);

                        conn.Open();

                        if (!(ds1.Tables[0].Rows.Count > 0))
                        {
                            if (dataGridViewPesquisa.DataSource == null)
                            {
                                dataGridViewPesquisa.Refresh();
                            }
                            if (!(dataGridViewPesquisa.DataSource == null))
                            {
                                //ValorPesquisa = 2;
                                //dataGridViewPesquisa.Columns.Clear();
                                dataGridViewPesquisa.Refresh();
                            }
                            label8.Text = dataGridViewPesquisa.RowCount.ToString();
                            VALORPESQUISA = 0;
                            MessageBox.Show("Nem um Registro de OS Achado!");
                            conn.Close();
                        }
                        if (ds1.Tables[0].Rows.Count > 0)
                        {
                            conn.Close();

                            this.Aberto = 1;
                            this.Processo = 2;
                            this.Fechado = 3;
                            this.Todos = 0;

                            dataGridViewPesquisaMS();
                            label8.Text = dataGridViewPesquisa.RowCount.ToString();
                        }
                    }
                    //Só Pode escolher todos em chexbox não mas nem um!
                    if (operadorA == 1 && operadorB > 0)
                    {
                        //SELECIONA POR TODOS OS 
                        SqlDataAdapter da2 = new SqlDataAdapter("EXEC D_O_ConsultaMsOstxt " + txtPesquisaMSOs.Text + "," + Aberto + "," + Processo + "," + Fechado + ",1;", conn);
                        DataSet ds1 = new DataSet();
                        da2.Fill(ds1);

                        conn.Open();

                        if (!(ds1.Tables[0].Rows.Count > 0))
                        {
                            if (dataGridViewPesquisa.DataSource == null)
                            {
                                dataGridViewPesquisa.Refresh();
                            }
                            if (!(dataGridViewPesquisa.DataSource == null))
                            {
                                //dataGridViewPesquisa.Columns.Clear();
                                dataGridViewPesquisa.Refresh();
                            }
                            label8.Text = dataGridViewPesquisa.RowCount.ToString();
                            VALORPESQUISA = 0;
                            MessageBox.Show("Nem um Registro de OS Achado!");

                            conn.Close();
                        }
                        if (ds1.Tables[0].Rows.Count > 0)
                        {
                            conn.Close();

                            ValorPesquisa = 2;
                            dataGridViewPesquisaMS();
                            label8.Text = dataGridViewPesquisa.RowCount.ToString();
                        }
                    }
                    if (operadorA == 0 && operadorB == 0)
                    {
                        if (dataGridViewPesquisa.DataSource == null)
                        {
                            dataGridViewPesquisa.Refresh();
                        }
                        if (!(dataGridViewPesquisa.DataSource == null))
                        {
                            //ValorPesquisa = 2;
                            // dataGridViewPesquisa.Columns.Clear();
                            dataGridViewPesquisa.Refresh();
                        }
                        label8.Text = dataGridViewPesquisa.RowCount.ToString();

                        MessageBox.Show("Por Favor Seleciona pelo menos uma opção!");
                        VALORPESQUISA = 0;

                        conn.Close();
                    }
                    if (operadorA == 0 && operadorB > 0)
                    {
                        //SELECIONA POR TODOS OS 
                        SqlDataAdapter da2 = new SqlDataAdapter("EXEC D_O_ConsultaMsOstxt " + txtPesquisaMSOs.Text + "," + Aberto + "," + Processo + "," + Fechado + ",1;", conn);
                        DataSet ds1 = new DataSet();
                        da2.Fill(ds1);

                        conn.Open();

                        if (!(ds1.Tables[0].Rows.Count > 0))
                        {
                            if (dataGridViewPesquisa.DataSource == null)
                            {
                                dataGridViewPesquisa.Refresh();
                            }
                            if (!(dataGridViewPesquisa.DataSource == null))
                            {
                                //dataGridViewPesquisa.Columns.Clear();
                            }
                            label8.Text = dataGridViewPesquisa.RowCount.ToString();

                            MessageBox.Show("Nem um Registro de OS Achado!");
                            VALORPESQUISA = 0;

                            conn.Close();
                        }
                        if (ds1.Tables[0].Rows.Count > 0)
                        {
                            conn.Close();
                            ValorPesquisa = 2;
                            dataGridViewPesquisaMS();
                            label8.Text = dataGridViewPesquisa.RowCount.ToString();
                        }
                    }
                }
            }
            if (radioButtonPesquisaNome.Checked)
            {
                if (txtPesquisaNomeOs.Text == "")
                {
                    if (dataGridViewPesquisa.DataSource == null)
                    {
                        dataGridViewPesquisa.Refresh();
                    }
                    if (!(dataGridViewPesquisa.DataSource == null))
                    {
                        //dataGridViewPesquisa.Columns.Clear();
                        dataGridViewPesquisa.Refresh();
                    }
                    label8.Text = dataGridViewPesquisa.RowCount.ToString();
                    VALORPESQUISA = 0;
                    MessageBox.Show("O Nome não pode esta em Branco!");
                }
                if (!(txtPesquisaNomeOs.Text == ""))
                {
                    if (operadorA == 1 && operadorB == 0)
                    {
                        //SELECIONA POR TODOS OS 
                        SqlDataAdapter da1 = new SqlDataAdapter("EXEC D_O_ConsultaNomeOstxt '" + txtPesquisaNomeOs.Text + "',1,2,3,1 ;", conn);
                        DataSet ds1 = new DataSet();
                        da1.Fill(ds1);

                        conn.Open();

                        if (!(ds1.Tables[0].Rows.Count > 0))
                        {
                            if (dataGridViewPesquisa.DataSource == null)
                            {
                                dataGridViewPesquisa.Refresh();
                            }
                            if (!(dataGridViewPesquisa.DataSource == null))
                            {
                                //dataGridViewPesquisa.Columns.Clear();
                                dataGridViewPesquisa.Refresh();
                            }
                            MessageBox.Show("Nem um Registro de OS Achado!");
                            VALORPESQUISA = 0;
                            conn.Close();
                        }
                        if (ds1.Tables[0].Rows.Count > 0)
                        {
                            conn.Close();

                            this.Aberto = 1;
                            this.Processo = 2;
                            this.Fechado = 3;
                            this.Todos = 0;

                            dataGridViewPesquisaNome();
                            label8.Text = dataGridViewPesquisa.RowCount.ToString();
                            ValorPesquisa = 3;
                        }
                    }
                    //Só Pode escolher todos em chexbox não mas nem um!
                    if (operadorA == 1 && operadorB > 0)
                    {
                        //SELECIONA POR TODOS OS 
                        SqlDataAdapter da2 = new SqlDataAdapter("EXEC D_O_ConsultaNomeOstxt '" + txtPesquisaNomeOs.Text + "'," + Aberto + "," + Processo + "," + Fechado + ",1;", conn);
                        DataSet ds1 = new DataSet();
                        da2.Fill(ds1);

                        conn.Open();

                        if (!(ds1.Tables[0].Rows.Count > 0))
                        {
                            if (dataGridViewPesquisa.DataSource == null)
                            {
                                dataGridViewPesquisa.Refresh();
                            }
                            if (!(dataGridViewPesquisa.DataSource == null))
                            {
                                // dataGridViewPesquisa.Columns.Clear();
                                dataGridViewPesquisa.Refresh();
                            }
                            label8.Text = dataGridViewPesquisa.RowCount.ToString();
                            VALORPESQUISA = 0;
                            MessageBox.Show("Nem um Registro de OS Achado!");

                            conn.Close();
                        }
                        if (ds1.Tables[0].Rows.Count > 0)
                        {
                            ValorPesquisa = 3;
                            dataGridViewPesquisaNome();
                            label8.Text = dataGridViewPesquisa.RowCount.ToString();
                            conn.Close();
                        }
                    }
                    if (operadorA == 0 && operadorB == 0)
                    {
                        if (dataGridViewPesquisa.DataSource == null)
                        {
                            dataGridViewPesquisa.Refresh();
                        }
                        if (!(dataGridViewPesquisa.DataSource == null))
                        {
                            //dataGridViewPesquisa.Columns.Clear();
                            dataGridViewPesquisa.Refresh();
                        }
                        label8.Text = dataGridViewPesquisa.RowCount.ToString();
                        VALORPESQUISA = 0;
                        MessageBox.Show("Por Favor Seleciona pelo menos uma opção!");

                        conn.Close();
                    }
                    if (operadorA == 0 && operadorB > 0)
                    {
                        //SELECIONA POR TODOS OS 
                        SqlDataAdapter da1 = new SqlDataAdapter("EXEC D_O_ConsultaNomeOstxt '" + txtPesquisaNomeOs.Text + "'," + Aberto + "," + Processo + "," + Fechado + ",1;", conn);
                        DataSet ds1 = new DataSet();
                        da1.Fill(ds1);

                        conn.Open();

                        if (!(ds1.Tables[0].Rows.Count > 0))
                        {
                            if (dataGridViewPesquisa.DataSource == null)
                            {
                                dataGridViewPesquisa.Refresh();
                            }
                            if (!(dataGridViewPesquisa.DataSource == null))
                            {
                                //dataGridViewPesquisa.Columns.Clear();
                                dataGridViewPesquisa.Refresh();
                            }
                            MessageBox.Show("Nem um Registro de OS Achado!");
                            VALORPESQUISA = 0;
                            conn.Close();
                        }
                        if (ds1.Tables[0].Rows.Count > 0)
                        {
                            conn.Close();
                            dataGridViewPesquisaNome();
                            ValorPesquisa = 3;
                            label8.Text = dataGridViewPesquisa.RowCount.ToString();
                        }
                    }
                }
            }
            if (radioButtonPesquisaData.Checked)
            {
                string DataInicial = txtDataSolicitacao.Value.ToShortDateString();

                string DataFinal = txtDataSolicitacao2.Value.ToShortDateString();

                if (txtDataSolicitacao.Value.Date.CompareTo(txtDataSolicitacao2.Value.Date) > 0)
                {
                    if (dataGridViewPesquisa.DataSource == null)
                    {
                        dataGridViewPesquisa.Refresh();
                    }
                    if (!(dataGridViewPesquisa.DataSource == null))
                    {
                        //dataGridViewPesquisa.Columns.Clear();
                        dataGridViewPesquisa.Refresh();
                    }
                    label8.Text = dataGridViewPesquisa.RowCount.ToString();

                    MessageBox.Show("Data Inicial não pode Se Maior que Data Final!");
                }
                if (txtDataSolicitacao.Value.Date.CompareTo(txtDataSolicitacao2.Value.Date) <= 0)
                {
                    if (operadorA == 0 && operadorB == 0)
                    {
                        if (dataGridViewPesquisa.DataSource == null)
                        {
                            dataGridViewPesquisa.Refresh();
                        }
                        if (!(dataGridViewPesquisa.DataSource == null))
                        {
                            //dataGridViewPesquisa.Columns.Clear();
                            dataGridViewPesquisa.Refresh();
                        }
                        label8.Text = dataGridViewPesquisa.RowCount.ToString();
                        VALORPESQUISA = 0;
                        MessageBox.Show("Por Favor Seleciona pelo menos uma opção!");
                        conn.Close();
                    }
                    if (operadorA == 1 && operadorB == 0)
                    {
                        //SELECIONA POR TODOS OS 
                        SqlDataAdapter da1 = new SqlDataAdapter("EXEC D_O_ConsultaDataOstxt '" + DataInicial + "','" + DataFinal + "',1;", conn);
                        DataSet ds1 = new DataSet();
                        da1.Fill(ds1);

                        conn.Open();

                        if (!(ds1.Tables[0].Rows.Count > 0))
                        {
                            if (dataGridViewPesquisa.DataSource == null)
                            {
                                dataGridViewPesquisa.Refresh();
                            }
                            if (!(dataGridViewPesquisa.DataSource == null))
                            {
                                //dataGridViewPesquisa.Columns.Clear();
                                dataGridViewPesquisa.Refresh();
                            }
                            label8.Text = dataGridViewPesquisa.RowCount.ToString();
                            VALORPESQUISA = 0;
                            MessageBox.Show("Nem um Registro de OS Achado!");
                            conn.Close();
                        }
                        if (ds1.Tables[0].Rows.Count > 0)
                        {
                            conn.Close();
                            SqlConnection conn1 = new SqlConnection(this.connetionString);
                            string sql = "EXEC D_O_ConsultaDataOstxt '" + DataInicial + "','" + DataFinal + "',1;";
                            SqlDataAdapter sda = new SqlDataAdapter(sql, conn1);
                            DataTable ds2 = new DataTable();
                            sda.Fill(ds2);
                            dataGridViewPesquisa.DataSource = ds2;
                            label8.Text = dataGridViewPesquisa.RowCount.ToString();
                            ValorPesquisa = 4;
                            conn1.Close();
                        }
                    }
                    if (operadorA == 1 && operadorB > 0)
                    {
                        //SELECIONA POR TODOS OS 
                        SqlDataAdapter da1 = new SqlDataAdapter("EXEC D_O_ConsultaDataOsNtxt '" + DataInicial + "','" + DataFinal + "'," + Aberto + "," + Processo + "," + Fechado + ",1;", conn);
                        DataSet ds1 = new DataSet();
                        da1.Fill(ds1);

                        conn.Open();

                        if (!(ds1.Tables[0].Rows.Count > 0))
                        {
                            if (dataGridViewPesquisa.DataSource == null)
                            {
                                dataGridViewPesquisa.Refresh();
                            }
                            if (!(dataGridViewPesquisa.DataSource == null))
                            {
                                //dataGridViewPesquisa.Columns.Clear();
                                dataGridViewPesquisa.Refresh();
                            }
                            label8.Text = dataGridViewPesquisa.RowCount.ToString();
                            VALORPESQUISA = 0;
                            MessageBox.Show("Nem um Registro de OS Achado!");
                            conn.Close();
                        }
                        if (ds1.Tables[0].Rows.Count > 0)
                        {
                            conn.Close();
                            SqlConnection conn1 = new SqlConnection(this.connetionString);
                            string sql = "EXEC D_O_ConsultaDataOsNtxt '" + DataInicial + "','" + DataFinal + "'," + Aberto + "," + Processo + "," + Fechado + ",1;";
                            SqlDataAdapter sda = new SqlDataAdapter(sql, conn1);
                            DataTable ds2 = new DataTable();
                            sda.Fill(ds2);
                            dataGridViewPesquisa.DataSource = ds2;
                            ValorPesquisa = 4;
                            label8.Text = dataGridViewPesquisa.RowCount.ToString();
                            conn1.Close();
                        }
                    }
                }
            }
        }
        private void radioButtonTodosClientes_CheckedChanged(object sender, EventArgs e)
        {
            panelEstado.Enabled = true;
            txtPesquisaMSOs.Enabled = false;
            txtPesquisaNomeOs.Enabled = false;
            txtDataSolicitacao.Enabled = false;
            txtDataSolicitacao2.Enabled = false;
            radioButtonPequisaMS.Enabled = true;
            radioButtonPesquisaNome.Enabled = true;
            radioButtonPesquisaData.Enabled = true;
            txtDataSolicitacao.Enabled = false;
            txtDataSolicitacao2.Enabled = false;
            txtPesquisaNomeOs.Clear();
            txtPesquisaMSOs.Clear();
            txtOrdemServico.Clear();

            checkBoxTodos.Checked = true;
            checkBoxEstadoA.Checked = false;
            checkBoxEstadoP.Checked = false;
            checkBoxEstadoF.Checked = false;
            checkBoxOs.Enabled = true;
  
            //dataGridViewPesquisa.Columns.Clear();
            //dataGridViewPesquisa.Refresh();
            label8.Text = dataGridViewPesquisa.RowCount.ToString();

        }

        private void checkBoxOs_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxOs.Checked == true)
            {
                txtOrdemServico.Enabled = true;
                checkBoxTodos.Checked = false;
                checkBoxEstadoA.Checked = false;
                checkBoxEstadoP.Checked = false;
                checkBoxEstadoF.Checked = false;
            }
            if (checkBoxOs.Checked == false)
            {
                txtOrdemServico.Enabled = false;
                checkBoxTodos.Checked = false;
                checkBoxEstadoA.Checked = false;
                checkBoxEstadoP.Checked = false;
                checkBoxEstadoF.Checked = false;
                txtOrdemServico.Clear();
            }
        }public void EditarOs()
        {

        }
        private void dataGridViewPesquisa_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FecharFormOSPesquisaEditar();

            if ((dataGridViewPesquisa.RowCount == 0) && (OsVisualizar == 0))
            {
                try
                {

                }
                catch (Exception ex)
                {
                    ex.ToString();
                }
            }
            if (!(dataGridViewPesquisa.RowCount == 0) && (OsVisualizar == 1))
            {
                try
                {
                    this.IdOs = Convert.ToInt32(dataGridViewPesquisa["ORDEM_SERVIÇO", e.RowIndex].Value);
                    //id = Convert.ToInt32(dataGridViewPesquisa.CurrentRow.Cells[0].Value.ToString());
                    //id = Convert.ToInt32(dataGridViewPesquisa.Rows[e.RowIndex].Cells["ORDEM_SERVIÇO"].Value.ToString());

                    SqlConnection conn1 = new SqlConnection(this.connetionString);
                    string sql1 = "exec D_O_ConsultaIdPessoaOs " + IdOs;
                    SqlDataAdapter sda1 = new SqlDataAdapter(sql1, conn1);
                    DataSet ds1 = new DataSet();
                    sda1.Fill(ds1);
                    conn1.Open();

                    int ID_Cliente =  int.Parse(ds1.Tables[0].Rows[0][0].ToString());
                    this.IdCLiente = ID_Cliente;

                    FormOSPesquisaEditar OSPesquisaE = new FormOSPesquisaEditar(this.IdOs,this.OSEDITAR, this.OSEXCLUIR, this.IdPessoaLogada, this.ClienteCCadastra,
                        this.IdCLiente, this.connetionString);
                    OSPesquisaE.MdiParent = FormOSPesquisaEditar.ActiveForm;
                    OSPesquisaE.Show();
                    OSPesquisaE.Top = 0;

                }
                catch (Exception ex)
                {
                    ex.ToString();
                }
            }
        }

        private void txtPesquisaNomeOs_TextChanged(object sender, EventArgs e)
        {
            if (ValorPesquisa == 3)
            {
                DataView DV = new DataView(TableNome);
                DV.RowFilter = string.Format("CLIENTE LIKE '%{0}%'", txtPesquisaNomeOs.Text);
                dataGridViewPesquisa.DataSource = DV;
                label8.Text = dataGridViewPesquisa.RowCount.ToString();
            }
        }

        private void buttonTeste_Click(object sender, EventArgs e)
        {

        }
        void dataGridViewPesquisaTodos()
        {
            string connetionString = (this.connetionString);
            SqlConnection connection = new SqlConnection(connetionString);
            SqlCommand command = new SqlCommand("Exec D_O_ConsultaOstodostxt " + this.Aberto + "," + this.Processo + "," + this.Fechado + ",1;", connection);
            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = command;
                TableTodos = new DataTable();
                adapter.Fill(TableTodos);
                BindingSource Source = new BindingSource();
                Source.DataSource = TableTodos;
                dataGridViewPesquisa.DataSource = Source;
                adapter.Update(TableTodos);

            }
            catch (Exception ex)
            {
                ex.ToString();
            }

            //DataTable dt = new DataTable();
        }
        void dataGridViewPesquisaOs()
        {
            SqlConnection connection = new SqlConnection(this.connetionString);
            SqlCommand command = new SqlCommand("Exec D_O_ConsultaOstxt " + txtOrdemServico.Text + ",1;", connection);
            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = command;
                TableOs = new DataTable();
                adapter.Fill(TableOs);
                BindingSource Source = new BindingSource();
                Source.DataSource = TableOs;
                dataGridViewPesquisa.DataSource = Source;
                adapter.Update(TableOs);

            }
            catch (Exception ex)
            {
                ex.ToString();
            }

            //DataTable dt = new DataTable();
        }
        void dataGridViewPesquisaMS()
        {
            SqlConnection connection = new SqlConnection(this.connetionString);
            SqlCommand command = new SqlCommand("Exec D_O_ConsultaMsOstxt '" + txtPesquisaMSOs.Text + "'," + this.Aberto + "," + this.Processo + "," + this.Fechado + ",1;", connection);
            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = command;
                TableMs = new DataTable();
                adapter.Fill(TableMs);
                BindingSource Source = new BindingSource();
                Source.DataSource = TableMs;
                dataGridViewPesquisa.DataSource = Source;
                adapter.Update(TableMs);
            }
            catch (Exception ex)
            {
                ex.ToString();
            }

            //DataTable dt = new DataTable();
        }
        void dataGridViewPesquisaNome()
        {
            SqlConnection connection = new SqlConnection(this.connetionString);
            SqlCommand command = new SqlCommand("Exec D_O_ConsultaNomeOstxt '" + txtPesquisaNomeOs.Text+ "'," + this.Aberto + "," + this.Processo + "," + this.Fechado + ",1;", connection);
            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = command;
                TableNome = new DataTable();
                adapter.Fill(TableNome);
                BindingSource Source = new BindingSource();
                Source.DataSource = TableNome;
                dataGridViewPesquisa.DataSource = Source;
                adapter.Update(TableNome);

            }
            catch (Exception ex)
            {
                ex.ToString();
            }
            //DataTable dt = new DataTable();
        }
        private void txtPesquisaMSOs_TextChanged(object sender, EventArgs e)
        {
            if(ValorPesquisa == 2)
            {
                DataView DV = new DataView(TableMs);
                DV.RowFilter = string.Format("MS LIKE '%{0}%'", int.Parse(txtPesquisaMSOs.Text));
                dataGridViewPesquisa.DataSource = DV;
                label8.Text = dataGridViewPesquisa.RowCount.ToString();
                
            }
        }

        private void txtOrdemServico_TextChanged(object sender, EventArgs e)
        {
            if(ValorPesquisa == 5)
            {
                DataView DV = new DataView(TableMs);
                DV.RowFilter = string.Format("ORDEM_SERVIÇO LIKE '%{0}%'", txtOrdemServico.Text);
                dataGridViewPesquisa.DataSource = DV;
                label8.Text = dataGridViewPesquisa.RowCount.ToString();
            }
        }

        private void buttonLimpaOs_Click(object sender, EventArgs e)
        {

        }
        

        private void txtPesquisaMSOs_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Se a tecla digitada não for número
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }
            if (e.KeyChar == 13)
            {
                PesquisaOs();
            }
        }

        private void txtPesquisaNomeOs_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                PesquisaOs();
            }
        }

        private void txtOrdemServico_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                PesquisaOs();
            }
        }

        private void FormOSPesquisa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
            {
                this.Close();
            }
        }
    }
}
