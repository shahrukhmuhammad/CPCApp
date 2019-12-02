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
    
    public partial class CPCUnsortedCash
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CPCUnsortedCash()
        {
            this.CPCUnsortedCashDetails = new HashSet<CPCUnsortedCashDetail>();
        }
    
        public System.Guid Id { get; set; }
        public long SerialNumber { get; set; }
        public System.DateTime Date { get; set; }
        public System.Guid CityId { get; set; }
        public System.Guid ProjectBranchId { get; set; }
        public Nullable<int> TotalNumberBundles { get; set; }
        public long TotalBalance { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public System.Guid CreatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedOn { get; set; }
        public Nullable<System.Guid> UpdatedBy { get; set; }
        public Nullable<byte> Status { get; set; }
        public bool IsActive { get; set; }
        public Nullable<int> OrderNumber { get; set; }
        public Nullable<System.Guid> OrderBookingId { get; set; }
    
        public virtual CPCCity CPCCity { get; set; }
        public virtual CPCOrderBooking CPCOrderBooking { get; set; }
        public virtual CPCProjectBranch CPCProjectBranch { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CPCUnsortedCashDetail> CPCUnsortedCashDetails { get; set; }
    }
}
