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
using System.Drawing.Imaging;



namespace DateSystem
{
    public partial class FormOSPesquisaEditar : Form
    {
        private string operacao = "";

        Bitmap bmp;

        private int ID_CADASTRO_OS = 0;
        public int id_CadastroOs
        {
            get
            {
                return this.ID_CADASTRO_OS;

            }
            set
            {
                this.ID_CADASTRO_OS = value;
            }
        }
        private int ID_PESSOALOGADA = 0;
        public int IdPessoaLogada
        {
            get
            {
                return this.ID_PESSOALOGADA;

            }
            set
            {
                this.ID_PESSOALOGADA = value;
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
        private int VERIFICADORIMAGEM = 0;
        public int VerficidorImagem
        {
            get
            {
                return this.VERIFICADORIMAGEM;

            }
            set
            {
                this.VERIFICADORIMAGEM = value;
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
        //Strings endereços
        private double TIPO_LOGRADOURO = 0;
        public double Tipologradouro
        {
            get
            {
                return this.TIPO_LOGRADOURO;

            }
            set
            {
                this.TIPO_LOGRADOURO = value;
            }
        }
        private double ENDERECOOS = 0;
        public double EnderecoOS
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
        private double COMPLEMENTOS = 0;
        public double Complementos
        {
            get
            {
                return this.COMPLEMENTOS;

            }
            set
            {
                this.COMPLEMENTOS = value;
            }
        }
        private double BAIRRONUMERO = 0;
        public double BairroNumero
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
        private double BAIRRO = 0;
        public double Bairro
        {
            get
            {
                return this.BAIRRO;

            }
            set
            {
                this.BAIRRO = value;
            }
        }
        private double CIDADE = 0;
        public double Cidade
        {
            get
            {
                return this.CIDADE;

            }
            set
            {
                this.CIDADE = value;
            }
        }
        private int OSEDITAR = 0;
        public int OsEditar
        {
            get
            {
                return this.OSEDITAR;

            }
            set
            {
                this.OSEDITAR = value;
            }
        }
        private int OSEXCLUIR = 0;
        public int OsExcluir
        {
            get
            {
                return this.OSEXCLUIR;

            }
            set
            {
                this.OSEXCLUIR = value;
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
        private Boolean ALTERACAO = false;
        public Boolean Alteracao
        {
            get
            {
                return this.ALTERACAO;

            }
            set
            {
                this.ALTERACAO = value;
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
        private int CLIENTECCADASTRA = 0;
        public int ClienteCCadastra
        {
            get
            {
                return this.CLIENTECCADASTRA;

            }
            set
            {
                this.CLIENTECCADASTRA = value;
            }
        }
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
        private int ID_PESSOA_CONTATOCC = 0;
        public int IdPessoaContatoCc
        {
            get
            {
                return this.ID_PESSOA_CONTATOCC;

            }
            set
            {
                this.ID_PESSOA_CONTATOCC = value;
            }
        }
        private int ID_PESSOA_CLIENTE = 0;
        public int IdPessoaCliente
        {
            get
            {
                return this.ID_PESSOA_CLIENTE;

            }
            set
            {
                this.ID_PESSOA_CLIENTE = value;
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
        private int ID_CLIENTE = 0;
        public int IdCliente
        {
            get
            {
                return this.ID_CLIENTE;

            }
            set
            {
                this.ID_CLIENTE = value;
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

        public Boolean ExcluidoOS = false;

        // VALIDAR ENTRADA COM ERROPROVIDER
        private Boolean OrigemChamado(TextBox textBox, ErrorProvider errorProvider)
        {
            if (!String.IsNullOrWhiteSpace(txtOrigemChamado.Text))
            {
                errorProviderOS.SetError(textBox, "");
                return true;
            }
            else
            {
                errorProviderOS.SetError(textBox, "Origem do Chamado em branco!");
                return false;
            }
        }
        private Boolean ServicoExecutados(TextBox textBox, ErrorProvider errorProvider)
        {
            if (!String.IsNullOrWhiteSpace(txtServicoExecutado.Text))
            {
                errorProviderOS.SetError(textBox, "");
                return true;
            }
            else
            {
                errorProviderOS.SetError(textBox, "Serviço Executados em branco!");
                return false;
            }
        }
        public FormOSPesquisaEditar(int IDOS, int OSEDITAR, int OSEXCLUIR, int IDPESSOALOGADA, int ClienteCCadastra, int IDCLIENTE, string CONNECTIONSTRING)
        {
            InitializeComponent();

            txtOrigemChamado.MaxLength = 462;
            txtServicoExecutado.MaxLength = 482;

            this.IdOs = IDOS;
            this.OsEditar = OSEDITAR;
            this.OsExcluir = OSEXCLUIR;
            this.IdPessoaLogada = IDPESSOALOGADA;
            this.ClienteCCadastra = ClienteCCadastra;
            this.IdCliente = IDCLIENTE;
            this.connetionString = CONNECTIONSTRING;



            SqlConnection conn1 = new SqlConnection(this.connetionString);
            string sql1 = "exec D_O_ConsultaOsEditarTxt " + IdOs;
            SqlDataAdapter sda1 = new SqlDataAdapter(sql1, conn1);
            DataSet ds1 = new DataSet();
            sda1.Fill(ds1);
            conn1.Open();

            txtNumeroOrdemServico.Text = " N° " + ds1.Tables[0].Rows[0][0].ToString();
            txtDataSolicitacao.Text = ds1.Tables[0].Rows[0][1].ToString();
            txtNomeOS.Text = ds1.Tables[0].Rows[0][2].ToString();
            txtMsOs.Text = ds1.Tables[0].Rows[0][5].ToString();
            txtTipo_logradouro.Text = ds1.Tables[0].Rows[0][6].ToString();
            txtEnderecoOS.Text = ds1.Tables[0].Rows[0][7].ToString();
            txtComplOs.Text = ds1.Tables[0].Rows[0][8].ToString();
            txtBairroNumero.Text = ds1.Tables[0].Rows[0][9].ToString();
            txtBairroOS.Text = ds1.Tables[0].Rows[0][10].ToString();
            txtCidadeOs.Text = ds1.Tables[0].Rows[0][11].ToString();
            comboBoxContato.Text = ds1.Tables[0].Rows[0][12].ToString();
            txtTelefoneOs.Text = ds1.Tables[0].Rows[0][13].ToString();
            txtOrigemChamado.Text = ds1.Tables[0].Rows[0][14].ToString();
            txtServicoExecutado.Text = ds1.Tables[0].Rows[0][15].ToString();
            txtNomeFuncionario.Text = ds1.Tables[0].Rows[0][16].ToString();
            maskedTxtHorarioInicio.Text = ds1.Tables[0].Rows[0][17].ToString();
            maskedTxtHorarioFInal.Text = ds1.Tables[0].Rows[0][18].ToString();

            string FINALIZADO_OS = ds1.Tables[0].Rows[0][20].ToString();

            int ID_PESSOA_LOGADA = int.Parse(ds1.Tables[0].Rows[0][21].ToString());

            string ID_PESSOA_LOGADA_ALTERADA = ds1.Tables[0].Rows[0][22].ToString();

            string ID_CONTATO_CLIENTE = ds1.Tables[0].Rows[0][23].ToString();

            this.Situacao = int.Parse(ds1.Tables[0].Rows[0][24].ToString());

            if (Situacao == 2)
            {
                checkBoxSituacao.Checked = false;
            }
            if (Situacao == 1)
            {
                checkBoxSituacao.Checked = true;
            }

            conn1.Close();
            SqlConnection conn7 = new SqlConnection(this.connetionString);
            string sql7 = "exec D_O_VerificarEstadoOs " + IdOs;
            SqlDataAdapter sda7 = new SqlDataAdapter(sql7, conn7);
            DataSet ds7 = new DataSet();
            sda7.Fill(ds7);
            conn7.Open();

            int statusOs = int.Parse(ds7.Tables[0].Rows[0][0].ToString());

            conn7.Close();

            this.status = statusOs;

            if (this.status == 1)
            {
                if (OsEditar == 0)
                {
                    buttonEditarOSe.Enabled = true;//false
                    buttonVerifica.Enabled = false;
                }
                if (OsEditar == 1)
                {
                    buttonEditarOSe.Enabled = true;
                    buttonVerifica.Enabled = false;

                    if (OsExcluir == 1)
                    {
                        checkBoxSituacao.Enabled = true;
                    }
                }
            }
            if (this.status == 2)
            {
                if (OsEditar == 0)
                {
                    buttonEditarOSe.Enabled = true;//false
                    buttonVerifica.Enabled = false;
                }
                if (OsEditar == 1)
                {
                    buttonEditarOSe.Enabled = true;
                    buttonVerifica.Enabled = false;
                }

            }
            if (this.status == 3)
            {
                if (OsEditar == 0)
                {
                    buttonEditarOSe.Enabled = true;//false
                    buttonVerifica.Enabled = false;
                    buttonDeletar.Enabled = false;
                }
                if (OsEditar == 1)
                {
                    buttonEditarOSe.Enabled = false;
                    buttonVerifica.Enabled = false;
                    buttonDeletar.Enabled = false;
                }
                checkBoxFinalizarOS.Checked = true;
            }

            if (!(ID_PESSOA_LOGADA_ALTERADA == ""))
            {
                SqlConnection conn5 = new SqlConnection(this.connetionString);
                int IdPessoaLoagadaAlterada = int.Parse(ID_PESSOA_LOGADA_ALTERADA);
                string sql = "SELECT * FROM U_LoginUsuario WHERE ID_LOGIN_USUARIO = " + IdPessoaLoagadaAlterada + ";";
                SqlDataAdapter sda5 = new SqlDataAdapter(sql, conn5);
                DataSet ds5 = new DataSet();
                sda5.Fill(ds5);
                conn5.Open();

                label16.Text = "Alterado por \n" + ds5.Tables[0].Rows[0][1].ToString(); ;
                //NomeLogado.Text = ds5.Tables[0].Rows[0][1].ToString();
                conn5.Close();
            }
            if (ID_PESSOA_LOGADA_ALTERADA == "")
            {
                SqlConnection conn5 = new SqlConnection(this.connetionString);
                string sql = "SELECT * FROM U_LoginUsuario WHERE ID_LOGIN_USUARIO = " + ID_PESSOA_LOGADA + ";";
                SqlDataAdapter sda5 = new SqlDataAdapter(sql, conn5);
                DataSet ds5 = new DataSet();
                sda5.Fill(ds5);
                conn5.Open();

                label16.Text = "Criado por \n" + ds5.Tables[0].Rows[0][1].ToString(); ;
                //NomeLogado.Text = ds5.Tables[0].Rows[0][1].ToString();
                conn5.Close();
            }

            if (ID_CONTATO_CLIENTE == "")
            {
                if (this.ClienteCCadastra == 0)
                {
                    comboBoxContato.Enabled = true;
                }
                if (this.ClienteCCadastra == 1)
                {
                    comboBoxContato.Enabled = true;
                    buttonAdicionarContato.Enabled = true;
                    buttonAdicionarContato.Visible = true;
                    buttonAtualizarContatos.Enabled = true;
                    buttonAtualizarContatos.Visible = true;
                    comboBoxContato.Items.Clear();
                    Fill_listBoxContatos();
                }


            }
            if (!(ID_CONTATO_CLIENTE == ""))
            {

                int ID_CONTATO_CADASTRADO = int.Parse(ID_CONTATO_CLIENTE);
                SqlConnection conn6 = new SqlConnection(this.connetionString);
                string Query6 = "EXEC D_O_ConsultaCadastroIdContatosClienteOS " + ID_CONTATO_CADASTRADO + ";";
                SqlDataAdapter sda6 = new SqlDataAdapter(Query6, conn6);
                DataSet ds6 = new DataSet();
                sda6.Fill(ds6);

                comboBoxContato.Items.Insert(0, ds6.Tables[0].Rows[0][0].ToString());
                comboBoxContato.SelectedIndex = 0;
                conn6.Close();
            }

            if (IdPessoaLogada == 6)
            {
                FormEditarOsTexto OsEditar = new FormEditarOsTexto(txtOrigemChamado.Text, txtServicoExecutado.Text);
                OsEditar.MdiParent = FormEditarOsTexto.ActiveForm;
                OsEditar.Show();
                OsEditar.Top = 0;
                OsEditar.Left = 0;
            }
        }

        public FormOSPesquisaEditar()
        {
            InitializeComponent();
        }

        //CHAMA O METODO CancelaCadastradoCliente QUE FECHA FORMULÁRIOS ABERTOS
        public void FecharFormulario()
        {
            CancelaEditorOs(typeof(FormOSPesquisaEditar));
            CancelaEditorOs(typeof(FormClientesContatos));

        }
        //METODO PARA VERIFICA SE O FORMULÁRIO ESTA ABERTO SE TIVER ELE FECHA!
        public static void CancelaEditorOs(Type frmType)
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
        private void buttonFecharOs_Click(object sender, EventArgs e)
        {
            FecharFormulario();
        }
        private void buttonVerifica_Click(object sender, EventArgs e)
        {
            SalvarAlteracaoOS();
        }
        public void SalvarAlteracaoOS()
        {
            try
            {
                buttonAnexo.Enabled = false;
                buttonAnexo.Visible = false;

                int MS = 0;

                //Acessa Banco de Dados e Salvar Alteração da Os
                Conexao conexao = new Conexao(this.connetionString);
                DALOrdemServico da = new DALOrdemServico(conexao);

                //Acessa Banco de Dados e Salvar Imagem 
                Conexao conexao1 = new Conexao(this.connetionString);
                DALOrdemServico da1 = new DALOrdemServico(conexao1);

                Os cadastra = new Os();

                cadastra.IdOs = IdOs;
                cadastra.IdPessoaLogadaAlterada = IdPessoaLogada;
                cadastra.OrigemChamado = txtOrigemChamado.Text;
                cadastra.ServicosExecutados = txtServicoExecutado.Text;
                cadastra.MudancaDataFechamento = 0;
                cadastra.IdContato = this.IdContato;

                if (checkBoxSituacao.Checked == false)
                {
                    cadastra.Situacao = 2;
                }
                if (checkBoxSituacao.Checked == true)
                {
                    cadastra.Situacao = 1;
                }

                //VERIFICA SE IMAGEM CONSTA NO SISTEMA! 
                SqlConnection conn = new SqlConnection(this.connetionString);

                SqlDataAdapter da2 = new SqlDataAdapter("EXEC D_O_ConsultaOsImagemValidar " + IdOs + ";", conn);
                DataSet ds2 = new DataSet();
                da2.Fill(ds2);
                //----------------------------------------------------------------------------------------------

                OsImagem Imagem = new OsImagem();

                Imagem.IdOs = IdOs;

                if (bmp == null)
                {
                    VerficidorImagem = 1;
                }
                if (bmp != null)
                {
                    MemoryStream memory = new MemoryStream();

                    bmp.Save(memory, ImageFormat.Bmp);

                    byte[] Foto = memory.ToArray();

                    Imagem.Imagem = Foto;
                }

                if (operacao == "Editar")
                {

                    if (checkBoxFinalizarOS.Checked == false)
                    {
                        if ((maskedTxtHorarioInicio.Text == "") && (maskedTxtHorarioFInal.Text == ""))
                        {
                            FecharFormulario();

                            cadastra.Estado = 1;

                            da.AlteraOS(cadastra);

                            if (pictureBoxImagem.Image != null)
                            {
                                if (ds2.Tables[0].Rows.Count == 0)
                                {
                                    MS++;
                                    da1.IncluirOsImagem(Imagem);
                                }
                                if (ds2.Tables[0].Rows.Count > 0)
                                {
                                    MS++;
                                    da1.AlterarOsImagem(Imagem);
                                }
                            }
                            switch (MS)
                            {
                                case 0:
                                    MessageBox.Show("Alteração da ordem de serviço realizada com sucesso!");
                                    break;
                                case 1:
                                    MessageBox.Show("Alteração da ordem de serviço realizada com sucesso! - Imagem salva!");
                                    break;
                                case 2:
                                    MessageBox.Show("Alteração da ordem de serviço realizada com sucesso! - Imagem Alterada!");
                                    break;
                            }
                        }

                        if (!(maskedTxtHorarioInicio.Text == "") && !(maskedTxtHorarioFInal.Text == ""))
                        {
                            FecharFormulario();

                            cadastra.Estado = 2;

                            cadastra.HorarioInicio = maskedTxtHorarioInicio.Text;
                            cadastra.HorarioFinal = maskedTxtHorarioFInal.Text;

                            da.AlteraOS(cadastra);

                            if (pictureBoxImagem.Image != null)
                            {
                                if (ds2.Tables[0].Rows.Count == 0)
                                {
                                    MS++;
                                    da1.IncluirOsImagem(Imagem);
                                }
                                if (ds2.Tables[0].Rows.Count > 0)
                                {
                                    MS++;
                                    da1.AlterarOsImagem(Imagem);
                                }
                            }
                            switch (MS)
                            {
                                case 0:
                                    MessageBox.Show("Alteração da ordem de serviço realizada com sucesso! - Em Processo!");
                                    break;
                                case 1:
                                    MessageBox.Show("Alteração da ordem de serviço realizada com sucesso! - Em Processo! - Imagem salva!");
                                    break;
                                case 2:
                                    MessageBox.Show("Alteração da ordem de serviço realizada com sucesso! -Em Processo!- Imagem Alterada!");
                                    break;
                            }
                        }
                        else if ((!(maskedTxtHorarioFInal.Text == "") && (maskedTxtHorarioInicio.Text == ""))
                            || ((maskedTxtHorarioFInal.Text == "") && !(maskedTxtHorarioInicio.Text == "")))
                        {
                            MessageBox.Show("O horário não foi preenchido corretamente! ");
                        }
                    }
                    if (checkBoxFinalizarOS.Checked == true)
                    {
                        if (comboBoxContato.Text == "")
                        {
                            MessageBox.Show("Não pode se finalizado OS sem o contato do Cliente!");
                        }
                        if (!(comboBoxContato.Text == ""))
                        {
                            if ((OrigemChamado(txtOrigemChamado, errorProviderOS) == true) && (ServicoExecutados(txtServicoExecutado, errorProviderOS) == true))
                            {
                                if (!(maskedTxtHorarioInicio.Text == "") && !(maskedTxtHorarioFInal.Text == ""))
                                {
                                    FecharFormulario();

                                    cadastra.Estado = 3;

                                    cadastra.HorarioInicio = maskedTxtHorarioInicio.Text;
                                    cadastra.HorarioFinal = maskedTxtHorarioFInal.Text;

                                    da.AlteraOS(cadastra);

                                    if (pictureBoxImagem.Image != null)
                                    {
                                        if (ds2.Tables[0].Rows.Count == 0)
                                        {
                                            MS++;
                                            da1.IncluirOsImagem(Imagem);
                                        }
                                        if (ds2.Tables[0].Rows.Count > 0)
                                        {
                                            MS++;
                                            da1.AlterarOsImagem(Imagem);
                                        }
                                    }
                                    switch (MS)
                                    {
                                        case 0:
                                            MessageBox.Show("Alteração da ordem de serviço realizada com sucesso! - Finalizado serviço!");
                                            break;
                                        case 1:
                                            MessageBox.Show("Alteração da ordem de serviço realizada com sucesso! - Finalizado serviço - Imagem salva!");
                                            break;
                                        case 2:
                                            MessageBox.Show("Alteração da ordem de serviço realizada com sucesso! -Finalizado serviço- Imagem Alterada!");
                                            break;
                                    }
                                }
                                if ((maskedTxtHorarioInicio.Text == "") && (maskedTxtHorarioFInal.Text == ""))
                                {
                                    MessageBox.Show("O horário não foi preenchido corretamente! ");
                                }
                                else if ((!(maskedTxtHorarioFInal.Text == "") && (maskedTxtHorarioInicio.Text == ""))
                                    || ((maskedTxtHorarioFInal.Text == "") && !(maskedTxtHorarioInicio.Text == "")))
                                {
                                    MessageBox.Show("O horário não foi preenchido corretamente! ");
                                }
                            }   
                        }
                    }

                    //if ((maskedTxtHorarioInicio.Text == "") && (maskedTxtHorarioFInal.Text == "") && (bmp == null))
                    //{
                    //    if (checkBoxFinalizarOS.Checked == false)
                    //    {
                    //        FecharFormulario();

                    //        cadastra.Estado = 1;

                    //        da.AlteraOS(cadastra);

                    //        MessageBox.Show("Alteração da ordem de serviço realizada com sucesso! ");
                    //    }

                    //    if ((checkBoxFinalizarOS.Checked == true) && (comboBoxContato.Text == ""))
                    //    {
                    //        MessageBox.Show("A ordem de serviço não pode se finalizada sem o preenchimento de horário inicial e horário final!" + "\n" + "E sem o contato do Cliente!");
                    //    }
                    //}
                    //if ((maskedTxtHorarioInicio.Text == "") && (maskedTxtHorarioFInal.Text == "") && !(bmp == null))
                    //{
                    //    if (checkBoxFinalizarOS.Checked == false)
                    //    {
                    //        FecharFormulario();

                    //        cadastra.Estado = 1;

                    //        conn.Open();

                    //        if (ds2.Tables[0].Rows.Count > 0)
                    //        {
                    //            da.AlteraOS(cadastra);
                    //            da1.AlterarOsImagem(Imagem);
                    //        }
                    //        if (!(ds2.Tables[0].Rows.Count > 0))
                    //        {
                    //            da.AlteraOS(cadastra);
                    //            da1.IncluirOsImagem(Imagem);
                    //        }
                    //        conn.Close();

                    //        MessageBox.Show("Alteração da ordem de serviço realizada com sucesso! - Imagem Salva!");
                    //    }
                    //    if ((checkBoxFinalizarOS.Checked == true) && (comboBoxContato.Text == ""))
                    //    {
                    //        MessageBox.Show("A ordem de serviço não pode se finalizada sem o preenchimento de horário inicial e horário final!" + "\n" + "E sem o contato do Cliente!");
                    //    }
                    //}
                    //if ((checkBoxFinalizarOS.Checked == true) && (bmp == null) && !(comboBoxContato.Text == "") && (maskedTxtHorarioInicio.Text == "") && (maskedTxtHorarioFInal.Text == ""))
                    //{
                    //    MessageBox.Show("A ordem de serviço não pode se finalizada sem o horário Informado!");
                    //}
                    //if ((checkBoxFinalizarOS.Checked == true) && !(bmp == null) && !(comboBoxContato.Text == "") && (maskedTxtHorarioInicio.Text == "") && (maskedTxtHorarioFInal.Text == ""))
                    //{
                    //    MessageBox.Show("A ordem de serviço não pode se finalizada sem o horário inicial e final!");
                    //}
                    ////if ((!(maskedTxtHorarioInicio.Text == "") && (maskedTxtHorarioFInal.Text == "")) || ((maskedTxtHorarioInicio.Text == "") && !(maskedTxtHorarioFInal.Text == "")))
                    //if (checkBoxSituacao.Checked == false)
                    //{
                    //    if ((maskedTxtHorarioFInal.Text == "") || (maskedTxtHorarioInicio.Text == ""))
                    //    {

                    //    }
                    //}
                    //if (checkBoxSituacao.Checked == true)
                    //{
                    //    if (!(maskedTxtHorarioFInal.Text == "") && (maskedTxtHorarioInicio.Text == ""))
                    //    {
                    //        MessageBox.Show("O horário não foi preenchido corretamente! ");
                    //    }
                    //    if ((maskedTxtHorarioFInal.Text == "") && !(maskedTxtHorarioInicio.Text == ""))
                    //    {
                    //        MessageBox.Show("O horário não foi preenchido corretamente! ");
                    //    }
                    //}


                    ////--------------
                    //if (!(maskedTxtHorarioInicio.Text == "") && !(maskedTxtHorarioFInal.Text == "") && (bmp == null))
                    //{
                    //    if (checkBoxFinalizarOS.Checked == false)
                    //    {
                    //        FecharFormulario();
                    //        cadastra.Estado = 2;
                    //        cadastra.HorarioInicio = maskedTxtHorarioInicio.Text;
                    //        cadastra.HorarioFinal = maskedTxtHorarioFInal.Text;

                    //        if (ds2.Tables[0].Rows.Count > 0)
                    //        {
                    //            da.AlteraOS(cadastra);
                    //        }
                    //        if (!(ds2.Tables[0].Rows.Count > 0))
                    //        {
                    //            da.AlteraOS(cadastra);
                    //        }

                    //        MessageBox.Show("Alteração da ordem de serviço realizada com sucesso! - Em Processo! - Sem imagem!");
                    //    }
                    //    if ((checkBoxFinalizarOS.Checked == true) && (bmp == null) && !(comboBoxContato.Text == ""))
                    //    {
                    //        DialogResult dialogResult = MessageBox.Show("Deseja finalizar a ordem de Serviço!", "Aviso", MessageBoxButtons.YesNo);
                    //        if (dialogResult == DialogResult.Yes)
                    //        {
                    //            FecharFormulario();
                    //            cadastra.MudancaDataFechamento = 1;
                    //            cadastra.Estado = 3;
                    //            cadastra.HorarioInicio = maskedTxtHorarioInicio.Text;
                    //            cadastra.HorarioFinal = maskedTxtHorarioFInal.Text;

                    //            panel.Enabled = false;
                    //            buttonEditarOSe.Enabled = false;
                    //            buttonVerifica.Enabled = false;

                    //            da.AlteraOS(cadastra);

                    //            MessageBox.Show("Alteração da ordem de serviço realizada com sucesso! - Já Finalizada! - Sem imagem!");

                    //        }
                    //        else if (dialogResult == DialogResult.No)
                    //        {

                    //        }
                    //    }
                    //    else if ((checkBoxFinalizarOS.Checked == true) && (bmp == null) && (comboBoxContato.Text == ""))
                    //    {
                    //        MessageBox.Show("As aterações não podem se realizada sem um contato do cliente cadastrado!");
                    //    }

                    //    if ((checkBoxFinalizarOS.Checked == true) && !(bmp == null) && !(comboBoxContato.Text == ""))
                    //    {
                    //        DialogResult dialogResult = MessageBox.Show("Deseja finalizar a ordem de Serviço!", "Aviso", MessageBoxButtons.YesNo);
                    //        if (dialogResult == DialogResult.Yes)
                    //        {
                    //            FecharFormulario();
                    //            cadastra.MudancaDataFechamento = 1;
                    //            cadastra.Estado = 3;
                    //            cadastra.HorarioInicio = maskedTxtHorarioInicio.Text;
                    //            cadastra.HorarioFinal = maskedTxtHorarioFInal.Text;

                    //            panel.Enabled = false;
                    //            buttonEditarOSe.Enabled = false;
                    //            buttonVerifica.Enabled = false;

                    //            conn.Open();

                    //            if (ds2.Tables[0].Rows.Count > 0)
                    //            {
                    //                da.AlteraOS(cadastra);
                    //                da1.AlterarOsImagem(Imagem);
                    //            }
                    //            if (!(ds2.Tables[0].Rows.Count > 0))
                    //            {
                    //                da.AlteraOS(cadastra);
                    //                da1.IncluirOsImagem(Imagem);
                    //            }
                    //            conn.Close();

                    //            MessageBox.Show("Alteração da ordem de serviço realizada com sucesso! - Já Finalizada! - Imagem salva!");

                    //        }
                    //        else if (dialogResult == DialogResult.No)
                    //        {
                    //            MessageBox.Show("Sem Salvar não ocorre alteração!");
                    //        }
                    //    }
                    //    else if ((checkBoxFinalizarOS.Checked == true) && !(bmp == null) && (comboBoxContato.Text == ""))
                    //    {
                    //        MessageBox.Show("As aterações não podem se realizada sem um contato do cliente cadastrado!");
                    //    }


                    //}

                    ////--
                    //else if (!(maskedTxtHorarioInicio.Text == "") && !(maskedTxtHorarioFInal.Text == "") && !(bmp == null))
                    //{
                    //    if (checkBoxFinalizarOS.Checked == false)
                    //    {
                    //        FecharFormulario();
                    //        cadastra.Estado = 2;
                    //        cadastra.HorarioInicio = maskedTxtHorarioInicio.Text;
                    //        cadastra.HorarioFinal = maskedTxtHorarioFInal.Text;

                    //        if (ds2.Tables[0].Rows.Count > 0)
                    //        {
                    //            da.AlteraOS(cadastra);
                    //            da1.AlterarOsImagem(Imagem);
                    //        }
                    //        if (!(ds2.Tables[0].Rows.Count > 0))
                    //        {
                    //            da.AlteraOS(cadastra);
                    //            da1.IncluirOsImagem(Imagem);
                    //        }

                    //        MessageBox.Show("Alteração da ordem de serviço realizada com sucesso! - Em Processo! - Imagem Salva!");
                    //    }
                    //    if ((checkBoxFinalizarOS.Checked == true) && (bmp == null) && !(comboBoxContato.Text == ""))
                    //    {
                    //        DialogResult dialogResult = MessageBox.Show("Deseja finalizar a ordem de Serviço!", "Aviso", MessageBoxButtons.YesNo);
                    //        if (dialogResult == DialogResult.Yes)
                    //        {
                    //            FecharFormulario();
                    //            cadastra.MudancaDataFechamento = 1;
                    //            cadastra.Estado = 3;
                    //            cadastra.HorarioInicio = maskedTxtHorarioInicio.Text;
                    //            cadastra.HorarioFinal = maskedTxtHorarioFInal.Text;


                    //            panel.Enabled = false;
                    //            buttonEditarOSe.Enabled = false;
                    //            buttonVerifica.Enabled = false;

                    //            da.AlteraOS(cadastra);

                    //            MessageBox.Show("Alteração da ordem de serviço realizada com sucesso! - Já Finalizada! - Sem imagem!");

                    //        }
                    //        else if (dialogResult == DialogResult.No)
                    //        {

                    //        }
                    //    }
                    //    else if ((checkBoxFinalizarOS.Checked == true) && (bmp == null) && (comboBoxContato.Text == ""))
                    //    {
                    //        MessageBox.Show("As aterações não podem se realizada sem um contato do cliente lançado!");
                    //    }
                    //    if ((checkBoxFinalizarOS.Checked == true) && !(bmp == null) && !(comboBoxContato.Text == ""))
                    //    {
                    //        DialogResult dialogResult = MessageBox.Show("Deseja finalizar a ordem de Serviço!", "Aviso", MessageBoxButtons.YesNo);
                    //        if (dialogResult == DialogResult.Yes)
                    //        {
                    //            FecharFormulario();
                    //            cadastra.MudancaDataFechamento = 1;
                    //            cadastra.Estado = 3;
                    //            cadastra.HorarioInicio = maskedTxtHorarioInicio.Text;
                    //            cadastra.HorarioFinal = maskedTxtHorarioFInal.Text;

                    //            panel.Enabled = false;
                    //            buttonEditarOSe.Enabled = false;
                    //            buttonVerifica.Enabled = false;

                    //            conn.Open();

                    //            if (ds2.Tables[0].Rows.Count > 0)
                    //            {
                    //                da.AlteraOS(cadastra);
                    //                da1.AlterarOsImagem(Imagem);
                    //            }
                    //            if (!(ds2.Tables[0].Rows.Count > 0))
                    //            {
                    //                da.AlteraOS(cadastra);
                    //                da1.IncluirOsImagem(Imagem);
                    //            }
                    //            conn.Close();

                    //            MessageBox.Show("Alteração da ordem de serviço realizada com sucesso! - Já Finalizada! - Imagem Salva!");

                    //        }
                    //        else if (dialogResult == DialogResult.No)
                    //        {
                    //            MessageBox.Show("Sem Salvar não ocorre alteração!");
                    //        }
                    //    }
                    //    else if ((checkBoxFinalizarOS.Checked == true) && !(bmp == null) && (comboBoxContato.Text == ""))
                    //    {
                    //        MessageBox.Show("As aterações não podem se realizada sem um contato do cliente lançado!");
                    //    }
                    //}


                }
            }
            catch(Exception ex)
            {
                ex.ToString();
            }
        }
        private void FormOSPesquisaEditar_Load(object sender, EventArgs e)
        {
            //InitializeComponent();
        }
        

        //LISTA OS Contatos da empresa Buscada
        private void Fill_listBoxContatos()
        {
            SqlConnection connection = new SqlConnection(this.connetionString);

            try
            {
                connection.Open();
                string Query = "EXEC D_O_ConsultaCadastroIdContatosOS " + this.IdCliente  + ";";


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
        private void comboBoxContato_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(this.connetionString);

            try
            {
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
        private void buttonEditarOSe_Click(object sender, EventArgs e)
        {
            if (OsEditar == 0)
            {
                MessageBox.Show("Acesso não Permitido!");
            }
            if (OsEditar == 1)
            {
                this.operacao = "Editar";

                buttonAnexo.Enabled = true;
                buttonAnexo.Visible = true;


                if (this.status == 1)
                {
                    AlteraBotoes(1);
                }
                if (this.status == 2)
                {
                    AlteraBotoes(2);
                }
                if (this.status == 3)
                {
                    AlteraBotoes(3);
                }
            }
        }
        public void AlteraBotoes(int op)
        {
            if (op == 1)// Editar
            {
                this.panel.Enabled = true;
                this.buttonEditarOSe.Enabled = false;
                this.buttonVerifica.Enabled = true;

                this.txtOrigemChamado.Enabled = true;
                this.txtServicoExecutado.Enabled = true;
                this.maskedTxtHorarioInicio.Enabled = true;
                this.maskedTxtHorarioFInal.Enabled = true;
                this.checkBoxFinalizarOS.Enabled = true;
            }
            if (op == 2)//Tela De Alteração Bloqueiada!
            {
                this.panel.Enabled = true;
                this.buttonEditarOSe.Enabled = false;
                this.buttonVerifica.Enabled = true;

                this.txtOrigemChamado.Enabled = true;
                this.txtServicoExecutado.Enabled = true;
                this.maskedTxtHorarioInicio.Enabled = false;
                this.maskedTxtHorarioFInal.Enabled = false;
                this.checkBoxFinalizarOS.Enabled = true;

                // ButtonEditarFornecedorFisica.Enabled = true;
            }
            if (op == 3) //Tela Editar Cadastro Fisico!
            {
                this.panel.Enabled = false;
                this.buttonEditarOSe.Enabled = false;
                this.buttonVerifica.Enabled = false;

                this.txtOrigemChamado.Enabled = false;
                this.txtServicoExecutado.Enabled = false;
                this.maskedTxtHorarioInicio.Enabled = false;
                this.maskedTxtHorarioFInal.Enabled = false;
                this.checkBoxFinalizarOS.Enabled = false;

            }
        }

        private void buttonImprimir_Click(object sender, EventArgs e)
        {
            if (printDialogTexto.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                printDocumentTexto.PrinterSettings = printDialogTexto.PrinterSettings;
                printDocumentTexto.Print();
            }
        }
        public static string Ver(string ver)
        {
            try
            {
                string ServicoExecutado2 = "";

                if (!string.IsNullOrWhiteSpace(ver))
                {
                    //this.Width = 1071;
                    //this.Height = 387;
                    string[] str = ver.Split('\r');
                    for (int i = 0; i < str.Length; i++)
                    {
                        str[i] = str[i].Replace("\n", "");
                        ServicoExecutado2 = str[i];

                        //lbTexto.Items.Add(str[i]);
                    }
                }           

                return ServicoExecutado2;
            }
            catch (Exception exp)
            {
                return exp.ToString();
            }
        }



        //public static string InsereQuebraTeste(string TEXTO_GRANDE)
        //{
        //    try
        //    {
        //        int margemLinha = 77;

        //        int i = 0;

        //        int j = 0;

        //        string ServicoExecutado2 = "";

        //        int quantString = TEXTO_GRANDE.Length;

        //        int total = quantString / 77;

        //        StringBuilder sb = new StringBuilder(TEXTO_GRANDE);       

        //        string StringTeste = TEXTO_GRANDE;
        //        string TextoMostrar = "";
        //        string temp = "";

        //        //NÃO A QUEBRA DE LINHA SE FOR SÓ UMA LINHA
        //        if (quantString <= margemLinha)
        //        {
        //            ServicoExecutado2 = sb.ToString();
        //        }
        //        //QUEBRA DE LINHA SE FOR MAS QUE UMA LINHA

        //        if (quantString > margemLinha)
        //        {
        //            while(quantString > margemLinha)
        //            {
        //                if (StringTeste[margemLinha] == ' ')
        //                {
        //                    temp = sb.ToString();

        //                    sb.Insert(margemLinha, '\n');

        //                    TextoMostrar = sb.ToString();

        //                    ServicoExecutado2 = TextoMostrar;

        //                    StringBuilder sb2 = new StringBuilder(temp);

        //                    sb = sb2;

        //                    sb.Remove(0, margemLinha);

        //                    sb.ToString();

        //                    int contador = 0;

        //                    for (i = 0; i < temp.Length; i++)
        //                    {
        //                        if ((temp[i] == ' '))
        //                        {
        //                            contador++;
        //                        }
        //                        if (!(temp[i] == ' '))
        //                        {
        //                            break;
        //                        }
        //                    }
        //                    sb.Remove(0, contador);

        //                    string quantStringResta = "";

        //                    quantStringResta = sb.ToString();

        //                    quantString = quantStringResta.Length;

        //                    break;

        //                }
        //                if (!(StringTeste[margemLinha] == ' '))
        //                {
        //                    for (i = 0; i < margemLinha; margemLinha--)
        //                    {
        //                        if (StringTeste[margemLinha] == ' ')
        //                        {
        //                            temp = sb.ToString();

        //                            sb.Insert(margemLinha + 1, '\n');

        //                            TextoMostrar = sb.ToString();

        //                            ServicoExecutado2 = TextoMostrar;

        //                            StringBuilder sb2 = new StringBuilder(temp);

        //                            sb = sb2;

        //                            sb.Remove(0, margemLinha);

        //                            sb.ToString();

        //                            int contador = 0;

        //                            for (j = 0; j < temp.Length; j++)
        //                            {
        //                                if ((temp[j] == ' '))
        //                                {
        //                                    contador++;
        //                                }
        //                                if (!(temp[j] == ' '))
        //                                {
        //                                    break;
        //                                }
        //                            }
        //                            sb.Remove(0, contador);

        //                            string quantStringResta = "";

        //                            quantStringResta = sb.ToString();

        //                            quantString = quantStringResta.Length;

        //                            break;
        //                        }
        //                    }
        //                }
        //            }                    
        //        }

        //        return ServicoExecutado2;
        //    }
        //    catch (Exception exp)
        //    {
        //        return exp.ToString();
        //    }
        //}


        public static string InsereQuebraPrincipal(string TEXTO_GRANDE)
        {
            try
            {
                int margemLinha = 72;

                int i = 0;

                string ServicoExecutado2 = "";

                Boolean finalizar = false;

                int quantString = TEXTO_GRANDE.Length;

                int total = quantString / 77;

                StringBuilder sb = new StringBuilder(TEXTO_GRANDE);

                string StringTeste = TEXTO_GRANDE;

                //NÃO A QUEBRA DE LINHA SE FOR SÓ UMA LINHA
                if (quantString <= margemLinha)
                {
                    ServicoExecutado2 = sb.ToString();
                }
                //QUEBRA DE LINHA SE FOR MAS QUE UMA LINHA

                if (quantString > margemLinha)
                {

                    if (finalizar == false)
                    {
                        if (StringTeste[margemLinha] == ' ')
                        {
  
                            sb.Insert(margemLinha, '\n');
                        }

                        if (!(StringTeste[margemLinha] == ' '))
                        {
                            for(i = 0; i < margemLinha; margemLinha--)
                            {
                                if (StringTeste[margemLinha] == ' ')
                                {
                                    string TextoMostrar = "";


                                    sb.Insert(margemLinha + 1, '\n');

                                    TextoMostrar = sb.ToString();
                                 
                                    ServicoExecutado2 = TextoMostrar;

                                    break;
                                }
                            } 

                        }

                        //ServicoExecutado2 = sb.ToString();

                        //acumuladorTemp = 77 + margemLinha;//acumulador2

                        //if (acumuladorTemp > quantString)
                        //{
                        //    finalizar = true;
                        //}
                        //if (acumuladorTemp < quantString)
                        //{
                        //    margemLinha = acumuladorTemp;
                        //}


                        //if (!(StringTeste[margemLinha] == ' '))
                        //{
                        //    for (n = (margemLinha); n > 0; n--)
                        //    {
                        //        if (StringTeste[n] == ' ')
                        //        {
                        //            sb.Insert(n + 1, '\n');

                        //            ServicoExecutado2 = sb.ToString();

                        //            acumuladorTemp = 77 + margemLinha;//n

                        //            n = 0;

                        //            if (acumuladorTemp > quantString)
                        //            {
                        //                finalizar = true;
                        //                //REMOVE O INICIO DO CARACTERES EM BRANCO DA ULTIMA LINHA
                        //                for (intTotal = ((total * 77)); intTotal > 0; intTotal--)
                        //                {
                        //                    if (ServicoExecutado2[intTotal] == ' ')
                        //                    {
                        //                        //sb.Remove(intTotal, 5);
                        //                        sb.Remove(intTotal, 1);
                        //                        ServicoExecutado2 = sb.ToString();

                        //                        intTotal = 0;
                        //                    }
                        //                }
                        //            }
                        //            if (acumuladorTemp < quantString)
                        //            {
                        //                margemLinha = acumuladorTemp;
                        //            }
                        //        }
                        //    }
                        //}
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
        private void buttonAnexo_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = "JPG Files(*.jpg)|*.jpg|JPG Files(*.png)|*.png";// all files(*.*) | *.*

            DialogResult dialogResult = MessageBox.Show("Deseja Anexa uma imagem!", "Aviso", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    openFileDialog.ShowDialog();

                    ImgLocation = openFileDialog.FileNames.ToString();

                    label15.Text = openFileDialog.FileName;

                    pictureBoxImagem.Image = Image.FromFile(openFileDialog.FileName);

                    bmp = new Bitmap(label15.Text);
                }
                catch (Exception ex)
                {
                    ex.ToString();
                }


            }
            else if (dialogResult == DialogResult.No)
            {
                MessageBox.Show("Cancelado o Anexo da Imagem!");
            }
        }

        private void buttonAbrirAnexo_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(this.connetionString);
            SqlCommand comand = new SqlCommand("D_O_ConsultaOsImagemSalva " + IdOs + ";", conn);
            conn.Open();

            SqlDataReader reader = comand.ExecuteReader();

            if (reader.Read())
            {
                byte[] Foto = (byte[])reader["IMAGEM"];
                MemoryStream ms = new MemoryStream(Foto);
                Imagem = Image.FromStream(ms);
            }
            if (Imagem == null)
            {
                MessageBox.Show("Não existir Imagem!");
            }
            if (Imagem != null)
            {
                pictureBoxImagem.Image = Imagem;
            }
        }
        private void printDocumentImagem_PrintPage(object sender, PrintPageEventArgs e)
        {
            if (Imagem == null)
            {
                MessageBox.Show("Carrega a Foto Antes dese Impresso!");
            }
            if (Imagem != null)
            {
                Point p = new Point(0, 0);
                e.Graphics.DrawImage(Imagem, p);
            }
        }

        private void buttonImprimirImagemOS_Click(object sender, EventArgs e)
        {
            printPreviewDialogImagem.Document = printDocumentImagem;
            printPreviewDialogImagem.ShowDialog();
        }
        private void adicionarContato_Click(object sender, EventArgs e)
        {
            if (ClienteCCadastra == 0)
            {
                MessageBox.Show("Acesso não Permitido!");
            }
            if (ClienteCCadastra == 1)
            {
                connetionString.ToString();
                //FecharTodosFormulario();
                FormCadastraContatoRegistro cadastracliente = new FormCadastraContatoRegistro(this.IdCliente, this.connetionString);
                cadastracliente.MdiParent = FormCadastraContatoRegistro.ActiveForm;
                cadastracliente.Show();
                cadastracliente.Top = 0;
                cadastracliente.Left = 0;
            }
        }

        private void buttonAtualizarContatos_Click(object sender, EventArgs e)
        {
            comboBoxContato.Items.Clear();
            Fill_listBoxContatos();
        }

        private void printDocumentTexto_PrintPage(object sender, PrintPageEventArgs e)
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
            e.Graphics.DrawString("" + txtNomeOS.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(162, 176));
            e.Graphics.DrawString("" + txtMsOs.Text, new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(646, 173));
            e.Graphics.DrawString("" + txtEnderecoOS.Text + "," + txtBairroNumero.Text + "," + txtComplOs.Text + "-" + txtBairroOS.Text + "-" + txtCidadeOs.Text + ".", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(162, 201));//+ txtTipo_logradouro.Text + ": "
            e.Graphics.DrawString("" + this.ComboBoxAbreviacao, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(162, 222));
            e.Graphics.DrawString("" + txtTelefoneOs.TextMaskFormat,new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(162, 250));
            e.Graphics.DrawString("" + txtNomeFuncionario.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(162, 947));
            e.Graphics.DrawString("" + (txtOrigemChamado.Text), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(12, 305));
            e.Graphics.DrawString("" + (txtServicoExecutado.Text), new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(12, 485));
            e.Graphics.DrawString("" + HorarioInicial, new Font("Arial", 15, FontStyle.Italic), Brushes.Black, new Point(220, 1032));
            e.Graphics.DrawString("" + HorarioFInal, new Font("Arial", 15, FontStyle.Italic), Brushes.Black, new Point(510, 1032));
        }

        private void buttonImprimirOS_Click(object sender, EventArgs e)
        {
            printPreviewDialogVisualizacao.Document = printDocumentTexto;
            printPreviewDialogVisualizacao.ShowDialog();
        }


        private void buttonDeletar_Click(object sender, EventArgs e)
        {
            int i  = 0;
            int Errado = 0;

            StringBuilder Horario = new StringBuilder(maskedTxtHorarioInicio.Text);
            string HorarioPassado = maskedTxtHorarioInicio.Text;
            HorarioPassado.ToString();


            Horario.Length.ToString();
            for (i = 0; i < 4; i++)
            {
                if (HorarioPassado[i] == ' ')
                {
                    Errado = Errado + 1;
                }
                Errado.ToString();
                HorarioPassado[i].ToString();
            }
            MessageBox.Show("Errado: " + Errado.ToString());



            //if (OsExcluir == 0)
            //{
            //    MessageBox.Show("Acesso não Permitido!");
            //}
            //if (OsExcluir == 1)
            //{
            //    DialogResult d = MessageBox.Show("Deseja Excluir a Ordem de Serviço N°: " + IdOs, "Aviso", MessageBoxButtons.YesNo);

            //    Conexao conexao = new Conexao(this.connetionString);
            //    DALOrdemServico dal = new DALOrdemServico(conexao);

            //    if (d.ToString() == "Yes")
            //    {
            //        dal.ExcluirOs(this.IdOs);
            //        ExcluidoOS = true;
            //        FecharFormulario();                  
            //    }
            //    if (d.ToString() == "No")
            //    {

            //    }
            //}
        }
        private void buttonImprimirImagem_Click(object sender, EventArgs e)
        {

        }
        private void FormOSPesquisaEditar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
            {
                this.Close();
            }
        }
        private void buttonAbrirArquivo_Click(object sender, EventArgs e)
        {
            FormEditarOsTexto OsEditar = new FormEditarOsTexto(txtOrigemChamado.Text, txtServicoExecutado.Text);
            OsEditar.MdiParent = FormEditarOsTexto.ActiveForm;
            OsEditar.Show();
            OsEditar.Top = 0;
            OsEditar.Left = 0;
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

        private void txtServicoExecutado_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                int tamanhoMaximoPorLinha = 105;
                int[] keysLiberadas = { (int)Keys.Enter, (int)Keys.Back };

                int posicaoAtual = txtServicoExecutado.SelectionStart;
                int linhaAtual = txtServicoExecutado.GetLineFromCharIndex(posicaoAtual);

                if (txtServicoExecutado.Lines.Length == 0)
                {
                    if (txtServicoExecutado.Text.Length > tamanhoMaximoPorLinha && !keysLiberadas.Contains((int)e.KeyChar))
                    {
                        e.Handled = true;
                    }
                }
                else if (txtServicoExecutado.Lines[linhaAtual].Length > tamanhoMaximoPorLinha && !keysLiberadas.Contains((int)e.KeyChar))
                {
                    e.Handled = true;
                }
            }
            catch(Exception)
            {
                if (e.KeyChar == (char)Keys.Back)
                {
                    e.Handled = false;
                }else { e.Handled = true; }              
            }
        }
    }
}
