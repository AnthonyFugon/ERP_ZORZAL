//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ERP_ZORZAL.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbProductoSubcategoria
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbProductoSubcategoria()
        {
            this.tbProducto = new HashSet<tbProducto>();
        }
    
        public int pscat_Id { get; set; }
        public string pscat_Descripcion { get; set; }
        public int pcat_Id { get; set; }
        public byte estm_Id { get; set; }
        public int pscat_UsuarioCrea { get; set; }
        public System.DateTime pscat_FechaCrea { get; set; }
        public Nullable<int> pscat_UsuarioModifica { get; set; }
        public Nullable<System.DateTime> pscat_FechaModifica { get; set; }
    
        public virtual tbEstadoMovimiento tbEstadoMovimiento { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbProducto> tbProducto { get; set; }
        public virtual tbProductoCategoria tbProductoCategoria { get; set; }
    }
}
