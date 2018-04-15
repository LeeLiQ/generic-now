using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using uow_generic.Core.Domains;
using uow_generic.DataTransferObjects;
using uow_generic.Services.Interfaces;

namespace uow_generic.Controllers
{
    [Route("api/[controller]")]
    public class VehiclesController : Controller
    {
        private readonly IVehicleService _vehicleService;
        public VehiclesController(IVehicleService vehicleService)
        {
            _vehicleService = vehicleService;
        }

        [HttpGet("{id}")]
        public VehicleDto GetVehicleById(int id)
        {
            return _vehicleService.GetById(id);
        }

        [HttpGet("{vinNumber}")]
        public VehicleDto GetByVin(string vinNumber)
        {
            return _vehicleService.GetByVin(vinNumber);
        }

        [HttpGet]
        public IEnumerable<VehicleDto> GetAll()
        {
            return _vehicleService.GetAll();
        }

        [HttpPost]
        public Vehicle Insert(VehicleDto vehicleDto)
        {
            return _vehicleService.Insert(vehicleDto);
        }

        [HttpPut]
        public Vehicle Update(Vehicle vehicle)
        {
            return _vehicleService.Update(vehicle);
        }

        [HttpDelete("{id}")]
        public Vehicle Delete(int id)
        {
            return _vehicleService.Delete(id);
        }
    }
}