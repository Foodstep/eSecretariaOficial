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
    
    public partial class ALUNO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ALUNO()
        {
            this.AULA = new HashSet<AULA>();
        }
    
        public int ID_ALUNO { get; set; }
        public string NOME_ALUNO { get; set; }
        public string NOME_RESPONSAVEL { get; set; }
        public string TELEFONE_CONTATO { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AULA> AULA { get; set; }
    }
}
