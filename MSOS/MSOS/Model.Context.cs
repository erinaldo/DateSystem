﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MSOS
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class MSOSEntities : DbContext
    {
        public MSOSEntities()
            : base("name=MSOSEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<C_Compra> C_Compra { get; set; }
        public virtual DbSet<F_FornecedoresContatos> F_FornecedoresContatos { get; set; }
        public virtual DbSet<F_FornecedorPessoa> F_FornecedorPessoa { get; set; }
        public virtual DbSet<G_Tecnicos> G_Tecnicos { get; set; }
        public virtual DbSet<O_OrdemServico> O_OrdemServico { get; set; }
        public virtual DbSet<O_Servico> O_Servico { get; set; }
        public virtual DbSet<P_Cidade> P_Cidade { get; set; }
        public virtual DbSet<P_ClientePessoa> P_ClientePessoa { get; set; }
        public virtual DbSet<P_Estado> P_Estado { get; set; }
        public virtual DbSet<P_Fisica> P_Fisica { get; set; }
        public virtual DbSet<P_Juridica> P_Juridica { get; set; }
        public virtual DbSet<P_PessoaContatos> P_PessoaContatos { get; set; }
        public virtual DbSet<P_Produto> P_Produto { get; set; }
        public virtual DbSet<P_ProdutoGrupo> P_ProdutoGrupo { get; set; }
        public virtual DbSet<P_ProdutoMarca> P_ProdutoMarca { get; set; }
        public virtual DbSet<V_Venda> V_Venda { get; set; }
    }
}
