//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cajero.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class ADMINISTRADOR
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ADMINISTRADOR()
        {
            this.MAQUINAs = new HashSet<MAQUINA>();
        }
    
        public int USER_ADMIN_CD { get; set; }
        public string USER_ADMIN_NM { get; set; }
        public int ADMIN_PASSWORD_CD { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MAQUINA> MAQUINAs { get; set; }
    }
}
