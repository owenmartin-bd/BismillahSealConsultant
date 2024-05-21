using System;
using System.Collections.Generic;

namespace BismillahSealConsultant.DataModels
{
    public partial class Viewemployee
    {
        public Guid? Id { get; set; }
        public string? IcPp { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Name { get; set; }
        public string? CurrentAddress { get; set; }
        public string? EmployeeCode { get; set; }
        public DateOnly? Dob { get; set; }
        public string? Cidb { get; set; }
        public string? Epf { get; set; }
        public DateOnly? JoiningDate { get; set; }
        public string? TaxNumber { get; set; }
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
        public DateOnly? VisaExp { get; set; }
        public DateOnly? CidbExpDate { get; set; }
        public Guid? RollId { get; set; }
    }
}
