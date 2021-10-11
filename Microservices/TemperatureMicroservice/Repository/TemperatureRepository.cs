using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TemperatureMicroservice.Models;
using Microsoft.EntityFrameworkCore;
using TemperatureMicroservice.DBContexts;

namespace TemperatureMicroservice.Repository
{
    public class TemperatureRepository : ITemperatureRepository
    {
        private readonly TemperatureContext _dbContext;
        public TemperatureRepository(TemperatureContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void DeleteTemperature(int temperatureId)
        {
            var temperature = _dbContext.Temperatures.Find(temperatureId);
            _dbContext.Temperatures.Remove(temperature);
            Save();
        }
        public Temperature GetTemperatureByID(int temperatureId)
        {
            return _dbContext.Temperatures.Find(temperatureId);
        }
        public IEnumerable<Temperature> GetTemperatures()
        {
            return _dbContext.Temperatures.ToList();
        }

        

        public void InsertTemperature(Temperature temperature)
        {
            _dbContext.Add(temperature);
            Save();
        }
        public void Save()
        {
            _dbContext.SaveChanges();
        }
        public void UpdateTemperature(Temperature temperature)
        {
            _dbContext.Entry(temperature).State = EntityState.Modified;
            Save();
        }

        
    }
}
