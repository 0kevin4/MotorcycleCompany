using Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class AgencyRepository : RepositoryBase<IAgency>, IAgency
    {
        public AgencyRepository(RepositoryContext context)
        : base(context)
        {

        }
    }
}
