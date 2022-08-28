//public partial class FormPesquisaFuncionarioEditar : Form
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
    public partial class FormPesquisaLoginUsuarioEditar : Form
    {
        string Operacao = "";
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
        private int USUARIOACESSO = 0;
        public int UsuarioAcesso
        {
            get
            {
                return this.USUARIOACESSO;

            }
            set
            {
                this.USUARIOACESSO = value;
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
        private int USUARIOALTERAR = 0;
        public int UsuarioAlterar
        {
            get
            {
                return this.USUARIOALTERAR;

            }
            set
            {
                this.USUARIOALTERAR = value;
            }
        }
        private int USUARIOEXCLUIR = 0;
        public int UsuarioExcluir
        {
            get
            {
                return this.USUARIOEXCLUIR;

            }
            set
            {
                this.USUARIOEXCLUIR = value;
            }
        }
        private int USUARIOVISUALIZAR = 0;
        public int UsuarioVisualizar
        {
            get
            {
                return this.USUARIOVISUALIZAR;

            }
            set
            {
                this.USUARIOVISUALIZAR = value;
            }
        }
        private string NOMEACESSOSISTEMA = "";
        public string NomeAcessoSistema
        {
            get
            {
                return this.NOMEACESSOSISTEMA;

            }
            set
            {
                this.NOMEACESSOSISTEMA = value;
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


        public FormPesquisaLoginUsuarioEditar(string NomeServidor, string NomeBaseDados, string NomeUsuario, string SenhaBaseDados)
        {
            InitializeComponent();

            this.NomeServidor = NomeServidor;
            this.NomeBaseDados = NomeBaseDados;
            this.NomeUsuario = NomeUsuario;
            this.SenhaBaseDados = SenhaBaseDados;

            this.connetionString = "Data Source=" + this.NomeServidor + ";Initial Catalog=" + this.NomeBaseDados + ";Persist Security Info=True;User ID=" + this.NomeUsuario + ";Password=" + this.SenhaBaseDados + ";";
        }
        public FormPesquisaLoginUsuarioEditar(int IdPessoa,string NOMEACESSO,int USUARIOACESSO,int USUARIOALTERAR,int USUARIOEXCLUIR,
            string NomeServidor, string NomeBaseDados, string NomeUsuario, string SenhaBaseDados)
        {
            InitializeComponent();

            this.NomeServidor = NomeServidor;
            this.NomeBaseDados = NomeBaseDados;
            this.NomeUsuario = NomeUsuario;
            this.SenhaBaseDados = SenhaBaseDados;
            this.connetionString = "Data Source=" + this.NomeServidor + ";Initial Catalog=" + this.NomeBaseDados + ";Persist Security Info=True;User ID=" + this.NomeUsuario + ";Password=" + this.SenhaBaseDados + ";";


            txtNomeFuncionario.MaxLength = 50;

            txtAbreviacaoFuncionario.MaxLength = 20;

            txtUsuarioLoginFuncionario.MaxLength = 20;

            txtSenhaFuncionario.MaxLength = 20;

            txtConfirmacaoSenhaFuncionario.MaxLength = 20;

            txtObservacaoFuncionario.MaxLength = 20;
            this.IdPessoa = IdPessoa;
            this.NomeAcesso = NOMEACESSO;
            this.UsuarioAcesso = USUARIOACESSO;
            this.UsuarioAlterar = USUARIOALTERAR;
            this.UsuarioExcluir = USUARIOEXCLUIR;

            SqlConnection conn1 = new SqlConnection(this.connetionString);
            string sql1 = "exec LoginUsuarioEditar " + this.IdPessoa;
            SqlDataAdapter sda1 = new SqlDataAdapter(sql1, conn1);
            DataSet ds1 = new DataSet();
            sda1.Fill(ds1);

            conn1.Open();

            int status = int.Parse(ds1.Tables[0].Rows[0][7].ToString());
            int UsuarioAcesso1 = int.Parse(ds1.Tables[0].Rows[0][8].ToString()); //Administrador do Sistema

            this.NomeAcessoSistema = ds1.Tables[0].Rows[0][3].ToString();
         
            txtNomeFuncionario.Text = ds1.Tables[0].Rows[0][1].ToString();
            
            txtAbreviacaoFuncionario.Text = ds1.Tables[0].Rows[0][2].ToString();
            txtUsuarioLoginFuncionario.Text = ds1.Tables[0].Rows[0][3].ToString();
            txtSenhaFuncionario.Text = ds1.Tables[0].Rows[0][4].ToString();
            txtConfirmacaoSenhaFuncionario.Text = ds1.Tables[0].Rows[0][5].ToString();
            txtObservacaoFuncionario.Text = ds1.Tables[0].Rows[0][6].ToString();

            buttonEditar.Enabled = true;
            buttonExcluirFornecedor.Enabled = true;

            if (status == 1)
            {
                checkBoxSituacao.Checked = true;
            }
            if (status == 2)
            {
                checkBoxSituacao.Checked = false;
            }

            if (UsuarioAcesso1 == 1)
            {
                checkBoxADM.Checked = true;
            }
            if (UsuarioAcesso1 == 2)
            {
                checkBoxADM.Checked = false;
            }
            

            //Verificação de Permissoões

            //PERMISSÃO DO SISTEMA
            int UsuarioCriar = int.Parse(ds1.Tables[0].Rows[0][9].ToString());
            if (UsuarioCriar == 0)
            {
                checkBoxCRIARSistema.Checked = false;
            }
            if (UsuarioCriar == 1)
            {
                checkBoxCRIARSistema.Checked = true;
            }
            int UsuarioAlterar = int.Parse(ds1.Tables[0].Rows[0][10].ToString());
            if (UsuarioAlterar == 0)
            {
                checkBoxALTERARSistema.Checked = false;
            }
            if (UsuarioAlterar == 1)
            {
                checkBoxALTERARSistema.Checked = true;
            }
            int UsuarioExcluir = int.Parse(ds1.Tables[0].Rows[0][11].ToString());
            if (UsuarioExcluir == 0)
            {
                checkBoxEXCLUIRSistema.Checked = false;
            }
            if (UsuarioExcluir == 1)
            {
                checkBoxEXCLUIRSistema.Checked = true;
            }
            int UsuarioPesquisa = int.Parse(ds1.Tables[0].Rows[0][12].ToString());
            if (UsuarioPesquisa == 0)
            {
                checkBoxPESQUISASistema.Checked = false;
            }
            if (UsuarioPesquisa == 1)
            {
                checkBoxPESQUISASistema.Checked = true;
            }
            int UsuarioVisualizar = int.Parse(ds1.Tables[0].Rows[0][13].ToString());
            if (UsuarioVisualizar == 0)
            {
                checkBoxVISUALIZARSistema.Checked = false;
            }
            if (UsuarioVisualizar == 1)
            {
                checkBoxVISUALIZARSistema.Checked = true;
            }

            //PERMISSÃO DO CLIENTE
            int ClienteCadastra = int.Parse(ds1.Tables[0].Rows[0][14].ToString());
            if (ClienteCadastra == 0)
            {
                checkBoxCADASTRACLIENTE.Checked = false;
            }
            if (ClienteCadastra == 1)
            {
                checkBoxCADASTRACLIENTE.Checked = true;
            }
            int ClientePesquisa = int.Parse(ds1.Tables[0].Rows[0][15].ToString());
            if (ClientePesquisa == 0)
            {
                checkBoxPESQUISACLIENTE.Checked = false;
            }
            if (ClientePesquisa == 1)
            {
                checkBoxPESQUISACLIENTE.Checked = true;
            }
            int ClienteVisualizar = int.Parse(ds1.Tables[0].Rows[0][16].ToString());
            if (ClienteVisualizar == 0)
            {
                checkBoxVISUALIZARCLIENTE.Checked = false;
            }
            if (ClienteVisualizar == 1)
            {
                checkBoxVISUALIZARCLIENTE.Checked = true;
            }
            int ClienteEditar = int.Parse(ds1.Tables[0].Rows[0][17].ToString());
            if (ClienteEditar == 0)
            {
                checkBoxEDITARCLIENTE.Checked = false;
            }
            if (ClienteEditar == 1)
            {
                checkBoxEDITARCLIENTE.Checked = true;
            }
            int ClienteExcluir = int.Parse(ds1.Tables[0].Rows[0][18].ToString());
            if (ClienteExcluir == 0)
            {
                checkBoxEXCLUIRCLIENTE.Checked = false;
            }
            if (ClienteExcluir == 1)
            {
                checkBoxEXCLUIRCLIENTE.Checked = true;
            }

            //PERMISSÃO DO CONTATOS CLIENTE
            int ClienteCCadastra = int.Parse(ds1.Tables[0].Rows[0][19].ToString());
            if (ClienteCCadastra == 0)
            {
                checkBoxCADASTRACCLIENTE.Checked = false;
            }
            if (ClienteCCadastra == 1)
            {
                checkBoxCADASTRACCLIENTE.Checked = true;
            }
            int ClienteCPesquisa = int.Parse(ds1.Tables[0].Rows[0][20].ToString());
            if (ClienteCPesquisa == 0)
            {
                checkBoxPESQUISACCLIENTE.Checked = false;
            }
            if (ClienteCPesquisa == 1)
            {
                checkBoxPESQUISACCLIENTE.Checked = true;
            }
            int ClienteCVisualizar = int.Parse(ds1.Tables[0].Rows[0][21].ToString());
            if (ClienteCVisualizar == 0)
            {
                checkBoxVISUALIZARCCLIENTE.Checked = false;
            }
            if (ClienteCVisualizar == 1)
            {
                checkBoxVISUALIZARCCLIENTE.Checked = true;
            }
            int ClienteCEditar = int.Parse(ds1.Tables[0].Rows[0][22].ToString());
            if (ClienteCEditar == 0)
            {
                checkBoxEDITARCCLIENTE.Checked = false;
            }
            if (ClienteCEditar == 1)
            {
                checkBoxEDITARCCLIENTE.Checked = true;
            }
            int ClienteCExcluir = int.Parse(ds1.Tables[0].Rows[0][23].ToString());
            if (ClienteCExcluir == 0)
            {
                checkBoxEXCLUIRCCLIENTE.Checked = false;
            }
            if (ClienteCExcluir == 1)
            {
                checkBoxEXCLUIRCCLIENTE.Checked = true;
            }

            //PERMISSÃO DO FORNECEDOR
            int FornecedorCadastra = int.Parse(ds1.Tables[0].Rows[0][24].ToString());
            if (FornecedorCadastra == 0)
            {
                checkBoxCADASTRAFORNECEDOR.Checked = false;
            }
            if (FornecedorCadastra == 1)
            {
                checkBoxCADASTRAFORNECEDOR.Checked = true;
            }
            int FornecedorPesquisa = int.Parse(ds1.Tables[0].Rows[0][25].ToString());
            if (FornecedorPesquisa == 0)
            {
                checkBoxPESQUISAFORNECEDOR.Checked = false;
            }
            if (FornecedorPesquisa == 1)
            {
                checkBoxPESQUISAFORNECEDOR.Checked = true;
            }
            int FornecedorVisualizar = int.Parse(ds1.Tables[0].Rows[0][26].ToString());
            if (FornecedorVisualizar == 0)
            {
                checkBoxVISUALIZARFORNECEDOR.Checked = false;
            }
            if (FornecedorVisualizar == 1)
            {
                checkBoxVISUALIZARFORNECEDOR.Checked = true;
            }
            int FornecedorEditar = int.Parse(ds1.Tables[0].Rows[0][27].ToString());
            if (FornecedorEditar == 0)
            {
                checkBoxEDITARFORNECEDOR.Checked = false;
            }
            if (FornecedorEditar == 1)
            {
                checkBoxEDITARFORNECEDOR.Checked = true;
            }
            int FornecedorExcluir = int.Parse(ds1.Tables[0].Rows[0][28].ToString());
            if (FornecedorExcluir == 0)
            {
                checkBoxEXCLUIRFORNECEDOR.Checked = false;
            }
            if (FornecedorExcluir == 1)
            {
                checkBoxEXCLUIRFORNECEDOR.Checked = true;
            }

            //PERMISSÃO DO CONTATOS FORNECEDOR
            int FornecedorCCadastra = int.Parse(ds1.Tables[0].Rows[0][29].ToString());
            if (FornecedorCCadastra == 0)
            {
                checkBoxCADASTRACFORNECEDOR.Checked = false;
            }
            if (FornecedorCCadastra == 1)
            {
                checkBoxCADASTRACFORNECEDOR.Checked = true;
            }
            int FornecedorCPesquisa = int.Parse(ds1.Tables[0].Rows[0][30].ToString());
            if (FornecedorCPesquisa == 0)
            {
                checkBoxPESQUISACFORNECEDOR.Checked = false;
            }
            if (FornecedorCPesquisa == 1)
            {
                checkBoxPESQUISACFORNECEDOR.Checked = true;
            }
            int FornecedorCVisualizar = int.Parse(ds1.Tables[0].Rows[0][31].ToString());
            if (FornecedorCVisualizar == 0)
            {
                checkBoxVISUALIZARCFORNECEDOR.Checked = false;
            }
            if (FornecedorCVisualizar == 1)
            {
                checkBoxVISUALIZARCFORNECEDOR.Checked = true;
            }
            int FornecedorCEditar = int.Parse(ds1.Tables[0].Rows[0][32].ToString());
            if (FornecedorCEditar == 0)
            {
                checkBoxEDITARCFORNECEDOR.Checked = false;
            }
            if (FornecedorCEditar == 1)
            {
                checkBoxEDITARCFORNECEDOR.Checked = true;
            }
            int FornecedorcExcluir = int.Parse(ds1.Tables[0].Rows[0][33].ToString());
            if (FornecedorcExcluir == 0)
            {
                checkBoxEXCLUIRCFORNECEDOR.Checked = false;
            }
            if (FornecedorcExcluir == 1)
            {
                checkBoxEXCLUIRCFORNECEDOR.Checked = true;
            }

            //PERMISSÃO DO FUNCIONÁRIO
            int FuncionarioCadastra = int.Parse(ds1.Tables[0].Rows[0][34].ToString());
            if (FuncionarioCadastra == 0)
            {
                checkBoxCADASTRAFUNCIOANRIO.Checked = false;
            }
            if (FuncionarioCadastra == 1)
            {
                checkBoxCADASTRAFUNCIOANRIO.Checked = true;
            }
            int FuncionarioPesquisa = int.Parse(ds1.Tables[0].Rows[0][35].ToString());
            if (FuncionarioPesquisa == 0)
            {
                checkBoxPESQUISAFUNCIONARIO.Checked = false;
            }
            if (FuncionarioPesquisa == 1)
            {
                checkBoxPESQUISAFUNCIONARIO.Checked = true;
            }
            int FuncionarioVisualizar = int.Parse(ds1.Tables[0].Rows[0][36].ToString());
            if (FuncionarioVisualizar == 0)
            {
                checkBoxVISUALIZARFUNCIONARIO.Checked = false;
            }
            if (FuncionarioVisualizar == 1)
            {
                checkBoxVISUALIZARFUNCIONARIO.Checked = true;
            }
            int FuncionarioEditar = int.Parse(ds1.Tables[0].Rows[0][37].ToString());
            if (FuncionarioEditar == 0)
            {
                checkBoxEDITARFUNCIONARIO.Checked = false;
            }
            if (FuncionarioEditar == 1)
            {
                checkBoxEDITARFUNCIONARIO.Checked = true;
            }
            int FuncionarioExcluir = int.Parse(ds1.Tables[0].Rows[0][38].ToString());
            if (FuncionarioExcluir == 0)
            {
                checkBoxEXCLUIRFUNCIONARIO.Checked = false;
            }
            if (FuncionarioExcluir == 1)
            {
                checkBoxEXCLUIRFUNCIONARIO.Checked = true;
            }

            //PERMISSÃO DE OS
            int OsCadastra = int.Parse(ds1.Tables[0].Rows[0][39].ToString());
            if (OsCadastra == 0)
            {
                checkBoxCADASTRAOS.Checked = false;
            }
            if (OsCadastra == 1)
            {
                checkBoxCADASTRAOS.Checked = true;
            }
            int OsPesquisa = int.Parse(ds1.Tables[0].Rows[0][40].ToString());
            if (OsPesquisa == 0)
            {
                checkBoxPESQUISAOS.Checked = false;
            }
            if (OsPesquisa == 1)
            {
                checkBoxPESQUISAOS.Checked = true;
            }
            int OsVisualizar = int.Parse(ds1.Tables[0].Rows[0][41].ToString());
            if (OsVisualizar == 0)
            {
                checkBoxVISUALIZAROS.Checked = false;
            }
            if (OsVisualizar == 1)
            {
                checkBoxVISUALIZAROS.Checked = true;
            }
            int OsEditar = int.Parse(ds1.Tables[0].Rows[0][42].ToString());
            if (OsEditar == 0)
            {
                checkBoxEDITAROS.Checked = false;
            }
            if (OsEditar == 1)
            {
                checkBoxEDITAROS.Checked = true;
            }
            int OsExcluir = int.Parse(ds1.Tables[0].Rows[0][43].ToString());
            if (OsExcluir == 0)
            {
                checkBoxEXCLUIROS.Checked = false;
            }
            if (OsExcluir == 1)
            {
                checkBoxEXCLUIROS.Checked = true;
            }

            //PERMISSÃO DE SELECIONAR PERMISSÕES

            if ((checkBoxCRIARSistema.Checked == true) && (checkBoxALTERARSistema.Checked == true) && (checkBoxEXCLUIRSistema.Checked == true) && (checkBoxPESQUISASistema.Checked == true) && (checkBoxVISUALIZARSistema.Checked == true)) { checkBoxSELECIONARSISTEMA.Checked = true; }

            if ((checkBoxCADASTRACLIENTE.Checked == true) && (checkBoxPESQUISACLIENTE.Checked == true) && (checkBoxVISUALIZARCLIENTE.Checked == true) && (checkBoxEDITARCLIENTE.Checked == true) && (checkBoxEXCLUIRCLIENTE.Checked == true)
                && (checkBoxCADASTRACCLIENTE.Checked == true) && (checkBoxPESQUISACCLIENTE.Checked == true) && (checkBoxVISUALIZARCCLIENTE.Checked == true) && (checkBoxEDITARCCLIENTE.Checked == true) && (checkBoxEXCLUIRCCLIENTE.Checked == true)) { checkBoxSELECIONARCLIENTE.Checked = true; }

            if ((checkBoxCADASTRAFORNECEDOR.Checked == true) && (checkBoxPESQUISAFORNECEDOR.Checked == true) && (checkBoxVISUALIZARFORNECEDOR.Checked == true) && (checkBoxEDITARFORNECEDOR.Checked == true) && (checkBoxEXCLUIRFORNECEDOR.Checked == true)
                && (checkBoxCADASTRACFORNECEDOR.Checked == true) && (checkBoxPESQUISACFORNECEDOR.Checked == true) && (checkBoxVISUALIZARCFORNECEDOR.Checked == true) && (checkBoxEDITARCFORNECEDOR.Checked == true) && (checkBoxEXCLUIRCFORNECEDOR.Checked == true)) { checkBoxSELECIONARFORNECEDOR.Checked = true; }

            if ((checkBoxCADASTRAFUNCIOANRIO.Checked == true) && (checkBoxPESQUISAFUNCIONARIO.Checked == true) && (checkBoxVISUALIZARFUNCIONARIO.Checked == true) && (checkBoxEDITARFUNCIONARIO.Checked == true)) { checkBoxSELECIONARFUNCIONARIO.Checked = true; }

            if ((checkBoxCADASTRAOS.Checked == true) && (checkBoxPESQUISAOS.Checked == true) && (checkBoxVISUALIZAROS.Checked == true) && (checkBoxEDITAROS.Checked == true) && (checkBoxEXCLUIROS.Checked == true)) { checkBoxSELECIONAROS.Checked = true; }

            if ((checkBoxSELECIONARSISTEMA.Checked == true) && (checkBoxSELECIONARCLIENTE.Checked == true) && (checkBoxSELECIONARFORNECEDOR.Checked == true) && (checkBoxSELECIONARFUNCIONARIO.Checked == true) && (checkBoxSELECIONAROS.Checked == true)) { checkBoxTODAS.Checked = true; }

        }

        private void FormPesquisaLoginUsuarioEditar_Load(object sender, EventArgs e)
        {
              
        }
        //METODO PARA VERIFICA SE O FORMULÁRIO ESTA ABERTO SE TIVER ELE FECHA!
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
            CancelaPesquisaCliente(typeof(FormPesquisaLoginUsuarioEditar));
        }
        //CHAMA O METODO CancelaCadastradoCliente QUE FECHA FORMULÁRIOS ABERTOS
        public void FecharFormulario()
        {
            CancelaPesquisaCliente(typeof(FormPesquisaLoginUsuarioEditar));
            CancelaPesquisaCliente(typeof(FormPesquisaLoginUsuario));
        }
        private void buttonVerificarFornecedor_Click(object sender, EventArgs e)
        {
            CadastroLoginNovo cadastrologin = new CadastroLoginNovo();
            cadastrologin.IdCadastroLoginNovo = IdPessoa;
            cadastrologin.Nome = txtNomeFuncionario.Text;
            cadastrologin.Usuario = txtUsuarioLoginFuncionario.Text;
            cadastrologin.Senha = txtSenhaFuncionario.Text;
            cadastrologin.ConfirmaSenha = txtConfirmacaoSenhaFuncionario.Text;
            cadastrologin.Observacao = txtObservacaoFuncionario.Text;

            if (checkBoxSituacao.Checked == false)
            {
                cadastrologin.Situacao = 2;
            }
            if (checkBoxSituacao.Checked == true)
            {
                cadastrologin.Situacao = 1;
            }
            if (checkBoxADM.Checked == false)
            {
                cadastrologin.UsuarioAcesso = 2;
            }
            if (checkBoxADM.Checked == true)
            {
                cadastrologin.UsuarioAcesso = 1;
            }

            //PERMISSÃO DO SISTEMA
            if (checkBoxCRIARSistema.Checked == true) { cadastrologin.UsuarioCriar = 1; }
            if (checkBoxCRIARSistema.Checked == false) { cadastrologin.UsuarioCriar = 0; }


            if (checkBoxALTERARSistema.Checked == true) { cadastrologin.UsuarioAlterar = 1; }
            if (checkBoxALTERARSistema.Checked == false) { cadastrologin.UsuarioAlterar = 0; }

            if (checkBoxEXCLUIRSistema.Checked == true) { cadastrologin.UsuarioExcluir = 1; }
            if (checkBoxEXCLUIRSistema.Checked == false) { cadastrologin.UsuarioExcluir = 0; }

            if (checkBoxPESQUISASistema.Checked == true) { cadastrologin.UsuarioPesquisa = 1; }
            if (checkBoxPESQUISASistema.Checked == false) { cadastrologin.UsuarioPesquisa = 0; }

            if (checkBoxVISUALIZARSistema.Checked == true) { cadastrologin.UsuarioVisualizar = 1; }
            if (checkBoxVISUALIZARSistema.Checked == false) { cadastrologin.UsuarioVisualizar = 0; }

            //PERMISSÃO DO CLIENTE
            if (checkBoxCADASTRACLIENTE.Checked == true) { cadastrologin.ClienteCadastra = 1; }
            if (checkBoxCADASTRACLIENTE.Checked == false) { cadastrologin.ClienteCadastra = 0; }

            if (checkBoxPESQUISACLIENTE.Checked == true) { cadastrologin.ClientePesquisa = 1; }
            if (checkBoxPESQUISACLIENTE.Checked == false) { cadastrologin.ClientePesquisa = 0; }

            if (checkBoxVISUALIZARCLIENTE.Checked == true) { cadastrologin.ClienteVisualizar = 1; }
            if (checkBoxVISUALIZARCLIENTE.Checked == false) { cadastrologin.ClienteVisualizar = 0; }

            if (checkBoxEDITARCLIENTE.Checked == true) { cadastrologin.ClienteEditar = 1; }
            if (checkBoxEDITARCLIENTE.Checked == false) { cadastrologin.ClienteEditar = 0; }

            if (checkBoxEXCLUIRCLIENTE.Checked == true) { cadastrologin.ClienteExcluir = 1; }
            if (checkBoxEXCLUIRCLIENTE.Checked == false) { cadastrologin.ClienteExcluir = 0; }


            //PERMISSÃO DO CONTATOS CLIENTE
            if (checkBoxCADASTRACCLIENTE.Checked == true) { cadastrologin.ClienteCCadastra = 1; }
            if (checkBoxCADASTRACCLIENTE.Checked == false) { cadastrologin.ClienteCCadastra = 0; }

            if (checkBoxPESQUISACCLIENTE.Checked == true) { cadastrologin.ClienteCPesquisa = 1; }
            if (checkBoxPESQUISACCLIENTE.Checked == false) { cadastrologin.ClienteCPesquisa = 0; }

            if (checkBoxVISUALIZARCCLIENTE.Checked == true) { cadastrologin.ClienteCVisualizar = 1; }
            if (checkBoxVISUALIZARCCLIENTE.Checked == false) { cadastrologin.ClienteCVisualizar = 0; }

            if (checkBoxEDITARCCLIENTE.Checked == true) { cadastrologin.ClienteCEditar = 1; }
            if (checkBoxEDITARCCLIENTE.Checked == false) { cadastrologin.ClienteCEditar = 0; }

            if (checkBoxEXCLUIRCCLIENTE.Checked == true) { cadastrologin.ClienteCExcluir = 1; }
            if (checkBoxEXCLUIRCCLIENTE.Checked == false) { cadastrologin.ClienteCExcluir = 0; }

            //PERMISSÃO DO FORNECEDOR
            if (checkBoxCADASTRAFORNECEDOR.Checked == true) { cadastrologin.FornecedorCadastra = 1; }
            if (checkBoxCADASTRAFORNECEDOR.Checked == false) { cadastrologin.FornecedorCadastra = 0; }

            if (checkBoxPESQUISAFORNECEDOR.Checked == true) { cadastrologin.FornecedorPesquisa = 1; }
            if (checkBoxPESQUISAFORNECEDOR.Checked == false) { cadastrologin.FornecedorPesquisa = 0; }

            if (checkBoxVISUALIZARFORNECEDOR.Checked == true) { cadastrologin.FornecedorVisualizar = 1; }
            if (checkBoxVISUALIZARFORNECEDOR.Checked == false) { cadastrologin.FornecedorVisualizar = 0; }

            if (checkBoxEDITARFORNECEDOR.Checked == true) { cadastrologin.FornecedorEditar = 1; }
            if (checkBoxEDITARFORNECEDOR.Checked == false) { cadastrologin.FornecedorEditar = 0; }

            if (checkBoxEXCLUIRFORNECEDOR.Checked == true) { cadastrologin.FornecedorExcluir = 1; }
            if (checkBoxEXCLUIRFORNECEDOR.Checked == false) { cadastrologin.FornecedorExcluir = 0; }

            //PERMISSÃO DO CONTATOS FORNECEDOR
            if (checkBoxCADASTRACFORNECEDOR.Checked == true) { cadastrologin.FornecedorCCadastra = 1; }
            if (checkBoxCADASTRACFORNECEDOR.Checked == false) { cadastrologin.FornecedorCCadastra = 0; }

            if (checkBoxPESQUISACFORNECEDOR.Checked == true) { cadastrologin.FornecedorCPesquisa = 1; }
            if (checkBoxPESQUISACFORNECEDOR.Checked == false) { cadastrologin.FornecedorCPesquisa = 0; }

            if (checkBoxVISUALIZARCFORNECEDOR.Checked == true) { cadastrologin.FornecedorCVisualizar = 1; }
            if (checkBoxVISUALIZARCFORNECEDOR.Checked == false) { cadastrologin.FornecedorCVisualizar = 0; }

            if (checkBoxEDITARCFORNECEDOR.Checked == true) { cadastrologin.FornecedorCEditar = 1; }
            if (checkBoxEDITARCFORNECEDOR.Checked == false) { cadastrologin.FornecedorCEditar = 0; }

            if (checkBoxEXCLUIRCFORNECEDOR.Checked == true) { cadastrologin.FornecedorcExcluir = 1; }
            if (checkBoxEXCLUIRCFORNECEDOR.Checked == false) { cadastrologin.FornecedorcExcluir = 0; }

            //PERMISSÃO DO FUNCIONÁRIO
            if (checkBoxCADASTRAFUNCIOANRIO.Checked == true) { cadastrologin.FuncionarioCadastra = 1; }
            if (checkBoxCADASTRAFUNCIOANRIO.Checked == false) { cadastrologin.FuncionarioCadastra = 0; }

            if (checkBoxPESQUISAFUNCIONARIO.Checked == true) { cadastrologin.FuncionarioPesquisa = 1; }
            if (checkBoxPESQUISAFUNCIONARIO.Checked == false) { cadastrologin.FuncionarioPesquisa = 0; }

            if (checkBoxVISUALIZARFUNCIONARIO.Checked == true) { cadastrologin.FuncionarioVisualizar = 1; }
            if (checkBoxVISUALIZARFUNCIONARIO.Checked == false) { cadastrologin.FuncionarioVisualizar = 0; }

            if (checkBoxEDITARFUNCIONARIO.Checked == true) { cadastrologin.FuncionarioEditar = 1; }
            if (checkBoxEDITARFUNCIONARIO.Checked == false) { cadastrologin.FuncionarioEditar = 0; }

            if (checkBoxEXCLUIRFUNCIONARIO.Checked == true) { cadastrologin.FuncionarioExcluir = 1; }
            if (checkBoxEXCLUIRFUNCIONARIO.Checked == false) { cadastrologin.FuncionarioExcluir = 0; }

            //PERMISSÃO DE OS
            if (checkBoxCADASTRAOS.Checked == true) { cadastrologin.OsCadastra = 1; }
            if (checkBoxCADASTRAOS.Checked == false) { cadastrologin.OsCadastra = 0; }

            if (checkBoxPESQUISAOS.Checked == true) { cadastrologin.OsPesquisa = 1; }
            if (checkBoxPESQUISAOS.Checked == false) { cadastrologin.OsPesquisa = 0; }

            if (checkBoxVISUALIZAROS.Checked == true) { cadastrologin.OsVisualizar = 1; }
            if (checkBoxVISUALIZAROS.Checked == false) { cadastrologin.OsVisualizar = 0; }

            if (checkBoxEDITAROS.Checked == true) { cadastrologin.OsEditar = 1; }
            if (checkBoxEDITAROS.Checked == false) { cadastrologin.OsEditar = 0; }

            if (checkBoxEXCLUIROS.Checked == true) { cadastrologin.OsExcluir = 1; }
            if (checkBoxEXCLUIROS.Checked == false) { cadastrologin.OsExcluir = 0; }


            if (Operacao == "Editar")
            {
                try
                {
                    string Senha = txtSenhaFuncionario.Text;
                    string ConfirmaSenha = txtConfirmacaoSenhaFuncionario.Text;
                    if (Senha.Equals(ConfirmaSenha))
                    {
                        Conexao conexao = new Conexao(this.connetionString);
                        DALDateSystem da = new DALDateSystem(conexao);

                        //da.AlterarLoginUsuario(cadastrologin);

                        FecharTodosFormulario();

                        MessageBox.Show("Usuário do sistema alterado com sucesso!");

                        FormPesquisaLoginUsuario cadastracliente = new FormPesquisaLoginUsuario(this.NomeServidor, this.NomeBaseDados, this.NomeUsuario, this.SenhaBaseDados);
                        cadastracliente.MdiParent = FormPesquisaLoginUsuario.ActiveForm;
                        cadastracliente.Show();
                        cadastracliente.Top = 0;
                        cadastracliente.Left = 0;
                    }
                    if (!Senha.Equals(ConfirmaSenha))
                    {
                        MessageBox.Show("As duas senhas não se conferem!");
                    }

                }
                catch (Exception ex)
                {
                    ex.ToString();
                }
            }
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            this.Operacao = "Editar";

            if (NomeAcessoSistema.Equals(NomeAcesso) && (UsuarioAcesso == 2) && (this.UsuarioAlterar == 1))
            {
                buttonEditar.Enabled = true;
                txtSenhaFuncionario.Enabled = true;
                txtConfirmacaoSenhaFuncionario.Enabled = true;
                txtObservacaoFuncionario.Enabled = true;
                checkBoxSituacao.Enabled = true;
                tabControl1.Enabled = false;
                panel1.Enabled = true;
            }
            if (!(NomeAcessoSistema.Equals(NomeAcesso)) && (UsuarioAcesso == 2) && (UsuarioAlterar == 1))
            {
                buttonEditar.Enabled = true;
                txtSenhaFuncionario.Enabled = false;
                txtConfirmacaoSenhaFuncionario.Enabled = false;
                txtObservacaoFuncionario.Enabled = false;
                checkBoxSituacao.Enabled = false;
                tabControl1.Enabled = false;

                MessageBox.Show("Alteração de outro Usuário não pode se Realizado!");
            }
            if (NomeAcessoSistema.Equals(NomeAcesso) && (UsuarioAcesso == 2) && (this.UsuarioAlterar == 0))
            {
                MessageBox.Show("Acesso não Permitido!");
            }
            if (!(NomeAcessoSistema.Equals(NomeAcesso)) && (UsuarioAcesso == 2) && (UsuarioAlterar == 0))
            {
                MessageBox.Show("Acesso não Permitido!");
            }
            if (UsuarioAcesso == 1)
            {
                buttonVerificarUsuario.Enabled = true;
                buttonEditar.Enabled = true;
                txtSenhaFuncionario.Enabled = true;
                txtConfirmacaoSenhaFuncionario.Enabled = true;
                txtObservacaoFuncionario.Enabled = true;
                checkBoxSituacao.Enabled = true;
                tabControl1.Enabled = true;
                panel1.Enabled = true;
            }

        }

        private void buttonExcluirFornecedor_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(this.connetionString);

            //Verifica Se a USUARIO CONSTA NO SISTEMA!    

            SqlDataAdapter da3 = new SqlDataAdapter("EXEC LoginUsuarioEditar " + this.IdPessoa + ";", conn);//VERIFICA SE É ADMINISTRADOR

            DataSet ds3 = new DataSet();
            da3.Fill(ds3);

            conn.Open();

            int compararacao = int.Parse(ds3.Tables[0].Rows[0][8].ToString());
            string admin = ds3.Tables[0].Rows[0][3].ToString();

            if ((NomeAcessoSistema.Equals(NomeAcesso)) && (UsuarioAcesso == 2) && (this.UsuarioExcluir == 0))
            {
                MessageBox.Show("Não tem permissão para excluir usuário!");
                conn.Close();

            }
            if ((NomeAcessoSistema.Equals(NomeAcesso)) && (UsuarioAcesso == 2) && (this.UsuarioExcluir == 1))
            {
                DialogResult d = MessageBox.Show("Deseja Excluir seu próprio registro?", "Aviso 1", MessageBoxButtons.YesNo);

                Conexao conexao = new Conexao(this.connetionString);
                DALDateSystem dal = new DALDateSystem(conexao);

                if (d.ToString() == "Yes")
                {
                    dal.ExcluirLoginUsuario(this.IdPessoa);

                    conn.Close();
                    FecharTodosFormulario();
                }
            }
            if ((!NomeAcessoSistema.Equals(NomeAcesso)) && (UsuarioAcesso == 2) && (this.UsuarioExcluir == 0))
            {
                MessageBox.Show("Não tem permissão para excluir usuário!");

            }
            if ((!NomeAcessoSistema.Equals(NomeAcesso)) && (UsuarioAcesso == 2) && (this.UsuarioExcluir == 1) && (compararacao == 2))
            {
                DialogResult d = MessageBox.Show("Deseja Excluir o registro?", "Aviso 2", MessageBoxButtons.YesNo);

                Conexao conexao = new Conexao(this.connetionString);
                DALDateSystem dal = new DALDateSystem(conexao);

                if (d.ToString() == "Yes")
                {
                    dal.ExcluirLoginUsuario(this.IdPessoa);
                    conn.Close();

                    FecharTodosFormulario();
                }
            }
            if ((!NomeAcessoSistema.Equals(NomeAcesso)) && (UsuarioAcesso == 2) && (this.UsuarioExcluir == 1) && (compararacao == 1))
            {
                MessageBox.Show("Não tem permissão para excluir usuário administrador!");
            }
            if (UsuarioAcesso == 1)
            {
                if (admin.Equals("HEXEN"))
                {
                    MessageBox.Show("O usuário principal não pode se excluído do sistema!");
                    conn.Close();
                }
                if (!admin.Equals("HEXEN"))
                {
                    DialogResult d = MessageBox.Show("Deseja Excluir o registro?", "Aviso 3", MessageBoxButtons.YesNo);

                    Conexao conexao = new Conexao(this.connetionString);
                    DALDateSystem dal = new DALDateSystem(conexao);

                    if (d.ToString() == "Yes")
                    {
                        dal.ExcluirLoginUsuario(this.IdPessoa);
                        conn.Close();
                        FecharTodosFormulario();
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
            FecharFormulario();
        }

        private void tabPagePesquisaOs_Click(object sender, EventArgs e)
        {

        }

        private void checkBoxTODAS_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxSELECIONAROS_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSELECIONAROS.Checked == true)
            {
                //PERMISSÃO DE OS
                checkBoxCADASTRAOS.Checked = true;
                checkBoxPESQUISAOS.Checked = true;
                checkBoxVISUALIZAROS.Checked = true;
                checkBoxEDITAROS.Checked = true;
                checkBoxEXCLUIROS.Checked = true;
            }
            if (checkBoxSELECIONAROS.Checked == false)
            {

                //PERMISSÃO DE OS
                checkBoxCADASTRAOS.Checked = false;
                checkBoxPESQUISAOS.Checked = false;
                checkBoxVISUALIZAROS.Checked = false;
                checkBoxEDITAROS.Checked = false;
                checkBoxEXCLUIROS.Checked = false;

                if ((checkBoxSELECIONARSISTEMA.Checked == false) && (checkBoxSELECIONARCLIENTE.Checked == false) && (checkBoxSELECIONARFORNECEDOR.Checked == false) &&
                    (checkBoxSELECIONARFUNCIONARIO.Checked == false) && (checkBoxSELECIONAROS.Checked == false))
                {
                    checkBoxTODAS.Checked = false;
                }
            }
        }

        private void checkBoxSELECIONARSISTEMA_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSELECIONARSISTEMA.Checked == true)
            {
                //PERMISSÃO DO SISTEMA
                checkBoxCRIARSistema.Checked = true;
                checkBoxALTERARSistema.Checked = true;
                checkBoxEXCLUIRSistema.Checked = true;
                checkBoxPESQUISASistema.Checked = true;
                checkBoxVISUALIZARSistema.Checked = true;

            }
            if (checkBoxSELECIONARSISTEMA.Checked == false)
            {
                //PERMISSÃO DO SISTEMA
                checkBoxCRIARSistema.Checked = false;
                checkBoxALTERARSistema.Checked = false;
                checkBoxEXCLUIRSistema.Checked = false;
                checkBoxPESQUISASistema.Checked = false;
                checkBoxVISUALIZARSistema.Checked = false;
                if ((checkBoxSELECIONARSISTEMA.Checked == false) && (checkBoxSELECIONARCLIENTE.Checked == false) && (checkBoxSELECIONARFORNECEDOR.Checked == false) &&
    (checkBoxSELECIONARFUNCIONARIO.Checked == false) && (checkBoxSELECIONAROS.Checked == false))
                {
                    checkBoxTODAS.Checked = false;
                }
            }
        }

        private void checkBoxSELECIONARCLIENTE_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSELECIONARCLIENTE.Checked == true)
            {
                //PERMISSÃO DO CLIENTE
                checkBoxCADASTRACLIENTE.Checked = true;
                checkBoxPESQUISACLIENTE.Checked = true;
                checkBoxVISUALIZARCLIENTE.Checked = true;
                checkBoxEDITARCLIENTE.Checked = true;
                checkBoxEXCLUIRCLIENTE.Checked = true;

                //PERMISSÃO DO CONTATOS CLIENTE
                checkBoxCADASTRACCLIENTE.Checked = true;
                checkBoxPESQUISACCLIENTE.Checked = true;
                checkBoxVISUALIZARCCLIENTE.Checked = true;
                checkBoxEDITARCCLIENTE.Checked = true;
                checkBoxEXCLUIRCCLIENTE.Checked = true;

            }
            if (checkBoxSELECIONARCLIENTE.Checked == false)
            {
                //PERMISSÃO DO CLIENTE
                checkBoxCADASTRACLIENTE.Checked = false;
                checkBoxPESQUISACLIENTE.Checked = false;
                checkBoxVISUALIZARCLIENTE.Checked = false;
                checkBoxEDITARCLIENTE.Checked = false;
                checkBoxEXCLUIRCLIENTE.Checked = false;

                //PERMISSÃO DO CONTATOS CLIENTE
                checkBoxCADASTRACCLIENTE.Checked = false;
                checkBoxPESQUISACCLIENTE.Checked = false;
                checkBoxVISUALIZARCCLIENTE.Checked = false;
                checkBoxEDITARCCLIENTE.Checked = false;
                checkBoxEXCLUIRCCLIENTE.Checked = false;
                if ((checkBoxSELECIONARSISTEMA.Checked == false) && (checkBoxSELECIONARCLIENTE.Checked == false) && (checkBoxSELECIONARFORNECEDOR.Checked == false) &&
                     (checkBoxSELECIONARFUNCIONARIO.Checked == false) && (checkBoxSELECIONAROS.Checked == false))
                {
                    checkBoxTODAS.Checked = false;
                }
            }
        }

        private void checkBoxSELECIONARFORNECEDOR_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSELECIONARFORNECEDOR.Checked == true)
            {

                //PERMISSÃO DO FORNECEDOR
                checkBoxCADASTRAFORNECEDOR.Checked = true;
                checkBoxPESQUISAFORNECEDOR.Checked = true;
                checkBoxVISUALIZARFORNECEDOR.Checked = true;
                checkBoxEDITARFORNECEDOR.Checked = true;
                checkBoxEXCLUIRFORNECEDOR.Checked = true;

                //PERMISSÃO DO CONTATOS FORNECEDOR
                checkBoxCADASTRACFORNECEDOR.Checked = true;
                checkBoxPESQUISACFORNECEDOR.Checked = true;
                checkBoxVISUALIZARCFORNECEDOR.Checked = true;
                checkBoxEDITARCFORNECEDOR.Checked = true;
                checkBoxEXCLUIRCFORNECEDOR.Checked = true;
            }
            if (checkBoxSELECIONARFORNECEDOR.Checked == false)
            {
                //PERMISSÃO DO FORNECEDOR
                checkBoxCADASTRAFORNECEDOR.Checked = false;
                checkBoxPESQUISAFORNECEDOR.Checked = false;
                checkBoxVISUALIZARFORNECEDOR.Checked = false;
                checkBoxEDITARFORNECEDOR.Checked = false;
                checkBoxEXCLUIRFORNECEDOR.Checked = false;

                //PERMISSÃO DO CONTATOS FORNECEDOR
                checkBoxCADASTRACFORNECEDOR.Checked = false;
                checkBoxPESQUISACFORNECEDOR.Checked = false;
                checkBoxVISUALIZARCFORNECEDOR.Checked = false;
                checkBoxEDITARCFORNECEDOR.Checked = false;
                checkBoxEXCLUIRCFORNECEDOR.Checked = false;
                if ((checkBoxSELECIONARSISTEMA.Checked == false) && (checkBoxSELECIONARCLIENTE.Checked == false) && (checkBoxSELECIONARFORNECEDOR.Checked == false) &&
                    (checkBoxSELECIONARFUNCIONARIO.Checked == false) && (checkBoxSELECIONAROS.Checked == false))
                {
                    checkBoxTODAS.Checked = false;
                }
            }
        }

        private void checkBoxSELECIONARFUNCIONARIO_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSELECIONARFUNCIONARIO.Checked == true)
            {
                //PERMISSÃO DO FUNCIONÁRIO
                checkBoxCADASTRAFUNCIOANRIO.Checked = true;
                checkBoxPESQUISAFUNCIONARIO.Checked = true;
                checkBoxVISUALIZARFUNCIONARIO.Checked = true;
                checkBoxEDITARFUNCIONARIO.Checked = true;
                checkBoxEXCLUIRFUNCIONARIO.Checked = true;
            }
            if (checkBoxSELECIONARFUNCIONARIO.Checked == false)
            {
                //PERMISSÃO DO FUNCIONÁRIO
                checkBoxCADASTRAFUNCIOANRIO.Checked = false;
                checkBoxPESQUISAFUNCIONARIO.Checked = false;
                checkBoxVISUALIZARFUNCIONARIO.Checked = false;
                checkBoxEDITARFUNCIONARIO.Checked = false;
                checkBoxEXCLUIRFUNCIONARIO.Checked = false;
                if ((checkBoxSELECIONARSISTEMA.Checked == false) && (checkBoxSELECIONARCLIENTE.Checked == false) && (checkBoxSELECIONARFORNECEDOR.Checked == false) &&
                     (checkBoxSELECIONARFUNCIONARIO.Checked == false) && (checkBoxSELECIONAROS.Checked == false))
                {
                    checkBoxTODAS.Checked = false;
                }
            }
        }
    }
}
