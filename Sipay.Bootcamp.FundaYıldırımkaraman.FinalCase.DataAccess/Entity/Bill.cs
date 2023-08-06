using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sipay.Bootcamp.FundaYıldırımkaraman.FinalCase.DataAccess.Entity
{
    public class Bill
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int ApartmentId { get; set; }

        [Required]
        public decimal AidAmount { get; set; }

        [Required]
        public decimal ElectricityAmount { get; set; }

        [Required]
        public decimal WaterAmount { get; set; }

        [Required]
        public decimal GasAmount { get; set; }

        [Required]
        public DateTime DueDate { get; set; }

        public virtual User User { get; set; }
        public virtual Apartment Apartment { get; set; }
        public virtual User UserId { get; set; }
    }
}
