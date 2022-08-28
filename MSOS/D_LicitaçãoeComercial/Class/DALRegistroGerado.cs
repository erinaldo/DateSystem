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
    class DALRegistroGerado
    {
        private Conexao objConexao;

        public DALRegistroGerado(Conexao conexao)
        {
            objConexao = conexao;
        }
        public void IncluirClienteRegistro(Registro ClienteRegistro)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = objConexao.ObjetoConexao;

            cmd.CommandText = "EXEC D_R_PessoaRegistroInserir @idPessoa, @Nome; ";

            cmd.Parameters.AddWithValue("@idPessoa", ClienteRegistro.idPessoa);
            //cmd.Parameters.AddWithValue("@IdPessoaTipo", Fisica.IdPessoaTipo);
            cmd.Parameters.AddWithValue("@Nome", ClienteRegistro.Nome);

            objConexao.Conectar();

            cmd.ExecuteScalar();
        }
        //Adiciona um registro gerado de um cliente!
        public void IncluirClienteRegistroGerado(RegistroGerados ClienteRegistroGerado)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = objConexao.ObjetoConexao;

            cmd.CommandText = "EXEC D_R_RegistroGeradoInserir @IdClienteRegistro, @IdContato, @Estado, @Situacao," +
                "@IdPessoaLogada, @IdPessoaLogadaAlterada, @OrigemRegistro, @DataCriadoRegistrado, @DataContato;";

            cmd.Parameters.AddWithValue("@IdClienteRegistro", ClienteRegistroGerado.IdClienteRegistro);

            cmd.Parameters.AddWithValue("@IdContato", ClienteRegistroGerado.IdContato);

            cmd.Parameters.AddWithValue("@Estado", ClienteRegistroGerado.Estado);

            cmd.Parameters.AddWithValue("@Situacao", ClienteRegistroGerado.Situacao);

            cmd.Parameters.AddWithValue("@IdPessoaLogada", ClienteRegistroGerado.IdPessoaLogada);

            cmd.Parameters.AddWithValue("@IdPessoaLogadaAlterada", ClienteRegistroGerado.IdPessoaLogadaAlterada);

            cmd.Parameters.AddWithValue("@OrigemRegistro", ClienteRegistroGerado.OrigemRegistro);

            cmd.Parameters.AddWithValue("@DataCriadoRegistrado", ClienteRegistroGerado.DataCriadoRegistrado);

            cmd.Parameters.AddWithValue("@DataContato", ClienteRegistroGerado.DataContato);

            objConexao.Conectar();

            ClienteRegistroGerado.IdGeradoRegistro = Convert.ToInt32(cmd.ExecuteScalar());

            objConexao.Desconectar();

        }
        public void AlterarClienteRegistroGerado(RegistroGerados ClienteRegistroGerado)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = objConexao.ObjetoConexao;

            cmd.CommandText = "EXEC D_R_RegistroGeradoUpdates @IdGeradoRegistro, @Estado, @Situacao, @IdPessoaLogadaAlterada," +
                "@OrigemRegistro, @MudancaDataFechamento;";

            cmd.Parameters.AddWithValue("@IdGeradoRegistro", ClienteRegistroGerado.IdGeradoRegistro);

            cmd.Parameters.AddWithValue("@Estado", ClienteRegistroGerado.Estado);

            cmd.Parameters.AddWithValue("@Situacao", ClienteRegistroGerado.Situacao);

            cmd.Parameters.AddWithValue("@IdPessoaLogadaAlterada", ClienteRegistroGerado.IdPessoaLogadaAlterada);

            cmd.Parameters.AddWithValue("@OrigemRegistro", ClienteRegistroGerado.OrigemRegistro);

            //FECHAMENTO DO REGISTRO GERADO
            if (ClienteRegistroGerado.Estado == 1 || ClienteRegistroGerado.Estado == 2)
            {
                if (!(ClienteRegistroGerado.MudancaDataFechamento == null))
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@MudancaDataFechamento", ClienteRegistroGerado.MudancaDataFechamento).Value = SqlDateTime.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@MudancaDataFechamento", ClienteRegistroGerado.MudancaDataFechamento);
                }
            }
            if (ClienteRegistroGerado.Estado == 3)
            {
                cmd.Parameters.AddWithValue("@MudancaDataFechamento", ClienteRegistroGerado.MudancaDataFechamento);
            }


            objConexao.Conectar();

            cmd.ExecuteScalar();

            objConexao.Desconectar();

        }
        public void AlterarClienteRegistroGeradoSub(RegistroGeradoSub RegistroGeradoSubs)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = objConexao.ObjetoConexao;

            cmd.CommandText = "EXEC D_R_RegistroGeradoSubUpdates @IdRegistroSub, @Situacao, @IdPessoaLogadaAlterada," +
                "@OrigemRegistro;";

            cmd.Parameters.AddWithValue("@IdRegistroSub", RegistroGeradoSubs.IdRegistroSub);

            cmd.Parameters.AddWithValue("@Situacao", RegistroGeradoSubs.Situacao);

            cmd.Parameters.AddWithValue("@IdPessoaLogadaAlterada", RegistroGeradoSubs.IdPessoaLogadaAlterada);

            cmd.Parameters.AddWithValue("@OrigemRegistro", RegistroGeradoSubs.OrigemRegistro);

            objConexao.Conectar();

            cmd.ExecuteScalar();

            objConexao.Desconectar();

        }
        //Adiciona um registro gerado de um cliente!
        public void IncluirClienteRegistroGeradoSub(RegistroGeradoSub ClienteRegistroGeradoSub)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = objConexao.ObjetoConexao;

            cmd.CommandText = "EXEC D_R_RegistroGeradoSubInserir @IdRegistro,@IdRegistroSub,@IdClienteRegistro,@IdContato,@Situacao," +
                "@IdPessoaLogada,@IdPessoaLogadaAlterada,@OrigemRegistro,@DataCriadoRegistrado,@DataContato;";

            cmd.Parameters.AddWithValue("@IdRegistro", ClienteRegistroGeradoSub.IdRegistro);

            cmd.Parameters.AddWithValue("@IdRegistroSub", ClienteRegistroGeradoSub.IdRegistroSub);

            cmd.Parameters.AddWithValue("@IdClienteRegistro", ClienteRegistroGeradoSub.IdClienteRegistro);

            cmd.Parameters.AddWithValue("@IdContato", ClienteRegistroGeradoSub.IdContato);

            cmd.Parameters.AddWithValue("@Situacao", ClienteRegistroGeradoSub.Situacao);

            cmd.Parameters.AddWithValue("@IdPessoaLogada", ClienteRegistroGeradoSub.IdPessoaLogada);

            cmd.Parameters.AddWithValue("@IdPessoaLogadaAlterada", ClienteRegistroGeradoSub.IdPessoaLogadaAlterada);

            cmd.Parameters.AddWithValue("@OrigemRegistro", ClienteRegistroGeradoSub.OrigemRegistro);

            cmd.Parameters.AddWithValue("@DataCriadoRegistrado", ClienteRegistroGeradoSub.DataCriadoRegistrado);

            cmd.Parameters.AddWithValue("@DataContato", ClienteRegistroGeradoSub.DataContato);

            //cmd.Parameters.AddWithValue("@MudancaDataFechamento", ClienteRegistroGerado.MudancaDataFechamento);
            objConexao.Conectar();

            cmd.ExecuteScalar();

            objConexao.Desconectar();
        }
    }
}
