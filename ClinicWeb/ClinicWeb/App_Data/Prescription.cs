//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClinicWeb.App_Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class Prescription
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Prescription()
        {
            this.Invoice = new HashSet<Invoice>();
            this.Prescription_Detail = new HashSet<Prescription_Detail>();
        }
    
        public int id { get; set; }
        public Nullable<int> patient_id { get; set; }
        public Nullable<int> doctor_id { get; set; }
        public Nullable<int> appointment_id { get; set; }
        public string conclusion { get; set; }
        public Nullable<System.DateTime> created_date { get; set; }
    
        public virtual Appointment Appointment { get; set; }
        public virtual Doctor Doctor { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Invoice> Invoice { get; set; }
        public virtual Patient Patient { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Prescription_Detail> Prescription_Detail { get; set; }
    }
}
