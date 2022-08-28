//public partial class FormPesquisaFuncionarioEditar : Form
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
    public partial class FormPesquisaFuncionarioEditar : Form
    {
        //MSOSEntities MSOS = null;

        private string operacao = "";
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
        private int IDPESSOA = 0;
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
        private int FUNCIONARIOEDITAR = 0;
        public int FuncionarioEditar
        {
            get
            {
                return this.FUNCIONARIOEDITAR;

            }
            set
            {
                this.FUNCIONARIOEDITAR = value;
            }
        }
        private int FUNCIONARIOEXCLUIR = 0;
        public int FuncionarioExcluir
        {
            get
            {
                return this.FUNCIONARIOEXCLUIR;

            }
            set
            {
                this.FUNCIONARIOEXCLUIR = value;
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


        public FormPesquisaFuncionarioEditar(string NomeServidor, string NomeBaseDados, string NomeUsuario, string SenhaBaseDados)
        {
            InitializeComponent();

            this.NomeServidor = NomeServidor;
            this.NomeBaseDados = NomeBaseDados;
            this.NomeUsuario = NomeUsuario;
            this.SenhaBaseDados = SenhaBaseDados;

            this.connetionString = "Data Source=" + this.NomeServidor + ";Initial Catalog=" + this.NomeBaseDados + ";Persist Security Info=True;User ID=" + this.NomeUsuario + ";Password=" + this.SenhaBaseDados + ";";


        }
        // VALIDAR ENTRADA COM ERROPROVIDER
        private Boolean validaNome(TextBox textBox, ErrorProvider errorProvider)
        {
            if (!String.IsNullOrWhiteSpace(txtNomeFuncionario.Text))
            {
                errorProviderFuncionario.SetError(textBox, "");
                return true;
            }
            else
            {
                errorProviderFuncionario.SetError(textBox, "Nome Inválido!");
                return false;
            }
        }

        // VALIDAR ENTRADA COM ERROPROVIDER
        private Boolean validaEndereco(TextBox textBox, ErrorProvider errorProvider)
        {
            if (!String.IsNullOrWhiteSpace(txtEnderecoFuncionario.Text))
            {
                errorProviderFuncionario.SetError(textBox, "");
                return true;
            }
            else
            {
                errorProviderFuncionario.SetError(textBox, "Endereço Inválido!");
                return false;
            }
        }
        // VALIDAR ENTRADA COM ERROPROVIDER
        private Boolean validaTelefone(TextBox textBox, ErrorProvider errorProvider)
        {
            if (!String.IsNullOrWhiteSpace(txtTelefoneFuncionario.Text))
            {
                errorProviderFuncionario.SetError(textBox, "");
                return true;
            }
            else
            {
                errorProviderFuncionario.SetError(textBox, "Telefone Inválido!");
                return false;
            }
        }
        // VALIDAR ENTRADA COM ERROPROVIDER
        private Boolean validaBairro(TextBox textBox, ErrorProvider errorProvider)
        {
            if (!String.IsNullOrWhiteSpace(txtBairroFuncionario.Text))
            {
                errorProviderFuncionario.SetError(textBox, "");
                return true;
            }
            else
            {
                errorProviderFuncionario.SetError(textBox, "Bairro Inválido!");
                return false;
            }
        }
        // VALIDAR ENTRADA COM ERROPROVIDER
        private Boolean validaCep(MaskedTextBox textBox, ErrorProvider errorProvider)
        {
            if (!String.IsNullOrWhiteSpace(txtCepFuncionario.Text))
            {
                errorProviderFuncionario.SetError(textBox, "");
                return true;
            }
            else
            {
                errorProviderFuncionario.SetError(textBox, "Cep Inválido!");
                return false;
            }
        }
        // VALIDAR ENTRADA COM ERROPROVIDER
        private Boolean validaCidade(TextBox textBox, ErrorProvider errorProvider)
        {
            if (!String.IsNullOrWhiteSpace(txtCidadeFuncionario.Text))
            {
                errorProviderFuncionario.SetError(textBox, "");
                return true;
            }
            else
            {
                errorProviderFuncionario.SetError(textBox, "Cidade Inválido!");
                return false;
            }
        }
        // VALIDAR ENTRADA COM ERROPROVIDER
        private Boolean validaEmail(TextBox textBox, ErrorProvider errorProvider)
        {
            string email = txtEmailFuncionario.Text;
            string modelo = @"[\w\.-]+(\+[\w-]*)?@([\w-]+\.)+[\w-]+";

            if (Regex.IsMatch(email, modelo))
            {
                errorProviderFuncionario.SetError(textBox, "");
                return true;
            }
            else
            {
                errorProviderFuncionario.SetError(textBox, "E-mail Inválido!");
                return false;
            }
        }
        private Boolean validaNumero(TextBox textBox, ErrorProvider errorProvider)
        {
            if (!String.IsNullOrWhiteSpace(txtBairroNumeroFuncionario.Text))
            {
                errorProviderFuncionario.SetError(textBox, "");
                return true;
            }
            else
            {
                errorProviderFuncionario.SetError(textBox, "Numero Inválido!");
                return false;
            }
        }
        //VALIDAR ENTRADA COM ERROPROVIDER
        private Boolean validaRg(TextBox textBox, ErrorProvider errorProvider)
        {
            if (!String.IsNullOrWhiteSpace(txtRgFuncionario.Text))
            {
                errorProviderFuncionario.SetError(textBox, "");
                return true;
            }
            else
            {
                errorProviderFuncionario.SetError(textBox, "Rg Inválido!");
                return false;
            }
        }
        // VALIDAR ENTRADA COM ERROPROVIDER
        private Boolean validaCpf(MaskedTextBox textBox, ErrorProvider errorProvider)
        {
            if (!String.IsNullOrWhiteSpace(txtCpfFuncionario.Text))
            {
                errorProviderFuncionario.SetError(textBox, "");
                return true;
            }
            else
            {
                errorProviderFuncionario.SetError(textBox, "Cpf Inválido!");
                return false;
            }
        }
        // VALIDAR ENTRADA COM ERROPROVIDER
        private bool validaCelular(MaskedTextBox textBox, ErrorProvider errorProvider)
        {
            if (!String.IsNullOrWhiteSpace(txtCelularFuncionario.Text))
            {
                errorProviderFuncionario.SetError(textBox, "");
                return true;
            }
            else
            {
                errorProviderFuncionario.SetError(textBox, "Celular Inválido!");
                return false;
            }
        }
        public void FecharTodosFormulario()
        {
            //CHAMA O METODO CancelaCadastradoFornecedor QUE FECHA FORMULÁRIOS ABERTOS
            CancelaCadastradoFornecedor(typeof(FormPesquisaFuncionarioEditar));
        }
        //METODO QUE SELECIONA MS NO SQL ORDERNADO POR NOME
        public static DataTable LoadDataTableNOME()
        {
            string connetionString = ("Data Source=PROGRAMAS;Initial Catalog=MSOS;Persist Security Info=True;User ID=sa;Password=dellm@ster2016;");
            SqlConnection connection;
            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable dt = new DataTable();
            string sql = "EXEC ConsultaPessoaFornecedorNome;";
            connection = new SqlConnection(connetionString);
            connection.Open();
            command = new SqlCommand(sql, connection);
            adapter.SelectCommand = command;
            adapter.Fill(dt);
            connection.Close();

            return dt;
        }

        //METODO STATIC QUE FAZ A COLEÇÃO DE DADOS DA STRING DA NOME
        public static AutoCompleteStringCollection LoadAutoCompleteNome()
        {
            DataTable dt = LoadDataTableNOME();

            AutoCompleteStringCollection stringNome = new AutoCompleteStringCollection();

            foreach (DataRow row in dt.Rows)
            {
                stringNome.Add(Convert.ToString(row["NOME"]));
            }

            return stringNome;
        }

        private void FormFornecedores_Load(object sender, EventArgs e)
        {


            txtNomeFuncionario.MaxLength = 50;

            txtEmailFuncionario.MaxLength = 40;

            txtObservacaoFuncionario.MaxLength = 40;


        }

        //Cadastrar Funcionario
        private void buttonCadastraFornecedor_Click(object sender, EventArgs e)
        {
            try
            {
                this.operacao = "Inserir";

                AlteraBotoes(1);

                checkBoxClienteSituacao.Checked = true;

                checkBoxClienteSituacao.Enabled = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Carregar o Salvar! " + ex.Message);
            }
        }
        //METODO PARA VERIFICA SE O FORMULÁRIO ESTA ABERTO SE TIVER ELE FECHA!
        public static void CancelaCadastradoFornecedor(Type frmType)
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

        //Metodo que altera Botões e outras funções
        public void AlteraBotoes(int op)
        {
            if (op == 1)// Cadastra Cliente
            {
            }
            if (op == 2)//salvar Cadastro de Cliente
            {

            }
            if (op == 3)//Calcelar Cadastro de Cliente
            {

            }
            if (op == 4) //  Editar Cadastro de Cliente
            {

            }
            if (op == 5)//Cancela Pesquisa
            {

            }
            if (op == 6)//Cadastro de Cliente Inicializado
            {
            }
            if (op == 7)//Botão Verificar informações Passadas
            {
            }
            if (op == 8)//Libera Pessoa Fisica e Juridica!
            {
            }
            if (op == 9)//Libera Pesquisa Por MS e Nome.
            {

            }
            if (op == 10)
            {

            }
            if (op == 11)
            {//Pessoa Fisica



            }
            if (op == 12)
            {//Pessoa Juridica
            }
        }

        private void buttonEditarFornecedor_Click(object sender, EventArgs e)
        {
            AlteraBotoes(4);

            this.operacao = "Editar";

        }

        private void buttonExcluirFornecedor_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Deseja Excluir o registro?", "Aviso", MessageBoxButtons.YesNo);

            Conexao conexao = new Conexao(this.connetionString);
            DALDateSystem dal = new DALDateSystem(conexao);

            if (d.ToString() == "Yes")
            {
                if (this.ID_TIPO_PESSOA == 1)
                {
                    dal.ExcluirFornecedorFisico(IdPessoa);

                    FecharTodosFormulario();
                    FormPesquisaFuncionario Fornecedor = new FormPesquisaFuncionario(this.NomeServidor, this.NomeBaseDados, this.NomeUsuario, this.SenhaBaseDados);
                    Fornecedor.MdiParent = FormPesquisaFuncionario.ActiveForm;
                    Fornecedor.Show();
                    Fornecedor.Top = 0;
                    Fornecedor.Left = 0;
                }
                if (this.ID_TIPO_PESSOA == 2)
                {
                    dal.ExcluirFornecedorJuridica(IdPessoa);

                    FecharTodosFormulario();
                    FormPesquisaFuncionario Fornecedor = new FormPesquisaFuncionario(this.NomeServidor, this.NomeBaseDados, this.NomeUsuario, this.SenhaBaseDados);
                    Fornecedor.MdiParent = FormPesquisaFuncionario.ActiveForm;
                    Fornecedor.Show();
                    Fornecedor.Top = 0;
                    Fornecedor.Left = 0;
                }
            }
        }
        private void buttonEditarFuncionario_Click(object sender, EventArgs e)
        {
            if (FuncionarioEditar == 0)
            {

            }
            if (FuncionarioEditar == 1)
            {
                this.operacao = "Editar";
                panelFuncionario.Enabled = true;
                buttonVerifica.Enabled = true;
            }
        }

        private void buttonExcluirFuncionario_Click(object sender, EventArgs e)
        {
            if (FuncionarioExcluir == 0)
            {

            }
            if (FuncionarioExcluir == 1)
            {
                DialogResult d = MessageBox.Show("Deseja Excluir o registro?", "Aviso", MessageBoxButtons.YesNo);

                Conexao conexao = new Conexao(this.connetionString);
                DALDateSystem dal = new DALDateSystem(conexao);

                if (d.ToString() == "Yes")
                {
                    dal.ExcluirFuncionario(IdPessoa);

                    FecharTodosFormulario();
                }
            }
        }

        private void FormPesquisaFuncionarioEditar_Load(object sender, EventArgs e)
        {

        }
        public FormPesquisaFuncionarioEditar(int idPessoa,int FUNCIONARIOEDITAR, int FUNCIONARIOEXCLUIR,
            string NomeServidor, string NomeBaseDados, string NomeUsuario, string SenhaBaseDados)
        {
            InitializeComponent();

            this.NomeServidor = NomeServidor;
            this.NomeBaseDados = NomeBaseDados;
            this.NomeUsuario = NomeUsuario;
            this.SenhaBaseDados = SenhaBaseDados;

            this.connetionString = "Data Source=" + this.NomeServidor + ";Initial Catalog=" + this.NomeBaseDados + ";Persist Security Info=True;User ID=" + this.NomeUsuario + ";Password=" + this.SenhaBaseDados + ";";


            txtNomeFuncionario.MaxLength = 50;

            txtAbreviacaoFuncionario.MaxLength = 20;

            txtReFuncionario.MaxLength = 9;

            txtTipo_logradouroFuncionario.MaxLength = 25;

            txtEnderecoFuncionario.MaxLength = 40;

            txtBairroNumeroFuncionario.MaxLength = 9;

            txtComplFuncionario.MaxLength = 40;

            txtBairroFuncionario.MaxLength = 40;

            txtCidadeFuncionario.MaxLength = 40;

            txtSiglaCidadeFuncionario.MaxLength = 2;

            txtEmailFuncionario.MaxLength = 40;

            comboBoxSexoFuncionario.MaxLength = 2;

            txtRgFuncionario.MaxLength = 9;

            txtObservacaoFuncionario.MaxLength = 40;

            this.FuncionarioEditar = FUNCIONARIOEDITAR;
            this.FuncionarioExcluir = FUNCIONARIOEXCLUIR;

            if (FuncionarioEditar == 0)
            {
                buttonEditarFuncionario.Enabled = false;
            }
            if (FuncionarioEditar == 1)
            {
                buttonEditarFuncionario.Enabled = true;
            }
            if (FuncionarioExcluir == 0)
            {
                buttonExcluirFuncionario.Enabled = false;
            }
            if (FuncionarioExcluir == 1)
            {
                buttonExcluirFuncionario.Enabled = true;
            }


            //IdPessoa = Convert.ToInt32(dataGridViewPesquisaCliente["ID_PESSOA", e.RowIndex].Value);
            ////id = Convert.ToInt32(dataGridViewPesquisa.CurrentRow.Cells[0].Value.ToString());
            ////id = Convert.ToInt32(dataGridViewPesquisa.Rows[e.RowIndex].Cells["ORDEM_SERVIÇO"].Value.ToString());

            SqlConnection conn1 = new SqlConnection(this.connetionString);
            string sql1 = "exec ConsultaFuncionarioEditarTxt " + idPessoa;
            SqlDataAdapter sda1 = new SqlDataAdapter(sql1, conn1);
            DataSet ds1 = new DataSet();
            sda1.Fill(ds1);

            int status = 0;
            this.IdPessoa = idPessoa;
            status = int.Parse(ds1.Tables[0].Rows[0][2].ToString());

            txtReFuncionario.Text = ds1.Tables[0].Rows[0][1].ToString();
            txtNomeFuncionario.Text = ds1.Tables[0].Rows[0][3].ToString();
            txtAbreviacaoFuncionario.Text = ds1.Tables[0].Rows[0][4].ToString();
            txtTelefoneFuncionario.Text = ds1.Tables[0].Rows[0][5].ToString();
            txtTelefone2Funcionario.Text = ds1.Tables[0].Rows[0][6].ToString();
            txtCelularFuncionario.Text = ds1.Tables[0].Rows[0][7].ToString();
            txtCelular2Funcionario.Text = ds1.Tables[0].Rows[0][8].ToString();
            txtEmailFuncionario.Text = ds1.Tables[0].Rows[0][9].ToString();
            txtObservacaoFuncionario.Text = ds1.Tables[0].Rows[0][10].ToString();
            comboBoxSexoFuncionario.Text = ds1.Tables[0].Rows[0][11].ToString();
            txtCpfFuncionario.Text = ds1.Tables[0].Rows[0][12].ToString();
            txtRgFuncionario.Text = ds1.Tables[0].Rows[0][13].ToString();
            txtDataNascimentoFuncionario.Text = ds1.Tables[0].Rows[0][14].ToString();
            txtCepFuncionario.Text = ds1.Tables[0].Rows[0][15].ToString();
            txtTipo_logradouroFuncionario.Text = ds1.Tables[0].Rows[0][16].ToString();
            txtEnderecoFuncionario.Text = ds1.Tables[0].Rows[0][17].ToString();
            txtBairroNumeroFuncionario.Text = ds1.Tables[0].Rows[0][18].ToString();
            txtComplFuncionario.Text = ds1.Tables[0].Rows[0][19].ToString();
            txtBairroFuncionario.Text = ds1.Tables[0].Rows[0][20].ToString();
            txtCidadeFuncionario.Text = ds1.Tables[0].Rows[0][21].ToString();
            txtSiglaCidadeFuncionario.Text = ds1.Tables[0].Rows[0][22].ToString();

            if (status == 1)
            {
                checkBoxClienteSituacao.Checked = true;
            }
        }
        //private void buttonVerifica_Click(object sender, EventArgs e)
        //{

        //    if ((validaNome(txtNomeFuncionario, errorProviderFuncionario) == true) && (validaNumero(txtBairroFuncionario, errorProviderFuncionario) == true))
        //    {
        //        try
        //        {
        //            Conexao conexao = new Conexao(this.connetionString);
        //            DALCadastro dal = new DALCadastro(conexao); //cadastra Pessoa

        //            //Dados Pessoa
        //            Funcionario cadastra = new Funcionario();
        //            cadastra.IdFuncionario = IdPessoa;

        //            cadastra.Nome = txtNomeFuncionario.Text;
        //            cadastra.Abreviacao = txtAbreviacaoFuncionario.Text;
        //            cadastra.Telefone = txtTelefoneFuncionario.Text;
        //            cadastra.Telefone2 = txtTelefone2Funcionario.Text;
        //            cadastra.Celular = txtCelularFuncionario.Text;
        //            cadastra.Celular2 = txtCelular2Funcionario.Text;
        //            cadastra.Email = txtEmailFuncionario.Text;
        //            cadastra.Observacao = txtObservacaoFuncionario.Text;

        //            if (checkBoxClienteSituacao.Checked == true)
        //            {
        //                cadastra.Situacao = 1;
        //            }
        //            if (checkBoxClienteSituacao.Checked == false)
        //            {
        //                cadastra.Situacao = 2;
        //            }                            

        //            if (this.operacao == "Editar")
        //            {
        //                dal.AlterarFuncionario(cadastra);

        //                FecharTodosFormulario();

        //                MessageBox.Show("As alterações em Funcionarios foram realizadas!");
        //            }

        //        }
        //        catch (Exception ex)
        //        {
        //            MessageBox.Show("Erro de acesso ao banco de Dados-----------------------------------------------------------------------------------------------------------------------------------------. ", ex.Message);
        //        }
        //    }
        //}

        private void buttonCancelarFuncionario_Click(object sender, EventArgs e)
        {
            FecharTodosFormulario();
            FormPesquisaFuncionario Fornecedor = new FormPesquisaFuncionario(this.NomeServidor, this.NomeBaseDados, this.NomeUsuario, this.SenhaBaseDados);
            Fornecedor.MdiParent = FormPesquisaFuncionario.ActiveForm;
            Fornecedor.Show();
            Fornecedor.Top = 0;
            Fornecedor.Left = 0;
        }

        private void buttonFecharFuncionario_Click(object sender, EventArgs e)
        {
            FecharTodosFormulario();
        }
    }
}

