//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CRM.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class NewRequests
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NewRequests()
        {
            this.Step = new HashSet<Step>();
        }
    
        public int Id { get; set; }
        public string Request { get; set; }
        public string Status { get; set; }
        public Nullable<CRM.Core.TypeCodes.PriorityType> Priority { get; set; }
        public string RequestorName { get; set; }
        public string AssignTo { get; set; }
        public Nullable<System.DateTime> StartingDate { get; set; }
        public Nullable<System.DateTime> Deadline { get; set; }
        public string WorkSteps { get; set; }
        public Nullable<bool> Checked { get; set; }
        public string Description { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Step> Step { get; set; }
    }
}
