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
    
    public partial class tbCaja1
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbCaja1()
        {
            this.tbArqueoCaja = new HashSet<tbArqueoCaja>();
        }
    
        public short cja_Id { get; set; }
        public string cja_Descripcion { get; set; }
        public short suc_Id { get; set; }
        public int cja_UsuarioCrea { get; set; }
        public System.DateTime cja_FechaCrea { get; set; }
        public Nullable<int> cja_UsuarioModifica { get; set; }
        public Nullable<System.DateTime> cja_FechaModifica { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbArqueoCaja> tbArqueoCaja { get; set; }
        public virtual tbSucursal tbSucursal { get; set; }
    }
}
