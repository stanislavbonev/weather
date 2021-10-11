using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TemperatureMicroservice.Models;
using TemperatureMicroservice.Repository;
using System.Transactions;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TemperatureMicroservice.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]
    public class TemperatureController : ControllerBase
    {
        private readonly ITemperatureRepository _temperatureRepository;

        public TemperatureController(ITemperatureRepository temperatureRepository)
        {
            _temperatureRepository = temperatureRepository;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var temperature = _temperatureRepository.GetTemperatures();
            return new OkObjectResult(temperature);
        }

       /* [HttpGet("{id}", Name = "Get")]
        public IActionResult Get(int id)
        {
            var pressure = _temperatureRepository.GetTemperatureByID(id);
            return new OkObjectResult(pressure);
        }

        [HttpPost]
        public IActionResult Post([FromBody] Temperature temperature)
        {
            using (var scope = new TransactionScope())
            {
                _temperatureRepository.InsertTemperature(temperature);
                scope.Complete();
                return CreatedAtAction(nameof(Get), new { id = temperature.Id }, temperature);
            }
        }

        [HttpPut]
        public IActionResult Put([FromBody] Temperature temperature)
        {
            if (temperature != null)
            {
                using (var scope = new TransactionScope())
                {
                    _temperatureRepository.UpdateTemperature(temperature);
                    scope.Complete();
                    return new OkResult();
                }
            }
            return new NoContentResult();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _temperatureRepository.DeleteTemperature(id);
            return new OkResult();
        }*/
    }
}
