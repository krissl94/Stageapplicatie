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
    
    public partial class RedenStudent
    {
        public RedenStudent()
        {
            this.TussentijdseBeindeging = new HashSet<TussentijdseBeindeging>();
        }
    
        public int RedenID { get; set; }
        public string Reden { get; set; }
    
        public virtual ICollection<TussentijdseBeindeging> TussentijdseBeindeging { get; set; }
    }
}
