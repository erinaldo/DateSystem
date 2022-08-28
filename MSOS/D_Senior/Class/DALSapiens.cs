using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Data.SqlTypes;
using System.Data;

namespace DateSystem
{
    class DALSapiens
    {
        private Conexao objConexao;

        public DALSapiens(Conexao conexao)
        {
            objConexao = conexao;
        }

        //Usuário do Senior

        public void ExcluirUSenior(int idUsuario)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = objConexao.ObjetoConexao;

            cmd.CommandText = "delete from sapiens.sapiens.r911mod where numsec = @idUsuario;";
            cmd.Parameters.AddWithValue("@idUsuario", idUsuario);

            objConexao.Conectar();
            cmd.ExecuteNonQuery();
            objConexao.Desconectar();

            SqlCommand cmd1 = new SqlCommand();
            cmd1.Connection = objConexao.ObjetoConexao;

            cmd1.CommandText = "delete from sapiens.sapiens.R911SEC where numsec = @idUsuario;";

            cmd1.Parameters.AddWithValue("@idUsuario", idUsuario);

            objConexao.Conectar();
            cmd1.ExecuteNonQuery();
            objConexao.Desconectar();
        }
    }
}
