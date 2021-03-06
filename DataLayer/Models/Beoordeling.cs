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
    
    public partial class Beoordeling
    {
        public int BeoordelingID { get; set; }
        public int Stage { get; set; }
        public System.DateTime Datum { get; set; }
        public int Beoordeling1 { get; set; }
        public int VoorbereidWerk { get; set; }
        public string VoorbereidWerkOpm { get; set; }
        public int PlanEnOrganiserenWerk { get; set; }
        public string PlanEnOrganiserenWerkOpm { get; set; }
        public int TheoretischInzicht { get; set; }
        public string TheoretischInzichtOpm { get; set; }
        public int KwalGeleverdWerk { get; set; }
        public string KwalGeleverdWerkOpm { get; set; }
        public int RapportWerk { get; set; }
        public string RapportWerkOpm { get; set; }
        public int HoudtBedrRegels { get; set; }
        public string HoudtBedrRegelsOpm { get; set; }
        public int HoudtARBORegels { get; set; }
        public string HoudtARBORegelsOpm { get; set; }
        public int WerkTempo { get; set; }
        public string WerkTempoOpm { get; set; }
        public int BeoordelingTechAspect { get; set; }
        public string BeoordelingTechAspectOpm { get; set; }
        public int VerloopEersteContact { get; set; }
        public string VerloopEersteContactOpm { get; set; }
        public int HoudingTAVCollegas { get; set; }
        public string HoudingTAVCollegasOpm { get; set; }
        public int HoudingTAVLeiding { get; set; }
        public string HoudingTAVLeidingOpm { get; set; }
        public int HoudingTAVDerden { get; set; }
        public string HoudingTAVDerdenOpm { get; set; }
        public int OmgaanKritiek { get; set; }
        public string OmgaanKritiekOpm { get; set; }
        public int OpTijd { get; set; }
        public string OpTijdOpm { get; set; }
        public int ToontInitiatief { get; set; }
        public string ToontInitiatiefOpm { get; set; }
        public int Inzet { get; set; }
        public string IntzetOpm { get; set; }
        public int ToontBelangstellingVak { get; set; }
        public string ToontBelangstellingVakOpm { get; set; }
        public int GrenzenAangeven { get; set; }
        public string GrenzenAangevenOpm { get; set; }
        public int KomtAfsprakenNa { get; set; }
        public string KomtAfsprakenNaOpm { get; set; }
        public int ZelfstandigWerken { get; set; }
        public string ZelfstandigWerkenOpm { get; set; }
        public int Gemotiveerd { get; set; }
        public string GemotiveerdOpm { get; set; }
        public int HoudingsAspecten { get; set; }
        public string HoudingAspectenOpm { get; set; }
        public int Verslag { get; set; }
        public string VerslagOpm { get; set; }
        public byte[] HandtekeningDocent { get; set; }
        public byte[] HandtekeningStudent { get; set; }
        public byte[] HandtekeningBegeleider { get; set; }
        public bool EindBeoordeling { get; set; }
    
        public virtual Stage Stage1 { get; set; }
    }
}
