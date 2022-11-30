using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DataTransferObject
{
    public record MotorcycleDto(string NumBast, string Color, string Brand, string model, string Street, int Num, DateTime Date);
}
