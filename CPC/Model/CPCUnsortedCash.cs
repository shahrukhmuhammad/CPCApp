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
        public string Station { get; set; }
        public string Client { get; set; }
        public Nullable<int> TotalNumberBundles { get; set; }
        public long TotalBalance { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public System.Guid CreatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedOn { get; set; }
        public Nullable<System.Guid> UpdatedBy { get; set; }
        public Nullable<byte> Status { get; set; }
        public bool IsActive { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CPCUnsortedCashDetail> CPCUnsortedCashDetails { get; set; }
    }
}