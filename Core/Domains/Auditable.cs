using System;

namespace uow_generic.Core.Domains
{
    public class Auditable
    {
        public int CreatedBy { get; set; }

        public DateTime? CreatedDate { get; set; }

        public int ModifiedBy { get; set; }

        public DateTime? ModifiedDate { get; set; }
    }
}