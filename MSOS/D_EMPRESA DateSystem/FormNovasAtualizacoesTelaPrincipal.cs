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
    public partial class FormNovasAtualizacoesTelaPrincipal : Form
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
        public FormNovasAtualizacoesTelaPrincipal(string NOMESERVIDOR, string NOMEBASEDADOS, string NOMESUARIO, string SENHABASEDADOS,
            int IDUSUARIO)
        {
            InitializeComponent();

            this.NomeServidor = NOMESERVIDOR;
            this.NomeBaseDados = NOMEBASEDADOS;
            this.NomeUsuario = NOMESUARIO;
            this.SenhaBaseDados = SENHABASEDADOS;
            this.IdUsuario = IDUSUARIO;

            TextoDeAtualizacao();

            this.connetionString = "Data Source=" + this.NomeServidor + ";Initial Catalog=" + this.NomeBaseDados + ";Persist Security Info=True;User ID=" + this.NomeUsuario + ";Password=" + this.SenhaBaseDados + ";";
        }
        public void TextoDeAtualizacao()
        {

            

                String S =
                "1   -> Uso manual e automático de busca por Cnpj em tempo real. \n" +
                "2   ->Atalho de recursos F3 e F4.Permissão para Verificar Os abertas seja inicializada. \n" +
                "3   ->Botões abreviados: S = Salvar, C = Cancelar, F = Fechar, L = Limpar, E = Editar, D = Deletar e T = Texto. \n" +
                "4   ->Corrigidos erro ocorrido a salvar os editadas. \n" +
                "5   ->Melhoria na busca de novas informações na base dados. \n" +
                "6   ->Liberado modulo de Registro Liberado modulo de registro de novos clientes. \n" +
                "6.1 ->Cadastro de clientes registro. \n" +
                "6.2 ->Cadastro de contatos de clientes registro.\n" +
                "6.3 ->Gerar de registro. \n" +
                "6.4 ->Gerar de Sub-registro. \n" +
                "6.5 ->Pesquisa de clientes registro. \n" +
                "6.6 ->Pesquisa de contatos de clientes registro. \n" +
                "6.7 ->Pesquisa Cadastro de registro. \n" +
                "6.8 ->Pesquisa Cadastro de Sub-registro. \n" +
                "7   ->Confirmação para Os e registro novos. \n" +
                "8   ->Alteração de uso na Razão Social para o usuário. \n" +
                "Versão do Sistema DateSystem 1.5 \n";

            txtAtualizacaoTelaPrincipal.Text = S.Replace("\r\n", "\n").Replace("\n", Environment.NewLine);
        }

        private void FormNovasAtualizacoesTelaPrincipal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
            {
                this.Close();
            }
        }

        private void FormNovasAtualizacoesTelaPrincipal_Load(object sender, EventArgs e)
        {

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
            CancelaCadastradoTelaPrincipal(typeof(FormNovasAtualizacoesTelaPrincipal));
        }

        private void buttonFecharTela_Click(object sender, EventArgs e)
        {
            FecharTodosFormulario();
        }

        private void buttonSalvarAlteracao_Click(object sender, EventArgs e)
        {
            try
            {
                //Tela Principal Mostra Novas Atualização no sistema.
                TelaPrincipalNovaAtualizacaoTexto TelaPrincipalNovaAtualizacaoTextoU = new TelaPrincipalNovaAtualizacaoTexto();
                TelaPrincipalNovaAtualizacaoTextoU.idUsuario = this.IdUsuario;

                if (checkBoxAtivo.Checked == true)
                {
                    TelaPrincipalNovaAtualizacaoTextoU.AtualizacaoTelaPrincipal = 1;
                }
                if (checkBoxAtivo.Checked == false)
                {
                    TelaPrincipalNovaAtualizacaoTextoU.AtualizacaoTelaPrincipal = 0;
                }

                Conexao conexao = new Conexao(this.connetionString);
                DALDateSystem dal = new DALDateSystem(conexao);//cadastra Pesssoa Juridica 

                dal.TelaPrincipalNovasAtualizacoesTexto(TelaPrincipalNovaAtualizacaoTextoU);
                FecharTodosFormulario();
                MessageBox.Show("Alterações no DateSystem realizado com exito! \n Só fechar o Programa e Reabri-lo!");
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
        }

        private void txtAtualizacaoTelaPrincipal_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void checkBoxAtivo_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
