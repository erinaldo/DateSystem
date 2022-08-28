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
using System.Globalization;

namespace DateSystem
{
    public partial class FormCadastraRegistro : Form
    {
        DataTable TableCliente;

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

        private int IDCONTATOCLIENTE = 0;
        public int IdContatoCliente 
        {
            get
            {
                return this.IDCONTATOCLIENTE;

            }
            set
            {
                this.IDCONTATOCLIENTE = value;
            }
        }
        private int NUMERO_OS_LIVRE = 0;
        public int NumeroOsLivre
        {
            get
            {
                return this.NUMERO_OS_LIVRE;

            }
            set
            {
                this.NUMERO_OS_LIVRE = value;
            }
        }
        private int CADASTRA_REGISTRON = 0;
        public int CadastraRegistroN
        {
            get
            {
                return this.CADASTRA_REGISTRON;

            }
            set
            {
                this.CADASTRA_REGISTRON = value;
            }
        }

        private int ID_REGISTRO = 0;
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
        private int ID_REGISTROSALVA = 0;
        public int IdRegistroSalva
        {
            get
            {
                return this.ID_REGISTROSALVA;

            }
            set
            {
                this.ID_REGISTROSALVA = value;
            }
        }
        public int ID_FUNCIONARIO = 0;
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

        private int ID_TIPO_PESSOA = 0;
        public int idPessoaTipo
        {
            get
            {
                return this.ID_TIPO_PESSOA;

            }
            set
            {
                this.ID_TIPO_PESSOA = value;
            }
        }
        private int IDPESSOA = 0;
        public int IdPessoa
        {
            get
            {
                return this.IDPESSOA;

            }
            set
            {
                this.IDPESSOA = value;
            }
        }
        //Strings endereços
        private string TIPO_LOGRADOURO = "";
        public string Tipologradouro
        {
            get
            {
                return this.TIPO_LOGRADOURO;

            }
            set
            {
                this.TIPO_LOGRADOURO = value;
            }
        }
        private string ENDERECOOS = "";
        public string EnderecoOS
        {
            get
            {
                return this.ENDERECOOS;

            }
            set
            {
                this.ENDERECOOS = value;
            }
        }
        private string COMPLEMENTOS = "";
        public string Complementos
        {
            get
            {
                return this.COMPLEMENTOS;

            }
            set
            {
                this.COMPLEMENTOS = value;
            }
        }
        private string BAIRRONUMERO = "";
        public string BairroNumero
        {
            get
            {
                return this.BAIRRONUMERO;

            }
            set
            {
                this.BAIRRONUMERO = value;
            }
        }
        private string BAIRRO = "";
        public string Bairro
        {
            get
            {
                return this.BAIRRO;

            }
            set
            {
                this.BAIRRO = value;
            }
        }
        private string CIDADE = "";
        public string Cidade
        {
            get
            {
                return this.CIDADE;

            }
            set
            {
                this.CIDADE = value;
            }
        }
        private string SERVICOEXECUTADO = "";
        public string ServicoExecutado
        {
            get
            {
                return this.SERVICOEXECUTADO;

            }
            set
            {
                this.SERVICOEXECUTADO = value;
            }
        }
        private string COMBOBOXABREVIACAO = "";
        public string ComboBoxAbreviacao
        {
            get
            {
                return this.COMBOBOXABREVIACAO;

            }
            set
            {
                this.COMBOBOXABREVIACAO = value;
            }
        }

        private string ORIGEM_SERVICO = "";
        public string OrigemServico
        {
            get
            {
                return this.ORIGEM_SERVICO;

            }
            set
            {
                this.ORIGEM_SERVICO = value;
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

        
        private Boolean validaNome(TextBox textBox, ErrorProvider errorProvider)
        {
            if (!String.IsNullOrWhiteSpace(txtOrigemRegistro.Text))
            {
                errorProviderCadastraRegistro.SetError(textBox, "");
                return true;
            }
            else
            {
                errorProviderCadastraRegistro.SetError(textBox, "Documentação Inválido!");
                return false;
            }

        }
        private string operacao = "";

        public FormCadastraRegistro()
        {
            InitializeComponent();
        }
        //Cadastra Registro Novo
        public FormCadastraRegistro(int ID_PESSOA_LOGADA, string NomeAcesso, string NomeServidor, string NomeBaseDados, string NomeUsuario, string SenhaBaseDados, int CadastraContatoRegistro )
        {
            InitializeComponent();

            txtOrigemRegistro.MaxLength = 1000;

            this.txtDataSolicitacaoProcesso.Value = DateTime.Now.Date;

            this.txtDataContatoRegistro.Value = DateTime.Now.Date;

            this.IdPessoaLogada = ID_PESSOA_LOGADA;
            this.NomeAcesso = NomeAcesso;
            NomeLogado.Text = "NOME:" + NomeAcesso;

            this.RegistroCCCadastra = CadastraContatoRegistro;

            this.NomeServidor = NomeServidor;
            this.NomeBaseDados = NomeBaseDados;
            this.NomeUsuario = NomeUsuario;
            this.SenhaBaseDados = SenhaBaseDados;
            this.connetionString = "Data Source=" + this.NomeServidor + ";Initial Catalog=" + this.NomeBaseDados + ";Persist Security Info=True;User ID=" + this.NomeUsuario + ";Password=" + this.SenhaBaseDados + ";";
            
        }
        public FormCadastraRegistro(int ID_PESSOA_LOGADA, string connetionString, string NomeAcesso)
        {
            InitializeComponent();

            txtOrigemRegistro.MaxLength = 1000;

            this.txtDataSolicitacaoProcesso.Value = DateTime.Now.Date;

            this.txtDataContatoRegistro.Value = DateTime.Now.Date;

            this.IdPessoaLogada = ID_PESSOA_LOGADA;

            this.NomeAcesso = NomeAcesso;
            NomeLogado.Text = "NOME:" + NomeAcesso;

            this.connetionString = connetionString;
        }


        private void radioButtonPequisaNumero_CheckedChanged(object sender, EventArgs e)
        {
            txtPesquisaNomeCliente.Enabled = false;
            txtPesquisaNumeroCliente.Enabled = true;
            txtPesquisaNumeroCliente.Clear();
            txtPesquisaNomeCliente.Clear();
        }

        private void radioButtonPesquisaNome_CheckedChanged(object sender, EventArgs e)
        {
            txtPesquisaNomeCliente.Enabled = true;
            txtPesquisaNumeroCliente.Enabled = false;
            txtPesquisaNumeroCliente.Clear();
            txtPesquisaNomeCliente.Clear();
        }

        private void txtPesquisaNomeCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                BuscaCliente();
            }
        }

        private void txtPesquisaNumeroCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                BuscaCliente();
            }
            //Se a tecla digitada não for número
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }

        }

        private void buttonPesquisaCliente_Click(object sender, EventArgs e)
        {
            BuscaCliente();
        }
        private void BuscaCliente()
        {
           try
            {
                //String connectionString = "Data Source=PROGRAMAS;Initial Catalog=MSOS;Persist Security Info=True;User ID=sa;Password=dellm@ster2016;";
                SqlConnection conn = new SqlConnection(this.connetionString);
                
                if (radioButtonTodos.Checked)
                {
                    //SELECIONA POR Todos
                    SqlDataAdapter da1 = new SqlDataAdapter("EXEC D_R_ConsultaPessoaTodosClienteRegistroTxt 1;", conn);                   
                    DataSet ds1 = new DataSet();
                    da1.Fill(ds1);

                    conn.Open();

                    if (ds1.Tables[0].Rows.Count == 0)
                    {
                        if (dataGridViewPesquisa.DataSource == null)
                        {
                            dataGridViewPesquisa.Refresh();
                        }
                        if (!(dataGridViewPesquisa.DataSource == null))
                        {
                            dataGridViewPesquisa.Refresh();
                        }
                        label1.Text = dataGridViewPesquisa.RowCount.ToString();

                        MessageBox.Show("Nem um Registro de nome Achado!");
                        conn.Close();
                    }
                    if (ds1.Tables[0].Rows.Count > 0)
                    {
                        dataGridViewPesquisaClienteTodos();
                        dataGridViewPesquisa.RowCount.ToString();
                        buttonVerifica.Enabled = true;
                        conn.Close();
                    }
                }

                if (radioButtonPequisaNumero.Checked)
                {
                    if (txtPesquisaNumeroCliente.Text == "")
                    {
                        MessageBox.Show("O Número não pode esta em branco! ");
                    }

                    if (!(txtPesquisaNumeroCliente.Text == ""))
                    {
                        int NUMERO = int.Parse(this.txtPesquisaNumeroCliente.Text);
                        //SELECIONA POR MS
                        SqlDataAdapter da1 = new SqlDataAdapter("EXEC D_R_ConsultaPessoaNumeroClienteRegistroTxt " + NUMERO + ",1; ", conn);
                        DataSet ds1 = new DataSet();
                        da1.Fill(ds1);

                        conn.Open();

                        if (ds1.Tables[0].Rows.Count == 0)
                        {
                            MessageBox.Show("O número de registro: " + NUMERO + " não consta no sistema!");

                            conn.Close();

                        }

                        if (ds1.Tables[0].Rows.Count > 0)
                        {
                            IdPessoa = int.Parse(ds1.Tables[0].Rows[0][0].ToString());
                            idPessoaTipo = int.Parse(ds1.Tables[0].Rows[0][1].ToString());

                            if (IdPessoa == 0)
                            {
                                MessageBox.Show("O Número não constra no sitema! ");
                            }

                            if (IdPessoa != 0)
                            {
                                buttonLimpaRegistro.Enabled = true;

                                dataGridViewPesquisa.Enabled = true;

                                panelDocumentoRegistro.Enabled = true;

                                buttonCancelarRegistro.Enabled = true;

                                buttonFecharRegistro.Enabled = true;

                                buttonVerifica.Enabled = true;

                                comboBoxContato.Items.Clear();
                                Fill_listBoxContatos();

                                if (RegistroCCCadastra == 1)
                                {
                                    buttonAdicionarContato.Enabled = true;
                                    buttonAtualizarContatos.Enabled = true;

                                    buttonAdicionarContato.Visible = true;
                                    buttonAtualizarContatos.Visible = true;
                                }

                                panelDadosCliente.Enabled = true;
                            }

                            try
                            {
                                if (idPessoaTipo == 1)
                                {
                                    try
                                    {
                                        txtNomeRegistro.Text = ds1.Tables[0].Rows[0][3].ToString();
                                        txtNumeroRegistro.Text = ds1.Tables[0].Rows[0][0].ToString();
                                        txtTelefoneRegistro.Text = ds1.Tables[0].Rows[0][4].ToString();
                                        //txtTipo_logradouro.Text = ds1.Tables[0].Rows[0][32].ToString();
                                        txtEnderecoRegistro.Text = ds1.Tables[0].Rows[0][38].ToString();
                                        txtBairroNumero.Text = ds1.Tables[0].Rows[0][39].ToString();
                                        txtComplRegistro.Text = ds1.Tables[0].Rows[0][40].ToString();
                                        txtBairroRegistro.Text = ds1.Tables[0].Rows[0][41].ToString();
                                        txtCidadeRegistro.Text = ds1.Tables[0].Rows[0][42].ToString();

                                        conn.Close();

                                    }
                                    catch (Exception ex)
                                    {
                                        MessageBox.Show(ex.Message);
                                    }
                                }
                                if (idPessoaTipo == 2)
                                {
                                    try
                                    {
                                        txtNomeRegistro.Text = ds1.Tables[0].Rows[0][3].ToString();
                                        txtNumeroRegistro.Text = ds1.Tables[0].Rows[0][0].ToString();
                                        txtTelefoneRegistro.Text = ds1.Tables[0].Rows[0][4].ToString();
                                        //txtTipo_logradouro.Text = ds1.Tables[0].Rows[0][32].ToString();
                                        txtEnderecoRegistro.Text = ds1.Tables[0].Rows[0][38].ToString();
                                        txtBairroNumero.Text = ds1.Tables[0].Rows[0][39].ToString();
                                        txtComplRegistro.Text = ds1.Tables[0].Rows[0][40].ToString();
                                        txtBairroRegistro.Text = ds1.Tables[0].Rows[0][41].ToString();
                                        txtCidadeRegistro.Text = ds1.Tables[0].Rows[0][42].ToString();

                                        conn.Close();

                                    }
                                    catch (Exception ex)
                                    {
                                        MessageBox.Show(ex.Message);
                                    }
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
                        }
                    }
                }
                if (radioButtonPesquisaNome.Checked)
                {
                    if (txtPesquisaNomeCliente.Text == "")
                    {
                        //dataGridViewPesquisaCliente.Columns.Clear();
                        dataGridViewPesquisa.Refresh();

                        label1.Text = dataGridViewPesquisa.RowCount.ToString();

                        MessageBox.Show("O nome não pode esta em Branco!");
                    }
                    if (!(txtPesquisaNomeCliente.Text == ""))
                    {
                        //SELECIONA POR TODOS OS 
                        SqlDataAdapter da1 = new SqlDataAdapter("EXEC D_R_ConsultaPessoaClienteRegistroNomeTxt '" + txtPesquisaNomeCliente.Text + "',1;", conn);
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
                                dataGridViewPesquisa.Refresh();
                            }
                            label1.Text = dataGridViewPesquisa.RowCount.ToString();

                            MessageBox.Show("Nem um Registro de nome Achado!");
                            conn.Close();
                        }
                        if (ds1.Tables[0].Rows.Count > 0)
                        {
                            dataGridViewPesquisaClienteNome();
                            dataGridViewPesquisa.RowCount.ToString();
                            buttonVerifica.Enabled = true;
                            conn.Close();
                        }
                    }
                }
                else if (!(radioButtonPequisaNumero.Checked) && !(radioButtonPesquisaNome.Checked) && !(radioButtonTodos.Checked)) MessageBox.Show("Seleciona Todos, Número ou Nome para uma Pesquisa!");
                {

                }
            }
            catch(Exception ex)
            {
                ex.ToString();
            }
        }
        private void buttonFecharRegistro_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.Count >= 1) //FECHA O TERCEIRO
                Application.OpenForms[Application.OpenForms.Count-1].Close();
        }
        private void buttonCancelarRegistro_Click(object sender, EventArgs e)
        {
            FecharTodosFormulario();

            FormCadastraRegistro cadastracliente = new FormCadastraRegistro(this.IdPessoaLogada, this.NomeAcesso,
                this.NomeServidor, this.NomeBaseDados, this.NomeUsuario, this.SenhaBaseDados, this.RegistroCCCadastra);
            cadastracliente.MdiParent = FormCadastraRegistro.ActiveForm;
            cadastracliente.Show();
            cadastracliente.Top = 0;
            cadastracliente.Left = 0;
        }
        public void FecharTodosFormulario()
        {
            CancelaCadastradoProposta(typeof(FormCadastraRegistro));
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

                    //MessageBox.Show("Formulario Já foi Fechado.");


                    bolCtl = true;
                    break;
                }
            }

            if (!bolCtl)
            {

            }
        }
        private void buttonCancelarRegistro1_Click(object sender, EventArgs e)
        {
            CancelarCadastroRegistro();
        }
        public void CancelarCadastroRegistro()
        {
            try
            {
                FecharTodosFormulario();
                FormCadastraRegistro cadastracliente = new FormCadastraRegistro(this.IdPessoaLogada, this.NomeAcesso,
                    this.NomeServidor, this.NomeBaseDados, this.NomeUsuario, this.SenhaBaseDados, this.RegistroCCCadastra);
                cadastracliente.MdiParent = FormCadastraRegistro.ActiveForm;
                cadastracliente.Show();
                cadastracliente.Top = 0;
                cadastracliente.Left = 0;
            }
            catch(Exception ex)
            {
                ex.ToString();
            }

        }
        private void buttonCadastraRegistro_Click(object sender, EventArgs e)
        {
            CadastraRegistro();
        }
        private void CadastraRegistro()
        {
            this.operacao = "Inserir";

            checkBoxSituacao.Checked = true;

            txtOrigemRegistro.MaxLength = 1000;

            dataGridViewPesquisa.Enabled = true;

            AlteraBotoes(1);

            SqlConnection conn = new SqlConnection(this.connetionString);

            SqlDataAdapter da = new SqlDataAdapter("EXEC D_R_ConsultaCadastroNRegistro ", conn);
            DataSet ds = new DataSet();
            da.Fill(ds);

            if (!(ds.Tables[0].Rows.Count > 0))
            {
                IdRegistro = 1;
                txtNumeroDoRegistro.Text = " N° " + IdRegistro.ToString();
                conn.Close();
            }
            if (ds.Tables[0].Rows.Count > 0)
            {
                int soma = int.Parse(ds.Tables[0].Rows[0][0].ToString());
                IdRegistro = 1 + soma;
                txtNumeroDoRegistro.Text = " N° " + IdRegistro.ToString();
                conn.Close();
            }

            comboBoxContato.Items.Clear();
            Fill_listBoxContatos();

            this.txtDataSolicitacaoProcesso.Value = DateTime.Now.Date;

            this.txtDataContatoRegistro.Value = DateTime.Now.Date;
        }
        public void GeraRegistroSalva()
        {
            SqlConnection conn = new SqlConnection(this.connetionString);

            SqlDataAdapter da = new SqlDataAdapter("EXEC D_R_ConsultaCadastroNRegistro ", conn);
            DataSet ds = new DataSet();
            da.Fill(ds);


            if (!(ds.Tables[0].Rows.Count > 0))
            {
                IdRegistroSalva = 1;
                txtNumeroDoRegistro.Text = " N° " + IdRegistroSalva.ToString();
                conn.Close();
            }
            if (ds.Tables[0].Rows.Count > 0)
            {
                int soma = int.Parse(ds.Tables[0].Rows[0][0].ToString());
                IdRegistroSalva = 1 + soma;
                txtNumeroDoRegistro.Text = " N° " + IdRegistroSalva.ToString();
                conn.Close();
            }
        }
        //LISTA OS Contatos da empresa Buscada
        void Fill_listBoxContatos()
        {
            SqlConnection connection = new SqlConnection(this.connetionString);

            try
            {
                connection.Open();
                string Query = "EXEC D_R_ConsultaCadastroIdRegistro " + IdPessoa + ";";


                SqlCommand command = new SqlCommand(Query, connection);
                SqlDataReader dr = command.ExecuteReader();
                while (dr.Read())
                {
                    string name = dr.GetString(0);
                    comboBoxContato.Items.Add(name);
                }
                connection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void comboBoxContato_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(this.connetionString);

            try
            {
                connection.Open();

                string Query = " SELECT ID_PESSOA_CONTATO, ABREVIACAO FROM P_Contatos WHERE Nome = '" + this.comboBoxContato.Text + "';";

                SqlCommand command = new SqlCommand(Query, connection);
                SqlDataReader dr = command.ExecuteReader();
                while (dr.Read())
                {

                    this.IdContatoCliente = dr.GetInt32(0);
                    comboBoxContato.Text = dr.GetString(1);
                    label8.Text = dr.GetString(1);
                    this.ComboBoxAbreviacao = dr.GetString(1);
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        void dataGridViewPesquisaClienteTodos()
        {
            int Situacao = 0;
            if (checkBoxSituacao.Checked == true)
            {
                Situacao = 1;
            }

            string connetionString = (this.connetionString);
            SqlConnection connection = new SqlConnection(connetionString);
            SqlCommand command = new SqlCommand("EXEC D_R_ConsultaPessoaTodosClienteRegistroTxt " + Situacao + ";", connection);
            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = command;
                TableCliente = new DataTable();
                adapter.Fill(TableCliente);
                BindingSource Source = new BindingSource();
                Source.DataSource = TableCliente;
                dataGridViewPesquisa.DataSource = Source;
                adapter.Update(TableCliente);
            }
            catch (Exception ex)
            {
                ex.ToString();
            }

            //DataTable dt = new DataTable();
        }
        void dataGridViewPesquisaClienteNome()
        {
            string connetionString = (this.connetionString);
            SqlConnection connection = new SqlConnection(connetionString);
            SqlCommand command = new SqlCommand("EXEC D_R_ConsultaPessoaClienteRegistroNomeTxt '" + txtPesquisaNomeCliente.Text + "',1;", connection);
            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = command;
                TableCliente = new DataTable();
                adapter.Fill(TableCliente);
                BindingSource Source = new BindingSource();
                Source.DataSource = TableCliente;
                dataGridViewPesquisa.DataSource = Source;
                adapter.Update(TableCliente);
            }
            catch (Exception ex)
            {
                ex.ToString();
            }

            //DataTable dt = new DataTable();
        }
        private void dataGridViewPesquisa_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewPesquisa.RowCount == 0)
            {
                IdPessoa = 0;
            }
            if (!(dataGridViewPesquisa.RowCount == 0))
            {
                try
                {
                    SqlConnection conn = new SqlConnection(this.connetionString);

                    IdPessoa = Convert.ToInt32(dataGridViewPesquisa["ID_PESSOA", e.RowIndex].Value);
                    IdPessoa.ToString();

                    //SELECIONA POR TODOS OS 
                    SqlDataAdapter da1 = new SqlDataAdapter("EXEC D_R_ConsultaPessoaNumeroClienteRegistroTxt " + IdPessoa + ",1;", conn);
                    DataSet ds1 = new DataSet();
                    da1.Fill(ds1);

                    conn.Open();

                    if (ds1.Tables[0].Rows.Count > 0)
                    {
                        IdPessoa = int.Parse(ds1.Tables[0].Rows[0][0].ToString());
                        idPessoaTipo = int.Parse(ds1.Tables[0].Rows[0][1].ToString());

                        if (IdPessoa != 0)
                        {

                            comboBoxContato.Items.Clear();
                            Fill_listBoxContatos();
                            buttonLimpaRegistro.Enabled = true;
                            panelDocumentoRegistro.Enabled = true;
                            comboBoxContato.Enabled = true;

                            panelDadosCliente.Enabled = true;

                            if (RegistroCCCadastra == 1)
                            {
                                buttonAdicionarContato.Enabled = true;
                                buttonAtualizarContatos.Enabled = true;

                                buttonAdicionarContato.Visible = true;
                                buttonAtualizarContatos.Visible = true;
                            }

                        }
                        if (IdPessoa == 0)
                        {

                        }

                        try
                        {
                            if (idPessoaTipo == 1)
                            {
                                try
                                {
                                    txtNomeRegistro.Text = ds1.Tables[0].Rows[0][3].ToString();
                                    int NumeroRegistroNovo = int.Parse(ds1.Tables[0].Rows[0][0].ToString()) + 1;
                                    txtNumeroRegistro.Text = NumeroRegistroNovo.ToString();
                                    txtTelefoneRegistro.Text = ds1.Tables[0].Rows[0][4].ToString();
                                    //txtTipo_logradouro.Text = ds1.Tables[0].Rows[0][32].ToString();
                                    txtEnderecoRegistro.Text = ds1.Tables[0].Rows[0][38].ToString();
                                    txtBairroNumero.Text = ds1.Tables[0].Rows[0][39].ToString();
                                    txtComplRegistro.Text = ds1.Tables[0].Rows[0][40].ToString();
                                    txtBairroRegistro.Text = ds1.Tables[0].Rows[0][41].ToString();
                                    txtCidadeRegistro.Text = ds1.Tables[0].Rows[0][42].ToString();

                                    conn.Close();
                                }
                                catch (Exception ex)
                                {
                                    ex.ToString();
                                }
                            }
                            if (idPessoaTipo == 2)
                            {
                                try
                                {
                                    txtNomeRegistro.Text = ds1.Tables[0].Rows[0][3].ToString();
                                    int NumeroRegistroNovo = int.Parse(ds1.Tables[0].Rows[0][0].ToString()) + 1;
                                    txtNumeroRegistro.Text = NumeroRegistroNovo.ToString();
                                    txtTelefoneRegistro.Text = ds1.Tables[0].Rows[0][4].ToString();
                                    //txtTipo_logradouro.Text = ds1.Tables[0].Rows[0][32].ToString();
                                    txtEnderecoRegistro.Text = ds1.Tables[0].Rows[0][38].ToString();
                                    txtBairroNumero.Text = ds1.Tables[0].Rows[0][39].ToString();
                                    txtComplRegistro.Text = ds1.Tables[0].Rows[0][40].ToString();
                                    txtBairroRegistro.Text = ds1.Tables[0].Rows[0][41].ToString();
                                    txtCidadeRegistro.Text = ds1.Tables[0].Rows[0][42].ToString();

                                    conn.Close();

                                }
                                catch (Exception ex)
                                {
                                    ex.ToString();
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            ex.ToString();
                        }
                    }
                    if (!(ds1.Tables[0].Rows.Count > 0))
                    {
                        MessageBox.Show("O cliente não consta no sistema!");

                        AlteraBotoes(10);
                    }
                }
                catch (Exception ex)
                {
                    ex.ToString();
                }
            }
        }
        //public void Modificar()
        //{
        //    if (ID_CONTATO_CLIENTE == "")
        //    {
        //        if (this.ClienteCCadastra == 0)
        //        {
        //            comboBoxContato.Enabled = true;
        //        }
        //        if (this.ClienteCCadastra == 1)
        //        {
        //            comboBoxContato.Enabled = true;
        //            buttonAdicionarContato.Enabled = true;
        //            buttonAdicionarContato.Visible = true;
        //            buttonAtualizarContatos.Enabled = true;
        //            buttonAtualizarContatos.Visible = true;
        //            comboBoxContato.Items.Clear();
        //            Fill_listBoxContatos();
        //        }


        //    }
        //    if (!(ID_CONTATO_CLIENTE == ""))
        //    {

        //        int ID_CONTATO_CADASTRADO = int.Parse(ID_CONTATO_CLIENTE);
        //        SqlConnection conn6 = new SqlConnection(this.connetionString);
        //        string Query6 = "EXEC D_O_ConsultaCadastroIdContatosClienteOS " + ID_CONTATO_CADASTRADO + ";";
        //        SqlDataAdapter sda6 = new SqlDataAdapter(Query6, conn6);
        //        DataSet ds6 = new DataSet();
        //        sda6.Fill(ds6);

        //        comboBoxContato.Items.Insert(0, ds6.Tables[0].Rows[0][0].ToString());
        //        comboBoxContato.SelectedIndex = 0;
        //        conn6.Close();
        //    }
        //}
        public void AlteraBotoes(int op)
        {
            if (op == 1)// Cadastra OS campos
            {
                panelBuscaInformacao.Enabled = true;


                buttonCadastraRegistro.Enabled = false;
                buttonCancelarRegistro.Enabled = true;


                buttonVerifica.Enabled = false;
                buttonLimpaRegistro.Enabled = false;
                buttonCancelarRegistro1.Enabled = true;
                buttonFecharRegistro.Enabled = true;
            }
        }

        private void FormCadastraRegistro_Load(object sender, EventArgs e)
        {

        }
        

        private void buttonVerifica_Click(object sender, EventArgs e)
        {
            CadastroRegistro();
        }
        public void CadastroRegistro()
        {
            try
            {
                Conexao conexao = new Conexao(this.connetionString);
                DALRegistroGerado da = new DALRegistroGerado(conexao);

                RegistroGerados RegistroGerado = new RegistroGerados();

                RegistroGerado.IdClienteRegistro = this.IdPessoa;

                RegistroGerado.IdContato = this.IdContatoCliente;

                RegistroGerado.Estado = 1;

                RegistroGerado.Situacao = 1;

                RegistroGerado.IdPessoaLogada = this.IdPessoaLogada;

                RegistroGerado.OrigemRegistro = txtOrigemRegistro.Text;

                RegistroGerado.DataCriadoRegistrado = Convert.ToDateTime(txtDataSolicitacaoProcesso.Value.Date.ToString("dd/MM/yyyy"));

                RegistroGerado.DataContato = Convert.ToDateTime(txtDataContatoRegistro.Value.Date.ToString("dd/MM/yyyy"));

                string NomeCliente = txtNomeRegistro.Text;
                string NumeroCadastro = txtNumeroRegistro.Text;
                string NomedoIdLogado = NomeLogado.Text;
                if (this.operacao == "Inserir")
                {
                    if (this.comboBoxContato.Text == "")
                    {
                        MessageBox.Show("Selecione um contato para Cadastrado no sistema!");
                    }
                    if (!(this.comboBoxContato.Text == ""))
                    {
                        GeraRegistroSalva();

                        if (IdRegistro == IdRegistroSalva)
                        {
                            DialogResult dialogResultRegistro = MessageBox.Show("Confirma a criação de Registro?", "Aviso", MessageBoxButtons.YesNo);

                            if (dialogResultRegistro == DialogResult.Yes)
                            {
                                da.IncluirClienteRegistroGerado(RegistroGerado);

                                MessageBox.Show("Registro Gerado Cadastrado com Exito! ");

                                DialogResult dialogResultSubRegistro = MessageBox.Show("Deseja criar um Sub Registro?", "Aviso", MessageBoxButtons.YesNo);
                                if (dialogResultSubRegistro == DialogResult.Yes)
                                {
                                    FecharTodosFormulario();

                                    FormCadastraRegistroSub CadastraRegistroSub = new FormCadastraRegistroSub(
                                        this.IdRegistroSalva, this.IdPessoa, NomeCliente, NumeroCadastro,
                                        this.IdPessoaLogada, NomedoIdLogado, this.connetionString, RegistroCCCadastra, 1, 1);
                                    CadastraRegistroSub.MdiParent = FormCadastraRegistroSub.ActiveForm;
                                    CadastraRegistroSub.Show();
                                    CadastraRegistroSub.Top = 0;
                                    CadastraRegistroSub.Left = 0;
                                }
                                else if (dialogResultSubRegistro == DialogResult.No)
                                {
                                    FecharTodosFormulario();
                                }
                            }
                            else if (dialogResultRegistro == DialogResult.No)
                            {
                                MessageBox.Show("Registro não criado! ");
                            }
                        }
                        if (IdRegistro != IdRegistroSalva)
                        {
                            DialogResult dialogResultRegistro = MessageBox.Show("Confirma a criação de Registro?", "Aviso", MessageBoxButtons.YesNo);

                            if (dialogResultRegistro == DialogResult.Yes)
                            {
                                da.IncluirClienteRegistroGerado(RegistroGerado);

                                MessageBox.Show("Novo número de registro N ° " + IdRegistroSalva + " \n Registro Gerado Cadastrado com Exito! ");

                                DialogResult dialogResultSubRegistro = MessageBox.Show("Deseja criar um Sub Registro?", "Aviso", MessageBoxButtons.YesNo);

                                if (dialogResultSubRegistro == DialogResult.Yes)
                                {
                                    FecharTodosFormulario();

                                    FormCadastraRegistroSub CadastraRegistroSub = new FormCadastraRegistroSub(
                                        this.IdRegistroSalva, this.IdPessoa, NomeCliente, NumeroCadastro,
                                        this.IdPessoaLogada, NomedoIdLogado, this.connetionString, 1, 1);
                                    CadastraRegistroSub.MdiParent = FormCadastraRegistroSub.ActiveForm;
                                    CadastraRegistroSub.Show();
                                    CadastraRegistroSub.Top = 0;
                                    CadastraRegistroSub.Left = 0;
                                }
                                else if (dialogResultSubRegistro == DialogResult.No)
                                {
                                    FecharTodosFormulario();
                                }
                            }
                            else if (dialogResultRegistro == DialogResult.No)
                            {
                                MessageBox.Show("Registro não criado! ");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro de acesso ao banco de Dados: " + ex.ToString());
            }
         
        }
        private void FormCadastraRegistro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
            {
                this.Close();
            }
        }

        private void buttonLimpaRegistro_Click(object sender, EventArgs e)
        {
            txtOrigemRegistro.Clear();
        }

        private void buttonAtualizarContatos_Click(object sender, EventArgs e)
        {
            comboBoxContato.Items.Clear();
            Fill_listBoxContatos();
        }

        private void buttonAdicionarContato_Click(object sender, EventArgs e)
        {
            try
            {
                if (RegistroCCCadastra == 0)
                {
                    MessageBox.Show("Acesso não Permitido!");
                }
                if (RegistroCCCadastra == 1)
                {

                    FormCadastraContatoRegistro cadastracliente = new FormCadastraContatoRegistro(this.IdPessoa, this.connetionString);
                    cadastracliente.MdiParent = FormCadastraContatoRegistro.ActiveForm;
                    cadastracliente.Show();
                    cadastracliente.Top = 0;
                    cadastracliente.Left = 0;
                }
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
        }

        private void txtOrigemRegistro_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                int tamanhoMaximoPorLinha = 105;
                int[] keysLiberadas = { (int)Keys.Enter, (int)Keys.Back };

                int posicaoAtual = txtOrigemRegistro.SelectionStart;
                int linhaAtual = txtOrigemRegistro.GetLineFromCharIndex(posicaoAtual);

                if (txtOrigemRegistro.Lines.Length == 0)
                {
                    if (txtOrigemRegistro.Text.Length > tamanhoMaximoPorLinha && !keysLiberadas.Contains((int)e.KeyChar))
                    {
                        e.Handled = true;
                    }
                }
                else if (txtOrigemRegistro.Lines[linhaAtual].Length > tamanhoMaximoPorLinha && !keysLiberadas.Contains((int)e.KeyChar))
                {
                    e.Handled = true;
                }
            }
            catch (Exception)
            {
                if (e.KeyChar == (char)Keys.Back)
                {
                    e.Handled = false;
                }
                else { e.Handled = true; }
            }
        }

        private void radioButtonTodos_CheckedChanged(object sender, EventArgs e)
        {
            txtPesquisaNomeCliente.Enabled = false;
            txtPesquisaNumeroCliente.Enabled = false;
            txtPesquisaNumeroCliente.Clear();
            txtPesquisaNomeCliente.Clear();
        }
    }
}
