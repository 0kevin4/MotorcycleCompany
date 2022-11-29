using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Contract
{
    public interface IPhonesServices
    {
        IEnumerable<Phones> GetAllPhones(bool trackChanges);
    }
}
