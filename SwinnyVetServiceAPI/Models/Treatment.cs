//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SwinnyVetServiceAPI.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Treatment
    {
        public int TreatmentID { get; set; }
        public string PetName { get; set; }
        public int PetID { get; set; }
        public int OwnerID { get; set; }
        public int ProcedureID { get; set; }
        public System.DateTime Date { get; set; }
        public string Notes { get; set; }
        public decimal Price { get; set; }
    
        public virtual Owner Owner { get; set; }
        public virtual Pet Pet { get; set; }
        public virtual Procedure Procedure { get; set; }
    }
}
