//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace StageApplicatie.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Bedrijf
    {
        public Bedrijf()
        {
            this.Persoonsgegevens = new HashSet<Persoonsgegevens>();
        }
    
        public int BedrijfID { get; set; }
        public string Naam { get; set; }
        public bool Actief { get; set; }
        public string NonActiefReden { get; set; }
    
        public virtual ICollection<Persoonsgegevens> Persoonsgegevens { get; set; }
    }
}
