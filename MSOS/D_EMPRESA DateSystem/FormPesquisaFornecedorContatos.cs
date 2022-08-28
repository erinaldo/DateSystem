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
    public partial class FormPesquisaFornecedorContatos : Form
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
        private int ID_PESSOACONTATO = 0;
        public int IdPessoaContato
        {
            get
            {
                return this.ID_PESSOACONTATO;

            }
            set
            {
                this.ID_PESSOACONTATO = value;
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
        private int FORNECEDORCVISUALIZAR = 0;
        public int FornecedorCVisualizar
        {
            get
            {
                return this.FORNECEDORCVISUALIZAR;

            }
            set
            {
                this.FORNECEDORCVISUALIZAR = value;
            }
        }
        private int FORNECEDORCEDITAR = 0;
        public int FornecedorCEditar
        {
            get
            {
                return this.FORNECEDORCEDITAR;

            }
            set
            {
                this.FORNECEDORCEDITAR = value;
            }
        }
        private int FORNECEDORCEXCLUIR = 0;
        public int FornecedorCExcluir
        {
            get
            {
                return this.FORNECEDORCEXCLUIR;

            }
            set
            {
                this.FORNECEDORCEXCLUIR = value;
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



        public FormPesquisaFornecedorContatos(string NomeServidor, string NomeBaseDados, string NomeUsuario, string SenhaBaseDados)
        {
            InitializeComponent();

            this.NomeServidor = NomeServidor;
            this.NomeBaseDados = NomeBaseDados;
            this.NomeUsuario = NomeUsuario;
            this.SenhaBaseDados = SenhaBaseDados;
            this.connetionString = "Data Source=" + this.NomeServidor + ";Initial Catalog=" + this.NomeBaseDados + ";Persist Security Info=True;User ID=" + this.NomeUsuario + ";Password=" + this.SenhaBaseDados + ";";

        }
        public FormPesquisaFornecedorContatos(int FORNECEDORCVISUALIZAR,int FORNECEDORCEDITAR,int FORNECEDORCEXCLUIR,
            string NomeServidor, string NomeBaseDados, string NomeUsuario, string SenhaBaseDados)
        {
            InitializeComponent();

            this.FornecedorCVisualizar = FORNECEDORCVISUALIZAR;
            this.FornecedorCEditar = FORNECEDORCEDITAR;
            this.FornecedorCExcluir = FORNECEDORCEXCLUIR;

            this.NomeServidor = NomeServidor;
            this.NomeBaseDados = NomeBaseDados;
            this.NomeUsuario = NomeUsuario;
            this.SenhaBaseDados = SenhaBaseDados;

            this.connetionString = "Data Source=" + this.NomeServidor + ";Initial Catalog=" + this.NomeBaseDados + ";Persist Security Info=True;User ID=" + this.NomeUsuario + ";Password=" + this.SenhaBaseDados + ";";

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
            CancelaPesquisaCliente(typeof(FormPesquisaClientes));
        }
        public void FecharCadastroCliente()
        {
            CancelaPesquisaCliente(typeof(FormPesquisaClientesEditar));
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
        public void PesquisaFornecedorContatos()
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

                // dataGridViewPesquisaCliente.Columns.Clear();
                dataGridViewPesquisaForncedorContatos.Refresh();

                label8.Text = dataGridViewPesquisaForncedorContatos.RowCount.ToString();


                //SELECIONA POR TODOS OS 
                SqlDataAdapter da1 = new SqlDataAdapter("EXEC D_ConsultaContatosFornecedorTodosTxT " + situacaoF + "," + situacaoC + ";", conn);
                DataSet ds1 = new DataSet();
                da1.Fill(ds1);
                conn.Open();

                if (!(ds1.Tables[0].Rows.Count > 0))
                {
                    if (dataGridViewPesquisaForncedorContatos.DataSource == null)
                    {
                        dataGridViewPesquisaForncedorContatos.Refresh();
                    }
                    if (!(dataGridViewPesquisaForncedorContatos.DataSource == null))
                    {
                        // dataGridViewPesquisaCliente.Columns.Clear();
                        dataGridViewPesquisaForncedorContatos.Refresh();
                    }
                    label8.Text = dataGridViewPesquisaForncedorContatos.RowCount.ToString();

                    MessageBox.Show("Nem um Registro  Achado!");
                    conn.Close();
                }
                if (ds1.Tables[0].Rows.Count > 0)
                {
                    conn.Close();

                    dataGridViewPesquisaTodos();
                    ValorPesquisa = 0;
                    label8.Text = dataGridViewPesquisaForncedorContatos.RowCount.ToString();
                }

            }

            if (radioButtonPesquisarNome.Checked)
            {
                if (txtPesquisaNomeContatos.Text == "")
                {
                    //dataGridViewPesquisaCliente.Columns.Clear();
                    dataGridViewPesquisaForncedorContatos.Refresh();

                    label8.Text = dataGridViewPesquisaForncedorContatos.RowCount.ToString();

                    MessageBox.Show("O nome não pode esta em Branco!");
                }
                if (!(txtPesquisaNomeContatos.Text == ""))
                {
                    //SELECIONA POR TODOS OS 
                    SqlDataAdapter da1 = new SqlDataAdapter("EXEC D_ConsultaContatosFornecedorNomeTxT '" + txtPesquisaNomeContatos.Text + "'," + situacaoF + "," + situacaoC + ";", conn);
                    DataSet ds1 = new DataSet();
                    da1.Fill(ds1);

                    conn.Open();

                    if (!(ds1.Tables[0].Rows.Count > 0))
                    {
                        if (dataGridViewPesquisaForncedorContatos.DataSource == null)
                        {
                            dataGridViewPesquisaForncedorContatos.Refresh();
                        }
                        if (!(dataGridViewPesquisaForncedorContatos.DataSource == null))
                        {
                            // dataGridViewPesquisaCliente.Columns.Clear();
                            dataGridViewPesquisaForncedorContatos.Refresh();
                        }
                        label8.Text = dataGridViewPesquisaForncedorContatos.RowCount.ToString();

                        MessageBox.Show("Nem um Registro de nome Achado!");
                        conn.Close();
                    }
                    if (ds1.Tables[0].Rows.Count > 0)
                    {
                        conn.Close();

                        dataGridViewPesquisaNome();
                        ValorPesquisa = 1;
                        label8.Text = dataGridViewPesquisaForncedorContatos.RowCount.ToString();
                    }
                }
            }
            if (radioButtonPesquisarAbreviacao.Checked)
            {
                if (txtPesquisaAbreviacaoContatos.Text == "")
                {
                    //dataGridViewPesquisaCliente.Columns.Clear();
                    dataGridViewPesquisaForncedorContatos.Refresh();

                    label8.Text = dataGridViewPesquisaForncedorContatos.RowCount.ToString();

                    MessageBox.Show("O nome Abreviado não pode esta em Branco!");
                }
                if (!(txtPesquisaAbreviacaoContatos.Text == ""))
                {
                    //SELECIONA POR TODOS OS 
                    SqlDataAdapter da1 = new SqlDataAdapter("EXEC D_ConsultaContatosFornecedorAbreviacaoTxT '" + txtPesquisaAbreviacaoContatos.Text + "'," + situacaoF + "," + situacaoC + ";", conn);
                    DataSet ds1 = new DataSet();
                    da1.Fill(ds1);

                    conn.Open();

                    if (!(ds1.Tables[0].Rows.Count > 0))
                    {
                        if (dataGridViewPesquisaForncedorContatos.DataSource == null)
                        {
                            dataGridViewPesquisaForncedorContatos.Refresh();
                        }
                        if (!(dataGridViewPesquisaForncedorContatos.DataSource == null))
                        {
                            //dataGridViewPesquisaCliente.Columns.Clear();
                            dataGridViewPesquisaForncedorContatos.Refresh();
                        }
                        label8.Text = dataGridViewPesquisaForncedorContatos.RowCount.ToString();

                        MessageBox.Show("Nem um Registro do nome abreviado foi Achado!");
                        conn.Close();
                    }
                    if (ds1.Tables[0].Rows.Count > 0)
                    {
                        conn.Close();

                        dataGridViewPesquisaAbreviacao();
                        ValorPesquisa = 2;
                        label8.Text = dataGridViewPesquisaForncedorContatos.RowCount.ToString();
                    }
                }
            }
            if (radioButtonFornecedor.Checked)
            {
                if (txtPesquisaFornecedorContatos.Text == "")
                {
                    //dataGridViewPesquisaCliente.Columns.Clear();
                    dataGridViewPesquisaForncedorContatos.Refresh();

                    label8.Text = dataGridViewPesquisaForncedorContatos.RowCount.ToString();

                    MessageBox.Show("O nome do fornecedor não pode esta em Branco!");
                }
                if (!(txtPesquisaFornecedorContatos.Text == ""))
                {
                    //SELECIONA POR TODOS OS 
                    SqlDataAdapter da1 = new SqlDataAdapter("EXEC D_ConsultaContatosFornecedorTxT '" + txtPesquisaFornecedorContatos.Text + "'," + situacaoF + "," + situacaoC + ";", conn);
                    DataSet ds1 = new DataSet();
                    da1.Fill(ds1);

                    conn.Open();

                    if (!(ds1.Tables[0].Rows.Count > 0))
                    {
                        if (dataGridViewPesquisaForncedorContatos.DataSource == null)
                        {
                            dataGridViewPesquisaForncedorContatos.Refresh();
                        }
                        if (!(dataGridViewPesquisaForncedorContatos.DataSource == null))
                        {
                            //dataGridViewPesquisaCliente.Columns.Clear();
                            dataGridViewPesquisaForncedorContatos.Refresh();
                        }
                        label8.Text = dataGridViewPesquisaForncedorContatos.RowCount.ToString();

                        MessageBox.Show("Nem um Registro do fornecedor foi Achado!");
                        conn.Close();
                    }
                    if (ds1.Tables[0].Rows.Count > 0)
                    {
                        conn.Close();

                        dataGridViewPesquisaFornecedor();
                        ValorPesquisa = 3;
                        label8.Text = dataGridViewPesquisaForncedorContatos.RowCount.ToString();
                    }
                }
            }
        }
        private void buttonPesquisaCliente_Click(object sender, EventArgs e)
        {
            PesquisaFornecedorContatos();
        }

        private void FormPesquisaFornecedorContatos_Load(object sender, EventArgs e)
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
            SqlCommand command = new SqlCommand("Exec D_ConsultaContatosFornecedorTodosTxT " + situacaoF + "," + situacaoC + ";", connection);
            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = command;
                TableTodos = new DataTable();
                adapter.Fill(TableTodos);
                BindingSource Source = new BindingSource();
                Source.DataSource = TableTodos;
                dataGridViewPesquisaForncedorContatos.DataSource = Source;
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
            SqlCommand command = new SqlCommand("Exec D_ConsultaContatosFornecedorNomeTxT '" + txtPesquisaNomeContatos.Text + "'," + situacaoF + "," + situacaoC + ";", connection);
            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = command;
                TableNome = new DataTable();
                adapter.Fill(TableNome);
                BindingSource Source = new BindingSource();
                Source.DataSource = TableNome;
                dataGridViewPesquisaForncedorContatos.DataSource = Source;
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
            SqlCommand command = new SqlCommand("Exec D_ConsultaContatosFornecedorAbreviacaoTxT '" + txtPesquisaAbreviacaoContatos.Text + "'," + situacaoF + "," + situacaoC + ";", connection);
            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = command;
                TableAbreviacao = new DataTable();
                adapter.Fill(TableAbreviacao);
                BindingSource Source = new BindingSource();
                Source.DataSource = TableAbreviacao;
                dataGridViewPesquisaForncedorContatos.DataSource = Source;
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
            SqlCommand command = new SqlCommand("Exec D_ConsultaContatosFornecedorTodosTxT '" + txtPesquisaFornecedorContatos.Text + "'," + situacaoF + "," + situacaoC + ";", connection);
            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = command;
                TableFornecedor = new DataTable();
                adapter.Fill(TableFornecedor);
                BindingSource Source = new BindingSource();
                Source.DataSource = TableFornecedor;
                dataGridViewPesquisaForncedorContatos.DataSource = Source;
                adapter.Update(TableFornecedor);

            }
            catch (Exception ex)
            {
                ex.ToString();
            }
        }

        private void dataGridViewPesquisaClienteContatos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (FornecedorCVisualizar == 0)
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
            if (FornecedorCVisualizar == 1)
            {
                try
                {
                    IdPessoaContato = Convert.ToInt32(dataGridViewPesquisaForncedorContatos["ID_PESSOA", e.RowIndex].Value);
                    FormPesquisaFornecedorContatosEditar ClientePesquisaE = new FormPesquisaFornecedorContatosEditar(IdPessoaContato, FORNECEDORCEDITAR, FORNECEDORCEXCLUIR,
                        this.NomeServidor, this.NomeBaseDados, this.NomeUsuario, this.SenhaBaseDados);
                    ClientePesquisaE.MdiParent = FormPesquisaFornecedorContatosEditar.ActiveForm;
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

        private void txtPesquisaNomeContatos_TextChanged(object sender, EventArgs e)
        {
            if(ValorPesquisa == 1)
            {
                DataView DV = new DataView(TableNome);
                DV.RowFilter = string.Format("NOME_CONTATO LIKE '%{0}%'", txtPesquisaNomeContatos.Text);
                dataGridViewPesquisaForncedorContatos.DataSource = DV;
                label8.Text = dataGridViewPesquisaForncedorContatos.RowCount.ToString();
            }
        }

        private void txtPesquisaAbreviacaoContatos_TextChanged(object sender, EventArgs e)
        {
            if (ValorPesquisa == 1)
            {
                DataView DV = new DataView(TableAbreviacao);
                DV.RowFilter = string.Format("ABREVIACAO LIKE '%{0}%'", txtPesquisaAbreviacaoContatos.Text);
                dataGridViewPesquisaForncedorContatos.DataSource = DV;
                label8.Text = dataGridViewPesquisaForncedorContatos.RowCount.ToString();
            }
        }

        private void txtPesquisaFornecedorContatos_TextChanged(object sender, EventArgs e)
        {
            if (ValorPesquisa == 1)
            {
                DataView DV = new DataView(TableFornecedor);
                DV.RowFilter = string.Format("CLIENTE LIKE '%{0}%'", txtPesquisaFornecedorContatos.Text);
                dataGridViewPesquisaForncedorContatos.DataSource = DV;
                label8.Text = dataGridViewPesquisaForncedorContatos.RowCount.ToString();
            }
        }

        private void buttonCancelarOs_Click(object sender, EventArgs e)
        {


            FormPesquisaFornecedorContatos cadastraFornecedorContatos = new FormPesquisaFornecedorContatos(this.NomeServidor, this.NomeBaseDados, this.NomeUsuario, this.SenhaBaseDados);
            cadastraFornecedorContatos.MdiParent = FormPesquisaFornecedorContatos.ActiveForm;
            cadastraFornecedorContatos.Show();
            cadastraFornecedorContatos.Top = 0;
            cadastraFornecedorContatos.Left = 0;
        }

        private void txtPesquisaNomeContatos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                PesquisaFornecedorContatos();
            }
        }

        private void txtPesquisaAbreviacaoContatos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                PesquisaFornecedorContatos();
            }
        }

        private void txtPesquisaFornecedorContatos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                PesquisaFornecedorContatos();
            }
        }

        private void FormPesquisaFornecedorContatos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
            {
                this.Close();
            }
        }
    }
}
