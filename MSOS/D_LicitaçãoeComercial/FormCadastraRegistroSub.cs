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
    public partial class FormCadastraRegistroSub : Form
    {
        Form Filho;
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
        private int IDCONTATOCLIENTE = 0;
        public int IdContatoCliente
        {
            get
            {
                return this.IDCONTATOCLIENTE;

            }
            set
            {
                this.IDCONTATOCLIENTE = value;
            }
        }
        public int ID_PESSOA_LOGADA = 0;
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
        private string NUMEROCLIENTE = "";
        public string NumeroCliente
        {
            get
            {
                return this.NUMEROCLIENTE;

            }
            set
            {
                this.NUMEROCLIENTE = value;
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
        private string NOMECLIENTE = "";
        public string NomeCliente
        {
            get
            {
                return this.NOMECLIENTE;

            }
            set
            {
                this.NOMECLIENTE = value;
            }
        }
        private int IDSUBREGISTRO = 0;
        public int IdSubRegistro
        {
            get
            {
                return this.IDSUBREGISTRO;

            }
            set
            {
                this.IDSUBREGISTRO = value;
            }
        }
        private int NUMEROGERADOSUBREGISTRO = 0;
        public int NumeroGeradoSUbRegistro
        {
            get
            {
                return this.NUMEROGERADOSUBREGISTRO;

            }
            set
            {
                this.NUMEROGERADOSUBREGISTRO = value;
            }
        }
        private int REGISTROCCCADASTRA = 0;
        public int RegistroCCCadastra
        {
            get
            {
                return this.REGISTROCCCADASTRA;

            }
            set
            {
                this.REGISTROCCCADASTRA = value;
            }
        }
        private int REGISTROEDITARSUB = 0;
        public int REGISTROEditarSub
        {
            get
            {
                return this.REGISTROEDITARSUB;

            }
            set
            {
                this.REGISTROEDITARSUB = value;
            }
        }
        //private int REGISTROCADASTRASUB = 0;
        //public int RegistroCadastraSub
        //{
        //    get
        //    {
        //        return this.REGISTROCADASTRASUB;

        //    }
        //    set
        //    {
        //        this.REGISTROCADASTRASUB = value;
        //    }
        //}

        private Boolean validaNome(TextBox textBox, ErrorProvider errorProvider)
        {
            if (!String.IsNullOrWhiteSpace(txtOrigemRegistro.Text))
            {
                errorProviderCadastraRegistroSub.SetError(textBox, "");
                return true;
            }
            else
            {
                errorProviderCadastraRegistroSub.SetError(textBox, "Documentação Inválido!");
                return false;
            }

        }
        private string operacao = "";
        public FormCadastraRegistroSub()
        {
            InitializeComponent();
        }
        //Cadastrando Novo Sub Registro
        public FormCadastraRegistroSub(int IDREGISTRO, int IDPESSOA, string NOMECLIENTE, 
            string NUMEROCLIENTE, int IDPESSOALOGADA, string NOMEUSARIOLOAGADO, string CONNETIONSTRING, 
            int RegistroCCCadastra, int C,int CS)
        {
            try
            {
                InitializeComponent();

                this.IdRegistro = IDREGISTRO;
                this.IdPessoa = IDPESSOA;
                this.NomeCliente = NOMECLIENTE;
                this.NumeroCliente = NUMEROCLIENTE;
                this.IdPessoaLogada = IDPESSOALOGADA;
                this.NomeUsuario = NOMEUSARIOLOAGADO;
                NomeLogado.Text = "NOME: " + NOMEUSARIOLOAGADO;
                this.connetionString = CONNETIONSTRING;

                this.RegistroCCCadastra = RegistroCCCadastra;

                if(RegistroCCCadastra == 1)
                {
                    buttonAdicionarContato.Enabled = true;
                    buttonAdicionarContato.Visible = true;

                    buttonAtualizarContatos.Enabled = true;
                    buttonAtualizarContatos.Visible = true;
                }

                buttonCadastraRegistro.Enabled = true;

                this.operacao = "Inserir";

                comboBoxContato.Items.Clear();
                Fill_listBoxContatos();

                NovoSubRegistro();

                txtNumeroRegistro.Text = IdRegistro.ToString();
                txtNomeRegistro.Text = NOMECLIENTE;
                txtNumeroCadastroCliente.Text = NUMEROCLIENTE;

                this.txtDataSolicitacaoProcesso.Value = DateTime.Now.Date;

                this.txtDataContatoRegistro.Value = DateTime.Now.Date;

                txtOrigemRegistro.MaxLength = 1000;
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
        }
        public FormCadastraRegistroSub(int IDREGISTRO, int IDPESSOA, string NOMECLIENTE,string NUMEROCLIENTE,
           int IDPESSOALOGADA,string NOMEUSARIOLOAGADO, string CONNETIONSTRING, int Editar)
        {
            try
            {
                InitializeComponent();

                this.IdRegistro = IDREGISTRO;
                this.IdPessoa = IDPESSOA;
                this.NomeCliente = NOMECLIENTE;
                this.NumeroCliente = NUMEROCLIENTE;
                this.IdPessoaLogada = IDPESSOALOGADA;
                this.NomeUsuario = NOMEUSARIOLOAGADO;
                NomeLogado.Text = "NOME: " + NOMEUSARIOLOAGADO;
                this.connetionString = CONNETIONSTRING;

                this.REGISTROEditarSub = Editar;

                this.operacao = "Inserir";

                comboBoxContato.Items.Clear();
                Fill_listBoxContatos();

                NovoSubRegistro();

                txtNumeroRegistro.Text = IdRegistro.ToString();
                txtNomeRegistro.Text = NOMECLIENTE;
                txtNumeroCadastroCliente.Text = NUMEROCLIENTE;

                this.txtDataSolicitacaoProcesso.Value = DateTime.Now.Date;

                this.txtDataContatoRegistro.Value = DateTime.Now.Date;

                txtOrigemRegistro.MaxLength = 1000;                             
            }
            catch(Exception ex)
            {
                ex.ToString();
            }
        }
        public FormCadastraRegistroSub(int IDREGISTRO, int IDPESSOA, string NOMECLIENTE, string NUMEROCLIENTE,
        int IDPESSOALOGADA, string NOMEUSARIOLOAGADO, string CONNETIONSTRING, int Editar, int RegistroCCCadastra)
        {
            try
            {
                InitializeComponent();

                this.IdRegistro = IDREGISTRO;
                this.IdPessoa = IDPESSOA;
                this.NomeCliente = NOMECLIENTE;
                this.NumeroCliente = NUMEROCLIENTE;
                this.IdPessoaLogada = IDPESSOALOGADA;
                this.NomeUsuario = NOMEUSARIOLOAGADO;
                NomeLogado.Text = "NOME: " + NOMEUSARIOLOAGADO;
                this.connetionString = CONNETIONSTRING;

                this.RegistroCCCadastra = RegistroCCCadastra;

                this.txtDataSolicitacaoProcesso.Value = DateTime.Now.Date;

                this.txtDataContatoRegistro.Value = DateTime.Now.Date;

                txtOrigemRegistro.MaxLength = 1000;

                if(Editar == 1)//Cadastra 1
                {
                    buttonCadastraRegistro.Enabled = true;
                }
                if (Editar == 2) //Editar 2
                {

                }
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
        }

        public void AlteraBotoes(int op)
        {
            if (op == 1)// Cadastra Registro campos
            {
                this.operacao = "Inserir";

                txtNumeroRegistro.Text = IdRegistro.ToString();
                txtNomeRegistro.Text = NomeCliente;
                txtNumeroCadastroCliente.Text = NumeroCliente;

                NovoSubRegistro();

                comboBoxContato.Items.Clear();
                Fill_listBoxContatos();

                panelDadosCliente.Enabled = true;
                panelDocumentoRegistro.Enabled = true;

                buttonCadastraRegistro.Enabled = false;
                buttonVerifica.Enabled = true;
                buttonLimpaRegistro.Enabled = true;
                buttonFecharRegistro.Enabled = true;

            }

            if (op == 2)// Editar Campos
            {
                buttonCadastraRegistro.Enabled = false;

                buttonLimpaRegistro.Enabled = true;
                buttonCancelarRegistro1.Enabled = true;
                buttonFecharRegistro.Enabled = true;
                buttonVerifica.Enabled = true;

                panelDadosCliente.Enabled = true;

                panelDocumentoRegistro.Enabled = true;

                checkBoxSituacao.Checked = true;
            }
        }
        private void FormCadastraRegistroSub_Load(object sender, EventArgs e)
        {

        }

        private void buttonVerifica_Click(object sender, EventArgs e)
        {
            CadastraRegistroSub();
        }
        
        public void CadastraRegistroSub()
        {
            Conexao conexao = new Conexao(this.connetionString);
            DALRegistroGerado da = new DALRegistroGerado(conexao);

            RegistroGeradoSub RegistroGeradoSubs = new RegistroGeradoSub();

            if ((validaNome(txtOrigemRegistro, errorProviderCadastraRegistroSub) == true)) //(labelConfirmacao.Text).Equals("sucesso - cep completo"))
            {
                try
                {
                    RegistroGeradoSubs.IdRegistro = IdRegistro;                  

                    RegistroGeradoSubs.IdClienteRegistro = this.IdPessoa;

                    RegistroGeradoSubs.IdContato = this.IdContatoCliente;

                    RegistroGeradoSubs.Situacao = 1;

                    RegistroGeradoSubs.IdPessoaLogada = this.IdPessoaLogada;

                    RegistroGeradoSubs.IdPessoaLogadaAlterada = 0;

                    RegistroGeradoSubs.OrigemRegistro = txtOrigemRegistro.Text;

                    RegistroGeradoSubs.DataCriadoRegistrado = Convert.ToDateTime(txtDataSolicitacaoProcesso.Value.Date.ToString("dd/MM/yyyy"));

                    RegistroGeradoSubs.DataContato = Convert.ToDateTime(txtDataContatoRegistro.Value.Date.ToString("dd/MM/yyyy"));


                    if (this.operacao == "Inserir")
                    {
                        if (this.comboBoxContato.Text == "")
                        {
                            MessageBox.Show("Selecione um contato para Cadastrado no sistema!");
                        }
                        if (!(this.comboBoxContato.Text == ""))
                        {

                            NovoSubRegistro();

                            RegistroGeradoSubs.IdRegistroSub = this.IdSubRegistro;

                            da.IncluirClienteRegistroGeradoSub(RegistroGeradoSubs);

                            MessageBox.Show("Registro Gerado Cadastrado com Exito! \n O número de Sub registro é " + RegistroGeradoSubs.IdRegistroSub.ToString() + " !");

                            this.Close();

                            DialogResult dialogResult = MessageBox.Show("Deseja criar um Sub Registro?", "Aviso", MessageBoxButtons.YesNo);

                            if (dialogResult == DialogResult.Yes)
                            {
                                timerRegistroSubNovo.Enabled = true;
                            }
                            else if (dialogResult == DialogResult.No)
                            {
                                this.Close();
                            }
                        }
                    }
                }                            

                catch
                {
                    //MessageBox.Show("Erro de acesso ao banco de Dados: " + ex.ToString());
                }
            }

            FormPesquisaCadastraRegistroEditar ChamaDataGrid = new FormPesquisaCadastraRegistroEditar();

            ChamaDataGrid.dataGridViewPesquisaTodos();
        }
        private void FormCadastraRegistroSub_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
            {
                //this.Close();
                if (Application.OpenForms.Count >= 1) //FECHA O TERCEIRO
                    Application.OpenForms[Application.OpenForms.Count - 1].Close();
            }

        }

        private void buttonCancelarRegistro_Click(object sender, EventArgs e)
        {
            FecharTodosFormulario();
    
        }

        private void buttonFecharRegistro_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.Count >= 1) //FECHA O TERCEIRO
                Application.OpenForms[Application.OpenForms.Count-1].Close();
        }

        private void buttonCadastraRegistro_Click(object sender, EventArgs e)
        {
            AlteraBotoes(1);
        }
        public void NovoSubRegistro()
        {
            SqlConnection conn = new SqlConnection(this.connetionString);

            SqlDataAdapter da = new SqlDataAdapter("EXEC D_R_ConsultaCadastroNRegistroSub " + IdRegistro + ";", conn);
            DataSet ds = new DataSet();
            da.Fill(ds);

            txtNumeroRegistro.Text = " N° " + IdRegistro.ToString();
            int SubRegistro = 1;

            if (!(ds.Tables[0].Rows.Count > 0))
            {
                txtNumeroSubRegistro.Text = " N° " + SubRegistro.ToString();

                this.IdSubRegistro = int.Parse(SubRegistro.ToString());

                conn.Close();
            }
            if (ds.Tables[0].Rows.Count > 0)
            {
                int soma = int.Parse(ds.Tables[0].Rows[0][0].ToString());

                SubRegistro = SubRegistro + soma;

                this.IdSubRegistro = SubRegistro;

                txtNumeroSubRegistro.Text = " N° " + SubRegistro.ToString();

                conn.Close();
            }
        }
        private void buttonCancelarRegistro1_Click(object sender, EventArgs e)
        {
            CancelarCadastroRegistroSub();
        }
        public void CancelarCadastroRegistroSub()
        {
            FecharTodosFormulario();

            FormCadastraRegistroSub CadastraRegistroSub = new FormCadastraRegistroSub(this.IdRegistro, this.IdPessoa,
            this.NomeCliente, this.NumeroCliente, this.IdPessoaLogada, this.NomeUsuario, this.connetionString, this.RegistroCCCadastra);
            CadastraRegistroSub.MdiParent = this;
            CadastraRegistroSub.Show();
            CadastraRegistroSub.Top = 0;
            CadastraRegistroSub.Left = 0;

        }
        public void FecharTodosFormulario()
        {
            CancelaCadastradoProposta(typeof(FormCadastraRegistroSub));
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

        void Fill_listBoxContatos()
        {
            SqlConnection connection = new SqlConnection(this.connetionString);

            try
            {
                connection.Open();
                string Query = "EXEC D_R_ConsultaCadastroIdRegistro " + IdPessoa + ";";


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
        private void comboBoxContato_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(this.connetionString);

            try
            {
                connection.Open();

                string Query = " SELECT ID_PESSOA_CONTATO, ABREVIACAO FROM P_Contatos WHERE Nome = '" + this.comboBoxContato.Text + "';";

                SqlCommand command = new SqlCommand(Query, connection);
                SqlDataReader dr = command.ExecuteReader();
                while (dr.Read())
                {

                    this.IdContatoCliente = dr.GetInt32(0);
                    comboBoxContato.Text = dr.GetString(1);
                    label8.Text = dr.GetString(1);
                    this.ComboBoxAbreviacao = dr.GetString(1);
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonLimpaRegistro_Click(object sender, EventArgs e)
        {
            txtOrigemRegistro.Clear();
        }
        private void timerRegistroSubNovo_Tick(object sender, EventArgs e)
        {
            try
            {
                timerRegistroSubNovo.Enabled = false;

                FormPesquisaCadastraRegistroEditar FormPesquisaCadastraRegistroEditarF = new FormPesquisaCadastraRegistroEditar();

                FormCadastraRegistroSub FormCadastraRegistroSubF = new FormCadastraRegistroSub(this.IdRegistro, this.IdPessoa,
                this.NomeCliente, this.NumeroCliente, this.IdPessoaLogada, this.NomeUsuario, 
                this.connetionString, this.RegistroCCCadastra, 1, 1);

                FormCadastraRegistroSubF.ShowDialog();
                FormCadastraRegistroSubF.Top = 0;
                FormCadastraRegistroSubF.Left = 0;

                //FormCadastraRegistroSub CadastraRegistroSub = new FormCadastraRegistroSub(this, this.IdRegistro, this.IdPessoa,
                //this.NomeCliente, this.NumeroCliente, this.IdPessoaLogada, this.NomeUsuario, this.connetionString);
                //CadastraRegistroSub.Parent = CadastraRegistroSub.MdiParent;
                //CadastraRegistroSub.Show(this);
                ////CadastraRegistroSub.Show(this);
                ////CadastraRegistroSub.MdiParent = FormCadastraRegistroSub.ActiveForm;
                ////CadastraRegistroSub.Show();
                //CadastraRegistroSub.Top = 0;
                //CadastraRegistroSub.Left = 0;


            }
            catch (Exception ex)
            {
                ex.ToString();
            }
        }

        private void buttonAdicionarContato_Click(object sender, EventArgs e)
        {
            try
            {
                FormCadastraContatoRegistro cadastracliente = new FormCadastraContatoRegistro(this.IdPessoa, this.connetionString);

                cadastracliente.Show();
                cadastracliente.Top = 0;
                cadastracliente.Left = 0;
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
        }

        private void buttonAtualizarContatos_Click(object sender, EventArgs e)
        {
            comboBoxContato.Items.Clear();
            Fill_listBoxContatos();
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
