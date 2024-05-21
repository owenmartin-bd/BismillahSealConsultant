using Microsoft.AspNetCore.Mvc.RazorPages;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using System.Xml.Linq;

namespace BismillahSealConsultant.DataModels
{
    public class DitchpatchFieldsViewModel
    {
        public Employee employee { get; set; }
        public double? TotalAmount { get; set; }
        public double? CompanyCost { get; set; }
        public bool ActualAmountEnabled { get; set; }
        public double? ActualAmount { get; set; }
        public double? CurrentBalance { get; set; }
        public double? Totaladvancetaken { get; set; }
        public double? AdvancePayedBack { get; set; }
        public double? AdvanceBalance { get; set; }
        public double? ActualDispatch { get; set; }

    }
}
