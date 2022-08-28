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
using System.IO;
using System.Drawing.Imaging;
using System.Globalization;
using System.Drawing.Printing;

namespace DateSystem
{
    public partial class FormPesquisaProdutoEditar : Form
    {
        Bitmap bmp;
        Bitmap bmp2;

        Boolean ImagemAnexa = false;
        Boolean ImagemAnexa2 = false;
        Boolean ImagemExiste = false;
        Boolean ImagemExiste2 = false;

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
        string Editar = "";
        private int IDPRODUTO = 0;
        public int IdProduto
        {
            get
            {
                return this.IDPRODUTO;

            }
            set
            {
                this.IDPRODUTO = value;
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

        private string STRINGPRODUTO = "";
        public string StringProduto
        {
            get
            {
                return this.STRINGPRODUTO;

            }
            set
            {
                this.STRINGPRODUTO = value;
            }
        }
        private string STRINGMARCA = "";
        public string StringMarca
        {
            get
            {
                return this.STRINGMARCA;

            }
            set
            {
                this.STRINGMARCA = value;
            }
        }
        private string STRINGCATEGORIA = "";
        public string StringCategoria
        {
            get
            {
                return this.STRINGCATEGORIA;

            }
            set
            {
                this.STRINGCATEGORIA = value;
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
        public FormPesquisaProdutoEditar(int ID_PRODUTO,string NomeServidor, string NomeBaseDados, string NomeUsuario,
            string SenhaBaseDados,int PRODUTOEDITAR, int PRODUTOEXCLUIR)
        {
            try
            {
                InitializeComponent();

                this.NomeServidor = NomeServidor;
                this.NomeBaseDados = NomeBaseDados;
                this.NomeUsuario = NomeUsuario;
                this.SenhaBaseDados = SenhaBaseDados;
                this.ProdutoEditar = PRODUTOEDITAR;
                this.ProdutoExcluir = PRODUTOEXCLUIR;
                label14.Text = "Quantidade atual \nno Estoque:";
                label15.Text= "Quantidade minima \npara o Estoque:";

                this.connetionString = "Data Source=" + this.NomeServidor + ";Initial Catalog=" + this.NomeBaseDados +
                    ";Persist Security Info=True;User ID=" + this.NomeUsuario + ";Password=" + this.SenhaBaseDados + ";";

                txtObservacao.MaxLength = 50;
                txtOrigemProduto.MaxLength = 50;

                if (ProdutoEditar == 0)
                {
                    buttonProdutoEditar.Enabled = false;
                }
                if (ProdutoEditar == 1)
                {
                    buttonProdutoEditar.Enabled = true;
                }

                SqlConnection conn1 = new SqlConnection(this.connetionString);
                string sql1 = "exec D_V_ConsultaEditarProdutoVendaTxt " + ID_PRODUTO;
                SqlDataAdapter sda1 = new SqlDataAdapter(sql1, conn1);
                DataSet ds1 = new DataSet();
                sda1.Fill(ds1);

                this.IdProduto = ID_PRODUTO;

                QuantidadeProdutoCadastrado();

                // CODIGO PRODOUTOS

                string ID_NOME_PRODUTO = ds1.Tables[0].Rows[0][1].ToString();
                string ID_MARCA = ds1.Tables[0].Rows[0][2].ToString();
                string ID_CATEGORIA = ds1.Tables[0].Rows[0][3].ToString();
                string ID_FORNECEDOR = ds1.Tables[0].Rows[0][28].ToString();

                txtDescriacaoProdutoSistema.Text = ds1.Tables[0].Rows[0][9].ToString();
                txtPrecoCusto.Text = DuasCasasDecimais(ds1.Tables[0].Rows[0][5].ToString());
                txtCustoMedio.Text = DuasCasasDecimais(ds1.Tables[0].Rows[0][6].ToString());
                txtPrecoVenda.Text = DuasCasasDecimais(ds1.Tables[0].Rows[0][7].ToString());
                txtMargemLucro.Text = DuasCasasDecimais(ds1.Tables[0].Rows[0][8].ToString());
                //Reajuste do Pedido
                if (ds1.Tables[0].Rows[0][10].ToString() == "")
                {
                    label13.Text = "Não consta data de reajuste.\nModo que os valores não\nforam alterados.";
                    dateTimePickerUltimoReajuste.Visible = false;
                    dateTimePickerUltimoReajuste.Enabled = false;
                }
                if (ds1.Tables[0].Rows[0][10].ToString() != "")
                {
                    label13.Text = "Data do último reajuste\nde preços:";
                    dateTimePickerUltimoReajuste.Text = ds1.Tables[0].Rows[0][10].ToString();
                }
                //Data Solicitação do produto
                if (ds1.Tables[0].Rows[0][33].ToString() == "")
                {
                    label86.Text = "Não consta data da compra do produto.\nModo que não será mostrado.";
                    dateTimePickerSolicitacao.Visible = false;
                    dateTimePickerSolicitacao.Enabled = false;
                }
                if (ds1.Tables[0].Rows[0][33].ToString() != "")
                {
                    label86.Text = "Data de Soliticação:";
                    dateTimePickerSolicitacao.Text = ds1.Tables[0].Rows[0][33].ToString();
                }
                //Data de Fabricação do Produto.
                if (ds1.Tables[0].Rows[0][20].ToString() == "")
                {
                    label85.Text = "Não consta data de fabricação do \nproduto.\nModo que não será mostrado.";
                    dateTimePickerFabricacao.Visible = false;
                    dateTimePickerFabricacao.Enabled = false;
                }
                if (ds1.Tables[0].Rows[0][20].ToString() != "")
                {
                    label85.Text = "Data de Fabricação:";
                    dateTimePickerFabricacao.Text = ds1.Tables[0].Rows[0][20].ToString();
                }
                //Data de Vencimento do Produto
                if (ds1.Tables[0].Rows[0][21].ToString() == "")
                {
                    label84.Text = "Não consta data de Vencimento \ndo produto.\nModo que não será mostrado.";
                    dateTimePickerVencimento.Visible = false;
                    dateTimePickerVencimento.Enabled = false;
                }
                if (ds1.Tables[0].Rows[0][21].ToString() != "")
                {
                    label84.Text = "Data de Vencimento:";
                    dateTimePickerVencimento.Text = ds1.Tables[0].Rows[0][21].ToString();
                }
                //Data de Entrada do Produto
                if (ds1.Tables[0].Rows[0][22].ToString() == "")
                {
                    label73.Text = "Não consta data de Entrada do\nproduto.\nModo que não será mostrado.";
                    dateTimePickerDataEntrada.Visible = false;
                    dateTimePickerDataEntrada.Enabled = false;
                }
                if (ds1.Tables[0].Rows[0][22].ToString() != "")
                {
                    label73.Text = "Data de Entrada:";
                    dateTimePickerDataEntrada.Text = ds1.Tables[0].Rows[0][22].ToString();
                }
                //Data da Compra do Produto
                if (ds1.Tables[0].Rows[0][33].ToString() == "")
                {
                    label18.Text = "Não consta data da Compra do \nproduto.\nModo que não será mostrado.";
                    dateTimePickerDataCompra.Visible = false;
                    dateTimePickerDataCompra.Enabled = false;
                }
                if (ds1.Tables[0].Rows[0][33].ToString() != "")
                {
                    label18.Text = "Data de Compra:";
                    dateTimePickerDataCompra.Text = ds1.Tables[0].Rows[0][33].ToString();
                }

                txtQuantidadeAtualEstoque.Text = ds1.Tables[0].Rows[0][34].ToString();
                txtQuantidadeMinimaEstoque.Text = ds1.Tables[0].Rows[0][11].ToString();
                int impressora = 0;
                int status = 0;
                impressora = int.Parse(ds1.Tables[0].Rows[0][12].ToString());
                status = int.Parse(ds1.Tables[0].Rows[0][13].ToString());
                if (impressora == 2)
                {
                    checkBoxnaoImprimir.Checked = false;
                }
                if (impressora == 1)
                {
                    checkBoxnaoImprimir.Checked = true;
                }

                if (status == 2)
                {
                    checkBoxAtivo.Checked = false;
                }
                if (status == 1)
                {
                    checkBoxAtivo.Checked = true;
                }
                txtCodigoInterno.Text = ds1.Tables[0].Rows[0][14].ToString();
                txtObservacao.Text = ds1.Tables[0].Rows[0][15].ToString();
                //if (ds1.Tables[0].Rows[0][40].ToString().Equals(""))
                //{

                //}
                //else txtDescricaoCstIcms.Text = AdicionadoVZ(ds1.Tables[0].Rows[0][40].ToString());
                //if (ds1.Tables[0].Rows[0][24].ToString().Equals(""))
                //{

                //}
                //else txtBaseIcms.Text = AdicionadoVZ(ds1.Tables[0].Rows[0][24].ToString());

                //if (ds1.Tables[0].Rows[0][26].ToString().Equals(""))
                //{

                //}
                //else txtDescricaoCstPis.Text = AdicionadoVZ(ds1.Tables[0].Rows[0][26].ToString());
                //if (ds1.Tables[0].Rows[0][27].ToString().Equals(""))
                //{

                //}
                //else txtPis.Text = AdicionadoVZ(ds1.Tables[0].Rows[0][27].ToString());

                //if (ds1.Tables[0].Rows[0][29].ToString().Equals(""))
                //{

                //}
                //else txtDescricaoCofins.Text = AdicionadoVZ(ds1.Tables[0].Rows[0][29].ToString());
                //if (ds1.Tables[0].Rows[0][30].ToString().Equals(""))
                //{

                //}
                //else txtConfins.Text = AdicionadoVZ(ds1.Tables[0].Rows[0][30].ToString());
                //if (ds1.Tables[0].Rows[0][32].ToString().Equals(""))
                //{

                //}
                //else txtDescricaoIpI.Text = AdicionadoVZ(ds1.Tables[0].Rows[0][32].ToString());
                //if (ds1.Tables[0].Rows[0][33].ToString().Equals(""))
                //{

                //}
                //else txtIpi.Text = AdicionadoVZ(ds1.Tables[0].Rows[0][33].ToString());
                //if ()
                //{

                //}
                //else
                txtCodigoGtin.Text = ds1.Tables[0].Rows[0][51].ToString();
                if (ds1.Tables[0].Rows[0][52].ToString().Equals(""))
                {

                }
                else txtPesoBruto.Text = AdicionadoVZ(ds1.Tables[0].Rows[0][52].ToString());
                if (ds1.Tables[0].Rows[0][53].ToString().Equals(""))
                {

                }
                else txtPesoLiquido.Text = AdicionadoVZ(ds1.Tables[0].Rows[0][53].ToString());
                //Data da previsão de chegada do Produto
                if (ds1.Tables[0].Rows[0][54].ToString() == "")
                {
                    label30.Text = "Não consta data de previsão de chegada do produto.\nModo que não será mostrado.";
                    dateTimePickerPrevisaoChegada.Visible = false;
                    dateTimePickerPrevisaoChegada.Enabled = false;
                }
                if (ds1.Tables[0].Rows[0][54].ToString() != "")
                {
                    label30.Text = "Data de Previsão de Chegada:";
                    dateTimePickerPrevisaoChegada.Text = ds1.Tables[0].Rows[0][54].ToString();
                }
               
                txtOrigemProduto.Text = ds1.Tables[0].Rows[0][55].ToString();
                string ID_PRODUTO_NOME = ds1.Tables[0].Rows[0][1].ToString();
                //this.StringProduto = ds1.Tables[0].Rows[0][58].ToString();
                comboBoxDescricaoProduto.Items.Add(ds1.Tables[0].Rows[0][58].ToString());
                comboBoxDescricaoProduto.SelectedIndex = 0;
                //string ID_MARCA = ds1.Tables[0].Rows[0][43].ToString();
                this.StringMarca = ds1.Tables[0].Rows[0][63].ToString();
                comboBoxMarca.Items.Add(ds1.Tables[0].Rows[0][63].ToString());
                comboBoxMarca.SelectedIndex = 0;
                //string ID_CATEGORIA = ds1.Tables[0].Rows[0][47].ToString();
                this.StringCategoria = ds1.Tables[0].Rows[0][65].ToString();
                comboBoxCartegoria.Items.Add(ds1.Tables[0].Rows[0][65].ToString());
                comboBoxCartegoria.SelectedIndex = 0;
                comboBoxFornecedor.Items.Add(ds1.Tables[0].Rows[0][67].ToString());
                comboBoxFornecedor.SelectedIndex = 0;
                comboBoxUnidade.Items.Add(ds1.Tables[0].Rows[0][67].ToString());
                comboBoxUnidade.SelectedIndex = 0;
                dateTimePickerCadastroProduto.Text = ds1.Tables[0].Rows[0][69].ToString();
                label75.Text = "Preço Total do produto.\nCalculado pelo o estoque:";
                txtPrecoTotalCompra.Text = ds1.Tables[0].Rows[0][23].ToString();



                ImagemProduto();
                ImagemProduto2();
            }
            catch (Exception ex)
            {
                ex.ToString();
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
        private void FormPesquisaProdutoEditar_Load_1(object sender, EventArgs e)
        {

        }
        public void ImagemProduto()
        {
            try
            {
                SqlConnection conn = new SqlConnection(this.connetionString);
                SqlCommand comand = new SqlCommand("D_V_ConsultaImagemProduto " + this.IdProduto + ";", conn);
                conn.Open();

                SqlDataReader reader = comand.ExecuteReader();

                if (reader.Read())
                {
                    byte[] Foto = (byte[])reader["IMAGEM"];
                    MemoryStream ms = new MemoryStream(Foto);
                    Imagem = Image.FromStream(ms);
                }
                //if (Imagem == null)
                //{
                //    MessageBox.Show("Não existir Imagem!");
                //}
                if (Imagem != null)
                {
                    pictureBoxImagem.Image = Imagem;
                    ImagemExiste = true;
                }
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
        }
        public void ImagemProduto2()
        {
            try
            {
                SqlConnection conn = new SqlConnection(this.connetionString);
                SqlCommand comand = new SqlCommand("D_V_ConsultaImagemProduto2 " + this.IdProduto + ";", conn);
                conn.Open();

                SqlDataReader reader = comand.ExecuteReader();

                if (reader.Read())
                {
                    byte[] Foto = (byte[])reader["IMAGEM2"];
                    MemoryStream ms = new MemoryStream(Foto);
                    Imagem2 = Image.FromStream(ms);
                }
                //if (Imagem == null)
                //{
                //    MessageBox.Show("Não existir Imagem!");
                //}
                if (Imagem2 != null)
                {
                    pictureBoxImagem2.Image = Imagem2;
                    ImagemExiste2 = true;
                }
            }
            catch (Exception ex)
            {
                ex.ToString();
            }

        }
        public void AlterarBotao(int botao)
        {
            try
            {
                if (botao == 1)
                {
                    panelGeral.Enabled = true;
                    buttonProdutoEditar.Enabled = false;
                    buttonProdutoSalvar.Enabled = true;
                    comboBoxDescricaoProduto.Enabled = true;
                    comboBoxMarca.Enabled = true;
                    comboBoxCartegoria.Enabled = true;
                    Editar = "Editar";

                    Fill_listBoxDescricaoProduto();
                 
                    Fill_listBoxMarcaProduto();
                    Fill_listBoxCategoriaProduto();
                }
                if (botao == 2)
                {

                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro" + e);
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
        public static string AdicionadoVZ(string VALORES)
        {
            try
            {
                Boolean vigula = false;

                StringBuilder sb = new StringBuilder(VALORES);

                int quantString = VALORES.Length;

                for (int i = 0; i < quantString; i++)
                {
                    if(VALORES[i] == ',')
                    {
                        vigula = true;
                        break;
                    }
                    
                }
                if(vigula == false)
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
        public void ProdutoSalvar()
        {
            try
            {
                if (Editar == "Editar")
                {
                    CadastraProdutos AltercaoProdutos = new CadastraProdutos();
                    AltercaoProdutos.IdProduto = this.IdProduto;

                    AltercaoProdutos.IdProdutoDescricao = this.IdDescricaoProduto;
                    AltercaoProdutos.IdMarca = this.IdMarcaProduto;
                    AltercaoProdutos.IdCategoriaProduto = this.IdMarcaProdutoCategoria;

                    AltercaoProdutos.IdUnidadeProduto = this.IdUnidadeProduto;

                    AltercaoProdutos.Observacao = txtObservacao.Text;

                    if (checkBoxnaoImprimir.Checked == false)
                    {
                        AltercaoProdutos.ImprimirProduto = 2;
                    }
                    if (checkBoxnaoImprimir.Checked == true)
                    {
                        AltercaoProdutos.ImprimirProduto = 1;
                    }

                    //Salvar Cadastro de Produto no sistema
                    Conexao conexao = new Conexao(this.connetionString);
                    DALCadastro2 da = new DALCadastro2(conexao);

                    da.AlterarProduto(AltercaoProdutos);
                    MessageBox.Show("Produto Cadastrado com exito!");

                    //Salvar Imagem em Base de Dados
                    Conexao conexao1 = new Conexao(this.connetionString);
                    DALCadastro2 da1 = new DALCadastro2(conexao1);
                    //Salvar Imagem em Base de Dados 2
                    Conexao conexao2 = new Conexao(this.connetionString);
                    DALCadastro2 da2 = new DALCadastro2(conexao2);

                    ProdutoImagem ImagemProduto = new ProdutoImagem();
                    ProdutoImagem2 ImagemProduto2 = new ProdutoImagem2();

                    ImagemProduto.IdProduto = this.IdProduto;
                    ImagemProduto2.IdProduto2 = this.IdProduto;

                    FecharTodosFormulario();

                    if (ImagemAnexa == true)
                    {
                        //imagem 1
                        MemoryStream memory = new MemoryStream();

                        bmp.Save(memory, ImageFormat.Bmp);

                        byte[] Foto = memory.ToArray();

                        ImagemProduto.Imagem = Foto;

                        if (ImagemExiste == true)
                        {
                            da1.AlterarProdutoImagem(ImagemProduto);
                        }
                        if (ImagemExiste == false)
                        {
                            da1.IncluirProdutoImagem(ImagemProduto);
                        }

                    }
                    if (ImagemAnexa2 == true)
                    {
                        //imagem 2
                        MemoryStream memory2 = new MemoryStream();

                        bmp2.Save(memory2, ImageFormat.Bmp);

                        byte[] Foto2 = memory2.ToArray();

                        ImagemProduto2.Imagem2 = Foto2;

                        if (ImagemExiste2 == true)
                        {
                            da1.AlterarProdutoImagem2(ImagemProduto2);
                        }
                        if (ImagemExiste2 == false)
                        {
                            da1.IncluirProdutoImagem2(ImagemProduto2);
                        }
                    }
                }
            }

            catch (Exception exp)
            {
                exp.ToString();
            }
        }
        //METODO PARA VERIFICA SE O FORMULÁRIO ESTA ABERTO SE TIVER ELE FECHA!
        public static void CancelaPesquisaCliente(Type frmType)
        {
            try
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

            catch (Exception exp)
            {
                exp.ToString();
            }
        }
        //CHAMA O METODO CancelaCadastradoCliente QUE FECHA FORMULÁRIOS ABERTOS
        public void FecharTodosFormulario()
        {
            CancelaPesquisaCliente(typeof(FormPesquisaProdutoEditar));
        }
        private void buttonAnexo_Click(object sender, EventArgs e)
        {
            //openFileDialog1.Filter = "JPG Files(*.jpg)|*.jpg|JPG Files(*.png)|*.png";// all files(*.*) | *.*

            //DialogResult dialogResult = MessageBox.Show("Deseja Anexa uma imagem!", "Aviso", MessageBoxButtons.YesNo);
            //if (dialogResult == DialogResult.Yes)
            //{
            //    try
            //    {
            //        openFileDialog1.ShowDialog();
            //        ImgLocation = openFileDialog1.FileNames.ToString();
            //        //label15.Text = Dialog.FileNames.ToString();
            //        label49.Text = openFileDialog1.FileName;
            //        pictureBoxImagem.Image = Image.FromFile(openFileDialog1.FileName);
            //        bmp = new Bitmap(label49.Text);
            //        ImagemAnexa = true;
            //    }
            //    catch (Exception ex)
            //    {
            //        ex.ToString();
            //    }
            //}
            //else if (dialogResult == DialogResult.No)
            //{
            //    MessageBox.Show("Cancelado o Anexo da Imagem!");
            //}
        }

        private void buttonAnexo2_Click(object sender, EventArgs e)
        {
            //openFileDialog2.Filter = "JPG Files(*.jpg)|*.jpg|JPG Files(*.png)|*.png";// all files(*.*) | *.*

            //DialogResult dialogResult = MessageBox.Show("Deseja Anexa uma imagem!", "Aviso", MessageBoxButtons.YesNo);
            //if (dialogResult == DialogResult.Yes)
            //{
            //    try
            //    {
            //        openFileDialog2.ShowDialog();
            //        ImgLocation2 = openFileDialog2.FileNames.ToString();
            //        //label15.Text = Dialog.FileNames.ToString();
            //        label49.Text = openFileDialog2.FileName;
            //        pictureBoxImagem2.Image = Image.FromFile(openFileDialog2.FileName);
            //        bmp2 = new Bitmap(label49.Text);
            //        ImagemAnexa2 = true;
            //    }
            //    catch (Exception ex)
            //    {
            //        ex.ToString();
            //    }
            //}
            //else if (dialogResult == DialogResult.No)
            //{
            //    MessageBox.Show("Cancelado o Anexo da Imagem!");
            //}
        }

        private void txtPrecoCusto_TextChanged(object sender, EventArgs e)
        {
            Moeda(ref txtPrecoCusto);
            txtPrecoCusto.TextAlign = HorizontalAlignment.Right;
        }

        private void txtMargemLucro_TextChanged(object sender, EventArgs e)
        {
            Moeda2(ref txtMargemLucro);
            txtMargemLucro.TextAlign = HorizontalAlignment.Right;
        }

        private void txtPrecoVenda_TextChanged(object sender, EventArgs e)
        {
            Moeda(ref txtPrecoVenda);
            txtPrecoVenda.TextAlign = HorizontalAlignment.Right;

        }

        private void txtCustoMedio_TextChanged(object sender, EventArgs e)
        {
            txtCustoMedio.TextAlign = HorizontalAlignment.Right;
        }
        public static string DuasCasasDecimais(string VALORES)
        {
            try
            {
                string ConversaoValores = VALORES;

                int i = 0;

                StringBuilder sb = new StringBuilder(VALORES);

                int quantString = VALORES.Length;

                string StringTeste = VALORES;


                //QUEBRA DE LINHA SE FOR MAS QUE UMA LINHA
                for (i = 0; i <= quantString - 1; i++)
                {
                    if (StringTeste[i] == ',')
                    {
                        i.ToString();
                        sb.Remove(i + 3, quantString - (i + 3));
                        ConversaoValores = sb.ToString();

                        VALORES.ToString();

                        return ConversaoValores;
                    }
                }

                return ConversaoValores;
            }

            catch (Exception exp)
            {
                return exp.ToString();
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
        private void comboBoxDescricaoProduto_SelectedIndexChanged_1(object sender, EventArgs e)
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
        private void comboBoxMarca_SelectedIndexChanged_1(object sender, EventArgs e)
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
        private void comboBoxCartegoria_SelectedIndexChanged_1(object sender, EventArgs e)
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

        private void FormPesquisaProdutoEditar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
            {
                this.Close();
            }
        }

        private void buttonProdutoEditar_Click_1(object sender, EventArgs e)
        {
            AlterarBotao(1);
        }

        private void buttonProdutoFechar_Click_1(object sender, EventArgs e)
        {
            FecharTodosFormulario();
        }

        private void buttonProdutoSalvar_Click(object sender, EventArgs e)
        {
            ProdutoSalvar();
        }

        private void txtPrecoCusto_TextChanged_1(object sender, EventArgs e)
        {
            Moeda(ref txtPrecoCusto);
            txtPrecoCusto.TextAlign = HorizontalAlignment.Right;
        }

        private void txtCustoMedio_TextChanged_1(object sender, EventArgs e)
        {
            Moeda(ref txtCustoMedio);
            txtCustoMedio.TextAlign = HorizontalAlignment.Right;
        }

        private void txtPrecoVenda_TextChanged_1(object sender, EventArgs e)
        {
            Moeda(ref txtPrecoVenda);
            txtPrecoVenda.TextAlign = HorizontalAlignment.Right;
        }

        private void txtPrecoTotalCompra_TextAlignChanged(object sender, EventArgs e)
        {
            Moeda(ref txtPrecoTotalCompra);
            txtPrecoTotalCompra.TextAlign = HorizontalAlignment.Right;
        }

        private void txtMargemLucro_TextChanged_1(object sender, EventArgs e)
        {
            Moeda(ref txtMargemLucro);
            txtMargemLucro.TextAlign = HorizontalAlignment.Right;
        }

        private void txtQuantidadeAtualEstoque_TextChanged(object sender, EventArgs e)
        {
            
            txtQuantidadeAtualEstoque.TextAlign = HorizontalAlignment.Right;
        }

        private void txtQuantidadeMinimaEstoque_TextChanged(object sender, EventArgs e)
        {
            txtQuantidadeMinimaEstoque.TextAlign = HorizontalAlignment.Right;
        }
    }
}