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
    
    public partial class P_Estado
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public P_Estado()
        {
            this.P_Cidade = new HashSet<P_Cidade>();
        }
    
        public int ID_ESTADO { get; set; }
        public string SIGLA_ESTADO { get; set; }
        public string NOME { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<P_Cidade> P_Cidade { get; set; }
    }
}
