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
    public partial class FormPesquisaProduto : Form
    {
        DataTable TableTodos;
        DataTable TableNome;
        DataTable TableRegistro;
        DataTable TableProduto;

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
        private int ID_PRODUTO = 0;
        public int IdProduto
        {
            get
            {
                return this.ID_PRODUTO;

            }
            set
            {
                this.ID_PRODUTO = value;
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
        private int PRODUTOVISUALIZAR = 0;
        public int ProdutoVisualizar
        {
            get
            {
                return this.PRODUTOVISUALIZAR;

            }
            set
            {
                this.PRODUTOVISUALIZAR = value;
            }
        }
        private int PRODUTOEDITAR = 0;
        public int ProdutoEditar
        {
            get
            {
                return this.PRODUTOEDITAR;

            }
            set
            {
                this.PRODUTOEDITAR = value;
            }
        }
        private int PRODUTOEXCLUIR = 0;
        public int ProdutoExcluir
        {
            get
            {
                return this.PRODUTOEXCLUIR;

            }
            set
            {
                this.PRODUTOEXCLUIR = value;
            }
        }
        private int ID_DESCRICAO_PRODUTO = 0;
        public int IdDescricaoProduto
        {
            get
            {
                return this.ID_DESCRICAO_PRODUTO;

            }
            set
            {
                this.ID_DESCRICAO_PRODUTO = value;
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
        public FormPesquisaProduto(string NomeServidor, string NomeBaseDados, string NomeUsuario, string SenhaBaseDados,
            int PRODUTOVISUALIZAR, int PRODUTOEDITAR, int PRODUTOEXCLUIR)
        {
            InitializeComponent();
            radioButtonOculto.Checked = true;

            this.ProdutoVisualizar = PRODUTOVISUALIZAR;
            this.ProdutoEditar = PRODUTOEDITAR;
            this.ProdutoExcluir = PRODUTOEXCLUIR;

            this.NomeServidor = NomeServidor;
            this.NomeBaseDados = NomeBaseDados;
            this.NomeUsuario = NomeUsuario;
            this.SenhaBaseDados = SenhaBaseDados;

            txtPesquisaRegistroProduto.MaxLength = 9;
            txtPesquisaDescricao.MaxLength = 50;

            this.connetionString = "Data Source=" + this.NomeServidor + ";Initial Catalog=" + this.NomeBaseDados + ";Persist Security Info=True;User ID=" + this.NomeUsuario + ";Password=" + this.SenhaBaseDados + ";";
        }

        private void FormPesquisaProduto_Load(object sender, EventArgs e)
        {

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
            SqlCommand command = new SqlCommand("Exec D_V_ConsultaProdutoVendaTodos " + situacao + ";", connection);
            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = command;
                TableTodos = new DataTable();
                adapter.Fill(TableTodos);
                BindingSource Source = new BindingSource();
                Source.DataSource = TableTodos;
                dataGridViewPesquisaProdutos.DataSource = Source;
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
            SqlCommand command = new SqlCommand("Exec D_V_ConsultaProdutoVendaRegistroTxt '" + txtPesquisaRegistroProduto.Text + "'," + situacao + ";", connection);
            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = command;
                TableRegistro = new DataTable();
                adapter.Fill(TableRegistro);
                BindingSource Source = new BindingSource();
                Source.DataSource = TableRegistro;
                dataGridViewPesquisaProdutos.DataSource = Source;
                adapter.Update(TableRegistro);
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
            SqlCommand command = new SqlCommand("Exec D_V_ConsultaProdutoVendaNomeTxt '" + txtPesquisaDescricao.Text + "'," + situacao + ";", connection);
            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = command;
                TableNome = new DataTable();
                adapter.Fill(TableNome);
                BindingSource Source = new BindingSource();
                Source.DataSource = TableNome;
                dataGridViewPesquisaProdutos.DataSource = Source;
                adapter.Update(TableNome);

            }
            catch (Exception ex)
            {
                ex.ToString();
            }
        }
        void dataGridViewPesquisaNomeProduto()
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
            SqlCommand command = new SqlCommand("Exec D_V_ConsultaProdutoVendaNomeProdutoTxt '" + IdDescricaoProduto + "'," + situacao + ";", connection);
            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = command;
                TableProduto = new DataTable();
                adapter.Fill(TableProduto);
                BindingSource Source = new BindingSource();
                Source.DataSource = TableProduto;
                dataGridViewPesquisaProdutos.DataSource = Source;
                adapter.Update(TableProduto);

            }
            catch (Exception ex)
            {
                ex.ToString();
            }
        }
        //Lista Produtos Descrição
        void Fill_listBoxDescricaoProduto()
        {
            SqlConnection connection = new SqlConnection(this.connetionString);

            try
            {
                connection.Open();
                string Query = "EXEC D_V_ConsultaProdutoNomeProduto;";


                SqlCommand command = new SqlCommand(Query, connection);
                SqlDataReader dr = command.ExecuteReader();
                while (dr.Read())
                {
                    string nome = dr.GetString(1);
                    comboBoxDescricaoProduto.Items.Add(nome);
                }
                connection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void comboBoxDescricaoProduto_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(this.connetionString);

            try
            {
                connection.Open();
                //PROCEDURE NAO EXISTE
                string Query = "SELECT * FROM Pr_ProdutoNome WHERE NOME = '" + this.comboBoxDescricaoProduto.Text + "';";
                SqlCommand command = new SqlCommand(Query, connection);
                SqlDataReader dr = command.ExecuteReader();
                while (dr.Read())
                {
                    IdDescricaoProduto = dr.GetInt32(0);
                    comboBoxDescricaoProduto.Text = dr.GetString(1);
                    
                    ValorPesquisa = 4;

                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        void Fill_listBoxDescricaoProdutoDataGridView()
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
            SqlCommand command = new SqlCommand("Exec D_V_ConsultaProdutoVendaNomeTxt '" + txtPesquisaDescricao.Text + "'," + situacao + ";", connection);
            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = command;
                TableProduto = new DataTable();
                adapter.Fill(TableProduto);
                BindingSource Source = new BindingSource();
                Source.DataSource = TableProduto;
                dataGridViewPesquisaProdutos.DataSource = Source;
                adapter.Update(TableProduto);
                label8.Text = "Produtos : " + dataGridViewPesquisaProdutos.RowCount.ToString();
            }
            catch (Exception ex)
            {
                ex.ToString();
            }

            //DataTable dt = new DataTable();
        }
        private void buttonPesquisaCliente_Click(object sender, EventArgs e)
        {
            PesquisaProduto();
        }
        public void PesquisaProduto()
        {
            try
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
                if (!(radioButtonPesquisarRegistro.Checked == true) && !(radioButtonPesquisarDescrição.Checked == true) && !(radioButtonTodos.Checked == true)
                    && !(radioButtonProduto.Checked == true))
                {
                    MessageBox.Show("Seleciona um modo de busca, por Numero Registro, Descrição do Produto ou Produto ");
                }
                if (radioButtonTodos.Checked)
                {
                    ValorPesquisa = 1;
                    dataGridViewPesquisaProdutos.Refresh();

                    label8.Text = "Produtos : " + dataGridViewPesquisaProdutos.RowCount.ToString();

                    //SELECIONA POR TODOS OS 
                    SqlDataAdapter da1 = new SqlDataAdapter("EXEC D_V_ConsultaProdutoVendaTodos " + situacao, conn);
                    DataSet ds1 = new DataSet();
                    da1.Fill(ds1);
                    conn.Open();

                    if (!(ds1.Tables[0].Rows.Count > 0))
                    {
                        if (dataGridViewPesquisaProdutos.DataSource == null)
                        {
                            dataGridViewPesquisaProdutos.Refresh();
                        }
                        if (!(dataGridViewPesquisaProdutos.DataSource == null))
                        {
                            // dataGridViewPesquisaCliente.Columns.Clear();
                            dataGridViewPesquisaProdutos.Refresh();
                        }
                        label8.Text = "Produtos : " + dataGridViewPesquisaProdutos.RowCount.ToString();

                        MessageBox.Show("Nem um Registro produto Achado!");
                        conn.Close();
                        ValorPesquisa = 0;
                    }
                    if (ds1.Tables[0].Rows.Count > 0)
                    {
                        conn.Close();

                        dataGridViewPesquisaTodos();
                        label8.Text = "Produtos : " + dataGridViewPesquisaProdutos.RowCount.ToString();
                        ValorPesquisa = 1;
                    }

                }
                if (radioButtonPesquisarRegistro.Checked)
                {
                    if (txtPesquisaRegistroProduto.Text == "")
                    {
                        //dataGridViewPesquisaCliente.Columns.Clear();
                        dataGridViewPesquisaProdutos.Refresh();

                        label8.Text = "Produtos : " + dataGridViewPesquisaProdutos.RowCount.ToString();

                        MessageBox.Show("O Numero não pode esta em Branco!");
                        ValorPesquisa = 0;
                    }
                    if (!(txtPesquisaRegistroProduto.Text == ""))
                    {
                        //SELECIONA POR TODOS OS 
                        SqlDataAdapter da1 = new SqlDataAdapter("EXEC D_V_ConsultaProdutoVendaRegistroTxt '" + txtPesquisaRegistroProduto.Text + "'," + situacao + ";", conn);
                        DataSet ds1 = new DataSet();
                        da1.Fill(ds1);

                        conn.Open();

                        if (!(ds1.Tables[0].Rows.Count > 0))
                        {
                            if (dataGridViewPesquisaProdutos.DataSource == null)
                            {
                                dataGridViewPesquisaProdutos.Refresh();
                            }
                            if (!(dataGridViewPesquisaProdutos.DataSource == null))
                            {
                                //dataGridViewPesquisaCliente.Columns.Clear();
                                dataGridViewPesquisaProdutos.Refresh();
                            }
                            label8.Text = "Produtos : " + dataGridViewPesquisaProdutos.RowCount.ToString();

                            MessageBox.Show("Nem numero de registro Achado!");
                            conn.Close();
                            ValorPesquisa = 0;
                        }
                        if (ds1.Tables[0].Rows.Count > 0)
                        {
                            conn.Close();
                            dataGridViewPesquisaRegistro();
                            label8.Text = "Produtos : " + dataGridViewPesquisaProdutos.RowCount.ToString();
                            ValorPesquisa = 2;
                        }
                    }
                }
                if (radioButtonPesquisarDescrição.Checked)
                {
                    if (txtPesquisaDescricao.Text == "")
                    {
                        //dataGridViewPesquisaCliente.Columns.Clear();
                        dataGridViewPesquisaProdutos.Refresh();

                        label8.Text = "Produtos : " + dataGridViewPesquisaProdutos.RowCount.ToString();

                        MessageBox.Show("O Nome não pode esta em Branco!");
                        ValorPesquisa = 0;
                    }
                    if (!(txtPesquisaDescricao.Text == ""))
                    {
                        //SELECIONA POR TODOS OS 
                        SqlDataAdapter da1 = new SqlDataAdapter("EXEC  D_V_ConsultaProdutoVendaNomeTxt '" + txtPesquisaDescricao.Text + "'," + situacao + ";", conn);
                        DataSet ds1 = new DataSet();
                        da1.Fill(ds1);

                        conn.Open();

                        if (!(ds1.Tables[0].Rows.Count > 0))
                        {
                            if (dataGridViewPesquisaProdutos.DataSource == null)
                            {
                                dataGridViewPesquisaProdutos.Refresh();
                            }
                            if (!(dataGridViewPesquisaProdutos.DataSource == null))
                            {
                                // dataGridViewPesquisaCliente.Columns.Clear();
                                dataGridViewPesquisaProdutos.Refresh();
                            }
                            label8.Text = "Produtos : " + dataGridViewPesquisaProdutos.RowCount.ToString();

                            MessageBox.Show("Nem um Registro com este nome foi Achado!");
                            conn.Close();
                            ValorPesquisa = 0;
                        }
                        if (ds1.Tables[0].Rows.Count > 0)
                        {
                            conn.Close();
                            dataGridViewPesquisaNome();
                            label8.Text = "Produtos : " + dataGridViewPesquisaProdutos.RowCount.ToString();
                            ValorPesquisa = 3;
                        }
                    }
                }
                if (radioButtonProduto.Checked)
                {
                    if (comboBoxDescricaoProduto.Text == "")
                    {
                        //dataGridViewPesquisaCliente.Columns.Clear();
                        dataGridViewPesquisaProdutos.Refresh();

                        label8.Text = "Produtos : " + dataGridViewPesquisaProdutos.RowCount.ToString();

                        MessageBox.Show("O produto não pode esta em Branco!");
                        ValorPesquisa = 4;
                    }
                    if (!(comboBoxDescricaoProduto.Text == ""))
                    {
                        //SELECIONA POR TODOS OS                      
                        SqlDataAdapter da1 = new SqlDataAdapter("Exec D_V_ConsultaProdutoVendaNomeProdutoTxt " + this.IdDescricaoProduto + "," + situacao + ";", conn);
                        DataSet ds1 = new DataSet();
                        da1.Fill(ds1);

                        conn.Open();

                        if (!(ds1.Tables[0].Rows.Count > 0))
                        {
                            if (dataGridViewPesquisaProdutos.DataSource == null)
                            {
                                dataGridViewPesquisaProdutos.Refresh();
                            }
                            if (!(dataGridViewPesquisaProdutos.DataSource == null))
                            {
                                //dataGridViewPesquisaCliente.Columns.Clear();
                                dataGridViewPesquisaProdutos.Refresh();
                            }
                            label8.Text = "Produtos : " + dataGridViewPesquisaProdutos.RowCount.ToString();

                            MessageBox.Show("Nem um produto de registro Achado!");
                            conn.Close();
                            ValorPesquisa = 4;
                        }
                        if (ds1.Tables[0].Rows.Count > 0)
                        {
                            conn.Close();
                            dataGridViewPesquisaNomeProduto();
                            //Fill_listBoxDescricaoProdutoDataGridView();
                            label8.Text = "Produtos : " + dataGridViewPesquisaProdutos.RowCount.ToString();
                            ValorPesquisa = 4;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
        }

        private void buttonCancelarOs_Click(object sender, EventArgs e)
        {
            FecharTodosFormulario();

            FormPesquisaProduto cadastracliente = new FormPesquisaProduto(this.NomeServidor, this.NomeBaseDados, this.NomeUsuario, this.SenhaBaseDados,
                    this.ProdutoVisualizar, this.ProdutoEditar, this.ProdutoExcluir);
            cadastracliente.MdiParent = FormPesquisaProduto.ActiveForm;
            cadastracliente.Show();
            cadastracliente.Top = 0;
            cadastracliente.Left = 0;
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
            CancelaPesquisaCliente(typeof(FormPesquisaProduto));
        }

        private void txtPesquisaRegistroProduto_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Se a tecla digitada não for número
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08 && !(e.KeyChar == ','))
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }
            if (e.KeyChar == 13)
            {
                PesquisaProduto();
            }
        }

        private void txtPesquisaNomeProduto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                PesquisaProduto();
            }
        }

        private void buttonFecharOs_Click(object sender, EventArgs e)
        {
            FecharTodosFormulario();
        }

        private void radioButtonTodos_CheckedChanged(object sender, EventArgs e)
        {
            AlteraBotoes(1);
        }
        private void radioButtonPesquisarRegistro_CheckedChanged(object sender, EventArgs e)
        {
            AlteraBotoes(2);
        }
        private void radioButtonPesquisarNome_CheckedChanged(object sender, EventArgs e)
        {
            AlteraBotoes(3);
        }
        private void radioButtonProduto_CheckedChanged(object sender, EventArgs e)
        {
            AlteraBotoes(4);
            Fill_listBoxDescricaoProduto();
        }
        public void AlteraBotoes(int op)
        {
            if (op == 1)// Pesquisa Todos os Produto
            {
                txtPesquisaRegistroProduto.Enabled = false;
                txtPesquisaRegistroProduto.Clear();
                txtPesquisaDescricao.Enabled = false;
                txtPesquisaDescricao.Clear();
                comboBoxDescricaoProduto.Enabled = false;
                comboBoxDescricaoProduto.Items.Clear();
            }
            if (op == 2)//Pesquisa Numero de Produto
            {

                txtPesquisaRegistroProduto.Enabled = true;
                txtPesquisaRegistroProduto.Clear();
                txtPesquisaDescricao.Enabled = false;
                txtPesquisaDescricao.Clear();
                comboBoxDescricaoProduto.Enabled = false;
                comboBoxDescricaoProduto.Items.Clear();
            }
            if (op == 3)//Pesquisa Descrição
            {
                txtPesquisaRegistroProduto.Enabled = false;
                txtPesquisaRegistroProduto.Clear();
                txtPesquisaDescricao.Enabled = true;
                txtPesquisaDescricao.Clear();
                comboBoxDescricaoProduto.Enabled = false;
                comboBoxDescricaoProduto.Items.Clear();
            }
            if (op == 4) //Produto
            {
                txtPesquisaRegistroProduto.Enabled = false;
                txtPesquisaRegistroProduto.Clear();
                txtPesquisaDescricao.Enabled = false;
                txtPesquisaDescricao.Clear();
                comboBoxDescricaoProduto.Enabled = true;
                comboBoxDescricaoProduto.Items.Clear();
            }
            if (op == 5)//Cancela Pesquisa
            {
                txtPesquisaRegistroProduto.Enabled = false;
                txtPesquisaDescricao.Enabled = false;
                buttonPesquisaCliente.Enabled = false;
                radioButtonOculto.Checked = true;

                radioButtonPesquisarDescrição.Enabled = false;

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

                radioButtonPesquisarDescrição.Enabled = true;
                buttonPesquisaCliente.Enabled = true;

            }
            if (op == 10)//limpa textos
            {
                txtPesquisaRegistroProduto.Clear();
                txtPesquisaDescricao.Clear();
            }

        }

        private void FormPesquisaProduto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
            {
                this.Close();
            }
        }

        private void dataGridViewPesquisaProdutos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (ProdutoVisualizar == 0)
                {

                }
                if (ProdutoVisualizar == 1)
                {
                    this.IdProduto = Convert.ToInt32(dataGridViewPesquisaProdutos["ID_PRODUTO1", e.RowIndex].Value);

                    FormPesquisaProdutoEditar ClientePesquisaE = new FormPesquisaProdutoEditar(IdProduto, this.NomeServidor, this.NomeBaseDados,
                        this.NomeUsuario, this.SenhaBaseDados, ProdutoEditar, ProdutoExcluir);
                    ClientePesquisaE.MdiParent = FormPesquisaProdutoEditar.ActiveForm;
                    ClientePesquisaE.Show();
                    ClientePesquisaE.Top = 0;
                    ClientePesquisaE.Left = 0;
                }


            }
            catch (Exception ex)
            {
                ex.ToString();
            }
        }

        private void txtPesquisaRegistroProduto_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (ValorPesquisa == 2)
                {
                    DataView DV = new DataView(TableRegistro);
                    DV.RowFilter = string.Format("ID_PRODUTO LIKE '%{0}%'", txtPesquisaRegistroProduto.Text);
                    dataGridViewPesquisaProdutos.DataSource = DV;
                    label8.Text = "Produtos : " + dataGridViewPesquisaProdutos.RowCount.ToString();
                }
            }
            catch
            {

            }
        }
        private void txtPesquisaNomeProduto_TextChanged(object sender, EventArgs e)
        {
            if (ValorPesquisa == 3)
            {
                DataView DV = new DataView(TableNome);
                DV.RowFilter = string.Format("DESCRICAO_PRODUTO LIKE '%{0}%'", txtPesquisaDescricao.Text);
                dataGridViewPesquisaProdutos.DataSource = DV;
                label8.Text = "Produtos : " + dataGridViewPesquisaProdutos.RowCount.ToString();
            }
        }
    }
}
