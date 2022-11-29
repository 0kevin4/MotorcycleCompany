using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Contract
{
    public interface IMotorcycleService
    {
        IEnumerable<Motorcycle> GetAllMotorcycles(bool trackChanges);
    }
}
