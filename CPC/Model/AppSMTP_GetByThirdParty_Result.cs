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
    
    public partial class AppSMTP_GetByThirdParty_Result
    {
        public System.Guid Id { get; set; }
        public string Title { get; set; }
        public byte ServerType { get; set; }
        public string IncomingServer { get; set; }
        public string OutgoingServer { get; set; }
        public Nullable<int> IncomingPort { get; set; }
        public int OutgoingPort { get; set; }
        public bool SSL { get; set; }
        public string DefaultUsername { get; set; }
        public string DefaultPassword { get; set; }
        public string Description { get; set; }
        public Nullable<byte> ThirdParty { get; set; }
        public Nullable<bool> TLS { get; set; }
    }
}