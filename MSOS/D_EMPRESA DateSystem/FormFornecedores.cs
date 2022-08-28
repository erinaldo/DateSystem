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

namespace DateSystem
{
    public partial class FormFornecedores : Form
    {
        //MSOSEntities MSOS = null;

        int SiteOFF = 0;

        Boolean verificador = false;

        Boolean CepSecundario = false;

        private string operacao = "";

        private ConsultaCNPJReceita consulta;

        //private int idCidadeSql = 0;

        private int ID_PESSOAFISICA = 0;
        public int idPessoaFisica
        {
            get
            {
                return this.ID_PESSOAFISICA;

            }
            set
            {
                this.ID_PESSOAFISICA = value;
            }
        }
        private int ID_PESSOAJURIDICA = 0;
        public int idPessoaJuridica
        {
            get
            {
                return this.ID_PESSOAJURIDICA;

            }
            set
            {
                this.ID_PESSOAJURIDICA = value;
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
        private int IDPESSOA = 0;
        Boolean VERIFICADOREDITAR = false;
        public Boolean VerificadorEditar
        {
            get
            {
                return this.VERIFICADOREDITAR;

            }
            set
            {
                this.VERIFICADOREDITAR = value;
            }
        }
        Boolean FORMULARIO = false;
        public Boolean Formulario
        {
            get
            {
                return this.FORMULARIO;

            }
            set
            {
                this.FORMULARIO = value;
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
        int CepManual = 0;
        int CepManualSe = 0;
        public FormFornecedores(string NomeServidor, string NomeBaseDados, string NomeUsuario, string SenhaBaseDados)
        {
            InitializeComponent();

            this.NomeServidor = NomeServidor;
            this.NomeBaseDados = NomeBaseDados;
            this.NomeUsuario = NomeUsuario;
            this.SenhaBaseDados = SenhaBaseDados;

            this.connetionString = "Data Source=" + this.NomeServidor + ";Initial Catalog=" + this.NomeBaseDados + ";Persist Security Info=True;User ID=" + this.NomeUsuario + ";Password=" + this.SenhaBaseDados + ";";


        }
        /*
// VALIDAR ENTRADA COM ERROPROVIDER
private Boolean validaMs(TextBox textBox, ErrorProvider errorProvider)
{
    if (!String.IsNullOrWhiteSpace(txtMsCliente.Text))
    {
        errorProviderCadastroDeCliente.SetError(textBox, "");
        return true;
    }
    else
    {
        errorProviderCadastroDeCliente.SetError(textBox, "MS Inválido!");
        return false;
    }
}
*/
        
        private Boolean ValidaNome(TextBox textBox, ErrorProvider errorProvider)
        {
            if (!String.IsNullOrWhiteSpace(txtNomeFornecedor.Text))
            {
                errorProviderFornecedor.SetError(textBox, "");
                return true;
            }
            else
            {
                errorProviderFornecedor.SetError(textBox, "Endereço Inválido!");
                return false;
            }
        }
        //private Boolean validaNumeroPrincipal(TextBox textBox, ErrorProvider errorProvider)
        //{
        //    if (!String.IsNullOrWhiteSpace(txtNumeroPrincipal.Text))
        //    {
        //        errorProviderFornecedor.SetError(textBox, "");
        //        return true;
        //    }
        //    else
        //    {
        //        errorProviderFornecedor.SetError(textBox, "Numero Inválido!");
        //        return false;
        //    }
        //}
        //private Boolean validaNumeroSecundario(TextBox textBox, ErrorProvider errorProvider)
        //{
        //    if (!String.IsNullOrWhiteSpace(txtBairroNumeroFornecedor.Text))
        //    {
        //        errorProviderFornecedor.SetError(textBox, "");
        //        return true;
        //    }
        //    else
        //    {
        //        errorProviderFornecedor.SetError(textBox, "Numero Inválido!");
        //        return false;
        //    }
        //}
        // VALIDAR ENTRADA COM ERROPROVIDER
        private Boolean validaEndereco(TextBox textBox, ErrorProvider errorProvider)
        {
            if (!String.IsNullOrWhiteSpace(txtEnderecoFornecedor.Text))
            {
                errorProviderFornecedor.SetError(textBox, "");
                return true;
            }
            else
            {
                errorProviderFornecedor.SetError(textBox, "Endereço Inválido!");
                return false;
            }
        }
        // VALIDAR ENTRADA COM ERROPROVIDER
        private Boolean validaTelefone(TextBox textBox, ErrorProvider errorProvider)
        {
            if (!String.IsNullOrWhiteSpace(txtTelefoneFornecedor.Text))
            {
                errorProviderFornecedor.SetError(textBox, "");
                return true;
            }
            else
            {
                errorProviderFornecedor.SetError(textBox, "Telefone Inválido!");
                return false;
            }
        }
        // VALIDAR ENTRADA COM ERROPROVIDER
        private Boolean validaBairro(TextBox textBox, ErrorProvider errorProvider)
        {
            if (!String.IsNullOrWhiteSpace(txtBairroFornecedor.Text))
            {
                errorProviderFornecedor.SetError(textBox, "");
                return true;
            }
            else
            {
                errorProviderFornecedor.SetError(textBox, "Bairro Inválido!");
                return false;
            }
        }
        // VALIDAR ENTRADA COM ERROPROVIDER
        private Boolean validaCep(MaskedTextBox textBox, ErrorProvider errorProvider)
        {
            if (!String.IsNullOrWhiteSpace(txtCepFornecedor.Text))
            {
                errorProviderFornecedor.SetError(textBox, "");
                return true;
            }
            else
            {
                errorProviderFornecedor.SetError(textBox, "Cep Inválido!");
                return false;
            }
        }
        // VALIDAR ENTRADA COM ERROPROVIDER
        private Boolean validaCidade(TextBox textBox, ErrorProvider errorProvider)
        {
            if (!String.IsNullOrWhiteSpace(txtCidadeFornecedor.Text))
            {
                errorProviderFornecedor.SetError(textBox, "");
                return true;
            }
            else
            {
                errorProviderFornecedor.SetError(textBox, "Cidade Inválido!");
                return false;
            }
        }
        // VALIDAR ENTRADA COM ERROPROVIDER
        private Boolean validaEmail(TextBox textBox, ErrorProvider errorProvider)
        {
            string email = txtEmailFornecedor.Text;
            string modelo = @"[\w\.-]+(\+[\w-]*)?@([\w-]+\.)+[\w-]+";

            if (Regex.IsMatch(email, modelo))
            {
                errorProviderFornecedor.SetError(textBox, "");
                return true;
            }
            else
            {
                errorProviderFornecedor.SetError(textBox, "E-mail Inválido!");
                return false;
            }
        }
        //private Boolean validaNumero(TextBox textBox, ErrorProvider errorProvider)
        //{
        //    if (!String.IsNullOrWhiteSpace(txtNumeroPrincipal.Text))
        //    {
        //        errorProviderFornecedor.SetError(textBox, "");
        //        return true;
        //    }
        //    else
        //    {
        //        errorProviderFornecedor.SetError(textBox, "Numero Inválido!");
        //        return false;
        //    }
        //}
        //private Boolean validaNumeroFornecedor(TextBox textBox, ErrorProvider errorProvider)
        //{
        //    if (!String.IsNullOrWhiteSpace(txtBairroNumeroFornecedor.Text))
        //    {
        //        errorProviderFornecedor.SetError(textBox, "");
        //        return true;
        //    }
        //    else
        //    {
        //        errorProviderFornecedor.SetError(textBox, "Numero Inválido!");
        //        return false;
        //    }
        //}
        // VALIDAR ENTRADA COM ERROPROVIDER
        private Boolean validaCnpj(TextBox textBox, ErrorProvider errorProvider)
        {
            if (!String.IsNullOrWhiteSpace(txtCnpj.Text))
            {
                errorProviderFornecedor.SetError(textBox, "");
                return true;
            }
            else
            {
                errorProviderFornecedor.SetError(textBox, "Cnpj Inválido!");
                return false;
            }

        }
        // VALIDAR ENTRADA COM ERROPROVIDER
        private Boolean validaInscricaoStadual(TextBox textBox, ErrorProvider errorProvider)
        {
            if (!String.IsNullOrWhiteSpace(txtInscStatual.Text))
            {
                errorProviderFornecedor.SetError(textBox, "");
                return true;
            }
            else
            {
                errorProviderFornecedor.SetError(textBox, "Inscrição Estatual Inválido!");
                return false;
            }
        }
        // VALIDAR ENTRADA COM ERROPROVIDER
        private Boolean validaRazãoSocial(TextBox textBox, ErrorProvider errorProvider)
        {
            if (!String.IsNullOrWhiteSpace(txtRazaoSocial.Text))
            {
                errorProviderFornecedor.SetError(textBox, "");
                return true;
            }
            else
            {
                errorProviderFornecedor.SetError(textBox, "Razão Social Inválido!");
                return false;
            }
        }
        // VALIDAR ENTRADA COM ERROPROVIDER
        private Boolean validaNomeContato(TextBox textBox, ErrorProvider errorProvider)
        {
            if (!String.IsNullOrWhiteSpace(txtNomeContato.Text))
            {
                errorProviderFornecedor.SetError(textBox, "");
                return true;
            }
            else
            {
                errorProviderFornecedor.SetError(textBox, "Nome do Contato Inválido!");
                return false;
            }
        }
        // VALIDAR ENTRADA COM ERROPROVIDER
        private bool validaSexo()
        {
            // Determine whether the favorite color has a valid value.
            return ((comboBoxSexoFFIsica.SelectedItem != null) &&
                (!comboBoxSexoFFIsica.SelectedItem.ToString().Equals("")));//none
        }
        // VALIDAR ENTRADA COM ERROPROVIDER
        private Boolean validaRg(TextBox textBox, ErrorProvider errorProvider)
        {
            if (!String.IsNullOrWhiteSpace(txtRgFisica.Text))
            {
                errorProviderFornecedor.SetError(textBox, "");
                return true;
            }
            else
            {
                errorProviderFornecedor.SetError(textBox, "Rg Inválido!");
                return false;
            }
        }
        // VALIDAR ENTRADA COM ERROPROVIDER
        private Boolean validaCpf(MaskedTextBox textBox, ErrorProvider errorProvider)
        {
            if (!String.IsNullOrWhiteSpace(txtCpfFFisica.Text))
            {
                errorProviderFornecedor.SetError(textBox, "");
                return true;
            }
            else
            {
                errorProviderFornecedor.SetError(textBox, "Cpf Inválido!");
                return false;
            }
        }
        // VALIDAR ENTRADA COM ERROPROVIDER
        private bool validaCelular(MaskedTextBox textBox, ErrorProvider errorProvider)
        {
            if (!String.IsNullOrWhiteSpace(txtCelularFFisica.Text))
            {
                errorProviderFornecedor.SetError(textBox, "");
                return true;
            }
            else
            {
                errorProviderFornecedor.SetError(textBox, "Celular Inválido!");
                return false;
            }
        }
        private bool validaCelular2(MaskedTextBox textBox, ErrorProvider errorProvider)
        {
            if (!String.IsNullOrWhiteSpace(txtCelularFFisica2.Text))
            {
                errorProviderFornecedor.SetError(textBox, "");
                return true;
            }
            else
            {
                errorProviderFornecedor.SetError(textBox, "Celular Inválido!");
                return false;
            }
        }
        // VALIDAR ENTRADA COM ERROPROVIDER
        private Boolean validanomefisica(TextBox textBox, ErrorProvider errorProvider)
        {
            if (!String.IsNullOrWhiteSpace(txtNomePFisica.Text))
            {
                errorProviderFornecedor.SetError(textBox, "");
                return true;
            }
            else
            {
                errorProviderFornecedor.SetError(textBox, "Cnpj Inválido!");
                return false;
            }

        }
        private Boolean validaCnae(TextBox textBox, ErrorProvider errorProvider)
        {
            if (!String.IsNullOrWhiteSpace(txtCnae.Text))
            {
                errorProviderFornecedor.SetError(textBox, "");
                return true;
            }
            else
            {
                errorProviderFornecedor.SetError(textBox, "Cnae Inválido!");
                return false;
            }

        }
        private void panelJuridico_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtCnpJTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Se a tecla digitada não for número
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }
        }



        private void FormFornecedores_Load(object sender, EventArgs e)
        {
            txtNomeFornecedor.MaxLength = 150;

            txtCargoContatoFornecedor.MaxLength = 20;

            txtNomeContatoFornecedor.MaxLength = 30;

            txtTipo_logradouro.MaxLength = 25;

            txtEnderecoFornecedor.MaxLength = 40;
            txtEnderecoFornecedor.Enabled = false;

            txtBairroNumeroFornecedor.MaxLength = 9;

            txtComplFornecedor.MaxLength = 40;

            txtBairroFornecedor.MaxLength = 40;
            txtBairroFornecedor.Enabled = false;

            txtCidadeFornecedor.MaxLength = 40;
            txtCidadeFornecedor.Enabled = false;

            txtSiglaCidadeFornecedor.MaxLength = 4;

            txtEmailFornecedor.MaxLength = 40;

            txtTipoFornecedor.MaxLength = 20;

            txtCpMunicipioFornecedor.MaxLength = 20;

            txtMunicipioFornecedor.MaxLength = 20;

            txtPaisFornecedor.MaxLength = 19;

            txtDesPaisFornecedor.MaxLength = 20;

            txtObservacaoFornecedor.MaxLength = 40;

            txtCnpj.MaxLength = 14;

            txtRazaoSocial.MaxLength = 150;

            txtInscStatual.MaxLength = 150;

            txtNomeContato.MaxLength = 20;


            txtNomePFisica.MaxLength = 50;

            comboBoxSexoFFIsica.MaxLength = 2;

            txtRgFisica.MaxLength = 9;

            radioButtonOculto.Checked = true;

            txtCnpjConsulta.MaxLength = 14;
            txtLetrasConulta.MaxLength = 6;
            txtCnae.MaxLength = 150;
            txtSigla.MaxLength = 2;
        }
        public void ConsultaCnpj()
        {
            try
            {
                if ((txtCnpjConsulta.Text == "") || (txtLetrasConulta.Text == ""))
                {
                    MessageBox.Show("Cnpj ou Letras não podem está em branco!");
                }
                if (!(txtCnpjConsulta.Text == "") && !(txtLetrasConulta.Text == ""))
                {
                    Cursor cursor;
                    cursor = this.Cursor;

                    try
                    {
                        this.Cursor = Cursors.WaitCursor;
                        string tmp = consulta.Consulta(txtCnpjConsulta.Text, txtLetrasConulta.Text);

                        if (tmp.Length > 0)
                        {
                            txtCnpjConsulta.Text = txtCnpjConsulta.Text;
                            txtRazaoSocial.Text = RecuperaColunaValor(tmp, Coluna.RazaoSocial);
                            txtNomeFornecedor.Text = RecuperaColunaValor(tmp, Coluna.RazaoSocial);
                            txtEndereco.Text = RecuperaColunaValor(tmp, Coluna.EnderecoLogradouro);
                            txtNumeroPrincipal.Text = RecuperaColunaValor(tmp, Coluna.EnderecoNumero);
                            txtBairro.Text = RecuperaColunaValor(tmp, Coluna.EnderecoBairro);
                            txtCnae.Text = RecuperaColunaValor(tmp, Coluna.AtividadeEconomicaPrimaria);
                            txtCidade.Text = RecuperaColunaValor(tmp, Coluna.EnderecoCidade);
                            txtSigla.Text = RecuperaColunaValor(tmp, Coluna.EnderecoEstado);
                            txtcomplemento.Text = RecuperaColunaValor(tmp, Coluna.EnderecoComplemento);
                            maskedTextBoxCep.Text = RecuperaColunaValor(tmp, Coluna.EnderecoCEP);
                            txtInscStatual.Text = RecuperaColunaValor(tmp, Coluna.NumeroDaInscricao);

                        }
                        if (tmp.Length <= 0)
                        {
                            tmp = consulta.Consulta(null, null);
                            MessageBox.Show("Não foi possível consultar Registro. 1");
                        }
                    }
                    catch (Exception)
                    {
                        txtLetrasConulta.Clear();
                        pictureBoxLetras.Image = null;

                        //string tmp = consulta.Consulta(null, null);

                        MessageBox.Show(" Erro ocorrido por possível lentidão na Receita Federal.\n Se persistir Cadastra manualmente! 2");

                        carregarCaptcha();
                    }

                    this.Cursor = cursor;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error se CNPJ e Letras não forem digitadas. 6");
            }

        }
        //Cadastrar Fornecedor
        private void buttonCadastraFornecedor_Click(object sender, EventArgs e)
        {
            try
            {
                this.operacao = "Inserir";

                AlteraBotoes(1);

                checkBoxClienteSituacao.Checked = true;

                checkBoxClienteSituacao.Enabled = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Carregar o Salvar! " + ex.Message);
            }
        }
        //METODO PARA VERIFICA SE O FORMULÁRIO ESTA ABERTO SE TIVER ELE FECHA!
        public static void CancelaCadastradoFornecedor(Type frmType)
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
        public void FecharTodosFormulario()
        {
            //CHAMA O METODO CancelaCadastradoFornecedor QUE FECHA FORMULÁRIOS ABERTOS
            CancelaCadastradoFornecedor(typeof(FormFornecedores));
        }

        //Botão que Cancelar FOrmulario de Cadastro de Fornecedor
        private void buttonCancelarFornecedor_Click(object sender, EventArgs e)
        {
            //CHAMA O METODO CancelaCadastradoCliente QUE FECHA FORMULÁRIOS ABERTOS
            FecharTodosFormulario();

            FormFornecedores Fornecedores = new FormFornecedores(this.NomeServidor, this.NomeBaseDados, this.NomeUsuario, this.SenhaBaseDados);
            Fornecedores.MdiParent = FormFornecedores.ActiveForm;
            Fornecedores.Show();
            Fornecedores.Top = 0;
            Fornecedores.Left = 0;
        }
        private Boolean VerificadorEndereco()
        {
            int EntradaContato = 0;

            string endereco1 = txtEndereco.ToString(), Bairro = txtBairro.ToString(), Logradouro = txtLogradouro.ToString(),
                Cidade = txtCidade.ToString(), Sigla = txtSigla.ToString();

            if (maskedTextBoxCep.Text == "")
            {
                if (endereco1.ToString() != "")
                {
                    for (int i = 0; i < endereco1.Length; i++)
                    {
                        if (endereco1[i] == '*')
                        {
                            EntradaContato++;
                            break;
                        }
                    }
                }
                if (Bairro.ToString() != "")
                {
                    for (int i = 0; i < Bairro.Length; i++)
                    {
                        if (Bairro[i] == '*')
                        {
                            EntradaContato++;
                            break;
                        }
                    }
                }
                if (Logradouro.ToString() != "")
                {
                    for (int i = 0; i < Logradouro.Length; i++)
                    {
                        if (Logradouro[i] == '*')
                        {
                            EntradaContato++;
                            break;
                        }
                    }
                }
                if (Cidade.ToString() != "")
                {
                    for (int i = 0; i < Cidade.Length; i++)
                    {
                        if (Cidade[i] == '*')
                        {
                            EntradaContato++;
                            break;
                        }
                    }
                }
                if (Sigla.ToString() != "")
                {
                    for (int i = 0; i < Sigla.Length; i++)
                    {
                        if (Sigla[i] == '*')
                        {
                            EntradaContato++;
                            break;
                        }
                    }
                }
                if (EntradaContato >= 5)
                {
                    return true;
                }
                else return false;
            }
            return false;
        }
        //Botão que Verifica Fornecedor
        private void buttonVerificarFornecedor_Click(object sender, EventArgs e)
        {
            SalvarCadastroFornecedor();
        }
        public void SalvarCadastroFornecedor()
        {
            try
            {
                string CepPrincipal = maskedTextBoxCep.Text;
                string CepSecundarioT = txtCepFornecedor.Text;
                //string tamanhoLetraCnpj = ;

                if ((txtTelefoneFornecedor.Equals("_____-___")))
                {
                    MessageBox.Show("ssssssssss");
                }
                if (txtTelefoneFornecedor.Equals(""))
                {
                    MessageBox.Show("nnnnnnnnnnnnnnnnnnnnnnn");
                }

                if ((ValidaNome(txtNomeFornecedor, errorProviderFornecedor) == true))
                {
                    if (!(txtTelefoneFornecedor.Text == ""))
                    {
                        SqlConnection conn = new SqlConnection(this.connetionString);

                        //Verifica Se a MS é Valida no sistema!

                        SqlDataAdapter da3 = new SqlDataAdapter("SELECT * FROM P_Pessoa where NOME = '" + txtNomeFornecedor.Text + "';", conn);

                        DataSet ds3 = new DataSet();
                        da3.Fill(ds3);

                        conn.Open();

                        if (ds3.Tables[0].Rows.Count > 0)

                        {
                            MessageBox.Show("O Nome consta no sistema não pode ser Inserido!");
                        }
                        if (!(ds3.Tables[0].Rows.Count > 0))
                        {
                            if ((radioButtonFornecedorFisica.Checked == false) && (radioButtonFornecedorJuridica.Checked == false))
                            {
                                MessageBox.Show("Seleciona Pessoa Fisíca ou Pessoa Jurídica!");
                            }
                            if (radioButtonFornecedorFisica.Checked == true)
                            {
                                //Pessoa fisica Cep não pode está em branco
                                if (CepPrincipal.Equals("_____-___"))
                                {
                                    verificador = false;
                                    MessageBox.Show("O cep não pode está em branco e pesquisa o cep!");
                                }//Modo cep principal automatico
                                else if (!CepPrincipal.Equals("_____-___"))
                                {
                                    if (CepManual == 0)
                                    {
                                        if (labelConfirmacaoPrimario.Text.Equals("Resultado:"))
                                        {
                                            verificador = false;
                                            MessageBox.Show("Pesquisa o cep Principal!");
                                        }
                                        if (labelConfirmacaoPrimario.Text.Equals("sucesso - cep não encontrado"))
                                        {
                                            verificador = false;
                                            MessageBox.Show("O cep é não é válido!");
                                        }
                                        if (labelConfirmacaoPrimario.Text.Equals("sucesso - cep completo"))
                                        {
                                            if (CepSecundarioT.Equals("_____-___"))
                                            {
                                                verificador = true;
                                            }
                                            //Cep Segundario Automatico
                                            else if (!CepSecundarioT.Equals("_____-___"))
                                            {
                                                if (CepManualSe == 0)
                                                {
                                                    if (labelConfirmacaoSecundario.Text.Equals("Resultado:"))
                                                    {
                                                        verificador = false;
                                                        MessageBox.Show("Pesquisa o cep Secundario! 1");
                                                    }
                                                    if (labelConfirmacaoSecundario.Text.Equals("sucesso - cep não encontrado"))
                                                    {
                                                        verificador = false;
                                                        MessageBox.Show("O cep é não é válido!");
                                                    }
                                                    if (labelConfirmacaoSecundario.Text.Equals("sucesso - cep completo"))
                                                    {
                                                        verificador = true;
                                                        CepSecundario = true;
                                                    }
                                                }
                                                if (CepManualSe == 1)
                                                {
                                                    if ((validaCep(txtCepFornecedor, errorProviderFornecedor) == true) && (validaEndereco(txtEnderecoFornecedor, errorProviderFornecedor) == true) &&
                                                       (validaBairro(txtBairroFornecedor, errorProviderFornecedor) == true) && (validaCidade(txtCidadeFornecedor, errorProviderFornecedor) == true))
                                                    {
                                                        verificador = true;
                                                        CepSecundario = true;
                                                    }
                                                }

                                            }
                                        }

                                    }
                                    if (CepManual == 1)
                                    {
                                        if ((validaCep(txtCepFornecedor, errorProviderFornecedor) == true) && (validaEndereco(txtEnderecoFornecedor, errorProviderFornecedor) == true) &&
                                           (validaBairro(txtBairroFornecedor, errorProviderFornecedor) == true) && (validaCidade(txtCidadeFornecedor, errorProviderFornecedor) == true))
                                        {
                                            if (CepSecundarioT.Equals("_____-___"))
                                            {
                                                verificador = true;
                                            }
                                            else if (!CepSecundarioT.Equals("_____-___"))
                                            {
                                                if (CepManualSe == 0)
                                                {
                                                    //Cep Segundario Automatico
                                                    if (labelConfirmacaoSecundario.Text.Equals("Resultado:"))
                                                    {
                                                        verificador = false;
                                                        MessageBox.Show("Pesquisa o cep secundario!");
                                                    }
                                                    if (labelConfirmacaoSecundario.Text.Equals("sucesso - cep não encontrado"))
                                                    {
                                                        verificador = false;
                                                        MessageBox.Show("O cep é não é válido!");
                                                    }
                                                    if (labelConfirmacaoSecundario.Text.Equals("sucesso - cep completo"))
                                                    {
                                                        verificador = true;

                                                        CepSecundario = true;
                                                    }
                                                }
                                                if (CepManualSe == 1)
                                                {
                                                    //Cep Segundario Manual
                                                    if (!CepSecundarioT.Equals("_____-___"))
                                                    {
                                                        if ((validaCep(txtCepFornecedor, errorProviderFornecedor) == true) && (validaEndereco(txtEnderecoFornecedor, errorProviderFornecedor) == true) &&
                                                               (validaBairro(txtBairroFornecedor, errorProviderFornecedor) == true) && (validaCidade(txtCidadeFornecedor, errorProviderFornecedor) == true))
                                                        {
                                                            verificador = true;

                                                            CepSecundario = true;
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                                if (!validaSexo())
                                {
                                    MessageBox.Show("Por favor Digite um Sexo Válido!");
                                    verificador = false;
                                }

                                if (verificador == true)
                                {
                                    try
                                    {
                                        Conexao conexao = new Conexao(this.connetionString);
                                        DALDateSystem dal = new DALDateSystem(conexao); //cadastra Pessoa

                                        Conexao conexao5 = new Conexao(this.connetionString);
                                        DALDateSystem dal5 = new DALDateSystem(conexao5);//cadastra Cep Principal

                                        Conexao conexao1 = new Conexao(this.connetionString);
                                        DALDateSystem dal1 = new DALDateSystem(conexao1);//cadastra Cep

                                        Conexao conexao2 = new Conexao(this.connetionString);
                                        DALDateSystem dal2 = new DALDateSystem(conexao2);//cadastra Pesssoa Clientes Fornecedor

                                        Conexao conexao4 = new Conexao(this.connetionString);
                                        DALDateSystem dal4 = new DALDateSystem(conexao4);//cadastra Pesssoa Fisica 

                                        Pessoa cadastra = new Pessoa();

                                        Fornecedor pessoaFornecedor = new Fornecedor();

                                        CepSecundario cadastraCepSecundario = new CepSecundario();

                                        PessoaFisica PessoaFisica = new PessoaFisica();

                                        // Dados Pessoa
                                        cadastra.IdOs = 0;
                                        cadastra.Situacao = 1;
                                        cadastra.Nome = txtNomeFornecedor.Text;
                                        cadastra.Telefone = txtTelefoneFornecedor.Text;
                                        cadastra.Telefone2 = txtTelefone2Fornecedor.Text;
                                        cadastra.FaxTelefone = txtFaxTelefoneFornecedor.Text;
                                        cadastra.TelexTelefone = txtTelexTelefoneFornecedor.Text;
                                        cadastra.Email = txtEmailFornecedor.Text;
                                        cadastra.Observacao = txtObservacaoFornecedor.Text;
                                        cadastra.Tipo = txtTipoFornecedor.Text;
                                        cadastra.CpMunicipio = txtCpMunicipioFornecedor.Text;
                                        cadastra.Municipio = txtMunicipioFornecedor.Text;
                                        cadastra.Pais = txtPaisFornecedor.Text;
                                        cadastra.DesPais = txtDesPaisFornecedor.Text;
                                        cadastra.IdPessoaTipo = 2;

                                        ////Pessoa Fisica
                                        PessoaFisica.Nome = txtNomePFisica.Text;
                                        PessoaFisica.Cpf = txtCpfFFisica.Text;
                                        PessoaFisica.Rg = txtRgFisica.Text;
                                        PessoaFisica.dataNacimento = txtDataNascimentoFFisica.Text;
                                        PessoaFisica.Celular = txtCelularFFisica.Text;
                                        PessoaFisica.Celular2 = txtCelularFFisica2.Text;

                                        //Dados Pessoa Cliente Forcenedor
                                        
                                        pessoaFornecedor.CargoContato = txtNomeFornecedor.Text;
                                        pessoaFornecedor.NomeContato = txtNomeFornecedor.Text;

                                        //Dados CEP Principal
                                        CepF CepFisico = new CepF();
                                        //Dados CEP
                                        if (maskedTextBoxCep.Text == "")
                                        {

                                        }
                                        else CepFisico.Cepc = int.Parse(maskedTextBoxCep.Text);
                                        CepFisico.TipoLogradouro = txtLogradouro.Text;
                                        CepFisico.Endereco = txtEndereco.Text;
                                        CepFisico.Numero = txtNumeroPrincipal.Text;
                                        CepFisico.Complemento = txtcomplemento.Text;
                                        CepFisico.Bairro = txtBairro.Text;
                                        CepFisico.Cidade = txtCidade.Text;
                                        CepFisico.SiglaCidade = txtSigla.Text;

                                        ////Dados CEP Secundario
                                        if (labelConfirmacaoSecundario.Text.Equals("sucesso - cep completo"))
                                        {
                                            cadastraCepSecundario.Cepc = int.Parse(txtCepFornecedor.Text);
                                            cadastraCepSecundario.TipoLogradouro = txtTipo_logradouro.Text;
                                            cadastraCepSecundario.Endereco = txtEmailFornecedor.Text;
                                            cadastraCepSecundario.Numero = txtBairroFornecedor.Text;
                                            cadastraCepSecundario.Complemento = txtComplFornecedor.Text;
                                            cadastraCepSecundario.Bairro = txtBairroFornecedor.Text;
                                            cadastraCepSecundario.Cidade = txtCidadeFornecedor.Text;
                                            cadastraCepSecundario.SiglaCidade = txtSiglaCidadeFornecedor.Text;
                                        }
                                        if (!labelConfirmacaoSecundario.Text.Equals("sucesso - cep completo"))
                                        {

                                        }
                                        if ((validanomefisica(txtNomePFisica, errorProviderFornecedor) == true) && (validaCpf(txtCpfFFisica, errorProviderFornecedor) == true) &&
                                            (validaRg(txtRgFisica, errorProviderFornecedor) == true) && (validaCelular(txtCelularFFisica, errorProviderFornecedor) == true) &&
                                            (validaSexo()) && (comboBoxSexoFFIsica.SelectedItem.ToString() == "M"))
                                        {
                                            //Pessoa Fisica recebe M
                                            PessoaFisica.Sexo = "M";

                                            if (maskedTextBoxCep.Text == "")
                                            {
                                                DialogResult SalvaClienteRegistro = MessageBox.Show("Deseja Salvar em Pessoa Física?\n" +
                                                "Salvar sem um cep válido!", "Aviso", MessageBoxButtons.YesNo);

                                                if (SalvaClienteRegistro == DialogResult.Yes)
                                                {
                                                    //Inserir Pessoa
                                                    dal.Incluir(cadastra);

                                                    idPessoaFisica = int.Parse(cadastra.idPessoa.ToString());

                                                    if (idPessoaFisica > 0)
                                                    {
                                                        if (this.operacao == "Inserir")
                                                        {
                                                            //Inserir Pessoa Fisica
                                                            PessoaFisica.idPessoaFisica = idPessoaFisica;
                                                            dal4.IncluirPessoaFIsica(PessoaFisica);

                                                            //Inserir Fornecedor
                                                            pessoaFornecedor.idFornecedor = idPessoaFisica;
                                                            dal2.IncluirF(pessoaFornecedor);

                                                            //inserir Cep Principal
                                                            CepFisico.idCep = idPessoaFisica;
                                                            CepFisico.Cepc = 00000000;
                                                            dal5.IncluirCepFisico(CepFisico);

                                                            if (CepSecundario == true)
                                                            {
                                                                //Inserir Cep Segundario
                                                                cadastraCepSecundario.Numero = txtBairroNumeroFornecedor.Text;
                                                                dal1.IncluirCepSecundario(cadastraCepSecundario);

                                                            }
                                                            MessageBox.Show("Cliente Cadastrado com sucesso!");

                                                            FecharTodosFormulario();

                                                            FormFornecedores Fornecedores = new FormFornecedores(this.NomeServidor, this.NomeBaseDados, this.NomeUsuario, this.SenhaBaseDados);
                                                            Fornecedores.MdiParent = FormFornecedores.ActiveForm;
                                                            Fornecedores.Show();
                                                            Fornecedores.Top = 0;
                                                            Fornecedores.Left = 0;
                                                        }
                                                    }
                                                    else if (idPessoaFisica <= 0)
                                                    {
                                                        MessageBox.Show("Erro na geração de ID F.1.");
                                                    }
                                                }
                                                if (SalvaClienteRegistro == DialogResult.No)
                                                {
                                                    MessageBox.Show("Não atribuido ao sistema!");
                                                }
                                            }
                                            if (maskedTextBoxCep.Text != "")
                                            {
                                                //Inserir Pessoa
                                                dal.Incluir(cadastra);

                                                idPessoaFisica = int.Parse(cadastra.idPessoa.ToString());

                                                if (idPessoaFisica > 0)
                                                {
                                                    if (this.operacao == "Inserir")
                                                    {
                                                        //Inserir Pessoa Fisica
                                                        PessoaFisica.idPessoaFisica = idPessoaFisica;
                                                        dal4.IncluirPessoaFIsica(PessoaFisica);
                                                        
                                                        //Inserir Fornecedor
                                                        pessoaFornecedor.idFornecedor = idPessoaFisica;
                                                        dal2.IncluirF(pessoaFornecedor);

                                                        //inserir Cep Principal
                                                        CepFisico.idCep = idPessoaFisica;
                                                        dal5.IncluirCepFisico(CepFisico);

                                                        if (CepSecundario == true)
                                                        {
                                                            //Inserir Cep Segundario
                                                            cadastraCepSecundario.Numero = txtBairroNumeroFornecedor.Text;
                                                            dal1.IncluirCepSecundario(cadastraCepSecundario);

                                                        }
                                                        MessageBox.Show("Cliente Cadastrado com sucesso!");

                                                        FecharTodosFormulario();

                                                        FormCadastraClienteRegistro cadastracliente = new FormCadastraClienteRegistro(this.NomeServidor, this.NomeBaseDados, this.NomeUsuario, this.SenhaBaseDados);
                                                        cadastracliente.MdiParent = FormCadastraClienteRegistro.ActiveForm;
                                                        cadastracliente.Show();
                                                        cadastracliente.Top = 0;
                                                        cadastracliente.Left = 0;

                                                    }
                                                }
                                                if (idPessoaFisica <= 0)
                                                {
                                                    MessageBox.Show("Erro na geração de ID F.2.");
                                                }
                                            }


                                            if ((validanomefisica(txtNomePFisica, errorProviderFornecedor) == true) && (validaCpf(txtCpfFFisica, errorProviderFornecedor) == true) &&
                                                (validaRg(txtRgFisica, errorProviderFornecedor) == true) && (validaCelular(txtCelularFFisica, errorProviderFornecedor) == true) &&
                                                (validaSexo()) && (comboBoxSexoFFIsica.SelectedItem.ToString() == "F"))
                                            {
                                                //Pessoa Fisica recebe M
                                                PessoaFisica.Sexo = "F";

                                                if (maskedTextBoxCep.Text == "")
                                                {
                                                    DialogResult SalvaClienteRegistro = MessageBox.Show("Deseja Salvar em Pessoa Física?\n" +
                                                    "Salvar sem um cep válido!", "Aviso", MessageBoxButtons.YesNo);

                                                    if (SalvaClienteRegistro == DialogResult.Yes)
                                                    {
                                                        //Inserir Pessoa
                                                        dal.Incluir(cadastra);

                                                        idPessoaFisica = int.Parse(cadastra.idPessoa.ToString());

                                                        if (idPessoaFisica > 0)
                                                        {
                                                            if (this.operacao == "Inserir")
                                                            {
                                                                //Inserir Pessoa Fisica
                                                                PessoaFisica.idPessoaFisica = idPessoaFisica;
                                                                dal4.IncluirPessoaFIsica(PessoaFisica);

                                                                //Inserir Fornecedor
                                                                pessoaFornecedor.idFornecedor = idPessoaFisica;
                                                                dal2.IncluirF(pessoaFornecedor);

                                                                //inserir Cep Principal
                                                                CepFisico.idCep = idPessoaFisica;
                                                                CepFisico.Cepc = 00000000;
                                                                dal5.IncluirCepFisico(CepFisico);

                                                                if (CepSecundario == true)
                                                                {
                                                                    //Inserir Cep Segundario
                                                                    cadastraCepSecundario.Numero = txtBairroNumeroFornecedor.Text;
                                                                    dal1.IncluirCepSecundario(cadastraCepSecundario);

                                                                }
                                                                MessageBox.Show("Cliente Cadastrado com sucesso!");

                                                                FecharTodosFormulario();

                                                                FormCadastraClienteRegistro cadastracliente = new FormCadastraClienteRegistro(this.NomeServidor, this.NomeBaseDados, this.NomeUsuario, this.SenhaBaseDados);
                                                                cadastracliente.MdiParent = FormCadastraClienteRegistro.ActiveForm;
                                                                cadastracliente.Show();
                                                                cadastracliente.Top = 0;
                                                                cadastracliente.Left = 0;
                                                            }
                                                        }
                                                        else if (idPessoaFisica <= 0)
                                                        {
                                                            MessageBox.Show("Erro na geração de ID F.3.");
                                                        }
                                                    }
                                                    if (SalvaClienteRegistro == DialogResult.No)
                                                    {
                                                        MessageBox.Show("Não atribuido ao sistema!");
                                                    }
                                                }
                                                if (maskedTextBoxCep.Text != "")
                                                {
                                                    //Inserir Pessoa
                                                    dal.Incluir(cadastra);
                                                    idPessoaFisica = int.Parse(cadastra.idPessoa.ToString());

                                                    if (idPessoaFisica > 0)
                                                    {
                                                        if (this.operacao == "Inserir")
                                                        {
                                                            //Inserir Pessoa Fisica
                                                            PessoaFisica.idPessoaFisica = idPessoaFisica;
                                                            dal4.IncluirPessoaFIsica(PessoaFisica);

                                                            //Inserir Fornecedor
                                                            pessoaFornecedor.idFornecedor = idPessoaFisica;
                                                            dal2.IncluirF(pessoaFornecedor);

                                                            //inserir Cep Principal
                                                            CepFisico.idCep = idPessoaFisica;
                                                            dal5.IncluirCepFisico(CepFisico);

                                                            if (CepSecundario == true)
                                                            {
                                                                //Inserir Cep Segundario
                                                                cadastraCepSecundario.Numero = txtBairroNumeroFornecedor.Text;
                                                                dal1.IncluirCepSecundario(cadastraCepSecundario);

                                                            }
                                                            MessageBox.Show("Cliente Cadastrado com sucesso!");

                                                            FecharTodosFormulario();

                                                            FormCadastraClienteRegistro cadastracliente = new FormCadastraClienteRegistro(this.NomeServidor, this.NomeBaseDados, this.NomeUsuario, this.SenhaBaseDados);
                                                            cadastracliente.MdiParent = FormCadastraClienteRegistro.ActiveForm;
                                                            cadastracliente.Show();
                                                            cadastracliente.Top = 0;
                                                            cadastracliente.Left = 0;

                                                        }
                                                    }
                                                    if (idPessoaFisica <= 0)
                                                    {
                                                        MessageBox.Show("Erro na geração de ID F.3.");
                                                    }
                                                }
                                            }
                                        }
                                    }
                                    catch (Exception ex)
                                    {
                                        MessageBox.Show("Erro de acesso ao banco de Dados " + ex.ToString() + "  ----------------------------------------------------------------------------------------------------------------------------------------. ", ex.Message);
                                    }
                                }
                            }
                            if (radioButtonFornecedorJuridica.Checked == true)
                            {
                                if (SiteOFF == 0)
                                {
                                    if (CepSecundarioT.Equals("_____-___"))
                                    {
                                        verificador = true;
                                    }

                                    else if (!CepSecundarioT.Equals("_____-___"))
                                    {
                                        //Cep Segundario Automatico
                                        if (CepManualSe == 0)
                                        {
                                            if (labelConfirmacaoSecundario.Text.Equals("Resultado:"))
                                            {
                                                verificador = false;
                                                MessageBox.Show("Pesquisa o cep secundario!");
                                            }
                                            if (labelConfirmacaoSecundario.Text.Equals("sucesso - cep não encontrado"))
                                            {
                                                verificador = false;
                                                MessageBox.Show("O cep é não é válido!");
                                            }
                                            if (labelConfirmacaoSecundario.Text.Equals("sucesso - cep completo"))
                                            {
                                                verificador = true;
                                                CepSecundario = true;
                                            }
                                        }
                                        //Cep Segundario Manual
                                        if (CepManualSe == 1)
                                        {
                                            if ((validaCep(txtCepFornecedor, errorProviderFornecedor) == true) && (validaEndereco(txtEnderecoFornecedor, errorProviderFornecedor) == true) &&
                                               (validaBairro(txtBairroFornecedor, errorProviderFornecedor) == true) && (validaCidade(txtCidadeFornecedor, errorProviderFornecedor) == true))
                                            {
                                                verificador = true;
                                                CepSecundario = true;
                                            }
                                        }

                                    }
                                    if ((ValidaNome(txtNomeFornecedor, errorProviderFornecedor) == true) && (verificador == true))//(labelConfirmacao.Text).Equals("sucesso - cep completo"))
                                    {
                                        try
                                        {
                                            Conexao conexao = new Conexao(this.connetionString);
                                            DALDateSystem dal = new DALDateSystem(conexao); //cadastra Pessoa

                                            Conexao conexao4 = new Conexao(this.connetionString);
                                            DALDateSystem dal4 = new DALDateSystem(conexao4);//Cadastra Cep Principal

                                            Conexao conexao1 = new Conexao(this.connetionString);
                                            DALDateSystem dal1 = new DALDateSystem(conexao1);//cadastra Cep

                                            Conexao conexao2 = new Conexao(this.connetionString);
                                            DALDateSystem dal2 = new DALDateSystem(conexao2);//cadastra Pesssoa Fornecedor DataSystem

                                            Conexao conexao5 = new Conexao(this.connetionString);
                                            DALDateSystem dal5 = new DALDateSystem(conexao5);//cadastra Pesssoa Juridica 


                                            Pessoa cadastra = new Pessoa();

                                            Fornecedor pessoaFornecedor = new Fornecedor();

                                            CepSecundario cadastraCepSecundario = new CepSecundario();

                                            CepJ cadastraCepJurica = new CepJ();

                                            // Dados Pessoa

                                            cadastra.IdOs = 0;
                                            cadastra.Situacao = 1;
                                            cadastra.Nome = txtNomeFornecedor.Text;
                                            cadastra.Telefone = txtTelefoneFornecedor.Text;
                                            cadastra.Telefone2 = txtTelefone2Fornecedor.Text;
                                            cadastra.FaxTelefone = txtFaxTelefoneFornecedor.Text;
                                            cadastra.TelexTelefone = txtTelexTelefoneFornecedor.Text;
                                            cadastra.Email = txtEmailFornecedor.Text;
                                            cadastra.Observacao = txtObservacaoFornecedor.Text;
                                            cadastra.Tipo = txtTipoFornecedor.Text;
                                            cadastra.CpMunicipio = txtCpMunicipioFornecedor.Text;
                                            cadastra.Municipio = txtMunicipioFornecedor.Text;
                                            cadastra.Pais = txtPaisFornecedor.Text;
                                            cadastra.DesPais = txtDesPaisFornecedor.Text;
                                            cadastra.IdPessoaTipo = 2;

                                            //Pessoa Juridica
                                            PessoaJuridica pessoaJuridica = new PessoaJuridica();
                                            pessoaJuridica.IdPessoaTipo = 2;
                                            pessoaJuridica.Cnpj = txtCnpj.Text;
                                            pessoaJuridica.RazaoSocial = txtRazaoSocial.Text;
                                            pessoaJuridica.InscricaoStadual = txtInscStatual.Text;
                                            pessoaJuridica.NomeContato = txtNomeFornecedor.Text;
                                            pessoaJuridica.Cnae = txtCnae.Text;


                                            //Dados Pessoa Cliente Forcenedor

                                            pessoaFornecedor.CargoContato = txtNomeFornecedor.Text;
                                            pessoaFornecedor.NomeContato = txtNomeFornecedor.Text;

                                            //Dados CEP Principal
                                            if (maskedTextBoxCep.Text == "")
                                            {

                                            }
                                            else cadastraCepJurica.Cepc = int.Parse(maskedTextBoxCep.Text);
                                            cadastraCepJurica.TipoLogradouro = txtLogradouro.Text;
                                            cadastraCepJurica.Endereco = txtEndereco.Text;
                                            cadastraCepJurica.Numero = txtNumeroPrincipal.Text;
                                            cadastraCepJurica.Complemento = txtcomplemento.Text;
                                            cadastraCepJurica.Bairro = txtBairro.Text;
                                            cadastraCepJurica.Cidade = txtCidade.Text;
                                            cadastraCepJurica.SiglaCidade = txtSigla.Text;

                                            ////Dados CEP Secundario
                                            if (labelConfirmacaoSecundario.Text.Equals("sucesso - cep completo"))
                                            {
                                                cadastraCepSecundario.Cepc = int.Parse(txtCepFornecedor.Text);
                                                cadastraCepSecundario.TipoLogradouro = txtTipo_logradouro.Text;
                                                cadastraCepSecundario.Endereco = txtEmailFornecedor.Text;
                                                cadastraCepSecundario.Numero = txtBairroFornecedor.Text;
                                                cadastraCepSecundario.Complemento = txtComplFornecedor.Text;
                                                cadastraCepSecundario.Bairro = txtBairroFornecedor.Text;
                                                cadastraCepSecundario.Cidade = txtCidadeFornecedor.Text;
                                                cadastraCepSecundario.SiglaCidade = txtSiglaCidadeFornecedor.Text;
                                            }
                                            if (!labelConfirmacaoSecundario.Text.Equals("sucesso - cep completo"))
                                            {

                                            }

                                            if ((validaCnpj(txtCnpjConsulta, errorProviderFornecedor) == true))
                                            //(labelConfirmacao.Text).Equals("sucesso - cep completo"))
                                            {

                                                if (this.operacao == "Inserir")
                                                {
                                                    if (maskedTextBoxCep.Text == "")
                                                    {
                                                        if (VerificadorEndereco() == true)
                                                        {
                                                            DialogResult SalvaClienteRegistro = MessageBox.Show("Deseja Salvar em Pessoa Juridica?\n" +
                                                                "Por não consta endereço na Receita Federal sera salvo sem o mesmo.", "Aviso", MessageBoxButtons.YesNo);

                                                            if (SalvaClienteRegistro == DialogResult.Yes)
                                                            {
                                                                dal.Incluir(cadastra);
                                                                idPessoaJuridica = int.Parse(cadastra.idPessoa.ToString());

                                                                if (idPessoaJuridica > 0)
                                                                {
                                                                    //Inserir Pessoa Juridica
                                                                    pessoaJuridica.idPessoaJuridica = idPessoaJuridica;
                                                                    dal5.IncluirPessoaJuridica(pessoaJuridica);

                                                                    //Inserir Fornecedor
                                                                    pessoaFornecedor.idFornecedor = idPessoaJuridica;
                                                                    dal2.IncluirF(pessoaFornecedor);

                                                                    //Inserir Cep
                                                                    cadastraCepJurica.idCep = idPessoaJuridica;
                                                                    cadastraCepJurica.Cepc = 00000000;
                                                                    cadastraCepJurica.TipoLogradouro = "";
                                                                    cadastraCepJurica.Endereco = "";
                                                                    cadastraCepJurica.Numero = "";
                                                                    cadastraCepJurica.Complemento = "";
                                                                    cadastraCepJurica.Bairro = "";
                                                                    cadastraCepJurica.Cidade = "";
                                                                    cadastraCepJurica.SiglaCidade = "";
                                                                    dal4.IncluirCepJuridico(cadastraCepJurica);

                                                                    if (CepManualSe == 1)
                                                                    {
                                                                        //Inserir Cep Segundario
                                                                        cadastraCepSecundario.idCep = idPessoaJuridica;

                                                                        cadastraCepSecundario.Numero = txtBairroFornecedor.Text;
                                                                        dal1.IncluirCepSecundario(cadastraCepSecundario);
                                                                    }

                                                                    MessageBox.Show("Cliente Cadastrado com sucesso!");

                                                                    FecharTodosFormulario();

                                                                    FormCadastraClienteRegistro cadastracliente = new FormCadastraClienteRegistro(this.NomeServidor, this.NomeBaseDados, this.NomeUsuario, this.SenhaBaseDados);
                                                                    cadastracliente.MdiParent = FormCadastraClienteRegistro.ActiveForm;
                                                                    cadastracliente.Show();
                                                                    cadastracliente.Top = 0;
                                                                    cadastracliente.Left = 0;
                                                                }
                                                                else if (idPessoaJuridica <= 0)
                                                                {
                                                                    MessageBox.Show("Erro na geração de ID J.1.");
                                                                }
                                                            }
                                                            else if (SalvaClienteRegistro == DialogResult.No)
                                                            {
                                                                MessageBox.Show("Não atribuido ao sistema!");
                                                            }
                                                        }
                                                        if (VerificadorEndereco() == false)
                                                        {
                                                            DialogResult SalvaClienteRegistro = MessageBox.Show("Deseja Salvar em Pessoa Juridica?\n" +
                                                             "Sem um endereço. Passando cep com a numeração 0.", "Aviso", MessageBoxButtons.YesNo);

                                                            if (SalvaClienteRegistro == DialogResult.Yes)
                                                            {
                                                                dal.Incluir(cadastra);
                                                                idPessoaJuridica = int.Parse(cadastra.idPessoa.ToString());

                                                                if (idPessoaJuridica > 0)
                                                                {
                                                                    //Inserir Pessoa Juridica
                                                                    pessoaJuridica.idPessoaJuridica = idPessoaJuridica;
                                                                    dal5.IncluirPessoaJuridica(pessoaJuridica);

                                                                    //Inserir Fornecedor
                                                                    pessoaFornecedor.idFornecedor = idPessoaJuridica;
                                                                    dal2.IncluirF(pessoaFornecedor);

                                                                    //Inserir Cep
                                                                    cadastraCepJurica.idCep = idPessoaJuridica;
                                                                    cadastraCepJurica.Cepc = 00000000;
                                                                    cadastraCepJurica.TipoLogradouro = "";
                                                                    cadastraCepJurica.Endereco = "";
                                                                    cadastraCepJurica.Numero = "";
                                                                    cadastraCepJurica.Complemento = "";
                                                                    cadastraCepJurica.Bairro = "";
                                                                    cadastraCepJurica.Cidade = "";
                                                                    cadastraCepJurica.SiglaCidade = "";
                                                                    dal4.IncluirCepJuridico(cadastraCepJurica);

                                                                    if (CepManualSe == 1)
                                                                    {
                                                                        //Inserir Cep Segundario
                                                                        cadastraCepSecundario.idCep = idPessoaJuridica;

                                                                        cadastraCepSecundario.Numero = txtBairroFornecedor.Text;
                                                                        dal1.IncluirCepSecundario(cadastraCepSecundario);
                                                                    }

                                                                    MessageBox.Show("Cliente Cadastrado com sucesso!");

                                                                    FecharTodosFormulario();

                                                                    FormCadastraClienteRegistro cadastracliente = new FormCadastraClienteRegistro(this.NomeServidor, this.NomeBaseDados, this.NomeUsuario, this.SenhaBaseDados);
                                                                    cadastracliente.MdiParent = FormCadastraClienteRegistro.ActiveForm;
                                                                    cadastracliente.Show();
                                                                    cadastracliente.Top = 0;
                                                                    cadastracliente.Left = 0;
                                                                }
                                                                else if (idPessoaJuridica <= 0)
                                                                {
                                                                    MessageBox.Show("Erro na geração de ID J.2.");
                                                                }
                                                            }
                                                            if (SalvaClienteRegistro == DialogResult.No)
                                                            {
                                                                MessageBox.Show("Não atribuido ao sistema!");
                                                            }
                                                        }
                                                    }
                                                    if (maskedTextBoxCep.Text != "")
                                                    {
                                                        dal.Incluir(cadastra);
                                                        idPessoaJuridica = int.Parse(cadastra.idPessoa.ToString());

                                                        if (idPessoaJuridica > 0)
                                                        {
                                                            //Inserir Pessoa Juridica
                                                            pessoaJuridica.idPessoaJuridica = idPessoaJuridica;
                                                            dal5.IncluirPessoaJuridica(pessoaJuridica);

                                                            //Inserir Fornecedor
                                                            pessoaFornecedor.idFornecedor = idPessoaJuridica;
                                                            dal2.IncluirF(pessoaFornecedor);

                                                            //Inserir Cep
                                                            cadastraCepJurica.idCep = idPessoaJuridica;
                                                            dal4.IncluirCepJuridico(cadastraCepJurica);

                                                            if (CepManualSe == 1)
                                                            {
                                                                //Inserir Cep Segundario
                                                                cadastraCepSecundario.idCep = idPessoaJuridica;

                                                                cadastraCepSecundario.Numero = txtBairroFornecedor.Text;
                                                                dal1.IncluirCepSecundario(cadastraCepSecundario);
                                                            }

                                                            MessageBox.Show("Cliente Cadastrado com sucesso!");

                                                            FecharTodosFormulario();

                                                            FormCadastraClienteRegistro cadastracliente = new FormCadastraClienteRegistro(this.NomeServidor, this.NomeBaseDados, this.NomeUsuario, this.SenhaBaseDados);
                                                            cadastracliente.MdiParent = FormCadastraClienteRegistro.ActiveForm;
                                                            cadastracliente.Show();
                                                            cadastracliente.Top = 0;
                                                            cadastracliente.Left = 0;
                                                        }
                                                        else if (idPessoaJuridica <= 0)
                                                        {
                                                            MessageBox.Show("Erro na geração de ID J.3.");
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                        catch (Exception ex)
                                        {
                                            MessageBox.Show(ex.Message);
                                        }
                                    }
                                }
                                if (SiteOFF == 1)
                                {
                                    //Pessoa fisica Cep não pode está em branco
                                    if (CepPrincipal.Equals("_____-___"))
                                    {
                                        verificador = false;
                                        MessageBox.Show("O cep não pode está em branco e pesquisa o cep!");
                                    }//Modo cep principal automatico
                                    else if (!CepPrincipal.Equals("_____-___"))
                                    {
                                        if (CepManual == 0)
                                        {
                                            if (labelConfirmacaoPrimario.Text.Equals("Resultado:"))
                                            {
                                                verificador = false;
                                                MessageBox.Show("Pesquisa o cep Principal!");
                                            }
                                            if (labelConfirmacaoPrimario.Text.Equals("sucesso - cep não encontrado"))
                                            {
                                                verificador = false;
                                                MessageBox.Show("O cep é não é válido!");
                                            }
                                            if (labelConfirmacaoPrimario.Text.Equals("sucesso - cep completo"))
                                            {
                                                if (CepSecundarioT.Equals("_____-___"))
                                                {
                                                    verificador = true;
                                                }
                                                //Cep Segundario Automatico
                                                else if (!CepSecundarioT.Equals("_____-___"))
                                                {
                                                    if (CepManualSe == 0)
                                                    {
                                                        if (labelConfirmacaoSecundario.Text.Equals("Resultado:"))
                                                        {
                                                            verificador = false;
                                                            MessageBox.Show("Pesquisa o cep Secundario!");
                                                        }
                                                        if (labelConfirmacaoSecundario.Text.Equals("sucesso - cep não encontrado"))
                                                        {
                                                            verificador = false;
                                                            MessageBox.Show("O cep é não é válido!");
                                                        }
                                                        if (labelConfirmacaoSecundario.Text.Equals("sucesso - cep completo"))
                                                        {
                                                            verificador = true;
                                                            CepSecundario = true;
                                                        }
                                                    }
                                                    if (CepManualSe == 1)
                                                    {
                                                        if ((validaCep(txtCepFornecedor, errorProviderFornecedor) == true) && (validaEndereco(txtEnderecoFornecedor, errorProviderFornecedor) == true) &&
                                                             (validaBairro(txtBairroFornecedor, errorProviderFornecedor) == true) && (validaCidade(txtCidadeFornecedor, errorProviderFornecedor) == true))
                                                        {
                                                            verificador = true;
                                                            CepSecundario = true;
                                                        }
                                                    }

                                                }
                                            }

                                        }
                                        if (CepManual == 1)
                                        {
                                            if ((validaCep(txtCepFornecedor, errorProviderFornecedor) == true) && (validaEndereco(txtEnderecoFornecedor, errorProviderFornecedor) == true) &&
                                                   (validaBairro(txtBairroFornecedor, errorProviderFornecedor) == true) && (validaCidade(txtCidadeFornecedor, errorProviderFornecedor) == true))
                                            {
                                                if (CepSecundarioT.Equals("_____-___"))
                                                {
                                                    verificador = true;
                                                }
                                                else if (!CepSecundarioT.Equals("_____-___"))
                                                {
                                                    if (CepManualSe == 0)
                                                    {
                                                        //Cep Segundario Automatico
                                                        if (labelConfirmacaoSecundario.Text.Equals("Resultado:"))
                                                        {
                                                            verificador = false;
                                                            MessageBox.Show("Pesquisa o cep secundario!");
                                                        }
                                                        if (labelConfirmacaoSecundario.Text.Equals("sucesso - cep não encontrado"))
                                                        {
                                                            verificador = false;
                                                            MessageBox.Show("O cep é não é válido!");
                                                        }
                                                        if (labelConfirmacaoSecundario.Text.Equals("sucesso - cep completo"))
                                                        {
                                                            verificador = true;
                                                            CepSecundario = true;
                                                        }
                                                    }
                                                    if (CepManualSe == 1)
                                                    {
                                                        //Cep Segundario Manual
                                                        if (!CepSecundarioT.Equals("_____-___"))
                                                        {
                                                            if ((validaCep(txtCepFornecedor, errorProviderFornecedor) == true) && (validaEndereco(txtEnderecoFornecedor, errorProviderFornecedor) == true) &&
                                                                   (validaBairro(txtBairroFornecedor, errorProviderFornecedor) == true) && (validaCidade(txtCidadeFornecedor, errorProviderFornecedor) == true))
                                                            {
                                                                verificador = true;

                                                                CepSecundario = true;
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }


                                    if ((ValidaNome(txtNomeFornecedor, errorProviderFornecedor) == true) && (verificador == true) &&
                                        (validaCnpj(txtCnpj, errorProviderFornecedor) == true) && (validaRazãoSocial(txtRazaoSocial, errorProviderFornecedor) == true) &&
                                        (validaInscricaoStadual(txtInscStatual, errorProviderFornecedor) == true) && (validaCnae(txtCnae, errorProviderFornecedor) == true) &&
                                        (txtCnpj.Text.Length == 14))//(labelConfirmacao.Text).Equals("sucesso - cep completo"))
                                    {
                                        try
                                        {
                                            Conexao conexao = new Conexao(this.connetionString);
                                            DALDateSystem dal = new DALDateSystem(conexao); //cadastra Pessoa

                                            Conexao conexao4 = new Conexao(this.connetionString);
                                            DALDateSystem dal4 = new DALDateSystem(conexao4);//Cadastra Cep Principal

                                            Conexao conexao1 = new Conexao(this.connetionString);
                                            DALDateSystem dal1 = new DALDateSystem(conexao1);//cadastra Cep

                                            Conexao conexao2 = new Conexao(this.connetionString);
                                            DALDateSystem dal2 = new DALDateSystem(conexao2);//cadastra Pesssoa Fornecedor DataSystem

                                            Conexao conexao5 = new Conexao(this.connetionString);
                                            DALDateSystem dal5 = new DALDateSystem(conexao5);//cadastra Pesssoa Juridica 


                                            Pessoa cadastra = new Pessoa();

                                            Fornecedor pessoaFornecedor = new Fornecedor();

                                            CepSecundario cadastraCepSecundario = new CepSecundario();

                                            CepJ cadastraCepJurica = new CepJ();

                                            // Dados Pessoa

                                            cadastra.IdOs = 0;
                                            cadastra.Situacao = 1;
                                            cadastra.Nome = txtNomeFornecedor.Text;
                                            cadastra.Telefone = txtTelefoneFornecedor.Text;
                                            cadastra.Telefone2 = txtTelefone2Fornecedor.Text;
                                            cadastra.FaxTelefone = txtFaxTelefoneFornecedor.Text;
                                            cadastra.TelexTelefone = txtTelexTelefoneFornecedor.Text;
                                            cadastra.Email = txtEmailFornecedor.Text;
                                            cadastra.Observacao = txtObservacaoFornecedor.Text;
                                            cadastra.Tipo = txtTipoFornecedor.Text;
                                            cadastra.CpMunicipio = txtCpMunicipioFornecedor.Text;
                                            cadastra.Municipio = txtMunicipioFornecedor.Text;
                                            cadastra.Pais = txtPaisFornecedor.Text;
                                            cadastra.DesPais = txtDesPaisFornecedor.Text;
                                            cadastra.IdPessoaTipo = 2;

                                            //Pessoa Juridica
                                            PessoaJuridica pessoaJuridica = new PessoaJuridica();
                                            pessoaJuridica.IdPessoaTipo = 2;
                                            pessoaJuridica.IdPessoaTipo = 2;
                                            pessoaJuridica.Cnpj = txtCnpj.Text;
                                            pessoaJuridica.RazaoSocial = txtRazaoSocial.Text;
                                            pessoaJuridica.InscricaoStadual = txtInscStatual.Text;
                                            pessoaJuridica.NomeContato = txtNomeFornecedor.Text;
                                            pessoaJuridica.Cnae = txtCnae.Text;


                                            //Dados Pessoa Cliente Forcenedor

                                            pessoaFornecedor.CargoContato = txtNomeFornecedor.Text;
                                            pessoaFornecedor.NomeContato = txtNomeFornecedor.Text;

                                            //Dados CEP
                                            if (maskedTextBoxCep.Text == "")
                                            {

                                            }
                                            else cadastraCepJurica.Cepc = int.Parse(maskedTextBoxCep.Text);
                                            cadastraCepJurica.TipoLogradouro = txtLogradouro.Text;
                                            cadastraCepJurica.Endereco = txtEndereco.Text;
                                            cadastraCepJurica.Numero = txtNumeroPrincipal.Text;
                                            cadastraCepJurica.Complemento = txtcomplemento.Text;
                                            cadastraCepJurica.Bairro = txtBairro.Text;
                                            cadastraCepJurica.Cidade = txtCidade.Text;
                                            cadastraCepJurica.SiglaCidade = txtSigla.Text;

                                            ////Dados CEP Secundario
                                            if (labelConfirmacaoSecundario.Text.Equals("sucesso - cep completo"))
                                            {
                                                cadastraCepSecundario.Cepc = int.Parse(txtCepFornecedor.Text);
                                                cadastraCepSecundario.TipoLogradouro = txtTipo_logradouro.Text;
                                                cadastraCepSecundario.Endereco = txtEmailFornecedor.Text;
                                                cadastraCepSecundario.Numero = txtBairroFornecedor.Text;
                                                cadastraCepSecundario.Complemento = txtComplFornecedor.Text;
                                                cadastraCepSecundario.Bairro = txtBairroFornecedor.Text;
                                                cadastraCepSecundario.Cidade = txtCidadeFornecedor.Text;
                                                cadastraCepSecundario.SiglaCidade = txtSiglaCidadeFornecedor.Text;
                                            }
                                            if (!labelConfirmacaoSecundario.Text.Equals("sucesso - cep completo"))
                                            {

                                            }

                                            if ((validaCnpj(txtCnpj, errorProviderFornecedor) == true))
                                            //(labelConfirmacao.Text).Equals("sucesso - cep completo"))
                                            {

                                                if (this.operacao == "Inserir")
                                                {
                                                    if (maskedTextBoxCep.Text == "")
                                                    {
                                                        if (VerificadorEndereco() == true)
                                                        {
                                                            DialogResult SalvaClienteRegistro = MessageBox.Show("Deseja Salvar em Pessoa Juridica?\n" +
                                                                "Por não consta endereço na Receita Federal sera salvo sem o mesmo.", "Aviso", MessageBoxButtons.YesNo);

                                                            if (SalvaClienteRegistro == DialogResult.Yes)
                                                            {
                                                                dal.Incluir(cadastra);
                                                                idPessoaJuridica = int.Parse(cadastra.idPessoa.ToString());

                                                                if (idPessoaJuridica > 0)
                                                                {
                                                                    //Inserir Pessoa Juridica
                                                                    pessoaJuridica.idPessoaJuridica = idPessoaJuridica;
                                                                    dal5.IncluirPessoaJuridica(pessoaJuridica);

                                                                    //Inserir Fornecedor
                                                                    pessoaFornecedor.idFornecedor = idPessoaJuridica;
                                                                    dal2.IncluirF(pessoaFornecedor);

                                                                    //Inserir Cep
                                                                    cadastraCepJurica.idCep = idPessoaJuridica;
                                                                    cadastraCepJurica.Cepc = 00000000;
                                                                    cadastraCepJurica.TipoLogradouro = "";
                                                                    cadastraCepJurica.Endereco = "";
                                                                    cadastraCepJurica.Numero = "";
                                                                    cadastraCepJurica.Complemento = "";
                                                                    cadastraCepJurica.Bairro = "";
                                                                    cadastraCepJurica.Cidade = "";
                                                                    cadastraCepJurica.SiglaCidade = "";

                                                                    dal4.IncluirCepJuridico(cadastraCepJurica);

                                                                    if (CepManualSe == 1)
                                                                    {
                                                                        //Inserir Cep Segundario
                                                                        cadastraCepSecundario.idCep = idPessoaJuridica;
                                                                        cadastraCepSecundario.Numero = txtBairroFornecedor.Text;
                                                                        dal1.IncluirCepSecundario(cadastraCepSecundario);
                                                                    }
                                                                    MessageBox.Show("Cliente Cadastrado com sucesso!");

                                                                    FecharTodosFormulario();

                                                                    FormCadastraClienteRegistro cadastracliente = new FormCadastraClienteRegistro(this.NomeServidor, this.NomeBaseDados, this.NomeUsuario, this.SenhaBaseDados);
                                                                    cadastracliente.MdiParent = FormCadastraClienteRegistro.ActiveForm;
                                                                    cadastracliente.Show();
                                                                    cadastracliente.Top = 0;
                                                                    cadastracliente.Left = 0;
                                                                }
                                                                else if (idPessoaJuridica <= 0)
                                                                {
                                                                    MessageBox.Show("Erro na geração de ID J.4.");
                                                                }
                                                            }
                                                            else if (SalvaClienteRegistro == DialogResult.No)
                                                            {
                                                                MessageBox.Show("Não atribuido ao sistema!");
                                                            }
                                                        }
                                                        if (VerificadorEndereco() == false)
                                                        {
                                                            DialogResult SalvaClienteRegistro = MessageBox.Show("Deseja Salvar em Pessoa Juridica?\n" +
                                                                "Sem um endereço. Passando cep com a numeração 0.", "Aviso", MessageBoxButtons.YesNo);

                                                            if (SalvaClienteRegistro == DialogResult.Yes)
                                                            {
                                                                dal.Incluir(cadastra);
                                                                idPessoaJuridica = int.Parse(cadastra.idPessoa.ToString());

                                                                if (idPessoaJuridica > 0)
                                                                {
                                                                    //Inserir Pessoa Juridica
                                                                    pessoaJuridica.idPessoaJuridica = idPessoaJuridica;
                                                                    dal5.IncluirPessoaJuridica(pessoaJuridica);

                                                                    //Inserir Fornecedor
                                                                    pessoaFornecedor.idFornecedor = idPessoaJuridica;
                                                                    dal2.IncluirF(pessoaFornecedor);

                                                                    //Inserir Cep
                                                                    cadastraCepJurica.idCep = idPessoaJuridica;
                                                                    cadastraCepJurica.Cepc = 00000000;
                                                                    dal4.IncluirCepJuridico(cadastraCepJurica);

                                                                    if (CepManualSe == 1)
                                                                    {
                                                                        //Inserir Cep Segundario
                                                                        cadastraCepSecundario.idCep = idPessoaJuridica;
                                                                        cadastraCepSecundario.Numero = txtBairroFornecedor.Text;
                                                                        dal1.IncluirCepSecundario(cadastraCepSecundario);
                                                                    }
                                                                    MessageBox.Show("Cliente Cadastrado com sucesso!");

                                                                    FecharTodosFormulario();

                                                                    FormCadastraClienteRegistro cadastracliente = new FormCadastraClienteRegistro(this.NomeServidor, this.NomeBaseDados, this.NomeUsuario, this.SenhaBaseDados);
                                                                    cadastracliente.MdiParent = FormCadastraClienteRegistro.ActiveForm;
                                                                    cadastracliente.Show();
                                                                    cadastracliente.Top = 0;
                                                                    cadastracliente.Left = 0;
                                                                }
                                                                else if (idPessoaJuridica <= 0)
                                                                {
                                                                    MessageBox.Show("Erro na geração de ID J.4.");
                                                                }
                                                            }
                                                            else if (SalvaClienteRegistro == DialogResult.No)
                                                            {
                                                                MessageBox.Show("Não atribuido ao sistema!");
                                                            }
                                                        }
                                                    }
                                                    if (maskedTextBoxCep.Text != "")
                                                    {
                                                        dal.Incluir(cadastra);

                                                        idPessoaJuridica = int.Parse(cadastra.idPessoa.ToString());

                                                        if (idPessoaJuridica > 0)
                                                        {
                                                            //Inserir Pessoa Juridica
                                                            pessoaJuridica.idPessoaJuridica = idPessoaJuridica;
                                                            dal5.IncluirPessoaJuridica(pessoaJuridica);

                                                            //Inserir Fornecedor
                                                            pessoaFornecedor.idFornecedor = idPessoaJuridica;
                                                            dal2.IncluirF(pessoaFornecedor);

                                                            //Inserir Cep
                                                            cadastraCepJurica.idCep = idPessoaJuridica;

                                                            dal4.IncluirCepJuridico(cadastraCepJurica);

                                                            if (CepManualSe == 1)
                                                            {
                                                                //Inserir Cep Segundario
                                                                cadastraCepSecundario.idCep = idPessoaJuridica;
                                                                cadastraCepSecundario.Numero = txtBairroFornecedor.Text;
                                                                dal1.IncluirCepSecundario(cadastraCepSecundario);
                                                            }
                                                            MessageBox.Show("Cliente Cadastrado com sucesso!");

                                                            FecharTodosFormulario();

                                                            FormCadastraClienteRegistro cadastracliente = new FormCadastraClienteRegistro(this.NomeServidor, this.NomeBaseDados, this.NomeUsuario, this.SenhaBaseDados);
                                                            cadastracliente.MdiParent = FormCadastraClienteRegistro.ActiveForm;
                                                            cadastracliente.Show();
                                                            cadastracliente.Top = 0;
                                                            cadastracliente.Left = 0;
                                                        }
                                                        else if (idPessoaJuridica <= 0)
                                                        {
                                                            MessageBox.Show("Erro na geração de ID J.4. ");
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                        catch (Exception ex)
                                        {
                                            MessageBox.Show(ex.Message);
                                        }
                                    }
                                }
                            }
                        }
                    }
                    else MessageBox.Show("Telefone da Empresa");
                }
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
        }

        //Inserir Fornecedor
        //pessoaFornecedor.idFornecedor = IdFornecedorFisica;
        //                            dal2.IncluirF(pessoaFornecedor);

        //Metodo que altera Botões e outras funções
        public void AlteraBotoes(int op)
        {
            if (op == 1)// Cadastra Cliente
            {
                panelCadastraFornecedor.Enabled = true;

                buttonCadastraFornecedor.Enabled = false;

                buttonVerificarFornecedor.Enabled = true;
                buttonLimpaFornecedor.Enabled = false;
                buttonCancelarFornecedor.Enabled = true;
                buttonFecharFornecedor.Enabled = true;

                radioButtonFornecedorFisica.Enabled = true;
                radioButtonFornecedorJuridica.Enabled = true;
            }
            if (op == 2)//salvar Cadastro de Cliente
            {
                panelCadastraFornecedor.Enabled = false;

                buttonCadastraFornecedor.Enabled = true;

                buttonVerificarFornecedor.Enabled = false;
                buttonLimpaFornecedor.Enabled = false;
                buttonCancelarFornecedor.Enabled = false;
                buttonFecharFornecedor.Enabled = true;

            }
            if (op == 3)//Calcelar Cadastro de Cliente
            {
                panelCadastraFornecedor.Enabled = false;

                buttonCadastraFornecedor.Enabled = true;

                buttonVerificarFornecedor.Enabled = false;
                buttonLimpaFornecedor.Enabled = false;
                buttonCancelarFornecedor.Enabled = false;
                buttonFecharFornecedor.Enabled = true;

            }
            if (op == 4) //  Editar Cadastro de Cliente
            {
                panelCadastraFornecedor.Enabled = true;

                buttonCadastraFornecedor.Enabled = false;

                buttonVerificarFornecedor.Enabled = true;
                buttonLimpaFornecedor.Enabled = false;
                buttonCancelarFornecedor.Enabled = true;
                buttonFecharFornecedor.Enabled = true;
                tabControlFornedor.Enabled = true;

            }
            if (op == 5)//Cancela Pesquisa
            {

            }
            if (op == 6)//Cadastro de Cliente Inicializado
            {
                buttonCadastraFornecedor.Enabled = false;

                buttonVerificarFornecedor.Enabled = true;
                buttonLimpaFornecedor.Enabled = false;
                buttonCancelarFornecedor.Enabled = true;
                buttonFecharFornecedor.Enabled = true;
            }
            if (op == 7)//Botão Verificar informações Passadas
            {
                txtNomeContatoFornecedor.Enabled = false;
                txtNomeFornecedor.Enabled = false;
                txtCargoContatoFornecedor.Enabled = false;
                txtCepFornecedor.Enabled = false;
                txtTipo_logradouro.Enabled = false;
                txtBairroFornecedor.Enabled = false;
                txtBairroNumeroFornecedor.Enabled = false;
                txtTelefone2Fornecedor.Enabled = false;
                txtTelefoneFornecedor.Enabled = false;
                txtTelexTelefoneFornecedor.Enabled = false;
                txtEmailFornecedor.Enabled = false;
                txtEnderecoFornecedor.Enabled = false;
                txtMunicipioFornecedor.Enabled = false;
                txtPaisFornecedor.Enabled = false;
                txtComplFornecedor.Enabled = false;
                txtCpMunicipioFornecedor.Enabled = false;
                txtFaxTelefoneFornecedor.Enabled = false;
                txtDesPaisFornecedor.Enabled = false;
                txtObservacaoFornecedor.Enabled = false;
                txtTipoFornecedor.Enabled = false;


                ButtonBuscaCep.Enabled = false;
            }
            if (op == 8)//Libera Pessoa Fisica e Juridica!
            {
                radioButtonFornecedorFisica.Enabled = true;
                radioButtonFornecedorJuridica.Enabled = true;
                buttonVerificarFornecedor.Enabled = false;
                buttonLimpaFornecedor.Enabled = false;
                buttonCancelarFornecedor.Enabled = false;
                buttonFecharFornecedor.Enabled = false;
            }
            if (op == 9)//Libera Pesquisa Por MS e Nome.
            {

                buttonCadastraFornecedor.Enabled = false;

            }
            if (op == 10)
            {
                txtNomeContatoFornecedor.Clear();
                txtCargoContatoFornecedor.Clear();
                txtNomeFornecedor.Clear();
                maskedTextBoxCep.Clear();
                txtEnderecoFornecedor.Clear();
                txtNumeroPrincipal.Clear();
                txtBairro.Clear();
                txtcomplemento.Clear();
                txtCidade.Clear();
                txtTelefoneFornecedor.Clear();
                txtTelefone2Fornecedor.Clear();
                txtFaxTelefoneFornecedor.Clear();
                txtTelexTelefoneFornecedor.Clear();
                txtEmailFornecedor.Clear();
                txtObservacaoFornecedor.Clear();
                txtCepFornecedor.Clear();
                txtTipoFornecedor.Clear();
                txtCpMunicipioFornecedor.Clear();
                txtMunicipioFornecedor.Clear();
                txtPaisFornecedor.Clear();
                txtDesPaisFornecedor.Clear();
                txtObservacaoFornecedor.Clear();
                txtCnpj.Clear();
                txtRazaoSocial.Clear();
                txtInscStatual.Clear();
                txtNomeContato.Clear();
                txtCnae.Clear();
                txtCnpjConsulta.Clear();
                txtLetrasConulta.Clear();
                txtNomePFisica.Clear();
                txtCpfFFisica.Clear();
                txtRgFisica.Clear();
                txtCelularFFisica.Clear();
                txtCelularFFisica2.Clear();
                txtCepFornecedor.Clear();
                txtLogradouro.Clear();
                txtEnderecoFornecedor.Clear();
                txtBairroNumeroFornecedor.Clear();
                txtComplFornecedor.Clear();
                txtBairroFornecedor.Clear();
                txtCidadeFornecedor.Clear();
                txtSiglaCidadeFornecedor.Clear();
                txtSigla.Clear();
            }
            if (op == 11)
            {//Pessoa Fisica
                txtNomePFisica.Enabled = true;
                comboBoxSexoFFIsica.Enabled = true;
                txtCpfFFisica.Enabled = true;
                txtRgFisica.Enabled = true;
                txtDataNascimentoFFisica.Enabled = true;
                txtCelularFFisica.Enabled = true;
                txtCelularFFisica2.Enabled = true;

                txtCnpj.Enabled = false;
                txtRazaoSocial.Enabled = false;
                txtInscStatual.Enabled = false;
                txtNomeContato.Enabled = false;
                txtCnae.Enabled = false;

                txtCnpj.Clear();
                txtRazaoSocial.Clear();
                txtInscStatual.Clear();
                txtNomeContato.Clear();
                txtCnpjConsulta.Clear();
                txtLetrasConulta.Clear();
                txtCnae.Clear();

                maskedTextBoxCep.Clear();
                txtEndereco.Clear();
                txtNumeroPrincipal.Clear();
                txtBairro.Clear();
                txtcomplemento.Clear();
                txtCidade.Clear();
                txtSigla.Clear();
                txtLogradouro.Clear();

                maskedTextBoxCep.Clear();
                txtBairro.Clear();
                txtEnderecoFornecedor.Clear();
                txtComplFornecedor.Clear();
                txtBairro.Clear();
                txtLogradouro.Clear();
                txtSiglaCidadeFornecedor.Clear();
                txtCepFornecedor.Clear();
                txtTipo_logradouro.Clear();
                txtBairroNumeroFornecedor.Clear();
                txtComplFornecedor.Clear();
                txtBairroFornecedor.Clear();
                txtCidadeFornecedor.Clear();

                labelConfirmacaoPrimario.Text = "Resultado:";

                buttonCnpjManual.Enabled = false;
                buttonCnpjAutomatico.Enabled = false;
                tabControlFornedor.Enabled = true;
                txtCepFornecedor.Enabled = true;
                txtBairroNumeroFornecedor.Enabled = true;
                txtComplFornecedor.Enabled = true;
                maskedTextBoxCep.Enabled = true;
                buttonConsultaCnpj.Visible = false;
                buttonTrocaImagem.Visible = false;
                label5.Visible = false;
                txtCnpjConsulta.Visible = false;
                label10.Visible = false;
                txtLetrasConulta.Visible = false;
                pictureBoxLetras.Visible = false;

                buttonConsultaCnpj.Enabled = false;
                buttonTrocaImagem.Enabled = false;
                label5.Enabled = false;
                txtCnpjConsulta.Enabled = false;
                label10.Enabled = false;
                txtLetrasConulta.Enabled = false;
                pictureBoxLetras.Enabled = false;
                buttonCepPrincipal.Enabled = true;
                txtNumeroPrincipal.Enabled = true;


            }
            if (op == 12)
            {//Pessoa Juridica

                txtNomePFisica.Enabled = false;
                comboBoxSexoFFIsica.Enabled = false;
                txtCpfFFisica.Enabled = false;
                txtRgFisica.Enabled = false;
                txtDataNascimentoFFisica.Enabled = false;
                txtCelularFFisica.Enabled = false;
                txtCelularFFisica2.Enabled = false;

                txtCnpj.Enabled = false;
                txtRazaoSocial.Enabled = false;
                txtInscStatual.Enabled = false;
                txtNomeContato.Enabled = true;
                txtCnae.Enabled = false;

                txtNomePFisica.Clear();

                txtCpfFFisica.Clear();
                txtRgFisica.Clear();

                txtCelularFFisica.Clear();
                txtCelularFFisica2.Clear();
                txtCnpj.Clear();
                txtRazaoSocial.Clear();
                txtInscStatual.Clear();
                txtNomeContato.Clear();
                txtCnpjConsulta.Clear();
                txtLetrasConulta.Clear();
                txtCnae.Clear();

                maskedTextBoxCep.Clear();
                txtEndereco.Clear();
                txtNumeroPrincipal.Clear();
                txtBairro.Clear();
                txtcomplemento.Clear();
                txtCidade.Clear();
                txtSigla.Clear();
                txtLogradouro.Clear();

                maskedTextBoxCep.Clear();
                txtBairro.Clear();
                txtEnderecoFornecedor.Clear();
                txtComplFornecedor.Clear();
                txtBairro.Clear();
                txtLogradouro.Clear();
                txtSiglaCidadeFornecedor.Clear();
                txtCepFornecedor.Clear();
                txtTipo_logradouro.Clear();
                txtBairroNumeroFornecedor.Clear();
                txtComplFornecedor.Clear();
                txtBairroFornecedor.Clear();
                txtCidadeFornecedor.Clear();

                labelConfirmacaoPrimario.Text = "Resultado:";

                buttonCnpjManual.Enabled = true;
                buttonCnpjAutomatico.Enabled = true;
                tabControlFornedor.Enabled = true;
                buttonCepPrincipal.Enabled = false;
                txtCepFornecedor.Enabled = true;
                txtBairroNumeroFornecedor.Enabled = true;
                txtComplFornecedor.Enabled = true;

            }
        }
        public void AlteraBotoesCnpj(int op)
        {
            if (op == 1)//Manual
            {
                buttonConsultaCnpj.Visible = false;
                buttonTrocaImagem.Visible = false;
                label5.Visible = false;
                txtCnpjConsulta.Visible = false;
                label10.Visible = false;
                txtLetrasConulta.Visible = false;
                pictureBoxLetras.Visible = false;

                buttonConsultaCnpj.Enabled = false;
                buttonTrocaImagem.Enabled = false;
                label5.Enabled = false;
                txtCnpjConsulta.Enabled = false;
                label10.Enabled = false;
                txtLetrasConulta.Enabled = false;
                pictureBoxLetras.Enabled = false;

                buttonCepPrincipal.Enabled = true;

                txtNumeroPrincipal.Enabled = true;
                txtNomeContato.Enabled = true;

                buttonCnpjManual.Enabled = false;
                buttonCnpjAutomatico.Enabled = true;

                txtCnpj.Enabled = true;
                txtRazaoSocial.Enabled = true;
                txtInscStatual.Enabled = true;
                txtCnae.Enabled = true;
                maskedTextBoxCep.Enabled = true;
            }
            if (op == 2)//Automatico
            {
                carregarCaptcha();
                buttonConsultaCnpj.Visible = true;
                buttonTrocaImagem.Visible = true;
                label5.Visible = true;
                txtCnpjConsulta.Visible = true;
                label10.Visible = true;
                txtLetrasConulta.Visible = true;
                pictureBoxLetras.Visible = true;
                maskedTextBoxCep.Enabled = false;
                buttonConsultaCnpj.Enabled = true;
                buttonTrocaImagem.Enabled = true;
                label5.Enabled = true;
                txtCnpjConsulta.Enabled = true;
                label10.Enabled = true;
                txtLetrasConulta.Enabled = true;
                pictureBoxLetras.Enabled = true;
                txtNumeroPrincipal.Enabled = false;
                buttonCepPrincipal.Enabled = false;

                buttonCnpjManual.Enabled = true;
                buttonCnpjAutomatico.Enabled = false;

                txtCnpj.Enabled = false;
                txtRazaoSocial.Enabled = false;
                txtInscStatual.Enabled = false;
                txtCnae.Enabled = false;

            }
        }
        private void ButtonBuscaCep_Click_1(object sender, EventArgs e)
        {
            try
            {
                string xml = "http://cep.republicavirtual.com.br/web_cep.php?cep=@cep&formato=xml"
                .Replace("@cep", txtCepFornecedor.Text);
                DataSet ds = new DataSet();
                ds.ReadXml(xml);

                labelConfirmacaoSecundario.Text = ds.Tables[0].Rows[0][1].ToString();
                //TesteValores.Text = txtCepCliente.Text;

                txtTipo_logradouro.Text = ds.Tables[0].Rows[0][5].ToString();
                txtEnderecoFornecedor.Text = ds.Tables[0].Rows[0][6].ToString();
                txtBairroFornecedor.Text = ds.Tables[0].Rows[0][4].ToString();
                txtCidadeFornecedor.Text = ds.Tables[0].Rows[0][3].ToString();
                txtSiglaCidadeFornecedor.Text = ds.Tables[0].Rows[0][2].ToString();
            }
            catch
            {
                MessageBox.Show(" Erro: " + e.ToString());
            }


            if (labelConfirmacaoPrimario.Text.Equals("sucesso - cep não encontrado"))
            {
                MessageBox.Show("O cep digitado não é válido!");
            }
        }

        private void buttonEditarFornecedor_Click(object sender, EventArgs e)
        {
            AlteraBotoes(4);

            this.operacao = "Editar";

        }

        private void buttonExcluirFornecedor_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Deseja Excluir o registro?", "Aviso", MessageBoxButtons.YesNo);

            Conexao conexao = new Conexao(this.connetionString);
            DALDateSystem dal = new DALDateSystem(conexao);

            if (d.ToString() == "Yes")
            {
                if (this.ID_TIPO_PESSOA == 1)
                {
                    dal.ExcluirFornecedorFisico(IdPessoa);

                    FecharTodosFormulario();

                    FormFornecedores Fornecedor = new FormFornecedores(this.NomeServidor, this.NomeBaseDados, this.NomeUsuario, this.SenhaBaseDados);
                    Fornecedor.MdiParent = FormFornecedores.ActiveForm;
                    Fornecedor.Show();
                    Fornecedor.Top = 0;
                    Fornecedor.Left = 0;
                }
                if (this.ID_TIPO_PESSOA == 2)
                {
                    dal.ExcluirFornecedorJuridica(IdPessoa);

                    FecharTodosFormulario();

                    FormFornecedores Fornecedor = new FormFornecedores(this.NomeServidor, this.NomeBaseDados, this.NomeUsuario, this.SenhaBaseDados);
                    Fornecedor.MdiParent = FormFornecedores.ActiveForm;
                    Fornecedor.Show();
                    Fornecedor.Top = 0;
                    Fornecedor.Left = 0;
                }
            }
        }

        private void ButtonPesquisa_Click(object sender, EventArgs e)
        {
            AlteraBotoes(9);

            radioButtonFornecedorFisica.Enabled = true;

            radioButtonFornecedorJuridica.Enabled = true;
        }

        private void buttonLimpaFornecedor_Click(object sender, EventArgs e)
        {
            AlteraBotoes(10);
        }

        private void buttonFecharFornecedor_Click(object sender, EventArgs e)
        {
            //CHAMA O METODO CancelaCadastradoCliente QUE FECHA FORMULÁRIOS ABERTOS
            FecharTodosFormulario();

        }

        private void radioButtonFornecedorFisica_CheckedChanged_1(object sender, EventArgs e)
        {
            AlteraBotoes(11);
            AlteraBotoes(10);

            SiteOFF = 0;

        }

        private void radioButtonFornecedorJuridica_CheckedChanged_1(object sender, EventArgs e)
        {
            AlteraBotoes(10);
            AlteraBotoes(12);

            SiteOFF = 0;

       }

        private void buttonCepPrincipal_Click(object sender, EventArgs e)
        {
            try
            {
                string xml = "http://cep.republicavirtual.com.br/web_cep.php?cep=@cep&formato=xml"
        .Replace("@cep", maskedTextBoxCep.Text);
                DataSet ds = new DataSet();
                ds.ReadXml(xml);

                labelConfirmacaoPrimario.Text = ds.Tables[0].Rows[0][1].ToString();
                txtLogradouro.Text = ds.Tables[0].Rows[0][5].ToString();
                txtEndereco.Text = ds.Tables[0].Rows[0][6].ToString();
                txtBairro.Text = ds.Tables[0].Rows[0][4].ToString();
                txtCidade.Text = ds.Tables[0].Rows[0][3].ToString();
                txtSigla.Text = ds.Tables[0].Rows[0][3].ToString();
            }
            catch
            {
                MessageBox.Show(" Erro: " + e.ToString());
            }


            if(labelConfirmacaoPrimario.Text.Equals("sucesso - cep não encontrado"))
            {
                MessageBox.Show("O cep digitado não é válido!");
            }
        }
        private void buttonTrocaImagem_Click(object sender, EventArgs e)
        {
            carregarCaptcha();
        }
        public void carregarCaptcha()
        {
            consulta = new ConsultaCNPJReceita();
            pictureBoxLetras.Text = "";
            pictureBoxLetras.Focus();
            Cursor cursor;
            cursor = this.Cursor;
            this.Cursor = Cursors.WaitCursor;
            Bitmap bit = consulta.GetCaptcha();
            if (bit != null)
            {
                pictureBoxLetras.Image = bit;
                AlteraBotoesCnpj(2); //automatico
                SiteOFF = 0;
            }
            else
            {
                MessageBox.Show("Não foi possível recuperar a imagem de validação do site da Receita Federal \n podendo está em manutenção!");
                AlteraBotoesCnpj(1);//Manual
                SiteOFF = 1;
            }
            this.Cursor = cursor;
        }
        private void buttonConsultaCnpj_Click(object sender, EventArgs e)
        {
            ConsultaCnpj();
        }
        private enum Coluna
        {
            RazaoSocial = 0,
            NomeFantasia,

            AtividadeEconomicaPrimaria,
            AtividadeEconomicaSecundaria,

            NumeroDaInscricao,
            MatrizFilial,
            NaturezaJuridica,

            SituacaoCadastral,
            DataSituacaoCadastral,
            MotivoSituacaoCadastral,

            EnderecoLogradouro,
            EnderecoNumero,
            EnderecoComplemento,
            EnderecoCEP,
            EnderecoBairro,
            EnderecoCidade,
            EnderecoEstado


        };
        private String RecuperaColunaValor(String pattern, Coluna col)
        {
            String S = pattern.Replace("\n", "").Replace("\t", "").Replace("\r", "");

            switch (col)
            {
                case Coluna.RazaoSocial:
                    {
                        S = StringEntreString(S, "<!-- Início Linha NOME EMPRESARIAL -->", "<!-- Fim Linha NOME EMPRESARIAL -->");
                        S = StringEntreString(S, "<tr>", "</tr>");
                        S = StringEntreString(S, "<b>", "</b>");
                        return S.Trim();
                    }
                case Coluna.NomeFantasia:
                    {
                        S = StringEntreString(S, "<!-- Início Linha ESTABELECIMENTO -->", "<!-- Fim Linha ESTABELECIMENTO -->");
                        S = StringEntreString(S, "<tr>", "</tr>");
                        S = StringEntreString(S, "<b>", "</b>");
                        return S.Trim();
                    }
                case Coluna.NaturezaJuridica:
                    {
                        S = StringEntreString(S, "<!-- Início Linha NATUREZA JURÍDICA -->", "<!-- Fim Linha NATUREZA JURÍDICA -->");
                        S = StringEntreString(S, "<tr>", "</tr>");
                        S = StringEntreString(S, "<b>", "</b>");
                        return S.Trim();
                    }
                case Coluna.AtividadeEconomicaPrimaria:
                    {
                        S = StringEntreString(S, "<!-- Início Linha ATIVIDADE ECONOMICA -->", "<!-- Fim Linha ATIVIDADE ECONOMICA -->");
                        S = StringEntreString(S, "<tr>", "</tr>");
                        S = StringEntreString(S, "<b>", "</b>");
                        return S.Trim();
                    }
                case Coluna.AtividadeEconomicaSecundaria:
                    {
                        S = StringEntreString(S, "<!-- Início Linha ATIVIDADE ECONOMICA SECUNDARIA-->", "<!-- Fim Linha ATIVIDADE ECONOMICA SECUNDARIA -->");
                        S = StringEntreString(S, "<tr>", "</tr>");
                        S = StringEntreString(S, "<b>", "</b>");
                        return S.Trim();
                    }
                case Coluna.NumeroDaInscricao:
                    {
                        S = StringEntreString(S, "<!-- Início Linha NÚMERO DE INSCRIÇÃO -->", "<!-- Fim Linha NÚMERO DE INSCRIÇÃO -->");
                        S = StringEntreString(S, "<tr>", "</tr>");
                        S = StringEntreString(S, "<b>", "</b>");
                        return S.Trim();
                    }
                case Coluna.MatrizFilial:
                    {
                        S = StringEntreString(S, "<!-- Início Linha NÚMERO DE INSCRIÇÃO -->", "<!-- Fim Linha NÚMERO DE INSCRIÇÃO -->");
                        S = StringEntreString(S, "<tr>", "</tr>");
                        S = StringSaltaString(S, "</b>");
                        S = StringEntreString(S, "<b>", "</b>");
                        return S.Trim();
                    }
                case Coluna.EnderecoLogradouro:
                    {
                        S = StringEntreString(S, "<!-- Início Linha LOGRADOURO -->", "<!-- Fim Linha LOGRADOURO -->");
                        S = StringEntreString(S, "<tr>", "</tr>");
                        S = StringEntreString(S, "<b>", "</b>");
                        return S.Trim();
                    }
                case Coluna.EnderecoNumero:
                    {
                        S = StringEntreString(S, "<!-- Início Linha LOGRADOURO -->", "<!-- Fim Linha LOGRADOURO -->");
                        S = StringEntreString(S, "<tr>", "</tr>");
                        S = StringSaltaString(S, "</b>");
                        S = StringEntreString(S, "<b>", "</b>");
                        return S.Trim();
                    }
                case Coluna.EnderecoComplemento:
                    {
                        S = StringEntreString(S, "<!-- Início Linha LOGRADOURO -->", "<!-- Fim Linha LOGRADOURO -->");
                        S = StringEntreString(S, "<tr>", "</tr>");
                        S = StringSaltaString(S, "</b>");
                        S = StringSaltaString(S, "</b>");
                        S = StringEntreString(S, "<b>", "</b>");
                        return S.Trim();
                    }
                case Coluna.EnderecoCEP:
                    {
                        S = StringEntreString(S, "<!-- Início Linha CEP -->", "<!-- Fim Linha CEP -->");
                        S = StringEntreString(S, "<tr>", "</tr>");
                        S = StringEntreString(S, "<b>", "</b>");
                        return S.Trim();
                    }
                case Coluna.EnderecoBairro:
                    {
                        S = StringEntreString(S, "<!-- Início Linha CEP -->", "<!-- Fim Linha CEP -->");
                        S = StringEntreString(S, "<tr>", "</tr>");
                        S = StringSaltaString(S, "</b>");
                        S = StringEntreString(S, "<b>", "</b>");
                        return S.Trim();
                    }
                case Coluna.EnderecoCidade:
                    {
                        S = StringEntreString(S, "<!-- Início Linha CEP -->", "<!-- Fim Linha CEP -->");
                        S = StringEntreString(S, "<tr>", "</tr>");
                        S = StringSaltaString(S, "</b>");
                        S = StringSaltaString(S, "</b>");
                        S = StringEntreString(S, "<b>", "</b>");
                        return S.Trim();
                    }
                case Coluna.EnderecoEstado:
                    {
                        S = StringEntreString(S, "<!-- Início Linha CEP -->", "<!-- Fim Linha CEP -->");
                        S = StringEntreString(S, "<tr>", "</tr>");
                        S = StringSaltaString(S, "</b>");
                        S = StringSaltaString(S, "</b>");
                        S = StringSaltaString(S, "</b>");
                        S = StringEntreString(S, "<b>", "</b>");
                        return S.Trim();
                    }
                case Coluna.SituacaoCadastral:
                    {
                        S = StringEntreString(S, "<!-- Início Linha SITUAÇÃO CADASTRAL -->", "<!-- Fim Linha SITUACAO CADASTRAL -->");
                        S = StringEntreString(S, "<tr>", "</tr>");
                        S = StringEntreString(S, "<b>", "</b>");
                        return S.Trim();
                    }
                case Coluna.DataSituacaoCadastral:
                    {
                        S = StringEntreString(S, "<!-- Início Linha SITUAÇÃO CADASTRAL -->", "<!-- Fim Linha SITUACAO CADASTRAL -->");
                        S = StringEntreString(S, "<tr>", "</tr>");
                        S = StringSaltaString(S, "</b>");
                        S = StringEntreString(S, "<b>", "</b>");
                        return S.Trim();
                    }
                case Coluna.MotivoSituacaoCadastral:
                    {
                        S = StringEntreString(S, "<!-- Início Linha MOTIVO DE SITUAÇÃO CADASTRAL -->", "<!-- Fim Linha MOTIVO DE SITUAÇÃO CADASTRAL -->");
                        S = StringEntreString(S, "<tr>", "</tr>");
                        S = StringEntreString(S, "<b>", "</b>");
                        return S.Trim();
                    }

                default:
                    {
                        return S;
                    }
            }
        }

        private String StringEntreString(String Str, String StrInicio, String StrFinal)
        {
            int Ini;
            int Fim;
            int Diff;
            Ini = Str.IndexOf(StrInicio);
            Fim = Str.IndexOf(StrFinal);
            if (Ini > 0) Ini = Ini + StrInicio.Length;
            if (Fim > 0) Fim = Fim + StrFinal.Length;
            Diff = ((Fim - Ini) - StrFinal.Length);
            if ((Fim > Ini) && (Diff > 0))
                return Str.Substring(Ini, Diff);
            else
                return "";
        }

        private String StringSaltaString(String Str, String StrInicio)
        {
            int Ini;
            Ini = Str.IndexOf(StrInicio);
            if (Ini > 0)
            {
                Ini = Ini + StrInicio.Length;
                return Str.Substring(Ini);
            }
            else
                return Str;
        }

        public string StringPrimeiraLetraMaiuscula(String Str)
        {
            string StrResult = "";
            if (Str.Length > 0)
            {
                StrResult += Str.Substring(0, 1).ToUpper();
                StrResult += Str.Substring(1, Str.Length - 1).ToLower();
            }
            return StrResult;
        }

        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Se a tecla digitada não for número
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }
        }

        private void txtBairroNumeroFornecedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Se a tecla digitada não for número
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }

        }

        private void txtCnpjConsulta_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Se a tecla digitada não for número
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }
            if (e.KeyChar == 13)
            {
                ConsultaCnpj();
            }
        }

        private void buttonCnpjManual_Click(object sender, EventArgs e)
        {
            
            AlteraBotoes(10);
            AlteraBotoesCnpj(1);
            SiteOFF = 1;
            maskedTextBoxCep.Enabled = true;
        }

        private void buttonCnpjAutomatico_Click(object sender, EventArgs e)
        {
            try
            {
                carregarCaptcha();
            }
            catch (Exception es)
            {
                es.ToString();
            }
            //AlteraBotoesCnpj(2);
            //if(SiteOFF == 1)
            //{
            //    AlteraBotoesCnpj(1);
            //}
        }

        private void txtLetrasConulta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                ConsultaCnpj();
            }
        }

        private void FormFornecedores_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
            {
                this.Close();
            }
        }

        private void buttonTrocaImagem_Click_1(object sender, EventArgs e)
        {
            carregarCaptcha();
        }
    }
}
            