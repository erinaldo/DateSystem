
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
    class DALOrdemServico
    {
        private Conexao objConexao;
        public DALOrdemServico(Conexao conexao)
        {
            objConexao = conexao;
        }
        //Clientes OS
        public void IncluirCliente(Clientes Cliente)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = objConexao.ObjetoConexao;

            cmd.CommandText = "EXEC D_PessoaClienteInserir @IdCliente, @Ms ; ";

            cmd.Parameters.AddWithValue("@IdCliente", Cliente.idPessoa);
            //cmd.Parameters.AddWithValue("@IdPessoaTipo", Fisica.IdPessoaTipo);
            cmd.Parameters.AddWithValue("@Ms", Cliente.IdMs);

            objConexao.Conectar();

            cmd.ExecuteScalar();
        }
        //Base de Dados Funcionario Os. ---------------------------------------------------------------------------------------------------------------------------
        public void IncluirFuncionarioOs(FuncionarioOS FuncionarioOs)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = objConexao.ObjetoConexao;

            cmd.CommandText = "EXEC D_FuncionarioOsInserir @IdFuncionario,@IdRe,@Abreviacao,@Telefone,@Telefone2,@Celular,@Celular2,@Email;";
            cmd.Parameters.AddWithValue("@IdFuncionario", FuncionarioOs.IdFuncionario);
            cmd.Parameters.AddWithValue("@IdRe", FuncionarioOs.IdRe);
            if (FuncionarioOs.Abreviacao == "")
            {
                // passa valor nulo para a tabela
                cmd.Parameters.AddWithValue("@Abreviacao", FuncionarioOs.Abreviacao).Value = SqlDateTime.Null;
            }
            else
            {
                cmd.Parameters.AddWithValue("@Abreviacao", FuncionarioOs.Abreviacao);
            }
            if (FuncionarioOs.Telefone == "")
            {
                // passa valor nulo para a tabela
                cmd.Parameters.AddWithValue("@Telefone", FuncionarioOs.Telefone).Value = SqlDateTime.Null;
            }
            else
            {
                cmd.Parameters.AddWithValue("@Telefone", FuncionarioOs.Telefone);
            }
            if (FuncionarioOs.Telefone2 == "")
            {
                // passa valor nulo para a tabela
                cmd.Parameters.AddWithValue("@Telefone2", FuncionarioOs.Telefone2).Value = SqlDateTime.Null;
            }
            else
            {
                cmd.Parameters.AddWithValue("@Telefone2", FuncionarioOs.Telefone2);
            }
            if (FuncionarioOs.Celular == "")
            {
                // passa valor nulo para a tabela
                cmd.Parameters.AddWithValue("@Celular", FuncionarioOs.Celular).Value = SqlDateTime.Null;
            }
            else
            {
                cmd.Parameters.AddWithValue("@Celular", FuncionarioOs.Celular);
            }
            if (FuncionarioOs.Celular2 == "")
            {
                // passa valor nulo para a tabela
                cmd.Parameters.AddWithValue("@Celular2", FuncionarioOs.Celular2).Value = SqlDateTime.Null;
            }
            else
            {
                cmd.Parameters.AddWithValue("@Celular2", FuncionarioOs.Celular2);
            }
            if (FuncionarioOs.Email == "")
            {
                // passa valor nulo para a tabela
                cmd.Parameters.AddWithValue("@Email", FuncionarioOs.Email).Value = SqlDateTime.Null;
            }
            else
            {
                cmd.Parameters.AddWithValue("@Email", FuncionarioOs.Email);
            }
            objConexao.Conectar();
            cmd.ExecuteScalar();
            objConexao.Desconectar();
        }
        //Base de Dados Funcionario. E tambem Cep---------------------------------------------------------------------------------------------------------------------------
        public void IncluiOS(Os cliente)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = objConexao.ObjetoConexao;

            cmd.CommandText = "EXEC D_O_OsInserir @idPessoa,@IdContato,@Funcionario,@IdServico,@IdItemServico,@IdEstado,@IdSituacao,@IdPessoaLogada,@OrigemChamado,@ServicosExecutados,@ValorObra," +
                "@HorarioInicio,@HorarioFinal,@DataSolicitacao,@DataFechamento;";

            cmd.Parameters.AddWithValue("@idPessoa", cliente.IdPessoaCliente);

            if (cliente.IdContato == 0)//
            {
                // passa valor nulo para a tabela
                cmd.Parameters.AddWithValue("@IdContato", cliente.IdContato).Value = SqlBinary.Null;
            }
            else
            {
                cmd.Parameters.AddWithValue("@IdContato", cliente.IdContato);
            }
            cmd.Parameters.AddWithValue("@Funcionario", cliente.IdFuncionario);
            cmd.Parameters.AddWithValue("@IdServico", cliente.IdServico);
            cmd.Parameters.AddWithValue("@IdItemServico", cliente.IdItemServico);
            cmd.Parameters.AddWithValue("@IdEstado", cliente.Estado);
            cmd.Parameters.AddWithValue("@IdSituacao", cliente.Situacao);
            cmd.Parameters.AddWithValue("@IdPessoaLogada", cliente.IdPessoaLogada);

            if (cliente.OrigemChamado == "")
            {
                // passa valor nulo para a tabela
                cmd.Parameters.AddWithValue("@OrigemChamado", cliente.OrigemChamado).Value = SqlDateTime.Null;
            }
            else
            {
                cmd.Parameters.AddWithValue("@OrigemChamado", cliente.OrigemChamado);
            }
            if (cliente.ServicosExecutados == "")
            {
                // passa valor nulo para a tabela
                cmd.Parameters.AddWithValue("@ServicosExecutados", cliente.ServicosExecutados).Value = SqlDateTime.Null;
            }
            else
            {
                cmd.Parameters.AddWithValue("@ServicosExecutados", cliente.ServicosExecutados);
            }
            if (cliente.ValorObra == "")
            {
                // passa valor nulo para a tabela
                cmd.Parameters.AddWithValue("@ValorObra", cliente.ValorObra).Value = SqlDateTime.Null;
            }
            else
            {
                cmd.Parameters.AddWithValue("@ValorObra", cliente.ValorObra);
            }
            if (cliente.HorarioInicio == "")
            {
                // passa valor nulo para a tabela
                cmd.Parameters.AddWithValue("@HorarioInicio", cliente.HorarioInicio).Value = SqlDateTime.Null;
            }
            else
            {
                cmd.Parameters.AddWithValue("@HorarioInicio", cliente.HorarioInicio);
            }
            if (cliente.HorarioFinal == "")
            {
                // passa valor nulo para a tabela
                cmd.Parameters.AddWithValue("@HorarioFinal", cliente.HorarioFinal).Value = SqlDateTime.Null;
            }
            else
            {
                cmd.Parameters.AddWithValue("@HorarioFinal", cliente.HorarioFinal);
            }
            cmd.Parameters.AddWithValue("@DataSolicitacao", cliente.DataSolicitacao);

            //if (cliente.DataSolicitacao == "")
            //{
            //    // passa valor nulo para a tabela
            //    cmd.Parameters.AddWithValue("@DataSolicitacao", cliente.DataSolicitacao).Value = SqlDateTime.Null;
            //}
            //else
            //{
            //    cmd.Parameters.AddWithValue("@DataSolicitacao", cliente.DataSolicitacao);
            //}
            if (cliente.MudancaDataFechamento == 0)
            {
                if (!(cliente.DataFechamento == null))
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@DataFechamento", cliente.DataFechamento).Value = SqlDateTime.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@DataFechamento", cliente.DataFechamento);
                }
            }
            if (cliente.MudancaDataFechamento == 1)
            {
                if ((cliente.DataFechamento == null))
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@DataFechamento", cliente.DataFechamento).Value = SqlDateTime.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@DataFechamento", cliente.DataFechamento);
                }
            }

            objConexao.Conectar();

            cliente.IdOs = Convert.ToInt32(cmd.ExecuteScalar());
        }
        //Clientes OS
        //Base de Dados Funcionario. E tambem Cep---------------------------------------------------------------------------------------------------------------------------
        public void AlteraOS(Os cliente)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = objConexao.ObjetoConexao;

            cmd.CommandText = "EXEC D_O_OsUpdates @IdOs,@IdContatoCliente,@IdPessoaLogadaAlterada,@OrigemChamado,@ServicosExecutados, @HorarioInicio,@HorarioFinal,@DataFechamento,@Estado,@Situacao;";

            cmd.Parameters.AddWithValue("@IdOs", cliente.IdOs);
            cmd.Parameters.AddWithValue("@Situacao", cliente.Situacao);
            if (cliente.IdContato.ToString() == "")
            {
                // passa valor nulo para a tabela
                cmd.Parameters.AddWithValue("@IdContatoCliente", cliente.IdContato).Value = SqlDateTime.Null;
            }
            else
            {
                cmd.Parameters.AddWithValue("@IdContatoCliente", cliente.IdContato);
            }
            cmd.Parameters.AddWithValue("@IdPessoaLogadaAlterada", cliente.IdPessoaLogadaAlterada);
            if (cliente.OrigemChamado == "")
            {
                // passa valor nulo para a tabela
                cmd.Parameters.AddWithValue("@OrigemChamado", cliente.OrigemChamado).Value = SqlDateTime.Null;
            }
            else
            {
                cmd.Parameters.AddWithValue("@OrigemChamado", cliente.OrigemChamado);
            }
            if (cliente.ServicosExecutados == "")
            {
                // passa valor nulo para a tabela
                cmd.Parameters.AddWithValue("@ServicosExecutados", cliente.ServicosExecutados).Value = SqlDateTime.Null;
            }
            else
            {
                cmd.Parameters.AddWithValue("@ServicosExecutados", cliente.ServicosExecutados);
            }
            if (cliente.HorarioInicio == "")
            {
                // passa valor nulo para a tabela
                cmd.Parameters.AddWithValue("@HorarioInicio", cliente.HorarioInicio).Value = SqlDateTime.Null;
            }
            else
            {
                cmd.Parameters.AddWithValue("@HorarioInicio", cliente.HorarioInicio);
            }
            if (cliente.HorarioFinal == "")
            {
                // passa valor nulo para a tabela
                cmd.Parameters.AddWithValue("@HorarioFinal", cliente.HorarioFinal).Value = SqlDateTime.Null;
            }
            else
            {
                cmd.Parameters.AddWithValue("@HorarioFinal", cliente.HorarioFinal);
            }
            cmd.Parameters.AddWithValue("@Estado", cliente.Estado);
            if (cliente.MudancaDataFechamento == 0)
            {
                if (!(cliente.DataFechamento == null))
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@DataFechamento", cliente.DataFechamento).Value = SqlDateTime.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@DataFechamento", cliente.DataFechamento);
                }
            }
            if (cliente.MudancaDataFechamento == 1)
            {
                if ((cliente.DataFechamento == null))
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@DataFechamento", cliente.DataFechamento).Value = SqlDateTime.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@DataFechamento", cliente.DataFechamento);
                }
            }
            objConexao.Conectar();

            cmd.ExecuteNonQuery();

            objConexao.Desconectar();

            if (cliente.IdContato == 0)
            {
                SqlCommand cmd1 = new SqlCommand();

                cmd1.Connection = objConexao.ObjetoConexao;

                cmd1.CommandText = "UPDATE O_OrdemServico SET ID_CONTATO = NULL WHERE ID_ORDEM_SERVICO =@IdOs; ";

                cmd1.Parameters.AddWithValue("@IdOs", cliente.IdOs);

                objConexao.Conectar();

                cmd1.ExecuteNonQuery();

                objConexao.Desconectar();
            }


        }
        public void OsUpadateAtiva(OsAtiva OsAtiva)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = objConexao.ObjetoConexao;

            //transacao = objConexao.ObjetoConexao.BeginTransaction("");


            cmd.CommandText = "EXEC D_O_OsUpdatesAtiva @NumeroOS,@IdCliente,@Situacao;";

            cmd.Parameters.AddWithValue("@NumeroOS", OsAtiva.NumeroOS);
            cmd.Parameters.AddWithValue("@IdCliente", OsAtiva.IdCliente);
            cmd.Parameters.AddWithValue("@Situacao", OsAtiva.Situacao);

            objConexao.Conectar();
            cmd.ExecuteNonQuery();
            objConexao.Desconectar();
        }
        //Base de Dados Os Imagem
        //Incluir Imagem de Os
        public void IncluirOsImagem(OsImagem Imagem)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = objConexao.ObjetoConexao;

            //transacao = objConexao.ObjetoConexao.BeginTransaction("");


            cmd.CommandText = "EXEC D_O_OsImagemInserir @IdOs,@Imagem;";

            cmd.Parameters.AddWithValue("@IdOs", Imagem.IdOs);
            cmd.Parameters.AddWithValue("@Imagem", Imagem.Imagem);

            objConexao.Conectar();
            cmd.ExecuteScalar();
        }
        public void AlterarOsImagem(OsImagem Imagem)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = objConexao.ObjetoConexao;

            //transacao = objConexao.ObjetoConexao.BeginTransaction("");


            cmd.CommandText = "EXEC D_O_OsImagemUpdate @IdOs,@Imagem;";

            cmd.Parameters.AddWithValue("@IdOs", Imagem.IdOs);
            cmd.Parameters.AddWithValue("@Imagem", Imagem.Imagem);


            objConexao.Conectar();

            cmd.ExecuteScalar();
        }
        //Excluir Os
        public void ExcluirOs(int IdOs)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = objConexao.ObjetoConexao;

            cmd.CommandText = "delete from O_OrdemServico where ID_ORDEM_SERVICO = @IdOs;";
            cmd.Parameters.AddWithValue("@IdOs", IdOs);

            objConexao.Conectar();
            cmd.ExecuteNonQuery();
            objConexao.Desconectar();

        }
        //Excluir Os
        public void TelaPrincipalConfiguracao(TelaPrincipalConfiguracao TPC)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = objConexao.ObjetoConexao;

            cmd.CommandText = "exec D_TelaPrincipalConfiguracaoUpdate @idUsuario,@VerificadorOS;";
            cmd.Parameters.AddWithValue("@idUsuario", TPC.idUsuario);
            cmd.Parameters.AddWithValue("@VerificadorOS", TPC.VerificadorOS);

            objConexao.Conectar();
            cmd.ExecuteNonQuery();
            objConexao.Desconectar();
        }
    }
}
