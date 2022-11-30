using Entities.Models;
using Shared.DataTransferObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Contract
{
    public interface ICityService
    {
        IEnumerable<CityDto> GetAllAgencias(bool trackChanges);
    }
}
