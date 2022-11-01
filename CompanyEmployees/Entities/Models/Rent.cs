using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Rent
    {
        public int IdMotorcycle { get; set; }

        public int IdAgency { get; set; }

        public string DNIClient { get; set; }

        public DateTime dateI { get; set; }

        public DateTime dateF { get; set; }

        public DateTime dateR { get; set; }

        public int Price { get; set; }

        public string paidout { get; set; }



    }
}
