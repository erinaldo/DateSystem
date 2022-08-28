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
using System.Drawing.Imaging;
using System.IO;
using System.Globalization;
using System.Drawing.Printing;

namespace DateSystem
{
    public partial class FormCadastraProdutos : Form
    {
        DataTable TableTodos;
        DataTable TableProduto;
        DataTable TableMarca;
        DataTable TableCategoria;
        DataTable TableCFornecedor;
        Bitmap bmp;
        Bitmap bmp2;

        private Image IMAGEM = null;
        public Image Imagem
        {
            get
            {
                return this.IMAGEM;

            }
            set
            {
                this.IMAGEM = value;
            }
        }
        private Image IMAGEM2 = null;
        public Image Imagem2
        {
            get
            {
                return this.IMAGEM2;

            }
            set
            {
                this.IMAGEM2 = value;
            }
        }
        private string IMGLOCATION = "";
        public string ImgLocation
        {
            get
            {
                return this.IMGLOCATION;

            }
            set
            {
                this.IMGLOCATION = value;
            }
        }
        private string IMGLOCATION2 = "";
        public string ImgLocation2
        {
            get
            {
                return this.IMGLOCATION2;

            }
            set
            {
                this.IMGLOCATION2 = value;
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
        private int ID_PRODUTO_IMAGEM = 0;
        public int IdProdutoImagem
        {
            get
            {
                return this.ID_PRODUTO_IMAGEM;

            }
            set
            {
                this.ID_PRODUTO_IMAGEM = value;
            }
        }
        private int IDMARCPRODUTO = 0;
        public int IdMarcaProduto
        {
            get
            {
                return this.IDMARCPRODUTO;

            }
            set
            {
                this.IDMARCPRODUTO = value;
            }
        }
        private int IDMARCAPRODUTOCATEGORIA = 0;
        public int IdMarcaProdutoCategoria
        {
            get
            {
                return this.IDMARCAPRODUTOCATEGORIA;

            }
            set
            {
                this.IDMARCAPRODUTOCATEGORIA = value;
            }
        }
        private int IDMARCFORNECEDOR = 0;
        public int IdMarcaFornecedor
        {
            get
            {
                return this.IDMARCFORNECEDOR;

            }
            set
            {
                this.IDMARCFORNECEDOR = value;
            }
        }
        private int IDFABRICANTEFORNECEDOR = 0;
        public int IdFabricanteFornecedor
        {
            get
            {
                return this.IDFABRICANTEFORNECEDOR;

            }
            set
            {
                this.IDFABRICANTEFORNECEDOR = value;
            }
        }
        private int IDORIGEMPRODUTO = 0;
        public int IdOrigemProduto
        {
            get
            {
                return this.IDORIGEMPRODUTO;

            }
            set
            {
                this.IDORIGEMPRODUTO = value;
            }
        }
        private int IDUNIDADEPRODUTO = 0;
        public int IdUnidadeProduto
        {
            get
            {
                return this.IDUNIDADEPRODUTO;

            }
            set
            {
                this.IDUNIDADEPRODUTO = value;
            }
        }
        private int ID_CST_ICMS = 0;
        public int IdCstIcms
        {
            get
            {
                return this.ID_CST_ICMS;

            }
            set
            {
                this.ID_CST_ICMS = value;
            }
        }
        private int ID_CST_PIS = 0;
        public int IdCstPis
        {
            get
            {
                return this.ID_CST_PIS;

            }
            set
            {
                this.ID_CST_PIS = value;
            }
        }
        private int ID_CST_COFINS = 0;
        public int IdCstCofins
        {
            get
            {
                return this.ID_CST_COFINS;

            }
            set
            {
                this.ID_CST_COFINS = value;
            }
        }
        private int ID_CST_IP = 0;
        public int IdCstIpi
        {
            get
            {
                return this.ID_CST_IP;

            }
            set
            {
                this.ID_CST_IP = value;
            }
        }
        private decimal TEMP_CUSTO_ENTER;
        public decimal TempCustoEnter
        {
            get
            {
                return this.TEMP_CUSTO_ENTER;

            }
            set
            {
                this.TEMP_CUSTO_ENTER = value;
            }
        }
        private decimal TEMP_MARGEM_LUCRO_ENTER;
        public decimal TempMargemLucroEnter
        {
            get
            {
                return this.TEMP_MARGEM_LUCRO_ENTER;

            }
            set
            {
                this.TEMP_MARGEM_LUCRO_ENTER = value;
            }
        }
        //private string TEM_CUSTO_LUCRO;
        //public string TempCustoEntrada
        //{
        //    get
        //    {
        //        return this.TEM_CUSTO_LUCRO;

        //    }
        //    set
        //    {
        //        this.TEM_CUSTO_LUCRO = value;
        //    }
        //}

        private decimal TEMP_VENDA_ENTER;
        public decimal TempVendaEnter
        {
            get
            {
                return this.TEMP_VENDA_ENTER;

            }
            set
            {
                this.TEMP_VENDA_ENTER = value;
            }
        }
        private int IDDESCRICAOPRODUTO = 0;
        public int IdDescricaoProduto
        {
            get
            {
                return this.IDDESCRICAOPRODUTO;

            }
            set
            {
                this.IDDESCRICAOPRODUTO = value;
            }
        }
        private decimal DIVIDA_TEMP = 0;
        public decimal DividaTemp
        {
            get
            {
                return this.DIVIDA_TEMP;

            }
            set
            {
                this.DIVIDA_TEMP = value;
            }
        }

        private int CADASTRAGTIN = 0;
        public int CadastraGtin
        {
            get
            {
                return this.CADASTRAGTIN;

            }
            set
            {
                this.CADASTRAGTIN = value;
            }
        }
        private int QUANTIDADE_USADA = 0;
        public int QuantidadeUsada
        {
            get
            {
                return this.QUANTIDADE_USADA;

            }
            set
            {
                this.QUANTIDADE_USADA = value;
            }
        }

        //--------------------------------------------------------
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

        // VALIDAR ENTRADA COM ERROPROVIDER
        private Boolean DescricaoProduto(TextBox textBox, ErrorProvider errorProvider)
        {
            if (!String.IsNullOrWhiteSpace(txtDescricaoProduto.Text))
            {
                errorProviderCadastroProduto.SetError(textBox, "");
                return true;
            }
            else
            {
                errorProviderCadastroProduto.SetError(textBox, "Descrição Vazia!");
                return false;
            }

        }
        // VALIDAR ENTRADA COM ERROPROVIDER
        private Boolean PrecoCusto(TextBox textBox, ErrorProvider errorProvider)
        {
            if (!String.IsNullOrWhiteSpace(txtPrecoCusto.Text))
            {
                errorProviderCadastroProduto.SetError(textBox, "");
                return true;
            }
            else
            {
                errorProviderCadastroProduto.SetError(textBox, "Custo Vazia!");
                return false;
            }

        }
        // VALIDAR ENTRADA COM ERROPROVIDER
        private Boolean PrecoVenda(TextBox textBox, ErrorProvider errorProvider)
        {
            if (!String.IsNullOrWhiteSpace(txtPrecoVenda.Text))
            {
                errorProviderCadastroProduto.SetError(textBox, "");
                return true;
            }
            else
            {
                errorProviderCadastroProduto.SetError(textBox, "Venda Vazia!");
                return false;
            }

        }
        // VALIDAR ENTRADA COM ERROPROVIDER
        private Boolean MargemLucro(TextBox textBox, ErrorProvider errorProvider)
        {
            if (!String.IsNullOrWhiteSpace(txtMargemLucro.Text))
            {
                errorProviderCadastroProduto.SetError(textBox, "");
                return true;
            }
            else
            {
                errorProviderCadastroProduto.SetError(textBox, "Lucro Vazia!");
                return false;
            }

        }       // VALIDAR ENTRADA COM ERROPROVIDER
        private Boolean CustoMedio(TextBox textBox, ErrorProvider errorProvider)
        {
            if (!String.IsNullOrWhiteSpace(txtCustoMedio.Text))
            {
                errorProviderCadastroProduto.SetError(textBox, "");
                return true;
            }
            else
            {
                errorProviderCadastroProduto.SetError(textBox, "Custo Medio Vazia!");
                return false;
            }

        }
        private Boolean QuantAtual(TextBox textBox, ErrorProvider errorProvider)
        {
            if (!String.IsNullOrWhiteSpace(txtQuantidadeAtualEstoque.Text))
            {
                errorProviderCadastroProduto.SetError(textBox, "");
                return true;
            }
            else
            {
                errorProviderCadastroProduto.SetError(textBox, "Quantidade M Vazia!");
                return false;
            }

        }
        private Boolean QuantMinima(TextBox textBox, ErrorProvider errorProvider)
        {
            if (!String.IsNullOrWhiteSpace(txtQuantidadeMinimaEstoque.Text))
            {
                errorProviderCadastroProduto.SetError(textBox, "");
                return true;
            }
            else
            {
                errorProviderCadastroProduto.SetError(textBox, "Quantidade minima Vazia!");
                return false;
            }

        }
        public FormCadastraProdutos(string NOMESERVIDOR, string NOMEBASEDADOS, string NOMEUSUARIO, string SENHABASEDADOS)
        {
            try
            {
                InitializeComponent();

                this.NomeServidor = NOMESERVIDOR;

                this.NomeBaseDados = NOMEBASEDADOS;

                this.NomeUsuario = NOMEUSUARIO;

                this.SenhaBaseDados = SENHABASEDADOS;

                label13.Text = "Data do último  \n reajuste de preços:";

                label14.Text = "Quantidade \natual em estoque:";

                label15.Text = "Quantidade \nMínima em estoque:";

                label54.Text = "Define as condições de cadastro do produto. Modo que da inicialização\ndo uso do produto de cadastrado.";

                checkBoxnaoImprimir.Text = "Não Imprimir este Produto na Tabela de Preços:";

                dateTimePickerUltimoReajuste.Value = DateTime.Now.Date;

                dateTimePickerSolicitacao.Value = DateTime.Now.Date;

                dateTimePickerPrevisaoChegada.Value = DateTime.Now.Date;

                dateTimePickerDataEntrada.Value = DateTime.Now.Date;

                dateTimePickerCadastroProduto.Value = DateTime.Now.Date;


                this.connetionString = "Data Source=" + this.NomeServidor + ";Initial Catalog=" + this.NomeBaseDados + ";Persist Security Info=True;User ID=" + this.NomeUsuario + ";Password=" + this.SenhaBaseDados + ";";

                AcionarComboBox();

                ////Verifica Itens já cadastrados!
                //SqlConnection conn = new SqlConnection(this.connetionString);

                //SqlDataAdapter da = new SqlDataAdapter("EXEC D_V_ConsultaMarcaProdutoConstaTxt '" + txtCadastroMarca.Text + "';", conn);

                //DataSet ds = new DataSet();
                //da.Fill(ds);

                //conn.Close();

                txtDescriacaoProdutoSistema.MaxLength = 150;

                txtCadastraProduto.MaxLength = 120;
                txtDescricaoProduto.MaxLength = 120;
                txtCadastroMarca.MaxLength = 120;
                txtCadastroDescricaoMarca.MaxLength = 120;
                txtCadastroCategoria.MaxLength = 120;
                txtDescricaoCategoria.MaxLength = 120;
                txtPrecoCusto.MaxLength = 16;
                txtMargemLucro.MaxLength = 7;
                txtCustoMedio.MaxLength = 16;
                txtPrecoVenda.MaxLength = 16;
                txtQuantidadeAtualEstoque.MaxLength = 9;
                txtQuantidadeMinimaEstoque.MaxLength = 9;
                txtPrecoCusto.Text = "0,00";
                txtMargemLucro.Text = "0,00";
                txtCustoMedio.Text = "0,00";
                txtPrecoVenda.Text = "0,00";
                txtPrecoTotalCompra.Text = "0,00";

                this.TempCustoEnter = decimal.Parse(txtPrecoCusto.Text = "0,00");
                this.TempMargemLucroEnter = decimal.Parse(txtMargemLucro.Text = "0,00");
                this.TempVendaEnter = decimal.Parse(txtPrecoVenda.Text = "0,00");

                labelAviso.Text = "Aviso se informa valores para Custo,\nMargem de Lucro e Valor de venda.\nApertar enter para fazer os Cálculo.";

            }
            catch(Exception ex)
            {
                ex.ToString();
            }

        }

        private void FormCadastraProdutos_Load(object sender, EventArgs e)
        {

        }
        public void ObjetosCadastrados()
        {
            SqlConnection conn = new SqlConnection(this.connetionString);

            if ((radioButtonProduto.Checked ==false) && (radioButtonMarca.Checked == false) && (radioButtonCategoria.Checked == false) 
                && (radioButtonFornecedor.Checked == false) && (radioButtonFabricante.Checked == false))
            {
                MessageBox.Show("A pesquisa tem que ter um dos itens na parte de cima selecionado");
            }
            if (radioButtonProduto.Checked == true)
            {
                txtConsultarItens.MaxLength = 120;
                if (txtConsultarItens.Text == "")
                {

                    MessageBox.Show("Sem informação de nome de produto não posso buscar informação!");
                    
                }
                if (!(txtConsultarItens.Text == ""))
                {
                    txtConsultarItens.MaxLength = 120;
                    SqlDataAdapter da1 = new SqlDataAdapter("Exec D_V_ConsultaProdutoNomeProdutoConstaTxt '" + txtConsultarItens.Text +"';", conn);
                    DataSet ds1 = new DataSet();
                    da1.Fill(ds1);

                    conn.Open();

                    if (!(ds1.Tables[0].Rows.Count > 0))
                    {
                        if (dataGridViewObjetosItens.DataSource == null)
                        {
                            dataGridViewObjetosItens.Refresh();
                        }
                        if (!(dataGridViewObjetosItens.DataSource == null))
                        {
                            //dataGridViewPesquisa.Columns.Clear();
                            dataGridViewObjetosItens.Refresh();
                        }
                        label48.Text = "Pesquisa Produtos n°: " + 0;
                        MessageBox.Show("Nem um nome de produto Achado!");

                        conn.Close();
                    }
                    if (ds1.Tables[0].Rows.Count > 0)
                    {
                        ValorPesquisa = 1;
                        dataGridViewPesquisaProdutosNome();
                        label48.Text = "Pesquisa Produtos n°: " + dataGridViewObjetosItens.RowCount.ToString();
                        conn.Close();
                    }
                }
            }
            if (radioButtonMarca.Checked == true)
            {
                txtConsultarItens.MaxLength = 120;

                if (txtConsultarItens.Text == "")
                {
                    MessageBox.Show("Sem informação de marca não posso buscar informação!");
                }
                if (!(txtConsultarItens.Text == ""))
                {
                    txtConsultarItens.MaxLength = 100;
                    SqlDataAdapter da1 = new SqlDataAdapter("Exec D_V_ConsultaMarcaProdutoConstaTxt '" + txtConsultarItens.Text + "';", conn);
                    DataSet ds1 = new DataSet();
                    da1.Fill(ds1);

                    conn.Open();

                    if (!(ds1.Tables[0].Rows.Count > 0))
                    {
                        if (dataGridViewObjetosItens.DataSource == null)
                        {
                            dataGridViewObjetosItens.Refresh();
                        }
                        if (!(dataGridViewObjetosItens.DataSource == null))
                        {
                            //dataGridViewPesquisa.Columns.Clear();
                            dataGridViewObjetosItens.Refresh();
                        }
                        label48.Text = "Pesquisa Marca n°: " + 0;
                        MessageBox.Show("Nem uma marca Achado!");

                        conn.Close();
                    }
                    if (ds1.Tables[0].Rows.Count > 0)
                    {
                        ValorPesquisa = 2;
                        dataGridViewPesquisaMarcasNome();
                        label48.Text = "Pesquisa Marca n°: " + dataGridViewObjetosItens.RowCount.ToString();
                        conn.Close();
                    }
                }
            }
            if (radioButtonCategoria.Checked == true)
            {
                if (txtConsultarItens.Text == "")
                {
                    MessageBox.Show("Sem informação de  categoria não posso buscar informação!");
                }
                if (!(txtConsultarItens.Text == ""))
                {
                    SqlDataAdapter da1 = new SqlDataAdapter("Exec D_V_ConsultaCategoriaProdutoConstaTxt '" + txtConsultarItens.Text + "';", conn);
                    DataSet ds1 = new DataSet();
                    da1.Fill(ds1);

                    conn.Open();

                    if (!(ds1.Tables[0].Rows.Count > 0))
                    {
                        if (dataGridViewObjetosItens.DataSource == null)
                        {
                            dataGridViewObjetosItens.Refresh();
                        }
                        if (!(dataGridViewObjetosItens.DataSource == null))
                        {
                            //dataGridViewPesquisa.Columns.Clear();
                            dataGridViewObjetosItens.Refresh();
                        }
                        label48.Text = "Pesquisa Categoria n°: " + 0;
                        MessageBox.Show("Nem uma categoria Achado!");

                        conn.Close();
                    }
                    if (ds1.Tables[0].Rows.Count > 0)
                    {
                        ValorPesquisa = 3;
                        dataGridViewPesquisaCategoriaNome();
                        label8.Text = dataGridViewObjetosItens.RowCount.ToString();
                        label48.Text = "Pesquisa Categoria n°: " + dataGridViewObjetosItens.RowCount.ToString();
                        conn.Close();

                    }
                }
            }
            if (radioButtonFornecedor.Checked == true)
            {
                if (txtConsultarItens.Text == "")
                {
                    MessageBox.Show("Sem informação de fornecedor não posso buscar informação!");
                }
                if (!(txtConsultarItens.Text == ""))
                {
                    SqlDataAdapter da1 = new SqlDataAdapter("Exec D_V_ConsultaFornecedorCadastroVendaTxt '" + txtConsultarItens.Text + "';", conn);
                    DataSet ds1 = new DataSet();
                    da1.Fill(ds1);

                    conn.Open();

                    if (!(ds1.Tables[0].Rows.Count > 0))
                    {
                        if (dataGridViewObjetosItens.DataSource == null)
                        {
                            dataGridViewObjetosItens.Refresh();
                        }
                        if (!(dataGridViewObjetosItens.DataSource == null))
                        {
                            //dataGridViewPesquisa.Columns.Clear();
                            dataGridViewObjetosItens.Refresh();
                        }
                        label48.Text = "Pesquisa Fornecedor n°: " + 0;
                        MessageBox.Show("Nem um fornecedor Achado!");

                        conn.Close();
                    }
                    if (ds1.Tables[0].Rows.Count > 0)
                    {
                        ValorPesquisa = 4;
                        dataGridViewPesquisaFornecedorNome();
                        label48.Text = "Pesquisa Fornecedor n°: " + dataGridViewObjetosItens.RowCount.ToString();
                        conn.Close();
                    }
                }
            }
            if (radioButtonFabricante.Checked == true)///////////
            {
                if (txtConsultarItens.Text == "")
                {
                    MessageBox.Show("Sem informação de Fabricante não posso buscar informação!");
                }
                if (!(txtConsultarItens.Text == ""))
                {
                    SqlDataAdapter da1 = new SqlDataAdapter("Exec D_V_ConsultaFornecedorCadastroVendaTxt '" + txtConsultarItens.Text + "';", conn);
                    DataSet ds1 = new DataSet();
                    da1.Fill(ds1);

                    conn.Open();

                    if (!(ds1.Tables[0].Rows.Count > 0))
                    {
                        if (dataGridViewObjetosItens.DataSource == null)
                        {
                            dataGridViewObjetosItens.Refresh();
                        }
                        if (!(dataGridViewObjetosItens.DataSource == null))
                        {
                            //dataGridViewPesquisa.Columns.Clear();
                            dataGridViewObjetosItens.Refresh();
                        }
                        label48.Text = "Pesquisa Fornecedor n°: " + 0;
                        MessageBox.Show("Nem um fornecedor Achado!");

                        conn.Close();
                    }
                    if (ds1.Tables[0].Rows.Count > 0)
                    {
                        ValorPesquisa = 4;
                        dataGridViewPesquisaFornecedorNome();
                        label48.Text = "Pesquisa Fornecedor n°: " + dataGridViewObjetosItens.RowCount.ToString();
                        conn.Close();
                    }
                }
            }
        }
        //PRODUTOS

        void dataGridViewPesquisaTodasEntrada()
        {
            try
            {
                string connetionString = (this.connetionString);
                SqlConnection connection = new SqlConnection(connetionString);
                VALORPESQUISA.ToString();

                if (radioButtonProduto.Checked == true)
                {
                    SqlCommand command = new SqlCommand("Exec D_V_ConsultaProdutoNomeProduto;", connection);
                    SqlDataAdapter adapter = new SqlDataAdapter();
                    adapter.SelectCommand = command;
                    TableTodos = new DataTable();
                    adapter.Fill(TableTodos);
                    BindingSource Source = new BindingSource();
                    Source.DataSource = TableTodos;
                    dataGridViewObjetosItens.DataSource = Source;
                    adapter.Update(TableTodos);
                    label48.Text = "Pesquisa Produtos n°: " + dataGridViewObjetosItens.RowCount.ToString();
                    connection.Close();
                }
                if (radioButtonMarca.Checked == true)
                {
                    SqlCommand command = new SqlCommand("Exec D_V_ConsultaMarcaProduto;", connection);
                    SqlDataAdapter adapter = new SqlDataAdapter();
                    adapter.SelectCommand = command;
                    TableTodos = new DataTable();
                    adapter.Fill(TableTodos);
                    BindingSource Source = new BindingSource();
                    Source.DataSource = TableTodos;
                    dataGridViewObjetosItens.DataSource = Source;
                    adapter.Update(TableTodos);
                    label48.Text = "Pesquisa Marca n°: " + dataGridViewObjetosItens.RowCount.ToString();
                    connection.Close();
                }
                if (radioButtonCategoria.Checked == true)
                {
                    SqlCommand command = new SqlCommand("Exec D_V_ConsultaCategoriaProduto;", connection);
                    SqlDataAdapter adapter = new SqlDataAdapter();
                    adapter.SelectCommand = command;
                    TableTodos = new DataTable();
                    adapter.Fill(TableTodos);
                    BindingSource Source = new BindingSource();
                    Source.DataSource = TableTodos;
                    dataGridViewObjetosItens.DataSource = Source;
                    adapter.Update(TableTodos);
                    label48.Text = "Pesquisa Categoria n°: " + dataGridViewObjetosItens.RowCount.ToString();
                    connection.Close();
                }
                if (radioButtonFornecedor.Checked == true)
                {
                    SqlCommand command = new SqlCommand("Exec D_V_ConsultaFornecedorCadastroVenda;", connection);
                    SqlDataAdapter adapter = new SqlDataAdapter();
                    adapter.SelectCommand = command;
                    TableTodos = new DataTable();
                    adapter.Fill(TableTodos);
                    BindingSource Source = new BindingSource();
                    Source.DataSource = TableTodos;
                    dataGridViewObjetosItens.DataSource = Source;
                    adapter.Update(TableTodos);
                    label48.Text = "Pesquisa Fornecedor n°: " + dataGridViewObjetosItens.RowCount.ToString();
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                ex.ToString();
            }

            //DataTable dt = new DataTable();
        }
        //Nome de Produto
        void dataGridViewPesquisaProdutosNome()
        {
            SqlConnection connection = new SqlConnection(this.connetionString);
            SqlCommand command = new SqlCommand("Exec D_V_ConsultaProdutoNomeProdutoConstaTxt '" + txtConsultarItens.Text + "';", connection);
            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = command;
                TableProduto = new DataTable();
                adapter.Fill(TableProduto);
                BindingSource Source = new BindingSource();
                Source.DataSource = TableProduto;
                dataGridViewObjetosItens.DataSource = Source;
                adapter.Update(TableProduto);
                connection.Close();
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
        }
        //MARCAS
        void dataGridViewPesquisaMarcasNome()
        {
            SqlConnection connection = new SqlConnection(this.connetionString);
            SqlCommand command = new SqlCommand("Exec D_V_ConsultaMarcaProdutoConstaTxt '" + txtConsultarItens.Text + "';", connection);
            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = command;
                TableMarca = new DataTable();
                adapter.Fill(TableMarca);
                BindingSource Source = new BindingSource();
                Source.DataSource = TableMarca;
                dataGridViewObjetosItens.DataSource = Source;
                adapter.Update(TableMarca);
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
        }
        //CATEGORIA
        void dataGridViewPesquisaCategoriaNome()
        {
            SqlConnection connection = new SqlConnection(this.connetionString);
            SqlCommand command = new SqlCommand("Exec D_V_ConsultaCategoriaProdutoConstaTxt '" + txtConsultarItens.Text + "';", connection);
            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = command;
                TableCategoria = new DataTable();
                adapter.Fill(TableCategoria);
                BindingSource Source = new BindingSource();
                Source.DataSource = TableCategoria;
                dataGridViewObjetosItens.DataSource = Source;
                adapter.Update(TableCategoria);
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
        }
        //FORNECEDOR
        void dataGridViewPesquisaFornecedorNome()
        {
            SqlConnection connection = new SqlConnection(this.connetionString);
            SqlCommand command = new SqlCommand("Exec D_V_ConsultaFornecedorCadastroVendaTxt '" + txtConsultarItens.Text + "';", connection);
            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = command;
                TableCFornecedor = new DataTable();
                adapter.Fill(TableCFornecedor);
                BindingSource Source = new BindingSource();
                Source.DataSource = TableCFornecedor;
                dataGridViewObjetosItens.DataSource = Source;
                adapter.Update(TableCFornecedor);
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
        public void AcionarComboBox()
        {
            comboBoxDescricaoProduto.Items.Clear();

            Fill_listBoxDescricaoProduto();

            comboBoxMarca.Items.Clear();

            Fill_listBoxMarcaProduto();

            comboBoxCartegoria.Items.Clear();

            Fill_listBoxCategoriaProduto();

            comboBoxFornecedor.Items.Clear();

            Fill_listBoxMarcaFornecedor();

            //Fill_listBoxOrigemProduto();
            comboBoxFabricante.Items.Clear();

            Fill_listBoxFabricanteProduto();         

            comboBoxUnidade.Items.Clear();

            Fill_listBoxUnidade();

            //comboBoxCstIcms.Items.Clear();

            //Fill_listBoxCstIcms();

            //comboBoxCstPis.Items.Clear();

            //Fill_listBoxCstPis();

            //comboBoxCstCofins.Items.Clear();

            //Fill_listBoxCstCofins();

            //comboBoxCstIpI.Items.Clear();

            //kFill_listBoxCstIpi();

        }
        public void AlteraBotoes(int entrada)
        {
            if (entrada == 1)
            {
                txtCodigoProduto.Enabled = false;
                //txtDescricaoProduto.Enabled = false;
                comboBoxCartegoria.Enabled = false;
                comboBoxFornecedor.Enabled = false;
                comboBoxMarca.Enabled = false;
                comboBoxDescricaoProduto.Enabled = false;
                comboBoxFabricante.Enabled = false;
                PainelFinanceiro.Enabled = false;
                PainelFisico.Enabled = false;
                dateTimePickerSolicitacao.Enabled = false;
                buttonCadastraProdutos.Enabled = false;
                checkBoxnaoImprimir.Enabled = false;
                checkBoxAtivo.Enabled = false;
                txtCodigoInterno.Enabled = false;
                buttonCodigoBusca.Enabled = false;
                buttonMarcaECartegoria.Enabled = false;
                txtObservacao.Enabled = false;
                //txtCstIcms.Enabled = false;
                txtNcm.Enabled = false;
                txtBaseIcms.Enabled = false;
                buttonVerifica.Enabled = false;
                buttonCancelarMarcaECartegoria.Enabled = true;
                panelPesquisaObjetos.Enabled = false;
                comboBoxUnidade.Enabled = false;

            }
            if (entrada == 2)
            {
                txtCodigoProduto.Enabled = false;
                txtDescricaoProduto.Enabled = true;
                comboBoxCartegoria.Enabled = true;
                comboBoxFornecedor.Enabled = true;
                comboBoxMarca.Enabled = true;
                comboBoxFabricante.Enabled = true;
                comboBoxDescricaoProduto.Enabled = true;
                PainelFinanceiro.Enabled = true;
                PainelFisico.Enabled = true;
                dateTimePickerSolicitacao.Enabled = true;
                buttonCadastraProdutos.Enabled = true;
                checkBoxnaoImprimir.Enabled = true;
                checkBoxAtivo.Enabled = true;
                txtCodigoInterno.Enabled = true;
                buttonCodigoBusca.Enabled = true;
                buttonMarcaECartegoria.Enabled = true;
                txtObservacao.Enabled = true;
                //txtCstIcms.Enabled = true;
                txtNcm.Enabled = true;
                txtBaseIcms.Enabled = true;
                buttonVerifica.Enabled = true;
                buttonCancelarMarcaECartegoria.Enabled = false;

                comboBoxUnidade.Enabled = true;

               
                comboBoxDescricaoProduto.Items.Clear();

                Fill_listBoxDescricaoProduto();

                comboBoxMarca.Items.Clear();

                Fill_listBoxMarcaProduto();

                comboBoxCartegoria.Items.Clear();

                Fill_listBoxCategoriaProduto();

                comboBoxFornecedor.Items.Clear();

                Fill_listBoxMarcaFornecedor();

                comboBoxFabricante.Items.Clear();

                Fill_listBoxFabricanteProduto();

                comboBoxUnidade.Items.Clear();

                Fill_listBoxUnidade();

            }
            if (entrada == 3)
            {
                txtCadastroMarca.Clear();
                txtCadastroCategoria.Clear();
                txtCadastroDescricaoMarca.Clear();
                txtDescricaoCategoria.Clear();
                txtCadastraProduto.Clear();
                txtDescricaoProduto.Clear();
                txtCadastroFabricante.Clear();
                txtDescricaoFabricante.Clear();
            }
        
            if (entrada == 4)
            {
                buttonSalvarMarcaCategoria.Enabled = true;
                panelCadastraMarcaECartegiria.Enabled = true;
                buttonVerifica.Enabled = false;
                buttonCancelarcadastrousuario.Enabled = true;
                buttonFecharFuncionario.Enabled = true;
            }
            //button cadastra produto
            if (entrada == 5)
            {
                buttonSalvarMarcaCategoria.Enabled = false;
                panelCadastraMarcaECartegiria.Enabled = false;
                buttonVerifica.Enabled = true;
                buttonCancelarcadastrousuario.Enabled = true;
                buttonFecharFuncionario.Enabled = true;
                buttonCancelaProdutos.Enabled = true;
                panelPesquisaObjetos.Enabled = true;
            }
            if(entrada == 6)
            {
                panelCadastraGtin.Enabled = true;
                buttonCadastraGtin.Enabled = false;
                buttonCancelarGtin.Enabled = true;
                CadastraGtin = 1;
            }
            if (entrada == 7)
            {
                panelCadastraGtin.Enabled = false;
                buttonCadastraGtin.Enabled = true;
                buttonCancelarGtin.Enabled = false;
                CadastraGtin = 0;
                txtCodigoGtin.Clear();
                txtPesoBruto.Clear();
                txtPesoBruto.ClearUndo();
                txtPesoLiquido.Clear();
                txtOrigemProduto.Clear();
            }
        }

        private void buttonMarcaECartegoria_Click(object sender, EventArgs e)
        {
            AlteraBotoes(1);
            AlteraBotoes(3);
            AlteraBotoes(4);
        }

        private void buttonCancelarMarcaECartegoria_Click(object sender, EventArgs e)
        {
            AlteraBotoes(2);
            AlteraBotoes(3);
            AlteraBotoes(5);
        }
        private void buttonSalvarMarcaCategoria_Click(object sender, EventArgs e)
        {
            CadastraObjetosItens();
        }
        public void CadastraObjetosItens()
        {
            try
            {
                int contadorObjetos = 0;
                bool ProdutoB = false;
                bool MarcaB = false;
                bool CartegoriaB = false;
                bool FabricanteB = false;

                if (txtCadastraProduto.Text == "")
                {

                }
                if (txtCadastraProduto.Text != "")
                {
                    if (VerificadorProduto() == false)
                    {
                        ProdutoB = true;
                    }
                    else { contadorObjetos++; MessageBox.Show("Já existe um produto com mesmo nome."); }
                }
                if (txtCadastroMarca.Text == "")
                {

                }
                if (txtCadastroMarca.Text != "")
                {
                    if (VerificadorMarca() == false)
                    {
                        MarcaB = true;
                    }
                    else if (VerificadorMarca() == true) { contadorObjetos++; MessageBox.Show("Já consta uma marca com o mesmo nome."); }
                }
                if (txtCadastroCategoria.Text == "")
                {

                }
                if (txtCadastroCategoria.Text != "")
                {
                    if (VerificadorCartegoria() == false)
                    {
                        CartegoriaB = true;
                    }
                    else { contadorObjetos++; MessageBox.Show("Já consta uma Cartegoria com o mesmo nome."); }
                }
                if (txtCadastroFabricante.Text == "")
                {

                }
                if (txtCadastroFabricante.Text != "")
                {
                    if (VerificadorFabricante() == false)
                    {
                        FabricanteB = true;
                    }
                    else { contadorObjetos++; MessageBox.Show("Já consta uma Fabricante com o mesmo nome."); }
                }
                if ((txtCadastraProduto.Text == "") && (txtCadastroMarca.Text == "") && (txtCadastroCategoria.Text == "") && (txtCadastroFabricante.Text == ""))
                {
                    contadorObjetos++; MessageBox.Show("Não podemos salva sem consta nem uma informação passada pelo o usuário.");
                }

                if (contadorObjetos == 0)
                {
                    MarcaECartegoria CadastraMarcaECartegoria = new MarcaECartegoria();

                    string Produto = txtCadastraProduto.Text;
                    string DescricaoProduto = txtDescricaoProduto.Text;
                    string Marca = txtCadastroMarca.Text;
                    string DescricaoMarca = txtCadastroDescricaoMarca.Text;
                    string Categoria = txtCadastroCategoria.Text;
                    string DescricaoCategoria = txtDescricaoCategoria.Text;
                    string Fabricante = txtCadastroFabricante.Text;
                    string DescricaoFabricante = txtDescricaoFabricante.Text;

                    CadastraMarcaECartegoria.Produto = Produto.ToUpper();
                    CadastraMarcaECartegoria.DescricaoProduto = DescricaoProduto.ToUpper();
                    CadastraMarcaECartegoria.Marca = Marca.ToUpper();
                    CadastraMarcaECartegoria.DescricaoMarca = DescricaoMarca.ToUpper();
                    CadastraMarcaECartegoria.Categoria = Categoria.ToUpper();
                    CadastraMarcaECartegoria.DescricaoCategoria = DescricaoCategoria.ToUpper();
                    CadastraMarcaECartegoria.Fabricante = Fabricante.ToUpper();
                    CadastraMarcaECartegoria.DescricaoFabricante = DescricaoFabricante.ToUpper();
                    if (ProdutoB == true)
                    {
                        Conexao conexao4 = new Conexao(this.connetionString);
                        DALCadastro2 da4 = new DALCadastro2(conexao4); //cadastra Produto
                        da4.InserirNomeProduto(CadastraMarcaECartegoria);
                    }
                    if (MarcaB == true)
                    {
                        Conexao conexao6 = new Conexao(this.connetionString);
                        DALCadastro2 dal6 = new DALCadastro2(conexao6); //cadastra marca
                        dal6.InserirMarca(CadastraMarcaECartegoria);
                    }
                    if (CartegoriaB == true)
                    {
                        Conexao conexao = new Conexao(this.connetionString);
                        DALCadastro2 dal = new DALCadastro2(conexao); //cadastra categoria
                        dal.InserirCategoria(CadastraMarcaECartegoria);
                    }
                    if (FabricanteB == true)
                    {
                        Conexao conexao2 = new Conexao(this.connetionString);
                        DALCadastro2 da2 = new DALCadastro2(conexao2); //cadastra Fabricante
                        da2.InserirFabricante(CadastraMarcaECartegoria);
                    }

                    AlteraBotoes(2);
                    AlteraBotoes(3);
                    AlteraBotoes(5);

                    buttonCadastraProdutos.Enabled = false;

                    MessageBox.Show("Dados salvos com sucesso");
                }
            }
            catch(Exception e)
            {
                e.ToString();
            }
        }
        public bool VerificadorProduto()
        {
            try
            {
                bool resultado = false;
                //Verifica Se a Produto já existe produto no sistema!
                SqlConnection conn = new SqlConnection(this.connetionString);

                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Pr_ProdutoNome WHERE NOME = '" + txtCadastraProduto.Text + "';", conn);

                DataSet ds = new DataSet();
                da.Fill(ds);

                if (ds.Tables[0].Rows.Count > 0)
                {
                    resultado = true;
                }
                conn.Close();
                return resultado;
            }
            catch(Exception )
            {
                return true;
            }
        }
        public bool VerificadorMarca()
        {
            try
            {
                bool resultado = false;
                //Verifica Se a Marca já existe no sistema!
                SqlConnection conn = new SqlConnection(this.connetionString);

                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Pr_Marca WHERE NOME = '" + txtCadastroMarca.Text + "';", conn);

                DataSet ds = new DataSet();
                da.Fill(ds);

                if (ds.Tables[0].Rows.Count > 0)
                {
                    resultado = true;
                }
                conn.Close();
                return resultado;
            }
            catch (Exception)
            {
                return true;
            }
        }
        public bool VerificadorCartegoria()
        {
            try
            {
                bool resultado = false;
                //Verifica Se a Cartegoria já existe no sistema!
                SqlConnection conn = new SqlConnection(this.connetionString);

                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Pr_Categoria WHERE NOME = '" + txtCadastroCategoria.Text + "';", conn);

                DataSet ds = new DataSet();
                da.Fill(ds);

                if (ds.Tables[0].Rows.Count > 0)
                {
                    resultado = true;
                }
                conn.Close();
                return resultado;
            }   
            catch (Exception)
            {
                return true;
            }     
        }
        public bool VerificadorFabricante()
        {
            try
            {
                bool resultado = false;
                //Verifica Se a Fabricante já existe no sistema!
                SqlConnection conn = new SqlConnection(this.connetionString);

                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Pr_Fabricante WHERE NOME = '" + txtCadastroFabricante.Text + "';", conn);

                DataSet ds = new DataSet();
                da.Fill(ds);

                if (ds.Tables[0].Rows.Count > 0)
                {
                    resultado = true;
                }
                conn.Close();
                return resultado;
            }
            catch (Exception)
            {
                return true;
            }
        }

        public void QuantidadeProdutoCadastrado()
        {
            SqlConnection conn = new SqlConnection(this.connetionString);

            SqlDataAdapter da = new SqlDataAdapter("EXEC D_V_ConsultaCadastroNProduto ", conn);
            DataSet ds = new DataSet();
            da.Fill(ds);

            if (!(ds.Tables[0].Rows.Count > 0))
            {
                txtCodigoProduto.Text = "Não consta registro de produto no sistema. Primeiro item.";


            }
            if (ds.Tables[0].Rows.Count > 0)
            {
                string numero = ds.Tables[0].Rows[0][0].ToString(); ;

                if (ds.Tables[0].Rows.Count == 1)
                {
                    txtCodigoProduto.Text = "No registro consta N° " + numero.ToString() + " item cadastrado.";
                }
                else { txtCodigoProduto.Text = "No registro consta N° " + numero.ToString() + " itens cadastrados."; }
            }
        }
        public void NumeroProdutoCadastrado()
        {
            SqlConnection conn = new SqlConnection(this.connetionString);

            SqlDataAdapter da = new SqlDataAdapter("EXEC D_V_ConsultaCadastroNProdutoProximo ", conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            int idProduto = 0;

            if (!(ds.Tables[0].Rows.Count > 0))
            {
                idProduto = 1;
                txtCodigoProduto.Text = "Sem Registro!";
            }
            if (ds.Tables[0].Rows.Count > 0)
            {
                int soma = ds.Tables[0].Rows.Count;

                idProduto = 1 + soma;

                txtCodigoProduto.Text = " N° " + idProduto.ToString() +".";
            }
        }

        private void buttonCadastraProdutos_Click(object sender, EventArgs e)
        {
            try
            {
                panelGeral.Enabled = true;
                buttonLimpaValores.Enabled = true;
                buttonCadastraProdutos.Enabled = false;
                AlteraBotoes(5);

                QuantidadeProdutoCadastrado();
                //NumeroProdutoCadastrado();

                txtDescriacaoProdutoSistema.Enabled = true;
            }
            catch
            {
                MessageBox.Show(" ERR.: " + e.ToString());
            }


        }

        private void buttonCancelaProdutos_Click(object sender, EventArgs e)
        {
            FecharTodosFormulario();

            FormCadastraProdutos cadastracliente = new FormCadastraProdutos(this.NomeServidor, this.NomeBaseDados, this.NomeUsuario, this.SenhaBaseDados);
            cadastracliente.MdiParent = FormCadastraProdutos.ActiveForm;
            cadastracliente.Show();
            cadastracliente.Top = 0;
            cadastracliente.Left = 0;
        }
        public static void Moeda(ref TextBox txt)
        {
            string n = string.Empty;

            double v = 0;

            try
            {
                n = txt.Text.Replace(",", "").Replace(".", "");
                if (n.Equals(""))
                    n = "";
                n = n.PadLeft(3, '0');
                if (n.Length > 3 & n.Substring(0, 1) == "0")
                    n = n.Substring(1, n.Length - 1);
                v = Convert.ToDouble(n) / 100;
                txt.Text = string.Format("{0:N}", v);
                txt.SelectionStart = txt.Text.Length;
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro" + e);
            }
        }
        public static void Moeda2(ref TextBox txt)
        {
            string n = string.Empty;

            double v = 0;

            try
            {
                n = txt.Text.Replace(",", "").Replace(".", "");
                if (n.Equals(""))
                    n = "";
                n = n.PadLeft(3, '0');
                if (n.Length > 3 & n.Substring(0, 1) == "0")
                    n = n.Substring(1, n.Length - 1);
                v = Convert.ToDouble(n) / 100;
                txt.Text = string.Format("{0:F}", v);
                txt.SelectionStart = txt.Text.Length;
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro" + e);
            }
        }
        public static string ConverterValores(string VALORES)
        {
            try
            {
                string Entrada = VALORES;

                if (Entrada == "0,00")
                {
                    return "0,00";   
                }
                if (Entrada != "0,00")
                {
                    string ConversaoValores = VALORES;

                    Boolean finalizador = false;

                    while (finalizador == false)
                    {
                        int i = 0;

                        StringBuilder sb = new StringBuilder(VALORES);

                        int quantString = VALORES.Length;

                        string StringTeste = VALORES;


                        //QUEBRA DE LINHA SE FOR MAS QUE UMA LINHA
                        for (i = 0; i <= quantString - 1; i++)
                        {
                            if (StringTeste[i] == '.')
                            {
                                sb.Remove(i, 1);
                                VALORES = sb.ToString();
                                finalizador = false;
                                break;
                            }
                            if (!(StringTeste[i] == '.'))
                            {
                                finalizador = true;
                                ConversaoValores = sb.ToString();
                            }
                        }
                    }
                    return VALORES = ConversaoValores;
                }
                return VALORES;
            }

            catch (Exception exp)
            {
                return exp.ToString();
            }
        }
        public static string ConverterValores2(string VALORES)
        {
            try
            {
                string Entrada = VALORES;

                if (Entrada == "0,00")
                {
                   return VALORES = "0,00";
                }
                if (Entrada != "0,00")
                {
                    string ConversaoValores = VALORES;

                    Boolean finalizador = false;

                    while (finalizador == false)
                    {
                        int i = 0;

                        StringBuilder sb = new StringBuilder(VALORES);

                        int quantString = VALORES.Length;

                        string StringTeste = VALORES;


                        //QUEBRA DE LINHA SE FOR MAS QUE UMA LINHA
                        for (i = 0; i <= quantString - 1; i++)
                        {
                            if (StringTeste[i] == '.')
                            {
                                sb.Remove(i, 1);
                                VALORES = sb.ToString();
                                finalizador = false;
                                break;
                            }
                            if (!(StringTeste[i] == '.'))
                            {
                                finalizador = true;
                                ConversaoValores = sb.ToString();
                            }
                        }
                    }
                    return VALORES = ConversaoValores;
                }
                return VALORES;
            }

            catch (Exception exp)
            {
                return exp.ToString();
            }
        }
        public static string AdicionadoVZ(string VALORES)
        {
            try
            {

                StringBuilder sb = new StringBuilder(VALORES);

                int quantString = VALORES.Length;

                sb.Insert(2, ",00");

                VALORES = sb.ToString();

                return VALORES;
            }

            catch (Exception exp)
            {
                return exp.ToString();
            }
        }
        private void txtPrecoCusto_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Se a tecla digitada não for número
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08 && !(e.KeyChar == ','))
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }
            if (e.KeyChar == 13)
            {
                //string preco = VerificarVirgula(txtPrecoCusto.Text);

                txtPrecoTotalCompra.Text = txtCustoMedio.Text = txtPrecoCusto.Text;

                TempCustoEnter = decimal.Parse(txtPrecoCusto.Text);

                txtCustoMedio.TextAlign = HorizontalAlignment.Right;
                txtPrecoTotalCompra.TextAlign = HorizontalAlignment.Right;

                txtMargemLucro.Clear();
                txtPrecoVenda.Clear();

                SendKeys.Send("{Tab}");

            }
        }

        private void txtCustoMedio_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Se a tecla digitada não for número
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }                
        }

        private void txtPrecoVenda_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Se a tecla digitada não for número
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08 && !(e.KeyChar == ','))
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }
            //Se a tecla digitada não for número
            if (e.KeyChar == 13)
            {
                try
                {
                    if (!(txtPrecoCusto.Text == "") && !(txtPrecoVenda.Text == ""))
                    {
                        string Primeiro = "";
                        string Segundo = "";

                        Segundo = ConverterValores(txtPrecoCusto.Text);
                        Primeiro = ConverterValores(txtPrecoVenda.Text);
                        TempCustoEnter = decimal.Parse(Segundo);

                        decimal PrecoVendido = decimal.Parse(Primeiro);
                        decimal PrecoCusto = decimal.Parse(Segundo);

                        if (PrecoVendido > PrecoCusto)
                        {
                            decimal menos = (PrecoVendido - PrecoCusto);
                            decimal dividr = (menos / PrecoCusto) * 100;
                            DividaTemp = dividr;

                            txtMargemLucro.Clear();
                            txtMargemLucro.Text = String.Format("{0:0,0.00}", DividaTemp);

                            TempMargemLucroEnter = decimal.Parse(txtMargemLucro.Text);

                            string TempConversao = String.Format("{0:0,0.00}", Primeiro);
                            TempVendaEnter = decimal.Parse(TempConversao);

                            Moeda(ref txtMargemLucro);
                            txtMargemLucro.TextAlign = HorizontalAlignment.Right;
                            txtPrecoTotalCompra.Text = txtPrecoVenda.Text;
                        }
                        if ((PrecoVendido == PrecoCusto) || (PrecoVendido < PrecoCusto))
                        {
                            txtMargemLucro.Text = "0,00";
                            txtPrecoTotalCompra.Text = txtPrecoCusto.Text;
                            txtMargemLucro.TextAlign = HorizontalAlignment.Right;
                        }

                        SendKeys.Send("{Tab}");
                        SendKeys.Send("{Tab}");
                    }
                }
                catch (Exception ex)
                {
                    ex.ToString();
                }
            }
        }

        private void txtMargemLucro_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Se a tecla digitada não for número
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }
            //Se a tecla digitada não for número
            if (e.KeyChar == 13)
            {
                try
                {
                    if (!(txtPrecoCusto.Text == "") && !(txtMargemLucro.Text == ""))
                    {
                        decimal txtPrecoCustoc1 = decimal.Parse (txtPrecoCusto.Text);
                        decimal txtMargemLucro1 = decimal.Parse(txtMargemLucro.Text);
                        decimal pocent = 0;
                        decimal calcula = 0;


                        if (txtPrecoCustoc1 > 0)
                        {
                            pocent = txtMargemLucro1 / 100;

                            calcula = (txtPrecoCustoc1 * pocent) + txtPrecoCustoc1;

                            TempMargemLucroEnter = txtMargemLucro1;
                      
                            txtPrecoVenda.Text = String.Format("{0:0,0.00}", calcula);

                            txtPrecoTotalCompra.Text = String.Format("{0:0,0.00}", calcula);

                            TempVendaEnter = decimal.Parse(txtPrecoVenda.Text);

                            txtPrecoTotalCompra.TextAlign = HorizontalAlignment.Right;
                            txtPrecoVenda.TextAlign = HorizontalAlignment.Right;
                        }
                        SendKeys.Send("{Tab}");
                    }
                }
                catch (Exception ex)
                {
                    ex.ToString();
                }
            }
        }

        private void txtQuantidadeAtualEstoque_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Se a tecla digitada não for número
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }
            if (e.KeyChar == 13)
            {
                try
                {
                   // CalculaValorTotal();
                    SendKeys.Send("{Tab}");
                }
                catch (Exception ex)
                {
                    ex.ToString();
                }
            }
        }

        private void txtQuantidadeMinimaEstoque_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Se a tecla digitada não for número
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }
        }

        private void txtCódigoInterno_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Se a tecla digitada não for número
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }
            //Se a tecla digitada não for número
            if (e.KeyChar == 13)
            {
                txtNcm.Text = txtCodigoInterno.Text;
            }
        }

        private void txtMargemLucro_TextChanged(object sender, EventArgs e)
        {
            Moeda2(ref txtMargemLucro);
            txtMargemLucro.TextAlign = HorizontalAlignment.Right;
            //txtMargemLucro.Text = VerificarVirgula(txtMargemLucro.Text);

        }
        //public static string VerificarVirgula(string ENTRADA)
        //{
        //    try
        //    {
        //        string Valores = ENTRADA;
        //        int cont = 0;

        //        StringBuilder sb = new StringBuilder(ENTRADA);

        //        int quantString = ENTRADA.Length;

        //      for(int i = 0; i < quantString; i++)
        //        {
        //            if(Valores[i] == ',')
        //            {
        //                cont++;
        //            }
        //            if(cont > 1)
        //            {
        //                sb.Remove(i, 1);
        //                cont--;
        //                ENTRADA = sb.ToString();
        //            }
        //        }

        //        return ENTRADA;
        //    }
        //    catch (Exception exp)
        //    {
        //        return exp.ToString();
        //    }
        //}
        //public static string DuasCasasDecimal(string ENTRADA1)
        //{
        //    try
        //    {
        //        string Valores = Convert.ToString(ENTRADA1);
        //        string ENTRADA = Convert.ToString(ENTRADA1);

                

        //        StringBuilder sb = new StringBuilder(ENTRADA);

        //        int quantString = ENTRADA.Length;

        //        for (int i = 0; i < quantString; i++)
        //        {
        //            if (Valores[i] == ',')
        //            {
        //                sb.Remove(i+2,quantString - (i+3));

        //                ENTRADA1 = sb.ToString();

        //                return ENTRADA1;               
        //            }
        //        }
        //        return ENTRADA1;
        //    }
        //    catch (Exception exp)
        //    {
        //        exp.ToString();
        //        return ENTRADA1;
        //    }
        //}
        public static string TresCasasDecimal(string ENTRADA)
        {
            try
            {
                string Valores = ENTRADA;

                StringBuilder sb = new StringBuilder(ENTRADA);

                int quantString = ENTRADA.Length;

                for (int i = 0; i < quantString; i++)
                {
                    if (Valores[i] == '.')
                    {
                        if (i + 3 < quantString)
                        {
                            sb.Remove(i + 4, quantString);
                            ENTRADA = sb.ToString();
                            return ENTRADA;
                        }
                    }
                }
                return ENTRADA;
            }
            catch (Exception exp)
            {
                exp.ToString();

                return ENTRADA;
            }
        }
        public static string ReajustaValoresSql(string ENTRADA)
        {
            try
            {
                string Valores = ENTRADA;

                StringBuilder sb = new StringBuilder(ENTRADA);

                int quantString = ENTRADA.Length;

                sb.Replace(',', '.');

                ENTRADA = sb.ToString();

                return ENTRADA;
            }
            catch (Exception exp)
            {
                return exp.ToString();
            }
        }
        private void txtPrecoVenda_TextChanged(object sender, EventArgs e)
        {
            Moeda(ref txtPrecoVenda);
            txtPrecoVenda.TextAlign = HorizontalAlignment.Right;
        }
        //Metodos de Validações de Salvar Arquivo --------------------------------------------------------------------------\\
        public static int DefinirSalvarProduto(Boolean checkBoxDataSolicitacao,Boolean checkBoxDataVencimento,
           Boolean checkBoxDataFabricacao, Boolean checkBoxDataEntrada,Boolean checkBoxInicializarEstoque)
        {
            if ((checkBoxDataSolicitacao == false) && (checkBoxDataVencimento == false) && (checkBoxDataFabricacao == false) 
                && (checkBoxDataEntrada == false) && checkBoxInicializarEstoque ==false)
            {
                return 0;
            }
            if ((checkBoxDataSolicitacao == false) && (checkBoxDataVencimento == false) && (checkBoxDataFabricacao == false)
            && (checkBoxDataEntrada == false) && checkBoxInicializarEstoque == true)
            {
                return 1;
            }


            return -1;
        }
        private void buttonVerifica_Click(object sender, EventArgs e)
        {
            SalvaProduto();
        }
        public void SalvaProduto()
        {
            try
            {
                int contador = 0;

                if (txtDescriacaoProdutoSistema.Text == "")
                {
                    MessageBox.Show("Descrição de Produto não pode está em branco!");
                }
                else if (txtDescriacaoProdutoSistema.Text != "")
                {
                    //Verifica Se a Marca é Valida no sistema!
                    SqlConnection conn4 = new SqlConnection(this.connetionString);

                    SqlDataAdapter da4 = new SqlDataAdapter("SELECT DECRICAO_PRODUTO FROM Pr_Produto WHERE DECRICAO_PRODUTO = '" + txtDescriacaoProdutoSistema.Text + "';", conn4);
                    IdDescricaoProduto.ToString();
                    DataSet ds4 = new DataSet();
                    da4.Fill(ds4);
                    conn4.Open();

                    if (ds4.Tables[0].Rows.Count > 0)
                    {
                        MessageBox.Show("Já consta uma descrição de produto com o mesmo nome.");
                        contador++;
                        conn4.Close();
                    }
                    if (!(ds4.Tables[0].Rows.Count > 0))
                    {
                        conn4.Close();

                        if (comboBoxDescricaoProduto.Text == "")
                        {
                            MessageBox.Show("Selecione uma descrição do produto!");
                            contador++;
                        }
                        else if (comboBoxCartegoria.Text == "")
                        {
                            MessageBox.Show("Selecione uma Categoria!");
                            contador++;
                        }
                        else if (comboBoxFornecedor.Text == "")
                        {
                            MessageBox.Show("Selecione uma Fornecedor!");
                            contador++;
                        }
                        else if (comboBoxMarca.Text == "")
                        {
                            MessageBox.Show("Selecione uma Marca!");
                            contador++;
                        }
                        else if (comboBoxFabricante.Text == "")
                        {
                            MessageBox.Show("Selecione uma Fabricante!");
                            contador++;
                        }
                        else if (comboBoxUnidade.Text == "")
                        {
                            MessageBox.Show("Selecione uma Unidade!");
                            contador++;
                        }

                        if (!(comboBoxDescricaoProduto.Text == "") && !(comboBoxCartegoria.Text == "") &&
                            !(comboBoxFornecedor.Text == "") && !(comboBoxMarca.Text == "") && !(comboBoxFabricante.Text == "") &&
                            !(comboBoxUnidade.Text == ""))
                        {
                            //Cadastra novo Produto
                            CadastraProdutos CadastraProdutosNovo = new CadastraProdutos();

                            //Combobox ---------------------
                            CadastraProdutosNovo.DescriacaoProduto = txtDescriacaoProdutoSistema.Text;
                            CadastraProdutosNovo.IdProdutoDescricao = IdDescricaoProduto;
                            CadastraProdutosNovo.IdMarca = IdMarcaProduto;
                            CadastraProdutosNovo.IdCategoriaProduto = IdMarcaProdutoCategoria;
                            CadastraProdutosNovo.IdFornecedor = IdMarcaFornecedor;
                            CadastraProdutosNovo.IdFabricanteProduto = IdFabricanteFornecedor;
                            CadastraProdutosNovo.IdUnidadeProduto = IdUnidadeProduto;

                            //VALORES SEM DEFINIDO NA TELA DE CADASTRO--------------
                            CadastraProdutosNovo.IdIDetalheVenda = 0;
                            CadastraProdutosNovo.IdItemVenda = 0;

                            //ConverterValores
                            //Paine Geral Esquerda
                            //Painel Financeiro


                            //Data de Reajuste
                            CadastraProdutosNovo.DataCadastro = Convert.ToDateTime(dateTimePickerCadastroProduto.Value.Date.ToString("dd/MM/yyyy"));                            

                            if (checkBoxDataSolicitacao.Checked == true)
                            {
                                CadastraProdutosNovo.DataSolicitacao = Convert.ToDateTime(dateTimePickerSolicitacao.Value.Date.ToString("dd/MM/yyyy"));
                                CadastraProdutosNovo.AdicionarDataSolicitacao = 1;
                            }
                            if (checkBoxDataVencimento.Checked == true)
                            {
                                CadastraProdutosNovo.DataVencimento = Convert.ToDateTime(dateTimePickerVencimento.Value.Date.ToString("dd/MM/yyyy"));
                                CadastraProdutosNovo.AdicionarDataVencimento = 1;
                            }
                            if (checkBoxDataFabricacao.Checked == true)
                            {
                                CadastraProdutosNovo.DataFabricacao = Convert.ToDateTime(dateTimePickerFabricacao.Value.Date.ToString("dd/MM/yyyy"));
                                CadastraProdutosNovo.AdicionarDataFabricacao = 1; ;
                            }
                            if (checkBoxDataEntrada.Checked == true)
                            {
                                CadastraProdutosNovo.DataEntradaProduto = Convert.ToDateTime(dateTimePickerDataEntrada.Value.Date.ToString("dd/MM/yyyy"));
                                CadastraProdutosNovo.AdicionarDataEntrada = 1;

                                CadastraProdutosNovo.Data_Compra = Convert.ToDateTime(dateTimePickerDataEntrada.Value.Date.ToString("dd/MM/yyyy"));
                                CadastraProdutosNovo.AdicionarDataCompra = 1;
                            }
                            if (this.CadastraGtin == 1)
                            {
                                CadastraProdutosNovo.PrevisaoChegada = Convert.ToDateTime(dateTimePickerUltimoReajuste.Value.Date.ToString("dd/MM/yyyy"));
                                CadastraProdutosNovo.AdicionarPrevisaoChegada = 1;
                            }


                            //CadastraProdutosNovo.DataReajuste = Convert.ToDateTime(dateTimePickerUltimoReajuste.Value.Date.ToString("dd/MM/yyyy"));
                            CadastraProdutosNovo.AdicionarDataReajuste = 0;

                            //painel Fisico
                            CadastraProdutosNovo.Quant_Estoque = int.Parse(txtQuantidadeAtualEstoque.Text);
                            CadastraProdutosNovo.Quant_Minima = int.Parse(txtQuantidadeMinimaEstoque.Text);
                            CadastraProdutosNovo.QuantComprada = int.Parse(txtQuantidadeAtualEstoque.Text);

           

                            //Paine Geral parte de baixo Data de compra
                            if (txtPrecoCusto.Text != "0,00")
                            {
                                //Verificar o Contador2 do sistema---------------------------
                                decimal TempCustoEntrada = decimal.Parse(txtPrecoCusto.Text);

                                //Verificador e os valores estão corretos com temporários
                                if (!this.TempCustoEnter.Equals(TempCustoEntrada))
                                {
                                    MessageBox.Show("As informações salvas no campo preço de custo não estão corretas! ");
                                    contador++;
                                }
                            }
                            if (txtMargemLucro.Text != "0,00")
                            {
                                decimal TempLucroEntrada = decimal.Parse(txtMargemLucro.Text);

                                if (!this.TempMargemLucroEnter.Equals(TempLucroEntrada))
                                {
                                    MessageBox.Show("As informações salvas no campo margem de lucro não estão corretas! ");
                                    contador++;
                                }
                            }
                            if (txtPrecoVenda.Text != "0,00")
                            {
                                decimal TempVendaEntrada = decimal.Parse(txtPrecoVenda.Text);

                                if (!this.TempVendaEnter.Equals(TempVendaEntrada))
                                {
                                    MessageBox.Show("As informações salvas no campo preço de venda não estão corretas! ");
                                    contador++;
                                }
                            }
                            if(checkBoxInicializarEstoque.Checked == true)
                            {
                                if ((CadastraProdutosNovo.Quant_Minima <= 0) || (CadastraProdutosNovo.Quant_Estoque <= 0))
                                {
                                    MessageBox.Show("Quantidade minima e quantidade em estoque não podem ser negativas.");
                                    contador++;
                                }
                                if (CadastraProdutosNovo.Quant_Minima > CadastraProdutosNovo.Quant_Estoque)
                                {
                                    MessageBox.Show("Quantidade minima não pode se maior que a quantidade em estoque.");
                                    contador++;
                                }
                            }
                            if (checkBoxInicializarEstoque.Checked == false)
                            {
                                if (CadastraProdutosNovo.Quant_Minima <= 0) 
                                {
                                    MessageBox.Show("Quantidade minima não podem ser negativas e nem zero.");
                                    contador++;
                                }
                            }
                                                        
                            //Verificar ID Estoque inicial 0
                            CadastraProdutosNovo.IdEstoque = 0;

                            //Painel Geral direito
                            if (checkBoxnaoImprimir.Checked == true)
                            {
                                CadastraProdutosNovo.ImprimirProduto = 1;
                            }
                            else CadastraProdutosNovo.ImprimirProduto = 2;
                            if (checkBoxAtivo.Checked == true)
                            {
                                CadastraProdutosNovo.Ativo = 1;
                            }
                            else CadastraProdutosNovo.Ativo = 2;
                            //Verificar codigo do NCM
                            if (txtCodigoInterno.Text == "")
                            {
                                CadastraProdutosNovo.Ncm = 0;
                            }
                            else CadastraProdutosNovo.Ncm = int.Parse(txtNcm.Text);
                            //Verificar codigo do Produto Cadastro
                            if (txtCodigoInterno.Text == "")
                            {
                                CadastraProdutosNovo.CodInterno = 0;
                            }
                            else CadastraProdutosNovo.CodInterno = int.Parse(txtCodigoInterno.Text);

                            CadastraProdutosNovo.Documento = txtDocumento.Text;
                           //tabControlNiveis Observação
                            CadastraProdutosNovo.Observacao = txtObservacao.Text;

                            //tabControlNiveis Dados Fiscais
                            //CST ICMS
                            if (comboBoxCstIcms.Text == "")
                            {
                                CadastraProdutosNovo.IdCstIcms = 0;
                            }
                            else if (comboBoxCstIcms.Text == "")
                            {
                                CadastraProdutosNovo.IdCstIcms = IdCstIcms;
                                if (txtBaseIcms.Text != "")
                                {
                                    string BaseCalculoIcmsS = ConverterValores(txtBaseIcms.Text);
                                    CadastraProdutosNovo.BaseCalculoIcms = BaseCalculoIcmsS;
                                }
                            }
                            //CST PIS
                            if (comboBoxCstPis.Text == "")
                            {
                                CadastraProdutosNovo.IdCstPis = 0;
                            }
                            else CadastraProdutosNovo.IdCstPis = IdCstPis;
                            if (txtDescricaoCstPis.Text != "")
                            {
                                string DescricaoCstPis = ConverterValores(txtDescricaoCstPis.Text);
                                CadastraProdutosNovo.DescricaoCstPis = DescricaoCstPis;
                            }
                            if (txtPis.Text != "")
                            {
                                string CstPisS = ConverterValores(txtPis.Text);
                                CadastraProdutosNovo.ValorPis = CstPisS;
                            }
                            //CST CONFINS
                            if (comboBoxCstCofins.Text == "")
                            {
                                CadastraProdutosNovo.IdCstCofins = 0;
                            }
                            else CadastraProdutosNovo.IdCstCofins = IdCstCofins;
                            if (txtDescricaoCofins.Text != "")
                            {
                                string DescricaoCofins = ConverterValores(txtDescricaoCofins.Text);
                                CadastraProdutosNovo.DescricaoCofins =DescricaoCofins;
                            }
                            if (txtConfins.Text != "")
                            {
                                string Confins = ConverterValores(txtConfins.Text);
                                CadastraProdutosNovo.ValorCofins = Confins;
                            }
                            //CST IPI
                            if (comboBoxCstIpI.Text == "")
                            {
                                CadastraProdutosNovo.IdCstIpi = 0;
                            }
                            else CadastraProdutosNovo.IdCstIpi = IdCstIpi;
                            if (txtDescricaoIpI.Text != "")
                            {
                                string DescricaoIpI = ConverterValores(txtDescricaoIpI.Text);
                                CadastraProdutosNovo.DescricaoCstIpi = DescricaoIpI;
                            }
                            if (txtIpi.Text != "")
                            {
                                string Ipi = ConverterValores(txtIpi.Text);
                                CadastraProdutosNovo.ValorIpi = Ipi;
                            }
                            else CadastraProdutosNovo.ValorIpi = "";
                            //tabControlNiveis Outros tanto para CadastraGtin 0 ou 1.
                            if (CadastraGtin == 0)
                            {
                                CadastraProdutosNovo.CodigoGtin = 0;
                            }
                            if (CadastraGtin == 1)
                            {
                                if (txtCodigoGtin.Text == "")
                                {
                                    CadastraProdutosNovo.CodigoGtin = 0;
                                }
                                else CadastraProdutosNovo.CodigoGtin = int.Parse(txtCodigoGtin.Text);

                                if (txtPesoBruto.Text != "")
                                {
                                    string PesoBrutoS = ConverterValores(txtPesoBruto.Text);
                                    CadastraProdutosNovo.PesoBruto = PesoBrutoS;
                                }
                                if (txtPesoLiquido.Text != "")
                                {
                                    string PesoLiquidoS = ConverterValores(txtPesoLiquido.Text);
                                    CadastraProdutosNovo.PesoLiquido = PesoLiquidoS;
                                }

                                CadastraProdutosNovo.PrevisaoChegada = Convert.ToDateTime(dateTimePickerPrevisaoChegada.Value.Date.ToString("dd/MM/yyyy"));

                                if (txtOrigemProduto.Text != "")
                                {
                                    CadastraProdutosNovo.OrigemProduto = txtOrigemProduto.Text;
                                }
                            }
                            //tabControlNiveis Foto
                            ProdutoImagem ImagemProduto = new ProdutoImagem();
                            ProdutoImagem2 ImagemProduto2 = new ProdutoImagem2();


                            //tabControlNiveis 5
                            if (contador != 0)
                            {
                                MessageBox.Show("Não podemos salvar no sistema!");
                            }

                            if (contador == 0)
                            {
                                Conexao conexao = new Conexao(this.connetionString);

                                //Salvar Cadastro de Produto no sistema

                                if (txtPrecoCusto.Text == "0,00")
                                {
                                    CadastraProdutosNovo.PrecoCusto = "";
                                }
                                if (txtPrecoCusto.Text != "0,00")
                                {
                                    string PrecoCustoS = ConverterValores(txtPrecoCusto.Text);
                                    CadastraProdutosNovo.PrecoCusto = ReajustaValoresSql(PrecoCustoS);
                                }
                                if (txtCustoMedio.Text == "0,00")
                                {
                                    CadastraProdutosNovo.PrecoMedio = "";
                                }
                                if (txtCustoMedio.Text != "0,00")
                                {
                                    string PrecoMedioS = ConverterValores(txtCustoMedio.Text);
                                    CadastraProdutosNovo.PrecoMedio = ReajustaValoresSql(PrecoMedioS);
                                }
                                if (txtPrecoVenda.Text == "0,00")
                                {
                                    CadastraProdutosNovo.PrecoVenda = "";
                                }
                                if (txtPrecoVenda.Text != "0,00")
                                {
                                    string PrecoVendaS = ConverterValores(txtPrecoVenda.Text);
                                    CadastraProdutosNovo.PrecoVenda = ReajustaValoresSql(PrecoVendaS);
                                }
                                if (txtMargemLucro.Text == "0,00")
                                {
                                    CadastraProdutosNovo.MargemLucro = "";
                                }
                                if (txtMargemLucro.Text != "0,00")
                                {
                                    string MargemLucroS = ConverterValores(txtMargemLucro.Text);
                                    CadastraProdutosNovo.MargemLucro = ReajustaValoresSql(MargemLucroS);
                                }
                                if (txtPrecoTotalCompra.Text == "0,00")
                                {
                                    CadastraProdutosNovo.ValorTotal = "";
                                }
                                if (txtPrecoTotalCompra.Text != "0,00")
                                {
                                    string ValorTotal = ConverterValores(txtPrecoTotalCompra.Text);
                                    CadastraProdutosNovo.ValorTotal = ReajustaValoresSql(ValorTotal);
                                }

                                if (checkBoxInicializarEstoque.Checked == false)
                                {
                                    DialogResult dialogResultImprimir = MessageBox.Show("Deseja Salvar?", "Aviso", MessageBoxButtons.YesNo);
                                    if (dialogResultImprimir == DialogResult.Yes)
                                    {
                                        DALCadastro2 da = new DALCadastro2(conexao);
                                        da.InserirProduto(CadastraProdutosNovo);

                                        if ((checkBoxDataSolicitacao.Checked == true) || (checkBoxDataFabricacao.Checked == true) ||
                                                (checkBoxDataVencimento.Checked == true) || (checkBoxDataEntrada.Checked == true))
                                        {
                                            //Salvar Cadastro de Produto no Estoque
                                            Conexao conexaoE = new Conexao(this.connetionString);
                                            DALCadastro2 daE = new DALCadastro2(conexao);

                                            daE.InserirEstoque(CadastraProdutosNovo);

                                            if (CadastraGtin == 0)
                                            {

                                            }
                                            if (CadastraGtin == 1)
                                            {
                                                //Salvar Cadastro de Produto no Estoque item sem produto
                                                Conexao conexaoEI = new Conexao(this.connetionString);
                                                DALCadastro2 daEI = new DALCadastro2(conexaoEI);

                                                CadastraProdutosNovo.QuantComprada = 0;
                                                CadastraProdutosNovo.PrecoCusto = "";
                                                CadastraProdutosNovo.PrecoMedio = "";
                                                CadastraProdutosNovo.PrecoVenda = "";
                                                CadastraProdutosNovo.MargemLucro = "";
                                                CadastraProdutosNovo.AdicionarDataCompra = 0;
                                                CadastraProdutosNovo.Quant_Estoque = 0;
                                                CadastraProdutosNovo.AdicionarDataFabricacao = 0;
                                                CadastraProdutosNovo.AdicionarDataVencimento = 0;
                                                CadastraProdutosNovo.AdicionarDataEntrada = 0;
                                                CadastraProdutosNovo.AdicionarDataSolicitacao = 0;
                                                CadastraProdutosNovo.AdicionarPrevisaoChegada = 1;//
                                                CadastraProdutosNovo.IdCstIcms = 0;
                                                CadastraProdutosNovo.DescricaoCstIcms = "";
                                                CadastraProdutosNovo.ValorIcms = "";
                                                CadastraProdutosNovo.IdCstPis = 0;
                                                CadastraProdutosNovo.DescricaoCstPis = "";
                                                CadastraProdutosNovo.ValorPis = "";
                                                CadastraProdutosNovo.IdCstCofins = 0;
                                                CadastraProdutosNovo.DescricaoCofins = "";
                                                CadastraProdutosNovo.ValorCofins = "";
                                                CadastraProdutosNovo.IdCstIpi = 0;
                                                CadastraProdutosNovo.DescricaoCstIpi = "";
                                                CadastraProdutosNovo.ValorIpi = "";
                                                CadastraProdutosNovo.CodigoGtin = 0;
                                                CadastraProdutosNovo.PesoBruto = "";
                                                CadastraProdutosNovo.PesoLiquido = "";
                                                CadastraProdutosNovo.OrigemProduto = "";

                                                daEI.InserirEstoqueItem(CadastraProdutosNovo);
                                            }
                                        }else
                                        {
                                            if (CadastraGtin == 0)
                                            {

                                            }
                                            if (CadastraGtin == 1)
                                            {


                                                CadastraProdutosNovo.QuantComprada = 0;
                                                CadastraProdutosNovo.PrecoCusto = "";
                                                CadastraProdutosNovo.PrecoMedio = "";
                                                CadastraProdutosNovo.PrecoVenda = "";
                                                CadastraProdutosNovo.MargemLucro = "";
                                                CadastraProdutosNovo.AdicionarDataCompra = 0;
                                                CadastraProdutosNovo.Quant_Estoque = 0;
                                                CadastraProdutosNovo.AdicionarDataFabricacao = 0;
                                                CadastraProdutosNovo.AdicionarDataVencimento = 0;
                                                CadastraProdutosNovo.AdicionarDataEntrada = 0;
                                                CadastraProdutosNovo.AdicionarDataSolicitacao = 0;
                                                CadastraProdutosNovo.AdicionarPrevisaoChegada = 1;//
                                                CadastraProdutosNovo.IdCstIcms = 0;
                                                CadastraProdutosNovo.DescricaoCstIcms = "";
                                                CadastraProdutosNovo.ValorIcms = "";
                                                CadastraProdutosNovo.IdCstPis = 0;
                                                CadastraProdutosNovo.DescricaoCstPis = "";
                                                CadastraProdutosNovo.ValorPis = "";
                                                CadastraProdutosNovo.IdCstCofins = 0;
                                                CadastraProdutosNovo.DescricaoCofins = "";
                                                CadastraProdutosNovo.ValorCofins = "";
                                                CadastraProdutosNovo.IdCstIpi = 0;
                                                CadastraProdutosNovo.DescricaoCstIpi = "";
                                                CadastraProdutosNovo.ValorIpi = "";
                                                CadastraProdutosNovo.CodigoGtin = 0;
                                                CadastraProdutosNovo.PesoBruto = "";
                                                CadastraProdutosNovo.PesoLiquido = "";
                                                CadastraProdutosNovo.OrigemProduto = "";

                                                //Salvar Cadastro de Produto no Estoque
                                                Conexao conexaoE = new Conexao(this.connetionString);
                                                DALCadastro2 daE = new DALCadastro2(conexao);

                                                daE.InserirEstoque(CadastraProdutosNovo);

                                                //Salvar Cadastro de Produto no Estoque item sem produto
                                                Conexao conexaoEI = new Conexao(this.connetionString);
                                                DALCadastro2 daEI = new DALCadastro2(conexaoEI);
                                                daEI.InserirEstoqueItem(CadastraProdutosNovo);
                                            }
                                        }
                                       

                                        MessageBox.Show("Produto cadastrado com exito!");

                                        FecharTodosFormulario();

                                        FormCadastraProdutos cadastraProduto = new FormCadastraProdutos(this.NomeServidor, this.NomeBaseDados, this.NomeUsuario, this.SenhaBaseDados);
                                        cadastraProduto.MdiParent = FormCadastraProdutos.ActiveForm;
                                        cadastraProduto.Show();
                                        cadastraProduto.Top = 0;
                                        cadastraProduto.Left = 0;
                                    }
                                    else if (dialogResultImprimir == DialogResult.No)
                                    {
   

                                    }
                                }
                                if (checkBoxInicializarEstoque.Checked == true)
                                {
                                    DialogResult dialogResultImprimir = MessageBox.Show("Esta não é a forma correta de cadastra produto.\n" +
                                    "A melhor forma é cadastra o produto sem 'Item Consta''.\n" +
                                    "Deseja continuar?", "Aviso", MessageBoxButtons.YesNo);
                                    if (dialogResultImprimir == DialogResult.Yes)
                                    {
                                        CadastraProdutosNovo.AdicionarQuantidadeAtualEstoque = 1;

                                        DALCadastro2 da = new DALCadastro2(conexao);
                                        da.InserirProduto(CadastraProdutosNovo);
  
                                        //Salvar Cadastro de Produto no Estoque
                                        Conexao conexaoE = new Conexao(this.connetionString);
                                        DALCadastro2 daE = new DALCadastro2(conexao);
                                        daE.InserirEstoque(CadastraProdutosNovo);

                                        if (CadastraGtin == 0)
                                        {
                                        }
                                        if (CadastraGtin == 1)
                                        {
                                            //Salvar Cadastro de Produto no Estoque item sem produto
                                            Conexao conexaoEI = new Conexao(this.connetionString);
                                            DALCadastro2 daEI = new DALCadastro2(conexaoEI);

                                            CadastraProdutosNovo.QuantComprada = 0;
                                            CadastraProdutosNovo.PrecoCusto = "";
                                            CadastraProdutosNovo.PrecoMedio = "";
                                            CadastraProdutosNovo.PrecoVenda = "";
                                            CadastraProdutosNovo.MargemLucro = "";                                
                                            CadastraProdutosNovo.AdicionarDataCompra = 0;
                                            CadastraProdutosNovo.Quant_Estoque = 0;
                                            CadastraProdutosNovo.AdicionarDataFabricacao = 0;
                                            CadastraProdutosNovo.AdicionarDataVencimento = 0;
                                            CadastraProdutosNovo.AdicionarDataEntrada = 0;
                                            CadastraProdutosNovo.AdicionarDataSolicitacao = 0;
                                            CadastraProdutosNovo.AdicionarPrevisaoChegada = 1;
                                            CadastraProdutosNovo.IdCstIcms = 0;
                                            CadastraProdutosNovo.DescricaoCstIcms = "";
                                            CadastraProdutosNovo.ValorIcms = "";
                                            CadastraProdutosNovo.IdCstPis = 0;
                                            CadastraProdutosNovo.DescricaoCstPis = "";
                                            CadastraProdutosNovo.ValorPis = "";
                                            CadastraProdutosNovo.IdCstCofins = 0;
                                            CadastraProdutosNovo.DescricaoCofins = "";
                                            CadastraProdutosNovo.ValorCofins = "";
                                            CadastraProdutosNovo.IdCstIpi = 0;
                                            CadastraProdutosNovo.DescricaoCstIpi = "";
                                            CadastraProdutosNovo.ValorIpi = "";
                                            CadastraProdutosNovo.CodigoGtin = 0;
                                            CadastraProdutosNovo.PesoBruto = "";
                                            CadastraProdutosNovo.PesoLiquido = "";                 
                                            CadastraProdutosNovo.OrigemProduto = "";                                        
                                         
                                            daEI.InserirEstoqueItem(CadastraProdutosNovo);
                                        }
                                        MessageBox.Show("Produto cadastrado com exito!");

                                        FecharTodosFormulario();

                                        FormCadastraProdutos cadastraProduto = new FormCadastraProdutos(this.NomeServidor, this.NomeBaseDados, this.NomeUsuario, this.SenhaBaseDados);
                                        cadastraProduto.MdiParent = FormCadastraProdutos.ActiveForm;
                                        cadastraProduto.Show();
                                        cadastraProduto.Top = 0;
                                        cadastraProduto.Left = 0;
                                    }
                                    else if (dialogResultImprimir == DialogResult.No)
                                    {
                                    }
                                }


                                //DALCadastro2 da = new DALCadastro2(conexao);

                                //da.InserirProduto(CadastraProdutosNovo);

                                //MessageBox.Show("Produto cadastrado com exito!");



                                ////Salvar Cadastro de Produto no Estoque
                                //Conexao conexaoE = new Conexao(this.connetionString);
                                //DALCadastro2 daE = new DALCadastro2(conexao);

                                //daE.InserirEstoque(CadastraProdutosNovo);

                                ////Salvar Cadastro de Produto no Estoque Item
                                //Conexao conexaoEI = new Conexao(this.connetionString);
                                //DALCadastro2 daEI = new DALCadastro2(conexao);

                                //daEI.InserirEstoqueItem(CadastraProdutosNovo);

                                //Salvar as imagem em produtos
                                //Salvar Imagem em Base de Dados
                                //    Conexao conexao1 = new Conexao(this.connetionString);
                                //    DALCadastro2 da1 = new DALCadastro2(conexao1);

                                //    //Salvar Imagem em Base de Dados 2
                                //    Conexao conexao2 = new Conexao(this.connetionString);
                                //    DALCadastro2 da2 = new DALCadastro2(conexao2);

                                //    //Salva contador em Pr_UnidadeMedida para saber o mas chamado
                                //    //Busca quantos ja foram adicionado

                                //    QuantidadeUnidadeUsada();


                                //    Conexao conexao3 = new Conexao(this.connetionString);
                                //    DALCadastro2 da3 = new DALCadastro2(conexao3);

                                //    CadastraObjetosVendas CadastraObjetosVendasContador = new CadastraObjetosVendas();
                                //    CadastraObjetosVendasContador.IdUnidadeMedida = this.IdUnidadeProduto;
                                //    CadastraObjetosVendasContador.QuantidadeUsada = QuantidadeUsada;   

                                //    da3.IncluiUnidadeProduto(CadastraObjetosVendasContador);

                                //    //Se não tiver Imagem nas duas!
                                //    if((bmp == null) && (bmp2 == null))
                                //    {

                                //    }
                                //    //Se tiver Imagem nas duas!
                                //    else if ((bmp != null) && (bmp2 != null))
                                //    {
                                //        ImagemProduto.IdProduto = int.Parse(CadastraProdutosNovo.IdProduto.ToString());
                                //        ImagemProduto2.IdProduto2 = int.Parse(CadastraProdutosNovo.IdProduto.ToString());
                                //        //imagem 1
                                //        MemoryStream memory = new MemoryStream();

                                //        bmp.Save(memory, ImageFormat.Bmp);

                                //        byte[] Foto = memory.ToArray();

                                //        ImagemProduto.Imagem = Foto;

                                //        da1.IncluirProdutoImagem(ImagemProduto);

                                //        //imagem 2
                                //        MemoryStream memory2 = new MemoryStream();

                                //        bmp2.Save(memory2, ImageFormat.Bmp);

                                //        byte[] Foto2 = memory2.ToArray();

                                //        ImagemProduto2.Imagem2 = Foto2;

                                //        da2.IncluirProdutoImagem2(ImagemProduto2);

                                //        MessageBox.Show("Produto Cadastrado com exito!\nAs duas imagens foram salvas!");
                                //    }
                                //    //Se tiver Imagem só na 1!
                                //    else if ((bmp != null) && (bmp2 == null))
                                //    {
                                //        ImagemProduto.IdProduto = int.Parse(CadastraProdutosNovo.IdProduto.ToString());

                                //        //imagem 1
                                //        MemoryStream memory = new MemoryStream();

                                //        bmp.Save(memory, ImageFormat.Bmp);

                                //        byte[] Foto = memory.ToArray();

                                //        ImagemProduto.Imagem = Foto;

                                //        da1.IncluirProdutoImagem(ImagemProduto);

                                //        MessageBox.Show("Produto Cadastrado com exito!\nImagem salva no sistema!");
                                //    }
                                //    //Se tiver Imagem só na 2!
                                //    else if ((bmp == null) && (bmp2 != null))
                                //    {
                                //        ImagemProduto2.IdProduto2 = int.Parse(CadastraProdutosNovo.IdProduto.ToString());
                                //        //imagem 2
                                //        MemoryStream memory2 = new MemoryStream();

                                //        bmp2.Save(memory2, ImageFormat.Bmp);

                                //        byte[] Foto2 = memory2.ToArray();

                                //        ImagemProduto2.Imagem2 = Foto2;

                                //        da2.IncluirProdutoImagem2(ImagemProduto2);

                                //        MessageBox.Show("Produto Cadastrado com exito!\nImagem salva no sistema!");
                                //    }

                                //    FecharTodosFormulario();

                                //    FormCadastraProdutos cadastraProduto = new FormCadastraProdutos(this.NomeServidor, this.NomeBaseDados, this.NomeUsuario, this.SenhaBaseDados);
                                //    cadastraProduto.MdiParent = FormCadastraProdutos.ActiveForm;
                                //    cadastraProduto.Show();
                                //    cadastraProduto.Top = 0;
                                //    cadastraProduto.Left = 0;
                            }
                        }
                    }
                }                
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
        }
        private void QuantidadeUnidadeUsada()
        {
            try
            {
                SqlConnection conn = new SqlConnection(this.connetionString);
                string sql = "SELECT QUANT_USADA FROM Pr_UnidadeMedida WHERE ID_UNIDADE_MEDIDA = " + this.IdUnidadeProduto + ";";
                SqlDataAdapter sda1 = new SqlDataAdapter(sql, conn);
                DataSet ds = new DataSet();
                sda1.Fill(ds);

                conn.Open();

                string Resultado = ds.Tables[0].Rows[0][0].ToString();

                if (Resultado == "")
                {
                    this.QuantidadeUsada = 1;
                }
                if (Resultado != "")
                {
                    this.QuantidadeUsada = 1 + int.Parse(Resultado);
                }

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void txtPesoBruto_TextChanged(object sender, EventArgs e)
        {
            Moeda(ref txtPesoBruto);
        }

        private void txtPesoLiquido_TextChanged(object sender, EventArgs e)
        {
            Moeda(ref txtPesoLiquido);
        }
        private void txtBaseIcms_TextChanged(object sender, EventArgs e)
        {
            Moeda(ref txtBaseIcms);
        }

        private void txtIpi_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Se a tecla digitada não for número
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }
            if (e.KeyChar == 13)
            {
                try
                {
                    SendKeys.Send("{Tab}");
                }
                catch (Exception ex)
                {
                    ex.ToString();
                }
            }
        }

        private void txtConfins_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Se a tecla digitada não for número
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }
            if (e.KeyChar == 13)
            {
                try
                {
                    SendKeys.Send("{Tab}");
                }
                catch (Exception ex)
                {
                    ex.ToString();
                }
            }
        }

        private void txtBaseIcms_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Se a tecla digitada não for número
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }
            if (e.KeyChar == 13)
            {
                try
                {
                    SendKeys.Send("{Tab}");
                }
                catch (Exception ex)
                {
                    ex.ToString();
                }
            }
        }

        private void txtConfins_TextChanged(object sender, EventArgs e)
        {
            Moeda(ref txtConfins);
        }
        //COMBOBOX PRODUTO, MARCA, CATEGORIA, FORNECEDOR, UNIDADE E ORIGEM DE PRODUTO!
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
        //SELECINE DESCRICAO DE PRODUTO
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
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //LISTA AS MARCAS CADASTRADA NO SISTEMA
        void Fill_listBoxMarcaProduto()
        {
            SqlConnection connection = new SqlConnection(this.connetionString);

            try
            {
                connection.Open();
                string Query = "EXEC D_V_ConsultaMarcaProduto;";


                SqlCommand command = new SqlCommand(Query, connection);
                SqlDataReader dr = command.ExecuteReader();
                while (dr.Read())
                {
                    string name = dr.GetString(1);
                    comboBoxMarca.Items.Add(name);
                }
                connection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        // SELECIONA A MARCA DE PRODUTO
        private void comboBoxMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(this.connetionString);

            try
            {
                connection.Open();

                string Query = "exec D_V_ConsultaMarcaProdutoConstaTxt '" + this.comboBoxMarca.Text + "';";

                SqlCommand command = new SqlCommand(Query, connection);
                SqlDataReader dr = command.ExecuteReader();
                while (dr.Read())
                {

                    IdMarcaProduto = dr.GetInt32(0);
                    comboBoxMarca.Text = dr.GetString(1);
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        //Lista de Categoria Produto
        void Fill_listBoxCategoriaProduto()
        {
            SqlConnection connection = new SqlConnection(this.connetionString);

            try
            {
                connection.Open();
                string Query = "EXEC D_V_ConsultaCategoriaProduto;";


                SqlCommand command = new SqlCommand(Query, connection);
                SqlDataReader dr = command.ExecuteReader();
                while (dr.Read())
                {
                    string name = dr.GetString(1);
                    comboBoxCartegoria.Items.Add(name);
                }
                connection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void comboBoxCartegoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(this.connetionString);

            try
            {
                connection.Open();

                string Query = "exec D_V_ConsultaCategoriaProdutoConstaTxt '" + this.comboBoxCartegoria.Text + "';";

                SqlCommand command = new SqlCommand(Query, connection);
                SqlDataReader dr = command.ExecuteReader();
                while (dr.Read())
                {

                    IdMarcaProdutoCategoria = dr.GetInt32(0);
                    comboBoxCartegoria.Text = dr.GetString(1);
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //LISTA AS MARCAS CADASTRADA NO SISTEMA
        void Fill_listBoxMarcaFornecedor()
        {
            SqlConnection connection = new SqlConnection(this.connetionString);

            try
            {
                connection.Open();
                string Query = "EXEC D_V_ConsultaFornecedorNomeCadastroContatos;";


                SqlCommand command = new SqlCommand(Query, connection);
                SqlDataReader dr = command.ExecuteReader();
                while (dr.Read())
                {
                    string name = dr.GetString(0);
                    comboBoxFornecedor.Items.Add(name);
                }
                connection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void comboBoxFornecedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(this.connetionString);

            try
            {
                connection.Open();
                //ESTA PROCEDURE NAO EXISTE
                string Query = "exec D_ConsultaFornecedorNomeCadastroContatostxt '" + this.comboBoxFornecedor.Text + "',1;";

                SqlCommand command = new SqlCommand(Query, connection);
                SqlDataReader dr = command.ExecuteReader();
                while (dr.Read())
                {

                    IdMarcaFornecedor = dr.GetInt32(0);
                    comboBoxFornecedor.Text = dr.GetString(2);
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        void Fill_listBoxFabricanteProduto()
        {
            SqlConnection connection = new SqlConnection(this.connetionString);

            try
            {
                connection.Open();
                string Query = "EXEC D_V_ConsultaFabricanteProduto;";


                SqlCommand command = new SqlCommand(Query, connection);
                SqlDataReader dr = command.ExecuteReader();
                while (dr.Read())
                {
                    string name = dr.GetString(1);
                    comboBoxFabricante.Items.Add(name);
                }
                connection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void comboBoxFabricante_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(this.connetionString);

            try
            {
                connection.Open();
                //ESTA PROCEDURE NAO EXISTE
                string Query = "exec D_V_ConsultaFabricanteProdutoConstaTxt '" + this.comboBoxFabricante.Text + "';";

                SqlCommand command = new SqlCommand(Query, connection);
                SqlDataReader dr = command.ExecuteReader();
                while (dr.Read())
                {

                    IdFabricanteFornecedor = dr.GetInt32(0);
                    comboBoxFabricante.Text = dr.GetString(1);
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //Lista de Unidade Produto
        void Fill_listBoxUnidade()
        {
            SqlConnection connection = new SqlConnection(this.connetionString);

            try
            {
                connection.Open();
                string Query = "EXEC D_V_ConsultaUnidadeProduto;";


                SqlCommand command = new SqlCommand(Query, connection);
                SqlDataReader dr = command.ExecuteReader();
                while (dr.Read())
                {
                    string name = dr.GetString(2);
                    comboBoxUnidade.Items.Add(name);
                }
                connection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //SELECIONAR UNIDADE DE PRODUTO
        private void comboBoxUnidade_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(this.connetionString);

            try
            {
                connection.Open();

                string Query = "exec D_V_ConsultaUnidadeProdutoTxt '" + this.comboBoxUnidade.Text + "';";

                SqlCommand command = new SqlCommand(Query, connection);
                SqlDataReader dr = command.ExecuteReader();
                while (dr.Read())
                {
                    IdUnidadeProduto = dr.GetInt32(0);
                    
                    comboBoxUnidade.Text = dr.GetString(2);
                    label47.Text = "Valor: " + dr.GetInt32(1) + " e descrição: " + dr.GetString(3) + ".";
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        ////Lista Selecionar Origem Produto
        //void Fill_listBoxOrigemProduto()
        //{
        //    SqlConnection connection = new SqlConnection(this.connetionString);

        //    try
        //    {
        //        connection.Open();
        //        string Query = "EXEC D_V_ConsultaOrigemProduto;";


        //        SqlCommand command = new SqlCommand(Query, connection);
        //        SqlDataReader dr = command.ExecuteReader();
        //        while (dr.Read())
        //        {
        //            string name = dr.GetString(1);
        //            comboBoxOrigemProduto.Items.Add(name);
        //        }
        //        connection.Close();

        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //}
        ////Lista Selecionar Origem Produto txt
        //private void comboBoxOrigemProduto_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    SqlConnection connection = new SqlConnection(this.connetionString);

        //    try
        //    {
        //        connection.Open();

        //        string Query = "exec D_V_ConsultaOrigemProdutoTxt '" + this.comboBoxOrigemProduto.Text + "';";

        //        SqlCommand command = new SqlCommand(Query, connection);
        //        SqlDataReader dr = command.ExecuteReader();
        //        while (dr.Read())
        //        {
        //            IdOrigemProduto = dr.GetInt32(0);
        //            comboBoxOrigemProduto.Text = dr.GetString(1);
        //        }
        //        connection.Close();
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //}

        //CALCULA ATÉ DUAS CASAS DECIMAIS

        
        

        //COMBOBOX ICMS,IPI E OUTROS--------------------------------

        //Lista de CstIcms Produto
        void Fill_listBoxCstIcms()
        {
            SqlConnection connection = new SqlConnection(this.connetionString);

            try
            {
                connection.Open();
                string Query = "EXEC D_V_ConsultaCstIcms;";


                SqlCommand command = new SqlCommand(Query, connection);
                SqlDataReader dr = command.ExecuteReader();
                while (dr.Read())
                {
                    int name = dr.GetInt32(1);
                    comboBoxCstIcms.Items.Add(name);
                }
                connection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //Selecione CstIcms Produto
        private void comboBoxCstIcms_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(this.connetionString);

            try
            {
                connection.Open();

                //int codigo = int.Parse(comboBoxCstIcms.Text);

                string Query = "exec D_V_ConsultaCstIcmsTxt " + this.comboBoxCstIcms.Text + ";";

                SqlCommand command = new SqlCommand(Query, connection);
                SqlDataReader dr = command.ExecuteReader();
                while (dr.Read())
                {
                    IdCstIcms = dr.GetInt32(0);
                    txtDescricaoCstIcms.Text = dr.GetString(2);
                    txtBaseIcms.Enabled = true;
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //Lista de Pis Produto
        void Fill_listBoxCstPis()
        {
            SqlConnection connection = new SqlConnection(this.connetionString);

            try
            {
                connection.Open();
                string Query = "EXEC D_V_ConsultaCstPis;";


                SqlCommand command = new SqlCommand(Query, connection);
                SqlDataReader dr = command.ExecuteReader();
                while (dr.Read())
                {
                    int name = dr.GetInt32(1);
                    comboBoxCstPis.Items.Add(name);
                }
                connection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //Selecione Pis Produto
        private void comboBoxCstPis_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(this.connetionString);

            try
            {
                connection.Open();

                string Query = "exec D_V_ConsultaCstPisTxt '" + this.comboBoxCstPis.Text + "';";

                SqlCommand command = new SqlCommand(Query, connection);
                SqlDataReader dr = command.ExecuteReader();
                while (dr.Read())
                {
                    IdCstPis = dr.GetInt32(0);
                    txtDescricaoCstPis.Text = dr.GetString(2);
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtPis_TextChanged(object sender, EventArgs e)
        {
            Moeda(ref txtPis);
        }

        //Lista de Cofins Produto
        void Fill_listBoxCstCofins()
        {
            SqlConnection connection = new SqlConnection(this.connetionString);

            try
            {
                connection.Open();
                string Query = "EXEC D_V_ConsultaCstCofins;";


                SqlCommand command = new SqlCommand(Query, connection);
                SqlDataReader dr = command.ExecuteReader();
                while (dr.Read())
                {
                    int codigo = dr.GetInt32(1);
                    comboBoxCstCofins.Items.Add(codigo);
                }
                connection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //Selecine  cofins Produto
        private void comboBoxCstCofins_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(this.connetionString);

            try
            {
                connection.Open();

                string Query = "exec  D_V_ConsultaCstCofinsTxt '" + this.comboBoxCstCofins.Text + "';";

                SqlCommand command = new SqlCommand(Query, connection);
                SqlDataReader dr = command.ExecuteReader();
                while (dr.Read())
                {
                    IdCstCofins = dr.GetInt32(0);
                    txtDescricaoCofins.Text = dr.GetString(2);
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //Lista de IPI Produto
        void Fill_listBoxCstIpi()
        {
            SqlConnection connection = new SqlConnection(this.connetionString);

            try
            {
                connection.Open();
                string Query = "EXEC D_V_ConsultaCstIpi;";


                SqlCommand command = new SqlCommand(Query, connection);
                SqlDataReader dr = command.ExecuteReader();
                while (dr.Read())
                {
                    int codigo = dr.GetInt32(1);
                    comboBoxCstIpI.Items.Add(codigo);
                }
                connection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //Selecine  Ipi Produto
        private void comboBoxCstIpI_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(this.connetionString);

            try
            {
                connection.Open();

                string Query = "exec  D_V_ConsultaCstIpiTxt '" + this.comboBoxCstIpI.Text + "';";

                SqlCommand command = new SqlCommand(Query, connection);
                SqlDataReader dr = command.ExecuteReader();
                while (dr.Read())
                {
                    IdCstIpi = dr.GetInt32(0);
                    txtDescricaoIpI.Text = dr.GetString(2);
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void txtNcm_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Se a tecla digitada não for número
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }
        }
        private void txtPrecoCusto_TextChanged(object sender, EventArgs e)
        {
            Moeda(ref txtPrecoCusto);
            txtPrecoCusto.TextAlign = HorizontalAlignment.Right;
            //txtPrecoCusto.Text = VerificarVirgula(txtPrecoCusto.Text);
        }

        private void txtCustoMedio_TextChanged(object sender, EventArgs e)
        {
            Moeda(ref txtCustoMedio);
            txtCustoMedio.TextAlign = HorizontalAlignment.Right;
        }
        //CHAMA O METODO CancelaCadastradoCliente QUE FECHA FORMULÁRIOS ABERTOS
        public void FecharTodosFormulario()
        {
            CancelaCadastradoProdutos(typeof(FormCadastraProdutos));
        }

        private void buttonFecharCliente_Click(object sender, EventArgs e)
        {
            FecharTodosFormulario();
        }
        public static void CancelaCadastradoProdutos(Type frmType)
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
        private void buttonCancelarcadastrousuario_Click(object sender, EventArgs e)
        {
            FecharTodosFormulario();

            FormCadastraProdutos cadastracliente = new FormCadastraProdutos(this.NomeServidor, this.NomeBaseDados, this.NomeUsuario, this.SenhaBaseDados);
            cadastracliente.MdiParent = FormCadastraProdutos.ActiveForm;
            cadastracliente.Show();
            cadastracliente.Top = 0;
            cadastracliente.Left = 0;
        }
        private void buttonAnexo_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "JPG Files(*.jpg)|*.jpg|JPG Files(*.png)|*.png";// all files(*.*) | *.*

            DialogResult dialogResult = MessageBox.Show("Deseja Anexa uma imagem!", "Aviso", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    openFileDialog1.ShowDialog();
                    ImgLocation = openFileDialog1.FileNames.ToString();
                    //label15.Text = Dialog.FileNames.ToString();
                    label49.Text =  openFileDialog1.FileName;
                    pictureBoxImagem.Image = Image.FromFile(openFileDialog1.FileName);
                    bmp = new Bitmap(label49.Text);
                }
                catch (Exception ex)
                {
                    ex.ToString();
                }
            }
            else if (dialogResult == DialogResult.No)
            {
                MessageBox.Show("Cancelado o Anexo da Imagem!");
            }
        }
        private void buttonAnexo2_Click(object sender, EventArgs e)
        {
            openFileDialog2.Filter = "JPG Files(*.jpg)|*.jpg|JPG Files(*.png)|*.png";// all files(*.*) | *.*

            DialogResult dialogResult = MessageBox.Show("Deseja Anexa uma imagem!", "Aviso", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    openFileDialog2.ShowDialog();
                    ImgLocation2 = openFileDialog2.FileNames.ToString();
                    //label15.Text = Dialog.FileNames.ToString();
                    label50.Text = openFileDialog2.FileName;
                    pictureBoxImagem2.Image = Image.FromFile(openFileDialog2.FileName);
                    bmp2 = new Bitmap(label50.Text);
                }
                catch (Exception ex)
                {
                    ex.ToString();
                }
            }
            else if (dialogResult == DialogResult.No)
            {
                MessageBox.Show("Cancelado o Anexo da Imagem!");
            }
        }
        private void buttonAbrirAnexo_Click(object sender, EventArgs e)
        {
            //int arruma = 0;
            //SqlConnection conn = new SqlConnection(this.connetionString);
            //SqlCommand comand = new SqlCommand("D_O_ConsultaOsImagemSalva " + arruma + ";", conn);
            //conn.Open();

            //SqlDataReader reader = comand.ExecuteReader();

            //if (reader.Read())
            //{
            //    byte[] Foto = (byte[])reader["IMAGEM"];
            //    MemoryStream ms = new MemoryStream(Foto);
            //    Imagem = Image.FromStream(ms);
            //}
            //if (Imagem == null)
            //{
            //    MessageBox.Show("Não existir Imagem!");
            //}
            //if (Imagem != null)
            //{
            //    pictureBoxImagem.Image = Imagem;
            //}
        }
        private void buttonImprimirImagemOS_Click(object sender, EventArgs e)
        {
            printPreviewDialogImagem.Document = printDocumentImagem;
            printPreviewDialogImagem.ShowDialog();
        }
        private void buttonCadastraGtin_Click(object sender, EventArgs e)
        {
            AlteraBotoes(6);
        }
        private void buttonCancelarGtin_Click(object sender, EventArgs e)
        {
            AlteraBotoes(7);
        }
        private void txtCodigoGtin_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Se a tecla digitada não for número
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }
            if (e.KeyChar == 13)
            {
                try
                {
                    SendKeys.Send("{Tab}");
                }
                catch (Exception ex)
                {
                    ex.ToString();
                }
            }
        }

        private void txtPesoBruto_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Se a tecla digitada não for número
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }
            if (e.KeyChar == 13)
            {
                try
                {
                    SendKeys.Send("{Tab}");
                }
                catch (Exception ex)
                {
                    ex.ToString();
                }
            }
        }
        private void txtPesoLiquido_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Se a tecla digitada não for número
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }
            if (e.KeyChar == 13)
            {
                try
                {
                    SendKeys.Send("{Tab}");
                }
                catch (Exception ex)
                {
                    ex.ToString();
                }
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                ObjetosCadastrados();
            }
        }

        private void txtConsultarItens_TextChanged(object sender, EventArgs e)
        {
            if(this.ValorPesquisa == 1)
            {
                DataView DV = new DataView(TableProduto);
                DV.RowFilter = string.Format("NOME LIKE '%{0}%'", txtConsultarItens.Text);
                dataGridViewObjetosItens.DataSource = DV;
                label48.Text = "Pesquisa Produtos n°: " + dataGridViewObjetosItens.RowCount.ToString();
            }
            if (this.ValorPesquisa == 2)
            {
                DataView DV = new DataView(TableMarca);
                DV.RowFilter = string.Format("NOME LIKE '%{0}%'", txtConsultarItens.Text);
                dataGridViewObjetosItens.DataSource = DV;
                label48.Text = "Pesquisa Marca n°: " + dataGridViewObjetosItens.RowCount.ToString();
            }
            if (this.ValorPesquisa == 3)
            {
                DataView DV = new DataView(TableCategoria);
                DV.RowFilter = string.Format("NOME LIKE '%{0}%'", txtConsultarItens.Text);
                dataGridViewObjetosItens.DataSource = DV;
                label48.Text = "Pesquisa Categoria n°: " + dataGridViewObjetosItens.RowCount.ToString();
            }
            if (this.ValorPesquisa == 4)
            {
                DataView DV = new DataView(TableCFornecedor);
                DV.RowFilter = string.Format("NOME LIKE '%{0}%'", txtConsultarItens.Text);
                dataGridViewObjetosItens.DataSource = DV;
                label48.Text = "Pesquisa Fornecedor n°: " + dataGridViewObjetosItens.RowCount.ToString();
            }
        }
        private void radioButtonProduto_CheckedChanged(object sender, EventArgs e)
        {
            txtConsultarItens.Clear();
            txtConsultarItens.MaxLength = 120;
            ValorPesquisa = 0;
            dataGridViewPesquisaTodasEntrada();
        }
        private void radioButtonMarca_CheckedChanged(object sender, EventArgs e)
        {
            txtConsultarItens.Clear();
            txtConsultarItens.MaxLength = 120;
            ValorPesquisa = 0;
            dataGridViewPesquisaTodasEntrada();
        }
        private void radioButtonCartegoria_CheckedChanged(object sender, EventArgs e)
        {
            txtConsultarItens.Clear();
            txtConsultarItens.MaxLength = 120;
            ValorPesquisa = 0;
            dataGridViewPesquisaTodasEntrada();
        }
        private void radioButtonFornecedor_CheckedChanged(object sender, EventArgs e)
        {
            txtConsultarItens.Clear();
            txtConsultarItens.MaxLength = 100;
            ValorPesquisa = 0;
            dataGridViewPesquisaTodasEntrada();
        }
        private void radioButtonFabricante_CheckedChanged(object sender, EventArgs e)
        {
            txtConsultarItens.Clear();
            txtConsultarItens.MaxLength = 120;
            ValorPesquisa = 0;
            dataGridViewPesquisaTodasEntrada();
        }

        private void dataGridViewObjetosItens_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!(dataGridViewObjetosItens.RowCount == 0))
            {
                try
                {
                    if (radioButtonProduto.Checked == true)
                    {
                        this.IdDescricaoProduto = Convert.ToInt32(dataGridViewObjetosItens["ID", e.RowIndex].Value);
                        comboBoxDescricaoProduto.SelectedItem = Convert.ToString(dataGridViewObjetosItens["NOME_CADASTRADO", e.RowIndex].Value);                     
                    }
                    if (radioButtonMarca.Checked == true)
                    {
                        this.IdMarcaProduto = Convert.ToInt32(dataGridViewObjetosItens["ID", e.RowIndex].Value);
                        comboBoxMarca.SelectedItem = Convert.ToString(dataGridViewObjetosItens["NOME_CADASTRADO", e.RowIndex].Value);
                    }
                    if (radioButtonCategoria.Checked == true)
                    {
                        this.IdMarcaProdutoCategoria = Convert.ToInt32(dataGridViewObjetosItens["ID", e.RowIndex].Value);
                        comboBoxCartegoria.SelectedItem = Convert.ToString(dataGridViewObjetosItens["NOME_CADASTRADO", e.RowIndex].Value);
                    }
                    if (radioButtonFornecedor.Checked == true)
                    {
                        this.IdMarcaFornecedor = Convert.ToInt32(dataGridViewObjetosItens["ID", e.RowIndex].Value);
                        comboBoxFornecedor.SelectedItem = Convert.ToString(dataGridViewObjetosItens["NOME_CADASTRADO", e.RowIndex].Value);
                    }
                    if (radioButtonFabricante.Checked == true)
                    {
                        this.IdMarcaFornecedor = Convert.ToInt32(dataGridViewObjetosItens["ID", e.RowIndex].Value);
                        comboBoxFornecedor.SelectedItem = Convert.ToString(dataGridViewObjetosItens["NOME_CADASTRADO", e.RowIndex].Value);
                    }
                }
                catch (Exception ex)
                {
                    ex.ToString();
                }
            }
        }
        private void buttonFecharFuncionario_Click(object sender, EventArgs e)
        {
            FecharTodosFormulario();
        }

        private void FormCadastraProdutos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
            {
                this.Close();
            }
        }
        private void buttonImprimirImagem_Click(object sender, EventArgs e)
        {
            if (printDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                printDialog.PrinterSettings = printDialog.PrinterSettings;
                printDocumentImagem.Print();
            }
        }

        private void buttonImprimirImagem2_Click(object sender, EventArgs e)
        {
            if (printDialog2.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                printDialog2.PrinterSettings = printDialog2.PrinterSettings;
                printDocumentImagem2.Print();
            }
        }

        private void buttonImprimirImagemOS2_Click(object sender, EventArgs e)
        {
            printPreviewDialogImagem2.Document = printDocumentImagem2;
            printPreviewDialogImagem2.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
        private void txtDescricaoCstIcms_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                try
                {
                    SendKeys.Send("{Tab}");
                }
                catch (Exception ex)
                {
                    ex.ToString();
                }
            }
        }

        private void txtDescricaoCstPis_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                try
                {
                    SendKeys.Send("{Tab}");
                }
                catch (Exception ex)
                {
                    ex.ToString();
                }
            }
        }

        private void txtPis_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                try
                {
                    SendKeys.Send("{Tab}");
                }
                catch (Exception ex)
                {
                    ex.ToString();
                }
            }
        }

        private void txtDescricaoCofins_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                try
                {
                    SendKeys.Send("{Tab}");
                }
                catch (Exception ex)
                {
                    ex.ToString();
                }
            }
        }

        private void txtDescricaoIpI_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                try
                {
                    SendKeys.Send("{Tab}");
                }
                catch (Exception ex)
                {
                    ex.ToString();
                }
            }
        }

        private void txtOrigemProduto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                try
                {
                    SendKeys.Send("{Tab}");
                }
                catch (Exception ex)
                {
                    ex.ToString();
                }
            }
        }

        private void txtCadastraProduto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                try
                {
                    SendKeys.Send("{Tab}");
                }
                catch (Exception ex)
                {
                    ex.ToString();
                }
            }
        }

        private void txtDescricaoProduto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                try
                {
                    SendKeys.Send("{Tab}");
                }
                catch (Exception ex)
                {
                    ex.ToString();
                }
            }
        }

        private void txtCadastroMarca_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                try
                {
                    SendKeys.Send("{Tab}");
                }
                catch (Exception ex)
                {
                    ex.ToString();
                }
            }
        }

        private void txtCadastroDescricaoMarca_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                try
                {
                    SendKeys.Send("{Tab}");
                }
                catch (Exception ex)
                {
                    ex.ToString();
                }
            }
        }

        private void txtCadastroCategoria_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                try
                {
                    SendKeys.Send("{Tab}");
                }
                catch (Exception ex)
                {
                    ex.ToString();
                }
            }
        }

        private void txtDescricaoCategoria_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                try
                {
                    SendKeys.Send("{Tab}");
                }
                catch (Exception ex)
                {
                    ex.ToString();
                }
            }
        }

        private void txtDescriacaoProdutoSistema_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                SendKeys.Send("{Tab}");
            }
        }

        private void buttonCodigoBusca_Click(object sender, EventArgs e)
        {

            //double c = 0;
            //float f = 0;
            //decimal de = 0m; 

            //c = 12.54557848 * 13.954547;
            //f = 12.54557848f * 13.954547f;
            //de = 12.54557848m * 13.954547m;
            //MessageBox.Show("Double: " + c + "  \nFloat: "+ f + " \nDecimal: " + de);


            //string connetionString = (this.connetionString);
            //SqlConnection connection = new SqlConnection(connetionString);

            //SqlCommand command = new SqlCommand("Exec D_V_ConsultaProdutoNomeProduto;", connection);
            //SqlDataAdapter adapter = new SqlDataAdapter();
            //adapter.SelectCommand = command;
            //TableTodos = new DataTable();
            //adapter.Fill(TableTodos);
            //BindingSource Source = new BindingSource();
            //Source.DataSource = TableTodos;
            //dataGridViewObjetosItens.DataSource = Source;
            //adapter.Update(TableTodos);
            //connection.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            CalculaValorTotal();
            //string PrecoCustoS = ConverterValores(txtPrecoCusto.Text);
            //PrecoCustoS = ReajustaValoresSql(PrecoCustoS);
            //string PrecoMedioS = ConverterValores(txtCustoMedio.Text);
            //PrecoMedioS = ReajustaValoresSql(PrecoMedioS);
            //string PrecoVendaS = ConverterValores(txtPrecoVenda.Text);
            //PrecoVendaS = ReajustaValoresSql(PrecoVendaS);
            //string MargemLucroS = ConverterValores(txtMargemLucro.Text);
            //MargemLucroS = ReajustaValoresSql(MargemLucroS);

            //MessageBox.Show(" A " + PrecoCustoS + " B " + PrecoMedioS + " C " + PrecoVendaS + " D " + MargemLucroS);
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void CalculaValorTotal()
        {
            try
            {

                if (txtQuantidadeAtualEstoque.Text == "")
                {
                    txtQuantidadeAtualEstoque.Text = "1";
                }
                if ((txtQuantidadeAtualEstoque.Text != "") && (txtPrecoVenda.Text != ""))
                {
                    int Quantidade = 0;
                    decimal PrecoVendaS = 0;
                    decimal PrecoVendaTotal = 0;


                    Quantidade = int.Parse(txtQuantidadeAtualEstoque.Text);
                    PrecoVendaS = Convert.ToDecimal(ConverterValores(txtPrecoVenda.Text));

                    if (Quantidade == 0)
                    {
                        txtQuantidadeAtualEstoque.Text = "1";
                    }
                    if (Quantidade > 1)
                    {
                        PrecoVendaTotal = PrecoVendaS * Quantidade;
                        txtPrecoTotalCompra.Text = PrecoVendaTotal.ToString();
                        txtPrecoTotalCompra.TextAlign = HorizontalAlignment.Right;
                    }

                }
            }
            catch (Exception erro)
            {
                erro.ToString();
            }
        }
        private void txtPrecoTotalCompra_TextChanged(object sender, EventArgs e)
        {
            Moeda(ref txtPrecoTotalCompra);
            txtPrecoTotalCompra.TextAlign = HorizontalAlignment.Right;
        }

        private void txtQuantidadeAtualEstoque_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if(checkBoxInicializarEstoque.Checked == true)
                {
                    txtQuantidadeAtualEstoque.TextAlign = HorizontalAlignment.Right;
                    if (txtQuantidadeAtualEstoque.Text == "")
                    {
                        txtQuantidadeAtualEstoque.Text = "1";
                    }
                    if ((txtQuantidadeAtualEstoque.Text != "") && (txtPrecoVenda.Text != ""))
                    {
                        int Quantidade = 0;
                        decimal PrecoVendaS = 0;
                        decimal PrecoVendaTotal = 0;


                        Quantidade = int.Parse(txtQuantidadeAtualEstoque.Text);
                        PrecoVendaS = Convert.ToDecimal(ConverterValores(txtPrecoVenda.Text));

                        if (Quantidade == 0)
                        {
                            txtQuantidadeAtualEstoque.Text = "1";
                        }
                        if (Quantidade > 1)
                        {
                            PrecoVendaTotal = PrecoVendaS * Quantidade;
                            txtPrecoTotalCompra.Text = PrecoVendaTotal.ToString();
                            txtPrecoTotalCompra.TextAlign = HorizontalAlignment.Right;
                        }

                    }
                }
                if (checkBoxInicializarEstoque.Checked == false)
                {
                    txtQuantidadeAtualEstoque.TextAlign = HorizontalAlignment.Right;
                    if (txtQuantidadeAtualEstoque.Text == "")
                    {
                        txtQuantidadeAtualEstoque.Text = "0";
                    }
                    if ((txtQuantidadeAtualEstoque.Text != "") && (txtPrecoVenda.Text != ""))
                    {
                        int Quantidade = 0;
                        decimal PrecoVendaS = 0;
                        decimal PrecoVendaTotal = 0;


                        Quantidade = int.Parse(txtQuantidadeAtualEstoque.Text);
                        PrecoVendaS = Convert.ToDecimal(ConverterValores(txtPrecoVenda.Text));

                        if (Quantidade == 0)
                        {
                            txtQuantidadeAtualEstoque.Text = "0";
                        }
                        if (Quantidade > 1)
                        {
                            PrecoVendaTotal = PrecoVendaS * Quantidade;
                            txtPrecoTotalCompra.Text = PrecoVendaTotal.ToString();
                            txtPrecoTotalCompra.TextAlign = HorizontalAlignment.Right;
                        }

                    }
                }
                
            }
            catch (Exception erro)
            {
                erro.ToString();
            }
        }

        private void checkBoxDataSolicitacao_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxDataSolicitacao.Checked == true)
            {
                dateTimePickerSolicitacao.Enabled = true;
            }
            if (checkBoxDataSolicitacao.Checked == false)
            {
                dateTimePickerSolicitacao.Enabled = false;
            }
        }

        private void checkBoxDataVencimento_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxDataVencimento.Checked == true)
            {
                dateTimePickerVencimento.Enabled = true;
            }
            if (checkBoxDataVencimento.Checked == false)
            {
                dateTimePickerVencimento.Enabled = false;
            }
        }

        private void checkBoxDataFabricacao_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxDataFabricacao.Checked == true)
            {
                dateTimePickerFabricacao.Enabled = true;
            }
            if (checkBoxDataFabricacao.Checked == false)
            {
                dateTimePickerFabricacao.Enabled = false;
            }
        }

        private void checkBoxDataEntrada_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxDataEntrada.Checked == true)
            {
                dateTimePickerDataEntrada.Enabled = true;

                dateTimePickerDataCompra.Enabled = true;
            }
            if (checkBoxDataEntrada.Checked == false)
            {
                dateTimePickerDataEntrada.Enabled = false;

                dateTimePickerDataCompra.Enabled = false;
            }
        }

        private void txtQuantidadeMinimaEstoque_TextChanged(object sender, EventArgs e)
        {
            txtQuantidadeMinimaEstoque.TextAlign = HorizontalAlignment.Right;
        }

        private void panelGeral_Paint(object sender, PaintEventArgs e)
        {

        }

        private void checkBoxInicializarEstoque_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxInicializarEstoque.Checked == true)
            {
                txtQuantidadeAtualEstoque.Enabled = true;
                txtQuantidadeAtualEstoque.Text = "1";
                MessageBox.Show("A forma correta de cadastro, Primeiramente só cadastrar o produto. \n Oks.");
            }
            if (checkBoxInicializarEstoque.Checked == false)
            {
                txtQuantidadeAtualEstoque.Enabled = false;

                txtQuantidadeAtualEstoque.Text = "0";        

                if(txtPrecoVenda.Text != "0,00")
                {
                    txtPrecoTotalCompra.Text = txtPrecoVenda.Text;
                }
                else if (txtPrecoCusto.Text != "0,00")
                {
                    txtPrecoTotalCompra.Text = txtPrecoCusto.Text;
                }
            }
        }

        private void buttonLimpaValores_Click(object sender, EventArgs e)
        {
            txtPrecoCusto.Text = "0,00";
            txtMargemLucro.Text = "0,00";
            txtCustoMedio.Text = "0,00";
            txtPrecoVenda.Text = "0,00";
            txtPrecoTotalCompra.Text = "0,00";

            this.TempCustoEnter = decimal.Parse(txtPrecoCusto.Text = "0,00");
            this.TempMargemLucroEnter = decimal.Parse(txtMargemLucro.Text = "0,00");
            this.TempVendaEnter = decimal.Parse(txtPrecoVenda.Text = "0,00");
        }
    }
}
            
