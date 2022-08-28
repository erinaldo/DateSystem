//String nomeArquivo = "C:/MSOS.txt";

//if (!System.IO.File.Exists(nomeArquivo))
//{
//    MessageBox.Show("Não tem Arquivo!");

//}
//if (System.IO.File.Exists(nomeArquivo))
//{
//    System.IO.File.Create(nomeArquivo).Close();

//    System.IO.TextWriter arqTXT = System.IO.File.AppendText(nomeArquivo);

//    arqTXT.WriteLine("TEXTO DO ARQUIVO");

//    arqTXT.Close();

//}
//--------------------------------------------------------------------
//                if (!System.IO.File.Exists(nomeArquivo))
//                {
//                    System.IO.File.Create(nomeArquivo).Close();

//System.IO.TextWriter arqTXT = System.IO.File.AppendText(nomeArquivo);

//arqTXT.WriteLine("TEXTO DO ARQUIVO AAAAA");

//                    arqTXT.Close();

//                }

//                if (System.IO.File.Exists(nomeArquivo))
//                {
//                    status = true;

//                    using (StreamReader texto = new StreamReader(nomeArquivo))
//                    {
//                        while ((mensagem = texto.ReadLine()) != null)
//                        {
//                            dados.Add(mensagem);
//                        }
//                    }
//                }
//                int registro = dados.Count; //total de linhas do arquivo.
//                for (int i = 0; i<dados.Count; i++)
//                {
//                    this.conteudo += dados[i];
//                    //File.WriteAllText(nomeArquivo, dados[i]);
//                    //File.WriteAllText(nomeArquivo, dados[i]+"22222");
//}


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
using System.Net.NetworkInformation;
using System.Data.Odbc;
using System.IO;
using System.Configuration;
using System.Data.OleDb;
using System.Data.Common;

namespace DateSystem
{
    public partial class FormLoginUsuario : Form
    {
        public Boolean logado = false;
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
        private string NOME = "";
        public string Nome
        {
            get
            {
                return this.NOME;

            }
            set
            {
                this.NOME = value;
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
        private string BASEDADOS = "";
        public string BaseDados
        {
            get
            {
                return this.BASEDADOS;

            }
            set
            {
                this.BASEDADOS = value;
            }
        }

        private string CAMINHOSERVIDOR = "";
        public string CaminhoServidor
        {
            get
            {
                return this.CAMINHOSERVIDOR;

            }
            set
            {
                this.CAMINHOSERVIDOR = value;
            }
        }
        private string CONNECTIONSTRING = "";
        public string connectionString
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

        private string mensagem;

        private string conteudo = "";

        Boolean status = false;

        private Boolean SERVIDOR = false;
        public Boolean Servidor
        {
            get
            {
                return this.SERVIDOR;

            }
            set
            {
                this.SERVIDOR = value;
            }
        }
        private string INICIAL = "";
        public string inicial
        {
            get
            {
                return this.INICIAL;

            }
            set
            {
                this.INICIAL = value;
            }
        }

        private string NUMEROSERVIDOR = "";
        public string NumeroServidor
        {
            get
            {
                return this.NUMEROSERVIDOR;

            }
            set
            {
                this.NUMEROSERVIDOR = value;
            }
        }
        private void FormLoginUsuario_KeyUp(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.F2)
            //{
            //    txtUsuario.Text = "hexen";
            //    txtSenha.Text = "hexen";

            //    AcessoLogin();

            //}
        }
        public FormLoginUsuario()
        {
            InitializeComponent();

            try
            {
                String nomeArquivo = "C:/DateSystem.txt";

                if (System.IO.File.Exists(nomeArquivo))
                {
                    status = true;

                    using (StreamReader texto = new StreamReader(nomeArquivo))
                    {
                        while ((mensagem = texto.ReadLine()) != null)
                        {
                            //dados.Add(mensagem);
                            this.conteudo += mensagem;
                        }
                    }
                }
                else if (!System.IO.File.Exists(nomeArquivo))
                {

                    Servidor = false;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }

            inicial = NumeroBancoDados(this.conteudo);

            string temp = inicial;

            this.comboBoxServidores.Items.AddRange(new object[]
            {
                    "1",
                    "2",
                    "3"
                   
            });
            if (status == true)
            {
                if (inicial == "1")
                {
                    //Driver ={ ODBC Driver 13 for SQL Server}; server = localhost; database = WideWorldImporters; trusted_connection = Yes;
                    comboBoxServidores.SelectedIndex = 0;
                    this.connectionString = "Data Source=ARQUIVOSERVER;Initial Catalog=MSOS;Persist Security Info=True;User ID=msos;Password=msos2019;";
                    labelServidorBase.Text = "SERVIDOR: ARQUIVOSERVER-MSOS";
                    status = true;
                }
                //if (inicial == "2")
                //{
                //    comboBoxServidores.SelectedIndex = 1;
                //    this.connectionString = "Data Source=ARQUIVOSERVER;Initial Catalog=MSOS;Persist Security Info=True;User ID=msos;Password=msos2019;";
                //    labelServidorBase.Text = "SERVIDOR: LOJA";
                //    status = true;
                //}
                if (inicial == "2")
                {
                    comboBoxServidores.SelectedIndex = 1;
                    this.connectionString = "Data Source=ARQUIVOSERVER;Initial Catalog=MSOSTESTE;Persist Security Info=True;User ID=msos;Password=msos2019;";
                    labelServidorBase.Text = "SERVIDOR: ARQUIVOSERVER-MSOSTESTE - LOJA";
                    status = true;
                }
                if (inicial == "3")
                {
                    comboBoxServidores.SelectedIndex = 2;
                    this.connectionString = "Data Source=ARQUIVOSERVER;Initial Catalog=MSOSTESTE2;Persist Security Info=True;User ID=msos;Password=msos2019;";
                    labelServidorBase.Text = "SERVIDOR: ARQUIVOSERVER-MSOSTESTE2 - MSOS TESTE";
                    status = true;
                }
            }
            if (status == false)
            {
                labelServidorBase.Text = "SERVIDOR: SEM SERVIDOR";
            }
        }
        private void comboBoxServidores_SelectedIndexChanged(object sender, EventArgs e)
        {
            int CaseInicial = int.Parse(comboBoxServidores.SelectedItem.ToString());

            if (1 == CaseInicial)
            {
                inicial = "1";
                labelServidorBase.Text = "SERVIDOR:ARQUIVOSERVER-MSOS";
                status = true;
                this.connectionString = "Data Source=ARQUIVOSERVER;Initial Catalog=MSOS;Persist Security Info=True;User ID=msos;Password=msos2019;";

            }

            //if (2 == CaseInicial)
            //{
            //    inicial = "2";
            //    labelServidorBase.Text = "SERVIDOR:LOJA";
            //    status = true;
            //    this.connectionString = "Data Source=ARQUIVOSERVER;Initial Catalog=MSOS;Persist Security Info=True;User ID=sa;Password=dellm@ster2015;";
            //}



            if (2 == CaseInicial)
            {
                inicial = "2";
                labelServidorBase.Text = "SERVIDOR:ARQUIVOSERVER-MSOSTESTE - LOJA";
                status = true;
                this.connectionString = "Data Source=ARQUIVOSERVER;Initial Catalog=MSOSTESTE;Persist Security Info=True;User ID=msos;Password=msos2019;";
            }
            if (3 == CaseInicial)
            {
                inicial = "3";
                labelServidorBase.Text = "SERVIDOR:ARQUIVOSERVER-MSOSTESTE2 - MSOS TESTE";
                status = true;
                this.connectionString = "Data Source=ARQUIVOSERVER;Initial Catalog=MSOSTESTE2;Persist Security Info=True;User ID=msos;Password=msos2019;";
            }
        }

        public static string NumeroBancoDados(string TEXTO_GRANDE)
        {
            try
            {
                int i = 0;

                string retorno = "";

                int quantString = TEXTO_GRANDE.Length;

                StringBuilder sb = new StringBuilder(TEXTO_GRANDE);

                string StringTeste = TEXTO_GRANDE;

                for (i = 0; i <= quantString; i++)
                {
                    if (StringTeste[i] == ';')
                    {
                        char letra = StringTeste[i - 1];
                        retorno = letra.ToString();
                        break;
                    }
                }

                return retorno;
            }

            catch (Exception exp)
            {
                return exp.ToString();
            }
        }
        public static string TrataStringServidor(string NOMEMSOS)
        {
            try
            {
                int i = 0;

                string ServicoExecutado2 = "";

                int quantString = NOMEMSOS.Length;

                StringBuilder sb = new StringBuilder(NOMEMSOS);

                string StringTeste = NOMEMSOS;


                //QUEBRA DE LINHA SE FOR MAS QUE UMA LINHA
                for (i = 0; i <= quantString - 1; i++)
                {
                    if (StringTeste[i] == '\\')
                    {
                        int resto = quantString - i;
                        sb.Remove(i, resto);

                        ServicoExecutado2 = sb.ToString();
                    }
                    if (i == (quantString - 1))
                    {
                        ServicoExecutado2 = sb.ToString();
                    }
                }

                return ServicoExecutado2;
            }
            catch (Exception exp)
            {
                return exp.ToString();
            }
        }
        public static void FechatodosOsFormularios(Type frmType)
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
        //CHAMA O METODO CancelaCadastradoCliente QUE FECHA FORMULÁRIOS ABERTOS
        public void FecharTodosFormulario()
        {
            FechatodosOsFormularios(typeof(FormLoginUsuario));
        }

        private void buttonEntrar_Click(object sender, EventArgs e)
        {
            AcessoLogin();

        }

        private void FormLoginUsuario_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void buttonCancelar_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Deseja Sair do Sistema!", "Aviso", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
            else if (dialogResult == DialogResult.No)
            {

            }
        }
        public void connectionStringAcesso()
        {
        }
        public void AcessoLogin()
        {
            try
            {
                //String nomeArquivo = "C:/MSOS.txt";

                //if (System.IO.File.Exists(nomeArquivo))
                //{
                //    File.WriteAllText(nomeArquivo, comboBoxServidores.SelectedItem.ToString() + ";");
                //}
                //if (!System.IO.File.Exists(nomeArquivo))
                //{
                //    System.IO.File.Create(nomeArquivo).Close();

                //    System.IO.TextWriter arqTXT = System.IO.File.AppendText(nomeArquivo);

                //    arqTXT.WriteLine(comboBoxServidores.SelectedItem.ToString() + ";");

                //    arqTXT.Close();
                //}

                //logado = true;
                //this.Nome = "hexen";
                //this.connectionString = "Data Source=ARQUIVOSERVER;Initial Catalog=MSOSTESTE2;Persist Security Info=True;User ID=master;Password=dellm@ster2016;";
                //this.BaseDados = "MSOSTESTE2";
                //this.Dispose();
               

                if (status == true)
                {
                    SqlConnection conn = new SqlConnection(connectionString);
                    string sql = "exec D_ConsultaNomeUsuarioAcesso '" + txtUsuario.Text + "';";
                    SqlDataAdapter sda = new SqlDataAdapter(sql, conn);
                    DataSet ds = new DataSet();
                    sda.Fill(ds);

                    conn.Open();

                    if (!(ds.Tables[0].Rows.Count > 0))
                    {
                        MessageBox.Show("Usuário ou Senha não registrada!");
                        conn.Close();
                    }
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        string nome = txtUsuario.Text;
                        string SenhaBancoDados = ds.Tables[0].Rows[0][17].ToString();
                        string SenhaFornecida = txtSenha.Text;
                        //int AtualixacaoTelaPrincipal = int.Parse(ds.Tables[0].Rows[0][62].ToString());

                        this.Nome = nome;


                        if (SenhaBancoDados.Equals(SenhaFornecida))
                        {
                            String nomeArquivo = "C:/DateSystem.txt";

                            if (System.IO.File.Exists(nomeArquivo))
                            {
                                File.WriteAllText(nomeArquivo, comboBoxServidores.SelectedItem.ToString() + ";");
                            }
                            if (!System.IO.File.Exists(nomeArquivo))
                            {
                                System.IO.File.Create(nomeArquivo).Close();

                                System.IO.TextWriter arqTXT = System.IO.File.AppendText(nomeArquivo);

                                arqTXT.WriteLine(comboBoxServidores.SelectedItem.ToString() + ";");

                                arqTXT.Close();
                            }

                            logado = true;
                            this.Dispose();

                            FecharTodosFormulario();
                        }
                        if (!SenhaBancoDados.Equals(SenhaFornecida))
                        {
                            MessageBox.Show("Usuário ou Senha estão incorretas!");
                        }

                        conn.Close();
                    }
                }
                if (status == false)
                {
                    MessageBox.Show("SERVIDOR NÃO VÁLIDO!");
                }




                //if (status == true)
                //{

                //    this.conn.Open();

                //    SqlConnection conn = new SqlConnection(connectionString);
                //    string sql = "exec ConsultaNomeUsuarioAcesso '" + txtUsuario.Text + "';";
                //    SqlDataAdapter sda = new SqlDataAdapter(sql, conn);
                //    DataSet ds = new DataSet();
                //    sda.Fill(ds);
                //    if (!(ds.Tables[0].Rows.Count > 0))
                //    {
                //        MessageBox.Show("Usuário e Senha não registrada!");
                //        conn.Close();
                //    }
                //    if (ds.Tables[0].Rows.Count > 0)
                //    {
                //        string nome = txtUsuario.Text;
                //        string SenhaBancoDados = ds.Tables[0].Rows[0][17].ToString();
                //        string SenhaFornecida = txtSenha.Text;

                //        if (SenhaBancoDados.Equals(SenhaFornecida))
                //        {
                //            logado = true;
                //            this.Dispose();
                //        }
                //        if (!SenhaBancoDados.Equals(SenhaFornecida))
                //        {
                //            MessageBox.Show("Usuário ou Senha estão incorretas!");
                //        }
                //        conn.Close();
                //    }

                //}








                //if ((status == false) && (Servidor == true))
                //{
                //    String nomeArquivo = "C:/MSOS.txt";

                //    if (!System.IO.File.Exists(nomeArquivo))
                //    {
                //        System.IO.File.Create(nomeArquivo).Close();

                //        System.IO.TextWriter arqTXT = System.IO.File.AppendText(nomeArquivo);

                //        arqTXT.WriteLine(comboBoxServidores.SelectedItem.ToString() + ";");

                //        arqTXT.Close();

                //    }
                //    this.conn.Open();

                //    SqlConnection conn = new SqlConnection(connectionString);
                //    string sql = "exec ConsultaNomeUsuarioAcesso '" + txtUsuario.Text + "';";
                //    SqlDataAdapter sda = new SqlDataAdapter(sql, conn);
                //    DataSet ds = new DataSet();
                //    sda.Fill(ds);
                //    if (!(ds.Tables[0].Rows.Count > 0))
                //    {
                //        MessageBox.Show("Usuário e Senha não registrada!");
                //        conn.Close();
                //    }
                //    if (ds.Tables[0].Rows.Count > 0)
                //    {
                //        string nome = txtUsuario.Text;
                //        string SenhaBancoDados = ds.Tables[0].Rows[0][17].ToString();
                //        string SenhaFornecida = txtSenha.Text;

                //        if (SenhaBancoDados.Equals(SenhaFornecida))
                //        {
                //            logado = true;
                //            this.Dispose();
                //        }
                //        if (!SenhaBancoDados.Equals(SenhaFornecida))
                //        {
                //            MessageBox.Show("Usuário ou Senha estão incorretas!");
                //        }
                //        conn.Close();
                //    }
                //}
            }
            catch (SqlException ex)
            {
                MessageBox.Show("O banco de dados não responde, Erro gerado pelo o sitema: " + ex.Message);
                this.Close();
                Application.Exit();
            }
        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                AcessoLogin();
            }
        }

        private void txtSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                AcessoLogin();
            }
        }

        
        private void FormLoginUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
            {
                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                String databaseConnectionString = "Data Source=localhost;MultipleActiveResultSets=True;Integrated Security=True";
                using (SqlConnection sqlDatabaseConnection = new SqlConnection(databaseConnectionString))
                {
                    try
                    {
                        sqlDatabaseConnection.Open();
                        string commandString = "SELECT @@VERSION AS 'SQL Server Version'; ";
                        SqlCommand sqlDatabaseCommand = new SqlCommand(commandString, sqlDatabaseConnection);
                        sqlDatabaseCommand.ExecuteNonQuery();
                        string retorno = sqlDatabaseCommand.ToString();
                        retorno.ToString();
                    }
                    catch (Exception ex)
                    {
                        ex.ToString();
                    }
                }

                //ConnectionStringSettings c = ConfigurationManager.ConnectionStrings["DateSystem"];
                //DbProviderFactory factory = DbProviderFactories.GetFactory(c.ProviderName);
                //using (IDbConnection connection = factory.CreateConnection())
                //{
                //    connection.ConnectionString = c.ConnectionString; 

                //}

                //OdbcConnection DbConnection = new OdbcConnection("DSN=DataSystem;");

                //DbConnection.Open();
                //DbConnection.ToString();

                //var conn = new OdbcConnection();
                //conn.ConnectionString = "Dsn=DataSystem";
                //conn.Open();

                ////  "Uid=msos;" +
                ////"Pwd=msos2019;";
                //conn.Open();
                //conn.ToString();


            }
            catch(Exception ex)
            {
                ex.ToString();
            }

        }
    }
}
