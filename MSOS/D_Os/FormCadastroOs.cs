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
    public partial class FormCadastroOsNovo : Form
    {
        DataTable TableCliente;
        DataTable TableNomeCliente;
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
        private int ID_OS = 0;
        public int IdOs
        {
            get
            {
                return this.ID_OS;

            }
            set
            {
                this.ID_OS = value;
            }
        }
        public int ID_FUNCIONARIO = 0;
        public int IdFuncionario
        {
            get
            {
                return this.ID_FUNCIONARIO;

            }
            set
            {
                this.ID_FUNCIONARIO = value;
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
        private string TIPO_LOGRADOURO2 = "";
        public string Tipologradouro2
        {
            get
            {
                return this.TIPO_LOGRADOURO2;

            }
            set
            {
                this.TIPO_LOGRADOURO2 = value;
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
        private string COMPLEMENTOS2 = "";
        public string Complementos2
        {
            get
            {
                return this.COMPLEMENTOS2;

            }
            set
            {
                this.COMPLEMENTOS2 = value;
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
        private string BAIRRO2 = "";
        public string Bairro2
        {
            get
            {
                return this.BAIRRO2;

            }
            set
            {
                this.BAIRRO2 = value;
            }
        }
        private string CIDADE2 = "";
        public string Cidade2
        {
            get
            {
                return this.CIDADE2;

            }
            set
            {
                this.CIDADE2 = value;
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


        private string operacao = "";

        private Boolean validaNome(TextBox textBox, ErrorProvider errorProvider)
        {
            if (!String.IsNullOrWhiteSpace(txtNomeOS.Text))
            {
                errorProviderOs.SetError(textBox, "");
                return true;
            }
            else
            {
                errorProviderOs.SetError(textBox, "Nome Inválido!");
                return false;
            }

        }
        public void AlteraBotoes(int op)
        {
            if (op == 1)// Cadastra OS campos
            {
                panel1.Enabled = true;
                panel2.Enabled = false;
                panel4.Enabled = true;
                panel6.Enabled = true;


                buttonCadastraOs.Enabled = true;


                buttonVerifica.Enabled = false;
                buttonLimpaOs.Enabled = false;
                buttonCancelarOs.Enabled = true;
                buttonFecharOs.Enabled = true;



            }
            if (op == 2)//salvar Cadastro de Cliente
            {
                panel1.Enabled = false;
                panel2.Enabled = false;
                panel3.Enabled = false;
                panel4.Enabled = false;
                panel5.Enabled = false;
                panel6.Enabled = false;

                buttonCadastraOs.Enabled = true;


                buttonVerifica.Enabled = false;
                buttonLimpaOs.Enabled = false;
                buttonCancelarOs.Enabled = false;
                buttonFecharOs.Enabled = true;


            }
            if (op == 3)//Calcelar Cadastro de Cliente
            {
                panel1.Enabled = false;
                panel2.Enabled = false;
                panel3.Enabled = false;
                panel4.Enabled = false;
                panel5.Enabled = false;
                panel6.Enabled = false;

                buttonCadastraOs.Enabled = true;

                buttonVerifica.Enabled = false;
                buttonLimpaOs.Enabled = false;
                buttonCancelarOs.Enabled = false;
                buttonFecharOs.Enabled = true;



            }
            if (op == 4) //  Editar Cadastro de Cliente
            {
                txtMsOs.Enabled = false;

                buttonCadastraOs.Enabled = false;

                buttonVerifica.Enabled = true;
                buttonLimpaOs.Enabled = false;
                buttonCancelarOs.Enabled = true;
                buttonFecharOs.Enabled = true;


            }
            if (op == 5)//Cancela Pesquisa
            {
                txtPesquisaMSCliente.Enabled = false;
                txtPesquisaNomeCliente.Enabled = false;
                buttonPesquisaCliente.Enabled = false;
                radioButtonOculto.Checked = true;
                radioButtonPequisaMS.Enabled = false;
                radioButtonPesquisaNome.Enabled = false;
            }
            if (op == 6)//Pesquisa Com suscesso!
            {
                buttonCadastraOs.Enabled = false;


                buttonVerifica.Enabled = false;
                buttonLimpaOs.Enabled = false;
                buttonCancelarOs.Enabled = true;
                buttonFecharOs.Enabled = true;
            }
            if (op == 7)//Botão Verificar informações Passadas
            {

                txtNomeOS.Enabled = false;
                txtMsOs.Enabled = false;

                txtTipo_logradouro.Enabled = false;
                txtBairroOS.Enabled = false;
                txtBairroNumero.Enabled = false;

                txtTelefoneOs.Enabled = false;

                txtEnderecoOS.Enabled = false;


            }
            if (op == 8)//Libera Pessoa Fisica e Juridica!
            {
                panel1.Enabled = true;
                panel2.Enabled = false;
                panel4.Enabled = true;
                panel6.Enabled = true;


                buttonCadastraOs.Enabled = false;


                buttonVerifica.Enabled = true;
                buttonLimpaOs.Enabled = false;
                buttonCancelarOs.Enabled = true;
                buttonFecharOs.Enabled = true;
            }
            if (op == 9)//Libera Pesquisa Por MS e Nome.
            {

                buttonCadastraOs.Enabled = false;

                buttonCancelarOs.Enabled = true;
                buttonFecharOs.Enabled = true;

            }
            if (op == 10)//limpa textos
            {
                txtMsOs.Clear();
                txtNomeOS.Clear();
                txtEnderecoOS.Clear();
                txtTelefoneOs.Clear();
                txtTipo_logradouro.Clear();
                txtEnderecoOS.Clear();
                txtBairroNumero.Clear();
                txtBairroOS.Clear();

                txtPesquisaMSCliente.Clear();
                txtPesquisaNomeCliente.Clear();

                comboBoxContato.Items.Clear();
                comboBoxFuncionario.Items.Clear();
            }

        }
        //METODO PARA VERIFICA SE O FORMULÁRIO ESTA ABERTO SE TIVER ELE FECHA!
        public static void CancelaCadastradoOs(Type frmType)
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
            CancelaCadastradoOs(typeof(FormCadastroOsNovo));
        }


        private void buttonFecharCliente_Click(object sender, EventArgs e)
        {
            FecharTodosFormulario();
        }

        private void buttonCancelarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                FecharTodosFormulario();
                buttonLimpaOs.Enabled = false;

                FormCadastroOsNovo cadastracliente = new FormCadastroOsNovo(this.IdPessoaLogada, this.NomeAcesso,
                    this.NomeServidor, this.NomeBaseDados, this.NomeUsuario, this.SenhaBaseDados);
                cadastracliente.MdiParent = FormCadastroOsNovo.ActiveForm;
                cadastracliente.Show();
                cadastracliente.Top = 0;
                cadastracliente.Left = 0;
            }
            catch(Exception err)
            {
                MessageBox.Show("Error " + err.ToString());
            }
        }

        private void buttonLimpaCliente_Click(object sender, EventArgs e)
        {
            AlteraBotoes(10);
        }

        private void buttonCadastraOs_Click(object sender, EventArgs e)
        {
            try
            {
                this.operacao = "Inserir";

                txtOrigemChamado.MaxLength = 400;

                txtservicoexecutados.MaxLength = 482;

                dataGridViewPesquisa.Enabled = true;

                AlteraBotoes(1);

                SqlConnection conn = new SqlConnection(this.connetionString);

                SqlDataAdapter da = new SqlDataAdapter("EXEC D_O_ConsultaCadastroNOS; ", conn);
                DataSet ds = new DataSet();
                da.Fill(ds);


                if (!(ds.Tables[0].Rows.Count > 0))
                {
                    IdOs = 1;
                    txtNumeroOrdemServico.Text = " N° " + IdOs.ToString();
                    conn.Close();
                }
                if (ds.Tables[0].Rows.Count > 0)
                {
                    int soma = int.Parse(ds.Tables[0].Rows[0][0].ToString());
                    IdOs = 1 + soma;
                    txtNumeroOrdemServico.Text = " N° " + IdOs.ToString();
                    conn.Close();
                }

                buttonCadastraOs.Enabled = false;
            }
            catch (Exception err)
            {
                MessageBox.Show("Error" + err.ToString());
            }
            

        }
        private void buttonPesquisaCliente_Click(object sender, EventArgs e)
        {
            PesquisaCliente();
        }
        public void PesquisaCliente()
        {
            try
            {
                //String connectionString = "Data Source=PROGRAMAS;Initial Catalog=MSOS;Persist Security Info=True;User ID=sa;Password=dellm@ster2016;";
                SqlConnection conn = new SqlConnection(this.connetionString);

                if (radioButtonPequisaMS.Checked)
                {
                    if (txtPesquisaMSCliente.Text == "")
                    {
                        MessageBox.Show("O nome campo MS nao pode esta em branco! ");
                        AlteraBotoes(10);
                    }

                    if (!(txtPesquisaMSCliente.Text == ""))
                    {
                        int MS = int.Parse(this.txtPesquisaMSCliente.Text);
                        //SELECIONA POR MS
                        SqlDataAdapter da1 = new SqlDataAdapter("EXEC D_ConsultaPessoaMsClienteTxt " + MS + ",1; ", conn);
                        DataSet ds1 = new DataSet();
                        da1.Fill(ds1);

                        conn.Open();

                        if (ds1.Tables[0].Rows.Count > 0)
                        {
                            IdPessoa = int.Parse(ds1.Tables[0].Rows[0][0].ToString());
                            idPessoaTipo = int.Parse(ds1.Tables[0].Rows[0][1].ToString());

                            if (IdPessoa != 0)
                            {
                                buttonLimpaOs.Enabled = true;
                                panel2.Enabled = true;
                                panel3.Enabled = true;
                                panel4.Enabled = false;
                                panel5.Enabled = true;
                                buttonEscolherImpressora.Enabled = true;
                                buttonImprimirOS.Enabled = true;
                                buttonVerifica.Enabled = true;
                                comboBoxContato.Items.Clear();
                                Fill_listBoxContatos();

                                comboBoxFuncionario.Items.Clear();

                                Fill_listBoxFuncionario();
                            }
                            if (IdPessoa == 0)
                            {
                                panel2.Enabled = false;
                                panel3.Enabled = false;
                                panel4.Enabled = false;
                                panel5.Enabled = false;
                                buttonEscolherImpressora.Enabled = false;
                                buttonImprimirOS.Enabled = false;
                                buttonVerifica.Enabled = false;

                            }

                            try
                            {
                                if (idPessoaTipo == 1)
                                {
                                    try
                                    {
                                        txtNomeOS.Text = ds1.Tables[0].Rows[0][3].ToString();
                                        txtMsOs.Text = ds1.Tables[0].Rows[0][44].ToString();
                                        txtTelefoneOs.Text = ds1.Tables[0].Rows[0][4].ToString();
                                        //txtTipo_logradouro.Text = ds1.Tables[0].Rows[0][32].ToString();
                                        txtEnderecoOS.Text = ds1.Tables[0].Rows[0][38].ToString();
                                        txtBairroNumero.Text = ds1.Tables[0].Rows[0][39].ToString();
                                        txtComplOs.Text = ds1.Tables[0].Rows[0][40].ToString();
                                        txtBairroOS.Text = ds1.Tables[0].Rows[0][41].ToString();
                                        txtCidadeOs.Text = ds1.Tables[0].Rows[0][42].ToString();

                                        conn.Close();

                                        panel2.Enabled = true;
                                    }
                                    catch (Exception ex)
                                    {
                                        MessageBox.Show(ex.Message);
                                    }
                                }
                                if (idPessoaTipo == 2)
                                {
                                    try
                                    {
                                        txtNomeOS.Text = ds1.Tables[0].Rows[0][3].ToString();
                                        txtMsOs.Text = ds1.Tables[0].Rows[0][44].ToString();
                                        txtTelefoneOs.Text = ds1.Tables[0].Rows[0][4].ToString();
                                        //txtTipo_logradouro.Text = ds1.Tables[0].Rows[0][32].ToString();
                                        txtEnderecoOS.Text = ds1.Tables[0].Rows[0][38].ToString();
                                        txtBairroNumero.Text = ds1.Tables[0].Rows[0][39].ToString();
                                        txtComplOs.Text = ds1.Tables[0].Rows[0][40].ToString();
                                        txtBairroOS.Text = ds1.Tables[0].Rows[0][41].ToString();
                                        txtCidadeOs.Text = ds1.Tables[0].Rows[0][42].ToString();

                                        conn.Close();

                                        panel2.Enabled = true;
                                    }
                                    catch (Exception ex)
                                    {
                                        MessageBox.Show(ex.Message);
                                    }
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
                        }
                        if (!(ds1.Tables[0].Rows.Count > 0))
                        {
                            MessageBox.Show("O ms: " + MS + " não consta no sistema!");
                            buttonEscolherImpressora.Enabled = false;
                            buttonImprimirOS.Enabled = false;

                            AlteraBotoes(10);
                            conn.Close();

                        }
                    }
                }
                if (radioButtonPesquisaNome.Checked)
                {
                    if (txtPesquisaNomeCliente.Text == "")
                    {
                        DialogResult dialogResultClientes = MessageBox.Show("Deseja consulta todos os clientes!", "Aviso", MessageBoxButtons.YesNo);

                        if (dialogResultClientes == DialogResult.Yes)
                        {
                            //SELECIONA POR TODOS OS 
                            SqlDataAdapter da1 = new SqlDataAdapter("EXEC D_ConsultaPessoaClienteNomeTxt '" + "',1;", conn);
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
                                    dataGridViewPesquisa.Refresh();
                                }
                                label8.Text = dataGridViewPesquisa.RowCount.ToString();

                                MessageBox.Show("Nem um Registro de nome Achado!");
                                conn.Close();
                            }
                            if (ds1.Tables[0].Rows.Count > 0)
                            {
                                dataGridViewPesquisaCliente();
                                dataGridViewPesquisa.RowCount.ToString();
                                buttonVerifica.Enabled = true;
                                conn.Close();
                            }
                        }
                        else if (dialogResultClientes == DialogResult.No)
                        {

                        }
                    }
                    if (!(txtPesquisaNomeCliente.Text == ""))
                    {
                        //SELECIONA POR TODOS OS 
                        SqlDataAdapter da1 = new SqlDataAdapter("EXEC D_ConsultaPessoaClienteNomeTxt '" + txtPesquisaNomeCliente.Text + "',1;", conn);
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
                                dataGridViewPesquisa.Refresh();
                            }
                            label8.Text = dataGridViewPesquisa.RowCount.ToString();

                            MessageBox.Show("Nem um Registro de nome Achado!");
                            conn.Close();
                        }
                        if (ds1.Tables[0].Rows.Count > 0)
                        {
                            dataGridViewPesquisaCliente();
                            dataGridViewPesquisa.RowCount.ToString();
                            buttonVerifica.Enabled = true;
                            conn.Close();
                        }
                    }
                }
                else if (!(radioButtonPequisaMS.Checked) && !(radioButtonPesquisaNome.Checked)) MessageBox.Show("Seleciona Ms ou Nome para uma Pesquisa!");
                {
                    conn.Close();
                }
            }
            catch(Exception err)
            {
                MessageBox.Show("Erro " + err.ToString());
            }     
        }
        private void radioButtonPequisaMS_CheckedChanged(object sender, EventArgs e)
        {
            txtPesquisaMSCliente.Enabled = true;
            txtPesquisaNomeCliente.Enabled = false;
            AlteraBotoes(10);
        }
        private void buttonVerifica_Click(object sender, EventArgs e)
        {
            CadastroOS();
        }
        private void radioButtonPesquisaNome_CheckedChanged(object sender, EventArgs e)
        {
            txtPesquisaMSCliente.Enabled = false;
            txtPesquisaNomeCliente.Enabled = true;
            AlteraBotoes(10);
        }
        public void CadastroOS()
        {
            try
            {
                Conexao conexao = new Conexao(this.connetionString);
                DALOrdemServico da = new DALOrdemServico(conexao);

                Os cadastra = new Os();

                if ((validaNome(txtNomeOS, errorProviderOs) == true)) //(labelConfirmacao.Text).Equals("sucesso - cep completo"))
                {
                    try
                    {
                        string NumeroIdContato = "";

                        NumeroIdContato = this.IdContato.ToString();
                        cadastra.IdPessoaCliente = IdPessoa;
                        if (NumeroIdContato == "")
                        {
                            cadastra.IdContato = 0;
                        }
                        if (!(NumeroIdContato == ""))
                        {
                            cadastra.IdContato = IdContato;
                        }
                        cadastra.IdFuncionario = IdFuncionario;
                        cadastra.IdServico = 0;
                        cadastra.IdItemServico = 0;
                        cadastra.IdPessoaLogada = this.IdPessoaLogada;
                        cadastra.OrigemChamado = txtOrigemChamado.Text;
                        cadastra.ServicosExecutados = txtservicoexecutados.Text;
                        cadastra.ValorObra = "Desenvolver";
                        cadastra.HorarioInicio = maskedTxtHorarioInicio.Text;
                        cadastra.HorarioFinal = maskedTxtHorarioFInal.Text;

                        cadastra.DataSolicitacao = Convert.ToDateTime(txtDataSolicitacao.Value.Date.ToString("dd/MM/yyyy"));

                        cadastra.Estado = 1;
                        cadastra.Situacao = 1;
                        cadastra.MudancaDataFechamento = 0;


                        if (this.operacao == "Inserir")
                        {
                            if (this.comboBoxFuncionario.Text == "")
                            {
                                MessageBox.Show("Selecione um funcionário Cadastrado no sistema!");
                            }
                            else if (!(this.comboBoxFuncionario.Text == ""))
                            {
                                DialogResult dialogResultOs = MessageBox.Show("Confirma a criação da OS?", "Aviso", MessageBoxButtons.YesNo);

                                if (dialogResultOs == DialogResult.Yes)
                                {
                                    da.IncluiOS(cadastra);

                                    MessageBox.Show("Os Cadastrado com Exito! \n A Os foi gerada como o número: " + cadastra.IdOs + ".");


                                    DialogResult dialogResultImprimir = MessageBox.Show("Deseja Visualizar ou Imprimir Documento!", "Aviso", MessageBoxButtons.YesNo);

                                    if (dialogResultImprimir == DialogResult.Yes)
                                    {
                                        panel1.Enabled = false;
                                        panel2.Enabled = false;
                                        panel3.Enabled = false;
                                        panel4.Enabled = false;
                                        panel5.Enabled = false;
                                        panel6.Enabled = false;
                                        buttonVerifica.Enabled = false;
                                        buttonLimpaOs.Enabled = false;
                                        buttonCadastraOs.Enabled = false;
                                        buttonFecharOs.Enabled = false;
                                        buttonCadastraOsNovo.Enabled = true;
                                        buttonImprimirOS.Enabled = true;
                                        buttonEscolherImpressora.Enabled = true;
                                    }
                                    else if (dialogResultImprimir == DialogResult.No)
                                    {
                                        FecharTodosFormulario();

                                        FormCadastroOsNovo CadastraOs = new FormCadastroOsNovo(this.IdPessoaLogada, this.NomeAcesso, this.NomeServidor, this.NomeBaseDados, this.NomeUsuario, this.SenhaBaseDados);
                                        CadastraOs.MdiParent = FormCadastroOsNovo.ActiveForm;
                                        CadastraOs.Show();
                                        CadastraOs.Top = 0;
                                        CadastraOs.Left = 0;
                                    }
                                }
                                else if (dialogResultOs == DialogResult.No)
                                {
                                    MessageBox.Show("A Os não foi gerada.");
                                }
                            }
                        }
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro de acesso ao banco de Dados-----------------------------------------------------------------------------------------------------------------------------------------. ", ex.Message);
                    }
                }
            }
            catch (Exception err)
            {
                err.ToString();
            }
        }
        public static string InsereQuebraPrincipal(string TEXTO_GRANDE)
        {
            try
            {
                int acumulador2 = 77;

                int i = 0;

                int n = 0;

                int intTotal = 0;

                int acumuladorTemp = 0;

                string ServicoExecutado2 = "";

                Boolean finalizar = false;

                int quantString = TEXTO_GRANDE.Length;

                int total = quantString / 77;

                StringBuilder sb = new StringBuilder(TEXTO_GRANDE);

                string StringTeste = TEXTO_GRANDE;

                //NÃO A QUEBRA DE LINHA SE FOR SÓ UMA LINHA
                if (quantString <= acumulador2)
                {
                    ServicoExecutado2 = sb.ToString();
                }
                //QUEBRA DE LINHA SE FOR MAS QUE UMA LINHA

                if (quantString > acumulador2)
                {
                    for (i = 0; i < total; i++)
                    {
                        if (finalizar == false)
                        {
                            if (StringTeste[acumulador2] == ' ')
                            {
                                sb.Insert(acumulador2 + 1, '\n');

                                ServicoExecutado2 = sb.ToString();

                                acumuladorTemp = 77 + acumulador2;//acumulador2

                                if (acumuladorTemp > quantString)
                                {
                                    finalizar = true;
                                }
                                if (acumuladorTemp < quantString)
                                {
                                    acumulador2 = acumuladorTemp;
                                }
                            }

                            if (!(StringTeste[acumulador2] == ' '))
                            {
                                for (n = (acumulador2); n > 0; n--)
                                {
                                    if (StringTeste[n] == ' ')
                                    {
                                        sb.Insert(n + 1, '\n');

                                        ServicoExecutado2 = sb.ToString();

                                        acumuladorTemp = 77 + acumulador2;//n

                                        n = 0;

                                        if (acumuladorTemp > quantString)
                                        {
                                            finalizar = true;
                                            //REMOVE O INICIO DO CARACTERES EM BRANCO DA ULTIMA LINHA
                                            for (intTotal = ((total * 77)); intTotal > 0; intTotal--)
                                            {
                                                if (ServicoExecutado2[intTotal] == ' ')
                                                {
                                                    //sb.Remove(intTotal, 5);
                                                    sb.Remove(intTotal, 1);
                                                    ServicoExecutado2 = sb.ToString();

                                                    intTotal = 0;
                                                }
                                            }
                                        }
                                        if (acumuladorTemp < quantString)
                                        {
                                            acumulador2 = acumuladorTemp;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }

                return ServicoExecutado2;
            }
            catch (Exception exp)
            {
                return exp.ToString();
            }
        }
        public static string InsereQuebraSegundario(string TEXTO_GRANDE)
        {
            try
            {
                int acumulador2 = 77;

                int i = 0;

                int n = 0;

                int intTotal = 0;

                int acumuladorTemp = 0;

                string ServicoExecutado2 = "";

                Boolean finalizar = false;

                int quantString = TEXTO_GRANDE.Length;

                int total = quantString / 77;

                StringBuilder sb = new StringBuilder(TEXTO_GRANDE);

                string StringTeste = TEXTO_GRANDE;

                //NÃO A QUEBRA DE LINHA SE FOR SÓ UMA LINHA
                if (quantString <= acumulador2)
                {
                    ServicoExecutado2 = sb.ToString();
                }
                //QUEBRA DE LINHA SE FOR MAS QUE UMA LINHA

                if (quantString > acumulador2)
                {
                    for (i = 0; i < total; i++)
                    {
                        if (finalizar == false)
                        {
                            if (StringTeste[acumulador2] == ' ')
                            {
                                sb.Insert(acumulador2 + 1, '\n');

                                ServicoExecutado2 = sb.ToString();

                                acumuladorTemp = 77 + acumulador2;//acumulador2

                                if (acumuladorTemp > quantString)
                                {
                                    finalizar = true;
                                }
                                if (acumuladorTemp < quantString)
                                {
                                    acumulador2 = acumuladorTemp;
                                }
                            }

                            if (!(StringTeste[acumulador2] == ' '))
                            {
                                for (n = (acumulador2); n > 0; n--)
                                {
                                    if (StringTeste[n] == ' ')
                                    {
                                        sb.Insert(n + 1, '\n');

                                        ServicoExecutado2 = sb.ToString();

                                        acumuladorTemp = 77 + acumulador2;//n

                                        n = 0;

                                        if (acumuladorTemp > quantString)
                                        {
                                            finalizar = true;
                                            //REMOVE O INICIO DO CARACTERES EM BRANCO DA ULTIMA LINHA
                                            for (intTotal = ((total * 77)); intTotal > 0; intTotal--)
                                            {
                                                if (ServicoExecutado2[intTotal] == ' ')
                                                {
                                                    //sb.Remove(intTotal, 5);
                                                    sb.Remove(intTotal, 1);
                                                    ServicoExecutado2 = sb.ToString();

                                                    intTotal = 0;
                                                }
                                            }
                                        }
                                        if (acumuladorTemp < quantString)
                                        {
                                            acumulador2 = acumuladorTemp;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }

                return ServicoExecutado2;
            }
            catch (Exception exp)
            {
                return exp.ToString();
            }
        }
        //LISTA OS Fucionarios da Empresa
        void Fill_listBoxFuncionario()
        {
            SqlConnection connection = new SqlConnection(this.connetionString);

            try
            {
                connection.Open();
                string Query = "EXEC D_O_ConsultaTecnicoOs;";


                SqlCommand command = new SqlCommand(Query, connection);
                SqlDataReader dr = command.ExecuteReader();
                while (dr.Read())
                {
                    string name = dr.GetString(0);
                    comboBoxFuncionario.Items.Add(name);
                }
                connection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //Seleciona Funcionario da empresa
        private void comboBoxFuncionario_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(this.connetionString);

            try
            {
                connection.Open();

                string Query = "exec D_ConsultaTecnicoOsTxT '" + this.comboBoxFuncionario.Text + "';";

                SqlCommand command = new SqlCommand(Query, connection);
                SqlDataReader dr = command.ExecuteReader();
                while (dr.Read())
                {

                    IdFuncionario = dr.GetInt32(0);
                    comboBoxFuncionario.Text = dr.GetString(1);
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //LISTA OS Contatos da empresa Buscada
        void Fill_listBoxContatos()
        {
            SqlConnection connection = new SqlConnection(this.connetionString);

            try
            {
                connection.Open();
                string Query = "EXEC D_O_ConsultaCadastroIdContatosOS " + IdPessoa + ";";


                SqlCommand command = new SqlCommand(Query, connection);
                SqlDataReader dr = command.ExecuteReader();
                while (dr.Read())
                {
                    string name = dr.GetString(0);
                    comboBoxContato.Items.Add(name);
                }
                connection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //Seleciona Contato da empresa
        private void comboBoxContato_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                SqlConnection connection = new SqlConnection(this.connetionString);
                connection.Open();

                string Query = "EXEC D_O_ConsultaCadastroNomeClienteOStxt '" + this.comboBoxContato.Text + "';";

                SqlCommand command = new SqlCommand(Query, connection);
                SqlDataReader dr = command.ExecuteReader();
                while (dr.Read())
                {

                    this.IdContato = dr.GetInt32(0);
                    comboBoxContato.Text = dr.GetString(1);
                    this.ComboBoxAbreviacao = dr.GetString(1);


                    //MessageBox.Show("O ID do Contato Selecionado foi: " + IdContato);

                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonCadastraOsNovo_Click(object sender, EventArgs e)
        {
            try
            {
                FecharTodosFormulario();

                FormCadastroOsNovo cadastracliente = new FormCadastroOsNovo(this.IdPessoaLogada, this.NomeAcesso,
                    this.NomeServidor, this.NomeBaseDados, this.NomeUsuario, this.SenhaBaseDados);
                cadastracliente.MdiParent = FormCadastroOsNovo.ActiveForm;
                cadastracliente.Show();
                cadastracliente.Top = 0;
                cadastracliente.Left = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FormCadastroOsNovo_Load(object sender, EventArgs e)
        {

        }
        //Cadastro Novo de OS sequência
        public FormCadastroOsNovo(int ID_PESSOA_LOGADA, string NomeAcesso, string NomeServidor, string NomeBaseDados, string NomeUsuario, string SenhaBaseDados)
        {
            InitializeComponent();

            this.txtDataSolicitacao.Value = DateTime.Now.Date;

            this.IdPessoaLogada = ID_PESSOA_LOGADA;
            this.NomeAcesso = NomeAcesso;
            NomeLogado.Text = NomeAcesso;

            this.NomeServidor = NomeServidor;
            this.NomeBaseDados = NomeBaseDados;
            this.NomeUsuario = NomeUsuario;
            this.SenhaBaseDados = SenhaBaseDados;
            this.connetionString = "Data Source=" + this.NomeServidor + ";Initial Catalog=" + this.NomeBaseDados + ";Persist Security Info=True;User ID=" + this.NomeUsuario + ";Password=" + this.SenhaBaseDados + ";";
        }
        public FormCadastroOsNovo(int ID_PESSOA_LOGADA,int NUMERO_OS_LIVRE, string NomeAcesso, string NomeServidor, string NomeBaseDados, string NomeUsuario, string SenhaBaseDados)
        {
            InitializeComponent();

            this.txtDataSolicitacao.Value = DateTime.Now.Date;

            this.NumeroOsLivre= NUMERO_OS_LIVRE;
            this.IdPessoaLogada = ID_PESSOA_LOGADA;
            this.NomeAcesso = NomeAcesso;
            NomeLogado.Text = NomeAcesso;

            this.NomeServidor = NomeServidor;
            this.NomeBaseDados = NomeBaseDados;
            this.NomeUsuario = NomeUsuario;
            this.SenhaBaseDados = SenhaBaseDados;
            this.connetionString = "Data Source=" + this.NomeServidor + ";Initial Catalog=" + this.NomeBaseDados + ";Persist Security Info=True;User ID=" + this.NomeUsuario + ";Password=" + this.SenhaBaseDados + ";";
        }
        public FormCadastroOsNovo(string NomeServidor, string NomeBaseDados, string NomeUsuario, string SenhaBaseDados)
        {
            InitializeComponent();

            this.txtDataSolicitacao.Value = DateTime.Now.Date;

            this.NomeServidor = NomeServidor;
            this.NomeBaseDados = NomeBaseDados;
            this.NomeUsuario = NomeUsuario;
            this.SenhaBaseDados = SenhaBaseDados;
            this.connetionString = "Data Source=" + this.NomeServidor + ";Initial Catalog=" + this.NomeBaseDados + ";Persist Security Info=True;User ID=" + this.NomeUsuario + ";Password=" + this.SenhaBaseDados + ";";
        }
        void dataGridViewPesquisaCliente()
        {
            string connetionString = (this.connetionString);
            SqlConnection connection = new SqlConnection(connetionString);
            SqlCommand command = new SqlCommand("EXEC D_ConsultaPessoaClienteNomeTxt '" + txtPesquisaNomeCliente.Text + "',1;", connection);
            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = command;
                TableCliente = new DataTable();
                adapter.Fill(TableCliente);
                BindingSource Source = new BindingSource();
                Source.DataSource = TableCliente;
                dataGridViewPesquisa.DataSource = Source;
                adapter.Update(TableCliente);
            }
            catch (Exception ex)
            {
                ex.ToString();
            }

            //DataTable dt = new DataTable();
        }
        ////METODO STATIC QUE FAZ A COLEÇÃO DE DADOS DA STRING DA MS
        //public static AutoCompleteStringCollection LoadAutoCompleteOsCliente()
        //{
        //    DataTable dt = LoadDataTableOsCliente();

        //    AutoCompleteStringCollection MS = new AutoCompleteStringCollection();

        //    foreach (DataRow row in dt.Rows)
        //    {
        //        MS.Add(Convert.ToString(row["MS"]));
        //    }

        //    return MS;
        //}
        ////METODO QUE SELECIONA MS NO SQL ORDERNADO POR MS
        //public static DataTable LoadDataTableOsCliente()
        //{
        //    string connetionString = ("Data Source=PROGRAMAS;Initial Catalog=MSOS;Persist Security Info=True;User ID=sa;Password=dellm@ster2016;");
        //    SqlConnection connection;
        //    SqlCommand command;
        //    SqlDataAdapter adapter = new SqlDataAdapter();
        //    DataTable dt = new DataTable();
        //    string sql = "EXEC ConsultaPessoaMsCliente; ";
        //    connection = new SqlConnection(connetionString);
        //    connection.Open();
        //    command = new SqlCommand(sql, connection);
        //    adapter.SelectCommand = command;
        //    adapter.Fill(dt);
        //    connection.Close();

        //    return dt;
        //}

        private void dataGridViewPesquisa_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // FecharCadastroCliente();

            if (dataGridViewPesquisa.RowCount == 0)
            {
                IdPessoa = 0;
            }
            if (!(dataGridViewPesquisa.RowCount == 0))
            {
                try
                {
                    SqlConnection conn = new SqlConnection(this.connetionString);

                    IdPessoa = Convert.ToInt32(dataGridViewPesquisa["ID_PESSOA", e.RowIndex].Value);

                    //SELECIONA POR TODOS OS 
                    SqlDataAdapter da1 = new SqlDataAdapter("EXEC D_ConsultaClienteEditarTxt " + IdPessoa + ";", conn);
                    DataSet ds1 = new DataSet();
                    da1.Fill(ds1);

                    conn.Open();

                    if (ds1.Tables[0].Rows.Count > 0)
                    {
                        IdPessoa = int.Parse(ds1.Tables[0].Rows[0][0].ToString());
                        idPessoaTipo = int.Parse(ds1.Tables[0].Rows[0][1].ToString());

                        if (IdPessoa != 0)
                        {
                            panel2.Enabled = true;
                            panel3.Enabled = true;
                            panel4.Enabled = false;
                            panel5.Enabled = true;
                            buttonEscolherImpressora.Enabled = true;
                            buttonImprimirOS.Enabled = true;

                            comboBoxContato.Items.Clear();
                            Fill_listBoxContatos();
                            buttonLimpaOs.Enabled = true;

                            comboBoxFuncionario.Items.Clear();

                            Fill_listBoxFuncionario();
                        }
                        if (IdPessoa == 0)
                        {
                            panel2.Enabled = false;
                            panel3.Enabled = false;
                            panel4.Enabled = false;
                            panel5.Enabled = false;
                            buttonEscolherImpressora.Enabled = false;
                            buttonImprimirOS.Enabled = false;

                        }

                        try
                        {
                            if (idPessoaTipo == 1)
                            {
                                try
                                {
                                    txtNomeOS.Text = ds1.Tables[0].Rows[0][3].ToString();
                                    txtMsOs.Text = ds1.Tables[0].Rows[0][44].ToString();
                                    txtTelefoneOs.Text = ds1.Tables[0].Rows[0][4].ToString();
                                    //txtTipo_logradouro.Text = ds1.Tables[0].Rows[0][32].ToString();
                                    txtEnderecoOS.Text = ds1.Tables[0].Rows[0][38].ToString();
                                    txtBairroNumero.Text = ds1.Tables[0].Rows[0][39].ToString();
                                    txtComplOs.Text = ds1.Tables[0].Rows[0][40].ToString();
                                    txtBairroOS.Text = ds1.Tables[0].Rows[0][41].ToString();
                                    txtCidadeOs.Text = ds1.Tables[0].Rows[0][42].ToString();

                                    conn.Close();

                                    panel2.Enabled = true;
                                }
                                catch (Exception ex)
                                {
                                    ex.ToString();
                                }
                            }
                            if (idPessoaTipo == 2)
                            {
                                try
                                {
                                    txtNomeOS.Text = ds1.Tables[0].Rows[0][3].ToString();
                                    txtMsOs.Text = ds1.Tables[0].Rows[0][44].ToString();
                                    txtTelefoneOs.Text = ds1.Tables[0].Rows[0][4].ToString();
                                    //txtTipo_logradouro.Text = ds1.Tables[0].Rows[0][32].ToString();
                                    txtEnderecoOS.Text = ds1.Tables[0].Rows[0][38].ToString();
                                    txtBairroNumero.Text = ds1.Tables[0].Rows[0][39].ToString();
                                    txtComplOs.Text = ds1.Tables[0].Rows[0][40].ToString();
                                    txtBairroOS.Text = ds1.Tables[0].Rows[0][41].ToString();
                                    txtCidadeOs.Text = ds1.Tables[0].Rows[0][42].ToString();

                                    conn.Close();

                                    panel2.Enabled = true;
                                }
                                catch (Exception ex)
                                {
                                    ex.ToString();
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            ex.ToString();
                        }
                    }
                    if (!(ds1.Tables[0].Rows.Count > 0))
                    {
                        MessageBox.Show("O cliente não consta no sistema!");
                        buttonEscolherImpressora.Enabled = false;
                        buttonImprimirOS.Enabled = false;

                        AlteraBotoes(10);

                    }
                }
                catch (Exception ex)
                {
                    ex.ToString();
                }
            }
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtPesquisaMSCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && !(e.KeyChar == (char)Keys.Enter) && !(e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }

            if (e.KeyChar == 13)
            {
                PesquisaCliente();
            }
        }
        private void txtPesquisaNomeCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                PesquisaCliente();
            }
        }
        void dataGridViewPesquisaNome()
        {
            SqlConnection connection = new SqlConnection(this.connetionString);
            SqlCommand command = new SqlCommand("EXEC D_ConsultaPessoaClienteNomeTxt '" + txtPesquisaNomeCliente.Text + "',1;", connection);
            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = command;
                TableNomeCliente = new DataTable();
                adapter.Fill(TableNomeCliente);
                BindingSource Source = new BindingSource();
                Source.DataSource = TableNomeCliente;
                dataGridViewPesquisa.DataSource = Source;
                adapter.Update(TableNomeCliente);
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
            connection.Close();
            //DataTable dt = new DataTable();
        }
        private void txtPesquisaNomeCliente_TextChanged(object sender, EventArgs e)
        {
            //DataView DV = new DataView(TableNomeCliente);
            //DV.RowFilter = string.Format("CLIENTE LIKE '%{0}%'", txtPesquisaNomeCliente.Text);
            //dataGridViewPesquisa.DataSource = DV;
            //label8.Text = dataGridViewPesquisa.RowCount.ToString();
        }

        private void buttonEscolherImpressora_Click(object sender, EventArgs e)
        {
            try
            {
                if (printDialogCaixa.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    printDocumentImprimir.PrinterSettings = printDialogCaixa.PrinterSettings;
                    printDocumentImprimir.Print();
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("Error " + err.ToString());
            }
        }

        private void printDocumentImprimir_PrintPage(object sender, PrintPageEventArgs e)
        {
            Bitmap bmp = Properties.Resources.ImagemOs1;
            Image newImagem = bmp;

            string HorarioInicial = "";
            string HorarioFInal = "";

            if (!(maskedTxtHorarioInicio.Text == ""))
            {
                StringBuilder HorarioInicialSb = new StringBuilder(maskedTxtHorarioInicio.Text);
                HorarioInicialSb.Insert(2, ":");
                HorarioInicial = HorarioInicialSb.ToString();
            }
            if (!(maskedTxtHorarioFInal.Text == ""))
            {
                StringBuilder HorarioFInalSb = new StringBuilder(maskedTxtHorarioFInal.Text);
                HorarioFInalSb.Insert(2, ":");
                HorarioFInal = HorarioFInalSb.ToString();
            }

            e.Graphics.DrawImage(newImagem, 0, 0, newImagem.Width, newImagem.Height);
            e.Graphics.DrawString("" + IdOs.ToString(), new Font("Arial", 30, FontStyle.Regular), Brushes.Black, new Point(592, 40));
            e.Graphics.DrawString("" + txtDataSolicitacao.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(337, 90));
            e.Graphics.DrawString("" + txtNomeOS.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(162, 173));
            e.Graphics.DrawString("" + txtMsOs.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(646, 174));
            e.Graphics.DrawString("" + txtEnderecoOS.Text + "," + txtBairroNumero.Text + "," + txtComplOs.Text + "-" + txtBairroOS.Text + "-", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(162, 198));//+ txtTipo_logradouro.Text + ": "
            e.Graphics.DrawString("" + this.ComboBoxAbreviacao, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(162, 222));
            e.Graphics.DrawString("" + txtTelefoneOs.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(162, 250));
            e.Graphics.DrawString("" + comboBoxFuncionario.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(162, 944));
            e.Graphics.DrawString("" + (txtOrigemChamado.Text), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(12, 305));
            e.Graphics.DrawString("" + (txtservicoexecutados.Text), new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(12, 485));
            e.Graphics.DrawString("" + HorarioInicial, new Font("Arial", 15, FontStyle.Italic), Brushes.Black, new Point(220, 1032));
            e.Graphics.DrawString("" + HorarioFInal, new Font("Arial", 15, FontStyle.Italic), Brushes.Black, new Point(510, 1032));
        }
        private void buttonImprimirOS_Click(object sender, EventArgs e)
        {
            try
            {
                printPreviewDialogVisualizar.Document = printDocumentImprimir;
                printPreviewDialogVisualizar.ShowDialog();
            }
            catch(Exception err)
            {
                MessageBox.Show("Error " + err.ToString());
            }

        }

        private void FormCadastroOsNovo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
            {
                this.Close();
            }
        }

        private void txtOrigemChamado_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                int tamanhoMaximoPorLinha = 105;
                int[] keysLiberadas = { (int)Keys.Enter, (int)Keys.Back };

                int posicaoAtual = txtOrigemChamado.SelectionStart;
                int linhaAtual = txtOrigemChamado.GetLineFromCharIndex(posicaoAtual);

                if (txtOrigemChamado.Lines.Length == 0)
                {
                    if (txtOrigemChamado.Text.Length > tamanhoMaximoPorLinha && !keysLiberadas.Contains((int)e.KeyChar))
                    {
                        e.Handled = true;
                    }
                }
                else if (txtOrigemChamado.Lines[linhaAtual].Length > tamanhoMaximoPorLinha && !keysLiberadas.Contains((int)e.KeyChar))
                {
                    e.Handled = true;
                }
            }
            catch (Exception)
            {
                if (e.KeyChar == (char)Keys.Back)
                {
                    e.Handled = false;
                }
                else { e.Handled = true; }
            }
        }

        private void txtservicoexecutados_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                int tamanhoMaximoPorLinha = 105;
                int[] keysLiberadas = { (int)Keys.Enter, (int)Keys.Back };

                int posicaoAtual = txtservicoexecutados.SelectionStart;
                int linhaAtual = txtservicoexecutados.GetLineFromCharIndex(posicaoAtual);

                if (txtservicoexecutados.Lines.Length == 0)
                {
                    if (txtservicoexecutados.Text.Length > tamanhoMaximoPorLinha && !keysLiberadas.Contains((int)e.KeyChar))
                    {
                        e.Handled = true;
                    }
                }
                else if (txtservicoexecutados.Lines[linhaAtual].Length > tamanhoMaximoPorLinha && !keysLiberadas.Contains((int)e.KeyChar))
                {
                    e.Handled = true;
                }
            }
            catch (Exception)
            {
                if (e.KeyChar == (char)Keys.Back)
                {
                    e.Handled = false;
                }
                else { e.Handled = true; }
            }
        }
    }
}