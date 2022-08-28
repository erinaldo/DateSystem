using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DateSystem
{
    public partial class FormConfiguracaoTelaPrincipal : Form
    {
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
        private int IDUSUARIO = 0;
        public int IdUsuario
        {
            get
            {
                return this.IDUSUARIO;

            }
            set
            {
                this.IDUSUARIO = value;
            }
        }
        private int PERMISSAOCLIENTE = 0;
        public int PermissaoCliente
        {
            get
            {
                return this.PERMISSAOCLIENTE;

            }
            set
            {
                this.PERMISSAOCLIENTE = value;
            }
        }
        private int VERIFICADOROS = 0;
        public int VerificadorOS
        {
            get
            {
                return this.VERIFICADOROS;

            }
            set
            {
                this.VERIFICADOROS = value;
            }
        }
        public FormConfiguracaoTelaPrincipal()
        {
            InitializeComponent();
        }
        public FormConfiguracaoTelaPrincipal(string NOMESERVIDOR, string  NOMEBASEDADOS, string NOMESUARIO, string SENHABASEDADOS,
            int IDUSUARIO, int PERMISSAOCLIENTE, int VERIFICADOROS)
        {
            InitializeComponent();

            this.NomeServidor = NOMESERVIDOR;
            this.NomeBaseDados = NOMEBASEDADOS;
            this.NomeUsuario = NOMESUARIO;
            this.SenhaBaseDados = SENHABASEDADOS;
            this.IdUsuario = IDUSUARIO;
            this.PermissaoCliente = PERMISSAOCLIENTE;
            this.VerificadorOS = VERIFICADOROS;

            this.connetionString = "Data Source=" + this.NomeServidor + ";Initial Catalog=" + this.NomeBaseDados + ";Persist Security Info=True;User ID=" + this.NomeUsuario + ";Password=" + this.SenhaBaseDados + ";";

            if(PermissaoCliente == 1)
            {
                PainelOs.Enabled = true;
                buttonVerifica.Enabled = true;
            }

            if (VerificadorOS == 0)
            {
                checkBoxVerificadorOs.Checked = false;
            }
            if (VerificadorOS == 1)
            {
                checkBoxVerificadorOs.Checked = true;
            }
        }
        private void FormConfiguracaoTelaPrincipal_Load(object sender, EventArgs e)
        {

        }
        private void buttonVerifica_Click(object sender, EventArgs e)
        {
            SalvarConfiguracoes();
        }
        public void SalvarConfiguracoes()
        {
            try
            {
                //Tela Principal sistema.
                TelaPrincipalConfiguracao TelaPrincipalConfiguracaoU = new TelaPrincipalConfiguracao();
                TelaPrincipalConfiguracaoU.idUsuario = this.IdUsuario;

                if (checkBoxVerificadorOs.Checked == true)
                {
                    TelaPrincipalConfiguracaoU.VerificadorOS = 1;
                }
                if (checkBoxVerificadorOs.Checked == false)
                {
                    TelaPrincipalConfiguracaoU.VerificadorOS = 0;
                }

                Conexao conexao = new Conexao(this.connetionString);
                DALOrdemServico dal = new DALOrdemServico(conexao);//cadastra Pesssoa Juridica 

                dal.TelaPrincipalConfiguracao(TelaPrincipalConfiguracaoU);
                FecharTodosFormulario();
                MessageBox.Show("Alterações no DateSystem realizado com exito! \n Só fechar o Programa e Reabri-lo!");
            }
            catch(Exception ex)
            {
                ex.ToString();
            }
        }
        public static void CancelaCadastradoTelaPrincipal(Type frmType)
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
            CancelaCadastradoTelaPrincipal(typeof(FormConfiguracaoTelaPrincipal));
        }

        private void buttonCancelarTelaSalvar_Click(object sender, EventArgs e)
        {
            FecharTodosFormulario();
            FormConfiguracaoTelaPrincipal cadastracliente = new FormConfiguracaoTelaPrincipal(this.NomeServidor, 
                this.NomeBaseDados, this.NomeUsuario, this.SenhaBaseDados, this.IdUsuario, this.PermissaoCliente,
                this.VerificadorOS);
            cadastracliente.MdiParent = FormConfiguracaoTelaPrincipal.ActiveForm;
            cadastracliente.Show();
            cadastracliente.Top = 0;
            cadastracliente.Left = 0;
        }

        private void buttonFecharTela_Click(object sender, EventArgs e)
        {
            FecharTodosFormulario();
        }

        private void FormConfiguracaoTelaPrincipal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
            {
                this.Close();
            }
        }
    }
}
