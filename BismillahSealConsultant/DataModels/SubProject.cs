using System;
using System.Collections.Generic;

namespace BismillahSealConsultant.DataModels
{
    public partial class SubProject
    {
        public Guid Id { get; set; }
        public Guid? ProjectId { get; set; }
        public Guid? SubprojectId { get; set; }
    }
}
