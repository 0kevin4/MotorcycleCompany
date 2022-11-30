using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DataTransferObject
{
    public record ClientDto(string Name, string Surname, string SecondSurname, string Direction, string City, string Phone);
}
