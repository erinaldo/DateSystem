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
    public partial class FormOspesquisaNumerosLivres : Form
    {
        DataTable TableTodos;
        DataTable TableCliente;
        DataTable TableNome;

        private int VALORPESQUISA = 0;
        public int ValorPesquisa
        {
            get
            {
                return this.VALORPESQUISA;

            }
            set
            {
                this.VALORPESQUISA = value;
            }
        }
        private int IDCLIENTEA = 0;
        public int IdClienteA
        {
            get
            {
                return this.IDCLIENTEA;

            }
            set
            {
                this.IDCLIENTEA = value;
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
        private int IDPESSOATIPO = 0;
        public int idPessoaTipo
        {
            get
            {
                return this.IDPESSOATIPO;

            }
            set
            {
                this.IDPESSOATIPO = value;
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
        public FormOspesquisaNumerosLivres(string NomeServidor, string NomeBaseDados, string NomeUsuario, string SenhaBaseDados)
        {
            InitializeComponent();

            this.NomeServidor = NomeServidor;
            this.NomeBaseDados = NomeBaseDados;
            this.NomeUsuario = NomeUsuario;
            this.SenhaBaseDados = SenhaBaseDados;

            this.connetionString = "Data Source=" + this.NomeServidor + ";Initial Catalog=" + this.NomeBaseDados + ";Persist Security Info=True;User ID=" + this.NomeUsuario + ";Password=" + this.SenhaBaseDados + ";";
        }
        public void AlteraBotoes(int op)
        {
            if (op == 1)//limpa textos
            {
                txtPesquisaMSCliente.Clear();
                txtPesquisaNomeCliente.Clear();
            }
        }
        private void FormOspesquisaNumerosLivres_Load(object sender, EventArgs e)
        {

        }
        //Pesquisa todos clientes cadastrados
        void dataGridViewPesquisaCliente()
        {
            string connetionString = (this.connetionString);
            SqlConnection connection = new SqlConnection(connetionString);
            SqlCommand command = new SqlCommand("EXEC D_O_ConsultaClienteOS '" + txtPesquisaNomeCliente.Text + "';", connection);
            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = command;
                TableCliente = new DataTable();
                adapter.Fill(TableCliente);
                BindingSource Source = new BindingSource();
                Source.DataSource = TableCliente;
                dataGridViewCliente.DataSource = Source;
                adapter.Update(TableCliente);
            }
            catch (Exception ex)
            {
                ex.ToString();
            }

            //DataTable dt = new DataTable();
        }
        public void PesquisaCliente()
        {
            //String connectionString = "Data Source=PROGRAMAS;Initial Catalog=MSOS;Persist Security Info=True;User ID=sa;Password=dellm@ster2016;";
            SqlConnection conn = new SqlConnection(this.connetionString);

            if (radioButtonPequisaMS.Checked)
            {
                if (txtPesquisaMSCliente.Text == "")
                {
                    MessageBox.Show("O nome campo MS nao pode esta em branco! ");
                    AlteraBotoes(10);
                }

                if (!(txtPesquisaMSCliente.Text == ""))
                {
                    int MS = int.Parse(this.txtPesquisaMSCliente.Text);
                    //SELECIONA POR MS
                    SqlDataAdapter da1 = new SqlDataAdapter("EXEC D_ConsultaPessoaMsClienteTxt " + MS + ",1; ", conn);
                    DataSet ds1 = new DataSet();
                    da1.Fill(ds1);

                    conn.Open();

                    if (ds1.Tables[0].Rows.Count > 0)
                    {
                        IdPessoa = int.Parse(ds1.Tables[0].Rows[0][0].ToString());
                        idPessoaTipo = int.Parse(ds1.Tables[0].Rows[0][1].ToString());
                        string Nome = ds1.Tables[0].Rows[0][3].ToString();

                        try
                        {

                            if (IdClienteA == 0)
                            {
                                MessageBox.Show("Selecione um cliente desativado. E depois busca um novo cliente por ms ou nome. ");
                            }
                            if (IdClienteA > 0)
                            {
                                DialogResult dialogResult = MessageBox.Show("Deseja troca a Ordem de Serviço " + this.IdClienteA + " para o cliente " + Nome + "!", "Aviso", MessageBoxButtons.YesNo);
                                if (dialogResult == DialogResult.Yes)
                                {
                                    OsAtiva OsAtivadas = new OsAtiva();

                                    OsAtivadas.NumeroOS = this.IdClienteA;
                                    OsAtivadas.IdCliente = this.IdPessoa;
                                    OsAtivadas.Situacao = 1;

                                    //Salva as alterações na Os Cliente
                                    Conexao conexao = new Conexao(this.connetionString);
                                    DALOrdemServico da = new DALOrdemServico(conexao);
                                    da.OsUpadateAtiva(OsAtivadas);
                                    dataGridViewPesquisa.Refresh();
                                    dataGridViewPesquisaTodos();
                                    IdClienteA = 0;
                                    label1.Text = "Quantidade de Os desativada: " + dataGridViewPesquisa.RowCount.ToString();
                                }
                                else if (dialogResult == DialogResult.No)
                                {

                                }
                            }
                            conn.Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }



                    }
                    if (!(ds1.Tables[0].Rows.Count > 0))
                    {
                        MessageBox.Show("O ms: " + MS + " não consta no sistema!");

                        AlteraBotoes(10);
                        conn.Close();

                    }
                }
            }
            if (radioButtonPesquisaNome.Checked)
            {
                if (txtPesquisaNomeCliente.Text == "")
                {
                    //dataGridViewPesquisaCliente.Columns.Clear();
                    dataGridViewCliente.Refresh();

                    label2.Text = "Quantidade de clientes: " + dataGridViewCliente.RowCount.ToString();

                    MessageBox.Show("O nome não pode esta em Branco!");
                }
                if (!(txtPesquisaNomeCliente.Text == ""))
                {
                    //SELECIONA POR TODOS OS 
                    SqlDataAdapter da1 = new SqlDataAdapter("EXEC D_O_ConsultaClienteOS '" + txtPesquisaNomeCliente.Text + "';", conn);
                    DataSet ds1 = new DataSet();
                    da1.Fill(ds1);

                    conn.Open();

                    if (!(ds1.Tables[0].Rows.Count > 0))
                    {
                        if (dataGridViewCliente.DataSource == null)
                        {
                            dataGridViewCliente.Refresh();
                        }
                        if (!(dataGridViewCliente.DataSource == null))
                        {
                            dataGridViewCliente.Refresh();
                        }
                        label2.Text = "Quantidade de clientes: " + dataGridViewCliente.RowCount.ToString();
                        dataGridViewCliente.Enabled = false;

                        MessageBox.Show("Nem um Registro de nome Achado!");
                        conn.Close();
                    }
                    if (ds1.Tables[0].Rows.Count > 0)
                    {
                        dataGridViewCliente.Enabled = true;
                        dataGridViewPesquisaCliente();
                        dataGridViewPesquisa.RowCount.ToString();
                        conn.Close();
                    }
                }
            }
            else if (!(radioButtonPequisaMS.Checked) && !(radioButtonPesquisaNome.Checked)) MessageBox.Show("Seleciona Ms ou Nome para uma Pesquisa!");
            {
                conn.Close();
            }
        }
        public void OsSituacaoF()
        {
            SqlConnection conn = new SqlConnection(this.connetionString);
            //SELECIONA POR TODOS OS 
            SqlDataAdapter da1 = new SqlDataAdapter("Exec D_O_ConsultaOsSituacaoDesativada;", conn);
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
                    //dataGridViewPesquisa.Columns.Clear();
                    dataGridViewPesquisa.Refresh();
                }
                label1.Text = "Quantidade de Os desativada: " + dataGridViewPesquisa.RowCount.ToString();
                MessageBox.Show("Nem um Registro de OS Achado!");

                conn.Close();
            }
            if (ds1.Tables[0].Rows.Count > 0)
            {
                dataGridViewPesquisaTodos();
                label1.Text = "Quantidade de Os desativada: " + dataGridViewPesquisa.RowCount.ToString();

            }
        }
        //Pesquisa todos clientes com ordem de serviço desativados
        void dataGridViewPesquisaTodos()
        {
            string connetionString = (this.connetionString);
            SqlConnection connection = new SqlConnection(connetionString);
            SqlCommand command = new SqlCommand("Exec D_O_ConsultaOsSituacaoDesativada;", connection);
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
        private void dataGridViewPesquisa_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dataGridViewPesquisa.RowCount == 0)
            {

            }
            if (!(dataGridViewPesquisa.RowCount == 0))
            {
                try
                {
                    this.IdClienteA = Convert.ToInt32(dataGridViewPesquisa["ORDEM_SERVIÇO", e.RowIndex].Value);
                    //string NomeCLiente = Convert.ToString(dataGridViewPesquisa["ORDEM_SERVIÇO", e.RowIndex].Value);

                    MessageBox.Show("Ordem de serviço selecionada é: " + IdClienteA.ToString() + ".");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void buttonBuscaOS_Click(object sender, EventArgs e)
        {
            OsSituacaoF();
        }

        private void radioButtonPequisaMS_CheckedChanged(object sender, EventArgs e)
        {
            txtPesquisaMSCliente.Enabled = true;
            txtPesquisaNomeCliente.Enabled = false;
            AlteraBotoes(10);
        }

        private void radioButtonPesquisaNome_CheckedChanged(object sender, EventArgs e)
        {
            txtPesquisaMSCliente.Enabled = false;
            txtPesquisaNomeCliente.Enabled = true;
            AlteraBotoes(10);
        }

        private void buttonPesquisaCliente_Click(object sender, EventArgs e)
        {
            PesquisaCliente();
        }

        private void txtPesquisaNomeCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                ValorPesquisa = 2;
                PesquisaCliente();
            }
        }

        private void txtPesquisaMSCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                ValorPesquisa = 1;
                PesquisaCliente();
            }
        }

        private void dataGridViewCliente_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                string Nome1 = "";

                IdPessoa = Convert.ToInt32(dataGridViewCliente["ID_PESSOA", e.RowIndex].Value);
                Nome1 = Convert.ToString(dataGridViewCliente["CLIENTE", e.RowIndex].Value);

                if (IdClienteA == 0)
                {
                    MessageBox.Show("Selecione um cliente desativado. E depois busca um novo cliente por ms ou nome. ");
                }
                if (IdClienteA > 0)
                {
                    DialogResult dialogResult = MessageBox.Show("Deseja troca a Ordem de Serviço " + this.IdClienteA + " para o cliente " + Nome1 + "!", "Aviso", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        OsAtiva OsAtivadas = new OsAtiva();

                        OsAtivadas.NumeroOS = IdClienteA;
                        OsAtivadas.IdCliente = IdPessoa;
                        OsAtivadas.Situacao = 1;

                        OsAtivadas.NumeroOS.ToString();
                        OsAtivadas.IdCliente.ToString();
                        OsAtivadas.Situacao.ToString();


                        //Salva as alterações na Os Cliente
                        Conexao conexao = new Conexao(this.connetionString);
                        DALOrdemServico da = new DALOrdemServico(conexao);
                        da.OsUpadateAtiva(OsAtivadas);
                        dataGridViewPesquisa.Refresh();
                        dataGridViewPesquisaTodos();

                        IdClienteA = 0;

                        label1.Text = "Quantidade de Os desativada: " + dataGridViewPesquisa.RowCount.ToString();
                    }
                    else if (dialogResult == DialogResult.No)
                    {

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void txtPesquisaNomeCliente_TextChanged(object sender, EventArgs e)
        {
            if (ValorPesquisa == 2)
            {
                DataView DV = new DataView(TableNome);
                DV.RowFilter = string.Format("CLIENTE LIKE '%{0}%'", txtPesquisaNomeCliente.Text);
                dataGridViewCliente.DataSource = DV;
                label2.Text = "Quantidade de clientes: " + dataGridViewCliente.RowCount.ToString();
            }
        }

        private void FormOspesquisaNumerosLivres_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
            {
                this.Close();
            }
        }
    }
}
