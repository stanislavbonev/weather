using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PressureMicroservice.Models;
using Microsoft.EntityFrameworkCore;
using PressureMicroservice.DBContexts;

namespace PressureMicroservice.Repository
{
    public class PressureRepository : IPressureRepository
    { 
        private readonly PressureContext _dbContext;
        public PressureRepository(PressureContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void DeletePressure(int pressureId)
        {
            var pressure = _dbContext.Pressures.Find(pressureId);
            _dbContext.Pressures.Remove(pressure);
            Save();
        }
        public Pressure GetPressureByID(int pressureId)
        {
            return _dbContext.Pressures.Find(pressureId);
        }
        public IEnumerable<Pressure> GetPressures()
        {
            return _dbContext.Pressures.ToList();
        }

        public Pressure GetPresureByID(int PressureID)
        {
            throw new NotImplementedException();
        }

        public void InsertPressure(Pressure pressure)
        {
            _dbContext.Add(pressure);
            Save();
        }
        public void Save()
        {
            _dbContext.SaveChanges();
        }
        public void UpdatePressure(Pressure pressure)
        {
            _dbContext.Entry(pressure).State = EntityState.Modified;
            Save();
        }

        public void UpdatePresure(Pressure Pressure)
        {
            throw new NotImplementedException();
        }
    }
}

