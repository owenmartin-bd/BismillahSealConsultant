using System;
using System.Collections.Generic;

namespace BismillahSealConsultant.DataModels
{
    public partial class WorkerReqSkill
    {
        public Guid Id { get; set; }
        public Guid? WorkerReqId { get; set; }
        public Guid? SkillId { get; set; }
    }
}
