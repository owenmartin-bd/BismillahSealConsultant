namespace BismillahSealConsultant.DataModels
{
    public class HourRate
    {
        public double Rate { get; set; }
        public TimeSpan? Hours { get; set; }

        public double Total { get; set; }

        public double MonthlyTotal { get; set; }

        public double Epf { get; set; }

        public double Sosco { get; set; }

        public double? site_advance { get; set; }

        public double? Levy { get; set; }

        public double? Probash_deposit { get; set; }

        public double? Probash_loan { get; set; }

        public double? office_advance { get; set; }

        public double? previous_loan { get; set; }

        public double? PPE { get; set; }

        public double? others { get; set; }

        public double? Penalty { get; set; }

        public double? Food_allowance { get; set; }

        public double? Mobile_allowance { get; set; }

        public double? House_allowance { get; set; }

        public double? Night_work_allowance { get; set; }

        public double? Other_allowance { get; set; }


        public double? GrandTotal { get; set; }





    }
}
