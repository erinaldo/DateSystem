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
    public partial class FormPesquisaFornecedorContatosEditar : Form
    {
        string OPERACAO = "";
        private int ID_PESSOACONTATO = 0;
        public int IdPessoaContato
        {
            get
            {
                return this.ID_PESSOACONTATO;

            }
            set
            {
                this.ID_PESSOACONTATO = value;
            }
        }
        private int FORNECEDORCEDITAR = 0;
        public int FornecedorCEditar
        {
            get
            {
                return this.FORNECEDORCEDITAR;

            }
            set
            {
                this.FORNECEDORCEDITAR = value;
            }
        }
        private int FORNECEDORCEXCLUIR = 0;
        public int FornecedorCExcluir
        {
            get
            {
                return this.FORNECEDORCEXCLUIR;

            }
            set
            {
                this.FORNECEDORCEXCLUIR = value;
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
            if (!String.IsNullOrWhiteSpace(txtNomeCContatos.Text))
            {
                errorProviderFornedorContatos.SetError(textBox, "");
                return true;
            }
            else
            {
                errorProviderFornedorContatos.SetError(textBox, "Nome Inválido!");
                return false;
            }

        }
        // VALIDAR ENTRADA COM ERROPROVIDER
        private Boolean validaAbreviacao(TextBox textBox, ErrorProvider errorProvider)
        {
            if (!String.IsNullOrWhiteSpace(txtAbreviacaoCContatos.Text))
            {
                errorProviderFornedorContatos.SetError(textBox, "");
                return true;
            }
            else
            {
                errorProviderFornedorContatos.SetError(textBox, "MS Inválido!");
                return false;
            }
        }
        // VALIDAR ENTRADA COM ERROPROVIDER
        private Boolean validaTelefone(TextBox textBox, ErrorProvider errorProvider)
        {
            if (!String.IsNullOrWhiteSpace(txtTelefoneCContatos.Text))
            {
                errorProviderFornedorContatos.SetError(textBox, "");
                return true;
            }
            else
            {
                errorProviderFornedorContatos.SetError(textBox, "Telefone Inválido!");
                return false;
            }
        }
        // VALIDAR ENTRADA COM ERROPROVIDER
        private Boolean validaEmail(TextBox textBox, ErrorProvider errorProvider)
        {
            string email = txtEmailCContatos.Text;
            string modelo = @"[\w\.-]+(\+[\w-]*)?@([\w-]+\.)+[\w-]+";

            if (Regex.IsMatch(email, modelo))
            {
                errorProviderFornedorContatos.SetError(textBox, "");
                return true;
            }
            else
            {
                errorProviderFornedorContatos.SetError(textBox, "E-mail Inválido!");
                return false;
            }
        }
        private void FormPesquisaClientesEditar_Load(object sender, EventArgs e)
        {
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
            CancelaPesquisaCliente(typeof(FormPesquisaFornecedorContatosEditar));
        }
        public void FecharCadastroCliente()
        {
            CancelaPesquisaCliente(typeof(FormPesquisaClientesEditar));
        }
        public FormPesquisaFornecedorContatosEditar(int idPessoaContato,int FORNECEDORCEDITAR,int FORNECEDORCEXCLUIR,
            string NomeServidor, string NomeBaseDados, string NomeUsuario, string SenhaBaseDados)
        {
            InitializeComponent();

            this.NomeServidor = NomeServidor;
            this.NomeBaseDados = NomeBaseDados;
            this.NomeUsuario = NomeUsuario;
            this.SenhaBaseDados = SenhaBaseDados;

            this.connetionString = "Data Source=" + this.NomeServidor + ";Initial Catalog=" + this.NomeBaseDados + ";Persist Security Info=True;User ID=" + this.NomeUsuario + ";Password=" + this.SenhaBaseDados + ";";


            txtNomeCContatos.MaxLength = 50;

            txtAbreviacaoCContatos.MaxLength = 20;

            txtEmailCContatos.MaxLength = 40;

            txtObservacaoCContatos.MaxLength = 40;

            this.FornecedorCEditar = FORNECEDORCEDITAR;
            this.FornecedorCExcluir = FORNECEDORCEXCLUIR;
            if (FornecedorCEditar == 0)
            {
                buttonEditarCContatos.Enabled = false;
            }
            if (FornecedorCEditar == 1)
            {
                buttonEditarCContatos.Enabled = true;
            }
            if (FornecedorCExcluir == 0)
            {
                buttonExcluirCContatos.Enabled = false;
            }
            if (FornecedorCExcluir == 1)
            {
                buttonExcluirCContatos.Enabled = true;
            }

            //IdPessoa = Convert.ToInt32(dataGridViewPesquisaCliente["ID_PESSOA", e.RowIndex].Value);
            ////id = Convert.ToInt32(dataGridViewPesquisa.CurrentRow.Cells[0].Value.ToString());
            ////id = Convert.ToInt32(dataGridViewPesquisa.Rows[e.RowIndex].Cells["ORDEM_SERVIÇO"].Value.ToString());

            SqlConnection conn1 = new SqlConnection(this.connetionString);
            string sql1 = "exec D_ConsultaFornecedorContatosEditarTxt " + idPessoaContato;
            SqlDataAdapter sda1 = new SqlDataAdapter(sql1, conn1);
            DataSet ds1 = new DataSet();
            sda1.Fill(ds1);

            int status = 0;
            this.IdPessoaContato = idPessoaContato;
            status = int.Parse(ds1.Tables[0].Rows[0][10].ToString());

            txtNomeCContatos.Text = ds1.Tables[0].Rows[0][2].ToString();
            txtAbreviacaoCContatos.Text = ds1.Tables[0].Rows[0][3].ToString();
            txtTelefoneCContatos.Text = ds1.Tables[0].Rows[0][4].ToString();
            txtTelefone2CContatos.Text = ds1.Tables[0].Rows[0][5].ToString();
            txtCelularCContatos.Text = ds1.Tables[0].Rows[0][6].ToString();
            txtCelular2CContatos.Text = ds1.Tables[0].Rows[0][7].ToString();
            txtEmailCContatos.Text = ds1.Tables[0].Rows[0][8].ToString();
            txtObservacaoCContatos.Text = ds1.Tables[0].Rows[0][9].ToString();


            if (status == 1)
            {
                checkBoxClienteSituacao.Checked = true;
            }
        }
        private void txtNomeCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonCancelarCliente_Click(object sender, EventArgs e)
        {
            FecharCadastroCliente();
            FormPesquisaClientesEditar cadastracliente = new FormPesquisaClientesEditar(this.NomeServidor, this.NomeBaseDados, this.NomeUsuario, this.SenhaBaseDados);
            cadastracliente.MdiParent = FormPesquisaClientesEditar.ActiveForm;
            cadastracliente.Show();
            cadastracliente.Top = 0;
            cadastracliente.Left = 0;
        }

        private void buttonFecharCliente_Click(object sender, EventArgs e)
        {
            FecharCadastroCliente();
        }
        public FormPesquisaFornecedorContatosEditar()
        {
            InitializeComponent();
        }

        private void FormPesquisaFornecedorContatosEditar_Load(object sender, EventArgs e)
        {

        }

        private void buttonEditarCContatos_Click(object sender, EventArgs e)
        {
            if (FornecedorCEditar == 0)
            {
                MessageBox.Show("Acesso não Permitido!");
            }
            if (FornecedorCEditar == 1)
            {
                this.OPERACAO = "Editar";
                panelFContatos.Enabled = true;
                buttonVerifica.Enabled = true;
                buttonEditarCContatos.Enabled = false;
            }
        }

        private void buttonVerifica_Click_1(object sender, EventArgs e)
        {
            Conexao conexao = new Conexao(this.connetionString);
            DALDateSystem dal = new DALDateSystem(conexao);

            Conexao conexao1 = new Conexao(this.connetionString);
            DALDateSystem da1 = new DALDateSystem(conexao1);

            FornecedorContatos contatos = new FornecedorContatos();
            //-------------------------EDITAR CADASTRATO---------------------------------------------------------------------------------------------------------------------------------------------------------------
            if (this.OPERACAO == "Editar")
            {
                if ((validaNome(txtNomeCContatos, errorProviderFornedorContatos) == true))//(labelConfirmacao.Text).Equals("sucesso - cep completo"))
                {
                    try
                    {
                        contatos.IdContatof = this.IdPessoaContato;
                        contatos.Nome = txtNomeCContatos.Text;
                        contatos.Abreviacao = txtAbreviacaoCContatos.Text;
                        contatos.Telefone = txtTelefoneCContatos.Text;
                        contatos.Telefone2 = txtTelefone2CContatos.Text;
                        contatos.Celular = txtCelularCContatos.Text;
                        contatos.Celular2 = txtCelular2CContatos.Text;
                        contatos.Observacao = txtObservacaoCContatos.Text;
                        contatos.Email = txtEmailCContatos.Text;
                        if (checkBoxClienteSituacao.Checked == true)
                        {
                            contatos.Situacao = 1;
                        }
                        else if (checkBoxClienteSituacao.Checked == false)
                        {
                            contatos.Situacao = 2;
                        }
                        da1.AlterarFContatos(contatos);

                        FecharTodosFormulario();

                        

                        //CHAMA O METODO CancelaCadastradoCliente QUE FECHA FORMULÁRIOS ABERTOS

                        MessageBox.Show("As alterações no Cadastrado Fornecedor Contatos Foram Salvas!");
                      

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void buttonExcluirCContatos_Click(object sender, EventArgs e)
        {
            if (FornecedorCExcluir == 0)
            {
                MessageBox.Show("Acesso não Permitido!");
            }
            if (FornecedorCExcluir == 1)
            {
                DialogResult d = MessageBox.Show("Deseja Excluir o registro?", "Aviso", MessageBoxButtons.YesNo);

                string strConexao = "Data Source=PROGRAMAS;Initial Catalog=MSOS;Persist Security Info=True;User ID=sa;Password=dellm@ster2016";
                Conexao conexao = new Conexao(strConexao);
                DALDateSystem dal = new DALDateSystem(conexao);

                if (d.ToString() == "Yes")
                {
                    dal.ExcluirFcontatos(this.IdPessoaContato);

                    FecharTodosFormulario();

                    FormClientesContatos FContatos = new FormClientesContatos(this.NomeServidor, this.NomeBaseDados, this.NomeUsuario, this.SenhaBaseDados);
                    FContatos.MdiParent = FormClientesContatos.ActiveForm;
                    FContatos.Show();
                    FContatos.Top = 0;
                    FContatos.Left = 0;
                }
            }
        }
        private void buttonFecharCContatos_Click(object sender, EventArgs e)
        {
            FecharTodosFormulario();
        }

        private void FormPesquisaFornecedorContatosEditar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
            {
                this.Close();
            }
        }
    }
}
