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
    public partial class FormPesquisaClientesRegistroEditar : Form
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
        private int CLIENTEEDITAR = 0;
        public int ClienteEditar
        {
            get
            {
                return this.CLIENTEEDITAR;

            }
            set
            {
                this.CLIENTEEDITAR = value;
            }
        }
        private int CLIENTEEXCLUIR = 0;
        public int ClienteExcluir
        {
            get
            {
                return this.CLIENTEEXCLUIR;

            }
            set
            {
                this.CLIENTEEXCLUIR = value;
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
            if (!String.IsNullOrWhiteSpace(txtNomeCliente.Text))
            {
                errorProviderEditarCliente.SetError(textBox, "");
                return true;
            }
            else
            {
                errorProviderEditarCliente.SetError(textBox, "Nome Inválido!");
                return false;
            }

        }
        // VALIDAR ENTRADA COM ERROPROVIDER
        private Boolean validaMs(TextBox textBox, ErrorProvider errorProvider)
        {
            if (!String.IsNullOrWhiteSpace(txtNumeroCliente.Text))
            {
                errorProviderEditarCliente.SetError(textBox, "");
                return true;
            }
            else
            {
                errorProviderEditarCliente.SetError(textBox, "MS Inválido!");
                return false;
            }
        }
        // VALIDAR ENTRADA COM ERROPROVIDER
        private Boolean validaEndereco(TextBox textBox, ErrorProvider errorProvider)
        {
            if (!String.IsNullOrWhiteSpace(txtEnderecoCliente.Text))
            {
                errorProviderEditarCliente.SetError(textBox, "");
                return true;
            }
            else
            {
                errorProviderEditarCliente.SetError(textBox, "Endereço Inválido!");
                return false;
            }
        }
        // VALIDAR ENTRADA COM ERROPROVIDER
        private Boolean validaTelefone(TextBox textBox, ErrorProvider errorProvider)
        {
            if (!String.IsNullOrWhiteSpace(txtTelefoneCliente.Text))
            {
                errorProviderEditarCliente.SetError(textBox, "");
                return true;
            }
            else
            {
                errorProviderEditarCliente.SetError(textBox, "Telefone Inválido!");
                return false;
            }
        }
        // VALIDAR ENTRADA COM ERROPROVIDER
        private Boolean validaBairro(TextBox textBox, ErrorProvider errorProvider)
        {
            if (!String.IsNullOrWhiteSpace(txtBairroCliente.Text))
            {
                errorProviderEditarCliente.SetError(textBox, "");
                return true;
            }
            else
            {
                errorProviderEditarCliente.SetError(textBox, "Bairro Inválido!");
                return false;
            }
        }
        // VALIDAR ENTRADA COM ERROPROVIDER
        private Boolean validaCep(MaskedTextBox textBox, ErrorProvider errorProvider)
        {
            if (!String.IsNullOrWhiteSpace(txtCepCliente.Text))
            {
                errorProviderEditarCliente.SetError(textBox, "");
                return true;
            }
            else
            {
                errorProviderEditarCliente.SetError(textBox, "Cep Inválido!");
                return false;
            }
        }
        // VALIDAR ENTRADA COM ERROPROVIDER
        private Boolean validaCidade(TextBox textBox, ErrorProvider errorProvider)
        {
            if (!String.IsNullOrWhiteSpace(txtCidadeCliente.Text))
            {
                errorProviderEditarCliente.SetError(textBox, "");
                return true;
            }
            else
            {
                errorProviderEditarCliente.SetError(textBox, "Cidade Inválido!");
                return false;
            }
        }
        // VALIDAR ENTRADA COM ERROPROVIDER
        private Boolean validaEmail(TextBox textBox, ErrorProvider errorProvider)
        {
            string email = txtEmailCliente.Text;
            string modelo = @"[\w\.-]+(\+[\w-]*)?@([\w-]+\.)+[\w-]+";

            if (Regex.IsMatch(email, modelo))
            {
                errorProviderEditarCliente.SetError(textBox, "");
                return true;
            }
            else
            {
                errorProviderEditarCliente.SetError(textBox, "E-mail Inválido!");
                return false;
            }
        }
        private Boolean validaNumero(TextBox textBox, ErrorProvider errorProvider)
        {
            if (!String.IsNullOrWhiteSpace(txtBairroNumero.Text))
            {
                errorProviderEditarCliente.SetError(textBox, "");
                return true;
            }
            else
            {
                errorProviderEditarCliente.SetError(textBox, "Numero Inválido!");
                return false;
            }
        }
        private void FormPesquisaClientesEditar_Load(object sender, EventArgs e)
        {
        }
        public FormPesquisaClientesRegistroEditar(string NomeServidor, string NomeBaseDados, string NomeUsuario, string SenhaBaseDados)
        {
            InitializeComponent();

            this.NomeServidor = NomeServidor;
            this.NomeBaseDados = NomeBaseDados;
            this.NomeUsuario = NomeUsuario;
            this.SenhaBaseDados = SenhaBaseDados;

            this.connetionString = "Data Source=" + this.NomeServidor + ";Initial Catalog=" + this.NomeBaseDados + ";Persist Security Info=True;User ID=" + this.NomeUsuario + ";Password=" + this.SenhaBaseDados + ";";

        }
        public static void CancelaPesquisaCliente(Type frmType)
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
            CancelaPesquisaCliente(typeof(FormPesquisaClientesRegistroEditar));
        }
        public void FecharCadastroCliente()
        {
            CancelaPesquisaCliente(typeof(FormPesquisaClientesRegistroEditar));
        }
        public FormPesquisaClientesRegistroEditar(int idPessoa, int CLIENTEEDITAR, int CLIENTEEXCLUIR, string NomeServidor, string NomeBaseDados, string NomeUsuario, string SenhaBaseDados)
        {
            InitializeComponent();

            this.NomeServidor = NomeServidor;
            this.NomeBaseDados = NomeBaseDados;
            this.NomeUsuario = NomeUsuario;
            this.SenhaBaseDados = SenhaBaseDados;

            this.connetionString = "Data Source=" + this.NomeServidor + ";Initial Catalog=" + this.NomeBaseDados + ";Persist Security Info=True;User ID=" + this.NomeUsuario + ";Password=" + this.SenhaBaseDados + ";";

            txtNomeCliente.MaxLength = 100;

            txtNumeroCliente.MaxLength = 9;

            txtEnderecoCliente.MaxLength = 40;

            txtBairroNumero.MaxLength = 9;

            txtComplCliente.MaxLength = 40;

            txtBairroCliente.MaxLength = 40;

            txtCidadeCliente.MaxLength = 40;

            txtEmailCliente.MaxLength = 40;

            txtTipoCliente.MaxLength = 20;

            txtCpMunicipalCliente.MaxLength = 20;

            txtMunicipioCliente.MaxLength = 20;

            txtPaisCliente.MaxLength = 19;

            txtDescPaisCliente.MaxLength = 20;

            txtObservacaoCliente.MaxLength = 40;

            txtCnpJTextBox.MaxLength = 14;

            txtrAZAO_SOCIALTextBox.MaxLength = 150;

            txtiNSCRICAO_STADUALTextBox.MaxLength = 150;

            txtnOME_CONTATOTextBox.MaxLength = 20;

            txtCnae.MaxLength = 150;
            
            txtNomePFisica.MaxLength = 50;

            comboBoxSexoPFIsica.MaxLength = 2;

            txtRgFisica.MaxLength = 9;

            this.ClienteEditar = CLIENTEEDITAR;
            this.ClienteExcluir = CLIENTEEXCLUIR;

            if (ClienteEditar == 0)
            {
                buttonEditarCliente.Enabled = false;
            }
            if (ClienteEditar == 1)
            {
                buttonEditarCliente.Enabled = true;
            }
            if (ClienteExcluir == 0)
            {
                buttonExcluirCliente.Enabled = false;
            }
            if (ClienteExcluir == 1)
            {
                buttonExcluirCliente.Enabled = true;
            }

            SqlConnection conn1 = new SqlConnection(this.connetionString);
            string sql1 = "exec D_R_ConsultaClienteRegistroEditarTxt " + idPessoa;
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

                txtNumeroCliente.Text = ds1.Tables[0].Rows[0][0].ToString();

                txtNomeCliente.Text = ds1.Tables[0].Rows[0][3].ToString();
                txtTelefoneCliente.Text = ds1.Tables[0].Rows[0][4].ToString();
                txtTelefone2Cliente.Text = ds1.Tables[0].Rows[0][5].ToString();
                txtFaxTelefoneCliente.Text = ds1.Tables[0].Rows[0][6].ToString();
                txtTelexTelefoneCliente.Text = ds1.Tables[0].Rows[0][7].ToString();
                txtEmailCliente.Text = ds1.Tables[0].Rows[0][8].ToString();
                txtObservacaoCliente.Text = ds1.Tables[0].Rows[0][9].ToString();

                maskedTextBoxCepSec.Text = ds1.Tables[0].Rows[0][29].ToString();
                //txtLogradouroSec.Text = ds1.Tables[0].Rows[0][31].ToString();
                txtEnderecoSec.Text = ds1.Tables[0].Rows[0][31].ToString();
                txtNumeroSec.Text = ds1.Tables[0].Rows[0][32].ToString();
                txtComplementoSec.Text = ds1.Tables[0].Rows[0][33].ToString();
                txtBairroSec.Text = ds1.Tables[0].Rows[0][34].ToString();
                txtCidadeSec.Text = ds1.Tables[0].Rows[0][35].ToString();
                //txtSiglaCiadadeSec.Text = ds1.Tables[0].Rows[0][37].ToString();
                txtCpMunicipalCliente.Text = ds1.Tables[0].Rows[0][11].ToString();
                txtMunicipioCliente.Text = ds1.Tables[0].Rows[0][12].ToString();
                txtPaisCliente.Text = ds1.Tables[0].Rows[0][13].ToString();
                txtDescPaisCliente.Text = ds1.Tables[0].Rows[0][14].ToString();
                txtTipoCliente.Text = ds1.Tables[0].Rows[0][10].ToString();

                //cep principal
                txtCepCliente.Text = ds1.Tables[0].Rows[0][37].ToString();
                //txtLogradouroSec.Text = ds1.Tables[0].Rows[0][38].ToString();
                txtEnderecoCliente.Text = ds1.Tables[0].Rows[0][38].ToString();
                txtBairroNumero.Text = ds1.Tables[0].Rows[0][39].ToString();
                txtComplCliente.Text = ds1.Tables[0].Rows[0][40].ToString();
                txtBairroCliente.Text = ds1.Tables[0].Rows[0][41].ToString();
                txtCidadeCliente.Text = ds1.Tables[0].Rows[0][42].ToString();


                if (status == 1)
                {
                    checkBoxClienteSituacao.Checked = true;
                }

            }
            if (IdPessoaTipo == 2)
            {
                //Cliente Juridica
                txtrAZAO_SOCIALTextBox.Text = ds1.Tables[0].Rows[0][24].ToString();
                txtCnpJTextBox.Text = ds1.Tables[0].Rows[0][25].ToString();
                txtnOME_CONTATOTextBox.Text = ds1.Tables[0].Rows[0][26].ToString();
                txtiNSCRICAO_STADUALTextBox.Text = ds1.Tables[0].Rows[0][27].ToString();
                txtCnae.Text = ds1.Tables[0].Rows[0][45].ToString();

                txtNumeroCliente.Text = ds1.Tables[0].Rows[0][0].ToString();

                txtNomeCliente.Text = ds1.Tables[0].Rows[0][3].ToString();
                txtTelefoneCliente.Text = ds1.Tables[0].Rows[0][4].ToString();
                txtTelefone2Cliente.Text = ds1.Tables[0].Rows[0][5].ToString();
                txtFaxTelefoneCliente.Text = ds1.Tables[0].Rows[0][6].ToString();
                txtTelexTelefoneCliente.Text = ds1.Tables[0].Rows[0][7].ToString();
                txtEmailCliente.Text = ds1.Tables[0].Rows[0][8].ToString();
                txtObservacaoCliente.Text = ds1.Tables[0].Rows[0][9].ToString();

                maskedTextBoxCepSec.Text = ds1.Tables[0].Rows[0][29].ToString();
                //txtLogradouroSec.Text = ds1.Tables[0].Rows[0][31].ToString();
                txtEnderecoSec.Text = ds1.Tables[0].Rows[0][31].ToString();
                txtNumeroSec.Text = ds1.Tables[0].Rows[0][32].ToString();
                txtComplementoSec.Text = ds1.Tables[0].Rows[0][33].ToString();
                txtBairroSec.Text = ds1.Tables[0].Rows[0][34].ToString();
                txtCidadeSec.Text = ds1.Tables[0].Rows[0][35].ToString();
                //txtSiglaCiadadeSec.Text = ds1.Tables[0].Rows[0][37].ToString();
                txtCpMunicipalCliente.Text = ds1.Tables[0].Rows[0][11].ToString();
                txtMunicipioCliente.Text = ds1.Tables[0].Rows[0][12].ToString();
                txtPaisCliente.Text = ds1.Tables[0].Rows[0][13].ToString();
                txtDescPaisCliente.Text = ds1.Tables[0].Rows[0][14].ToString();
                txtTipoCliente.Text = ds1.Tables[0].Rows[0][10].ToString();

                txtCepCliente.Text = ds1.Tables[0].Rows[0][37].ToString();
                //txtLogradouroSec.Text = ds1.Tables[0].Rows[0][38].ToString();
                txtEnderecoCliente.Text = ds1.Tables[0].Rows[0][38].ToString();
                txtBairroNumero.Text = ds1.Tables[0].Rows[0][39].ToString();
                txtComplCliente.Text = ds1.Tables[0].Rows[0][40].ToString();
                txtBairroCliente.Text = ds1.Tables[0].Rows[0][41].ToString();
                txtCidadeCliente.Text = ds1.Tables[0].Rows[0][42].ToString();

                if (status == 1)
                {
                    checkBoxClienteSituacao.Checked = true;
                }
            }
        }

        private void FormPesquisaClientesRegistroEditar_Load(object sender, EventArgs e)
        {

        }

        private void buttonEditarCliente_Click(object sender, EventArgs e)
        {
            if (ClienteEditar == 0)
            {
                MessageBox.Show("Acesso não Permitido!");
            }
            if (ClienteEditar == 1)
            {
                this.OPERACAO = "Editar";
                panelCadastroCliente.Enabled = true;
                tabControlFisicaJuridica.Enabled = true;
                buttonVerifica.Enabled = true;
                buttonEditarCliente.Enabled = false;

                if (IdPessoaTipo == 1)
                {
                    //Pessoa Fisica
                    panelJuridico.Enabled = false;
                    panelFisica.Enabled = true;

                    txtNomePFisica.Enabled = false;
                    comboBoxSexoPFIsica.Enabled = false;
                    txtCpfPFisica.Enabled = false;
                    txtRgFisica.Enabled = false;
                    txtCelularPFisica.Enabled = true;
                    txtCelularPFisica2.Enabled = true;
                    txtDataNascimento.Enabled = false;

                    panelJuridico.Enabled = false;
                    panelCadastroCliente.Enabled = true;
                    tabControlFisicaJuridica.Enabled = true;


                }
                if (IdPessoaTipo == 2)
                {
                    //Pessoa Juridica
                    panelJuridico.Enabled = true;
                    panelFisica.Enabled = false;

                    txtrAZAO_SOCIALTextBox.Enabled = false;
                    txtCnpJTextBox.Enabled = false;
                    txtnOME_CONTATOTextBox.Enabled = true;
                    txtiNSCRICAO_STADUALTextBox.Enabled = false;
                }
            }
        }

        private void buttonExcluirCliente_Click(object sender, EventArgs e)
        {
            if (ClienteExcluir == 0)
            {
                MessageBox.Show("Acesso não Permitido!");
            }
            if (ClienteExcluir == 1)
            {
                DialogResult d = MessageBox.Show("Deseja Excluir o registro?", "Aviso", MessageBoxButtons.YesNo);

                Conexao conexao = new Conexao(this.connetionString);
                DALDateSystem dal = new DALDateSystem(conexao);

                if (d.ToString() == "Yes")
                {
                    if (this.IdPessoaTipo == 1)
                    {

                        dal.ExcluirClienteFisico(IdPessoa);

                        FecharTodosFormulario();

                    }
                    if (this.IdPessoaTipo == 2)
                    {
                        dal.ExcluirClienteJuridica(IdPessoa);

                        FecharTodosFormulario();
                    }
                }
            }
        }

        private void buttonFecharCliente_Click(object sender, EventArgs e)
        {
            FecharCadastroCliente();
        }

        private void buttonVerifica_Click(object sender, EventArgs e)
        {
            SalvarAlteracaoClienteRegistro();
        }
        public void SalvarAlteracaoClienteRegistro()
        {
            //-------------------------EDITAR CADASTRATO---------------------------------------------------------------------------------------------------------------------------------------------------------------
            if ((validaNome(txtNomeCliente, errorProviderEditarCliente) == true) && (validaMs(txtNumeroCliente, errorProviderEditarCliente) == true) &&
                    (validaNumero(txtBairroNumero, errorProviderEditarCliente) == true))
            {
                try
                {
                    Conexao conexao = new Conexao(this.connetionString);
                    DALDateSystem dal = new DALDateSystem(conexao);

                    Pessoa cadastra = new Pessoa();

                    cadastra.idPessoa = this.IdPessoa;
                    cadastra.Nome = txtNomeCliente.Text;
                    cadastra.Telefone = txtTelefoneCliente.Text;
                    cadastra.Telefone2 = txtTelefone2Cliente.Text;
                    cadastra.FaxTelefone = txtFaxTelefoneCliente.Text;
                    cadastra.TelexTelefone = txtTelexTelefoneCliente.Text;
                    cadastra.Email = txtEmailCliente.Text;
                    cadastra.Observacao = txtObservacaoCliente.Text;
                    cadastra.Tipo = txtTipoCliente.Text;
                    cadastra.CpMunicipio = txtCpMunicipalCliente.Text;
                    cadastra.Municipio = txtMunicipioCliente.Text;
                    cadastra.Pais = txtPaisCliente.Text;
                    cadastra.DesPais = txtDescPaisCliente.Text;
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
                        buttonVerifica.Enabled = false;

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
                        MessageBox.Show("As alterações no Cadastrado Cliente Registro Foram Salvas!");

                        FecharCadastroCliente();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro de acesso ao banco de Dados-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------. ", ex.Message);
                }
            }
        }

        private void FormPesquisaClientesRegistroEditar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
            {
                this.Close();
            }
        }
    }
}
