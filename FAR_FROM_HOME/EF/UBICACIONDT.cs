//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FAR_FROM_HOME.EF
{
    using System;
    using System.Collections.Generic;
    
    public partial class UBICACIONDT
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public UBICACIONDT()
        {
            this.PUBLICACIONDT = new HashSet<PUBLICACIONDT>();
        }
    
        public int ID_UBICACION { get; set; }
        public string D_UBICACION { get; set; }
        public string D_ZONA { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PUBLICACIONDT> PUBLICACIONDT { get; set; }
    }
}
