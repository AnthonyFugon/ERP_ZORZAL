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
    
    public partial class tbMoneda
    {
        public short mnda_Id { get; set; }
        public string mnda_Iso { get; set; }
        public string mnda_Nombre { get; set; }
        public int mnda_UsuarioCrea { get; set; }
        public System.DateTime mnda_FechaCrea { get; set; }
        public Nullable<int> mnda_UsuarioModifica { get; set; }
        public Nullable<System.DateTime> mnda_FechaModifica { get; set; }
    }
}
