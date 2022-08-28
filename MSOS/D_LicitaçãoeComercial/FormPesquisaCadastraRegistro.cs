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
    public partial class FormPesquisaCadastraRegistro : Form
    {
        Form Pai;
        DataTable TableNome;
        DataTable TableMs;
        DataTable TableTodos;
        DataTable TableOs;

        private int ID_REGISTROE = 0;
        public int IdRegistro
        {
            get
            {
                return this.ID_REGISTROE;

            }
            set
            {
                this.ID_REGISTROE = value;
            }
        }
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
        private int NUMERO_REGISTRO = 0;
        public int NumeroRegistro
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
        private int REGISTROPESQUISA = 0;
        public int RegistroPesquisa
        {
            get
            {
                return this.REGISTROPESQUISA;

            }
            set
            {
                this.REGISTROPESQUISA = value;
            }
        }
        private int REGISTROVISUALIZAR = 0;
        public int RegistroVisualizar
        {
            get
            {
                return this.REGISTROVISUALIZAR;

            }
            set
            {
                this.REGISTROVISUALIZAR = value;
            }
        }
        private int REGISTROEDITAR = 0;
        public int RegistroEditar
        {
            get
            {
                return this.REGISTROEDITAR;

            }
            set
            {
                this.REGISTROEDITAR = value;
            }
        }
        private int REGISTROCADASTRA = 0;
        public int RegistroCadastra
        {
            get
            {
                return this.REGISTROCADASTRA;

            }
            set
            {
                this.REGISTROCADASTRA = value;
            }
        }
        private int REGISTROEXCLUIR = 0;
        public int RegistroExcluir
        {
            get
            {
                return this.REGISTROEXCLUIR;

            }
            set
            {
                this.REGISTROEXCLUIR = value;
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
        private int ATIVO = 0;
        public int Ativo
        {
            get
            {
                return this.ATIVO;

            }
            set
            {
                this.ATIVO = value;
            }
        }
        private int REGISTROCCCADASTRA = 0;
        public int RegistroCCCadastra
        {
            get
            {
                return this.REGISTROCCCADASTRA;

            }
            set
            {
                this.REGISTROCCCADASTRA = value;
            }
        }
        public FormPesquisaCadastraRegistro()
        {
            InitializeComponent();
        }
        public FormPesquisaCadastraRegistro(Form filho, int IdUsuarioAcesso, string NomeAcesso,
            string NomeServidor,string NomeBaseDados, string NomeUsuario, string SenhaBaseDados,
            int RegistroVisualizar,int RegistroEditar, int RegistroExcluir,int REGISTROCADASTRA, 
            int RegistroCCCadastra)
        {
            try
            {
                InitializeComponent();

                this.IdPessoaLogada = IdUsuarioAcesso;
                this.NomeAcesso = NomeAcesso;
                this.NomeServidor = NomeServidor;
                this.NomeBaseDados = NomeBaseDados;
                this.NomeUsuario = NomeUsuario;
                this.SenhaBaseDados = SenhaBaseDados;
                this.RegistroVisualizar = RegistroVisualizar;
                this.RegistroEditar = RegistroEditar;
                this.RegistroExcluir = RegistroExcluir;
                this.RegistroCadastra = REGISTROCADASTRA;
                this.RegistroCCCadastra = RegistroCCCadastra;

                Pai = filho;
                this.txtDataSolicitacao.Value = DateTime.Now.Date;

                this.txtDataSolicitacao2.Value = DateTime.Now.Date;

                this.connetionString = "Data Source=" + this.NomeServidor + ";Initial Catalog=" + this.NomeBaseDados + ";Persist Security Info=True;User ID=" + this.NomeUsuario + ";Password=" + this.SenhaBaseDados + ";";
            }
            catch ( Exception ex)
            {
                ex.ToString();
            }
        }
        private void FormPesquisaCadastraRegistro_Load(object sender, EventArgs e)
        {

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
        public int Verificador2(int NumeroRegistro)
        {

            int soma = 0;

            soma = NumeroRegistro + soma;

            return soma;
        }

        private void buttonPesquisaCliente_Click(object sender, EventArgs e)
        {
            PesquisaRegistro();
        }
        public void PesquisaRegistro()
        {
            try
            {
                this.Todos = 0;
                this.Aberto = 0;
                this.Processo = 0;
                this.Fechado = 0;
                this.NumeroRegistro = 0;
    
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
                if (checkBoxRegistro.Checked == true)
                {
                    this.NumeroRegistro = 1;
                }

                if (checkBoxSituacao.Checked == true)
                {
                    this.Ativo = 1;
                }
                if (checkBoxSituacao.Checked == false)
                {
                    this.Ativo = 2;
                }
                Verificador1(Todos);
                Verificador(Aberto, Processo, Fechado);

                int operadorA = Verificador1(Todos);
                int operadorB = Verificador(Aberto, Processo, Fechado);
                int operadorC = Verificador2(NumeroRegistro);
                int operadorAB = Verificador(Aberto, Processo, Fechado) + Verificador1(Todos);

                SqlConnection conn = new SqlConnection(this.connetionString);

                if (!(radioButtonTodosClientes.Checked == true) && !(radioButtonPequisaNumero.Checked == true) && !(radioButtonPesquisaNome.Checked == true) &&
                    !(radioButtonPesquisaData.Checked == true))
                {
                    MessageBox.Show("Seleciona um modo de busca, por Todos, Número cliente , Nome , Período de Data e Número Registro!");
                }
                else if (radioButtonTodosClientes.Checked)
                {
                    dataGridViewPesquisa.Refresh();

                    if (operadorA == 1 && operadorB == 0)
                    {
                        //SELECIONA POR TODOS Registro 
                        SqlDataAdapter da1 = new SqlDataAdapter("Exec D_R_ConsultaRegistroGeradosTodosTxT " + this.Ativo + ",1,2,3;", conn);
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
                            label6.Text = dataGridViewPesquisa.RowCount.ToString();
                            MessageBox.Show("Nem um Registro Achado!");

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
                            label6.Text = dataGridViewPesquisa.RowCount.ToString();

                        }
                    }
                    
                    if (operadorA == 0 && operadorB > 0)
                    {
                        //SELECIONA POR TODOS OS 
                        SqlDataAdapter da1 = new SqlDataAdapter("Exec D_R_ConsultaRegistroGeradosTodosTxT " + this.Ativo + "," + this.Aberto + "," + this.Processo + "," + this.Fechado + ";", conn);
                        DataSet ds1 = new DataSet();
                        da1.Fill(ds1);

                        conn.Open();
                        if (!(ds1.Tables[0].Rows.Count > 0))
                        {
                            dataGridViewPesquisa.Refresh();
                            label6.Text = dataGridViewPesquisa.RowCount.ToString();

                            MessageBox.Show("Nem um Registro Achado!");

                            conn.Close();
                        }
                        if (ds1.Tables[0].Rows.Count > 0)
                        {
                            conn.Close();
                            dataGridViewPesquisaTodos();
                            ValorPesquisa = 1;
                            label6.Text = dataGridViewPesquisa.RowCount.ToString();
                        }
                    }
                    //Só Pode escolher todos em chexbox não mas nem um!
                    if (operadorA == 1 && operadorB > 0)
                    {
                        //SELECIONA POR TODOS OS 
                        SqlDataAdapter da1 = new SqlDataAdapter("Exec D_R_ConsultaRegistroGeradosTodosTxT " + this.Ativo + "," + this.Aberto + "," + this.Processo + "," + this.Fechado + ";", conn);
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
                            label6.Text = dataGridViewPesquisa.RowCount.ToString();

                            MessageBox.Show("Nem um Registro Achado!");

                            conn.Close();
                        }
                        if (ds1.Tables[0].Rows.Count > 0)
                        {
                            conn.Close();

                            dataGridViewPesquisaTodos();
                            ValorPesquisa = 1;
                            label6.Text = dataGridViewPesquisa.RowCount.ToString();
                        }
                    }
                    if (operadorC == 1)
                    {
                        if (txtNRegisto.Text == "")
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

                            label6.Text = dataGridViewPesquisa.RowCount.ToString();

                            MessageBox.Show("O número do registro não pode esta em Branco!");
                        }
                        if (!(txtNRegisto.Text == ""))
                        {
                            //SELECIONA POR TODOS OS 
                            SqlDataAdapter da1 = new SqlDataAdapter("EXEC D_R_ConsultaRegistroGeradosNRegistroTxT " + txtNRegisto.Text + "," + this.Ativo + ";", conn);
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
                                label6.Text = dataGridViewPesquisa.RowCount.ToString();

                                MessageBox.Show("Nem um Registro Achado!");

                                conn.Close();
                            }
                            if (ds1.Tables[0].Rows.Count > 0)
                            {
                                dataGridViewPesquisaRegistro();
                                ValorPesquisa = 5;
                                label6.Text = dataGridViewPesquisa.RowCount.ToString();
                            }
                        }
                    }
                    if (operadorA == 0 && operadorB == 0 && operadorC == 0)
                    {
                        MessageBox.Show("Por Favor Seleciona A ESCOLHA A ou alguma opção de ESCOLHA B!");
                    }
                }
                if (radioButtonPequisaNumero.Checked)
                {
                    if (txtPesquisaNumeroCliente.Text == "")
                    {
                        //dataGridViewPesquisa.Columns.Clear();
                        dataGridViewPesquisa.Refresh();

                        label6.Text = dataGridViewPesquisa.RowCount.ToString();
                        VALORPESQUISA = 0;
                        MessageBox.Show("O número do registro não pode esta em Branco!");
                    }
                    if (!(txtPesquisaNumeroCliente.Text == ""))
                    {
                        if (operadorA == 1 && operadorB == 0)
                        {
                            //SELECIONA POR TODOS Registro 
                            SqlDataAdapter da1 = new SqlDataAdapter("EXEC D_R_ConsultaRegistroGeradoNClientetxt '" + txtPesquisaNumeroCliente.Text + "'," + this.Ativo + ",1,2,3;", conn);
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
                                label6.Text = dataGridViewPesquisa.RowCount.ToString();
                                VALORPESQUISA = 0;
                                MessageBox.Show("Nem um Registro Achado!");
                                conn.Close();
                            }
                            if (ds1.Tables[0].Rows.Count > 0)
                            {
                                conn.Close();

                                this.Aberto = 1;
                                this.Processo = 2;
                                this.Fechado = 3;
                                this.Todos = 0;

                                dataGridViewPesquisaNumeroRegistro();
                                label6.Text = dataGridViewPesquisa.RowCount.ToString();
                            }
                        }
                        //Só Pode escolher todos em chexbox não mas nem um!
                        if (operadorA == 1 && operadorB > 0)
                        {
                            //SELECIONA POR TODOS OS 
                            SqlDataAdapter da2 = new SqlDataAdapter("EXEC D_R_ConsultaRegistroGeradoNClientetxt " + txtPesquisaNumeroCliente.Text + "," + this.Ativo + "," + this.Aberto + "," + this.Processo + "," + this.Fechado + ";", conn);
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
                                label6.Text = dataGridViewPesquisa.RowCount.ToString();
                                VALORPESQUISA = 0;
                                MessageBox.Show("Nem um Registro Achado!");

                                conn.Close();
                            }
                            if (ds1.Tables[0].Rows.Count > 0)
                            {
                                conn.Close();

                                ValorPesquisa = 2;
                                dataGridViewPesquisaNumeroRegistro();
                                label6.Text = dataGridViewPesquisa.RowCount.ToString();
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
                            label6.Text = dataGridViewPesquisa.RowCount.ToString();

                            MessageBox.Show("Por Favor Seleciona pelo menos uma opção!");
                            VALORPESQUISA = 0;

                            conn.Close();
                        }
                        if (operadorA == 0 && operadorB > 0)
                        {
                            //SELECIONA POR TODOS OS 
                            SqlDataAdapter da2 = new SqlDataAdapter("EXEC D_R_ConsultaRegistroGeradoNClientetxt " + txtPesquisaNumeroCliente.Text + "," + this.Ativo + "," + this.Aberto + "," + this.Processo + "," + this.Fechado + ";", conn);
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
                                label6.Text = dataGridViewPesquisa.RowCount.ToString();

                                MessageBox.Show("Nem um Registro Achado!");
                                VALORPESQUISA = 0;

                                conn.Close();
                            }
                            if (ds1.Tables[0].Rows.Count > 0)
                            {
                                conn.Close();
                                ValorPesquisa = 2;
                                dataGridViewPesquisaNumeroRegistro();
                                label6.Text = dataGridViewPesquisa.RowCount.ToString();
                            }
                        }
                    }
                }
                if (radioButtonPesquisaNome.Checked)
                {
                    if (txtPesquisaNomeRegistro.Text == "")
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
                        label6.Text = dataGridViewPesquisa.RowCount.ToString();
                        VALORPESQUISA = 0;
                        MessageBox.Show("O Nome não pode esta em Branco!");
                    }
                    if (!(txtPesquisaNomeRegistro.Text == ""))
                    {
                        if (operadorA == 1 && operadorB == 0)
                        {
                            //SELECIONA POR TODOS OS 
                            SqlDataAdapter da1 = new SqlDataAdapter("EXEC D_R_ConsultaRegistroGeradoNomeClientetxt '" + txtPesquisaNomeRegistro.Text + "',1,1,2,3;", conn);
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
                                MessageBox.Show("Nem um Registro Achado!");
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
                                label6.Text = dataGridViewPesquisa.RowCount.ToString();
                                ValorPesquisa = 3;
                            }
                        }
                        //Só Pode escolher todos em chexbox não mas nem um!
                        if (operadorA == 1 && operadorB > 0)
                        {
                            //SELECIONA POR TODOS OS 
                            SqlDataAdapter da2 = new SqlDataAdapter("EXEC D_R_ConsultaRegistroGeradoNomeClientetxt '" + txtPesquisaNomeRegistro.Text + "'," + this.Ativo + "," + this.Aberto + "," + this.Processo + "," + this.Fechado + ";", conn);
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
                                label6.Text = dataGridViewPesquisa.RowCount.ToString();
                                VALORPESQUISA = 0;
                                MessageBox.Show("Nem um Registro Achado!");

                                conn.Close();
                            }
                            if (ds1.Tables[0].Rows.Count > 0)
                            {
                                ValorPesquisa = 3;
                                dataGridViewPesquisaNome();
                                label6.Text = dataGridViewPesquisa.RowCount.ToString();
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
                            label6.Text = dataGridViewPesquisa.RowCount.ToString();
                            VALORPESQUISA = 0;
                            MessageBox.Show("Por Favor Seleciona pelo menos uma opção!");

                            conn.Close();
                        }
                        if (operadorA == 0 && operadorB > 0)
                        {
                               
                            //SELECIONA POR TODOS OS 
                            SqlDataAdapter da1 = new SqlDataAdapter("EXEC D_R_ConsultaRegistroGeradoNomeClientetxt '" + txtPesquisaNomeRegistro.Text + "'," + this.Ativo + "," + this.Aberto + "," + this.Processo + "," + this.Fechado + ";", conn);
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
                                MessageBox.Show("Nem um Registro Achado!");
                                VALORPESQUISA = 0;
                                conn.Close();
                            }
                            if (ds1.Tables[0].Rows.Count > 0)
                            {
                                conn.Close();
                                dataGridViewPesquisaNome();
                                ValorPesquisa = 3;
                                label6.Text = dataGridViewPesquisa.RowCount.ToString();
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
                        label6.Text = dataGridViewPesquisa.RowCount.ToString();

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
                            label6.Text = dataGridViewPesquisa.RowCount.ToString();
                            VALORPESQUISA = 0;
                            MessageBox.Show("Por Favor Seleciona pelo menos uma opção!");
                            conn.Close();
                        }
                        if (operadorA == 1 && operadorB == 0)
                        {
                            //SELECIONA POR TODOS OS 
                            SqlDataAdapter da1 = new SqlDataAdapter("EXEC D_R_ConsultaRegistroGeradoDataCriadatxt '" + DataInicial + "','" + DataFinal + "'," + this.Ativo + ";", conn);
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
                                label6.Text = dataGridViewPesquisa.RowCount.ToString();
                                VALORPESQUISA = 0;
                                MessageBox.Show("Nem um Registro Achado!");
                                conn.Close();
                            }
                            if (ds1.Tables[0].Rows.Count > 0)
                            {
                                conn.Close();
                                SqlConnection conn1 = new SqlConnection(this.connetionString);
                                string sql = "EXEC D_R_ConsultaRegistroGeradoDataCriadatxt '" + DataInicial + "','" + DataFinal + "'," + this.Ativo + ";";
                                SqlDataAdapter sda = new SqlDataAdapter(sql, conn1);
                                DataTable ds2 = new DataTable();
                                sda.Fill(ds2);
                                dataGridViewPesquisa.DataSource = ds2;
                                label6.Text = dataGridViewPesquisa.RowCount.ToString();
                                ValorPesquisa = 4;
                                conn1.Close();
                            }
                        }
                        if (operadorA == 1 && operadorB > 0)
                        {
                            //SELECIONA POR TODOS OS 
                            SqlDataAdapter da1 = new SqlDataAdapter("EXEC D_R_ConsultaRegistroGeradoDataCriadaNtxt '" + DataInicial + "','" + DataFinal + "'," + this.Aberto + "," + this.Processo + "," + this.Fechado + "," + this.Ativo + ";", conn);
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
                                label6.Text = dataGridViewPesquisa.RowCount.ToString();
                                VALORPESQUISA = 0;
                                MessageBox.Show("Nem um Registro Achado!");
                                conn.Close();
                            }
                            if (ds1.Tables[0].Rows.Count > 0)
                            {
                                conn.Close();
                                SqlConnection conn1 = new SqlConnection(this.connetionString);
                                string sql = "EXEC D_R_ConsultaRegistroGeradoDataCriadaNtxt '" + DataInicial + "','" + DataFinal + "'," + this.Aberto + "," + this.Processo + "," + this.Fechado + "," + this.Ativo + ";";
                                SqlDataAdapter sda = new SqlDataAdapter(sql, conn1);
                                DataTable ds2 = new DataTable();
                                sda.Fill(ds2);
                                dataGridViewPesquisa.DataSource = ds2;
                                ValorPesquisa = 4;
                                label6.Text = dataGridViewPesquisa.RowCount.ToString();
                                conn1.Close();
                            }
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                ex.ToString();
            }
        }
        void dataGridViewPesquisaTodos()
        {
            try
            {
                string connetionString = (this.connetionString);
                SqlConnection connection = new SqlConnection(connetionString);
                SqlCommand command = new SqlCommand("Exec D_R_ConsultaRegistroGeradosTodosTxT " + this.Ativo + "," + this.Aberto + ", " + this.Processo + "," + this.Fechado + ";", connection);
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
        }
        void dataGridViewPesquisaRegistro()
        {
            try
            {
                SqlConnection connection = new SqlConnection(this.connetionString);
                SqlCommand command = new SqlCommand("Exec D_R_ConsultaRegistroGeradosNRegistroTxT " + txtNRegisto.Text + "," + this.Ativo + ";", connection);

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
        void dataGridViewPesquisaNumeroRegistro()
        {
            try
            {
                SqlConnection connection = new SqlConnection(this.connetionString);
                SqlCommand command = new SqlCommand("Exec D_R_ConsultaRegistroGeradoNClientetxt '" + txtPesquisaNumeroCliente.Text + "'," + this.Ativo + "," + this.Aberto + "," + this.Processo + "," + this.Fechado + ";", connection);
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
        }
        void dataGridViewPesquisaNome()
        {
            try
            {
                SqlConnection connection = new SqlConnection(this.connetionString);
                SqlCommand command = new SqlCommand("Exec D_R_ConsultaRegistroGeradoNomeClientetxt '" + txtPesquisaNomeRegistro.Text + "'," + this.Ativo + "," + this.Aberto + "," + this.Processo + "," + this.Fechado + ";", connection);
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
        private void radioButtonTodosClientes_CheckedChanged_1(object sender, EventArgs e)
        {
            panelEstado.Enabled = true;
            txtPesquisaNumeroCliente.Enabled = false;
            txtPesquisaNomeRegistro.Enabled = false;
            txtDataSolicitacao.Enabled = false;
            txtDataSolicitacao2.Enabled = false;
            radioButtonPequisaNumero.Enabled = true;
            radioButtonPesquisaNome.Enabled = true;
            radioButtonPesquisaData.Enabled = true;
            txtDataSolicitacao.Enabled = false;
            txtDataSolicitacao2.Enabled = false;
            txtPesquisaNomeRegistro.Clear();
            txtPesquisaNumeroCliente.Clear();
            txtNRegisto.Clear();

            checkBoxTodos.Checked = true;
            checkBoxEstadoA.Checked = false;
            checkBoxEstadoP.Checked = false;
            checkBoxEstadoF.Checked = false;
            checkBoxRegistro.Enabled = true;

            //dataGridViewPesquisa.Columns.Clear();
            //dataGridViewPesquisa.Refresh();
            label6.Text = dataGridViewPesquisa.RowCount.ToString();

            //PesquisaRegistro();
        }

        private void checkBoxRegistro_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxRegistro.Checked == true)
            {
                txtNRegisto.Enabled = true;
                checkBoxTodos.Checked = false;
                checkBoxEstadoA.Checked = false;
                checkBoxEstadoP.Checked = false;
                checkBoxEstadoF.Checked = false;
            }
            if (checkBoxRegistro.Checked == false)
            {
                txtNRegisto.Enabled = false;
                checkBoxTodos.Checked = false;
                checkBoxEstadoA.Checked = false;
                checkBoxEstadoP.Checked = false;
                checkBoxEstadoF.Checked = false;
                txtNRegisto.Clear();
            }
        }

        private void radioButtonPequisaNumero_CheckedChanged(object sender, EventArgs e)
        {
            txtPesquisaNumeroCliente.Enabled = true;
            txtPesquisaNomeRegistro.Enabled = false;
            txtDataSolicitacao.Enabled = false;
            txtDataSolicitacao2.Enabled = false;
            panelEstado.Enabled = true;
            txtNRegisto.Enabled = false;

            txtPesquisaNomeRegistro.Clear();
            txtPesquisaNumeroCliente.Clear();
            txtNRegisto.Clear();

            checkBoxTodos.Checked = true;
            checkBoxEstadoA.Checked = false;
            checkBoxEstadoP.Checked = false;
            checkBoxEstadoF.Checked = false;
            checkBoxRegistro.Enabled = false;
            checkBoxRegistro.Checked = false;

            //dataGridViewPesquisa.Columns.Clear();
            //dataGridViewPesquisa.Refresh();
            label6.Text = dataGridViewPesquisa.RowCount.ToString();
        }

        private void radioButtonPesquisaNome_CheckedChanged(object sender, EventArgs e)
        {
            txtPesquisaNumeroCliente.Enabled = false;
            txtPesquisaNomeRegistro.Enabled = true;
            txtDataSolicitacao.Enabled = false;
            txtDataSolicitacao2.Enabled = false;
            panelEstado.Enabled = true;
            panelEstado.Enabled = true;
            txtNRegisto.Enabled = false;
            txtPesquisaNomeRegistro.Clear();
            txtPesquisaNumeroCliente.Clear();
            txtNRegisto.Clear();

            checkBoxTodos.Checked = true;
            checkBoxEstadoA.Checked = false;
            checkBoxEstadoP.Checked = false;
            checkBoxEstadoF.Checked = false;
            checkBoxRegistro.Enabled = false;
            checkBoxRegistro.Checked = false;
        }

        private void radioButtonPesquisaData_CheckedChanged(object sender, EventArgs e)
        {
            txtPesquisaNumeroCliente.Enabled = false;
            txtPesquisaNomeRegistro.Enabled = false;
            txtDataSolicitacao.Enabled = true;
            txtDataSolicitacao2.Enabled = true;
            panelEstado.Enabled = true;

            txtNRegisto.Enabled = false;
            txtPesquisaNomeRegistro.Clear();
            txtPesquisaNumeroCliente.Clear();
            txtNRegisto.Clear();

            checkBoxTodos.Checked = true;
            checkBoxEstadoA.Checked = false;
            checkBoxEstadoP.Checked = false;
            checkBoxEstadoF.Checked = false;
            checkBoxRegistro.Enabled = false;
            checkBoxRegistro.Checked = false;

            //dataGridViewPesquisa.Columns.Clear();

            label6.Text = dataGridViewPesquisa.RowCount.ToString();
        }

        private void txtNRegisto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                PesquisaRegistro();
            }
        }

        private void txtPesquisaNumeroCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && !(e.KeyChar == (char)Keys.Enter) && !(e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }
            if (e.KeyChar == 13)
            {
                PesquisaRegistro();
            }
        }

        private void txtPesquisaNomeRegistro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                PesquisaRegistro();
            }
        }
        private void FecharFormulariosFilhos()
        {
            // percorre todos os formulários abertos
            for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
            {
                // se o formulário for filho
                if (Application.OpenForms[i].IsMdiChild)
                {
                    // fecha o formulário
                    Application.OpenForms[i].Close();
                }
            }
        }


        private void dataGridViewPesquisa_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (RegistroVisualizar == 0)
                {
                    try
                    {
                        MessageBox.Show("Acesso não Permitido!");

                    }
                    catch (Exception ex)
                    {
                        ex.ToString();
                    }
                }
                if ((dataGridViewPesquisa.RowCount > 0) &&RegistroVisualizar == 1)
                {
                    try
                    {
                        this.IdRegistro = Convert.ToInt32(dataGridViewPesquisa["ID_REGISTRO", e.RowIndex].Value);
                        IdRegistro.ToString();
                        this.NomeAcesso.ToString();

                        FormPesquisaCadastraRegistroEditar FormPesquisaCadastraRegistroEditarF = new FormPesquisaCadastraRegistroEditar(
                        this.IdRegistro,this.RegistroVisualizar, this.RegistroEditar,this.RegistroExcluir, 
                        this.IdPessoaLogada, this.connetionString, this.RegistroCadastra, this.NomeAcesso, this.RegistroCCCadastra);

                        FormPesquisaCadastraRegistroEditarF.ShowDialog();
                        FormPesquisaCadastraRegistroEditarF.Top = 0;
                        FormPesquisaCadastraRegistroEditarF.Left = 0;

                    }
                    catch (Exception ex)
                    {
                        ex.ToString();
                    }
                }
            }
            catch(Exception ex)
            {
                ex.ToString();
            }
        }

        private void FormPesquisaCadastraRegistro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
            {
                this.Close();
            }
        }
        private void buttonCancelarOs_Click(object sender, EventArgs e)
        {
            //FecharTodosFormulario();
            //FormPesquisaCadastraRegistro CadastraRegistro = new FormPesquisaCadastraRegistro(this, this.IdPessoaLogada, this.NomeAcesso, this.NomeServidor,
            //this.NomeBaseDados, this.NomeUsuario, this.SenhaBaseDados, this.RegistroVisualizar, this.RegistroEditar, this.RegistroExcluir, this.RegistroCadastra);
            //CadastraRegistro.MdiParent = this;
            //CadastraRegistro.Show();
            //CadastraRegistro.Top = 0;
            //CadastraRegistro.Left = 0;
        }
        public void FecharTodosFormulario()
        {
            CancelaCadastradoProposta(typeof(FormPesquisaCadastraRegistro));
        }
        public static void CancelaCadastradoProposta(Type frmType)
        {
            bool bolCtl = false;
            Type a = frmType;
            foreach (Form form in System.Windows.Forms.Application.OpenForms)
            {
                if (form.GetType().Equals(frmType))
                {

                    form.Close();

                    bolCtl = true;
                    break;
                }
            }

            if (!bolCtl)
            {

            }
        }
        private void buttonFecharOs_Click(object sender, EventArgs e)
        {
            this.Close();
            //FecharTodosFormulario();
        }
    }
}
