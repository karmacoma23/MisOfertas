//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LoginOfertas3.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class SUB_PRODUCTO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SUB_PRODUCTO()
        {
            this.CAT_PRODUCT = new HashSet<CAT_PRODUCT>();
        }
    
        public decimal SUB_ID { get; set; }
        public string SUB_NOMBRE { get; set; }
        public decimal CAT_ID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CAT_PRODUCT> CAT_PRODUCT { get; set; }
    }
}