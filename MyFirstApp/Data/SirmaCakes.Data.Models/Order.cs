namespace SirmaCakes.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Text;

    using SirmaCakes.Data.Common.Models;

    public class Order : BaseDeletableModel<string>
    {
        // we have Id from basemodel // ind db
        public Order()
        {
            this.OrderDetails = new HashSet<OrderDetails>();
        }

        [Required]
        public DateTime OrderPlacedTime { get; set; }

        [StringLength(255)]
        [Required]
        public string FirstName { get; set; }

        [StringLength(255)]
        [Required]
        public string LastName { get; set; }

        [StringLength(255)]
        [Required]
        public string AddressLine1 { get; set; }

        [StringLength(255)]
        public string AddressLine2 { get; set; }

        [StringLength(255)]
        [Required]
        public string City { get; set; }

        [StringLength(255)]
        [Required]
        public string Country { get; set; }

        [StringLength(6)]
        [Required]
        public string ZipCode { get; set; }

        [StringLength(10)]
        [Required]
        public string PhoneNumber { get; set; }

        [StringLength(255)]
        [Required]
        public string Email { get; set; }

        public decimal OrderTotal { get; set; }

        [StringLength(255)]
        public string Personal_Note { get; set; }

        // Ot koi user e napravena porychka za tortata-> lognatiq Use
        [Required]
        public string BoughtByUserId { get; set; }

        public virtual ApplicationUser BoughtByUser { get; set; }

        public ICollection<OrderDetails> OrderDetails { get; set; }
    }
}
