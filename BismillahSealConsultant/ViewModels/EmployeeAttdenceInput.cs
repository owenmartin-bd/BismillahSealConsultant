namespace BismillahSealConsultant.ViewModels
{
    public class EmployeeAttdenceInput
    {
        public Guid EmployeeID { get; set; }
        public string EmployeeName { get; set; }
        public string EmployeeCode { get; set; }

        public DateTime? intime { get; set; }
        
        public DateTime? outtime { get; set; }
    }
}
