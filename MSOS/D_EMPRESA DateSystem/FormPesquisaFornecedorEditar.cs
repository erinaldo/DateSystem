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
    public partial class FormPesquisaFornecedorEditar : Form
    {
        string OPERACAO = "";
        private int ID_PESSOA = 0;
        public int IdPessoa
        {
            get
            {
                return this.ID_PESSOA;

            }
            set
            {
                this.ID_PESSOA = value;
            }
        }
        private int ID_PESSOA_TIPO = 0;
        public int IdPessoaTipo
        {
            get
            {
                return this.ID_PESSOA_TIPO;

            }
            set
            {
                this.ID_PESSOA_TIPO = value;
            }
        }
        private int STATUS = 0;
        public int status
        {
            get
            {
                return this.STATUS;

            }
            set
            {
                this.STATUS = value;
            }
        }
        private int FORNECEDOREDITAR = 0;
        public int FornecedorEditar
        {
            get
            {
                return this.FORNECEDOREDITAR;

            }
            set
            {
                this.FORNECEDOREDITAR = value;
            }
        }
        private int FORNECEDOREXCLUIR = 0;
        public int FornecedorExcluir
        {
            get
            {
                return this.FORNECEDOREXCLUIR;

            }
            set
            {
                this.FORNECEDOREXCLUIR = value;
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


        // VALIDAR ENTRADA COM ERROPROVIDER
        private Boolean validaNome(TextBox textBox, ErrorProvider errorProvider)
        {
            if (!String.IsNullOrWhiteSpace(txtNomeFornecedor.Text))
            {
                errorProviderFornecedor.SetError(textBox, "");
                return true;
            }
            else
            {
                errorProviderFornecedor.SetError(textBox, "Nome Inválido!");
                return false;
            }
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
            if (!String.IsNullOrWhiteSpace(txtCidade.Text))
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
        private Boolean validaNumero(TextBox textBox, ErrorProvider errorProvider)
        {
            if (!String.IsNullOrWhiteSpace(txtBairroFornecedor.Text))
            {
                errorProviderFornecedor.SetError(textBox, "");
                return true;
            }
            else
            {
                errorProviderFornecedor.SetError(textBox, "Numero Inválido!");
                return false;
            }
        }
        // VALIDAR ENTRADA COM ERROPROVIDER
        private Boolean validaCnpj(TextBox textBox, ErrorProvider errorProvider)
        {
            if (!String.IsNullOrWhiteSpace(txtCnpJTextBox.Text))
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
            if (!String.IsNullOrWhiteSpace(txtiNSCRICAO_STADUALTextBox.Text))
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
            if (!String.IsNullOrWhiteSpace(txtrAZAO_SOCIALTextBox.Text))
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
            if (!String.IsNullOrWhiteSpace(txtnOME_CONTATOTextBox.Text))
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
            return ((comboBoxSexoPFIsica.SelectedItem != null) &&
                (!comboBoxSexoPFIsica.SelectedItem.ToString().Equals("")));//none
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
            if (!String.IsNullOrWhiteSpace(txtCpfPFisica.Text))
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
            if (!String.IsNullOrWhiteSpace(txtCelularPFisica.Text))
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
            if (!String.IsNullOrWhiteSpace(txtCelularPFisica2.Text))
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
        public FormPesquisaFornecedorEditar(string NomeServidor, string NomeBaseDados, string NomeUsuario, string SenhaBaseDados)
        {
            InitializeComponent();

            this.NomeServidor = NomeServidor;
            this.NomeBaseDados = NomeBaseDados;
            this.NomeUsuario = NomeUsuario;
            this.SenhaBaseDados = SenhaBaseDados;

            this.connetionString = "Data Source=" + this.NomeServidor + ";Initial Catalog=" + this.NomeBaseDados + ";Persist Security Info=True;User ID=" + this.NomeUsuario + ";Password=" + this.SenhaBaseDados + ";";

        }
        private void FormPesquisaFornecedorEditar_Load(object sender, EventArgs e)
        {

        }
        public static void CancelaPesquisaFormulario(Type frmType)
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
            CancelaPesquisaFormulario(typeof(FormPesquisaFornecedorEditar));
        }
        public FormPesquisaFornecedorEditar(int idPessoa,int FORNECEDOREDITAR,int FORNECEDOREXCLUIR,
            string NomeServidor, string NomeBaseDados, string NomeUsuario, string SenhaBaseDados)
        {
            InitializeComponent();

            this.NomeServidor = NomeServidor;
            this.NomeBaseDados = NomeBaseDados;
            this.NomeUsuario = NomeUsuario;
            this.SenhaBaseDados = SenhaBaseDados;

            this.connetionString = "Data Source=" + this.NomeServidor + ";Initial Catalog=" + this.NomeBaseDados + ";Persist Security Info=True;User ID=" + this.NomeUsuario + ";Password=" + this.SenhaBaseDados + ";";


            txtNomeFornecedor.MaxLength = 50;

            txtCargoContatoFornecedor.MaxLength = 20;

            txtNomeContatoFornecedor.MaxLength = 30;

            txtTipo_logradouro.MaxLength = 25;

            txtEnderecoFornecedor.MaxLength = 40;


            txtBairroNumeroFornecedor.MaxLength = 9;

            txtComplFornecedor.MaxLength = 40;

            txtBairroFornecedor.MaxLength = 40;


            txtCidade.MaxLength = 40;

            txtSiglaCidadeFornecedor.MaxLength = 4;

            txtEmailFornecedor.MaxLength = 40;

            txtTipoFornecedor.MaxLength = 20;

            txtCpMunicipioFornecedor.MaxLength = 20;

            txtMunicipioFornecedor.MaxLength = 20;

            txtPaisFornecedor.MaxLength = 19;

            txtDesPaisFornecedor.MaxLength = 20;

            txtObservacaoFornecedor.MaxLength = 40;

            txtCnpJTextBox.MaxLength = 14;

            txtrAZAO_SOCIALTextBox.MaxLength = 40;

            txtiNSCRICAO_STADUALTextBox.MaxLength = 20;

            txtnOME_CONTATOTextBox.MaxLength = 20;


            txtNomePFisica.MaxLength = 50;

            comboBoxSexoPFIsica.MaxLength = 2;

            txtRgFisica.MaxLength = 9;

            this.FornecedorEditar = FORNECEDOREDITAR;
            this.FornecedorExcluir = FORNECEDOREXCLUIR;
            if (FornecedorEditar == 0)
            {
                buttonEditar.Enabled = false;
            }
            if (FornecedorEditar == 1)
            {
                buttonEditar.Enabled = true;
            }
            if (FornecedorExcluir == 0)
            {
                buttonExcluirFornecedor.Enabled = false;
            }
            if (FornecedorExcluir == 1)
            {
                buttonExcluirFornecedor.Enabled = true;
            }

            //IdPessoa = Convert.ToInt32(dataGridViewPesquisaCliente["ID_PESSOA", e.RowIndex].Value);
            ////id = Convert.ToInt32(dataGridViewPesquisa.CurrentRow.Cells[0].Value.ToString());
            ////id = Convert.ToInt32(dataGridViewPesquisa.Rows[e.RowIndex].Cells["ORDEM_SERVIÇO"].Value.ToString());

            SqlConnection conn1 = new SqlConnection(this.connetionString);
            string sql1 = "exec D_ConsultaFornecedorEditarTxt " + idPessoa;
            SqlDataAdapter sda1 = new SqlDataAdapter(sql1, conn1);
            DataSet ds1 = new DataSet();
            sda1.Fill(ds1);

            this.IdPessoa = idPessoa;
            IdPessoaTipo = int.Parse(ds1.Tables[0].Rows[0][1].ToString());
            status = int.Parse(ds1.Tables[0].Rows[0][2].ToString());

            if (IdPessoaTipo == 1)
            {
                //Cliente Fisico 
                txtNomePFisica.Text = ds1.Tables[0].Rows[0][16].ToString();
                comboBoxSexoPFIsica.Text = ds1.Tables[0].Rows[0][17].ToString();
                txtCpfPFisica.Text = ds1.Tables[0].Rows[0][18].ToString();
                txtRgFisica.Text = ds1.Tables[0].Rows[0][19].ToString();
                txtCelularPFisica.Text = ds1.Tables[0].Rows[0][21].ToString();
                txtCelularPFisica2.Text = ds1.Tables[0].Rows[0][22].ToString();
                txtDataNascimento.Text = ds1.Tables[0].Rows[0][20].ToString();

                
                txtNomeFornecedor.Text = ds1.Tables[0].Rows[0][3].ToString();
                txtTelefoneFornecedor.Text = ds1.Tables[0].Rows[0][4].ToString();
                txtTelefone2Fornecedor.Text = ds1.Tables[0].Rows[0][5].ToString();
                txtFaxTelefoneFornecedor.Text = ds1.Tables[0].Rows[0][6].ToString();
                txtTelexTelefoneFornecedor.Text = ds1.Tables[0].Rows[0][7].ToString();
                txtEmailFornecedor.Text = ds1.Tables[0].Rows[0][8].ToString();
                txtObservacaoFornecedor.Text = ds1.Tables[0].Rows[0][9].ToString();
                txtCepFornecedor.Text = ds1.Tables[0].Rows[0][29].ToString();
                txtTipo_logradouro.Text = ds1.Tables[0].Rows[0][30].ToString();
                txtEnderecoFornecedor.Text = ds1.Tables[0].Rows[0][31].ToString();
                txtBairroNumeroFornecedor.Text = ds1.Tables[0].Rows[0][32].ToString();
                txtComplFornecedor.Text = ds1.Tables[0].Rows[0][33].ToString();
                txtBairroFornecedor.Text = ds1.Tables[0].Rows[0][34].ToString();
                txtCidade.Text = ds1.Tables[0].Rows[0][35].ToString();
                txtSiglaCidadeFornecedor.Text = ds1.Tables[0].Rows[0][36].ToString();
                txtCpMunicipioFornecedor.Text = ds1.Tables[0].Rows[0][11].ToString();
                txtMunicipioFornecedor.Text = ds1.Tables[0].Rows[0][12].ToString();
                txtPaisFornecedor.Text = ds1.Tables[0].Rows[0][13].ToString();
                txtDesPaisFornecedor.Text = ds1.Tables[0].Rows[0][14].ToString();
                txtTipoFornecedor.Text = ds1.Tables[0].Rows[0][10].ToString();

                maskedTextBoxCep.Text = ds1.Tables[0].Rows[0][37].ToString();
                txtEndereco.Text = ds1.Tables[0].Rows[0][38].ToString();
                txtNumero.Text = ds1.Tables[0].Rows[0][39].ToString();
                txtcomplemento.Text = ds1.Tables[0].Rows[0][40].ToString();
                txtBairro.Text = ds1.Tables[0].Rows[0][41].ToString();
                txtCidade.Text = ds1.Tables[0].Rows[0][42].ToString();

                txtCargoContatoFornecedor.Text = ds1.Tables[0].Rows[0][45].ToString();
                txtNomeContatoFornecedor.Text = ds1.Tables[0].Rows[0][44].ToString();
                if (status == 1)
                {
                    checkBoxClienteSituacao.Checked = true;
                }

                panelJuridico.Enabled = false;
                txtNomePFisica.Enabled = false;
                comboBoxSexoPFIsica.Enabled = false;
                txtCpfPFisica.Enabled = false;
                txtRgFisica.Enabled = false;
                txtDataNascimento.Enabled = false;
            }
            if (IdPessoaTipo == 2)
            {
                //Cliente Juridica
                txtrAZAO_SOCIALTextBox.Text = ds1.Tables[0].Rows[0][24].ToString();
                txtCnpJTextBox.Text = ds1.Tables[0].Rows[0][25].ToString();
                txtiNSCRICAO_STADUALTextBox.Text = ds1.Tables[0].Rows[0][26].ToString();
                txtnOME_CONTATOTextBox.Text = ds1.Tables[0].Rows[0][27].ToString();


                txtNomeFornecedor.Text = ds1.Tables[0].Rows[0][3].ToString();
                txtTelefoneFornecedor.Text = ds1.Tables[0].Rows[0][4].ToString();
                txtTelefone2Fornecedor.Text = ds1.Tables[0].Rows[0][5].ToString();
                txtFaxTelefoneFornecedor.Text = ds1.Tables[0].Rows[0][6].ToString();
                txtTelexTelefoneFornecedor.Text = ds1.Tables[0].Rows[0][7].ToString();
                txtEmailFornecedor.Text = ds1.Tables[0].Rows[0][8].ToString();
                txtObservacaoFornecedor.Text = ds1.Tables[0].Rows[0][9].ToString();
                txtCepFornecedor.Text = ds1.Tables[0].Rows[0][29].ToString();
                txtTipo_logradouro.Text = ds1.Tables[0].Rows[0][30].ToString();
                txtEnderecoFornecedor.Text = ds1.Tables[0].Rows[0][31].ToString();
                txtBairroNumeroFornecedor.Text = ds1.Tables[0].Rows[0][32].ToString();
                txtComplFornecedor.Text = ds1.Tables[0].Rows[0][33].ToString();
                txtBairroFornecedor.Text = ds1.Tables[0].Rows[0][34].ToString();
                txtCidade.Text = ds1.Tables[0].Rows[0][35].ToString();
                txtSiglaCidadeFornecedor.Text = ds1.Tables[0].Rows[0][36].ToString();
                txtCpMunicipioFornecedor.Text = ds1.Tables[0].Rows[0][11].ToString();
                txtMunicipioFornecedor.Text = ds1.Tables[0].Rows[0][12].ToString();
                txtPaisFornecedor.Text = ds1.Tables[0].Rows[0][13].ToString();
                txtDesPaisFornecedor.Text = ds1.Tables[0].Rows[0][14].ToString();
                txtTipoFornecedor.Text = ds1.Tables[0].Rows[0][10].ToString();

                maskedTextBoxCep.Text = ds1.Tables[0].Rows[0][37].ToString();
                txtEndereco.Text = ds1.Tables[0].Rows[0][38].ToString();
                txtNumero.Text = ds1.Tables[0].Rows[0][39].ToString();
                txtcomplemento.Text = ds1.Tables[0].Rows[0][40].ToString();
                txtBairro.Text = ds1.Tables[0].Rows[0][41].ToString();
                txtCidade.Text = ds1.Tables[0].Rows[0][42].ToString();

                txtCargoContatoFornecedor.Text = ds1.Tables[0].Rows[0][45].ToString();
                txtNomeContatoFornecedor.Text = ds1.Tables[0].Rows[0][44].ToString();

                if (status == 1)
                {
                    checkBoxClienteSituacao.Checked = true;
                }
                panelFisica.Enabled = false;
                txtCnpJTextBox.Enabled = false;
                txtrAZAO_SOCIALTextBox.Enabled = false;
                txtiNSCRICAO_STADUALTextBox.Enabled = false;
                txtnOME_CONTATOTextBox.Enabled = true;
            }
        }
        //Metodo que altera Botões e outras funções
        public void AlteraBotoes(int op)
        {
            if (op == 1)// Cadastra Cliente
            {
                panelCadastraFornecedor.Enabled = true;

                buttonVerificarFornecedor.Enabled = true;
                buttonExcluirFornecedor.Enabled = false;
                buttonFecharFornecedor.Enabled = true;
            }
            if (op == 2)//salvar Cadastro de Cliente
            {
                panelCadastraFornecedor.Enabled = false;

                buttonVerificarFornecedor.Enabled = false;
                buttonExcluirFornecedor.Enabled = false;
                buttonFecharFornecedor.Enabled = true;

            }
            if (op == 3)//Calcelar Cadastro de Cliente
            {
                panelCadastraFornecedor.Enabled = false;

                buttonVerificarFornecedor.Enabled = false;
                buttonExcluirFornecedor.Enabled = false;
                buttonFecharFornecedor.Enabled = true;

            }
            if (op == 4) //  Editar Cadastro de Cliente
            {
                panelCadastraFornecedor.Enabled = true;


                buttonVerificarFornecedor.Enabled = true;
                buttonExcluirFornecedor.Enabled = false;
                buttonFecharFornecedor.Enabled = true;
                tabControlFisicaJuridica.Enabled = true;

                txtNomeFornecedor.Enabled = false;
                ButtonBuscaCep.Enabled = false;
                txtTipo_logradouro.Enabled = false;
                txtEnderecoFornecedor.Enabled = false;
                txtBairroFornecedor.Enabled = false;
                txtCidade.Enabled = false;
                txtSiglaCidadeFornecedor.Enabled = false;
                txtCepFornecedor.Enabled = false;

                buttonEditar.Enabled = false;

            }
            if (op == 5)//Cancela Pesquisa
            {

                radioButtonOculto.Checked = true;

            }
            if (op == 6)//Cadastro de Cliente Inicializado
            {
                buttonVerificarFornecedor.Enabled = true;
                buttonExcluirFornecedor.Enabled = true;
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
                buttonVerificarFornecedor.Enabled = false;
                buttonExcluirFornecedor.Enabled = false;
                buttonFecharFornecedor.Enabled = false;
            }
            if (op == 9)//Libera Pesquisa Por MS e Nome.
            {
                //buttonPesquisaFornecedor.Enabled = true;
                //buttonEditarCliente.Enabled = true;
            }
            if (op == 10)
            {
                txtNomeContatoFornecedor.Clear();
                txtCargoContatoFornecedor.Clear();
                txtNomeFornecedor.Clear();
                txtEnderecoFornecedor.Clear();
                txtTelefoneFornecedor.Clear();
                txtTelefone2Fornecedor.Clear();
                txtFaxTelefoneFornecedor.Clear();
                txtTelexTelefoneFornecedor.Clear();
                txtEmailFornecedor.Clear();
                txtObservacaoFornecedor.Clear();
                txtCepFornecedor.Clear();
                txtTipoFornecedor.Clear();
                txtBairroFornecedor.Clear();
                txtComplFornecedor.Clear();
                txtBairroNumeroFornecedor.Clear();
                txtCidade.Clear();
                txtSiglaCidadeFornecedor.Clear();
                txtMunicipioFornecedor.Clear();
                txtCpMunicipioFornecedor.Clear();
                txtPaisFornecedor.Clear();
                txtDesPaisFornecedor.Clear();
                txtTipo_logradouro.Clear();

            }
            if (op == 11)
            {
                //Pessoa Fisica
                txtNomePFisica.Enabled = true;
                comboBoxSexoPFIsica.Enabled = true;
                txtCpfPFisica.Enabled = true;
                txtRgFisica.Enabled = true;
                txtDataNascimento.Enabled = true;
                txtCelularPFisica.Enabled = true;
                txtCelularPFisica2.Enabled = true;

                txtCpfPFisica.Enabled = false;
                txtrAZAO_SOCIALTextBox.Enabled = false;
                txtiNSCRICAO_STADUALTextBox.Enabled = false;
                txtnOME_CONTATOTextBox.Enabled = false;


                txtCnpJTextBox.Clear();
                txtrAZAO_SOCIALTextBox.Clear();
                txtiNSCRICAO_STADUALTextBox.Clear();
                txtnOME_CONTATOTextBox.Clear();


            }
            if (op == 12)
            {
                //Pessoa Juridica

                txtCnpJTextBox.Enabled = true;
                txtrAZAO_SOCIALTextBox.Enabled = true;
                txtiNSCRICAO_STADUALTextBox.Enabled = true;
                txtnOME_CONTATOTextBox.Enabled = true;

                txtNomePFisica.Enabled = false;
                comboBoxSexoPFIsica.Enabled = false;
                txtCpfPFisica.Enabled = false;
                txtRgFisica.Enabled = false;
                txtDataNascimento.Enabled = false;
                txtCelularPFisica.Enabled = false;
                txtCelularPFisica2.Enabled = false;

                txtNomePFisica.Clear();

                txtCpfPFisica.Clear();
                txtRgFisica.Clear();

                txtCelularPFisica.Clear();
                txtCelularPFisica2.Clear();
            }
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            if (FornecedorEditar == 0)
            {
                MessageBox.Show("Acesso não Permitido!");
            }
            if (FornecedorEditar == 1)
            {
                this.OPERACAO = "Editar";
                AlteraBotoes(4);
            }
        }

        private void buttonVerificarFornecedor_Click_1(object sender, EventArgs e)
        {
            //-------------------------EDITAR CADASTRATO---------------------------------------------------------------------------------------------------------------------------------------------------------------
            if ((validaNome(txtNomeFornecedor, errorProviderFornecedor) == true) &&(validaNumero(txtBairroNumeroFornecedor, errorProviderFornecedor) == true))//&& ((labelConfirmacao.Text).Equals("sucesso - cep completo")))
                //(labelConfirmacao.Text).Equals("sucesso - cep completo"))
            {
                try
                {
                    Conexao conexao = new Conexao(this.connetionString);
                    DALDateSystem dal = new DALDateSystem(conexao);

                    Pessoa cadastra = new Pessoa();

                    cadastra.idPessoa = this.IdPessoa;
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

                    Fornecedor Fornecedor = new Fornecedor();
                    Fornecedor.idFornecedor = this.IdPessoa;
                    Fornecedor.NomeContato = txtNomeContatoFornecedor.Text;
                    Fornecedor.CargoContato = txtCargoContatoFornecedor.Text;



                    if (checkBoxClienteSituacao.Checked == true)
                    {
                        cadastra.Situacao = 1;
                    }
                    else if (checkBoxClienteSituacao.Checked == false)
                    {
                        cadastra.Situacao = 2;
                    }



                    if (this.OPERACAO == "Editar")
                    {
                        buttonVerificarFornecedor.Enabled = false;

                        dal.Alterar(cadastra);

                        if (IdPessoaTipo == 1)
                        {
                            Conexao conexao2 = new Conexao(this.connetionString);
                            DALDateSystem dal2 = new DALDateSystem(conexao2);

                            FornecedorFisica FornecedorFisica = new FornecedorFisica();
                            FornecedorFisica.idFornecedorFisica = this.IdPessoa;
                            FornecedorFisica.Celular = txtCelularPFisica.Text;
                            FornecedorFisica.Celular2 = txtCelularPFisica2.Text;
                            dal2.AlterarFornecedorFIsica(FornecedorFisica);
                        }
                        if (IdPessoaTipo == 2)
                        {
                            Conexao conexao3 = new Conexao(this.connetionString);
                            DALDateSystem dal3 = new DALDateSystem(conexao3);

                            FornecedorJuridica FornecedorJuridica = new FornecedorJuridica();
                            FornecedorJuridica.idFornecedorJuridica = this.IdPessoa;
                            FornecedorJuridica.NomeContato = txtnOME_CONTATOTextBox.Text;

                            dal3.AlterarFornecedorJuridica(FornecedorJuridica);
                        }

                        FecharTodosFormulario();

                        MessageBox.Show("As alterações no Cadastrado do Fornecedor Foram Salvas!");


                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void radioButtonFornecedorFisica_CheckedChanged(object sender, EventArgs e)
        {
            AlteraBotoes(11);
        }

        private void radioButtonFornecedorJuridica_CheckedChanged(object sender, EventArgs e)
        {
            AlteraBotoes(12);
        }

        private void buttonExcluirFornecedor_Click_1(object sender, EventArgs e)
        {
            if (FornecedorExcluir == 0)
            {
                MessageBox.Show("Acesso não Permitido!");
            }
            if (FornecedorExcluir == 1)
            {
                DialogResult d = MessageBox.Show("Deseja Excluir o registro?", "Aviso", MessageBoxButtons.YesNo);

                Conexao conexao = new Conexao(this.connetionString);
                DALDateSystem dal = new DALDateSystem(conexao);

                if (d.ToString() == "Yes")
                {
                    if (this.IdPessoaTipo == 1)
                    {
                        dal.ExcluirFornecedorFisico(IdPessoa);

                        FecharTodosFormulario();

                        FormFornecedores Fornecedor = new FormFornecedores(this.NomeServidor, this.NomeBaseDados, this.NomeUsuario, this.SenhaBaseDados);
                        Fornecedor.MdiParent = FormFornecedores.ActiveForm;
                        Fornecedor.Show();
                        Fornecedor.Top = 0;
                        Fornecedor.Left = 0;
                    }
                    if (this.IdPessoaTipo == 2)
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
        }

        private void buttonCancelarFornecedor_Click(object sender, EventArgs e)
        {
            FecharTodosFormulario();
        }

        private void buttonFecharFornecedor_Click(object sender, EventArgs e)
        {
            FecharTodosFormulario();
        }

        private void FormPesquisaFornecedorEditar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
            {
                this.Close();
            }
        }
    }
}
