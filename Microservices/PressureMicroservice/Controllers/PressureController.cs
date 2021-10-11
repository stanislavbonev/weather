using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PressureMicroservice.Models;
using PressureMicroservice.Repository;
using System.Transactions;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PressureMicroservice.Controllers
{
    [Produces("application/xml")]
    [Route("api/[controller]")]
    [ApiController]
    public class PressureController : ControllerBase
    {
        private readonly IPressureRepository _pressureRepository;

        public PressureController(IPressureRepository pressureRepository)
        {
            _pressureRepository = pressureRepository;
        }

        [HttpGet]
        public  IActionResult Get()
        {
            var pressure = _pressureRepository.GetPressures();
            return new OkObjectResult(pressure);
        }

        /*[HttpGet("{id}", Name = "Get")]
        public IActionResult Get(int id)
        {
            var pressure = _pressureRepository.GetPresureByID(id);
            return new OkObjectResult(pressure);
        }

        [HttpPost]
        public IActionResult Post([FromBody] Pressure pressure)
        {
            using (var scope = new TransactionScope())
            {
                _pressureRepository.InsertPressure(pressure);
                scope.Complete();
                return CreatedAtAction(nameof(Get), new { id = pressure.Id }, pressure);
            }
        }

        [HttpPut]
        public IActionResult Put([FromBody] Pressure pressure)
        {
            if (pressure != null)
            {
                using (var scope = new TransactionScope())
                {
                    _pressureRepository.UpdatePresure(pressure);
                    scope.Complete();
                    return new OkResult();
                }
            }
            return new NoContentResult();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _pressureRepository.DeletePressure(id);
            return new OkResult();
        }*/
    }
}
