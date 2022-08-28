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
    public partial class FormPesquisaLoginUsuario : Form
    {
        DataTable TableTodos;
        DataTable TableNome;

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


        DataTable TableAcessoUsuario;
        

        public FormPesquisaLoginUsuario(string NomeServidor, string NomeBaseDados, string NomeUsuario, string SenhaBaseDados)
        {
            InitializeComponent();

            this.NomeServidor = NomeServidor;
            this.NomeBaseDados = NomeBaseDados;
            this.NomeUsuario = NomeUsuario;
            this.SenhaBaseDados = SenhaBaseDados;

            this.connetionString = "Data Source=" + this.NomeServidor + ";Initial Catalog=" + this.NomeBaseDados + ";Persist Security Info=True;User ID=" + this.NomeUsuario + ";Password=" + this.SenhaBaseDados + ";";

        }
        public FormPesquisaLoginUsuario(string NOMEACESSO,int USUARIOACESSO, int USUARIOALTERAR,int USUARIOEXCLUIR,int USUARIOVISUALIZAR,
            string NomeServidor, string NomeBaseDados, string NomeUsuario, string SenhaBaseDados)
        {
            InitializeComponent();

            this.NomeAcesso = NOMEACESSO;
            this.UsuarioAcesso = USUARIOACESSO;
            this.UsuarioAlterar = USUARIOALTERAR;
            this.UsuarioExcluir = USUARIOEXCLUIR;
            this.UsuarioVisualizar = USUARIOVISUALIZAR;

            this.NomeServidor = NomeServidor;
            this.NomeBaseDados = NomeBaseDados;
            this.NomeUsuario = NomeUsuario;
            this.SenhaBaseDados = SenhaBaseDados;

            this.connetionString = "Data Source=" + this.NomeServidor + ";Initial Catalog=" + this.NomeBaseDados + ";Persist Security Info=True;User ID=" + this.NomeUsuario + ";Password=" + this.SenhaBaseDados + ";";

        }

        private void radioButtonTodos_CheckedChanged(object sender, EventArgs e)
        {
            txtPesquisaUsuario.Enabled = false;
        }

        private void radioButtonPesquisaFuncionario_CheckedChanged(object sender, EventArgs e)
        {
            txtPesquisaUsuario.Enabled = true;
        }

        private void buttonFuncionarioPesquisa_Click(object sender, EventArgs e)
        {
            int situacao = 0;

            if (checkBoxSituacao.Checked == true)
            {
                situacao = 1;
            }
            if (checkBoxSituacao.Checked == false)
            {
                situacao = 2;
            }
            SqlConnection conn = new SqlConnection(this.connetionString);

            if (!(radioButtonPesquisaUsuario.Checked == true) && !(radioButtonTodos.Checked == true))
            {
                MessageBox.Show("Seleciona um modo de busca, por Todos ou Nome! ");
            }
            if (radioButtonTodos.Checked)
            {

                // dataGridViewPesquisaCliente.Columns.Clear();
                dataGridViewPesquisa.Refresh();

                label8.Text = dataGridViewPesquisa.RowCount.ToString();


                //SELECIONA POR TODOS OS 
                SqlDataAdapter da1 = new SqlDataAdapter("EXEC ConsultaUsuarioAcessoTodosTxt " + situacao, conn);
                DataSet ds1 = new DataSet();
                da1.Fill(ds1);
                conn.Open();

                if (!(ds1.Tables[0].Rows.Count > 0))
                {
                    if (dataGridViewPesquisa.DataSource == null)
                    {
                        dataGridViewPesquisa.Refresh();
                    }
                    if (!(dataGridViewPesquisa.DataSource == null))
                    {
                        // dataGridViewPesquisaCliente.Columns.Clear();
                        dataGridViewPesquisa.Refresh();
                    }
                    label8.Text = dataGridViewPesquisa.RowCount.ToString();

                    MessageBox.Show("Nem um Registro Achado!");
                    conn.Close();
                }
                if (ds1.Tables[0].Rows.Count > 0)
                {
                    conn.Close();

                    dataGridViewPesquisaTodos();
                    label8.Text = dataGridViewPesquisa.RowCount.ToString();
                }

            }
            if (radioButtonPesquisaUsuario.Checked)
            {
                if (txtPesquisaUsuario.Text == "")
                {
                    //dataGridViewPesquisaCliente.Columns.Clear();
                    dataGridViewPesquisa.Refresh();

                    label8.Text = dataGridViewPesquisa.RowCount.ToString();

                    MessageBox.Show("O nome não pode esta em Branco!");
                }
                if (!(txtPesquisaUsuario.Text == ""))
                {
                    //SELECIONA POR TODOS OS 
                    SqlDataAdapter da1 = new SqlDataAdapter("EXEC ConsultaUsuarioAcessoNomeTxt '" + txtPesquisaUsuario.Text + "'," + situacao + ";", conn);
                    DataSet ds1 = new DataSet();
                    da1.Fill(ds1);

                    conn.Open();

                    if (!(ds1.Tables[0].Rows.Count > 0))
                    {
                        if (dataGridViewPesquisa.DataSource == null)
                        {
                            dataGridViewPesquisa.Refresh();
                        }
                        if (!(dataGridViewPesquisa.DataSource == null))
                        {
                            // dataGridViewPesquisaCliente.Columns.Clear();
                            dataGridViewPesquisa.Refresh();
                        }
                        label8.Text = dataGridViewPesquisa.RowCount.ToString();

                        MessageBox.Show("Nem um Registro de nome Achado!");
                        conn.Close();
                    }
                    if (ds1.Tables[0].Rows.Count > 0)
                    {
                        conn.Close();

                        dataGridViewPesquisaNome();
                        label8.Text = dataGridViewPesquisa.RowCount.ToString();
                    }
                }
            }
        }

        private void FormPesquisaLoginUsuario_Load(object sender, EventArgs e)
        {

        }
        void dataGridViewPesquisaTodos()
        {
            int situacao = 0;

            if (checkBoxSituacao.Checked == true)
            {
                situacao = 1;
            }
            if (checkBoxSituacao.Checked == false)
            {
                situacao = 2;
            }
            SqlConnection connection = new SqlConnection(this.connetionString);
            SqlCommand command = new SqlCommand("Exec ConsultaUsuarioAcessoTodosTxt " + situacao + ";", connection);
            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = command;
                TableTodos = new DataTable();
                adapter.Fill(TableTodos);
                BindingSource Source = new BindingSource();
                Source.DataSource = TableTodos;
                dataGridViewPesquisa.DataSource = Source;
                adapter.Update(TableTodos);
            }
            catch (Exception ex)
            {
                ex.ToString();
            }

            //DataTable dt = new DataTable();
        }
        void dataGridViewPesquisaNome()
        {
            int situacao = 0;

            if (checkBoxSituacao.Checked == true)
            {
                situacao = 1;
            }
            if (checkBoxSituacao.Checked == false)
            {
                situacao = 2;
            }
            SqlConnection connection = new SqlConnection(this.connetionString);
            SqlCommand command = new SqlCommand("Exec ConsultaUsuarioAcessoNomeTxt '" + txtPesquisaUsuario.Text + "'," + situacao + ";", connection);
            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = command;
                TableNome = new DataTable();
                adapter.Fill(TableNome);
                BindingSource Source = new BindingSource();
                Source.DataSource = TableNome;
                dataGridViewPesquisa.DataSource = Source;
                adapter.Update(TableNome);
            }
            catch (Exception ex)
            {
                ex.ToString();
            }

            //DataTable dt = new DataTable();
        }
        //METODO PARA VERIFICA SE O FORMULÁRIO ESTA ABERTO SE TIVER ELE FECHA!
        public static void CancelaCadastradoFuncionario(Type frmType)
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
            CancelaCadastradoFuncionario(typeof(FormPesquisaLoginUsuario));
        }
        private void buttonCancelarOs_Click(object sender, EventArgs e)
        {
            FecharTodosFormulario();

            FormPesquisaLoginUsuario cadastracliente = new FormPesquisaLoginUsuario(this.NomeServidor, this.NomeBaseDados, this.NomeUsuario, this.SenhaBaseDados);
            cadastracliente.MdiParent = FormPesquisaLoginUsuario.ActiveForm;
            cadastracliente.Show();
            cadastracliente.Top = 0;
            cadastracliente.Left = 0;
        }

        private void buttonFecharOs_Click(object sender, EventArgs e)
        {
            FecharTodosFormulario();
        }

        private void dataGridViewPesquisa_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (UsuarioVisualizar == 0)
            {
                MessageBox.Show("Acesso não Permitido!");
            }
            if (UsuarioVisualizar == 1)
            {
                try
                {
                    IdPessoa = Convert.ToInt32(dataGridViewPesquisa["ID_ACESSO", e.RowIndex].Value);
                    //MessageBox.Show("11   " + IdPessoa);
                    FormPesquisaLoginUsuarioEditar ClientePesquisaE = new FormPesquisaLoginUsuarioEditar(IdPessoa, this.NomeAcesso, this.UsuarioAcesso, this.UsuarioAlterar, UsuarioExcluir,
                        this.NomeServidor, this.NomeBaseDados, this.NomeUsuario, this.SenhaBaseDados);
                    ClientePesquisaE.MdiParent = FormPesquisaLoginUsuarioEditar.ActiveForm;
                    ClientePesquisaE.Show();
                    ClientePesquisaE.Top = 0;
                    ClientePesquisaE.Left = 0;
                }
                catch (Exception ex)
                {
                    ex.ToString();
                }
            }
        }

        private void txtPesquisaUsuario_TextChanged(object sender, EventArgs e)
        {
            DataView DV = new DataView(TableAcessoUsuario);
            DV.RowFilter = string.Format("NOME LIKE '%{0}%'", txtPesquisaUsuario.Text);
            dataGridViewPesquisa.DataSource = DV;
            label8.Text = dataGridViewPesquisa.RowCount.ToString();
        }
    }
}
