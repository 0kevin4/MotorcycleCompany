using Contracts;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Repository
{
    public class AgencyRepository : RepositoryBase<Agency>, IAgency
    {
        public AgencyRepository(RepositoryContext context)
        : base(context)
        {

        }

        public IEnumerable<Agency> GetAllAgencias(bool trackChanges) =>
            FindAll(trackChanges).Include("Motorcycle_Agency")
            .OrderBy(a => a.Name)
            .ToList();
       
    }
}
