using System;

namespace uow_generic.Core.Domains
{
    public class Vehicle : Auditable
    {
        public int VehicleId { get; set; }

        public DateTime ManufacturedOn { get; set; }

        public string Vin { get; set; }

        public bool IsRegistered { get; set; }
    }
}