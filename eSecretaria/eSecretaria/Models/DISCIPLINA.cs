//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace eSecretaria.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class DISCIPLINA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DISCIPLINA()
        {
            this.PROFESSOR = new HashSet<PROFESSOR>();
        }
    
        public int ID_DISCIPLINA { get; set; }
        public string NOME_DISCIPLINA { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PROFESSOR> PROFESSOR { get; set; }
    }
}
