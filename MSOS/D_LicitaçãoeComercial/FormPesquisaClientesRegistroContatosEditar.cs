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
    public partial class FormPesquisaClientesRegistroContatosEditar : Form
    {
        string OPERACAO = "Editar";
        private int ID_PESSOA_CONTATO = 0;
        public int IdPessoaContato
        {
            get
            {
                return this.ID_PESSOA_CONTATO;

            }
            set
            {
                this.ID_PESSOA_CONTATO = value;
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
        private int STATUS2 = 0;
        public int status2
        {
            get
            {
                return this.STATUS2;

            }
            set
            {
                this.STATUS2 = value;
            }
        }
        private int CLIENTECEDITAR = 0;
        public int ClienteCEditar
        {
            get
            {
                return this.CLIENTECEDITAR;

            }
            set
            {
                this.CLIENTECEDITAR = value;
            }
        }
        private int CLIENTECEXCLUIR = 0;
        public int ClienteCExcluir
        {
            get
            {
                return this.CLIENTECEXCLUIR;

            }
            set
            {
                this.CLIENTECEXCLUIR = value;
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
        private Boolean validaAbreviacao(TextBox textBox, ErrorProvider errorProvider)
        {
            if (!String.IsNullOrWhiteSpace(txtAbreviacaoCContatos.Text))
            {
                errorProviderContatoEditar.SetError(textBox, "");
                return true;
            }
            else
            {
                errorProviderContatoEditar.SetError(textBox, "Abreviação Inválido!");
                return false;
            }
        }
        private Boolean validaCelular(TextBox textBox, ErrorProvider errorProvider)
        {
            if (!String.IsNullOrWhiteSpace(txtCelularCContatos.Text))
            {
                errorProviderContatoEditar.SetError(textBox, "");
                return true;
            }
            else
            {
                errorProviderContatoEditar.SetError(textBox, "Celular Inválido!");
                return false;
            }
        }
        private Boolean validaNome(TextBox textBox, ErrorProvider errorProvider)
        {
            if (!String.IsNullOrWhiteSpace(txtNomeCContatos.Text))
            {
                errorProviderContatoEditar.SetError(textBox, "");
                return true;
            }
            else
            {
                errorProviderContatoEditar.SetError(textBox, "Endereço Inválido!");
                return false;
            }
        }
        public FormPesquisaClientesRegistroContatosEditar(string NomeServidor, string NomeBaseDados, string NomeUsuario, string SenhaBaseDados)
        {
            InitializeComponent();

            this.NomeServidor = NomeServidor;
            this.NomeBaseDados = NomeBaseDados;
            this.NomeUsuario = NomeUsuario;
            this.SenhaBaseDados = SenhaBaseDados;

            this.connetionString = "Data Source=" + this.NomeServidor + ";Initial Catalog=" + this.NomeBaseDados + ";Persist Security Info=True;User ID=" + this.NomeUsuario + ";Password=" + this.SenhaBaseDados + ";";
        }
        public static void CancelaCadastradoCContatos(Type frmType)
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
            CancelaCadastradoCContatos(typeof(FormPesquisaClientesRegistroContatosEditar));
        }
        public FormPesquisaClientesRegistroContatosEditar(int idPessoaContato, int CLIENTECEDITAR, int CLIENTECEXCLUIR, string NomeServidor, string NomeBaseDados, string NomeUsuario, string SenhaBaseDados)
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

            this.ClienteCEditar = CLIENTECEDITAR;
            this.ClienteCExcluir = CLIENTECEXCLUIR;

            if (ClienteCEditar == 0)
            {
                buttonEditarCContatos.Enabled = false;
            }
            if (ClienteCEditar == 1)
            {
                buttonEditarCContatos.Enabled = true;
            }
            if (ClienteCExcluir == 0)
            {
                buttonExcluirCContatos.Enabled = false;
            }
            if (ClienteCExcluir == 1)
            {
                buttonExcluirCContatos.Enabled = true;
            }

            //IdPessoa = Convert.ToInt32(dataGridViewPesquisaCliente["ID_PESSOA", e.RowIndex].Value);
            ////id = Convert.ToInt32(dataGridViewPesquisa.CurrentRow.Cells[0].Value.ToString());
            ////id = Convert.ToInt32(dataGridViewPesquisa.Rows[e.RowIndex].Cells["ORDEM_SERVIÇO"].Value.ToString());

            SqlConnection conn1 = new SqlConnection(this.connetionString);
            string sql1 = "exec D_R_ConsultaClienteRegistroContatoEditarTxt " + idPessoaContato;
            SqlDataAdapter sda1 = new SqlDataAdapter(sql1, conn1);
            DataSet ds1 = new DataSet();
            sda1.Fill(ds1);

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
            if (status == 2)
            {
                checkBoxClienteSituacao.Checked = false;
            }

        }

        private void FormPesquisaClientesRegistroContatosEditar_Load(object sender, EventArgs e)
        {

        }

        private void FormPesquisaClientesRegistroContatosEditar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
            {
                this.Close();
            }
        }

        private void buttonEditarCContatos_Click(object sender, EventArgs e)
        {
            if (ClienteCEditar == 0)
            {
                MessageBox.Show("Acesso não Permitido!");
            }
            if (ClienteCEditar == 1)
            {
                this.OPERACAO = "Editar";
                panelFContatos.Enabled = true;
                buttonVerifica.Enabled = true;
                buttonEditarCContatos.Enabled = false;
            }
        }

        private void buttonExcluirCContatos_Click(object sender, EventArgs e)
        {
            if (ClienteCExcluir == 0)
            {
                MessageBox.Show("Acesso não Permitido!");
            }
            if (ClienteCExcluir == 1)
            {
                DialogResult d = MessageBox.Show("Deseja Excluir o registro?", "Aviso", MessageBoxButtons.YesNo);

                Conexao conexao = new Conexao(this.connetionString);
                DALDateSystem dal = new DALDateSystem(conexao);

                if (d.ToString() == "Yes")
                {
                    dal.ExcluirFcontatos(this.IdPessoaContato);

                    FecharTodosFormulario();
                }
            }
        }

        private void buttonFecharCContatos_Click(object sender, EventArgs e)
        {
            FecharTodosFormulario();
        }

        private void buttonVerifica_Click(object sender, EventArgs e)
        {
            SalvarContatoRegistro();
        }
        public void SalvarContatoRegistro()
        {
            Conexao conexao = new Conexao(this.connetionString);
            DALDateSystem da = new DALDateSystem(conexao);

            ClientesContatos cadastra = new ClientesContatos();
            //-------------------------EDITAR CADASTRATO---------------------------------------------------------------------------------------------------------------------------------------------------------------
            if (this.OPERACAO == "Editar")
            {
                if ((validaNome(txtNomeCContatos, errorProviderContatoEditar) == true))//(labelConfirmacao.Text).Equals("sucesso - cep completo"))
                {
                    try
                    {
                        cadastra.IdContatof = this.IdPessoaContato;
                        cadastra.Nome = txtNomeCContatos.Text;
                        cadastra.Abreviacao = txtAbreviacaoCContatos.Text;
                        cadastra.Telefone = txtTelefoneCContatos.Text;
                        cadastra.Telefone2 = txtTelefone2CContatos.Text;
                        cadastra.Celular = txtCelularCContatos.Text;
                        cadastra.Celular2 = txtCelular2CContatos.Text;
                        cadastra.Email = txtEmailCContatos.Text;
                        cadastra.Observacao = txtObservacaoCContatos.Text;

                        if (checkBoxClienteSituacao.Checked == true)
                        {
                            cadastra.Situacao = 1;
                        }
                        else if (checkBoxClienteSituacao.Checked == false)
                        {
                            cadastra.Situacao = 2;
                        }

                        da.AlterarCContatos(cadastra);

                        //CHAMA O METODO CancelaCadastradoCliente QUE FECHA FORMULÁRIOS ABERTOS

                        MessageBox.Show("As alterações no Cadastrado Cliente de Registro do Contatos Foram Salvas!");

                        FecharTodosFormulario();

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
