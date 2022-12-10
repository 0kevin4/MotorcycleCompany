using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Exceptions
{
    public sealed class AgencyNotFoundException : NotFoundException
    {
        public AgencyNotFoundException(int Id) 
            : base($"The Agency With Id:{Id} doesn´t exist in the Database")
        {
        }
    }
}
