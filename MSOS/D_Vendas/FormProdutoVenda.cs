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
using System.Globalization;

namespace DateSystem
{
    public partial class FormProdutoVenda : Form
    {
        DataTable TableNomeProduto;
        //DataTable TableNomeCliente;

        List<ListaProduto>  lista = new List<ListaProduto>();

        ComboBox Produtos = new ComboBox();

        TextBox txtQuantidades = new TextBox();

        TextBox txtPrecosUnidades = new TextBox();

        private decimal PRODUTO_TOTAL = 0;
        public decimal Produto_Total
        {
            get
            {
                return this.PRODUTO_TOTAL;

            }
            set
            {
                this.PRODUTO_TOTAL = value;
            }
        }
        private decimal DESCONTO_VENDA = 0;
        public decimal Desconto_venda
        {
            get
            {
                return this.DESCONTO_VENDA;

            }
            set
            {
                this.DESCONTO_VENDA = value;
            }
        }
        private int LINHA_SELECIONADA = 0;
        public int Linha_Selecionada
        {
            get
            {
                return this.LINHA_SELECIONADA;

            }
            set
            {
                this.LINHA_SELECIONADA = value;
            }
        }

        private int QUANTIDADE_LINHA = 0;
        public int Quantidade_Linha
        {
            get
            {
                return this.QUANTIDADE_LINHA;

            }
            set
            { 
                this.QUANTIDADE_LINHA = value;
            }
        }
        private int NUMERO_LINHAC = 0;
        public int Numero_LinhaC
        {
            get
            {
                return this.NUMERO_LINHAC;

            }
            set
            {
                this.NUMERO_LINHAC = value;
            }
        }

        private int LINHA_ATUALC = 1;
        public int linhaAtualC
        {
            get
            {
                return this.LINHA_ATUALC;

            }
            set
            {
                this.LINHA_ATUALC = value;
            }
        }

        private int CONTADOR = 1;
        public int Contador
        {
            get
            {
                return this.CONTADOR;

            }
            set
            {
                this.CONTADOR = value;
            }
        }
        //ComboBox Produtos = new ComboBox();
        Rectangle _Rectangle;

        private string PRODUTONOME = "";
        public string ProdutoNome
        {
            get
            {
                return this.PRODUTONOME;

            }
            set
            {
                this.PRODUTONOME = value;
            }
        }
        private decimal TEMPTOTAL = 0;
        public decimal TempTotal
        {
            get
            {
                return this.TEMPTOTAL;

            }
            set
            {
                this.TEMPTOTAL = value;
            }
        }
        private string PRODUTO = "";
        public string Produto
        {
            get
            {
                return this.PRODUTO;

            }
            set
            {
                this.PRODUTO = value;
            }
        }
        private int QUANTIDADE = 0;
        public int Quantidade
        {
            get
            {
                return this.QUANTIDADE;

            }
            set
            {
                this.QUANTIDADE = value;
            }
        }

        private decimal VALORUNITARIO1 = 0;
        public decimal Valor_Unitário1
        {
            get
            {
                return this.VALORUNITARIO1;

            }
            set
            {
                this.VALORUNITARIO1 = value;
            }
        }
        private int ID_PESSOA_LOGADA = 0;
        public int IdPessoaLogada
        {
            get
            {
                return this.ID_PESSOA_LOGADA;

            }
            set
            {
                this.ID_PESSOA_LOGADA = value;
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
        private int NUMERO_OS_LIVRE = 0;
        public int NumeroOsLivre
        {
            get
            {
                return this.NUMERO_OS_LIVRE;

            }
            set
            {
                this.NUMERO_OS_LIVRE = value;
            }
        }
        private string NOMEACESSO = "";
        public string NomeAcesso
        {
            get
            {
                return this.NOMEACESSO;

            }
            set
            {
                this.NOMEACESSO = value;
            }
        }
        private int ID_NUMERO_VENDA = 0;
        public int IdNumeroVenda
        {
            get
            {
                return this.ID_NUMERO_VENDA;

            }
            set
            {
                this.ID_NUMERO_VENDA = value;
            }
        }
        public int ID_FORMA_PAGAMENTO = 0;
        public int IdFormaPagamento
        {
            get
            {
                return this.ID_FORMA_PAGAMENTO;

            }
            set
            {
                this.ID_FORMA_PAGAMENTO = value;
            }
        }
        public int ID_CONTATO = 0;
        public int IdContato
        {
            get
            {
                return this.ID_CONTATO;

            }
            set
            {
                this.ID_CONTATO = value;
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
        //Strings endereços
        private string TIPO_LOGRADOURO = "";
        public string Tipologradouro
        {
            get
            {
                return this.TIPO_LOGRADOURO;

            }
            set
            {
                this.TIPO_LOGRADOURO = value;
            }
        }
        private string ENDERECOOS = "";
        public string EnderecoOS
        {
            get
            {
                return this.ENDERECOOS;

            }
            set
            {
                this.ENDERECOOS = value;
            }
        }
        private string COMPLEMENTOS = "";
        public string Complementos
        {
            get
            {
                return this.COMPLEMENTOS;

            }
            set
            {
                this.COMPLEMENTOS = value;
            }
        }
        private string BAIRRONUMERO = "";
        public string BairroNumero
        {
            get
            {
                return this.BAIRRONUMERO;

            }
            set
            {
                this.BAIRRONUMERO = value;
            }
        }
        private string BAIRRO = "";
        public string Bairro
        {
            get
            {
                return this.BAIRRO;

            }
            set
            {
                this.BAIRRO = value;
            }
        }
        private string CIDADE = "";
        public string Cidade
        {
            get
            {
                return this.CIDADE;

            }
            set
            {
                this.CIDADE = value;
            }
        }
        private string SERVICOEXECUTADO = "";
        public string ServicoExecutado
        {
            get
            {
                return this.SERVICOEXECUTADO;

            }
            set
            {
                this.SERVICOEXECUTADO = value;
            }
        }
        private string COMBOBOXABREVIACAO = "";
        public string ComboBoxAbreviacao
        {
            get
            {
                return this.COMBOBOXABREVIACAO;

            }
            set
            {
                this.COMBOBOXABREVIACAO = value;
            }
        }

        private string ORIGEM_SERVICO = "";
        public string OrigemServico
        {
            get
            {
                return this.ORIGEM_SERVICO;

            }
            set
            {
                this.ORIGEM_SERVICO = value;
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
        public FormProdutoVenda()
        {
            InitializeComponent();
        }

        public FormProdutoVenda(string NomeServidor, string NomeBaseDados, string NomeUsuario, string SenhaBaseDados)
        {
            InitializeComponent();
            
            try
            {
                this.dateTimePickerDataEntrega.Value = DateTime.Now.Date;
                this.dateTimePickerDataVenda.Value = DateTime.Now.Date;

                this.NomeServidor = NomeServidor;
                this.NomeBaseDados = NomeBaseDados;
                this.NomeUsuario = NomeUsuario;
                this.SenhaBaseDados = SenhaBaseDados;

                this.connetionString = "Data Source=" + this.NomeServidor + ";Initial Catalog=" + this.NomeBaseDados + ";Persist Security Info=True;User ID=" + this.NomeUsuario + ";Password=" + this.SenhaBaseDados + ";";

                dataGridViewProdutoVenda.Rows.Add("0","0", "Bem vindo, seleciona",
                "na coluna ", "produto", "para compra!");

                this.Quantidade_Linha = int.Parse(dataGridViewProdutoVenda.RowCount.ToString());

                dataGridViewProdutoVenda.Controls.Add(this.Produtos);
                //produtos.Format = DateTimePickerFormat.Custom;
                this.Produtos.SelectedIndexChanged += new EventHandler(comboBoxProdutos_SelectedIndexChanged);
                this.Produtos.Visible = false;

                AlterarBotao(1);
            }
            catch (Exception)
            {

            }
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

        private void FormProdutoVenda_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
            {
                this.Close();
            }
        }

        private void FormProdutoVenda_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridViewProdutoVenda.ColumnCount; i++)
            {
                dataGridViewProdutoVenda.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }
        public void AlterarBotao(int B)
        {
            //Cadastra novo Produto de venda
            if (1 == B)
            {
                panelN1.Enabled = true;
                panelN2.Enabled = true;
                dataGridViewProdutoVenda.Enabled = true;
                ConsultaProdutoNumeroVenda();
                buttonNovaVenda.Enabled = false;
                Fill_listBoxFormaPagamento();
            }
            if (2 == B)
            {

            }
        }
        public void ConsultaProdutoNumeroVenda()
        {
            try
            {
                SqlConnection conn = new SqlConnection(this.connetionString);

                SqlDataAdapter da = new SqlDataAdapter("EXEC D_V_ConsultaCadastroNVendaProduto ", conn);
                DataSet ds = new DataSet();
                da.Fill(ds);

                if (!(ds.Tables[0].Rows.Count > 0))
                {
                    IdNumeroVenda = 1;
                    txtNumeroVenda.Text = " N° " + IdNumeroVenda.ToString();
                    conn.Close();
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    int soma = int.Parse(ds.Tables[0].Rows[0][0].ToString());
                    IdNumeroVenda = 1 + soma;
                    txtNumeroVenda.Text = " N° " + IdNumeroVenda.ToString();
                    conn.Close();
                }
            }catch(Exception ex)
            {
                ex.ToString();
            }

        }

        private void buttonNovaVenda_Click(object sender, EventArgs e)
        {
            AlterarBotao(1);
        }
        //LISTA OS Fucionarios da Empresa
        void Fill_listBoxFormaPagamento()
        {
            SqlConnection connection = new SqlConnection(this.connetionString);

            try
            {
                connection.Open();
                string Query = "EXEC D_V_ConsultaFormaPagamento;";


                SqlCommand command = new SqlCommand(Query, connection);
                SqlDataReader dr = command.ExecuteReader();
                while (dr.Read())
                {
                    string name = dr.GetString(1);
                    comboBoxModoPagamento.Items.Add(name);
                }
                connection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void comboBoxModoPagamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(this.connetionString);

            try
            {
                connection.Open();

                string Query = "exec D_V_ConsultaFormaPagamentoTxT '" + this.comboBoxModoPagamento.Text + "';";

                SqlCommand command = new SqlCommand(Query, connection);
                SqlDataReader dr = command.ExecuteReader();
                while (dr.Read())
                {
                    IdProduto = dr.GetInt32(0);
                    textBox1.Text = dr.GetString(1);
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        void Fill_listBoxListaProduto()
        {
                SqlConnection connection = new SqlConnection(this.connetionString);

                try
                {
                    connection.Open();
                    string Query = "EXEC D_V_ConsultaProdutoAtivosVendas;";


                    SqlCommand command = new SqlCommand(Query, connection);
                    SqlDataReader dr = command.ExecuteReader();
                    while (dr.Read())
                    {
                        string name = dr.GetString(1);
                        //ComboBox Produtos = e.Control as ComboBox;
                        this.Produtos.Items.Add(name);
                        this.ProdutoNome = name;
                    }
                    connection.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            //Selecionar_Produto.ToString();
            
        
        private void comboBoxProdutos_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                txtDescontoCompras.Clear();
                txtValorPago.Text = null;
                txtTroco.Text = null;
                txtValorPago.Clear();
                txtTroco.Clear();

                SqlConnection connection = new SqlConnection(this.connetionString);

                connection.Open();

                string Query = "SELECT * FROM Pr_ProdutoNome PN " +
                                "INNER JOIN Pr_Produto P " +
                                "on PN.ID_PRODUTO_NOME = P.ID_NOME_PRODUTO " +
                                "WHERE NOME = '" + Produtos.Text.ToString() + "';";
                SqlCommand command = new SqlCommand(Query, connection);
                SqlDataReader dr = command.ExecuteReader();
                while (dr.Read())
                {
                    int IdProdutoBase = dr.GetInt32(0);
                    Boolean confirmacao = false;
                    decimal PrecoCustoB = dr.GetDecimal(14);
                    decimal PrecoVendaB = dr.GetDecimal(14);
                    int Quantidade1 = dr.GetInt32(18);
                    string PrecoCustoString = AdicionadoVZ(PrecoCustoB.ToString());
                    string PrecoVendaString = AdicionadoVZ(PrecoVendaB.ToString());

                    int i = 0;
                    
                    if (Linha_Selecionada == 0)
                    {
                        this.Produtos.Visible = false;
                        this.Linha_Selecionada.ToString();
                        DataGridViewCell cell = null;
                        cell = this.dataGridViewProdutoVenda.Rows[0].Cells[2];
                        cell.ReadOnly = true;
                        break;
                    }

                    if (Contador == 1)
                    {
                        dataGridViewProdutoVenda.Rows.Add("", "", "Selecione Produto",
                        "Quantidade", "Valor Unitário", "Valor Total");

                        dataGridViewProdutoVenda.Rows[this.Linha_Selecionada].Cells[0].Value = Linha_Selecionada;
                        dataGridViewProdutoVenda.Rows[this.Linha_Selecionada].Cells[1].Value = IdProdutoBase;
                        dataGridViewProdutoVenda.Rows[this.Linha_Selecionada].Cells[2].Value = Produtos.Text.ToString();
                        dataGridViewProdutoVenda.Rows[this.Linha_Selecionada].Cells[3].Value = 1;
                        dataGridViewProdutoVenda.Rows[this.Linha_Selecionada].Cells[4].Value = PrecoCustoString;
                        dataGridViewProdutoVenda.Rows[this.Linha_Selecionada].Cells[5].Value = PrecoCustoString;
                        Contador++;

                        if ((dataGridViewProdutoVenda.Columns[2].Name == "ProdutoB") 
                            && (VerificarObjeto(dataGridViewProdutoVenda.Rows[Linha_Selecionada].Cells[1].Value) == false))
                        {
                            this.Produtos.Visible = false;

                            DataGridViewCell cell = null;
                            cell = this.dataGridViewProdutoVenda.Rows[Linha_Selecionada].Cells[2];
                            cell.ReadOnly = true;
                        }
                    }
                    if (Contador > 1)
                    {
                        for (i = 1; i < this.Quantidade_Linha - 1; i++)
                        {
                            //compara se o produto já existe
                            //int DataGring = int.Parse(dataGridViewProdutoVenda.Rows[i].Cells[1].Value.ToString());
                            //int a = this.linhaAtual - 1;
                            //i.ToString();
                            //a.ToString();
                            if (dataGridViewProdutoVenda.Rows[i].Cells[1].Value.ToString() == IdProdutoBase.ToString())
                            {
                                dataGridViewProdutoVenda.Rows.Add("", "", "Selecione Produto",
                                "Quantidade", "Valor Unitário", "Valor Total");

                                //dataGridViewProdutoVenda.Rows[this.Numero_Linha].Cells[0].Value = Numero_Linha;
                                //dataGridViewProdutoVenda.Rows[this.Numero_Linha].Cells[1].Value = IdProdutoBase;
                                //dataGridViewProdutoVenda.Rows[this.Numero_Linha].Cells[2].Value = Produtos.Text.ToString();
                                //dataGridViewProdutoVenda.Rows[this.Numero_Linha].Cells[3].Value = 1;
                                //dataGridViewProdutoVenda.Rows[this.Numero_Linha].Cells[4].Value = PrecoCustoString;
                                //dataGridViewProdutoVenda.Rows[this.Numero_Linha].Cells[5].Value = PrecoCustoString;

                                //dataGridViewProdutoVenda.Rows.RemoveAt(Numero_Linha);
                                dataGridViewProdutoVenda.Refresh();
                                dataGridViewProdutoVenda.Rows.RemoveAt(Linha_Selecionada);
                                //dataGridViewProdutoVenda.Rows.Remove(dataGridViewProdutoVenda.Rows[1]);
                                dataGridViewProdutoVenda.Refresh();
                                this.Produtos.Visible = false;

                                confirmacao = true;
                                //DataGridViewCell cell = null;
                                //cell = this.dataGridViewProdutoVenda.Rows[Contador].Cells[2];
                                //cell.ReadOnly = true;
                                break;
                            }
                        }
                        if (confirmacao == false)
                        {
                            if (VerificarObjeto(dataGridViewProdutoVenda.Rows[Linha_Selecionada].Cells[1].Value) == true)
                            {
                                dataGridViewProdutoVenda.Rows.Add("", "", "Selecione Produto",
                                "Quantidade", "Valor Unitário", "Valor Total");

                                dataGridViewProdutoVenda.Rows[this.Linha_Selecionada].Cells[0].Value = Linha_Selecionada;
                                dataGridViewProdutoVenda.Rows[this.Linha_Selecionada].Cells[1].Value = IdProdutoBase;
                                dataGridViewProdutoVenda.Rows[this.Linha_Selecionada].Cells[2].Value = Produtos.Text.ToString();
                                dataGridViewProdutoVenda.Rows[this.Linha_Selecionada].Cells[3].Value = 1;
                                dataGridViewProdutoVenda.Rows[this.Linha_Selecionada].Cells[4].Value = PrecoCustoString;
                                dataGridViewProdutoVenda.Rows[this.Linha_Selecionada].Cells[5].Value = PrecoCustoString;
                                Contador.ToString();
                                Contador++;

                                if ((dataGridViewProdutoVenda.Columns[2].Name == "ProdutoB")
                                    && (VerificarObjeto(dataGridViewProdutoVenda.Rows[Linha_Selecionada].Cells[1].Value) == false))
                                {
                                    this.Produtos.Visible = false;

                                    DataGridViewCell cell = null;
                                    cell = this.dataGridViewProdutoVenda.Rows[Linha_Selecionada].Cells[2];
                                    cell.ReadOnly = true;
                                }

                                break;
                            }
                            if (VerificarObjeto(dataGridViewProdutoVenda.Rows[Linha_Selecionada].Cells[1].Value) == false)
                            {
                                dataGridViewProdutoVenda.Rows[this.Linha_Selecionada].Cells[0].Value = Linha_Selecionada;
                                dataGridViewProdutoVenda.Rows[this.Linha_Selecionada].Cells[1].Value = IdProdutoBase;
                                dataGridViewProdutoVenda.Rows[this.Linha_Selecionada].Cells[2].Value = Produtos.Text.ToString();
                                dataGridViewProdutoVenda.Rows[this.Linha_Selecionada].Cells[3].Value = 1;
                                dataGridViewProdutoVenda.Rows[this.Linha_Selecionada].Cells[4].Value = PrecoCustoString;
                                dataGridViewProdutoVenda.Rows[this.Linha_Selecionada].Cells[5].Value = PrecoCustoString;
                                Contador.ToString();

                                break;
                            }
                        }
                    }
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                this.Refresh();
                CalcularQuantidadeValorTotalCompra(0);
                txtResultadoTotal.Text = this.Produto_Total.ToString();
            }
        }
            //    //resultadoNumero_Linha.ToString();
        //    if ((VerificarObjeto(dataGridViewProdutoVenda.Rows[linhaAtual].Cells[1].Value) == true))
        //    {
        //        linhaAtual.ToString();
        //        dataGridViewProdutoVenda.Rows.Add("", "", "Selecione Produto",
        //        "Quantidade", "Valor Unitário", "Valor Total");
        //        dataGridViewProdutoVenda.Rows[Numero_Linha - 1].Cells[0].Value = Numero_Linha;
        //        dataGridViewProdutoVenda.Rows[Numero_Linha - 1].Cells[1].Value = IdProdutoBase;
        //        dataGridViewProdutoVenda.Rows[Numero_Linha - 1].Cells[2].Value = Produtos.Text.ToString();
        //        dataGridViewProdutoVenda.Rows[Numero_Linha - 1].Cells[3].Value = 1;
        //        dataGridViewProdutoVenda.Rows[Numero_Linha - 1].Cells[4].Value = ValorTotal;
        //        dataGridViewProdutoVenda.Rows[Numero_Linha - 1].Cells[5].Value = ValorTotal;
        //        Contador++;
        //        Contador.ToString();
        //        break;
        //    }
        //    //if ((VerificarObjeto(dataGridViewProdutoVenda.Rows[linhaAtual].Cells[1].Value) == false))
        //    //{
        //    //    linhaAtual.ToString();
        //    //    dataGridViewProdutoVenda.Rows[linhaAtual - 1].Cells[0].Value = Numero_Linha;
        //    //    dataGridViewProdutoVenda.Rows[linhaAtual - 1].Cells[1].Value = IdProdutoBase;
        //    //    dataGridViewProdutoVenda.Rows[linhaAtual - 1].Cells[2].Value = Produtos.Text.ToString();
        //    //    dataGridViewProdutoVenda.Rows[linhaAtual - 1].Cells[3].Value = 1;
        //    //    dataGridViewProdutoVenda.Rows[linhaAtual - 1].Cells[4].Value = ValorTotal;
        //    //    dataGridViewProdutoVenda.Rows[linhaAtual - 1].Cells[5].Value = ValorTotal;
        //    //    Contador++;
        //    //    Contador.ToString();
        //    //    break;
        //    //}
        //}


        //    //se a primeira coluna estiver em branco
        //    if (dataGridViewProdutoVenda.Rows[i].Cells[1].Value.ToString() != IdProdutoBase.ToString()
        //        && (VerificarObjeto(dataGridViewProdutoVenda.Rows[Numero_Linha-1].Cells[1].Value) == true))
        //    {
        //        dataGridViewProdutoVenda.Rows.Add("", "", "Selecione Produto",
        //        "Quantidade", "Valor Unitário", "Valor Total");

        //        dataGridViewProdutoVenda.Rows[Numero_Linha - 1].Cells[0].Value = Numero_Linha;
        //        dataGridViewProdutoVenda.Rows[Numero_Linha - 1].Cells[1].Value = IdProdutoBase;
        //        dataGridViewProdutoVenda.Rows[Numero_Linha - 1].Cells[2].Value = Produtos.Text.ToString();
        //        dataGridViewProdutoVenda.Rows[Numero_Linha - 1].Cells[3].Value = 1;
        //        dataGridViewProdutoVenda.Rows[Numero_Linha - 1].Cells[4].Value = ValorTotal;
        //        dataGridViewProdutoVenda.Rows[Numero_Linha - 1].Cells[5].Value = ValorTotal;

        //        //dataGridViewProdutoVenda.Rows.RemoveAt(Numero_Linha);
        //        dataGridViewProdutoVenda.Refresh();
        //        dataGridViewProdutoVenda.Rows.RemoveAt(Numero_Linha - 1);
        //        //dataGridViewProdutoVenda.Rows.Remove(dataGridViewProdutoVenda.Rows[1]);
        //        dataGridViewProdutoVenda.Refresh();
        //        this.Produtos.Visible = false;
        //        confirmacao = true;

        //        //DataGridViewCell cell = null;
        //        //cell = this.dataGridViewProdutoVenda.Rows[Contador].Cells[2];
        //        //cell.ReadOnly = true;

        //        Contador++;
        //        break;
        //    }
        //    //se a primeira coluna não estiver em branco
        //    if (dataGridViewProdutoVenda.Rows[i].Cells[1].Value.ToString() != IdProdutoBase.ToString()
        //        && (VerificarObjeto(dataGridViewProdutoVenda.Rows[Numero_Linha-1].Cells[1].Value) == false))
        //    {
        //        dataGridViewProdutoVenda.Rows[Numero_Linha - 1].Cells[1].Value = IdProdutoBase;
        //        dataGridViewProdutoVenda.Rows[Numero_Linha - 1].Cells[2].Value = Produtos.Text.ToString();
        //        dataGridViewProdutoVenda.Rows[Numero_Linha - 1].Cells[3].Value = 1;
        //        dataGridViewProdutoVenda.Rows[Numero_Linha - 1].Cells[4].Value = ValorTotal;
        //        dataGridViewProdutoVenda.Rows[Numero_Linha - 1].Cells[5].Value = ValorTotal;

        //        //dataGridViewProdutoVenda.Rows.RemoveAt(Numero_Linha);
        //        dataGridViewProdutoVenda.Refresh();
        //        dataGridViewProdutoVenda.Rows.RemoveAt(Numero_Linha - 1);
        //        //dataGridViewProdutoVenda.Rows.Remove(dataGridViewProdutoVenda.Rows[1]);
        //        dataGridViewProdutoVenda.Refresh();
        //        this.Produtos.Visible = false;
        //        confirmacao = true;
        //        Numero_Linha.ToString();
        //        Contador.ToString();

        //        break;
        //    }
        //}
        //se não consta o produto ele Add


        //    //dataGridViewProdutoVenda.Rows[dataGridViewProdutoVenda.Rows.Count - 1].Cells[3].Value = ValorTotal;
        //    //dataGridViewProdutoVenda.Rows[dataGridViewProdutoVenda.Rows.Count - 1].Cells[4].Value = ValorTotal;
        //    //Quantidade = Quantidade1;


        //    //DataGridViewRow selecionaColuna = dataGridViewProdutoVenda.Rows[Numero_Linha - 1];


        //    //txtDesconto.Text = selecionaColuna.Cells[3].Value.ToString();

        //    //txtDesconto.Text = dataGridViewProdutoVenda.Rows[Numero_Linha - 1].Cells[3].Value.ToString();

        //    //MessageBox.Show(" Numero da Linha " + Numero_Linha + /*" Id Produto" + IdProduto +*/ " Produtos " + Produtos.Text.ToString() + " ValorTotal " + ValorTotal);
        //    //if (dataGridViewProdutoVenda.Rows[Numero_Linha - 1].Cells[3].Value.ToString() == "Valor Unitário")
        //    //{
        //    //    MessageBox.Show("Linha em Branco");
        //    //}
        //    //if (!dataGridViewProdutoVenda.Rows[Numero_Linha - 1].Cells[3].Value.Equals("Valor Unitário"))
        //    //{
        //    //    MessageBox.Show("Linha não esta em Branco");
        //    //}

        //    //AdicionadoVZ(PrecoVenda.ToString());
        //    //MessageBox.Show(" IdProduto " + IdProduto + " PrecoCusto " + PrecoCusto + " PrecoVenda " + PrecoVenda);
        //    //MessageBox.Show("22222222222222");

        public static string AdicionadoVZ(string VALORES)
        {
            try
            {
                Boolean vigula = false;

                StringBuilder sb = new StringBuilder(VALORES);

                int quantString = VALORES.Length;

                for (int i = 0; i < quantString; i++)
                {
                    if (VALORES[i] == ',')
                    {
                        vigula = true;
                        break;
                    }

                }
                if (vigula == false)
                {
                    sb.Insert(quantString, ",00");
                    VALORES = sb.ToString();
                }
                return VALORES;
            }

            catch (Exception exp)
            {
                return exp.ToString();
            }
        }
        private void txtDesconto_TextChanged(object sender, EventArgs e)
        {
            Moeda(ref txtDesconto);           
        }

        private void txtValorPago_TextChanged(object sender, EventArgs e)
        {
            Moeda(ref txtValorPago);
        }

        private void txtTroco_TextChanged(object sender, EventArgs e)
        {
            Moeda(ref txtTroco);

        }
        public void Quantidades_TextChanged(object sender, System.EventArgs e)
        {
            try
            {
            }
            catch (Exception ex )
            {
                ex.ToString();
            }
            finally
            {
                this.Refresh();
            }
             
        }
        private void button1_Click(object sender, EventArgs e)
        {
            dataGridViewProdutoVenda.Refresh();

            

            //int LinhaTotal = int.Parse(dataGridViewProdutoVenda.RowCount.ToString());

            //int i = 0;
            //decimal TotalCalcuado = 0;
            //if (LinhaTotal >= 1)
            //{
            //    for (i = 0; i < LinhaTotal - 1; i++)
            //    {
            //            decimal Quantidadecalcula = decimal.Parse(dataGridViewProdutoVenda.Rows[i].Cells[3].Value.ToString());
            //            decimal ValorUnitario = decimal.Parse(dataGridViewProdutoVenda.Rows[i].Cells[4].Value.ToString());
            //            dataGridViewProdutoVenda.Rows[i].Cells[5].Value = Quantidadecalcula * ValorUnitario;
            //            dataGridViewProdutoVenda.Refresh();
            //    }
            //}
            //if (LinhaTotal >= 1)
            //{
            //    for (i = 0; i < LinhaTotal - 1; i++)
            //    {

            //        decimal  TotalCalcular = decimal.Parse(dataGridViewProdutoVenda.Rows[i].Cells[5].Value.ToString());
            //        TotalCalcuado = TotalCalcular + TotalCalcuado;
            //        dataGridViewProdutoVenda.Refresh();
            //    }
            //}
            //txtTotal.Text = TotalCalcuado.ToString();     
            //try
            //{
            //    Produto = dataGridViewProdutoVenda[0, 0].Value.ToString();
            //    Quantidade = int.Parse(dataGridViewProdutoVenda[1, 0].Value.ToString());
            //    Valor_Unitario = decimal.Parse(dataGridViewProdutoVenda[2, 0].Value.ToString());
            //    ValorTotal = decimal.Parse(dataGridViewProdutoVenda[3, 0].Value.ToString());

            //    int linhaAtual = int.Parse(dataGridViewProdutoVenda.RowCount.ToString());
            //    int i = 0;
            //    linhaAtual = linhaAtual - 2;
            //    for (i = 0; i <= linhaAtual; i++)
            //    {
            //        i.ToString();
            //        linhaAtual.ToString();
            //        Produto = dataGridViewProdutoVenda[0, i].Value.ToString();
            //        Quantidade = int.Parse(dataGridViewProdutoVenda[1, i].Value.ToString());
            //        Valor_Unitario = decimal.Parse(dataGridViewProdutoVenda[2, i].Value.ToString());
            //        ValorTotal = decimal.Parse(dataGridViewProdutoVenda[3, i].Value.ToString());

            //        //MessageBox.Show("Produto " + Produto + " Quantidade: " + Quantidade + " Valor Unitario " + Valor_Unitario +
            //        //" Valor Total " + ValorTotal + " i " + i);

            //    }
            //try
            //{
            //    int linhaAtual = int.Parse(dataGridViewProdutoVenda.RowCount.ToString());
            //    int i = 0;
            //    decimal soma = 0;
            //    linhaAtual = linhaAtual - 2;
            //    for (i = 0; i <= linhaAtual; i++)
            //    {
            //        TempTotal = decimal.Parse(dataGridViewProdutoVenda[3, i].Value.ToString());
            //        soma = soma + TempTotal;
            //    }
            //    txtValorPago.Text = soma.ToString();

            //}
            //catch (Exception ex)
            //{
            //    ex.ToString();
            //}

        }
        private void dataGridViewProdutoVenda_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            try
            {
                this.txtQuantidades = (TextBox)e.Control;

                this.txtPrecosUnidades = (TextBox)e.Control;

                
                //TextBox PrecosUnidades = e.Control as TextBox;

                TextBox TotalPrecos = e.Control as TextBox;

                DataGridViewTextBoxCell cell = (DataGridViewTextBoxCell)dataGridViewProdutoVenda.CurrentCell;

                if (txtQuantidades != null && cell.OwningColumn == dataGridViewProdutoVenda.Columns[3])
                {
                    // Remove any existing handler
                    txtQuantidades.KeyPress -= QuantidadeV;
                    // Add the new handler
                    txtQuantidades.KeyPress += QuantidadeV;

                    //     Quantidades.TextChanged -= new EventHandler(Quantidades_TextChanged);
                   // txtQuantidades.TextChanged += new EventHandler(Quantidades_TextChanged);
                }
                if (txtPrecosUnidades != null && cell.OwningColumn == dataGridViewProdutoVenda.Columns[4])
                {
                    // Remove any existing handler
                    txtPrecosUnidades.KeyPress -= PrecosUnidadesV;
                    // Add the new handler
                    txtPrecosUnidades.KeyPress += PrecosUnidadesV;
                    //     txtPrecosUnidades.TextChanged += new EventHandler(Quantidades_TextChanged);

                }
                if (TotalPrecos != null && cell.OwningColumn == dataGridViewProdutoVenda.Columns[5])
                {

                    // Remove any existing handler
                    TotalPrecos.KeyPress -= TotalPrecosV;
                    // Add the new handler
                    TotalPrecos.KeyPress += TotalPrecosV;

                }
               

                //if (PrecosUnidades != null)
                //{
                //    // Remove any existing handler
                //    PrecosUnidades.KeyPress -= Conversao;
                //    // Add the new handler
                //    PrecosUnidades.KeyPress += Conversao;

                //    Moeda(ref PrecosUnidades);
                //}
                //if (TotalPrecos != null)
                //{
                //    // Remove any existing handler
                //    TotalPrecos.KeyPress -= Conversao2;
                //    // Add the new handler
                //    TotalPrecos.KeyPress += Conversao2;

                //    Moeda(ref TotalPrecos);

                //}
                //MessageBox.Show("333333333333");
            }
            catch (Exception)
            {

            }     
        }
        //public void CalculaQualidade()
        //{
        //    decimal Quantidadecalcula = 0;
        //    decimal ValorUnitario = 0;
        //    decimal ValorTotal = 0;

        //    int linhaAtual = int.Parse(dataGridViewProdutoVenda.RowCount.ToString());

        //    Quantidadecalcula = decimal.Parse(dataGridViewProdutoVenda.Rows[linhaAtual - 1].Cells[3].Value.ToString());
        //    ValorUnitario = decimal.Parse(dataGridViewProdutoVenda.Rows[linhaAtual - 1].Cells[4].Value.ToString());
        //    ValorTotal = Quantidadecalcula * ValorUnitario;
        //    dataGridViewProdutoVenda.Rows[linhaAtual - 1].Cells[5].Value = ValorTotal;
        //}

        private void ProdutoV(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            try
            {

            }
            catch (Exception)
            {
            }
        }
        private void QuantidadeV(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            try
            {
                if (dataGridViewProdutoVenda.CurrentCell.ColumnIndex == 3)
                {
                    //Se a tecla digitada não for número
                    if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
                    {
                        //Atribui True no Handled para cancelar o evento
                        e.Handled = true;
                    }
                }
            }
            catch (Exception)
            {
            }
                        
        }
        private void PrecosUnidadesV(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            try
            {
                if (dataGridViewProdutoVenda.CurrentCell.ColumnIndex == 4)
                {
                    //Se a tecla digitada não for número
                    if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
                    {
                        //Atribui True no Handled para cancelar o evento
                        e.Handled = true;
                    }
                    Moeda2(ref txtPrecosUnidades);
                }
            }
            catch (Exception)
            {
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
                n = n.PadLeft(1, '0');
                
                if (n.Length > 3 & n.Substring(0, 1) == "0")
                    n = n.Substring(1, n.Length - 1);//-1
                v = Convert.ToDouble(n) / 100;
                txt.Text = string.Format("{0:N}", v);
                txt.SelectionStart = txt.Text.Length-1;

                

            }
            catch (Exception e)
            {
                MessageBox.Show("Erro" + e);
            }
        }
        //private void txtPrecosUnidades_TextChanged(object sender, EventArgs e)
        //{
        //    Moeda(ref this.txtPrecosUnidades);
        //}
        //private void PrecosUnidadesV(object sender, System.Windows.Forms.KeyPressEventArgs e)
        //{
        //    try
        //    {
        //        if (dataGridViewProdutoVenda.CurrentCell.ColumnIndex == 4)
        //        {
        //            //Se a tecla digitada não for número

        //            if (!Char.IsControl(e.KeyChar))
        //            {
        //                //Atribui True no Handled para cancelar o evento
        //                e.Handled = true;
        //            }
        //        }
        //    }
        //    catch (Exception)
        //    {
        //    }
        //}
        private void TotalPrecosV(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            try
            {
                if (dataGridViewProdutoVenda.CurrentCell.ColumnIndex == 5)
                {
                    //Se a tecla digitada não for número
                    if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
                    {
                        //Atribui True no Handled para cancelar o evento
                        e.Handled = true;
                    }
                }
            }
            catch (Exception)
            {
            }
        }

        void tb_KeyPress2(object sender, KeyPressEventArgs e)
        {
            // Aceita apenas Letras, BackSpace(apagar) e Espaço
            if (!char.IsLetter(e.KeyChar) && !(e.KeyChar == (char)Keys.Back) && !(e.KeyChar == (char)Keys.Space))
            {
                e.Handled = true;
            }
        }
        bool VerificarObjeto(object obj)
        {
            try
            {
                object objeto = obj;
                if (objeto == null)
                {
                    return true;
                }
                else return false;
            }
            catch(Exception ex)
            {
                ex.ToString();
                return true;
            }
            
        }
        public void CalcularQuantidadeValorTotalCompra(int entrada)
        {
            try
            {
                Boolean aceito = false;

                int QuantidadeRecebido = 0;

                decimal ValorUnitario = 0;

                decimal Valor_Somado = 0;

                for (int i = 1; i < (Quantidade_Linha - entrada); i++)
                {
                    ValorUnitario = decimal.Parse(dataGridViewProdutoVenda.Rows[i].Cells[4].Value.ToString());

                    if (VerificarObjeto(dataGridViewProdutoVenda.Rows[i].Cells[3].Value) == true)
                    {
                        dataGridViewProdutoVenda.Rows[i].Cells[3].Value = 1;
                    }
                    if (VerificarObjeto(dataGridViewProdutoVenda.Rows[i].Cells[3].Value) == false)
                    {
                        QuantidadeRecebido = int.Parse(dataGridViewProdutoVenda.Rows[i].Cells[3].Value.ToString());

                        QuantidadeRecebido.ToString();

                        if (QuantidadeRecebido <= 0)
                        {
                            dataGridViewProdutoVenda.Rows[i].Cells[3].Value = 1;
                        }
                        if (QuantidadeRecebido == 1)
                        {
                            dataGridViewProdutoVenda.Rows[i].Cells[5].Value = ValorUnitario;
                        }
                        if (QuantidadeRecebido > 1)
                        {

                        }
                    }
                    if ((i + 1) == (Quantidade_Linha - entrada))
                    {
                        aceito = true;
                    }
                }
                if (aceito == true)
                {

                    for (int i = 1; i < (Quantidade_Linha - entrada); i++)
                    {
                        decimal ValorTotal = 0;

                        QuantidadeRecebido = int.Parse(dataGridViewProdutoVenda.Rows[i].Cells[3].Value.ToString());
                        ValorUnitario = decimal.Parse(dataGridViewProdutoVenda.Rows[i].Cells[4].Value.ToString());

                        ValorTotal = QuantidadeRecebido * ValorUnitario;
                        dataGridViewProdutoVenda.Rows[i].Cells[5].Value = ValorTotal;
                        Valor_Somado = Valor_Somado + ValorTotal;            
                        
                        dataGridViewProdutoVenda.Rows[Quantidade_Linha - entrada].Cells[5].Value = Valor_Somado;

                        Produto_Total = Valor_Somado;
                    }
                }             
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
            finally
            {
                dataGridViewProdutoVenda.Refresh();
                this.Refresh();
            }                          
        }
        public void CalcularValorTotalCompra(int entrada)
        {
            try
            {
                Boolean aceito = false;

                int QuantidadeRecebido = 0;

                decimal UnidadeProduto = 0;

                decimal ValorUnitario = 0;

                decimal Valor_Somado = 0;

                for (int i = 1; i < (Quantidade_Linha - entrada); i++)
                {
                    ValorUnitario = decimal.Parse(dataGridViewProdutoVenda.Rows[i].Cells[4].Value.ToString());

                    if (VerificarObjeto(dataGridViewProdutoVenda.Rows[i].Cells[4].Value) == true)
                    {
                        dataGridViewProdutoVenda.Rows[i].Cells[4].Value = 1;
                    }
                    if (VerificarObjeto(dataGridViewProdutoVenda.Rows[i].Cells[4].Value) == false)
                    {
                        UnidadeProduto = int.Parse(dataGridViewProdutoVenda.Rows[i].Cells[4].Value.ToString());

                        if (UnidadeProduto <= 0)
                        {
                            dataGridViewProdutoVenda.Rows[i].Cells[4].Value = 1;
                        }
                        if (UnidadeProduto == 1)
                        {
                            dataGridViewProdutoVenda.Rows[i].Cells[4].Value = ValorUnitario;
                        }
                        if (UnidadeProduto > 1)
                        {

                        }
                    }
                    if ((i + 1) == (Quantidade_Linha - entrada))
                    {
                        aceito = true;
                    }
                }
                if (aceito == true)
                {

                    for (int i = 1; i < (Quantidade_Linha - entrada); i++)
                    {
                        decimal ValorTotal = 0;

                        UnidadeProduto = int.Parse(dataGridViewProdutoVenda.Rows[i].Cells[3].Value.ToString());
                        ValorUnitario = int.Parse(dataGridViewProdutoVenda.Rows[i].Cells[3].Value.ToString());
                        ValorUnitario = decimal.Parse(dataGridViewProdutoVenda.Rows[i].Cells[4].Value.ToString());

                        ValorTotal = QuantidadeRecebido * ValorUnitario;

                        dataGridViewProdutoVenda.Rows[i].Cells[5].Value = ValorTotal;
                        Valor_Somado = Valor_Somado + ValorTotal;

                        dataGridViewProdutoVenda.Rows[Quantidade_Linha - entrada].Cells[5].Value = Valor_Somado;

                        Produto_Total = Valor_Somado;
                    }
                }
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
            finally
            {
                dataGridViewProdutoVenda.Refresh();
                this.Refresh();
            }
        }
        private void dataGridViewProdutoVenda_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 2)
                {
                    if (e.Value != null)
                    {
                        e.Value = e.Value.ToString();
                    }
                    else e.Value = "Selecione Produto";
                }
                if (e.ColumnIndex == 3)
                {
                    if (e.Value != null)
                    {
                        e.Value = e.Value.ToString();
                    }
                    else e.Value = "Quantidade";
                }
                if (e.ColumnIndex == 4)
                {
                    if (e.Value != null)
                    {
                        //e.Value = Valor_Unitario;
                    }
                    else e.Value = "Valor Unitário";
                }
                if (e.ColumnIndex == 5)
                {
                    if (e.Value != null)
                    {
                        //e.Value = Valor_Total;
                    }
                    else e.Value = "Valor Total";
                }
                if (this.Quantidade_Linha < 2)
                {
                    if ((VerificarObjeto(dataGridViewProdutoVenda.Rows[Quantidade_Linha - 1].Cells[1].Value) == true) &&
                        (VerificarObjeto(dataGridViewProdutoVenda.Rows[Quantidade_Linha].Cells[1].Value) == true))
                    {
                        dataGridViewProdutoVenda.Refresh();
                        dataGridViewProdutoVenda.Rows.RemoveAt(Quantidade_Linha);
                        Contador--;
                    }
                }

                //int j = 1;
                //int LinhaTotal = 20;

                //if (LinhaTotal > 20)
                //{
                //    LinhaTotal.ToString();

                //    for (j = 1; j < LinhaTotal - 1; j++)
                //    {
                //        if (j < LinhaTotal)
                //        {
                //            //texto2.Text = dataGridViewProdutoVenda.Rows[i + 1].Cells[1].Value.ToString();

                //            if (VerificarObjeto(dataGridViewProdutoVenda.Rows[j].Cells[1].Value) == false)
                //            {
                //                //    MessageBox.Show("Tem Elemento");
                //                //dataGridViewProdutoVenda.Rows.Remove(dataGridViewProdutoVenda.Rows[LinhaTotal - 1]);
                //                //dataGridViewProdutoVenda.Refresh();
                //            }

                //            if (VerificarObjeto(dataGridViewProdutoVenda.Rows[j].Cells[1].Value) == true)
                //            {
                //                int Numero_Linha = (1 + int.Parse(dataGridViewProdutoVenda.CurrentRow.Index.ToString()));

                //                Numero_Linha.ToString();
                //                LinhaTotal.ToString();

                //                dataGridViewProdutoVenda.Rows.RemoveAt(2);



                //                Numero_Linha--;
                //                LinhaTotal--;


                //                Numero_Linha.ToString();
                //                LinhaTotal.ToString();

                //                dataGridViewProdutoVenda.Columns.RemoveAt(1);

                //                //int l = 0;
                //                //for(l = 0;l < LinhaTotal; l++)
                //                //{

                //                //    lista.Add(new ListaProduto { IdListaL = string.Format(dataGridViewProdutoVenda.Rows[0].Cells[0].Value.ToString()),
                //                //        IdProdutoL = string.Format(dataGridViewProdutoVenda.Rows[0].Cells[1].Value.ToString()),
                //                //        QuantidadeL = string.Format(dataGridViewProdutoVenda.Rows[0].Cells[2].Value.ToString()),
                //                //        ValorVendidoL = string.Format(dataGridViewProdutoVenda.Rows[0].Cells[3].Value.ToString()),
                //                //        ValorTotalL = string.Format(dataGridViewProdutoVenda.Rows[0].Cells[4].Value.ToString())
                //                //    });
                //                //    lista[0].ValorTotalL.ToString();
                //                //   // MessageBox.Show(" VALORTOTAL" + lista[0].ValorTotalL.ToString());
                //                //}

                //                dataGridViewProdutoVenda.Refresh();


                //                //dataGridViewProdutoVenda.Controls.Add(this.Produtos);
                //                ////produtos.Format = DateTimePickerFormat.Custom;
                //                //this.Produtos.SelectedIndexChanged += new EventHandler(comboBoxProdutos_SelectedIndexChanged);
                //                //this.Produtos.Visible = false;

                //                //dataGridViewProdutoVenda.Refresh();
                //            }

                //            //if (linhaPrimeira.Equals(linhaSegunda))
                //            //{
                //            //    MessageBox.Show("Erro erro");
                //            //    //dataGridViewProdutoVenda.Rows[i].Cells[4].Value = ValorTotal;
                //            //    //dataGridViewProdutoVenda.Rows.Remove(dataGridViewProdutoVenda.Rows[i]);
                //            //}
                //        }
                //        if (j == LinhaTotal)
                //        {

                //        }

                //    }
                //}

            }


            //if (VerificarObjeto(dataGridViewProdutoVenda.Rows[1].Cells[1].Value) == false)
            //{

            //    DataGridViewCell cell0 = null;
            //    DataGridViewCell cell1 = null;
            //    DataGridViewCell cell2 = null;
            //    DataGridViewCell cell3 = null;


            //    cell0 = this.dataGridViewProdutoVenda.Rows[1].Cells[0];
            //    cell1 = this.dataGridViewProdutoVenda.Rows[1].Cells[1];
            //    cell2 = this.dataGridViewProdutoVenda.Rows[1].Cells[2];
            //    cell3 = this.dataGridViewProdutoVenda.Rows[1].Cells[3];



            //    cell0.ReadOnly = true;
            //    cell1.ReadOnly = true;
            //    cell3.ReadOnly = true;
            //}

            catch (Exception ex)
            {
                ex.ToString();
            }
            
        }
        private void dataGridViewProdutoVenda_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                DataGridViewTextBoxCell cell = (DataGridViewTextBoxCell)dataGridViewProdutoVenda.CurrentCell;
                if (cell.ColumnIndex == 3 && e.KeyChar == 13 /* && e == Keys.Tab*/ )
                {
                    CalcularQuantidadeValorTotalCompra(1);
                    txtResultadoTotal.Text = this.Produto_Total.ToString();
                }
                //DataGridViewTextBoxCell cell = (DataGridViewTextBoxCell)dataGridViewProdutoVenda.CurrentCell;
                //if (cell.ColumnIndex == 3 && e.KeyChar == 13 /* && e == Keys.Tab*/ )
                //{
                //    int Numero_Linha = (1 + int.Parse(dataGridViewProdutoVenda.CurrentRow.Index.ToString()));
                //    //if (Keys.Tab)
                //    //{

                //        int Quantidade1 = int.Parse(dataGridViewProdutoVenda.Rows[Numero_Linha].Cells[3].Value.ToString());
                //        Quantidade1.ToString();
                //        decimal valorTotal = decimal.Parse(dataGridViewProdutoVenda.Rows[Numero_Linha].Cells[4].Value.ToString());
                //        valorTotal.ToString();
                //        decimal calculo = Quantidade1 * valorTotal;
                //        calculo.ToString();
                //        dataGridViewProdutoVenda.Rows[Numero_Linha].Cells[5].Value = calculo;
                //    //}
                //}
                //MessageBox.Show("5555555555555");
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
        }
        private void dataGridViewProdutoVenda_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                this.Linha_Selecionada = int.Parse(dataGridViewProdutoVenda.CurrentRow.Index.ToString());
                this.Quantidade_Linha = int.Parse(dataGridViewProdutoVenda.RowCount.ToString());

                if ((dataGridViewProdutoVenda.Columns[e.ColumnIndex].Name == "ProdutoB") && (Linha_Selecionada == 0))
                {
                    DataGridViewCell cell = null;
                    cell = this.dataGridViewProdutoVenda.Rows[0].Cells[2];
                    cell.ReadOnly = true;
                    this.Produtos.Visible = false;
                    DataGridViewCell cell2 = null;
                    cell2 = this.dataGridViewProdutoVenda.Rows[0].Cells[3];
                    cell2.ReadOnly = true;
                    this.Produtos.Visible = false;
                    //Selecionar_Produto = 0;
                }
                if ((dataGridViewProdutoVenda.Columns[e.ColumnIndex].Name == "ProdutoB") && (VerificarObjeto(dataGridViewProdutoVenda.Rows[this.Contador].Cells[1].Value) == true)
                    && (Linha_Selecionada > 0))
                {
                    _Rectangle = dataGridViewProdutoVenda.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);
                    this.Produtos.Size = new Size(_Rectangle.Width, _Rectangle.Height);
                    this.Produtos.Location = new Point(_Rectangle.X, _Rectangle.Y);
                    this.Produtos.Visible = true;
                    this.Produtos.DropDownStyle = ComboBoxStyle.DropDownList;
                    this.Produtos.Items.Clear();
                    Fill_listBoxListaProduto();
                }
                if ((dataGridViewProdutoVenda.Columns[e.ColumnIndex].Name == "ProdutoB") && (VerificarObjeto(dataGridViewProdutoVenda.Rows[Linha_Selecionada].Cells[1].Value) == false)
                    && (Linha_Selecionada > 0))
                {
                    this.Produtos.Visible = false;

                    DataGridViewCell cell = null;
                    cell = this.dataGridViewProdutoVenda.Rows[Linha_Selecionada].Cells[2];
                    cell.ReadOnly = true;
                }
                if ((dataGridViewProdutoVenda.Columns[e.ColumnIndex].Name == "Quantidade1") && (Quantidade_Linha != 1))
                {
                    CalcularQuantidadeValorTotalCompra(1);

                    this.Linha_Selecionada = int.Parse(dataGridViewProdutoVenda.CurrentRow.Index.ToString());
                    this.Quantidade_Linha = int.Parse(dataGridViewProdutoVenda.RowCount.ToString());

                    if ((VerificarObjeto(dataGridViewProdutoVenda.Rows[Linha_Selecionada].Cells[1].Value) == true))
                    {
                        DataGridViewCell cell = null;
                        cell = this.dataGridViewProdutoVenda.Rows[Linha_Selecionada].Cells[3];
                        cell.ReadOnly = true;
                        this.Produtos.Visible = false;
                    }
                    txtResultadoTotal.Text = this.Produto_Total.ToString();
                }
                if ((dataGridViewProdutoVenda.Columns[e.ColumnIndex].Name == "Valor_Unitario")|| (dataGridViewProdutoVenda.Columns[e.ColumnIndex].Name == "Valor_Total"))
                {
                    this.Linha_Selecionada = int.Parse(dataGridViewProdutoVenda.CurrentRow.Index.ToString());
                    this.Quantidade_Linha = int.Parse(dataGridViewProdutoVenda.RowCount.ToString());

                }
                if ((dataGridViewProdutoVenda.Columns[e.ColumnIndex].Name == "ID_PRODUTOC") ||
                    (dataGridViewProdutoVenda.Columns[e.ColumnIndex].Name == "Valor_Unitario"))
                {
                    this.Linha_Selecionada = int.Parse(dataGridViewProdutoVenda.CurrentRow.Index.ToString());
                    this.Quantidade_Linha = int.Parse(dataGridViewProdutoVenda.RowCount.ToString());

                }
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
            finally
            {
                dataGridViewProdutoVenda.Refresh();
                this.Refresh();
            }
        }

        private void dataGridViewProdutoVenda_Scroll(object sender, ScrollEventArgs e)
        {
            this.Produtos.Visible = false;
        }

        private void dataGridViewProdutoVenda_ColumnMinimumWidthChanged(object sender, DataGridViewColumnEventArgs e)
        {
            this.Produtos.Visible = false;
        }
        void dataGridViewPesquisaNome()
        {
            SqlConnection connection = new SqlConnection(this.connetionString);
            SqlCommand command = new SqlCommand("EXEC D_V_ConsultaProdutoNomeProdutoConstaTxt '" + dataGridViewProdutoVenda[0,0] + ";", connection);
            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = command;
                TableNomeProduto = new DataTable();
                adapter.Fill(TableNomeProduto);
                BindingSource Source = new BindingSource();
                Source.DataSource = TableNomeProduto;
                dataGridViewProdutoVenda.DataSource = Source;
                adapter.Update(TableNomeProduto);
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
            connection.Close();
            //DataTable dt = new DataTable();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                CalcularQuantidadeValorTotalCompra(1);
            }
            catch (Exception ex)
            {
                ex.Message.ToString();
            }
        }

        private void dataGridViewProdutoVenda_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                this.Linha_Selecionada = int.Parse(dataGridViewProdutoVenda.CurrentRow.Index.ToString());

                if ((VerificarObjeto(dataGridViewProdutoVenda.Rows[Linha_Selecionada].Cells[2].Value) == false) && (Linha_Selecionada != 0))
                {
                    DialogResult dialogResult = MessageBox.Show("Deseja Remover " + dataGridViewProdutoVenda.Rows[Linha_Selecionada].Cells[2].Value.ToString() + " ? ", " Aviso", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        dataGridViewProdutoVenda.Rows.RemoveAt(Linha_Selecionada);
                        Contador--;
                        CalcularQuantidadeValorTotalCompra(1);
                    }
                    else if (dialogResult == DialogResult.No)
                    {

                    }
                }                
            }
            catch (Exception)
            {
                e.ToString();
            }
            finally
            {
                this.Refresh();
            }
        }

        private void txtDesconto_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == 13)
                {
                    CalcularQuantidadeValorTotalCompra(0);

                    if (!(txtResultadoTotal.Text == "") && (txtDesconto.Text == ""))
                    {
                        MessageBox.Show("Sem valor para o desconto!");
                    }
                    if ((txtResultadoTotal.Text == "") && !(txtDesconto.Text == ""))
                    {
                        MessageBox.Show("Sem produto de venda!");
                    }
                    if ((txtResultadoTotal.Text == "") && (txtDesconto.Text == ""))
                    {
                        MessageBox.Show("Sem produto de venda e valor de desconto!");
                    }

                    if (!(txtResultadoTotal.Text == "") && !(txtDesconto.Text == ""))
                    {
                        string Segundo = "";

                        Segundo = ConverterValores(txtDesconto.Text);

                        //string TempVenda = "";

                        Decimal PrecoTotal = Produto_Total;
                        Decimal PrecoDesconto = Decimal.Parse(Segundo);

                        decimal PrecoDescontoC = PrecoDesconto / 100;

                        Decimal DescontoProduto = (PrecoTotal * PrecoDescontoC);

                        Decimal retorno = PrecoTotal - DescontoProduto;

                        txtResultadoTotal.Clear();

                        txtDescontoCompras.Clear();

                        txtResultadoTotal.Text = String.Format("{0:0,0.00}", retorno);

                        txtDescontoCompras.Text = String.Format("{0:0,0.00}", DescontoProduto);
                    }
                }
            }
            catch (Exception)
            {
            }       
        }
        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtResultadoTotal_TextChanged(object sender, EventArgs e)
        {
            Moeda(ref txtResultadoTotal);
        }
        public static string ConverterValores(string VALORES)
        {
            try
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

                return ConversaoValores;
            }

            catch (Exception exp)
            {
                return exp.ToString();
            }
        }

        private void txtValorPago_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == 13)
                {
                    CalcularQuantidadeValorTotalCompra(0);

                    if ((txtResultadoTotal.Text == "") && (txtValorPago.Text == ""))
                    {
                        MessageBox.Show("Sem Produto em sistema para calcular!");
                    }
                    if ((txtResultadoTotal.Text == "") && (txtValorPago.Text == ""))
                    {
                        MessageBox.Show("Sem Produto em sistema para calcular e valor do pago em branco!");
                    }

                    if (!(txtResultadoTotal.Text == "") && !(txtValorPago.Text == ""))
                    {
                        string primerio = "";

                        string Segundo = "";

                        primerio = ConverterValores(txtResultadoTotal.Text);

                        Segundo = ConverterValores(txtValorPago.Text);

                        Decimal PrecoTotal = Decimal.Parse(primerio);

                        Decimal PrecoPagamento = Decimal.Parse(Segundo);

                        if (PrecoTotal <= PrecoPagamento)
                        {
                            decimal PrecoTroco = PrecoPagamento - PrecoTotal;

                            txtTroco.Clear();

                            txtTroco.Text = String.Format("{0:0,0.00}", PrecoTroco);
                        }
                        if (PrecoTotal > PrecoPagamento)
                        {
                            decimal PrecoTroco = PrecoPagamento - PrecoTotal;

                            txtTroco.Clear();

                            txtTroco.Text = String.Format("{0:0,0.00}", PrecoTroco);
                        }
                    }
                }
            }
            catch (Exception)
            {
            }
        }

        private void timerValores_Tick(object sender, EventArgs e)
        {

        }
    }
}


//DataGridViewCell cell = null;

//cell = this.dataGridViewProdutoVenda.Rows[0].Cells[2];

//cell.ReadOnly = true;

//if ((VerificarObjeto(dataGridViewProdutoVenda.Rows[1].Cells[1].Value) == true) &&
//    (VerificarObjeto(dataGridViewProdutoVenda.Rows[1].Cells[2].Value) == true))
//{
//    Produto = dataGridViewProdutoVenda[1, 0].Value.ToString();
//    string nome = dataGridViewProdutoVenda[2, 0].Value.ToString();
//    Quantidade = int.Parse(dataGridViewProdutoVenda[3, 0].Value.ToString());
//    decimal Valor_Unitario = decimal.Parse(dataGridViewProdutoVenda[4, 0].Value.ToString());
//    ValorTotal = decimal.Parse(dataGridViewProdutoVenda[5, 0].Value.ToString());

//    dataGridViewProdutoVenda.Rows.RemoveAt(2);
//    dataGridViewProdutoVenda.Rows.RemoveAt(1);
//    dataGridViewProdutoVenda.Refresh();

//    lista.Add(new ListaProduto { IdListaL = "1", IdProdutoL = Produto, QuantidadeL = Quantidade.ToString(),
//        ValorVendidoL = Valor_Unitario.ToString(), ValorTotalL = ValorTotal.ToString() });

//    //                MessageBox.Show(Produto + " Produto " + nome + " nome " + Quantidade +
//    //" Quantidade " + Valor_Unitario + " Valor_Unitario " + ValorTotal);

//    string idLista = lista[0].IdProdutoL;
//    MessageBox.Show("Numero da Id " + idLista);
//}



//private void ProdutoSelecionado(string NomeProduto)
//{
//    SqlConnection connection = new SqlConnection(this.connetionString);

//    try
//    {
//        connection.Open();

//        string Query = "SELECT * FROM Pr_ProdutoNome PN " +
//                       "INNER JOIN Pr_Produto P " + 
//                       "on PN.ID_PRODUTO_NOME = P.ID_NOME_PRODUTO "+
//                       "WHERE NOME = '" + NomeProduto + "';";

//        SqlCommand command = new SqlCommand(Query, connection);
//        SqlDataReader dr = command.ExecuteReader();
//        while (dr.Read())
//        {

//            IdProduto = dr.GetInt32(0);

//            decimal PrecoCustoB = dr.GetDecimal(14);
//            decimal PrecoVendaB = dr.GetDecimal(14);
//            int Quantidade1 = dr.GetInt32(18);
//            string PrecoCustoString = AdicionadoVZ(PrecoCustoB.ToString());
//            string PrecoVendaString = AdicionadoVZ(PrecoVendaB.ToString());

//            Valor_Unitário1 = decimal.Parse(PrecoCustoString);
//            ValorTotal = decimal.Parse(PrecoVendaString);

//            int Numero_Linha = (1 + int.Parse(dataGridViewProdutoVenda.CurrentRow.Index.ToString()));
//            //ListaProduto a = new ListaProduto();
//            //a.IdListaL = 1;


//            List<ListaProduto> resultado = lista.FindAll(x => x.IdListaL == Numero_Linha);

//            resultado.ToString();

//            //if (resultado.Equals(0))
//            //{
//            lista.Add(new ListaProduto { IdListaL = Numero_Linha, IdProdutoL = IdProduto, QuantidadeL = 1, ValorVendidoL = ValorTotal, ValorTotalL = ValorTotal });


//            lista.Count.ToString();


//            MessageBox.Show("A linha foi criada!");
//            //}
//            //if (resultado.Equals(1))
//            //{
//            //    MessageBox.Show("Já consta a linha em base dados!" + Numero_Linha);
//            //}

//            //lista.Add(new ListaProduto { IdListaL = Numero_Linha,IdProdutoL = IdProduto, QuantidadeL = 1, ValorVendidoL = ValorTotal,ValorTotalL = ValorTotal });
//            //this.dataGridViewProdutoVenda.DataSource = lista;
//            //int linhaAtual = int.Parse(dataGridViewProdutoVenda.RowCount.ToString());
//            //int i = 0;
//            //linhaAtual = linhaAtual - 2;
//            //for (i = 0; i <= linhaAtual; i++)
//            //{
//            //    i.ToString();
//            //    linhaAtual.ToString();
//            //    Produto = dataGridViewProdutoVenda[0, i].Value.ToString();
//            //    Quantidade = int.Parse(dataGridViewProdutoVenda[1, i].Value.ToString());
//            //    ValorTotal = decimal.Parse(dataGridViewProdutoVenda[3, i].Value.ToString());
//            //}

//            dataGridViewProdutoVenda.Rows[dataGridViewProdutoVenda.Rows.Count - 1].Cells[0].Value = IdProduto;
//            dataGridViewProdutoVenda.Rows[dataGridViewProdutoVenda.Rows.Count - 1].Cells[3].Value = ValorTotal;
//            dataGridViewProdutoVenda.Rows[dataGridViewProdutoVenda.Rows.Count - 1].Cells[4].Value = ValorTotal;
//            Quantidade = Quantidade1;


//            //AdicionadoVZ(PrecoVenda.ToString());
//            //MessageBox.Show(" IdProduto " + IdProduto + " PrecoCusto " + PrecoCusto + " PrecoVenda " + PrecoVenda);
//        }
//        connection.Close();
//    }
//    catch (Exception ex)
//    {
//        MessageBox.Show(ex.Message);
//    }
//}

//switch (dataGridViewProdutoVenda.Columns[e.ColumnIndex].Name)
//{
//    case "ProdutoB":

//        //DataGridViewTextBoxCell cell = (DataGridViewTextBoxCell)dataGridViewProdutoVenda.CurrentCell;

//        //if (cell.ColumnIndex == 0 && e.KeyChar == 13)
//        //{
//        _Rectangle = dataGridViewProdutoVenda.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);
//        produtos.Size = new Size(_Rectangle.Width, _Rectangle.Height);
//        produtos.Location = new Point(_Rectangle.X, _Rectangle.Y);
//        produtos.Visible = true;
//        produtos.Items.Clear();
//        Fill_listBoxListaProduto();

//        break;

//}


//try
//{
//    DataGridViewTextBoxCell cell = (DataGridViewTextBoxCell)dataGridViewProdutoVenda.CurrentCell;

//    if (cell.ColumnIndex == 0 && e.KeyChar == 13)
//    {
//        _Rectangle = dataGridViewProdutoVenda.GetCellDisplayRectangle(cell.ColumnIndex, cell.RowIndex, false);
//        //produtos.Size = new Size(_Rectangle.Width, _Rectangle.Height);
//        //produtos.Location = new Point(_Rectangle.X, _Rectangle.Y);
//        produtos.Visible = true;
//    }
//}
//catch (Exception)
//{

//}
//try
//{
//    DataGridViewTextBoxCell cell = (DataGridViewTextBoxCell)dataGridViewProdutoVenda.CurrentCell;

//    if (cell.ColumnIndex == 4 && e.KeyChar == 13)
//    {

//        decimal Quantidade1 = Quantidade;
//        decimal calculo  = Quantidade1 * ValorTotal;

//        Quantidade1.ToString();
//        calculo.ToString();
//        dataGridViewProdutoVenda.Rows[dataGridViewProdutoVenda.Rows.Count - 1].Cells[4].Value = calculo;
//    }
//}
//catch (Exception)
//{
//}

// TODO: This line of code loads data into the 'mSOSDataSet.P_Produto' table. You can move, or remove it, as needed.
//this.p_ProdutoTableAdapter.Fill(this.mSOSDataSet.P_Produto);
//// TODO: This line of code loads data into the 'mSOSDataSet.P_ProdutoGrupo' table. You can move, or remove it, as needed.
//this.p_ProdutoGrupoTableAdapter.Fill(this.mSOSDataSet.P_ProdutoGrupo);
//dataGridViewProdutoVenda.EditingControlShowing += new DataGridViewEditingControlShowingEventHandler(dataGridViewProdutoVenda_EditingControlShowing);

//dataGridViewProdutoVenda.CellBeginEdit += new DataGridViewCellCancelEventHandler(dataGridViewProdutoVenda_CellBeginEdit);
//dataGridViewProdutoVenda.EditingControlShowing += new DataGridViewEditingControlShowingEventHandler(dataGridViewProdutoVenda_EditingControlShowing);
//dataGridViewProdutoVenda.CellEndEdit += new DataGridViewCellEventHandler(dataGridViewProdutoVenda_CellEndEdit);
