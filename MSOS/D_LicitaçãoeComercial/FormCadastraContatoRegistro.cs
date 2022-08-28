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
    public partial class FormCadastraContatoRegistro : Form
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
        private int CLASSEPRINCIPALCADASTRO = 0;
        public int ClassePrincipalCadastro
        {
            get
            {
                return this.CLASSEPRINCIPALCADASTRO;

            }
            set
            {
                this.CLASSEPRINCIPALCADASTRO = value;
            }
        }
        // VALIDAR ENTRADA COM ERROPROVIDER
        private Boolean validaAbreviacao(TextBox textBox, ErrorProvider errorProvider)
        {
            if (!String.IsNullOrWhiteSpace(txtAbreviacaoCContatos.Text))
            {
                errorProviderCadastraContatoRegistro.SetError(textBox, "");
                return true;
            }
            else
            {
                errorProviderCadastraContatoRegistro.SetError(textBox, "Abreviação Inválido!");
                return false;
            }
        }
        private Boolean validaCelular(TextBox textBox, ErrorProvider errorProvider)
        {
            if (!String.IsNullOrWhiteSpace(txtCelularCContatos.Text))
            {
                errorProviderCadastraContatoRegistro.SetError(textBox, "");
                return true;
            }
            else
            {
                errorProviderCadastraContatoRegistro.SetError(textBox, "Celular Inválido!");
                return false;
            }
        }
        private Boolean validaNome(TextBox textBox, ErrorProvider errorProvider)
        {
            if (!String.IsNullOrWhiteSpace(txtNomeCContatos.Text))
            {
                errorProviderCadastraContatoRegistro.SetError(textBox, "");
                return true;
            }
            else
            {
                errorProviderCadastraContatoRegistro.SetError(textBox, "Endereço Inválido!");
                return false;
            }
        }
        public FormCadastraContatoRegistro(string NomeServidor, string NomeBaseDados, string NomeUsuario, string SenhaBaseDados)
        {
            InitializeComponent();

            this.NomeServidor = NomeServidor;
            this.NomeBaseDados = NomeBaseDados;
            this.NomeUsuario = NomeUsuario;
            this.SenhaBaseDados = SenhaBaseDados;

            this.connetionString = "Data Source=" + this.NomeServidor + ";Initial Catalog=" + this.NomeBaseDados + ";Persist Security Info=True;User ID=" + this.NomeUsuario + ";Password=" + this.SenhaBaseDados + ";";

        }
        //
        public FormCadastraContatoRegistro(int IdPessoa, string CONNETIONSTRING)
        {
            InitializeComponent();

            this.connetionString = CONNETIONSTRING;

            this.idPessoa = IdPessoa;

            buttonCadastroCContatos.Enabled = false;

            panelFContatos.Enabled = true;

            buttonCancelarCContatos.Enabled = true;

            buttonFecharCContatos.Enabled = true;

            this.operacao = "inserir";

            this.ClassePrincipalCadastro = 1;

            SqlConnection conn = new SqlConnection(this.connetionString);

            SqlDataAdapter da = new SqlDataAdapter("EXEC D_R_ConsultaPessoaIdClienteRegistroTxt " + this.idPessoa + ",1; ", conn);//Arruma busca de cliente!
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
            if (op == 11)
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
        public FormCadastraContatoRegistro()
        {
            InitializeComponent();
        }

        private void FormCadastraContatoRegistro_Load(object sender, EventArgs e)
        {
            txtNomeCContatos.MaxLength = 50;

            txtAbreviacaoCContatos.MaxLength = 20;

            txtEmailCContatos.MaxLength = 60;

            txtObservacaoCContatos.MaxLength = 40;

            radioButtonOculto.Checked = true;
        }

        private void radioButtonTodos_CheckedChanged(object sender, EventArgs e)
        {
            txtPesquisaCCadastro1.Enabled = false;
            AlteraBotoes(10);
        }

        private void radioButtonCNome1_CheckedChanged(object sender, EventArgs e)
        {
            txtPesquisaCCadastro1.Enabled = true;

            AlteraBotoes(10);
        }

        private void buttonBuscaEmpresa_Click(object sender, EventArgs e)
        {
            ConsultaContatoClienteRegistro();
        }
        public void ConsultaContatoClienteRegistro()
        {
            SqlConnection conn = new SqlConnection(this.connetionString);

            if (radioButtonTodos.Checked)
            {
                //SELECIONA POR TODOS OS 
                SqlDataAdapter da1 = new SqlDataAdapter("EXEC D_R_ConsultaPessoaClienteRegistroTodos 1;", conn);
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
                label1.Text = "Cliente Contratos:" + dataGridViewPesquisa.RowCount.ToString();
                VALORPESQUISA = 1;
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
                    SqlDataAdapter da1 = new SqlDataAdapter("EXEC D_R_ConsultaPessoaClienteRegistroNomeTxt '" + txtPesquisaCCadastro1.Text + "',1;", conn);
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
                    label1.Text = "Cliente Contratos:" + dataGridViewPesquisa.RowCount.ToString();
                    VALORPESQUISA = 2;
                }
            }
            if ((radioButtonTodos.Checked == false) && (radioButtonCNome1.Checked == false))
            {
                MessageBox.Show("Selecione Todos ou Nome!");
            }
        }

        private void buttonVerifica_Click(object sender, EventArgs e)
        {
            SalvarContato();
        }
        public void SalvarContato()
        {
            Conexao conexao = new Conexao(this.connetionString);
            DALDateSystem da = new DALDateSystem(conexao);

            ClientesContatos cadastra = new ClientesContatos();


            if ((validaNome(txtNomeCContatos, errorProviderCadastraContatoRegistro) == true) && (validaAbreviacao(txtAbreviacaoCContatos, errorProviderCadastraContatoRegistro) == true)) //(labelConfirmacao.Text).Equals("sucesso - cep completo"))
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

                    SqlDataAdapter da2 = new SqlDataAdapter
                        ("SELECT PCS.ID_PESSOA_CONTATO AS ID_PESSOA_CONTATO,PCS.ID_PESSOA AS ID_PESSOA,P.NOME AS CLIENTE,"+
                        "PCS.NOME AS NOME_CONTATO,PCS.ABREVIACAO AS ABREVIACAO,PCS.TELEFONE AS TELEFONE,PCS.TELEFONE2 AS TELEFONE2,"+
                        "PCS.CELULAR AS CELULAR, PCS.CELULAR2 AS CELULAR2, PCS.EMAIL AS EMAIL, PCS.OBSERVACAO AS OBSERVACAO "+
                        "FROM P_Pessoa P LEFT JOIN P_Fisica PF ON P.ID_PESSOA = PF.ID_PESSOA_FISICA "+
                        "LEFT JOIN P_Juridica PJ ON P.ID_PESSOA = PJ.ID_PESSOA_JURIDICA INNER JOIN P_Registro PR ON PR.ID_PESSOA_REGISTRO = P.ID_PESSOA "+
                        "INNER JOIN P_Contatos PCS ON PCS.ID_PESSOA = P.ID_PESSOA WHERE P.ID_PESSOA = " + this.idPessoa +  " AND PCS.ABREVIACAO = '" + txtAbreviacaoCContatos.Text+"' "+
                        "AND P.ID_SITUACAO = 1 AND PCS.ID_SITUACAO = 1;", conn);

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

                            MessageBox.Show("Contato de Cliente Registro Cadastrado com Exito! ");

                            DialogResult dialogResult = MessageBox.Show("Deseja Adicionar novo contato Neste Registro de Cliente?", "Aviso", MessageBoxButtons.YesNo);
                            if (dialogResult == DialogResult.Yes)
                            {
                                FecharTodosFormulario();

                                FormCadastraContatoRegistro ClientesContatos1 = new FormCadastraContatoRegistro(this.idPessoa, this.connetionString);
                                ClientesContatos1.MdiParent = FormCadastraContatoRegistro.ActiveForm;
                                ClientesContatos1.Show();
                                ClientesContatos1.Top = 0;
                                ClientesContatos1.Left = 0;
                            }
                            else if (dialogResult == DialogResult.No)
                            {
                                if (ClassePrincipalCadastro == 0)
                                {
                                    FecharTodosFormulario();

                                    FormCadastraContatoRegistro ClientesContatos2 = new FormCadastraContatoRegistro
                                        (this.NomeServidor, this.NomeBaseDados, this.NomeUsuario, this.SenhaBaseDados);
                                    ClientesContatos2.MdiParent = FormCadastraContatoRegistro.ActiveForm;
                                    ClientesContatos2.Show();
                                    ClientesContatos2.Top = 0;
                                    ClientesContatos2.Left = 0;
                                }
                                if (ClassePrincipalCadastro == 1)
                                {
                                    FecharTodosFormulario();
                                }
                            }
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

                            MessageBox.Show("Contato de Contrato do Cliente Atualizado com Exito! ");

                            FecharTodosFormulario();

                            FormCadastraContatoRegistro ClientesContatos = new FormCadastraContatoRegistro(this.idPessoa, this.connetionString);
                            ClientesContatos.MdiParent = FormCadastraContatoRegistro.ActiveForm;
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

        private void buttonCancelarCContatos_Click(object sender, EventArgs e)
        {
            FecharTodosFormulario();
            FormCadastraContatoRegistro FCContatos = new FormCadastraContatoRegistro(this.NomeServidor, this.NomeBaseDados, this.NomeUsuario, this.SenhaBaseDados);
            FCContatos.MdiParent = FormCadastraContatoRegistro.ActiveForm;
            FCContatos.Show();
            FCContatos.Top = 0;
            FCContatos.Left = 0;
        }

        private void buttonFecharCContatos_Click(object sender, EventArgs e)
        {
            FecharTodosFormulario();
            FormCadastraContatoRegistro FCContatos = new FormCadastraContatoRegistro(this.NomeServidor, this.NomeBaseDados, this.NomeUsuario, this.SenhaBaseDados);
            FCContatos.MdiParent = FormCadastraContatoRegistro.ActiveForm;
            FCContatos.Show();
            FCContatos.Top = 0;
            FCContatos.Left = 0;
        }

        private void buttonCadastroCContatos_Click(object sender, EventArgs e)
        {
            panelPesquisaEmpresa.Enabled = true;
            radioButtonCNome1.Enabled = true;
            radioButtonTodos.Enabled = true;
            //radioButtonMS1.Enabled = true;
            buttonBuscaEmpresa.Enabled = true;
            dataGridViewPesquisa.Enabled = true;

            this.operacao = "inserir";

            buttonCadastroCContatos.Enabled = false;
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
                    SqlDataAdapter da1 = new SqlDataAdapter("EXEC D_R_ConsultaClienteRegistroEditarTxt " + idPessoa + ";", conn);
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
                                buttonVerifica.Enabled = true;

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
                        MessageBox.Show("O cliente de Contratos não consta no sistema!");

                        AlteraBotoes(10);
                    }
                }
                catch (Exception ex)
                {
                    ex.ToString();
                }
            }
        }

        private void FormCadastraContatoRegistro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
            {
                this.Close();
            }
        }
        public static void CancelaCadastradoContatoPropostaContratos(Type frmType)
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
            CancelaCadastradoContatoPropostaContratos(typeof(FormCadastraContatoRegistro));
        }
        void dataGridViewPesquisaCliente()
        {
            SqlConnection connection = new SqlConnection(this.connetionString);
            SqlCommand command = new SqlCommand("EXEC D_R_ConsultaPessoaClienteRegistroNomeTxt '" + txtPesquisaCCadastro1.Text + "',1;", connection);
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

        private void txtPesquisaCCadastro1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                ConsultaContatoClienteRegistro();
            }
        }
    }
}
