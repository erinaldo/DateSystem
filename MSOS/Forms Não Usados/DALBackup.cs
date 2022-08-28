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
    class DALBackup
    {
        private Conexao objConexao;

        public DALBackup(Conexao conexao)
        {
            objConexao = conexao;
        }


        //Base de Dados Clientes Fisica e Juridica. E tambem Cep---------------------------------------------------------------------------------------------------------------------------
        public void Incluir(Pessoa cliente)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = objConexao.ObjetoConexao;

            //transacao = objConexao.ObjetoConexao.BeginTransaction("");


            cmd.CommandText = "EXEC D_PessoaInserir @IdTipoPessoa,@Situacao,@Nome,@Telefone,@Telefone2,@FaxTelefone,@TelexTelefone," +
                              " @Email,@Observacao,@Tipo,@CpMunicipio,@Municipio,@Pais,@DesPais; select @@IDENTITY;";
            cmd.Parameters.AddWithValue("@IdTipoPessoa", cliente.IdPessoaTipo);
            cmd.Parameters.AddWithValue("@Situacao", cliente.Situacao);
            cmd.Parameters.AddWithValue("@Nome", cliente.Nome);

            if (cliente.Telefone == "")
            {
                // passa valor nulo para a tabela
                cmd.Parameters.AddWithValue("@Telefone", cliente.Telefone).Value = SqlDateTime.Null;
            }
            else
            {
                cmd.Parameters.AddWithValue("@Telefone", cliente.Telefone);
            }
            if (cliente.Telefone2 == "")
            {
                // passa valor nulo para a tabela
                cmd.Parameters.AddWithValue("@Telefone2", cliente.Telefone2).Value = SqlDateTime.Null;
            }
            else
            {
                cmd.Parameters.AddWithValue("@Telefone2", cliente.Telefone2);
            }
            if (cliente.FaxTelefone == "")
            {
                // passa valor nulo para a tabela
                cmd.Parameters.AddWithValue("@FaxTelefone", cliente.FaxTelefone).Value = SqlDateTime.Null;
            }
            else
            {
                cmd.Parameters.AddWithValue("@FaxTelefone", cliente.FaxTelefone);
            }
            if (cliente.TelexTelefone == "")
            {
                // passa valor nulo para a tabela
                cmd.Parameters.AddWithValue("@TelexTelefone", cliente.TelexTelefone).Value = SqlDateTime.Null;
            }
            else
            {
                cmd.Parameters.AddWithValue("@TelexTelefone", cliente.TelexTelefone);
            }
            cmd.Parameters.AddWithValue("@Email", cliente.Email);

            if (cliente.Observacao == "")
            {
                // passa valor nulo para a tabela
                cmd.Parameters.AddWithValue("@Observacao", cliente.Observacao).Value = SqlDateTime.Null;
            }
            else
            {
                cmd.Parameters.AddWithValue("@Observacao", cliente.Observacao);
            }
            if (cliente.Tipo == "")
            {
                // passa valor nulo para a tabela
                cmd.Parameters.AddWithValue("@Tipo", cliente.Tipo).Value = SqlDateTime.Null;
            }
            else
            {
                cmd.Parameters.AddWithValue("@Tipo", cliente.Tipo);
            }
            if (cliente.CpMunicipio == "")
            {
                // passa valor nulo para a tabela
                cmd.Parameters.AddWithValue("@CpMunicipio", cliente.CpMunicipio).Value = SqlDateTime.Null;
            }
            else
            {
                cmd.Parameters.AddWithValue("@CpMunicipio", cliente.CpMunicipio);
            }
            if (cliente.Municipio == "")
            {
                // passa valor nulo para a tabela
                cmd.Parameters.AddWithValue("@Municipio", cliente.Municipio).Value = SqlDateTime.Null;
            }
            else
            {
                cmd.Parameters.AddWithValue("@Municipio", cliente.Municipio);
            }
            if (cliente.Pais == "")
            {
                // passa valor nulo para a tabela
                cmd.Parameters.AddWithValue("@Pais", cliente.Pais).Value = SqlDateTime.Null;
            }
            else
            {
                cmd.Parameters.AddWithValue("@Pais", cliente.Pais);
            }
            if (cliente.DesPais == "")
            {
                // passa valor nulo para a tabela
                cmd.Parameters.AddWithValue("@DesPais", cliente.DesPais).Value = SqlDateTime.Null;
            }
            else
            {
                cmd.Parameters.AddWithValue("@DesPais", cliente.DesPais);
            }

            objConexao.Conectar();

            cliente.idPessoa = Convert.ToInt32(cmd.ExecuteScalar());

            objConexao.Desconectar();

        }
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
        public void IncluirPessoaFIsica(PessoaFisica Fisica)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = objConexao.ObjetoConexao;
            //transacao = objConexao.ObjetoConexao.BeginTransaction("SampleTransaction");
            /*
            cmd.CommandText = "INSERT INTO [dbo].[P_Fisica] (ID_PESSOA_FISICA,ID_PESSOA_TIPO,SEXO,CPF,RG,DATA_NASCIMENTO,CELULAR,CELULAR2) VALUES(@idPessoaFisica,@IdPessoaTipo,@Sexo,@Cpf," +
            "@Rg,@dataNacimento,@Celular,@Celular2);select @@IDENTITY;";
            */
            cmd.CommandText = "EXEC D_PessoaFisicaInserir @idPessoaFisica,@Nome1,@Sexo,@Cpf,@Rg,@dataNacimento,@Celular,@Celular2;";

            cmd.Parameters.AddWithValue("@idPessoaFisica", Fisica.idPessoaFisica);
            //cmd.Parameters.AddWithValue("@IdPessoaTipo", Fisica.IdPessoaTipo);
            cmd.Parameters.AddWithValue("@Sexo", Fisica.Sexo);
            cmd.Parameters.AddWithValue("@Cpf", Fisica.Cpf);
            cmd.Parameters.AddWithValue("@Rg", Fisica.Rg);
            cmd.Parameters.AddWithValue("@dataNacimento", Fisica.dataNacimento);
            cmd.Parameters.AddWithValue("@Celular", Fisica.Celular);

            if (Fisica.Nome == "")
            {
                // passa valor nulo para a tabela
                cmd.Parameters.AddWithValue("@Nome1", Fisica.Nome).Value = SqlDateTime.Null;
            }
            else
            {
                cmd.Parameters.AddWithValue("@Nome1", Fisica.Nome);
            }

            if (Fisica.Celular2 == "")
            {
                // passa valor nulo para a tabela
                cmd.Parameters.AddWithValue("@Celular2", Fisica.Celular2).Value = SqlDateTime.Null;
            }
            else
            {
                cmd.Parameters.AddWithValue("@Celular2", Fisica.Celular2);
            }

            objConexao.Conectar();

            cmd.ExecuteScalar();

            SqlCommand cmd1 = new SqlCommand();
            cmd1.Connection = objConexao.ObjetoConexao;

            cmd1.CommandText = "UPDATE [dbo].[P_Pessoa] SET[ID_PESSOA_TIPO] = 1 WHERE ID_PESSOA = @idPessoaFisica; ";
            cmd1.Parameters.AddWithValue("@idPessoaFisica", Fisica.idPessoaFisica);


            cmd1.ExecuteScalar();

        }
        public void IncluirPessoaJuridica(PessoaJuridica Juridica)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = objConexao.ObjetoConexao;
            //transacao = objConexao.ObjetoConexao.BeginTransaction("SampleTransaction");
            cmd.CommandText = "EXEC D_PessoaJuridicaInserir @idPessoaJuridica,@RazaoSocial,@Cnpj,@NomeContato, @InscricaoStadual,@Cnae;";
            cmd.Parameters.AddWithValue("@idPessoaJuridica", Juridica.idPessoaJuridica);
            cmd.Parameters.AddWithValue("@RazaoSocial", Juridica.RazaoSocial);
            cmd.Parameters.AddWithValue("@Cnpj", Juridica.Cnpj);

            if (Juridica.NomeContato == "")
            {
                // passa valor nulo para a tabela
                cmd.Parameters.AddWithValue("@NomeContato", Juridica.NomeContato).Value = SqlDateTime.Null;
            }
            else
            {
                cmd.Parameters.AddWithValue("@NomeContato", Juridica.NomeContato);
            }

            if (Juridica.InscricaoStadual == "")
            {
                // passa valor nulo para a tabela
                cmd.Parameters.AddWithValue("@InscricaoStadual", Juridica.InscricaoStadual).Value = SqlDateTime.Null;
            }
            else
            {
                cmd.Parameters.AddWithValue("@InscricaoStadual", Juridica.InscricaoStadual);
            }
            if (Juridica.Cnae == "")
            {
                // passa valor nulo para a tabela
                cmd.Parameters.AddWithValue("@Cnae", Juridica.Cnae).Value = SqlDateTime.Null;
            }
            else
            {
                cmd.Parameters.AddWithValue("@Cnae", Juridica.Cnae);
            }

            objConexao.Conectar();

            cmd.ExecuteScalar();


        }

        public void IncluirCepFisico(CepF cep)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = objConexao.ObjetoConexao;

            /*
            cmd.CommandText = "INSERT INTO [dbo].[P_Cep]([ID_CEP],[CEP],[TIPO_LOGRADOURO],[ENDERECO],[NUMERO],[COMPLEMENTO],[BAIRRO],[CIDADE],[SIGLA_CIDADE])"
            + " VALUES(@IdCep,@Cep,@TipoLogradouro,@Endereco,@Numero,@Complemento,@Bairro,@Cidade,@SiglaCidade);select @@IDENTITY;";
            */
            cmd.CommandText = "exec D_PessoaCepPrincipalFInserir @IdCep,@Cep,@Endereco,@Numero,@Complemento,@Bairro,@Cidade;select @@IDENTITY;";

            cmd.Parameters.AddWithValue("@IdCep", cep.idCep);
            cmd.Parameters.AddWithValue("@Cep", cep.Cepc);
            cmd.Parameters.AddWithValue("Numero", cep.Numero);

            if (cep.Complemento == "")
            {
                // passa valor nulo para a tabela
                cmd.Parameters.AddWithValue("@Complemento", cep.Complemento).Value = SqlDateTime.Null;
            }
            else
            {
                cmd.Parameters.AddWithValue("@Complemento", cep.Complemento);
            }
            if (cep.Endereco == "")
            {
                // passa valor nulo para a tabela
                cmd.Parameters.AddWithValue("@Endereco", cep.Endereco).Value = SqlDateTime.Null;
            }
            else
            {
                cmd.Parameters.AddWithValue("@Endereco", cep.Endereco);
            }
            if (cep.Bairro == "")
            {
                // passa valor nulo para a tabela
                cmd.Parameters.AddWithValue("@Bairro", cep.Bairro).Value = SqlDateTime.Null;
            }
            else
            {
                cmd.Parameters.AddWithValue("@Bairro", cep.Bairro);
            }
            if (cep.Cidade == "")
            {
                // passa valor nulo para a tabela
                cmd.Parameters.AddWithValue("@Cidade", cep.Cidade).Value = SqlDateTime.Null;
            }
            else
            {
                cmd.Parameters.AddWithValue("@Cidade", cep.Cidade);
            }

            objConexao.Conectar();
            cmd.ExecuteScalar();

        }
        public void IncluirCepJuridico(CepJ cep)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = objConexao.ObjetoConexao;

            cmd.CommandText = "exec D_PessoaCepPrincipalJInserir @IdCep,@Cep,@Endereco,@Numero,@Complemento,@Bairro,@Cidade;select @@IDENTITY;";

            cmd.Parameters.AddWithValue("@IdCep", cep.idCep);
            cmd.Parameters.AddWithValue("@Cep", cep.Cepc);
            cmd.Parameters.AddWithValue("@Endereco", cep.Endereco);
            cmd.Parameters.AddWithValue("Numero", cep.Numero);

            if (cep.Complemento == "")
            {
                // passa valor nulo para a tabela
                cmd.Parameters.AddWithValue("@Complemento", cep.Complemento).Value = SqlDateTime.Null;
            }
            else
            {
                cmd.Parameters.AddWithValue("@Complemento", cep.Complemento);
            }
            cmd.Parameters.AddWithValue("@Bairro", cep.Bairro);
            cmd.Parameters.AddWithValue("@Cidade", cep.Cidade);

            objConexao.Conectar();
            cmd.ExecuteScalar();

        }

        public void IncluirCepSecundario(CepSecundario cep)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = objConexao.ObjetoConexao;

            /*
            cmd.CommandText = "INSERT INTO [dbo].[P_Cep]([ID_CEP],[CEP],[TIPO_LOGRADOURO],[ENDERECO],[NUMERO],[COMPLEMENTO],[BAIRRO],[CIDADE],[SIGLA_CIDADE])"
            + " VALUES(@IdCep,@Cep,@TipoLogradouro,@Endereco,@Numero,@Complemento,@Bairro,@Cidade,@SiglaCidade);select @@IDENTITY;";
            */
            cmd.CommandText = "exec D_PessoaCepInserir @IdCep,@Cep,@TipoLogradouro,@Endereco,@Numero,@Complemento,@Bairro,@Cidade,@SiglaCidade;select @@IDENTITY;";

            cmd.Parameters.AddWithValue("@IdCep", cep.idCep);
            cmd.Parameters.AddWithValue("@Cep", cep.Cepc);
            cmd.Parameters.AddWithValue("Numero", cep.Numero);

            if (cep.Complemento == "")
            {
                // passa valor nulo para a tabela
                cmd.Parameters.AddWithValue("@Complemento", cep.Complemento).Value = SqlDateTime.Null;
            }
            else
            {
                cmd.Parameters.AddWithValue("@Complemento", cep.Complemento);
            }
            if (cep.TipoLogradouro == "")
            {
                // passa valor nulo para a tabela
                cmd.Parameters.AddWithValue("@TipoLogradouro", cep.TipoLogradouro).Value = SqlDateTime.Null;
            }
            else
            {
                cmd.Parameters.AddWithValue("@TipoLogradouro", cep.TipoLogradouro);
            }
            if (cep.Endereco == "")
            {
                // passa valor nulo para a tabela
                cmd.Parameters.AddWithValue("@Endereco", cep.Endereco).Value = SqlDateTime.Null;
            }
            else
            {
                cmd.Parameters.AddWithValue("@Endereco", cep.Endereco);
            }
            if (cep.Bairro == "")
            {
                // passa valor nulo para a tabela
                cmd.Parameters.AddWithValue("@Bairro", cep.Bairro).Value = SqlDateTime.Null;
            }
            else
            {
                cmd.Parameters.AddWithValue("@Bairro", cep.Bairro);
            }
            if (cep.Cidade == "")
            {
                // passa valor nulo para a tabela
                cmd.Parameters.AddWithValue("@Cidade", cep.Cidade).Value = SqlDateTime.Null;
            }
            else
            {
                cmd.Parameters.AddWithValue("@Cidade", cep.Cidade);
            }
            if (cep.SiglaCidade == "")
            {
                // passa valor nulo para a tabela
                cmd.Parameters.AddWithValue("@SiglaCidade", cep.SiglaCidade).Value = SqlDateTime.Null;
            }
            else
            {
                cmd.Parameters.AddWithValue("@SiglaCidade", cep.SiglaCidade);
            }
            objConexao.Conectar();
            cmd.ExecuteScalar();
        }

        //Alterar Informação de Cadastra Fisica e Juridica------------------------------------------------------------------------------------------------------------------------------------

        public void Alterar(Pessoa cliente)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = objConexao.ObjetoConexao;

            cmd.CommandText = "EXEC D_PessoaUpdate @idPessoa,@Situacao,@Nome,@Telefone,@Telefone2,@FaxTelefone,@TelexTelefone,@Email," +
            "@Observacao,@Tipo,@CpMunicipio,@Municipio,@Pais,@DesPais;";
            cmd.Parameters.AddWithValue("@idPessoa", cliente.idPessoa);
            cmd.Parameters.AddWithValue("@Nome", cliente.Nome);
            cmd.Parameters.AddWithValue("@Telefone", cliente.Telefone);

            if (cliente.Telefone2 == "")
            {
                // passa valor nulo para a tabela
                cmd.Parameters.AddWithValue("@Telefone2", cliente.Telefone2).Value = SqlDateTime.Null;
            }
            else
            {
                cmd.Parameters.AddWithValue("@Telefone2", cliente.Telefone2);
            }
            if (cliente.FaxTelefone == "")
            {
                // passa valor nulo para a tabela
                cmd.Parameters.AddWithValue("@FaxTelefone", cliente.FaxTelefone).Value = SqlDateTime.Null;
            }
            else
            {
                cmd.Parameters.AddWithValue("@FaxTelefone", cliente.FaxTelefone);
            }
            if (cliente.TelexTelefone == "")
            {
                // passa valor nulo para a tabela
                cmd.Parameters.AddWithValue("@TelexTelefone", cliente.TelexTelefone).Value = SqlDateTime.Null;
            }
            else
            {
                cmd.Parameters.AddWithValue("@TelexTelefone", cliente.TelexTelefone);
            }

            cmd.Parameters.AddWithValue("@Situacao", cliente.Situacao);
            cmd.Parameters.AddWithValue("@Email", cliente.Email);

            if (cliente.Observacao == "")
            {
                // passa valor nulo para a tabela
                cmd.Parameters.AddWithValue("@Observacao", cliente.Observacao).Value = SqlDateTime.Null;
            }
            else
            {
                cmd.Parameters.AddWithValue("@Observacao", cliente.Observacao);
            }
            if (cliente.Tipo == "")
            {
                // passa valor nulo para a tabela
                cmd.Parameters.AddWithValue("@Tipo", cliente.Tipo).Value = SqlDateTime.Null;
            }
            else
            {
                cmd.Parameters.AddWithValue("@Tipo", cliente.Tipo);
            }
            if (cliente.CpMunicipio == "")
            {
                // passa valor nulo para a tabela
                cmd.Parameters.AddWithValue("@CpMunicipio", cliente.CpMunicipio).Value = SqlDateTime.Null;
            }
            else
            {
                cmd.Parameters.AddWithValue("@CpMunicipio", cliente.CpMunicipio);
            }
            if (cliente.Municipio == "")
            {
                // passa valor nulo para a tabela
                cmd.Parameters.AddWithValue("@Municipio", cliente.Municipio).Value = SqlDateTime.Null;
            }
            else
            {
                cmd.Parameters.AddWithValue("@Municipio", cliente.Municipio);
            }
            if (cliente.Pais == "")
            {
                // passa valor nulo para a tabela
                cmd.Parameters.AddWithValue("@Pais", cliente.Pais).Value = SqlDateTime.Null;
            }
            else
            {
                cmd.Parameters.AddWithValue("@Pais", cliente.Pais);
            }
            if (cliente.DesPais == "")
            {
                // passa valor nulo para a tabela
                cmd.Parameters.AddWithValue("@DesPais", cliente.DesPais).Value = SqlDateTime.Null;
            }
            else
            {
                cmd.Parameters.AddWithValue("@DesPais", cliente.DesPais);
            }

            objConexao.Conectar();

            cmd.ExecuteNonQuery();

            objConexao.Desconectar();
        }

        public void AlterarClienteFIsica(PessoaFisica Fisica)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = objConexao.ObjetoConexao;

            cmd.CommandText = "EXEC D_PessoaFisicaUpdate @idPessoaFisica,@Celular,@Celular2; ";
            cmd.Parameters.AddWithValue("@idPessoaFisica", Fisica.idPessoaFisica);
            if (Fisica.Celular == "")
            {
                // passa valor nulo para a tabela
                cmd.Parameters.AddWithValue("@Celular", Fisica.Celular).Value = SqlDateTime.Null;
            }
            else
            {
                cmd.Parameters.AddWithValue("@Celular", Fisica.Celular);
            }
            if (Fisica.Celular2 == "")
            {
                // passa valor nulo para a tabela
                cmd.Parameters.AddWithValue("@Celular2", Fisica.Celular2).Value = SqlDateTime.Null;
            }
            else
            {
                cmd.Parameters.AddWithValue("@Celular2", Fisica.Celular2);
            }
            objConexao.Conectar();
            cmd.ExecuteNonQuery();
            objConexao.Desconectar();

        }
        public void AlterarClienteJuridica(PessoaJuridica Juridica)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = objConexao.ObjetoConexao;

            cmd.CommandText = "EXEC D_PessoaJuridicaUpdate @idPessoaJuridica,@NomeContato; ";

            cmd.Parameters.AddWithValue("@idPessoaJuridica", Juridica.idPessoaJuridica);
            cmd.Parameters.AddWithValue("@NomeContato", Juridica.NomeContato);

            objConexao.Conectar();
            cmd.ExecuteNonQuery();
            objConexao.Desconectar();


        }

        //Excluir Informação de Cadastra Fisica e Juridica

        public void ExcluirClienteFisico(int IdCliente)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = objConexao.ObjetoConexao;

            cmd.CommandText = "DELETE FROM [dbo].[P_Cliente] WHERE ID_CLIENTE_PESSOA = @idPessoa;";
            cmd.Parameters.AddWithValue("@idPessoa", IdCliente);

            objConexao.Conectar();
            cmd.ExecuteNonQuery();
            objConexao.Desconectar();

            SqlCommand cmd1 = new SqlCommand();
            cmd1.Connection = objConexao.ObjetoConexao;

            cmd1.CommandText = "DELETE FROM [dbo].[P_Fisica] WHERE ID_PESSOA_FISICA = @idPessoa;";

            cmd1.Parameters.AddWithValue("@idPessoa", IdCliente);

            objConexao.Conectar();
            cmd1.ExecuteNonQuery();
            objConexao.Desconectar();

            SqlCommand cmd2 = new SqlCommand();
            cmd2.Connection = objConexao.ObjetoConexao;

            cmd2.CommandText = "DELETE FROM [dbo].[P_Pessoa] WHERE ID_PESSOA = @idPessoa;";

            cmd2.Parameters.AddWithValue("@idPessoa", IdCliente);

            objConexao.Conectar();
            cmd2.ExecuteNonQuery();
        }
        public void ExcluirClienteJuridica(int Juridica)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = objConexao.ObjetoConexao;

            cmd.CommandText = "DELETE FROM [dbo].[P_Cliente] WHERE ID_CLIENTE_PESSOA = @idPessoa;";
            cmd.Parameters.AddWithValue("@idPessoa", Juridica);

            objConexao.Conectar();
            cmd.ExecuteNonQuery();
            objConexao.Desconectar();

            SqlCommand cmd1 = new SqlCommand();
            cmd1.Connection = objConexao.ObjetoConexao;

            cmd1.CommandText = "DELETE FROM [dbo].[P_Juridica] WHERE ID_PESSOA_JURIDICA = @idPessoa;";

            cmd1.Parameters.AddWithValue("@idPessoa", Juridica);

            objConexao.Conectar();
            cmd1.ExecuteNonQuery();
            objConexao.Desconectar();

            SqlCommand cmd2 = new SqlCommand();
            cmd2.Connection = objConexao.ObjetoConexao;

            cmd2.CommandText = "DELETE FROM [dbo].[P_Pessoa] WHERE ID_PESSOA = @idPessoa;";

            cmd2.Parameters.AddWithValue("@idPessoa", Juridica);

            objConexao.Conectar();
            cmd2.ExecuteNonQuery();
        }
        //----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        //Base de Dados Fornecedor Fisica e Juridica. E tambem Cep
        public void IncluirF(Fornecedor Fornecedor)
        {

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = objConexao.ObjetoConexao;

            cmd.CommandText = "EXEC D_PessoaFornecedorInserir @IdFornecedorPessoa, @NomeContato,@CargoContato ; ";

            cmd.Parameters.AddWithValue("@IdFornecedorPessoa", Fornecedor.idFornecedor);

            if (Fornecedor.NomeContato == "")
            {
                // passa valor nulo para a tabela
                cmd.Parameters.AddWithValue("@NomeContato", Fornecedor.NomeContato).Value = SqlDateTime.Null;
            }
            else
            {
                cmd.Parameters.AddWithValue("@NomeContato", Fornecedor.NomeContato);
            }

            if (Fornecedor.CargoContato == "")
            {
                // passa valor nulo para a tabela
                cmd.Parameters.AddWithValue("@CargoContato", Fornecedor.CargoContato).Value = SqlDateTime.Null;
            }
            else
            {
                cmd.Parameters.AddWithValue("@CargoContato", Fornecedor.CargoContato);
            }

            objConexao.Conectar();

            cmd.ExecuteScalar();
        }

        //public void IncluirPessoaFIsica(FornecedorFisica Fisica)
        //{
        //    SqlCommand cmd = new SqlCommand();
        //    cmd.Connection = objConexao.ObjetoConexao;
        //    //transacao = objConexao.ObjetoConexao.BeginTransaction("SampleTransaction");
        //    /*
        //    cmd.CommandText = "INSERT INTO [dbo].[P_Fisica] (ID_PESSOA_FISICA,ID_PESSOA_TIPO,SEXO,CPF,RG,DATA_NASCIMENTO,CELULAR,CELULAR2) VALUES(@idPessoaFisica,@IdPessoaTipo,@Sexo,@Cpf," +
        //    "@Rg,@dataNacimento,@Celular,@Celular2);select @@IDENTITY;";
        //    */
        //    cmd.CommandText = "EXEC PessoaFisicaInserir @idPessoaFisica,@Nome1,@Sexo,@Cpf,@Rg,@dataNacimento,@Celular,@Celular2;";

        //    cmd.Parameters.AddWithValue("@idPessoaFisica", Fisica.idFornecedorFisica);
        //    //cmd.Parameters.AddWithValue("@IdPessoaTipo", Fisica.IdPessoaTipo);
        //    cmd.Parameters.AddWithValue("@Sexo", Fisica.Sexo);
        //    cmd.Parameters.AddWithValue("@Cpf", Fisica.Cpf);
        //    cmd.Parameters.AddWithValue("@Rg", Fisica.Rg);
        //    cmd.Parameters.AddWithValue("@dataNacimento", Fisica.dataNacimento);
        //    cmd.Parameters.AddWithValue("@Celular", Fisica.Celular);

        //    if (Fisica.Nome == "")
        //    {
        //        // passa valor nulo para a tabela
        //        cmd.Parameters.AddWithValue("@Nome1", Fisica.Nome).Value = SqlDateTime.Null;
        //    }
        //    else
        //    {
        //        cmd.Parameters.AddWithValue("@Nome1", Fisica.Nome);
        //    }

        //    if (Fisica.Celular2 == "")
        //    {
        //        // passa valor nulo para a tabela
        //        cmd.Parameters.AddWithValue("@Celular2", Fisica.Celular2).Value = SqlDateTime.Null;
        //    }
        //    else
        //    {
        //        cmd.Parameters.AddWithValue("@Celular2", Fisica.Celular2);
        //    }

        //    objConexao.Conectar();

        //    cmd.ExecuteScalar();

        //    SqlCommand cmd1 = new SqlCommand();
        //    cmd1.Connection = objConexao.ObjetoConexao;

        //    cmd1.CommandText = "UPDATE [dbo].[P_Pessoa] SET[ID_PESSOA_TIPO] = 1 WHERE ID_PESSOA = @idPessoaFisica; ";
        //    cmd1.Parameters.AddWithValue("@idPessoaFisica", Fisica.idFornecedorFisica);


        //    cmd1.ExecuteScalar();

        //}
        //public void IncluirPessoaJuridica(FornecedorJuridica Juridica)
        //{
        //    SqlCommand cmd = new SqlCommand();
        //    cmd.Connection = objConexao.ObjetoConexao;
        //    //transacao = objConexao.ObjetoConexao.BeginTransaction("SampleTransaction");
        //    cmd.CommandText = "EXEC PessoaJuridicaInserir @idPessoaJuridica,@RazaoSocial,@Cnpj,@NomeContato, @InscricaoStadual;";
        //    cmd.Parameters.AddWithValue("@idPessoaJuridica", Juridica.idFornecedorJuridica);
        //    cmd.Parameters.AddWithValue("@RazaoSocial", Juridica.RazaoSocial);
        //    cmd.Parameters.AddWithValue("@Cnpj", Juridica.Cnpj);
        //    cmd.Parameters.AddWithValue("@NomeContato", Juridica.NomeContato);
        //    cmd.Parameters.AddWithValue("@InscricaoStadual", Juridica.InscricaoStadual);

        //    objConexao.Conectar();

        //    cmd.ExecuteScalar();


        //}

        public void AlterarFornecedorFIsica(FornecedorFisica Fisica)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = objConexao.ObjetoConexao;

            cmd.CommandText = "EXEC D_PessoaFisicaUpdate @idPessoaFisica,@Celular,@Celular2; ";
            cmd.Parameters.AddWithValue("@idPessoaFisica", Fisica.idFornecedorFisica);
            if (Fisica.Celular == "")
            {
                // passa valor nulo para a tabela
                cmd.Parameters.AddWithValue("@Celular", Fisica.Celular).Value = SqlDateTime.Null;
            }
            else
            {
                cmd.Parameters.AddWithValue("@Celular", Fisica.Celular);
            }
            if (Fisica.Celular2 == "")
            {
                // passa valor nulo para a tabela
                cmd.Parameters.AddWithValue("@Celular2", Fisica.Celular2).Value = SqlDateTime.Null;
            }
            else
            {
                cmd.Parameters.AddWithValue("@Celular2", Fisica.Celular2);
            }
            objConexao.Conectar();
            cmd.ExecuteNonQuery();
            objConexao.Desconectar();

        }
        public void AlterarFornecedorJuridica(FornecedorJuridica Juridica)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = objConexao.ObjetoConexao;

            cmd.CommandText = "EXEC D_PessoaJuridicaUpdate @idPessoaJuridica,@NomeContato; ";

            cmd.Parameters.AddWithValue("@idPessoaJuridica", Juridica.idFornecedorJuridica);
            cmd.Parameters.AddWithValue("@NomeContato", Juridica.NomeContato);

            objConexao.Conectar();
            cmd.ExecuteNonQuery();
            objConexao.Desconectar();


        }

        //Alterar Informação de Cadastra Fornecedor Fisica e Juridica------------------------------------------------------------------------------------------------------------------------------------

        public void AlterarF(Fornecedor cliente)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = objConexao.ObjetoConexao;
            cmd.CommandText = "EXEC D_FornecedorUpdate @idPessoa,@NomeContato,@CargoContato " +
            cmd.Parameters.AddWithValue("@idPessoa", cliente.idFornecedor);
            if (cliente.NomeContato == "")
            {
                // passa valor nulo para a tabela
                cmd.Parameters.AddWithValue("@NomeContato", cliente.NomeContato).Value = SqlDateTime.Null;
            }
            else
            {
                cmd.Parameters.AddWithValue("@NomeContato", cliente.NomeContato);
            }
            if (cliente.CargoContato == "")
            {
                // passa valor nulo para a tabela
                cmd.Parameters.AddWithValue("@CargoContato", cliente.CargoContato).Value = SqlDateTime.Null;
            }
            else
            {
                cmd.Parameters.AddWithValue("@CargoContato", cliente.CargoContato);
            }


            objConexao.Conectar();

            cmd.ExecuteNonQuery();

            objConexao.Desconectar();

        }
        public void ExcluirFornecedorFisico(int Fisica)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = objConexao.ObjetoConexao;

            cmd.CommandText = "DELETE FROM [dbo].[P_Cliente] WHERE ID_CLIENTE_PESSOA = @idPessoa;";
            cmd.Parameters.AddWithValue("@idPessoa", Fisica);

            objConexao.Conectar();
            cmd.ExecuteNonQuery();
            objConexao.Desconectar();

            SqlCommand cmd1 = new SqlCommand();
            cmd1.Connection = objConexao.ObjetoConexao;

            cmd1.CommandText = "DELETE FROM [dbo].[P_Fisica] WHERE ID_PESSOA_FISICA = @idPessoa;";

            cmd1.Parameters.AddWithValue("@idPessoa", Fisica);

            objConexao.Conectar();
            cmd1.ExecuteNonQuery();
            objConexao.Desconectar();

            SqlCommand cmd2 = new SqlCommand();
            cmd2.Connection = objConexao.ObjetoConexao;

            cmd2.CommandText = "DELETE FROM [dbo].[P_Pessoa] WHERE ID_PESSOA = @idPessoa;";

            cmd2.Parameters.AddWithValue("@idPessoa", Fisica);

            objConexao.Conectar();
            cmd2.ExecuteNonQuery();
        }
        public void ExcluirFornecedorJuridica(int Juridica)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = objConexao.ObjetoConexao;

            cmd.CommandText = "DELETE FROM [dbo].[P_Cliente] WHERE ID_CLIENTE_PESSOA = @idPessoa;";
            cmd.Parameters.AddWithValue("@idPessoa", Juridica);

            objConexao.Conectar();
            cmd.ExecuteNonQuery();
            objConexao.Desconectar();

            SqlCommand cmd1 = new SqlCommand();
            cmd1.Connection = objConexao.ObjetoConexao;

            cmd1.CommandText = "DELETE FROM [dbo].[P_Juridica] WHERE ID_PESSOA_JURIDICA = @idPessoa;";

            cmd1.Parameters.AddWithValue("@idPessoa", Juridica);

            objConexao.Conectar();
            cmd1.ExecuteNonQuery();
            objConexao.Desconectar();

            SqlCommand cmd2 = new SqlCommand();
            cmd2.Connection = objConexao.ObjetoConexao;

            cmd2.CommandText = "DELETE FROM [dbo].[P_Pessoa] WHERE ID_PESSOA = @idPessoa;";

            cmd2.Parameters.AddWithValue("@idPessoa", Juridica);

            objConexao.Conectar();
            cmd2.ExecuteNonQuery();
        }
        //Base de Dados Funcionario. E tambem Cep---------------------------------------------------------------------------------------------------------------------------
        public void IncluirUsuarioGeral(CadastraUsuario Usuario)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = objConexao.ObjetoConexao;
            cmd.CommandText = "EXEC D_UsuarioGeralInserir @IdSituacao,@Nome,@SobreNome,@Abreviacao,@Telefone,@Telefone2,@Celular,@Celular2,@Email," +
                "@Observacao,@Sexo,@Cpf,@Rg,@Data_Nascimento;select @@IDENTITY;";

            cmd.Parameters.AddWithValue("@IdSituacao", Usuario.IdSituacao);
            cmd.Parameters.AddWithValue("@Nome", Usuario.Nome);
            cmd.Parameters.AddWithValue("@SobreNome", Usuario.SobreNome);
            cmd.Parameters.AddWithValue("@Abreviacao", Usuario.Abreviacao);
            if (Usuario.Telefone == "")
            {
                // passa valor nulo para a tabela
                cmd.Parameters.AddWithValue("@Telefone", Usuario.Telefone).Value = SqlDateTime.Null;
            }
            else
            {
                cmd.Parameters.AddWithValue("@Telefone", Usuario.Telefone);
            }
            if (Usuario.Telefone2 == "")
            {
                // passa valor nulo para a tabela
                cmd.Parameters.AddWithValue("@Telefone2", Usuario.Telefone2).Value = SqlDateTime.Null;
            }
            else
            {
                cmd.Parameters.AddWithValue("@Telefone2", Usuario.Telefone2);
            }
            if (Usuario.Celular == "")
            {
                // passa valor nulo para a tabela
                cmd.Parameters.AddWithValue("@Celular", Usuario.Celular).Value = SqlDateTime.Null;
            }
            else
            {
                cmd.Parameters.AddWithValue("@Celular", Usuario.Celular);
            }
            if (Usuario.Celular2 == "")
            {
                // passa valor nulo para a tabela
                cmd.Parameters.AddWithValue("@Celular2", Usuario.Celular2).Value = SqlDateTime.Null;
            }
            else
            {
                cmd.Parameters.AddWithValue("@Celular2", Usuario.Celular2);
            }
            if (Usuario.Email == "")
            {
                // passa valor nulo para a tabela
                cmd.Parameters.AddWithValue("@Email", Usuario.Email).Value = SqlDateTime.Null;
            }
            else
            {
                cmd.Parameters.AddWithValue("@Email", Usuario.Email);
            }
            if (Usuario.Observacao == "")
            {
                // passa valor nulo para a tabela
                cmd.Parameters.AddWithValue("@Observacao", Usuario.Observacao).Value = SqlDateTime.Null;
            }
            else
            {
                cmd.Parameters.AddWithValue("@Observacao", Usuario.Observacao);
            }
            if (Usuario.Sexo == "")
            {
                // passa valor nulo para a tabela
                cmd.Parameters.AddWithValue("@Sexo", Usuario.Sexo).Value = SqlDateTime.Null;
            }
            else
            {
                cmd.Parameters.AddWithValue("@Sexo", Usuario.Sexo);
            }
            if (Usuario.Cpf == "")
            {
                // passa valor nulo para a tabela
                cmd.Parameters.AddWithValue("@Cpf", Usuario.Cpf).Value = SqlDateTime.Null;
            }
            else
            {
                cmd.Parameters.AddWithValue("@Cpf", Usuario.Cpf);
            }
            if (Usuario.Rg == "")
            {
                // passa valor nulo para a tabela
                cmd.Parameters.AddWithValue("@Rg", Usuario.Rg).Value = SqlDateTime.Null;
            }
            else
            {
                cmd.Parameters.AddWithValue("@Rg", Usuario.Rg);
            }
            if (Usuario.Data_Nascimento == null)
            {
                // passa valor nulo para a tabela
                cmd.Parameters.AddWithValue("@Data_Nascimento", Usuario.Data_Nascimento).Value = SqlDateTime.Null;
            }
            else
            {
                cmd.Parameters.AddWithValue("@Data_Nascimento", Usuario.Data_Nascimento);
            }

            objConexao.Conectar();

            //cmd.ExecuteNonQuery();

            Usuario.IdUsuario = Convert.ToInt32(cmd.ExecuteScalar());

            objConexao.Desconectar();

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
        //Incluir Funcionario Vendedor  ---------------------------------------------------------------------------------------------------------------------------
        public void IncluirFuncionarioVendedor(Vendedor Vendedor)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = objConexao.ObjetoConexao;

            //transacao = objConexao.ObjetoConexao.BeginTransaction("");

            cmd.CommandText = "EXEC D_FuncionarioVendedorInserir @IdVendedor,@Salario,@Comissao,@Tipo,@Abreviacao,@Telefone,@Telefone2,@Celular,@Celular2,@Email,@Descricao," +
                "@Cargo,@DataAdmissao,@DiaPAgamento;";

            cmd.Parameters.AddWithValue("@IdVendedor", Vendedor.IdVendedor);

            if (Vendedor.Salario == 0)//
            {
                // passa valor nulo para a tabela
                cmd.Parameters.AddWithValue("@Salario", Vendedor.Salario).Value = SqlBinary.Null;
            }
            else
            {
                cmd.Parameters.AddWithValue("@Salario", Vendedor.Salario);
            }

            if (Vendedor.Comissao == 0)//
            {
                // passa valor nulo para a tabela
                cmd.Parameters.AddWithValue("@Comissao", Vendedor.Comissao).Value = SqlBinary.Null;
            }
            else
            {
                cmd.Parameters.AddWithValue("@Comissao", Vendedor.Comissao);
            }

            if (Vendedor.Tipo == 0)//
            {
                // passa valor nulo para a tabela
                cmd.Parameters.AddWithValue("@Tipo", Vendedor.Tipo).Value = SqlBinary.Null;
            }
            else
            {
                cmd.Parameters.AddWithValue("@Tipo", Vendedor.Tipo);
            }
            if (Vendedor.Abreviacao == "")
            {
                // passa valor nulo para a tabela
                cmd.Parameters.AddWithValue("@Abreviacao", Vendedor.Abreviacao).Value = SqlDateTime.Null;
            }
            else
            {
                cmd.Parameters.AddWithValue("@Abreviacao", Vendedor.Abreviacao);
            }
            if (Vendedor.Telefone == "")
            {
                // passa valor nulo para a tabela
                cmd.Parameters.AddWithValue("@Telefone", Vendedor.Telefone).Value = SqlDateTime.Null;
            }
            else
            {
                cmd.Parameters.AddWithValue("@Telefone", Vendedor.Telefone);
            }
            if (Vendedor.Telefone2 == "")
            {
                // passa valor nulo para a tabela
                cmd.Parameters.AddWithValue("@Telefone2", Vendedor.Telefone2).Value = SqlDateTime.Null;
            }
            else
            {
                cmd.Parameters.AddWithValue("@Telefone2", Vendedor.Telefone2);
            }
            if (Vendedor.Celular == "")
            {
                // passa valor nulo para a tabela
                cmd.Parameters.AddWithValue("@Celular", Vendedor.Celular).Value = SqlDateTime.Null;
            }
            else
            {
                cmd.Parameters.AddWithValue("@Celular", Vendedor.Celular);
            }
            if (Vendedor.Celular2 == "")
            {
                // passa valor nulo para a tabela
                cmd.Parameters.AddWithValue("@Celular2", Vendedor.Celular2).Value = SqlDateTime.Null;
            }
            else
            {
                cmd.Parameters.AddWithValue("@Celular2", Vendedor.Celular2);
            }
            if (Vendedor.Email == "")
            {
                // passa valor nulo para a tabela
                cmd.Parameters.AddWithValue("@Email", Vendedor.Email).Value = SqlDateTime.Null;
            }
            else
            {
                cmd.Parameters.AddWithValue("@Email", Vendedor.Email);
            }
            if (Vendedor.Observacao == "")
            {
                // passa valor nulo para a tabela
                cmd.Parameters.AddWithValue("@Descricao", Vendedor.Descricao).Value = SqlDateTime.Null;
            }
            else
            {
                cmd.Parameters.AddWithValue("@Descricao", Vendedor.Descricao);
            }
            if (Vendedor.Cargo == "")
            {
                // passa valor nulo para a tabela
                cmd.Parameters.AddWithValue("@Cargo", Vendedor.Cargo).Value = SqlDateTime.Null;
            }
            else
            {
                cmd.Parameters.AddWithValue("@Cargo", Vendedor.Cargo);
            }
            cmd.Parameters.AddWithValue("@DataAdmissao", Vendedor.DataAdmissao);

            if (Vendedor.DiaPAgamento == 0)//
            {
                // passa valor nulo para a tabela
                cmd.Parameters.AddWithValue("@DiaPAgamento", Vendedor.DiaPAgamento).Value = SqlBinary.Null;
            }
            else
            {
                cmd.Parameters.AddWithValue("@DiaPAgamento", Vendedor.DiaPAgamento);
            }

            //cmd.Parameters.AddWithValue("@Tipo", Vendedor.Tipo);

            objConexao.Conectar();
            cmd.ExecuteScalar();
            objConexao.Desconectar();

        }
        public void IncluirUsuarioV(UsuarioV UsuarioVenda)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = objConexao.ObjetoConexao;

            //transacao = objConexao.ObjetoConexao.BeginTransaction("");

            cmd.CommandText = "EXEC D_FuncionarioUsuarioVInserir @ID_UsuarioV,@Abreviacao,@Telefone,@Telefone2,@Celular,@Celular2,@Email;";

            cmd.Parameters.AddWithValue("@ID_UsuarioV", UsuarioVenda.ID_UsuarioV);

            if (UsuarioVenda.Abreviacao == "")
            {
                // passa valor nulo para a tabela
                cmd.Parameters.AddWithValue("@Abreviacao", UsuarioVenda.Abreviacao).Value = SqlDateTime.Null;
            }
            else
            {
                cmd.Parameters.AddWithValue("@Abreviacao", UsuarioVenda.Abreviacao);
            }
            if (UsuarioVenda.Telefone == "")
            {
                // passa valor nulo para a tabela
                cmd.Parameters.AddWithValue("@Telefone", UsuarioVenda.Telefone).Value = SqlDateTime.Null;
            }
            else
            {
                cmd.Parameters.AddWithValue("@Telefone", UsuarioVenda.Telefone);
            }
            if (UsuarioVenda.Telefone2 == "")
            {
                // passa valor nulo para a tabela
                cmd.Parameters.AddWithValue("@Telefone2", UsuarioVenda.Telefone2).Value = SqlDateTime.Null;
            }
            else
            {
                cmd.Parameters.AddWithValue("@Telefone2", UsuarioVenda.Telefone2);
            }
            if (UsuarioVenda.Celular == "")
            {
                // passa valor nulo para a tabela
                cmd.Parameters.AddWithValue("@Celular", UsuarioVenda.Celular).Value = SqlDateTime.Null;
            }
            else
            {
                cmd.Parameters.AddWithValue("@Celular", UsuarioVenda.Celular);
            }
            if (UsuarioVenda.Celular2 == "")
            {
                // passa valor nulo para a tabela
                cmd.Parameters.AddWithValue("@Celular2", UsuarioVenda.Celular2).Value = SqlDateTime.Null;
            }
            else
            {
                cmd.Parameters.AddWithValue("@Celular2", UsuarioVenda.Celular2);
            }
            if (UsuarioVenda.Email == "")
            {
                // passa valor nulo para a tabela
                cmd.Parameters.AddWithValue("@Email", UsuarioVenda.Email).Value = SqlDateTime.Null;
            }
            else
            {
                cmd.Parameters.AddWithValue("@Email", UsuarioVenda.Email);
            }

            objConexao.Conectar();
            cmd.ExecuteScalar();
            objConexao.Desconectar();

        }
        //Base de Dados Funcionario Contratos. ---------------------------------------------------------------------------------------------------------------------------
        public void IncluirFuncionarioRegistro(FuncionarioRegistro FuncionarioRegistro)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = objConexao.ObjetoConexao;

            cmd.CommandText = "EXEC D_FuncionarioRegistroInserir @IdFuncionario,@IdRe,@Abreviacao,@Telefone,@Telefone2,@Celular,@Celular2,@Email;";
            cmd.Parameters.AddWithValue("@IdFuncionario", FuncionarioRegistro.IdFuncionario);
            cmd.Parameters.AddWithValue("@IdRe", FuncionarioRegistro.IdRe);
            if (FuncionarioRegistro.Abreviacao == "")
            {
                // passa valor nulo para a tabela
                cmd.Parameters.AddWithValue("@Abreviacao", FuncionarioRegistro.Abreviacao).Value = SqlDateTime.Null;
            }
            else
            {
                cmd.Parameters.AddWithValue("@Abreviacao", FuncionarioRegistro.Abreviacao);
            }
            if (FuncionarioRegistro.Telefone == "")
            {
                // passa valor nulo para a tabela
                cmd.Parameters.AddWithValue("@Telefone", FuncionarioRegistro.Telefone).Value = SqlDateTime.Null;
            }
            else
            {
                cmd.Parameters.AddWithValue("@Telefone", FuncionarioRegistro.Telefone);
            }
            if (FuncionarioRegistro.Telefone2 == "")
            {
                // passa valor nulo para a tabela
                cmd.Parameters.AddWithValue("@Telefone2", FuncionarioRegistro.Telefone2).Value = SqlDateTime.Null;
            }
            else
            {
                cmd.Parameters.AddWithValue("@Telefone2", FuncionarioRegistro.Telefone2);
            }
            if (FuncionarioRegistro.Celular == "")
            {
                // passa valor nulo para a tabela
                cmd.Parameters.AddWithValue("@Celular", FuncionarioRegistro.Celular).Value = SqlDateTime.Null;
            }
            else
            {
                cmd.Parameters.AddWithValue("@Celular", FuncionarioRegistro.Celular);
            }
            if (FuncionarioRegistro.Celular2 == "")
            {
                // passa valor nulo para a tabela
                cmd.Parameters.AddWithValue("@Celular2", FuncionarioRegistro.Celular2).Value = SqlDateTime.Null;
            }
            else
            {
                cmd.Parameters.AddWithValue("@Celular2", FuncionarioRegistro.Celular2);
            }
            if (FuncionarioRegistro.Email == "")
            {
                // passa valor nulo para a tabela
                cmd.Parameters.AddWithValue("@Email", FuncionarioRegistro.Email).Value = SqlDateTime.Null;
            }
            else
            {
                cmd.Parameters.AddWithValue("@Email", FuncionarioRegistro.Email);
            }
            objConexao.Conectar();
            cmd.ExecuteScalar();
            objConexao.Desconectar();
        }
        //Ceu do usuario em geral Se ele precisa
        public void UsuarioGeralCepInserir(CepCadastraUsuario cep)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = objConexao.ObjetoConexao;

            cmd.CommandText = "exec D_UsuarioGeralCepInserir @IdCep,@Cep,@TipoLogradouro,@Endereco,@Numero,@Complemento,@Bairro,@Cidade,@SiglaCidade;";

            cmd.Parameters.AddWithValue("@IdCep", cep.idCep);
            cmd.Parameters.AddWithValue("@Cep", cep.Cepc);
            cmd.Parameters.AddWithValue("@TipoLogradouro", cep.TipoLogradouro);
            cmd.Parameters.AddWithValue("@Endereco", cep.Endereco);
            cmd.Parameters.AddWithValue("Numero", cep.Numero);

            if (cep.Complemento == "")
            {
                // passa valor nulo para a tabela
                cmd.Parameters.AddWithValue("@Complemento", cep.Complemento).Value = SqlDateTime.Null;
            }
            else
            {
                cmd.Parameters.AddWithValue("@Complemento", cep.Complemento);
            }
            if (cep.Bairro == "")
            {
                // passa valor nulo para a tabela
                cmd.Parameters.AddWithValue("@Bairro", cep.Bairro).Value = SqlDateTime.Null;
            }
            else
            {
                cmd.Parameters.AddWithValue("@Bairro", cep.Bairro);
            }
            if (cep.Cidade == "")
            {
                // passa valor nulo para a tabela
                cmd.Parameters.AddWithValue("@Cidade", cep.Cidade).Value = SqlDateTime.Null;
            }
            else
            {
                cmd.Parameters.AddWithValue("@Cidade", cep.Cidade);
            }
            if (cep.SiglaCidade == "")
            {
                // passa valor nulo para a tabela
                cmd.Parameters.AddWithValue("@SiglaCidade", cep.SiglaCidade).Value = SqlDateTime.Null;
            }
            else
            {
                cmd.Parameters.AddWithValue("@SiglaCidade", cep.SiglaCidade);
            }

            objConexao.Conectar();
            cmd.ExecuteScalar();
            objConexao.Desconectar();
        }

        //Altera informação de Funcionario-----------------------------------------------------------------------------------------------------------------------------------
        //public void AlterarFuncionario(Funcionario cliente)
        //{
        //    SqlCommand cmd = new SqlCommand();
        //    cmd.Connection = objConexao.ObjetoConexao;

        //    cmd.CommandText = "EXEC D_FuncionarioUpdate @idPessoa,@Situacao,@Nome,@Abreviacao,@Telefone,@Telefone2,@Celular,@Celular2,@Email,@Observacao;";
        //    cmd.Parameters.AddWithValue("@idPessoa", cliente.IdFuncionario);
        //    cmd.Parameters.AddWithValue("@Nome", cliente.Nome);
        //    cmd.Parameters.AddWithValue("@Abreviacao", cliente.Abreviacao);
        //    cmd.Parameters.AddWithValue("@Telefone", cliente.Telefone);
        //    cmd.Parameters.AddWithValue("@Situacao", cliente.Situacao);

        //    if (cliente.Telefone2 == "")
        //    {
        //        // passa valor nulo para a tabela
        //        cmd.Parameters.AddWithValue("@Telefone2", cliente.Telefone2).Value = SqlDateTime.Null;
        //    }
        //    else
        //    {
        //        cmd.Parameters.AddWithValue("@Telefone2", cliente.Telefone2);
        //    }
        //    if (cliente.Celular == "")
        //    {
        //        // passa valor nulo para a tabela
        //        cmd.Parameters.AddWithValue("@Celular", cliente.Celular).Value = SqlDateTime.Null;
        //    }
        //    else
        //    {
        //        cmd.Parameters.AddWithValue("@Celular", cliente.Celular);
        //    }
        //    if (cliente.Celular2 == "")
        //    {
        //        // passa valor nulo para a tabela
        //        cmd.Parameters.AddWithValue("@Celular2", cliente.Celular2).Value = SqlDateTime.Null;
        //    }
        //    else
        //    {
        //        cmd.Parameters.AddWithValue("@Celular2", cliente.Celular2);
        //    }
        //    if (cliente.Email == "")
        //    {
        //        // passa valor nulo para a tabela
        //        cmd.Parameters.AddWithValue("@Email", cliente.Email).Value = SqlDateTime.Null;
        //    }
        //    else
        //    {
        //        cmd.Parameters.AddWithValue("@Email", cliente.Email);
        //    }
        //    if (cliente.Observacao == "")
        //    {
        //        // passa valor nulo para a tabela
        //        cmd.Parameters.AddWithValue("@Observacao", cliente.Observacao).Value = SqlDateTime.Null;
        //    }
        //    else
        //    {
        //        cmd.Parameters.AddWithValue("@Observacao", cliente.Observacao);
        //    }

        //    objConexao.Conectar();

        //    cmd.ExecuteNonQuery();

        //    objConexao.Desconectar();
        //}
        public void AlteraCepFuncionario(CepFEcs cep)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = objConexao.ObjetoConexao;

            /*
            cmd.CommandText = "INSERT INTO [dbo].[P_Cep]([ID_CEP],[CEP],[TIPO_LOGRADOURO],[ENDERECO],[NUMERO],[COMPLEMENTO],[BAIRRO],[CIDADE],[SIGLA_CIDADE])"
            + " VALUES(@IdCep,@Cep,@TipoLogradouro,@Endereco,@Numero,@Complemento,@Bairro,@Cidade,@SiglaCidade);select @@IDENTITY;";
            */
            cmd.CommandText = "exec D_FuncionarioCepUpdate @IdCep,@Complemento";

            cmd.Parameters.AddWithValue("@IdCep", cep.idCep);
            if (cep.Complemento == "")
            {
                // passa valor nulo para a tabela
                cmd.Parameters.AddWithValue("@Complemento", cep.Complemento).Value = SqlDateTime.Null;
            }
            else
            {
                cmd.Parameters.AddWithValue("@Complemento", cep.Complemento);
            }

            objConexao.Conectar();
            cmd.ExecuteScalar();
        }


        //Excluir informação de Funcionario---------------------------------------------------------------------------------------------------------------------------------
        public void ExcluirFuncionario(int funcionario)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = objConexao.ObjetoConexao;

            cmd.CommandText = "DELETE FROM [dbo].[G_Cep] WHERE ID_CEP_PESSOA = @idPessoa;";
            cmd.Parameters.AddWithValue("@idPessoa", funcionario);

            objConexao.Conectar();
            cmd.ExecuteNonQuery();
            objConexao.Desconectar();

            SqlCommand cmd1 = new SqlCommand();
            cmd1.Connection = objConexao.ObjetoConexao;

            cmd.CommandText = "DELETE FROM [dbo].[G_Funcionario] WHERE ID_FUNCIONARIO = @idPessoa;";
            cmd.Parameters.AddWithValue("@idPessoa", funcionario);

            objConexao.Conectar();
            cmd1.ExecuteNonQuery();
            objConexao.Desconectar();

        }



        //Fornecedores Clientes Contatos
        //Base de Dados Funcionario. E tambem Cep---------------------------------------------------------------------------------------------------------------------------
        public void IncluirFContatos(FornecedorContatos cliente)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = objConexao.ObjetoConexao;

            //transacao = objConexao.ObjetoConexao.BeginTransaction("");


            cmd.CommandText = "EXEC D_PessoaContatosInserir @idPessoa,@Situacao,@Nome,@Abreviacao, @Telefone,@Telefone2, @Celular,@Celular2,@Email,@Observacao;";



            cmd.Parameters.AddWithValue("@idPessoa", cliente.IdFornecedor);
            cmd.Parameters.AddWithValue("@Situacao", cliente.Situacao);
            cmd.Parameters.AddWithValue("@Nome", cliente.Nome);
            cmd.Parameters.AddWithValue("@Abreviacao", cliente.Abreviacao);
            cmd.Parameters.AddWithValue("@Telefone", cliente.Telefone);

            if (cliente.Telefone2 == "")
            {
                // passa valor nulo para a tabela
                cmd.Parameters.AddWithValue("@Telefone2", cliente.Telefone2).Value = SqlDateTime.Null;
            }
            else
            {
                cmd.Parameters.AddWithValue("@Telefone2", cliente.Telefone2);
            }
            if (cliente.Celular == "")
            {
                // passa valor nulo para a tabela
                cmd.Parameters.AddWithValue("@Celular", cliente.Celular).Value = SqlDateTime.Null;
            }
            else
            {
                cmd.Parameters.AddWithValue("@Celular", cliente.Celular);
            }
            if (cliente.Celular2 == "")
            {
                // passa valor nulo para a tabela
                cmd.Parameters.AddWithValue("@Celular2", cliente.Celular2).Value = SqlDateTime.Null;
            }
            else
            {
                cmd.Parameters.AddWithValue("@Celular2", cliente.Celular2);
            }

            cmd.Parameters.AddWithValue("@Email", cliente.Email);

            if (cliente.Observacao == "")
            {
                // passa valor nulo para a tabela
                cmd.Parameters.AddWithValue("@Observacao", cliente.Observacao).Value = SqlDateTime.Null;
            }
            else
            {
                cmd.Parameters.AddWithValue("@Observacao", cliente.Observacao);
            }

            objConexao.Conectar();

            cliente.IdContatof = Convert.ToInt32(cmd.ExecuteScalar());
        }



        //Altera informação de Funcionario Contatos-------------------------------------------------------------------------------------------------------------------------
        public void AlterarFContatos(FornecedorContatos cliente)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = objConexao.ObjetoConexao;

            cmd.CommandText = "EXEC D_PessoaContatosUpdate @idPessoa,@Situacao,@Nome,@Abreviacao,@Telefone,@Telefone2,@Celular,@Celular,@Email,@Observacao; ";

            cmd.Parameters.AddWithValue("@idPessoa", cliente.IdContatof);
            cmd.Parameters.AddWithValue("@Situacao", cliente.Situacao);
            cmd.Parameters.AddWithValue("@Nome", cliente.Nome);
            cmd.Parameters.AddWithValue("@Abreviacao", cliente.Abreviacao);
            cmd.Parameters.AddWithValue("@Telefone", cliente.Telefone);

            if (cliente.Telefone2 == "")
            {
                // passa valor nulo para a tabela
                cmd.Parameters.AddWithValue("@Telefone2", cliente.Telefone2).Value = SqlDateTime.Null;
            }
            else
            {
                cmd.Parameters.AddWithValue("@Telefone2", cliente.Telefone2);
            }
            if (cliente.Celular == "")
            {
                // passa valor nulo para a tabela
                cmd.Parameters.AddWithValue("@Celular", cliente.Celular).Value = SqlDateTime.Null;
            }
            else
            {
                cmd.Parameters.AddWithValue("@Celular", cliente.Celular);
            }
            if (cliente.Celular2 == "")
            {
                // passa valor nulo para a tabela
                cmd.Parameters.AddWithValue("@Celular2", cliente.Celular2).Value = SqlDateTime.Null;
            }
            else
            {
                cmd.Parameters.AddWithValue("@Celular2", cliente.Celular2);
            }
            if (cliente.Email == "")
            {
                // passa valor nulo para a tabela
                cmd.Parameters.AddWithValue("@Email", cliente.Email).Value = SqlDateTime.Null;
            }
            else
            {
                cmd.Parameters.AddWithValue("@Email", cliente.Email);
            }
            if (cliente.Observacao == "")
            {
                // passa valor nulo para a tabela
                cmd.Parameters.AddWithValue("@Observacao", cliente.Observacao).Value = SqlDateTime.Null;
            }
            else
            {
                cmd.Parameters.AddWithValue("@Observacao", cliente.Observacao);
            }

            objConexao.Conectar();

            cmd.ExecuteNonQuery();

            objConexao.Desconectar();
        }
        //Excluir informação de Funcionario---------------------------------------------------------------------------------------------------------------------------------
        public void ExcluirFcontatos(int funcionario)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = objConexao.ObjetoConexao;

            cmd.CommandText = "DELETE FROM [dbo].[P_Contatos] WHERE ID_PESSOA_CONTATO = @idPessoa;";
            cmd.Parameters.AddWithValue("@idPessoa", funcionario);

            objConexao.Conectar();
            cmd.ExecuteNonQuery();
            objConexao.Desconectar();

        }

        //Clientes Contatos
        //Base de Dados Funcionario. E tambem Cep---------------------------------------------------------------------------------------------------------------------------
        public void IncluirCContatos(ClientesContatos cliente)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = objConexao.ObjetoConexao;

            //transacao = objConexao.ObjetoConexao.BeginTransaction("");

            cmd.CommandText = "EXEC D_PessoaContatosInserir @idPessoa,@Situacao,@Nome,@Abreviacao, @Telefone,@Telefone2, @Celular,@Celular2,@Email,@Observacao;";

            cmd.Parameters.AddWithValue("@idPessoa", cliente.IdContatof);
            cmd.Parameters.AddWithValue("@Situacao", cliente.Situacao);
            cmd.Parameters.AddWithValue("@Nome", cliente.Nome);
            cmd.Parameters.AddWithValue("@Abreviacao", cliente.Abreviacao);
            cmd.Parameters.AddWithValue("@Telefone", cliente.Telefone);

            if (cliente.Telefone2 == "")
            {
                // passa valor nulo para a tabela
                cmd.Parameters.AddWithValue("@Telefone2", cliente.Telefone2).Value = SqlDateTime.Null;
            }
            else
            {
                cmd.Parameters.AddWithValue("@Telefone2", cliente.Telefone2);
            }
            if (cliente.Celular == "")
            {
                // passa valor nulo para a tabela
                cmd.Parameters.AddWithValue("@Celular", cliente.Celular).Value = SqlDateTime.Null;
            }
            else
            {
                cmd.Parameters.AddWithValue("@Celular", cliente.Celular);
            }
            if (cliente.Celular2 == "")
            {
                // passa valor nulo para a tabela
                cmd.Parameters.AddWithValue("@Celular2", cliente.Celular2).Value = SqlDateTime.Null;
            }
            else
            {
                cmd.Parameters.AddWithValue("@Celular2", cliente.Celular2);
            }
            if (cliente.Email == "")
            {
                // passa valor nulo para a tabela
                cmd.Parameters.AddWithValue("@Email", cliente.Email).Value = SqlDateTime.Null;
            }
            else
            {
                cmd.Parameters.AddWithValue("@Email", cliente.Email);
            }

            if (cliente.Observacao == "")
            {
                // passa valor nulo para a tabela
                cmd.Parameters.AddWithValue("@Observacao", cliente.Observacao).Value = SqlDateTime.Null;
            }
            else
            {
                cmd.Parameters.AddWithValue("@Observacao", cliente.Observacao);
            }


            objConexao.Conectar();

            cliente.IdFornecedor = Convert.ToInt32(cmd.ExecuteScalar());// numero da id Gerada Pelo sistema auto incrementa

            //cliente.IdContatof = Convert.ToInt32(cmd.ExecuteScalar());
        }



        //Altera informação de Funcionario Contatos-------------------------------------------------------------------------------------------------------------------------
        public void AlterarCContatos(ClientesContatos cliente)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = objConexao.ObjetoConexao;

            cmd.CommandText = "EXEC D_PessoaContatosUpdate @idPessoa,@Situacao,@Nome,@Abreviacao,@Telefone,@Telefone2,@Celular,@Celular2,@Email,@Observacao;";

            cmd.Parameters.AddWithValue("@idPessoa", cliente.IdContatof);
            cmd.Parameters.AddWithValue("@Situacao", cliente.Situacao);
            cmd.Parameters.AddWithValue("@Nome", cliente.Nome);
            cmd.Parameters.AddWithValue("@Abreviacao", cliente.Abreviacao);
            cmd.Parameters.AddWithValue("@Telefone", cliente.Telefone);

            if (cliente.Telefone2 == "")
            {
                // passa valor nulo para a tabela
                cmd.Parameters.AddWithValue("@Telefone2", cliente.Telefone2).Value = SqlDateTime.Null;
            }
            else
            {
                cmd.Parameters.AddWithValue("@Telefone2", cliente.Telefone2);
            }
            if (cliente.Celular == "")
            {
                // passa valor nulo para a tabela
                cmd.Parameters.AddWithValue("@Celular", cliente.Celular).Value = SqlDateTime.Null;
            }
            else
            {
                cmd.Parameters.AddWithValue("@Celular", cliente.Celular);
            }
            if (cliente.Celular2 == "")
            {
                // passa valor nulo para a tabela
                cmd.Parameters.AddWithValue("@Celular2", cliente.Celular2).Value = SqlDateTime.Null;
            }
            else
            {
                cmd.Parameters.AddWithValue("@Celular2", cliente.Celular2);
            }
            if (cliente.Email == "")
            {
                // passa valor nulo para a tabela
                cmd.Parameters.AddWithValue("@Email", cliente.Email).Value = SqlDateTime.Null;
            }
            else
            {
                cmd.Parameters.AddWithValue("@Email", cliente.Email);
            }
            if (cliente.Observacao == "")
            {
                // passa valor nulo para a tabela
                cmd.Parameters.AddWithValue("@Observacao", cliente.Observacao).Value = SqlDateTime.Null;
            }
            else
            {
                cmd.Parameters.AddWithValue("@Observacao", cliente.Observacao);
            }

            objConexao.Conectar();

            cmd.ExecuteNonQuery();

            objConexao.Desconectar();
        }
        //Excluir informação de Funcionario---------------------------------------------------------------------------------------------------------------------------------
        public void ExcluirCcontatos(int funcionario)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = objConexao.ObjetoConexao;

            cmd.CommandText = "DELETE FROM [dbo].[P_Contatos] WHERE ID_PESSOA_CONTATO = @idPessoa;";
            cmd.Parameters.AddWithValue("@idPessoa", funcionario);

            objConexao.Conectar();
            cmd.ExecuteNonQuery();
            objConexao.Desconectar();

        }



        //Clientes OS
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

        //Criacao de login dos usuarios

        public void IncluirLoginUsuario(CadastroLoginNovo Usuario)
        {

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = objConexao.ObjetoConexao;

            cmd.CommandText = "EXEC D_LoginUsuarioInserir @IdCadastroLoginNovo, @Usuario, @Senha, @ConfirmaSenha, @UsuarioAcesso, @IdAcessoBaseDados," +
                "@CriarDadosPessoas, @CriarFuncionarioOs, @CriarFuncionarioVendas, @CriarUsuarioAcesso," +
                "@UsuarioCriar, @UsuarioAlterar, @UsuarioExcluir, @UsuarioPesquisa, @UsuarioVisualizar," +
                "@ClienteCadastra, @ClientePesquisa, @ClienteVisualizar, @ClienteEditar, @ClienteExcluir," +
                "@ClienteCCadastra, @ClienteCPesquisa, @ClienteCVisualizar, @ClienteCEditar, @ClienteCExcluir," +
                "@FornecedorCadastra, @FornecedorPesquisa, @FornecedorVisualizar, @FornecedorEditar, @FornecedorExcluir," +
                "@FornecedorCCadastra, @FornecedorCPesquisa, @FornecedorCVisualizar, @FornecedorCEditar, @FornecedorcExcluir," +
                "@FuncionarioCadastra, @FuncionarioPesquisa, @FuncionarioVisualizar, @FuncionarioEditar, @FuncionarioExcluir," +
                "@OsCadastra, @OsPesquisa, @OsVisualizar, @OsEditar, @OsExcluir," +
                "@SeniorSapiensAcesso, @SeniorSapiensPesquisa, @SeniorSapiensExcluir," +
                "@PermissaoBasedados, @PermissaoNivelaAcesso, @PermissaoCliente, @PermissaoFornecedor, @PermissaoFuncionarioOs, @PermissaoFuncionarioVendedor," +
                "@PermissaoUsuarioAcesso, @PermissaoOs, @PermissaoSeniorSapiens," +
                "@VendedorCadastra, @VendedorPesquisa, @VendedorVisualizar, @VendedorEditar, @VendedorExcluir, " +
                "@ProdutosCadastra, @ProdutosVisualizar, @ProdutosPesquisa, @ProdutosEditar, @ProdutosExcluir," +
                "@RegistroCCadastra, @RegistroCVisualizar, @RegistroCPesquisa, @RegistroCEditar, @RegistroCExcluir, " +
                "@CriarFuncionarioProdutos, @CriarFuncionarioRegistro, @PermissaoRegistro, @PermissaoFuncionarioProdutos," +
                "@RegistroCCCadastra, @RegistroCCVisualizar, @RegistroCCPesquisa, @RegistroCCEditar,@RegistroCCExcluir," +
                "@RegistroCadastra, @RegistroVisualizar, @RegistroPesquisa, @RegistroEditar, @RegistroExcluir," +
                "@PropostaCadastra, @PropostaVisualizar, @PropostaPesquisa, @PropostaEditar, @PropostaExcluir," +
                "@CriarProposta, @PermissaoProposta;";

            cmd.Parameters.AddWithValue("@IdCadastroLoginNovo", Usuario.IdCadastroLoginNovo);//
            cmd.Parameters.AddWithValue("@Usuario", Usuario.Usuario);//
            cmd.Parameters.AddWithValue("@Senha", Usuario.Senha);//
            cmd.Parameters.AddWithValue("@ConfirmaSenha", Usuario.ConfirmaSenha);//
            cmd.Parameters.AddWithValue("@UsuarioAcesso", Usuario.UsuarioAcesso);//
            cmd.Parameters.AddWithValue("@IdAcessoBaseDados", Usuario.IdAcessoBaseDados);//

            cmd.Parameters.AddWithValue("@CriarDadosPessoas", Usuario.CriarDadosPessoas);
            cmd.Parameters.AddWithValue("@CriarFuncionarioOs", Usuario.CriarFuncionarioOs);
            cmd.Parameters.AddWithValue("@CriarFuncionarioVendas", Usuario.CriarFuncionarioVendas);
            cmd.Parameters.AddWithValue("@CriarUsuarioAcesso", Usuario.CriarUsuarioAcesso);

            cmd.Parameters.AddWithValue("@UsuarioCriar", Usuario.UsuarioCriar);
            cmd.Parameters.AddWithValue("@UsuarioAlterar", Usuario.UsuarioAlterar);
            cmd.Parameters.AddWithValue("@UsuarioExcluir", Usuario.UsuarioExcluir);
            cmd.Parameters.AddWithValue("@UsuarioPesquisa", Usuario.UsuarioPesquisa);
            cmd.Parameters.AddWithValue("@UsuarioVisualizar", Usuario.UsuarioVisualizar);

            cmd.Parameters.AddWithValue("@ClienteCadastra", Usuario.ClienteCadastra);
            cmd.Parameters.AddWithValue("@ClientePesquisa", Usuario.ClientePesquisa);
            cmd.Parameters.AddWithValue("@ClienteVisualizar", Usuario.ClienteVisualizar);
            cmd.Parameters.AddWithValue("@ClienteEditar", Usuario.ClienteEditar);
            cmd.Parameters.AddWithValue("@ClienteExcluir", Usuario.ClienteExcluir);

            cmd.Parameters.AddWithValue("@ClienteCCadastra", Usuario.ClienteCCadastra);
            cmd.Parameters.AddWithValue("@ClienteCPesquisa", Usuario.ClienteCPesquisa);
            cmd.Parameters.AddWithValue("@ClienteCVisualizar", Usuario.ClienteCVisualizar);
            cmd.Parameters.AddWithValue("@ClienteCEditar", Usuario.ClienteCEditar);
            cmd.Parameters.AddWithValue("@ClienteCExcluir", Usuario.ClienteCExcluir);

            cmd.Parameters.AddWithValue("@FornecedorCadastra", Usuario.FornecedorCadastra);
            cmd.Parameters.AddWithValue("@FornecedorPesquisa", Usuario.FornecedorPesquisa);
            cmd.Parameters.AddWithValue("@FornecedorVisualizar", Usuario.FornecedorVisualizar);
            cmd.Parameters.AddWithValue("@FornecedorEditar", Usuario.FornecedorEditar);
            cmd.Parameters.AddWithValue("@FornecedorExcluir", Usuario.FornecedorExcluir);

            cmd.Parameters.AddWithValue("@FornecedorCCadastra", Usuario.FornecedorCCadastra);
            cmd.Parameters.AddWithValue("@FornecedorCPesquisa", Usuario.FornecedorCPesquisa);
            cmd.Parameters.AddWithValue("@FornecedorCVisualizar", Usuario.FornecedorCVisualizar);
            cmd.Parameters.AddWithValue("@FornecedorCEditar", Usuario.FornecedorCEditar);
            cmd.Parameters.AddWithValue("@FornecedorcExcluir", Usuario.FornecedorcExcluir);
            //
            cmd.Parameters.AddWithValue("@FuncionarioCadastra", Usuario.FuncionarioCadastra);//NÃO USANDO
            cmd.Parameters.AddWithValue("@FuncionarioPesquisa", Usuario.FuncionarioPesquisa);//NÃO USANDO
            cmd.Parameters.AddWithValue("@FuncionarioVisualizar", Usuario.FuncionarioVisualizar);//NÃO USANDO
            cmd.Parameters.AddWithValue("@FuncionarioEditar", Usuario.FuncionarioEditar);//NÃO USANDO
            cmd.Parameters.AddWithValue("@FuncionarioExcluir", Usuario.FuncionarioExcluir);//NÃO USANDO

            cmd.Parameters.AddWithValue("@OsCadastra", Usuario.OsCadastra);
            cmd.Parameters.AddWithValue("@OsPesquisa", Usuario.OsPesquisa);
            cmd.Parameters.AddWithValue("@OsVisualizar", Usuario.OsVisualizar);
            cmd.Parameters.AddWithValue("@OsEditar", Usuario.OsEditar);
            cmd.Parameters.AddWithValue("@OsExcluir", Usuario.OsExcluir);

            cmd.Parameters.AddWithValue("@SeniorSapiensAcesso", Usuario.SeniorSapiensAcesso);
            cmd.Parameters.AddWithValue("@SeniorSapiensPesquisa", Usuario.SeniorSapiensPesquisa);
            cmd.Parameters.AddWithValue("@SeniorSapiensExcluir", Usuario.SeniorSapiensExcluir);

            cmd.Parameters.AddWithValue("@PermissaoBasedados", Usuario.PermissaoBasedados);
            cmd.Parameters.AddWithValue("@PermissaoNivelaAcesso", Usuario.PermissaoNivelaAcesso);
            cmd.Parameters.AddWithValue("@PermissaoCliente", Usuario.PermissaoCliente);
            cmd.Parameters.AddWithValue("@PermissaoFornecedor", Usuario.PermissaoFornecedor);
            cmd.Parameters.AddWithValue("@PermissaoFuncionarioOs", Usuario.PermissaoFuncionarioOs);
            cmd.Parameters.AddWithValue("@PermissaoFuncionarioVendedor", Usuario.PermissaoFuncionarioVendedor);

            cmd.Parameters.AddWithValue("@PermissaoUsuarioAcesso", Usuario.PermissaoUsuarioAcesso);
            cmd.Parameters.AddWithValue("@PermissaoOs", Usuario.PermissaoOs);/////
            cmd.Parameters.AddWithValue("@PermissaoSeniorSapiens", Usuario.PermissaoSeniorSapiens);

            cmd.Parameters.AddWithValue("@VendedorCadastra", Usuario.VendedorCadastra);
            cmd.Parameters.AddWithValue("@VendedorPesquisa", Usuario.VendedorPesquisa);
            cmd.Parameters.AddWithValue("@VendedorVisualizar", Usuario.VendedorVisualizar);
            cmd.Parameters.AddWithValue("@VendedorEditar", Usuario.VendedorEditar);
            cmd.Parameters.AddWithValue("@VendedorExcluir", Usuario.VendedorExcluir);

            cmd.Parameters.AddWithValue("@ProdutosCadastra", Usuario.ProdutosCadastra);
            cmd.Parameters.AddWithValue("@ProdutosVisualizar", Usuario.ProdutosVisualizar);
            cmd.Parameters.AddWithValue("@ProdutosPesquisa", Usuario.ProdutosPesquisa);
            cmd.Parameters.AddWithValue("@ProdutosEditar", Usuario.ProdutosEditar);
            cmd.Parameters.AddWithValue("@ProdutosExcluir", Usuario.ProdutosExcluir);

            cmd.Parameters.AddWithValue("@RegistroCCadastra", Usuario.RegistroCCadastra);
            cmd.Parameters.AddWithValue("@RegistroCVisualizar", Usuario.RegistroCVisualizar);
            cmd.Parameters.AddWithValue("@RegistroCPesquisa", Usuario.RegistroCPesquisa);
            cmd.Parameters.AddWithValue("@RegistroCEditar", Usuario.RegistroCEditar);
            cmd.Parameters.AddWithValue("@RegistroCExcluir", Usuario.RegistroCExcluir);

            cmd.Parameters.AddWithValue("@CriarFuncionarioProdutos", Usuario.CriarFuncionarioProdutos);//CRIARCCC     
            cmd.Parameters.AddWithValue("@CriarFuncionarioRegistro", Usuario.CriarFuncionarioRegistro);//CRIARCCC
            cmd.Parameters.AddWithValue("@PermissaoRegistro", Usuario.PermissaoRegistro);//CRIARCCCC
            cmd.Parameters.AddWithValue("@PermissaoFuncionarioProdutos", Usuario.PermissaoFuncionarioProdutos);

            cmd.Parameters.AddWithValue("@RegistroCCCadastra", Usuario.RegistroCCCadastra);
            cmd.Parameters.AddWithValue("@RegistroCCVisualizar", Usuario.RegistroCCVisualizar);
            cmd.Parameters.AddWithValue("@RegistroCCPesquisa", Usuario.RegistroCCPesquisa);
            cmd.Parameters.AddWithValue("@RegistroCCEditar", Usuario.RegistroCCEditar);
            cmd.Parameters.AddWithValue("@RegistroCCExcluir", Usuario.RegistroCCExcluir);

            cmd.Parameters.AddWithValue("@RegistroCadastra", Usuario.RegistroCadastra);
            cmd.Parameters.AddWithValue("@RegistroVisualizar", Usuario.RegistroVisualizar);
            cmd.Parameters.AddWithValue("@RegistroPesquisa", Usuario.RegistroPesquisa);
            cmd.Parameters.AddWithValue("@RegistroEditar", Usuario.RegistroEditar);
            cmd.Parameters.AddWithValue("@RegistroExcluir", Usuario.RegistroExcluir);

            cmd.Parameters.AddWithValue("@PropostaCadastra", Usuario.PropostaCadastra);
            cmd.Parameters.AddWithValue("@PropostaVisualizar", Usuario.PropostaVisualizar);
            cmd.Parameters.AddWithValue("@PropostaPesquisa", Usuario.PropostaPesquisa);
            cmd.Parameters.AddWithValue("@PropostaEditar", Usuario.PropostaEditar);
            cmd.Parameters.AddWithValue("@PropostaExcluir", Usuario.PropostaExcluir);
            cmd.Parameters.AddWithValue("@CriarProposta", Usuario.CriarProposta);
            cmd.Parameters.AddWithValue("@PermissaoProposta", Usuario.PermissaoProposta);

            objConexao.Conectar();
            cmd.ExecuteScalar();
            objConexao.Desconectar();

        }



        public void ExcluirLoginUsuario(int idUsuario)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = objConexao.ObjetoConexao;

            cmd.CommandText = "DELETE FROM [dbo].[LoginUsuario] WHERE ID_LOGIN_USUARIO = @idPessoa;";
            cmd.Parameters.AddWithValue("@idPessoa", idUsuario);

            objConexao.Conectar();
            cmd.ExecuteNonQuery();
            objConexao.Desconectar();

        }
        public void UpdateLoginUsuario(int Id_LoginUsuario, int Id_AcessoBaseDados)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = objConexao.ObjetoConexao;

            cmd.CommandText = "UPDATE [dbo].LoginUsuario SET ID_ACESSO_BASE_DADOS=@Id_AcessoBaseDados WHERE ID_LOGIN_USUARIO = @Id_LoginUsuario;";
            cmd.Parameters.AddWithValue("@Id_LoginUsuario", Id_LoginUsuario);
            cmd.Parameters.AddWithValue("@Id_AcessoBaseDados", Id_AcessoBaseDados);

            objConexao.Conectar();
            cmd.ExecuteNonQuery();
            objConexao.Desconectar();

        }
        //Usuario Acesso ao SQL Base de Dados

        public void IncluiAcessoBancoDados(AcessoBaseDados cliente)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = objConexao.ObjetoConexao;

            //transacao = objConexao.ObjetoConexao.BeginTransaction("");


            cmd.CommandText = "EXEC D_AcessoBancoDadosInserir @Servidor,@BaseDados,@Nome,@Senha;";



            cmd.Parameters.AddWithValue("@Servidor", cliente.Servidor);
            cmd.Parameters.AddWithValue("@BaseDados", cliente.BaseDados);
            cmd.Parameters.AddWithValue("@Nome", cliente.Nome);
            cmd.Parameters.AddWithValue("@Senha", cliente.Senha);


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
        //Adiciona a pessoa de Registro
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

            cmd.CommandText = "EXEC D_R_RegistroGeradoUpdates @IdRegistroSub, @Situacao, @IdPessoaLogadaAlterada," +
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
