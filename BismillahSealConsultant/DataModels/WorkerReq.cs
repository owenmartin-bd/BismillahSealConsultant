using System;
using System.Collections.Generic;

namespace BismillahSealConsultant.DataModels
{
    public partial class WorkerReq
    {
        public Guid Id { get; set; }
        public string? IcPp { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? CurrentAddress { get; set; }
        public DateOnly? Dob { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public string? EmergencyContact { get; set; }
        public string? EmerhencyContactName { get; set; }
        public string? EmergengyContactRelation { get; set; }
        public string? Nationality { get; set; }
        public string? PemanantAddress { get; set; }
        public string? Remark { get; set; }
        public string? Photo { get; set; }
        public DateTime? EntryCreated { get; set; }
        public DateOnly? PassExp { get; set; }
    }
}
