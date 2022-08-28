using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DateSystem
{
    public partial class FormTeste : Form
    {
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
        private int ID_CST_ICMS;
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
        private int ID_CST_PIS;
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
        private int ID_CST_COFINS;
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
        private int ID_CST_IP;
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
        private float TEMP_CUSTO;
        public float TempCusto
        {
            get
            {
                return this.TEMP_CUSTO;

            }
            set
            {
                this.TEMP_CUSTO = value;
            }
        }
        private float TEMP_LUCRO;
        public float TempLucro
        {
            get
            {
                return this.TEMP_LUCRO;

            }
            set
            {
                this.TEMP_LUCRO = value;
            }
        }
        private float TEMP_MEDIO;
        public float TempMedio
        {
            get
            {
                return this.TEMP_MEDIO;

            }
            set
            {
                this.TEMP_MEDIO = value;
            }
        }
        private float TEMP_VENDA;
        public float TempVenda
        {
            get
            {
                return this.TEMP_VENDA;

            }
            set
            {
                this.TEMP_VENDA = value;
            }
        }
        private int IDDESCRICAOPRODUTO;
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
        public FormTeste()
        {
            InitializeComponent();
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
                        //if (StringTeste[i] == '.')
                        //{
                        //    sb.Remove(i, 1);
                        //    VALORES = sb.ToString();
                        //    finalizador = false;
                        //    break;
                        //}
                        if (StringTeste[i] == ',')
                        {
                            sb.Remove(i, 1);
                            VALORES = sb.ToString();
                            finalizador = false;
                            break;
                        }
                        else if (!(StringTeste[i] == '.') && !(StringTeste[i] == ','))
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
        public static string DoisNiveis(string VALORES)
        {
            try
            {
                string ConversaoValores = VALORES;

                StringBuilder sb = new StringBuilder(VALORES);

                int quantString = VALORES.Length;
                if (quantString > 2)
                {
                    sb.Insert(2, '.');
                    VALORES = sb.ToString();
                }
                if (quantString <= 2)
                {
                }

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
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }
            if (e.KeyChar == 13)
            {
                Moeda(ref txtPrecoCusto);

                txtCustoMedio.Text = txtPrecoCusto.Text;

                string CustoMedioS = ConverterValores(txtPrecoCusto.Text);
                TempCusto = int.Parse(CustoMedioS);
                TempMedio = int.Parse(CustoMedioS);
            }
        }

        private void FormTeste_Load(object sender, EventArgs e)
        {

        }

        private void txtPrecoCusto_TextChanged(object sender, EventArgs e)
        {
            Moeda(ref txtPrecoCusto);
        }

        private void txtMargemLucro_TextChanged(object sender, EventArgs e)
        {
            Moeda2(ref txtMargemLucro);
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
                    if (!(txtPrecoCusto.Text == ""))
                    {
                        string PrecoCusto = "";
                        string Lucro = "";

                        PrecoCusto = ConverterValores(txtPrecoCusto.Text);
                        Lucro = txtMargemLucro.Text;

                        float PrecoCustoC = float.Parse(PrecoCusto);
                        float LucroC = float.Parse(Lucro);

                        if (LucroC > 0)
                        {
                            float temp = PrecoCustoC;

                            LucroC = (LucroC / 100);

                            float valor = 0;

                            valor = temp + (PrecoCustoC * LucroC);

                            TempLucro = (LucroC * 100);
                            txtPrecoVenda.Clear();
                            txtPrecoVenda.Text = valor.ToString();
                            TempVenda = valor;


                        }
                    }
                }
                catch (Exception ex)
                {
                    ex.ToString();
                }
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

        private void txtPrecoVenda_TextChanged(object sender, EventArgs e)
        {
            Moeda(ref txtPrecoVenda);
        }

        private void txtPrecoVenda_KeyPress(object sender, KeyPressEventArgs e)
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
                    if (!(txtPrecoCusto.Text == "") && !(txtPrecoVenda.Text == ""))
                    {
                        string Primeiro = "";
                        string Segundo = "";

                        Segundo = ConverterValores(txtPrecoCusto.Text);
                        Primeiro = ConverterValores(txtPrecoVenda.Text);

                        float PrecoVendido = int.Parse(Primeiro);
                        float PrecoCusto = int.Parse(Segundo);

                        if (PrecoVendido > PrecoCusto)
                        {
                            float numero1 = float.Parse(txtNumero.Text);
                            float numero = numero1;

                            for (float d = 1.1f; d <= 1.5f; d += 0.1f)
                            {
                                Console.WriteLine("Iteração #: {0}, valor float : {1}", d + "" + d.ToString("e10"));
                            }




                            float menos = (PrecoVendido - PrecoCusto);
                            float dividr = (menos / PrecoCusto) * 100;
                            float dividaTemp = dividr;

                            float retorno = float.Parse(dividaTemp.ToString());

                            TempVenda = PrecoVendido;

                            txtMargemLucro.Clear();
                            txtMargemLucro.Text = retorno.ToString();


                            //Moeda(ref txtMargemLucro);
                        }
                        if ((PrecoVendido == PrecoCusto) || (PrecoVendido < PrecoCusto))
                        {
                            txtMargemLucro.Text = "Valor não aceito!";
                        }
                    }
                }
                catch (Exception ex)
                {
                    ex.ToString();
                }
            }
        }

        private void txtNumer3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                float soma = 0;
                float soma2 = 0;
                float soma3 = 0;
                soma2 = float.Parse(txtNumero.Text);
                soma3 = float.Parse(txtNumero2.Text);
                soma = (soma2 + soma3);
                txtNumero3.Text = soma.ToString();
            }
        }
    }
}
