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
    
    public partial class Vew_CPCAnnexureI
    {
        public System.Guid Id { get; set; }
        public Nullable<int> SrNo { get; set; }
        public System.DateTime DateOfCollection { get; set; }
        public Nullable<System.Guid> CashHandedOverCPCStaffAId { get; set; }
        public Nullable<System.Guid> CashHandedOverCPCStaffBId { get; set; }
        public Nullable<System.Guid> CashHandedOverCITStaffAId { get; set; }
        public Nullable<System.Guid> CashHandedOverCITStaffBId { get; set; }
        public Nullable<System.Guid> SignatureCPCHandingOverCashAId { get; set; }
        public Nullable<System.Guid> SignatureCPCHandingOverCashBId { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public System.Guid CreatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedOn { get; set; }
        public Nullable<System.Guid> UpdatedBy { get; set; }
        public System.Guid CPCAnnexureIDetailsId { get; set; }
        public Nullable<System.Guid> CashProcessingCellId { get; set; }
        public string CashProcessingCellTitle { get; set; }
        public Nullable<System.Guid> ProjectBranchId { get; set; }
        public string BranchCode { get; set; }
        public string BranchName { get; set; }
        public Nullable<System.Guid> DenominationId { get; set; }
        public Nullable<int> DenominationTitle { get; set; }
        public Nullable<int> NoOfBundles { get; set; }
        public Nullable<int> TotalAmount { get; set; }
        public string SealNo { get; set; }
        public string ShipmentReciptNo { get; set; }
        public string CashHandedOverCPCStaffAName { get; set; }
        public string CashHandedOverCPCStaffBName { get; set; }
        public string CashHandedOverCITStaffAName { get; set; }
        public string CashHandedOverCITStaffBName { get; set; }
        public string SignatureCPCHandingOverCashAName { get; set; }
        public string SignatureCPCHandingOverCashBName { get; set; }
        public bool IsActive { get; set; }
    }
}
