//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PresentacionDesktop
{
    using System;
    using System.Collections.Generic;
    
    public partial class Mesas
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Mesas()
        {
            this.MesasPorSalon = new HashSet<MesasPorSalon>();
        }
    
        public int ID { get; set; }
        public string Mesa { get; set; }
        public int TipoMesa { get; set; }
        public byte CantidadPersonas { get; set; }
    
        public virtual MesasTipos MesasTipos { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MesasPorSalon> MesasPorSalon { get; set; }
    }
}