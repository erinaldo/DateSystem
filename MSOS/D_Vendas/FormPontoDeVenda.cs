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
    public partial class FormPontoDeVenda : Form
    {
        DataTable TableCFornecedor;

        // ComboBox Produtos = new ComboBox();

        TextBox txtQuantidades = new TextBox();

        TextBox txtProdutosPesquisa = new TextBox();

        TextBox txtPrecosUnidades = new TextBox();

        TextBox txtValorTotal = new TextBox();

        TextBox TotalPrecos = new TextBox();

        TextBox BolqueioTela = new TextBox();

        TextBox txMoeda2 = new txtMoeda();

        Rectangle _Rectangle;

        List<String> lista = new List<String> { "Linha_Usada", "Id_Produto,", "Quantidade", "Produto_Pequisado", "Valor_Unitario", "Valor_Total" };

        DataGridViewCell cellProdutoPesquisa = null;

        string valor;

        private string IDCSTCSOPESTOQUE = "";
        public string IdCstCsopEstoque
        {
            get
            {
                return this.IDCSTCSOPESTOQUE;

            }
            set
            {
                this.IDCSTCSOPESTOQUE = value;
            }
        }
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
        private int IDTIPOENTRADAESTOQUE = 0;
        public int IdEntradaEstoque
        {
            get
            {
                return this.IDTIPOENTRADAESTOQUE;

            }
            set
            {
                this.IDTIPOENTRADAESTOQUE = value;
            }
        }
        private int IDESTOQUEFORNECEDOR = 0;
        public int IdEstoqueFornecedor
        {
            get
            {
                return this.IDESTOQUEFORNECEDOR;

            }
            set
            {
                this.IDESTOQUEFORNECEDOR = value;
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
        private int LINHA_SELECIONADAALTERIOR = -1;
        public int Linha_SelecionadaAnterior
        {
            get
            {
                return this.LINHA_SELECIONADAALTERIOR;

            }
            set
            {
                this.LINHA_SELECIONADAALTERIOR = value;
            }
        }
        private int LINHA_SELECIONADA_RETORNO = 0;
        public int Linha_SelecionadaRetorno
        {
            get
            {
                return this.LINHA_SELECIONADA_RETORNO;

            }
            set
            {
                this.LINHA_SELECIONADA_RETORNO = value;
            }
        }
        private int COLUNA_SELECIONADA = 0;
        public int Coluna_Selecionada
        {
            get
            {
                return this.COLUNA_SELECIONADA;

            }
            set
            {
                this.COLUNA_SELECIONADA = value;
            }
        }
        private int COLUNA_SELECIONADAALTERIOR = 0;
        public int Coluna_SelecionadaAnterior
        {
            get
            {
                return this.COLUNA_SELECIONADAALTERIOR;

            }
            set
            {
                this.COLUNA_SELECIONADAALTERIOR = value;
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
        private string QUANTIDADE_PRODUTO = "";
        public string Quantidade_Produto
        {
            get
            {
                return this.QUANTIDADE_PRODUTO;

            }
            set
            {
                this.QUANTIDADE_PRODUTO = value;
            }
        }
        //------------------------------------
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


        //Teste paramentros


        private string FORM_ENTRADA_NO_ESTOQUE_ID_PRODUTO = "";
        public string FormEntradaNoEstoqueIdProduto
        {
            get
            {
                return this.FORM_ENTRADA_NO_ESTOQUE_ID_PRODUTO;

            }
            set
            {
                this.FORM_ENTRADA_NO_ESTOQUE_ID_PRODUTO = value;
            }
        }
        private string FORM_ENTRADA_NO_ESTOQUE_NOME_PRODUTO = "";
        public string FormEntradaNoEstoqueNomeProduto
        {
            get
            {
                return this.FORM_ENTRADA_NO_ESTOQUE_NOME_PRODUTO;

            }
            set
            {
                this.FORM_ENTRADA_NO_ESTOQUE_NOME_PRODUTO = value;
            }
        }
        private string FORM_ENTRADA_NO_ESTOQUE_QUANTIDADE_PRODUTO = "";
        public string FormEntradaNoEstoqueQuantidadeProduto
        {
            get
            {
                return this.FORM_ENTRADA_NO_ESTOQUE_QUANTIDADE_PRODUTO;

            }
            set
            {
                this.FORM_ENTRADA_NO_ESTOQUE_QUANTIDADE_PRODUTO = value;
            }
        }
        private string FORM_ENTRADA_NO_ESTOQUE_VALOR_UNITARIO = "";
        public string FormEntradaNoEstoqueValorUnitario
        {
            get
            {
                return this.FORM_ENTRADA_NO_ESTOQUE_VALOR_UNITARIO;

            }
            set
            {
                this.FORM_ENTRADA_NO_ESTOQUE_VALOR_UNITARIO = value;
            }
        }
        public FormPontoDeVenda()
        {
            InitializeComponent();
        }
        public FormPontoDeVenda(string NOMESERVIDOR, string NOMEBASEDADOS, string NOMEUSUARIO, string SENHABASEDADOS)
        {
            try
            {
                InitializeComponent();

                this.NomeServidor = NOMESERVIDOR;

                this.NomeBaseDados = NOMEBASEDADOS;

                this.NomeUsuario = NOMEUSUARIO;

                this.SenhaBaseDados = SENHABASEDADOS;

                dateTimePickerSaida.Value = DateTime.Now.Date;

                this.connetionString = "Data Source=" + this.NomeServidor + ";Initial Catalog=" + this.NomeBaseDados + ";Persist Security Info=True;User ID=" + this.NomeUsuario + ";Password=" + this.SenhaBaseDados + ";";

                txtPercentual.MaxLength = 9;

                this.Quantidade_Linha = int.Parse(dataGridViewPontoDeVenda.RowCount.ToString());

                txtValorTotalPV.MaxLength = 9;

                txtNDoComprovante.MaxLength = 9;

                txtNotaFiscalNumero.MaxLength = 9;

                txtNotaFiscalSerie.MaxLength = 4;


                //Fill_listBoxEstoqueFornecedor();

                //Fill_listBoxTipoEntradaEstoque();

                //Fill_listBoxCst_CfopEstoque();
            }
            catch (Exception ex)
            {
                ex.ToString();
            }

        }

        private void FormPontoDeVenda_Load(object sender, EventArgs e)
        {

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
            catch (Exception ex)
            {
                ex.ToString();
                return true;
            }

        }
        public void CalcularQuantidadeValorTotal()
        {
            try
            {
                bool ValorFinal = false;

                decimal SomaValorFInal = 0;

                for (int i = 0; i < dataGridViewPontoDeVenda.RowCount - 1; i++)
                {
                    if ((VerificarObjeto(dataGridViewPontoDeVenda.Rows[i].Cells[1].Value) == false))
                    {
                        int QuantidadeRecebido = 0;
                        decimal ValorUnitario = 0;
                        decimal Valor_Total = 0;
                        ValorFinal = true;

                        //string.Format("{0:C}", Convert.ToDouble(this.FormEntradaNoEstoqueValorUnitario));

                        QuantidadeRecebido = int.Parse(dataGridViewPontoDeVenda.Rows[i].Cells[2].Value.ToString());
                        string ValorVerificar = ConverterValores(dataGridViewPontoDeVenda.Rows[i].Cells[4].Value.ToString());

                        string Entrada = ValorVerificar.ToString();
                        string ValorVerificar2 = Entrada.Replace("R$", "");

                        ValorUnitario = decimal.Parse(ValorVerificar2);
                        Valor_Total = QuantidadeRecebido * ValorUnitario;

                        SomaValorFInal = SomaValorFInal + Valor_Total;

                        dataGridViewPontoDeVenda.Rows[i].Cells[5].Value = string.Format("{0:C}", Convert.ToDouble(Valor_Total));
                    }
                }
                if (ValorFinal == true)
                {
                    label12.Text = String.Format("{0:0,0.00}", SomaValorFInal);
                }
                if (ValorFinal == false)
                {
                    label12.Text = "Valor";
                }
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
            finally
            {
                dataGridViewPontoDeVenda.Refresh();
                this.Refresh();
            }
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
        public void ProdutoQuantidadeInicial()
        {
            if (dataGridViewPontoDeVenda.RowCount > 0)
            {
                int LinhasConsta = 0;
                int quantidadeRecebida = 0;

                LinhasConsta = dataGridViewPontoDeVenda.RowCount;

                for (int i = 0; i < LinhasConsta; i++)
                {
                    if ((VerificarObjeto(dataGridViewPontoDeVenda.Rows[i].Cells[1].Value) == false) &&
                        (VerificarObjeto(dataGridViewPontoDeVenda.Rows[i].Cells[2].Value) == false))
                    {
                        quantidadeRecebida = int.Parse(dataGridViewPontoDeVenda.Rows[i].Cells[2].Value.ToString());

                        if (quantidadeRecebida == 0)
                        {
                            dataGridViewPontoDeVenda.Rows[i].Cells[2].Value = 1;
                        }
                    }
                }
            }
        }
        public void ValorLinhadataGridViewEstoque()
        {
            int Linhas = 0;
            for (Linhas = 0; Linhas < dataGridViewPontoDeVenda.Rows.Count; Linhas++)
            {
                dataGridViewPontoDeVenda.Rows[Linhas].Cells[0].Value = Linhas;
            }
        }
        private void QuantidadeV(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            try
            {
                if (dataGridViewPontoDeVenda.CurrentCell.ColumnIndex == 2)
                {
                    if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
                    {
                        e.Handled = true;
                    }

                    if (txtQuantidades.Text.Length == 0)
                    {
                        if (e.KeyChar == '0')
                        {
                            e.Handled = true;
                        }
                    }
                    //Bloqueio Teclado
                    //if (e.KeyChar >= 0 && e.KeyChar <= 127)
                    //{
                    //    e.Handled = true;
                    //}
                    //VerificaZeroEntrada(ref txtQuantidades);


                    //txtQuantidades.TextAlign = HorizontalAlignment.Right;
                }
            }
            catch
            {

            }
        }

        private void PesquisaProdutoV(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            try
            {
                if (dataGridViewPontoDeVenda.CurrentCell.ColumnIndex == 3)
                {
                    //Se a tecla digitada não for número
                    if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
                    {
                        //Atribui True no Handled para cancelar o evento
                        e.Handled = true;
                        txtProdutosPesquisa.ReadOnly = true;
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
                if (dataGridViewPontoDeVenda.CurrentCell.ColumnIndex == 4)
                {
                    if ((VerificarObjeto(dataGridViewPontoDeVenda.Rows[Linha_Selecionada].Cells[3].Value) == true))
                    {
                        //Bloqueio Teclado
                        if (e.KeyChar >= 0 && e.KeyChar <= 127)
                        {
                            e.Handled = true;
                        }
                    }


                    //txtPrecosUnidades.Text = string.Format("{0:N}", double.Parse(txtPrecosUnidades.Text));

                    //txtPrecosUnidades.SelectionStart = txtPrecosUnidades.Text.Length;
                    //MoedaDataGridView(ref txtPrecosUnidades);
                }
            }
            catch (Exception)
            {
            }
        }
        private void ValorTotalV(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            try
            {
                if (dataGridViewPontoDeVenda.CurrentCell.ColumnIndex == 5)
                {
                    //Se a tecla digitada não for número
                    if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
                    {
                        //Atribui True no Handled para cancelar o evento
                        e.Handled = true;
                    }
                    MoedaDataGridView(ref txtValorTotal);
                    //txtValorTotal.TextAlign = HorizontalAlignment.Right;
                }
            }
            catch (Exception)
            {
            }
        }
        private void TotalPrecosV(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            try
            {
                //if (dataGridViewEstoque.CurrentCell.ColumnIndex == 5)
                //{
                //    //Se a tecla digitada não for número
                //    if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
                //    {
                //        //Atribui True no Handled para cancelar o evento
                //        e.Handled = true;
                //    }
                //}
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
                txt.Text = string.Format("{0:N}", v);//0:N
                txt.SelectionStart = txt.Text.Length;
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro" + e);
            }
        }
        public static void MoedaDataGridView(ref TextBox txt)
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
        private void txtPrecosUnidades_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(Keys.Back))
            {
                if (e.KeyChar == ',')
                {

                    e.Handled = (txtPrecosUnidades.Text.Contains(","));
                }
                else
                    e.Handled = true;
            }
        }

        private void txtPrecosUnidades_Leave(object sender, EventArgs e)
        {
            try
            {
                valor = txtPrecosUnidades.Text.Replace("R$", "");
                txtPrecosUnidades.Text = string.Format("{0:C}", Convert.ToDouble(txtPrecosUnidades));
            }
            catch
            {

            }
        }

        private void txtPrecosUnidades_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                valor = txtPrecosUnidades.Text.Replace("R$", "").Replace(",", "").Replace(" ", "").Replace("00,", "");
                if (valor.Length == 0)
                {
                    txtPrecosUnidades.Text = "0,00" + valor;
                }
                if (valor.Length == 1)
                {
                    txtPrecosUnidades.Text = "0,0" + valor;
                }
                if (valor.Length == 2)
                {
                    txtPrecosUnidades.Text = "0," + valor;
                }
                else if (valor.Length >= 3)
                {
                    if (txtPrecosUnidades.Text.StartsWith("0,"))
                    {
                        txtPrecosUnidades.Text = valor.Insert(valor.Length - 2, ",").Replace("0,", "");
                    }
                    else if (txtPrecosUnidades.Text.Contains("00,"))
                    {
                        txtPrecosUnidades.Text = valor.Insert(valor.Length - 2, ",").Replace("00,", "");
                    }
                    else
                    {
                        txtPrecosUnidades.Text = valor.Insert(valor.Length - 2, ",");
                    }
                }
                valor = txtPrecosUnidades.Text;
                txtPrecosUnidades.Text = string.Format("{0:C}", Convert.ToDouble(valor));
                txtPrecosUnidades.Select(txtPrecosUnidades.Text.Length, 0);
            }
            catch
            {

            }
        }
        private void dataGridViewPontoDeVenda_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                this.Linha_Selecionada = int.Parse(dataGridViewPontoDeVenda.CurrentRow.Index.ToString());
                int Coluna_Chamada = dataGridViewPontoDeVenda.CurrentCell.ColumnIndex;

                if (Coluna_Chamada == 3)
                {
                    if ((VerificarObjeto(dataGridViewPontoDeVenda.Rows[Linha_Selecionada].Cells[2].Value) == false) &&
                         (VerificarObjeto(dataGridViewPontoDeVenda.Rows[Linha_Selecionada].Cells[3].Value) == true))
                    {
                        if (e.KeyCode == Keys.Down)
                        {

                            FormEntradaNoEstoquePesquisaProduto FormEntradaNoEstoquePesquisaProdutoP = new FormEntradaNoEstoquePesquisaProduto(
                                this, this.NomeServidor, this.NomeBaseDados, this.NomeUsuario, this.SenhaBaseDados, Linha_Selecionada);
                            FormEntradaNoEstoquePesquisaProdutoP.ShowDialog();
                        }
                    }
                }
                if (Coluna_Chamada == 2 || Coluna_Chamada == 3 || Coluna_Chamada == 4 || Coluna_Chamada == 5)
                {
                    if ((VerificarObjeto(dataGridViewPontoDeVenda.Rows[Linha_Selecionada].Cells[2].Value) == false) &&
                         (VerificarObjeto(dataGridViewPontoDeVenda.Rows[Linha_Selecionada].Cells[4].Value) == false))
                    {
                        if (e.KeyCode == Keys.Enter)
                        {
                            CalcularQuantidadeValorTotal();
                        }
                    }
                }
                if (Coluna_Chamada == 1)
                {
                    if (VerificarObjeto(dataGridViewPontoDeVenda.Rows[Linha_Selecionada].Cells[3].Value) == false)
                    {
                        if (e.KeyCode == Keys.Delete)
                        {
                            DialogResult dialogResultProdutoVenda = MessageBox.Show("Deseja excluir produto de entrada no estoque?", "Aviso", MessageBoxButtons.YesNo);

                            if (dialogResultProdutoVenda == DialogResult.Yes)
                            {
                                dataGridViewPontoDeVenda.Rows.RemoveAt(Linha_Selecionada);
                                ValorLinhadataGridViewEstoque();

                            }
                            else if (dialogResultProdutoVenda == DialogResult.No)
                            {

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
        private void FormPontoDeVenda_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
            {
                this.Close();
            }
        }
        private void dataGridViewPontoDeVenda_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int Coluna_Chamada = dataGridViewPontoDeVenda.CurrentCell.ColumnIndex;
                Linha_Selecionada = dataGridViewPontoDeVenda.CurrentRow.Index;
                if (Coluna_Chamada == 3)
                {
                    if ((VerificarObjeto(dataGridViewPontoDeVenda.Rows[Linha_Selecionada].Cells[2].Value) == false) &&
                         (VerificarObjeto(dataGridViewPontoDeVenda.Rows[Linha_Selecionada].Cells[3].Value) == true))
                    {
                        FormEntradaNoEstoquePesquisaProduto FormEntradaNoEstoquePesquisaProdutoP = new FormEntradaNoEstoquePesquisaProduto(
                            this, this.NomeServidor, this.NomeBaseDados, this.NomeUsuario, this.SenhaBaseDados, Linha_Selecionada);
                        FormEntradaNoEstoquePesquisaProdutoP.ShowDialog();
                    }
                }
                if (Coluna_Chamada == 1)
                {
                    DialogResult dialogResultProdutoVenda = MessageBox.Show("Deseja excluir produto de entrada no estoque?", "Aviso", MessageBoxButtons.YesNo);

                    if (dialogResultProdutoVenda == DialogResult.Yes)
                    {
                        dataGridViewPontoDeVenda.Rows.RemoveAt(Linha_Selecionada);
                        ValorLinhadataGridViewEstoque();

                    }
                    else if (dialogResultProdutoVenda == DialogResult.No)
                    {

                    }
                }

            }
            catch (Exception ex)
            {
                ex.ToString();
            }
        }

        private void dataGridViewPontoDeVenda_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            try
            {
                ValorLinhadataGridViewEstoque();

                TextBox BolqueioTela = e.Control as TextBox;

                this.txtQuantidades = (TextBox)e.Control;

                this.txtProdutosPesquisa = (TextBox)e.Control;

                this.txtPrecosUnidades = (TextBox)e.Control;

                this.txtValorTotal = (TextBox)e.Control;

                this.TotalPrecos = (TextBox)e.Control;

                //TextBox PrecosUnidades = e.Control as TextBox;

                //TextBox TotalPrecos = e.Control as TextBox;

                DataGridViewTextBoxCell cell = (DataGridViewTextBoxCell)dataGridViewPontoDeVenda.CurrentCell;

                this.Linha_Selecionada = int.Parse(dataGridViewPontoDeVenda.CurrentRow.Index.ToString());

                int Coluna_Chamada = dataGridViewPontoDeVenda.CurrentCell.ColumnIndex;

                //if ((VerificarObjeto(dataGridViewEstoque.Rows[Linha_SelecionadaAnterior].Cells[2].Value) == true) &&
                //     (Coluna_Chamada == 0) || (Coluna_Chamada == 1) || (Coluna_Chamada == 3) || (Coluna_Chamada == 4) || (Coluna_Chamada == 5))
                //{
                //    dataGridViewEstoque.CurrentRow.Selected = false;
                //}

                if (txtQuantidades != null && cell.OwningColumn == dataGridViewPontoDeVenda.Columns[2])
                {
                    txtPrecosUnidades.KeyPress -= PrecosUnidadesV;
                    txtPrecosUnidades.KeyPress -= new KeyPressEventHandler(txtPrecosUnidades_KeyPress);
                    txtPrecosUnidades.KeyPress -= new KeyPressEventHandler(txtPrecosUnidades_Leave);
                    txtPrecosUnidades.KeyUp -= new KeyEventHandler(txtPrecosUnidades_KeyUp);

                    // Remove any existing handler
                    txtQuantidades.KeyPress -= QuantidadeV;
                    // Add the new handler
                    txtQuantidades.KeyPress += QuantidadeV;

                    if ((VerificarObjeto(dataGridViewPontoDeVenda.Rows[Linha_Selecionada].Cells[2].Value) == false) &&
                    (VerificarObjeto(dataGridViewPontoDeVenda.Rows[Linha_Selecionada].Cells[3].Value) == false))
                    {
                        this.Linha_SelecionadaAnterior = Linha_Selecionada;
                        Quantidade_Produto = dataGridViewPontoDeVenda.Rows[Linha_Selecionada].Cells[2].Value.ToString();
                    }

                    //txtQuantidades.KeyDown -= new KeyEventHandler(BloqueiaSetas_KeyDown);
                    //txtQuantidades.KeyDown += new KeyEventHandler(BloqueiaSetas_KeyDown);
                }
                if (txtProdutosPesquisa != null && cell.OwningColumn == dataGridViewPontoDeVenda.Columns[3])
                {

                }
                if (txtPrecosUnidades != null && cell.OwningColumn == dataGridViewPontoDeVenda.Columns[4])
                {
                    //Remove any existing handler
                    txtPrecosUnidades.KeyPress -= PrecosUnidadesV;
                    // Add the new handler
                    txtPrecosUnidades.KeyPress += PrecosUnidadesV;

                    txtPrecosUnidades.KeyPress -= new KeyPressEventHandler(txtPrecosUnidades_KeyPress);
                    txtPrecosUnidades.KeyPress += new KeyPressEventHandler(txtPrecosUnidades_KeyPress);

                    txtPrecosUnidades.KeyPress -= new KeyPressEventHandler(txtPrecosUnidades_Leave);
                    txtPrecosUnidades.KeyPress += new KeyPressEventHandler(txtPrecosUnidades_Leave);

                    txtPrecosUnidades.KeyUp -= new KeyEventHandler(txtPrecosUnidades_KeyUp);
                    txtPrecosUnidades.KeyUp += new KeyEventHandler(txtPrecosUnidades_KeyUp);


                }

                if (txtValorTotal != null && cell.OwningColumn == dataGridViewPontoDeVenda.Columns[5])
                {
                    // Remove any existing handler
                    txtValorTotal.KeyPress -= ValorTotalV;
                    // Add the new handler
                    txtValorTotal.KeyPress += ValorTotalV;

                }
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
        }

        private void dataGridViewPontoDeVenda_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                //int Coluna_Chamada = dataGridViewEstoque.CurrentCell.ColumnIndex;

                //Verifica se Quantidade é validada
                if (Linha_SelecionadaAnterior != -1)
                {
                    Linha_SelecionadaAnterior.ToString();
                    if ((VerificarObjeto(dataGridViewPontoDeVenda.Rows[Linha_SelecionadaAnterior].Cells[2].Value) == true) &&
                        (VerificarObjeto(dataGridViewPontoDeVenda.Rows[Linha_SelecionadaAnterior].Cells[3].Value) == false))
                    {
                        dataGridViewPontoDeVenda.Rows[Linha_SelecionadaAnterior].Cells[2].Value = this.Quantidade_Produto.ToString();
                        MessageBox.Show("Adicionado produto, quantidade não pode ficar em branco!");
                        Linha_SelecionadaAnterior = -1;
                    }
                }
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
        }

        private void buttonFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtPercentual_TextChanged(object sender, EventArgs e)
        {
            Moeda(ref txtPercentual);
            txtPercentual.TextAlign = HorizontalAlignment.Right;
        }

        private void txtPercentual_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Se a tecla digitada não for número
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }
        }

        private void txtNDoComprovante_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Se a tecla digitada não for número
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }
        }

        private void txtNotaFiscalNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Se a tecla digitada não for número
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }
        }

        private void txtNotaFiscalSerie_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Se a tecla digitada não for número
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if(radioButtonAvista.Checked == true)
            {
                int a = 4;
                int b = 7;
                int t = a + b;

                string d = Convert.ToString(t);

                MessageBox.Show(d);
            }

        }
    }
}
