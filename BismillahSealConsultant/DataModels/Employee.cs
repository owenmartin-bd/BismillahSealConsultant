using System;
using System.Collections.Generic;

namespace BismillahSealConsultant.DataModels
{
    public partial class Employee
    {
        public Employee()
        {
            Degrees = new HashSet<Degree>();
            Docs = new HashSet<Doc>();
        }

        public Guid Id { get; set; }
        public string? IcPp { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? CurrentAddress { get; set; }
        public string? EmployeeCode { get; set; }
        public DateOnly? Dob { get; set; }
        public string? Cidb { get; set; }
        public string? Socso { get; set; }
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
        public Guid? RollId { get; set; }
        public DateOnly? CidbExpDate { get; set; }
        public bool? Active { get; set; }
        public DateOnly? LastWorkingDay { get; set; }
        public string? BankAcNo { get; set; }
        public string? Level { get; set; }
        public string? OtElecgibility { get; set; }
        public bool? Own { get; set; }
        public string? BankaccountNumber { get; set; }
        public string? BankName { get; set; }
        public string? Department { get; set; }
        public string? MysjId { get; set; }
        public string? Password { get; set; }

        public virtual ICollection<Degree> Degrees { get; set; }
        public virtual ICollection<Doc> Docs { get; set; }
    }
}
