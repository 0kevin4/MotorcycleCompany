using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DataTransferObject
{
    public record RentDto(DateTime dateI, DateTime dateF, DateTime dateR, int Price, string Paidout);
}
