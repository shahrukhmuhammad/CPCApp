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
    
    public partial class CPCCity
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CPCCity()
        {
            this.CPCProjectBranches = new HashSet<CPCProjectBranch>();
            this.CPCUnsortedCashes = new HashSet<CPCUnsortedCash>();
            this.CPCVaultCustodians = new HashSet<CPCVaultCustodian>();
            this.CPCVaultConsolidateds = new HashSet<CPCVaultConsolidated>();
        }
    
        public System.Guid Id { get; set; }
        public string CityName { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CPCProjectBranch> CPCProjectBranches { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CPCUnsortedCash> CPCUnsortedCashes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CPCVaultCustodian> CPCVaultCustodians { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CPCVaultConsolidated> CPCVaultConsolidateds { get; set; }
    }
}
