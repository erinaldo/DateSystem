//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DateSystem
{
    using System;
    using System.Collections.Generic;
    
    public partial class F_FornecedorPessoa
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public F_FornecedorPessoa()
        {
            this.P_Produto = new HashSet<P_Produto>();
        }
    
        public int ID_FORNECEDOR { get; set; }
        public Nullable<int> ID_CONTATOF { get; set; }
        public string NOME { get; set; }
        public string NOME_CONTATO { get; set; }
        public string CARGO_CONTATO { get; set; }
        public string ENDERECO { get; set; }
        public string CIDADE { get; set; }
        public string UF { get; set; }
        public string TELEFONE { get; set; }
        public string TELEFONE2 { get; set; }
        public string FAX_TELEFONE { get; set; }
        public string TELEX_TELEFONE { get; set; }
        public string SITUACAO { get; set; }
        public string BAIRRO { get; set; }
        public string EMAIL { get; set; }
        public string CEP { get; set; }
        public string OBSERVACAO { get; set; }
        public string TIPO { get; set; }
        public string CP_MUNICIPIO { get; set; }
        public string MUNICIPIO { get; set; }
        public string PAIS { get; set; }
        public string DESC_PAIS { get; set; }
        public string NIVEL { get; set; }
    
        public virtual F_FornecedoresContatos F_FornecedoresContatos { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<P_Produto> P_Produto { get; set; }
    }
}
