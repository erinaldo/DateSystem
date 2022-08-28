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
    public partial class FormFornecedoresContatos : Form
    {
        DataTable TableFornecedor;
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
        private int ID_TIPO_PESSOA = 0;
        public int IdTipoPessoa
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




        public FormFornecedoresContatos(string NomeServidor, string NomeBaseDados, string NomeUsuario, string SenhaBaseDados)
        {
            InitializeComponent();

            this.NomeServidor = NomeServidor;
            this.NomeBaseDados = NomeBaseDados;
            this.NomeUsuario = NomeUsuario;
            this.SenhaBaseDados = SenhaBaseDados;

            this.connetionString = "Data Source=" + this.NomeServidor + ";Initial Catalog=" + this.NomeBaseDados + ";Persist Security Info=True;User ID=" + this.NomeUsuario + ";Password=" + this.SenhaBaseDados + ";";

        }
        public FormFornecedoresContatos(int a)
        {
            if((1 == a))
            {
                InitializeComponent();

                //buttonBuscaFContatos

                panelFContatos.Enabled = false;

                txtNomeFContatos.MaxLength = 50;

                txtAbreviacaoFContatos.MaxLength = 20;

                txtEmailFContatos.MaxLength = 40;

                txtObservacaoFContatos.MaxLength = 40;

                radioButtonOculto.Checked = true;
            }
            
            
        }

        private void txtDataNascimentoFuncionario_ValueChanged(object sender, EventArgs e)
        {

        }
        // VALIDAR ENTRADA COM ERROPROVIDER
        private Boolean validaAbreviacao(TextBox textBox, ErrorProvider errorProvider)
        {
            if (!String.IsNullOrWhiteSpace(txtAbreviacaoFContatos.Text))
            {
                errorProviderFContatos.SetError(textBox, "");
                return true;
            }
            else
            {
                errorProviderFContatos.SetError(textBox, "Abreviação Inválido!");
                return false;
            }
        }
        private Boolean validaCelular(TextBox textBox, ErrorProvider errorProvider)
        {
            if (!String.IsNullOrWhiteSpace(txtCelularFContatos.Text))
            {
                errorProviderFContatos.SetError(textBox, "");
                return true;
            }
            else
            {
                errorProviderFContatos.SetError(textBox, "Celular Inválido!");
                return false;
            }
        }
        private Boolean validaNome(TextBox textBox, ErrorProvider errorProvider)
        {
            if (!String.IsNullOrWhiteSpace(txtNomeFContatos.Text))
            {
                errorProviderFContatos.SetError(textBox, "");
                return true;
            }
            else
            {
                errorProviderFContatos.SetError(textBox, "Endereço Inválido!");
                return false;
            }
        }

        public void AlteraBotoes(int op)
        {
            if (op == 1)// Cadastra Cliente
            {
                panelFContatos.Enabled = true;

                buttonCadastroFContatos.Enabled = false;

                buttonVerifica.Enabled = true;
                buttonLimpaFornecedor.Enabled = false;
                buttonCancelarFContatos.Enabled = true;
                buttonFecharFContatos.Enabled = false;




            }
            if (op == 2)//salvar Cadastro de Cliente
            {
                panelFContatos.Enabled = false;

                buttonCadastroFContatos.Enabled = true;

                buttonVerifica.Enabled = false;
                buttonLimpaFornecedor.Enabled = false;
                buttonCancelarFContatos.Enabled = false;
                buttonFecharFContatos.Enabled = true;
            }
            if (op == 3)//Calcelar Cadastro de Cliente
            {
                panelFContatos.Enabled = false;

                buttonCadastroFContatos.Enabled = true;

                buttonVerifica.Enabled = false;
                buttonLimpaFornecedor.Enabled = false;
                buttonCancelarFContatos.Enabled = false;
                buttonFecharFContatos.Enabled = true;

            }
            if (op == 4) //  Editar Cadastro de Funcionario
            {
                panelFContatos.Enabled = true;

                buttonCadastroFContatos.Enabled = false;
                buttonVerifica.Enabled = true;
                buttonLimpaFornecedor.Enabled = false;
                buttonCancelarFContatos.Enabled = true;
                buttonFecharFContatos.Enabled = true;

                VERIFICADOREDITAR = true;

            }
            if (op == 5)//Inverte o que o botão Libera
            {
                radioButtonOculto.Checked = true;
            }
            if (op == 6)//Pesquisa de Funcionario Inicializado
            {
                buttonCadastroFContatos.Enabled = false;

                buttonVerifica.Enabled = false;
                buttonLimpaFornecedor.Enabled = false;
                buttonCancelarFContatos.Enabled = true;
                buttonFecharFContatos.Enabled = true;
            }
            if (op == 7)//Limpa Campos de Cima
            {
                txtRespostaEmpresa.Clear();
                txtRespostaEmpresa2.Clear();
                txtPesquisaNomeCadastro.Clear();
                txtPesquisaMSp1.Clear();

            }
            if (op == 8)//Libera Editar e Excluir
            {
            }
            if (op == 9)//Libera Pesquisa Por MS e Nome.
            {

                buttonCadastroFContatos.Enabled = false;
            }
            if (op == 10) //Limpa os textos do txtTodos
            {
                txtNomeFContatos.Clear();
                txtAbreviacaoFContatos.Clear();
                txtTelefoneFContatos.Clear();
                txtTelefone2FContatos.Clear();
                txtCelularFContatos.Clear();
                txtCelular2FContatos.Clear();
                txtEmailFContatos.Clear();
                txtObservacaoFContatos.Clear();

                txtRespostaEmpresa.Clear();
                txtRespostaEmpresa2.Clear();
                txtPesquisaNomeCadastro.Clear();
                txtPesquisaMSp1.Clear();
            }
            if(op == 11)
            {
                radioButtonFNomeCadastro1.Enabled = true;

                radioButtonMSP1.Enabled = true;

                panelPesquisaEmpresa.Enabled = true;

                buttonBuscaEmpresa.Enabled = true;

                buttonLimpaFornecedor.Enabled = true;

                buttonCancelarFContatos.Enabled = true;

                checkBoxClienteSituacao.Checked = true;

                checkBoxClienteSituacao.Enabled = false;

                buttonCadastroFContatos.Enabled = false;
            }
        }


        private void radioButtonPequisaRE_CheckedChanged(object sender, EventArgs e)
        {
            AlteraBotoes(10);
        }

        private void radioButtonPesquisaNome_CheckedChanged(object sender, EventArgs e)
        {
            AlteraBotoes(10);
        }
        //BOTÃO PARA EDITAR CADASTRO DE CLIENTE
        private void buttonEditarCliente_Click(object sender, EventArgs e)
        {
            AlteraBotoes(4);

            this.operacao = "Editar";

        }

        //BOTÃO PARA CANCELAR CADASTRO DE CLIENTE
        private void buttonCancelarCliente_Click(object sender, EventArgs e)
        {
            //CHAMA O METODO CancelaCadastradoCliente QUE FECHA FORMULÁRIOS ABERTOS
            FecharTodosFormulario();
        }


        //METODO PARA VERIFICA SE O FORMULÁRIO ESTA ABERTO SE TIVER ELE FECHA!
        public static void CancelaCadastradoFContatos(Type frmType)
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
            CancelaCadastradoFContatos(typeof(FormFornecedoresContatos));
        }

        ////METODO QUE SELECIONA NOME NO SQL ORDERNADO POR NOME  do contato do Fornecedor
        //public static DataTable LoadDataTableNOMEFornecedor()
        //{
        //    string connetionString = ("Data Source=PROGRAMAS;Initial Catalog=MSOS;Persist Security Info=True;User ID=sa;Password=dellm@ster2016;");
        //    SqlConnection connection;
        //    SqlCommand command;
        //    SqlDataAdapter adapter = new SqlDataAdapter();
        //    DataTable dt = new DataTable();

        //    string sql = "EXEC ConsultaFornecedorNomeCadastroContatos; ";

        //    connection = new SqlConnection(connetionString);
        //    connection.Open();
        //    command = new SqlCommand(sql, connection);
        //    adapter.SelectCommand = command;
        //    adapter.Fill(dt);
        //    connection.Close();

        //    return dt;
        //}

        ////METODO STATIC QUE FAZ A COLEÇÃO DE DADOS DA STRING DA Nome
        //public static AutoCompleteStringCollection LoadAutoCompleteNomeFornecedor()
        //{
        //    DataTable dt = LoadDataTableNOMEFornecedor();

        //    AutoCompleteStringCollection stringNome = new AutoCompleteStringCollection();

        //    foreach (DataRow row in dt.Rows)
        //    {
        //        stringNome.Add(Convert.ToString(row["NOME"]));
        //    }

        //    return stringNome;
        //}
        ////METODO QUE SELECIONA ABREVIACAO NO SQL ORDERNADO POR ABREVIACAO do contato do Fornecedor
        //public static DataTable LoadDataTableABREVIACAOFornecedor()
        //{
        //    string connetionString = ("Data Source=PROGRAMAS;Initial Catalog=MSOS;Persist Security Info=True;User ID=sa;Password=dellm@ster2016;");
        //    SqlConnection connection;
        //    SqlCommand command;
        //    SqlDataAdapter adapter = new SqlDataAdapter();
        //    DataTable dt = new DataTable();

        //    string sql = "EXEC ConsultaContatosFornecedorAbreviacao; ";

        //    connection = new SqlConnection(connetionString);
        //    connection.Open();
        //    command = new SqlCommand(sql, connection);
        //    adapter.SelectCommand = command;
        //    adapter.Fill(dt);
        //    connection.Close();

        //    return dt;
        //}

        ////METODO STATIC QUE FAZ A COLEÇÃO DE DADOS DA STRING DA ABREVIACAO
        //public static AutoCompleteStringCollection LoadAutoCompleteABREVIACAOeFornecedor()
        //{
        //    DataTable dt = LoadDataTableABREVIACAOFornecedor();

        //    AutoCompleteStringCollection stringNome = new AutoCompleteStringCollection();

        //    foreach (DataRow row in dt.Rows)
        //    {
        //        stringNome.Add(Convert.ToString(row["ABREVIACAO"]));
        //    }

        //    return stringNome;
        //}
        //METODO QUE SELECIONA NOME NO SQL ORDERNADO POR NOME do contato do Fornecedor
        public static DataTable LoadDataTableNOMEFContatos()
        {
            string connetionString = ("Data Source=PROGRAMAS;Initial Catalog=MSOS;Persist Security Info=True;User ID=sa;Password=dellm@ster2016;");
            SqlConnection connection;
            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable dt = new DataTable();

            string sql = "EXEC D_ConsultaContatosFornecedorNome; ";

            connection = new SqlConnection(connetionString);
            connection.Open();
            command = new SqlCommand(sql, connection);
            adapter.SelectCommand = command;
            adapter.Fill(dt);
            connection.Close();

            return dt;
        }

        ////METODO STATIC QUE FAZ A COLEÇÃO DE DADOS DA STRING DA NOME contato do fornecedor
        //public static AutoCompleteStringCollection LoadAutoCompleteNomeFContatos()
        //{
        //    DataTable dt = LoadDataTableNOMEFContatos();

        //    AutoCompleteStringCollection stringNome = new AutoCompleteStringCollection();

        //    foreach (DataRow row in dt.Rows)
        //    {
        //        stringNome.Add(Convert.ToString(row["NOME"]));
        //    }

        //    return stringNome;
        //}

        private void buttonEditarFuncionario_Click(object sender, EventArgs e)
        {
            AlteraBotoes(4);

            this.operacao = "Editar";
        }
        private void buttonCancelarFuncionario_Click(object sender, EventArgs e)
        {
            AlteraBotoes(3);
            AlteraBotoes(10);
        }


        private void ButtonPesquisaFuncionario_Click_1(object sender, EventArgs e)
        {
            AlteraBotoes(6);
        }
        private void FormFornecedoresContatos_Load(object sender, EventArgs e)
        {
            //USADO PARA CADASTRA CONTATOS NO FORNECEDOR
            //txtPesquisaNomeCadastro.AutoCompleteMode = AutoCompleteMode.Suggest;
            //txtPesquisaNomeCadastro.AutoCompleteSource = AutoCompleteSource.CustomSource;
            //txtPesquisaNomeCadastro.AutoCompleteCustomSource = FormFornecedoresContatos.LoadAutoCompleteNomeFornecedor();


            panelFContatos.Enabled = false;

            txtNomeFContatos.MaxLength = 50;

            txtAbreviacaoFContatos.MaxLength = 20;

            txtEmailFContatos.MaxLength = 60;

            txtObservacaoFContatos.MaxLength = 40;

            radioButtonOculto.Checked = true;

        }
        public void ConsultaContatosFornecedor()
        {
            SqlConnection conn = new SqlConnection(this.connetionString);

            if (radioButtonFNomeCadastro1.Checked == false)
            {
                MessageBox.Show("Selecione nome do fornecedor para busca!");
            }
            if (radioButtonFNomeCadastro1.Checked == true)
            {
                if (txtPesquisaNomeCadastro.Text == "")
                {
                    //dataGridViewPesquisaCliente.Columns.Clear();
                    dataGridViewPesquisa.Refresh();

                    MessageBox.Show("O nome não pode esta em Branco!");
                }
                if (!(txtPesquisaNomeCadastro.Text == ""))
                {
                    //SELECIONA POR TODOS OS 
                    SqlDataAdapter da1 = new SqlDataAdapter("EXEC D_ConsultaFornecedorNomeCadastroContatostxt '" + txtPesquisaNomeCadastro.Text + "',1;", conn);
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
                        AlteraBotoes(10);
                        MessageBox.Show("Nem um Registro de nome Achado!");
                        conn.Close();
                    }
                    if (ds1.Tables[0].Rows.Count > 0)
                    {
                        conn.Close();

                        dataGridViewPesquisaFornecedores();

                        panelFContatos.Enabled = true;
                        buttonVerifica.Enabled = true;
                        radioButtonFNomeCadastro1.Enabled = true;
                        txtPesquisaMSp1.Enabled = false;

                        dataGridViewPesquisa.RowCount.ToString();
                        ValorPesquisa = 1;
                        label1.Text = "Fornecedor::" + dataGridViewPesquisa.RowCount.ToString();
                    }
                }
            }
        }
        private void buttonCadastroFContatos_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridViewPesquisa.Enabled = true;
                this.operacao = "inserir";

                //buttonVerifica.Enabled = true;

                AlteraBotoes(11);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Carregar o Salvar! " + ex.Message);
            }
        }

        private void buttonVerifica_Click(object sender, EventArgs e)
        {
            Conexao conexao = new Conexao(this.connetionString);
            DALDateSystem da = new DALDateSystem(conexao);

            FornecedorContatos cadastra = new FornecedorContatos();

            if ((validaNome(txtNomeFContatos, errorProviderFContatos) == true)) //(labelConfirmacao.Text).Equals("sucesso - cep completo"))
            {
                try
                {
                    cadastra.IdFornecedor = idPessoa;
                    cadastra.Nome = txtNomeFContatos.Text;
                    cadastra.Abreviacao = txtAbreviacaoFContatos.Text;
                    cadastra.Telefone = txtTelefoneFContatos.Text;
                    cadastra.Telefone2 = txtTelefone2FContatos.Text;
                    cadastra.Celular = txtCelularFContatos.Text;
                    cadastra.Celular2 = txtCelular2FContatos.Text;
                    cadastra.Situacao = 1;
                    cadastra.Email = txtEmailFContatos.Text;
                    cadastra.Observacao = txtObservacaoFContatos.Text;

                    if (this.operacao == "inserir")
                    {
                        da.IncluirFContatos(cadastra);


                        txtPesquisaNomeCadastro.Enabled = false;
                        buttonVerifica.Enabled = false;

                        MessageBox.Show("Contato de fornecedor Cadastrado com Exito! ");

                        FecharTodosFormulario();

                        FormFornecedoresContatos FornecedorContatos = new FormFornecedoresContatos(1);
                        FornecedorContatos.MdiParent = FormFornecedoresContatos.ActiveForm;
                        FornecedorContatos.Show();
                        FornecedorContatos.Top = 0;
                        FornecedorContatos.Left = 0;

                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Erro de acesso ao banco de Dados-----------------------------------------------------------------------------------------------------------------------------------------. ", ex.Message);
                }
            }
            //-------------------------EDITAR CADASTRATO---------------------------------------------------------------------------------------------------------------------------------------------------------------
            if (this.operacao == "Editar")
            {
                if ((validaNome(txtNomeFContatos, errorProviderFContatos) == true))//(labelConfirmacao.Text).Equals("sucesso - cep completo"))
                {
                    try
                    {
                        Conexao conexao1 = new Conexao(this.connetionString);
                        DALDateSystem da1 = new DALDateSystem(conexao1);

                        FornecedorContatos cadastra1 = new FornecedorContatos();

                        cadastra1.IdFornecedor = IDPESSOA;
                        cadastra1.Nome = txtNomeFContatos.Text;
                        cadastra1.Abreviacao = txtAbreviacaoFContatos.Text;
                        cadastra1.Telefone = txtTelefoneFContatos.Text;
                        cadastra1.Telefone2 = txtTelefone2FContatos.Text;
                        cadastra1.Celular = txtCelularFContatos.Text;
                        cadastra1.Celular2 = txtCelular2FContatos.Text;
                        cadastra1.Email = txtEmailFContatos.Text;
                        cadastra1.Observacao = txtObservacaoFContatos.Text;
                        if (checkBoxClienteSituacao.Checked == true)
                        {
                            cadastra.Situacao = 1;
                        }
                        else if (checkBoxClienteSituacao.Checked == false)
                        {
                            cadastra.Situacao = 2;
                        }


                        da1.AlterarFContatos(cadastra1);

                        //CHAMA O METODO CancelaCadastradoCliente QUE FECHA FORMULÁRIOS ABERTOS

                        MessageBox.Show("As alterações no Cadastrado Fornecedor Contatos Foram Salvas!");

                        FecharTodosFormulario();

                        FormFornecedoresContatos FornecedorContatos = new FormFornecedoresContatos(1);
                        FornecedorContatos.MdiParent = FormFornecedoresContatos.ActiveForm;
                        FornecedorContatos.Show();
                        FornecedorContatos.Top = 0;
                        FornecedorContatos.Left = 0;


                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro de acesso ao banco de Dados-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------. ", ex.Message);
                    }
                }
            }
        }
        private void buttonBuscaEmpresa_Click(object sender, EventArgs e)
        {
            ConsultaContatosFornecedor();
        }

        private void radioButtonMSP1_CheckedChanged(object sender, EventArgs e)
        {
            txtPesquisaMSp1.Enabled = true;
            txtPesquisaNomeCadastro.Enabled = false;
            txtPesquisaNomeCadastro.Clear();
            txtRespostaEmpresa.Clear();
            txtRespostaEmpresa2.Clear();
            AlteraBotoes(10);
        }

        private void radioButtonAbreviacaoP1_CheckedChanged(object sender, EventArgs e)
        {
            txtPesquisaNomeCadastro.Enabled = true;
            txtPesquisaMSp1.Enabled = false;
            txtPesquisaMSp1.Clear();
            txtRespostaEmpresa.Clear();
            txtRespostaEmpresa2.Clear();
            AlteraBotoes(10);

        }

        private void buttonCancelarFContatos_Click(object sender, EventArgs e)
        {
            FecharTodosFormulario();

            FormFornecedoresContatos FornecedorContatos = new FormFornecedoresContatos(this.NomeServidor, this.NomeBaseDados, this.NomeUsuario, this.SenhaBaseDados);
            FornecedorContatos.MdiParent = FormFornecedoresContatos.ActiveForm;
            FornecedorContatos.Show();
            FornecedorContatos.Top = 0;
            FornecedorContatos.Left = 0;

        }

        private void buttonFecharFContatos_Click(object sender, EventArgs e)
        {
            FecharTodosFormulario();
        }

        private void ButtonPesquisaFContatos_Click(object sender, EventArgs e)
        {
            //radioButtonPequisaAbreFContatos.Enabled = true;
            //radioButtonMsFContatos.Enabled = true;

            buttonLimpaFornecedor.Enabled = true;
            buttonCancelarFContatos.Enabled = true;

            buttonCadastroFContatos.Enabled = false;
        }

        private void buttonEditarFContatos_Click(object sender, EventArgs e)
        {
            this.operacao = "Editar";

            AlteraBotoes(4);
        }

        private void buttonExcluirFContatos_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Deseja Excluir o registro?", "Aviso", MessageBoxButtons.YesNo);

            Conexao conexao = new Conexao(this.connetionString);
            DALDateSystem dal = new DALDateSystem(conexao);

            if (d.ToString() == "Yes")
            {
                dal.ExcluirFcontatos(idPessoa);

                FecharTodosFormulario();

                FormFornecedoresContatos FContatos = new FormFornecedoresContatos(this.NomeServidor, this.NomeBaseDados, this.NomeUsuario, this.SenhaBaseDados);
                FContatos.MdiParent = FormFornecedoresContatos.ActiveForm;
                FContatos.Show();
                FContatos.Top = 0;
                FContatos.Left = 0;
            }
        }

        private void buttonLimpaFornecedor_Click(object sender, EventArgs e)
        {
            AlteraBotoes(10);
        }
        void dataGridViewPesquisaFornecedores()
        {
            SqlConnection connection = new SqlConnection(this.connetionString);
            SqlCommand command = new SqlCommand("EXEC D_ConsultaFornecedorNomeCadastroContatostxt '" + txtPesquisaNomeCadastro.Text + "',1;", connection);
            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = command;
                TableFornecedor = new DataTable();
                adapter.Fill(TableFornecedor);
                BindingSource Source = new BindingSource();
                Source.DataSource = TableFornecedor;
                dataGridViewPesquisa.DataSource = Source;
                adapter.Update(TableFornecedor);
            }
            catch (Exception ex)
            {
                ex.ToString();
            }

            //DataTable dt = new DataTable();
        }

        private void dataGridViewPesquisa_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(this.connetionString);

                idPessoa = Convert.ToInt32(dataGridViewPesquisa["ID_PESSOA", e.RowIndex].Value);

                //SELECIONA POR TODOS OS 
                SqlDataAdapter da1 = new SqlDataAdapter("EXEC D_ConsultaFornecedorEditar2Txt " + idPessoa + ";", conn);
                DataSet ds1 = new DataSet();
                da1.Fill(ds1);

                conn.Open();

                if (ds1.Tables[0].Rows.Count > 0)
                {
                    idPessoa = int.Parse(ds1.Tables[0].Rows[0][0].ToString());
                    IdTipoPessoa = int.Parse(ds1.Tables[0].Rows[0][1].ToString());

                    try
                    {
                        if (IdTipoPessoa == 1)
                        {
                            try
                            {
                                txtRespostaEmpresa.Text = ds1.Tables[0].Rows[0][2].ToString();
                                txtRespostaEmpresa2.Text = ds1.Tables[0].Rows[0][3].ToString();

                                conn.Close();

                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
                        }
                        if (IdTipoPessoa == 2)
                        {
                            try
                            {
                                txtRespostaEmpresa.Text = ds1.Tables[0].Rows[0][2].ToString();
                                txtRespostaEmpresa2.Text = ds1.Tables[0].Rows[0][4].ToString();

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
                    label1.Text = "Fornecedor::" + dataGridViewPesquisa.RowCount.ToString();
                    ValorPesquisa = 1;
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

        private void txtPesquisaNomeCadastro_TextChanged(object sender, EventArgs e)
        {
            if (ValorPesquisa == 1)
            {
                DataView DV = new DataView(TableFornecedor);
                DV.RowFilter = string.Format("CLIENTE LIKE '%{0}%'", txtPesquisaNomeCadastro.Text);
                dataGridViewPesquisa.DataSource = DV;

                label1.Text = "Fornecedor::" + dataGridViewPesquisa.RowCount.ToString();
            }
        }

        private void txtPesquisaNomeCadastro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                ConsultaContatosFornecedor();
            }
        }

        private void FormFornecedoresContatos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
            {
                this.Close();
            }
        }
    }
}
