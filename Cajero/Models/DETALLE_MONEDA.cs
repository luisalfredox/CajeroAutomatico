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
    
    public partial class DETALLE_MONEDA
    {
        public int ID_MONEDA_DETALLE { get; set; }
        public int BILLETE { get; set; }
        public int CANTIDAD { get; set; }
        public int ID_MAQUINA { get; set; }
    
        public virtual MAQUINA MAQUINA { get; set; }
    }
}
