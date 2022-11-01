using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Phones
    {
        [Key]
        public int IdAgency { get; set; }

        [Key]
        public int phone { get; set; }
    }
}
