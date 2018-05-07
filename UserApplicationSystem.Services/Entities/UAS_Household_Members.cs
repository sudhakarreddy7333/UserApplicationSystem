//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UserApplicationSystem.Services.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class UAS_Household_Members
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public UAS_Household_Members()
        {
            this.UAS_Family_Relations = new HashSet<UAS_Family_Relations>();
        }
    
        public int HId { get; set; }
        public Nullable<int> UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public string Suffix { get; set; }
        public string Gender { get; set; }
        public System.DateTime Dob { get; set; }
        public string Relation { get; set; }
    
        public virtual UAS_User_Details UAS_User_Details { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UAS_Family_Relations> UAS_Family_Relations { get; set; }
    }
}
