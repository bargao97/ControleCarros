//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SistemaControleCarrosVanderson.Database
{
    using System;
    using System.Collections.Generic;
    
    public partial class CARROS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CARROS()
        {
            this.SERVICOS = new HashSet<SERVICOS>();
        }
    
        public int IDCARRO { get; set; }
        public string PLACA { get; set; }
        public Nullable<int> ANO { get; set; }
        public Nullable<int> FABRICANTE { get; set; }
        public Nullable<int> MARCA { get; set; }
    
        public virtual FABRICANTE FABRICANTE1 { get; set; }
        public virtual MARCA MARCA1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SERVICOS> SERVICOS { get; set; }
    }
}
