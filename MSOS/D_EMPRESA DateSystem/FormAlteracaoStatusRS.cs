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
    public partial class FormAlteracaoStatusRS : Form
    {
        DataTable TableTodos;
        DataTable TableNumeroCadastro;
        DataTable TableNomeCadastro;
        DataTable TableCnpj;

        //Lista de Classes já atribuidas
        bool OrdemServicosAtribuido;
        bool FornecedorAtribuido;
        bool VendedorAtribuido;
        bool RegistroAtribuido;


        List<int> listaStatusTemp = new List<int>();

        List<int> listaStatusTempA = new List<int>();

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
        private int IDPESSOA = 0;
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
        private string NOMECADASTRADAEMPRESA = "";
        public string NomeCadastradaEmpresa
        {
            get
            {
                return this.NOMECADASTRADAEMPRESA;

            }
            set
            {
                this.NOMECADASTRADAEMPRESA = value;
            }
        }

        public FormAlteracaoStatusRS()
        {
            InitializeComponent();
        }
        public FormAlteracaoStatusRS(string NomeServidor, string NomeBaseDados, string NomeUsuario, string SenhaBaseDados)
        {
            InitializeComponent();

            this.NomeServidor = NomeServidor;
            this.NomeBaseDados = NomeBaseDados;
            this.NomeUsuario = NomeUsuario;
            this.SenhaBaseDados = SenhaBaseDados;

            this.connetionString = "Data Source=" + this.NomeServidor + ";Initial Catalog=" + this.NomeBaseDados + ";Persist Security Info=True;User ID=" + this.NomeUsuario + ";Password=" + this.SenhaBaseDados + ";";

            txtNomeOs.MaxLength = 150;
            txtMS.MaxLength = 9;
            txtNomeContato.MaxLength = 30;
            txtCargoContato.MaxLength = 20;
            txtNumeroVendedor.MaxLength = 30;
            txtNomeRegistro.MaxLength = 150;
        }

        private void FormAlteracapStatusRS_Load(object sender, EventArgs e)
        {

        }
        private void buttonBuscaCasdatrado_Click(object sender, EventArgs e)
        {
            BuscaPessoaCadastrada();
        }
        public void BuscaPessoaCadastrada()
        {
            try
            {
                SqlConnection conn = new SqlConnection(this.connetionString);

                if (radioButtonTodos.Checked == true)
                {
                    //SELECIONA POR TODOS OS 
                    SqlDataAdapter da1 = new SqlDataAdapter("EXEC D_ConsultaStatusRSTodosTxt;", conn);
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
                            //dataGridViewPesquisa.Columns.Clear();
                            dataGridViewPesquisa.Refresh();
                        }
                        label2.Text = "Quantidade de Cadastrado : " + 0;
                        MessageBox.Show("Nem um Registro Achado!");

                        conn.Close();
                    }
                    if ((ds1.Tables[0].Rows.Count > 0))
                    {
                        if (dataGridViewPesquisa.DataSource == null)
                        {
                            dataGridViewPesquisa.Refresh();
                        }
                        if (!(dataGridViewPesquisa.DataSource == null))
                        {
                            //dataGridViewPesquisa.Columns.Clear();
                            dataGridViewPesquisa.Refresh();
                        }
                        label2.Text = "Quantidade de Cadastrado : " + dataGridViewPesquisa.RowCount.ToString();
                        dataGridViewPesquisaTodos();
                        conn.Close();
                        ValorPesquisa = 1;
                        checkedListBoxStatus.Enabled = true;
                    }
                }
                if (radioButtonNumeroCadastro.Checked == true)
                {
                    if (txtNumeroCadastro.Text == "")
                    {
                        MessageBox.Show("O número não pode esta em branco!");
                    }
                    if (txtNumeroCadastro.Text != "")
                    {
                        //SELECIONA POR TODOS OS 
                        SqlDataAdapter da1 = new SqlDataAdapter("EXEC D_ConsultaStatusRSNumeroTxt " + txtNumeroCadastro.Text + ";", conn);
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
                                //dataGridViewPesquisa.Columns.Clear();
                                dataGridViewPesquisa.Refresh();
                            }
                            label2.Text = "Quantidade de Cadastrado : " + 0;
                            MessageBox.Show("Nem um Registro Achado!");

                            conn.Close();
                        }
                        if ((ds1.Tables[0].Rows.Count > 0))
                        {
                            if (dataGridViewPesquisa.DataSource == null)
                            {
                                dataGridViewPesquisa.Refresh();
                            }
                            if (!(dataGridViewPesquisa.DataSource == null))
                            {
                                //dataGridViewPesquisa.Columns.Clear();
                                dataGridViewPesquisa.Refresh();
                            }
                            label2.Text = "Quantidade de Cadastrado : " + dataGridViewPesquisa.RowCount.ToString();
                            dataGridViewPesquisaNumero();
                            conn.Close();
                            ValorPesquisa = 2;
                            checkedListBoxStatus.Enabled = true;
                        }
                    }

                }
                if (radioButtonNomeCadastro.Checked == true)
                {
                    if (txtNomeCadastro.Text == "")
                    {
                        MessageBox.Show("O nome não pode esta em branco!");
                    }
                    if (txtNomeCadastro.Text != "")
                    {
                        //SELECIONA POR TODOS OS 
                        SqlDataAdapter da1 = new SqlDataAdapter("EXEC D_ConsultaStatusRSNomeTxt " + txtNomeCadastro.Text + ";", conn);
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
                                //dataGridViewPesquisa.Columns.Clear();
                                dataGridViewPesquisa.Refresh();
                            }
                            label2.Text = "Quantidade de Cadastrado : " + 0;
                            MessageBox.Show("Nem um Registro Achado!");

                            conn.Close();
                        }
                        if ((ds1.Tables[0].Rows.Count > 0))
                        {
                            if (dataGridViewPesquisa.DataSource == null)
                            {
                                dataGridViewPesquisa.Refresh();
                            }
                            if (!(dataGridViewPesquisa.DataSource == null))
                            {
                                //dataGridViewPesquisa.Columns.Clear();
                                dataGridViewPesquisa.Refresh();
                            }
                            label2.Text = "Quantidade de Cadastrado : " + dataGridViewPesquisa.RowCount.ToString();
                            dataGridViewPesquisaNome();
                            conn.Close();
                            ValorPesquisa = 3;
                            checkedListBoxStatus.Enabled = true;
                        }
                    }

                }
                if (radioButtonCnpj.Checked == true)
                {
                    if (txtNomeCadastro.Text == "")
                    {
                        MessageBox.Show("O cnpj não pode esta em branco!");
                    }
                    if (txtCnpj.Text != "")
                    {
                        //SELECIONA POR TODOS OS 
                        SqlDataAdapter da1 = new SqlDataAdapter("EXEC D_ConsultaStatusRSCnpjTxt " + txtCnpj.Text + ";", conn);
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
                                //dataGridViewPesquisa.Columns.Clear();
                                dataGridViewPesquisa.Refresh();
                            }
                            label2.Text = "Quantidade de Cadastrado : " + 0;
                            MessageBox.Show("Nem um Registro Achado!");

                            conn.Close();
                        }
                        if ((ds1.Tables[0].Rows.Count > 0))
                        {
                            if (dataGridViewPesquisa.DataSource == null)
                            {
                                dataGridViewPesquisa.Refresh();
                            }
                            if (!(dataGridViewPesquisa.DataSource == null))
                            {
                                //dataGridViewPesquisa.Columns.Clear();
                                dataGridViewPesquisa.Refresh();
                            }
                            label2.Text = "Quantidade de Cadastrado : " + dataGridViewPesquisa.RowCount.ToString();
                            dataGridViewPesquisaCnpj();
                            conn.Close();
                            ValorPesquisa = 4;
                            checkedListBoxStatus.Enabled = true;
                        }
                    }

                }
                if (!(radioButtonTodos.Checked == true) && !(radioButtonNumeroCadastro.Checked == true) && !(radioButtonNomeCadastro.Checked == true) &&
                !(radioButtonCnpj.Checked == true))
                {
                    MessageBox.Show("Seleciona um modo de Busca Razão Social, por Todos, Número, Nome o Cnpj!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro:" + ex.ToString());
            }

        }
        void dataGridViewPesquisaTodos()
        {
            string connetionString = (this.connetionString);
            SqlConnection connection = new SqlConnection(connetionString);
            SqlCommand command = new SqlCommand("Exec D_ConsultaStatusRSTodosTxt;", connection);
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

                ValorPesquisa = 1;

            }
            catch (Exception ex)
            {
                ex.ToString();
            }
        }
        void dataGridViewPesquisaNumero()
        {
            string connetionString = (this.connetionString);
            SqlConnection connection = new SqlConnection(connetionString);
            SqlCommand command = new SqlCommand("EXEC D_ConsultaStatusRSNumeroTxt " + txtNumeroCadastro.Text + ";", connection);
            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = command;
                TableNumeroCadastro = new DataTable();
                adapter.Fill(TableNumeroCadastro);
                BindingSource Source = new BindingSource();
                Source.DataSource = TableNumeroCadastro;
                dataGridViewPesquisa.DataSource = Source;
                adapter.Update(TableNumeroCadastro);

                ValorPesquisa = 2;

            }
            catch (Exception ex)
            {
                ex.ToString();
            }
        }
        void dataGridViewPesquisaNome()
        {
            string connetionString = (this.connetionString);
            SqlConnection connection = new SqlConnection(connetionString);
            SqlCommand command = new SqlCommand("EXEC D_ConsultaStatusRSNomeTxt " + txtNomeCadastro.Text + ";", connection);
            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = command;
                TableNomeCadastro = new DataTable();
                adapter.Fill(TableNomeCadastro);
                BindingSource Source = new BindingSource();
                Source.DataSource = TableNomeCadastro;
                dataGridViewPesquisa.DataSource = Source;
                adapter.Update(TableNomeCadastro);

                ValorPesquisa = 3;

            }
            catch (Exception ex)
            {
                ex.ToString();
            }
        }
        void dataGridViewPesquisaCnpj()
        {
            string connetionString = (this.connetionString);
            SqlConnection connection = new SqlConnection(connetionString);
            SqlCommand command = new SqlCommand("EXEC D_ConsultaStatusRSCnpjTxt " + txtCnpj.Text + ";", connection);
            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = command;
                TableCnpj = new DataTable();
                adapter.Fill(TableCnpj);
                BindingSource Source = new BindingSource();
                Source.DataSource = TableCnpj;
                dataGridViewPesquisa.DataSource = Source;
                adapter.Update(TableCnpj);

                ValorPesquisa = 4;
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
        }

        private void FormAlteracapStatusRS_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
            {
                this.Close();
            }
        }
        private void txtNomeCadastro_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (ValorPesquisa == 3)
                {
                    DataView DV = new DataView(TableNomeCadastro);
                    DV.RowFilter = string.Format("NOMECADASTRADO LIKE '%{0}%'", txtNomeCadastro.Text);
                    dataGridViewPesquisa.DataSource = DV;
                    label2.Text = dataGridViewPesquisa.RowCount.ToString();
                }
            }
            catch
            {

            }
        }

        private void txtCnpj_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (ValorPesquisa == 4)
                {
                    DataView DV = new DataView(TableCnpj);
                    DV.RowFilter = string.Format("CNPJ LIKE '%{0}%'", txtCnpj.Text);
                    dataGridViewPesquisa.DataSource = DV;
                    label2.Text = dataGridViewPesquisa.RowCount.ToString();
                }
            }
            catch
            {

            }
        }

        private void txtNumeroCadastro_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Se a tecla digitada não for número
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }
            if (e.KeyChar == 13)
            {
                BuscaPessoaCadastrada();
            }
        }

        private void txtNomeCadastro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                BuscaPessoaCadastrada();
            }
        }

        private void txtCnpj_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Se a tecla digitada não for número
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }
            if (e.KeyChar == 13)
            {
                BuscaPessoaCadastrada();
            }
        }

        private void radioButtonTodos_CheckedChanged(object sender, EventArgs e)
        {
            txtNumeroCadastro.Clear();
            txtNumeroCadastro.Enabled = false;

            txtNomeCadastro.Clear();
            txtNomeCadastro.Enabled = false;

            txtCnpj.Clear();
            txtCnpj.Enabled = false;

            ValorPesquisa = 1;
        }

        private void radioButtonNumeroCadastro_CheckedChanged(object sender, EventArgs e)
        {
            txtNumeroCadastro.Clear();
            txtNumeroCadastro.Enabled = true;

            txtNomeCadastro.Clear();
            txtNomeCadastro.Enabled = false;

            txtCnpj.Clear();
            txtCnpj.Enabled = false;

            ValorPesquisa = 2;
        }

        private void radioButtonNomeCadastro_CheckedChanged(object sender, EventArgs e)
        {
            txtNumeroCadastro.Clear();
            txtNumeroCadastro.Enabled = false;

            txtNomeCadastro.Clear();
            txtNomeCadastro.Enabled = true;

            txtCnpj.Clear();
            txtCnpj.Enabled = false;

        }

        private void radioButtonCnpj_CheckedChanged(object sender, EventArgs e)
        {
            txtNumeroCadastro.Clear();
            txtNumeroCadastro.Enabled = false;

            txtNomeCadastro.Clear();
            txtNomeCadastro.Enabled = false;

            txtCnpj.Clear();
            txtCnpj.Enabled = true;
        }

        //PESQUISA SE O ID É ESTA CADASTRADO EM QUAIS FUNÇÕES CLIENTE DE OS, FORNECEDOR, VENDEDOR E REGISTRO.
        //CRIAR UM ARQUIVO listaStatusTemp ADD PARA VERIFICAÇÃO
        public void PesquisaClienteOs()
        {
            SqlConnection conn = new SqlConnection(this.connetionString);

            try
            {
                //SELECIONA POR TODOS OS 
                SqlDataAdapter da1 = new SqlDataAdapter("SELECT * FROM P_Cliente WHERE ID_CLIENTE_PESSOA = " + IdPessoa + ";", conn);
                DataSet ds1 = new DataSet();
                da1.Fill(ds1);

                conn.Open();

                if (!(ds1.Tables[0].Rows.Count > 0))
                {
                    conn.Close();
                    listaStatusTemp.Add(0);
                }
                if ((ds1.Tables[0].Rows.Count > 0))
                {
                    //OrdemServicosAtribuido = true;
                    listaStatusTemp.Add(1);
                    //checkedListBoxStatus.SetItemChecked(0,true);
                    conn.Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro: " + ex.ToString());
            }
        }
        public void PesquisaFornecedor()
        {
            SqlConnection conn = new SqlConnection(this.connetionString);

            try
            {
                //SELECIONA POR TODOS OS 
                SqlDataAdapter da1 = new SqlDataAdapter("SELECT * FROM P_Fornecedor WHERE ID_FORNECEDOR_PESSOA  = " + IdPessoa + ";", conn);
                DataSet ds1 = new DataSet();
                da1.Fill(ds1);

                conn.Open();

                if (!(ds1.Tables[0].Rows.Count > 0))
                {
                    listaStatusTemp.Add(0);
                    conn.Close();
                }
                if ((ds1.Tables[0].Rows.Count > 0))
                {
                    //FornecedorAtribuido = true;
                    listaStatusTemp.Add(1);
                    //checkedListBoxStatus.SetItemChecked(1, true);
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.ToString());
            }
        }
        public void PesquisaClienteVendedor()
        {
            try
            {
                SqlConnection conn = new SqlConnection(this.connetionString);

                //SELECIONA POR TODOS OS 
                SqlDataAdapter da1 = new SqlDataAdapter("SELECT * FROM P_ClienteVenda WHERE ID_PESSOA_VENDA  = " + IdPessoa + ";", conn);
                DataSet ds1 = new DataSet();
                da1.Fill(ds1);

                conn.Open();

                if (!(ds1.Tables[0].Rows.Count > 0))
                {
                    listaStatusTemp.Add(0);
                    conn.Close();
                }
                if ((ds1.Tables[0].Rows.Count > 0))
                {
                    //VendedorAtribuido = true;
                    listaStatusTemp.Add(1);
                    //checkedListBoxStatus.SetItemChecked(2, true);
                    conn.Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex.ToString());
            }
        }
        public void PesquisaClienteRegistro()
        {
            try
            {
                SqlConnection conn = new SqlConnection(this.connetionString);

                //SELECIONA POR TODOS OS 
                SqlDataAdapter da1 = new SqlDataAdapter("SELECT * FROM P_Registro WHERE ID_PESSOA_REGISTRO  = " + IdPessoa + ";", conn);
                DataSet ds1 = new DataSet();
                da1.Fill(ds1);

                conn.Open();

                if (!(ds1.Tables[0].Rows.Count > 0))
                {
                    listaStatusTemp.Add(0);
                    conn.Close();
                }
                if ((ds1.Tables[0].Rows.Count > 0))
                {
                    //RegistroAtribuido = true;
                    listaStatusTemp.Add(1);
                    //checkedListBoxStatus.SetItemChecked(3, true);
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.ToString());
            }

        }

        //PESQUISA SE O ID É ESTA CADASTRADO EM QUAIS FUNÇÕES CLIENTE DE OS, FORNECEDOR, VENDEDOR E REGISTRO.
        //2 
        public void PesquisaClienteOs2()
        {
            try
            {
                SqlConnection conn = new SqlConnection(this.connetionString);

                //SELECIONA POR TODOS OS 
                SqlDataAdapter da1 = new SqlDataAdapter("SELECT * FROM P_Cliente WHERE ID_CLIENTE_PESSOA = " + IdPessoa + ";", conn);
                DataSet ds1 = new DataSet();
                da1.Fill(ds1);

                conn.Open();

                if (!(ds1.Tables[0].Rows.Count > 0))
                {
                    OrdemServicosAtribuido = true;
                    conn.Close();

                }
                if ((ds1.Tables[0].Rows.Count > 0))
                {
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.ToString());
            }

        }
        public void PesquisaFornecedor2()
        {
            try
            {
                SqlConnection conn = new SqlConnection(this.connetionString);

                //SELECIONA POR TODOS OS 
                SqlDataAdapter da1 = new SqlDataAdapter("SELECT * FROM P_Fornecedor WHERE ID_FORNECEDOR_PESSOA  = " + IdPessoa + ";", conn);
                DataSet ds1 = new DataSet();
                da1.Fill(ds1);

                conn.Open();

                if (!(ds1.Tables[0].Rows.Count > 0))
                {
                    FornecedorAtribuido = true;
                    conn.Close();
                }
                if ((ds1.Tables[0].Rows.Count > 0))
                {
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.ToString());
            }

        }
        public void PesquisaClienteVendedor2()
        {
            try
            {
                SqlConnection conn = new SqlConnection(this.connetionString);

                //SELECIONA POR TODOS OS 
                SqlDataAdapter da1 = new SqlDataAdapter("SELECT * FROM P_ClienteVenda WHERE ID_PESSOA_VENDA  = " + IdPessoa + ";", conn);
                DataSet ds1 = new DataSet();
                da1.Fill(ds1);

                conn.Open();

                if (!(ds1.Tables[0].Rows.Count > 0))
                {
                    VendedorAtribuido = true;
                    conn.Close();
                }
                if ((ds1.Tables[0].Rows.Count > 0))
                {
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.ToString());
            }
        }
        public void PesquisaClienteRegistro2()
        {
            try
            {
                SqlConnection conn = new SqlConnection(this.connetionString);

                //SELECIONA POR TODOS OS 
                SqlDataAdapter da1 = new SqlDataAdapter("SELECT * FROM P_Registro WHERE ID_PESSOA_REGISTRO  = " + IdPessoa + ";", conn);
                DataSet ds1 = new DataSet();
                da1.Fill(ds1);

                conn.Open();

                if (!(ds1.Tables[0].Rows.Count > 0))
                {
                    RegistroAtribuido = true;
                    conn.Close();
                }
                if ((ds1.Tables[0].Rows.Count > 0))
                {
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.ToString());
            }
        }

        
        //METODO PARA VERIFICA SE O FORMULÁRIO ESTA ABERTO SE TIVER ELE FECHA!
        public static void CancelaCadastradoUsuario(Type frmType)
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
            CancelaCadastradoUsuario(typeof(FormAlteracaoStatusRS));
        }

        private void radioButtonNumeroCadastro_CheckedChanged_1(object sender, EventArgs e)
        {
            txtNumeroCadastro.Clear();
            txtNumeroCadastro.Enabled = true;

            txtNomeCadastro.Clear();
            txtNomeCadastro.Enabled = false;

            txtCnpj.Clear();
            txtCnpj.Enabled = false;
        }
        public void LimpaDuploCick(int L)
        {
            if(L == 1)
            {
                panelOS.Enabled = false;
                panelFORNECEDOR.Enabled = false;
                panelVENDEDOR.Enabled = false;
                panelREGISTRO.Enabled = false;

                txtNomeOs.Clear();
                txtMS.Clear();

                txtNomeContato.Clear();
                txtCargoContato.Clear();

                txtNumeroVendedor.Clear();

                txtNomeRegistro.Clear();

                buttonSalvaAlteracao.Enabled = false;
            }
        }
        private void buttonSalvaAlteracao_Click(object sender, EventArgs e)
        {
            SalvarAlteracao();
        }
        public void SalvarAlteracao()
        {
            try
            {
                DialogResult dialogResultVerificar = MessageBox.Show("Deseja salvar as alterações?", "Aviso", MessageBoxButtons.YesNo);

                int contador = 0;

                if (dialogResultVerificar == DialogResult.Yes)
                {
                    OrdemServicosAtribuido = false;
                    FornecedorAtribuido = false;
                    VendedorAtribuido = false;
                    RegistroAtribuido = false;


                    for (int i = 0; i < 4; i++)
                    {
                        if ((int.Parse(listaStatusTemp[i].ToString()) == 0) && (
                            int.Parse(listaStatusTempA[i].ToString()) == 1))
                        {
                            if (i == 0)
                            {
                                contador++;
                                PesquisaClienteOs2();
                            }
                            if (i == 1)
                            {
                                contador++;
                                PesquisaFornecedor2();
                            }
                            if (i == 2)
                            {
                                contador++;
                                PesquisaClienteVendedor2();
                            }
                            if (i == 3)
                            {
                                contador++;
                                PesquisaClienteRegistro2();
                            }
                        }
                    }
                    if (contador != 0)
                    {
                        int contadorN = 0;

                        if (panelOS.Enabled == true)
                        {
                            if (txtMS.Text == "")
                            {
                                contadorN++;
                                MessageBox.Show("Precisa ser definido um MS para o Cliente novo!");
                            }
                            if (txtMS.Text != "")
                            {
                                SqlConnection conn = new SqlConnection(this.connetionString);

                                //Verifica Se a MS é Valida no sistema!

                                int MS = int.Parse(txtMS.Text);

                                SqlDataAdapter da3 = new SqlDataAdapter("EXEC D_ConsultaMsValidar " + MS + ";", conn);

                                DataSet ds3 = new DataSet();
                                da3.Fill(ds3);

                                conn.Open();

                                if (ds3.Tables[0].Rows.Count > 0)

                                {
                                    contadorN++;
                                    MessageBox.Show("O Ms consta no sistema não pode ser Inserido!");
                                }
                                if (!(ds3.Tables[0].Rows.Count > 0))
                                {
                                    if (panelVENDEDOR.Enabled == true)
                                    {
                                        if (txtNumeroVendedor.Text == "")
                                        {
                                            contadorN++;
                                            MessageBox.Show("Precisa ser definido um número para o vendedor novo!");
                                        }
                                        if (txtNumeroVendedor.Text != "")
                                        {
                                            //MessageBox.Show("Sistem Salvo com Sucesso 1");
                                        }
                                    }
                                    else
                                    {
                                        //MessageBox.Show("Sistem Salvo com Sucesso 2"); 
                                    }

                                }
                            }
                        }

                        if ((panelOS.Enabled == false) && panelVENDEDOR.Enabled == true)
                        {
                            if (txtNumeroVendedor.Text == "")
                            {
                                contadorN++;
                                MessageBox.Show("Precisa ser definido um número para o vendedor novo!");
                            }
                            if (txtNumeroVendedor.Text != "")
                            {
                                //MessageBox.Show("Sistem Salvo com Sucesso 3");
                            }
                        }
                        else
                        {
                            if ((panelOS.Enabled == false) && panelVENDEDOR.Enabled == false)
                            {

                                //MessageBox.Show("Sistem Salvo com Sucesso 4");

                            }
                        }
                        if (contadorN == 0)
                        {
                            DialogResult dialogResultSalvar = MessageBox.Show("Confirma as atualizações modificadas? ", " Aviso De salvar", MessageBoxButtons.YesNo);
                            if (dialogResultSalvar == DialogResult.Yes)
                            {
                                AlteracaoStatusRS AlteracaoStatusRSS = new AlteracaoStatusRS();


                                if (OrdemServicosAtribuido == true)
                                {
                                    Clientes ClientesC = new Clientes();
                                    Conexao conexao = new Conexao(this.connetionString);
                                    DALOrdemServico dal = new DALOrdemServico(conexao);//PERMISSÃO PARA ORDEM SERVIÇO

                                    ClientesC.idPessoa = this.IdPessoa;
                                    ClientesC.IdMs = int.Parse(txtMS.Text);

                                    dal.IncluirCliente(ClientesC);

                                    //MessageBox.Show("Salvo Texto 1");
                                }
                                if (FornecedorAtribuido == true)
                                {
                                    Fornecedor FornecedorC = new Fornecedor();
                                    Conexao conexao = new Conexao(this.connetionString);
                                    DALDateSystem dal = new DALDateSystem(conexao);//PERMISSÃO PARA FORNECEDOR

                                    FornecedorC.idFornecedor = this.IdPessoa;
                                    FornecedorC.NomeContato = txtNomeContato.Text;
                                    FornecedorC.CargoContato = txtCargoContato.Text;

                                    dal.IncluirF(FornecedorC);


                                    //MessageBox.Show("Salvo Texto 2");
                                }
                                if (VendedorAtribuido == true)
                                {
                                    ClienteVenda VendedorC = new ClienteVenda();
                                    Conexao conexao = new Conexao(this.connetionString);
                                    DALCadastro2 dal = new DALCadastro2(conexao);//PERMISSÃO PARA VENDEDOR

                                    VendedorC.idPessoa = this.IdPessoa;
                                    VendedorC.NumeroRegistro = txtNumeroVendedor.Text;

                                    dal.IncluirClienteVenda(VendedorC);


                                    //MessageBox.Show("Salvo Texto 3");
                                }
                                if (RegistroAtribuido == true)
                                {
                                    Registro RegistroC = new Registro();
                                    Conexao conexao = new Conexao(this.connetionString);
                                    DALRegistroGerado dal = new DALRegistroGerado(conexao);//PERMISSÃO PARA REGISTRO

                                    RegistroC.idPessoa = this.IdPessoa;
                                    RegistroC.Nome = txtNomeRegistro.Text;

                                    dal.IncluirClienteRegistro(RegistroC);

                                    //MessageBox.Show("Salvo Texto 4");
                                }
                            }
                            else if (dialogResultSalvar == DialogResult.No)
                            {
                                MessageBox.Show("Alterações não realizadas no sistema! - Não confirmadas!");
                            }

                        }
                    }
                }
                else if (dialogResultVerificar == DialogResult.No)
                {
                    MessageBox.Show("Alterações não realizadas no sistema!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.ToString());
            }

            
        }
        private void dataGridViewPesquisa_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                IdPessoa = Convert.ToInt32(dataGridViewPesquisa["ID_PESSOA", e.RowIndex].Value);

                label3.Text = "Razão Social Selecionada: " +
                    Convert.ToString(dataGridViewPesquisa["NOMECADASTRADO", e.RowIndex].Value)
                    + ", número de Registro: " + Convert.ToString(dataGridViewPesquisa["ID_PESSOA", e.RowIndex].Value) + ".";

                NomeCadastradaEmpresa = Convert.ToString(dataGridViewPesquisa["NOMECADASTRADO", e.RowIndex].Value);

                listaStatusTemp.Clear();

                checkedListBoxStatus.Items.Clear();

                LimpaDuploCick(1);

                PesquisaClienteOs();
                PesquisaFornecedor();
                PesquisaClienteVendedor();
                PesquisaClienteRegistro();


                //Definir o tamanho da lista a ser criado!
                for (int i = 0; i < 4; i++)
                {
                    if (i == 0)
                    {
                        if (int.Parse(listaStatusTemp[i].ToString()) == 0)
                        {
                            checkedListBoxStatus.Items.Add("CLIENTE DE OS", CheckState.Unchecked);
                        }
                        else { checkedListBoxStatus.Items.Add("CLIENTE DE OS", CheckState.Indeterminate); }
                    }
                    if (i == 1)
                    {
                        if (int.Parse(listaStatusTemp[i].ToString()) == 0)
                        {
                            checkedListBoxStatus.Items.Add("FORNECEDOR", CheckState.Unchecked);
                        }
                        else { checkedListBoxStatus.Items.Add("FORNECEDOR", CheckState.Indeterminate); }
                    }
                    if (i == 2)
                    {
                        if (int.Parse(listaStatusTemp[i].ToString()) == 0)
                        {
                            checkedListBoxStatus.Items.Add("VENDEDOR", CheckState.Unchecked);
                        }
                        else { checkedListBoxStatus.Items.Add("VENDEDOR", CheckState.Indeterminate); }
                    }
                    if (i == 3)
                    {
                        if (int.Parse(listaStatusTemp[i].ToString()) == 0)
                        {
                            checkedListBoxStatus.Items.Add("REGISTRO", CheckState.Unchecked);
                        }
                        else { checkedListBoxStatus.Items.Add("REGISTRO", CheckState.Indeterminate); }
                    }
                }

            }
            catch
            {

            }
        }

        private void buttonVerificar_Click(object sender, EventArgs e)
        {
            VerificarLiberacao();
        }
        public void VerificarLiberacao()
        {
            try
            {
                listaStatusTempA.Clear();

                LimpaDuploCick(1);


                int contador = 0;

                for (int i = 0; i < 4; i++)
                {
                    if (checkedListBoxStatus.GetItemChecked(i) == true)
                    {
                        listaStatusTempA.Add(1);
                    }
                    else { listaStatusTempA.Add(0); }

                }
                for (int i = 0; i < 4; i++)
                {
                    if ((int.Parse(listaStatusTemp[i].ToString()) == 0) && (
                        int.Parse(listaStatusTempA[i].ToString()) == 1))
                    {
                        if (i == 0)
                        {
                            txtNomeOs.Text = NomeCadastradaEmpresa;
                            contador++;
                            panelOS.Enabled = true;

                        }
                        if (i == 1)
                        {
                            contador++;
                            panelFORNECEDOR.Enabled = true;
                        }
                        if (i == 2)
                        {
                            contador++;
                            panelVENDEDOR.Enabled = true;
                        }
                        if (i == 3)
                        {
                            txtNomeRegistro.Text = NomeCadastradaEmpresa;
                            contador++;
                            panelREGISTRO.Enabled = true;
                        }
                        if (contador > 0)
                        {
                            buttonSalvaAlteracao.Enabled = true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.ToString());
            }
        }

        private void txtMS_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Se a tecla digitada não for número
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }
        }
    }
}

////PESQUSA SE TEM PARAMETROS GERADOS POR ELES.
//public void PesquisaClienteGeradoRegistro()
//{
//    SqlConnection conn = new SqlConnection(this.connetionString);

//    //SELECIONA POR TODOS OS 
//    SqlDataAdapter da1 = new SqlDataAdapter("SELECT * FROM R_RegistroGerados WHERE ID_PESSOA_CLIENTE = " + IdPessoa + ";", conn);
//    DataSet ds1 = new DataSet();
//    da1.Fill(ds1);

//    conn.Open();

//    if (!(ds1.Tables[0].Rows.Count > 0))
//    {
//        conn.Close();
//    }
//    if ((ds1.Tables[0].Rows.Count > 0))
//    {
//        RegistroGeradosB = true;
//        conn.Close();
//    }
//}
//public void PesquisaClienteGeradoOS()
//{
//    SqlConnection conn = new SqlConnection(this.connetionString);

//    //SELECIONA POR TODOS OS 
//    SqlDataAdapter da1 = new SqlDataAdapter("SELECT * FROM O_OrdemServico WHERE ID_PESSOA_CLIENTE = " + IdPessoa + ";", conn);
//    DataSet ds1 = new DataSet();
//    da1.Fill(ds1);

//    conn.Open();

//    if (!(ds1.Tables[0].Rows.Count > 0))
//    {
//        conn.Close();
//    }
//    if ((ds1.Tables[0].Rows.Count > 0))
//    {
//        OrdemServicosGeradosB = true;
//        conn.Close();
//    }
//}