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
    
    public partial class CertificateSettings_Select_Result
    {
        public System.Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public byte Impact { get; set; }
        public string AppliesTo { get; set; }
        public Nullable<byte> PerformAction { get; set; }
        public Nullable<bool> IsExpiryDate { get; set; }
    }
}