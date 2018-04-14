using System;

namespace uow_generic.DataTransferObjects
{
    public class VehicleDto
    {
        public DateTime ManufacturedOn { get; set; }

        public string Vin { get; set; }

        public bool IsRegistered { get; set; }

        public string NickName { get; set; }
    }
}