using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    public interface IAgency
    {
        IEnumerable<Agency> GetAllAgencias(bool trackChanges);
        Agency GetAgencias(int Id, bool trackChanges);
    }
}
