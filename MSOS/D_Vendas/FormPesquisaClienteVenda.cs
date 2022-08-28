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
    public partial class FormPesquisaClienteVenda : Form
    {
        DataTable TableNome;
        DataTable TableMs;
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
        private int CLIENTEVISUALIZAR = 0;
        public int ClienteVisualizar
        {
            get
            {
                return this.CLIENTEVISUALIZAR;

            }
            set
            {
                this.CLIENTEVISUALIZAR = value;
            }
        }
        private int CLIENTEEDITAR = 0;
        public int ClienteEditar
        {
            get
            {
                return this.CLIENTEEDITAR;

            }
            set
            {
                this.CLIENTEEDITAR = value;
            }
        }
        private int CLIENTEEXCLUIR = 0;
        public int ClienteExcluir
        {
            get
            {
                return this.CLIENTEEXCLUIR;

            }
            set
            {
                this.CLIENTEEXCLUIR = value;
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
        public FormPesquisaClienteVenda(int CLIENTEVISUALIZAR, int CLIENTEEDITAR, int CLIENTEEXCLUIR, string NomeServidor, string NomeBaseDados, string NomeUsuario, string SenhaBaseDados)
        {
            InitializeComponent();
            radioButtonOculto.Checked = true;

            this.ClienteVisualizar = CLIENTEVISUALIZAR;
            this.ClienteEditar = CLIENTEEDITAR;
            this.ClienteExcluir = CLIENTEEXCLUIR;

            this.NomeServidor = NomeServidor;
            this.NomeBaseDados = NomeBaseDados;
            this.NomeUsuario = NomeUsuario;
            this.SenhaBaseDados = SenhaBaseDados;

            this.connetionString = "Data Source=" + this.NomeServidor + ";Initial Catalog=" + this.NomeBaseDados + ";Persist Security Info=True;User ID=" + this.NomeUsuario + ";Password=" + this.SenhaBaseDados + ";";
        }

        private void FormPesquisaClienteVenda_Load(object sender, EventArgs e)
        {

        }
        public void AlteraBotoes(int op)
        {
            if (op == 1)// Cadastra Cliente campos
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
                txtPesquisaRegistroCliente.Enabled = false;
                txtPesquisaNomeCliente.Enabled = false;
                buttonPesquisaCliente.Enabled = false;
                radioButtonOculto.Checked = true;

                radioButtonPesquisarNome.Enabled = false;

            }
            if (op == 6)//Pesquisa Com suscesso!
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

                radioButtonPesquisarNome.Enabled = true;
                buttonPesquisaCliente.Enabled = true;

            }
            if (op == 10)//limpa textos
            {
                txtPesquisaRegistroCliente.Clear();
                txtPesquisaNomeCliente.Clear();
            }

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
            CancelaPesquisaCliente(typeof(FormPesquisaClienteVenda));
        }
        public void FecharCadastroCliente()
        {
            CancelaPesquisaCliente(typeof(FormPesquisaClienteVenda));
        }
        public void PesquisaCliente()
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
            if (!(radioButtonPesquisarRegistro.Checked == true) && !(radioButtonPesquisarNome.Checked == true) && !(radioButtonTodos.Checked == true))
            {
                MessageBox.Show("Seleciona um modo de busca, por Numero Registro ou Nome ");
            }
            if (radioButtonTodos.Checked)
            {

                // dataGridViewPesquisaCliente.Columns.Clear();
                dataGridViewPesquisaCliente.Refresh();

                label8.Text = dataGridViewPesquisaCliente.RowCount.ToString();


                //SELECIONA POR TODOS OS 
                SqlDataAdapter da1 = new SqlDataAdapter("EXEC D_V_ConsultaTodosClienteVenda " + situacao, conn);
                DataSet ds1 = new DataSet();
                da1.Fill(ds1);
                conn.Open();

                if (!(ds1.Tables[0].Rows.Count > 0))
                {
                    if (dataGridViewPesquisaCliente.DataSource == null)
                    {
                        dataGridViewPesquisaCliente.Refresh();
                    }
                    if (!(dataGridViewPesquisaCliente.DataSource == null))
                    {
                        // dataGridViewPesquisaCliente.Columns.Clear();
                        dataGridViewPesquisaCliente.Refresh();
                    }
                    label8.Text = dataGridViewPesquisaCliente.RowCount.ToString();

                    MessageBox.Show("Nem um Registro Achado!");
                    conn.Close();
                }
                if (ds1.Tables[0].Rows.Count > 0)
                {
                    conn.Close();

                    ValorPesquisa = 1;
                    dataGridViewPesquisaTodos();
                    label8.Text = dataGridViewPesquisaCliente.RowCount.ToString();
                }

            }
            if (radioButtonPesquisarRegistro.Checked)
            {
                if (txtPesquisaRegistroCliente.Text == "")
                {
                    //dataGridViewPesquisaCliente.Columns.Clear();
                    dataGridViewPesquisaCliente.Refresh();

                    label8.Text = dataGridViewPesquisaCliente.RowCount.ToString();

                    MessageBox.Show("O Numero não pode esta em Branco!");
                }
                if (!(txtPesquisaRegistroCliente.Text == ""))
                {
                    //SELECIONA POR TODOS OS 
                    SqlDataAdapter da1 = new SqlDataAdapter("EXEC D_V_ConsultaPessoRegistroClienteTxt '" + txtPesquisaRegistroCliente.Text + "'," + situacao + ";", conn);
                    DataSet ds1 = new DataSet();
                    da1.Fill(ds1);

                    conn.Open();

                    if (!(ds1.Tables[0].Rows.Count > 0))
                    {
                        if (dataGridViewPesquisaCliente.DataSource == null)
                        {
                            dataGridViewPesquisaCliente.Refresh();
                        }
                        if (!(dataGridViewPesquisaCliente.DataSource == null))
                        {
                            //dataGridViewPesquisaCliente.Columns.Clear();
                            dataGridViewPesquisaCliente.Refresh();
                        }
                        label8.Text = dataGridViewPesquisaCliente.RowCount.ToString();

                        MessageBox.Show("Nem numero de registro Achado!");
                        conn.Close();
                    }
                    if (ds1.Tables[0].Rows.Count > 0)
                    {
                        conn.Close();
                        ValorPesquisa = 2;
                        dataGridViewPesquisaRegistro();
                        label8.Text = dataGridViewPesquisaCliente.RowCount.ToString();
                    }
                }
            }
            if (radioButtonPesquisarNome.Checked)
            {
                if (txtPesquisaNomeCliente.Text == "")
                {
                    //dataGridViewPesquisaCliente.Columns.Clear();
                    dataGridViewPesquisaCliente.Refresh();

                    label8.Text = dataGridViewPesquisaCliente.RowCount.ToString();

                    MessageBox.Show("O Nome não pode esta em Branco!");
                }
                if (!(txtPesquisaNomeCliente.Text == ""))
                {
                    //SELECIONA POR TODOS OS 
                    SqlDataAdapter da1 = new SqlDataAdapter("EXEC  D_V_ConsultaPessoaClienteVendaNomeTxt '" + txtPesquisaNomeCliente.Text + "'," + situacao + ";", conn);
                    DataSet ds1 = new DataSet();
                    da1.Fill(ds1);

                    conn.Open();

                    if (!(ds1.Tables[0].Rows.Count > 0))
                    {
                        if (dataGridViewPesquisaCliente.DataSource == null)
                        {
                            dataGridViewPesquisaCliente.Refresh();
                        }
                        if (!(dataGridViewPesquisaCliente.DataSource == null))
                        {
                            // dataGridViewPesquisaCliente.Columns.Clear();
                            dataGridViewPesquisaCliente.Refresh();
                        }
                        label8.Text = dataGridViewPesquisaCliente.RowCount.ToString();

                        MessageBox.Show("Nem um Registro com este nome foi Achado!");
                        conn.Close();
                    }
                    if (ds1.Tables[0].Rows.Count > 0)
                    {
                        conn.Close();

                        ValorPesquisa = 3;
                        dataGridViewPesquisaNome();
                        label8.Text = dataGridViewPesquisaCliente.RowCount.ToString();
                    }
                }
            }
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
            SqlCommand command = new SqlCommand("Exec D_V_ConsultaTodosClienteVenda " + situacao + ";", connection);
            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = command;
                TableTodos = new DataTable();
                adapter.Fill(TableTodos);
                BindingSource Source = new BindingSource();
                Source.DataSource = TableTodos;
                dataGridViewPesquisaCliente.DataSource = Source;
                adapter.Update(TableTodos);
            }
            catch (Exception ex)
            {
                ex.ToString();
            }

            //DataTable dt = new DataTable();
        }
        void dataGridViewPesquisaRegistro()
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
            SqlCommand command = new SqlCommand("Exec D_V_ConsultaPessoRegistroClienteTxt '" + txtPesquisaRegistroCliente.Text + "'," + situacao + ";", connection);
            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = command;
                TableMs = new DataTable();
                adapter.Fill(TableMs);
                BindingSource Source = new BindingSource();
                Source.DataSource = TableMs;
                dataGridViewPesquisaCliente.DataSource = Source;
                adapter.Update(TableMs);
            }
            catch (Exception ex)
            {
                ex.ToString();
            }

            //DataTable dt = new DataTable();
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
            SqlCommand command = new SqlCommand("Exec D_V_ConsultaPessoaClienteVendaNomeTxt '" + txtPesquisaNomeCliente.Text + "'," + situacao + ";", connection);
            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = command;
                TableNome = new DataTable();
                adapter.Fill(TableNome);
                BindingSource Source = new BindingSource();
                Source.DataSource = TableNome;
                dataGridViewPesquisaCliente.DataSource = Source;
                adapter.Update(TableNome);

            }
            catch (Exception ex)
            {
                ex.ToString();
            }

            //DataTable dt = new DataTable();
        }

        private void buttonPesquisaCliente_Click(object sender, EventArgs e)
        {
            PesquisaCliente();
        }

        private void radioButtonPesquisarNome_CheckedChanged(object sender, EventArgs e)
        {
            txtPesquisaRegistroCliente.Enabled = false;
            txtPesquisaNomeCliente.Enabled = true;
            AlteraBotoes(10);
        }

        private void radioButtonPesquisarRegistro_CheckedChanged(object sender, EventArgs e)
        {
            txtPesquisaRegistroCliente.Enabled = true;
            txtPesquisaNomeCliente.Enabled = false;
            AlteraBotoes(10);
        }

        private void buttonCancelarOs_Click(object sender, EventArgs e)
        {
            FecharTodosFormulario();

            FormPesquisaClienteVenda cadastracliente = new FormPesquisaClienteVenda(this.ClienteVisualizar, this.ClienteEditar, this.ClienteExcluir, this.NomeServidor, this.NomeBaseDados, this.NomeUsuario, this.SenhaBaseDados);
            cadastracliente.MdiParent = FormPesquisaClienteVenda.ActiveForm;
            cadastracliente.Show();
            cadastracliente.Top = 0;
            cadastracliente.Left = 0;
        }

        private void buttonFecharOs_Click(object sender, EventArgs e)
        {
            FecharTodosFormulario();
        }

        private void txtPesquisaRegistroCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Se a tecla digitada não for número
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }
            if (e.KeyChar == 13)
            {
                PesquisaCliente();
            }
        }

        private void txtPesquisaRegistroCliente_TextChanged(object sender, EventArgs e)
        {
            if (ValorPesquisa == 2)
            {
                DataView DV = new DataView(TableMs);
                DV.RowFilter = string.Format("NUMERO_REGISTRO LIKE '%{0}%'", txtPesquisaRegistroCliente.Text);
                dataGridViewPesquisaCliente.DataSource = DV;
                label8.Text = dataGridViewPesquisaCliente.RowCount.ToString();
            }
        }

        private void txtPesquisaNomeCliente_TextChanged(object sender, EventArgs e)
        {
            if (ValorPesquisa == 3)
            {
                DataView DV = new DataView(TableNome);
                DV.RowFilter = string.Format("CLIENTE LIKE '%{0}%'", txtPesquisaNomeCliente.Text);
                dataGridViewPesquisaCliente.DataSource = DV;
                label8.Text = dataGridViewPesquisaCliente.RowCount.ToString();
            }
        }

        private void txtPesquisaNomeCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                PesquisaCliente();
            }
        }

        private void radioButtonTodos_CheckedChanged(object sender, EventArgs e)
        {
            txtPesquisaRegistroCliente.Enabled = false;
            txtPesquisaNomeCliente.Enabled = false;
            txtPesquisaRegistroCliente.Clear();
            txtPesquisaNomeCliente.Clear();
        }

        private void dataGridViewPesquisaCliente_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                IdPessoa = Convert.ToInt32(dataGridViewPesquisaCliente["ID_PESSOA1", e.RowIndex].Value);
                FormPesquisaClientesVendaEditar ClientePesquisaE = new FormPesquisaClientesVendaEditar(IdPessoa, ClienteEditar, ClienteExcluir,
                    this.NomeServidor, this.NomeBaseDados, this.NomeUsuario, this.SenhaBaseDados);
                ClientePesquisaE.MdiParent = FormPesquisaClientesVendaEditar.ActiveForm;
                ClientePesquisaE.Show();
                ClientePesquisaE.Top = 0;
                ClientePesquisaE.Left = 0;
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
        }

        private void FormPesquisaClienteVenda_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
            {
                this.Close();
            }
        }
    }
}

