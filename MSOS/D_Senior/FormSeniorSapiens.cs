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
    public partial class FormSeniorSapiens : Form
    {
        DataTable TableTodos;

        public int QUANTUSUARIO = 0;
        public int QuantUsuario
        {
            get
            {
                return this.QUANTUSUARIO;

            }
            set
            {
                this.QUANTUSUARIO = value;
            }
        }

        public int IDUSUARIO1 = 0;
        public int IdUsuario1
        {
            get
            {
                return this.IDUSUARIO1;

            }
            set
            {
                this.IDUSUARIO1 = value;
            }
        }
        public string NOMEUSUARIO1 = "";
        public string NomeUsuario1
        {
            get
            {
                return this.NOMEUSUARIO1;

            }
            set
            {
                this.NOMEUSUARIO1 = value;
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
        public FormSeniorSapiens(string NOMEUSUARIO1)
        {
            InitializeComponent();

            this.NomeUsuario1 = NOMEUSUARIO1;

            String connectionString = "Data Source=PROGRAMAS;Initial Catalog=MSOS;Persist Security Info=True;User ID=sa;Password=dellm@ster2016;";
            SqlConnection conn = new SqlConnection(connectionString);
            string sql = "exec D_ConsultaNomeAcesso '" + NomeUsuario1 + "';";
            SqlDataAdapter sda = new SqlDataAdapter(sql, conn);
            DataSet ds1 = new DataSet();
            sda.Fill(ds1);


            //PERMISSÃO DE SENIOR SAPIENS
            this.SeniorSapiensAcesso = int.Parse(ds1.Tables[0].Rows[0][44].ToString());
            this.SeniorSapiensPesquisa = int.Parse(ds1.Tables[0].Rows[0][45].ToString());
            this.SeniorSapiensExcluir = int.Parse(ds1.Tables[0].Rows[0][46].ToString());

            conn.Close();


        }
        public FormSeniorSapiens(int SeniorSapiensPesquisa, int SeniorSapiensExcluir)
        {
            InitializeComponent();

            //PERMISSÃO DE SENIOR SAPIENS
            this.SeniorSapiensPesquisa = SeniorSapiensPesquisa;
            this.SeniorSapiensExcluir = SeniorSapiensExcluir;
        }


        private void FormSeniorSapiens_Load(object sender, EventArgs e)
        {

        }

        void dataGridViewPesquisaTodos()
        {
           // Data Source = SISTEM; Initial Catalog = sapiens; User ID = sapiens; Password = ***********
            string connetionString = ("Data Source=SISTEM;Initial Catalog=sapiens;Persist Security Info=True;User ID=sapiens;Password=sapiens;");
            SqlConnection connection = new SqlConnection(connetionString);
            SqlCommand command = new SqlCommand("select NumSec AS IDUSUARIO,DatTim AS DATTIM, ComNam AS NOMECOMPUTADOR,"+
                                                "UsrNam AS NOMEUSUARIO, AppNam AS SISTEMA, AppUsr AS NOMEUSUARIOAPLI, idinst AS IDINST "+
                                                "FROM sapiens.sapiens.R911SEC order by UsrNam; ", connection);
            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = command;
                TableTodos = new DataTable();
                adapter.Fill(TableTodos);
                BindingSource Source = new BindingSource();
                Source.DataSource = TableTodos;
                bool[] status = { true };


                for (int i = 0; i < QuantUsuario; i++)
                {
                    DataRow TableTodos2 = TableTodos.NewRow();
                    TableTodos2["SELECIONAR"]=status[i];
                    TableTodos.Rows.Add(TableTodos2);
                }

                dataGridViewPesquisaSenior.DataSource = Source;
                adapter.Update(TableTodos);
            }
            catch (Exception ex)
            {
                ex.ToString();
            }

            //DataTable dt = new DataTable();
        }
        private void BuscarUsuariosNosistemaSenior()
        {
            if (SeniorSapiensPesquisa == 0)
            {
                MessageBox.Show("Acesso não Permitido!");
            }
            if (SeniorSapiensPesquisa == 1)
            {

                String connectionString = "Data Source=SISTEM;Initial Catalog=sapiens;Persist Security Info=True;User ID=sapiens;Password=sapiens;";

                SqlConnection conn = new SqlConnection(connectionString);


                //SELECIONA POR TODOS OS 
                SqlDataAdapter da1 = new SqlDataAdapter("select NumSec AS IDUSUARIO,DatTim AS DATTIM, ComNam AS NOMECOMPUTADOR," +
                                                        "UsrNam AS NOMEUSUARIO, AppNam AS SISTEMA, AppUsr AS NOMEUSUARIOAPLI, idinst AS IDINST " +
                                                        "FROM sapiens.sapiens.R911SEC order by UsrNam; ", conn);
                DataSet ds1 = new DataSet();
                da1.Fill(ds1);

                conn.Open();

                label2.Text = dataGridViewPesquisaSenior.RowCount.ToString();

                this.QuantUsuario = int.Parse(dataGridViewPesquisaSenior.RowCount.ToString());

                if (!(ds1.Tables[0].Rows.Count > 0))
                {
                    if (dataGridViewPesquisaSenior.DataSource == null)
                    {
                        dataGridViewPesquisaSenior.Refresh();
                    }
                    if (!(dataGridViewPesquisaSenior.DataSource == null))
                    {
                        dataGridViewPesquisaSenior.Refresh();
                    }

                    conn.Close();
                }
                if (ds1.Tables[0].Rows.Count > 0)
                {
                    conn.Close();

                    dataGridViewPesquisaTodos();


                    dataGridViewPesquisaSenior.RowCount.ToString();
                }
            }
        }
        private void buttonPesquisaUsuario_Click(object sender, EventArgs e)
        {
            BuscarUsuariosNosistemaSenior();
        }

        private void dataGridViewPesquisaSenior_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if ((dataGridViewPesquisaSenior.RowCount == 0) && (SeniorSapiensExcluir == 0))
            {
                MessageBox.Show("Acesso não Permitido!");
            }
            if (!(dataGridViewPesquisaSenior.RowCount == 0) && (SeniorSapiensExcluir == 0))
            {
                MessageBox.Show("Acesso não Permitido!");
            }
            if (!(dataGridViewPesquisaSenior.RowCount == 0) && (SeniorSapiensExcluir == 1))
            {                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                   
                try
                {
                    this.IdUsuario1 = Convert.ToInt32(dataGridViewPesquisaSenior["IDUSUARIO", e.RowIndex].Value);

                    string nome = Convert.ToString(dataGridViewPesquisaSenior["NOMEUSUARIO", e.RowIndex].Value);
                    string nome1 = Convert.ToString(dataGridViewPesquisaSenior["NOMEUSUARIOAPLI", e.RowIndex].Value);

                    string strConexao = "Data Source=SISTEM;Initial Catalog=sapiens;Persist Security Info=True;User ID=sapiens;Password=sapiens;";
                    Conexao conexao = new Conexao(strConexao);
                    DALSapiens dal = new DALSapiens(conexao);

                    if (this.IDUSUARIO1 > 0)
                    {
                        DialogResult dialogResult = MessageBox.Show("Deseja derruba o computador "+ nome +" nome do usuário: "+nome1+ " ?", "Aviso", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                        {
                            dal.ExcluirUSenior(this.IdUsuario1);

                            dataGridViewPesquisaTodos();
                            dataGridViewPesquisaSenior.Refresh();

                            String connectionString = "Data Source=SISTEM;Initial Catalog=sapiens;Persist Security Info=True;User ID=sapiens;Password=sapiens;";

                            SqlConnection conn = new SqlConnection(connectionString);

                            //SELECIONA POR TODOS OS 
                            SqlDataAdapter da1 = new SqlDataAdapter("select * FROM sapiens.sapiens.R911SEC WHERE NumSec = " + this.IdUsuario1+";", conn);
                            DataSet ds1 = new DataSet();
                            da1.Fill(ds1);

                            String connectionString2 = "Data Source=SISTEM;Initial Catalog=sapiens;Persist Security Info=True;User ID=sapiens;Password=sapiens;";

                            SqlConnection conn2 = new SqlConnection(connectionString2);

                            //SELECIONA POR TODOS OS 
                            SqlDataAdapter da2 = new SqlDataAdapter("select * FROM sapiens.sapiens.R911SEC WHERE NumSec = " + this.IdUsuario1 + ";", conn2);
                            DataSet ds2 = new DataSet();
                            da2.Fill(ds2);

                            conn.Open();

                            if ((ds1.Tables[0].Rows.Count > 0) && (ds2.Tables[0].Rows.Count > 0))
                            {
                                MessageBox.Show("O usuário não foi derrubado do sistema!");
                                conn.Close();
                                conn2.Open();
                            }
                            if (!(ds1.Tables[0].Rows.Count > 0) && (ds2.Tables[0].Rows.Count > 0))
                            {
                                MessageBox.Show("O usuário não foi derrubado do sistema!");
                                conn.Close();
                                conn2.Open();
                            }
                            if ((ds1.Tables[0].Rows.Count > 0) && !(ds2.Tables[0].Rows.Count > 0))
                            {
                                MessageBox.Show("O usuário não foi derrubado do sistema!");
                                conn.Close();
                                conn2.Open();
                            }
                            if (!(ds1.Tables[0].Rows.Count > 0)&& !(ds2.Tables[0].Rows.Count > 0))
                            {
                                MessageBox.Show("O usuário foi derrubado do sistema!");
                                conn.Close();
                                conn2.Open();
                            }
                            dataGridViewPesquisaTodos();
                            dataGridViewPesquisaSenior.Refresh();
                        }
                        else if (dialogResult == DialogResult.No)
                        {

                        }
                    }
                }
                catch (Exception ex)
                {
                    ex.ToString();
                }
            }
        }

        private void checkBoxSapiens_MouseClick(object sender, MouseEventArgs e)
        {
            if (SeniorSapiensPesquisa == 0)
            {
                MessageBox.Show("Acesso não Permitido!");
            }
            if (SeniorSapiensPesquisa == 1)
            {
                DialogResult dialogResult = MessageBox.Show("Deseja derruba Todos os usuários do Sapiens?", "Tem certeza?", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    String connectionString = "Data Source=SISTEM;Initial Catalog=sapiens;Persist Security Info=True;User ID=sapiens;Password=sapiens;";

                    SqlConnection conn = new SqlConnection(connectionString);


                    //EXCLUIR CLIENTES INTEGRADOS
                    SqlDataAdapter da1 = new SqlDataAdapter("delete from sapiens.sapiens.r911mod; ", conn);
                    DataSet ds1 = new DataSet();
                    da1.Fill(ds1);

                    conn.Close();

                    //SELECIONA POR TODOS OS 
                    SqlDataAdapter da4 = new SqlDataAdapter("delete from sapiens.sapiens.R911SEC ", conn);
                    DataSet ds4 = new DataSet();
                    da4.Fill(ds4);

                    conn.Close();


                    //SELECIONA POR TODOS OS 
                    SqlDataAdapter da2 = new SqlDataAdapter("select * FROM sapiens.sapiens.R911SEC WHERE NumSec = " + this.IdUsuario1 + ";", conn);
                    DataSet ds2 = new DataSet();
                    da2.Fill(ds2);

                    conn.Close();

                    //SELECIONA POR TODOS OS 
                    SqlDataAdapter da3 = new SqlDataAdapter("select * FROM sapiens.sapiens.R911SEC WHERE NumSec = " + this.IdUsuario1 + ";", conn);
                    DataSet ds3 = new DataSet();
                    da3.Fill(ds3);

                    conn.Open();

                    if ((ds2.Tables[0].Rows.Count > 0) && (ds3.Tables[0].Rows.Count > 0))
                    {
                        MessageBox.Show("Todos os usuários não foram derrubados do sistema!");
                        conn.Close();
                    }
                    if (!(ds2.Tables[0].Rows.Count > 0) && (ds3.Tables[0].Rows.Count > 0))
                    {
                        MessageBox.Show("Todos os usuários não foram derrubados do sistema!");
                        conn.Close();
                    }
                    if ((ds2.Tables[0].Rows.Count > 0) && !(ds3.Tables[0].Rows.Count > 0))
                    {
                        MessageBox.Show("Todos os usuários não foram derrubados do sistema!");
                        conn.Close();
                    }
                    if (!(ds2.Tables[0].Rows.Count > 0) && !(ds3.Tables[0].Rows.Count > 0))
                    {
                        MessageBox.Show("Todos os usuário foram derrubados do sistema!");
                        conn.Close();
                    }

                    checkBoxSapiens.Checked = false;

                }
                else if (dialogResult == DialogResult.No)
                {
                    checkBoxSapiens.Checked = false;
                }
            }
        }

        private void FormSeniorSapiens_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
            {
                this.Close();
            }
        }

        private void buttonSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
