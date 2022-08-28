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
    public partial class FormPesquisaFornecedor : Form
    {

        DataTable TableTodos;
        DataTable TableRazaoSocial;
        DataTable TableNome;

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
        private int ID_PESSOAF = 0;
        public int IdPessoaF
        {
            get
            {
                return this.ID_PESSOAF;

            }
            set
            {
                this.ID_PESSOAF = value;
            }
        }
        private int FORNECEDORVISUALIZAR = 0;
        public int FornecedorVisualizar
        {
            get
            {
                return this.FORNECEDORVISUALIZAR;

            }
            set
            {
                this.FORNECEDORVISUALIZAR = value;
            }
        }
        private int FORNECEDOREDITAR = 0;
        public int FornecedorEditar
        {
            get
            {
                return this.FORNECEDOREDITAR;

            }
            set
            {
                this.FORNECEDOREDITAR = value;
            }
        }
        private int FORNECEDOREXCLUIR = 0;
        public int FornecedorExcluir
        {
            get
            {
                return this.FORNECEDOREXCLUIR;

            }
            set
            {
                this.FORNECEDOREXCLUIR = value;
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


        public FormPesquisaFornecedor(int FORNECEDORVISUALIZAR, int FORNECEDOREDITAR,int FORNECEDOREXCLUIR, string NomeServidor, string NomeBaseDados, string NomeUsuario, string SenhaBaseDados)
        {
            InitializeComponent();
            this.FornecedorVisualizar = FORNECEDORVISUALIZAR;
            this.FornecedorEditar = FORNECEDOREDITAR;
            this.FornecedorExcluir = FORNECEDOREXCLUIR;

            this.NomeServidor = NomeServidor;
            this.NomeBaseDados = NomeBaseDados;
            this.NomeUsuario = NomeUsuario;
            this.SenhaBaseDados = SenhaBaseDados;

            this.connetionString = "Data Source=" + this.NomeServidor + ";Initial Catalog=" + this.NomeBaseDados + ";Persist Security Info=True;User ID=" + this.NomeUsuario + ";Password=" + this.SenhaBaseDados + ";";

        }
        public void PesquisaFornecedor()
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

            if (!(radioButtonTodos.Checked == true) && !(radioButtonRazaoSocial.Checked == true) && !(radioButtonPesquisaCliente.Checked == true))
            {
                MessageBox.Show("Seleciona um modo de busca, por Todos, Razão Social ou Nome do Cliente! ");
            }
            if (radioButtonTodos.Checked)
            {

                // dataGridViewPesquisaCliente.Columns.Clear();
                dataGridViewPesquisa.Refresh();

                label8.Text = dataGridViewPesquisa.RowCount.ToString();


                //SELECIONA POR TODOS OS 
                SqlDataAdapter da1 = new SqlDataAdapter("EXEC D_ConsultaPessoaFornecedorTodos " + situacao, conn);
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

                    MessageBox.Show("Nem um Registro de Fornecedor Achado!");
                    conn.Close();
                }
                if (ds1.Tables[0].Rows.Count > 0)
                {
                    conn.Close();

                    dataGridViewPesquisaTodos();
                    ValorPesquisa = 0;
                    label8.Text = dataGridViewPesquisa.RowCount.ToString();
                }

            }
            if (radioButtonRazaoSocial.Checked)
            {
                if (txtPesquisaRazaoSocialFornecedor.Text == "")
                {
                    //dataGridViewPesquisaCliente.Columns.Clear();
                    dataGridViewPesquisa.Refresh();

                    label8.Text = dataGridViewPesquisa.RowCount.ToString();

                    MessageBox.Show("A Razão Social não pode esta em Branco!");
                }
                if (!(txtPesquisaRazaoSocialFornecedor.Text == ""))
                {
                    //SELECIONA POR TODOS OS 
                    SqlDataAdapter da1 = new SqlDataAdapter("EXEC D_ConsultaPessoaFornecedorRazaoSocialTxt '" + txtPesquisaRazaoSocialFornecedor.Text + "'," + situacao + ";", conn);
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

                        MessageBox.Show("Nem um Registro de Fornecedor Achado!");
                        conn.Close();
                    }
                    if (ds1.Tables[0].Rows.Count > 0)
                    {
                        conn.Close();

                        dataGridViewPesquisaRazaoSocial();
                        ValorPesquisa = 1;
                        label8.Text = dataGridViewPesquisa.RowCount.ToString();
                    }
                }
            }
            if (radioButtonPesquisaCliente.Checked)
            {
                if (txtPesquisaClienteFornecedor.Text == "")
                {
                    //dataGridViewPesquisaCliente.Columns.Clear();
                    dataGridViewPesquisa.Refresh();

                    label8.Text = dataGridViewPesquisa.RowCount.ToString();

                    MessageBox.Show("O Cliente não pode esta em Branco!");
                }
                if (!(txtPesquisaClienteFornecedor.Text == ""))
                {
                    //SELECIONA POR TODOS OS 
                    SqlDataAdapter da1 = new SqlDataAdapter("EXEC D_ConsultaPessoaFornecedorClienteTxt '" + txtPesquisaClienteFornecedor.Text + "'," + situacao + ";", conn);
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

                        MessageBox.Show("Nem um Registro de nome Achado!");
                        conn.Close();
                    }
                    if (ds1.Tables[0].Rows.Count > 0)
                    {
                        conn.Close();

                        dataGridViewPesquisaNome();
                        ValorPesquisa = 2;
                        label8.Text = dataGridViewPesquisa.RowCount.ToString();
                    }
                }
            }
        }
        private void buttonFornecedorPesquisa_Click(object sender, EventArgs e)
        {
            PesquisaFornecedor();
        }

        private void buttonCancelarOs_Click(object sender, EventArgs e)
        {
            FecharTodosFormulario();

            FormPesquisaFornecedor cadastraFornecedor = new FormPesquisaFornecedor(this.FornecedorVisualizar, this.FornecedorEditar, this.FornecedorExcluir, 
                this.NomeServidor, this.NomeBaseDados, this.NomeUsuario, this.SenhaBaseDados);
            cadastraFornecedor.MdiParent = FormOSPesquisa.ActiveForm;
            cadastraFornecedor.Show();
            cadastraFornecedor.Top = 0;
            cadastraFornecedor.Left = 0;
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
            CancelaCadastradoCliente(typeof(FormPesquisaFornecedor));
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
            SqlCommand command = new SqlCommand("Exec D_ConsultaPessoaFornecedorTodos " + situacao + ";", connection);
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
        void dataGridViewPesquisaRazaoSocial()
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
            SqlCommand command = new SqlCommand("Exec D_ConsultaPessoaFornecedorRazaoSocialTxt '" + txtPesquisaRazaoSocialFornecedor.Text + "'," + situacao + ";", connection);
            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = command;
                TableRazaoSocial = new DataTable();
                adapter.Fill(TableRazaoSocial);
                BindingSource Source = new BindingSource();
                Source.DataSource = TableRazaoSocial;
                dataGridViewPesquisa.DataSource = Source;
                adapter.Update(TableRazaoSocial);
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
            SqlCommand command = new SqlCommand("Exec D_ConsultaPessoaFornecedorClienteTxt '" + txtPesquisaClienteFornecedor.Text + "'," + situacao + ";", connection);
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
            radioButtonPesquisaCliente.Enabled = true;
        }

        private void radioButtonTodos_CheckedChanged(object sender, EventArgs e)
        {
            txtPesquisaClienteFornecedor.Enabled=false;
            txtPesquisaClienteFornecedor.Clear();

            txtPesquisaRazaoSocialFornecedor.Enabled = false;
            txtPesquisaRazaoSocialFornecedor.Clear();
        }

        private void radioButtonRazaoSocial_CheckedChanged(object sender, EventArgs e)
        {
            txtPesquisaClienteFornecedor.Enabled = false;
            txtPesquisaClienteFornecedor.Clear();

            txtPesquisaRazaoSocialFornecedor.Enabled = true;
            txtPesquisaRazaoSocialFornecedor.Clear();
        }

        private void radioButtonPesquisaCliente_CheckedChanged(object sender, EventArgs e)
        {
            txtPesquisaClienteFornecedor.Enabled = true;
            txtPesquisaClienteFornecedor.Clear();

            txtPesquisaRazaoSocialFornecedor.Enabled = false;
            txtPesquisaRazaoSocialFornecedor.Clear();
        }

        private void txtPesquisaRazaoSocialFornecedor_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (ValorPesquisa == 1)
                {
                    DataView DV = new DataView(TableRazaoSocial);
                    DV.RowFilter = string.Format("RAZAO_SOCIAL LIKE '%{0}%'", txtPesquisaRazaoSocialFornecedor.Text);
                    dataGridViewPesquisa.DataSource = DV;
                    label8.Text = dataGridViewPesquisa.RowCount.ToString();
                }
            }
            catch
            {

            }

        }

        private void txtPesquisaClienteFornecedor_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (ValorPesquisa == 2)
                {
                    DataView DV = new DataView(TableNome);
                    DV.RowFilter = string.Format("CLIENTE LIKE '%{0}%'", txtPesquisaClienteFornecedor.Text);
                    dataGridViewPesquisa.DataSource = DV;
                    label8.Text = dataGridViewPesquisa.RowCount.ToString();
                }
            }
            catch
            {

            }

        }

        private void dataGridViewPesquisa_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // FecharCadastroCliente();

            if (dataGridViewPesquisa.RowCount == 0)
            {
                IdPessoaF = 0;
            }
            if (!(dataGridViewPesquisa.RowCount == 0)&&(FornecedorVisualizar == 0))
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
            if (!(dataGridViewPesquisa.RowCount == 0) && (FornecedorVisualizar == 1))
            {
                try
                {
                    IdPessoaF = Convert.ToInt32(dataGridViewPesquisa["ID_PESSOA", e.RowIndex].Value);
                    FormPesquisaFornecedorEditar ClientePesquisaE = new FormPesquisaFornecedorEditar(IdPessoaF, this.FornecedorEditar, this.FornecedorExcluir,
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

        private void txtPesquisaRazaoSocialFornecedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                PesquisaFornecedor();
            }
        }

        private void txtPesquisaClienteFornecedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                PesquisaFornecedor();
            }
        }

        private void FormPesquisaFornecedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
            {
                this.Close();
            }
        }
    }
}
