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
    public partial class FormPesquisaFuncionario : Form
    {

        DataTable TableTodos;
        DataTable TableRe;
        DataTable TableNome;

        private int ID_PESSOA = 0;
        public int IdPessoa
        {
            get
            {
                return this.ID_PESSOA;

            }
            set
            {
                this.ID_PESSOA = value;
            }
        }
        private int FUNCIONARIOPESQUISA = 0;
        public int FuncionarioPesquisa
        {
            get
            {
                return this.FUNCIONARIOPESQUISA;

            }
            set
            {
                this.FUNCIONARIOPESQUISA = value;
            }
        }
        private int FUNCIONARIOVISUALIZAR = 0;
        public int FuncionarioVisualizar
        {
            get
            {
                return this.FUNCIONARIOVISUALIZAR;

            }
            set
            {
                this.FUNCIONARIOVISUALIZAR = value;
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



        public FormPesquisaFuncionario(int FUNCIONARIOVISUALIZAR,int FUNCIONARIOEDITAR,int FUNCIONARIOEXCLUIR,
            string NomeServidor, string NomeBaseDados, string NomeUsuario, string SenhaBaseDados)
        {
            InitializeComponent();

            this.FuncionarioVisualizar = FUNCIONARIOVISUALIZAR;
            this.FuncionarioEditar = FUNCIONARIOEDITAR;
            this.FuncionarioExcluir = FUNCIONARIOEXCLUIR;

            this.NomeServidor = NomeServidor;
            this.NomeBaseDados = NomeBaseDados;
            this.NomeUsuario = NomeUsuario;
            this.SenhaBaseDados = SenhaBaseDados;

            this.connetionString = "Data Source=" + this.NomeServidor + ";Initial Catalog=" + this.NomeBaseDados + ";Persist Security Info=True;User ID=" + this.NomeUsuario + ";Password=" + this.SenhaBaseDados + ";";


        }
        public FormPesquisaFuncionario(string NomeServidor, string NomeBaseDados, string NomeUsuario, string SenhaBaseDados)
        {
            InitializeComponent();

            this.FuncionarioVisualizar = FUNCIONARIOVISUALIZAR;
            this.FuncionarioEditar = FUNCIONARIOEDITAR;
            this.FuncionarioExcluir = FUNCIONARIOEXCLUIR;

            this.NomeServidor = NomeServidor;
            this.NomeBaseDados = NomeBaseDados;
            this.NomeUsuario = NomeUsuario;
            this.SenhaBaseDados = SenhaBaseDados;

            this.connetionString = "Data Source=" + this.NomeServidor + ";Initial Catalog=" + this.NomeBaseDados + ";Persist Security Info=True;User ID=" + this.NomeUsuario + ";Password=" + this.SenhaBaseDados + ";";


        }
        private void FormPesquisaFornecedor_Load(object sender, EventArgs e)
        {

        }
        //METODO PARA VERIFICA SE O FORMULÁRIO ESTA ABERTO SE TIVER ELE FECHA!
        public static void CancelaCadastradoCliente(Type frmType)
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
            CancelaCadastradoCliente(typeof(FormPesquisaFuncionario));
        }

        private void buttonFecharOs_Click(object sender, EventArgs e)
        {
            FecharTodosFormulario();
        }
        void dataGridViewPesquisaTodos()
        {
            int situacao = 0;

            if (checkBoxSituacao.Checked == true)
            {
                situacao = 1;
            }
            if (checkBoxSituacao.Checked == false)
            {
                situacao = 2;
            }
            SqlConnection connection = new SqlConnection(this.connetionString);
            SqlCommand command = new SqlCommand("Exec ConsultaFuncionarioTodosTxt " + situacao + ";", connection);
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
        }
        void dataGridViewPesquisaRe()
        {
            int situacao = 0;

            if (checkBoxSituacao.Checked == true)
            {
                situacao = 1;
            }
            if (checkBoxSituacao.Checked == false)
            {
                situacao = 2;
            }
            SqlConnection connection = new SqlConnection(this.connetionString);
            SqlCommand command = new SqlCommand("Exec ConsultaFuncionarioReTxt '" + txtPesquisaRe.Text + "'," + situacao + ";", connection);
            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = command;
                TableRe = new DataTable();
                adapter.Fill(TableRe);
                BindingSource Source = new BindingSource();
                Source.DataSource = TableRe;
                dataGridViewPesquisa.DataSource = Source;
                adapter.Update(TableRe);
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
        }
        void dataGridViewPesquisaNome()
        {
            int situacao = 0;

            if (checkBoxSituacao.Checked == true)
            {
                situacao = 1;
            }
            if (checkBoxSituacao.Checked == false)
            {
                situacao = 2;
            }
            SqlConnection connection = new SqlConnection(this.connetionString);
            SqlCommand command = new SqlCommand("Exec ConsultaFuncionarioNomeTxt '" + txtPesquisaFuncionario.Text + "'," + situacao + ";", connection);
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
        }

        private void buttonPesquisa_Click(object sender, EventArgs e)
        {
            radioButtonTodos.Enabled = true;
            radioButtonRazaoSocial1.Enabled = true;
            radioButtonPesquisaFuncionario.Enabled = true;
        }

        private void dataGridViewPesquisa_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // FecharCadastroCliente();

            if (dataGridViewPesquisa.RowCount == 0)
            {
                IdPessoa = 0;
            }
            if (!(dataGridViewPesquisa.RowCount == 0))
            {
                try
                {
                    IdPessoa = Convert.ToInt32(dataGridViewPesquisa["ID_FUNCIONARIO", e.RowIndex].Value);
                    FormPesquisaFornecedorEditar ClientePesquisaE = new FormPesquisaFornecedorEditar(IdPessoa, this.FuncionarioEditar,  this.FuncionarioExcluir,
                        this.NomeServidor, this.NomeBaseDados, this.NomeUsuario, this.SenhaBaseDados);
                    ClientePesquisaE.MdiParent = FormPesquisaFornecedorEditar.ActiveForm;
                    ClientePesquisaE.Show();
                    ClientePesquisaE.Top = 0;
                    ClientePesquisaE.Left = 0;
                }
                catch (Exception ex)
                {
                    ex.ToString();
                }
            }
        }

        private void buttonFuncionarioPesquisa_Click(object sender, EventArgs e)
        {
            int situacao = 0;

            if (checkBoxSituacao.Checked == true)
            {
                situacao = 1;
            }
            if (checkBoxSituacao.Checked == false)
            {
                situacao = 2;
            }
            SqlConnection conn = new SqlConnection(this.connetionString);

            if (!(radioButtonTodos.Checked == true) && !(radioButtonRE.Checked == true) && !(radioButtonPesquisaFuncionario.Checked == true))
            {
                MessageBox.Show("Seleciona um modo de busca, por Todos, RE ou Nome do Funcionario! ");
            }
            if (radioButtonTodos.Checked)
            {

                // dataGridViewPesquisaCliente.Columns.Clear();
                dataGridViewPesquisa.Refresh();

                label8.Text = dataGridViewPesquisa.RowCount.ToString();


                //SELECIONA POR TODOS OS 
                SqlDataAdapter da1 = new SqlDataAdapter("EXEC ConsultaFuncionarioTodosTxt " + situacao, conn);
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
                        // dataGridViewPesquisaCliente.Columns.Clear();
                        dataGridViewPesquisa.Refresh();
                    }
                    label8.Text = dataGridViewPesquisa.RowCount.ToString();

                    MessageBox.Show("Nem um Registro do Funcionario achado!");
                    conn.Close();
                }
                if (ds1.Tables[0].Rows.Count > 0)
                {
                    conn.Close();

                    dataGridViewPesquisaTodos();
                    label8.Text = dataGridViewPesquisa.RowCount.ToString();
                }

            }
            if (radioButtonRE.Checked)
            {
                if (txtPesquisaRe.Text == "")
                {
                    //dataGridViewPesquisaCliente.Columns.Clear();
                    dataGridViewPesquisa.Refresh();

                    label8.Text = dataGridViewPesquisa.RowCount.ToString();

                    MessageBox.Show("O RE não pode esta em Branco!");
                }
                if (!(txtPesquisaRe.Text == ""))
                {
                    //SELECIONA POR TODOS OS 
                    SqlDataAdapter da1 = new SqlDataAdapter("EXEC ConsultaFuncionarioReTxt '" + txtPesquisaRe.Text + "'," + situacao + ";", conn);
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
                            //dataGridViewPesquisaCliente.Columns.Clear();
                            dataGridViewPesquisa.Refresh();
                        }
                        label8.Text = dataGridViewPesquisa.RowCount.ToString();

                        MessageBox.Show("Nem um Registro do RE Achado!");
                        conn.Close();
                    }
                    if (ds1.Tables[0].Rows.Count > 0)
                    {
                        conn.Close();

                        dataGridViewPesquisaRe();
                        label8.Text = dataGridViewPesquisa.RowCount.ToString();
                    }
                }
            }
            if (radioButtonPesquisaFuncionario.Checked)
            {
                if (txtPesquisaFuncionario.Text == "")
                {
                    //dataGridViewPesquisaCliente.Columns.Clear();
                    dataGridViewPesquisa.Refresh();

                    label8.Text = dataGridViewPesquisa.RowCount.ToString();

                    MessageBox.Show("O Funcionario não pode esta em Branco!");
                }
                if (!(txtPesquisaFuncionario.Text == ""))
                {
                    //SELECIONA POR TODOS OS 
                    SqlDataAdapter da1 = new SqlDataAdapter("EXEC ConsultaFuncionarioNomeTxt '" + txtPesquisaFuncionario.Text + "'," + situacao + ";", conn);
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
                            // dataGridViewPesquisaCliente.Columns.Clear();
                            dataGridViewPesquisa.Refresh();
                        }
                        label8.Text = dataGridViewPesquisa.RowCount.ToString();

                        MessageBox.Show("Nem um Registro do Re Achado!");
                        conn.Close();
                    }
                    if (ds1.Tables[0].Rows.Count > 0)
                    {
                        conn.Close();

                        dataGridViewPesquisaNome();
                        label8.Text = dataGridViewPesquisa.RowCount.ToString();
                    }
                }
            }
        }

        private void FormPesquisaFuncionario_Load(object sender, EventArgs e)
        {

        }

        private void txtPesquisaFuncionario_TextChanged(object sender, EventArgs e)
        {
            DataView DV = new DataView(TableNome);
            DV.RowFilter = string.Format("NOME LIKE '%{0}%'", txtPesquisaFuncionario.Text);
            dataGridViewPesquisa.DataSource = DV;
            label8.Text = dataGridViewPesquisa.RowCount.ToString();
        }

        private void txtPesquisaRe_TextChanged(object sender, EventArgs e)
        {
            DataView DV = new DataView(TableRe);
            DV.RowFilter = string.Format("ID_RE LIKE '%{0}%'", txtPesquisaRe.Text);
            dataGridViewPesquisa.DataSource = DV;
            label8.Text = dataGridViewPesquisa.RowCount.ToString();
        }

        private void radioButtonTodos_CheckedChanged_1(object sender, EventArgs e)
        {
            txtPesquisaFuncionario.Enabled = false;
            txtPesquisaFuncionario.Clear();

            txtPesquisaRe.Enabled = false;
            txtPesquisaRe.Clear();
        }

        private void radioButtonPesquisaFuncionario_CheckedChanged(object sender, EventArgs e)
        {
            txtPesquisaFuncionario.Enabled = true;
            txtPesquisaFuncionario.Clear();

            txtPesquisaRe.Enabled = false;
            txtPesquisaRe.Clear();
        }

        private void radioButtonRE_CheckedChanged(object sender, EventArgs e)
        {
            txtPesquisaFuncionario.Enabled = false;
            txtPesquisaFuncionario.Clear();

            txtPesquisaRe.Enabled = true;
            txtPesquisaRe.Clear();
        }

        private void buttonCancelarOs_Click_1(object sender, EventArgs e)
        {
            FecharTodosFormulario();

            FormPesquisaFuncionario cadastraFornecedor = new FormPesquisaFuncionario(this.NomeServidor, this.NomeBaseDados, this.NomeUsuario, this.SenhaBaseDados);
            cadastraFornecedor.MdiParent = FormPesquisaFuncionario.ActiveForm;
            cadastraFornecedor.Show();
            cadastraFornecedor.Top = 0;
            cadastraFornecedor.Left = 0;
        }

        private void buttonFecharOs_Click_1(object sender, EventArgs e)
        {
            FecharTodosFormulario();
        }

        private void dataGridViewPesquisa_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            // FecharCadastroCliente();

            if (dataGridViewPesquisa.RowCount == 0)
            {
                IdPessoa = 0;
            }
            if (FuncionarioVisualizar == 0 )
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
            if (FuncionarioVisualizar == 1)
            {
                try
                {
                    IdPessoa = Convert.ToInt32(dataGridViewPesquisa["ID_FUNCIONARIO", e.RowIndex].Value);
                    FormPesquisaFuncionarioEditar ClientePesquisaE = new FormPesquisaFuncionarioEditar(IdPessoa, this.FuncionarioEditar,this.FuncionarioExcluir,
                        this.NomeServidor, this.NomeBaseDados, this.NomeUsuario, this.SenhaBaseDados);
                    ClientePesquisaE.MdiParent = FormPesquisaFuncionarioEditar.ActiveForm;
                    ClientePesquisaE.Show();
                    ClientePesquisaE.Top = 0;
                    ClientePesquisaE.Left = 0;
                }
                catch (Exception ex)
                {
                    ex.ToString();
                }
            }
        }
    }
}

