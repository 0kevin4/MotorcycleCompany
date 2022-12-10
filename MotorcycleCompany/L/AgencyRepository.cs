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

        public Agency GetAgencias(int Id, bool trackChanges) =>
            FindByCondition(K => K.Id.Equals(Id), trackChanges).SingleOrDefault();
        

        public IEnumerable<Agency> GetAllAgencias(bool trackChanges) =>
            FindAll(trackChanges)
            .OrderBy(a => a.Name)
            .ToList();
       
    }
}
