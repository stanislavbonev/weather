using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TemperatureMicroservice.Models;

namespace TemperatureMicroservice.Repository
{
    public interface ITemperatureRepository
    {
        IEnumerable<Temperature> GetTemperatures();
        Temperature GetTemperatureByID(int TemperatureID);
        void InsertTemperature(Temperature Temperature);
        void DeleteTemperature(int TemperatureId);
        void UpdateTemperature(Temperature Temperature);
        void Save();
    }
}