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
    public partial class FormLoginUsuarioSapiens : Form
    {
        private string USUARIO = "";
        public string Usuario
        {
            get
            {
                return this.USUARIO;

            }
            set
            {
                this.USUARIO = value;
            }
        }
        private string SENHA = "";
        public string Senha
        {
            get
            {
                return this.SENHA;

            }
            set
            {
                this.SENHA = value;
            }
        }
        private int ID_CADASTRAOS = 0;
        public int IdCadastraOs
        {
            get
            {
                return this.ID_CADASTRAOS;

            }
            set
            {
                this.ID_CADASTRAOS = value;
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
        private int SENIORSAPIENSACESSO = 0;
        public int SeniorSapiensAcesso
        {
            get
            {
                return this.SENIORSAPIENSACESSO;

            }
            set
            {
                this.SENIORSAPIENSACESSO = value;
            }
        }
        private int SENIORSAPIENSPESQUISA = 0;
        public int SeniorSapiensPesquisa
        {
            get
            {
                return this.SENIORSAPIENSPESQUISA;

            }
            set
            {
                this.SENIORSAPIENSPESQUISA = value;
            }
        }
        private int SENIORSAPIENSEXCLUIR = 0;
        public int SeniorSapiensExcluir
        {
            get
            {
                return this.SENIORSAPIENSEXCLUIR;

            }
            set
            {
                this.SENIORSAPIENSEXCLUIR = value;
            }
        }



        public FormLoginUsuarioSapiens(string NomeServidor, string NomeBaseDados, string NomeUsuario, string SenhaBaseDados)
        {
            InitializeComponent();

            this.NomeServidor = NomeServidor;
            this.NomeBaseDados = NomeBaseDados;
            this.NomeUsuario = NomeUsuario;
            this.SenhaBaseDados = SenhaBaseDados;

            this.connetionString = "Data Source=" + this.NomeServidor + ";Initial Catalog=" + this.NomeBaseDados + ";Persist Security Info=True;User ID=" + this.NomeUsuario + ";Password=" + this.SenhaBaseDados + ";";

        }

        private void FormLoginUsuarioSapiens_Load(object sender, EventArgs e)
        {

        }
        public static void CancelaAcessoSapiens(Type frmType)
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
            CancelaAcessoSapiens(typeof(FormLoginUsuarioSapiens));
        }
        private void buttonEntrar_Click(object sender, EventArgs e)
        {
            AcessoSistemaSenior();
        }
        public void AcessoSistemaSenior()
        {
            if((txtUsuario.Text =="") && (txtSenha.Text == ""))
            {
                MessageBox.Show("Acesso negado. Usuário e senha não podem estarem em branco.");
            }
            else if ((txtUsuario.Text == "") || (txtSenha.Text == ""))
            {
                MessageBox.Show("Acesso negado. Usuário ou senha não podem estarem em branco.");
            }
            if (!(txtUsuario.Text == "") && !(txtSenha.Text == ""))
            {
                SqlConnection conn;
                conn = new SqlConnection(this.connetionString);
                try
                {
                    conn.Open();
                    int cont = 0;
                    string sql = "exec D_S_ConsultaNomeAcessoSapiensSenior '" + txtUsuario.Text + "';";
                    SqlDataAdapter sda = new SqlDataAdapter(sql, conn);
                    DataSet ds = new DataSet();
                    sda.Fill(ds);
                    if (!(ds.Tables[0].Rows.Count > 0))
                    {
                        MessageBox.Show("Usuário e Senha não registrada!");
                        conn.Close();
                    }
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        string NomeFornecida = txtUsuario.Text;
                        string NomeBaseDados = ds.Tables[0].Rows[0][112].ToString();
                        string SenhaBancoDados = ds.Tables[0].Rows[0][113].ToString();
                        string SenhaFornecida = txtSenha.Text;

                        //PERMISSÃO DE SENIOR SAPIENS
                        this.SeniorSapiensAcesso = int.Parse(ds.Tables[0].Rows[0][60].ToString());
                        this.SeniorSapiensPesquisa = int.Parse(ds.Tables[0].Rows[0][61].ToString());
                        this.SeniorSapiensExcluir = int.Parse(ds.Tables[0].Rows[0][62].ToString());

                        if (NomeBaseDados.Equals(NomeFornecida))
                        {
                            cont++;
                        }

                        if (SenhaBancoDados.Equals(SenhaFornecida))
                        {
                            cont++;
                        }
                        if(cont != 2)
                        {
                            MessageBox.Show("Usuário ou Senha estão incorretas!");
                        }
                        else if(cont == 2)
                        {
                            if (SeniorSapiensAcesso == 0)
                            {
                                MessageBox.Show("Usuário não tem permissão para acessa!");
                            }
                            if (SeniorSapiensAcesso == 1)
                            {
                                FecharTodosFormulario();

                                FormSeniorSapiens FormFormSeniorSapiens = new FormSeniorSapiens(SeniorSapiensPesquisa, SeniorSapiensExcluir);
                                FormFormSeniorSapiens.MdiParent = FormSeniorSapiens.ActiveForm;
                                FormFormSeniorSapiens.Show();
                                FormFormSeniorSapiens.Top = 0;
                                FormFormSeniorSapiens.Left = 0;
                            }
                        }

                        conn.Close();
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("O banco de dados não responde, Erro gerado pelo o sitema: " + ex.Message);
                    this.Close();
                    Application.Exit();
                }
                finally
                {
                    conn.Close();
                }
            }

        }
        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                AcessoSistemaSenior();
            }       
        }

        private void txtSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                AcessoSistemaSenior();
            }
        }

        private void FormLoginUsuarioSapiens_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
            {
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
