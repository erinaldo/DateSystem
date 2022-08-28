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
    public partial class FormPesquisaClientesRegistroContatos : Form
    {
        DataTable TableNome;
        DataTable TableAbreviacao;
        DataTable TableFornecedor;
        DataTable TableTodos;

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
        private int ID_PESSOA_CONTATO2 = 0;
        public int IdPessoaContato
        {
            get
            {
                return this.ID_PESSOA_CONTATO2;

            }
            set
            {
                this.ID_PESSOA_CONTATO2 = value;
            }
        }
        private int ID_PESSOA_TIPO = 0;
        public int IdPessoaTipo
        {
            get
            {
                return this.ID_PESSOA_TIPO;

            }
            set
            {
                this.ID_PESSOA_TIPO = value;
            }
        }
        private int CLIENTEVICSUALIZAR = 0;
        public int ClienteCVisualizar
        {
            get
            {
                return this.CLIENTEVICSUALIZAR;

            }
            set
            {
                this.CLIENTEVICSUALIZAR = value;
            }
        }
        private int CLIENTECEDITAR = 0;
        public int ClienteCEditar
        {
            get
            {
                return this.CLIENTECEDITAR;

            }
            set
            {
                this.CLIENTECEDITAR = value;
            }
        }
        private int CLIENTECEXCLUIR = 0;
        public int ClienteCExcluir
        {
            get
            {
                return this.CLIENTECEXCLUIR;

            }
            set
            {
                this.CLIENTECEXCLUIR = value;
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


        private void FormPesquisaClientes_Load(object sender, EventArgs e)
        {

        }
        //METODO PARA VERIFICA SE O FORMULÁRIO ESTA ABERTO SE TIVER ELE FECHA!
        public static void CancelaPesquisaCliente(Type frmType)
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
            CancelaPesquisaCliente(typeof(FormPesquisaClientesRegistroContatos));

        }
        public void FecharCadastroCliente()
        {
            CancelaPesquisaCliente(typeof(FormPesquisaClientesRegistroContatos));
        }

        //public FormPesquisaClientesContatos(string NomeServidor, string NomeBaseDados, string NomeUsuario, string SenhaBaseDados)
        //{
        //    InitializeComponent();

        //    this.NomeServidor = NomeServidor;
        //    this.NomeBaseDados = NomeBaseDados;
        //    this.NomeUsuario = NomeUsuario;
        //    this.SenhaBaseDados = SenhaBaseDados;

        //    this.connetionString = "Data Source=" + this.NomeServidor + ";Initial Catalog=" + this.NomeBaseDados + ";Persist Security Info=True;User ID=" + this.NomeUsuario + ";Password=" + this.SenhaBaseDados + ";";
        //}
        public FormPesquisaClientesRegistroContatos(int CLIENTECVISUALIZAR, int CLIENTECEDITAR, int CLIENTECEXCLUIR, string NomeServidor, string NomeBaseDados, string NomeUsuario, string SenhaBaseDados)
        {
            InitializeComponent();

            radioButtonOculto.Checked = true;

            this.NomeServidor = NomeServidor;
            this.NomeBaseDados = NomeBaseDados;
            this.NomeUsuario = NomeUsuario;
            this.SenhaBaseDados = SenhaBaseDados;
            this.ClienteCVisualizar = CLIENTECVISUALIZAR;
            this.ClienteCEditar = CLIENTECEDITAR;
            this.ClienteCExcluir = CLIENTECEXCLUIR;

            this.connetionString = "Data Source=" + this.NomeServidor + ";Initial Catalog=" + this.NomeBaseDados + ";Persist Security Info=True;User ID=" + this.NomeUsuario + ";Password=" + this.SenhaBaseDados + ";";
        }
        public FormPesquisaClientesRegistroContatos()
        {
            InitializeComponent();
        }

        private void FormPesquisaClientesRegistroContatos_Load(object sender, EventArgs e)
        {

        }
        void dataGridViewPesquisaTodos()
        {
            int situacaoF = 0;
            int situacaoC = 0;

            if (checkBoxFornecedor.Checked == true)
            {
                situacaoF = 1;
            }
            if (checkBoxFornecedor.Checked == false)
            {
                situacaoF = 2;
            }

            if (checkBoxSituacao.Checked == true)
            {
                situacaoC = 1;
            }
            if (checkBoxSituacao.Checked == false)
            {
                situacaoC = 2;
            }

            SqlConnection connection = new SqlConnection(this.connetionString);
            SqlCommand command = new SqlCommand("Exec D_R_ConsultaClienteRegistroContatoTodosTxt " + situacaoF + "," + situacaoC + ";", connection);
            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = command;
                TableTodos = new DataTable();
                adapter.Fill(TableTodos);
                BindingSource Source = new BindingSource();
                Source.DataSource = TableTodos;
                dataGridViewPesquisaClienteContatos.DataSource = Source;
                adapter.Update(TableTodos);
            }
            catch (Exception ex)
            {
                ex.ToString();
            }

            //DataTable dt = new DataTable();
        }
        void dataGridViewPesquisaNome()
        {
            int situacaoF = 0;
            int situacaoC = 0;

            if (checkBoxFornecedor.Checked == true)
            {
                situacaoF = 1;
            }
            if (checkBoxFornecedor.Checked == false)
            {
                situacaoF = 2;
            }

            if (checkBoxSituacao.Checked == true)
            {
                situacaoC = 1;
            }
            if (checkBoxSituacao.Checked == false)
            {
                situacaoC = 2;
            }
            SqlConnection connection = new SqlConnection(this.connetionString);
            SqlCommand command = new SqlCommand("Exec D_R_ConsultaClienteRegistroContatoNomeTxt '" + txtPesquisaNomeContatos.Text + "'," + situacaoF + "," + situacaoC + ";", connection);
            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = command;
                TableNome = new DataTable();
                adapter.Fill(TableNome);
                BindingSource Source = new BindingSource();
                Source.DataSource = TableNome;
                dataGridViewPesquisaClienteContatos.DataSource = Source;
                adapter.Update(TableNome);
            }
            catch (Exception ex)
            {
                ex.ToString();
            }

            //DataTable dt = new DataTable();
        }
        void dataGridViewPesquisaAbreviacao()
        {
            int situacaoF = 0;
            int situacaoC = 0;

            if (checkBoxFornecedor.Checked == true)
            {
                situacaoF = 1;
            }
            if (checkBoxFornecedor.Checked == false)
            {
                situacaoF = 2;
            }

            if (checkBoxSituacao.Checked == true)
            {
                situacaoC = 1;
            }
            if (checkBoxSituacao.Checked == false)
            {
                situacaoC = 2;
            }
            SqlConnection connection = new SqlConnection(this.connetionString);
            SqlCommand command = new SqlCommand("Exec D_R_ConsultaClienteRegistroContatoAbreviacaoTxt '" + txtPesquisaAbreviacaoContatos.Text + "'," + situacaoF + "," + situacaoC + ";", connection);
            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = command;
                TableAbreviacao = new DataTable();
                adapter.Fill(TableAbreviacao);
                BindingSource Source = new BindingSource();
                Source.DataSource = TableAbreviacao;
                dataGridViewPesquisaClienteContatos.DataSource = Source;
                adapter.Update(TableAbreviacao);

            }
            catch (Exception ex)
            {
                ex.ToString();
            }

            //DataTable dt = new DataTable();
        }
        void dataGridViewPesquisaFornecedor()
        {
            int situacaoF = 0;
            int situacaoC = 0;

            if (checkBoxFornecedor.Checked == true)
            {
                situacaoF = 1;
            }
            if (checkBoxFornecedor.Checked == false)
            {
                situacaoF = 2;
            }

            if (checkBoxSituacao.Checked == true)
            {
                situacaoC = 1;
            }
            if (checkBoxSituacao.Checked == false)
            {
                situacaoC = 2;
            }
            SqlConnection connection = new SqlConnection(this.connetionString);
            SqlCommand command = new SqlCommand("Exec D_R_ConsultaClienteRegistroContatoFornecedorTxt '" + txtPesquisaFornecedorContatos.Text + "'," + situacaoF + "," + situacaoC + ";", connection);
            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = command;
                TableFornecedor = new DataTable();
                adapter.Fill(TableFornecedor);
                BindingSource Source = new BindingSource();
                Source.DataSource = TableFornecedor;
                dataGridViewPesquisaClienteContatos.DataSource = Source;
                adapter.Update(TableFornecedor);

            }
            catch (Exception ex)
            {
                ex.ToString();
            }

            //DataTable dt = new DataTable();
        }

        private void buttonPesquisaCliente_Click(object sender, EventArgs e)
        {
            PesquisaContatosRegistro();
        }
        public void PesquisaContatosRegistro()
        {
            int situacaoF = 0;
            int situacaoC = 0;

            if (checkBoxFornecedor.Checked == true)
            {
                situacaoF = 1;
            }
            if (checkBoxFornecedor.Checked == false)
            {
                situacaoF = 2;
            }

            if (checkBoxSituacao.Checked == true)
            {
                situacaoC = 1;
            }
            if (checkBoxSituacao.Checked == false)
            {
                situacaoC = 2;
            }
            SqlConnection conn = new SqlConnection(this.connetionString);

            if (!(radioButtonPesquisarAbreviacao.Checked == true) && !(radioButtonPesquisarNome.Checked == true) && !(radioButtonTodos.Checked == true) && !(radioButtonFornecedor.Checked == true))
            {
                MessageBox.Show("Seleciona um modo de busca, por Todos, Nome, Abreviação ou Fornecedor! ");
            }
            if (radioButtonTodos.Checked)
            {
                conn.ToString();
                connetionString.ToString();
                // dataGridViewPesquisaCliente.Columns.Clear();
                dataGridViewPesquisaClienteContatos.Refresh();

                label8.Text = dataGridViewPesquisaClienteContatos.RowCount.ToString();

                //SELECIONA POR TODOS OS 
                SqlDataAdapter da1 = new SqlDataAdapter("EXEC D_R_ConsultaClienteRegistroContatoTodosTxt " + situacaoF + "," + situacaoC + ";", conn);
                DataSet ds1 = new DataSet();
                da1.Fill(ds1);


                if ((ds1.Tables[0].Rows.Count > 0))
                {
                    conn.Close();
                    ValorPesquisa = 0;
                    dataGridViewPesquisaTodos();
                    label8.Text = dataGridViewPesquisaClienteContatos.RowCount.ToString();
                }
                if (!(ds1.Tables[0].Rows.Count > 0))
                {
                    if (dataGridViewPesquisaClienteContatos.DataSource == null)
                    {
                        dataGridViewPesquisaClienteContatos.Refresh();
                    }
                    if (!(dataGridViewPesquisaClienteContatos.DataSource == null))
                    {
                        // dataGridViewPesquisaCliente.Columns.Clear();
                        dataGridViewPesquisaClienteContatos.Refresh();
                    }
                    label8.Text = dataGridViewPesquisaClienteContatos.RowCount.ToString();

                    MessageBox.Show("Nem um Registro  Achado!");
                    conn.Close();
                }
            }

            if (radioButtonPesquisarNome.Checked)
            {
                if (txtPesquisaNomeContatos.Text == "")
                {
                    //dataGridViewPesquisaCliente.Columns.Clear();
                    dataGridViewPesquisaClienteContatos.Refresh();

                    label8.Text = dataGridViewPesquisaClienteContatos.RowCount.ToString();

                    MessageBox.Show("O nome não pode esta em Branco!");
                }
                if (!(txtPesquisaNomeContatos.Text == ""))
                {
                    //SELECIONA POR TODOS OS 
                    SqlDataAdapter da1 = new SqlDataAdapter("EXEC D_R_ConsultaClienteRegistroContatoNomeTxt '" + txtPesquisaNomeContatos.Text + "'," + situacaoF + "," + situacaoC + ";", conn);
                    DataSet ds1 = new DataSet();
                    da1.Fill(ds1);

                    conn.Open();

                    if (!(ds1.Tables[0].Rows.Count > 0))
                    {
                        if (dataGridViewPesquisaClienteContatos.DataSource == null)
                        {
                            dataGridViewPesquisaClienteContatos.Refresh();
                        }
                        if (!(dataGridViewPesquisaClienteContatos.DataSource == null))
                        {
                            // dataGridViewPesquisaCliente.Columns.Clear();
                            dataGridViewPesquisaClienteContatos.Refresh();
                        }
                        label8.Text = dataGridViewPesquisaClienteContatos.RowCount.ToString();

                        MessageBox.Show("Nem um Registro de nome Achado!");
                        conn.Close();
                    }
                    if (ds1.Tables[0].Rows.Count > 0)
                    {
                        conn.Close();

                        dataGridViewPesquisaNome();
                        ValorPesquisa = 1;
                        label8.Text = dataGridViewPesquisaClienteContatos.RowCount.ToString();
                    }
                }
            }
            if (radioButtonPesquisarAbreviacao.Checked)
            {
                if (txtPesquisaAbreviacaoContatos.Text == "")
                {
                    //dataGridViewPesquisaCliente.Columns.Clear();
                    dataGridViewPesquisaClienteContatos.Refresh();

                    label8.Text = dataGridViewPesquisaClienteContatos.RowCount.ToString();

                    MessageBox.Show("O nome Abreviado não pode esta em Branco!");
                }
                if (!(txtPesquisaAbreviacaoContatos.Text == ""))
                {
                    //SELECIONA POR TODOS OS 
                    SqlDataAdapter da1 = new SqlDataAdapter("EXEC D_R_ConsultaClienteRegistroContatoAbreviacaoTxt '" + txtPesquisaAbreviacaoContatos.Text + "'," + situacaoF + "," + situacaoC + ";", conn);
                    DataSet ds1 = new DataSet();
                    da1.Fill(ds1);

                    conn.Open();

                    if (!(ds1.Tables[0].Rows.Count > 0))
                    {
                        if (dataGridViewPesquisaClienteContatos.DataSource == null)
                        {
                            dataGridViewPesquisaClienteContatos.Refresh();
                        }
                        if (!(dataGridViewPesquisaClienteContatos.DataSource == null))
                        {
                            //dataGridViewPesquisaCliente.Columns.Clear();
                            dataGridViewPesquisaClienteContatos.Refresh();
                        }
                        label8.Text = dataGridViewPesquisaClienteContatos.RowCount.ToString();

                        MessageBox.Show("Nem um Registro do nome abreviado foi Achado!");
                        conn.Close();
                    }
                    if (ds1.Tables[0].Rows.Count > 0)
                    {
                        conn.Close();

                        ValorPesquisa = 2;
                        dataGridViewPesquisaAbreviacao();
                        label8.Text = dataGridViewPesquisaClienteContatos.RowCount.ToString();
                    }
                }
            }
            if (radioButtonFornecedor.Checked)
            {
                if (txtPesquisaFornecedorContatos.Text == "")
                {
                    //dataGridViewPesquisaCliente.Columns.Clear();
                    dataGridViewPesquisaClienteContatos.Refresh();

                    label8.Text = dataGridViewPesquisaClienteContatos.RowCount.ToString();

                    MessageBox.Show("O nome do fornecedor não pode esta em Branco!");
                }
                if (!(txtPesquisaFornecedorContatos.Text == ""))
                {
                    //SELECIONA POR TODOS OS 
                    SqlDataAdapter da1 = new SqlDataAdapter("EXEC D_R_ConsultaClienteRegistroContatoFornecedorTxt '" + txtPesquisaFornecedorContatos.Text + "'," + situacaoF + "," + situacaoC + ";", conn);
                    DataSet ds1 = new DataSet();
                    da1.Fill(ds1);

                    conn.Open();

                    if (!(ds1.Tables[0].Rows.Count > 0))
                    {
                        if (dataGridViewPesquisaClienteContatos.DataSource == null)
                        {
                            dataGridViewPesquisaClienteContatos.Refresh();
                        }
                        if (!(dataGridViewPesquisaClienteContatos.DataSource == null))
                        {
                            //dataGridViewPesquisaCliente.Columns.Clear();
                            dataGridViewPesquisaClienteContatos.Refresh();
                        }
                        label8.Text = dataGridViewPesquisaClienteContatos.RowCount.ToString();

                        MessageBox.Show("Nem um Registro do fornecedor foi Achado!");
                        conn.Close();
                    }
                    if (ds1.Tables[0].Rows.Count > 0)
                    {
                        conn.Close();

                        ValorPesquisa = 3;
                        dataGridViewPesquisaFornecedor();
                        label8.Text = dataGridViewPesquisaClienteContatos.RowCount.ToString();
                    }
                }
            }
        }

        private void radioButtonTodos_CheckedChanged(object sender, EventArgs e)
        {
            txtPesquisaNomeContatos.Enabled = false;
            txtPesquisaNomeContatos.Clear();
            txtPesquisaAbreviacaoContatos.Enabled = false;
            txtPesquisaAbreviacaoContatos.Clear();
            txtPesquisaFornecedorContatos.Enabled = false;
            txtPesquisaFornecedorContatos.Clear();
        }

        private void radioButtonPesquisarNome_CheckedChanged(object sender, EventArgs e)
        {
            txtPesquisaNomeContatos.Enabled = true;
            txtPesquisaNomeContatos.Clear();
            txtPesquisaAbreviacaoContatos.Enabled = false;
            txtPesquisaAbreviacaoContatos.Clear();
            txtPesquisaFornecedorContatos.Enabled = false;
            txtPesquisaFornecedorContatos.Clear();
        }

        private void radioButtonPesquisarAbreviacao_CheckedChanged(object sender, EventArgs e)
        {
            txtPesquisaNomeContatos.Enabled = false;
            txtPesquisaNomeContatos.Clear();
            txtPesquisaAbreviacaoContatos.Enabled = true;
            txtPesquisaAbreviacaoContatos.Clear();
            txtPesquisaFornecedorContatos.Enabled = false;
            txtPesquisaFornecedorContatos.Clear();
        }

        private void radioButtonFornecedor_CheckedChanged(object sender, EventArgs e)
        {
            txtPesquisaNomeContatos.Enabled = false;
            txtPesquisaNomeContatos.Clear();
            txtPesquisaAbreviacaoContatos.Enabled = false;
            txtPesquisaAbreviacaoContatos.Clear();
            txtPesquisaFornecedorContatos.Enabled = true;
            txtPesquisaFornecedorContatos.Clear();
        }

        private void buttonCancelarOs_Click(object sender, EventArgs e)
        {
            FecharTodosFormulario();

            FormPesquisaClientesRegistroContatos FormPesquisaClientesRegistroContatosR = new FormPesquisaClientesRegistroContatos(this.ClienteCVisualizar, this.ClienteCEditar, this.ClienteCExcluir, this.NomeServidor, this.NomeBaseDados, this.NomeUsuario, this.SenhaBaseDados);
            FormPesquisaClientesRegistroContatosR.MdiParent = FormPesquisaClientesContatos.ActiveForm;
            FormPesquisaClientesRegistroContatosR.Show();
            FormPesquisaClientesRegistroContatosR.Top = 0;
            FormPesquisaClientesRegistroContatosR.Left = 0;
        }

        private void buttonFecharOs_Click(object sender, EventArgs e)
        {
            FecharTodosFormulario();
        }

        private void txtPesquisaNomeContatos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                PesquisaContatosRegistro();
            }
        }

        private void txtPesquisaAbreviacaoContatos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                PesquisaContatosRegistro();
            }
        }

        private void txtPesquisaFornecedorContatos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                PesquisaContatosRegistro();
            }
        }

        private void dataGridViewPesquisaClienteContatos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // FecharCadastroCliente();

            if (dataGridViewPesquisaClienteContatos.RowCount == 0)
            {
                IdPessoaContato = 0;
            }
            if (!(dataGridViewPesquisaClienteContatos.RowCount == 0) && (ClienteCVisualizar == 0))
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
            if (!(dataGridViewPesquisaClienteContatos.RowCount == 0) && (ClienteCVisualizar == 1))
            {
                try
                {
                    IdPessoaContato = Convert.ToInt32(dataGridViewPesquisaClienteContatos["ID_PESSOA_CONTATO", e.RowIndex].Value);
                    IdPessoaContato.ToString();
                    FormPesquisaClientesRegistroContatosEditar ClientePesquisaE = new FormPesquisaClientesRegistroContatosEditar(IdPessoaContato, CLIENTECEDITAR, CLIENTECEXCLUIR,
                    this.NomeServidor, this.NomeBaseDados, this.NomeUsuario, this.SenhaBaseDados);
                    ClientePesquisaE.MdiParent = FormPesquisaClientesRegistroContatosEditar.ActiveForm;
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

        private void FormPesquisaClientesRegistroContatos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
            {
                this.Close();
            }
        }
    }
}
