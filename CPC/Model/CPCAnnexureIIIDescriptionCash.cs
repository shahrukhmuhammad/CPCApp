//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CPC.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class CPCAnnexureIIIDescriptionCash
    {
        public System.Guid Id { get; set; }
        public Nullable<System.Guid> CPCAnnexureIIId { get; set; }
        public Nullable<System.Guid> CPCDenominationsId { get; set; }
        public Nullable<int> UnsortedCashCollected { get; set; }
        public Nullable<int> FITReIssuable { get; set; }
        public Nullable<int> UnfitSoiled { get; set; }
        public Nullable<int> MismatchDefacedZeroValue { get; set; }
        public Nullable<int> CounterfeitNotes { get; set; }
        public Nullable<int> NetExcess { get; set; }
        public Nullable<int> NetShortage { get; set; }
        public Nullable<int> TotalCashReturned { get; set; }
        public Nullable<int> NumberOfBundles { get; set; }
        public Nullable<int> Value { get; set; }
    }
}
