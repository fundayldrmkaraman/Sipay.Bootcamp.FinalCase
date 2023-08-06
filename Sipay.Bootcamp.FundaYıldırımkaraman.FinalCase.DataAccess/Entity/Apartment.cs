using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sipay.Bootcamp.FundaYıldırımkaraman.FinalCase.DataAccess.Entity
{
    public class Apartment
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Block { get; set; }

        [Required]
        public bool IsOccupied { get; set; }

        [Required]
        public int Floor { get; set; }

        [Required]
        [MaxLength(50)]
        public string Type { get; set; }

        [Required]
        [MaxLength(50)]
        public string Number { get; set; }

        [Required]
        [MaxLength(100)]
        public string OwnerOrTenant { get; set; }

        public virtual ICollection<Bill> Bills { get; set; }
    }
}
