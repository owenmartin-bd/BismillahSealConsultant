using System;
using System.Collections.Generic;

namespace BismillahSealConsultant.DataModels
{
    public partial class ExtraEarn
    {
        public Guid Id { get; set; }
        public double? FoodAllowance { get; set; }
        public double? MobileAllowance { get; set; }
        public double? HouseAllowance { get; set; }
        public double? NightWorkAllowance { get; set; }
        public double? OtherAllowance { get; set; }
        public Guid? EmployeeId { get; set; }
        public DateOnly? Date { get; set; }
    }
}
