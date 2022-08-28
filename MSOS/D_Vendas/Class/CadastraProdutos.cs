using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateSystem
{
    class CadastraProdutos
    {
        public CadastraProdutos()
        {
            this.IdProduto = 0;
            this.IdProdutoDescricao = 0;
            this.IdEstoque = 0;
            this.IdItemVenda = 0;
            this.IdFornecedor = 0;
            this.IdMarca = 0;
            this.IdCategoriaProduto = 0;
            this.IdFabricanteProduto = 0;
            this.IdIDetalheVenda = 0;
            this.DescriacaoProduto = "";
            this.PrecoCusto = "";
            DateTime Data_Compra = DateTime.Now;
            string Data_CompraFormato = Data_Compra.ToString("MM/dd/yyyy");
            this.Data_Compra = Data_Compra;
            this.Ativo = 0;
            this.ImprimirProduto = 0;
            this.Unidade = 0;
            this.Quant_Estoque = 0;
            this.Quant_Minima = 0;
            this.Observacao = "";
            this.CodInterno = 0;
            this.Cts_Csosn = "";
            this.Cest = "";
            this.Aliquota_Icms = "";
            this.BaseCalculoIcms = "";
            this.Ncm = 0;
            this.IdAliquotaIpi = "";
            this.ValorUnitario ="";
            this.Versao = "";
            this.PrecoVenda = "";
            this.MargemLucro = "";
            DateTime DataReajuste = DateTime.Now;
            string DataReajusteFormato = DataReajuste.ToString("MM/dd/yyyy");
            this.DataReajuste = DataReajuste;
            this.CodigoGtin = 0;
            this.PesoBruto = "";
            this.PesoLiquido = "";
            DateTime PrevisaoChegada = DateTime.Now;
            string PrevisaoChegadaFormato = PrevisaoChegada.ToString("MM/dd/yyyy");
            this.PrevisaoChegada = PrevisaoChegada;
            this.OrigemProduto = "";
            this.IdUnidadeProduto = 0;
            this.ValorIcms = "";
            this.ValorPis = "";
            this.ValorCofins = "";
            this.DescricaoCstIcms = "";
            this.DescricaoCstPis = "";
            this.DescricaoCofins = "";
            this.DescricaoCstIpi = "";
            this.QuantComprada = 0;
            this.Documento = "";
            this.DataFabricacao = DateTime.Now;
            this.DataVencimento = DateTime.Now;
            this.DataSolicitacao = DateTime.Now;
            this.ValorTotal = "";
            this.DataCadastro = DateTime.Now;
            this.DataEntradaProduto = DateTime.Now;
            this.AdicionarDataSolicitacao = 0;
            this.AdicionarDataFabricacao = 0;
            this.AdicionarDataVencimento = 0;
            this.AdicionarDataEntrada = 0;
            this.AdicionarDataCompra = 0;
            this.AdicionarDataReajuste = 0;
            this.AdicionarPrevisaoChegada = 0;
            this.AdicionarValorTotal = 0;
            this.AdicionarQuantidadeAtualEstoque = 0;

        }
        public CadastraProdutos(int ID_PRODUTO, int ID_ESTOQUE, int ID_ITEM_VENDA, int ID_FORNECEDOR, int ID_MARCA, int ID_CATEGORIA_PRODUTO, int ID_FABRICANTE_PRODUTO, int ID_PRODUTO_DESCRICAO, int ID_DETALHE_VENDA,
            string DESCRICAO_PRODUTO, string PRECO_CUSTO,DateTime DATA_COMPRA, int ATIVO, int IMPRIMIR_PRODUTO, int UNIDADE, int QUANT_ESTOQUE, int QUANT_MINIMA, string OBSERVACAO, int CODIGO_INTERNO, String CST_CSOSN, String CEST,
            String ALIQUOTA_ICMS, String BASE_CALCULO_ICMS, int NCM, String ID_ALIQUOTA_IPI, string VALOR_UNITARIO, String VERSAO, string PRECO_VENDA, string MARGEM_LUCRO, DateTime DATA_REAJUSTE,
             int CODIGO_GTIN, String PESO_BRUTO, String PESO_LIQUIDO ,DateTime PREVISAO_CHEGADA, string ORIGEM_PRODUTO, int IDUNIDADE_PRODUTO, String VALOR_ICMS, String VALOR_PIS, String COFINS,
             String DESCRICAO_CST_ICMS, String DESCRICAO_CST_PIS, String DESCRICAO_CST_COFINS, String DESCRICAO_CST_IPI, int QUANTIDADE_COMPRADA, String DOCUMENTO, DateTime DATA_FABRICACAO, DateTime DATA_VENCIMENTO,
             DateTime DATA_SOLICITACAO, String VALOR_TOTAL, DateTime DATA_CADASTRO, DateTime DATA_ENTRADA_PRODUTO, int ADICIONAR_DATA_REAJUSTE, int ADICIONAR_DATA_COMPRA, int ADICIONAR_DATA_ENTRADA, int ADICIONAR_DATA_VENCIMENTO,
            int ADICIONAR_DATA_FABRICACAO,int ADICIONAR_DATA_SOLICITACAO,int ADICIONAR_DATA_PREVISAO_CHEGADA,int ADICIONAR_VALOR_TOTAL, int ADICIONAR_QUANTIDADE_ATUAL_ESTOQUE)
        {

            this.IdProduto = ID_PRODUTO;
            this.IdProdutoDescricao = ID_PRODUTO_DESCRICAO;
            this.IdEstoque = ID_ESTOQUE;
            this.IdItemVenda = ID_ITEM_VENDA;
            this.IdFornecedor = ID_FORNECEDOR;
            this.IdMarca = ID_MARCA;
            this.IdCategoriaProduto = ID_CATEGORIA_PRODUTO;
            this.IdFabricanteProduto = ID_FABRICANTE_PRODUTO;
            this.IdIDetalheVenda = ID_DETALHE_VENDA;
            this.DescriacaoProduto = DESCRICAO_PRODUTO;
            this.PrecoCusto = PRECO_CUSTO;
            this.Data_Compra = DATA_COMPRA;
            this.Ativo = ATIVO;
            this.ImprimirProduto = IMPRIMIR_PRODUTO;
            this.Unidade = UNIDADE;
            this.Quant_Estoque = QUANT_ESTOQUE;
            this.Quant_Minima = QUANT_MINIMA;
            this.Observacao = OBSERVACAO;
            this.CodInterno = CODIGO_INTERNO;
            this.Cts_Csosn = CST_CSOSN;
            this.Cest = CEST;
            this.Aliquota_Icms = ALIQUOTA_ICMS;
            this.BaseCalculoIcms = BASE_CALCULO_ICMS;
            this.Ncm = NCM;
            this.IdAliquotaIpi = ID_ALIQUOTA_IPI;
            this.ValorUnitario = VALOR_UNITARIO;
            this.Versao = VERSAO;
            this.PrecoVenda = PRECO_VENDA;
            this.MargemLucro = MARGEM_LUCRO;
            this.DataReajuste = DATA_REAJUSTE;
            this.CodigoGtin = CODIGO_GTIN;
            this.PesoBruto = PESO_BRUTO;
            this.PesoLiquido = PESO_LIQUIDO;
            this.PrevisaoChegada = PREVISAO_CHEGADA;
            this.OrigemProduto = ORIGEM_PRODUTO;
            this.IdUnidadeProduto = IDUNIDADE_PRODUTO;
            this.ValorIcms = VALOR_ICMS;
            this.ValorPis = VALOR_PIS;
            this.ValorCofins = COFINS;
            this.DescricaoCstIcms = DESCRICAO_CST_ICMS;
            this.DescricaoCstPis = DESCRICAO_CST_PIS;
            this.DescricaoCofins = DESCRICAO_CST_COFINS;
            this.DescricaoCstIpi = DESCRICAO_CST_IPI;
            this.QuantComprada = QUANTIDADE_COMPRADA;
            this.Documento = DOCUMENTO;
            this.DataFabricacao = DATA_FABRICACAO;
            this.DataVencimento = DATA_VENCIMENTO;
            this.DataSolicitacao = DATA_SOLICITACAO;
            this.ValorTotal = VALOR_TOTAL;
            this.DataCadastro = DATA_CADASTRO;
            this.DataEntradaProduto = DATA_ENTRADA_PRODUTO;
            this.AdicionarDataSolicitacao = ADICIONAR_DATA_SOLICITACAO;
            this.AdicionarDataFabricacao = ADICIONAR_DATA_VENCIMENTO;
            this.AdicionarDataVencimento = ADICIONAR_DATA_FABRICACAO;
            this.AdicionarDataEntrada = ADICIONAR_DATA_ENTRADA;
            this.AdicionarDataCompra = ADICIONAR_DATA_COMPRA;
            this.AdicionarDataReajuste = ADICIONAR_DATA_REAJUSTE;
            this.AdicionarPrevisaoChegada = ADICIONAR_DATA_PREVISAO_CHEGADA;
            this.AdicionarValorTotal = ADICIONAR_VALOR_TOTAL;
            this.AdicionarQuantidadeAtualEstoque = ADICIONAR_QUANTIDADE_ATUAL_ESTOQUE;
        }

        private int ID_PRODUTO;
        public int IdProduto
        {
            get
            {
                return this.ID_PRODUTO;

            }
            set
            {
                this.ID_PRODUTO = value;
            }
        }

        private int ID_ESTOQUE;
        public int IdEstoque
        {
            get
            {
                return this.ID_ESTOQUE;

            }
            set
            {
                this.ID_ESTOQUE = value;
            }
        }
        private int ID_ITEM_VENDA;
        public int IdItemVenda
        {
            get
            {
                return this.ID_ITEM_VENDA;

            }
            set
            {
                this.ID_ITEM_VENDA = value;
            }
        }
        private int ID_DETALHE_VENDA;
        public int IdIDetalheVenda
        {
            get
            {
                return this.ID_DETALHE_VENDA;

            }
            set
            {
                this.ID_DETALHE_VENDA = value;
            }
        }
        private int ID_FORNECEDOR;
        public int IdFornecedor
        {
            get
            {
                return this.ID_FORNECEDOR;

            }
            set
            {
                this.ID_FORNECEDOR = value;
            }
        }
        private int ID_MARCA;
        public int IdMarca
        {
            get
            {
                return this.ID_MARCA;

            }
            set
            {
                this.ID_MARCA = value;
            }
        }
        private int ID_CATEGORIA_PRODUTO;
        public int IdCategoriaProduto
        {
            get
            {
                return this.ID_CATEGORIA_PRODUTO;

            }
            set
            {
                this.ID_CATEGORIA_PRODUTO = value;
            }
        }
        private int ID_FABRICANTE_PRODUTO;
        public int IdFabricanteProduto
        {
            get
            {
                return this.ID_FABRICANTE_PRODUTO;

            }
            set
            {
                this.ID_FABRICANTE_PRODUTO = value;
            }
        }
        private string DESCRICAO_PRODUTO;
        public string DescriacaoProduto
        {
            get
            {
                return this.DESCRICAO_PRODUTO;

            }
            set
            {
                this.DESCRICAO_PRODUTO = value;
            }
        }
        private int ID_PRODUTO_DESCRICAO;
        public int IdProdutoDescricao
        {
            get
            {
                return this.ID_PRODUTO_DESCRICAO;

            }
            set
            {
                this.ID_PRODUTO_DESCRICAO = value;
            }
        }
        private string PRECO_CUSTO;
        public string PrecoCusto
        {
            get
            {
                return this.PRECO_CUSTO;

            }
            set
            {
                this.PRECO_CUSTO = value;
            }
        }

        private DateTime DATA_COMPRA;
        public DateTime Data_Compra
        {
            get
            {
                return this.DATA_COMPRA;

            }
            set
            {
                this.DATA_COMPRA = value;
            }
        }
        private int ATIVO;
        public int Ativo
        {
            get
            {
                return this.ATIVO;

            }
            set
            {
                this.ATIVO = value;
            }
        }

        private string OBSERVACAO;
        public string Observacao
        {
            get
            {
                return this.OBSERVACAO;

            }
            set
            {
                this.OBSERVACAO = value;
            }
        }

        private int IMPRIMIR_PRODUTO;
        public int ImprimirProduto
        {
            get
            {
                return this.IMPRIMIR_PRODUTO;

            }
            set
            {
                this.IMPRIMIR_PRODUTO = value;
            }

        }

        private int UNIDADE;
        public int Unidade
        {
            get
            {
                return this.UNIDADE;

            }
            set
            {
                this.UNIDADE = value;
            }
        }

        private int QUANT_ESTOQUE;
        public int Quant_Estoque
        {
            get
            {
                return this.QUANT_ESTOQUE;

            }
            set
            {
                this.QUANT_ESTOQUE = value;
            }
        }

        private int QUANT_MINIMA;
        public int Quant_Minima
        {
            get
            {
                return this.QUANT_MINIMA;

            }
            set
            {
                this.QUANT_MINIMA = value;
            }
        }

        private int CODIGO_INTERNO;
        public int CodInterno
        {
            get
            {
                return this.CODIGO_INTERNO;

            }
            set
            {
                this.CODIGO_INTERNO = value;
            }
        }

        private string CST_CSOSN;
        public string Cts_Csosn
        {
            get
            {
                return this.CST_CSOSN;

            }
            set
            {
                this.CST_CSOSN = value;
            }
        }

        private string CEST;
        public string Cest
        {
            get
            {
                return this.CEST;

            }
            set
            {
                this.CEST = value;
            }
        }

        private string ALIQUOTA_ICMS;
        public string Aliquota_Icms
        {
            get
            {
                return this.ALIQUOTA_ICMS;

            }
            set
            {
                this.ALIQUOTA_ICMS = value;
            }
        }
        private string BASE_CALCULO_ICMS;
        public string BaseCalculoIcms
        {
            get
            {
                return this.BASE_CALCULO_ICMS;

            }
            set
            {
                this.BASE_CALCULO_ICMS = value;
            }
        }
        private int NCM;
        public int Ncm
        {
            get
            {
                return this.NCM;

            }
            set
            {
                this.NCM = value;
            }
        }
        private string ID_ALIQUOTA_IPI;
        public string IdAliquotaIpi
        {
            get
            {
                return this.ID_ALIQUOTA_IPI;

            }
            set
            {
                this.ID_ALIQUOTA_IPI = value;
            }
        }
        private string VALOR_UNITARIO;
        public string ValorUnitario
        {
            get
            {
                return this.VALOR_UNITARIO;

            }
            set
            {
                this.VALOR_UNITARIO = value;
            }
        }
        private string VERSAO;
        public string Versao
        {
            get
            {
                return this.VERSAO;

            }
            set
            {
                this.VERSAO = value;
            }
        }
        private string PRECO_VENDA;
        public string PrecoVenda
        {
            get
            {
                return this.PRECO_VENDA;

            }
            set
            {
                this.PRECO_VENDA = value;
            }
        }
        private string MARGEM_LUCRO;
        public string MargemLucro
        {
            get
            {
                return this.MARGEM_LUCRO;

            }
            set
            {
                this.MARGEM_LUCRO = value;
            }
        }
        private DateTime DATAREAJUSTE;
        public DateTime DataReajuste
        {
            get
            {
                return this.DATAREAJUSTE;

            }
            set
            {
                this.DATAREAJUSTE = value;
            }
        }
        private int CODIGO_GTIN;
        public int CodigoGtin
        {
            get
            {
                return this.CODIGO_GTIN;

            }
            set
            {
                this.CODIGO_GTIN = value;
            }
        }
        private string PESO_BRUTO;
        public string PesoBruto
        {
            get
            {
                return this.PESO_BRUTO;

            }
            set
            {
                this.PESO_BRUTO = value;
            }
        }
        private string PESO_LIQUIDO;
        public string PesoLiquido
        {
            get
            {
                return this.PESO_LIQUIDO;

            }
            set
            {
                this.PESO_LIQUIDO = value;
            }
        }
        private DateTime PREVISAO_CHEGADA;
        public DateTime PrevisaoChegada
        {
            get
            {
                return this.PREVISAO_CHEGADA;

            }
            set
            {
                this.PREVISAO_CHEGADA = value;
            }
        }
        private string ORIGEM_PRODUTO;
        public string OrigemProduto
        {
            get
            {
                return this.ORIGEM_PRODUTO;

            }
            set
            {
                this.ORIGEM_PRODUTO = value;
            }
        }
        private int IDUNIDADE_PRODUTO;
        public int IdUnidadeProduto
        {
            get
            {
                return this.IDUNIDADE_PRODUTO;

            }
            set
            {
                this.IDUNIDADE_PRODUTO = value;
            }
        }
        private int ID_CST_ICMS;
        public int IdCstIcms
        {
            get
            {
                return this.ID_CST_ICMS;

            }
            set
            {
                this.ID_CST_ICMS = value;
            }
        }
        private int ID_CST_PIS;
        public int IdCstPis
        {
            get
            {
                return this.ID_CST_PIS;

            }
            set
            {
                this.ID_CST_PIS = value;
            }
        }
        private int ID_CST_COFINS;
        public int IdCstCofins
        {
            get
            {
                return this.ID_CST_COFINS;

            }
            set
            {
                this.ID_CST_COFINS = value;
            }
        }
        private int ID_CST_IP;
        public int IdCstIpi
        {
            get
            {
                return this.ID_CST_IP;

            }
            set
            {
                this.ID_CST_IP = value;
            }
        }
        private string VALOR_ICMS;
        public string ValorIcms
        {
            get
            {
                return this.VALOR_ICMS;

            }
            set
            {
                this.VALOR_ICMS = value;
            }
        }
        private string VALOR_PIS;
        public string ValorPis
        {
            get
            {
                return this.VALOR_PIS;

            }
            set
            {
                this.VALOR_PIS = value;
            }
        }
        private string VALOR_COFINS;
        public string ValorCofins
        {
            get
            {
                return this.VALOR_COFINS;

            }
            set
            {
                this.VALOR_COFINS = value;
            }
        }
        private string PRECO_MEDIO;
        public string PrecoMedio
        {
            get
            {
                return this.PRECO_MEDIO;

            }
            set
            {
                this.PRECO_MEDIO = value;
            }
        }
        private string DESCRICAO_CST_ICMS;
        public string DescricaoCstIcms
        {
            get
            {
                return this.DESCRICAO_CST_ICMS;

            }
            set
            {
                this.DESCRICAO_CST_ICMS = value;
            }
        }
        private string DESCRICAO_CST_PIS;
        public string DescricaoCstPis
        {
            get
            {
                return this.DESCRICAO_CST_PIS;

            }
            set
            {
                this.DESCRICAO_CST_PIS = value;
            }
        }
        private string DESCRICAO_CST_COFINS;
        public string DescricaoCofins
        {
            get
            {
                return this.DESCRICAO_CST_COFINS;

            }
            set
            {
                this.DESCRICAO_CST_COFINS = value;
            }
        }
        private string DESCRICAO_CST_IPI;
        public string DescricaoCstIpi
        {
            get
            {
                return this.DESCRICAO_CST_IPI;

            }
            set
            {
                this.DESCRICAO_CST_IPI = value;
            }
        }
        private string VALOR_IPI;
        public string ValorIpi
        {
            get
            {
                return this.VALOR_IPI;

            }
            set
            {
                this.VALOR_IPI = value;
            }
        }
        private int QUANTIDADE_COMPRADA;
        public int QuantComprada
        {
            get
            {
                return this.QUANTIDADE_COMPRADA;

            }
            set
            {
                this.QUANTIDADE_COMPRADA = value;
            }
        }
        private string DOCUMENTO;
        public string Documento
        {
            get
            {
                return this.DOCUMENTO;

            }
            set
            {
                this.DOCUMENTO = value;
            }
        }
        private DateTime DATA_FABRICACAO;
        public DateTime DataFabricacao
        {
            get
            {
                return this.DATA_FABRICACAO;

            }
            set
            {
                this.DATA_FABRICACAO = value;
            }
        }
        private DateTime DATA_VENCIMENTO;
        public DateTime DataVencimento
        {
            get
            {
                return this.DATA_VENCIMENTO;

            }
            set
            {
                this.DATA_VENCIMENTO = value;
            }
        }
        private DateTime DATA_SOLICITACAO;
        public DateTime DataSolicitacao
        {
            get
            {
                return this.DATA_SOLICITACAO;

            }
            set
            {
                this.DATA_SOLICITACAO = value;
            }
        }
        private String VALOR_TOTAL;
        public String ValorTotal
        {
            get
            {
                return this.VALOR_TOTAL;

            }
            set
            {
                this.VALOR_TOTAL = value;
            }
        }
        private DateTime DATA_CADASTRO;
        public DateTime DataCadastro
        {
            get
            {
                return this.DATA_CADASTRO;

            }
            set
            {
                this.DATA_CADASTRO = value;
            }
        }
        private DateTime DATA_ENTRADA_PRODUTO;
        public DateTime DataEntradaProduto
        {
            get
            {
                return this.DATA_ENTRADA_PRODUTO;

            }
            set
            {
                this.DATA_ENTRADA_PRODUTO = value;
            }
        }
        private int ADICIONAR_DATA_SOLICITACAO;
        public int AdicionarDataSolicitacao
        {
            get
            {
                return this.ADICIONAR_DATA_SOLICITACAO;

            }
            set
            {
                this.ADICIONAR_DATA_SOLICITACAO = value;
            }
        }
        private int ADICIONAR_DATA_FABRICACAO;
        public int AdicionarDataFabricacao
        {
            get
            {
                return this.ADICIONAR_DATA_FABRICACAO;

            }
            set
            {
                this.ADICIONAR_DATA_FABRICACAO = value;
            }
        }
        private int ADICIONAR_DATA_VENCIMENTO;
        public int AdicionarDataVencimento
        {
            get
            {
                return this.ADICIONAR_DATA_VENCIMENTO;

            }
            set
            {
                this.ADICIONAR_DATA_VENCIMENTO = value;
            }
        }
        private int ADICIONAR_DATA_ENTRADA;
        public int AdicionarDataEntrada 
        {
            get
            {
                return this.ADICIONAR_DATA_ENTRADA;

            }
            set
            {
                this.ADICIONAR_DATA_ENTRADA = value;
            }
        }
        private int ADICIONAR_DATA_COMPRA;
        public int AdicionarDataCompra
        {
            get
            {
                return this.ADICIONAR_DATA_COMPRA;

            }
            set
            {
                this.ADICIONAR_DATA_COMPRA = value;
            }
        }
        private int ADICIONAR_DATA_REAJUSTE;
        public int AdicionarDataReajuste 
        {
            get
            {
                return this.ADICIONAR_DATA_REAJUSTE;

            }
            set
            {
                this.ADICIONAR_DATA_REAJUSTE = value;
            }
        }
        private int ADICIONAR_DATA_PREVISAO_CHEGADA;
        public int AdicionarPrevisaoChegada
        {
            get
            {
                return this.ADICIONAR_DATA_PREVISAO_CHEGADA;

            }
            set
            {
                this.ADICIONAR_DATA_PREVISAO_CHEGADA = value;
            }
        }
        private int ADICIONAR_VALOR_TOTAL;
        public int AdicionarValorTotal
        {
            get
            {
                return this.ADICIONAR_VALOR_TOTAL;

            }
            set
            {
                this.ADICIONAR_VALOR_TOTAL = value;
            }
        }
        private int ADICIONAR_QUANTIDADE_ATUAL_ESTOQUE;
        public int AdicionarQuantidadeAtualEstoque
        {
            get
            {
                return this.ADICIONAR_QUANTIDADE_ATUAL_ESTOQUE;

            }
            set
            {
                this.ADICIONAR_QUANTIDADE_ATUAL_ESTOQUE = value;
            }
        }
    }
}