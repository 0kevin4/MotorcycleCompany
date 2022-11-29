using Contracts;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    internal class MotorcycleRepository : RepositoryBase<Motorcycle>, IMotorcycle
    {
        public MotorcycleRepository(RepositoryContext context)
      : base(context)
        {

        }

        public IEnumerable<Motorcycle> GetAllMotorcycles(bool trackChanges)=>
            FindAll(trackChanges)
            .OrderBy(a => a.Id)
            .ToList();
    }
}
