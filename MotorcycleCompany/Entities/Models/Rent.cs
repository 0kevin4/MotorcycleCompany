using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Rent
    {

        [Key]
        public int Id { get; set; }

        public int IdMotorcycle { get; set; }

        public int IdAgency { get; set; }

        [MaxLength(9, ErrorMessage = "Maximun lenght for the DNIClient is 9 characters")]
        public string DNIClient { get; set; }

        public DateTime dateI { get; set; }

        public DateTime dateF { get; set; }

        public DateTime dateR { get; set; }

        public int Price { get; set; }

        public string Paidout { get; set; }


       

        [ForeignKey("DNIClient")]
        [InverseProperty("Rent")]
        public  Client Client { get; set; }


        [ForeignKey("IdAgency")]
        [InverseProperty("Rent")]
        public  Agency Agency { get; set; }

        [ForeignKey("IdMotorcycle")]
        [InverseProperty("Rent")]
        public Motorcycle Motorcycle { get; set; }

    }
}
