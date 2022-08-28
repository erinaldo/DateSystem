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
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace DateSystem
{
    public partial class FormClientesContatos : Form
    {
        DataTable TableCliente;
        private string operacao = "";
        
        private int IDPESSOA = 0;
        public int idPessoa
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
        private int IDCCONTATOS = 0;
        public int idcontatos
        {
            get
            {
                return this.IDCCONTATOS;

            }
            set
            {
                this.IDCCONTATOS = value;
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
        private int ID_CLIENTE = 0;
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
        Boolean VERIFICADOREDITAR = false;
        public Boolean VerificadorEditar
        {
            get
            {
                return this.VERIFICADOREDITAR;

            }
            set
            {
                this.VERIFICADOREDITAR = value;
            }
        }
        Boolean FORMULARIO = false;
        public Boolean Formulario
        {
            get
            {
                return this.FORMULARIO;

            }
            set
            {
                this.FORMULARIO = value;
            }
        }
        Boolean CLIENTECONTATO = false;
        public Boolean ClienteContato
        {
            get
            {
                return this.CLIENTECONTATO;

            }
            set
            {
                this.CLIENTECONTATO = value;
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



        public FormClientesContatos(string NomeServidor, string NomeBaseDados, string NomeUsuario, string SenhaBaseDados)
        {
            InitializeComponent();

            this.NomeServidor = NomeServidor;
            this.NomeBaseDados = NomeBaseDados;
            this.NomeUsuario = NomeUsuario;
            this.SenhaBaseDados = SenhaBaseDados;

            this.connetionString = "Data Source=" + this.NomeServidor + ";Initial Catalog=" + this.NomeBaseDados + ";Persist Security Info=True;User ID=" + this.NomeUsuario + ";Password=" + this.SenhaBaseDados + ";";

        }

        // VALIDAR ENTRADA COM ERROPROVIDER
        private Boolean validaAbreviacao(TextBox textBox, ErrorProvider errorProvider)
        {
            if (!String.IsNullOrWhiteSpace(txtAbreviacaoCContatos.Text))
            {
                errorProviderCClientes.SetError(textBox, "");
                return true;
            }
            else
            {
                errorProviderCClientes.SetError(textBox, "Abreviação Inválido!");
                return false;
            }
        }
        private Boolean validaCelular(TextBox textBox, ErrorProvider errorProvider)
        {
            if (!String.IsNullOrWhiteSpace(txtCelularCContatos.Text))
            {
                errorProviderCClientes.SetError(textBox, "");
                return true;
            }
            else
            {
                errorProviderCClientes.SetError(textBox, "Celular Inválido!");
                return false;
            }
        }
        private Boolean validaNome(TextBox textBox, ErrorProvider errorProvider)
        {
            if (!String.IsNullOrWhiteSpace(txtNomeCContatos.Text))
            {
                errorProviderCClientes.SetError(textBox, "");
                return true;
            }
            else
            {
                errorProviderCClientes.SetError(textBox, "Endereço Inválido!");
                return false;
            }
        }

        public FormClientesContatos(int IdPessoa, string CONNETIONSTRING)
        {
            InitializeComponent();

            this.NomeServidor = NomeServidor;
            this.NomeBaseDados = NomeBaseDados;
            this.NomeUsuario = NomeUsuario;
            this.SenhaBaseDados = SenhaBaseDados;

            //this.connetionString = "Data Source=" + this.NomeServidor + ";Initial Catalog=" + this.NomeBaseDados + ";Persist Security Info=True;User ID=" + this.NomeUsuario + ";Password=" + this.SenhaBaseDados + ";";

            this.connetionString = CONNETIONSTRING;

            this.idPessoa = IdPessoa;

            buttonCadastroCContatos.Enabled = false;

            panelFContatos.Enabled = true;

            this.operacao = "Atualizar";

            SqlConnection conn = new SqlConnection(this.connetionString);

            SqlDataAdapter da = new SqlDataAdapter("EXEC D_ConsultaPessoaIdClienteTxt " + this.idPessoa + ",1; ", conn);//Arruma busca de cliente!
            DataSet ds = new DataSet();
            da.Fill(ds);

            if (ds.Tables[0].Rows.Count > 0)
            {
                int tipoPessoa = 0;

                tipoPessoa = int.Parse(ds.Tables[0].Rows[0][1].ToString());

                if (tipoPessoa == 1)
                {
                    buttonVerifica.Enabled = true;
                    radioButtonMS1.Enabled = false;
                    radioButtonCNome1.Enabled = false;
                    txtPesquisaMSp1.Enabled = false;
                    txtPesquisaCCadastro1.Enabled = false;

                    txtRespostaEmpresa.Text = ds.Tables[0].Rows[0][3].ToString();
                    txtRespostaEmpresa2.Text = ds.Tables[0].Rows[0][15].ToString();
                }
                if (tipoPessoa == 2)
                {
                    buttonVerifica.Enabled = true;
                    radioButtonMS1.Enabled = false;
                    radioButtonCNome1.Enabled = false;
                    txtPesquisaMSp1.Enabled = false;
                    txtPesquisaCCadastro1.Enabled = false;

                    txtRespostaEmpresa.Text = ds.Tables[0].Rows[0][3].ToString();
                    txtRespostaEmpresa2.Text = ds.Tables[0].Rows[0][23].ToString();
                }
            }
        }
        public void AlteraBotoes(int op)
        {
            if (op == 1)// Cadastra Cliente
            {
                panelFContatos.Enabled = true;

                buttonCadastroCContatos.Enabled = false;


                buttonVerifica.Enabled = true;
                buttonCancelarCContatos.Enabled = true;
                buttonFecharCContatos.Enabled = false;

            }
            if (op == 2)//salvar Cadastro de Cliente
            {
                panelFContatos.Enabled = false;

                buttonCadastroCContatos.Enabled = true;


                buttonVerifica.Enabled = false;
                buttonCancelarCContatos.Enabled = false;
                buttonFecharCContatos.Enabled = true;
            }
            if (op == 3)//Calcelar Cadastro de Cliente
            {
                panelFContatos.Enabled = false;

                buttonCadastroCContatos.Enabled = true;


                buttonVerifica.Enabled = false;
                buttonCancelarCContatos.Enabled = false;
                buttonFecharCContatos.Enabled = true;

            }
            if (op == 4) //  Editar Cadastro de Funcionario
            {
                panelFContatos.Enabled = true;

                buttonCadastroCContatos.Enabled = false;


                buttonVerifica.Enabled = true;
                buttonCancelarCContatos.Enabled = true;
                buttonFecharCContatos.Enabled = true;

                VERIFICADOREDITAR = true;

            }
            if (op == 5)//Inverte o que o botão Libera
            {
                radioButtonOculto.Checked = true;

            }
            if (op == 6)//Pesquisa de Funcionario Inicializado
            {
                buttonCadastroCContatos.Enabled = false;

                buttonVerifica.Enabled = false;
                buttonCancelarCContatos.Enabled = true;
                buttonFecharCContatos.Enabled = true;
            }
            if (op == 7)//Limpa Campos de Cima
            {
                txtRespostaEmpresa.Clear();
                txtRespostaEmpresa2.Clear();
                txtPesquisaCCadastro1.Clear();
                txtPesquisaMSp1.Clear();

            }
            if (op == 8)//Libera Editar e Excluir
            {
            }
            if (op == 9)//Libera Pesquisa Por MS e Nome.
            {
                buttonCadastroCContatos.Enabled = false;
            }
            if (op == 10) //Limpa os textos do txtTodos
            {
                txtNomeCContatos.Clear();
                txtAbreviacaoCContatos.Clear();
                txtTelefoneCContatos.Clear();
                txtTelefone2CContatos.Clear();
                txtCelularCContatos.Clear();
                txtCelular2CContatos.Clear();
                txtEmailCContatos.Clear();
                txtObservacaoCContatos.Clear();

                txtRespostaEmpresa.Clear();
                txtRespostaEmpresa2.Clear();
                //txtPesquisaMSp1.Clear();
                txtPesquisaCCadastro1.Clear();
            }
            if(op == 11)
            {
                txtNomeCContatos.Clear();
                txtAbreviacaoCContatos.Clear();
                txtTelefoneCContatos.Clear();
                txtTelefone2CContatos.Clear();
                txtCelularCContatos.Clear();
                txtCelular2CContatos.Clear();
                txtEmailCContatos.Clear();
                txtObservacaoCContatos.Clear();

            }
        }

        public void SalvarContato()
        {
            Conexao conexao = new Conexao(this.connetionString);
            DALDateSystem da = new DALDateSystem(conexao);

            ClientesContatos cadastra = new ClientesContatos();


            if ((validaNome(txtNomeCContatos, errorProviderCClientes) == true) && (validaAbreviacao(txtAbreviacaoCContatos, errorProviderCClientes) == true)) //(labelConfirmacao.Text).Equals("sucesso - cep completo"))
            {
                try
                {
                    cadastra.IdContatof = idPessoa;
                    cadastra.Nome = txtNomeCContatos.Text;
                    cadastra.Abreviacao = txtAbreviacaoCContatos.Text;
                    cadastra.Telefone = txtTelefoneCContatos.Text;
                    cadastra.Telefone2 = txtTelefone2CContatos.Text;
                    cadastra.Celular = txtCelularCContatos.Text;
                    cadastra.Celular2 = txtCelular2CContatos.Text;
                    cadastra.Situacao = 1;
                    cadastra.Email = txtEmailCContatos.Text;
                    cadastra.Observacao = txtObservacaoCContatos.Text;
                    
                    //VERIFICA SE Existe já um Abreviacao! 
                    SqlConnection conn = new SqlConnection(this.connetionString);

                    SqlDataAdapter da2 = new SqlDataAdapter("EXEC D_ConsultaClienteContatoAbreviacaoTxt '" + txtAbreviacaoCContatos.Text + "',1,1;", conn);
                    DataSet ds2 = new DataSet();
                    da2.Fill(ds2);

                    conn.Open();

                    if (this.operacao == "inserir")
                    {

                        if (ds2.Tables[0].Rows.Count == 0)
                        {
                            da.IncluirCContatos(cadastra);

                            checkBoxClienteSituacao.Enabled = false;
                            txtPesquisaCCadastro1.Enabled = false;
                            buttonVerifica.Enabled = false;

                            MessageBox.Show("Contato de Cliente Cadastrado com Exito! ");

                            FecharTodosFormulario();

                            FormClientesContatos ClientesContatos = new FormClientesContatos(this.idPessoa, this.connetionString);
                            ClientesContatos.MdiParent = FormClientesContatos.ActiveForm;
                            ClientesContatos.Show();
                            ClientesContatos.Top = 0;
                            ClientesContatos.Left = 0;
                            buttonVerifica.Enabled = true;
                            conn.Close();

                        }
                        if ((ds2.Tables[0].Rows.Count > 0))
                        {
                            MessageBox.Show("Abreviação não é aceita já consta contato com este formato! ");
                            conn.Close();
                        }

                    }
                    if (this.operacao == "Atualizar")
                    {
                        if (ds2.Tables[0].Rows.Count == 0)
                        {

                            da.IncluirCContatos(cadastra);

                            checkBoxClienteSituacao.Enabled = false;
                            txtPesquisaCCadastro1.Enabled = false;
                            buttonVerifica.Enabled = false;

                            MessageBox.Show("Contato de Cliente Atualizado com Exito! ");

                            FecharTodosFormulario();

                            FormClientesContatos ClientesContatos = new FormClientesContatos(this.idPessoa, this.connetionString);
                            ClientesContatos.MdiParent = FormClientesContatos.ActiveForm;
                            ClientesContatos.Show();
                            ClientesContatos.Top = 0;
                            ClientesContatos.Left = 0;
                            conn.Close();

                        }
                        if ((ds2.Tables[0].Rows.Count > 0))
                        {
                            MessageBox.Show("Abreviação não é aceita já consta contato com este formato! ");
                            conn.Close();
                        }
                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Erro de acesso ao banco de Dados-----------------------------------------------------------------------------------------------------------------------------------------. ", ex.Message);
                }
            }
        }
        private void buttonVerifica_Click(object sender, EventArgs e)
        {
            SalvarContato();
        }

        ////METODO QUE SELECIONA MS NO SQL ORDERNADO POR NOME do contato do Fornecedor
        //public static DataTable LoadDataTableNOMECContatos(string connetionString)
        //{
        //    SqlConnection connection;
        //    SqlCommand command;
        //    SqlDataAdapter adapter = new SqlDataAdapter();
        //    DataTable dt = new DataTable();
        //    string sql = "EXEC D_ConsultaClienteContatoNomeTxt; ";
        //    connection = new SqlConnection(connetionString);
        //    connection.Open();
        //    command = new SqlCommand(sql, connection);
        //    adapter.SelectCommand = command;
        //    adapter.Fill(dt);
        //    connection.Close();

        //    return dt;

        //}

        ////METODO STATIC QUE FAZ A COLEÇÃO DE DADOS DA STRING DA ABREVIACAO
        //public static AutoCompleteStringCollection LoadAutoCompleteAbreFContatos()
        //{
        //    DataTable dt = LoadDataTableAbreFContatos();

        //    AutoCompleteStringCollection stringAbreviacao = new AutoCompleteStringCollection();

        //    foreach (DataRow row in dt.Rows)
        //    {
        //        stringAbreviacao.Add(Convert.ToString(row["ABREVIACAO"]));
        //    }

        //    return stringAbreviacao;
        //}
        //public static DataTable LoadDataTableAbreFContatos()
        //{
        //    string connetionString = ("Data Source=PROGRAMAS;Initial Catalog=MSOS;Persist Security Info=True;User ID=sa;Password=dellm@ster2016;");
        //    SqlConnection connection;
        //    SqlCommand command;
        //    SqlDataAdapter adapter = new SqlDataAdapter();
        //    DataTable dt = new DataTable();
        //    string sql = "EXEC ConsultaClienteContatoAbreviacao; ";
        //    connection = new SqlConnection(connetionString);
        //    connection.Open();
        //    command = new SqlCommand(sql, connection);
        //    adapter.SelectCommand = command;
        //    adapter.Fill(dt);
        //    connection.Close();

        //    return dt;
        //}

        ///*---------------------------------------------------------------------------------------------------------------------------------------------------------*/
        ////METODO STATIC QUE FAZ A COLEÇÃO DE DADOS DA STRING DA NOME
        //public static AutoCompleteStringCollection LoadAutoCompleteNOMECliente()
        //{
        //    DataTable dt = LoadDataTableNOMECliente();

        //    AutoCompleteStringCollection MS = new AutoCompleteStringCollection();

        //    foreach (DataRow row in dt.Rows)
        //    {
        //        MS.Add(Convert.ToString(row["NOME"]));
        //    }

        //    return MS;
        //}
        ////METODO QUE SELECIONA MS NO SQL ORDERNADO POR MS
        //public static DataTable LoadDataTableNOMECliente()
        //{
        //    string connetionString = ("Data Source=PROGRAMAS;Initial Catalog=MSOS;Persist Security Info=True;User ID=sa;Password=dellm@ster2016;");
        //    SqlConnection connection;
        //    SqlCommand command;
        //    SqlDataAdapter adapter = new SqlDataAdapter();
        //    DataTable dt = new DataTable();
        //    string sql = "EXEC ConsultaClienteContatoNome; ";
        //    connection = new SqlConnection(connetionString);
        //    connection.Open();
        //    command = new SqlCommand(sql, connection);
        //    adapter.SelectCommand = command;
        //    adapter.Fill(dt);
        //    connection.Close();

        //    return dt;
        //}

        ////METODO STATIC QUE FAZ A COLEÇÃO DE DADOS DA STRING DA MS
        //public static AutoCompleteStringCollection LoadAutoCompleteMsFContatos()
        //{
        //    DataTable dt = LoadDataTableMSFContatos();

        //    AutoCompleteStringCollection MS = new AutoCompleteStringCollection();

        //    foreach (DataRow row in dt.Rows)
        //    {
        //        MS.Add(Convert.ToString(row["MS"]));
        //    }

        //    return MS;
        //}
        ////METODO QUE SELECIONA MS NO SQL ORDERNADO POR MS
        //public static DataTable LoadDataTableMSFContatos()
        //{
        //    string connetionString = ("Data Source=PROGRAMAS;Initial Catalog=MSOS;Persist Security Info=True;User ID=sa;Password=dellm@ster2016;");
        //    SqlConnection connection;
        //    SqlCommand command;
        //    SqlDataAdapter adapter = new SqlDataAdapter();
        //    DataTable dt = new DataTable();
        //    string sql = "EXEC ConsultaPessoaMsCliente; ";
        //    connection = new SqlConnection(connetionString);
        //    connection.Open();
        //    command = new SqlCommand(sql, connection);
        //    adapter.SelectCommand = command;
        //    adapter.Fill(dt);
        //    connection.Close();

        //    return dt;
        //}

        /*-------------------------------------------------------------------------------------------------------------------------------------------*/

        private void FormClientesContatos_Load(object sender, EventArgs e)
        {
            //Consulta Cliente por MS
            //txtPesquisaMSp1.AutoCompleteMode = AutoCompleteMode.Suggest;
            //txtPesquisaMSp1.AutoCompleteSource = AutoCompleteSource.CustomSource;
            //txtPesquisaMSp1.AutoCompleteCustomSource = FormClientesContatos.LoadAutoCompleteMsFContatos();

            ////Consulta Cliente por NOME
            //txtPesquisaCCadastro1.AutoCompleteMode = AutoCompleteMode.Suggest;
            //txtPesquisaCCadastro1.AutoCompleteSource = AutoCompleteSource.CustomSource;
            //txtPesquisaCCadastro1.AutoCompleteCustomSource = FormClientesContatos.LoadAutoCompleteNOMECliente();

             txtNomeCContatos.MaxLength = 50;

            txtAbreviacaoCContatos.MaxLength = 20;

            txtEmailCContatos.MaxLength = 60;

            txtObservacaoCContatos.MaxLength = 40;

            radioButtonOculto.Checked = true;

        }
        public static void CancelaCadastradoCContatos(Type frmType)
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
            CancelaCadastradoCContatos(typeof(FormClientesContatos));
        }

        private void radioButtonPesquisaNome_CheckedChanged(object sender, EventArgs e)
        {
            AlteraBotoes(10);
        }


        private void buttonEditarCContatos_Click(object sender, EventArgs e)
        {
            this.operacao = "Editar";

            AlteraBotoes(4);
            checkBoxClienteSituacao.Enabled = true;
        }

        private void buttonExcluirCContatos_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonLimpaFornecedor_Click(object sender, EventArgs e)
        {
            AlteraBotoes(11);
        }

        private void buttonCancelarCContatos_Click(object sender, EventArgs e)
        {
            FecharTodosFormulario();
            FormClientesContatos FContatos = new FormClientesContatos(this.NomeServidor, this.NomeBaseDados, this.NomeUsuario, this.SenhaBaseDados);
            FContatos.MdiParent = FormClientesContatos.ActiveForm;
            FContatos.Show();
            FContatos.Top = 0;
            FContatos.Left = 0;
        }

        private void buttonFecharCContatos_Click(object sender, EventArgs e)
        {
            FecharTodosFormulario();
        }
        private void ButtonPesquisaCContatos_Click(object sender, EventArgs e)
        {
            //radioButtonPequisaAbreFContatos.Enabled = true;
            //radioButtonMsFContatos.Enabled = true;
            panelPesquisaEmpresa.Enabled = true;
        }

        private void buttonCadastroCContatos_Click(object sender, EventArgs e)
        {
            try
            {
                this.operacao = "inserir";

                //buttonVerifica.Enabled = true;

                radioButtonCNome1.Enabled = true;

                radioButtonMS1.Enabled = true;

                panelPesquisaEmpresa.Enabled = true;

                buttonBuscaEmpresa.Enabled = true;

                checkBoxClienteSituacao.Checked = true;

                checkBoxClienteSituacao.Enabled = false;

                buttonCadastroCContatos.Enabled = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Carregar o Salvar! " + ex.Message);
            }
        }

        private void radioButtonAbreviacaoP1_CheckedChanged(object sender, EventArgs e)
        {
            txtPesquisaCCadastro1.Enabled = true;
            txtPesquisaMSp1.Enabled = false;
            txtPesquisaMSp1.Clear();
            txtRespostaEmpresa.Clear();
            txtRespostaEmpresa2.Clear();
            AlteraBotoes(10);
        }

        private void radioButtonMSP1_CheckedChanged(object sender, EventArgs e)
        {
            txtPesquisaMSp1.Enabled = true;
            txtPesquisaCCadastro1.Enabled = false;
            txtPesquisaCCadastro1.Clear();
            txtRespostaEmpresa.Clear();
            txtRespostaEmpresa2.Clear();
            AlteraBotoes(10);
        }

        private void ButtonPesquisaCContatos_Click_1(object sender, EventArgs e)
        {
            buttonCadastroCContatos.Enabled = false;
        }

        private void buttonCadastroCContatos_Click_1(object sender, EventArgs e)
        {
            panelPesquisaEmpresa.Enabled = true;
            radioButtonCNome1.Enabled = true;
            radioButtonMS1.Enabled = true;
            buttonBuscaEmpresa.Enabled = true;
            dataGridViewPesquisa.Enabled = true;

            this.operacao = "inserir";

            buttonCadastroCContatos.Enabled = false;
        }

        private void radioButtonCNome1_CheckedChanged(object sender, EventArgs e)
        {
            txtPesquisaCCadastro1.Enabled = true;
            txtPesquisaMSp1.Enabled = false;
            AlteraBotoes(10);
        }

        private void radioButtonMS1_CheckedChanged(object sender, EventArgs e)
        {
            txtPesquisaCCadastro1.Enabled = false;
            txtPesquisaMSp1.Enabled = true;
            AlteraBotoes(10);
        }

        private void buttonBuscaEmpresa_Click(object sender, EventArgs e)
        {
            ConsultaContatoCliente();
            
        }
        public void ConsultaContatoCliente()
        {
            SqlConnection conn = new SqlConnection(this.connetionString);

            if (radioButtonMS1.Checked)
            {
                if (txtPesquisaMSp1.Text == "")
                {
                    MessageBox.Show("Por favor o ms não pode esta em Branco!");
                    AlteraBotoes(10);
                }

                if (!(txtPesquisaMSp1.Text == ""))
                {
                    //SELECIONA POR ms
                    int MS = int.Parse(txtPesquisaMSp1.Text);
                    SqlDataAdapter da = new SqlDataAdapter("EXEC D_ConsultaPessoaMsClienteTxt " + MS + ",1; ", conn);//Arruma busca de cliente!
                    DataSet ds = new DataSet();
                    da.Fill(ds);

                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        int tipoPessoa = 0;
                        idPessoa = int.Parse(ds.Tables[0].Rows[0][0].ToString());
                        tipoPessoa = int.Parse(ds.Tables[0].Rows[0][1].ToString());

                        if (tipoPessoa == 1)
                        {
                            panelFContatos.Enabled = true;
                            buttonVerifica.Enabled = true;
                            radioButtonMS1.Enabled = false;
                            radioButtonCNome1.Enabled = false;
                            txtPesquisaMSp1.Enabled = false;
                            txtPesquisaCCadastro1.Enabled = false;
                            txtRespostaEmpresa.Text = ds.Tables[0].Rows[0][3].ToString();
                            txtRespostaEmpresa2.Text = ds.Tables[0].Rows[0][16].ToString();
                        }
                        if (tipoPessoa == 2)
                        {
                            panelFContatos.Enabled = true;
                            buttonVerifica.Enabled = true;
                            radioButtonMS1.Enabled = false;
                            radioButtonCNome1.Enabled = false;
                            txtPesquisaMSp1.Enabled = false;
                            txtPesquisaCCadastro1.Enabled = false;

                            txtRespostaEmpresa.Text = ds.Tables[0].Rows[0][3].ToString();
                            txtRespostaEmpresa2.Text = ds.Tables[0].Rows[0][24].ToString();
                        }
                    }
                    if (!(ds.Tables[0].Rows.Count > 0))
                    {
                        MessageBox.Show("O Ms  " + txtPesquisaMSp1.Text + " nao consta no sistema! ");
                        AlteraBotoes(10);
                    }
                    VALORPESQUISA = 1;
                }
            }
            if (radioButtonCNome1.Checked)
            {
                if (txtPesquisaCCadastro1.Text == "")
                {
                    //dataGridViewPesquisaCliente.Columns.Clear();
                    dataGridViewPesquisa.Refresh();

                    MessageBox.Show("O nome não pode esta em Branco!");
                }
                if (!(txtPesquisaCCadastro1.Text == ""))
                {
                    //SELECIONA POR TODOS OS 
                    SqlDataAdapter da1 = new SqlDataAdapter("EXEC D_ConsultaPessoaClienteNomeTxt '" + txtPesquisaCCadastro1.Text + "',1;", conn);
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

                        MessageBox.Show("Nem um Registro de nome Achado!");
                        conn.Close();
                    }
                    if (ds1.Tables[0].Rows.Count > 0)
                    {
                        conn.Close();

                        dataGridViewPesquisaCliente();

                        dataGridViewPesquisa.RowCount.ToString();
                    }
                    label1.Text = "Cliente:" + dataGridViewPesquisa.RowCount.ToString();
                    VALORPESQUISA = 2;
                }
            }
            if ((radioButtonMS1.Checked == false) && (radioButtonCNome1.Checked == false))
            {
                MessageBox.Show("Selecione Ms ou Nome!");
            }            
        }
        void dataGridViewPesquisaCliente()
        {
            SqlConnection connection = new SqlConnection(this.connetionString);
            SqlCommand command = new SqlCommand("EXEC D_ConsultaPessoaClienteNomeTxt '" + txtPesquisaCCadastro1.Text + "',1;", connection);
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
        }

        private void dataGridViewPesquisa_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewPesquisa.RowCount == 0)
            {
                idPessoa = 0;
            }
            if (!(dataGridViewPesquisa.RowCount == 0))
            {
                try
                {
                    SqlConnection conn = new SqlConnection(this.connetionString);

                    idPessoa = Convert.ToInt32(dataGridViewPesquisa["ID_PESSOA", e.RowIndex].Value);

                    //SELECIONA POR TODOS OS 
                    SqlDataAdapter da1 = new SqlDataAdapter("EXEC D_ConsultaClienteEditarTxt " + idPessoa + ";", conn);
                    DataSet ds1 = new DataSet();
                    da1.Fill(ds1);
                    this.idPessoa = idPessoa;
                    conn.Open();

                    if (ds1.Tables[0].Rows.Count > 0)
                    {
                        if (idPessoa != 0)
                        {
                            try
                            {
                                idPessoaTipo = int.Parse(ds1.Tables[0].Rows[0][1].ToString());
                                panelFContatos.Enabled = true;
                                panelPesquisaEmpresa.Enabled = true;

                                if (idPessoaTipo == 1)
                                {
                                    txtRespostaEmpresa.Text = ds1.Tables[0].Rows[0][3].ToString();
                                    txtRespostaEmpresa2.Text = ds1.Tables[0].Rows[0][15].ToString();

                                    conn.Close();
                                }
                                if (idPessoaTipo == 2)
                                {
                                    txtRespostaEmpresa.Text = ds1.Tables[0].Rows[0][3].ToString();
                                    txtRespostaEmpresa2.Text = ds1.Tables[0].Rows[0][24].ToString();                                

                                    conn.Close();
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }

                        }
                        if (idPessoa == 0)
                        {
                            panelFContatos.Enabled = false;
                            panelPesquisaEmpresa.Enabled = false;

                            AlteraBotoes(11);
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

        private void txtPesquisaMSp1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Se a tecla digitada não for número
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }
            if (e.KeyChar == 13)
            {
                ConsultaContatoCliente();
            }
        }

        private void txtPesquisaCCadastro1_TextChanged(object sender, EventArgs e)
        {
            if (ValorPesquisa == 2)
            {
                DataView DV = new DataView(TableCliente);
                DV.RowFilter = string.Format("CLIENTE LIKE '%{0}%'", txtPesquisaCCadastro1.Text);
                dataGridViewPesquisa.DataSource = DV;

                label1.Text = "Cliente:" + dataGridViewPesquisa.RowCount.ToString();
            }
        }

        private void txtPesquisaCCadastro1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                ConsultaContatoCliente();
            }
        }

        private void FormClientesContatos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
            {
                this.Close();
            }
        }
    }
}
