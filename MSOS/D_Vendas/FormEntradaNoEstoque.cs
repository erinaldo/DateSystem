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
    public partial class FormEntradaNoEstoque : Form
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
        public FormEntradaNoEstoque()
        {
            InitializeComponent();
        }
        public FormEntradaNoEstoque(string NOMESERVIDOR, string NOMEBASEDADOS, string NOMEUSUARIO, string SENHABASEDADOS)
        {
            try
            {
                InitializeComponent();

                this.NomeServidor = NOMESERVIDOR;

                this.NomeBaseDados = NOMEBASEDADOS;

                this.NomeUsuario = NOMEUSUARIO;

                this.SenhaBaseDados = SENHABASEDADOS;

                dateTimePickerEntradaNota.Value = DateTime.Now.Date;

                this.connetionString = "Data Source=" + this.NomeServidor + ";Initial Catalog=" + this.NomeBaseDados + ";Persist Security Info=True;User ID=" + this.NomeUsuario + ";Password=" + this.SenhaBaseDados + ";";

                txtConsultarFornecedor.MaxLength = 50;

                this.Quantidade_Linha = int.Parse(dataGridViewEstoque.RowCount.ToString());

                txtNumeroNota.MaxLength = 9;

                //Fill_listBoxEstoqueFornecedor();

                //Fill_listBoxTipoEntradaEstoque();

                //Fill_listBoxCst_CfopEstoque();
            }
            catch (Exception ex)
            {
                ex.ToString();
            }

        }


        private void dataGridViewFornecedores_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!(dataGridViewFornecedores.RowCount == 0))
            {
                try
                {
                    this.IdEstoqueFornecedor = Convert.ToInt32(dataGridViewFornecedores["ID", e.RowIndex].Value);
                    comboBoxFornecedor.SelectedItem = Convert.ToString(dataGridViewFornecedores["NOME1", e.RowIndex].Value);

                }
                catch (Exception ex)
                {
                    ex.ToString();
                }
            }
        }
        
        private void FormEntradaNoEstoque_Load(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                ex.ToString();
            }
        }
        private void FormEntradaNoEstoque_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
            {
                this.Close();
            }
        }
        private void dataGridViewEstoque_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                this.Linha_Selecionada = int.Parse(dataGridViewEstoque.CurrentRow.Index.ToString());
                int Coluna_Chamada = dataGridViewEstoque.CurrentCell.ColumnIndex;

                if (Coluna_Chamada == 3)
                {
                    if ((VerificarObjeto(dataGridViewEstoque.Rows[Linha_Selecionada].Cells[2].Value) == false) &&
                         (VerificarObjeto(dataGridViewEstoque.Rows[Linha_Selecionada].Cells[3].Value) == true))
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
                    if ((VerificarObjeto(dataGridViewEstoque.Rows[Linha_Selecionada].Cells[2].Value) == false) &&
                         (VerificarObjeto(dataGridViewEstoque.Rows[Linha_Selecionada].Cells[4].Value) == false))
                    {
                        if (e.KeyCode == Keys.Enter)
                        {
                            CalcularQuantidadeValorTotal();
                        }
                    }
                }
                if (Coluna_Chamada == 1)
                {
                    if (VerificarObjeto(dataGridViewEstoque.Rows[Linha_Selecionada].Cells[3].Value) == false)
                    {
                        if (e.KeyCode == Keys.Delete)
                        {
                            DialogResult dialogResultProdutoVenda = MessageBox.Show("Deseja excluir produto de entrada no estoque?", "Aviso", MessageBoxButtons.YesNo);

                            if (dialogResultProdutoVenda == DialogResult.Yes)
                            {
                                dataGridViewEstoque.Rows.RemoveAt(Linha_Selecionada);
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
        private void dataGridViewEstoque_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                //int Coluna_Chamada = dataGridViewEstoque.CurrentCell.ColumnIndex;

                //Verifica se Quantidade é validada
                if (Linha_SelecionadaAnterior != -1)
                {
                    Linha_SelecionadaAnterior.ToString();
                    if ((VerificarObjeto(dataGridViewEstoque.Rows[Linha_SelecionadaAnterior].Cells[2].Value) == true) &&
                        (VerificarObjeto(dataGridViewEstoque.Rows[Linha_SelecionadaAnterior].Cells[3].Value) == false))
                    {
                        dataGridViewEstoque.Rows[Linha_SelecionadaAnterior].Cells[2].Value = this.Quantidade_Produto.ToString();
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
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                AdicionandoProdutoVenda();

            }
            catch (Exception ex)
            {
                ex.ToString();
            }

        }
        private void timerVerfiicaCampo_Tick_1(object sender, EventArgs e)
        {
            //if ((VerificarObjeto(dataGridViewEstoque.Rows[Linha_Selecionada].Cells[2].Value) == true) &&
            //    (VerificarObjeto(dataGridViewEstoque.Rows[Linha_Selecionada].Cells[3].Value) == false))
            //{
            //    if (this.dataGridViewEstoque.Rows[Linha_Selecionada].Cells[2].Value == null)
            //    {
            //        timerVerfiicaCampo.Stop();
            //        dataGridViewEstoque.Rows[Linha_Selecionada].Cells[2].Value = this.Quantidade_Produto.ToString();
            //        MessageBox.Show("Adicionado produto, quantidade não pode ficar em branco!");
            //        timerVerfiicaCampo.Start();
            //    }
            //}
        }

        private void buttonFecharOs_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void txtTesteNumero_KeyDown(object sender, KeyEventArgs e)
        {
            //if ((e.KeyCode == Keys.Left) || e.KeyCode == Keys.Right || e.KeyCode == Keys.Up || e.KeyCode == Keys.Down
            //    || e.KeyCode == Keys.Delete)
            //{
            //    e.Handled = true;
            //}
        }

        private void txtTesteNumero_TextChanged(object sender, EventArgs e)
        {
            //Moeda2(ref txtTesteNumero);
            //txtTesteNumero.Text = string.Format("{0:N}", double.Parse(txtTesteNumero.Text));
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

        private void dataGridViewEstoque_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int Coluna_Chamada = dataGridViewEstoque.CurrentCell.ColumnIndex;
                Linha_Selecionada = dataGridViewEstoque.CurrentRow.Index;
                if (Coluna_Chamada == 3)
                {
                    if ((VerificarObjeto(dataGridViewEstoque.Rows[Linha_Selecionada].Cells[2].Value) == false) &&
                         (VerificarObjeto(dataGridViewEstoque.Rows[Linha_Selecionada].Cells[3].Value) == true))
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
                        dataGridViewEstoque.Rows.RemoveAt(Linha_Selecionada);
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
        private void dataGridViewEstoque_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
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

                DataGridViewTextBoxCell cell = (DataGridViewTextBoxCell)dataGridViewEstoque.CurrentCell;

                this.Linha_Selecionada = int.Parse(dataGridViewEstoque.CurrentRow.Index.ToString());

                int Coluna_Chamada = dataGridViewEstoque.CurrentCell.ColumnIndex;

                //if ((VerificarObjeto(dataGridViewEstoque.Rows[Linha_SelecionadaAnterior].Cells[2].Value) == true) &&
                //     (Coluna_Chamada == 0) || (Coluna_Chamada == 1) || (Coluna_Chamada == 3) || (Coluna_Chamada == 4) || (Coluna_Chamada == 5))
                //{
                //    dataGridViewEstoque.CurrentRow.Selected = false;
                //}

                if (txtQuantidades != null && cell.OwningColumn == dataGridViewEstoque.Columns[2])
                {
                    txtPrecosUnidades.KeyPress -= PrecosUnidadesV;
                    txtPrecosUnidades.KeyPress -= new KeyPressEventHandler(txtPrecosUnidades_KeyPress);
                    txtPrecosUnidades.KeyPress -= new KeyPressEventHandler(txtPrecosUnidades_Leave);
                    txtPrecosUnidades.KeyUp -= new KeyEventHandler(txtPrecosUnidades_KeyUp);

                    // Remove any existing handler
                    txtQuantidades.KeyPress -= QuantidadeV;
                    // Add the new handler
                    txtQuantidades.KeyPress += QuantidadeV;

                    if ((VerificarObjeto(dataGridViewEstoque.Rows[Linha_Selecionada].Cells[2].Value) == false) &&
                    (VerificarObjeto(dataGridViewEstoque.Rows[Linha_Selecionada].Cells[3].Value) == false))
                    {
                        this.Linha_SelecionadaAnterior = Linha_Selecionada;
                        Quantidade_Produto = dataGridViewEstoque.Rows[Linha_Selecionada].Cells[2].Value.ToString();
                    }

                    //txtQuantidades.KeyDown -= new KeyEventHandler(BloqueiaSetas_KeyDown);
                    //txtQuantidades.KeyDown += new KeyEventHandler(BloqueiaSetas_KeyDown);
                }
                if (txtProdutosPesquisa != null && cell.OwningColumn == dataGridViewEstoque.Columns[3])
                {

                }
                if (txtPrecosUnidades != null && cell.OwningColumn == dataGridViewEstoque.Columns[4])
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

                if (txtValorTotal != null && cell.OwningColumn == dataGridViewEstoque.Columns[5])
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
        //Metodos
        void Fill_listBoxEstoqueFornecedor()
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
                int situacao = 0;
                if (checkBoxSituacao.Checked == true)
                {
                    situacao = 1;
                }
                connection.Open();
                //ESTA PROCEDURE NAO EXISTE
                string Query = "exec D_ConsultaFornecedorNomeCadastroContatostxt '" + this.comboBoxFornecedor.Text + "'" + "," + situacao + ";";

                SqlCommand command = new SqlCommand(Query, connection);
                SqlDataReader dr = command.ExecuteReader();
                while (dr.Read())
                {

                    IdEstoqueFornecedor = dr.GetInt32(0);
                    comboBoxFornecedor.Text = dr.GetString(2);
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        void Fill_listBoxTipoEntradaEstoque()
        {
            SqlConnection connection = new SqlConnection(this.connetionString);

            try
            {
                connection.Open();
                string Query = "EXEC D_V_ConsultaTipoDeEntradaEstoque;";


                SqlCommand command = new SqlCommand(Query, connection);
                SqlDataReader dr = command.ExecuteReader();
                while (dr.Read())
                {
                    string name = dr.GetString(1);
                    comboBoxTipoEntrada.Items.Add(name);
                }
                connection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void comboBoxTipoEntrada_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(this.connetionString);

            try
            {
                connection.Open();
                //ESTA PROCEDURE NAO EXISTE
                string Query = "exec D_V_ConsultaTipoDeEntradaEstoqueTxt '" + this.comboBoxTipoEntrada.Text + "';";

                SqlCommand command = new SqlCommand(Query, connection);
                SqlDataReader dr = command.ExecuteReader();
                while (dr.Read())
                {

                    IdEntradaEstoque = dr.GetInt32(0);
                    comboBoxTipoEntrada.Text = dr.GetString(1);
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        void Fill_listBoxCst_CfopEstoque()
        {
            SqlConnection connection = new SqlConnection(this.connetionString);

            try
            {
                connection.Open();
                string Query = "EXEC D_V_ConsultaCst_CfopEntradaEstoque;";


                SqlCommand command = new SqlCommand(Query, connection);
                SqlDataReader dr = command.ExecuteReader();
                while (dr.Read())
                {
                    string name = dr.GetString(0);
                    comboBoxCFOP.Items.Add(name);
                }
                connection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void comboBoxCFOP_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(this.connetionString);

            try
            {
                connection.Open();
                //ESTA PROCEDURE NAO EXISTE
                string Query = "exec D_V_ConsultaCst_CfopEntradaEstoqueTxt '" + this.comboBoxCFOP.Text + "';";

                SqlCommand command = new SqlCommand(Query, connection);
                SqlDataReader dr = command.ExecuteReader();
                while (dr.Read())
                {

                    IdCstCsopEstoque = dr.GetString(0);
                    comboBoxCFOP.Text = dr.GetString(0);
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void txtConsultarItens_TextChanged(object sender, EventArgs e)
        {
            if (this.ValorPesquisa == 4)
            {
                DataView DV = new DataView(TableCFornecedor);
                DV.RowFilter = string.Format("NOME LIKE '%{0}%'", txtConsultarFornecedor.Text);
                dataGridViewFornecedores.DataSource = DV;
                label4.Text = "Pesquisa Fornecedor n°: " + dataGridViewFornecedores.RowCount.ToString();
            }
        }

        private void txtConsultarFornecedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                ObjetosCadastrados();
            }
        }
        public void ObjetosCadastrados()
        {
            try
            {
                SqlConnection conn = new SqlConnection(this.connetionString);

                if (txtConsultarFornecedor.Text == "")
                {
                    SqlDataAdapter da1 = new SqlDataAdapter("Exec D_V_ConsultaFornecedorCadastroVenda;", conn);
                    DataSet ds1 = new DataSet();
                    da1.Fill(ds1);

                    conn.Open();

                    if (!(ds1.Tables[0].Rows.Count > 0))
                    {
                        if (dataGridViewFornecedores.DataSource == null)
                        {
                            dataGridViewFornecedores.Refresh();
                        }
                        if (!(dataGridViewFornecedores.DataSource == null))
                        {
                            //dataGridViewPesquisa.Columns.Clear();
                            dataGridViewFornecedores.Refresh();
                        }
                        label4.Text = "Pesquisa Fornecedor n°: " + 0;
                        MessageBox.Show("Nem um fornecedor Achado!");

                        conn.Close();
                    }
                    if (ds1.Tables[0].Rows.Count > 0)
                    {
                        ValorPesquisa = 4;
                        dataGridViewPesquisaFornecedorNome();
                        label4.Text = "Pesquisa Fornecedor n°: " + dataGridViewFornecedores.RowCount.ToString();
                        conn.Close();
                    }
                }
                if (!(txtConsultarFornecedor.Text == ""))
                {
                    SqlDataAdapter da1 = new SqlDataAdapter("Exec D_V_ConsultaFornecedorCadastroVendaTxt '" + txtConsultarFornecedor.Text + "';", conn);
                    DataSet ds1 = new DataSet();
                    da1.Fill(ds1);

                    conn.Open();

                    if (!(ds1.Tables[0].Rows.Count > 0))
                    {
                        if (dataGridViewFornecedores.DataSource == null)
                        {
                            dataGridViewFornecedores.Refresh();
                        }
                        if (!(dataGridViewFornecedores.DataSource == null))
                        {
                            //dataGridViewPesquisa.Columns.Clear();
                            dataGridViewFornecedores.Refresh();
                        }
                        label4.Text = "Pesquisa Fornecedor n°: " + 0;
                        MessageBox.Show("Nem um fornecedor Achado!");

                        conn.Close();
                    }
                    if (ds1.Tables[0].Rows.Count > 0)
                    {
                        ValorPesquisa = 4;
                        dataGridViewPesquisaFornecedorNome();
                        label4.Text = "Pesquisa Fornecedor n°: " + dataGridViewFornecedores.RowCount.ToString();
                        conn.Close();
                    }

                }
            }
            catch (Exception e)
            {
                e.ToString();
            }
        }
        //FORNECEDOR
        void dataGridViewPesquisaFornecedorNome()
        {
            SqlConnection connection = new SqlConnection(this.connetionString);
            SqlCommand command = new SqlCommand("Exec D_V_ConsultaFornecedorCadastroVendaTxt '" + txtConsultarFornecedor.Text + "';", connection);
            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = command;
                TableCFornecedor = new DataTable();
                adapter.Fill(TableCFornecedor);
                BindingSource Source = new BindingSource();
                Source.DataSource = TableCFornecedor;
                dataGridViewFornecedores.DataSource = Source;
                adapter.Update(TableCFornecedor);
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
        }
        private void BloqueiaSetas_KeyDown(object sender, KeyEventArgs e)
        {
            //if ((e.KeyCode == Keys.Left) || e.KeyCode == Keys.Right || e.KeyCode == Keys.Up || e.KeyCode == Keys.Down
            //    || e.KeyCode == Keys.Delete)
            //{
            //    e.Handled = true;
            //}
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
        public static void VerificaZeroEntrada(ref TextBox txt)
        {
            string n = txt.Text;
            try
            {
                StringBuilder sb = new StringBuilder(n);
                string StringTeste = n;

                StringTeste.Length.ToString();
                if (StringTeste.Length == 0)
                {

                }
                if (StringTeste.Length != 0)
                {
                    if (StringTeste[0] == '0')
                    {
                        sb.ToString();
                        sb.Remove(0, 1);
                        n = sb.ToString();
                    }
                    if ((StringTeste[0] != '0') && (StringTeste.Length > 0))
                    {

                        n = sb.ToString();
                    }
                }
                txt.Text = n.ToString();

                StringTeste.Length.ToString();

                txt.SelectionStart = txt.Text.Length;

            }
            catch (Exception e)
            {
                MessageBox.Show("Erro" + e);
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
                    // this.ProdutosCadastrado.Items.Add(name);
                    this.ProdutoNome = name;
                }
                connection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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

                for (int i = 0; i < dataGridViewEstoque.RowCount - 1; i++)
                {
                    if ((VerificarObjeto(dataGridViewEstoque.Rows[i].Cells[1].Value) == false))
                    {
                        int QuantidadeRecebido = 0;
                        decimal ValorUnitario = 0;
                        decimal Valor_Total = 0;
                        ValorFinal = true;

                        //string.Format("{0:C}", Convert.ToDouble(this.FormEntradaNoEstoqueValorUnitario));

                        QuantidadeRecebido = int.Parse(dataGridViewEstoque.Rows[i].Cells[2].Value.ToString());
                        string ValorVerificar = ConverterValores(dataGridViewEstoque.Rows[i].Cells[4].Value.ToString());
                        
                        string Entrada = ValorVerificar.ToString();
                        string ValorVerificar2 = Entrada.Replace("R$", "");

                        ValorUnitario = decimal.Parse(ValorVerificar2);
                        Valor_Total = QuantidadeRecebido * ValorUnitario;

                        SomaValorFInal = SomaValorFInal + Valor_Total;

                        dataGridViewEstoque.Rows[i].Cells[5].Value = string.Format("{0:C}", Convert.ToDouble(Valor_Total));
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
                dataGridViewEstoque.Refresh();
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
        private void QuantidadeV(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            try
            {
                if (dataGridViewEstoque.CurrentCell.ColumnIndex == 2)
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
                if (dataGridViewEstoque.CurrentCell.ColumnIndex == 3)
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
                if (dataGridViewEstoque.CurrentCell.ColumnIndex == 4)
                {
                    if ((VerificarObjeto(dataGridViewEstoque.Rows[Linha_Selecionada].Cells[3].Value) == true))
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
                if (dataGridViewEstoque.CurrentCell.ColumnIndex == 5)
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

        public void ProdutoQuantidadeInicial()
        {
            if (dataGridViewEstoque.RowCount > 0)
            {
                int LinhasConsta = 0;
                int quantidadeRecebida = 0;

                LinhasConsta = dataGridViewEstoque.RowCount;

                for (int i = 0; i < LinhasConsta; i++)
                {
                    if ((VerificarObjeto(dataGridViewEstoque.Rows[i].Cells[1].Value) == false) &&
                        (VerificarObjeto(dataGridViewEstoque.Rows[i].Cells[2].Value) == false))
                    {
                        quantidadeRecebida = int.Parse(dataGridViewEstoque.Rows[i].Cells[2].Value.ToString());

                        if (quantidadeRecebida == 0)
                        {
                            dataGridViewEstoque.Rows[i].Cells[2].Value = 1;
                        }
                    }
                }
            }
        }
        public void ValorLinhadataGridViewEstoque()
        {
            int Linhas = 0;
            for (Linhas = 0; Linhas < dataGridViewEstoque.Rows.Count; Linhas++)
            {
                dataGridViewEstoque.Rows[Linhas].Cells[0].Value = Linhas;
            }
        }
        public void AdicionandoProdutoVenda()
        {
            try
            {
                bool ItemConsta = false;
                dataGridViewEstoque.RowCount.ToString();
                //Verifica todos os Id Produto Cadastrado
                for (int i = 0; i < dataGridViewEstoque.RowCount; i++)
                {
                    if ((VerificarObjeto(dataGridViewEstoque.Rows[i].Cells[1].Value) == false))
                    {
                        int IdProdutoAdicionado = 0;

                        IdProdutoAdicionado = int.Parse(dataGridViewEstoque.Rows[i].Cells[1].Value.ToString());
                        //Verifica se já tem produto lançado;
                        if (IdProdutoAdicionado == int.Parse(this.FormEntradaNoEstoqueIdProduto))
                        {
                            ItemConsta = true;

                            int QuantidadeProdutoEntrada = 0;

                            QuantidadeProdutoEntrada = int.Parse(dataGridViewEstoque.Rows[i].Cells[2].Value.ToString());

                            if (QuantidadeProdutoEntrada <= int.Parse(FormEntradaNoEstoqueQuantidadeProduto))
                            {
                                dataGridViewEstoque.Rows[i].Cells[1].Value = this.FormEntradaNoEstoqueIdProduto;
                                dataGridViewEstoque.Rows[i].Cells[2].Value = QuantidadeProdutoEntrada;
                                dataGridViewEstoque.Rows[i].Cells[3].Value = this.FormEntradaNoEstoqueNomeProduto;
                                dataGridViewEstoque.Rows[i].Cells[4].Value = this.FormEntradaNoEstoqueValorUnitario = string.Format("{0:C}", Convert.ToDouble(this.FormEntradaNoEstoqueValorUnitario));
                                dataGridViewEstoque.Rows[i].Cells[5].Value = this.FormEntradaNoEstoqueValorUnitario;
                            }
                            else if (QuantidadeProdutoEntrada > int.Parse(FormEntradaNoEstoqueQuantidadeProduto))
                            {
                                dataGridViewEstoque.Rows[i].Cells[1].Value = this.FormEntradaNoEstoqueIdProduto;
                                dataGridViewEstoque.Rows[i].Cells[2].Value = FormEntradaNoEstoqueQuantidadeProduto;
                                dataGridViewEstoque.Rows[i].Cells[3].Value = this.FormEntradaNoEstoqueNomeProduto;
                                dataGridViewEstoque.Rows[i].Cells[4].Value = this.FormEntradaNoEstoqueValorUnitario = string.Format("{0:C}", Convert.ToDouble(this.FormEntradaNoEstoqueValorUnitario));
                                dataGridViewEstoque.Rows[i].Cells[5].Value = this.FormEntradaNoEstoqueValorUnitario;
                            }
                            dataGridViewEstoque.Rows.RemoveAt(this.Linha_SelecionadaRetorno);
                        }
                    }
                }
                if (ItemConsta == false)
                {
                    int QuantidadeProdutoEntrada = 0;

                    QuantidadeProdutoEntrada = int.Parse(dataGridViewEstoque.Rows[Linha_SelecionadaRetorno].Cells[2].Value.ToString());

                    if (QuantidadeProdutoEntrada <= int.Parse(FormEntradaNoEstoqueQuantidadeProduto))
                    {
                        dataGridViewEstoque.Rows[Linha_SelecionadaRetorno].Cells[1].Value = this.FormEntradaNoEstoqueIdProduto;
                        dataGridViewEstoque.Rows[Linha_SelecionadaRetorno].Cells[2].Value = QuantidadeProdutoEntrada;
                        dataGridViewEstoque.Rows[Linha_SelecionadaRetorno].Cells[3].Value = this.FormEntradaNoEstoqueNomeProduto;
                        dataGridViewEstoque.Rows[Linha_SelecionadaRetorno].Cells[4].Value = string.Format("{0:C}", Convert.ToDouble(this.FormEntradaNoEstoqueValorUnitario));
                        dataGridViewEstoque.Rows[Linha_SelecionadaRetorno].Cells[5].Value = this.FormEntradaNoEstoqueValorUnitario;
                    }
                    if (QuantidadeProdutoEntrada > int.Parse(FormEntradaNoEstoqueQuantidadeProduto))
                    {
                        dataGridViewEstoque.Rows[Linha_SelecionadaRetorno].Cells[1].Value = this.FormEntradaNoEstoqueIdProduto;
                        dataGridViewEstoque.Rows[Linha_SelecionadaRetorno].Cells[2].Value = this.FormEntradaNoEstoqueQuantidadeProduto;
                        dataGridViewEstoque.Rows[Linha_SelecionadaRetorno].Cells[3].Value = this.FormEntradaNoEstoqueNomeProduto;
                        dataGridViewEstoque.Rows[Linha_SelecionadaRetorno].Cells[4].Value = string.Format("{0:C}", Convert.ToDouble(this.FormEntradaNoEstoqueValorUnitario));
                        dataGridViewEstoque.Rows[Linha_SelecionadaRetorno].Cells[5].Value = this.FormEntradaNoEstoqueValorUnitario;
                    }
                }
                ValorLinhadataGridViewEstoque();

                //ProdutoQuantidadeInicial();

                CalcularQuantidadeValorTotal();
            }
            catch
            {

            }
        }
        public void VerificaLinhasBrancosdataGridViewEstoque()
        {
            for (int i = 0; i < dataGridViewEstoque.RowCount; i++)
            {
                if ((VerificarObjeto(dataGridViewEstoque.Rows[i].Cells[1].Value) == true))
                {
                    dataGridViewEstoque.Rows.RemoveAt(i + 1);
                }
            }
        }

        private void txtIcms_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08 && !(e.KeyChar == ','))
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }
        }

        private void txtIcms_TextChanged(object sender, EventArgs e)
        {
            Moeda(ref txtIcms);
            txtIcms.TextAlign = HorizontalAlignment.Right;
        }

        private void txtNumeroNota_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08 && !(e.KeyChar == ','))
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }
        }
    }
}






//if (e.ColumnIndex == 0)
//{
//    if (e.Value != null)
//    {
//        e.Value = e.Value.ToString();
//    }
//    else e.Value = "Linha usada";
//}
//if (e.ColumnIndex == 1)
//{
//    if (e.Value != null)
//    {
//        e.Value = e.Value.ToString();
//    }
//    else e.Value = "Id Produto";
//}
//if (e.ColumnIndex == 2)
//{
//    if (e.Value != null)
//    {
//        //e.Value = Valor_Unitario;
//    }
//    else e.Value = "Quantidade";
//}
//if (e.ColumnIndex == 3)
//{
//    if (e.Value != null)
//    {
//        //e.Value = Valor_Total;
//    }
//    else e.Value = "Produto Pesquisa";
//}
//if (e.ColumnIndex == 4)
//{
//    if (e.Value != null)
//    {
//        //e.Value = Valor_Total;
//    }
//    else e.Value = "Valor Utilitario";
//}
//if (e.ColumnIndex == 5)
//{
//    if (e.Value != null)
//    {
//        //e.Value = Valor_Total;
//    }
//    else e.Value = "Valor Total";
//}
//{
//    if ((VerificarObjeto(dataGridViewEstoque.Rows[Quantidade_Linha - 1].Cells[1].Value) == true) &&
//        (VerificarObjeto(dataGridViewEstoque.Rows[Quantidade_Linha].Cells[1].Value) == true))
//    {
//        dataGridViewEstoque.Refresh();
//        dataGridViewEstoque.Rows.RemoveAt(Quantidade_Linha);
//        Contador--;
//    }
//}







//try
//{
//    if (e.ColumnIndex == 0)
//    {
//        if (e.Value != null)
//        {
//            e.Value = e.Value.ToString();
//        }
//        else e.Value = "Linha_Usada";
//    }
//    if (e.ColumnIndex == 1)
//    {
//        if (e.Value != null)
//        {
//            e.Value = e.Value.ToString();
//        }
//        else e.Value = "ID_PRODUTOC";
//    }
//    if (e.ColumnIndex == 2)
//    {
//        if (e.Value != null)
//        {
//            e.Value = e.Value.ToString();
//        }
//        else e.Value = "Quantidade1";
//    }
//    if (e.ColumnIndex == 3)
//    {
//        if (e.Value != null)
//        {
//            e.Value = e.Value.ToString();
//        }
//        else e.Value = "ProdutoPesquisa";
//    }

//    if (e.ColumnIndex == 4)
//    {
//        if (e.Value != null)
//        {
//            //e.Value = Valor_Unitario;
//        }
//        else e.Value = "Valor_Unitario";
//    }
//    if (e.ColumnIndex == 5)
//    {
//        if (e.Value != null)
//        {
//            //e.Value = Valor_Total;
//        }
//        else e.Value = "Valor_Total";
//    }
//    if (this.Quantidade_Linha < 2)
//    {
//        if ((VerificarObjeto(dataGridViewProdutoVenda.Rows[Quantidade_Linha - 1].Cells[0].Value) == true) &&
//            (VerificarObjeto(dataGridViewProdutoVenda.Rows[Quantidade_Linha].Cells[0].Value) == true))
//        {
//            dataGridViewProdutoVenda.Refresh();
//            dataGridViewProdutoVenda.Rows.RemoveAt(Quantidade_Linha);
//            Contador--;
//        }
//    }
//    //int j = 1;
//    //int LinhaTotal = 20;

//    //if (LinhaTotal > 20)
//    //{
//    //    LinhaTotal.ToString();

//    //    for (j = 1; j < LinhaTotal - 1; j++)
//    //    {
//    //        if (j < LinhaTotal)
//    //        {
//    //            //texto2.Text = dataGridViewProdutoVenda.Rows[i + 1].Cells[1].Value.ToString();

//    //            if (VerificarObjeto(dataGridViewProdutoVenda.Rows[j].Cells[1].Value) == false)
//    //            {
//    //                //    MessageBox.Show("Tem Elemento");
//    //                //dataGridViewProdutoVenda.Rows.Remove(dataGridViewProdutoVenda.Rows[LinhaTotal - 1]);
//    //                //dataGridViewProdutoVenda.Refresh();
//    //            }

//    //            if (VerificarObjeto(dataGridViewProdutoVenda.Rows[j].Cells[1].Value) == true)
//    //            {
//    //                int Numero_Linha = (1 + int.Parse(dataGridViewProdutoVenda.CurrentRow.Index.ToString()));

//    //                Numero_Linha.ToString();
//    //                LinhaTotal.ToString();

//    //                dataGridViewProdutoVenda.Rows.RemoveAt(2);



//    //                Numero_Linha--;
//    //                LinhaTotal--;


//    //                Numero_Linha.ToString();
//    //                LinhaTotal.ToString();

//    //                dataGridViewProdutoVenda.Columns.RemoveAt(1);

//    //                //int l = 0;
//    //                //for(l = 0;l < LinhaTotal; l++)
//    //                //{

//    //                //    lista.Add(new ListaProduto { IdListaL = string.Format(dataGridViewProdutoVenda.Rows[0].Cells[0].Value.ToString()),
//    //                //        IdProdutoL = string.Format(dataGridViewProdutoVenda.Rows[0].Cells[1].Value.ToString()),
//    //                //        QuantidadeL = string.Format(dataGridViewProdutoVenda.Rows[0].Cells[2].Value.ToString()),
//    //                //        ValorVendidoL = string.Format(dataGridViewProdutoVenda.Rows[0].Cells[3].Value.ToString()),
//    //                //        ValorTotalL = string.Format(dataGridViewProdutoVenda.Rows[0].Cells[4].Value.ToString())
//    //                //    });
//    //                //    lista[0].ValorTotalL.ToString();
//    //                //   // MessageBox.Show(" VALORTOTAL" + lista[0].ValorTotalL.ToString());
//    //                //}

//    //                dataGridViewProdutoVenda.Refresh();


//    //                //dataGridViewProdutoVenda.Controls.Add(this.Produtos);
//    //                ////produtos.Format = DateTimePickerFormat.Custom;
//    //                //this.Produtos.SelectedIndexChanged += new EventHandler(comboBoxProdutos_SelectedIndexChanged);
//    //                //this.Produtos.Visible = false;

//    //                //dataGridViewProdutoVenda.Refresh();
//    //            }

//    //            //if (linhaPrimeira.Equals(linhaSegunda))
//    //            //{
//    //            //    MessageBox.Show("Erro erro");
//    //            //    //dataGridViewProdutoVenda.Rows[i].Cells[4].Value = ValorTotal;
//    //            //    //dataGridViewProdutoVenda.Rows.Remove(dataGridViewProdutoVenda.Rows[i]);
//    //            //}
//    //        }
//    //        if (j == LinhaTotal)
//    //        {

//    //        }

//    //    }
//    //}

//}


////if (VerificarObjeto(dataGridViewProdutoVenda.Rows[1].Cells[1].Value) == false)
////{

////    DataGridViewCell cell0 = null;
////    DataGridViewCell cell1 = null;
////    DataGridViewCell cell2 = null;
////    DataGridViewCell cell3 = null;


////    cell0 = this.dataGridViewProdutoVenda.Rows[1].Cells[0];
////    cell1 = this.dataGridViewProdutoVenda.Rows[1].Cells[1];
////    cell2 = this.dataGridViewProdutoVenda.Rows[1].Cells[2];
////    cell3 = this.dataGridViewProdutoVenda.Rows[1].Cells[3];



////    cell0.ReadOnly = true;
////    cell1.ReadOnly = true;
////    cell3.ReadOnly = true;
////}

//catch (Exception ex)
//{
//    ex.ToString();
//}