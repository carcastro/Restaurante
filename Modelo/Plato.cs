//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Modelo
{
    using System;
    using System.Collections.Generic;
    
    public partial class Plato
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Plato()
        {
            this.Pedidos = new HashSet<Pedido>();
        }
    
        public int ID { get; set; }
        public string NombrePlato { get; set; }
        public int TipoPlato { get; set; }
        public int Cheff { get; set; }
        public System.TimeSpan TiempoPreparacion { get; set; }
        public string RutaFoto { get; set; }
    
        public virtual Cheff Cheff1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Pedido> Pedidos { get; set; }
        public virtual PlatosTipos PlatosTipos { get; set; }
    }
}
