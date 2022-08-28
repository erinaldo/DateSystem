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
    class DALCadastro2
    {
        private Conexao objConexao;

        public DALCadastro2(Conexao conexao)
        {
            objConexao = conexao;
        }


        //Inserir Marca e Categoria ---------------------------------------------------------------------------------------------------------------------------
        public void InserirMarcaCategoria(MarcaECartegoria MarcaCategoria)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = objConexao.ObjetoConexao;

            cmd.CommandText = "EXEC D_V_MarcaProdutoInserir @Marca,@DescricaoMarca;";
            cmd.Parameters.AddWithValue("@Marca", MarcaCategoria.Marca);

            if (MarcaCategoria.DescricaoMarca == "")
            {
                // passa valor nulo para a tabela
                cmd.Parameters.AddWithValue("@DescricaoMarca", MarcaCategoria.DescricaoMarca).Value = SqlDateTime.Null;
            }
            else
            {
                cmd.Parameters.AddWithValue("@DescricaoMarca", MarcaCategoria.DescricaoMarca);
            }

            objConexao.Conectar();

            cmd.ExecuteNonQuery();

            objConexao.Desconectar();

            SqlCommand cmd2 = new SqlCommand();
            cmd2.Connection = objConexao.ObjetoConexao;

            cmd2.CommandText = "EXEC D_V_CategoriaProdutoInserir @Categoria,@DescricaoCategoria;";
            cmd2.Parameters.AddWithValue("@Categoria", MarcaCategoria.Categoria);

            if (MarcaCategoria.DescricaoCategoria == "")
            {
                // passa valor nulo para a tabela
                cmd2.Parameters.AddWithValue("@DescricaoCategoria", MarcaCategoria.DescricaoCategoria).Value = SqlDateTime.Null;
            }
            else
            {
                cmd2.Parameters.AddWithValue("@DescricaoCategoria", MarcaCategoria.DescricaoCategoria);
            }

            objConexao.Conectar();

            cmd2.ExecuteNonQuery();

            objConexao.Desconectar();

            SqlCommand cmd3 = new SqlCommand();
            cmd3.Connection = objConexao.ObjetoConexao;

            cmd3.CommandText = "EXEC D_V_ProdutoNomeProdutoInserir @Produto,@DescricaoProduto;";
            cmd3.Parameters.AddWithValue("@Produto", MarcaCategoria.Produto);

            if (MarcaCategoria.DescricaoProduto == "")
            {
                // passa valor nulo para a tabela
                cmd3.Parameters.AddWithValue("@DescricaoProduto", MarcaCategoria.DescricaoProduto).Value = SqlDateTime.Null;
            }
            else
            {
                cmd3.Parameters.AddWithValue("@DescricaoProduto", MarcaCategoria.DescricaoProduto);
            }

            objConexao.Conectar();

            cmd3.ExecuteNonQuery();

            objConexao.Desconectar();

        }
        //Cadastra Cliente Venda
        public void IncluirClienteVenda(ClienteVenda Cliente)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = objConexao.ObjetoConexao;

            cmd.CommandText = "EXEC D_V_PessoaClienteVendaInserir @IdCliente, @NumeroRegistro;";

            cmd.Parameters.AddWithValue("@IdCliente", Cliente.idPessoa);
            //cmd.Parameters.AddWithValue("@IdPessoaTipo", Fisica.IdPessoaTipo);
            cmd.Parameters.AddWithValue("@NumeroRegistro", Cliente.NumeroRegistro);

            objConexao.Conectar();

            cmd.ExecuteScalar();
        }
        //Inserir Produto  ---------------------------------------------------------------------------------------------------------------------------
        public void InserirNomeProduto(MarcaECartegoria MarcaCategoria)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = objConexao.ObjetoConexao;

                cmd.CommandText = "EXEC D_V_ProdutoNomeProdutoInserir @Produto,@DescricaoProduto;";

                if (MarcaCategoria.Produto == "")
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@Produto", MarcaCategoria.Produto).Value = SqlDateTime.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@Produto", MarcaCategoria.Produto);
                }
                if (MarcaCategoria.DescricaoProduto == "")
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@DescricaoProduto", MarcaCategoria.DescricaoProduto).Value = SqlDateTime.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@DescricaoProduto", MarcaCategoria.DescricaoProduto);
                }

                objConexao.Conectar();

                cmd.ExecuteNonQuery();

                objConexao.Desconectar();
            }
            catch(Exception e)
            {
                e.ToString();
            }


        }
        //Inserir Marca e  ---------------------------------------------------------------------------------------------------------------------------
        public void InserirMarca(MarcaECartegoria MarcaCategoria)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = objConexao.ObjetoConexao;

                cmd.CommandText = "EXEC D_V_MarcaProdutoInserir @Marca,@DescricaoMarca;";

                if (MarcaCategoria.Marca == "")
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@Marca", MarcaCategoria.Marca).Value = SqlDateTime.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@Marca", MarcaCategoria.Marca);
                }
                if (MarcaCategoria.DescricaoMarca == "")
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@DescricaoMarca", MarcaCategoria.DescricaoMarca).Value = SqlDateTime.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@DescricaoMarca", MarcaCategoria.DescricaoMarca);
                }

                objConexao.Conectar();

                cmd.ExecuteNonQuery();

                objConexao.Desconectar();
            }
            catch(Exception e)
            {
                e.ToString();
            }
        }
        //Inserir Marca  ---------------------------------------------------------------------------------------------------------------------------
        public void InserirCategoria(MarcaECartegoria MarcaCategoria)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = objConexao.ObjetoConexao;

                cmd.CommandText = "EXEC D_V_CategoriaProdutoInserir @Categoria,@DescricaoCategoria;";

                if (MarcaCategoria.Categoria == "")
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@Categoria", MarcaCategoria.Categoria).Value = SqlDateTime.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@Categoria", MarcaCategoria.Categoria);
                }
                if (MarcaCategoria.DescricaoCategoria == "")
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@DescricaoCategoria", MarcaCategoria.DescricaoCategoria).Value = SqlDateTime.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@DescricaoCategoria", MarcaCategoria.DescricaoCategoria);
                }

                objConexao.Conectar();

                cmd.ExecuteNonQuery();

                objConexao.Desconectar();
            }
            catch(Exception e)
            {
                e.ToString();
            }
        }
        //Inserir Fabricante  ---------------------------------------------------------------------------------------------------------------------------
        public void InserirFabricante(MarcaECartegoria MarcaCategoria)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = objConexao.ObjetoConexao;

                cmd.CommandText = "EXEC D_V_FabricanteProdutoInserir @Fabricante,@DescricaoFabricante;";

                if (MarcaCategoria.Fabricante == "")
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@Fabricante", MarcaCategoria.Fabricante).Value = SqlDateTime.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@Fabricante", MarcaCategoria.Fabricante);
                }
                if (MarcaCategoria.DescricaoFabricante == "")
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@DescricaoFabricante", MarcaCategoria.DescricaoFabricante).Value = SqlDateTime.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@DescricaoFabricante", MarcaCategoria.DescricaoFabricante);
                }

                objConexao.Conectar();

                cmd.ExecuteNonQuery();

                objConexao.Desconectar();
            }
            catch(Exception e)
            {
                e.ToString();
            }
        }

        //Inserir Produto  ---------------------------------------------------------------------------------------------------------------------------
        public void InserirProduto(CadastraProdutos CadastraProduto)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = objConexao.ObjetoConexao;

                cmd.CommandText = "EXEC D_V_ProdutoInserir @IdProdutoDescricao,@IdMarca,@IdCategoriaProduto,@IdFabricanteProduto,@IdUnidadeProduto," +
                "@DescriacaoProduto,@PrecoCusto,@PrecoMedio,@PrecoVenda,@MargemLucro,@DataReajuste,@Quant_Minima,@ImprimirProduto," +
                "@Ativo,@CodInterno,@Observacao,@DataCadastro,@ValorTotal;select @@IDENTITY;";

                cmd.Parameters.AddWithValue("@IdProdutoDescricao", CadastraProduto.IdProdutoDescricao);
                cmd.Parameters.AddWithValue("@IdMarca", CadastraProduto.IdMarca);
                cmd.Parameters.AddWithValue("@IdCategoriaProduto", CadastraProduto.IdCategoriaProduto);
                cmd.Parameters.AddWithValue("@IdFabricanteProduto", CadastraProduto.IdFabricanteProduto);
                cmd.Parameters.AddWithValue("@IdUnidadeProduto", CadastraProduto.IdUnidadeProduto);
                cmd.Parameters.AddWithValue("@DescriacaoProduto", CadastraProduto.DescriacaoProduto);

                if (CadastraProduto.PrecoCusto == "")
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@PrecoCusto", CadastraProduto.PrecoCusto).Value = SqlBinary.Null;
                }else{cmd.Parameters.AddWithValue("@PrecoCusto", CadastraProduto.PrecoCusto);}
                if (CadastraProduto.PrecoMedio == "")
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@PrecoMedio", CadastraProduto.PrecoMedio).Value = SqlBinary.Null;
                }else{cmd.Parameters.AddWithValue("@PrecoMedio", CadastraProduto.PrecoMedio);}
                if (CadastraProduto.PrecoVenda == "")
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@PrecoVenda", CadastraProduto.PrecoVenda).Value = SqlBinary.Null;
                }
                else{cmd.Parameters.AddWithValue("@PrecoVenda", CadastraProduto.PrecoVenda);}
                if (CadastraProduto.MargemLucro == "")
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@MargemLucro", CadastraProduto.MargemLucro).Value = SqlBinary.Null;
                }else { cmd.Parameters.AddWithValue("@MargemLucro", CadastraProduto.MargemLucro); }
                if (CadastraProduto.AdicionarDataReajuste == 0)
                {
                    cmd.Parameters.AddWithValue("@DataReajuste", CadastraProduto.DataReajuste).Value = SqlDateTime.Null;
                }else { cmd.Parameters.AddWithValue("@DataReajuste", CadastraProduto.DataReajuste); }
                cmd.Parameters.AddWithValue("@Quant_Minima", CadastraProduto.Quant_Minima);
                cmd.Parameters.AddWithValue("@ImprimirProduto", CadastraProduto.ImprimirProduto);
                cmd.Parameters.AddWithValue("@Ativo", CadastraProduto.Ativo);
                if (CadastraProduto.CodInterno == 0)//
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@CodInterno", CadastraProduto.CodInterno).Value = SqlBinary.Null;
                }
                else { cmd.Parameters.AddWithValue("@CodInterno", CadastraProduto.CodInterno); }
                if (CadastraProduto.Observacao == "")
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@Observacao", CadastraProduto.Observacao).Value = SqlBinary.Null;
                }
                else { cmd.Parameters.AddWithValue("@Observacao", CadastraProduto.Observacao); }
                cmd.Parameters.AddWithValue("@DataCadastro", CadastraProduto.DataCadastro);
                if (CadastraProduto.ValorTotal == "")
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@ValorTotal", CadastraProduto.ValorTotal).Value = SqlBinary.Null;
                }
                else { cmd.Parameters.AddWithValue("@ValorTotal", CadastraProduto.ValorTotal); }

                objConexao.Conectar();

                CadastraProduto.IdProduto = Convert.ToInt32(cmd.ExecuteScalar());

                objConexao.Desconectar();
            }
            catch (Exception ex)
            {
                ex.ToString();
            }

        }
        public void InserirEstoque(CadastraProdutos CadastraProduto)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = objConexao.ObjetoConexao;

                cmd.CommandText = "EXEC D_V_EstoqueInserir @IdProduto,@QuantComprada,@Documento,@DataFabricacao,@DataVencimento," +
                "@DataEntradaProduto,@DataSolicitacao,@ValorTotal,@Ativo;select @@IDENTITY";

                cmd.Parameters.AddWithValue("@IdProduto", CadastraProduto.IdProduto);

                if (CadastraProduto.AdicionarQuantidadeAtualEstoque == 0)
                {
                    cmd.Parameters.AddWithValue("@QuantComprada", CadastraProduto.QuantComprada).Value = SqlBinary.Null;
                }
                else cmd.Parameters.AddWithValue("@QuantComprada", CadastraProduto.QuantComprada);

                cmd.Parameters.AddWithValue("@Documento", CadastraProduto.Documento);

                if (CadastraProduto.AdicionarDataSolicitacao == 0)
                {
                    cmd.Parameters.AddWithValue("@DataSolicitacao", CadastraProduto.DataSolicitacao).Value = SqlDateTime.Null;
                }
                else cmd.Parameters.AddWithValue("@DataSolicitacao", CadastraProduto.DataSolicitacao);

                if (CadastraProduto.AdicionarDataFabricacao == 0)
                {
                    cmd.Parameters.AddWithValue("@DataFabricacao", CadastraProduto.DataFabricacao).Value = SqlDateTime.Null;
                }else cmd.Parameters.AddWithValue("@DataFabricacao", CadastraProduto.DataFabricacao);

                if (CadastraProduto.AdicionarDataVencimento == 0)
                {
                    cmd.Parameters.AddWithValue("@DataVencimento", CadastraProduto.DataVencimento).Value = SqlDateTime.Null;
                }else cmd.Parameters.AddWithValue("@DataVencimento", CadastraProduto.DataVencimento);

                if (CadastraProduto.AdicionarDataEntrada == 0)
                {
                    cmd.Parameters.AddWithValue("@DataEntradaProduto", CadastraProduto.DataEntradaProduto).Value = SqlDateTime.Null;
                }else cmd.Parameters.AddWithValue("@DataEntradaProduto", CadastraProduto.DataEntradaProduto);

                if (CadastraProduto.ValorTotal == "")
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@ValorTotal", CadastraProduto.ValorTotal).Value = SqlBinary.Null;
                }
                else { cmd.Parameters.AddWithValue("@ValorTotal", CadastraProduto.ValorTotal); }

                cmd.Parameters.AddWithValue("@Ativo", CadastraProduto.Ativo);
                

                objConexao.Conectar();

                CadastraProduto.IdEstoque = Convert.ToInt32(cmd.ExecuteScalar());

                objConexao.Desconectar();
            }
            catch(Exception err)
            {
                err.ToString();
            }

        }
        public void InserirEstoqueItem(CadastraProdutos CadastraProduto)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = objConexao.ObjetoConexao;

                cmd.CommandText = "EXEC D_V_EstoqueItemInserir @IdEstoque,@IdProduto,@IdFornecedor,@IdFabricanteProduto,@PrecoCusto,@PrecoMedio," +
                "@PrecoVenda,@MargemLucro,@Data_Compra,@Quant_Estoque,@DataFabricacao,@DataVencimento,@DataEntradaProduto,@DataSolicitacao,@Ativo,@IdCstIcms," +
                "@DescricaoCstIcms,@ValorIcms,@IdCstPis,@DescricaoCstPis,@ValorPis,@IdCstCofins,@DescricaoCofins,@ValorCofins,@IdCstIpi, " +
                "@DescricaoCstIpi,@ValorIpi,@CodigoGtin,@PesoBruto,@PesoLiquido,@PrevisaoChegada,@OrigemProduto,@QuantComprada;";

                if (CadastraProduto.IdEstoque == 0)//
                {
                    //passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@IdEstoque", CadastraProduto.IdEstoque).Value = SqlBinary.Null;
                }else cmd.Parameters.AddWithValue("@IdEstoque", CadastraProduto.IdEstoque);
                if (CadastraProduto.IdProduto == 0)//
                {
                    //passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@IdProduto", CadastraProduto.IdProduto).Value = SqlBinary.Null;
                }else cmd.Parameters.AddWithValue("@IdProduto", CadastraProduto.IdProduto);
                if (CadastraProduto.IdFornecedor == 0)//
                {
                    //passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@IdFornecedor", CadastraProduto.IdFornecedor).Value = SqlBinary.Null;
                }else cmd.Parameters.AddWithValue("@IdFornecedor", CadastraProduto.IdFornecedor);
                if (CadastraProduto.IdFabricanteProduto == 0)//
                {
                    //passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@IdFabricanteProduto", CadastraProduto.IdFabricanteProduto).Value = SqlBinary.Null;
                }else cmd.Parameters.AddWithValue("@IdFabricanteProduto", CadastraProduto.IdFabricanteProduto);
                if (CadastraProduto.QuantComprada == 0)//
                {
                    //passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@QuantComprada", CadastraProduto.QuantComprada).Value = SqlBinary.Null;
                }else cmd.Parameters.AddWithValue("@QuantComprada", CadastraProduto.QuantComprada);
                if (CadastraProduto.PrecoCusto == "")//
                {
                    //passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@PrecoCusto", CadastraProduto.PrecoCusto).Value = SqlBinary.Null;
                }else cmd.Parameters.AddWithValue("@PrecoCusto", CadastraProduto.PrecoCusto);
                if (CadastraProduto.PrecoMedio == "")//
                {
                    //passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@PrecoMedio", CadastraProduto.PrecoMedio).Value = SqlBinary.Null;
                }else cmd.Parameters.AddWithValue("@PrecoMedio", CadastraProduto.PrecoMedio);
                if (CadastraProduto.PrecoVenda == "")//
                {
                    //passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@PrecoVenda", CadastraProduto.PrecoVenda).Value = SqlBinary.Null;
                }else cmd.Parameters.AddWithValue("@PrecoVenda", CadastraProduto.PrecoVenda);
                if (CadastraProduto.MargemLucro == "")//
                {
                    //passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@MargemLucro", CadastraProduto.MargemLucro).Value = SqlBinary.Null;
                }else cmd.Parameters.AddWithValue("@MargemLucro", CadastraProduto.MargemLucro);

                if (CadastraProduto.AdicionarDataCompra == 0)
                {
                    cmd.Parameters.AddWithValue("@Data_Compra", CadastraProduto.Data_Compra).Value = SqlDateTime.Null;
                }
                else cmd.Parameters.AddWithValue("@Data_Compra", CadastraProduto.Data_Compra);

                if (CadastraProduto.Quant_Estoque == 0)
                {
                    cmd.Parameters.AddWithValue("@Quant_Estoque", CadastraProduto.Quant_Estoque).Value = SqlBinary.Null;
                }
                else cmd.Parameters.AddWithValue("@Quant_Estoque", CadastraProduto.Quant_Estoque);


                if (CadastraProduto.AdicionarDataFabricacao == 0)
                {
                    cmd.Parameters.AddWithValue("@DataFabricacao", CadastraProduto.DataFabricacao).Value = SqlDateTime.Null;
                }else cmd.Parameters.AddWithValue("@DataFabricacao", CadastraProduto.DataFabricacao);

                if (CadastraProduto.AdicionarDataVencimento == 0)
                {
                    cmd.Parameters.AddWithValue("@DataVencimento", CadastraProduto.DataVencimento).Value = SqlDateTime.Null;
                }else cmd.Parameters.AddWithValue("@DataVencimento", CadastraProduto.DataVencimento);

                if (CadastraProduto.AdicionarDataEntrada == 0)
                {
                    cmd.Parameters.AddWithValue("@DataEntradaProduto", CadastraProduto.DataEntradaProduto).Value = SqlDateTime.Null;
                }else cmd.Parameters.AddWithValue("@DataEntradaProduto", CadastraProduto.DataEntradaProduto);
                if (CadastraProduto.AdicionarDataSolicitacao == 0)
                {
                    cmd.Parameters.AddWithValue("@DataSolicitacao", CadastraProduto.DataSolicitacao).Value = SqlDateTime.Null;
                }
                else cmd.Parameters.AddWithValue("@DataSolicitacao", CadastraProduto.DataSolicitacao);
                if (CadastraProduto.AdicionarPrevisaoChegada == 0)
                {
                    cmd.Parameters.AddWithValue("@PrevisaoChegada", CadastraProduto.PrevisaoChegada).Value = SqlDateTime.Null;
                }else cmd.Parameters.AddWithValue("@PrevisaoChegada", CadastraProduto.PrevisaoChegada);


                cmd.Parameters.AddWithValue("@Ativo", CadastraProduto.Ativo);

                if (CadastraProduto.IdCstIcms == 0)//
                {
                    //passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@IdCstIcms", CadastraProduto.IdCstIcms).Value = SqlBinary.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@IdCstIcms", CadastraProduto.IdCstIcms);
                }
                if (CadastraProduto.DescricaoCstIcms == "")//
                {
                    //passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@DescricaoCstIcms", CadastraProduto.DescricaoCstIcms).Value = SqlBinary.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@DescricaoCstIcms", CadastraProduto.DescricaoCstIcms);
                }
                if (CadastraProduto.ValorIcms == "")//
                {
                    //passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@ValorIcms", CadastraProduto.ValorIcms).Value = SqlBinary.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@ValorIcms", CadastraProduto.ValorIcms);
                }
                if (CadastraProduto.IdCstPis == 0)//
                {
                    //passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@IdCstPis", CadastraProduto.IdCstPis).Value = SqlBinary.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@IdCstPis", CadastraProduto.IdCstPis);
                }
                if (CadastraProduto.DescricaoCstPis == "")//
                {
                    //passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@DescricaoCstPis", CadastraProduto.DescricaoCstPis).Value = SqlBinary.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@DescricaoCstPis", CadastraProduto.DescricaoCstPis);
                }
                if (CadastraProduto.ValorPis == "")//
                {
                    //passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@ValorPis", CadastraProduto.ValorPis).Value = SqlBinary.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@ValorPis", CadastraProduto.ValorPis);
                }
                if (CadastraProduto.IdCstCofins == 0)//
                {
                    //passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@IdCstCofins", CadastraProduto.IdCstCofins).Value = SqlBinary.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@IdCstCofins", CadastraProduto.IdCstCofins);
                }
                if (CadastraProduto.DescricaoCofins == "")//
                {
                    //passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@DescricaoCofins", CadastraProduto.DescricaoCofins).Value = SqlBinary.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@DescricaoCofins", CadastraProduto.DescricaoCofins);
                }
                if (CadastraProduto.ValorCofins == "")//
                {
                    //passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@ValorCofins", CadastraProduto.ValorCofins).Value = SqlBinary.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@ValorCofins", CadastraProduto.ValorCofins);
                }
                if (CadastraProduto.IdCstIpi == 0)//
                {
                    //passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@IdCstIpi", CadastraProduto.IdCstIpi).Value = SqlBinary.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@IdCstIpi", CadastraProduto.IdCstIpi);
                }
                if (CadastraProduto.DescricaoCstIpi == "")//
                {
                    //passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@DescricaoCstIpi", CadastraProduto.DescricaoCstIpi).Value = SqlBinary.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@DescricaoCstIpi", CadastraProduto.DescricaoCstIpi);
                }
                if (CadastraProduto.ValorIpi == "")//
                {
                    //passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@ValorIpi", CadastraProduto.ValorIpi).Value = SqlBinary.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@ValorIpi", CadastraProduto.ValorIpi);
                }
                if (CadastraProduto.CodigoGtin == 0)//
                {
                    //passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@CodigoGtin", CadastraProduto.CodigoGtin).Value = SqlBinary.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@CodigoGtin", CadastraProduto.CodigoGtin);
                }
                if (CadastraProduto.PesoBruto == "")//
                {
                    //passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@PesoBruto", CadastraProduto.PesoBruto).Value = SqlBinary.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@PesoBruto", CadastraProduto.PesoBruto);
                }
                if (CadastraProduto.PesoLiquido == "")//
                {
                    //passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@PesoLiquido", CadastraProduto.PesoLiquido).Value = SqlBinary.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@PesoLiquido", CadastraProduto.PesoLiquido);
                }
                if (CadastraProduto.OrigemProduto == "")//
                {
                    //passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@OrigemProduto", CadastraProduto.OrigemProduto).Value = SqlDateTime.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@OrigemProduto", CadastraProduto.OrigemProduto);
                }                
                objConexao.Conectar();

                cmd.ExecuteNonQuery();

                objConexao.Desconectar();
            }
            catch(Exception err)
            {
                err.ToString();
            }

        }
        //Inserir Produto  ---------------------------------------------------------------------------------------------------------------------------
        public void AlterarProduto(CadastraProdutos AlterarProduto)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = objConexao.ObjetoConexao;

                cmd.CommandText = "EXEC D_V_ProdutoUpdate @IdProduto,@IdProdutoDescricao,@IdMarca,@IdCategoriaProduto,@ImprimirProduto," +
                "@Observacao;";
                cmd.Parameters.AddWithValue("@IdProduto", AlterarProduto.IdProduto);
                cmd.Parameters.AddWithValue("@IdProdutoDescricao", AlterarProduto.IdProdutoDescricao);
                cmd.Parameters.AddWithValue("@IdMarca", AlterarProduto.IdMarca);
                cmd.Parameters.AddWithValue("@IdCategoriaProduto", AlterarProduto.IdCategoriaProduto);
                cmd.Parameters.AddWithValue("@ImprimirProduto", AlterarProduto.ImprimirProduto);
                if (AlterarProduto.Observacao == "")
                {
                    // passa valor nulo para a tabela
                    cmd.Parameters.AddWithValue("@Observacao", AlterarProduto.Observacao).Value = SqlDateTime.Null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@Observacao", AlterarProduto.Observacao);
                }

                objConexao.Conectar();

                cmd.ExecuteNonQuery();

                objConexao.Desconectar();
            }
            catch(SqlException ex)
            {
                ex.ToString();
            }
            

        }
        //CeP do usuario em geral Se ele precisa
        public void UsuarioGeralCepInserir(CepCadastraUsuario cep)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = objConexao.ObjetoConexao;

            /*
            cmd.CommandText = "INSERT INTO [dbo].[P_Cep]([ID_CEP],[CEP],[TIPO_LOGRADOURO],[ENDERECO],[NUMERO],[COMPLEMENTO],[BAIRRO],[CIDADE],[SIGLA_CIDADE])"
            + " VALUES(@IdCep,@Cep,@TipoLogradouro,@Endereco,@Numero,@Complemento,@Bairro,@Cidade,@SiglaCidade);select @@IDENTITY;";
            */
            //PROCEDURE NAO EXISTE
            cmd.CommandText = "exec UsuarioGeralCepInserir @IdCep,@Cep,@TipoLogradouro,@Endereco,@Numero,@Complemento,@Bairro,@Cidade,@SiglaCidade;";

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
            cmd.Parameters.AddWithValue("@Bairro", cep.Bairro);
            cmd.Parameters.AddWithValue("@Cidade", cep.Cidade);
            cmd.Parameters.AddWithValue("@SiglaCidade", cep.SiglaCidade);

            objConexao.Conectar();
            cmd.ExecuteScalar();
            objConexao.Desconectar();
        }

        ////Altera informação de Funcionario-----------------------------------------------------------------------------------------------------------------------------------
        //public void AlterarFuncionario(Funcionario cliente)
        //{
        //    SqlCommand cmd = new SqlCommand();
        //    cmd.Connection = objConexao.ObjetoConexao;

        //    cmd.CommandText = "EXEC FuncionarioUpdate @idPessoa,@Situacao,@Nome,@Abreviacao,@Telefone,@Telefone2,@Celular,@Celular2,@Email,@Observacao;";
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
            cmd.CommandText = "exec FuncionarioCepUpdate @IdCep,@Complemento";

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
            objConexao.Desconectar();
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


            cmd.CommandText = "EXEC PessoaContatosInserir @idPessoa,@Situacao,@Nome,@Abreviacao, @Telefone,@Telefone2, @Celular,@Celular2,@Email,@Observacao;"; 



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

            objConexao.Desconectar();
        }

        

        //Altera informação de Funcionario Contatos-------------------------------------------------------------------------------------------------------------------------
        public void AlterarFContatos(FornecedorContatos cliente)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = objConexao.ObjetoConexao;

            cmd.CommandText = "EXEC PessoaContatosUpdate @idPessoa,@Situacao,@Nome,@Abreviacao,@Telefone,@Telefone2,@Celular,@Celular,@Email,@Observacao; ";

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

            cmd.CommandText = "EXEC PessoaContatosInserir @idPessoa,@Situacao,@Nome,@Abreviacao, @Telefone,@Telefone2, @Celular,@Celular2,@Email,@Observacao;";

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

            objConexao.Desconectar();

            //cliente.IdContatof = Convert.ToInt32(cmd.ExecuteScalar());
        }



        //Altera informação de Funcionario Contatos-------------------------------------------------------------------------------------------------------------------------
        public void AlterarCContatos(ClientesContatos cliente)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = objConexao.ObjetoConexao;

            cmd.CommandText = "EXEC PessoaContatosUpdate @idPessoa,@Situacao,@Nome,@Abreviacao,@Telefone,@Telefone2,@Celular,@Celular2,@Email,@Observacao;"; 

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

            cmd.CommandText = "EXEC OsInserir @idPessoa,@IdContato,@Funcionario,@IdServico,@IdItemServico,@IdEstado,@IdSituacao,@IdPessoaLogada,@OrigemChamado,@ServicosExecutados,@ValorObra," +
                "@HorarioInicio,@HorarioFinal,@DataSolicitacao,@DataFechamento;";

            cmd.Parameters.AddWithValue("@idPessoa", cliente.IdPessoaCliente);
            cmd.Parameters.AddWithValue("@IdContato", cliente.IdContato);
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
            if(cliente.MudancaDataFechamento == 0)
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

            cmd.CommandText = "EXEC OsUpdates @IdOs,@IdContatoCliente,@IdPessoaLogadaAlterada,@OrigemChamado,@ServicosExecutados, @HorarioInicio,@HorarioFinal,@DataFechamento,@Estado;";

            cmd.Parameters.AddWithValue("@IdOs", cliente.IdOs);
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

        //Base de Dados Produto Imagem
        //Incluir Imagem de Produto
        public void IncluirProdutoImagem(ProdutoImagem Imagem)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = objConexao.ObjetoConexao;

            //transacao = objConexao.ObjetoConexao.BeginTransaction("");


            cmd.CommandText = "EXEC D_V_ProdutoImagemInserir @IdProduto,@Imagem;";

            cmd.Parameters.AddWithValue("@IdProduto", Imagem.IdProduto);
            cmd.Parameters.AddWithValue("@Imagem", Imagem.Imagem);

            objConexao.Conectar();
            cmd.ExecuteScalar();
            objConexao.Desconectar();
        }
        public void IncluirProdutoImagem2(ProdutoImagem2 Imagem2)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = objConexao.ObjetoConexao;

            //transacao = objConexao.ObjetoConexao.BeginTransaction("");


            cmd.CommandText = "EXEC D_V_ProdutoImagemInserir2 @IdProduto2,@Imagem2;";

            cmd.Parameters.AddWithValue("@IdProduto2", Imagem2.IdProduto2);
            cmd.Parameters.AddWithValue("@Imagem2", Imagem2.Imagem2);

            objConexao.Conectar();
            cmd.ExecuteScalar();
            objConexao.Desconectar();
        }
        public void AlterarProdutoImagem(ProdutoImagem Imagem)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = objConexao.ObjetoConexao;

            //transacao = objConexao.ObjetoConexao.BeginTransaction("");


            cmd.CommandText = "EXEC D_V_ProdutoImagemUpdate @IdProduto,@Imagem;";

            cmd.Parameters.AddWithValue("@IdProduto", Imagem.IdProduto);
            cmd.Parameters.AddWithValue("@Imagem", Imagem.Imagem);


            objConexao.Conectar();
            cmd.ExecuteScalar();
            objConexao.Desconectar();
        }
        public void AlterarProdutoImagem2(ProdutoImagem2 Imagem2)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = objConexao.ObjetoConexao;

            //transacao = objConexao.ObjetoConexao.BeginTransaction("");


            cmd.CommandText = "EXEC D_V_ProdutoImagemUpdate2 @IdProduto2,@Imagem2;";

            cmd.Parameters.AddWithValue("@IdProduto2", Imagem2.IdProduto2);
            cmd.Parameters.AddWithValue("@Imagem2", Imagem2.Imagem2);


            objConexao.Conectar();
            cmd.ExecuteScalar();
            objConexao.Desconectar();
        }

        //Criacao de login dos usuarios

        public void IncluirLoginUsuario(CadastroLoginNovo Usuario)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = objConexao.ObjetoConexao;

            cmd.CommandText = "EXEC LoginUsuarioInserir @Nome,@Abreviacao,@Usuario,@Senha,@ConfirmaSenha,@Observacao,@Situacao,@UsuarioAcesso,@IdAcessoBaseDados,@UsuarioCriar,@UsuarioAlterar,@UsuarioExcluir," +
                "@UsuarioPesquisa,@UsuarioVisualizar,@ClienteCadastra,@ClientePesquisa,@ClienteVisualizar,@ClienteEditar,@ClienteExcluir," +
                "@ClienteCCadastra,@ClienteCPesquisa,@ClienteCVisualizar,@ClienteCEditar,@ClienteCExcluir,@FornecedorCadastra,@FornecedorPesquisa,@FornecedorVisualizar," +
                "@FornecedorEditar,@FornecedorExcluir,@FornecedorCCadastra,@FornecedorCPesquisa,@FornecedorCVisualizar,@FornecedorCEditar,@FornecedorcExcluir,@FuncionarioCadastra,@FuncionarioPesquisa," +
                "@FuncionarioVisualizar,@FuncionarioEditar,@FuncionarioExcluir,@OsCadastra,@OsPesquisa,@OsVisualizar,@OsEditar,@OsExcluir,@SeniorSapiensAcesso,@SeniorSapiensPesquisa,@SeniorSapiensExcluir,"+
                "@VendedorCadastra,@VendedorPesquisa, @VendedorVisualizar,@VendedorEditar,@VendedorExcluir,@PermissaoBasedados, @PermissaoNivelaAcesso,@PermissaoCliente,@PermissaoFornecedor,"+
                "@PermissaoFuncionarioOs,@PermissaoFuncionarioVendedor,@PermissaoUsuarioAcesso,@PermissaoOs,@PermissaoSeniorSapiens;";

            cmd.Parameters.AddWithValue("@Nome", Usuario.IdCadastroLoginNovo);
            cmd.Parameters.AddWithValue("@Nome", Usuario.Nome);
            cmd.Parameters.AddWithValue("@Usuario", Usuario.Usuario);
            cmd.Parameters.AddWithValue("@Senha", Usuario.Senha);
            cmd.Parameters.AddWithValue("@ConfirmaSenha", Usuario.ConfirmaSenha);
            cmd.Parameters.AddWithValue("@Observacao", Usuario.Observacao);
            cmd.Parameters.AddWithValue("@Situacao", Usuario.Situacao);
            cmd.Parameters.AddWithValue("@UsuarioAcesso", Usuario.UsuarioAcesso);
            cmd.Parameters.AddWithValue("@IdAcessoBaseDados", Usuario.IdAcessoBaseDados);

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
            cmd.Parameters.AddWithValue("@FuncionarioCadastra", Usuario.FuncionarioCadastra);
            cmd.Parameters.AddWithValue("@FuncionarioPesquisa", Usuario.FuncionarioPesquisa);
            cmd.Parameters.AddWithValue("@FuncionarioVisualizar", Usuario.FuncionarioVisualizar);
            cmd.Parameters.AddWithValue("@FuncionarioEditar", Usuario.FuncionarioEditar);
            cmd.Parameters.AddWithValue("@FuncionarioExcluir", Usuario.FuncionarioExcluir);
            cmd.Parameters.AddWithValue("@OsCadastra", Usuario.OsCadastra);
            cmd.Parameters.AddWithValue("@OsPesquisa", Usuario.OsPesquisa);
            cmd.Parameters.AddWithValue("@OsVisualizar", Usuario.OsVisualizar);
            cmd.Parameters.AddWithValue("@OsEditar", Usuario.OsEditar);
            cmd.Parameters.AddWithValue("@OsExcluir", Usuario.OsExcluir);
            cmd.Parameters.AddWithValue("@SeniorSapiensAcesso", Usuario.SeniorSapiensAcesso);
            cmd.Parameters.AddWithValue("@SeniorSapiensPesquisa", Usuario.SeniorSapiensPesquisa);
            cmd.Parameters.AddWithValue("@SeniorSapiensExcluir", Usuario.SeniorSapiensExcluir);
            cmd.Parameters.AddWithValue("@VendedorCadastra", Usuario.VendedorCadastra);
            cmd.Parameters.AddWithValue("@VendedorPesquisa", Usuario.VendedorPesquisa);
            cmd.Parameters.AddWithValue("@VendedorVisualizar", Usuario.VendedorVisualizar);
            cmd.Parameters.AddWithValue("@VendedorEditar", Usuario.VendedorEditar);
            cmd.Parameters.AddWithValue("@VendedorExcluir", Usuario.VendedorExcluir);
            cmd.Parameters.AddWithValue("@PermissaoBasedados", Usuario.PermissaoBasedados);
            cmd.Parameters.AddWithValue("@PermissaoNivelaAcesso", Usuario.PermissaoNivelaAcesso);
            cmd.Parameters.AddWithValue("@PermissaoCliente", Usuario.PermissaoCliente);
            cmd.Parameters.AddWithValue("@PermissaoFornecedor", Usuario.PermissaoFornecedor);
            cmd.Parameters.AddWithValue("@PermissaoFuncionarioOs", Usuario.PermissaoFuncionarioOs);
            cmd.Parameters.AddWithValue("@PermissaoFuncionarioVendedor", Usuario.PermissaoFuncionarioVendedor);
            cmd.Parameters.AddWithValue("@PermissaoUsuarioAcesso", Usuario.PermissaoUsuarioAcesso);
            cmd.Parameters.AddWithValue("@PermissaoOs", Usuario.PermissaoOs);
            cmd.Parameters.AddWithValue("@PermissaoSeniorSapiens", Usuario.PermissaoSeniorSapiens);


            objConexao.Conectar();
            cmd.ExecuteScalar();
            objConexao.Desconectar();

        }

        public void AlterarLoginUsuario(CadastroLoginNovo Usuario)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = objConexao.ObjetoConexao;

            cmd.CommandText = "EXEC D_V_ProdutoUpdate @idUsuario,@Senha,@ConfirmaSenha,@Observacao,@Situacao,@UsuarioAcesso,@UsuarioCriar,@UsuarioAlterar,@UsuarioExcluir," +
                "@UsuarioPesquisa,@UsuarioVisualizar,@ClienteCadastra,@ClientePesquisa,@ClienteVisualizar,@ClienteEditar,@ClienteExcluir," +
                "@ClienteCCadastra,@ClienteCPesquisa,@ClienteCVisualizar,@ClienteCEditar,@ClienteCExcluir,@FornecedorCadastra,@FornecedorPesquisa,@FornecedorVisualizar," +
                "@FornecedorEditar,@FornecedorExcluir,@FornecedorCCadastra,@FornecedorCPesquisa,@FornecedorCVisualizar,@FornecedorCEditar,@FornecedorcExcluir,@FuncionarioCadastra,@FuncionarioPesquisa," +
                "@FuncionarioVisualizar,@FuncionarioEditar,@FuncionarioExcluir,@OsCadastra,@OsPesquisa,@OsVisualizar,@OsEditar,@OsExcluir,@SeniorSapiensAcesso,@SeniorSapiensPesquisa,@SeniorSapiensExcluir;";
 
            cmd.Parameters.AddWithValue("@idUsuario", Usuario.IdCadastroLoginNovo);
            cmd.Parameters.AddWithValue("@Senha", Usuario.Senha);
            cmd.Parameters.AddWithValue("@ConfirmaSenha", Usuario.ConfirmaSenha);
            cmd.Parameters.AddWithValue("@Observacao", Usuario.Observacao);
            cmd.Parameters.AddWithValue("@Situacao", Usuario.Situacao);
            cmd.Parameters.AddWithValue("@UsuarioAcesso", Usuario.UsuarioAcesso);

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
            cmd.Parameters.AddWithValue("@FuncionarioCadastra", Usuario.FuncionarioCadastra);
            cmd.Parameters.AddWithValue("@FuncionarioPesquisa", Usuario.FuncionarioPesquisa);
            cmd.Parameters.AddWithValue("@FuncionarioVisualizar", Usuario.FuncionarioVisualizar);
            cmd.Parameters.AddWithValue("@FuncionarioEditar", Usuario.FuncionarioEditar);
            cmd.Parameters.AddWithValue("@FuncionarioExcluir", Usuario.FuncionarioExcluir);
            cmd.Parameters.AddWithValue("@OsCadastra", Usuario.OsCadastra);
            cmd.Parameters.AddWithValue("@OsPesquisa", Usuario.OsPesquisa);
            cmd.Parameters.AddWithValue("@OsVisualizar", Usuario.OsVisualizar);
            cmd.Parameters.AddWithValue("@OsEditar", Usuario.OsEditar);
            cmd.Parameters.AddWithValue("@OsExcluir", Usuario.OsExcluir);
            cmd.Parameters.AddWithValue("@SeniorSapiensAcesso", Usuario.SeniorSapiensAcesso);
            cmd.Parameters.AddWithValue("@SeniorSapiensPesquisa", Usuario.SeniorSapiensPesquisa);
            cmd.Parameters.AddWithValue("@SeniorSapiensExcluir", Usuario.SeniorSapiensExcluir);

            objConexao.Conectar();

            cmd.ExecuteScalar();
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

            objConexao.Conectar();
        }

        //public void AlterarOsImagem(OsImagem Imagem)
        //{
        //    SqlCommand cmd = new SqlCommand();
        //    cmd.Connection = objConexao.ObjetoConexao;

        //    //transacao = objConexao.ObjetoConexao.BeginTransaction("");


        //    cmd.CommandText = "EXEC OsImagemUpdate @IdOs,@Imagem;";

        //    cmd.Parameters.AddWithValue("@IdOs", Imagem.IdOs);
        //    cmd.Parameters.AddWithValue("@Imagem", Imagem.Imagem);


        //    objConexao.Conectar();

        //    cmd.ExecuteScalar();
        //}
        //Usuario Acesso ao SQL Base de Dados

        public void IncluiAcessoBancoDados(AcessoBaseDados cliente)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = objConexao.ObjetoConexao;

            //transacao = objConexao.ObjetoConexao.BeginTransaction("");


            cmd.CommandText = "EXEC AcessoBancoDadosInserir @Servidor,@BaseDados,@Nome,@Senha;";



            cmd.Parameters.AddWithValue("@Servidor", cliente.Servidor);
            cmd.Parameters.AddWithValue("@BaseDados", cliente.BaseDados);
            cmd.Parameters.AddWithValue("@Nome", cliente.Nome);
            cmd.Parameters.AddWithValue("@Senha", cliente.Senha);


            objConexao.Conectar();
            cmd.ExecuteScalar();
        }
        // Adicionar Quantidade de usado em Unidade de Produto -----------
        public void IncluiUnidadeProduto(CadastraObjetosVendas UnidadeMedida)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = objConexao.ObjetoConexao;

            cmd.CommandText = "EXEC D_V_Pr_UnidadeMedidaQUUpdate @IdUnidadeMedida,@QuantidadeUsada;";

            cmd.Parameters.AddWithValue("@IdUnidadeMedida", UnidadeMedida.IdUnidadeMedida);
            cmd.Parameters.AddWithValue("@QuantidadeUsada", UnidadeMedida.QuantidadeUsada);

            objConexao.Conectar();
            cmd.ExecuteScalar();
        }
    }
}

