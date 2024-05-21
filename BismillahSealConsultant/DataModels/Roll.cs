using System;
using System.Collections.Generic;

namespace BismillahSealConsultant.DataModels
{
    public partial class Roll
    {
        public Roll()
        {
            Accesses = new HashSet<Access>();
        }

        public Guid Id { get; set; }
        public string? Name { get; set; }
        public bool? Isactive { get; set; }
        public Guid? LevelId { get; set; }

        public virtual ICollection<Access> Accesses { get; set; }
    }
}
