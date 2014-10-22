//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataLayer.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class TussentijdseBeindeging
    {
        public TussentijdseBeindeging()
        {
            this.RedenOnderwijsinstelling = new HashSet<RedenOnderwijsinstelling>();
            this.RedenOrganisatie = new HashSet<RedenOrganisatie>();
            this.RedenStudent = new HashSet<RedenStudent>();
        }
    
        public int TussentijdsebeoordelingID { get; set; }
        public int Stage { get; set; }
        public System.DateTime Einddatum { get; set; }
        public string CREBO { get; set; }
        public int Leerweg { get; set; }
    
        public virtual Stage Stage1 { get; set; }
        public virtual ICollection<RedenOnderwijsinstelling> RedenOnderwijsinstelling { get; set; }
        public virtual ICollection<RedenOrganisatie> RedenOrganisatie { get; set; }
        public virtual ICollection<RedenStudent> RedenStudent { get; set; }
    }
}
