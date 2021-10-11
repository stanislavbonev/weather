using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PressureMicroservice.Models;

namespace PressureMicroservice.Repository
{
     public interface IPressureRepository
    {
        IEnumerable<Pressure> GetPressures();
        Pressure GetPresureByID(int PressureID);
        void InsertPressure(Pressure Pressure);
        void DeletePressure(int PressureId);
        void UpdatePresure(Pressure Pressure);
        void Save();
    }
}