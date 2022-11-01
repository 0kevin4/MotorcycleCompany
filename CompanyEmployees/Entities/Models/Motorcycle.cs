using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Motorcycle
    { 
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Motorcycle NumBast is required field")]
        [MaxLength(20, ErrorMessage = "Maximun lenght for the NumBast is 20 characters")]
        public string NumBast { get; set; }

        [Required(ErrorMessage = "Motorcycle Color is required field")]
        [MaxLength(30, ErrorMessage = "Maximun lenght for the Color is 30 characters")]
        public string Color { get; set; }

        [Required(ErrorMessage = "Motorcycle Brand is required field")]
        [MaxLength(30, ErrorMessage = "Maximun lenght for the Brand is 30 characters")]
        public string Brand { get; set; }

        [Required(ErrorMessage = "Motorcycle model is required field")]
        [MaxLength(30, ErrorMessage = "Maximun lenght for the model is 30 characters")]
        public string model { get; set; }

        [Required(ErrorMessage = "Motorcycle IdCity is required field")]
        public int IdCity { get; set; }

        [Required(ErrorMessage = "Motorcycle Street is required field")]
        [MaxLength(30, ErrorMessage = "Maximun lenght for the Street is 30 characters")]
        public string Street { get; set; }

        [Required(ErrorMessage = "Motorcycle Num is required field")]
        public int Num { get; set; }

        [Required(ErrorMessage = "Motorcycle Date is required field")]
        public DateTime Date { get; set; }

        [Required(ErrorMessage = "Motorcycle IdAgency is required field")]        
        public int IdAgency { get; set; }

    }
}
