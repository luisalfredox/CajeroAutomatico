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
    
    public partial class MAQUINA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MAQUINA()
        {
            this.ATM_TRANSACTION = new HashSet<ATM_TRANSACTION>();
            this.DETALLE_MONEDA = new HashSet<DETALLE_MONEDA>();
        }
    
        public int ID_ATM_CD { get; set; }
        public int USER_ADMIN_CD { get; set; }
        public string ADDRESS_DESC { get; set; }
        public string TYPE_DISTINC_CASH_NM { get; set; }
        public int CASH_CANT_CNT { get; set; }
        public int BALANCE_AMT { get; set; }
        public string ESTATUS { get; set; }
    
        public virtual ADMINISTRADOR ADMINISTRADOR { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ATM_TRANSACTION> ATM_TRANSACTION { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DETALLE_MONEDA> DETALLE_MONEDA { get; set; }
    }
}