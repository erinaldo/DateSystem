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
    class Conexao
    {
        private string _StringConexao;
        private SqlConnection _conexao;
       // private SqlTransaction transacao;
        public Conexao(string dadosConexao)
        {
            this._conexao = new SqlConnection();
            this.StringConexao = dadosConexao;
            this._conexao.ConnectionString = dadosConexao;
            //this.transacao = _conexao.BeginTransaction("");
        }
        
        public string StringConexao
        {
            get
            {
                return this._StringConexao;
            }
            set
            {
                this._StringConexao = value;
            }
        }
        public SqlConnection ObjetoConexao
        {
            get
            {
                return this._conexao;
            }
            set
            {
                this._conexao = value;
            }
        }
        /*
        public SqlTransaction ObjetoTransacao
        {
            get
            {
                return this.transacao;
            }
            set
            {
                this.transacao = value;
            }
        }
        public void commit()
        {
            this.transacao.Commit();
        }
        public void Rollback()
        {
            this.transacao.Rollback();
        }*/

        public void Conectar()
        {
            this._conexao.Open();
        }
        public void Desconectar()
        {
            this._conexao.Close();
        }
    }
}
