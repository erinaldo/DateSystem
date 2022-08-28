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
    public partial class FormEntradaNoEstoquePesquisaProduto : Form
    {
        FormEntradaNoEstoque FormEntradaNoEstoqueP;
        FormPontoDeVenda FormPontoDeVendaP;

        DataTable TablePorProduto;
        DataTable TablePorCodigo;
        DataTable TableObservavacao;
        DataTable TableCodigoInterno;

        private int LINHA_SELECIONADAV = 0;
        public int Linha_SelecionadaV
        {
            get
            {
                return this.LINHA_SELECIONADAV;

            }
            set
            {
                this.LINHA_SELECIONADAV = value;
            }
        }
        private int LINHA_SELECIONADAP = 0;
        public int Linha_SelecionadaP
        {
            get
            {
                return this.LINHA_SELECIONADAP;

            }
            set
            {
                this.LINHA_SELECIONADAP = value;
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
        private int VALOR_PESQUISA = 0;
        public int ValorPesquisa
        {
            get
            {
                return this.VALOR_PESQUISA;

            }
            set
            {
                this.VALOR_PESQUISA = value;
            }
        }
        public FormEntradaNoEstoquePesquisaProduto(FormEntradaNoEstoque retorno, string NOMESERVIDOR, string NOMEBASEDADOS, string NOMEUSUARIO, string SENHABASEDADOS, int LINHASELECIONADA)
        {
            InitializeComponent();
            txtPesquisaProduto.MaxLength = 50;


            FormEntradaNoEstoqueP = retorno;
            this.NomeServidor = NOMESERVIDOR;
            this.NomeBaseDados = NOMEBASEDADOS;
            this.NomeUsuario = NOMEUSUARIO;
            this.SenhaBaseDados = SENHABASEDADOS;
            this.Linha_SelecionadaV = LINHASELECIONADA;
            
        }
        public FormEntradaNoEstoquePesquisaProduto(FormPontoDeVenda retorno, string NOMESERVIDOR, string NOMEBASEDADOS, string NOMEUSUARIO, string SENHABASEDADOS, int LINHASELECIONADA)
        {
            InitializeComponent();
            txtPesquisaProduto.MaxLength = 50;


            FormPontoDeVendaP = retorno;
            this.NomeServidor = NOMESERVIDOR;
            this.NomeBaseDados = NOMEBASEDADOS;
            this.NomeUsuario = NOMEUSUARIO;
            this.SenhaBaseDados = SENHABASEDADOS;
            this.Linha_SelecionadaV = LINHASELECIONADA;

        }
        public FormEntradaNoEstoquePesquisaProduto()
        {
            InitializeComponent();
            txtPesquisaProduto.MaxLength = 50;

        }
        private void FormEntradaNoEstoquePesquisaProduto_Load(object sender, EventArgs e)
        {

        }
        private void radioButtonPesquisaPorProduto_CheckedChanged(object sender, EventArgs e)
        {
            labelPesquisa.Text = "Pesquisa por Produto";
        }
        private void radioButtonPesquisaPorCodigo_CheckedChanged(object sender, EventArgs e)
        {
            labelPesquisa.Text = "Pesquisa por Código";
        }

        private void radioButtonPesquisaObservavacao_CheckedChanged(object sender, EventArgs e)
        {
            labelPesquisa.Text = "Observações";
        }

        private void radioButtonCodigoInterno_CheckedChanged(object sender, EventArgs e)
        {
            labelPesquisa.Text = "Código interno";
        }

        private void FormEntradaNoEstoquePesquisaProduto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
            {
                this.Close();
            }
        }

        private void PesquisaProdutoVenda()
        {
            try
            {
                SqlConnection conn = new SqlConnection(this.connetionString);
                if (!(radioButtonPesquisaPorProduto.Checked == true) && !(radioButtonPesquisaPorCodigo.Checked == true) && !(radioButtonPesquisaObservavacao.Checked == true)
                    && !(radioButtonCodigoInterno.Checked == true))
                {
                    MessageBox.Show("Seleciona um modo de busca, por Numero Registro, Descrição do Produto ou Produto ");
                }
                if (radioButtonPesquisaPorProduto.Checked)
                {
                    ValorPesquisa = 1;
                    dataGridViewProdutoVenda.Refresh();

                    label8.Text = "Produtos : " + dataGridViewProdutoVenda.RowCount.ToString();

                    //SELECIONA POR TODOS OS 
                    SqlDataAdapter da1 = new SqlDataAdapter("EXEC   ", conn);
                    DataSet ds1 = new DataSet();
                    da1.Fill(ds1);
                    conn.Open();

                    if (!(ds1.Tables[0].Rows.Count > 0))
                    {
                        if (dataGridViewProdutoVenda.DataSource == null)
                        {
                            dataGridViewProdutoVenda.Refresh();
                        }
                        if (!(dataGridViewProdutoVenda.DataSource == null))
                        {
                            // dataGridViewPesquisaCliente.Columns.Clear();
                            dataGridViewProdutoVenda.Refresh();
                        }
                        label8.Text = "Produtos : " + dataGridViewProdutoVenda.RowCount.ToString();

                        MessageBox.Show("Nem um Produto produto Achado!");
                        conn.Close();
                        ValorPesquisa = 0;
                    }
                    if (ds1.Tables[0].Rows.Count > 0)
                    {
                        conn.Close();

                        dataGridViewPesquisaPorProduto();
                        label8.Text = "Produtos : " + dataGridViewProdutoVenda.RowCount.ToString();
                        ValorPesquisa = 1;
                    }

                }
                if (radioButtonPesquisaPorCodigo.Checked)
                {
                    if (txtPesquisaProduto.Text == "")
                    {
                        //dataGridViewPesquisaCliente.Columns.Clear();
                        dataGridViewProdutoVenda.Refresh();

                        label8.Text = "Produtos : " + dataGridViewProdutoVenda.RowCount.ToString();

                        MessageBox.Show("O Numero não pode esta em Branco!");
                        ValorPesquisa = 0;
                    }
                    if (!(txtPesquisaProduto.Text == ""))
                    {
                        //SELECIONA POR TODOS OS 
                        SqlDataAdapter da1 = new SqlDataAdapter("EXEC   '" + txtPesquisaProduto.Text + "' ;", conn);
                        DataSet ds1 = new DataSet();
                        da1.Fill(ds1);

                        conn.Open();

                        if (!(ds1.Tables[0].Rows.Count > 0))
                        {
                            if (dataGridViewProdutoVenda.DataSource == null)
                            {
                                dataGridViewProdutoVenda.Refresh();
                            }
                            if (!(dataGridViewProdutoVenda.DataSource == null))
                            {
                                //dataGridViewPesquisaCliente.Columns.Clear();
                                dataGridViewProdutoVenda.Refresh();
                            }
                            label8.Text = "Produtos : " + dataGridViewProdutoVenda.RowCount.ToString();

                            MessageBox.Show("Nem numero de Produto por Código Achado!");
                            conn.Close();
                            ValorPesquisa = 0;
                        }
                        if (ds1.Tables[0].Rows.Count > 0)
                        {
                            conn.Close();
                            dataGridViewPesquisaPorCodigo();
                            label8.Text = "Produtos : " + dataGridViewProdutoVenda.RowCount.ToString();
                            ValorPesquisa = 2;
                        }
                    }
                }
                if (radioButtonPesquisaObservavacao.Checked)
                {
                    if (txtPesquisaProduto.Text == "")
                    {
                        //dataGridViewPesquisaCliente.Columns.Clear();
                        dataGridViewProdutoVenda.Refresh();

                        label8.Text = "Produtos : " + dataGridViewProdutoVenda.RowCount.ToString();

                        MessageBox.Show("O Nome não pode esta em Branco!");
                        ValorPesquisa = 0;
                    }
                    if (!(txtPesquisaProduto.Text == ""))
                    {
                        //SELECIONA POR TODOS OS 
                        SqlDataAdapter da1 = new SqlDataAdapter("EXEC   '" + txtPesquisaProduto.Text + "';", conn);
                        DataSet ds1 = new DataSet();
                        da1.Fill(ds1);

                        conn.Open();

                        if (!(ds1.Tables[0].Rows.Count > 0))
                        {
                            if (dataGridViewProdutoVenda.DataSource == null)
                            {
                                dataGridViewProdutoVenda.Refresh();
                            }
                            if (!(dataGridViewProdutoVenda.DataSource == null))
                            {
                                // dataGridViewPesquisaCliente.Columns.Clear();
                                dataGridViewProdutoVenda.Refresh();
                            }
                            label8.Text = "Produtos : " + dataGridViewProdutoVenda.RowCount.ToString();

                            MessageBox.Show("Nem um Registro com Observação foi Achado!");
                            conn.Close();
                            ValorPesquisa = 0;
                        }
                        if (ds1.Tables[0].Rows.Count > 0)
                        {
                            conn.Close();
                            dataGridViewPesquisaObservavacao();
                            label8.Text = "Produtos : " + dataGridViewProdutoVenda.RowCount.ToString();
                            ValorPesquisa = 3;
                        }
                    }
                }
                if (radioButtonCodigoInterno.Checked)
                {
                    if (txtPesquisaProduto.Text == "")
                    {
                        //dataGridViewPesquisaCliente.Columns.Clear();
                        dataGridViewProdutoVenda.Refresh();

                        label8.Text = "Produtos : " + dataGridViewProdutoVenda.RowCount.ToString();

                        MessageBox.Show("O produto não pode esta em Branco!");
                        ValorPesquisa = 4;
                    }
                    if (!(txtPesquisaProduto.Text == ""))
                    {
                        //SELECIONA POR TODOS OS                      
                        SqlDataAdapter da1 = new SqlDataAdapter("Exec  '" + "';", conn);
                        DataSet ds1 = new DataSet();
                        da1.Fill(ds1);

                        conn.Open();

                        if (!(ds1.Tables[0].Rows.Count > 0))
                        {
                            if (dataGridViewProdutoVenda.DataSource == null)
                            {
                                dataGridViewProdutoVenda.Refresh();
                            }
                            if (!(dataGridViewProdutoVenda.DataSource == null))
                            {
                                //dataGridViewPesquisaCliente.Columns.Clear();
                                dataGridViewProdutoVenda.Refresh();
                            }
                            label8.Text = "Produtos : " + dataGridViewProdutoVenda.RowCount.ToString();

                            MessageBox.Show("Nem um produto de registro Achado!");
                            conn.Close();
                            ValorPesquisa = 4;
                        }
                        if (ds1.Tables[0].Rows.Count > 0)
                        {
                            conn.Close();
                            dataGridViewPCodigoInterno();
                            //Fill_listBoxDescricaoProdutoDataGridView();
                            label8.Text = "Produtos : " + dataGridViewProdutoVenda.RowCount.ToString();
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
        private void PesquisaProdutoVendaTeste()
        {
            try
            {
                
                dataGridViewProdutoVenda.Rows.Add("01", "CELULAR MK1", "SAMSUNG", String.Format("{0:0,0.00}", 975,56) , String.Format("{0:0,0.00}", 1110,40) , String.Format("{0:0,0.00}", 1245,25), "12", "UN",
                   String.Format("{0:0,0.00}", 269,69), "", "", "");
                dataGridViewProdutoVenda.Rows.Add("02", "PERFUME SEDUÇÃO", "R7", String.Format("{0:0,0.00}", 1365,60) , String.Format("{0:0,0.00}", 1365,60), String.Format("{0:0,0.00}", 1753,29), "07", "UN",
                   String.Format("{0:0,0.00}", 387,69), "", "", "");
                dataGridViewProdutoVenda.Rows.Add("03", "RELOGIO TAEQS", "TAEQ", String.Format("{0:0,0.00}", 550,33), String.Format("{0:0,0.00}", 641,74), String.Format("{0:0,0.00}", 733,15), "15", "UN",
                    String.Format("{0:0,0.00}", 182,82), "", "", "");
                dataGridViewProdutoVenda.Rows.Add("04", "CELULAR MST", "PANASONIC", String.Format("{0:0,0.00}", 1147,56), String.Format("{0:0,0.00}", 1563,40), String.Format("{0:0,0.00}", 1355,48), "22", "UN",
                String.Format("{0:0,0.00}", 415, 84), "", "", "");
                dataGridViewProdutoVenda.Rows.Add("05", "JAQUETA", "L&L", String.Format("{0:0,0.00}", 2364,44), String.Format("{0:0,0.00}", 4230,36), String.Format("{0:0,0.00}", 3297,40), "15", "UN",
                   String.Format("{0:0,0.00}", 1865, 92), "", "", "");
                dataGridViewProdutoVenda.Rows.Add("06", "BONE CORINTHIANS", "NIKE", String.Format("{0:0,0.00}", 550,33), String.Format("{0:0,0.00}", 396,74), String.Format("{0:0,0.00}", 473, 53), "39", "UN",
                    String.Format("{0:0,0.00}", 40, 25), "", "", "");

            }
            catch
            {

            }
        }
        //String.Format("{0:0,0.00}", Valor_Total)
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
                txt.Text = string.Format("{0:N}", v);//0:N
                txt.SelectionStart = txt.Text.Length;
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro" + e);
            }
        }
        void dataGridViewPesquisaPorProduto()
        {
            SqlConnection connection = new SqlConnection(this.connetionString);
            SqlCommand command = new SqlCommand("Exec  " + ";", connection);
            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = command;
                TablePorProduto = new DataTable();
                adapter.Fill(TablePorProduto);
                BindingSource Source = new BindingSource();
                Source.DataSource = TablePorProduto;
                dataGridViewProdutoVenda.DataSource = Source;
                adapter.Update(TablePorProduto);
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
            //DataTable dt = new DataTable();
        }
        void dataGridViewPesquisaPorCodigo()
        {
            SqlConnection connection = new SqlConnection(this.connetionString);
            SqlCommand command = new SqlCommand("Exec  '" + txtPesquisaProduto.Text + ";", connection);
            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = command;
                TablePorCodigo = new DataTable();
                adapter.Fill(TablePorCodigo);
                BindingSource Source = new BindingSource();
                Source.DataSource = TablePorCodigo;
                dataGridViewProdutoVenda.DataSource = Source;
                adapter.Update(TablePorCodigo);
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
            //DataTable dt = new DataTable();
        }
        void dataGridViewPesquisaObservavacao()
        {
            SqlConnection connection = new SqlConnection(this.connetionString);
            SqlCommand command = new SqlCommand("Exec '" + txtPesquisaProduto.Text + "';", connection);
            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = command;
                TableObservavacao = new DataTable();
                adapter.Fill(TableObservavacao);
                BindingSource Source = new BindingSource();
                Source.DataSource = TableObservavacao;
                dataGridViewProdutoVenda.DataSource = Source;
                adapter.Update(TableObservavacao);

            }
            catch (Exception ex)
            {
                ex.ToString();
            }
        }
        void dataGridViewPCodigoInterno()
        {
            SqlConnection connection = new SqlConnection(this.connetionString);
            SqlCommand command = new SqlCommand("Exec  '" + txtPesquisaProduto + "';", connection);
            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = command;
                DataTable TableCodigoInterno = new DataTable();
                adapter.Fill(TableCodigoInterno);
                BindingSource Source = new BindingSource();
                Source.DataSource = TableCodigoInterno;
                dataGridViewProdutoVenda.DataSource = Source;
                adapter.Update(TableCodigoInterno);
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
        }

        private void txtPesquisaProduto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                PesquisaProdutoVendaTeste();
                //PesquisaProdutoVenda();
            }
        }

        private void dataGridViewProdutoVenda_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                this.Linha_SelecionadaP = dataGridViewProdutoVenda.CurrentRow.Index;
                int Coluna_Chamada = dataGridViewProdutoVenda.CurrentCell.ColumnIndex;

                if (Coluna_Chamada == 0)
                {
                    if (e.KeyCode == Keys.Enter)
                    {
                        string IdProdutoV = "";
                        string NomedoProduto = "";
                        string QuantidadeProduto = "";
                        string ValorUnitario = "";

                        IdProdutoV = dataGridViewProdutoVenda.Rows[Linha_SelecionadaP].Cells[0].Value.ToString();
                        NomedoProduto = dataGridViewProdutoVenda.Rows[Linha_SelecionadaP].Cells[1].Value.ToString();
                        QuantidadeProduto = dataGridViewProdutoVenda.Rows[Linha_SelecionadaP].Cells[6].Value.ToString();
                        ValorUnitario = dataGridViewProdutoVenda.Rows[Linha_SelecionadaP].Cells[5].Value.ToString();

                        FormEntradaNoEstoqueP.Linha_SelecionadaRetorno = this.Linha_SelecionadaV;
                        FormEntradaNoEstoqueP.FormEntradaNoEstoqueIdProduto = IdProdutoV;
                        FormEntradaNoEstoqueP.FormEntradaNoEstoqueNomeProduto = NomedoProduto;
                        FormEntradaNoEstoqueP.FormEntradaNoEstoqueQuantidadeProduto = QuantidadeProduto;
                        FormEntradaNoEstoqueP.FormEntradaNoEstoqueValorUnitario =  ValorUnitario;

                        FormEntradaNoEstoqueP.AdicionandoProdutoVenda();

                        FechatodosOsFormularios(typeof(FormEntradaNoEstoquePesquisaProduto));
                    }
                }
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
        }
        //METODO PARA VERIFICA SE O FORMULÁRIO ESTA ABERTO SE TIVER ELE FECHA!
        public static void FechatodosOsFormularios(Type frmType)
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

        private void dataGridViewProdutoVenda_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                this.Linha_SelecionadaP = int.Parse(dataGridViewProdutoVenda.CurrentRow.Index.ToString());
                int Coluna_Chamada = dataGridViewProdutoVenda.CurrentCell.ColumnIndex;

                if ((Coluna_Chamada == 0)|| (Coluna_Chamada == 1))
                {
                        string IdProdutoV = "";
                        string NomedoProduto = "";
                        string QuantidadeProduto = "";
                        string ValorUnitario = "";

                        IdProdutoV = dataGridViewProdutoVenda.Rows[Linha_SelecionadaP].Cells[0].Value.ToString();
                        NomedoProduto = dataGridViewProdutoVenda.Rows[Linha_SelecionadaP].Cells[1].Value.ToString();
                        QuantidadeProduto = dataGridViewProdutoVenda.Rows[Linha_SelecionadaP].Cells[6].Value.ToString();
                        ValorUnitario = dataGridViewProdutoVenda.Rows[Linha_SelecionadaP].Cells[5].Value.ToString();

                        FormEntradaNoEstoqueP.Linha_SelecionadaRetorno = this.Linha_SelecionadaV;
                        FormEntradaNoEstoqueP.FormEntradaNoEstoqueIdProduto = IdProdutoV;
                        FormEntradaNoEstoqueP.FormEntradaNoEstoqueNomeProduto = NomedoProduto;
                        FormEntradaNoEstoqueP.FormEntradaNoEstoqueQuantidadeProduto = QuantidadeProduto;
                        FormEntradaNoEstoqueP.FormEntradaNoEstoqueValorUnitario = ValorUnitario;

                        FormEntradaNoEstoqueP.AdicionandoProdutoVenda();

                        FechatodosOsFormularios(typeof(FormEntradaNoEstoquePesquisaProduto));                   
                }
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
        }
    }
}
