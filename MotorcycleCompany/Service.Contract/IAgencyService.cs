using Entities.Models;
using Shared.DataTransferObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Contract
{
    public interface IAgencyService
    {
        //IEnumerable<Agency> GetAllAgencias(bool trackChanges);
        IEnumerable<AgencyDto> GetAllAgencias(bool trackChanges);
        AgencyDto GetAgencias(int Id, bool trackChanges);
    }
}
