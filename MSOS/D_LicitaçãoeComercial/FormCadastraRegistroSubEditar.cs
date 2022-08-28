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
    public partial class FormCadastraRegistroSubEditar : Form
    {
        private int ID_REGISTRO = 0;
        public int IdRegistro
        {
            get
            {
                return this.ID_REGISTRO;

            }
            set
            {
                this.ID_REGISTRO = value;
            }
        }
        private int ID_REGISTROSUB1 = 0;
        public int IdRegistroSub1
        {
            get
            {
                return this.ID_REGISTROSUB1;

            }
            set
            {
                this.ID_REGISTROSUB1 = value;
            }
        }
        private int REGISTROEDITAR = 0;
        public int RegistroEditar
        {
            get
            {
                return this.REGISTROEDITAR;

            }
            set
            {
                this.REGISTROEDITAR = value;
            }
        }
        private int REGISTROEXCLUIR = 0;
        public int RegistroExcluir
        {
            get
            {
                return this.REGISTROEXCLUIR;

            }
            set
            {
                this.REGISTROEXCLUIR = value;
            }
        }
        private int IDPESSOALOGADA = 0;
        public int IdPessoaLogada
        {
            get
            {
                return this.IDPESSOALOGADA;

            }
            set
            {
                this.IDPESSOALOGADA = value;
            }
        }
        private string NOMEPESSOALOGADA = "";
        public string NomePessoaLogada
        {
            get
            {
                return this.NOMEPESSOALOGADA;

            }
            set
            {
                this.NOMEPESSOALOGADA = value;
            }
        }
        private string CONNETIONSTRING = "";
        public string connetionString
        {
            get
            {
                return this.CONNETIONSTRING;

            }
            set
            {
                this.CONNETIONSTRING = value;
            }
        }
        private int SITUACAO = 0;
        public int Situacao
        {
            get
            {
                return this.SITUACAO;

            }
            set
            {
                this.SITUACAO = value;
            }
        }
        private int IDCLIENTE = 0;
        public int IdCliente
        {
            get
            {
                return this.IDCLIENTE;

            }
            set
            {
                this.IDCLIENTE = value;
            }
        }
        private string SIDCLIENTE = "";
        public string SIdCliente
        {
            get
            {
                return this.SIDCLIENTE;

            }
            set
            {
                this.SIDCLIENTE = value;
            }
        }
        string Operacao = "";
        // VALIDAR ENTRADA COM ERROPROVIDER
        private Boolean txtOrigemRegistroa(TextBox textBox, ErrorProvider errorProvider)
        {
            if (!String.IsNullOrWhiteSpace(txtOrigemRegistro.Text))
            {
                errorProviderCadastraRegistroSubEditar.SetError(textBox, "");
                return true;
            }
            else
            {
                errorProviderCadastraRegistroSubEditar.SetError(textBox, "Nome Inválido!");
                return false;
            }
        }
        public FormCadastraRegistroSubEditar()
        {
            InitializeComponent();
        }
        //Só pode Editar Sem a função de Cadastra novo Sub
        public FormCadastraRegistroSubEditar(int IdRegistro, int IdRegistroSub1, int RegistroEditar,
                int RegistroExcluir, int IdPessoaLogada,string NomePessoaLogada, string connetionString, int Editar)
        {
            InitializeComponent();

            this.IdRegistro = IdRegistro;
            this.IdRegistroSub1 = IdRegistroSub1;
            this.RegistroEditar = RegistroEditar;
            this.RegistroExcluir = RegistroExcluir;
            this.IdPessoaLogada = IdPessoaLogada;
            this.NomePessoaLogada = NomePessoaLogada;
            NomeLogado.Text = "NOME: " + NomePessoaLogada;
            this.connetionString = connetionString;

            txtNumeroRegistro.Text = IdRegistro.ToString();

            txtOrigemRegistro.MaxLength = 1000;
            
            if(Editar == 2)
            {
                CadastraRegistroSubEditar();

                buttonCadastraRegistro.Enabled = false;               
            }
        }
        void CadastraRegistroSubEditar()
        {
            SqlConnection conn = new SqlConnection(this.connetionString);

            SqlDataAdapter da = new SqlDataAdapter("EXEC D_R_ConsultaRegistroGeradoSubNSEditartxt " + this.IdRegistroSub1 + ";", conn);
            DataSet ds = new DataSet();
            da.Fill(ds);

            conn.Open();
            
            txtNumeroSubRegistro.Text = ds.Tables[0].Rows[0][2].ToString();
            txtDataSolicitacaoProcesso.Text = ds.Tables[0].Rows[0][9].ToString();
            txtNomeRegistro.Text = ds.Tables[0].Rows[0][12].ToString();
            txtNumeroCadastroCliente.Text = ds.Tables[0].Rows[0][11].ToString();
            txtNomeContato.Text = ds.Tables[0].Rows[0][16].ToString();
            label8.Text = ds.Tables[0].Rows[0][17].ToString();
            txtOrigemRegistro.Text = ds.Tables[0].Rows[0][8].ToString();
            txtDataContatoRegistro.Text = ds.Tables[0].Rows[0][10].ToString();

            Situacao = int.Parse(ds.Tables[0].Rows[0][5].ToString());

            if (Situacao == 0)
            {
                checkBoxSituacao.Checked = false;
            }
            if (Situacao == 1)
            {
                checkBoxSituacao.Checked = true;
            }
            if (RegistroEditar == 1)
            {
                buttonEditar.Enabled = true;
            }
            conn.Close();

        }

        private void FormCadastraRegistroSubEditar_Load(object sender, EventArgs e)
        {

        }
        public void FecharTodosFormulario()
        {
            CancelaCadastradoProposta(typeof(FormPesquisaCadastraRegistroEditar));
            CancelaCadastradoProposta(typeof(FormPesquisaCadastraRegistro));
            CancelaCadastradoProposta(typeof(FormCadastraRegistroSubEditar));
            CancelaCadastradoProposta(typeof(FormCadastraRegistroSub));
        }
        public void FecharTodosFormulario2()
        {
            CancelaCadastradoProposta(typeof(FormCadastraRegistroSubEditar));
        }
        public static void CancelaCadastradoProposta(Type frmType)
        {
            bool bolCtl = false;
            Type a = frmType;
            foreach (Form form in System.Windows.Forms.Application.OpenForms)
            {
                if (form.GetType().Equals(frmType))
                {

                    form.Close();

                    bolCtl = true;
                    break;
                }
            }

            if (!bolCtl)
            {

            }
        }
        private void buttonEditar_Click(object sender, EventArgs e)
        {
            Editar();
        }
        public void Editar()
        {
            if(REGISTROEDITAR == 0 || Situacao == 0)
            {
                MessageBox.Show("Acesso negado!");
            }
            if (REGISTROEDITAR == 1 && (Situacao == 1))
            {               
                BotaoAlteracao(1);
            }
        }
        public void BotaoAlteracao(int numero)
        {
            if (numero == 1)//Editar
            {
                panelDocumentoRegistro.Enabled = true;
                buttonVerifica.Enabled = true;
                this.Operacao = "Editar";
                buttonEditar.Enabled = false;
                buttonCadastraRegistro.Enabled = false;
                buttonLimpaRegistro.Enabled = true;
            }
            if (numero == 2)
            {
                SqlConnection conn = new SqlConnection(this.connetionString);
                SqlDataAdapter da = new SqlDataAdapter("SELECT ID_PESSOA_CLIENTE from R_RegistroGerados WHERE ID_REGISTRO = '" + this.IdRegistro + "';", conn);
                DataSet ds = new DataSet();
                da.Fill(ds);

                conn.Open();

                this.IdCliente = int.Parse(ds.Tables[0].Rows[0][0].ToString());

                this.SIdCliente = IdCliente.ToString();

                DialogResult dialogResult = MessageBox.Show("Deseja Cadastra novo Sub Registro "+ txtNomeRegistro.Text + "?", "Aviso", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    FecharTodosFormulario();

                    timerRegistroSubNovoEditar.Enabled = true;
                }
                else if (dialogResult == DialogResult.No)
                {
                    FecharTodosFormulario();
                }
            }
        }
        public void Cancelar()
        {
            //FecharTodosFormulario();
            //FormCadastraRegistroSubEditar CadastraRegistroEditar = new FormCadastraRegistroSubEditar(this.IdRegistro, this.IdRegistroSub1, this.RegistroEditar,
            //this.RegistroExcluir, this.IdPessoaLogada, this.connetionString);
            //CadastraRegistroEditar.MdiParent = FormCadastraRegistroSubEditar.ActiveForm;
            //CadastraRegistroEditar.Show();
            //CadastraRegistroEditar.Top = 0;
        }
        private void buttonVerifica_Click(object sender, EventArgs e)
        {
            SalvarAlteracao();
        }
        public void SalvarAlteracao()
        {
            Conexao conexao = new Conexao(this.connetionString);
            DALRegistroGerado da = new DALRegistroGerado(conexao);

            RegistroGeradoSub RegistroGeradoSub = new RegistroGeradoSub();

            if ((txtOrigemRegistroa(txtNomeRegistro, errorProviderCadastraRegistroSubEditar) == true)) //(labelConfirmacao.Text).Equals("sucesso - cep completo"))
            {
                try
                {
                    RegistroGeradoSub.IdRegistroSub = this.IdRegistroSub1;

                    if (checkBoxSituacao.Checked == false)
                    {
                        RegistroGeradoSub.Situacao = 2;
                    }
                    if (checkBoxSituacao.Checked == true)
                    {
                        RegistroGeradoSub.Situacao = 1;
                    }

                    RegistroGeradoSub.IdPessoaLogadaAlterada = this.IdPessoaLogada;

                    RegistroGeradoSub.OrigemRegistro = txtOrigemRegistro.Text;

                    if (this.Operacao == "Editar")
                    {
                        da.AlterarClienteRegistroGeradoSub(RegistroGeradoSub);

                        this.Close();

                        MessageBox.Show("Sub Registro alterado com exito!");                  
                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Erro de acesso ao banco de Dados: " + ex.ToString());
                }
            }
        }

        private void buttonCadastraRegistro_Click(object sender, EventArgs e)
        {
            CadastraNovoSubRegistro();
        }
        public void CadastraNovoSubRegistro()
        {
            BotaoAlteracao(2);
        }

        private void FormCadastraRegistroSubEditar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
            {
                this.Close();
            }
        }
        private void timerRegistroSubNovoEditar_Tick(object sender, EventArgs e)
        {
            FormCadastraRegistroSub CadastraRegistroSub = new FormCadastraRegistroSub(this.IdRegistro, this.IdCliente,
            txtNomeRegistro.Text, this.SIdCliente, this.IdPessoaLogada, NomeLogado.Text, this.connetionString, 0);//editar = 0;             
                                                                                                                  //CadastraRegistroSub.MdiParent = FormCadastraRegistroSub.ActiveForm;
            CadastraRegistroSub.MdiParent = this;
            CadastraRegistroSub.Show();
            CadastraRegistroSub.Top = 0;
            CadastraRegistroSub.Left = 0;

            timerRegistroSubNovoEditar.Enabled = false;
        }

        private void buttonFecharRegistro_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonLimpaRegistro_Click(object sender, EventArgs e)
        {
            txtOrigemRegistro.Clear();
        }

        private void txtOrigemRegistro_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                int tamanhoMaximoPorLinha = 105;
                int[] keysLiberadas = { (int)Keys.Enter, (int)Keys.Back };

                int posicaoAtual = txtOrigemRegistro.SelectionStart;
                int linhaAtual = txtOrigemRegistro.GetLineFromCharIndex(posicaoAtual);

                if (txtOrigemRegistro.Lines.Length == 0)
                {
                    if (txtOrigemRegistro.Text.Length > tamanhoMaximoPorLinha && !keysLiberadas.Contains((int)e.KeyChar))
                    {
                        e.Handled = true;
                    }
                }
                else if (txtOrigemRegistro.Lines[linhaAtual].Length > tamanhoMaximoPorLinha && !keysLiberadas.Contains((int)e.KeyChar))
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
